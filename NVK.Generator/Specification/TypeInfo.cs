namespace NVK.Generator.Specification;

/// <summary>Represents a parsed type.</summary>
internal class TypeInfo
{
    /*********
    ** Fields
    *********/
    /// <summary>The C to C# type mapping.</summary>
    private static readonly Dictionary<string, string> TypeConverter = new()
    {
        ["char"] = "byte",
        ["uint8_t"] = "byte",
        ["uint16_t"] = "ushort",
        ["uint32_t"] = "uint",
        ["uint64_t"] = "ulong",
        ["int32_t"] = "int",
        ["int64_t"] = "long",
        ["size_t"] = "nuint",

        // wayland
        ["wl_display"] = "void",
        ["wl_surface"] = "void",

        // x11
        ["Display"] = "void",
        ["VisualID"] = "IntPtr",
        ["Window"] = "IntPtr",
        ["RROutput"] = "IntPtr",

        // xcb
        ["xcb_connection_t"] = "void",
        ["xcb_window_t"] = "IntPtr",
        ["xcb_visualid_t"] = "IntPtr",

        // android
        ["ANativeWindow"] = "void",
        ["AHardwareBuffer"] = "void",

        // win32
        ["HINSTANCE"] = "IntPtr",
        ["HWND"] = "IntPtr",
        ["HMONITOR"] = "IntPtr",
        ["HANDLE"] = "IntPtr",
        ["DWORD"] = "uint",
        ["LPCWSTR"] = "IntPtr",
        ["SECURITY_ATTRIBUTES"] = "SecurityAttributes",

        // misc Vulkan
        ["VkRemoteAddressNV"] = "IntPtr",
        ["VkSampleMask"] = "uint"
    };


    /*********
    ** Properties
    *********/
    /// <summary>The name of the type.</summary>
    public string Name { get; }

    /// <summary>The pointer indirection of the type.</summary>
    public int PointerIndirection { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the type.</param>
    /// <param name="pointerIndirection">The pointer indirection of the type.</param>
    public TypeInfo(string name, int pointerIndirection = 0)
    {
        Name = CalculateDisplayName(name);
        PointerIndirection = pointerIndirection;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Gets a string that represents the type.</summary>
    /// <returns>A string that represents the type.</returns>
    public override string? ToString() => $"{Name}{new('*', PointerIndirection)}";


    /*********
    ** Private Methods
    *********/
    /// <summary>Calculates the display name of a type name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <returns>The display name for a type called <paramref name="name"/>.</returns>
    private static string CalculateDisplayName(string name)
    {
        if (TypeConverter.ContainsKey(name))
            return TypeConverter[name];

        return name;
    }
}
