namespace Vulkan
{
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
        /// <summary>Converts a <see cref="VkDeviceAddress"/> to a <see cref="int"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
        public static implicit operator int(VkDeviceAddress value) => (int)value.Value;

        /// <summary>Converts a <see cref="int"/> to a <see cref="VkDeviceAddress"/>.</summary>
        /// <param name="value">The <see cref="int"/> to convert.</param>
        public static explicit operator VkDeviceAddress(int value) => new VkDeviceAddress() { Value = (ulong)value };

        /// <summary>Converts a <see cref="VkDeviceAddress"/> to a <see cref="uint"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
        public static explicit operator uint(VkDeviceAddress value) => (uint)value.Value;

        /// <summary>Converts a <see cref="uint"/> to a <see cref="VkDeviceSize"/>.</summary>
        /// <param name="value">The <see cref="uint"/> to convert.</param>
        public static implicit operator VkDeviceAddress(uint value) => new VkDeviceAddress() { Value = value };

        /// <summary>Converts a <see cref="VkDeviceAddress"/> to a <see cref="ulong"/>.</summary>
        /// <param name="value">The <see cref="VkDeviceAddress"/> to convert.</param>
        public static implicit operator ulong(VkDeviceAddress value) => value.Value;

        /// <summary>Converts a <see cref="ulong"/> to a <see cref="VkDeviceAddress"/>.</summary>
        /// <param name="value">The <see cref="ulong"/> to convert.</param>
        public static implicit operator VkDeviceAddress(ulong value) => new VkDeviceAddress() { Value = value };
    }
}
