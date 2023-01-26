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

        // some structs end in a number (e.g. VkPipelineStageFlags2), these need to be manually removed from the beginning of the field name
        var lastDigit = '\0';
        if (char.IsDigit(enumName.Last()))
            lastDigit = enumName.Last();

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

        if (splitFieldName.First() == lastDigit.ToString())
            splitFieldName.RemoveAt(0);

        // reconstruct the name and ensure it doesn't start with a digit (as that's not a valid C# identifier)
        var newEnumFieldName = string.Join("", splitFieldName.Select(CapitaliseEnumFieldNameSection));
        if (char.IsDigit(newEnumFieldName[0]))
            newEnumFieldName = $"_{newEnumFieldName}";

        return newEnumFieldName.ResolveAbbreviations();
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Capitalises a section of an enum field name.</summary>
    /// <param name="enumFieldNameSection">The enum field name section to capitalise.</param>
    /// <returns>The correctly capitalised <paramref name="enumFieldNameSection"/>.</returns>
    private static string CapitaliseEnumFieldNameSection(string enumFieldNameSection)
    {
        enumFieldNameSection = enumFieldNameSection.ToLower();

        // check if section is a compression format
        var compressionFormats = new[] { "bc", "etc", "eac", "astc", "pvrtc" };
        if (compressionFormats.Any(enumFieldNameSection.StartsWith))
            return enumFieldNameSection.ToUpper();

        if (enumFieldNameSection.EndsWith("bpc"))
            return enumFieldNameSection.ToUpper();
        if (enumFieldNameSection.EndsWith("bpp"))
            return enumFieldNameSection.ToUpper();

        // check if the section is the format channel definitions (e.g. R8G8B8A8)
        var channelCharacters = new[] { 'r', 'g', 'b', 'a', 'e' };
        if (enumFieldNameSection.Length > 1 && channelCharacters.Contains(enumFieldNameSection[0]) && char.IsDigit(enumFieldNameSection[1]))
            return enumFieldNameSection.ToUpper();

        // check if the section is a numbered pack section (e.g. 4PACK16)
        if (enumFieldNameSection.Length > 1 && char.IsDigit(enumFieldNameSection[0]) && enumFieldNameSection[1] == 'p')
        {
            // capitalise the 'p', not the number
            var charArray = enumFieldNameSection.ToCharArray();
            charArray[1] = char.ToUpper(charArray[1]);
            return new string(charArray);
        }

        // check if the section has a special static capitalisation
        var specialCapitalisationCases = new Dictionary<string, string>()
        {
            ["ycbcr"] = "YCBCR",
            ["srgb"] = "SRGB",
            ["uint"] = "UInt",
            ["sint"] = "SInt",
            ["unorm"] = "UNorm",
            ["snorm"] = "SNorm",
            ["ufloat"] = "UFloat",
            ["sfloat"] = "SFloat",
            ["uscaled"] = "UScaled",
            ["sscaled"] = "SScaled",
            ["rgb"] = "RGB",
            ["rgba"] = "RGBA",
            ["hsl"] = "HSL",

            ["uint8"] = "UInt8",
            ["uint16"] = "UInt16",
            ["uint32"] = "UInt32",
            ["uint64"] = "UInt64",
            ["sint8"] = "SInt8",
            ["sint16"] = "SInt16",
            ["sint32"] = "SInt32",
            ["sint64"] = "SInt64",

            ["vblank"] = "VBlank",

            ["cpu"] = "CPU",
            ["gpu"] = "GPU",

            ["d3d11"] = "D3D11",
            ["d3d12"] = "D3D12",

            ["gdeflate"] = "GDeflate",

            ["sm"] = "SM",
            ["hw"] = "HW",
            ["api"] = "API",
            ["itu"] = "ITU",
            ["1d"] = "1D",
            ["2d"] = "2D",
            ["3d"] = "3D",
            ["drm"] = "DRM",
            ["aabb"] = "AABB",
            ["aabbs"] = "AABBs",
            ["dpb"] = "DPB",
            ["pci"] = "PCI",
            ["rdma"] = "RDMA",

            ["dci"] = "DCI",
            ["hdr"] = "HDR",
            ["hdr10"] = "HDR10",
            ["st2084"] = "ST2084",
            ["hlg"] = "HLG",
            ["bt709"] = "BT709",
            ["bt2020"] = "BT2020",
            ["adobergb"] = "AdobeRGB",
            ["dolbyvision"] = "DolbyVision"
        };
        if (specialCapitalisationCases.TryGetValue(enumFieldNameSection, out var value))
            return value;

        return enumFieldNameSection.FirstToUpper();
    }
}
