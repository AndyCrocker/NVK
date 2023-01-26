namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see langword="string"/>.</summary>
internal static class StringExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Splits a string on every uppercase character.</summary>
    /// <param name="value">The string to split.</param>
    /// <returns>An array whose elements contain the substrings from this instance that start with an uppercase.</returns>
    public static string[] SplitOnUpper(this string value) => Regex.Split(value, @"(?<!^)(?=[A-Z])"); // https://stackoverflow.com/a/4489031

    /// <summary>Converts the first character to lowercase.</summary>
    /// <param name="value">The string whose first character should be converted to lowercase.</param>
    /// <returns>A string with its first character as lowercase.</returns>
    public static string FirstToLower(this string value)
    {
        if (value == "")
            return value;

        var charArray = value.ToCharArray();
        charArray[0] = char.ToLower(charArray[0]);
        return new string(charArray);
    }

    /// <summary>Converts the first character to uppercase.</summary>
    /// <param name="value">The string whose first character should be converted to uppercase.</param>
    /// <returns>A string with its first character as uppercase.</returns>
    public static string FirstToUpper(this string value)
    {
        if (value == "")
            return value;

        var charArray = value.ToCharArray();
        charArray[0] = char.ToUpper(charArray[0]);
        return new string(charArray);
    }

    /// <summary>Resolves all abbreviations in a string.</summary>
    /// <param name="value">The string to resolve the abbreviations of.</param>
    /// <returns>A string with all abbreviations resolved.</returns>
    public static string ResolveAbbreviations(this string value)
    {
        var abbreviations = new List<(string Abbreviated, string Resolved)>
        {
            ("Src", "Source"),
            ("Dst", "Destination"),
            ("Cmd", "Command"),
            ("ProcAddr", "ProcedureAddress"),
            ("Fd", "FileDescriptor")
        };

        foreach (var (abbreviated, resolved) in abbreviations)
        {
            // completely ignoring case can't be done as it'll convert 'BlendState' to 'BlenDestinationate' among others
            value = value.Replace(abbreviated, resolved);
            value = value.Replace(abbreviated.ToLower(), resolved);
        }

        return value;
    }

    /// <summary>Ensures a string isn't a reserved C# word.</summary>
    /// <param name="value">The string to ensure isn't a reserved keyword.</param>
    /// <returns>A string that isn't a reserved keyword.</returns>
    public static string EnsureIsntReserved(this string value)
    {
        var reservedKeywords = new[] { "event", "object" }; // obviously not all the reserved keywords, but these are the only ones Vulkan uses
        if (reservedKeywords.Contains(value))
            value = $"@{value}";

        return value;
    }

    /// <summary>Capitalises the vendor tags at the end of a string.</summary>
    /// <param name="value">The string to capitalise the vendor tags at the end of.</param>
    /// <returns>A string that has any suffixed vendor tags capitalised.</returns>
    public static string CapitaliseSuffixedVendorTags(this string value)
    {
        var suffix = "";
        while (true)
        {
            var vendorTagRemoved = false;

            foreach (var vendorTag in VulkanSpecification.VendorTags)
                if (value.EndsWith(vendorTag, StringComparison.InvariantCultureIgnoreCase))
                {
                    suffix = vendorTag.ToUpper() + suffix;
                    value = value[..^vendorTag.Length];
                    vendorTagRemoved = true;
                }

            if (!vendorTagRemoved)
                break;
        }

        return value + suffix;
    }
}
