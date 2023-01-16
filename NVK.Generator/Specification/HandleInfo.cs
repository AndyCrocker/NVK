namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan handle.</summary>
public class HandleInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the handle.</summary>
    public string Name { get; }

    /// <summary>Whether the handle is a dispatchable object handle.</summary>
    public bool Dispatchable { get; }

    /// <summary>The name of the handle that this handle is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The extension that added this handle.</summary>
    public string? Extension { get; set; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance</summary>
    /// <param name="element">The handle element.</param>
    public HandleInfo(XElement element)
    {
        // check if the command is an alias
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
        {
            Name = element.Attribute("name")?.Value ?? throw new ArgumentException($"Element: {element} is an alias but doesn't contain a 'name' attribute.", nameof(element));
            return;
        }

        // it's not a alias, create it like normal
        Name = element.Element("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' element.", nameof(element));
        Dispatchable = element.Element("type")?.Value == "VK_DEFINE_HANDLE";
    }
}
