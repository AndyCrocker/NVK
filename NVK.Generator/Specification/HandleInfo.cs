namespace NVK.Generator.Specification;

/// <summary>Represents a parsed handle.</summary>
internal class HandleInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the handle.</summary>
    public string Name { get; }

    /// <summary>The name of the handle that this handle is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>Whether the handle is a dispatchable object handle.</summary>
    public bool Dispatchable { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance</summary>
    /// <param name="element">The &lt;type&gt; element to parse the handle from.</param>
    public HandleInfo(XElement element)
    {
        // if the handle is an alias, the name is stored as an attribute instead of a child element
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
        {
            Name = element.Attribute("name")!.Value;
            return;
        }

        Name = element.Element("name")!.Value;
        Dispatchable = element.Element("type")!.Value == "VK_DEFINE_HANDLE";
    }
}
