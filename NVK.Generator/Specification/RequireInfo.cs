namespace NVK.Generator.Specification;

/// <summary>Represents a parsed &lt;require&gt; tag.</summary>
internal class RequireInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The names of the types that are added.</summary>
    public List<string> TypeNames { get; } = new();

    /// <summary>The names of the functions that are added.</summary>
    public List<string> FunctionNames { get; } = new();

    /// <summary>The names of previously declared constants that are added.</summary>
    public List<string> ConstantNames { get; } = new();

    /// <summary>The constants that are added that weren't previously declared in the specification.</summary>
    public List<ConstantInfo> Constants { get; } = new();

    /// <summary>The enem field elements keyed on the enum name that are added.</summary>
    public List<ExtensionEnumFieldInfo> EnumFields { get; } = new();


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;require&gt; element to parse the structure field from.</param>
    /// <param name="extensionNumber">The value of the number attribute of the &lt;extension&gt; tag that contains this &lt;require&gt;.</param>
    public RequireInfo(XElement element, int? extensionNumber = null)
	{
        foreach (var typeElement in element.Elements("type"))
            TypeNames.Add(typeElement.Attribute("name")!.Value);

        foreach (var functionElement in element.Elements("command"))
            FunctionNames.Add(functionElement.Attribute("name")!.Value);

        foreach (var enumElement in element.Elements("enum"))
        {
            // if the enum doesn't extend a type, it's refering to a constant
            var extendedEnumName = enumElement.Attribute("extends")?.Value;
            if (extendedEnumName == null)
            {
                // if a value or alias is specified, it's a constant that hasn't been previously declared
                if (enumElement.HasAttribute("value") || enumElement.HasAttribute("alias"))
                    Constants.Add(new(enumElement));
                else
                    ConstantNames.Add(enumElement.Attribute("name")!.Value);

                continue;
            }

            EnumFields.Add(new(extensionNumber, extendedEnumName, enumElement));
        }
    }
}
