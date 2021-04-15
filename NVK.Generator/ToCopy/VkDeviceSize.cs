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
        /// <summary>Converts a <see cref="VkDeviceSize"/> to a <see cref="int"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static implicit operator int(VkDeviceSize value) => (int)value.Value;

        /// <summary>Converts a <see cref="int"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see cref="int"/> to convert.</param>
        public static explicit operator VkDeviceSize(int value) => new VkDeviceSize() { Value = (ulong)value };

        /// <summary>Converts a <see cref="VkDeviceSize"/> to a <see cref="uint"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static explicit operator uint(VkDeviceSize value) => (uint)value.Value;

        /// <summary>Converts a <see cref="uint"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see cref="uint"/> to convert.</param>
        public static implicit operator VkDeviceSize(uint value) => new VkDeviceSize() { Value = value };

        /// <summary>Converts a <see cref="VkDeviceSize"/> to a <see cref="ulong"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceSize"/> to convert.</param>
        public static implicit operator ulong(VkDeviceSize value) => value.Value;

        /// <summary>Converts a <see cref="ulong"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see cref="ulong"/> to convert.</param>
        public static implicit operator VkDeviceSize(ulong value) => new VkDeviceSize() { Value = value };
    }
}
