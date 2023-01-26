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

    /// <summary>The modifier of the parameter.</summary>
    public ParameterModifier Modifier { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;param&gt; element to parse the function parameter from.</param>
    public FunctionParameterInfo(XElement element)
    {
        Type = new TypeInfo(element.Element("type")!.Value, element.Value.Count(character => character == '*'));

        var name = element.Element("name")!.Value;
        Name = CalculateDisplayName(name, Type.PointerIndirection);
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the parameter.</param>
    /// <param name="type">The type of the parameter.</param>
    /// <param name="modifier">The modifier of the parameter.</param>
    public FunctionParameterInfo(string name, TypeInfo type, ParameterModifier modifier)
    {
        Name = name;
        Type = type;
        Modifier = modifier;
    }

    /// <summary>Calculates the display name of a parameter name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <param name="pointerIndirection">The pointer indirection of the parameter.</param>
    /// <returns>The display name for a parameter called <paramref name="name"/>.</returns>
    public static string CalculateDisplayName(string name, int pointerIndirection)
    {
        for (int i = 0; i < pointerIndirection; i++)
            if (name.StartsWith('p'))
                name = name[1..];

        return name.ResolveAbbreviations().FirstToLower().EnsureIsntReserved();
    }
}
