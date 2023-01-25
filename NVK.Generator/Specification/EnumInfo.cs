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
            Fields = new();
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
