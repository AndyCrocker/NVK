namespace Vulkan
{
    /// <summary>Represents an API version.</summary>
    public class VkVersion
    {
        /*********
        ** Fields
        *********/
        /// <summary>The underlying version as a <see langword="uint"/>.</summary>
        private readonly uint Version;


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="variant">The variant number.</param>
        /// <param name="major">The major version number.</param>
        /// <param name="minor">The minor version number.</param>
        /// <param name="patch">The patch version number.</param>
        public VkVersion(uint variant, uint major, uint minor, uint patch)
        {
            Version = variant << 29 | major << 22 | minor << 12 | patch;
        }


        /*********
        ** Operators
        *********/
        /// <summary>Converts a <see cref="VkVersion"/> to a <see langword="uint"/>.</summary>
        /// <param name="version">The <see cref="VkVersion"/> to convert.</param>
        public static implicit operator uint(VkVersion version) => version.Version;
    }
}
