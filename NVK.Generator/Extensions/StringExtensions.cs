namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see langword="string"/>.</summary>
internal static class StringExtensions
{
    /*********
    ** Public Methods
    *********/
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
}
