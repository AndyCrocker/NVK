// this file was generated, don't edit manually

using System;
using System.Runtime.InteropServices;

namespace Vulkan;
/// <summary>Base structure for a read-only pointer chain.</summary>
public unsafe struct VkBaseOutStructure
{
	/// <summary>The structure type of the structure being iterated through.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to the next structure in a structure chain.</summary>
	public VkBaseOutStructure* Next;
}
/// <summary>Base structure for a read-only pointer chain.</summary>
public unsafe struct VkBaseInStructure
{
	/// <summary>The structure type of the structure being iterated through.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to the next structure in a structure chain.</summary>
	public VkBaseInStructure* Next;
}
/// <summary>Structure specifying a two-dimensional offset.</summary>
public unsafe struct VkOffset2D
{
	/// <summary>The x offset.</summary>
	public int X;
	/// <summary>The y offset.</summary>
	public int Y;
	public static VkOffset2D Zero => new();
	public VkOffset2D(int x, int y)
	{
		X = x;
		Y = y;
	}
}
/// <summary>Structure specifying a three-dimensional offset.</summary>
public unsafe struct VkOffset3D
{
	/// <summary>The x offset.</summary>
	public int X;
	/// <summary>The y offset.</summary>
	public int Y;
	/// <summary>The z offset.</summary>
	public int Z;
	public static VkOffset3D Zero => new();
	public VkOffset3D(int x, int y, int z)
	{
		X = x;
		Y = y;
		Z = z;
	}
}
/// <summary>Structure specifying a two-dimensional extent.</summary>
public unsafe struct VkExtent2D
{
	/// <summary>The width of the extent.</summary>
	public uint Width;
	/// <summary>The height of the extent.</summary>
	public uint Height;
	public static VkExtent2D Zero => new();
	public VkExtent2D(uint width, uint height)
	{
		Width = width;
		Height = height;
	}
}
/// <summary>Structure specifying a three-dimensional extent.</summary>
public unsafe struct VkExtent3D
{
	/// <summary>The width of the extent.</summary>
	public uint Width;
	/// <summary>The height of the extent.</summary>
	public uint Height;
	/// <summary>The depth of the extent.</summary>
	public uint Depth;
	public static VkExtent3D Zero => new();
	public VkExtent3D(uint width, uint height, uint depth)
	{
		Width = width;
		Height = height;
		Depth = depth;
	}
}
/// <summary>Structure specifying a viewport.</summary>
public unsafe struct VkViewport
{
	/// <summary>The x position of the upper left corner.</summary>
	public float X;
	/// <summary>The y position of the upper left corner.</summary>
	public float Y;
	/// <summary>The width of the viewport.</summary>
	public float Width;
	/// <summary>The height of the viewport.</summary>
	public float Height;
	/// <summary>The min depth of the viewport.</summary>
	public float MinDepth;
	/// <summary>The max depth of the viewport.</summary>
	public float MaxDepth;
}
/// <summary>Structure specifying a two-dimensional subregion.</summary>
public unsafe struct VkRect2D
{
	/// <summary>A <see cref="VkOffset2D"/> specifying the rectangle offset.</summary>
	public VkOffset2D Offset;
	/// <summary>A <see cref="VkExtent2D"/> specifying the rectangle extent.</summary>
	public VkExtent2D Extent;
	public VkRect2D(VkOffset2D offset, VkExtent2D extent)
	{
		Offset = offset;
		Extent = extent;
	}
}
/// <summary>Structure specifying a clear rectangle.</summary>
public unsafe struct VkClearRect
{
	/// <summary>The two-dimensional region to be cleared.</summary>
	public VkRect2D Rect;
	/// <summary>The first layer to be cleared.</summary>
	public uint BaseArrayLayer;
	/// <summary>The number of layers to clear.</summary>
	public uint LayerCount;
}
/// <summary>Structure specifying a color component mapping.</summary>
public unsafe struct VkComponentMapping
{
	/// <summary>A <see cref="VkComponentSwizzle"/> specifying the component value placed in the R component of the output vector.</summary>
	public VkComponentSwizzle R;
	/// <summary>A <see cref="VkComponentSwizzle"/> specifying the component value placed in the G component of the output vector.</summary>
	public VkComponentSwizzle G;
	/// <summary>A <see cref="VkComponentSwizzle"/> specifying the component value placed in the B component of the output vector.</summary>
	public VkComponentSwizzle B;
	/// <summary>A <see cref="VkComponentSwizzle"/> specifying the component value placed in the A component of the output vector.</summary>
	public VkComponentSwizzle A;
	public static VkComponentMapping Identity => new(VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity);
	public VkComponentMapping(VkComponentSwizzle r, VkComponentSwizzle g, VkComponentSwizzle b, VkComponentSwizzle a)
	{
		R = r;
		G = g;
		B = b;
		A = a;
	}
}
/// <summary>Structure specifying physical device properties.</summary>
public unsafe struct VkPhysicalDeviceProperties
{
	/// <summary>The version of Vulkan supported by the device.</summary>
	public uint ApiVersion;
	/// <summary>The vendor-specified version of the driver.</summary>
	public uint DriverVersion;
	/// <summary>A unique identifier for the vendor of the physical device.</summary>
	public uint VendorID;
	/// <summary>A unique identifier for the physical device among devices available from the vendor.</summary>
	public uint DeviceID;
	/// <summary>A <see cref="VkPhysicalDeviceType"/> specifying the type of device.</summary>
	public VkPhysicalDeviceType DeviceType;
	/// <summary>An array of <see cref="VK.MaxPhysicalDeviceNameSize"/> <see langword="byte"/>s containing a null-terminated UTF-8 string which is the name of the device.</summary>
	public fixed byte DeviceName[(int)VK.MaxPhysicalDeviceNameSize];
	/// <summary>An array of <see cref="VK.UuidSize"/> <see langword="byte"/> values representing a universally unique identifier for the device.</summary>
	public fixed byte PipelineCacheUUID[(int)VK.UuidSize];
	/// <summary>The <see cref="VkPhysicalDeviceLimits"/> structure specifying device-specific limits of the physical device.</summary>
	public VkPhysicalDeviceLimits Limits;
	/// <summary>The <see cref="VkPhysicalDeviceSparseProperties"/> structure specifying various sparse related properties of the physical device.</summary>
	public VkPhysicalDeviceSparseProperties SparseProperties;
}
/// <summary>Structure specifying an extension properties.</summary>
public unsafe struct VkExtensionProperties
{
	/// <summary>An array of <see cref="VK.MaxExtensionNameSize"/> <see langword="byte"/>s containing a null-terminated UTF-8 string which is the name of the extension.</summary>
	public fixed byte ExtensionName[(int)VK.MaxExtensionNameSize];
	/// <summary>The version of this extension. It is an integer, incremented with backward compatible changes.</summary>
	public uint SpecVersion;
}
/// <summary>Structure specifying layer properties.</summary>
public unsafe struct VkLayerProperties
{
	/// <summary>An array of <see cref="VK.MaxExtensionNameSize"/> <see langword="byte"/>s containing a null-terminated UTF-8 string which is the name of the layer.</summary>
	public fixed byte LayerName[(int)VK.MaxExtensionNameSize];
	/// <summary>The Vulkan version the layer was written to.</summary>
	public uint SpecVersion;
	/// <summary>The version of this layer. It is an integer, increasing with backward compatible changes.</summary>
	public uint ImplementationVersion;
	/// <summary>An array of <see cref="VK.MaxDescriptionSize"/> <see langword="byte"/>s containing a null-terminated UTF-8 string which provides additional details that can be used by the application to identify the layer.</summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
}
/// <summary>Structure specifying application information.</summary>
public unsafe struct VkApplicationInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary><see langword="null"/> or is a pointer to a null-terminated UTF-8 string containing the name of the application.</summary>
	public byte* ApplicationName;
	/// <summary>An unsigned integer variable containing the developer-supplied version number of the application.</summary>
	public uint ApplicationVersion;
	/// <summary><see langword="null"/> or is a pointer to a null-terminated UTF-8 string containing the name of the engine (if any) used to create the application.</summary>
	public byte* EngineName;
	/// <summary>An unsigned integer variable containing the developer-supplied version number of the engine used to create the application.</summary>
	public uint EngineVersion;
	/// <summary>The highest version of Vulkan that the application is designed to use.</summary>
	public uint ApiVersion;
}
/// <summary>Structure containing callback function pointers for memory allocation.</summary>
public unsafe struct VkAllocationCallbacks
{
	/// <summary>A value to be interpreted by the implementation of the callbacks. When any of the callbacks in <see cref="VkAllocationCallbacks"/> are called, the Vulkan implementation will pass this value as the first parameter to the callback. This value can vary each time an allocator is passed into a command, even when the same object takes an allocator in multiple commands.</summary>
	public void* UserData;
	/// <summary>A pointer to an application-defined memory allocation function.</summary>
	public IntPtr Allocation;
	/// <summary>A pointer to an application-defined memory reallocation function.</summary>
	public IntPtr Reallocation;
	/// <summary>A pointer to an application-defined memory free function.</summary>
	public IntPtr Free;
	/// <summary>A pointer to an application-defined function that is called by the implementation when the implementation makes internal allocations.</summary>
	public IntPtr InternalAllocation;
	/// <summary>A pointer to an application-defined function that is called by the implementation when the implementation frees internal allocations.</summary>
	public IntPtr InternalFree;
}
/// <summary>Structure specifying parameters of a newly created device queue.</summary>
public unsafe struct VkDeviceQueueCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask indicating behavior of the queues.</summary>
	public VkDeviceQueueCreateFlags Flags;
	/// <summary>An unsigned integer indicating the index of the queue family in which to create the queues on this device.</summary>
	public uint QueueFamilyIndex;
	/// <summary>An unsigned integer specifying the number of queues to create in the queue family indicated by <see cref="QueueFamilyIndex"/>, and with the behavior specified by <see cref="Flags"/>.</summary>
	public uint QueueCount;
	/// <summary>A pointer to an array of <see cref="QueueCount"/> normalized floating point values, specifying priorities of work that will be submitted to each created queue.</summary>
	public float* QueuePriorities;
}
/// <summary>Structure specifying parameters of a newly created device.</summary>
public unsafe struct VkDeviceCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>Reserved for future use.</summary>
	public uint Flags;
	/// <summary>The unsigned integer size of the <see cref="QueueCreateInfos"/> array.</summary>
	public uint QueueCreateInfoCount;
	/// <summary>A pointer to an array of <see cref="VkDeviceQueueCreateInfo"/> structures describing the queues that are requested to be created along with the logical device.</summary>
	public VkDeviceQueueCreateInfo* QueueCreateInfos;
	/// <summary>Deprecated and ignored.</summary>
	public uint EnabledLayerCount;
	/// <summary>Deprecated and ignored.</summary>
	public byte** EnabledLayerNames;
	/// <summary>The number of device extensions to enable.</summary>
	public uint EnabledExtensionCount;
	/// <summary>A pointer to an array of <see cref="EnabledExtensionCount"/> null-terminated UTF-8 strings containing the names of extensions to enable for the created device.</summary>
	public byte** EnabledExtensionNames;
	/// <summary><see langword="null"/> or a pointer to a <see cref="VkPhysicalDeviceFeatures"/> structure containing boolean indicators of all the features to be enabled.</summary>
	public VkPhysicalDeviceFeatures* EnabledFeatures;
}
/// <summary>Structure specifying parameters of a newly created instance.</summary>
public unsafe struct VkInstanceCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkInstanceCreateFlags"/> indicating the behavior of the instance.</summary>
	public VkInstanceCreateFlags Flags;
	/// <summary><see langword="null"/> or a pointer to a <see cref="VkApplicationInfo"/> structure. If not <see langword="null"/>, this information helps implementations recognize behavior inherent to classes of applications.</summary>
	public VkApplicationInfo* ApplicationInfo;
	/// <summary>The number of global layers to enable.</summary>
	public uint EnabledLayerCount;
	/// <summary>A pointer to an array of <see cref="EnabledLayerCount"/> null-terminated UTF-8 strings containing the names of layers to enable for the created instance. The layers are loaded in the order they are listed in this array, with the first array element being the closest to the application, and the last array element being the closest to the driver.</summary>
	public byte** EnabledLayerNames;
	/// <summary>The number of global extensions to enable.</summary>
	public uint EnabledExtensionCount;
	/// <summary>A pointer to an array of <see cref="EnabledExtensionCount"/> null-terminated UTF-8 strings containing the names of extensions to enable.</summary>
	public byte** EnabledExtensionNames;
}
/// <summary>Structure providing information about a queue family.</summary>
public unsafe struct VkQueueFamilyProperties
{
	/// <summary>A bitmask of <see cref="VkQueueFlags "/> indicating capabilities of the queues in this queue family.</summary>
	public VkQueueFlags QueueFlags;
	/// <summary>The unsigned integer count of queues in this queue family. Each queue family must support at least one queue.</summary>
	public uint QueueCount;
	/// <summary>The unsigned integer count of meaningful bits in the timestamps written via <see cref="VK.CommandWriteTimestamp2"/> or <see cref="VK.CommandWriteTimestamp"/>. The valid range for the count is 36..64 bits, or a value of 0, indicating no support for timestamps. Bits outside the valid range are guaranteed to be zeros.</summary>
	public uint TimestampValidBits;
	/// <summary>The minimum granularity supported for image transfer operations on the queues in this queue family.</summary>
	public VkExtent3D MinImageTransferGranularity;
}
/// <summary>Structure specifying physical device memory properties.</summary>
public unsafe struct VkPhysicalDeviceMemoryProperties
{
	/// <summary>The number of valid elements in the MemoryTypes array.</summary>
	public uint MemoryTypeCount;
	/// <summary>The 1st element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_0;
	/// <summary>The 2nd element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_1;
	/// <summary>The 3rd element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_2;
	/// <summary>The 4th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_3;
	/// <summary>The 5th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_4;
	/// <summary>The 6th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_5;
	/// <summary>The 7th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_6;
	/// <summary>The 8th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_7;
	/// <summary>The 9th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_8;
	/// <summary>The 10th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_9;
	/// <summary>The 11th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_10;
	/// <summary>The 12th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_11;
	/// <summary>The 13th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_12;
	/// <summary>The 14th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_13;
	/// <summary>The 15th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_14;
	/// <summary>The 16th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_15;
	/// <summary>The 17th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_16;
	/// <summary>The 18th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_17;
	/// <summary>The 19th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_18;
	/// <summary>The 20th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_19;
	/// <summary>The 21st element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_20;
	/// <summary>The 22nd element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_21;
	/// <summary>The 23rd element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_22;
	/// <summary>The 24th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_23;
	/// <summary>The 25th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_24;
	/// <summary>The 26th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_25;
	/// <summary>The 27th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_26;
	/// <summary>The 28th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_27;
	/// <summary>The 29th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_28;
	/// <summary>The 30th element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_29;
	/// <summary>The 31st element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_30;
	/// <summary>The 32nd element in an array of <see cref="VK.MaxMemoryTypes"/> <see cref="VkMemoryType"/> structures describing the memory types that can be used to access memory allocated from the heaps specified by MemoryHeaps.</summary>
	public VkMemoryType MemoryTypes_31;
	/// <summary>The number of valid elements in the MemoryHeaps array.</summary>
	public uint MemoryHeapCount;
	/// <summary>The 1st element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_0;
	/// <summary>The 2nd element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_1;
	/// <summary>The 3rd element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_2;
	/// <summary>The 4th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_3;
	/// <summary>The 5th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_4;
	/// <summary>The 6th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_5;
	/// <summary>The 7th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_6;
	/// <summary>The 8th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_7;
	/// <summary>The 9th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_8;
	/// <summary>The 10th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_9;
	/// <summary>The 11th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_10;
	/// <summary>The 12th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_11;
	/// <summary>The 13th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_12;
	/// <summary>The 14th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_13;
	/// <summary>The 15th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_14;
	/// <summary>The 16th element in an array of <see cref="VK.MaxMemoryHeaps"/> <see cref="VkMemoryHeap"/> structures describing the memory heaps from which memory can be allocated.</summary>
	public VkMemoryHeap MemoryHeaps_15;
}
/// <summary>Structure containing parameters of a memory allocation.</summary>
public unsafe struct VkMemoryAllocateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>The size of the allocation in bytes.</summary>
	public VkDeviceSize AllocationSize;
	/// <summary>An index identifying a memory type from the MemoryTypes array of the <see cref="VkPhysicalDeviceMemoryProperties"/> structure.</summary>
	public uint MemoryTypeIndex;
}
/// <summary>Structure specifying memory requirements.</summary>
public unsafe struct VkMemoryRequirements
{
	/// <summary>The size, in <see langword="byte"/>s, of the memory allocation required for the resource.</summary>
	public VkDeviceSize Size;
	/// <summary>The alignment, in <see langword="byte"/>s, of the offset within the allocation required for the resource.</summary>
	public VkDeviceSize Alignment;
	/// <summary>Contains one bit set for every supported memory type for the resource. Bit i is set if and only if the memory type i in the <see cref="VkPhysicalDeviceMemoryProperties"/> structure for the physical device is supported for the resource.</summary>
	public uint MemoryTypeBits;
}
/// <summary>Structure specifying sparse image format properties.</summary>
public unsafe struct VkSparseImageFormatProperties
{
	/// <summary>A bitmask <see cref="VkImageAspectFlags"/> specifying which aspects of the image the properties apply to.</summary>
	public VkImageAspectFlags AspectMask;
	/// <summary>The width, height, and depth of the sparse image block in texels or compressed texel blocks.</summary>
	public VkExtent3D ImageGranularity;
	/// <summary>A bitmask of <see cref="VkSparseImageFormatFlags "/> specifying additional information about the sparse resource.</summary>
	public VkSparseImageFormatFlags Flags;
}
/// <summary>Structure specifying sparse image memory requirements.</summary>
public unsafe struct VkSparseImageMemoryRequirements
{
	/// <summary>A <see cref="VkSparseImageFormatProperties"/> structure specifying properties of the image format.</summary>
	public VkSparseImageFormatProperties FormatProperties;
	/// <summary>The first mip level at which image subresources are included in the mip tail region.</summary>
	public uint ImageMipTailFirstLod;
	/// <summary>The memory size (in <see langword="byte"/>s) of the mip tail region. If <see cref="FormatProperties"/>.Flags contains <see cref="VkSparseImageFormatFlags.SingleMiptail"/>, this is the size of the whole mip tail, otherwise this is the size of the mip tail of a single array layer. This value is guaranteed to be a multiple of the sparse block size in <see langword="byte"/>s.</summary>
	public VkDeviceSize ImageMipTailSize;
	/// <summary>The opaque memory offset used with <see cref="VkSparseImageOpaqueMemoryBindInfo"/> to bind the mip tail region(s).</summary>
	public VkDeviceSize ImageMipTailOffset;
	/// <summary>The offset stride between each array-layer’s mip tail, if <see cref="FormatProperties"/>.Flags does not contain <see cref="VkSparseImageFormatFlags.SingleMiptail"/> (otherwise the value is undefined).</summary>
	public VkDeviceSize ImageMipTailStride;
}
/// <summary>Structure specifying memory type.</summary>
public unsafe struct VkMemoryType
{
	/// <summary>A bitmask of <see cref="VkMemoryPropertyFlags"/> of properties for this memory type.</summary>
	public VkMemoryPropertyFlags PropertyFlags;
	/// <summary>Describes which memory heap this memory type corresponds to, and must be less than <see cref="VkPhysicalDeviceMemoryProperties.MemoryHeapCount"/>.</summary>
	public uint HeapIndex;
}
/// <summary>Structure specifying a memory heap.</summary>
public unsafe struct VkMemoryHeap
{
	/// <summary>The total memory size in <see langword="byte"/>s in the heap.</summary>
	public VkDeviceSize Size;
	/// <summary>A bitmask of <see cref="VkMemoryHeapFlags"/> specifying attribute flags for the heap.</summary>
	public VkMemoryHeapFlags Flags;
}
/// <summary>Structure specifying a mapped memory range.</summary>
public unsafe struct VkMappedMemoryRange
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>The memory object to which this range belongs.</summary>
	public VkDeviceMemory Memory;
	/// <summary>The zero-based <see langword="byte"/> offset from the beginning of the memory object.</summary>
	public VkDeviceSize Offset;
	/// <summary>Either the size of range, or <see cref="VK.WholeSize"/> to affect the range from offset to the end of the current mapping of the allocation.</summary>
	public VkDeviceSize Size;
}
/// <summary>Structure specifying image format properties.</summary>
public unsafe struct VkFormatProperties
{
	/// <summary>A bitmask of <see cref="VkFormatFeatureFlags"/> specifying features supported by images created with a tiling parameter of <see cref="VkImageTiling.Linear"/>.</summary>
	public VkFormatFeatureFlags LinearTilingFeatures;
	/// <summary>A bitmask of <see cref="VkFormatFeatureFlags"/> specifying features supported by images created with a tiling parameter of <see cref="VkImageTiling.Optimal"/>.</summary>
	public VkFormatFeatureFlags OptimalTilingFeatures;
	/// <summary>A bitmask of <see cref="VkFormatFeatureFlags"/> specifying features supported by buffers.</summary>
	public VkFormatFeatureFlags BufferFeatures;
}
/// <summary>Structure specifying an image format properties.</summary>
public unsafe struct VkImageFormatProperties
{
	/// <summary>The maximum image dimensions.</summary>
	public VkExtent3D MaxExtent;
	/// <summary>The maximum number of mipmap levels.</summary>
	public uint MaxMipLevels;
	/// <summary>The maximum number of array layers.</summary>
	public uint MaxArrayLayers;
	/// <summary>A bitmask of <see cref="VkSampleCountFlags"/> specifying all the supported sample counts for this image.</summary>
	public VkSampleCountFlags SampleCounts;
	/// <summary>An upper bound on the total image size in <see langword="byte"/>s, inclusive of all image subresources.</summary>
	public VkDeviceSize MaxResourceSize;
}
/// <summary>Structure specifying descriptor buffer information.</summary>
public unsafe struct VkDescriptorBufferInfo
{
	/// <summary><see cref="VkBuffer.Null"/> or the buffer resource.</summary>
	public VkBuffer Buffer;
	/// <summary>The offset in <see langword="byte"/>s from the start of buffer. Access to buffer memory via this descriptor uses addressing that is relative to this starting offset.</summary>
	public VkDeviceSize Offset;
	/// <summary>The size in <see langword="byte"/>s that is used for this descriptor update, or <see cref="VK.WholeSize"/> to use the range from <see cref="Offset"/> to the end of the buffer.</summary>
	public VkDeviceSize Range;
}
/// <summary>Structure specifying descriptor image information.</summary>
public unsafe struct VkDescriptorImageInfo
{
	/// <summary>A sampler handle that is used in descriptor updates for types <see cref="VkDescriptorType.Sampler"/> and <see cref="VkDescriptorType.CombinedImageSampler"/> if the binding being updated does not use immutable samplers.</summary>
	public VkSampler Sampler;
	/// <summary><see cref="VkImageView.Null"/> or an image view handle, and is used in descriptor updates for types <see cref="VkDescriptorType.SampledImage"/>, <see cref="VkDescriptorType.StorageImage"/>, <see cref="VkDescriptorType.CombinedImageSmapler"/>, and <see cref="VkDescriptorType.ImputAttachment"/>.</summary>
	public VkImageView ImageView;
	/// <summary>The layout that the image subresources accessible from <see cref="ImageView"/> will be in at the time this descriptor is accessed. <see cref="ImageLayout"/> is used in descriptor updates for types <see cref="VkDescriptorType.SampledImage"/>, <see cref="VkDescriptorType.StorageImage"/>, <see cref="VkDescriptorType.CombinedImageSmapler"/>, and <see cref="VkDescriptorType.ImputAttachment"/>.</summary>
	public VkImageLayout ImageLayout;
}
/// <summary>Structure specifying the parameters of a descriptor set write operation.</summary>
public unsafe struct VkWriteDescriptorSet
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>The destination descriptor set to update.</summary>
	public VkDescriptorSet DestinationSet;
	/// <summary>The descriptor binding within that set.</summary>
	public uint DestinationBinding;
	/// <summary>The starting element in that array. If the descriptor binding identified by <see cref="DestinationSet"/> and <see cref="DestinationBinding"/> has a descriptor type of <see cref="VkDescriptorType.InlineUniformBlock"> then <see cref="DestinationArrayElement"/> specifies the starting <see langword="byte"/> offset within the binding.</summary>
	public uint DestinationArrayElement;
	/// <summary>The number of descriptors to update. If the descriptor binding identified by <see cref="DestinationSet"/> and <see cref="DestinationBinding"/> has a descriptor type of <see cref="VkDescriptorType.InlineUniformBlock">, then <see cref="DescriptorCount"/> specifies the number of <see langword="byte"/>s to update.</summary>
	public uint DescriptorCount;
	/// <summary>A <see cref="VkDescriptorType"> specifying the type of each descriptor in <see cref="ImageInfo"/>, <see cref="BufferInfo"/>, or <see cref="TexelBufferView"/>.</summary>
	public VkDescriptorType DescriptorType;
	/// <summary>A pointer to an array of <see cref="VkDescriptorImageInfo"/> structures or is ignored.</summary>
	public VkDescriptorImageInfo* ImageInfo;
	/// <summary>A pointer to an array of <see cref="VkDescriptorBufferInfo"/> structures or is ignored.</summary>
	public VkDescriptorBufferInfo* BufferInfo;
	/// <summary>A pointer to an array of <see cref="VkBufferView"/> handles or is ignored.</summary>
	public VkBufferView* TexelBufferView;
}
/// <summary>Structure specifying a copy descriptor set operation.</summary>
public unsafe struct VkCopyDescriptorSet
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>The source set.</summary>
	public VkDescriptorSet SourceSet;
	/// <summary>The source binding.</summary>
	public uint SourceBinding;
	/// <summary>The source array element.</summary>
	public uint SourceArrayElement;
	/// <summary>The destination set.</summary>
	public VkDescriptorSet DestinationSet;
	/// <summary>The destination binding.</summary>
	public uint DestinationBinding;
	/// <summary>The destination array element.</summary>
	public uint DestinationArrayElement;
	/// <summary>The number of descriptors to copy from the source to destinatio</summary>
	public uint DescriptorCount;
}
/// <summary>Structure specifying the parameters of a newly created buffer object.</summary>
public unsafe struct VkBufferCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkBufferCreateFlags"/> specifying additional parameters of the buffer.</summary>
	public VkBufferCreateFlags Flags;
	/// <summary>The size in <see langword="byte"/>s of the buffer to be created.</summary>
	public VkDeviceSize Size;
	/// <summary>A bitmask of <see cref="VkBufferUsageFlags"/> specifying allowed usages of the buffer.</summary>
	public VkBufferUsageFlags Usage;
	/// <summary>A <see cref="VkSharingMode"/> value specifying the sharing mode of the buffer when it will be accessed by multiple queue families.</summary>
	public VkSharingMode SharingMode;
	/// <summary>The number of entries in the <see cref="QueueFamilyIndices"/> array.</summary>
	public uint QueueFamilyIndexCount;
	/// <summary>A pointer to an array of queue families that will access this buffer. It is ignored if <see cref="SharingMode"/> is not <see cref="VkSharingMode.Concurrent"/>.</summary>
	public uint* QueueFamilyIndices;
}
/// <summary>Structure specifying parameters of a newly created buffer view.</summary>
public unsafe struct VkBufferViewCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>Reserved for future use.</summary>
	public uint Flags;
	/// <summary>A <see cref="VkBuffer"/> on which the view will be created.</summary>
	public VkBuffer Buffer;
	/// <summary>A <see cref="VkFormat"/> describing the format of the data elements in the buffer.</summary>
	public VkFormat Format;
	/// <summary>An offset in <see langword="byte"/>s from the base address of the buffer. Accesses to the buffer view from shaders use addressing that is relative to this starting offset.</summary>
	public VkDeviceSize Offset;
	/// <summary>The size in <see langword="byte"/>s of the buffer view. If range is equal to <see cref="VK.WholeSize"/>, the range from offset to the end of the buffer is used. If <see cref="VK.WholeSize"/> is used and the remaining size of the buffer is not a multiple of the texel block size of <see cref="Format"/>, the nearest smaller multiple is used.</summary>
	public VkDeviceSize Range;
}
/// <summary>Structure specifying an image subresource.</summary>
public unsafe struct VkImageSubresource
{
	/// <summary>A <see cref="VkImageAspectFlags"/> value selecting the image aspect.</summary>
	public VkImageAspectFlags AspectMask;
	/// <summary>The mipmap level.</summary>
	public uint MipLevel;
	/// <summary>The array layer.</summary>
	public uint ArrayLayer;
	public VkImageSubresource(VkImageAspectFlags aspectMask, uint mipLevel, uint arrayLayer)
	{
		AspectMask = aspectMask;
		MipLevel = mipLevel;
		ArrayLayer = arrayLayer;
	}
}
/// <summary>Structure specifying an image subresource layers.</summary>
public unsafe struct VkImageSubresourceLayers
{
	/// <summary>A combination of <see cref="VkImageAspectFlags"/>, selecting the color, depth and/or stencil aspects to be copied.</summary>
	public VkImageAspectFlags AspectMask;
	/// <summary>The mipmap level to copy</summary>
	public uint MipLevel;
	/// <summary>The starting layer to copy.</summary>
	public uint BaseArrayLayer;
	/// <summary>The number of layers to copy.</summary>
	public uint LayerCount;
	public VkImageSubresourceLayers(VkImageAspectFlags aspectMask, uint mipLevel, uint baseArrayLayer, uint layerCount)
	{
		AspectMask = aspectMask;
		MipLevel = mipLevel;
		BaseArrayLayer = baseArrayLayer;
		LayerCount = layerCount;
	}
}
/// <summary>Structure specifying an image subresource range.</summary>
public unsafe struct VkImageSubresourceRange
{
	/// <summary>A bitmask of <see cref="VkImageAspectFlags"/> specifying which aspect(s) of the image are included in the view.</summary>
	public VkImageAspectFlags AspectMask;
	/// <summary>The first mipmap level accessible to the view.</summary>
	public uint BaseMipLevel;
	/// <summary>The number of mipmap levels (starting from <see cref="BaseMipLevel"/>) accessible to the view.</summary>
	public uint LevelCount;
	/// <summary>The first array layer accessible to the view.</summary>
	public uint BaseArrayLayer;
	/// <summary>The number of array layers (starting from <see cref="BaseArrayLayer"/>) accessible to the view.</summary>
	public uint LayerCount;
	public VkImageSubresourceRange(VkImageAspectFlags aspectMask, uint baseMipLevel, uint levelCount, uint baseArrayLayer, uint layerCount)
	{
		AspectMask = aspectMask;
		BaseMipLevel = baseMipLevel;
		LevelCount = levelCount;
		BaseArrayLayer = baseArrayLayer;
		LayerCount = layerCount;
	}
}
/// <summary>Structure specifying a global memory barrier.</summary>
public unsafe struct VkMemoryBarrier
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a source access mask.</summary>
	public VkAccessFlags SourceAccessMask;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a destination access mask.</summary>
	public VkAccessFlags DestinationAccessMask;
}
/// <summary>Structure specifying a buffer memory barrier.</summary>
public unsafe struct VkBufferMemoryBarrier
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a source access mask.</summary>
	public VkAccessFlags SourceAccessMask;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a destination access mask.</summary>
	public VkAccessFlags DestinationAccessMask;
	/// <summary>The source queue family for a queue family ownership transfer.</summary>
	public uint SourceQueueFamilyIndex;
	/// <summary>The destination queue family for a queue family ownership transfer.</summary>
	public uint DestinationQueueFamilyIndex;
	/// <summary>A handle to the buffer whose backing memory is affected by the barrier.</summary>
	public VkBuffer Buffer;
	/// <summary>An offset in <see langword="byte"/>s into the backing memory for <see cref="Buffer"/>; this is relative to the base offset as bound to the buffer.</summary>
	public VkDeviceSize Offset;
	/// <summary>The size in <see langword="byte"/>s of the affected area of backing memory for <see cref="Buffer"/>, or <see cref="VK.WholeSize"/> to use the range from <see cref="Offset"/> to the end of the buffer.</summary>
	public VkDeviceSize Size;
}
/// <summary>Structure specifying the parameters of an image memory barrier.</summary>
public unsafe struct VkImageMemoryBarrier
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a source access mask.</summary>
	public VkAccessFlags SourceAccessMask;
	/// <summary>A bitmask of <see cref="VkAccessFlags"/> specifying a destination access mask.</summary>
	public VkAccessFlags DestinationAccessMask;
	/// <summary>The old layout in an image layout transition.</summary>
	public VkImageLayout OldLayout;
	/// <summary>The new layout in an image layout transition.</summary>
	public VkImageLayout NewLayout;
	/// <summary>The source queue family for a queue family ownership transfer.</summary>
	public uint SourceQueueFamilyIndex;
	/// <summary>The destination queue family for a queue family ownership transfer.</summary>
	public uint DestinationQueueFamilyIndex;
	/// <summary>A handle to the image affected by this barrier.</summary>
	public VkImage Image;
	/// <summary>The image subresource range within image that is affected by this barrier.</summary>
	public VkImageSubresourceRange SubresourceRange;
}
/// <summary>Structure specifying the parameters of a newly created image object.</summary>
public unsafe struct VkImageCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkImageCreateFlags"/> describing additional parameters of the image.</summary>
	public VkImageCreateFlags Flags;
	/// <summary>A <see cref="VkImageType"/> value specifying the basic dimensionality of the image. Layers in array textures do not count as a dimension for the purposes of the image type.</summary>
	public VkImageType ImageType;
	/// <summary>A <see cref="VkFormat"/> describing the format and type of the texel blocks that will be contained in the image.</summary>
	public VkFormat Format;
	/// <summary>A <see cref="VkExtent3D"/> describing the number of data elements in each dimension of the base level.</summary>
	public VkExtent3D Extent;
	/// <summary>he number of levels of detail available for minified sampling of the image.</summary>
	public uint MipLevels;
	/// <summary>The number of layers in the image.</summary>
	public uint ArrayLayers;
	/// <summary>A <see cref="VkSampleCountFlags"/> value specifying the number of samples per texel.</summary>
	public VkSampleCountFlags Samples;
	/// <summary>A <see cref="VkImageTiling"/> value specifying the tiling arrangement of the texel blocks in memory.</summary>
	public VkImageTiling Tiling;
	/// <summary>A bitmask of <see cref="VkImageUsageFlags"/> describing the intended usage of the image.</summary>
	public VkImageUsageFlags Usage;
	/// <summary>A <see cref="VkSharingMode"/> value specifying the sharing mode of the image when it will be accessed by multiple queue families.</summary>
	public VkSharingMode SharingMode;
	/// <summary>The number of entries in the <see cref="QueueFamilyIndices"/> array.</summary>
	public uint QueueFamilyIndexCount;
	/// <summary>A pointer to an array of queue families that will access this image. It is ignored if <see cref="SharingMode"/> is not <see cref="VkSharingMode.Concurrent"/>.</summary>
	public uint* QueueFamilyIndices;
	/// <summary>A <see cref="VkImageLayout"/> value specifying the initial <see cref="VkImageLayout"/> of all image subresources of the image.</summary>
	public VkImageLayout InitialLayout;
}
/// <summary>Structure specifying subresource layout.</summary>
public unsafe struct VkSubresourceLayout
{
	/// <summary>The <see langword="byte"/> offset from the start of the image or the plane where the image subresource begins.</summary>
	public VkDeviceSize Offset;
	/// <summary>The size in <see langword="byte"/>s of the image subresource. <see cref="Size"/> includes any extra memory that is required based on <see cref="RowPitch"/>.</summary>
	public VkDeviceSize Size;
	/// <summary>The number of <see langword="byte"/>s between each row of texels in an image.</summary>
	public VkDeviceSize RowPitch;
	/// <summary>The number of <see langword="byte"/>s between each array layer of an image.</summary>
	public VkDeviceSize ArrayPitch;
	/// <summary>The number of <see langword="byte"/>s between each slice of 3D image.</summary>
	public VkDeviceSize DepthPitch;
}
/// <summary>Structure specifying parameters of a newly created image view.</summary>
public unsafe struct VkImageViewCreateInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>A bitmask of <see cref="VkImageViewCreateFlags"/> describing additional parameters of the image view.</summary>
	public VkImageViewCreateFlags Flags;
	/// <summary>A <see cref="VkImage"/> on which the view will be created.</summary>
	public VkImage Image;
	/// <summary>A <see cref="VkImageViewType"/> value specifying the type of the image view.</summary>
	public VkImageViewType ViewType;
	/// <summary>A <see cref="VkFormat"/> describing the format and type used to interpret texel blocks in the image.</summary>
	public VkFormat Format;
	/// <summary>A <see cref="VkComponentMapping"/> structure specifying a remapping of color components (or of depth or stencil components after they have been converted into color components).</summary>
	public VkComponentMapping Components;
	/// <summary>A <see cref="VkImageSubresourceRange"/> structure selecting the set of mipmap levels and array layers to be accessible to the view.</summary>
	public VkImageSubresourceRange SubresourceRange;
}
/// <summary>Structure specifying a buffer copy operation.</summary>
public unsafe struct VkBufferCopy
{
	/// <summary>The starting offset in <see langword="byte"/>s from the start of SourceBuffer.</summary>
	public VkDeviceSize SourceOffset;
	/// <summary>The starting offset in <see langword="byte"/>s from the start of DestinationBuffer.</summary>
	public VkDeviceSize DestinationOffset;
	/// <summary>The number of <see langword="byte"/>s to copy.</summary>
	public VkDeviceSize Size;
}
/// <summary>Structure specifying a sparse memory bind operation.</summary>
public unsafe struct VkSparseMemoryBind
{
	/// <summary>The offset into the resource.</summary>
	public VkDeviceSize ResourceOffset;
	/// <summary>The size of the memory region to be bound.</summary>
	public VkDeviceSize Size;
	/// <summary>The <see cref="VkDeviceMemory"/> object that the range of the resource is bound to. If <see cref="Memory"/> is <see cref="VkDeviceMemory.Null"/>, the range is unbound.</summary>
	public VkDeviceMemory Memory;
	/// <summary>The offset into the <see cref="VkDeviceMemory"/> object to bind the resource range to. If <see cref="Memory"/> is <see cref="VkDeviceMemory.Null"/>, this value is ignored.</summary>
	public VkDeviceSize MemoryOffset;
	/// <summary>A bitmask of <see cref="VkSparseMemoryBindFlags"/> specifying usage of the binding operation.</summary>
	public VkSparseMemoryBindFlags Flags;
}
/// <summary>Structure specifying sparse image memory bind.</summary>
public unsafe struct VkSparseImageMemoryBind
{
	/// <summary>The image aspect and region of interest in the image.</summary>
	public VkImageSubresource Subresource;
	/// <summary>The coordinates of the first texel within the image subresource to bind.</summary>
	public VkOffset3D Offset;
	/// <summary>The size in texels of the region within the image subresource to bind. The extent must be a multiple of the sparse image block dimensions, except when binding sparse image blocks along the edge of an image subresource it can instead be such that any coordinate of <see cref="Offset"/> + <see cref="Extent"/> equals the corresponding dimensions of the image subresource.</summary>
	public VkExtent3D Extent;
	/// <summary>The <see cref="VkDeviceMemory"/> object that the sparse image blocks of the image are bound to. If <see cref="Memory"/> is <see cref="VkDeviceMemory.Null"/>, the sparse image blocks are unbound.</summary>
	public VkDeviceMemory Memory;
	/// <summary>An offset into <see cref="VkDeviceMemory"/> object. If <see cref="Memory"/> is <see cref="VkDeviceMemory.Null"/>, this value is ignored.</summary>
	public VkDeviceSize MemoryOffset;
	/// <summary>The sparse memory binding flags.</summary>
	public VkSparseMemoryBindFlags Flags;
}
/// <summary>Structure specifying a sparse buffer memory bind operation.</summary>
public unsafe struct VkSparseBufferMemoryBindInfo
{
	/// <summary>The <see cref="VkBuffer"/> object to be bound.</summary>
	public VkBuffer Buffer;
	/// <summary>The number of <see cref="VkSparseMemoryBind"/> structures in the <see cref="Binds"/> array.</summary>
	public uint BindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseMemoryBind"/> structures.</summary>
	public VkSparseMemoryBind* Binds;
}
/// <summary>Structure specifying sparse image opaque memory bind information.</summary>
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
	/// <summary>The <see cref="VkImage"/> object to be bound.</summary>
	public VkImage Image;
	/// <summary>The number of <see cref="VkSparseMemoryBind"/> structures in the <see cref="Binds"/> array.</summary>
	public uint BindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseMemoryBind"/> structures.</summary>
	public VkSparseMemoryBind* Binds;
}
/// <summary>Structure specifying sparse image memory bind information.</summary>
public unsafe struct VkSparseImageMemoryBindInfo
{
	/// <summary>The <see cref="VkImage"/> object to be bound</summary>
	public VkImage Image;
	/// <summary>The number of <see cref="VkSparseImageMemoryBind"/> structures in <see cref="Binds"/> array</summary>
	public uint BindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseImageMemoryBind "/> structures</summary>
	public VkSparseImageMemoryBind* Binds;
}
/// <summary>Structure specifying a sparse binding operation.</summary>
public unsafe struct VkBindSparseInfo
{
	/// <summary>The type of this structure.</summary>
	public VkStructureType SType;
	/// <summary><see langword="null"/> or a pointer to a structure extending this structure.</summary>
	public void* Next;
	/// <summary>The number of semaphores upon which to wait before executing the sparse binding operations for the batch.</summary>
	public uint WaitSemaphoreCount;
	/// <summary>A pointer to an array of semaphores upon which to wait on before the sparse binding operations for this batch begin execution.</summary>
	public VkSemaphore* WaitSemaphores;
	/// <summary>The number of sparse buffer bindings to perform in the batch.</summary>
	public uint BufferBindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseBufferMemoryBindInfo"/> structures.</summary>
	public VkSparseBufferMemoryBindInfo* BufferBinds;
	/// <summary>The number of opaque sparse image bindings to perform.</summary>
	public uint ImageOpaqueBindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseImageOpaqueMemoryBindInfo"/> structures, indicating opaque sparse image bindings to perform.</summary>
	public VkSparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;
	/// <summary>The number of sparse image bindings to perform.</summary>
	public uint ImageBindCount;
	/// <summary>A pointer to an array of <see cref="VkSparseImageMemoryBindInfo"/> structures, indicating sparse image bindings to perform.</summary>
	public VkSparseImageMemoryBindInfo* ImageBinds;
	/// <summary>The number of semaphores to be signaled once the sparse binding operations specified by the structure have completed execution.</summary>
	public uint SignalSemaphoreCount;
	/// <summary>A pointer to an array of semaphores which will be signaled when the sparse binding operations for this batch have completed execution.</summary>
	public VkSemaphore* SignalSemaphores;
}
/// <summary>Structure specifying an image copy operation.</summary>
public unsafe struct VkImageCopy
{
	/// <summary>A <see cref="VkImageSubresourceLayers"/> structure specifying the image subresources of the images used for the source image data.</summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary>The initial x, y, and z offsets in texels of the sub-regions of the source image data.</summary>
	public VkOffset3D SourceOffset;
	/// <summary>A <see cref="VkImageSubresourceLayers"/> structure specifying the image subresources of the images used for the destination image data.</summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary>The initial x, y, and z offsets in texels of the sub-regions of the destination image data.</summary>
	public VkOffset3D DestinationOffset;
	/// <summary>The size in texels of the image to copy in width, height and depth.</summary>
	public VkExtent3D Extent;
}
/// <summary>Structure specifying an image blit operation.</summary>
public unsafe struct VkImageBlit
{
	/// <summary>The subresource to blit from.</summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary>The 1st <see cref="VkOffset3D"/> structure specifying the bounds of the source region within <see cref="SourceSubresource"/>.</summary>
	public VkOffset3D SourceOffsets_0;
	/// <summary>The 2nd <see cref="VkOffset3D"/> structure specifying the bounds of the source region within <see cref="SourceSubresource"/>.</summary>
	public VkOffset3D SourceOffsets_1;
	/// <summary>The subresource to blit into.</summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary>The 1st <see cref="VkOffset3D"/> structure specifying the bounds of the destination region within <see cref="DestinationSubresource"/>.</summary>
	public VkOffset3D DestinationOffsets_0;
	/// <summary>The 2nd <see cref="VkOffset3D"/> structure specifying the bounds of the destination region within <see cref="DestinationSubresource"/>.</summary>
	public VkOffset3D DestinationOffsets_1;
}
/// <summary>Structure specifying a buffer image copy operation.</summary>
public unsafe struct VkBufferImageCopy
{
	/// <summary>The offset in <see langword="byte"/>s from the start of the buffer object where the image data is copied from or to.</summary>
	public VkDeviceSize BufferOffset;
	/// <summary>Specify in texels a subregion of a larger two- or three-dimensional image in buffer memory, and control the addressing calculations.</summary>
	public uint BufferRowLength;
	/// <summary>Specify in texels a subregion of a larger two- or three-dimensional image in buffer memory, and control the addressing calculations.</summary>
	public uint BufferImageHeight;
	/// <summary>A <see cref="VkImageSubresourceLayers"/> used to specify the specific image subresources of the image used for the source or destination image data.</summary>
	public VkImageSubresourceLayers ImageSubresource;
	/// <summary>The initial x, y, z offsets in texels of the sub-region of the source or destination image data.</summary>
	public VkOffset3D ImageOffset;
	/// <summary>The size in texels of the image to copy in width, height and depth.</summary>
	public VkExtent3D ImageExtent;
}
/// <summary>Structure specifying an image resolve operation.</summary>
public unsafe struct VkImageResolve
{
	/// <summary>A <see cref="VkImageSubresourceLayers"/> structures specifying the image subresources of the images used for the source image data.</summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary>The initial x, y, and z offsets in texels of the sub-regions of the source image data.</summary>
	public VkOffset3D SourceOffset;
	/// <summary>A <see cref="VkImageSubresourceLayers"/> structures specifying the image subresources of the images used for the destination image data.</summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary>The initial x, y, and z offsets in texels of the sub-regions of the destination image data.</summary>
	public VkOffset3D DestinationOffset;
	/// <summary>The size in texels of the source image to resolve in width, height and depth.</summary>
	public VkExtent3D Extent;
}
/// <summary></summary>
public unsafe struct VkShaderModuleCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public nuint CodeSize;
	/// <summary></summary>
	public uint* Code;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetLayoutBinding
{
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public VkDescriptorType DescriptorType;
	/// <summary></summary>
	public uint DescriptorCount;
	/// <summary></summary>
	public VkShaderStageFlags StageFlags;
	/// <summary></summary>
	public VkSampler* ImmutableSamplers;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDescriptorSetLayoutCreateFlags Flags;
	/// <summary></summary>
	public uint BindingCount;
	/// <summary></summary>
	public VkDescriptorSetLayoutBinding* Bindings;
}
/// <summary></summary>
public unsafe struct VkDescriptorPoolSize
{
	/// <summary></summary>
	public VkDescriptorType Type;
	/// <summary></summary>
	public uint DescriptorCount;
}
/// <summary></summary>
public unsafe struct VkDescriptorPoolCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDescriptorPoolCreateFlags Flags;
	/// <summary></summary>
	public uint MaxSets;
	/// <summary></summary>
	public uint PoolSizeCount;
	/// <summary></summary>
	public VkDescriptorPoolSize* PoolSizes;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDescriptorPool DescriptorPool;
	/// <summary></summary>
	public uint DescriptorSetCount;
	/// <summary></summary>
	public VkDescriptorSetLayout* SetLayouts;
}
/// <summary></summary>
public unsafe struct VkSpecializationMapEntry
{
	/// <summary></summary>
	public uint ConstantID;
	/// <summary></summary>
	public uint Offset;
	/// <summary></summary>
	public nuint Size;
}
/// <summary></summary>
public unsafe struct VkSpecializationInfo
{
	/// <summary></summary>
	public uint MapEntryCount;
	/// <summary></summary>
	public VkSpecializationMapEntry* MapEntries;
	/// <summary></summary>
	public nuint DataSize;
	/// <summary></summary>
	public void* Data;
}
/// <summary></summary>
public unsafe struct VkPipelineShaderStageCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineShaderStageCreateFlags Flags;
	/// <summary></summary>
	public VkShaderStageFlags Stage;
	/// <summary></summary>
	public VkShaderModule Module;
	/// <summary></summary>
	public byte* Name;
	/// <summary></summary>
	public VkSpecializationInfo* SpecializationInfo;
}
/// <summary></summary>
public unsafe struct VkComputePipelineCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCreateFlags Flags;
	/// <summary></summary>
	public VkPipelineShaderStageCreateInfo Stage;
	/// <summary></summary>
	public VkPipelineLayout Layout;
	/// <summary></summary>
	public VkPipeline BasePipelineHandle;
	/// <summary></summary>
	public int BasePipelineIndex;
}
/// <summary></summary>
public unsafe struct VkVertexInputBindingDescription
{
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public uint Stride;
	/// <summary></summary>
	public VkVertexInputRate InputRate;
}
/// <summary></summary>
public unsafe struct VkVertexInputAttributeDescription
{
	/// <summary></summary>
	public uint Location;
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public uint Offset;
}
/// <summary></summary>
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint VertexBindingDescriptionCount;
	/// <summary></summary>
	public VkVertexInputBindingDescription* VertexBindingDescriptions;
	/// <summary></summary>
	public uint VertexAttributeDescriptionCount;
	/// <summary></summary>
	public VkVertexInputAttributeDescription* VertexAttributeDescriptions;
}
/// <summary></summary>
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkPrimitiveTopology Topology;
	/// <summary></summary>
	public VkBool32 PrimitiveRestartEnable;
}
/// <summary></summary>
public unsafe struct VkPipelineTessellationStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint PatchControlPoints;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint ViewportCount;
	/// <summary></summary>
	public VkViewport* Viewports;
	/// <summary></summary>
	public uint ScissorCount;
	/// <summary></summary>
	public VkRect2D* Scissors;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkBool32 DepthClampEnable;
	/// <summary></summary>
	public VkBool32 RasterizerDiscardEnable;
	/// <summary></summary>
	public VkPolygonMode PolygonMode;
	/// <summary></summary>
	public VkCullModeFlags CullMode;
	/// <summary></summary>
	public VkFrontFace FrontFace;
	/// <summary></summary>
	public VkBool32 DepthBiasEnable;
	/// <summary></summary>
	public float DepthBiasConstantFactor;
	/// <summary></summary>
	public float DepthBiasClamp;
	/// <summary></summary>
	public float DepthBiasSlopeFactor;
	/// <summary></summary>
	public float LineWidth;
}
/// <summary></summary>
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkSampleCountFlags RasterizationSamples;
	/// <summary></summary>
	public VkBool32 SampleShadingEnable;
	/// <summary></summary>
	public float MinSampleShading;
	/// <summary></summary>
	public uint* SampleMask;
	/// <summary></summary>
	public VkBool32 AlphaToCoverageEnable;
	/// <summary></summary>
	public VkBool32 AlphaToOneEnable;
}
/// <summary></summary>
public unsafe struct VkPipelineColorBlendAttachmentState
{
	/// <summary></summary>
	public VkBool32 BlendEnable;
	/// <summary></summary>
	public VkBlendFactor SourceColorBlendFactor;
	/// <summary></summary>
	public VkBlendFactor DestinationColorBlendFactor;
	/// <summary></summary>
	public VkBlendOp ColorBlendOp;
	/// <summary></summary>
	public VkBlendFactor SourceAlphaBlendFactor;
	/// <summary></summary>
	public VkBlendFactor DestinationAlphaBlendFactor;
	/// <summary></summary>
	public VkBlendOp AlphaBlendOp;
	/// <summary></summary>
	public VkColorComponentFlags ColorWriteMask;
}
/// <summary></summary>
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineColorBlendStateCreateFlags Flags;
	/// <summary></summary>
	public VkBool32 LogicOpEnable;
	/// <summary></summary>
	public VkLogicOp LogicOp;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkPipelineColorBlendAttachmentState* Attachments;
	/// <summary></summary>
	public fixed float BlendConstants[4];
}
/// <summary></summary>
public unsafe struct VkPipelineDynamicStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint DynamicStateCount;
	/// <summary></summary>
	public VkDynamicState* DynamicStates;
}
/// <summary></summary>
public unsafe struct VkStencilOpState
{
	/// <summary></summary>
	public VkStencilOp FailOp;
	/// <summary></summary>
	public VkStencilOp PassOp;
	/// <summary></summary>
	public VkStencilOp DepthFailOp;
	/// <summary></summary>
	public VkCompareOp CompareOp;
	/// <summary></summary>
	public uint CompareMask;
	/// <summary></summary>
	public uint WriteMask;
	/// <summary></summary>
	public uint Reference;
}
/// <summary></summary>
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineDepthStencilStateCreateFlags Flags;
	/// <summary></summary>
	public VkBool32 DepthTestEnable;
	/// <summary></summary>
	public VkBool32 DepthWriteEnable;
	/// <summary></summary>
	public VkCompareOp DepthCompareOp;
	/// <summary></summary>
	public VkBool32 DepthBoundsTestEnable;
	/// <summary></summary>
	public VkBool32 StencilTestEnable;
	/// <summary></summary>
	public VkStencilOpState Front;
	/// <summary></summary>
	public VkStencilOpState Back;
	/// <summary></summary>
	public float MinDepthBounds;
	/// <summary></summary>
	public float MaxDepthBounds;
}
/// <summary></summary>
public unsafe struct VkGraphicsPipelineCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCreateFlags Flags;
	/// <summary></summary>
	public uint StageCount;
	/// <summary></summary>
	public VkPipelineShaderStageCreateInfo* Stages;
	/// <summary></summary>
	public VkPipelineVertexInputStateCreateInfo* VertexInputState;
	/// <summary></summary>
	public VkPipelineInputAssemblyStateCreateInfo* InputAssemblyState;
	/// <summary></summary>
	public VkPipelineTessellationStateCreateInfo* TessellationState;
	/// <summary></summary>
	public VkPipelineViewportStateCreateInfo* ViewportState;
	/// <summary></summary>
	public VkPipelineRasterizationStateCreateInfo* RasterizationState;
	/// <summary></summary>
	public VkPipelineMultisampleStateCreateInfo* MultisampleState;
	/// <summary></summary>
	public VkPipelineDepthStencilStateCreateInfo* DepthStencilState;
	/// <summary></summary>
	public VkPipelineColorBlendStateCreateInfo* ColorBlendState;
	/// <summary></summary>
	public VkPipelineDynamicStateCreateInfo* DynamicState;
	/// <summary></summary>
	public VkPipelineLayout Layout;
	/// <summary></summary>
	public VkRenderPass RenderPass;
	/// <summary></summary>
	public uint Subpass;
	/// <summary></summary>
	public VkPipeline BasePipelineHandle;
	/// <summary></summary>
	public int BasePipelineIndex;
}
/// <summary></summary>
public unsafe struct VkPipelineCacheCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCacheCreateFlags Flags;
	/// <summary></summary>
	public nuint InitialDataSize;
	/// <summary></summary>
	public void* InitialData;
}
/// <summary></summary>
public unsafe struct VkPipelineCacheHeaderVersionOne
{
	/// <summary></summary>
	public uint HeaderSize;
	/// <summary></summary>
	public VkPipelineCacheHeaderVersion HeaderVersion;
	/// <summary></summary>
	public uint VendorID;
	/// <summary></summary>
	public uint DeviceID;
	/// <summary></summary>
	public fixed byte PipelineCacheUUID[(int)VK.UuidSize];
}
/// <summary></summary>
public unsafe struct VkPushConstantRange
{
	/// <summary></summary>
	public VkShaderStageFlags StageFlags;
	/// <summary></summary>
	public uint Offset;
	/// <summary></summary>
	public uint Size;
}
/// <summary></summary>
public unsafe struct VkPipelineLayoutCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineLayoutCreateFlags Flags;
	/// <summary></summary>
	public uint SetLayoutCount;
	/// <summary></summary>
	public VkDescriptorSetLayout* SetLayouts;
	/// <summary></summary>
	public uint PushConstantRangeCount;
	/// <summary></summary>
	public VkPushConstantRange* PushConstantRanges;
}
/// <summary></summary>
public unsafe struct VkSamplerCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSamplerCreateFlags Flags;
	/// <summary></summary>
	public VkFilter MagFilter;
	/// <summary></summary>
	public VkFilter MinFilter;
	/// <summary></summary>
	public VkSamplerMipmapMode MipmapMode;
	/// <summary></summary>
	public VkSamplerAddressMode AddressModeU;
	/// <summary></summary>
	public VkSamplerAddressMode AddressModeV;
	/// <summary></summary>
	public VkSamplerAddressMode AddressModeW;
	/// <summary></summary>
	public float MipLodBias;
	/// <summary></summary>
	public VkBool32 AnisotropyEnable;
	/// <summary></summary>
	public float MaxAnisotropy;
	/// <summary></summary>
	public VkBool32 CompareEnable;
	/// <summary></summary>
	public VkCompareOp CompareOp;
	/// <summary></summary>
	public float MinLod;
	/// <summary></summary>
	public float MaxLod;
	/// <summary></summary>
	public VkBorderColor BorderColor;
	/// <summary></summary>
	public VkBool32 UnnormalizedCoordinates;
}
/// <summary></summary>
public unsafe struct VkCommandPoolCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCommandPoolCreateFlags Flags;
	/// <summary></summary>
	public uint QueueFamilyIndex;
}
/// <summary></summary>
public unsafe struct VkCommandBufferAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCommandPool CommandPool;
	/// <summary></summary>
	public VkCommandBufferLevel Level;
	/// <summary></summary>
	public uint CommandBufferCount;
}
/// <summary></summary>
public unsafe struct VkCommandBufferInheritanceInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPass RenderPass;
	/// <summary></summary>
	public uint Subpass;
	/// <summary></summary>
	public VkFramebuffer Framebuffer;
	/// <summary></summary>
	public VkBool32 OcclusionQueryEnable;
	/// <summary></summary>
	public VkQueryControlFlags QueryFlags;
	/// <summary></summary>
	public VkQueryPipelineStatisticFlags PipelineStatistics;
}
/// <summary></summary>
public unsafe struct VkCommandBufferBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCommandBufferUsageFlags Flags;
	/// <summary></summary>
	public VkCommandBufferInheritanceInfo* InheritanceInfo;
}
/// <summary></summary>
public unsafe struct VkRenderPassBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPass RenderPass;
	/// <summary></summary>
	public VkFramebuffer Framebuffer;
	/// <summary></summary>
	public VkRect2D RenderArea;
	/// <summary></summary>
	public uint ClearValueCount;
	/// <summary></summary>
	public VkClearValue* ClearValues;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkClearColorValue
{
	[FieldOffset(0)]
	/// <summary></summary>
	public fixed float Float32[4];
	[FieldOffset(0)]
	/// <summary></summary>
	public fixed int Int32[4];
	[FieldOffset(0)]
	/// <summary></summary>
	public fixed uint Uint32[4];
	public VkClearColorValue(float r, float g, float b, float a)
	{
		Float32[0] = r;
		Float32[1] = g;
		Float32[2] = b;
		Float32[3] = a;
	}
	public VkClearColorValue(int r, int g, int b, int a)
	{
		Int32[0] = r;
		Int32[1] = g;
		Int32[2] = b;
		Int32[3] = a;
	}
	public VkClearColorValue(uint r, uint g, uint b, uint a)
	{
		Uint32[0] = r;
		Uint32[1] = g;
		Uint32[2] = b;
		Uint32[3] = a;
	}
}
/// <summary></summary>
public unsafe struct VkClearDepthStencilValue
{
	/// <summary></summary>
	public float Depth;
	/// <summary></summary>
	public uint Stencil;
	public VkClearDepthStencilValue(float depth, uint stencil)
	{
		Depth = depth;
		Stencil = stencil;
	}
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkClearValue
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkClearColorValue Color;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkClearDepthStencilValue DepthStencil;
	public static implicit operator VkClearValue(VkClearColorValue colour) => new() { Color = colour };
	public static implicit operator VkClearValue(VkClearDepthStencilValue depthStencil) => new() { DepthStencil = depthStencil };
}
/// <summary></summary>
public unsafe struct VkClearAttachment
{
	/// <summary></summary>
	public VkImageAspectFlags AspectMask;
	/// <summary></summary>
	public uint ColorAttachment;
	/// <summary></summary>
	public VkClearValue ClearValue;
}
/// <summary></summary>
public unsafe struct VkAttachmentDescription
{
	/// <summary></summary>
	public VkAttachmentDescriptionFlags Flags;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkSampleCountFlags Samples;
	/// <summary></summary>
	public VkAttachmentLoadOp LoadOp;
	/// <summary></summary>
	public VkAttachmentStoreOp StoreOp;
	/// <summary></summary>
	public VkAttachmentLoadOp StencilLoadOp;
	/// <summary></summary>
	public VkAttachmentStoreOp StencilStoreOp;
	/// <summary></summary>
	public VkImageLayout InitialLayout;
	/// <summary></summary>
	public VkImageLayout FinalLayout;
}
/// <summary></summary>
public unsafe struct VkAttachmentReference
{
	/// <summary></summary>
	public uint Attachment;
	/// <summary></summary>
	public VkImageLayout Layout;
}
/// <summary></summary>
public unsafe struct VkSubpassDescription
{
	/// <summary></summary>
	public VkSubpassDescriptionFlags Flags;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public uint InputAttachmentCount;
	/// <summary></summary>
	public VkAttachmentReference* InputAttachments;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkAttachmentReference* ColorAttachments;
	/// <summary></summary>
	public VkAttachmentReference* ResolveAttachments;
	/// <summary></summary>
	public VkAttachmentReference* DepthStencilAttachment;
	/// <summary></summary>
	public uint PreserveAttachmentCount;
	/// <summary></summary>
	public uint* PreserveAttachments;
}
/// <summary></summary>
public unsafe struct VkSubpassDependency
{
	/// <summary></summary>
	public uint SourceSubpass;
	/// <summary></summary>
	public uint DestinationSubpass;
	/// <summary></summary>
	public VkPipelineStageFlags SourceStageMask;
	/// <summary></summary>
	public VkPipelineStageFlags DestinationStageMask;
	/// <summary></summary>
	public VkAccessFlags SourceAccessMask;
	/// <summary></summary>
	public VkAccessFlags DestinationAccessMask;
	/// <summary></summary>
	public VkDependencyFlags DependencyFlags;
}
/// <summary></summary>
public unsafe struct VkRenderPassCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPassCreateFlags Flags;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkAttachmentDescription* Attachments;
	/// <summary></summary>
	public uint SubpassCount;
	/// <summary></summary>
	public VkSubpassDescription* Subpasses;
	/// <summary></summary>
	public uint DependencyCount;
	/// <summary></summary>
	public VkSubpassDependency* Dependencies;
}
/// <summary></summary>
public unsafe struct VkEventCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkEventCreateFlags Flags;
}
/// <summary></summary>
public unsafe struct VkFenceCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFenceCreateFlags Flags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFeatures
{
	/// <summary></summary>
	public VkBool32 RobustBufferAccess;
	/// <summary></summary>
	public VkBool32 FullDrawIndexUint32;
	/// <summary></summary>
	public VkBool32 ImageCubeArray;
	/// <summary></summary>
	public VkBool32 IndependentBlend;
	/// <summary></summary>
	public VkBool32 GeometryShader;
	/// <summary></summary>
	public VkBool32 TessellationShader;
	/// <summary></summary>
	public VkBool32 SampleRateShading;
	/// <summary></summary>
	public VkBool32 DualSourceBlend;
	/// <summary></summary>
	public VkBool32 LogicOp;
	/// <summary></summary>
	public VkBool32 MultiDrawIndirect;
	/// <summary></summary>
	public VkBool32 DrawIndirectFirstInstance;
	/// <summary></summary>
	public VkBool32 DepthClamp;
	/// <summary></summary>
	public VkBool32 DepthBiasClamp;
	/// <summary></summary>
	public VkBool32 FillModeNonSolid;
	/// <summary></summary>
	public VkBool32 DepthBounds;
	/// <summary></summary>
	public VkBool32 WideLines;
	/// <summary></summary>
	public VkBool32 LargePoints;
	/// <summary></summary>
	public VkBool32 AlphaToOne;
	/// <summary></summary>
	public VkBool32 MultiViewport;
	/// <summary></summary>
	public VkBool32 SamplerAnisotropy;
	/// <summary></summary>
	public VkBool32 TextureCompressionETC2;
	/// <summary></summary>
	public VkBool32 TextureCompressionASTC_LDR;
	/// <summary></summary>
	public VkBool32 TextureCompressionBC;
	/// <summary></summary>
	public VkBool32 OcclusionQueryPrecise;
	/// <summary></summary>
	public VkBool32 PipelineStatisticsQuery;
	/// <summary></summary>
	public VkBool32 VertexPipelineStoresAndAtomics;
	/// <summary></summary>
	public VkBool32 FragmentStoresAndAtomics;
	/// <summary></summary>
	public VkBool32 ShaderTessellationAndGeometryPointSize;
	/// <summary></summary>
	public VkBool32 ShaderImageGatherExtended;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageExtendedFormats;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageMultisample;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageReadWithoutFormat;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageWriteWithoutFormat;
	/// <summary></summary>
	public VkBool32 ShaderUniformBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderSampledImageArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderClipDistance;
	/// <summary></summary>
	public VkBool32 ShaderCullDistance;
	/// <summary></summary>
	public VkBool32 ShaderFloat64;
	/// <summary></summary>
	public VkBool32 ShaderInt64;
	/// <summary></summary>
	public VkBool32 ShaderInt16;
	/// <summary></summary>
	public VkBool32 ShaderResourceResidency;
	/// <summary></summary>
	public VkBool32 ShaderResourceMinLod;
	/// <summary></summary>
	public VkBool32 SparseBinding;
	/// <summary></summary>
	public VkBool32 SparseResidencyBuffer;
	/// <summary></summary>
	public VkBool32 SparseResidencyImage2D;
	/// <summary></summary>
	public VkBool32 SparseResidencyImage3D;
	/// <summary></summary>
	public VkBool32 SparseResidency2Samples;
	/// <summary></summary>
	public VkBool32 SparseResidency4Samples;
	/// <summary></summary>
	public VkBool32 SparseResidency8Samples;
	/// <summary></summary>
	public VkBool32 SparseResidency16Samples;
	/// <summary></summary>
	public VkBool32 SparseResidencyAliased;
	/// <summary></summary>
	public VkBool32 VariableMultisampleRate;
	/// <summary></summary>
	public VkBool32 InheritedQueries;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSparseProperties
{
	/// <summary></summary>
	public VkBool32 ResidencyStandard2DBlockShape;
	/// <summary></summary>
	public VkBool32 ResidencyStandard2DMultisampleBlockShape;
	/// <summary></summary>
	public VkBool32 ResidencyStandard3DBlockShape;
	/// <summary></summary>
	public VkBool32 ResidencyAlignedMipSize;
	/// <summary></summary>
	public VkBool32 ResidencyNonResidentStrict;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceLimits
{
	/// <summary></summary>
	public uint MaxImageDimension1D;
	/// <summary></summary>
	public uint MaxImageDimension2D;
	/// <summary></summary>
	public uint MaxImageDimension3D;
	/// <summary></summary>
	public uint MaxImageDimensionCube;
	/// <summary></summary>
	public uint MaxImageArrayLayers;
	/// <summary></summary>
	public uint MaxTexelBufferElements;
	/// <summary></summary>
	public uint MaxUniformBufferRange;
	/// <summary></summary>
	public uint MaxStorageBufferRange;
	/// <summary></summary>
	public uint MaxPushConstantsSize;
	/// <summary></summary>
	public uint MaxMemoryAllocationCount;
	/// <summary></summary>
	public uint MaxSamplerAllocationCount;
	/// <summary></summary>
	public VkDeviceSize BufferImageGranularity;
	/// <summary></summary>
	public VkDeviceSize SparseAddressSpaceSize;
	/// <summary></summary>
	public uint MaxBoundDescriptorSets;
	/// <summary></summary>
	public uint MaxPerStageDescriptorSamplers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUniformBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorStorageBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorSampledImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorStorageImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorInputAttachments;
	/// <summary></summary>
	public uint MaxPerStageResources;
	/// <summary></summary>
	public uint MaxDescriptorSetSamplers;
	/// <summary></summary>
	public uint MaxDescriptorSetUniformBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetUniformBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetStorageBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetStorageBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetSampledImages;
	/// <summary></summary>
	public uint MaxDescriptorSetStorageImages;
	/// <summary></summary>
	public uint MaxDescriptorSetInputAttachments;
	/// <summary></summary>
	public uint MaxVertexInputAttributes;
	/// <summary></summary>
	public uint MaxVertexInputBindings;
	/// <summary></summary>
	public uint MaxVertexInputAttributeOffset;
	/// <summary></summary>
	public uint MaxVertexInputBindingStride;
	/// <summary></summary>
	public uint MaxVertexOutputComponents;
	/// <summary></summary>
	public uint MaxTessellationGenerationLevel;
	/// <summary></summary>
	public uint MaxTessellationPatchSize;
	/// <summary></summary>
	public uint MaxTessellationControlPerVertexInputComponents;
	/// <summary></summary>
	public uint MaxTessellationControlPerVertexOutputComponents;
	/// <summary></summary>
	public uint MaxTessellationControlPerPatchOutputComponents;
	/// <summary></summary>
	public uint MaxTessellationControlTotalOutputComponents;
	/// <summary></summary>
	public uint MaxTessellationEvaluationInputComponents;
	/// <summary></summary>
	public uint MaxTessellationEvaluationOutputComponents;
	/// <summary></summary>
	public uint MaxGeometryShaderInvocations;
	/// <summary></summary>
	public uint MaxGeometryInputComponents;
	/// <summary></summary>
	public uint MaxGeometryOutputComponents;
	/// <summary></summary>
	public uint MaxGeometryOutputVertices;
	/// <summary></summary>
	public uint MaxGeometryTotalOutputComponents;
	/// <summary></summary>
	public uint MaxFragmentInputComponents;
	/// <summary></summary>
	public uint MaxFragmentOutputAttachments;
	/// <summary></summary>
	public uint MaxFragmentDualSourceAttachments;
	/// <summary></summary>
	public uint MaxFragmentCombinedOutputResources;
	/// <summary></summary>
	public uint MaxComputeSharedMemorySize;
	/// <summary></summary>
	public fixed uint MaxComputeWorkGroupCount[3];
	/// <summary></summary>
	public uint MaxComputeWorkGroupInvocations;
	/// <summary></summary>
	public fixed uint MaxComputeWorkGroupSize[3];
	/// <summary></summary>
	public uint SubPixelPrecisionBits;
	/// <summary></summary>
	public uint SubTexelPrecisionBits;
	/// <summary></summary>
	public uint MipmapPrecisionBits;
	/// <summary></summary>
	public uint MaxDrawIndexedIndexValue;
	/// <summary></summary>
	public uint MaxDrawIndirectCount;
	/// <summary></summary>
	public float MaxSamplerLodBias;
	/// <summary></summary>
	public float MaxSamplerAnisotropy;
	/// <summary></summary>
	public uint MaxViewports;
	/// <summary></summary>
	public fixed uint MaxViewportDimensions[2];
	/// <summary></summary>
	public fixed float ViewportBoundsRange[2];
	/// <summary></summary>
	public uint ViewportSubPixelBits;
	/// <summary></summary>
	public nuint MinMemoryMapAlignment;
	/// <summary></summary>
	public VkDeviceSize MinTexelBufferOffsetAlignment;
	/// <summary></summary>
	public VkDeviceSize MinUniformBufferOffsetAlignment;
	/// <summary></summary>
	public VkDeviceSize MinStorageBufferOffsetAlignment;
	/// <summary></summary>
	public int MinTexelOffset;
	/// <summary></summary>
	public uint MaxTexelOffset;
	/// <summary></summary>
	public int MinTexelGatherOffset;
	/// <summary></summary>
	public uint MaxTexelGatherOffset;
	/// <summary></summary>
	public float MinInterpolationOffset;
	/// <summary></summary>
	public float MaxInterpolationOffset;
	/// <summary></summary>
	public uint SubPixelInterpolationOffsetBits;
	/// <summary></summary>
	public uint MaxFramebufferWidth;
	/// <summary></summary>
	public uint MaxFramebufferHeight;
	/// <summary></summary>
	public uint MaxFramebufferLayers;
	/// <summary></summary>
	public VkSampleCountFlags FramebufferColorSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags FramebufferDepthSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags FramebufferStencilSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags FramebufferNoAttachmentsSampleCounts;
	/// <summary></summary>
	public uint MaxColorAttachments;
	/// <summary></summary>
	public VkSampleCountFlags SampledImageColorSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags SampledImageIntegerSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags SampledImageDepthSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags SampledImageStencilSampleCounts;
	/// <summary></summary>
	public VkSampleCountFlags StorageImageSampleCounts;
	/// <summary></summary>
	public uint MaxSampleMaskWords;
	/// <summary></summary>
	public VkBool32 TimestampComputeAndGraphics;
	/// <summary></summary>
	public float TimestampPeriod;
	/// <summary></summary>
	public uint MaxClipDistances;
	/// <summary></summary>
	public uint MaxCullDistances;
	/// <summary></summary>
	public uint MaxCombinedClipAndCullDistances;
	/// <summary></summary>
	public uint DiscreteQueuePriorities;
	/// <summary></summary>
	public fixed float PointSizeRange[2];
	/// <summary></summary>
	public fixed float LineWidthRange[2];
	/// <summary></summary>
	public float PointSizeGranularity;
	/// <summary></summary>
	public float LineWidthGranularity;
	/// <summary></summary>
	public VkBool32 StrictLines;
	/// <summary></summary>
	public VkBool32 StandardSampleLocations;
	/// <summary></summary>
	public VkDeviceSize OptimalBufferCopyOffsetAlignment;
	/// <summary></summary>
	public VkDeviceSize OptimalBufferCopyRowPitchAlignment;
	/// <summary></summary>
	public VkDeviceSize NonCoherentAtomSize;
}
/// <summary></summary>
public unsafe struct VkSemaphoreCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
}
/// <summary></summary>
public unsafe struct VkQueryPoolCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkQueryType QueryType;
	/// <summary></summary>
	public uint QueryCount;
	/// <summary></summary>
	public VkQueryPipelineStatisticFlags PipelineStatistics;
}
/// <summary></summary>
public unsafe struct VkFramebufferCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFramebufferCreateFlags Flags;
	/// <summary></summary>
	public VkRenderPass RenderPass;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkImageView* Attachments;
	/// <summary></summary>
	public uint Width;
	/// <summary></summary>
	public uint Height;
	/// <summary></summary>
	public uint Layers;
}
/// <summary></summary>
public unsafe struct VkDrawIndirectCommand
{
	/// <summary></summary>
	public uint VertexCount;
	/// <summary></summary>
	public uint InstanceCount;
	/// <summary></summary>
	public uint FirstVertex;
	/// <summary></summary>
	public uint FirstInstance;
}
/// <summary></summary>
public unsafe struct VkDrawIndexedIndirectCommand
{
	/// <summary></summary>
	public uint IndexCount;
	/// <summary></summary>
	public uint InstanceCount;
	/// <summary></summary>
	public uint FirstIndex;
	/// <summary></summary>
	public int VertexOffset;
	/// <summary></summary>
	public uint FirstInstance;
}
/// <summary></summary>
public unsafe struct VkDispatchIndirectCommand
{
	/// <summary></summary>
	public uint X;
	/// <summary></summary>
	public uint Y;
	/// <summary></summary>
	public uint Z;
}
/// <summary></summary>
public unsafe struct VkMultiDrawInfoEXT
{
	/// <summary></summary>
	public uint FirstVertex;
	/// <summary></summary>
	public uint VertexCount;
}
/// <summary></summary>
public unsafe struct VkMultiDrawIndexedInfoEXT
{
	/// <summary></summary>
	public uint FirstIndex;
	/// <summary></summary>
	public uint IndexCount;
	/// <summary></summary>
	public int VertexOffset;
}
/// <summary></summary>
public unsafe struct VkSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint WaitSemaphoreCount;
	/// <summary></summary>
	public VkSemaphore* WaitSemaphores;
	/// <summary></summary>
	public VkPipelineStageFlags* WaitDestinationStageMask;
	/// <summary></summary>
	public uint CommandBufferCount;
	/// <summary></summary>
	public VkCommandBuffer* CommandBuffers;
	/// <summary></summary>
	public uint SignalSemaphoreCount;
	/// <summary></summary>
	public VkSemaphore* SignalSemaphores;
}
/// <summary></summary>
public unsafe struct VkDisplayPropertiesKHR
{
	/// <summary></summary>
	public VkDisplayKHR Display;
	/// <summary></summary>
	public byte* DisplayName;
	/// <summary></summary>
	public VkExtent2D PhysicalDimensions;
	/// <summary></summary>
	public VkExtent2D PhysicalResolution;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	/// <summary></summary>
	public VkBool32 PlaneReorderPossible;
	/// <summary></summary>
	public VkBool32 PersistentContent;
}
/// <summary></summary>
public unsafe struct VkDisplayPlanePropertiesKHR
{
	/// <summary></summary>
	public VkDisplayKHR CurrentDisplay;
	/// <summary></summary>
	public uint CurrentStackIndex;
}
/// <summary></summary>
public unsafe struct VkDisplayModeParametersKHR
{
	/// <summary></summary>
	public VkExtent2D VisibleRegion;
	/// <summary></summary>
	public uint RefreshRate;
}
/// <summary></summary>
public unsafe struct VkDisplayModePropertiesKHR
{
	/// <summary></summary>
	public VkDisplayModeKHR DisplayMode;
	/// <summary></summary>
	public VkDisplayModeParametersKHR Parameters;
}
/// <summary></summary>
public unsafe struct VkDisplayModeCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkDisplayModeParametersKHR Parameters;
}
/// <summary></summary>
public unsafe struct VkDisplayPlaneCapabilitiesKHR
{
	/// <summary></summary>
	public VkDisplayPlaneAlphaFlagsKHR SupportedAlpha;
	/// <summary></summary>
	public VkOffset2D MinSourcePosition;
	/// <summary></summary>
	public VkOffset2D MaxSourcePosition;
	/// <summary></summary>
	public VkExtent2D MinSourceExtent;
	/// <summary></summary>
	public VkExtent2D MaxSourceExtent;
	/// <summary></summary>
	public VkOffset2D MinDestinationPosition;
	/// <summary></summary>
	public VkOffset2D MaxDestinationPosition;
	/// <summary></summary>
	public VkExtent2D MinDestinationExtent;
	/// <summary></summary>
	public VkExtent2D MaxDestinationExtent;
}
/// <summary></summary>
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkDisplayModeKHR DisplayMode;
	/// <summary></summary>
	public uint PlaneIndex;
	/// <summary></summary>
	public uint PlaneStackIndex;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR Transform;
	/// <summary></summary>
	public float GlobalAlpha;
	/// <summary></summary>
	public VkDisplayPlaneAlphaFlagsKHR AlphaMode;
	/// <summary></summary>
	public VkExtent2D ImageExtent;
}
/// <summary></summary>
public unsafe struct VkDisplayPresentInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRect2D SourceRect;
	/// <summary></summary>
	public VkRect2D DestinationRect;
	/// <summary></summary>
	public VkBool32 Persistent;
}
/// <summary></summary>
public unsafe struct VkSurfaceCapabilitiesKHR
{
	/// <summary></summary>
	public uint MinImageCount;
	/// <summary></summary>
	public uint MaxImageCount;
	/// <summary></summary>
	public VkExtent2D CurrentExtent;
	/// <summary></summary>
	public VkExtent2D MinImageExtent;
	/// <summary></summary>
	public VkExtent2D MaxImageExtent;
	/// <summary></summary>
	public uint MaxImageArrayLayers;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR CurrentTransform;
	/// <summary></summary>
	public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;
	/// <summary></summary>
	public VkImageUsageFlags SupportedUsageFlags;
}
/// <summary></summary>
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public IntPtr* Window;
}
/// <summary></summary>
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public IntPtr Hinstance;
	/// <summary></summary>
	public IntPtr Hwnd;
}
/// <summary></summary>
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public IntPtr* Dpy;
	/// <summary></summary>
	public IntPtr Window;
}
/// <summary></summary>
public unsafe struct VkSurfaceFormatKHR
{
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkColorSpaceKHR ColorSpace;
}
/// <summary></summary>
public unsafe struct VkSwapchainCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSwapchainCreateFlagsKHR Flags;
	/// <summary></summary>
	public VkSurfaceKHR Surface;
	/// <summary></summary>
	public uint MinImageCount;
	/// <summary></summary>
	public VkFormat ImageFormat;
	/// <summary></summary>
	public VkColorSpaceKHR ImageColorSpace;
	/// <summary></summary>
	public VkExtent2D ImageExtent;
	/// <summary></summary>
	public uint ImageArrayLayers;
	/// <summary></summary>
	public VkImageUsageFlags ImageUsage;
	/// <summary></summary>
	public VkSharingMode ImageSharingMode;
	/// <summary></summary>
	public uint QueueFamilyIndexCount;
	/// <summary></summary>
	public uint* QueueFamilyIndices;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR PreTransform;
	/// <summary></summary>
	public VkCompositeAlphaFlagsKHR CompositeAlpha;
	/// <summary></summary>
	public VkPresentModeKHR PresentMode;
	/// <summary></summary>
	public VkBool32 Clipped;
	/// <summary></summary>
	public VkSwapchainKHR OldSwapchain;
}
/// <summary></summary>
public unsafe struct VkPresentInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint WaitSemaphoreCount;
	/// <summary></summary>
	public VkSemaphore* WaitSemaphores;
	/// <summary></summary>
	public uint SwapchainCount;
	/// <summary></summary>
	public VkSwapchainKHR* Swapchains;
	/// <summary></summary>
	public uint* ImageIndices;
	/// <summary></summary>
	public VkResult* Results;
}
/// <summary></summary>
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDebugReportFlagsEXT Flags;
	/// <summary></summary>
	public IntPtr Callback;
	/// <summary></summary>
	public void* UserData;
}
/// <summary></summary>
public unsafe struct VkValidationFlagsEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DisabledValidationCheckCount;
	/// <summary></summary>
	public VkValidationCheckEXT* DisabledValidationChecks;
}
/// <summary></summary>
public unsafe struct VkValidationFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint EnabledValidationFeatureCount;
	/// <summary></summary>
	public VkValidationFeatureEnableEXT* EnabledValidationFeatures;
	/// <summary></summary>
	public uint DisabledValidationFeatureCount;
	/// <summary></summary>
	public VkValidationFeatureDisableEXT* DisabledValidationFeatures;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRasterizationOrderAMD RasterizationOrder;
}
/// <summary></summary>
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDebugReportObjectTypeEXT ObjectType;
	/// <summary></summary>
	public ulong Object;
	/// <summary></summary>
	public byte* ObjectName;
}
/// <summary></summary>
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDebugReportObjectTypeEXT ObjectType;
	/// <summary></summary>
	public ulong Object;
	/// <summary></summary>
	public ulong TagName;
	/// <summary></summary>
	public nuint TagSize;
	/// <summary></summary>
	public void* Tag;
}
/// <summary></summary>
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public byte* MarkerName;
	/// <summary></summary>
	public fixed float Color[4];
}
/// <summary></summary>
public unsafe struct VkDedicatedAllocationImageCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DedicatedAllocation;
}
/// <summary></summary>
public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DedicatedAllocation;
}
/// <summary></summary>
public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage Image;
	/// <summary></summary>
	public VkBuffer Buffer;
}
/// <summary></summary>
public unsafe struct VkExternalImageFormatPropertiesNV
{
	/// <summary></summary>
	public VkImageFormatProperties ImageFormatProperties;
	/// <summary></summary>
	public VkExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
}
/// <summary></summary>
public unsafe struct VkExternalMemoryImageCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
}
/// <summary></summary>
public unsafe struct VkExportMemoryAllocateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
}
/// <summary></summary>
public unsafe struct VkImportMemoryWin32HandleInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlagsNV HandleType;
	/// <summary></summary>
	public IntPtr Handle;
}
/// <summary></summary>
public unsafe struct VkExportMemoryWin32HandleInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public SecurityAttributes* Attributes;
	/// <summary></summary>
	public uint DwAccess;
}
/// <summary></summary>
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AcquireCount;
	/// <summary></summary>
	public VkDeviceMemory* AcquireSyncs;
	/// <summary></summary>
	public ulong* AcquireKeys;
	/// <summary></summary>
	public uint* AcquireTimeoutMilliseconds;
	/// <summary></summary>
	public uint ReleaseCount;
	/// <summary></summary>
	public VkDeviceMemory* ReleaseSyncs;
	/// <summary></summary>
	public ulong* ReleaseKeys;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DeviceGeneratedCommands;
}
/// <summary></summary>
public unsafe struct VkDevicePrivateDataCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint PrivateDataSlotRequestCount;
}
/// <summary></summary>
public unsafe struct VkPrivateDataSlotCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePrivateDataFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PrivateData;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxGraphicsShaderGroupCount;
	/// <summary></summary>
	public uint MaxIndirectSequenceCount;
	/// <summary></summary>
	public uint MaxIndirectCommandsTokenCount;
	/// <summary></summary>
	public uint MaxIndirectCommandsStreamCount;
	/// <summary></summary>
	public uint MaxIndirectCommandsTokenOffset;
	/// <summary></summary>
	public uint MaxIndirectCommandsStreamStride;
	/// <summary></summary>
	public uint MinSequencesCountBufferOffsetAlignment;
	/// <summary></summary>
	public uint MinSequencesIndexBufferOffsetAlignment;
	/// <summary></summary>
	public uint MinIndirectCommandsBufferOffsetAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxMultiDrawCount;
}
/// <summary></summary>
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint StageCount;
	/// <summary></summary>
	public VkPipelineShaderStageCreateInfo* Stages;
	/// <summary></summary>
	public VkPipelineVertexInputStateCreateInfo* VertexInputState;
	/// <summary></summary>
	public VkPipelineTessellationStateCreateInfo* TessellationState;
}
/// <summary></summary>
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint GroupCount;
	/// <summary></summary>
	public VkGraphicsShaderGroupCreateInfoNV* Groups;
	/// <summary></summary>
	public uint PipelineCount;
	/// <summary></summary>
	public VkPipeline* Pipelines;
}
/// <summary></summary>
public unsafe struct VkBindShaderGroupIndirectCommandNV
{
	/// <summary></summary>
	public uint GroupIndex;
}
/// <summary></summary>
public unsafe struct VkBindIndexBufferIndirectCommandNV
{
	/// <summary></summary>
	public VkDeviceAddress BufferAddress;
	/// <summary></summary>
	public uint Size;
	/// <summary></summary>
	public VkIndexType IndexType;
}
/// <summary></summary>
public unsafe struct VkBindVertexBufferIndirectCommandNV
{
	/// <summary></summary>
	public VkDeviceAddress BufferAddress;
	/// <summary></summary>
	public uint Size;
	/// <summary></summary>
	public uint Stride;
}
/// <summary></summary>
public unsafe struct VkSetStateFlagsIndirectCommandNV
{
	/// <summary></summary>
	public uint Data;
}
/// <summary></summary>
public unsafe struct VkIndirectCommandsStreamNV
{
	/// <summary></summary>
	public VkBuffer Buffer;
	/// <summary></summary>
	public VkDeviceSize Offset;
}
/// <summary></summary>
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkIndirectCommandsTokenTypeNV TokenType;
	/// <summary></summary>
	public uint Stream;
	/// <summary></summary>
	public uint Offset;
	/// <summary></summary>
	public uint VertexBindingUnit;
	/// <summary></summary>
	public VkBool32 VertexDynamicStride;
	/// <summary></summary>
	public VkPipelineLayout PushconstantPipelineLayout;
	/// <summary></summary>
	public VkShaderStageFlags PushconstantShaderStageFlags;
	/// <summary></summary>
	public uint PushconstantOffset;
	/// <summary></summary>
	public uint PushconstantSize;
	/// <summary></summary>
	public VkIndirectStateFlagsNV IndirectStateFlags;
	/// <summary></summary>
	public uint IndexTypeCount;
	/// <summary></summary>
	public VkIndexType* IndexTypes;
	/// <summary></summary>
	public uint* IndexTypeValues;
}
/// <summary></summary>
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkIndirectCommandsLayoutUsageFlagsNV Flags;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public uint TokenCount;
	/// <summary></summary>
	public VkIndirectCommandsLayoutTokenNV* Tokens;
	/// <summary></summary>
	public uint StreamCount;
	/// <summary></summary>
	public uint* StreamStrides;
}
/// <summary></summary>
public unsafe struct VkGeneratedCommandsInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public VkPipeline Pipeline;
	/// <summary></summary>
	public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
	/// <summary></summary>
	public uint StreamCount;
	/// <summary></summary>
	public VkIndirectCommandsStreamNV* Streams;
	/// <summary></summary>
	public uint SequencesCount;
	/// <summary></summary>
	public VkBuffer PreprocessBuffer;
	/// <summary></summary>
	public VkDeviceSize PreprocessOffset;
	/// <summary></summary>
	public VkDeviceSize PreprocessSize;
	/// <summary></summary>
	public VkBuffer SequencesCountBuffer;
	/// <summary></summary>
	public VkDeviceSize SequencesCountOffset;
	/// <summary></summary>
	public VkBuffer SequencesIndexBuffer;
	/// <summary></summary>
	public VkDeviceSize SequencesIndexOffset;
}
/// <summary></summary>
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public VkPipeline Pipeline;
	/// <summary></summary>
	public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
	/// <summary></summary>
	public uint MaxSequencesCount;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFeatures2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPhysicalDeviceFeatures Features;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPhysicalDeviceProperties Properties;
}
/// <summary></summary>
public unsafe struct VkFormatProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormatProperties FormatProperties;
}
/// <summary></summary>
public unsafe struct VkImageFormatProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageFormatProperties ImageFormatProperties;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkImageType Type;
	/// <summary></summary>
	public VkImageTiling Tiling;
	/// <summary></summary>
	public VkImageUsageFlags Usage;
	/// <summary></summary>
	public VkImageCreateFlags Flags;
}
/// <summary></summary>
public unsafe struct VkQueueFamilyProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkQueueFamilyProperties QueueFamilyProperties;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPhysicalDeviceMemoryProperties MemoryProperties;
}
/// <summary></summary>
public unsafe struct VkSparseImageFormatProperties2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSparseImageFormatProperties Properties;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkImageType Type;
	/// <summary></summary>
	public VkSampleCountFlags Samples;
	/// <summary></summary>
	public VkImageUsageFlags Usage;
	/// <summary></summary>
	public VkImageTiling Tiling;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxPushDescriptors;
}
/// <summary></summary>
public unsafe struct VkConformanceVersion
{
	/// <summary></summary>
	public byte Major;
	/// <summary></summary>
	public byte Minor;
	/// <summary></summary>
	public byte Subminor;
	/// <summary></summary>
	public byte Patch;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDriverProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDriverId DriverID;
	/// <summary></summary>
	public fixed byte DriverName[(int)VK.MaxDriverNameSize];
	/// <summary></summary>
	public fixed byte DriverInfo[(int)VK.MaxDriverInfoSize];
	/// <summary></summary>
	public VkConformanceVersion ConformanceVersion;
}
/// <summary></summary>
public unsafe struct VkPresentRegionsKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SwapchainCount;
	/// <summary></summary>
	public VkPresentRegionKHR* Regions;
}
/// <summary></summary>
public unsafe struct VkPresentRegionKHR
{
	/// <summary></summary>
	public uint RectangleCount;
	/// <summary></summary>
	public VkRectLayerKHR* Rectangles;
}
/// <summary></summary>
public unsafe struct VkRectLayerKHR
{
	/// <summary></summary>
	public VkOffset2D Offset;
	/// <summary></summary>
	public VkExtent2D Extent;
	/// <summary></summary>
	public uint Layer;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 VariablePointersStorageBuffer;
	/// <summary></summary>
	public VkBool32 VariablePointers;
}
/// <summary></summary>
public unsafe struct VkExternalMemoryProperties
{
	/// <summary></summary>
	public VkExternalMemoryFeatureFlags ExternalMemoryFeatures;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkExternalImageFormatProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBufferCreateFlags Flags;
	/// <summary></summary>
	public VkBufferUsageFlags Usage;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkExternalBufferProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceIDProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	/// <summary></summary>
	public fixed byte DriverUUID[(int)VK.UuidSize];
	/// <summary></summary>
	public fixed byte DeviceLUID[(int)VK.LuidSize];
	/// <summary></summary>
	public uint DeviceNodeMask;
	/// <summary></summary>
	public VkBool32 DeviceLUIDValid;
}
/// <summary></summary>
public unsafe struct VkExternalMemoryImageCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
/// <summary></summary>
public unsafe struct VkExternalMemoryBufferCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
/// <summary></summary>
public unsafe struct VkExportMemoryAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
/// <summary></summary>
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
	/// <summary></summary>
	public IntPtr Handle;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public SecurityAttributes* Attributes;
	/// <summary></summary>
	public uint DwAccess;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MemoryTypeBits;
}
/// <summary></summary>
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkImportMemoryFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
	/// <summary></summary>
	public int FileDescriptor;
}
/// <summary></summary>
public unsafe struct VkMemoryFdPropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MemoryTypeBits;
}
/// <summary></summary>
public unsafe struct VkMemoryGetFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AcquireCount;
	/// <summary></summary>
	public VkDeviceMemory* AcquireSyncs;
	/// <summary></summary>
	public ulong* AcquireKeys;
	/// <summary></summary>
	public uint* AcquireTimeouts;
	/// <summary></summary>
	public uint ReleaseCount;
	/// <summary></summary>
	public VkDeviceMemory* ReleaseSyncs;
	/// <summary></summary>
	public ulong* ReleaseKeys;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkExternalSemaphoreProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;
	/// <summary></summary>
	public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
}
/// <summary></summary>
public unsafe struct VkExportSemaphoreCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleTypes;
}
/// <summary></summary>
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public VkSemaphoreImportFlags Flags;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleType;
	/// <summary></summary>
	public IntPtr Handle;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public SecurityAttributes* Attributes;
	/// <summary></summary>
	public uint DwAccess;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint WaitSemaphoreValuesCount;
	/// <summary></summary>
	public ulong* WaitSemaphoreValues;
	/// <summary></summary>
	public uint SignalSemaphoreValuesCount;
	/// <summary></summary>
	public ulong* SignalSemaphoreValues;
}
/// <summary></summary>
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkImportSemaphoreFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public VkSemaphoreImportFlags Flags;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleType;
	/// <summary></summary>
	public int FileDescriptor;
}
/// <summary></summary>
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkExternalFenceProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags CompatibleHandleTypes;
	/// <summary></summary>
	public VkExternalFenceFeatureFlags ExternalFenceFeatures;
}
/// <summary></summary>
public unsafe struct VkExportFenceCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleTypes;
}
/// <summary></summary>
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFence Fence;
	/// <summary></summary>
	public VkFenceImportFlags Flags;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleType;
	/// <summary></summary>
	public IntPtr Handle;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public SecurityAttributes* Attributes;
	/// <summary></summary>
	public uint DwAccess;
	/// <summary></summary>
	public IntPtr Name;
}
/// <summary></summary>
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFence Fence;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkImportFenceFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFence Fence;
	/// <summary></summary>
	public VkFenceImportFlags Flags;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleType;
	/// <summary></summary>
	public int FileDescriptor;
}
/// <summary></summary>
public unsafe struct VkFenceGetFdInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFence Fence;
	/// <summary></summary>
	public VkExternalFenceHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Multiview;
	/// <summary></summary>
	public VkBool32 MultiviewGeometryShader;
	/// <summary></summary>
	public VkBool32 MultiviewTessellationShader;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxMultiviewViewCount;
	/// <summary></summary>
	public uint MaxMultiviewInstanceIndex;
}
/// <summary></summary>
public unsafe struct VkRenderPassMultiviewCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SubpassCount;
	/// <summary></summary>
	public uint* ViewMasks;
	/// <summary></summary>
	public uint DependencyCount;
	/// <summary></summary>
	public int* ViewOffsets;
	/// <summary></summary>
	public uint CorrelationMaskCount;
	/// <summary></summary>
	public uint* CorrelationMasks;
}
/// <summary></summary>
public unsafe struct VkSurfaceCapabilities2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MinImageCount;
	/// <summary></summary>
	public uint MaxImageCount;
	/// <summary></summary>
	public VkExtent2D CurrentExtent;
	/// <summary></summary>
	public VkExtent2D MinImageExtent;
	/// <summary></summary>
	public VkExtent2D MaxImageExtent;
	/// <summary></summary>
	public uint MaxImageArrayLayers;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR CurrentTransform;
	/// <summary></summary>
	public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;
	/// <summary></summary>
	public VkImageUsageFlags SupportedUsageFlags;
	/// <summary></summary>
	public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters;
}
/// <summary></summary>
public unsafe struct VkDisplayPowerInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayPowerStateEXT PowerState;
}
/// <summary></summary>
public unsafe struct VkDeviceEventInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceEventTypeEXT DeviceEvent;
}
/// <summary></summary>
public unsafe struct VkDisplayEventInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayEventTypeEXT DisplayEvent;
}
/// <summary></summary>
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceCounterFlagsEXT SurfaceCounters;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceGroupProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint PhysicalDeviceCount;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_0;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_1;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_2;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_3;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_4;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_5;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_6;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_7;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_8;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_9;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_10;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_11;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_12;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_13;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_14;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_15;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_16;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_17;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_18;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_19;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_20;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_21;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_22;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_23;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_24;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_25;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_26;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_27;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_28;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_29;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_30;
	/// <summary></summary>
	public VkPhysicalDevice PhysicalDevices_31;
	/// <summary></summary>
	public VkBool32 SubsetAllocation;
}
/// <summary></summary>
public unsafe struct VkMemoryAllocateFlagsInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkMemoryAllocateFlags Flags;
	/// <summary></summary>
	public uint DeviceMask;
}
/// <summary></summary>
public unsafe struct VkBindBufferMemoryInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer Buffer;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkDeviceSize MemoryOffset;
}
/// <summary></summary>
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DeviceIndexCount;
	/// <summary></summary>
	public uint* DeviceIndices;
}
/// <summary></summary>
public unsafe struct VkBindImageMemoryInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage Image;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkDeviceSize MemoryOffset;
}
/// <summary></summary>
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DeviceIndexCount;
	/// <summary></summary>
	public uint* DeviceIndices;
	/// <summary></summary>
	public uint SplitInstanceBindRegionCount;
	/// <summary></summary>
	public VkRect2D* SplitInstanceBindRegions;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DeviceMask;
	/// <summary></summary>
	public uint DeviceRenderAreaCount;
	/// <summary></summary>
	public VkRect2D* DeviceRenderAreas;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DeviceMask;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint WaitSemaphoreCount;
	/// <summary></summary>
	public uint* WaitSemaphoreDeviceIndices;
	/// <summary></summary>
	public uint CommandBufferCount;
	/// <summary></summary>
	public uint* CommandBufferDeviceMasks;
	/// <summary></summary>
	public uint SignalSemaphoreCount;
	/// <summary></summary>
	public uint* SignalSemaphoreDeviceIndices;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupBindSparseInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ResourceDeviceIndex;
	/// <summary></summary>
	public uint MemoryDeviceIndex;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed uint PresentMask[(int)VK.MaxDeviceGroupSize];
	/// <summary></summary>
	public VkDeviceGroupPresentModeFlagsKHR Modes;
}
/// <summary></summary>
public unsafe struct VkImageSwapchainCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSwapchainKHR Swapchain;
}
/// <summary></summary>
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSwapchainKHR Swapchain;
	/// <summary></summary>
	public uint ImageIndex;
}
/// <summary></summary>
public unsafe struct VkAcquireNextImageInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSwapchainKHR Swapchain;
	/// <summary></summary>
	public ulong Timeout;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public VkFence Fence;
	/// <summary></summary>
	public uint DeviceMask;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SwapchainCount;
	/// <summary></summary>
	public uint* DeviceMasks;
	/// <summary></summary>
	public VkDeviceGroupPresentModeFlagsKHR Mode;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint PhysicalDeviceCount;
	/// <summary></summary>
	public VkPhysicalDevice* PhysicalDevices;
}
/// <summary></summary>
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceGroupPresentModeFlagsKHR Modes;
}
/// <summary></summary>
public unsafe struct VkDescriptorUpdateTemplateEntry
{
	/// <summary></summary>
	public uint DestinationBinding;
	/// <summary></summary>
	public uint DestinationArrayElement;
	/// <summary></summary>
	public uint DescriptorCount;
	/// <summary></summary>
	public VkDescriptorType DescriptorType;
	/// <summary></summary>
	public nuint Offset;
	/// <summary></summary>
	public nuint Stride;
}
/// <summary></summary>
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint DescriptorUpdateEntryCount;
	/// <summary></summary>
	public VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries;
	/// <summary></summary>
	public VkDescriptorUpdateTemplateType TemplateType;
	/// <summary></summary>
	public VkDescriptorSetLayout DescriptorSetLayout;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public VkPipelineLayout PipelineLayout;
	/// <summary></summary>
	public uint Set;
}
/// <summary></summary>
public unsafe struct VkXYColorEXT
{
	/// <summary></summary>
	public float X;
	/// <summary></summary>
	public float Y;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PresentId;
}
/// <summary></summary>
public unsafe struct VkPresentIdKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SwapchainCount;
	/// <summary></summary>
	public ulong* PresentIds;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PresentWait;
}
/// <summary></summary>
public unsafe struct VkHdrMetadataEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkXYColorEXT DisplayPrimaryRed;
	/// <summary></summary>
	public VkXYColorEXT DisplayPrimaryGreen;
	/// <summary></summary>
	public VkXYColorEXT DisplayPrimaryBlue;
	/// <summary></summary>
	public VkXYColorEXT WhitePoint;
	/// <summary></summary>
	public float MaxLuminance;
	/// <summary></summary>
	public float MinLuminance;
	/// <summary></summary>
	public float MaxContentLightLevel;
	/// <summary></summary>
	public float MaxFrameAverageLightLevel;
}
/// <summary></summary>
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 LocalDimmingSupport;
}
/// <summary></summary>
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 LocalDimmingEnable;
}
/// <summary></summary>
public unsafe struct VkRefreshCycleDurationGOOGLE
{
	/// <summary></summary>
	public ulong RefreshDuration;
}
/// <summary></summary>
public unsafe struct VkPastPresentationTimingGOOGLE
{
	/// <summary></summary>
	public uint PresentID;
	/// <summary></summary>
	public ulong DesiredPresentTime;
	/// <summary></summary>
	public ulong ActualPresentTime;
	/// <summary></summary>
	public ulong EarliestPresentTime;
	/// <summary></summary>
	public ulong PresentMargin;
}
/// <summary></summary>
public unsafe struct VkPresentTimesInfoGOOGLE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SwapchainCount;
	/// <summary></summary>
	public VkPresentTimeGOOGLE* Times;
}
/// <summary></summary>
public unsafe struct VkPresentTimeGOOGLE
{
	/// <summary></summary>
	public uint PresentID;
	/// <summary></summary>
	public ulong DesiredPresentTime;
}
/// <summary></summary>
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public void* View;
}
/// <summary></summary>
public unsafe struct VkViewportWScalingNV
{
	/// <summary></summary>
	public float Xcoeff;
	/// <summary></summary>
	public float Ycoeff;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ViewportWScalingEnable;
	/// <summary></summary>
	public uint ViewportCount;
	/// <summary></summary>
	public VkViewportWScalingNV* ViewportWScalings;
}
/// <summary></summary>
public unsafe struct VkViewportSwizzleNV
{
	/// <summary></summary>
	public VkViewportCoordinateSwizzleNV X;
	/// <summary></summary>
	public VkViewportCoordinateSwizzleNV Y;
	/// <summary></summary>
	public VkViewportCoordinateSwizzleNV Z;
	/// <summary></summary>
	public VkViewportCoordinateSwizzleNV W;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint ViewportCount;
	/// <summary></summary>
	public VkViewportSwizzleNV* ViewportSwizzles;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxDiscardRectangles;
}
/// <summary></summary>
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkDiscardRectangleModeEXT DiscardRectangleMode;
	/// <summary></summary>
	public uint DiscardRectangleCount;
	/// <summary></summary>
	public VkRect2D* DiscardRectangles;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PerViewPositionAllComponents;
}
/// <summary></summary>
public unsafe struct VkInputAttachmentAspectReference
{
	/// <summary></summary>
	public uint Subpass;
	/// <summary></summary>
	public uint InputAttachmentIndex;
	/// <summary></summary>
	public VkImageAspectFlags AspectMask;
}
/// <summary></summary>
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AspectReferenceCount;
	/// <summary></summary>
	public VkInputAttachmentAspectReference* AspectReferences;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceKHR Surface;
}
/// <summary></summary>
public unsafe struct VkSurfaceCapabilities2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceCapabilitiesKHR SurfaceCapabilities;
}
/// <summary></summary>
public unsafe struct VkSurfaceFormat2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceFormatKHR SurfaceFormat;
}
/// <summary></summary>
public unsafe struct VkDisplayProperties2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayPropertiesKHR DisplayProperties;
}
/// <summary></summary>
public unsafe struct VkDisplayPlaneProperties2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayPlanePropertiesKHR DisplayPlaneProperties;
}
/// <summary></summary>
public unsafe struct VkDisplayModeProperties2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayModePropertiesKHR DisplayModeProperties;
}
/// <summary></summary>
public unsafe struct VkDisplayPlaneInfo2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayModeKHR Mode;
	/// <summary></summary>
	public uint PlaneIndex;
}
/// <summary></summary>
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDisplayPlaneCapabilitiesKHR Capabilities;
}
/// <summary></summary>
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageUsageFlags SharedPresentSupportedUsageFlags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 StorageBuffer16BitAccess;
	/// <summary></summary>
	public VkBool32 UniformAndStorageBuffer16BitAccess;
	/// <summary></summary>
	public VkBool32 StoragePushConstant16;
	/// <summary></summary>
	public VkBool32 StorageInputOutput16;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SubgroupSize;
	/// <summary></summary>
	public VkShaderStageFlags SupportedStages;
	/// <summary></summary>
	public VkSubgroupFeatureFlags SupportedOperations;
	/// <summary></summary>
	public VkBool32 QuadOperationsInAllStages;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderSubgroupExtendedTypes;
}
/// <summary></summary>
public unsafe struct VkBufferMemoryRequirementsInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer Buffer;
}
/// <summary></summary>
public unsafe struct VkDeviceBufferMemoryRequirements
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBufferCreateInfo* CreateInfo;
}
/// <summary></summary>
public unsafe struct VkImageMemoryRequirementsInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage Image;
}
/// <summary></summary>
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage Image;
}
/// <summary></summary>
public unsafe struct VkDeviceImageMemoryRequirements
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageCreateInfo* CreateInfo;
	/// <summary></summary>
	public VkImageAspectFlags PlaneAspect;
}
/// <summary></summary>
public unsafe struct VkMemoryRequirements2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkMemoryRequirements MemoryRequirements;
}
/// <summary></summary>
public unsafe struct VkSparseImageMemoryRequirements2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSparseImageMemoryRequirements MemoryRequirements;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePointClippingProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPointClippingBehavior PointClippingBehavior;
}
/// <summary></summary>
public unsafe struct VkMemoryDedicatedRequirements
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PrefersDedicatedAllocation;
	/// <summary></summary>
	public VkBool32 RequiresDedicatedAllocation;
}
/// <summary></summary>
public unsafe struct VkMemoryDedicatedAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage Image;
	/// <summary></summary>
	public VkBuffer Buffer;
}
/// <summary></summary>
public unsafe struct VkImageViewUsageCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageUsageFlags Usage;
}
/// <summary></summary>
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkTessellationDomainOrigin DomainOrigin;
}
/// <summary></summary>
public unsafe struct VkSamplerYcbcrConversionInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSamplerYcbcrConversion Conversion;
}
/// <summary></summary>
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkSamplerYcbcrModelConversion YcbcrModel;
	/// <summary></summary>
	public VkSamplerYcbcrRange YcbcrRange;
	/// <summary></summary>
	public VkComponentMapping Components;
	/// <summary></summary>
	public VkChromaLocation XChromaOffset;
	/// <summary></summary>
	public VkChromaLocation YChromaOffset;
	/// <summary></summary>
	public VkFilter ChromaFilter;
	/// <summary></summary>
	public VkBool32 ForceExplicitReconstruction;
}
/// <summary></summary>
public unsafe struct VkBindImagePlaneMemoryInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageAspectFlags PlaneAspect;
}
/// <summary></summary>
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageAspectFlags PlaneAspect;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SamplerYcbcrConversion;
}
/// <summary></summary>
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint CombinedImageSamplerDescriptorCount;
}
/// <summary></summary>
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SupportsTextureGatherLODBiasAMD;
}
/// <summary></summary>
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer Buffer;
	/// <summary></summary>
	public VkDeviceSize Offset;
	/// <summary></summary>
	public VkConditionalRenderingFlagsEXT Flags;
}
/// <summary></summary>
public unsafe struct VkProtectedSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ProtectedSubmit;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ProtectedMemory;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ProtectedNoFault;
}
/// <summary></summary>
public unsafe struct VkDeviceQueueInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceQueueCreateFlags Flags;
	/// <summary></summary>
	public uint QueueFamilyIndex;
	/// <summary></summary>
	public uint QueueIndex;
}
/// <summary></summary>
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkBool32 CoverageToColorEnable;
	/// <summary></summary>
	public uint CoverageToColorLocation;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FilterMinmaxSingleComponentFormats;
	/// <summary></summary>
	public VkBool32 FilterMinmaxImageComponentMapping;
}
/// <summary></summary>
public unsafe struct VkSampleLocationEXT
{
	/// <summary></summary>
	public float X;
	/// <summary></summary>
	public float Y;
}
/// <summary></summary>
public unsafe struct VkSampleLocationsInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSampleCountFlags SampleLocationsPerPixel;
	/// <summary></summary>
	public VkExtent2D SampleLocationGridSize;
	/// <summary></summary>
	public uint SampleLocationsCount;
	/// <summary></summary>
	public VkSampleLocationEXT* SampleLocations;
}
/// <summary></summary>
public unsafe struct VkAttachmentSampleLocationsEXT
{
	/// <summary></summary>
	public uint AttachmentIndex;
	/// <summary></summary>
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
/// <summary></summary>
public unsafe struct VkSubpassSampleLocationsEXT
{
	/// <summary></summary>
	public uint SubpassIndex;
	/// <summary></summary>
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
/// <summary></summary>
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AttachmentInitialSampleLocationsCount;
	/// <summary></summary>
	public VkAttachmentSampleLocationsEXT* AttachmentInitialSampleLocations;
	/// <summary></summary>
	public uint PostSubpassSampleLocationsCount;
	/// <summary></summary>
	public VkSubpassSampleLocationsEXT* PostSubpassSampleLocations;
}
/// <summary></summary>
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SampleLocationsEnable;
	/// <summary></summary>
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSampleCountFlags SampleLocationSampleCounts;
	/// <summary></summary>
	public VkExtent2D MaxSampleLocationGridSize;
	/// <summary></summary>
	public fixed float SampleLocationCoordinateRange[2];
	/// <summary></summary>
	public uint SampleLocationSubPixelBits;
	/// <summary></summary>
	public VkBool32 VariableSampleLocations;
}
/// <summary></summary>
public unsafe struct VkMultisamplePropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D MaxSampleLocationGridSize;
}
/// <summary></summary>
public unsafe struct VkSamplerReductionModeCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSamplerReductionMode ReductionMode;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 AdvancedBlendCoherentOperations;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MultiDraw;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AdvancedBlendMaxColorAttachments;
	/// <summary></summary>
	public VkBool32 AdvancedBlendIndependentBlend;
	/// <summary></summary>
	public VkBool32 AdvancedBlendNonPremultipliedSourceColor;
	/// <summary></summary>
	public VkBool32 AdvancedBlendNonPremultipliedDestinationColor;
	/// <summary></summary>
	public VkBool32 AdvancedBlendCorrelatedOverlap;
	/// <summary></summary>
	public VkBool32 AdvancedBlendAllOperations;
}
/// <summary></summary>
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SourcePremultiplied;
	/// <summary></summary>
	public VkBool32 DestinationPremultiplied;
	/// <summary></summary>
	public VkBlendOverlapEXT BlendOverlap;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 InlineUniformBlock;
	/// <summary></summary>
	public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxInlineUniformBlockSize;
	/// <summary></summary>
	public uint MaxPerStageDescriptorInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxDescriptorSetInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
