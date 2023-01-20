// This file was generated, don't manually edit
namespace Vulkan_1_3;

/// <summary>Represents the address of a block of device memory.</summary>
public struct VkDeviceAddress
{
    /*********
    ** Fields
    *********/
    /// <summary>The underlying value.</summary>
    private ulong Value;


    /*********
    ** Public Methods
    *********/
    /// <inheritdoc/>
    public override string ToString() => Value.ToString();


    /*********
    ** Operators
    *********/
    /// <summary>Converts a <see cref="VkDeviceAddress"/> to an <see langword="int"/>.</summary>
    /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
    public static implicit operator int(VkDeviceAddress value) => (int)value.Value;

    /// <summary>Converts an <see langword="int"/> to a <see cref="VkDeviceAddress"/>.</summary>
    /// <param name="value">The <see langword="int"/> to convert.</param>
    public static explicit operator VkDeviceAddress(int value) => new() { Value = (ulong)value };

    /// <summary>Converts a <see cref="VkDeviceAddress"/> to a <see langword="uint"/>.</summary>
    /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
    public static explicit operator uint(VkDeviceAddress value) => (uint)value.Value;

    /// <summary>Converts a <see langword="uint"/> to a <see cref="VkDeviceSize"/>.</summary>
    /// <param name="value">The <see langword="uint"/> to convert.</param>
    public static implicit operator VkDeviceAddress(uint value) => new() { Value = value };

    /// <summary>Converts a <see cref="VkDeviceAddress"/> to a <see langword="ulong"/>.</summary>
    /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
    public static implicit operator ulong(VkDeviceAddress value) => value.Value;

    /// <summary>Converts a <see langword="ulong"/> to a <see cref="VkDeviceAddress"/>.</summary>
    /// <param name="value">The <see langword="ulong"/> to convert.</param>
    public static implicit operator VkDeviceAddress(ulong value) => new() { Value = value };
}
