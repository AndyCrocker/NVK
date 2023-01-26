/// <summary>Represents the Unix dynamic library api.</summary>
internal static partial class LibDl
{
    /*********
    ** Constants
    *********/
    /// <summary>Specifies that all undefined symbols in the shared object are resolved before <see cref="dlopen(string, int)"/> returns.</summary>
    public const int RtldNow = 1 << 1;


    /*********
    ** Public Methods
    *********/
    /// <summary>Opens a dynamic library.</summary>
    /// <param name="fileName">The name of the library to open.</param>
    /// <param name="flags">The flags to use when opening the library.</param>
    /// <returns>A handle to the library, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [LibraryImport("libdl.so", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr dlopen(string fileName, int flags);

    /// <summary>Retrieves a pointer to a function in a specified library.</summary>
    /// <param name="libraryHandle">A handle to the library containing the function to retrieve.</param>
    /// <param name="functionName">The name of the function to retrieve.</param>
    /// <returns>A handle to the function, if this function succeeds; otherwise, <see cref="IntPtr.Zero"/>.</returns>
    [LibraryImport("libdl.so", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr dlsym(IntPtr libraryHandle, string functionName);

    /// <summary>Frees the specified library.</summary>
    /// <param name="libraryHandle">A handle to the library to free.</param>
    /// <returns>Zero if this function succeeds; otherwise, nonzero.</returns>
    [LibraryImport("libdl.so")]
    public static partial int dlclose(IntPtr libraryHandle);
}