/// <summary></summary>
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DataSize;
	/// <summary></summary>
	public void* Data;
}
/// <summary></summary>
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxInlineUniformBlockBindings;
}
/// <summary></summary>
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkCoverageModulationModeNV CoverageModulationMode;
	/// <summary></summary>
	public VkBool32 CoverageModulationTableEnable;
	/// <summary></summary>
	public uint CoverageModulationTableCount;
	/// <summary></summary>
	public float* CoverageModulationTable;
}
/// <summary></summary>
public unsafe struct VkImageFormatListCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ViewFormatCount;
	/// <summary></summary>
	public VkFormat* ViewFormats;
}
/// <summary></summary>
public unsafe struct VkValidationCacheCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public nuint InitialDataSize;
	/// <summary></summary>
	public void* InitialData;
}
/// <summary></summary>
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkValidationCacheEXT ValidationCache;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxPerSetDescriptors;
	/// <summary></summary>
	public VkDeviceSize MaxMemoryAllocationSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Maintenance4;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize MaxBufferSize;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetLayoutSupport
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Supported;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderDrawParameters;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderFloat16;
	/// <summary></summary>
	public VkBool32 ShaderInt8;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkShaderFloatControlsIndependence DenormBehaviorIndependence;
	/// <summary></summary>
	public VkShaderFloatControlsIndependence RoundingModeIndependence;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat16;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat32;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat64;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat16;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat32;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat64;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat16;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat32;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat64;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat16;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat32;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat64;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat16;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat32;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat64;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 HostQueryReset;
}
/// <summary></summary>
public unsafe struct VkNativeBufferUsage2ANDROID
{
	/// <summary></summary>
	public ulong Consumer;
	/// <summary></summary>
	public ulong Producer;
}
/// <summary></summary>
public unsafe struct VkNativeBufferANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public void* Handle;
	/// <summary></summary>
	public int Stride;
	/// <summary></summary>
	public int Format;
	/// <summary></summary>
	public int Usage;
	/// <summary></summary>
	public VkNativeBufferUsage2ANDROID Usage2;
}
/// <summary></summary>
public unsafe struct VkSwapchainImageCreateInfoANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSwapchainImageUsageFlagsANDROID Usage;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePresentationPropertiesANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SharedImage;
}
/// <summary></summary>
public unsafe struct VkShaderResourceUsageAMD
{
	/// <summary></summary>
	public uint NumUsedVgprs;
	/// <summary></summary>
	public uint NumUsedSgprs;
	/// <summary></summary>
	public uint LdsSizePerLocalWorkGroup;
	/// <summary></summary>
	public nuint LdsUsageSizeInBytes;
	/// <summary></summary>
	public nuint ScratchMemUsageInBytes;
}
/// <summary></summary>
public unsafe struct VkShaderStatisticsInfoAMD
{
	/// <summary></summary>
	public VkShaderStageFlags ShaderStageMask;
	/// <summary></summary>
	public VkShaderResourceUsageAMD ResourceUsage;
	/// <summary></summary>
	public uint NumPhysicalVgprs;
	/// <summary></summary>
	public uint NumPhysicalSgprs;
	/// <summary></summary>
	public uint NumAvailableVgprs;
	/// <summary></summary>
	public uint NumAvailableSgprs;
	/// <summary></summary>
	public fixed uint ComputeWorkGroupSize[3];
}
/// <summary></summary>
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR GlobalPriority;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 GlobalPriorityQuery;
}
/// <summary></summary>
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint PriorityCount;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_0;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_1;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_2;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_3;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_4;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_5;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_6;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_7;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_8;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_9;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_10;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_11;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_12;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_13;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_14;
	/// <summary></summary>
	public VkQueueGlobalPriorityKHR Priorities_15;
}
/// <summary></summary>
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkObjectType ObjectType;
	/// <summary></summary>
	public ulong ObjectHandle;
	/// <summary></summary>
	public byte* ObjectName;
}
/// <summary></summary>
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkObjectType ObjectType;
	/// <summary></summary>
	public ulong ObjectHandle;
	/// <summary></summary>
	public ulong TagName;
	/// <summary></summary>
	public nuint TagSize;
	/// <summary></summary>
	public void* Tag;
}
/// <summary></summary>
public unsafe struct VkDebugUtilsLabelEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public byte* LabelName;
	/// <summary></summary>
	public fixed float Color[4];
}
/// <summary></summary>
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;
	/// <summary></summary>
	public VkDebugUtilsMessageTypeFlagsEXT MessageType;
	/// <summary></summary>
	public IntPtr UserCallback;
	/// <summary></summary>
	public void* UserData;
}
/// <summary></summary>
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public byte* MessageIdName;
	/// <summary></summary>
	public int MessageIdNumber;
	/// <summary></summary>
	public byte* Message;
	/// <summary></summary>
	public uint QueueLabelCount;
	/// <summary></summary>
	public VkDebugUtilsLabelEXT* QueueLabels;
	/// <summary></summary>
	public uint CommandBufLabelCount;
	/// <summary></summary>
	public VkDebugUtilsLabelEXT* CommandBufLabels;
	/// <summary></summary>
	public uint ObjectCount;
	/// <summary></summary>
	public VkDebugUtilsObjectNameInfoEXT* Objects;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DeviceMemoryReport;
}
/// <summary></summary>
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public IntPtr UserCallback;
	/// <summary></summary>
	public void* UserData;
}
/// <summary></summary>
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkDeviceMemoryReportEventTypeEXT Type;
	/// <summary></summary>
	public ulong MemoryObjectId;
	/// <summary></summary>
	public VkDeviceSize Size;
	/// <summary></summary>
	public VkObjectType ObjectType;
	/// <summary></summary>
	public ulong ObjectHandle;
	/// <summary></summary>
	public uint HeapIndex;
}
/// <summary></summary>
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
	/// <summary></summary>
	public void* HostPointer;
}
/// <summary></summary>
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MemoryTypeBits;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize MinImportedHostPointerAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public float PrimitiveOverestimationSize;
	/// <summary></summary>
	public float MaxExtraPrimitiveOverestimationSize;
	/// <summary></summary>
	public float ExtraPrimitiveOverestimationSizeGranularity;
	/// <summary></summary>
	public VkBool32 PrimitiveUnderestimation;
	/// <summary></summary>
	public VkBool32 ConservativePointAndLineRasterization;
	/// <summary></summary>
	public VkBool32 DegenerateTrianglesRasterized;
	/// <summary></summary>
	public VkBool32 DegenerateLinesRasterized;
	/// <summary></summary>
	public VkBool32 FullyCoveredFragmentShaderInputVariable;
	/// <summary></summary>
	public VkBool32 ConservativeRasterizationPostDepthCoverage;
}
/// <summary></summary>
public unsafe struct VkCalibratedTimestampInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkTimeDomainEXT TimeDomain;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ShaderEngineCount;
	/// <summary></summary>
	public uint ShaderArraysPerEngineCount;
	/// <summary></summary>
	public uint ComputeUnitsPerShaderArray;
	/// <summary></summary>
	public uint SimdPerComputeUnit;
	/// <summary></summary>
	public uint WavefrontsPerSimd;
	/// <summary></summary>
	public uint WavefrontSize;
	/// <summary></summary>
	public uint SgprsPerSimd;
	/// <summary></summary>
	public uint MinSgprAllocation;
	/// <summary></summary>
	public uint MaxSgprAllocation;
	/// <summary></summary>
	public uint SgprAllocationGranularity;
	/// <summary></summary>
	public uint VgprsPerSimd;
	/// <summary></summary>
	public uint MinVgprAllocation;
	/// <summary></summary>
	public uint MaxVgprAllocation;
	/// <summary></summary>
	public uint VgprAllocationGranularity;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
	/// <summary></summary>
	public uint ActiveComputeUnitCount;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkConservativeRasterizationModeEXT ConservativeRasterizationMode;
	/// <summary></summary>
	public float ExtraPrimitiveOverestimationSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderSampledImageArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingSampledImageUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageImageUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUpdateUnusedWhilePending;
	/// <summary></summary>
	public VkBool32 DescriptorBindingPartiallyBound;
	/// <summary></summary>
	public VkBool32 DescriptorBindingVariableDescriptorCount;
	/// <summary></summary>
	public VkBool32 RuntimeDescriptorArray;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxUpdateAfterBindDescriptorsInAllPools;
	/// <summary></summary>
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 RobustBufferAccessUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 QuadDivergentImplicitLod;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
	/// <summary></summary>
	public uint MaxPerStageUpdateAfterBindResources;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindSamplers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindSampledImages;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageImages;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint BindingCount;
	/// <summary></summary>
	public VkDescriptorBindingFlags* BindingFlags;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DescriptorSetCount;
	/// <summary></summary>
	public uint* DescriptorCounts;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxVariableDescriptorCount;
}
/// <summary></summary>
public unsafe struct VkAttachmentDescription2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAttachmentDescriptionFlags Flags;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public VkSampleCountFlags Samples;
	/// <summary></summary>
	public VkAttachmentLoadOp LoadOp;
	/// <summary></summary>
	public VkAttachmentStoreOp StoreOp;
	/// <summary></summary>
	public VkAttachmentLoadOp StencilLoadOp;
	/// <summary></summary>
	public VkAttachmentStoreOp StencilStoreOp;
	/// <summary></summary>
	public VkImageLayout InitialLayout;
	/// <summary></summary>
	public VkImageLayout FinalLayout;
}
/// <summary></summary>
public unsafe struct VkAttachmentReference2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Attachment;
	/// <summary></summary>
	public VkImageLayout Layout;
	/// <summary></summary>
	public VkImageAspectFlags AspectMask;
}
/// <summary></summary>
public unsafe struct VkSubpassDescription2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSubpassDescriptionFlags Flags;
	/// <summary></summary>
	public VkPipelineBindPoint PipelineBindPoint;
	/// <summary></summary>
	public uint ViewMask;
	/// <summary></summary>
	public uint InputAttachmentCount;
	/// <summary></summary>
	public VkAttachmentReference2* InputAttachments;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkAttachmentReference2* ColorAttachments;
	/// <summary></summary>
	public VkAttachmentReference2* ResolveAttachments;
	/// <summary></summary>
	public VkAttachmentReference2* DepthStencilAttachment;
	/// <summary></summary>
	public uint PreserveAttachmentCount;
	/// <summary></summary>
	public uint* PreserveAttachments;
}
/// <summary></summary>
public unsafe struct VkSubpassDependency2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint SourceSubpass;
	/// <summary></summary>
	public uint DestinationSubpass;
	/// <summary></summary>
	public VkPipelineStageFlags SourceStageMask;
	/// <summary></summary>
	public VkPipelineStageFlags DestinationStageMask;
	/// <summary></summary>
	public VkAccessFlags SourceAccessMask;
	/// <summary></summary>
	public VkAccessFlags DestinationAccessMask;
	/// <summary></summary>
	public VkDependencyFlags DependencyFlags;
	/// <summary></summary>
	public int ViewOffset;
}
/// <summary></summary>
public unsafe struct VkRenderPassCreateInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPassCreateFlags Flags;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkAttachmentDescription2* Attachments;
	/// <summary></summary>
	public uint SubpassCount;
	/// <summary></summary>
	public VkSubpassDescription2* Subpasses;
	/// <summary></summary>
	public uint DependencyCount;
	/// <summary></summary>
	public VkSubpassDependency2* Dependencies;
	/// <summary></summary>
	public uint CorrelatedViewMaskCount;
	/// <summary></summary>
	public uint* CorrelatedViewMasks;
}
/// <summary></summary>
public unsafe struct VkSubpassBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSubpassContents Contents;
}
/// <summary></summary>
public unsafe struct VkSubpassEndInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TimelineSemaphore;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong MaxTimelineSemaphoreValueDifference;
}
/// <summary></summary>
public unsafe struct VkSemaphoreTypeCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphoreType SemaphoreType;
	/// <summary></summary>
	public ulong InitialValue;
}
/// <summary></summary>
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint WaitSemaphoreValueCount;
	/// <summary></summary>
	public ulong* WaitSemaphoreValues;
	/// <summary></summary>
	public uint SignalSemaphoreValueCount;
	/// <summary></summary>
	public ulong* SignalSemaphoreValues;
}
/// <summary></summary>
public unsafe struct VkSemaphoreWaitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphoreWaitFlags Flags;
	/// <summary></summary>
	public uint SemaphoreCount;
	/// <summary></summary>
	public VkSemaphore* Semaphores;
	/// <summary></summary>
	public ulong* Values;
}
/// <summary></summary>
public unsafe struct VkSemaphoreSignalInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public ulong Value;
}
/// <summary></summary>
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public uint Divisor;
}
/// <summary></summary>
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint VertexBindingDivisorCount;
	/// <summary></summary>
	public VkVertexInputBindingDivisorDescriptionEXT* VertexBindingDivisors;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxVertexAttribDivisor;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint PciDomain;
	/// <summary></summary>
	public uint PciBus;
	/// <summary></summary>
	public uint PciDevice;
	/// <summary></summary>
	public uint PciFunction;
}
/// <summary></summary>
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public IntPtr* Buffer;
}
/// <summary></summary>
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong AndroidHardwareBufferUsage;
}
/// <summary></summary>
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize AllocationSize;
	/// <summary></summary>
	public uint MemoryTypeBits;
}
/// <summary></summary>
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceMemory Memory;
}
/// <summary></summary>
public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public ulong ExternalFormat;
	/// <summary></summary>
	public VkFormatFeatureFlags FormatFeatures;
	/// <summary></summary>
	public VkComponentMapping SamplerYcbcrConversionComponents;
	/// <summary></summary>
	public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
	/// <summary></summary>
	public VkSamplerYcbcrRange SuggestedYcbcrRange;
	/// <summary></summary>
	public VkChromaLocation SuggestedXChromaOffset;
	/// <summary></summary>
	public VkChromaLocation SuggestedYChromaOffset;
}
/// <summary></summary>
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ConditionalRenderingEnable;
}
/// <summary></summary>
public unsafe struct VkExternalFormatANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong ExternalFormat;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 StorageBuffer8BitAccess;
	/// <summary></summary>
	public VkBool32 UniformAndStorageBuffer8BitAccess;
	/// <summary></summary>
	public VkBool32 StoragePushConstant8;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ConditionalRendering;
	/// <summary></summary>
	public VkBool32 InheritedConditionalRendering;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModel;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModelDeviceScope;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderBufferInt64Atomics;
	/// <summary></summary>
	public VkBool32 ShaderSharedInt64Atomics;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat32Atomics;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat32AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat64Atomics;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat64AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat32Atomics;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat32AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat64Atomics;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat64AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderImageFloat32Atomics;
	/// <summary></summary>
	public VkBool32 ShaderImageFloat32AtomicAdd;
	/// <summary></summary>
	public VkBool32 SparseImageFloat32Atomics;
	/// <summary></summary>
	public VkBool32 SparseImageFloat32AtomicAdd;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat16Atomics;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat16AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat16AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat32AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderBufferFloat64AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat16Atomics;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat16AtomicAdd;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat16AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat32AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderSharedFloat64AtomicMinMax;
	/// <summary></summary>
	public VkBool32 ShaderImageFloat32AtomicMinMax;
	/// <summary></summary>
	public VkBool32 SparseImageFloat32AtomicMinMax;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 VertexAttributeInstanceRateDivisor;
	/// <summary></summary>
	public VkBool32 VertexAttributeInstanceRateZeroDivisor;
}
/// <summary></summary>
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags CheckpointExecutionStageMask;
}
/// <summary></summary>
public unsafe struct VkCheckpointDataNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags Stage;
	/// <summary></summary>
	public void* CheckpointMarker;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkResolveModeFlags SupportedDepthResolveModes;
	/// <summary></summary>
	public VkResolveModeFlags SupportedStencilResolveModes;
	/// <summary></summary>
	public VkBool32 IndependentResolveNone;
	/// <summary></summary>
	public VkBool32 IndependentResolve;
}
/// <summary></summary>
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkResolveModeFlags DepthResolveMode;
	/// <summary></summary>
	public VkResolveModeFlags StencilResolveMode;
	/// <summary></summary>
	public VkAttachmentReference2* DepthStencilResolveAttachment;
}
/// <summary></summary>
public unsafe struct VkImageViewASTCDecodeModeEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat DecodeMode;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DecodeModeSharedExponent;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TransformFeedback;
	/// <summary></summary>
	public VkBool32 GeometryStreams;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxTransformFeedbackStreams;
	/// <summary></summary>
	public uint MaxTransformFeedbackBuffers;
	/// <summary></summary>
	public VkDeviceSize MaxTransformFeedbackBufferSize;
	/// <summary></summary>
	public uint MaxTransformFeedbackStreamDataSize;
	/// <summary></summary>
	public uint MaxTransformFeedbackBufferDataSize;
	/// <summary></summary>
	public uint MaxTransformFeedbackBufferDataStride;
	/// <summary></summary>
	public VkBool32 TransformFeedbackQueries;
	/// <summary></summary>
	public VkBool32 TransformFeedbackStreamsLinesTriangles;
	/// <summary></summary>
	public VkBool32 TransformFeedbackRasterizationStreamSelect;
	/// <summary></summary>
	public VkBool32 TransformFeedbackDraw;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public uint RasterizationStream;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RepresentativeFragmentTest;
}
/// <summary></summary>
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RepresentativeFragmentTestEnable;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ExclusiveScissor;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ExclusiveScissorCount;
	/// <summary></summary>
	public VkRect2D* ExclusiveScissors;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 CornerSampledImage;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ComputeDerivativeGroupQuads;
	/// <summary></summary>
	public VkBool32 ComputeDerivativeGroupLinear;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ImageFootprint;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DedicatedAllocationImageAliasing;
}
/// <summary></summary>
public unsafe struct VkShadingRatePaletteNV
{
	/// <summary></summary>
	public uint ShadingRatePaletteEntryCount;
	/// <summary></summary>
	public VkShadingRatePaletteEntryNV* ShadingRatePaletteEntries;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShadingRateImageEnable;
	/// <summary></summary>
	public uint ViewportCount;
	/// <summary></summary>
	public VkShadingRatePaletteNV* ShadingRatePalettes;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShadingRateImage;
	/// <summary></summary>
	public VkBool32 ShadingRateCoarseSampleOrder;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D ShadingRateTexelSize;
	/// <summary></summary>
	public uint ShadingRatePaletteSize;
	/// <summary></summary>
	public uint ShadingRateMaxCoarseSamples;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 InvocationMask;
}
/// <summary></summary>
public unsafe struct VkCoarseSampleLocationNV
{
	/// <summary></summary>
	public uint PixelX;
	/// <summary></summary>
	public uint PixelY;
	/// <summary></summary>
	public uint Sample;
}
/// <summary></summary>
public unsafe struct VkCoarseSampleOrderCustomNV
{
	/// <summary></summary>
	public VkShadingRatePaletteEntryNV ShadingRate;
	/// <summary></summary>
	public uint SampleCount;
	/// <summary></summary>
	public uint SampleLocationCount;
	/// <summary></summary>
	public VkCoarseSampleLocationNV* SampleLocations;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCoarseSampleOrderTypeNV SampleOrderType;
	/// <summary></summary>
	public uint CustomSampleOrderCount;
	/// <summary></summary>
	public VkCoarseSampleOrderCustomNV* CustomSampleOrders;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TaskShader;
	/// <summary></summary>
	public VkBool32 MeshShader;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxDrawMeshTasksCount;
	/// <summary></summary>
	public uint MaxTaskWorkGroupInvocations;
	/// <summary></summary>
	public fixed uint MaxTaskWorkGroupSize[3];
	/// <summary></summary>
	public uint MaxTaskTotalMemorySize;
	/// <summary></summary>
	public uint MaxTaskOutputCount;
	/// <summary></summary>
	public uint MaxMeshWorkGroupInvocations;
	/// <summary></summary>
	public fixed uint MaxMeshWorkGroupSize[3];
	/// <summary></summary>
	public uint MaxMeshTotalMemorySize;
	/// <summary></summary>
	public uint MaxMeshOutputVertices;
	/// <summary></summary>
	public uint MaxMeshOutputPrimitives;
	/// <summary></summary>
	public uint MaxMeshMultiviewViewCount;
	/// <summary></summary>
	public uint MeshOutputPerVertexGranularity;
	/// <summary></summary>
	public uint MeshOutputPerPrimitiveGranularity;
}
/// <summary></summary>
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
	/// <summary></summary>
	public uint TaskCount;
	/// <summary></summary>
	public uint FirstTask;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TaskShader;
	/// <summary></summary>
	public VkBool32 MeshShader;
	/// <summary></summary>
	public VkBool32 MultiviewMeshShader;
	/// <summary></summary>
	public VkBool32 PrimitiveFragmentShadingRateMeshShader;
	/// <summary></summary>
	public VkBool32 MeshShaderQueries;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxTaskWorkGroupTotalCount;
	/// <summary></summary>
	public fixed uint MaxTaskWorkGroupCount[3];
	/// <summary></summary>
	public uint MaxTaskWorkGroupInvocations;
	/// <summary></summary>
	public fixed uint MaxTaskWorkGroupSize[3];
	/// <summary></summary>
	public uint MaxTaskPayloadSize;
	/// <summary></summary>
	public uint MaxTaskSharedMemorySize;
	/// <summary></summary>
	public uint MaxTaskPayloadAndSharedMemorySize;
	/// <summary></summary>
	public uint MaxMeshWorkGroupTotalCount;
	/// <summary></summary>
	public fixed uint MaxMeshWorkGroupCount[3];
	/// <summary></summary>
	public uint MaxMeshWorkGroupInvocations;
	/// <summary></summary>
	public fixed uint MaxMeshWorkGroupSize[3];
	/// <summary></summary>
	public uint MaxMeshSharedMemorySize;
	/// <summary></summary>
	public uint MaxMeshPayloadAndSharedMemorySize;
	/// <summary></summary>
	public uint MaxMeshOutputMemorySize;
	/// <summary></summary>
	public uint MaxMeshPayloadAndOutputMemorySize;
	/// <summary></summary>
	public uint MaxMeshOutputComponents;
	/// <summary></summary>
	public uint MaxMeshOutputVertices;
	/// <summary></summary>
	public uint MaxMeshOutputPrimitives;
	/// <summary></summary>
	public uint MaxMeshOutputLayers;
	/// <summary></summary>
	public uint MaxMeshMultiviewViewCount;
	/// <summary></summary>
	public uint MeshOutputPerVertexGranularity;
	/// <summary></summary>
	public uint MeshOutputPerPrimitiveGranularity;
	/// <summary></summary>
	public uint MaxPreferredTaskWorkGroupInvocations;
	/// <summary></summary>
	public uint MaxPreferredMeshWorkGroupInvocations;
	/// <summary></summary>
	public VkBool32 PrefersLocalInvocationVertexOutput;
	/// <summary></summary>
	public VkBool32 PrefersLocalInvocationPrimitiveOutput;
	/// <summary></summary>
	public VkBool32 PrefersCompactVertexOutput;
	/// <summary></summary>
	public VkBool32 PrefersCompactPrimitiveOutput;
}
/// <summary></summary>
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
	/// <summary></summary>
	public uint GroupCountX;
	/// <summary></summary>
	public uint GroupCountY;
	/// <summary></summary>
	public uint GroupCountZ;
}
/// <summary></summary>
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRayTracingShaderGroupTypeKHR Type;
	/// <summary></summary>
	public uint GeneralShader;
	/// <summary></summary>
	public uint ClosestHitShader;
	/// <summary></summary>
	public uint AnyHitShader;
	/// <summary></summary>
	public uint IntersectionShader;
}
/// <summary></summary>
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRayTracingShaderGroupTypeKHR Type;
	/// <summary></summary>
	public uint GeneralShader;
	/// <summary></summary>
	public uint ClosestHitShader;
	/// <summary></summary>
	public uint AnyHitShader;
	/// <summary></summary>
	public uint IntersectionShader;
	/// <summary></summary>
	public void* ShaderGroupCaptureReplayHandle;
}
/// <summary></summary>
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCreateFlags Flags;
	/// <summary></summary>
	public uint StageCount;
	/// <summary></summary>
	public VkPipelineShaderStageCreateInfo* Stages;
	/// <summary></summary>
	public uint GroupCount;
	/// <summary></summary>
	public VkRayTracingShaderGroupCreateInfoNV* Groups;
	/// <summary></summary>
	public uint MaxRecursionDepth;
	/// <summary></summary>
	public VkPipelineLayout Layout;
	/// <summary></summary>
	public VkPipeline BasePipelineHandle;
	/// <summary></summary>
	public int BasePipelineIndex;
}
/// <summary></summary>
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCreateFlags Flags;
	/// <summary></summary>
	public uint StageCount;
	/// <summary></summary>
	public VkPipelineShaderStageCreateInfo* Stages;
	/// <summary></summary>
	public uint GroupCount;
	/// <summary></summary>
	public VkRayTracingShaderGroupCreateInfoKHR* Groups;
	/// <summary></summary>
	public uint MaxPipelineRayRecursionDepth;
	/// <summary></summary>
	public VkPipelineLibraryCreateInfoKHR* LibraryInfo;
	/// <summary></summary>
	public VkRayTracingPipelineInterfaceCreateInfoKHR* LibraryInterface;
	/// <summary></summary>
	public VkPipelineDynamicStateCreateInfo* DynamicState;
	/// <summary></summary>
	public VkPipelineLayout Layout;
	/// <summary></summary>
	public VkPipeline BasePipelineHandle;
	/// <summary></summary>
	public int BasePipelineIndex;
}
/// <summary></summary>
public unsafe struct VkGeometryTrianglesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer VertexData;
	/// <summary></summary>
	public VkDeviceSize VertexOffset;
	/// <summary></summary>
	public uint VertexCount;
	/// <summary></summary>
	public VkDeviceSize VertexStride;
	/// <summary></summary>
	public VkFormat VertexFormat;
	/// <summary></summary>
	public VkBuffer IndexData;
	/// <summary></summary>
	public VkDeviceSize IndexOffset;
	/// <summary></summary>
	public uint IndexCount;
	/// <summary></summary>
	public VkIndexType IndexType;
	/// <summary></summary>
	public VkBuffer TransformData;
	/// <summary></summary>
	public VkDeviceSize TransformOffset;
}
/// <summary></summary>
public unsafe struct VkGeometryAABBNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer AabbData;
	/// <summary></summary>
	public uint NumAABBs;
	/// <summary></summary>
	public uint Stride;
	/// <summary></summary>
	public VkDeviceSize Offset;
}
/// <summary></summary>
public unsafe struct VkGeometryDataNV
{
	/// <summary></summary>
	public VkGeometryTrianglesNV Triangles;
	/// <summary></summary>
	public VkGeometryAABBNV Aabbs;
}
/// <summary></summary>
public unsafe struct VkGeometryNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkGeometryTypeKHR GeometryType;
	/// <summary></summary>
	public VkGeometryDataNV Geometry;
	/// <summary></summary>
	public VkGeometryFlagsKHR Flags;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureTypeKHR Type;
	/// <summary></summary>
	public VkBuildAccelerationStructureFlagsKHR Flags;
	/// <summary></summary>
	public uint InstanceCount;
	/// <summary></summary>
	public uint GeometryCount;
	/// <summary></summary>
	public VkGeometryNV* Geometries;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize CompactedSize;
	/// <summary></summary>
	public VkAccelerationStructureInfoNV Info;
}
/// <summary></summary>
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureNV AccelerationStructure;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkDeviceSize MemoryOffset;
	/// <summary></summary>
	public uint DeviceIndexCount;
	/// <summary></summary>
	public uint* DeviceIndices;
}
/// <summary></summary>
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AccelerationStructureCount;
	/// <summary></summary>
	public VkAccelerationStructureKHR* AccelerationStructures;
}
/// <summary></summary>
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AccelerationStructureCount;
	/// <summary></summary>
	public VkAccelerationStructureNV* AccelerationStructures;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureMemoryRequirementsTypeNV Type;
	/// <summary></summary>
	public VkAccelerationStructureNV AccelerationStructure;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 AccelerationStructure;
	/// <summary></summary>
	public VkBool32 AccelerationStructureCaptureReplay;
	/// <summary></summary>
	public VkBool32 AccelerationStructureIndirectBuild;
	/// <summary></summary>
	public VkBool32 AccelerationStructureHostCommands;
	/// <summary></summary>
	public VkBool32 DescriptorBindingAccelerationStructureUpdateAfterBind;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RayTracingPipeline;
	/// <summary></summary>
	public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplay;
	/// <summary></summary>
	public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplayMixed;
	/// <summary></summary>
	public VkBool32 RayTracingPipelineTraceRaysIndirect;
	/// <summary></summary>
	public VkBool32 RayTraversalPrimitiveCulling;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RayQuery;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong MaxGeometryCount;
	/// <summary></summary>
	public ulong MaxInstanceCount;
	/// <summary></summary>
	public ulong MaxPrimitiveCount;
	/// <summary></summary>
	public uint MaxPerStageDescriptorAccelerationStructures;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
	/// <summary></summary>
	public uint MaxDescriptorSetAccelerationStructures;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;
	/// <summary></summary>
	public uint MinAccelerationStructureScratchOffsetAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ShaderGroupHandleSize;
	/// <summary></summary>
	public uint MaxRayRecursionDepth;
	/// <summary></summary>
	public uint MaxShaderGroupStride;
	/// <summary></summary>
	public uint ShaderGroupBaseAlignment;
	/// <summary></summary>
	public uint ShaderGroupHandleCaptureReplaySize;
	/// <summary></summary>
	public uint MaxRayDispatchInvocationCount;
	/// <summary></summary>
	public uint ShaderGroupHandleAlignment;
	/// <summary></summary>
	public uint MaxRayHitAttributeSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ShaderGroupHandleSize;
	/// <summary></summary>
	public uint MaxRecursionDepth;
	/// <summary></summary>
	public uint MaxShaderGroupStride;
	/// <summary></summary>
	public uint ShaderGroupBaseAlignment;
	/// <summary></summary>
	public ulong MaxGeometryCount;
	/// <summary></summary>
	public ulong MaxInstanceCount;
	/// <summary></summary>
	public ulong MaxTriangleCount;
	/// <summary></summary>
	public uint MaxDescriptorSetAccelerationStructures;
}
/// <summary></summary>
public unsafe struct VkStridedDeviceAddressRegionKHR
{
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
	/// <summary></summary>
	public VkDeviceSize Stride;
	/// <summary></summary>
	public VkDeviceSize Size;
}
/// <summary></summary>
public unsafe struct VkTraceRaysIndirectCommandKHR
{
	/// <summary></summary>
	public uint Width;
	/// <summary></summary>
	public uint Height;
	/// <summary></summary>
	public uint Depth;
}
/// <summary></summary>
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
	/// <summary></summary>
	public VkDeviceAddress RaygenShaderRecordAddress;
	/// <summary></summary>
	public VkDeviceSize RaygenShaderRecordSize;
	/// <summary></summary>
	public VkDeviceAddress MissShaderBindingTableAddress;
	/// <summary></summary>
	public VkDeviceSize MissShaderBindingTableSize;
	/// <summary></summary>
	public VkDeviceSize MissShaderBindingTableStride;
	/// <summary></summary>
	public VkDeviceAddress HitShaderBindingTableAddress;
	/// <summary></summary>
	public VkDeviceSize HitShaderBindingTableSize;
	/// <summary></summary>
	public VkDeviceSize HitShaderBindingTableStride;
	/// <summary></summary>
	public VkDeviceAddress CallableShaderBindingTableAddress;
	/// <summary></summary>
	public VkDeviceSize CallableShaderBindingTableSize;
	/// <summary></summary>
	public VkDeviceSize CallableShaderBindingTableStride;
	/// <summary></summary>
	public uint Width;
	/// <summary></summary>
	public uint Height;
	/// <summary></summary>
	public uint Depth;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RayTracingMaintenance1;
	/// <summary></summary>
	public VkBool32 RayTracingPipelineTraceRaysIndirect2;
}
/// <summary></summary>
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DrmFormatModifierCount;
	/// <summary></summary>
	public VkDrmFormatModifierPropertiesEXT* DrmFormatModifierProperties;
}
/// <summary></summary>
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
	/// <summary></summary>
	public ulong DrmFormatModifier;
	/// <summary></summary>
	public uint DrmFormatModifierPlaneCount;
	/// <summary></summary>
	public VkFormatFeatureFlags DrmFormatModifierTilingFeatures;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong DrmFormatModifier;
	/// <summary></summary>
	public VkSharingMode SharingMode;
	/// <summary></summary>
	public uint QueueFamilyIndexCount;
	/// <summary></summary>
	public uint* QueueFamilyIndices;
}
/// <summary></summary>
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DrmFormatModifierCount;
	/// <summary></summary>
	public ulong* DrmFormatModifiers;
}
/// <summary></summary>
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong DrmFormatModifier;
	/// <summary></summary>
	public uint DrmFormatModifierPlaneCount;
	/// <summary></summary>
	public VkSubresourceLayout* PlaneLayouts;
}
/// <summary></summary>
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong DrmFormatModifier;
}
/// <summary></summary>
public unsafe struct VkImageStencilUsageCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageUsageFlags StencilUsage;
}
/// <summary></summary>
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkMemoryOverallocationBehaviorAMD OverallocationBehavior;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentDensityMap;
	/// <summary></summary>
	public VkBool32 FragmentDensityMapDynamic;
	/// <summary></summary>
	public VkBool32 FragmentDensityMapNonSubsampledImages;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentDensityMapDeferred;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentDensityMapOffset;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D MinFragmentDensityTexelSize;
	/// <summary></summary>
	public VkExtent2D MaxFragmentDensityTexelSize;
	/// <summary></summary>
	public VkBool32 FragmentDensityInvocations;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SubsampledLoads;
	/// <summary></summary>
	public VkBool32 SubsampledCoarseReconstructionEarlyAccess;
	/// <summary></summary>
	public uint MaxSubsampledArrayLayers;
	/// <summary></summary>
	public uint MaxDescriptorSetSubsampledSamplers;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D FragmentDensityOffsetGranularity;
}
/// <summary></summary>
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAttachmentReference FragmentDensityMapAttachment;
}
/// <summary></summary>
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint FragmentDensityOffsetCount;
	/// <summary></summary>
	public VkOffset2D* FragmentDensityOffsets;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ScalarBlockLayout;
}
/// <summary></summary>
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SupportsProtected;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 UniformBufferStandardLayout;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DepthClipEnable;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkBool32 DepthClipEnable;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_0;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_1;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_2;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_3;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_4;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_5;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_6;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_7;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_8;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_9;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_10;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_11;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_12;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_13;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_14;
	/// <summary></summary>
	public VkDeviceSize HeapBudget_15;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_0;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_1;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_2;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_3;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_4;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_5;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_6;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_7;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_8;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_9;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_10;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_11;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_12;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_13;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_14;
	/// <summary></summary>
	public VkDeviceSize HeapUsage_15;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MemoryPriority;
}
/// <summary></summary>
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public float Priority;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PageableDeviceLocalMemory;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddress;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressCaptureReplay;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressMultiDevice;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddress;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressCaptureReplay;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressMultiDevice;
}
/// <summary></summary>
public unsafe struct VkBufferDeviceAddressInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer Buffer;
}
/// <summary></summary>
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong OpaqueCaptureAddress;
}
/// <summary></summary>
public unsafe struct VkBufferDeviceAddressCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageViewType ImageViewType;
}
/// <summary></summary>
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FilterCubic;
	/// <summary></summary>
	public VkBool32 FilterCubicMinmax;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ImagelessFramebuffer;
}
/// <summary></summary>
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AttachmentImageInfoCount;
	/// <summary></summary>
	public VkFramebufferAttachmentImageInfo* AttachmentImageInfos;
}
/// <summary></summary>
public unsafe struct VkFramebufferAttachmentImageInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageCreateFlags Flags;
	/// <summary></summary>
	public VkImageUsageFlags Usage;
	/// <summary></summary>
	public uint Width;
	/// <summary></summary>
	public uint Height;
	/// <summary></summary>
	public uint LayerCount;
	/// <summary></summary>
	public uint ViewFormatCount;
	/// <summary></summary>
	public VkFormat* ViewFormats;
}
/// <summary></summary>
public unsafe struct VkRenderPassAttachmentBeginInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkImageView* Attachments;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TextureCompressionASTC_HDR;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 CooperativeMatrix;
	/// <summary></summary>
	public VkBool32 CooperativeMatrixRobustBufferAccess;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkShaderStageFlags CooperativeMatrixSupportedStages;
}
/// <summary></summary>
public unsafe struct VkCooperativeMatrixPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MSize;
	/// <summary></summary>
	public uint NSize;
	/// <summary></summary>
	public uint KSize;
	/// <summary></summary>
	public VkComponentTypeNV AType;
	/// <summary></summary>
	public VkComponentTypeNV BType;
	/// <summary></summary>
	public VkComponentTypeNV CType;
	/// <summary></summary>
	public VkComponentTypeNV DType;
	/// <summary></summary>
	public VkScopeNV Scope;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 YcbcrImageArrays;
}
/// <summary></summary>
public unsafe struct VkImageViewHandleInfoNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageView ImageView;
	/// <summary></summary>
	public VkDescriptorType DescriptorType;
	/// <summary></summary>
	public VkSampler Sampler;
}
/// <summary></summary>
public unsafe struct VkImageViewAddressPropertiesNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
	/// <summary></summary>
	public VkDeviceSize Size;
}
/// <summary></summary>
public unsafe struct VkPipelineCreationFeedback
{
	/// <summary></summary>
	public VkPipelineCreationFeedbackFlags Flags;
	/// <summary></summary>
	public ulong Duration;
}
/// <summary></summary>
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCreationFeedback* PipelineCreationFeedback;
	/// <summary></summary>
	public uint PipelineStageCreationFeedbackCount;
	/// <summary></summary>
	public VkPipelineCreationFeedback** PipelineStageCreationFeedbacks;
}
/// <summary></summary>
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFullScreenExclusiveEXT FullScreenExclusive;
}
/// <summary></summary>
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public IntPtr Hmonitor;
}
/// <summary></summary>
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FullScreenExclusiveSupported;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PerformanceCounterQueryPools;
	/// <summary></summary>
	public VkBool32 PerformanceCounterMultipleQueryPools;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 AllowCommandBufferQueryCopies;
}
/// <summary></summary>
public unsafe struct VkPerformanceCounterKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPerformanceCounterUnitKHR Unit;
	/// <summary></summary>
	public VkPerformanceCounterScopeKHR Scope;
	/// <summary></summary>
	public VkPerformanceCounterStorageKHR Storage;
	/// <summary></summary>
	public fixed byte Uuid[(int)VK.UuidSize];
}
/// <summary></summary>
public unsafe struct VkPerformanceCounterDescriptionKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPerformanceCounterDescriptionFlagsKHR Flags;
	/// <summary></summary>
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Category[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
}
/// <summary></summary>
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint QueueFamilyIndex;
	/// <summary></summary>
	public uint CounterIndexCount;
	/// <summary></summary>
	public uint* CounterIndices;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkPerformanceCounterResultKHR
{
	[FieldOffset(0)]
	/// <summary></summary>
	public int Int32;
	[FieldOffset(0)]
	/// <summary></summary>
	public long Int64;
	[FieldOffset(0)]
	/// <summary></summary>
	public uint Uint32;
	[FieldOffset(0)]
	/// <summary></summary>
	public ulong Uint64;
	[FieldOffset(0)]
	/// <summary></summary>
	public float Float32;
	[FieldOffset(0)]
	/// <summary></summary>
	public double Float64;
}
/// <summary></summary>
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAcquireProfilingLockFlagsKHR Flags;
	/// <summary></summary>
	public ulong Timeout;
}
/// <summary></summary>
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint CounterPassIndex;
}
/// <summary></summary>
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 CoverageReductionMode;
}
/// <summary></summary>
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkCoverageReductionModeNV CoverageReductionMode;
}
/// <summary></summary>
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCoverageReductionModeNV CoverageReductionMode;
	/// <summary></summary>
	public VkSampleCountFlags RasterizationSamples;
	/// <summary></summary>
	public VkSampleCountFlags DepthStencilSamples;
	/// <summary></summary>
	public VkSampleCountFlags ColorSamples;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderIntegerFunctions2;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkPerformanceValueDataINTEL
{
	[FieldOffset(0)]
	/// <summary></summary>
	public uint Value32;
	[FieldOffset(0)]
	/// <summary></summary>
	public ulong Value64;
	[FieldOffset(0)]
	/// <summary></summary>
	public float ValueFloat;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkBool32 ValueBool;
	[FieldOffset(0)]
	/// <summary></summary>
	public byte* ValueString;
}
/// <summary></summary>
public unsafe struct VkPerformanceValueINTEL
{
	/// <summary></summary>
	public VkPerformanceValueTypeINTEL Type;
	/// <summary></summary>
	public VkPerformanceValueDataINTEL Data;
}
/// <summary></summary>
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public void* UserData;
}
/// <summary></summary>
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
}
/// <summary></summary>
public unsafe struct VkPerformanceMarkerInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong Marker;
}
/// <summary></summary>
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Marker;
}
/// <summary></summary>
public unsafe struct VkPerformanceOverrideInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPerformanceOverrideTypeINTEL Type;
	/// <summary></summary>
	public VkBool32 Enable;
	/// <summary></summary>
	public ulong Parameter;
}
/// <summary></summary>
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPerformanceConfigurationTypeINTEL Type;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderSubgroupClock;
	/// <summary></summary>
	public VkBool32 ShaderDeviceClock;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 IndexTypeUint8;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ShaderSMCount;
	/// <summary></summary>
	public uint ShaderWarpsPerSM;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderSMBuiltins;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentShaderSampleInterlock;
	/// <summary></summary>
	public VkBool32 FragmentShaderPixelInterlock;
	/// <summary></summary>
	public VkBool32 FragmentShaderShadingRateInterlock;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SeparateDepthStencilLayouts;
}
/// <summary></summary>
public unsafe struct VkAttachmentReferenceStencilLayout
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageLayout StencilLayout;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PrimitiveTopologyListRestart;
	/// <summary></summary>
	public VkBool32 PrimitiveTopologyPatchListRestart;
}
/// <summary></summary>
public unsafe struct VkAttachmentDescriptionStencilLayout
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageLayout StencilInitialLayout;
	/// <summary></summary>
	public VkImageLayout StencilFinalLayout;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PipelineExecutableInfo;
}
/// <summary></summary>
public unsafe struct VkPipelineInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipeline Pipeline;
}
/// <summary></summary>
public unsafe struct VkPipelineExecutablePropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkShaderStageFlags Stages;
	/// <summary></summary>
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public uint SubgroupSize;
}
/// <summary></summary>
public unsafe struct VkPipelineExecutableInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipeline Pipeline;
	/// <summary></summary>
	public uint ExecutableIndex;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkBool32 B32;
	[FieldOffset(0)]
	/// <summary></summary>
	public long I64;
	[FieldOffset(0)]
	/// <summary></summary>
	public ulong U64;
	[FieldOffset(0)]
	/// <summary></summary>
	public double F64;
}
/// <summary></summary>
public unsafe struct VkPipelineExecutableStatisticKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public VkPipelineExecutableStatisticFormatKHR Format;
	/// <summary></summary>
	public VkPipelineExecutableStatisticValueKHR Value;
}
/// <summary></summary>
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public VkBool32 IsText;
	/// <summary></summary>
	public nuint DataSize;
	/// <summary></summary>
	public void* Data;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderDemoteToHelperInvocation;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TexelBufferAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
	/// <summary></summary>
	public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
	/// <summary></summary>
	public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
	/// <summary></summary>
	public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SubgroupSizeControl;
	/// <summary></summary>
	public VkBool32 ComputeFullSubgroups;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MinSubgroupSize;
	/// <summary></summary>
	public uint MaxSubgroupSize;
	/// <summary></summary>
	public uint MaxComputeWorkgroupSubgroups;
	/// <summary></summary>
	public VkShaderStageFlags RequiredSubgroupSizeStages;
}
/// <summary></summary>
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint RequiredSubgroupSize;
}
/// <summary></summary>
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPass RenderPass;
	/// <summary></summary>
	public uint Subpass;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxSubpassShadingWorkgroupSizeAspectRatio;
}
/// <summary></summary>
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong OpaqueCaptureAddress;
}
/// <summary></summary>
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceMemory Memory;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RectangularLines;
	/// <summary></summary>
	public VkBool32 BresenhamLines;
	/// <summary></summary>
	public VkBool32 SmoothLines;
	/// <summary></summary>
	public VkBool32 StippledRectangularLines;
	/// <summary></summary>
	public VkBool32 StippledBresenhamLines;
	/// <summary></summary>
	public VkBool32 StippledSmoothLines;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint LineSubPixelPrecisionBits;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkLineRasterizationModeEXT LineRasterizationMode;
	/// <summary></summary>
	public VkBool32 StippledLineEnable;
	/// <summary></summary>
	public uint LineStippleFactor;
	/// <summary></summary>
	public ushort LineStipplePattern;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PipelineCreationCacheControl;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan11Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 StorageBuffer16BitAccess;
	/// <summary></summary>
	public VkBool32 UniformAndStorageBuffer16BitAccess;
	/// <summary></summary>
	public VkBool32 StoragePushConstant16;
	/// <summary></summary>
	public VkBool32 StorageInputOutput16;
	/// <summary></summary>
	public VkBool32 Multiview;
	/// <summary></summary>
	public VkBool32 MultiviewGeometryShader;
	/// <summary></summary>
	public VkBool32 MultiviewTessellationShader;
	/// <summary></summary>
	public VkBool32 VariablePointersStorageBuffer;
	/// <summary></summary>
	public VkBool32 VariablePointers;
	/// <summary></summary>
	public VkBool32 ProtectedMemory;
	/// <summary></summary>
	public VkBool32 SamplerYcbcrConversion;
	/// <summary></summary>
	public VkBool32 ShaderDrawParameters;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	/// <summary></summary>
	public fixed byte DriverUUID[(int)VK.UuidSize];
	/// <summary></summary>
	public fixed byte DeviceLUID[(int)VK.LuidSize];
	/// <summary></summary>
	public uint DeviceNodeMask;
	/// <summary></summary>
	public VkBool32 DeviceLUIDValid;
	/// <summary></summary>
	public uint SubgroupSize;
	/// <summary></summary>
	public VkShaderStageFlags SubgroupSupportedStages;
	/// <summary></summary>
	public VkSubgroupFeatureFlags SubgroupSupportedOperations;
	/// <summary></summary>
	public VkBool32 SubgroupQuadOperationsInAllStages;
	/// <summary></summary>
	public VkPointClippingBehavior PointClippingBehavior;
	/// <summary></summary>
	public uint MaxMultiviewViewCount;
	/// <summary></summary>
	public uint MaxMultiviewInstanceIndex;
	/// <summary></summary>
	public VkBool32 ProtectedNoFault;
	/// <summary></summary>
	public uint MaxPerSetDescriptors;
	/// <summary></summary>
	public VkDeviceSize MaxMemoryAllocationSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan12Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SamplerMirrorClampToEdge;
	/// <summary></summary>
	public VkBool32 DrawIndirectCount;
	/// <summary></summary>
	public VkBool32 StorageBuffer8BitAccess;
	/// <summary></summary>
	public VkBool32 UniformAndStorageBuffer8BitAccess;
	/// <summary></summary>
	public VkBool32 StoragePushConstant8;
	/// <summary></summary>
	public VkBool32 ShaderBufferInt64Atomics;
	/// <summary></summary>
	public VkBool32 ShaderSharedInt64Atomics;
	/// <summary></summary>
	public VkBool32 ShaderFloat16;
	/// <summary></summary>
	public VkBool32 ShaderInt8;
	/// <summary></summary>
	public VkBool32 DescriptorIndexing;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderSampledImageArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingSampledImageUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageImageUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 DescriptorBindingUpdateUnusedWhilePending;
	/// <summary></summary>
	public VkBool32 DescriptorBindingPartiallyBound;
	/// <summary></summary>
	public VkBool32 DescriptorBindingVariableDescriptorCount;
	/// <summary></summary>
	public VkBool32 RuntimeDescriptorArray;
	/// <summary></summary>
	public VkBool32 SamplerFilterMinmax;
	/// <summary></summary>
	public VkBool32 ScalarBlockLayout;
	/// <summary></summary>
	public VkBool32 ImagelessFramebuffer;
	/// <summary></summary>
	public VkBool32 UniformBufferStandardLayout;
	/// <summary></summary>
	public VkBool32 ShaderSubgroupExtendedTypes;
	/// <summary></summary>
	public VkBool32 SeparateDepthStencilLayouts;
	/// <summary></summary>
	public VkBool32 HostQueryReset;
	/// <summary></summary>
	public VkBool32 TimelineSemaphore;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddress;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressCaptureReplay;
	/// <summary></summary>
	public VkBool32 BufferDeviceAddressMultiDevice;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModel;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModelDeviceScope;
	/// <summary></summary>
	public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
	/// <summary></summary>
	public VkBool32 ShaderOutputViewportIndex;
	/// <summary></summary>
	public VkBool32 ShaderOutputLayer;
	/// <summary></summary>
	public VkBool32 SubgroupBroadcastDynamicId;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDriverId DriverID;
	/// <summary></summary>
	public fixed byte DriverName[(int)VK.MaxDriverNameSize];
	/// <summary></summary>
	public fixed byte DriverInfo[(int)VK.MaxDriverInfoSize];
	/// <summary></summary>
	public VkConformanceVersion ConformanceVersion;
	/// <summary></summary>
	public VkShaderFloatControlsIndependence DenormBehaviorIndependence;
	/// <summary></summary>
	public VkShaderFloatControlsIndependence RoundingModeIndependence;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat16;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat32;
	/// <summary></summary>
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat64;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat16;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat32;
	/// <summary></summary>
	public VkBool32 ShaderDenormPreserveFloat64;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat16;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat32;
	/// <summary></summary>
	public VkBool32 ShaderDenormFlushToZeroFloat64;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat16;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat32;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTEFloat64;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat16;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat32;
	/// <summary></summary>
	public VkBool32 ShaderRoundingModeRTZFloat64;
	/// <summary></summary>
	public uint MaxUpdateAfterBindDescriptorsInAllPools;
	/// <summary></summary>
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
	/// <summary></summary>
	public VkBool32 RobustBufferAccessUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 QuadDivergentImplicitLod;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
	/// <summary></summary>
	public uint MaxPerStageUpdateAfterBindResources;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindSamplers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindSampledImages;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindStorageImages;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
	/// <summary></summary>
	public VkResolveModeFlags SupportedDepthResolveModes;
	/// <summary></summary>
	public VkResolveModeFlags SupportedStencilResolveModes;
	/// <summary></summary>
	public VkBool32 IndependentResolveNone;
	/// <summary></summary>
	public VkBool32 IndependentResolve;
	/// <summary></summary>
	public VkBool32 FilterMinmaxSingleComponentFormats;
	/// <summary></summary>
	public VkBool32 FilterMinmaxImageComponentMapping;
	/// <summary></summary>
	public ulong MaxTimelineSemaphoreValueDifference;
	/// <summary></summary>
	public VkSampleCountFlags FramebufferIntegerColorSampleCounts;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan13Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RobustImageAccess;
	/// <summary></summary>
	public VkBool32 InlineUniformBlock;
	/// <summary></summary>
	public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
	/// <summary></summary>
	public VkBool32 PipelineCreationCacheControl;
	/// <summary></summary>
	public VkBool32 PrivateData;
	/// <summary></summary>
	public VkBool32 ShaderDemoteToHelperInvocation;
	/// <summary></summary>
	public VkBool32 ShaderTerminateInvocation;
	/// <summary></summary>
	public VkBool32 SubgroupSizeControl;
	/// <summary></summary>
	public VkBool32 ComputeFullSubgroups;
	/// <summary></summary>
	public VkBool32 Synchronization2;
	/// <summary></summary>
	public VkBool32 TextureCompressionASTC_HDR;
	/// <summary></summary>
	public VkBool32 ShaderZeroInitializeWorkgroupMemory;
	/// <summary></summary>
	public VkBool32 DynamicRendering;
	/// <summary></summary>
	public VkBool32 ShaderIntegerDotProduct;
	/// <summary></summary>
	public VkBool32 Maintenance4;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MinSubgroupSize;
	/// <summary></summary>
	public uint MaxSubgroupSize;
	/// <summary></summary>
	public uint MaxComputeWorkgroupSubgroups;
	/// <summary></summary>
	public VkShaderStageFlags RequiredSubgroupSizeStages;
	/// <summary></summary>
	public uint MaxInlineUniformBlockSize;
	/// <summary></summary>
	public uint MaxPerStageDescriptorInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxDescriptorSetInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	/// <summary></summary>
	public uint MaxInlineUniformTotalSize;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
	/// <summary></summary>
	public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
	/// <summary></summary>
	public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
	/// <summary></summary>
	public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
	/// <summary></summary>
	public VkDeviceSize MaxBufferSize;
}
/// <summary></summary>
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineCompilerControlFlagsAMD CompilerControlFlags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DeviceCoherentMemory;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceToolProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte Name[(int)VK.MaxExtensionNameSize];
	/// <summary></summary>
	public fixed byte Version[(int)VK.MaxExtensionNameSize];
	/// <summary></summary>
	public VkToolPurposeFlags Purposes;
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public fixed byte Layer[(int)VK.MaxExtensionNameSize];
}
/// <summary></summary>
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkClearColorValue CustomBorderColor;
	/// <summary></summary>
	public VkFormat Format;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxCustomBorderColorSamplers;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 CustomBorderColors;
	/// <summary></summary>
	public VkBool32 CustomBorderColorWithoutFormat;
}
/// <summary></summary>
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkComponentMapping Components;
	/// <summary></summary>
	public VkBool32 Srgb;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 BorderColorSwizzle;
	/// <summary></summary>
	public VkBool32 BorderColorSwizzleFromImage;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkDeviceOrHostAddressKHR
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
	[FieldOffset(0)]
	/// <summary></summary>
	public void* HostAddress;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkDeviceOrHostAddressConstKHR
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
	[FieldOffset(0)]
	/// <summary></summary>
	public void* HostAddress;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat VertexFormat;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR VertexData;
	/// <summary></summary>
	public VkDeviceSize VertexStride;
	/// <summary></summary>
	public uint MaxVertex;
	/// <summary></summary>
	public VkIndexType IndexType;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR IndexData;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR TransformData;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR Data;
	/// <summary></summary>
	public VkDeviceSize Stride;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ArrayOfPointers;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR Data;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureGeometryTrianglesDataKHR Triangles;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureGeometryAabbsDataKHR Aabbs;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureGeometryInstancesDataKHR Instances;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkGeometryTypeKHR GeometryType;
	/// <summary></summary>
	public VkAccelerationStructureGeometryDataKHR Geometry;
	/// <summary></summary>
	public VkGeometryFlagsKHR Flags;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureTypeKHR Type;
	/// <summary></summary>
	public VkBuildAccelerationStructureFlagsKHR Flags;
	/// <summary></summary>
	public VkBuildAccelerationStructureModeKHR Mode;
	/// <summary></summary>
	public VkAccelerationStructureKHR SourceAccelerationStructure;
	/// <summary></summary>
	public VkAccelerationStructureKHR DestinationAccelerationStructure;
	/// <summary></summary>
	public uint GeometryCount;
	/// <summary></summary>
	public VkAccelerationStructureGeometryKHR* Geometries;
	/// <summary></summary>
	public VkAccelerationStructureGeometryKHR** Geometries2;
	/// <summary></summary>
	public VkDeviceOrHostAddressKHR ScratchData;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
	/// <summary></summary>
	public uint PrimitiveCount;
	/// <summary></summary>
	public uint PrimitiveOffset;
	/// <summary></summary>
	public uint FirstVertex;
	/// <summary></summary>
	public uint TransformOffset;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureCreateFlagsKHR CreateFlags;
	/// <summary></summary>
	public VkBuffer Buffer;
	/// <summary></summary>
	public VkDeviceSize Offset;
	/// <summary></summary>
	public VkDeviceSize Size;
	/// <summary></summary>
	public VkAccelerationStructureTypeKHR Type;
	/// <summary></summary>
	public VkDeviceAddress DeviceAddress;
}
/// <summary></summary>
public unsafe struct VkAabbPositionsKHR
{
	/// <summary></summary>
	public float MinX;
	/// <summary></summary>
	public float MinY;
	/// <summary></summary>
	public float MinZ;
	/// <summary></summary>
	public float MaxX;
	/// <summary></summary>
	public float MaxY;
	/// <summary></summary>
	public float MaxZ;
}
/// <summary></summary>
public unsafe struct VkTransformMatrixKHR
{
	/// <summary></summary>
	public fixed float Matrix[12];
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureInstanceKHR
{
	/// <summary></summary>
	public VkTransformMatrixKHR Transform;
	/// <summary></summary>
	public uint InstanceCustomIndex;
	/// <summary></summary>
	public uint Mask;
	/// <summary></summary>
	public uint InstanceShaderBindingTableRecordOffset;
	/// <summary></summary>
	public VkGeometryInstanceFlagsKHR Flags;
	/// <summary></summary>
	public ulong AccelerationStructureReference;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureKHR AccelerationStructure;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public byte* VersionData;
}
/// <summary></summary>
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureKHR Source;
	/// <summary></summary>
	public VkAccelerationStructureKHR Destination;
	/// <summary></summary>
	public VkCopyAccelerationStructureModeKHR Mode;
}
/// <summary></summary>
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAccelerationStructureKHR Source;
	/// <summary></summary>
	public VkDeviceOrHostAddressKHR Destination;
	/// <summary></summary>
	public VkCopyAccelerationStructureModeKHR Mode;
}
/// <summary></summary>
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR Source;
	/// <summary></summary>
	public VkAccelerationStructureKHR Destination;
	/// <summary></summary>
	public VkCopyAccelerationStructureModeKHR Mode;
}
/// <summary></summary>
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxPipelineRayPayloadSize;
	/// <summary></summary>
	public uint MaxPipelineRayHitAttributeSize;
}
/// <summary></summary>
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint LibraryCount;
	/// <summary></summary>
	public VkPipeline* Libraries;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ExtendedDynamicState;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ExtendedDynamicState2;
	/// <summary></summary>
	public VkBool32 ExtendedDynamicState2LogicOp;
	/// <summary></summary>
	public VkBool32 ExtendedDynamicState2PatchControlPoints;
}
/// <summary></summary>
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR Transform;
}
/// <summary></summary>
public unsafe struct VkCopyCommandTransformInfoQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR Transform;
}
/// <summary></summary>
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSurfaceTransformFlagsKHR Transform;
	/// <summary></summary>
	public VkRect2D RenderArea;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DiagnosticsConfig;
}
/// <summary></summary>
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceDiagnosticsConfigFlagsNV Flags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderZeroInitializeWorkgroupMemory;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderSubgroupUniformControlFlow;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RobustBufferAccess2;
	/// <summary></summary>
	public VkBool32 RobustImageAccess2;
	/// <summary></summary>
	public VkBool32 NullDescriptor;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize RobustStorageBufferAccessSizeAlignment;
	/// <summary></summary>
	public VkDeviceSize RobustUniformBufferAccessSizeAlignment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RobustImageAccess;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 WorkgroupMemoryExplicitLayout;
	/// <summary></summary>
	public VkBool32 WorkgroupMemoryExplicitLayoutScalarBlockLayout;
	/// <summary></summary>
	public VkBool32 WorkgroupMemoryExplicitLayout8BitAccess;
	/// <summary></summary>
	public VkBool32 WorkgroupMemoryExplicitLayout16BitAccess;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FormatA4R4G4B4;
	/// <summary></summary>
	public VkBool32 FormatA4B4G4R4;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SubpassShading;
}
/// <summary></summary>
public unsafe struct VkBufferCopy2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize SourceOffset;
	/// <summary></summary>
	public VkDeviceSize DestinationOffset;
	/// <summary></summary>
	public VkDeviceSize Size;
}
/// <summary></summary>
public unsafe struct VkImageCopy2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary></summary>
	public VkOffset3D SourceOffset;
	/// <summary></summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary></summary>
	public VkOffset3D DestinationOffset;
	/// <summary></summary>
	public VkExtent3D Extent;
}
/// <summary></summary>
public unsafe struct VkImageBlit2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary></summary>
	public VkOffset3D SourceOffsets_0;
	/// <summary></summary>
	public VkOffset3D SourceOffsets_1;
	/// <summary></summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary></summary>
	public VkOffset3D DestinationOffsets_0;
	/// <summary></summary>
	public VkOffset3D DestinationOffsets_1;
}
/// <summary></summary>
public unsafe struct VkBufferImageCopy2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize BufferOffset;
	/// <summary></summary>
	public uint BufferRowLength;
	/// <summary></summary>
	public uint BufferImageHeight;
	/// <summary></summary>
	public VkImageSubresourceLayers ImageSubresource;
	/// <summary></summary>
	public VkOffset3D ImageOffset;
	/// <summary></summary>
	public VkExtent3D ImageExtent;
}
/// <summary></summary>
public unsafe struct VkImageResolve2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageSubresourceLayers SourceSubresource;
	/// <summary></summary>
	public VkOffset3D SourceOffset;
	/// <summary></summary>
	public VkImageSubresourceLayers DestinationSubresource;
	/// <summary></summary>
	public VkOffset3D DestinationOffset;
	/// <summary></summary>
	public VkExtent3D Extent;
}
/// <summary></summary>
public unsafe struct VkCopyBufferInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer SourceBuffer;
	/// <summary></summary>
	public VkBuffer DestinationBuffer;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkBufferCopy2* Regions;
}
/// <summary></summary>
public unsafe struct VkCopyImageInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage SourceImage;
	/// <summary></summary>
	public VkImageLayout SourceImageLayout;
	/// <summary></summary>
	public VkImage DestinationImage;
	/// <summary></summary>
	public VkImageLayout DestinationImageLayout;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkImageCopy2* Regions;
}
/// <summary></summary>
public unsafe struct VkBlitImageInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage SourceImage;
	/// <summary></summary>
	public VkImageLayout SourceImageLayout;
	/// <summary></summary>
	public VkImage DestinationImage;
	/// <summary></summary>
	public VkImageLayout DestinationImageLayout;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkImageBlit2* Regions;
	/// <summary></summary>
	public VkFilter Filter;
}
/// <summary></summary>
public unsafe struct VkCopyBufferToImageInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBuffer SourceBuffer;
	/// <summary></summary>
	public VkImage DestinationImage;
	/// <summary></summary>
	public VkImageLayout DestinationImageLayout;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkBufferImageCopy2* Regions;
}
/// <summary></summary>
public unsafe struct VkCopyImageToBufferInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage SourceImage;
	/// <summary></summary>
	public VkImageLayout SourceImageLayout;
	/// <summary></summary>
	public VkBuffer DestinationBuffer;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkBufferImageCopy2* Regions;
}
/// <summary></summary>
public unsafe struct VkResolveImageInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImage SourceImage;
	/// <summary></summary>
	public VkImageLayout SourceImageLayout;
	/// <summary></summary>
	public VkImage DestinationImage;
	/// <summary></summary>
	public VkImageLayout DestinationImageLayout;
	/// <summary></summary>
	public uint RegionCount;
	/// <summary></summary>
	public VkImageResolve2* Regions;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderImageInt64Atomics;
	/// <summary></summary>
	public VkBool32 SparseImageInt64Atomics;
}
/// <summary></summary>
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkAttachmentReference2* FragmentShadingRateAttachment;
	/// <summary></summary>
	public VkExtent2D ShadingRateAttachmentTexelSize;
}
/// <summary></summary>
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D FragmentSize;
	/// <summary></summary>
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_0;
	/// <summary></summary>
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_1;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PipelineFragmentShadingRate;
	/// <summary></summary>
	public VkBool32 PrimitiveFragmentShadingRate;
	/// <summary></summary>
	public VkBool32 AttachmentFragmentShadingRate;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent2D MinFragmentShadingRateAttachmentTexelSize;
	/// <summary></summary>
	public VkExtent2D MaxFragmentShadingRateAttachmentTexelSize;
	/// <summary></summary>
	public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;
	/// <summary></summary>
	public VkBool32 PrimitiveFragmentShadingRateWithMultipleViewports;
	/// <summary></summary>
	public VkBool32 LayeredShadingRateAttachments;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateNonTrivialCombinerOps;
	/// <summary></summary>
	public VkExtent2D MaxFragmentSize;
	/// <summary></summary>
	public uint MaxFragmentSizeAspectRatio;
	/// <summary></summary>
	public uint MaxFragmentShadingRateCoverageSamples;
	/// <summary></summary>
	public VkSampleCountFlags MaxFragmentShadingRateRasterizationSamples;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithShaderDepthStencilWrites;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithSampleMask;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithShaderSampleMask;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithConservativeRasterization;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithFragmentShaderInterlock;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateWithCustomSampleLocations;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateStrictMultiplyCombiner;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSampleCountFlags SampleCounts;
	/// <summary></summary>
	public VkExtent2D FragmentSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderTerminateInvocation;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentShadingRateEnums;
	/// <summary></summary>
	public VkBool32 SupersampleFragmentShadingRates;
	/// <summary></summary>
	public VkBool32 NoInvocationFragmentShadingRates;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSampleCountFlags MaxFragmentShadingRateInvocationCount;
}
/// <summary></summary>
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFragmentShadingRateTypeNV ShadingRateType;
	/// <summary></summary>
	public VkFragmentShadingRateNV ShadingRate;
	/// <summary></summary>
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_0;
	/// <summary></summary>
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_1;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceSize AccelerationStructureSize;
	/// <summary></summary>
	public VkDeviceSize UpdateScratchSize;
	/// <summary></summary>
	public VkDeviceSize BuildScratchSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Image2DViewOf3D;
	/// <summary></summary>
	public VkBool32 Sampler2DViewOf3D;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MutableDescriptorType;
}
/// <summary></summary>
public unsafe struct VkMutableDescriptorTypeListVALVE
{
	/// <summary></summary>
	public uint DescriptorTypeCount;
	/// <summary></summary>
	public VkDescriptorType* DescriptorTypes;
}
/// <summary></summary>
public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MutableDescriptorTypeListCount;
	/// <summary></summary>
	public VkMutableDescriptorTypeListVALVE* MutableDescriptorTypeLists;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DepthClipControl;
}
/// <summary></summary>
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 NegativeOneToOne;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 VertexInputDynamicState;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ExternalMemoryRDMA;
}
/// <summary></summary>
public unsafe struct VkVertexInputBindingDescription2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public uint Stride;
	/// <summary></summary>
	public VkVertexInputRate InputRate;
	/// <summary></summary>
	public uint Divisor;
}
/// <summary></summary>
public unsafe struct VkVertexInputAttributeDescription2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint Location;
	/// <summary></summary>
	public uint Binding;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public uint Offset;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ColorWriteEnable;
}
/// <summary></summary>
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint AttachmentCount;
	/// <summary></summary>
	public VkBool32* ColorWriteEnables;
}
/// <summary></summary>
public unsafe struct VkMemoryBarrier2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags2 SourceStageMask;
	/// <summary></summary>
	public VkAccessFlags2 SourceAccessMask;
	/// <summary></summary>
	public VkPipelineStageFlags2 DestinationStageMask;
	/// <summary></summary>
	public VkAccessFlags2 DestinationAccessMask;
}
/// <summary></summary>
public unsafe struct VkImageMemoryBarrier2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags2 SourceStageMask;
	/// <summary></summary>
	public VkAccessFlags2 SourceAccessMask;
	/// <summary></summary>
	public VkPipelineStageFlags2 DestinationStageMask;
	/// <summary></summary>
	public VkAccessFlags2 DestinationAccessMask;
	/// <summary></summary>
	public VkImageLayout OldLayout;
	/// <summary></summary>
	public VkImageLayout NewLayout;
	/// <summary></summary>
	public uint SourceQueueFamilyIndex;
	/// <summary></summary>
	public uint DestinationQueueFamilyIndex;
	/// <summary></summary>
	public VkImage Image;
	/// <summary></summary>
	public VkImageSubresourceRange SubresourceRange;
}
/// <summary></summary>
public unsafe struct VkBufferMemoryBarrier2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags2 SourceStageMask;
	/// <summary></summary>
	public VkAccessFlags2 SourceAccessMask;
	/// <summary></summary>
	public VkPipelineStageFlags2 DestinationStageMask;
	/// <summary></summary>
	public VkAccessFlags2 DestinationAccessMask;
	/// <summary></summary>
	public uint SourceQueueFamilyIndex;
	/// <summary></summary>
	public uint DestinationQueueFamilyIndex;
	/// <summary></summary>
	public VkBuffer Buffer;
	/// <summary></summary>
	public VkDeviceSize Offset;
	/// <summary></summary>
	public VkDeviceSize Size;
}
/// <summary></summary>
public unsafe struct VkDependencyInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDependencyFlags DependencyFlags;
	/// <summary></summary>
	public uint MemoryBarrierCount;
	/// <summary></summary>
	public VkMemoryBarrier2* MemoryBarriers;
	/// <summary></summary>
	public uint BufferMemoryBarrierCount;
	/// <summary></summary>
	public VkBufferMemoryBarrier2* BufferMemoryBarriers;
	/// <summary></summary>
	public uint ImageMemoryBarrierCount;
	/// <summary></summary>
	public VkImageMemoryBarrier2* ImageMemoryBarriers;
}
/// <summary></summary>
public unsafe struct VkSemaphoreSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSemaphore Semaphore;
	/// <summary></summary>
	public ulong Value;
	/// <summary></summary>
	public VkPipelineStageFlags2 StageMask;
	/// <summary></summary>
	public uint DeviceIndex;
}
/// <summary></summary>
public unsafe struct VkCommandBufferSubmitInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCommandBuffer CommandBuffer;
	/// <summary></summary>
	public uint DeviceMask;
}
/// <summary></summary>
public unsafe struct VkSubmitInfo2
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSubmitFlags Flags;
	/// <summary></summary>
	public uint WaitSemaphoreInfoCount;
	/// <summary></summary>
	public VkSemaphoreSubmitInfo* WaitSemaphoreInfos;
	/// <summary></summary>
	public uint CommandBufferInfoCount;
	/// <summary></summary>
	public VkCommandBufferSubmitInfo* CommandBufferInfos;
	/// <summary></summary>
	public uint SignalSemaphoreInfoCount;
	/// <summary></summary>
	public VkSemaphoreSubmitInfo* SignalSemaphoreInfos;
}
/// <summary></summary>
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags2 CheckpointExecutionStageMask;
}
/// <summary></summary>
public unsafe struct VkCheckpointData2NV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineStageFlags2 Stage;
	/// <summary></summary>
	public void* CheckpointMarker;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Synchronization2;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PrimitivesGeneratedQuery;
	/// <summary></summary>
	public VkBool32 PrimitivesGeneratedQueryWithRasterizerDiscard;
	/// <summary></summary>
	public VkBool32 PrimitivesGeneratedQueryWithNonZeroStreams;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MultisampledRenderToSingleSampled;
}
/// <summary></summary>
public unsafe struct VkSubpassResolvePerformanceQueryEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Optimal;
}
/// <summary></summary>
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MultisampledRenderToSingleSampledEnable;
	/// <summary></summary>
	public VkSampleCountFlags RasterizationSamples;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 InheritedViewportScissor2D;
}
/// <summary></summary>
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ViewportScissor2D;
	/// <summary></summary>
	public uint ViewportDepthCount;
	/// <summary></summary>
	public VkViewport* ViewportDepths;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 Ycbcr2plane444Formats;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ProvokingVertexLast;
	/// <summary></summary>
	public VkBool32 TransformFeedbackPreservesProvokingVertex;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ProvokingVertexModePerPipeline;
	/// <summary></summary>
	public VkBool32 TransformFeedbackPreservesTriangleFanProvokingVertex;
}
/// <summary></summary>
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkProvokingVertexModeEXT ProvokingVertexMode;
}
/// <summary></summary>
public unsafe struct VkCuModuleCreateInfoNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public nuint DataSize;
	/// <summary></summary>
	public void* Data;
}
/// <summary></summary>
public unsafe struct VkCuFunctionCreateInfoNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCuModuleNVX Module;
	/// <summary></summary>
	public byte* Name;
}
/// <summary></summary>
public unsafe struct VkCuLaunchInfoNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkCuFunctionNVX Function;
	/// <summary></summary>
	public uint GridDimX;
	/// <summary></summary>
	public uint GridDimY;
	/// <summary></summary>
	public uint GridDimZ;
	/// <summary></summary>
	public uint BlockDimX;
	/// <summary></summary>
	public uint BlockDimY;
	/// <summary></summary>
	public uint BlockDimZ;
	/// <summary></summary>
	public uint SharedMemBytes;
	/// <summary></summary>
	public nuint ParamCount;
	/// <summary></summary>
	public void** Params;
	/// <summary></summary>
	public nuint ExtraCount;
	/// <summary></summary>
	public void** Extras;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderIntegerDotProduct;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
	/// <summary></summary>
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 HasPrimary;
	/// <summary></summary>
	public VkBool32 HasRender;
	/// <summary></summary>
	public long PrimaryMajor;
	/// <summary></summary>
	public long PrimaryMinor;
	/// <summary></summary>
	public long RenderMajor;
	/// <summary></summary>
	public long RenderMinor;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FragmentShaderBarycentric;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TriStripVertexOrderIndependentOfProvokingVertex;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RayTracingMotionBlur;
	/// <summary></summary>
	public VkBool32 RayTracingMotionBlurPipelineTraceRaysIndirect;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceOrHostAddressConstKHR VertexData;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureMotionInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxInstances;
	/// <summary></summary>
	public uint Flags;
}
/// <summary></summary>
public unsafe struct VkSRTDataNV
{
	/// <summary></summary>
	public float Sx;
	/// <summary></summary>
	public float A;
	/// <summary></summary>
	public float B;
	/// <summary></summary>
	public float Pvx;
	/// <summary></summary>
	public float Sy;
	/// <summary></summary>
	public float C;
	/// <summary></summary>
	public float Pvy;
	/// <summary></summary>
	public float Sz;
	/// <summary></summary>
	public float Pvz;
	/// <summary></summary>
	public float Qx;
	/// <summary></summary>
	public float Qy;
	/// <summary></summary>
	public float Qz;
	/// <summary></summary>
	public float Qw;
	/// <summary></summary>
	public float Tx;
	/// <summary></summary>
	public float Ty;
	/// <summary></summary>
	public float Tz;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
	/// <summary></summary>
	public VkSRTDataNV TransformT0;
	/// <summary></summary>
	public VkSRTDataNV TransformT1;
	/// <summary></summary>
	public uint InstanceCustomIndex;
	/// <summary></summary>
	public uint Mask;
	/// <summary></summary>
	public uint InstanceShaderBindingTableRecordOffset;
	/// <summary></summary>
	public VkGeometryInstanceFlagsKHR Flags;
	/// <summary></summary>
	public ulong AccelerationStructureReference;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
	/// <summary></summary>
	public VkTransformMatrixKHR TransformT0;
	/// <summary></summary>
	public VkTransformMatrixKHR TransformT1;
	/// <summary></summary>
	public uint InstanceCustomIndex;
	/// <summary></summary>
	public uint Mask;
	/// <summary></summary>
	public uint InstanceShaderBindingTableRecordOffset;
	/// <summary></summary>
	public VkGeometryInstanceFlagsKHR Flags;
	/// <summary></summary>
	public ulong AccelerationStructureReference;
}
[StructLayout(LayoutKind.Explicit)]
/// <summary></summary>
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureInstanceKHR StaticInstance;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;
	[FieldOffset(0)]
	/// <summary></summary>
	public VkAccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
}
/// <summary></summary>
public unsafe struct VkAccelerationStructureMotionInstanceNV
{
	/// <summary></summary>
	public VkAccelerationStructureMotionInstanceTypeNV Type;
	/// <summary></summary>
	public uint Flags;
	/// <summary></summary>
	public VkAccelerationStructureMotionInstanceDataNV Data;
}
/// <summary></summary>
public unsafe struct VkMemoryGetRemoteAddressInfoNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDeviceMemory Memory;
	/// <summary></summary>
	public VkExternalMemoryHandleTypeFlags HandleType;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 FormatRgba10x6WithoutYCbCrSampler;
}
/// <summary></summary>
public unsafe struct VkFormatProperties3
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormatFeatureFlags2 LinearTilingFeatures;
	/// <summary></summary>
	public VkFormatFeatureFlags2 OptimalTilingFeatures;
	/// <summary></summary>
	public VkFormatFeatureFlags2 BufferFeatures;
}
/// <summary></summary>
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint DrmFormatModifierCount;
	/// <summary></summary>
	public VkDrmFormatModifierProperties2EXT* DrmFormatModifierProperties;
}
/// <summary></summary>
public unsafe struct VkDrmFormatModifierProperties2EXT
{
	/// <summary></summary>
	public ulong DrmFormatModifier;
	/// <summary></summary>
	public uint DrmFormatModifierPlaneCount;
	/// <summary></summary>
	public VkFormatFeatureFlags2 DrmFormatModifierTilingFeatures;
}
/// <summary></summary>
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkFormat Format;
	/// <summary></summary>
	public ulong ExternalFormat;
	/// <summary></summary>
	public VkFormatFeatureFlags2 FormatFeatures;
	/// <summary></summary>
	public VkComponentMapping SamplerYcbcrConversionComponents;
	/// <summary></summary>
	public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
	/// <summary></summary>
	public VkSamplerYcbcrRange SuggestedYcbcrRange;
	/// <summary></summary>
	public VkChromaLocation SuggestedXChromaOffset;
	/// <summary></summary>
	public VkChromaLocation SuggestedYChromaOffset;
}
/// <summary></summary>
public unsafe struct VkPipelineRenderingCreateInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ViewMask;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkFormat* ColorAttachmentFormats;
	/// <summary></summary>
	public VkFormat DepthAttachmentFormat;
	/// <summary></summary>
	public VkFormat StencilAttachmentFormat;
}
/// <summary></summary>
public unsafe struct VkRenderingInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderingFlags Flags;
	/// <summary></summary>
	public VkRect2D RenderArea;
	/// <summary></summary>
	public uint LayerCount;
	/// <summary></summary>
	public uint ViewMask;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkRenderingAttachmentInfo* ColorAttachments;
	/// <summary></summary>
	public VkRenderingAttachmentInfo* DepthAttachment;
	/// <summary></summary>
	public VkRenderingAttachmentInfo* StencilAttachment;
}
/// <summary></summary>
public unsafe struct VkRenderingAttachmentInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageView ImageView;
	/// <summary></summary>
	public VkImageLayout ImageLayout;
	/// <summary></summary>
	public VkResolveModeFlags ResolveMode;
	/// <summary></summary>
	public VkImageView ResolveImageView;
	/// <summary></summary>
	public VkImageLayout ResolveImageLayout;
	/// <summary></summary>
	public VkAttachmentLoadOp LoadOp;
	/// <summary></summary>
	public VkAttachmentStoreOp StoreOp;
	/// <summary></summary>
	public VkClearValue ClearValue;
}
/// <summary></summary>
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageView ImageView;
	/// <summary></summary>
	public VkImageLayout ImageLayout;
	/// <summary></summary>
	public VkExtent2D ShadingRateAttachmentTexelSize;
}
/// <summary></summary>
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageView ImageView;
	/// <summary></summary>
	public VkImageLayout ImageLayout;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DynamicRendering;
}
/// <summary></summary>
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderingFlags Flags;
	/// <summary></summary>
	public uint ViewMask;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkFormat* ColorAttachmentFormats;
	/// <summary></summary>
	public VkFormat DepthAttachmentFormat;
	/// <summary></summary>
	public VkFormat StencilAttachmentFormat;
	/// <summary></summary>
	public VkSampleCountFlags RasterizationSamples;
}
/// <summary></summary>
public unsafe struct VkAttachmentSampleCountInfoAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint ColorAttachmentCount;
	/// <summary></summary>
	public VkSampleCountFlags* ColorAttachmentSamples;
	/// <summary></summary>
	public VkSampleCountFlags DepthStencilAttachmentSamples;
}
/// <summary></summary>
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PerViewAttributes;
	/// <summary></summary>
	public VkBool32 PerViewAttributesPositionXOnly;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 MinLod;
}
/// <summary></summary>
public unsafe struct VkImageViewMinLodCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public float MinLod;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 RasterizationOrderColorAttachmentAccess;
	/// <summary></summary>
	public VkBool32 RasterizationOrderDepthAttachmentAccess;
	/// <summary></summary>
	public VkBool32 RasterizationOrderStencilAttachmentAccess;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 LinearColorAttachment;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 GraphicsPipelineLibrary;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 GraphicsPipelineLibraryFastLinking;
	/// <summary></summary>
	public VkBool32 GraphicsPipelineLibraryIndependentInterpolationDecoration;
}
/// <summary></summary>
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkGraphicsPipelineLibraryFlagsEXT Flags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DescriptorSetHostMapping;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkDescriptorSetLayout DescriptorSetLayout;
	/// <summary></summary>
	public uint Binding;
}
/// <summary></summary>
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public nuint DescriptorOffset;
	/// <summary></summary>
	public uint DescriptorSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderModuleIdentifier;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte ShaderModuleIdentifierAlgorithmUUID[(int)VK.UuidSize];
}
/// <summary></summary>
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint IdentifierSize;
	/// <summary></summary>
	public byte* Identifier;
}
/// <summary></summary>
public unsafe struct VkShaderModuleIdentifierEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint IdentifierSize;
	/// <summary></summary>
	public fixed byte Identifier[(int)VK.MaxShaderModuleIdentifierSizeExt];
}
/// <summary></summary>
public unsafe struct VkImageCompressionControlEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageCompressionFlagsEXT Flags;
	/// <summary></summary>
	public uint CompressionControlPlaneCount;
	/// <summary></summary>
	public VkImageCompressionFixedRateFlagsEXT* FixedRateFlags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ImageCompressionControl;
}
/// <summary></summary>
public unsafe struct VkImageCompressionPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageCompressionFlagsEXT ImageCompressionFlags;
	/// <summary></summary>
	public VkImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ImageCompressionControlSwapchain;
}
/// <summary></summary>
public unsafe struct VkImageSubresource2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkImageSubresource ImageSubresource;
}
/// <summary></summary>
public unsafe struct VkSubresourceLayout2EXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkSubresourceLayout SubresourceLayout;
}
/// <summary></summary>
public unsafe struct VkRenderPassCreationControlEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DisallowMerging;
}
/// <summary></summary>
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
	/// <summary></summary>
	public uint PostMergeSubpassCount;
}
/// <summary></summary>
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPassCreationFeedbackInfoEXT* RenderPassFeedback;
}
/// <summary></summary>
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
	/// <summary></summary>
	public VkSubpassMergeStatusEXT SubpassMergeStatus;
	/// <summary></summary>
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	/// <summary></summary>
	public uint PostMergeIndex;
}
/// <summary></summary>
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkRenderPassSubpassFeedbackInfoEXT* SubpassFeedback;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 SubpassMergeFeedback;
}
/// <summary></summary>
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public fixed byte PipelineIdentifier[(int)VK.UuidSize];
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PipelinePropertiesIdentifier;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 ShaderEarlyAndLateFragmentTests;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 NonSeamlessCubeMap;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 PipelineRobustness;
}
/// <summary></summary>
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT StorageBuffers;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT UniformBuffers;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT VertexInputs;
	/// <summary></summary>
	public VkPipelineRobustnessImageBehaviorEXT Images;
}
/// <summary></summary>
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessStorageBuffers;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessUniformBuffers;
	/// <summary></summary>
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessVertexInputs;
	/// <summary></summary>
	public VkPipelineRobustnessImageBehaviorEXT DefaultRobustnessImages;
}
/// <summary></summary>
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkOffset2D FilterCenter;
	/// <summary></summary>
	public VkExtent2D FilterSize;
	/// <summary></summary>
	public uint NumPhases;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TextureSampleWeighted;
	/// <summary></summary>
	public VkBool32 TextureBoxFilter;
	/// <summary></summary>
	public VkBool32 TextureBlockMatch;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public uint MaxWeightFilterPhases;
	/// <summary></summary>
	public VkExtent2D MaxWeightFilterDimension;
	/// <summary></summary>
	public VkExtent2D MaxBlockMatchRegion;
	/// <summary></summary>
	public VkExtent2D MaxBoxFilterBlockSize;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 TileProperties;
}
/// <summary></summary>
public unsafe struct VkTilePropertiesQCOM
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkExtent3D TileSize;
	/// <summary></summary>
	public VkExtent2D ApronSize;
	/// <summary></summary>
	public VkOffset2D Origin;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 AmigoProfiling;
}
/// <summary></summary>
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public ulong FirstDrawTimestamp;
	/// <summary></summary>
	public ulong SwapBufferTimestamp;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 AttachmentFeedbackLoopLayout;
}
/// <summary></summary>
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
	/// <summary></summary>
	public VkStructureType SType;
	/// <summary></summary>
	public void* Next;
	/// <summary></summary>
	public VkBool32 DepthClampZeroOne;
}
