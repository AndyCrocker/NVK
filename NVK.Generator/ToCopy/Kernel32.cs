namespace Vulkan;

/// <summary>Represents the Windows 'kernel32' api.</summary>
internal static class Kernel32
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Loads a specified library.</summary>
    /// <param name="libraryFileName">The name of the library.</param>
    /// <returns>A handle to the library, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [DllImport("kernel32")]
    public static extern IntPtr LoadLibrary(string libraryFileName);

    /// <summary>Retrieves a pointer to a function in a specified library.</summary>
    /// <param name="libraryHandle">A handle to the library containing the function to retrieve.</param>
    /// <param name="functionName">The name of the function to retrieve.</param>
    /// <returns>A handle to the function, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [DllImport("kernel32")]
    public static extern IntPtr GetProcAddress(IntPtr libraryHandle, string functionName);

    /// <summary>Frees the specified library.</summary>
    /// <param name="libraryHandle">A handle to the library to free.</param>
    /// <returns><see langword="true"/> if this function succeeds; otherwise, <see langword="false"/>.</returns>
    [DllImport("kernel32")]
    public static extern bool FreeLibrary(IntPtr libraryHandle);
}
