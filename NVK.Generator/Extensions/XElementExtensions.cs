namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see cref="XElement"/>.</summary>
internal static class XElementExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Gets whether the current element has the specified attribute with a specified value.</summary>
    /// <param name="element">The element to check whether it has the attribute <paramref name="attributeName"/> with a value in <paramref name="attributeValues"/>.</param>
    /// <param name="attributeName">The name of the attribute to check whether it one of the values in <paramref name="attributeValues"/>.</param>
    /// <param name="attributeValues">The values to check if the attribute has.</param>
    /// <returns><see langword="true"/> if the attribute exists and, if <paramref name="attributeValues"/> is specified, has one of the values in <paramref name="attributeValues"/>; otherwise, <see langword="false"/>.</returns>
    public static bool HasAttribute(this XElement element, string attributeName, params string[] attributeValues)
    {
        var attribute = element.Attribute(attributeName);
        if (attribute == null)
            return false;

        if (!attributeValues.Any())
            return true;

        return attributeValues.Contains(attribute.Value);
    }
}
