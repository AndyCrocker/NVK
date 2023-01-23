/// <summary>Represents the base for specifying how the Vulkan library should be loaded/freed as well as how function pointers should be retrieved from it for an operating system.</summary>
internal abstract class OSVulkanLibraryBase : IDisposable
{
    /*********
    ** Properties
    *********/
    /// <summary>A handle to the loaded native library.</summary>
    public IntPtr Handle { get; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    public OSVulkanLibraryBase()
    {
        Handle = LoadLibrary();
        if (Handle == IntPtr.Zero)
            throw new InvalidOperationException($"Failed to load Vulkan library");
    }

    /// <summary>Gets a function pointer.</summary>
    /// <param name="functionName">The name of the function to get a pointer to.</param>
    /// <returns>A pointer to the function with the specified name.</returns>
    public abstract IntPtr GetFunctionPointer(string functionName);

    /// <inheritdoc/>
    public void Dispose() => FreeLibrary();

    /// <summary>Creates a Vulkan library based on the environment operating system.</summary>
    /// <returns>The Vulkan library for the environment operating system.</returns>
    public static OSVulkanLibraryBase CreateOSVulkanLibrary()
    {
        if (OperatingSystem.IsWindows())
            return new WindowsVulkanLibrary();
        else if (OperatingSystem.IsMacOS() || OperatingSystem.IsLinux() || OperatingSystem.IsAndroid())
            return new UnixVulkanLibrary();
        else
            throw new PlatformNotSupportedException("Cannot load the Vulkan library for the environment operating system");
    }


    /*********
    ** Protected Methods
    *********/
    /// <summary>Loads a library.</summary>
    /// <returns>A handle to the loaded library.</returns>
    protected abstract IntPtr LoadLibrary();

    /// <summary>Frees a library.</summary>
    protected abstract void FreeLibrary();
}
