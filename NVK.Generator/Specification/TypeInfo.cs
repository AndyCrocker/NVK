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
        ["VkSampleMask"] = "uint",
        ["PFN_vkVoidFunction"] = "IntPtr"
    };


    /*********
    ** Properties
    *********/
    /// <summary>The name of the type.</summary>
    public string Name { get; }

    /// <summary>The pointer indirection of the type.</summary>
    public int PointerIndirection { get; }

    /// <summary>Whether the type is an array.</summary>
    public bool IsArray { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the type.</param>
    /// <param name="pointerIndirection">The pointer indirection of the type.</param>
    /// <param name="isArray">Whether the type is an array.</param>
    public TypeInfo(string name, int pointerIndirection = 0, bool isArray = false)
    {
        Name = CalculateDisplayName(name);
        PointerIndirection = pointerIndirection;
        IsArray = isArray;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Gets a string that represents the type.</summary>
    /// <returns>A string that represents the type.</returns>
    public override string? ToString() => $"{Name}{new('*', PointerIndirection)}{(IsArray ? "[]" : "")}";


    /*********
    ** Private Methods
    *********/
    /// <summary>Calculates the display name of a type name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <returns>The display name for a type called <paramref name="name"/>.</returns>
    private static string CalculateDisplayName(string name)
    {
        if (TypeConverter.TryGetValue(name, out var convertedName))
            name = convertedName;

        if (name.StartsWith("PFN_vk"))
            return DelegateInfo.CalculateDisplayName(name);

        return name;
    }
}
