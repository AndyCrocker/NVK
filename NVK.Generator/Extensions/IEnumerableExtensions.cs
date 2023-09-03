namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see cref="IEnumerable{T}"/>.</summary>
internal static class IEnumerableExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Filters a sequence of values that have a specified attribute, optionally with a specified value.</summary>
    /// <param name="elements">The elements to filter.</param>
    /// <param name="attributeName">The name of the attribute to filter on.</param>
    /// <param name="attributeValues">If specified, the values to use when filtering the elements.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains elements from the input sequence that have the specified attribute name and, if <paramref name="attributeValues"/> is specified, whose value is one of the values in <paramref name="attributeValues"/>.</returns>
    public static IEnumerable<XElement> WithAttribute(this IEnumerable<XElement> elements, string attributeName, params string[] attributeValues) =>
        elements.Where(element => element.HasAttribute(attributeName, attributeValues));

    /// <summary>Filters a sequence of values that don't have a specified attribute, optionally with a specified value.</summary>
    /// <param name="elements">The elements to filter.</param>
    /// <param name="attributeName">The name of the attribute to filter on.</param>
    /// <param name="attributeValues">If specified, the values to use when filtering the elements.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains elements from the input sequence that don't have the specified attribute name or, if <paramref name="attributeValues"/> is specified, whose value is not one of the values in <paramref name="attributeValues"/>.</returns>
    public static IEnumerable<XElement> WithoutAttribute(this IEnumerable<XElement> elements, string attributeName, params string[] attributeValues) =>
        elements.Where(element => !element.HasAttribute(attributeName, attributeValues));

    /// <summary>Filters a sequence of values that have "vulkan" in the "api" attribute, if one is present.</summary>
    /// <param name="elements">The elements to filter.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains elements from the input sequence that either don't have an "api" attribute, or the "api" attribute contains "vulkan".</returns>
    public static IEnumerable<XElement> WhereVulkanInApi(this IEnumerable<XElement> elements) =>
        elements.Where(element => element.Attribute("api")?.Value.Split(",").Contains("vulkan") ?? true);

    /// <summary>Filters a sequence of values that have "vulkan" in the "supported" attribute, if one is present.</summary>
    /// <param name="elements">The elements to filter.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains elements from the input sequence that either don't have a "supported" attribute, or the "supported" attribute contains "vulkan".</returns>
    public static IEnumerable<XElement> WhereVulkanInSupported(this IEnumerable<XElement> elements) =>
        elements.Where(element => element.Attribute("supported")?.Value.Split(",").Contains("vulkan") ?? true);
}
