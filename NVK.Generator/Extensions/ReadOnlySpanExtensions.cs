namespace NVK.Generator.Extensions;

/// <summary>Extension methods for <see langword="string"/>.</summary>
internal static class ReadOnlySpanExtensions
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Forms a slice out of the current read-only span that begins at a specified string and ends at another.</summary>
    /// <param name="span">The span to slice.</param>
    /// <param name="start">The start string to use when slicing the span.</param>
    /// <param name="end">The end string to use when slicing the span.</param>
    /// <returns>A span that consists of all elements of the current span from <paramref name="start"/> to <paramref name="end"/> (exclusive).</returns>
    /// <remarks><paramref name="start"/> and <paramref name="end"/> are exclusive.</remarks>
    public static ReadOnlySpan<char> Slice(this ReadOnlySpan<char> span, string start, string end)
    {
        var startIndex = span.IndexOf(start);
        if (startIndex != -1)
            span = span.Slice(startIndex + start.Length);

        var endIndex = span.IndexOf(end);
        if (endIndex != -1)
            span = span.Slice(0, endIndex);

        return span;
    }
}
