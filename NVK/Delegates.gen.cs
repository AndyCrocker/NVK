// this file was generated, don't edit manually

using System;

namespace Vulkan;
public unsafe delegate void InternalAllocationNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void InternalFreeNotificationDelegate(void* userData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void* ReallocationFunctionDelegate(void* userData, void* original, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void* AllocationFunctionDelegate(void* userData, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void FreeFunctionDelegate(void* userData, void* memory);
public unsafe delegate void VoidFunctionDelegate();
public unsafe delegate VkBool32 DebugReportCallbackEXTDelegate(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message, void* userData);
public unsafe delegate VkBool32 DebugUtilsMessengerCallbackEXTDelegate(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData, void* userData);
public unsafe delegate void DeviceMemoryReportCallbackEXTDelegate(VkDeviceMemoryReportCallbackDataEXT* callbackData, void* userData);
