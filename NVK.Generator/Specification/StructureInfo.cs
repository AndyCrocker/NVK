namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan structure.</summary>
internal class StructureInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the structure.</summary>
    public string Name { get; }

    /// <summary>The fields in the structure.</summary>
    public List<FieldInfo> Fields { get; }

    /// <summary>Whether the structure is a union.</summary>
    public bool IsUnion { get; }

    /// <summary>The extension that added this structure.</summary>
    public string? Extension { get; set; }

    /// <summary>The name of the structure ready for displaying.</summary>
    public string DisplayName => Utilities.PrettifyStructureName(Name);


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The structure element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public StructureInfo(XElement element, TypeConverter typeConverter)
    {
        Name = element.Attribute("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' attribute.", nameof(element));
        Fields = element.Elements("member")
            .Select(fieldElement => new FieldInfo(fieldElement, typeConverter))
            .ToList();
        IsUnion = element.HasAttributeWithValue("category", "union");
    }
}
