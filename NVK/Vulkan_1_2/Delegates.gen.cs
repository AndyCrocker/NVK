// This file was generated, don't manually edit
namespace Vulkan_1_2;

public unsafe delegate void* PFN_vkAllocationFunction(void* pUserData, size_t size, size_t alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void* PFN_vkReallocationFunction(void* pUserData, void* pOriginal, size_t size, size_t alignment, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkFreeFunction(void* pUserData, void* pMemory);
public unsafe delegate void PFN_vkInternalAllocationNotification(void* pUserData, size_t size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkInternalFreeNotification(void* pUserData, size_t size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
public unsafe delegate void PFN_vkVoidFunction();
public unsafe delegate VkBool32 PFN_vkDebugReportCallbackEXT(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage, void* pUserData);
public unsafe delegate VkBool32 PFN_vkDebugUtilsMessengerCallbackEXT(VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData);
public unsafe delegate void PFN_vkDeviceMemoryReportCallbackEXT(VkDeviceMemoryReportCallbackDataEXT* pCallbackData, void* pUserData);
