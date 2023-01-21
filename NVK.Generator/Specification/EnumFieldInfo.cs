namespace NVK.Generator.Specification;

/// <summary>Represents a parsed enum field.</summary>
internal class EnumFieldInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The enum that this field belongs to.</summary>
    public EnumInfo ParentEnum { get; }

    /// <summary>The name of the enum field.</summary>
    public string Name { get; }

    /// <summary>The name of the enum field that this enum field is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The value of the enum field.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Enum"/>.</remarks>
    public string? Value { get; }

    /// <summary>The bit position of the value.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Bitmask"/>.</remarks>
    public int? BitPosition { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="parentEnum">The enum that this field belongs to.</param>
    /// <param name="element">The &lt;enum&gt; element to parse the enum field from.</param>
    /// <param name="extensionNumber">The number of the extension that defines this enum field, if it was defined by an extension.</param>
    public EnumFieldInfo(EnumInfo parentEnum, XElement element, int? extensionNumber = null)
    {
        ParentEnum = parentEnum;
        Name = element.Attribute("name")!.Value;
        Alias = element.Attribute("alias")?.Value;

        if (Alias != null)
            return;

        Value = element.Attribute("value")?.Value;
        if (Value != null)
            return;

        if (element.HasAttribute("bitpos"))
        {
            BitPosition = int.Parse(element.Attribute("bitpos")!.Value);
            return;
        }
            
        // if the enum value isn't an alias, has a hardcoded value, or has a bit position, then it's value needs to be calculated from its extension, offset, and direction
        extensionNumber ??= int.Parse(element.Attribute("extnumber")!.Value);
        var offset = int.Parse(element.Attribute("offset")!.Value);
        var direction = element.HasAttribute("dir", "-") ? -1 : 1;

        Value = (direction * ((extensionNumber - 1) * 1000 + offset + 1000000000)).ToString();
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the enum to a C# writer.</summary>
    /// <param name="writer">The writer to write the enum to.</param>
    public void Write(CsWriter writer)
    {
        string value;
        if (Alias != null)
            value = Alias;
        else if (BitPosition != null)
            value = $"1 << {BitPosition}";
        else
            value = Value!;

        writer.WriteLine($"{Name} = {value},");
    }
}
