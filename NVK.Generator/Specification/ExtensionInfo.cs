namespace NVK.Generator.Specification;

/// <summary>Represents a parsed extension.</summary>
internal class ExtensionInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The platform the extension is for.</summary>
    public string? Platform { get; }

    /// <summary>The api name this extension is for, if the extension should be ignored this will be "disabled".</summary>
    public string Supported { get; }

    /// <summary>The &lt;require&gt; tags that are defined in the extension.</summary>
    public List<RequireInfo> RequireInfos { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;extension&gt; element to parse the extension from.</param>
    /// <param name="specification">The specification to use when creating the extension.</param>
    public ExtensionInfo(XElement element, VulkanSpecification specification)
	{
        Platform = element.Attribute("platform")?.Value;
        Supported = element.Attribute("supported")!.Value;

        var number = int.Parse(element.Attribute("number")!.Value);
        RequireInfos = element.Elements("require")
            .Select(requireElement => new RequireInfo(requireElement, specification, number)).ToList();
    }
}
