namespace NVK.Generator;

/// <summary>Handles converting types ready for C# generation.</summary>
internal class TypeConverter
{
    /*********
    ** Fields
    *********/
    /// <summary>A type map for converting old types to new types.</summary>
    private readonly Dictionary<string, string> TypeMap = new()
    {
        { "char", "byte" },
        { "uint8_t", "byte" },
        { "uint16_t", "ushort" },
        { "uint32_t", "uint" },
        { "uint64_t", "ulong" },
        { "int32_t", "int" },
        { "int64_t", "long" },
        { "size_t", "nuint" },

        { "DWORD", "uint" },
        { "HINSTANCE", "IntPtr" },
        { "HWND", "IntPtr" },
        { "HANDLE", "IntPtr" },
        { "HMONITOR", "IntPtr" },
        { "SECURITY_ATTRIBUTES", "SecurityAttributes" },
        { "LPCWSTR", "IntPtr" },
        { "wl_display", "IntPtr" },
        { "wl_surface", "IntPtr" },
        { "xcb_connection_t", "IntPtr" },
        { "xcb_window_t", "IntPtr" },
        { "zx_handle_t", "IntPtr" },
        { "Display", "IntPtr" },
        { "Window", "IntPtr" },
        { "VisualID", "IntPtr" },
        { "ANativeWindow", "IntPtr" },
        { "AHardwareBuffer", "IntPtr" },

        // edge case typedefs that aren't defined the same way as the others in the xml file
        { "IOSurfaceRef", "IntPtr" },

        // aliased structures, they're used so rarely that it's just easier to manually specify them here
        { "VkMemoryRequirements2KHR", "VkMemoryRequirements2" },
        { "VkPipelineInfoEXT", "VkPipelineInfoKHR" }
    };


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="typedefs">The typedefs to create the type converter for.</param>
    /// <param name="enumAliases">The enum aliases to create the type convert for.</param>
    public TypeConverter(List<TypedefInfo> typedefs, Dictionary<string, string> enumAliases)
    {
        // add typedefs to map
        foreach (var typedef in typedefs)
            if (typedef.Requires != null)
                RegisterTypeConversion(typedef.Requires, typedef.Name);
            else
                RegisterTypeConversion(typedef.Name, typedef.Type);

        // add enum aliases to map
        foreach (var enumAlias in enumAliases)
            RegisterTypeConversion(enumAlias.Key, enumAlias.Value);
    }

    /// <summary>Registers a type conversion.</summary>
    /// <param name="oldType">The type to replace.</param>
    /// <param name="newType">The type to replace it with.</param>
    public void RegisterTypeConversion(string oldType, string newType) => TypeMap[oldType] = newType;

    /// <summary>Gets the converted type of a type.</summary>
    /// <param name="type">The type to get the converted type of.</param>
    /// <returns>The converted version of <paramref name="type"/>.</returns>
    public string GetConvertedType(string type)
    {
        // manually convert function pointers
        if (type.StartsWith("PFN_"))
            return "IntPtr";

        // check if type is aliasing another type
        if (!TypeMap.ContainsKey(type))
            return type;

        // find the type being aliased
        var aliasedType = type;
        do
        {
            aliasedType = TypeMap.First(typeName => typeName.Key == aliasedType).Value;
        }
        while (TypeMap.ContainsKey(aliasedType));

        return aliasedType;
    }
}
