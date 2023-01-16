namespace NVK.Generator;

/// <summary>Handles documentation for the generated code.</summary>
internal static class DocumentationManager
{
    /*********
    ** Fields
    *********/
    /// <summary>The loaded documentation strings.</summary>
    private static readonly Dictionary<string, string> DocumentationStrings = new();


    /*********
    ** Public Methods
    *********/
    /// <summary>Checks whether a documentation string exists.</summary>
    /// <param name="documentationString">The documentation string to check.</param>
    /// <returns><see langword="true"/>, if the documentation string exists; otherwise, <see langword="false"/>.</returns>
    public static bool DoesDocumentationStringExist(string documentationString) => DocumentationStrings.ContainsKey(documentationString);

    /// <summary>Gets a documentation string.</summary>
    /// <param name="documentationStringId">The id of the documentation string.</param>
    /// <returns>The documentation string with the specified id, if documentation exists; otherwise, "ERROR: NO DOCUMENTATION EXISTS FOR <paramref name="documentationStringId"/>".</returns>
    public static string GetDocumentationString(string documentationStringId)
    {
        if (DocumentationStrings.TryGetValue(documentationStringId, out var documentationString))
            return documentationString;
        else
            return $"ERROR: NO DOCUMENTATION EXISTS FOR {documentationStringId}";
    }
}
