namespace NVK.Generator.Specification;

/// <summary>Represents a parsed enum field that's defined by an extension.</summary>
internal class ExtensionEnumFieldInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The value of the extnumber attribute of the &lt;require&gt; tag that defined the enum field.</summary>
    /// <remarks>There are some edge cases where the extension number isn't defined on the &lt;require&gt; tag or the &lt;enum&gt; tag, they have a bitpos attribute so the extension number isn't required.</remarks>
    public int? ExtensionNumber { get; }

    /// <summary>The name of the enum that this field will be added to.</summary>
    public string EnumName { get; }

    /// <summary>The element of the field definition.</summary>
    public XElement EnumFieldElement { get; }

    /// <summary>The name of the enum field.</summary>
    /// <remarks>This is used purely as a work around for how Vulkan 1.0 breaks the schema, for a more indepth description, see the comment above the reference.</remarks>
    public string Name { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="extensionNumber">The value of the extnumber attribute of the &lt;require&gt; tag that defined the enum field.</param>
    /// <param name="enumName">The name of the enum that this field will be added to.</param>
    /// <param name="enumFieldElement">The element of the field definition.</param>
    public ExtensionEnumFieldInfo(int? extensionNumber, string enumName, XElement enumFieldElement)
    {
        ExtensionNumber = extensionNumber;
        EnumName = TypeInfo.CalculateDisplayName(enumName);
        EnumFieldElement = enumFieldElement;

        Name = enumFieldElement.Attribute("name")!.Value;
    }
}
