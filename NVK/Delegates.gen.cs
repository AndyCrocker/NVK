// this file was generated, don't edit manually

namespace Vulkan;

/// <summary></summary>
/// <param name="userData">The value specified for <see cref="VkAllocationCallbacks.UserData"/> in the allocator specified by the application.</param>
/// <param name="size">The requested size of an allocation.</param>
/// <param name="allocationType">A <see cref="VkInternalAllocationType"/> value specifying the requested type of an allocation.</param>
/// <param name="allocationScope">A <see cref="VkSystemAllocationScope"/> value specifying the allocation scope of the lifetime of the allocation.</param>
/// <remarks>This is a purely informational callback.</remarks>
public unsafe delegate void InternalAllocationNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData">The value specified for <see cref="VkAllocationCallbacks.UserData"/> in the allocator specified by the application.</param>
/// <param name="size">The requested size of an allocation.</param>
/// <param name="allocationType">A <see cref="VkInternalAllocationType"/> value specifying the requested type of an allocation.</param>
/// <param name="allocationScope">A <see cref="VkSystemAllocationScope"/> value specifying the allocation scope of the lifetime of the allocation.</param>
public unsafe delegate void InternalFreeNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData">The value specified for <see cref="VkAllocationCallbacks.UserData"/> in the allocator specified by the application.</param>
/// <param name="original"><strong>Must</strong> be either <see langword="null"/> or a pointer previously returned by <see cref="VkAllocationCallbacks.Reallocation"/> or <see cref="VkAllocationCallbacks.Allocation"/> of a compatible allocator.</param>
/// <param name="size">The size in bytes of the requested allocation.</param>
/// <param name="alignment">The requested alignment of the allocation in bytes and <strong>must</strong> be a power of two.</param>
/// <param name="allocationScope">A <see cref="VkSystemAllocationScope"/> value specifying the allocation scope of the lifetime of the allocation.</param>
/// <remarks><see cref="VkAllocationCallbacks.Reallocation"/> <strong>must</strong> return an allocation with enough space for <paramref name="size"/> bytes, and the contents of the original allocation from bytes zero to <c>min(original size, new size) - 1</c> <strong>must</strong> be preserved in the returned allocation. If <paramref name="size"/> is larger than the old size, the contents of the additional space are undefined. If satisfying these requirements involves creating a new allocation, then the old allocation <strong>should</strong> be freed.</remarks>
public unsafe delegate void* ReallocationFunctionDelegate(void* userData, void* original, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData">The value specified for <see cref="VkAllocationCallbacks.UserData"/> in the allocator specified by the application.</param>
/// <param name="size">The size in bytes of the requested allocation.</param>
/// <param name="alignment">The requested alignment of the allocation in bytes and <strong>must</strong> be a power of two.</param>
/// <param name="allocationScope">A <see cref="VkSystemAllocationScope"/> value specifying the allocation scope of the lifetime of the allocation.</param>
public unsafe delegate void* AllocationFunctionDelegate(void* userData, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData">The value specified for <see cref="VkAllocationCallbacks.UserData"/> in the allocator specified by the application.</param>
/// <param name="memory">The allocation to be freed.</param>
/// <remarks><paramref name="memory"/> <strong>may</strong> be <see langword="null"/>, which the callback <strong>must</strong> handle safely. If <paramref name="memory"/> is non-<see langword="null"/>, it <strong>must</strong> be a pointer previously allocated by <see cref="VkAllocationCallbacks.Allocation"/> or <see cref="VkAllocationCallbacks.Reallocation"/>. The application <strong>should</strong> free this memory.</remarks>
public unsafe delegate void FreeFunctionDelegate(void* userData, void* memory);

/// <summary></summary>
public unsafe delegate void VoidFunctionDelegate();

/// <summary></summary>
/// <param name="flags">Specifies the <see cref="VkDebugReportFlagsEXT"/> that triggered this callback.</param>
/// <param name="objectType">A <see cref="VkDebugReportObjectTypeEXT"/> value specifying the type of object being used or created at the time the event was triggered.</param>
/// <param name="object">The object where the issue was detected. If <paramref name="objectType"/> is <see cref="VkDebugReportObjectTypeEXT.UnknownExt"/>, <paramref name="object"/> is undefined.</param>
/// <param name="location">A component (layer, driver, loader) defined value specifying the <em>location</em> of the trigger. This is an <strong>optional</strong> value.</param>
/// <param name="messageCode">A layer-defined value indicating what test triggered this callback.</param>
/// <param name="layerPrefix">A <see langword="null"/>-terminated string that is an abbreviation of the name of the component making the callback. <paramref name="layerPrefix"/> is only valid for the duration of the callback.</param>
/// <param name="message">A <see langword="null"/>-terminated string detailing the trigger conditions. <paramref name="message"/> is only valid for the duration of the callback.</param>
/// <param name="userData">The user data given when the <see cref="VkDebugReportCallbackEXT"/> was created.</param>
/// <remarks>The callback <strong>must</strong> not call <see cref="VK.DestroyDebugReportCallbackEXT"/>.</remarks>
public unsafe delegate VkBool32 DebugReportCallbackEXTDelegate(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message, void* userData);

/// <summary></summary>
/// <param name="messageSeverity">Specifies the <see cref="VkDebugUtilsMessageSeverityFlagsEXT"/> that triggered this callback.</param>
/// <param name="messageTypes">A bitmask of <see cref="VkDebugUtilsMessageTypeFlagsEXT"/> specifying which type of event(s) triggered this callback.</param>
/// <param name="callbackData">Contains all the callback related data in the <see cref="VkDebugUtilsMessengerCallbackDataEXT"/> structure.</param>
/// <param name="userData">The user data provided when the <see cref="VkDebugUtilsMessengerEXT"/> was created.</param>
/// <remarks>The callback returns a <see cref="VkBool32"/>, which is interpreted in a layer-specified manner. The application <strong>should</strong> always return <see cref="VK.False"/>. The <see cref="VK.True"/> value is reserved for use in layer development.</remarks>
public unsafe delegate VkBool32 DebugUtilsMessengerCallbackEXTDelegate(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData, void* userData);

/// <summary></summary>
/// <param name="callbackData">Contains all the callback related data in the <see cref="VkDeviceMemoryReportCallbackDataEXT"/> structure.</param>
/// <param name="userData">The user data provided when the <see cref="VkDeviceDeviceMemoryReportCreateInfoEXT"/> was created.</param>
/// <remarks>The callback <strong>must</strong> not make calls to any Vulkan commands.</remarks>
public unsafe delegate void DeviceMemoryReportCallbackEXTDelegate(VkDeviceMemoryReportCallbackDataEXT* callbackData, void* userData);

