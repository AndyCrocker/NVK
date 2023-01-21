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
    /// <param name="element">The &lt;require&gt; element to parse the require info from.</param>
    /// <param name="specification">The specification to use when creating the require info.</param>
    /// <param name="extensionNumber">The value of the number attribute of the &lt;extension&gt; tag that contains this &lt;require&gt;.</param>
    public RequireInfo(XElement element, VulkanSpecification specification, int? extensionNumber = null)
	{
        foreach (var typeElement in element.Elements("type"))
            TypeNames.Add(typeElement.Attribute("name")!.Value);

        foreach (var functionElement in element.Elements("command"))
            FunctionNames.Add(functionElement.Attribute("name")!.Value);

        foreach (var enumElement in element.Elements("enum"))
        {
            // the registry for Vulkan 1.0 breaks the schema and adds aliased enum fields without specifying an "extends" attribute, in this case it'll
            // only specify a "name" and "value" attribute, so we need to check if the aliased value (the value of the "value" attribute) is a preexisting
            // enum field before determining it's a constant declaration; the preexisting enum field may be a field that this extension added, so we need to check
            // through those as well as the enums in the specification
            var name = enumElement.Attribute("name")!.Value;
            var value = enumElement.Attribute("value")?.Value;
            var hasAlias = enumElement.HasAttribute("alias");

            if (value != null)
            {
                var enumName = 
                    specification.Enums.SingleOrDefault(enumInfo => enumInfo.Fields.Any(fieldInfo => fieldInfo.Name == value))?.Name ??
                    EnumFields.SingleOrDefault(enumFieldInfo => enumFieldInfo.Name == value)?.EnumName;

                if (enumName != null)
                {
                    EnumFields.Add(new(null, enumName, enumElement));
                    continue;
                }
            }

            // if the enum doesn't extend a type, it's refering to a constant
            var extendedEnumName = enumElement.Attribute("extends")?.Value;
            if (extendedEnumName == null)
            {
                // if a value or alias is specified, it's a constant that hasn't been previously declared
                if (value != null || hasAlias)
                    Constants.Add(new(enumElement));
                else
                    ConstantNames.Add(enumElement.Attribute("name")!.Value);

                continue;
            }

            EnumFields.Add(new(extensionNumber, extendedEnumName, enumElement));
        }
    }
}
