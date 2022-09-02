using System;
using System.Xml.Linq;
using NVK.Generator.Extensions;

namespace NVK.Generator.Specification;

/// <summary>Represents an enum field added by an extension.</summary>
public class ExtensionEnumFieldInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the enum that this enum field is being added to.</summary>
    public string ExtendedType { get; }

    /// <summary>The name of the enum field.</summary>
    public string Name { get; }

    /// <summary>The value of the enum field.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Enum"/>.<br/>This is a <see langword="string"/> so hex numbers can be stored properly.</remarks>
    public string? Value { get; }

    /// <summary>The bit position of the enum field.</summary>
    /// <remarks>This is only used if the enum has a type of <see cref="EnumType.Bitmask"/>.</remarks>
    public int? BitPosition { get; }

    /// <summary>The name of the enum field that this enum field is an alias of.</summary>
    public string? Alias { get; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="extensionNumber">The number of the extension to use when determining the value of the enum.</param>
    /// <param name="element">The extension enum field element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public ExtensionEnumFieldInfo(int? extensionNumber, XElement element, TypeConverter typeConverter)
    {
        ExtendedType = element.Attribute("extends")?.Value ?? throw new ArgumentException("Doesn't contain an 'extends' attribute.", nameof(element));
        ExtendedType = typeConverter.GetConvertedType(ExtendedType);
        Name = element.Attribute("name")?.Value ?? throw new ArgumentException("Child 'enum' element doesn't contain a 'name' attribute.");

        Alias = element.Attribute("alias")?.Value;
        var offsetString = element.Attribute("offset")?.Value;
        var bitPositionString = element.Attribute("bitpos")?.Value;

        // don't try to get the value or bit position if it's an alias
        if (Alias == null)
        {
            // check if the value is being set by an offset
            if (offsetString != null)
            {
                var offset = int.Parse(offsetString);
                var direction = 1;
                if (element.HasAttributeWithValue("dir", "-"))
                    direction = -1;

                if (extensionNumber == null)
                    throw new ArgumentException("Extension enum field contains an 'offset' attribute but the extension number isn't valid.", nameof(extensionNumber));
                Value = (direction * ((extensionNumber - 1) * 1000 + offset + 1000000000)).ToString();
            }

            // otherwise, check if the value is being set by a bit position
            else if (bitPositionString != null)
                BitPosition = int.Parse(bitPositionString);

            // otherwise, just get the value directly
            else
                Value = element.Attribute("value")?.Value ?? throw new ArgumentException("Doesn't contain an 'offset', 'bitpos', or 'value' attribute.", nameof(element));
        }
    }
}
