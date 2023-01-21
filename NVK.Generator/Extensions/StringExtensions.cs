namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see langword="string"/>.</summary>
internal static class StringExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Converts the first character to uppercase.</summary>
    /// <param name="value">The string whose first character should be converted to uppercase.</param>
    /// <returns>A string with it's first character as uppercase.</returns>
    public static string FirstToUpper(this string value)
    {
        if (value == "")
            return value;

        var charArray = value.ToCharArray();
        charArray[0] = char.ToUpper(charArray[0]);
        return new string(charArray);
    }
}
