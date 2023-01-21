// This file was generated, don't manually edit
namespace Vulkan_1_2;

public unsafe delegate void* PFN_vkAllocationFunction(void* pUserData, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void* PFN_vkReallocationFunction(void* pUserData, void* pOriginal, nuint size, nuint alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkFreeFunction(void* pUserData, void* pMemory);
public unsafe delegate void PFN_vkInternalAllocationNotification(void* pUserData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkInternalFreeNotification(void* pUserData, nuint size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkVoidFunction();
public unsafe delegate VkBool32 PFN_vkDebugReportCallbackEXT(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage, void* pUserData);
public unsafe delegate VkBool32 PFN_vkDebugUtilsMessengerCallbackEXT(VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData);
public unsafe delegate void PFN_vkDeviceMemoryReportCallbackEXT(VkDeviceMemoryReportCallbackDataEXT* pCallbackData, void* pUserData);
