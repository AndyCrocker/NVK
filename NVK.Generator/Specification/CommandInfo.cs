namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan command.</summary>
internal class CommandInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the command.</summary>
    public string Name { get; }

    /// <summary>The return type of the command.</summary>
    public TypeInfo? ReturnType { get; }

    /// <summary>The parameters of the command.</summary>
    public List<CommandParameterInfo> Parameters { get; } = new();

    /// <summary>The name of the command that this command is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The extension that added the command.</summary>
    public string? Extension { get; set; }

    /// <summary>The name of the command ready for displaying.</summary>
    public string DisplayName => Utilities.PrettifyCommandName(Name);

    /// <summary>The alias of the command ready for displaying.</summary>
    public string? AliasDisplayName
    {
        get
        {
            if (Alias == null)
                return null;

            return Utilities.PrettifyCommandName(Alias);
        }
    }

    /// <summary>The name of the command ready for displaying as a pointer.</summary>
    public string PointerDisplayName => DisplayName + "Pointer";

    /// <summary>The name of the command ready for displaying as a delegate.</summary>
    public string DelegateDisplayName => Utilities.PrettifyDelegateName(Name);


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The 'command' element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public CommandInfo(XElement element, TypeConverter typeConverter)
    {
        // check if the command is an alias
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
            Name = element.Attribute("name")?.Value ?? throw new ArgumentException("Is an alias but doesn't contain a 'name' attribute.", nameof(element));

        // it's not a alias, create it like normal
        else
        {
            var protoElement = element.Element("proto") ?? throw new ArgumentException("Doesn't contain a 'proto' element.", nameof(element));

            Name = protoElement.Element("name")?.Value ?? throw new ArgumentException("Doesn't contain a 'name' element.", nameof(element));
            ReturnType = new(typeConverter.GetConvertedType(protoElement.Element("type")?.Value ?? throw new ArgumentException("Child 'proto' element doesn't contain a 'type' element.")));
            Parameters = element.Elements("param")
                .Select(parameterElement => new CommandParameterInfo(parameterElement, typeConverter))
                .ToList();
        }
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the command.</param>
    /// <param name="returnType">The return type of the command.</param>
    /// <param name="parameters">The parameters of the command.</param>
    /// <param name="alias">The name of the command that this command is an alias of.</param>
    public CommandInfo(string name, TypeInfo returnType, List<CommandParameterInfo> parameters, string? alias)
    {
        Name = name;
        ReturnType = returnType;
        Parameters = parameters;
        Alias = alias;
    }
}
