// This file was generated, don't manually edit
namespace Vulkan_1_0;

/// <summary>Represents the Windows 'kernel32' api.</summary>
internal static partial class Kernel32
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Loads a specified library.</summary>
    /// <param name="libraryFileName">The name of the library.</param>
    /// <returns>A handle to the library, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [LibraryImport("kernel32", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr LoadLibraryA(string libraryFileName);

    /// <summary>Retrieves a pointer to a function in a specified library.</summary>
    /// <param name="libraryHandle">A handle to the library containing the function to retrieve.</param>
    /// <param name="functionName">The name of the function to retrieve.</param>
    /// <returns>A handle to the function, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [LibraryImport("kernel32", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr GetProcAddress(IntPtr libraryHandle, string functionName);

    /// <summary>Frees the specified library.</summary>
    /// <param name="libraryHandle">A handle to the library to free.</param>
    /// <returns><see langword="true"/> if this function succeeds; otherwise, <see langword="false"/>.</returns>
    [LibraryImport("kernel32")]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool FreeLibrary(IntPtr libraryHandle);
}
