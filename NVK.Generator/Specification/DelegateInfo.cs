namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan function pointer.</summary>
/// <remarks>Note: this isn't used for storing info to create delegates used for interop, this is purly used for Vulkan <c>PFN_</c> types.<br/>Interop delegates are generated from <see cref="CommandInfo"/>s at <see cref="CodeGenerator.WriteDelegate(CsWriter, CommandInfo)"/>.</remarks>
internal class DelegateInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the delegate.</summary>
    public string Name { get; }

    /// <summary>The remarks documentation of the delegate.</summary>
    public string? RemarksDocumentation { get; set; }

    /// <summary>The return type of the delegate.</summary>
    public TypeInfo ReturnType { get; }

    /// <summary>The parameters of the delegate.</summary>
    public List<DelegateParameterInfo> Parameters { get; } = new();

    /// <summary>The name of the delegate ready for displaying.</summary>
    public string DisplayName => Utilities.PrettifyDelegateName(Name);


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The 'delegate' element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public DelegateInfo(XElement element, TypeConverter typeConverter)
    {
        Name = element.Element("name")?.Value ?? throw new ArgumentException("Doesn't contain a 'name' element.", nameof(element));
        typeConverter.RegisterTypeConversion(Name, DisplayName);

        // get the return type
        var returnTypeString = element.Value.Split(' ')[1]; // an example layout for the delegate definition is: `typedef void* (VKAPI_PTR *[name]) ([parameters]);`
        ReturnType = new TypeInfo(new string(returnTypeString.Where(character => character != '*').ToArray()), returnTypeString.Count(character => character == '*'));

        // get the parameter names, they aren't stored in elements so they need to be retrieved from parsing the string
        var parameterString = element.Value.Substring(element.Value.LastIndexOf('(') + 1).TrimEnd(')', ';'); // substring from the opening bracket of the parameters
        if (parameterString == "void") // a function pointer with "void" in the parameters section signifies no parameters
            return;

        var parameters = parameterString.Split(',');
        var parameterNames = parameters.Select(parameterName => parameterName.Split(' ').Last()).ToList();

        // get the parameter types
        var typeNames = element.Elements("type").Select(typeElement => typeElement.Value).ToList();
        var types = new List<TypeInfo>();
        for (int i = 0; i < parameters.Length; i++)
            types.Add(new TypeInfo(typeConverter.GetConvertedType(typeNames[i]), parameters[i].Count(character => character == '*')));

        for (int i = 0; i < parameters.Length; i++)
            Parameters.Add(new DelegateParameterInfo(parameterNames[i], types[i]));
    }
}
