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

    /// <summary>The type of the enum.</summary>
    public EnumType Type { get; }

    /// <summary>The bitwidth of the enum.</summary>
    public int BitWidth { get; }

    /// <summary>The fields of the enum.</summary>
    public List<EnumFieldInfo> Fields { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;enums&gt; element to parse the enum from.</param>
    public EnumInfo(XElement element)
    {
        Name = element.Attribute("name")!.Value;
        Type = Enum.Parse<EnumType>(element.Attribute("type")!.Value, true);
        BitWidth = int.Parse(element.Attribute("bitwidth")?.Value ?? "32");
        Fields = element.Elements("enum")
            .Select(enumFieldElement => new EnumFieldInfo(this, enumFieldElement)).ToList();
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;type&gt; element to parse the enum from.</param>
    /// <param name="enumDefinitions">The enum definitions to copy over data from.</param>
    public EnumInfo(XElement element, List<EnumInfo> enumDefinitions)
    {
        Fields = new();

        // bitmasks are declared as a typedef, while enums aren't, an couple examples or a bitmask are:
        // <type requires="[bitsName]" category="bitmask">typedef <type>[ignored]</type> <name>[name]</name>;</type>
        // <type                       category="bitmask" name="[name]" alias="[aliasName]"/>
        if (element.HasAttribute("category", "bitmask"))
        {
            Type = EnumType.Bitmask;

            Alias = element.Attribute("alias")?.Value;
            if (Alias != null)
            {
                Name = element.Attribute("name")!.Value;
                return;
            }

            Name = element.Element("name")!.Value;

            // if a bitmask doesn't have a 'requires' attribute and isn't an alias, it doesn't have any definition or extensions extending it
            if (!element.HasAttribute("requires"))
            {
                BitWidth = 32;
                return;
            }
        }
        else
        {
            Name = element.Attribute("name")!.Value;
            Alias = element.Attribute("alias")?.Value;
        }

        // if a definition hasn't been provided, the enum is the _Bits enum for a bitmask without any values, just use default values
        var enumDefinition = enumDefinitions.SingleOrDefault(enumDefinition => enumDefinition.Name == (Alias ?? Name));
        if (enumDefinition == null)
        {
            BitWidth = 32;
            return;
        }

        Type = enumDefinition.Type;
        BitWidth = enumDefinition.BitWidth;
        Fields = enumDefinition.Fields;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the enum to a C# writer.</summary>
    /// <param name="writer">The writer to write the enum to.</param>
    public void Write(CsWriter writer)
    {
        if (Type == EnumType.Bitmask)
            writer.WriteLine($"[Flags]");

        writer.WriteLine($"public enum {Name}{(BitWidth == 64 ? " : long" : "")}");
        writer.WriteScope(() =>
        {
            foreach (var fieldInfo in Fields)
                fieldInfo.Write(writer);
        });
    }
}
