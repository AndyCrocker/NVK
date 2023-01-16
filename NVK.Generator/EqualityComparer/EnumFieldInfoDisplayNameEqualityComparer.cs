namespace NVK.Generator.EqualityComparer;

/// <summary>Defines how two <see cref="EnumFieldInfo"/>s should be compared.</summary>
/// <remarks>This only uses <see cref="EnumFieldInfo.DisplayName"/>.</remarks>
public class EnumFieldInfoDisplayNameEqualityComparer : IEqualityComparer<EnumFieldInfo>
{
    /*********
    ** Public Methods
    *********/
    /// <inheritdoc/>
    public bool Equals(EnumFieldInfo? x, EnumFieldInfo? y) => x?.DisplayName == y?.DisplayName;

    /// <inheritdoc/>
    public int GetHashCode([DisallowNull] EnumFieldInfo obj) => obj.DisplayName.GetHashCode();
}
