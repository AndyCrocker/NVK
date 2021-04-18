namespace Vulkan
{
    /// <summary>Represents the size of a block of device memory.</summary>
    public struct VkDeviceSize
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
        /// <summary>Converts a <see cref="VkDeviceSize"/> to an <see langword="int"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static explicit operator int(VkDeviceSize value) => (int)value.Value;

        /// <summary>Converts an <see langword="int"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see langword="int"/> to convert.</param>
        public static implicit operator VkDeviceSize(int value) => new VkDeviceSize() { Value = (ulong)value };

        /// <summary>Converts a <see cref="VkDeviceSize"/> to a <see langword="uint"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static explicit operator uint(VkDeviceSize value) => (uint)value.Value;

        /// <summary>Converts a <see langword="uint"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see langword="uint"/> to convert.</param>
        public static implicit operator VkDeviceSize(uint value) => new VkDeviceSize() { Value = value };

        /// <summary>Converts a <see cref="VkDeviceSize"/> to a <see langword="ulong"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static implicit operator ulong(VkDeviceSize value) => value.Value;

        /// <summary>Converts a <see langword="ulong"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see langword="ulong"/> to convert.</param>
        public static implicit operator VkDeviceSize(ulong value) => new VkDeviceSize() { Value = value };
    }
}
