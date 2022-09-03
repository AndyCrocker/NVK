using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace NVK.Generator;

/// <summary>Handles documentation for the generated code.</summary>
internal static class DocumentationManager
{
    /*********
    ** Fields
    *********/
    /// <summary>The loaded documentation strings.</summary>
    private static readonly Dictionary<string, string> DocumentationStrings;


    /*********
    ** Public Methods
    *********/
    /// <summary>Initialises the class.</summary>
    static DocumentationManager()
    {
        DocumentationStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("./DocumentationStrings.json")) ?? new();
    }

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
