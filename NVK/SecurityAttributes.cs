namespace Vulkan;

/// <summary>Contains the security descriptor for an object and specifies whether the handle retrieved by specifying this structure is inheritable.</summary>
public struct SecurityAttributes
{
    /*********
    ** Fields
    *********/
    /// <summary>The size, in <see langword="byte"/>s, of this structure.</summary>
    public uint Length;

    /// <summary>A pointer to a SECURITY_DESCRIPTOR structure that control access to the object.</summary>
    public IntPtr SecurityDescriptor;

    /// <summary>Specifies whether the returned handle is inherited when a new process is created.</summary>
    [MarshalAs(UnmanagedType.I4)]
    public bool InheritHandle;
}
