using NVK.Generator.Attributes;

namespace NVK.Generator.Specification
{
    /// <summary>The modifier a parameter can have.</summary>
    public enum ParameterModifier
    {
        /// <summary>No modifier.</summary>
        None,

        /// <summary>The 'ref' modifier.</summary>
        [UnderlyingType("ref ")]
        Ref,

        /// <summary>The 'out' modifier.</summary>
        [UnderlyingType("out ")]
        Out,

        /// <summary>Explicit InAttribute & OutAttribute.</summary>
        [UnderlyingAttribute("[In, Out] ")]
        InOut,
    }
}
