**NVK** is a low-level .NET7 [Vulkan](https://www.khronos.org/vulkan/) binding.

### Usage
NVK exposes all major Vulkan versions through namespaces, for example: `using Vulkan_1_0;`<br />
All structures, handles, enums, constants, and functions are stored in the namespace.

#### Naming
- Structures and Handles are named exactly the same as defined in Vulkan.<br />
  The structure fields have any prefixed `p` removed and are pascal case to follow C# conventions.
- Enums are mostly named the same, all bitmask enums are named with `..Flags` (instead of `..FlagBits`).<br />
  Bitmask enums fields have the `BIT` at the end removed.
- All constants are stored inside of `VK`, with the names changed to follow C# conventions, for example: `VK_MAX_PHYSICAL_DEVICE_NAME_SIZE` becomes `VK.MaxPhysicalDeviceNameSize`.
- All functions are stored inside of `VK`, with the prefixed `vk` removed, for example: `vkCreateInstance(..)` becomes `VK.CreateInstance(..)`; abbreviations are also resolved, for example: `vkGetInstanceProcAddr(..)` becomes `VK.GetInstanceProcedureAddress(..)`.

#### Versions
When calculating the version of the API or application in `VkApplicationInfo` use `VkVersion`, for example:
```cs
var applicationInfo = new VkApplicationInfo
{
    SType = VkStructureType.ApplicationInfo,
    ApplicationVersion = new VkVersion(0, 1, 0, 0),
    ApiVersion = new VkVersion(0, 1, 0, 0)
};
```

#### Functions
By default the only Vulkan functions that can be used are:<br />
`VK.CreateInstance(..)`<br />
`VK.GetInstanceProcedureAddress(..)`<br />
`VK.EnumerateInstanceExtensionProperties(..)`<br />
`VK.EnumerateInstanceLayerProperties(..)`<br />

To use the other Vulkan functions you must create an instance using `VK.CreateInstance(..)` and pass the created `VkInstance` handle to `VK.InitialiseInstanceMethods(VkInstance)`.

#### Structure Fields
If a structure field is a pointer in the Vulkan definition, then it also is in the C# definition; this will require either using `&` or pinning memory, for example:
```cs
var applicationName = "application name"u8;
var engineName = "engine name"u8;

fixed (byte* applicationNamePointer = applicationName)
fixed (byte* engineNamePointer = engineName)
{
    var applicationInfo = new VkApplicationInfo
    {
        SType = VkStructureType.ApplicationInfo,
        ApplicationName = applicationNamePointer,
        ApplicationVersion = new VkVersion(0, 1, 0, 0),
        EngineName = engineNamePointer,
        ApiVersion = new VkVersion(0, 1, 3, 0)
    };

    var instanceCreateInfo = new VkInstanceCreateInfo
    {
        SType = VkStructureType.InstanceCreateInfo,
        ApplicationInfo = &applicationInfo,
        EnabledLayerCount = 0,
        EnabledExtensionCount = 0
    };

    if (VK.CreateInstance(&instanceCreateInfo, null, out var instance) != VkResult.Success)
    {
        // instance failed to be created
    }

    // instance create successfully
}
```

#### Function Overloads
Functions that have a parameter that is a pointer have overloads to be able to use them in a more conventional C# way, meaning there are overloads that use `ref`, `out`, `[In, Out]`, `string`, and `[]` where appropriate, instead of pointers.<br />
For example:
```cs
public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) {}
public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) {}
public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) {}
public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) {}
```