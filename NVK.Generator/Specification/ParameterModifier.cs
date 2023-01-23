namespace NVK.Generator.Specification;

/// <summary>The modifier a parameter can have.</summary>
internal enum ParameterModifier
{
    /// <summary>No modifier.</summary>
    None,

    /// <summary>The 'ref' modifier.</summary>
    [ParameterModifier("ref ", true)]
    Ref,

    /// <summary>The 'out' modifier.</summary>
    [ParameterModifier("out ", true)]
    Out,

    /// <summary>Explicit InAttribute & OutAttribute.</summary>
    [ParameterModifier("[In, Out] ", false)]
    InOut,
}
