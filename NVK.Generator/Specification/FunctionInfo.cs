namespace NVK.Generator.Specification;

/// <summary>Represents a parsed function.</summary>
internal class FunctionInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the function.</summary>
    public string Name { get; }

    /// <summary>The name of the function that this function is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The command queues the function can be placed on.</summary>
    public string[] Queues { get; } = Array.Empty<string>();

    /// <summary>The possible successful return codes from the function.</summary>
    public string[] SuccessCodes { get; } = Array.Empty<string>();

    /// <summary>The possible error return codes from the function.</summary>
    public string[] ErrorCodes { get; } = Array.Empty<string>();

    /// <summary>The return type of the function.</summary>
    public TypeInfo ReturnType { get; }

    /// <summary>The parameters of the function.</summary>
    public List<FunctionParameterInfo> Parameters { get; } = new();


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;command&gt; element to parse the function from.</param>
    public FunctionInfo(XElement element)
    {
        // if the function is an alias, the name is stored as an attribute instead of a child element
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
        {
            Name = element.Attribute("name")!.Value;
            ReturnType = new("void");
            return;
        }

        Queues = element.Attribute("queues")?.Value.Split(',') ?? Array.Empty<string>();
        SuccessCodes = element.Attribute("successcodes")?.Value.Split(',') ?? Array.Empty<string>();
        ErrorCodes = element.Attribute("errorcodes")?.Value.Split(',') ?? Array.Empty<string>();

        // an example layout of a function is:
        // `<proto><type>[returnTypeName]</type> <name>[name]</name></proto>
        // <param>const <type>[parameterTypeName]</type>* <name>[parameterName]</name></param>
        // [..]`
        var protoElement = element.Element("proto")!;

        Name = protoElement.Element("name")!.Value;
        ReturnType = new(protoElement.Element("type")!.Value);
        Parameters = element.Elements("param")
            .Select(parameterElement => new FunctionParameterInfo(parameterElement)).ToList();
    }
}
