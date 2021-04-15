using System;

namespace Vulkan
{
    /// <summary>Specifies how the Vulkan library should be loaded/freed as well as how function pointers should be retrieved from it for Windows.</summary>
    internal class WindowsVulkanLibrary : OSVulkanLibraryBase
    {
        /*********
        ** Public Methods
        *********/
        /// <inheritdoc/>
        public override IntPtr GetFunctionPointer(string functionName) => Kernel32.GetProcAddress(Handle, functionName);


        /*********
        ** Protected Methods
        *********/
        /// <inheritdoc/>
        protected override IntPtr LoadLibrary() => Kernel32.LoadLibrary("vulkan-1.dll");

        /// <inheritdoc/>
        protected override void FreeLibrary() => Kernel32.FreeLibrary(Handle);
    }
}
