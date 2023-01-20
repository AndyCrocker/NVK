// This file was generated, don't manually edit
namespace Vulkan_1_1;

/// <summary>A boolean (<see langword="true"/> or <see langword="false"/>) value stored in a 32-bit unsigned integer.</summary>
public struct VkBool32
{
    /*********
    ** Fields
    *********/
    /// <summary>The underlying value.</summary>
    /// <remarks>A value of 0 represents <see langword="false"/>, any other value represents <see langword="true"/>.</remarks>
    private uint Value;


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="value">The underlying value.</param>
    public VkBool32(bool value)
    {
        Value = value ? 1u : 0u;
    }

    /// <inheritdoc/>
    public override string ToString() => ((bool)this).ToString();


    /*********
    ** Operators
    *********/
    /// <summary>Converts a <see cref="VkBool32"/> to a <see langword="bool"/>.</summary>
    /// <param name="value">The <see cref="VkBool32"/> to convert.</param>
    public static implicit operator bool(VkBool32 value) => value.Value != 0;

    /// <summary>Converts a <see langword="bool"/> to a <see cref="VkBool32"/>.</summary>
    /// <param name="value">The <see langword="bool"/> to convert.</param>
    public static implicit operator VkBool32(bool value) => new(value);
}
