namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan enum.</summary>
internal class EnumInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the enum.</summary>
    public string Name { get; }

    /// <summary>The type of the enum.</summary>
    public EnumType Type { get; }

    /// <summary>The bitwidth of the enum.</summary>
    public int BitWidth { get; }

    /// <summary>The values of the enum.</summary>
    public List<EnumFieldInfo> Values { get; } = new();

    /// <summary>The extension that added this enum.</summary>
    public string? Extension { get; set; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The enum element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public EnumInfo(XElement element, TypeConverter typeConverter)
    {
        Name = typeConverter.GetConvertedType(element.Attribute("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' attribute.", nameof(element)));
        Type = (EnumType)Enum.Parse(typeof(EnumType), element.Attribute("type")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'type' attribute.", nameof(element)), true);
        BitWidth = int.Parse(element.Attribute("bitwidth")?.Value ?? "32");

        foreach (var enumValueElement in element.Elements("enum"))
            Values.Add(new EnumFieldInfo(Name, enumValueElement));
    }
}
