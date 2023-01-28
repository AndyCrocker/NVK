namespace NVK.Generator.Specification;

/// <summary>Represents a parsed structure field.</summary>
internal class StructureFieldInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The structure that this field belongs to.</summary>
    public StructureInfo ParentStructure { get; }

    /// <summary>The name of the field.</summary>
    public string Name { get; }

    /// <summary>The type of the field.</summary>
    public TypeInfo Type { get; }

    /// <summary>List of enumeration values that are valid for the structure type.</summary>
    /// <remarks>This is only valid on <c>sType</c>.</remarks>
    public string[] Values { get; }

    /// <summary>The value specified in the fixed-length array.</summary>
    /// <remarks>This can be a numerical literal, a constant (e.g. "VK_UUID_SIZE"), or the inside of an array of arrays (e.g. "3][4").</remarks>
    public string? ArrayLength { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;member&gt; element to parse the structure field from.</param>
    public StructureFieldInfo(StructureInfo parentStructure, XElement element)
    {
        ParentStructure = parentStructure;
        Type = new(element.Element("type")!.Value, element.Value.Count(character => character == '*'));
        Values = element.Attribute("values")?.Value.Split(',') ?? Array.Empty<string>();

        var name = element.Element("name")!.Value;
        Name = CalculateDisplayName(name, Type.PointerIndirection);

        // remove the comment element as it can sometimes contains "[]" which falsely implies an array
        element.Element("comment")?.Remove();

        var match = Regex.Match(element.Value, @"\[.*\]");
        if (match.Success)
            ArrayLength = match.Value[1..^1];
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the field to a C# writer.</summary>
    /// <param name="writer">The writer to write the field to.</param>
    /// <param name="specification">The specification to use when writing the field.</param>
    public void Write(CsWriter writer, FeatureInfo specification)
    {
        if (ParentStructure.IsUnion)
            writer.WriteLine("[FieldOffset(0)]");

        if (ArrayLength == null)
        {
            writer.WriteLine($"public {Type} {Name};");
            return;
        }

        var arrayLengthNumerical = 0;
        var arrayLengthDisplay = (string?)null;
        if (!int.TryParse(ArrayLength, out arrayLengthNumerical))
        {
            // some fields are an array of arrays, C# doesn't support fixed version of these, so we'll flatten them into an appropriately sized array
            if (ArrayLength.Contains("]["))
            {
                arrayLengthNumerical = ArrayLength.Split("][")
                    .Select(CalculateNumericalArrayLength)
                    .Aggregate(1, (x, y) => x * y);
                arrayLengthDisplay = arrayLengthNumerical.ToString();
            }

            // if it's not a numerical literal or an array of arrays, then the value is a vulkan constant
            else
            {
                arrayLengthNumerical = CalculateNumericalArrayLength(ArrayLength); // need to keep track of the numerical value incase it's an invalid type (for a fixed array) so we need to convert the array to fields
                arrayLengthDisplay = $"(int)VK.{ConstantInfo.CalculateDisplayName(ArrayLength)}";
            }
        }
        arrayLengthDisplay ??= arrayLengthNumerical.ToString();

        // C# only supports certain types as fixed length arrays, if an unsupported type is needed as a fixed length array then we'll just add a field per element instead of an array
        var fixedArrayTypes = new[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "bool", "char", "float", "double" };
        if (fixedArrayTypes.Contains(Type.Name))
        {
            writer.WriteLine($"public fixed {Type} {Name}[{arrayLengthDisplay}];");
            return;
        }

        for (int i = 0; i < arrayLengthNumerical; i++)
            writer.WriteLine($"public {Type} {Name}_{i};");

        // Calculates the numerical value or a string defined in ArrayLength
        // This can either be a number or a constant name
        int CalculateNumericalArrayLength(string value)
        {
            if (int.TryParse(value, out var number))
                return number;

            var constantInfo = specification.Constants.Single(constantInfo => constantInfo.Name == value);
            return int.Parse(constantInfo.Value!);
        }
    }

    /// <summary>Calculates the display name of a parameter name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <param name="pointerIndirection">The pointer indirection of the parameter.</param>
    /// <returns>The display name for a parameter called <paramref name="name"/>.</returns>
    public static string CalculateDisplayName(string name, int pointerIndirection)
    {
        if (name == "sType")
            return "SType";

        for (int i = 0; i < pointerIndirection; i++)
            if (name.StartsWith('p'))
                name = name[1..];

        name = name.Replace("pfn", "");

        // a couple edge cases where two fields are only differentiated by the level of pointer indirection (and therefore the prefixed 'p's that we've just removed)
        if ((name == "Geometries" || name == "UsageCounts") && pointerIndirection == 2)
            name += "2";

        return name.ResolveAbbreviations().FirstToUpper();
    }
}
