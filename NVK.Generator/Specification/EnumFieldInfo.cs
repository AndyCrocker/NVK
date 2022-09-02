using System;
using System.Xml.Linq;

namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan enum field.</summary>
public class EnumFieldInfo
{
    /*********
    ** Fields
    *********/
    /// <summary>The name of the enum that this value belongs to.</summary>
    private string EnumName;


    /*********
    ** Accessors
    *********/
    /// <summary>The name of the enum field.</summary>
    public string Name { get; }

    /// <summary>The value of the enum field.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Enum"/>.<br/>This is a <see langword="string"/> so hex numbers can be stored properly.</remarks>
    public string? Value { get; }

    /// <summary>The bit position of the value.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Bitmask"/>.</remarks>
    public int? BitPosition { get; }

    /// <summary>The name of the enum field that this enum field is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The extension that added this enum field.</summary>
    public string? Extension { get; set; }

    /// <summary>The name of the enum field ready for displaying.</summary>
    public string DisplayName => Utilities.PrettifyEnumFieldName(EnumName, Name);

    /// <summary>The alias of the enum field ready for displaying.</summary>
    public string? AliasDisplayName
    {
        get
        {
            if (Alias == null)
                return null;

            return Utilities.PrettifyEnumFieldName(EnumName, Alias);
        }
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="enumName">The name of the enum that this value belongs to.</param>
    /// <param name="element">The enum field element.</param>
    public EnumFieldInfo(string enumName, XElement element)
    {
        EnumName = enumName;
        Name = element.Attribute("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' attribute.", nameof(element));
        Value = element.Attribute("value")?.Value;
        if (int.TryParse(element.Attribute("bitpos")?.Value, out var parsedBitPosition))
            BitPosition = parsedBitPosition;
        Alias = element.Attribute("alias")?.Value;
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="enumName">The name of the enum that this value belongs to.</param>
    /// <param name="name">The name of the enum field.</param>
    /// <param name="value">The value of the enum field.</param>
    /// <param name="bitPosition">The bit position of the value.</param>
    /// <param name="alias">The name of the enum field that this enum field is an alias of.</param>
    public EnumFieldInfo(string enumName, string name, string? value, int? bitPosition, string? alias)
    {
        EnumName = enumName;
        Name = name;
        Value = value;
        BitPosition = bitPosition;
        Alias = alias;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        string value;
        if (AliasDisplayName != null)
            value = AliasDisplayName;
        else if (BitPosition != null)
            value = $"1 << {BitPosition}";
        else
            value = Value?.ToString() ?? throw new InvalidOperationException("Enum field doesn't contain a value, bit position, or alias.");

        return $"{DisplayName} = {value},";
    }
}
