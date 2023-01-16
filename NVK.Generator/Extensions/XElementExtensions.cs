namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see cref="XElement"/>.</summary>
internal static class XElementExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Gets whether the current <see cref="XElement"/> has the specified attribute with the specified value.</summary>
    /// <param name="element">The <see cref="XElement"/> to get whether it has the attribute <paramref name="attributeName"/> with a value of <paramref name="attributeValue"/>.</param>
    /// <param name="attributeName">The name of the attribute to check whether it contains the value of <paramref name="attributeValue"/>.</param>
    /// <param name="attributeValue">The value that <paramref name="attributeName"/> should be.</param>
    /// <returns><see langword="true"/> if the attribute exists and has the specified value; otherwise, <see langword="false"/>.</returns>
    public static bool HasAttributeWithValue(this XElement element, string attributeName, string attributeValue)
    {
        // ensure the attribute exists
        var attribute = element.Attribute(attributeName);
        if (attribute == null)
            return false;

        // return whether the attribute value is correct
        return attribute.Value == attributeValue;
    }
}
