// this file was generated, don't edit manually

namespace Vulkan;

/// <summary></summary>
/// <param name="userData"> is the value specified for <a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified by the application.</param>
/// <param name="size"> is the requested size of an allocation.</param>
/// <param name="allocationType"> is a <a href="#VkInternalAllocationType">VkInternalAllocationType</a> value specifying the requested type of an allocation.</param>
/// <param name="allocationScope"> is a <a href="#VkSystemAllocationScope">VkSystemAllocationScope</a> value specifying the allocation scope of the lifetime of the allocation, as described <a href="#memory-host-allocation-scope">here</a>.</param>
/// <remarks>This is a purely informational callback.</remarks>
public unsafe delegate void InternalAllocationNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData"> is the value specified for <a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified by the application.</param>
/// <param name="size"> is the requested size of an allocation.</param>
/// <param name="allocationType"> is a <a href="#VkInternalAllocationType">VkInternalAllocationType</a> value specifying the requested type of an allocation.</param>
/// <param name="allocationScope"> is a <a href="#VkSystemAllocationScope">VkSystemAllocationScope</a> value specifying the allocation scope of the lifetime of the allocation, as described <a href="#memory-host-allocation-scope">here</a>.</param>
public unsafe delegate void InternalFreeNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData"> is the value specified for <a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified by the application.</param>
/// <param name="original"> <strong class="purple">must</strong> be either <code>NULL</code> or a pointer previously returned by <code>pfnReallocation</code> or <code>pfnAllocation</code> of a compatible allocator.</param>
/// <param name="size"> is the size in bytes of the requested allocation.</param>
/// <param name="alignment"> is the requested alignment of the allocation in bytes and <strong class="purple">must</strong> be a power of two.</param>
/// <param name="allocationScope"> is a <a href="#VkSystemAllocationScope">VkSystemAllocationScope</a> value specifying the allocation scope of the lifetime of the allocation, as described <a href="#memory-host-allocation-scope">here</a>.</param>
/// <remarks><code>pfnReallocation</code> <strong class="purple">must</strong> return an allocation with enough space for <code>size</code> bytes, and the contents of the original allocation from bytes zero to <span class="eq">min(original size, new size) - 1</span> <strong class="purple">must</strong> be preserved in the returned allocation. If <code>size</code> is larger than the old size, the contents of the additional space are undefined. If satisfying these requirements involves creating a new allocation, then the old allocation <strong class="purple">should</strong> be freed.</remarks>
public unsafe delegate void* ReallocationFunctionDelegate(void* userData, void* original, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData"> is the value specified for <a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified by the application.</param>
/// <param name="size"> is the size in bytes of the requested allocation.</param>
/// <param name="alignment"> is the requested alignment of the allocation in bytes and <strong class="purple">must</strong> be a power of two.</param>
/// <param name="allocationScope"> is a <a href="#VkSystemAllocationScope">VkSystemAllocationScope</a> value specifying the allocation scope of the lifetime of the allocation, as described <a href="#memory-host-allocation-scope">here</a>.</param>
public unsafe delegate void* AllocationFunctionDelegate(void* userData, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);

/// <summary></summary>
/// <param name="userData"> is the value specified for <a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified by the application.</param>
/// <param name="memory"> is the allocation to be freed.</param>
/// <remarks><code>pMemory</code> <strong class="purple">may</strong> be <code>NULL</code>, which the callback <strong class="purple">must</strong> handle safely. If <code>pMemory</code> is non-<code>NULL</code>, it <strong class="purple">must</strong> be a pointer previously allocated by <code>pfnAllocation</code> or <code>pfnReallocation</code>. The application <strong class="purple">should</strong> free this memory.</remarks>
public unsafe delegate void FreeFunctionDelegate(void* userData, void* memory);

/// <summary></summary>
public unsafe delegate void VoidFunctionDelegate();

/// <summary></summary>
/// <param name="flags"> specifies the <a href="#VkDebugReportFlagBitsEXT">VkDebugReportFlagBitsEXT</a> that triggered this callback.</param>
/// <param name="objectType"> is a <a href="#VkDebugReportObjectTypeEXT">VkDebugReportObjectTypeEXT</a> value specifying the type of object being used or created at the time the event was triggered.</param>
/// <param name="object"> is the object where the issue was detected. If <code>objectType</code> is <code>VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT</code>, <code>object</code> is undefined.</param>
/// <param name="location"> is a component (layer, driver, loader) defined value specifying the <em>location</em> of the trigger. This is an <strong class="purple">optional</strong> value.</param>
/// <param name="messageCode"> is a layer-defined value indicating what test triggered this callback.</param>
/// <param name="layerPrefix"> is a null-terminated string that is an abbreviation of the name of the component making the callback. <code>pLayerPrefix</code> is only valid for the duration of the callback.</param>
/// <param name="message"> is a null-terminated string detailing the trigger conditions. <code>pMessage</code> is only valid for the duration of the callback.</param>
/// <param name="userData"> is the user data given when the <a href="#VkDebugReportCallbackEXT">VkDebugReportCallbackEXT</a> was created.</param>
/// <remarks>The callback <strong class="purple">must</strong> not call <code>vkDestroyDebugReportCallbackEXT</code>.</remarks>
public unsafe delegate VkBool32 DebugReportCallbackEXTDelegate(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message, void* userData);

/// <summary></summary>
/// <param name="messageSeverity"> specifies the <a href="#VkDebugUtilsMessageSeverityFlagBitsEXT">VkDebugUtilsMessageSeverityFlagBitsEXT</a> that triggered this callback.</param>
/// <param name="messageTypes"> is a bitmask of <a href="#VkDebugUtilsMessageTypeFlagBitsEXT">VkDebugUtilsMessageTypeFlagBitsEXT</a> specifying which type of event(s) triggered this callback.</param>
/// <param name="callbackData"> contains all the callback related data in the <a href="#VkDebugUtilsMessengerCallbackDataEXT">VkDebugUtilsMessengerCallbackDataEXT</a> structure.</param>
/// <param name="userData"> is the user data provided when the <a href="#VkDebugUtilsMessengerEXT">VkDebugUtilsMessengerEXT</a> was created.</param>
/// <remarks>The callback returns a <a href="#VkBool32">VkBool32</a>, which is interpreted in a layer-specified manner. The application <strong class="purple">should</strong> always return <code>VK_FALSE</code>. The <code>VK_TRUE</code> value is reserved for use in layer development.</remarks>
public unsafe delegate VkBool32 DebugUtilsMessengerCallbackEXTDelegate(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData, void* userData);

/// <summary></summary>
/// <param name="callbackData"> contains all the callback related data in the <a href="#VkDeviceMemoryReportCallbackDataEXT">VkDeviceMemoryReportCallbackDataEXT</a> structure.</param>
/// <param name="userData"> is the user data provided when the <a href="#VkDeviceDeviceMemoryReportCreateInfoEXT">VkDeviceDeviceMemoryReportCreateInfoEXT</a> was created.</param>
/// <remarks>The callback <strong class="purple">must</strong> not make calls to any Vulkan commands.</remarks>
public unsafe delegate void DeviceMemoryReportCallbackEXTDelegate(VkDeviceMemoryReportCallbackDataEXT* callbackData, void* userData);

