namespace NVK.Generator.Specification;

/// <summary>The type of a constant.</summary>
internal enum ConstantType
{
    /// <summary>An unsigned 32-bit integer.</summary>
    [UnderlyingType("uint")]
    UInt,

    /// <summary>An unsigned 64-bit integer.</summary>
    [UnderlyingType("ulong")]
    ULong,

    /// <summary>A single-precision floating-point number.</summary>
    [UnderlyingType("float")]
    Single,

    /// <summary>Text as a sequence of UTF-16 characters.</summary>
    [UnderlyingType("string")]
    String
}