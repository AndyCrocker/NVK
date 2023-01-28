namespace NVK.Generator.Specification;

/// <summary>Represents a parsed enum.</summary>
internal class EnumInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the enum.</summary>
    public string Name { get; }

    /// <summary>The name of the enum that this enum is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The name of the enum that this enum requires to complete its definition.</summary>
    public string? Requires { get; }

    /// <summary>The type of the enum.</summary>
    public EnumType Type { get; private set; }

    /// <summary>The bitwidth of the enum.</summary>
    public int BitWidth { get; private set; }

    /// <summary>The fields of the enum.</summary>
    public List<EnumFieldInfo> Fields { get; private set; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;type&gt; element (with "struct" category) to parse the enum definition from.</param>
    /// <remarks>This is to be used one when parsing relevant struct definitions as bitmasks when they use the ": [num]" C syntax on each field.</remarks>
    public EnumInfo(XElement element)
    {
        Name = element.Attribute("name")!.Value;
        Type = EnumType.Bitmask;
        Fields = new();

        var bitOffset = 0;
        foreach (var memberElement in element.Elements("member"))
        {
            // some fields are more than one bit, in these cases we'll just make multiple flags suffixed with the bit offset of each one
            // TODO: perhaps at some point make extension methods that will automatically stitch these together to a single number

            // due to some fields having more than one bit width, we can't rely on EnumFieldInfo parsing them elegantly (due to the afformentioned note of creating
            // multiple bit fields on struct fields with more than one bit width) so we'll just parsing them here
            var name = memberElement.Element("name")!.Value;
            if (name.Contains("flag", StringComparison.InvariantCultureIgnoreCase))
            {
                var flagIndex = name.LastIndexOf("flag", StringComparison.InvariantCultureIgnoreCase);
                name = name.Remove(flagIndex, 4);
            }

            var bitWidth = int.Parse(memberElement.Value.Split(':')[1]);
            if (bitWidth == 1)
            {
                Fields.Add(new(this, name, bitOffset++));
                continue;
            }

            for (int i = 0; i < bitWidth; i++)
                Fields.Add(new(this, $"{name}{i}", bitOffset++));
        }
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;enums&gt; element to parse the enum definition from, or the &lt;type&gt; element to parse the enum declaration from.</param>
    /// <param name="isDefinition">Whether the element passed if a definition.</param>
    public EnumInfo(XElement element, bool isDefinition)
    {
        if (isDefinition)
        {
            Name = element.Attribute("name")!.Value;
            Type = Enum.Parse<EnumType>(element.Attribute("type")!.Value, true);
            BitWidth = int.Parse(element.Attribute("bitwidth")?.Value ?? "32");
            Fields = element.Elements("enum")
                .Select(enumFieldElement => new EnumFieldInfo(this, enumFieldElement)).ToList();
            // some enum fields are aliased to fix incorrect formatting or missing "_BIT" (which is removed in the display name), these result in identical display
            // names so we'll just ignore these enum fields
            Fields.RemoveAll(fieldInfo => EnumFieldInfo.CalculateDisplayName(Name, fieldInfo.Name) == EnumFieldInfo.CalculateDisplayName(Name, fieldInfo.Alias));
        }
        else
        {
            Alias = element.Attribute("alias")?.Value;
            Name = element.Attribute("name")?.Value ?? element.Element("name")!.Value;
            Type = element.HasAttribute("category", "bitmask") ? EnumType.Bitmask : EnumType.Enum;
            Requires = element.Attribute("requires")?.Value ?? element.Attribute("bitvalues")?.Value;
            Fields = new();

            if (Requires != null)
                TypeInfo.RegisterTypeConversion(Requires, Name);
        }
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Populates fields for a declaration that couldn't be populated during parsing.</summary>
    /// <param name="enumDeclarations">The enum declarations (&lt;type&gt;) to copy over data from.</param>
    /// <param name="enumDefinitions">The enum definitions (&lt;enums&gt;) to copy over data from.</param>
    public void PopulateFields(List<EnumInfo> enumDeclarations, List<EnumInfo> enumDefinitions)
    {
        // some enums and be aliases or enums that have a requires, keep going until we get down to the one with the field definitions
        var enumInfo = this;
        while (enumInfo?.Requires != null || enumInfo?.Alias != null)
            if (enumInfo.Requires != null)
                enumInfo = enumDefinitions.SingleOrDefault(enumDefinition => enumDefinition.Name == enumInfo.Requires);
            else if (enumInfo.Alias != null)
                enumInfo = enumDeclarations.SingleOrDefault(enumDeclaration => enumDeclaration.Name == enumInfo.Alias);

        if (enumInfo == this)
            enumInfo = enumDefinitions.SingleOrDefault(enumDefinition => enumDefinition.Name == Name);

        // if no enum was found, the enum is the declaration of an enum without any fields
        if (enumInfo == null)
        {
            BitWidth = 32;
            Fields ??= new(); // fields may already be populated if they were specified in video.xml and we are parsing vk.xml (which would mean enumInfo is null)
            return;
        }

        Type = enumInfo.Type;
        BitWidth = enumInfo.BitWidth;
        Fields = enumInfo.Fields;
    }

    /// <summary>Writes the enum to a C# writer.</summary>
    /// <param name="writer">The writer to write the enum to.</param>
    public void Write(CsWriter writer)
    {
        if (Alias != null)
            writer.WriteLine($"[Obsolete(\"Use {Alias}\")]");

        if (Type == EnumType.Bitmask)
            writer.WriteLine("[Flags]");

        writer.WriteLine($"public enum {Name}{(BitWidth == 64 ? " : long" : "")}");
        writer.WriteScope(() =>
        {
            foreach (var fieldInfo in Fields)
                fieldInfo.Write(writer);
        });
    }
}
