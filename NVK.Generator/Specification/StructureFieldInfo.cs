namespace NVK.Generator.Specification;

/// <summary>Represents a parsed structure field.</summary>
internal class StructureFieldInfo
{
    /*********
    ** Properties
    *********/
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
    public StructureFieldInfo(XElement element)
    {
        Name = element.Element("name")!.Value;
        Type = new(element.Element("type")!.Value, element.Value.Count(character => character == '*'));
        Values = element.Attribute("values")?.Value.Split(',') ?? Array.Empty<string>();

        var match = Regex.Match(element.Value, @"\[.*\]");
        if (match.Success)
            ArrayLength = match.Value[1..^1];
    }
}
