namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan typedef.</summary>
internal class TypedefInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the typedef.</summary>
    public string Name { get; }

    /// <summary>The type that the typedef requires.</summary>
    public string? Requires { get; }

    /// <summary>The type of the typedef.</summary>
    public string Type { get; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The typedef element.</param>
    public TypedefInfo(XElement element)
    {
        Name = element.Element("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' element.", nameof(element));
        Requires = element.Attribute("requires")?.Value ?? element.Attribute("bitvalues")?.Value;
        Type = element.Element("type")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'type' element.", nameof(element));
    }
}
