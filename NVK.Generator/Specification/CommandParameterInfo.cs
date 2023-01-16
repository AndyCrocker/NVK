namespace NVK.Generator.Specification;

/// <summary>Represents a <see cref="CommandInfo"/> parameter.</summary>
internal class CommandParameterInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the parameter.</summary>
    public string Name { get; }

    /// <summary>The type of the parameter.</summary>
    public TypeInfo Type { get; }

    /// <summary>The modifier of the parameter.</summary>
    public ParameterModifier Modifier { get; }

    /// <summary>The name of the parameter readu for displaying.</summary>
    public string DisplayName
    {
        get
        {
            var pointerIndirection = Type.PointerIndirection;
            if (Type.ArrayDimensions != 0)
                pointerIndirection++;
            if (Type.Name == "string")
                pointerIndirection++;
            if (Modifier.GetAttribute<UnderlyingTypeAttribute>() != null)
                pointerIndirection++;

            return Utilities.PrettifyParameterName(Name, pointerIndirection);
        }
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance from a 'command parameter' element.</summary>
    /// <param name="element">The 'command parameter' element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public CommandParameterInfo(XElement element, TypeConverter typeConverter)
    {
        Name = element.Element("name")?.Value ?? throw new ArgumentException($"Element: {element } doesn't contain a 'name' element.", nameof(element));

        var typeName = element.Element("type")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'type' element.", nameof(element));
        var pointerIndirection = element.Value.Count(character => character == '*');
        Type = new TypeInfo(typeConverter.GetConvertedType(typeName), pointerIndirection);
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the parameter.</param>
    /// <param name="type">The type of the parameter.</param>
    /// <param name="modifier">The modifier of the parameter.</param>
    public CommandParameterInfo(string name, TypeInfo type, ParameterModifier modifier)
    {
        Name = name;
        Type = type;
        Modifier = modifier;
    }

    /// <inheritdoc/>
    public override string ToString() => $"{Modifier.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType ?? Modifier.GetAttribute<UnderlyingAttributeAttribute>()?.UnderlyingAttribute}{Type} {DisplayName}";
}
