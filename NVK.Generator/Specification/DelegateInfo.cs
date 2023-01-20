namespace NVK.Generator.Specification;

/// <summary>Represents a parsed delegate.</summary>
internal class DelegateInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the delegate.</summary>
    public string Name { get; }

    /// <summary>The return type of the delegate.</summary>
    public TypeInfo ReturnType { get; }

    /// <summary>The parameters of the delegate.</summary>
    public List<DelegateParameterInfo> Parameters { get; } = new();


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;type&gt; element to parse the delegate from.</param>
    public DelegateInfo(XElement element)
    {
        Name = element.Element("name")!.Value;

        // return type isn't stored in and elements, so it needs to be parsed from the string
        // an example layout for the delegate definition is: `typedef void* (VKAPI_PTR *[name]) ([parameters]);`
        var returnTypeString = element.Value.Split(' ')[1];
        ReturnType = new TypeInfo(new string(returnTypeString.Where(character => character != '*').ToArray()), returnTypeString.Count(character => character == '*'));

        // parameter names aren't stored in elements, so they need to be parsed from the string
        var parameterString = element.Value.Substring(element.Value.LastIndexOf('(') + 1).TrimEnd(')', ';');
        if (parameterString == "void") // a function pointer with "void" in the parameters section signifies no parameters
            return;

        // an example layout for the delegate parameters is: `(<type>void</type>* [name], const <type>char</type>* [name2])`
        var parameters = parameterString.Split(',');
        var parameterNames = parameters.Select(parameterName => parameterName.Split(' ').Last()).ToList();

        var parameterTypeNames = element.Elements("type").Select(typeElement => typeElement.Value).ToList();
        var parameterTypes = new List<TypeInfo>();
        for (int i = 0; i < parameters.Length; i++)
            parameterTypes.Add(new TypeInfo(parameterTypeNames[i], parameters[i].Count(character => character == '*')));

        for (int i = 0; i < parameters.Length; i++)
            Parameters.Add(new DelegateParameterInfo(parameterNames[i], parameterTypes[i]));
    }
}
