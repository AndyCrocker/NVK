// This file was generated, don't manually edit
namespace Vulkan_1_0;

/// <summary>Specifies how the Vulkan library should be loaded/freed as well as how function pointers should be retrieved from it for Unix.</summary>
internal class UnixVulkanLibrary : OSVulkanLibraryBase
{
    /*********
    ** Public Methods
    *********/
    /// <inheritdoc/>
    public override IntPtr GetFunctionPointer(string functionName) => LibDl.dlsym(Handle, functionName);


    /*********
    ** Protected Methods
    *********/
    /// <inheritdoc/>
    protected override IntPtr LoadLibrary()
    {
        var handle = LibDl.dlopen("libvulkan.so.1", LibDl.RtldNow); // desktop linux
        if (handle == IntPtr.Zero)
            handle = LibDl.dlopen("libvulkan.so", LibDl.RtldNow); // android

        return handle;
    }

    /// <inheritdoc/>
    protected override void FreeLibrary() => LibDl.dlclose(Handle);
}
