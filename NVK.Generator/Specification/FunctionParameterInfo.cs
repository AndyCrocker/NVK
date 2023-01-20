namespace NVK.Generator.Specification;

/// <summary>Represents a parsed function parameter.</summary>
internal class FunctionParameterInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the parameter.</summary>
    public string Name { get; }

    /// <summary>The type of the parameter.</summary>
    public TypeInfo Type { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;param&gt; element to parse the function parameter from.</param>
    public FunctionParameterInfo(XElement element)
    {
        Name = element.Element("name")!.Value;
        Type = new TypeInfo(element.Element("type")!.Value, element.Value.Count(character => character == '*'));
    }
}
