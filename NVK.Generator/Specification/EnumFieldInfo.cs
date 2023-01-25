namespace NVK.Generator.Specification;

/// <summary>Represents a parsed enum field.</summary>
internal class EnumFieldInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The enum that this field belongs to.</summary>
    public EnumInfo ParentEnum { get; }

    /// <summary>The name of the enum field.</summary>
    public string Name { get; }

    /// <summary>The name of the enum field that this enum field is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The value of the enum field.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Enum"/>.</remarks>
    public string? Value { get; }

    /// <summary>The bit position of the value.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Bitmask"/>.</remarks>
    public int? BitPosition { get; }

    /// <summary>The display string for <see cref="Name"/>.</summary>
    private string DisplayName => CalculateDisplayName(ParentEnum.Name, Name)!;

    /// <summary>The display string for <see cref="Alias"/>.</summary>
    private string? DisplayAliasName => CalculateDisplayName(ParentEnum.Name, Alias);


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="parentEnum">The enum that this field belongs to.</param>
    /// <param name="element">The &lt;enum&gt; element to parse the enum field from.</param>
    /// <param name="extensionNumber">The number of the extension that defines this enum field, if it was defined by an extension.</param>
    public EnumFieldInfo(EnumInfo parentEnum, XElement element, int? extensionNumber = null)
    {
        ParentEnum = parentEnum;
        Name = element.Attribute("name")!.Value;
        Alias = element.Attribute("alias")?.Value;

        if (Alias != null)
            return;

        Value = element.Attribute("value")?.Value;
        if (Value != null)
        {
            // this is to fix the schema voilations in Vulkan 1.0, for a more thorough explanation, see FeatureInfo.ctor
            if (ParentEnum.Fields?.Any(fieldInfo => fieldInfo.Name == Value) ?? false)
            {
                Alias = Value;
                Value = null;
            }

            return;
        }

        if (element.HasAttribute("bitpos"))
        {
            BitPosition = int.Parse(element.Attribute("bitpos")!.Value);
            return;
        }
            
        // if the enum value isn't an alias, has a hardcoded value, or has a bit position, then it's value needs to be calculated from its extension, offset, and direction
        extensionNumber ??= int.Parse(element.Attribute("extnumber")!.Value);
        var offset = int.Parse(element.Attribute("offset")!.Value);
        var direction = element.HasAttribute("dir", "-") ? -1 : 1;

        Value = (direction * ((extensionNumber - 1) * 1000 + offset + 1000000000)).ToString();
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the enum to a C# writer.</summary>
    /// <param name="writer">The writer to write the enum to.</param>
    public void Write(CsWriter writer)
    {
        if (Alias != null)
            writer.WriteLine($"[Obsolete(\"Use {TypeInfo.CalculateDisplayName(ParentEnum.Name)}.{DisplayAliasName}\")]");

        string value;
        if (Alias != null)
            value = DisplayAliasName!;
        else if (BitPosition != null)
            value = $"1 << {BitPosition}";
        else
            value = Value!;

        writer.WriteLine($"{DisplayName} = {value},");
    }

    /// <summary>Calculates the display name of an enum field name.</summary>
    /// <param name="enumName">The name of the enum that contains the field to calculate the display name for.</param>
    /// <param name="fieldName">The name to calculate the display name of.</param>
    /// <returns>The display name for an enum field called <paramref name="name"/> in an enum called <paramref name="enumName"/>.</returns>
    public static string? CalculateDisplayName(string enumName, string? fieldName)
    {
        if (fieldName == null)
            return null;

        // remove the enum name from the field name
        var splitEnumName = enumName.SplitOnUpper().ToList();
        var splitFieldName = fieldName.Split('_').ToList();

        for (int i = 0; i < MathF.Min(splitEnumName.Count, splitFieldName.Count); i++)
            if (splitEnumName[i].ToLower() == splitFieldName[i].ToLower())
            {
                splitEnumName.RemoveAt(i);
                splitFieldName.RemoveAt(i--);
            }

        // bitfield enums have an unwanted 'BIT' in their field names
        splitFieldName.Remove("BIT");

        // reconstruct the name and ensure it doesn't start with a digit (as that's not a valid C# identifier)
        var newEnumFieldName = string.Join("", splitFieldName.Select(fieldNameSection => fieldNameSection.ToLower().FirstToUpper()));//.Select(splitName => CapitaliseEnumFieldNameSection(enumName, splitName)));
        if (char.IsDigit(newEnumFieldName[0]))
            newEnumFieldName = $"_{newEnumFieldName}";

        return newEnumFieldName.ResolveAbbreviations();
    }
}
