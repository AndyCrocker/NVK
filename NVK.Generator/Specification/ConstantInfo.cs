namespace NVK.Generator.Specification;

/// <summary>Represents a parsed constant.</summary>
internal class ConstantInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the constant.</summary>
    public string Name { get; }

    /// <summary>The name of the constant that this constant is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The value of the constant.</summary>
    public string? Value { get; set; }

    /// <summary>The type of the constant.</summary>
    public ConstantType Type { get; }

    /// <summary>The display string for <see cref="Type"/>.</summary>
    private string DisplayType => Type.GetAttribute<UnderlyingTypeAttribute>()!.UnderlyingType;

    /// <summary>The display string for <see cref="Name"/>.</summary>
    private string DisplayName => CalculateDisplayName(Name)!;

    /// <summary>The display string for <see cref="Alias"/>.</summary>
    private string? DisplayAliasName => CalculateDisplayName(Alias);

    /// <summary>The display string for <see cref="Value"/>.</summary>
    private string? DisplayValue => Value?.Trim('(', ')').Replace("LL", "L").Replace(".0F", "F", StringComparison.InvariantCultureIgnoreCase);


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;enum&gt; element to parse the constant from.</param>
    public ConstantInfo(XElement element)
    {
        Name = element.Attribute("name")!.Value;
        Alias = element.Attribute("alias")?.Value;
        Value = element.Attribute("value")?.Value;

        // not all constants have a specified "type" attribute, so type needs to be calculated from the value
        if (Value != null)
            Type = CalculateType(Value);
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the constant to a C# writer.</summary>
    /// <param name="writer">The writer to write the constant to.</param>
    public void Write(CsWriter writer)
    {
        if (Alias != null)
            writer.WriteLine($"[Obsolete(\"Use {DisplayAliasName}\")]");

        writer.WriteLine($"public const {DisplayType} {DisplayName} = {DisplayValue ?? DisplayAliasName};");
    }

    /// <summary>Calculates the display name of a constant name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <returns>The display name for a constant called <paramref name="name"/>.</returns>
    public static string? CalculateDisplayName(string? name)
    {
        if (name == null)
            return null;

        var splitConstantName = name.Split('_').Skip(1); // remove "VK_" prefix
        return string.Concat(splitConstantName.Select(splitName => splitName.ToLower().FirstToUpper()));
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Calculates the type of a constant value.</summary>
    /// <param name="value">The value to calculate the type of.</param>
    /// <returns>The type of the value.</returns>
    private static ConstantType CalculateType(string value)
    {
        if (value.ToLower().EndsWith("f"))
            return ConstantType.Single;
        else if (value.EndsWith("ULL)"))
            return ConstantType.ULong;
        else if (value.Contains('"'))
            return ConstantType.String;
        else
            return ConstantType.UInt;
    }
}
