// This file was generated, don't manually edit
namespace Vulkan_1_0;

public static unsafe class VK
{
	public const float LodClampNone = 1000F;
	public const uint RemainingMipLevels = ~0U;
	public const uint RemainingArrayLayers = ~0U;
	public const ulong WholeSize = ~0UL;
	public const uint AttachmentUnused = ~0U;
	public const uint True = 1;
	public const uint False = 0;
	public const uint QueueFamilyIgnored = ~0U;
	public const uint SubpassExternal = ~0U;
	public const uint MaxPhysicalDeviceNameSize = 256;
	public const uint UuidSize = 16;
	public const uint MaxMemoryTypes = 32;
	public const uint MaxMemoryHeaps = 16;
	public const uint MaxExtensionNameSize = 256;
	public const uint MaxDescriptionSize = 256;
	public const uint KhrSurfaceSpecVersion = 25;
	public const string KhrSurfaceExtensionName = "VK_KHR_surface";
	public const uint KhrSwapchainSpecVersion = 68;
	public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
	public const uint KhrDisplaySpecVersion = 21;
	public const string KhrDisplayExtensionName = "VK_KHR_display";
	public const uint KhrDisplaySwapchainSpecVersion = 9;
	public const string KhrDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
	public const uint KhrXlibSurfaceSpecVersion = 6;
	public const string KhrXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
	public const uint KhrXcbSurfaceSpecVersion = 6;
	public const string KhrXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
	public const uint KhrWaylandSurfaceSpecVersion = 6;
	public const string KhrWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
	public const uint KhrMirSurfaceSpecVersion = 4;
	public const string KhrMirSurfaceExtensionName = "VK_KHR_mir_surface";
	public const uint KhrAndroidSurfaceSpecVersion = 6;
	public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
	public const uint KhrWin32SurfaceSpecVersion = 6;
	public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
	public const uint ExtDebugReportSpecVersion = 9;
	public const string ExtDebugReportExtensionName = "VK_EXT_debug_report";
	public const uint NvGlslShaderSpecVersion = 1;
	public const string NvGlslShaderExtensionName = "VK_NV_glsl_shader";
	public const uint ExtDepthRangeUnrestrictedSpecVersion = 1;
	public const string ExtDepthRangeUnrestrictedExtensionName = "VK_EXT_depth_range_unrestricted";
	public const uint KhrSamplerMirrorClampToEdgeSpecVersion = 1;
	public const string KhrSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
	public const uint ImgFilterCubicSpecVersion = 1;
	public const string ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
	public const uint AmdRasterizationOrderSpecVersion = 1;
	public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
	public const uint AmdShaderTrinaryMinmaxSpecVersion = 1;
	public const string AmdShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
	public const uint AmdShaderExplicitVertexParameterSpecVersion = 1;
	public const string AmdShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
	public const uint ExtDebugMarkerSpecVersion = 4;
	public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
	public const uint AmdGcnShaderSpecVersion = 1;
	public const string AmdGcnShaderExtensionName = "VK_AMD_gcn_shader";
	public const uint NvDedicatedAllocationSpecVersion = 1;
	public const string NvDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
	public const uint AmdDrawIndirectCountSpecVersion = 1;
	public const string AmdDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
	public const uint AmdNegativeViewportHeightSpecVersion = 1;
	public const string AmdNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
	public const uint AmdGpuShaderHalfFloatSpecVersion = 1;
	public const string AmdGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
	public const uint AmdShaderBallotSpecVersion = 1;
	public const string AmdShaderBallotExtensionName = "VK_AMD_shader_ballot";
	public const uint AmdTextureGatherBiasLodSpecVersion = 1;
	public const string AmdTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
	public const uint AmdShaderInfoSpecVersion = 1;
	public const string AmdShaderInfoExtensionName = "VK_AMD_shader_info";
	public const uint AmdShaderImageLoadStoreLodSpecVersion = 1;
	public const string AmdShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
	public const uint KhxMultiviewSpecVersion = 1;
	public const string KhxMultiviewExtensionName = "VK_KHX_multiview";
	public const uint ImgFormatPvrtcSpecVersion = 1;
	public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
	public const uint NvExternalMemoryCapabilitiesSpecVersion = 1;
	public const string NvExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
	public const uint NvExternalMemorySpecVersion = 1;
	public const string NvExternalMemoryExtensionName = "VK_NV_external_memory";
	public const uint NvExternalMemoryWin32SpecVersion = 1;
	public const string NvExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
	public const uint NvWin32KeyedMutexSpecVersion = 1;
	public const string NvWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
	public const uint KhrGetPhysicalDeviceProperties2SpecVersion = 1;
	public const string KhrGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
	public const uint KhxDeviceGroupSpecVersion = 2;
	public const string KhxDeviceGroupExtensionName = "VK_KHX_device_group";
	public const uint MaxDeviceGroupSizeKhx = 32;
	public const uint ExtValidationFlagsSpecVersion = 1;
	public const string ExtValidationFlagsExtensionName = "VK_EXT_validation_flags";
	public const uint NnViSurfaceSpecVersion = 1;
	public const string NnViSurfaceExtensionName = "VK_NN_vi_surface";
	public const uint KhrShaderDrawParametersSpecVersion = 1;
	public const string KhrShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
	public const uint ExtShaderSubgroupBallotSpecVersion = 1;
	public const string ExtShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
	public const uint ExtShaderSubgroupVoteSpecVersion = 1;
	public const string ExtShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
	public const uint KhrMaintenance1SpecVersion = 1;
	public const string KhrMaintenance1ExtensionName = "VK_KHR_maintenance1";
	public const uint KhxDeviceGroupCreationSpecVersion = 1;
	public const string KhxDeviceGroupCreationExtensionName = "VK_KHX_device_group_creation";
	public const uint LuidSizeKhr = 8;
	public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
	public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
	public const uint QueueFamilyExternalKhr = ~0U-1;
	public const uint KhrExternalMemorySpecVersion = 1;
	public const string KhrExternalMemoryExtensionName = "VK_KHR_external_memory";
	public const uint KhrExternalMemoryWin32SpecVersion = 1;
	public const string KhrExternalMemoryWin32ExtensionName = "VK_KHR_external_memory_win32";
	public const uint KhrExternalMemoryFdSpecVersion = 1;
	public const string KhrExternalMemoryFdExtensionName = "VK_KHR_external_memory_fd";
	public const uint KhrWin32KeyedMutexSpecVersion = 1;
	public const string KhrWin32KeyedMutexExtensionName = "VK_KHR_win32_keyed_mutex";
	public const uint KhrExternalSemaphoreCapabilitiesSpecVersion = 1;
	public const string KhrExternalSemaphoreCapabilitiesExtensionName = "VK_KHR_external_semaphore_capabilities";
	public const uint KhrExternalSemaphoreSpecVersion = 1;
	public const string KhrExternalSemaphoreExtensionName = "VK_KHR_external_semaphore";
	public const uint KhrExternalSemaphoreWin32SpecVersion = 1;
	public const string KhrExternalSemaphoreWin32ExtensionName = "VK_KHR_external_semaphore_win32";
	public const uint KhrExternalSemaphoreFdSpecVersion = 1;
	public const string KhrExternalSemaphoreFdExtensionName = "VK_KHR_external_semaphore_fd";
	public const uint KhrPushDescriptorSpecVersion = 1;
	public const string KhrPushDescriptorExtensionName = "VK_KHR_push_descriptor";
	public const uint Khr16bitStorageSpecVersion = 1;
	public const string Khr16bitStorageExtensionName = "VK_KHR_16bit_storage";
	public const uint KhrIncrementalPresentSpecVersion = 1;
	public const string KhrIncrementalPresentExtensionName = "VK_KHR_incremental_present";
	public const uint KhrDescriptorUpdateTemplateSpecVersion = 1;
	public const string KhrDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
	public const uint NvxDeviceGeneratedCommandsSpecVersion = 3;
	public const string NvxDeviceGeneratedCommandsExtensionName = "VK_NVX_device_generated_commands";
	public const uint NvClipSpaceWScalingSpecVersion = 1;
	public const string NvClipSpaceWScalingExtensionName = "VK_NV_clip_space_w_scaling";
	public const uint ExtDirectModeDisplaySpecVersion = 1;
	public const string ExtDirectModeDisplayExtensionName = "VK_EXT_direct_mode_display";
	public const uint ExtAcquireXlibDisplaySpecVersion = 1;
	public const string ExtAcquireXlibDisplayExtensionName = "VK_EXT_acquire_xlib_display";
	public const uint ExtDisplaySurfaceCounterSpecVersion = 1;
	public const string ExtDisplaySurfaceCounterExtensionName = "VK_EXT_display_surface_counter";
	public const uint ExtDisplayControlSpecVersion = 1;
	public const string ExtDisplayControlExtensionName = "VK_EXT_display_control";
	public const uint GoogleDisplayTimingSpecVersion = 1;
	public const string GoogleDisplayTimingExtensionName = "VK_GOOGLE_display_timing";
	public const uint NvSampleMaskOverrideCoverageSpecVersion = 1;
	public const string NvSampleMaskOverrideCoverageExtensionName = "VK_NV_sample_mask_override_coverage";
	public const uint NvGeometryShaderPassthroughSpecVersion = 1;
	public const string NvGeometryShaderPassthroughExtensionName = "VK_NV_geometry_shader_passthrough";
	public const uint NvViewportArray2SpecVersion = 1;
	public const string NvViewportArray2ExtensionName = "VK_NV_viewport_array2";
	public const uint NvxMultiviewPerViewAttributesSpecVersion = 1;
	public const string NvxMultiviewPerViewAttributesExtensionName = "VK_NVX_multiview_per_view_attributes";
	public const uint NvViewportSwizzleSpecVersion = 1;
	public const string NvViewportSwizzleExtensionName = "VK_NV_viewport_swizzle";
	public const uint ExtDiscardRectanglesSpecVersion = 1;
	public const string ExtDiscardRectanglesExtensionName = "VK_EXT_discard_rectangles";
	public const uint ExtConservativeRasterizationSpecVersion = 1;
	public const string ExtConservativeRasterizationExtensionName = "VK_EXT_conservative_rasterization";
	public const uint ExtSwapchainColorSpaceSpecVersion = 3;
	public const string ExtSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
	public const uint ExtHdrMetadataSpecVersion = 1;
	public const string ExtHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
	public const uint KhrSharedPresentableImageSpecVersion = 1;
	public const string KhrSharedPresentableImageExtensionName = "VK_KHR_shared_presentable_image";
	public const uint KhrExternalFenceCapabilitiesSpecVersion = 1;
	public const string KhrExternalFenceCapabilitiesExtensionName = "VK_KHR_external_fence_capabilities";
	public const uint KhrExternalFenceSpecVersion = 1;
	public const string KhrExternalFenceExtensionName = "VK_KHR_external_fence";
	public const uint KhrExternalFenceWin32SpecVersion = 1;
	public const string KhrExternalFenceWin32ExtensionName = "VK_KHR_external_fence_win32";
	public const uint KhrExternalFenceFdSpecVersion = 1;
	public const string KhrExternalFenceFdExtensionName = "VK_KHR_external_fence_fd";
	public const uint KhrMaintenance2SpecVersion = 1;
	public const string KhrMaintenance2ExtensionName = "VK_KHR_maintenance2";
	public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
	public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
	public const uint KhrVariablePointersSpecVersion = 1;
	public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
	public const uint MvkIosSurfaceSpecVersion = 2;
	public const string MvkIosSurfaceExtensionName = "VK_MVK_ios_surface";
	public const uint MvkMacosSurfaceSpecVersion = 2;
	public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
	public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
	public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
	public const uint QueueFamilyForeignExt = ~0U-2;
	public const uint ExtQueueFamilyForeignSpecVersion = 1;
	public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
	public const uint KhrDedicatedAllocationSpecVersion = 3;
	public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
	public const uint ExtSamplerFilterMinmaxSpecVersion = 1;
	public const string ExtSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
	public const uint KhrStorageBufferStorageClassSpecVersion = 1;
	public const string KhrStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
	public const uint AmdGpuShaderInt16SpecVersion = 1;
	public const string AmdGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
	public const uint AmdMixedAttachmentSamplesSpecVersion = 1;
	public const string AmdMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
	public const uint AmdShaderFragmentMaskSpecVersion = 1;
	public const string AmdShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
	public const uint ExtShaderStencilExportSpecVersion = 1;
	public const string ExtShaderStencilExportExtensionName = "VK_EXT_shader_stencil_export";
	public const uint ExtSampleLocationsSpecVersion = 1;
	public const string ExtSampleLocationsExtensionName = "VK_EXT_sample_locations";
	public const uint KhrRelaxedBlockLayoutSpecVersion = 1;
	public const string KhrRelaxedBlockLayoutExtensionName = "VK_KHR_relaxed_block_layout";
	public const uint KhrGetMemoryRequirements2SpecVersion = 1;
	public const string KhrGetMemoryRequirements2ExtensionName = "VK_KHR_get_memory_requirements2";
	public const uint KhrImageFormatListSpecVersion = 1;
	public const string KhrImageFormatListExtensionName = "VK_KHR_image_format_list";
	public const uint ExtBlendOperationAdvancedSpecVersion = 2;
	public const string ExtBlendOperationAdvancedExtensionName = "VK_EXT_blend_operation_advanced";
	public const uint NvFragmentCoverageToColorSpecVersion = 1;
	public const string NvFragmentCoverageToColorExtensionName = "VK_NV_fragment_coverage_to_color";
	public const uint NvFramebufferMixedSamplesSpecVersion = 1;
	public const string NvFramebufferMixedSamplesExtensionName = "VK_NV_framebuffer_mixed_samples";
	public const uint NvFillRectangleSpecVersion = 1;
	public const string NvFillRectangleExtensionName = "VK_NV_fill_rectangle";
	public const uint ExtPostDepthCoverageSpecVersion = 1;
	public const string ExtPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
	public const uint KhrSamplerYcbcrConversionSpecVersion = 1;
	public const string KhrSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
	public const uint KhrBindMemory2SpecVersion = 1;
	public const string KhrBindMemory2ExtensionName = "VK_KHR_bind_memory2";
	public const uint ExtValidationCacheSpecVersion = 1;
	public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
	public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
	public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
	public const uint ExtGlobalPrioritySpecVersion = 2;
	public const string ExtGlobalPriorityExtensionName = "VK_EXT_global_priority";
	public const uint ExtExternalMemoryHostSpecVersion = 1;
	public const string ExtExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
	public const uint AmdBufferMarkerSpecVersion = 1;
	public const string AmdBufferMarkerExtensionName = "VK_AMD_buffer_marker";
	public static VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance) => vkCreateInstance_0(pCreateInfo, pAllocator, pInstance);
	private delegate VkResult vkCreateInstanceDelegate_0(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
	private static IntPtr vkCreateInstancePointer;
	private static vkCreateInstanceDelegate_0 vkCreateInstance_0;
	public static void vkDestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator) => vkDestroyInstance_0(instance, pAllocator);
	private delegate void vkDestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyInstancePointer;
	private static vkDestroyInstanceDelegate_0 vkDestroyInstance_0;
	public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices) => vkEnumeratePhysicalDevices_0(instance, pPhysicalDeviceCount, pPhysicalDevices);
	private delegate VkResult vkEnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
	private static IntPtr vkEnumeratePhysicalDevicesPointer;
	private static vkEnumeratePhysicalDevicesDelegate_0 vkEnumeratePhysicalDevices_0;
	public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures) => vkGetPhysicalDeviceFeatures_0(physicalDevice, pFeatures);
	private delegate void vkGetPhysicalDeviceFeaturesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);
	private static IntPtr vkGetPhysicalDeviceFeaturesPointer;
	private static vkGetPhysicalDeviceFeaturesDelegate_0 vkGetPhysicalDeviceFeatures_0;
	public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties) => vkGetPhysicalDeviceFormatProperties_0(physicalDevice, format, pFormatProperties);
	private delegate void vkGetPhysicalDeviceFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);
	private static IntPtr vkGetPhysicalDeviceFormatPropertiesPointer;
	private static vkGetPhysicalDeviceFormatPropertiesDelegate_0 vkGetPhysicalDeviceFormatProperties_0;
	public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties) => vkGetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
	private delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceImageFormatPropertiesPointer;
	private static vkGetPhysicalDeviceImageFormatPropertiesDelegate_0 vkGetPhysicalDeviceImageFormatProperties_0;
	public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties) => vkGetPhysicalDeviceProperties_0(physicalDevice, pProperties);
	private delegate void vkGetPhysicalDevicePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);
	private static IntPtr vkGetPhysicalDevicePropertiesPointer;
	private static vkGetPhysicalDevicePropertiesDelegate_0 vkGetPhysicalDeviceProperties_0;
	public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) => vkGetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyPropertiesPointer;
	private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate_0 vkGetPhysicalDeviceQueueFamilyProperties_0;
	public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties) => vkGetPhysicalDeviceMemoryProperties_0(physicalDevice, pMemoryProperties);
	private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
	private static IntPtr vkGetPhysicalDeviceMemoryPropertiesPointer;
	private static vkGetPhysicalDeviceMemoryPropertiesDelegate_0 vkGetPhysicalDeviceMemoryProperties_0;
	public static PFN_vkVoidFunction vkGetInstanceProcAddr(VkInstance instance, byte* pName) => vkGetInstanceProcAddr_0(instance, pName);
	private delegate PFN_vkVoidFunction vkGetInstanceProcAddrDelegate_0(VkInstance instance, byte* pName);
	private static IntPtr vkGetInstanceProcAddrPointer;
	private static vkGetInstanceProcAddrDelegate_0 vkGetInstanceProcAddr_0;
	public static PFN_vkVoidFunction vkGetDeviceProcAddr(VkDevice device, byte* pName) => vkGetDeviceProcAddr_0(device, pName);
	private delegate PFN_vkVoidFunction vkGetDeviceProcAddrDelegate_0(VkDevice device, byte* pName);
	private static IntPtr vkGetDeviceProcAddrPointer;
	private static vkGetDeviceProcAddrDelegate_0 vkGetDeviceProcAddr_0;
	public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice) => vkCreateDevice_0(physicalDevice, pCreateInfo, pAllocator, pDevice);
	private delegate VkResult vkCreateDeviceDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice);
	private static IntPtr vkCreateDevicePointer;
	private static vkCreateDeviceDelegate_0 vkCreateDevice_0;
	public static void vkDestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator) => vkDestroyDevice_0(device, pAllocator);
	private delegate void vkDestroyDeviceDelegate_0(VkDevice device, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDevicePointer;
	private static vkDestroyDeviceDelegate_0 vkDestroyDevice_0;
	public static VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties) => vkEnumerateInstanceExtensionProperties_0(pLayerName, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate_0(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr vkEnumerateInstanceExtensionPropertiesPointer;
	private static vkEnumerateInstanceExtensionPropertiesDelegate_0 vkEnumerateInstanceExtensionProperties_0;
	public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties) => vkEnumerateDeviceExtensionProperties_0(physicalDevice, pLayerName, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr vkEnumerateDeviceExtensionPropertiesPointer;
	private static vkEnumerateDeviceExtensionPropertiesDelegate_0 vkEnumerateDeviceExtensionProperties_0;
	public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties) => vkEnumerateInstanceLayerProperties_0(pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate_0(uint* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr vkEnumerateInstanceLayerPropertiesPointer;
	private static vkEnumerateInstanceLayerPropertiesDelegate_0 vkEnumerateInstanceLayerProperties_0;
	public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties) => vkEnumerateDeviceLayerProperties_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr vkEnumerateDeviceLayerPropertiesPointer;
	private static vkEnumerateDeviceLayerPropertiesDelegate_0 vkEnumerateDeviceLayerProperties_0;
	public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue) => vkGetDeviceQueue_0(device, queueFamilyIndex, queueIndex, pQueue);
	private delegate void vkGetDeviceQueueDelegate_0(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue);
	private static IntPtr vkGetDeviceQueuePointer;
	private static vkGetDeviceQueueDelegate_0 vkGetDeviceQueue_0;
	public static VkResult vkQueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence) => vkQueueSubmit_0(queue, submitCount, pSubmits, fence);
	private delegate VkResult vkQueueSubmitDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence);
	private static IntPtr vkQueueSubmitPointer;
	private static vkQueueSubmitDelegate_0 vkQueueSubmit_0;
	public static VkResult vkQueueWaitIdle(VkQueue queue) => vkQueueWaitIdle_0(queue);
	private delegate VkResult vkQueueWaitIdleDelegate_0(VkQueue queue);
	private static IntPtr vkQueueWaitIdlePointer;
	private static vkQueueWaitIdleDelegate_0 vkQueueWaitIdle_0;
	public static VkResult vkDeviceWaitIdle(VkDevice device) => vkDeviceWaitIdle_0(device);
	private delegate VkResult vkDeviceWaitIdleDelegate_0(VkDevice device);
	private static IntPtr vkDeviceWaitIdlePointer;
	private static vkDeviceWaitIdleDelegate_0 vkDeviceWaitIdle_0;
	public static VkResult vkAllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory) => vkAllocateMemory_0(device, pAllocateInfo, pAllocator, pMemory);
	private delegate VkResult vkAllocateMemoryDelegate_0(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);
	private static IntPtr vkAllocateMemoryPointer;
	private static vkAllocateMemoryDelegate_0 vkAllocateMemory_0;
	public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator) => vkFreeMemory_0(device, memory, pAllocator);
	private delegate void vkFreeMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkFreeMemoryPointer;
	private static vkFreeMemoryDelegate_0 vkFreeMemory_0;
	public static VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** ppData) => vkMapMemory_0(device, memory, offset, size, flags, ppData);
	private delegate VkResult vkMapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** ppData);
	private static IntPtr vkMapMemoryPointer;
	private static vkMapMemoryDelegate_0 vkMapMemory_0;
	public static void vkUnmapMemory(VkDevice device, VkDeviceMemory memory) => vkUnmapMemory_0(device, memory);
	private delegate void vkUnmapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory);
	private static IntPtr vkUnmapMemoryPointer;
	private static vkUnmapMemoryDelegate_0 vkUnmapMemory_0;
	public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => vkFlushMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult vkFlushMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
	private static IntPtr vkFlushMappedMemoryRangesPointer;
	private static vkFlushMappedMemoryRangesDelegate_0 vkFlushMappedMemoryRanges_0;
	public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => vkInvalidateMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult vkInvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
	private static IntPtr vkInvalidateMappedMemoryRangesPointer;
	private static vkInvalidateMappedMemoryRangesDelegate_0 vkInvalidateMappedMemoryRanges_0;
	public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes) => vkGetDeviceMemoryCommitment_0(device, memory, pCommittedMemoryInBytes);
	private delegate void vkGetDeviceMemoryCommitmentDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes);
	private static IntPtr vkGetDeviceMemoryCommitmentPointer;
	private static vkGetDeviceMemoryCommitmentDelegate_0 vkGetDeviceMemoryCommitment_0;
	public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) => vkBindBufferMemory_0(device, buffer, memory, memoryOffset);
	private delegate VkResult vkBindBufferMemoryDelegate_0(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static IntPtr vkBindBufferMemoryPointer;
	private static vkBindBufferMemoryDelegate_0 vkBindBufferMemory_0;
	public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset) => vkBindImageMemory_0(device, image, memory, memoryOffset);
	private delegate VkResult vkBindImageMemoryDelegate_0(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static IntPtr vkBindImageMemoryPointer;
	private static vkBindImageMemoryDelegate_0 vkBindImageMemory_0;
	public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements) => vkGetBufferMemoryRequirements_0(device, buffer, pMemoryRequirements);
	private delegate void vkGetBufferMemoryRequirementsDelegate_0(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);
	private static IntPtr vkGetBufferMemoryRequirementsPointer;
	private static vkGetBufferMemoryRequirementsDelegate_0 vkGetBufferMemoryRequirements_0;
	public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements) => vkGetImageMemoryRequirements_0(device, image, pMemoryRequirements);
	private delegate void vkGetImageMemoryRequirementsDelegate_0(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);
	private static IntPtr vkGetImageMemoryRequirementsPointer;
	private static vkGetImageMemoryRequirementsDelegate_0 vkGetImageMemoryRequirements_0;
	public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements) => vkGetImageSparseMemoryRequirements_0(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
	private static IntPtr vkGetImageSparseMemoryRequirementsPointer;
	private static vkGetImageSparseMemoryRequirementsDelegate_0 vkGetImageSparseMemoryRequirements_0;
	public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties) => vkGetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
	private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties);
	private static IntPtr vkGetPhysicalDeviceSparseImageFormatPropertiesPointer;
	private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 vkGetPhysicalDeviceSparseImageFormatProperties_0;
	public static VkResult vkQueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence) => vkQueueBindSparse_0(queue, bindInfoCount, pBindInfo, fence);
	private delegate VkResult vkQueueBindSparseDelegate_0(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
	private static IntPtr vkQueueBindSparsePointer;
	private static vkQueueBindSparseDelegate_0 vkQueueBindSparse_0;
	public static VkResult vkCreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => vkCreateFence_0(device, pCreateInfo, pAllocator, pFence);
	private delegate VkResult vkCreateFenceDelegate_0(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr vkCreateFencePointer;
	private static vkCreateFenceDelegate_0 vkCreateFence_0;
	public static void vkDestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator) => vkDestroyFence_0(device, fence, pAllocator);
	private delegate void vkDestroyFenceDelegate_0(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyFencePointer;
	private static vkDestroyFenceDelegate_0 vkDestroyFence_0;
	public static VkResult vkResetFences(VkDevice device, uint fenceCount, VkFence* pFences) => vkResetFences_0(device, fenceCount, pFences);
	private delegate VkResult vkResetFencesDelegate_0(VkDevice device, uint fenceCount, VkFence* pFences);
	private static IntPtr vkResetFencesPointer;
	private static vkResetFencesDelegate_0 vkResetFences_0;
	public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence) => vkGetFenceStatus_0(device, fence);
	private delegate VkResult vkGetFenceStatusDelegate_0(VkDevice device, VkFence fence);
	private static IntPtr vkGetFenceStatusPointer;
	private static vkGetFenceStatusDelegate_0 vkGetFenceStatus_0;
	public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout) => vkWaitForFences_0(device, fenceCount, pFences, waitAll, timeout);
	private delegate VkResult vkWaitForFencesDelegate_0(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout);
	private static IntPtr vkWaitForFencesPointer;
	private static vkWaitForFencesDelegate_0 vkWaitForFences_0;
	public static VkResult vkCreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore) => vkCreateSemaphore_0(device, pCreateInfo, pAllocator, pSemaphore);
	private delegate VkResult vkCreateSemaphoreDelegate_0(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);
	private static IntPtr vkCreateSemaphorePointer;
	private static vkCreateSemaphoreDelegate_0 vkCreateSemaphore_0;
	public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator) => vkDestroySemaphore_0(device, semaphore, pAllocator);
	private delegate void vkDestroySemaphoreDelegate_0(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySemaphorePointer;
	private static vkDestroySemaphoreDelegate_0 vkDestroySemaphore_0;
	public static VkResult vkCreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent) => vkCreateEvent_0(device, pCreateInfo, pAllocator, pEvent);
	private delegate VkResult vkCreateEventDelegate_0(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent);
	private static IntPtr vkCreateEventPointer;
	private static vkCreateEventDelegate_0 vkCreateEvent_0;
	public static void vkDestroyEvent(VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator) => vkDestroyEvent_0(device, event, pAllocator);
	private delegate void vkDestroyEventDelegate_0(VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyEventPointer;
	private static vkDestroyEventDelegate_0 vkDestroyEvent_0;
	public static VkResult vkGetEventStatus(VkDevice device, VkEvent event) => vkGetEventStatus_0(device, event);
	private delegate VkResult vkGetEventStatusDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr vkGetEventStatusPointer;
	private static vkGetEventStatusDelegate_0 vkGetEventStatus_0;
	public static VkResult vkSetEvent(VkDevice device, VkEvent event) => vkSetEvent_0(device, event);
	private delegate VkResult vkSetEventDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr vkSetEventPointer;
	private static vkSetEventDelegate_0 vkSetEvent_0;
	public static VkResult vkResetEvent(VkDevice device, VkEvent event) => vkResetEvent_0(device, event);
	private delegate VkResult vkResetEventDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr vkResetEventPointer;
	private static vkResetEventDelegate_0 vkResetEvent_0;
	public static VkResult vkCreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool) => vkCreateQueryPool_0(device, pCreateInfo, pAllocator, pQueryPool);
	private delegate VkResult vkCreateQueryPoolDelegate_0(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);
	private static IntPtr vkCreateQueryPoolPointer;
	private static vkCreateQueryPoolDelegate_0 vkCreateQueryPool_0;
	public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator) => vkDestroyQueryPool_0(device, queryPool, pAllocator);
	private delegate void vkDestroyQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyQueryPoolPointer;
	private static vkDestroyQueryPoolDelegate_0 vkDestroyQueryPool_0;
	public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags) => vkGetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
	private delegate VkResult vkGetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags);
	private static IntPtr vkGetQueryPoolResultsPointer;
	private static vkGetQueryPoolResultsDelegate_0 vkGetQueryPoolResults_0;
	public static VkResult vkCreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer) => vkCreateBuffer_0(device, pCreateInfo, pAllocator, pBuffer);
	private delegate VkResult vkCreateBufferDelegate_0(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);
	private static IntPtr vkCreateBufferPointer;
	private static vkCreateBufferDelegate_0 vkCreateBuffer_0;
	public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator) => vkDestroyBuffer_0(device, buffer, pAllocator);
	private delegate void vkDestroyBufferDelegate_0(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyBufferPointer;
	private static vkDestroyBufferDelegate_0 vkDestroyBuffer_0;
	public static VkResult vkCreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView) => vkCreateBufferView_0(device, pCreateInfo, pAllocator, pView);
	private delegate VkResult vkCreateBufferViewDelegate_0(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView);
	private static IntPtr vkCreateBufferViewPointer;
	private static vkCreateBufferViewDelegate_0 vkCreateBufferView_0;
	public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator) => vkDestroyBufferView_0(device, bufferView, pAllocator);
	private delegate void vkDestroyBufferViewDelegate_0(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyBufferViewPointer;
	private static vkDestroyBufferViewDelegate_0 vkDestroyBufferView_0;
	public static VkResult vkCreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage) => vkCreateImage_0(device, pCreateInfo, pAllocator, pImage);
	private delegate VkResult vkCreateImageDelegate_0(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage);
	private static IntPtr vkCreateImagePointer;
	private static vkCreateImageDelegate_0 vkCreateImage_0;
	public static void vkDestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator) => vkDestroyImage_0(device, image, pAllocator);
	private delegate void vkDestroyImageDelegate_0(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyImagePointer;
	private static vkDestroyImageDelegate_0 vkDestroyImage_0;
	public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout) => vkGetImageSubresourceLayout_0(device, image, pSubresource, pLayout);
	private delegate void vkGetImageSubresourceLayoutDelegate_0(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);
	private static IntPtr vkGetImageSubresourceLayoutPointer;
	private static vkGetImageSubresourceLayoutDelegate_0 vkGetImageSubresourceLayout_0;
	public static VkResult vkCreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView) => vkCreateImageView_0(device, pCreateInfo, pAllocator, pView);
	private delegate VkResult vkCreateImageViewDelegate_0(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView);
	private static IntPtr vkCreateImageViewPointer;
	private static vkCreateImageViewDelegate_0 vkCreateImageView_0;
	public static void vkDestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator) => vkDestroyImageView_0(device, imageView, pAllocator);
	private delegate void vkDestroyImageViewDelegate_0(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyImageViewPointer;
	private static vkDestroyImageViewDelegate_0 vkDestroyImageView_0;
	public static VkResult vkCreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule) => vkCreateShaderModule_0(device, pCreateInfo, pAllocator, pShaderModule);
	private delegate VkResult vkCreateShaderModuleDelegate_0(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);
	private static IntPtr vkCreateShaderModulePointer;
	private static vkCreateShaderModuleDelegate_0 vkCreateShaderModule_0;
	public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator) => vkDestroyShaderModule_0(device, shaderModule, pAllocator);
	private delegate void vkDestroyShaderModuleDelegate_0(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyShaderModulePointer;
	private static vkDestroyShaderModuleDelegate_0 vkDestroyShaderModule_0;
	public static VkResult vkCreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache) => vkCreatePipelineCache_0(device, pCreateInfo, pAllocator, pPipelineCache);
	private delegate VkResult vkCreatePipelineCacheDelegate_0(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);
	private static IntPtr vkCreatePipelineCachePointer;
	private static vkCreatePipelineCacheDelegate_0 vkCreatePipelineCache_0;
	public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator) => vkDestroyPipelineCache_0(device, pipelineCache, pAllocator);
	private delegate void vkDestroyPipelineCacheDelegate_0(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyPipelineCachePointer;
	private static vkDestroyPipelineCacheDelegate_0 vkDestroyPipelineCache_0;
	public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData) => vkGetPipelineCacheData_0(device, pipelineCache, pDataSize, pData);
	private delegate VkResult vkGetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData);
	private static IntPtr vkGetPipelineCacheDataPointer;
	private static vkGetPipelineCacheDataDelegate_0 vkGetPipelineCacheData_0;
	public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches) => vkMergePipelineCaches_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult vkMergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches);
	private static IntPtr vkMergePipelineCachesPointer;
	private static vkMergePipelineCachesDelegate_0 vkMergePipelineCaches_0;
	public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr vkCreateGraphicsPipelinesPointer;
	private static vkCreateGraphicsPipelinesDelegate_0 vkCreateGraphicsPipelines_0;
	public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateComputePipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr vkCreateComputePipelinesPointer;
	private static vkCreateComputePipelinesDelegate_0 vkCreateComputePipelines_0;
	public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator) => vkDestroyPipeline_0(device, pipeline, pAllocator);
	private delegate void vkDestroyPipelineDelegate_0(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyPipelinePointer;
	private static vkDestroyPipelineDelegate_0 vkDestroyPipeline_0;
	public static VkResult vkCreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout) => vkCreatePipelineLayout_0(device, pCreateInfo, pAllocator, pPipelineLayout);
	private delegate VkResult vkCreatePipelineLayoutDelegate_0(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);
	private static IntPtr vkCreatePipelineLayoutPointer;
	private static vkCreatePipelineLayoutDelegate_0 vkCreatePipelineLayout_0;
	public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator) => vkDestroyPipelineLayout_0(device, pipelineLayout, pAllocator);
	private delegate void vkDestroyPipelineLayoutDelegate_0(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyPipelineLayoutPointer;
	private static vkDestroyPipelineLayoutDelegate_0 vkDestroyPipelineLayout_0;
	public static VkResult vkCreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler) => vkCreateSampler_0(device, pCreateInfo, pAllocator, pSampler);
	private delegate VkResult vkCreateSamplerDelegate_0(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler);
	private static IntPtr vkCreateSamplerPointer;
	private static vkCreateSamplerDelegate_0 vkCreateSampler_0;
	public static void vkDestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator) => vkDestroySampler_0(device, sampler, pAllocator);
	private delegate void vkDestroySamplerDelegate_0(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySamplerPointer;
	private static vkDestroySamplerDelegate_0 vkDestroySampler_0;
	public static VkResult vkCreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout) => vkCreateDescriptorSetLayout_0(device, pCreateInfo, pAllocator, pSetLayout);
	private delegate VkResult vkCreateDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);
	private static IntPtr vkCreateDescriptorSetLayoutPointer;
	private static vkCreateDescriptorSetLayoutDelegate_0 vkCreateDescriptorSetLayout_0;
	public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator) => vkDestroyDescriptorSetLayout_0(device, descriptorSetLayout, pAllocator);
	private delegate void vkDestroyDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDescriptorSetLayoutPointer;
	private static vkDestroyDescriptorSetLayoutDelegate_0 vkDestroyDescriptorSetLayout_0;
	public static VkResult vkCreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool) => vkCreateDescriptorPool_0(device, pCreateInfo, pAllocator, pDescriptorPool);
	private delegate VkResult vkCreateDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);
	private static IntPtr vkCreateDescriptorPoolPointer;
	private static vkCreateDescriptorPoolDelegate_0 vkCreateDescriptorPool_0;
	public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator) => vkDestroyDescriptorPool_0(device, descriptorPool, pAllocator);
	private delegate void vkDestroyDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDescriptorPoolPointer;
	private static vkDestroyDescriptorPoolDelegate_0 vkDestroyDescriptorPool_0;
	public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags) => vkResetDescriptorPool_0(device, descriptorPool, flags);
	private delegate VkResult vkResetDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
	private static IntPtr vkResetDescriptorPoolPointer;
	private static vkResetDescriptorPoolDelegate_0 vkResetDescriptorPool_0;
	public static VkResult vkAllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets) => vkAllocateDescriptorSets_0(device, pAllocateInfo, pDescriptorSets);
	private delegate VkResult vkAllocateDescriptorSetsDelegate_0(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);
	private static IntPtr vkAllocateDescriptorSetsPointer;
	private static vkAllocateDescriptorSetsDelegate_0 vkAllocateDescriptorSets_0;
	public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets) => vkFreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, pDescriptorSets);
	private delegate VkResult vkFreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets);
	private static IntPtr vkFreeDescriptorSetsPointer;
	private static vkFreeDescriptorSetsDelegate_0 vkFreeDescriptorSets_0;
	public static void vkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies) => vkUpdateDescriptorSets_0(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
	private delegate void vkUpdateDescriptorSetsDelegate_0(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
	private static IntPtr vkUpdateDescriptorSetsPointer;
	private static vkUpdateDescriptorSetsDelegate_0 vkUpdateDescriptorSets_0;
	public static VkResult vkCreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer) => vkCreateFramebuffer_0(device, pCreateInfo, pAllocator, pFramebuffer);
	private delegate VkResult vkCreateFramebufferDelegate_0(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);
	private static IntPtr vkCreateFramebufferPointer;
	private static vkCreateFramebufferDelegate_0 vkCreateFramebuffer_0;
	public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator) => vkDestroyFramebuffer_0(device, framebuffer, pAllocator);
	private delegate void vkDestroyFramebufferDelegate_0(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyFramebufferPointer;
	private static vkDestroyFramebufferDelegate_0 vkDestroyFramebuffer_0;
	public static VkResult vkCreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => vkCreateRenderPass_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate VkResult vkCreateRenderPassDelegate_0(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr vkCreateRenderPassPointer;
	private static vkCreateRenderPassDelegate_0 vkCreateRenderPass_0;
	public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator) => vkDestroyRenderPass_0(device, renderPass, pAllocator);
	private delegate void vkDestroyRenderPassDelegate_0(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyRenderPassPointer;
	private static vkDestroyRenderPassDelegate_0 vkDestroyRenderPass_0;
	public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity) => vkGetRenderAreaGranularity_0(device, renderPass, pGranularity);
	private delegate void vkGetRenderAreaGranularityDelegate_0(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);
	private static IntPtr vkGetRenderAreaGranularityPointer;
	private static vkGetRenderAreaGranularityDelegate_0 vkGetRenderAreaGranularity_0;
	public static VkResult vkCreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool) => vkCreateCommandPool_0(device, pCreateInfo, pAllocator, pCommandPool);
	private delegate VkResult vkCreateCommandPoolDelegate_0(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);
	private static IntPtr vkCreateCommandPoolPointer;
	private static vkCreateCommandPoolDelegate_0 vkCreateCommandPool_0;
	public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator) => vkDestroyCommandPool_0(device, commandPool, pAllocator);
	private delegate void vkDestroyCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyCommandPoolPointer;
	private static vkDestroyCommandPoolDelegate_0 vkDestroyCommandPool_0;
	public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags) => vkResetCommandPool_0(device, commandPool, flags);
	private delegate VkResult vkResetCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
	private static IntPtr vkResetCommandPoolPointer;
	private static vkResetCommandPoolDelegate_0 vkResetCommandPool_0;
	public static VkResult vkAllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers) => vkAllocateCommandBuffers_0(device, pAllocateInfo, pCommandBuffers);
	private delegate VkResult vkAllocateCommandBuffersDelegate_0(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);
	private static IntPtr vkAllocateCommandBuffersPointer;
	private static vkAllocateCommandBuffersDelegate_0 vkAllocateCommandBuffers_0;
	public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers) => vkFreeCommandBuffers_0(device, commandPool, commandBufferCount, pCommandBuffers);
	private delegate void vkFreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
	private static IntPtr vkFreeCommandBuffersPointer;
	private static vkFreeCommandBuffersDelegate_0 vkFreeCommandBuffers_0;
	public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo) => vkBeginCommandBuffer_0(commandBuffer, pBeginInfo);
	private delegate VkResult vkBeginCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo);
	private static IntPtr vkBeginCommandBufferPointer;
	private static vkBeginCommandBufferDelegate_0 vkBeginCommandBuffer_0;
	public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer) => vkEndCommandBuffer_0(commandBuffer);
	private delegate VkResult vkEndCommandBufferDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkEndCommandBufferPointer;
	private static vkEndCommandBufferDelegate_0 vkEndCommandBuffer_0;
	public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags) => vkResetCommandBuffer_0(commandBuffer, flags);
	private delegate VkResult vkResetCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
	private static IntPtr vkResetCommandBufferPointer;
	private static vkResetCommandBufferDelegate_0 vkResetCommandBuffer_0;
	public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline) => vkCmdBindPipeline_0(commandBuffer, pipelineBindPoint, pipeline);
	private delegate void vkCmdBindPipelineDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
	private static IntPtr vkCmdBindPipelinePointer;
	private static vkCmdBindPipelineDelegate_0 vkCmdBindPipeline_0;
	public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports) => vkCmdSetViewport_0(commandBuffer, firstViewport, viewportCount, pViewports);
	private delegate void vkCmdSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports);
	private static IntPtr vkCmdSetViewportPointer;
	private static vkCmdSetViewportDelegate_0 vkCmdSetViewport_0;
	public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors) => vkCmdSetScissor_0(commandBuffer, firstScissor, scissorCount, pScissors);
	private delegate void vkCmdSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors);
	private static IntPtr vkCmdSetScissorPointer;
	private static vkCmdSetScissorDelegate_0 vkCmdSetScissor_0;
	public static void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth) => vkCmdSetLineWidth_0(commandBuffer, lineWidth);
	private delegate void vkCmdSetLineWidthDelegate_0(VkCommandBuffer commandBuffer, float lineWidth);
	private static IntPtr vkCmdSetLineWidthPointer;
	private static vkCmdSetLineWidthDelegate_0 vkCmdSetLineWidth_0;
	public static void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) => vkCmdSetDepthBias_0(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
	private delegate void vkCmdSetDepthBiasDelegate_0(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
	private static IntPtr vkCmdSetDepthBiasPointer;
	private static vkCmdSetDepthBiasDelegate_0 vkCmdSetDepthBias_0;
	public static void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants) => vkCmdSetBlendConstants_0(commandBuffer, blendConstants);
	private delegate void vkCmdSetBlendConstantsDelegate_0(VkCommandBuffer commandBuffer, float blendConstants);
	private static IntPtr vkCmdSetBlendConstantsPointer;
	private static vkCmdSetBlendConstantsDelegate_0 vkCmdSetBlendConstants_0;
	public static void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds) => vkCmdSetDepthBounds_0(commandBuffer, minDepthBounds, maxDepthBounds);
	private delegate void vkCmdSetDepthBoundsDelegate_0(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
	private static IntPtr vkCmdSetDepthBoundsPointer;
	private static vkCmdSetDepthBoundsDelegate_0 vkCmdSetDepthBounds_0;
	public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask) => vkCmdSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
	private delegate void vkCmdSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
	private static IntPtr vkCmdSetStencilCompareMaskPointer;
	private static vkCmdSetStencilCompareMaskDelegate_0 vkCmdSetStencilCompareMask_0;
	public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask) => vkCmdSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
	private delegate void vkCmdSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
	private static IntPtr vkCmdSetStencilWriteMaskPointer;
	private static vkCmdSetStencilWriteMaskDelegate_0 vkCmdSetStencilWriteMask_0;
	public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference) => vkCmdSetStencilReference_0(commandBuffer, faceMask, reference);
	private delegate void vkCmdSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
	private static IntPtr vkCmdSetStencilReferencePointer;
	private static vkCmdSetStencilReferenceDelegate_0 vkCmdSetStencilReference_0;
	public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets) => vkCmdBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
	private delegate void vkCmdBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
	private static IntPtr vkCmdBindDescriptorSetsPointer;
	private static vkCmdBindDescriptorSetsDelegate_0 vkCmdBindDescriptorSets_0;
	public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => vkCmdBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
	private delegate void vkCmdBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
	private static IntPtr vkCmdBindIndexBufferPointer;
	private static vkCmdBindIndexBufferDelegate_0 vkCmdBindIndexBuffer_0;
	public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets) => vkCmdBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
	private delegate void vkCmdBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets);
	private static IntPtr vkCmdBindVertexBuffersPointer;
	private static vkCmdBindVertexBuffersDelegate_0 vkCmdBindVertexBuffers_0;
	public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) => vkCmdDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
	private delegate void vkCmdDrawDelegate_0(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
	private static IntPtr vkCmdDrawPointer;
	private static vkCmdDrawDelegate_0 vkCmdDraw_0;
	public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) => vkCmdDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
	private delegate void vkCmdDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
	private static IntPtr vkCmdDrawIndexedPointer;
	private static vkCmdDrawIndexedDelegate_0 vkCmdDrawIndexed_0;
	public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => vkCmdDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void vkCmdDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static IntPtr vkCmdDrawIndirectPointer;
	private static vkCmdDrawIndirectDelegate_0 vkCmdDrawIndirect_0;
	public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => vkCmdDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static IntPtr vkCmdDrawIndexedIndirectPointer;
	private static vkCmdDrawIndexedIndirectDelegate_0 vkCmdDrawIndexedIndirect_0;
	public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) => vkCmdDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
	private delegate void vkCmdDispatchDelegate_0(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static IntPtr vkCmdDispatchPointer;
	private static vkCmdDispatchDelegate_0 vkCmdDispatch_0;
	public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => vkCmdDispatchIndirect_0(commandBuffer, buffer, offset);
	private delegate void vkCmdDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
	private static IntPtr vkCmdDispatchIndirectPointer;
	private static vkCmdDispatchIndirectDelegate_0 vkCmdDispatchIndirect_0;
	public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions) => vkCmdCopyBuffer_0(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
	private delegate void vkCmdCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions);
	private static IntPtr vkCmdCopyBufferPointer;
	private static vkCmdCopyBufferDelegate_0 vkCmdCopyBuffer_0;
	public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions) => vkCmdCopyImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions);
	private static IntPtr vkCmdCopyImagePointer;
	private static vkCmdCopyImageDelegate_0 vkCmdCopyImage_0;
	public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter) => vkCmdBlitImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
	private delegate void vkCmdBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter);
	private static IntPtr vkCmdBlitImagePointer;
	private static vkCmdBlitImageDelegate_0 vkCmdBlitImage_0;
	public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions) => vkCmdCopyBufferToImage_0(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr vkCmdCopyBufferToImagePointer;
	private static vkCmdCopyBufferToImageDelegate_0 vkCmdCopyBufferToImage_0;
	public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions) => vkCmdCopyImageToBuffer_0(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
	private delegate void vkCmdCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr vkCmdCopyImageToBufferPointer;
	private static vkCmdCopyImageToBufferDelegate_0 vkCmdCopyImageToBuffer_0;
	public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData) => vkCmdUpdateBuffer_0(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
	private delegate void vkCmdUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData);
	private static IntPtr vkCmdUpdateBufferPointer;
	private static vkCmdUpdateBufferDelegate_0 vkCmdUpdateBuffer_0;
	public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint data) => vkCmdFillBuffer_0(commandBuffer, dstBuffer, dstOffset, size, data);
	private delegate void vkCmdFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint data);
	private static IntPtr vkCmdFillBufferPointer;
	private static vkCmdFillBufferDelegate_0 vkCmdFillBuffer_0;
	public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges) => vkCmdClearColorImage_0(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
	private delegate void vkCmdClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr vkCmdClearColorImagePointer;
	private static vkCmdClearColorImageDelegate_0 vkCmdClearColorImage_0;
	public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges) => vkCmdClearDepthStencilImage_0(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
	private delegate void vkCmdClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr vkCmdClearDepthStencilImagePointer;
	private static vkCmdClearDepthStencilImageDelegate_0 vkCmdClearDepthStencilImage_0;
	public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects) => vkCmdClearAttachments_0(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
	private delegate void vkCmdClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects);
	private static IntPtr vkCmdClearAttachmentsPointer;
	private static vkCmdClearAttachmentsDelegate_0 vkCmdClearAttachments_0;
	public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions) => vkCmdResolveImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions);
	private static IntPtr vkCmdResolveImagePointer;
	private static vkCmdResolveImageDelegate_0 vkCmdResolveImage_0;
	public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask) => vkCmdSetEvent_0(commandBuffer, event, stageMask);
	private delegate void vkCmdSetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
	private static IntPtr vkCmdSetEventPointer;
	private static vkCmdSetEventDelegate_0 vkCmdSetEvent_0;
	public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask) => vkCmdResetEvent_0(commandBuffer, event, stageMask);
	private delegate void vkCmdResetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
	private static IntPtr vkCmdResetEventPointer;
	private static vkCmdResetEventDelegate_0 vkCmdResetEvent_0;
	public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => vkCmdWaitEvents_0(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void vkCmdWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr vkCmdWaitEventsPointer;
	private static vkCmdWaitEventsDelegate_0 vkCmdWaitEvents_0;
	public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => vkCmdPipelineBarrier_0(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void vkCmdPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr vkCmdPipelineBarrierPointer;
	private static vkCmdPipelineBarrierDelegate_0 vkCmdPipelineBarrier_0;
	public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags) => vkCmdBeginQuery_0(commandBuffer, queryPool, query, flags);
	private delegate void vkCmdBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
	private static IntPtr vkCmdBeginQueryPointer;
	private static vkCmdBeginQueryDelegate_0 vkCmdBeginQuery_0;
	public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query) => vkCmdEndQuery_0(commandBuffer, queryPool, query);
	private delegate void vkCmdEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
	private static IntPtr vkCmdEndQueryPointer;
	private static vkCmdEndQueryDelegate_0 vkCmdEndQuery_0;
	public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount) => vkCmdResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
	private delegate void vkCmdResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static IntPtr vkCmdResetQueryPoolPointer;
	private static vkCmdResetQueryPoolDelegate_0 vkCmdResetQueryPool_0;
	public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query) => vkCmdWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
	private delegate void vkCmdWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query);
	private static IntPtr vkCmdWriteTimestampPointer;
	private static vkCmdWriteTimestampDelegate_0 vkCmdWriteTimestamp_0;
	public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags) => vkCmdCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
	private delegate void vkCmdCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags);
	private static IntPtr vkCmdCopyQueryPoolResultsPointer;
	private static vkCmdCopyQueryPoolResultsDelegate_0 vkCmdCopyQueryPoolResults_0;
	public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues) => vkCmdPushConstants_0(commandBuffer, layout, stageFlags, offset, size, pValues);
	private delegate void vkCmdPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
	private static IntPtr vkCmdPushConstantsPointer;
	private static vkCmdPushConstantsDelegate_0 vkCmdPushConstants_0;
	public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents) => vkCmdBeginRenderPass_0(commandBuffer, pRenderPassBegin, contents);
	private delegate void vkCmdBeginRenderPassDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);
	private static IntPtr vkCmdBeginRenderPassPointer;
	private static vkCmdBeginRenderPassDelegate_0 vkCmdBeginRenderPass_0;
	public static void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents) => vkCmdNextSubpass_0(commandBuffer, contents);
	private delegate void vkCmdNextSubpassDelegate_0(VkCommandBuffer commandBuffer, VkSubpassContents contents);
	private static IntPtr vkCmdNextSubpassPointer;
	private static vkCmdNextSubpassDelegate_0 vkCmdNextSubpass_0;
	public static void vkCmdEndRenderPass(VkCommandBuffer commandBuffer) => vkCmdEndRenderPass_0(commandBuffer);
	private delegate void vkCmdEndRenderPassDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdEndRenderPassPointer;
	private static vkCmdEndRenderPassDelegate_0 vkCmdEndRenderPass_0;
	public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers) => vkCmdExecuteCommands_0(commandBuffer, commandBufferCount, pCommandBuffers);
	private delegate void vkCmdExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
	private static IntPtr vkCmdExecuteCommandsPointer;
	private static vkCmdExecuteCommandsDelegate_0 vkCmdExecuteCommands_0;
	public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator) => vkDestroySurfaceKHR_0(instance, surface, pAllocator);
	private delegate void vkDestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySurfaceKHRPointer;
	private static vkDestroySurfaceKHRDelegate_0 vkDestroySurfaceKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported) => vkGetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, pSupported);
	private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);
	private static IntPtr vkGetPhysicalDeviceSurfaceSupportKHRPointer;
	private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate_0 vkGetPhysicalDeviceSurfaceSupportKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, pSurfaceCapabilities);
	private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
	private static IntPtr vkGetPhysicalDeviceSurfaceCapabilitiesKHRPointer;
	private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 vkGetPhysicalDeviceSurfaceCapabilitiesKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats) => vkGetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
	private static IntPtr vkGetPhysicalDeviceSurfaceFormatsKHRPointer;
	private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate_0 vkGetPhysicalDeviceSurfaceFormatsKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) => vkGetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, pPresentModeCount, pPresentModes);
	private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
	private static IntPtr vkGetPhysicalDeviceSurfacePresentModesKHRPointer;
	private static vkGetPhysicalDeviceSurfacePresentModesKHRDelegate_0 vkGetPhysicalDeviceSurfacePresentModesKHR_0;
	public static VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain) => vkCreateSwapchainKHR_0(device, pCreateInfo, pAllocator, pSwapchain);
	private delegate VkResult vkCreateSwapchainKHRDelegate_0(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain);
	private static IntPtr vkCreateSwapchainKHRPointer;
	private static vkCreateSwapchainKHRDelegate_0 vkCreateSwapchainKHR_0;
	public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator) => vkDestroySwapchainKHR_0(device, swapchain, pAllocator);
	private delegate void vkDestroySwapchainKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySwapchainKHRPointer;
	private static vkDestroySwapchainKHRDelegate_0 vkDestroySwapchainKHR_0;
	public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages) => vkGetSwapchainImagesKHR_0(device, swapchain, pSwapchainImageCount, pSwapchainImages);
	private delegate VkResult vkGetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages);
	private static IntPtr vkGetSwapchainImagesKHRPointer;
	private static vkGetSwapchainImagesKHRDelegate_0 vkGetSwapchainImagesKHR_0;
	public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex) => vkAcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, pImageIndex);
	private delegate VkResult vkAcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
	private static IntPtr vkAcquireNextImageKHRPointer;
	private static vkAcquireNextImageKHRDelegate_0 vkAcquireNextImageKHR_0;
	public static VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo) => vkQueuePresentKHR_0(queue, pPresentInfo);
	private delegate VkResult vkQueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* pPresentInfo);
	private static IntPtr vkQueuePresentKHRPointer;
	private static vkQueuePresentKHRDelegate_0 vkQueuePresentKHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties) => vkGetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayPropertiesKHRPointer;
	private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate_0 vkGetPhysicalDeviceDisplayPropertiesKHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties) => vkGetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayPlanePropertiesKHRPointer;
	private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 vkGetPhysicalDeviceDisplayPlanePropertiesKHR_0;
	public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays) => vkGetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, pDisplayCount, pDisplays);
	private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays);
	private static IntPtr vkGetDisplayPlaneSupportedDisplaysKHRPointer;
	private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate_0 vkGetDisplayPlaneSupportedDisplaysKHR_0;
	public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties) => vkGetDisplayModePropertiesKHR_0(physicalDevice, display, pPropertyCount, pProperties);
	private delegate VkResult vkGetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
	private static IntPtr vkGetDisplayModePropertiesKHRPointer;
	private static vkGetDisplayModePropertiesKHRDelegate_0 vkGetDisplayModePropertiesKHR_0;
	public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode) => vkCreateDisplayModeKHR_0(physicalDevice, display, pCreateInfo, pAllocator, pMode);
	private delegate VkResult vkCreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);
	private static IntPtr vkCreateDisplayModeKHRPointer;
	private static vkCreateDisplayModeKHRDelegate_0 vkCreateDisplayModeKHR_0;
	public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities) => vkGetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, pCapabilities);
	private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);
	private static IntPtr vkGetDisplayPlaneCapabilitiesKHRPointer;
	private static vkGetDisplayPlaneCapabilitiesKHRDelegate_0 vkGetDisplayPlaneCapabilitiesKHR_0;
	public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateDisplayPlaneSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateDisplayPlaneSurfaceKHRPointer;
	private static vkCreateDisplayPlaneSurfaceKHRDelegate_0 vkCreateDisplayPlaneSurfaceKHR_0;
	public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains) => vkCreateSharedSwapchainsKHR_0(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
	private delegate VkResult vkCreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);
	private static IntPtr vkCreateSharedSwapchainsKHRPointer;
	private static vkCreateSharedSwapchainsKHRDelegate_0 vkCreateSharedSwapchainsKHR_0;
	public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateXlibSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateXlibSurfaceKHRPointer;
	private static vkCreateXlibSurfaceKHRDelegate_0 vkCreateXlibSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID) => vkGetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
	private delegate VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID);
	private static IntPtr vkGetPhysicalDeviceXlibPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceXlibPresentationSupportKHR_0;
	public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateXcbSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateXcbSurfaceKHRDelegate_0(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateXcbSurfaceKHRPointer;
	private static vkCreateXcbSurfaceKHRDelegate_0 vkCreateXcbSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id) => vkGetPhysicalDeviceXcbPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection, visual_id);
	private delegate VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id);
	private static IntPtr vkGetPhysicalDeviceXcbPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceXcbPresentationSupportKHR_0;
	public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateWaylandSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateWaylandSurfaceKHRDelegate_0(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateWaylandSurfaceKHRPointer;
	private static vkCreateWaylandSurfaceKHRDelegate_0 vkCreateWaylandSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display) => vkGetPhysicalDeviceWaylandPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, display);
	private delegate VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display);
	private static IntPtr vkGetPhysicalDeviceWaylandPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceWaylandPresentationSupportKHR_0;
	public static VkResult vkCreateMirSurfaceKHR(VkInstance instance, VkMirSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateMirSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateMirSurfaceKHRDelegate_0(VkInstance instance, VkMirSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateMirSurfaceKHRPointer;
	private static vkCreateMirSurfaceKHRDelegate_0 vkCreateMirSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceMirPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, MirConnection* connection) => vkGetPhysicalDeviceMirPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection);
	private delegate VkBool32 vkGetPhysicalDeviceMirPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, MirConnection* connection);
	private static IntPtr vkGetPhysicalDeviceMirPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceMirPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceMirPresentationSupportKHR_0;
	public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateAndroidSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateAndroidSurfaceKHRPointer;
	private static vkCreateAndroidSurfaceKHRDelegate_0 vkCreateAndroidSurfaceKHR_0;
	public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateWin32SurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateWin32SurfaceKHRPointer;
	private static vkCreateWin32SurfaceKHRDelegate_0 vkCreateWin32SurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex) => vkGetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
	private delegate VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
	private static IntPtr vkGetPhysicalDeviceWin32PresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate_0 vkGetPhysicalDeviceWin32PresentationSupportKHR_0;
	public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback) => vkCreateDebugReportCallbackEXT_0(instance, pCreateInfo, pAllocator, pCallback);
	private delegate VkResult vkCreateDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback);
	private static IntPtr vkCreateDebugReportCallbackEXTPointer;
	private static vkCreateDebugReportCallbackEXTDelegate_0 vkCreateDebugReportCallbackEXT_0;
	public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator) => vkDestroyDebugReportCallbackEXT_0(instance, callback, pAllocator);
	private delegate void vkDestroyDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDebugReportCallbackEXTPointer;
	private static vkDestroyDebugReportCallbackEXTDelegate_0 vkDestroyDebugReportCallbackEXT_0;
	public static void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage) => vkDebugReportMessageEXT_0(instance, flags, objectType, object, location, messageCode, pLayerPrefix, pMessage);
	private delegate void vkDebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage);
	private static IntPtr vkDebugReportMessageEXTPointer;
	private static vkDebugReportMessageEXTDelegate_0 vkDebugReportMessageEXT_0;
	public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo) => vkDebugMarkerSetObjectTagEXT_0(device, pTagInfo);
	private delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate_0(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo);
	private static IntPtr vkDebugMarkerSetObjectTagEXTPointer;
	private static vkDebugMarkerSetObjectTagEXTDelegate_0 vkDebugMarkerSetObjectTagEXT_0;
	public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo) => vkDebugMarkerSetObjectNameEXT_0(device, pNameInfo);
	private delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate_0(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo);
	private static IntPtr vkDebugMarkerSetObjectNameEXTPointer;
	private static vkDebugMarkerSetObjectNameEXTDelegate_0 vkDebugMarkerSetObjectNameEXT_0;
	public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo) => vkCmdDebugMarkerBeginEXT_0(commandBuffer, pMarkerInfo);
	private delegate void vkCmdDebugMarkerBeginEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
	private static IntPtr vkCmdDebugMarkerBeginEXTPointer;
	private static vkCmdDebugMarkerBeginEXTDelegate_0 vkCmdDebugMarkerBeginEXT_0;
	public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer) => vkCmdDebugMarkerEndEXT_0(commandBuffer);
	private delegate void vkCmdDebugMarkerEndEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdDebugMarkerEndEXTPointer;
	private static vkCmdDebugMarkerEndEXTDelegate_0 vkCmdDebugMarkerEndEXT_0;
	public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo) => vkCmdDebugMarkerInsertEXT_0(commandBuffer, pMarkerInfo);
	private delegate void vkCmdDebugMarkerInsertEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
	private static IntPtr vkCmdDebugMarkerInsertEXTPointer;
	private static vkCmdDebugMarkerInsertEXTDelegate_0 vkCmdDebugMarkerInsertEXT_0;
	public static void vkCmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => vkCmdDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr vkCmdDrawIndirectCountAMDPointer;
	private static vkCmdDrawIndirectCountAMDDelegate_0 vkCmdDrawIndirectCountAMD_0;
	public static void vkCmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => vkCmdDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr vkCmdDrawIndexedIndirectCountAMDPointer;
	private static vkCmdDrawIndexedIndirectCountAMDDelegate_0 vkCmdDrawIndexedIndirectCountAMD_0;
	public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo) => vkGetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
	private delegate VkResult vkGetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo);
	private static IntPtr vkGetShaderInfoAMDPointer;
	private static vkGetShaderInfoAMDDelegate_0 vkGetShaderInfoAMD_0;
	public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties) => vkGetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
	private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceExternalImageFormatPropertiesNVPointer;
	private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 vkGetPhysicalDeviceExternalImageFormatPropertiesNV_0;
	public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle) => vkGetMemoryWin32HandleNV_0(device, memory, handleType, pHandle);
	private delegate VkResult vkGetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle);
	private static IntPtr vkGetMemoryWin32HandleNVPointer;
	private static vkGetMemoryWin32HandleNVDelegate_0 vkGetMemoryWin32HandleNV_0;
	public static void vkGetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2KHR* pFeatures) => vkGetPhysicalDeviceFeatures2KHR_0(physicalDevice, pFeatures);
	private delegate void vkGetPhysicalDeviceFeatures2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2KHR* pFeatures);
	private static IntPtr vkGetPhysicalDeviceFeatures2KHRPointer;
	private static vkGetPhysicalDeviceFeatures2KHRDelegate_0 vkGetPhysicalDeviceFeatures2KHR_0;
	public static void vkGetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2KHR* pProperties) => vkGetPhysicalDeviceProperties2KHR_0(physicalDevice, pProperties);
	private delegate void vkGetPhysicalDeviceProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2KHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceProperties2KHRPointer;
	private static vkGetPhysicalDeviceProperties2KHRDelegate_0 vkGetPhysicalDeviceProperties2KHR_0;
	public static void vkGetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2KHR* pFormatProperties) => vkGetPhysicalDeviceFormatProperties2KHR_0(physicalDevice, format, pFormatProperties);
	private delegate void vkGetPhysicalDeviceFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2KHR* pFormatProperties);
	private static IntPtr vkGetPhysicalDeviceFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceFormatProperties2KHR_0;
	public static VkResult vkGetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* pImageFormatInfo, VkImageFormatProperties2KHR* pImageFormatProperties) => vkGetPhysicalDeviceImageFormatProperties2KHR_0(physicalDevice, pImageFormatInfo, pImageFormatProperties);
	private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* pImageFormatInfo, VkImageFormatProperties2KHR* pImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceImageFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceImageFormatProperties2KHR_0;
	public static void vkGetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2KHR* pQueueFamilyProperties) => vkGetPhysicalDeviceQueueFamilyProperties2KHR_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2KHR* pQueueFamilyProperties);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer;
	private static vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0 vkGetPhysicalDeviceQueueFamilyProperties2KHR_0;
	public static void vkGetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2KHR* pMemoryProperties) => vkGetPhysicalDeviceMemoryProperties2KHR_0(physicalDevice, pMemoryProperties);
	private delegate void vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2KHR* pMemoryProperties);
	private static IntPtr vkGetPhysicalDeviceMemoryProperties2KHRPointer;
	private static vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0 vkGetPhysicalDeviceMemoryProperties2KHR_0;
	public static void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2KHR* pProperties) => vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
	private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2KHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0;
	public static void vkGetDeviceGroupPeerMemoryFeaturesKHX(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagsKHX* pPeerMemoryFeatures) => vkGetDeviceGroupPeerMemoryFeaturesKHX_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
	private delegate void vkGetDeviceGroupPeerMemoryFeaturesKHXDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagsKHX* pPeerMemoryFeatures);
	private static IntPtr vkGetDeviceGroupPeerMemoryFeaturesKHXPointer;
	private static vkGetDeviceGroupPeerMemoryFeaturesKHXDelegate_0 vkGetDeviceGroupPeerMemoryFeaturesKHX_0;
	public static void vkCmdSetDeviceMaskKHX(VkCommandBuffer commandBuffer, uint deviceMask) => vkCmdSetDeviceMaskKHX_0(commandBuffer, deviceMask);
	private delegate void vkCmdSetDeviceMaskKHXDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static IntPtr vkCmdSetDeviceMaskKHXPointer;
	private static vkCmdSetDeviceMaskKHXDelegate_0 vkCmdSetDeviceMaskKHX_0;
	public static void vkCmdDispatchBaseKHX(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => vkCmdDispatchBaseKHX_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void vkCmdDispatchBaseKHXDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static IntPtr vkCmdDispatchBaseKHXPointer;
	private static vkCmdDispatchBaseKHXDelegate_0 vkCmdDispatchBaseKHX_0;
	public static VkResult vkGetDeviceGroupPresentCapabilitiesKHX(VkDevice device, VkDeviceGroupPresentCapabilitiesKHX* pDeviceGroupPresentCapabilities) => vkGetDeviceGroupPresentCapabilitiesKHX_0(device, pDeviceGroupPresentCapabilities);
	private delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHXDelegate_0(VkDevice device, VkDeviceGroupPresentCapabilitiesKHX* pDeviceGroupPresentCapabilities);
	private static IntPtr vkGetDeviceGroupPresentCapabilitiesKHXPointer;
	private static vkGetDeviceGroupPresentCapabilitiesKHXDelegate_0 vkGetDeviceGroupPresentCapabilitiesKHX_0;
	public static VkResult vkGetDeviceGroupSurfacePresentModesKHX(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHX* pModes) => vkGetDeviceGroupSurfacePresentModesKHX_0(device, surface, pModes);
	private delegate VkResult vkGetDeviceGroupSurfacePresentModesKHXDelegate_0(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHX* pModes);
	private static IntPtr vkGetDeviceGroupSurfacePresentModesKHXPointer;
	private static vkGetDeviceGroupSurfacePresentModesKHXDelegate_0 vkGetDeviceGroupSurfacePresentModesKHX_0;
	public static VkResult vkGetPhysicalDevicePresentRectanglesKHX(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects) => vkGetPhysicalDevicePresentRectanglesKHX_0(physicalDevice, surface, pRectCount, pRects);
	private delegate VkResult vkGetPhysicalDevicePresentRectanglesKHXDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects);
	private static IntPtr vkGetPhysicalDevicePresentRectanglesKHXPointer;
	private static vkGetPhysicalDevicePresentRectanglesKHXDelegate_0 vkGetPhysicalDevicePresentRectanglesKHX_0;
	public static VkResult vkAcquireNextImage2KHX(VkDevice device, VkAcquireNextImageInfoKHX* pAcquireInfo, uint* pImageIndex) => vkAcquireNextImage2KHX_0(device, pAcquireInfo, pImageIndex);
	private delegate VkResult vkAcquireNextImage2KHXDelegate_0(VkDevice device, VkAcquireNextImageInfoKHX* pAcquireInfo, uint* pImageIndex);
	private static IntPtr vkAcquireNextImage2KHXPointer;
	private static vkAcquireNextImage2KHXDelegate_0 vkAcquireNextImage2KHX_0;
	public static VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateViSurfaceNN_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateViSurfaceNNDelegate_0(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateViSurfaceNNPointer;
	private static vkCreateViSurfaceNNDelegate_0 vkCreateViSurfaceNN_0;
	public static void vkTrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags) => vkTrimCommandPoolKHR_0(device, commandPool, flags);
	private delegate void vkTrimCommandPoolKHRDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags);
	private static IntPtr vkTrimCommandPoolKHRPointer;
	private static vkTrimCommandPoolKHRDelegate_0 vkTrimCommandPoolKHR_0;
	public static VkResult vkEnumeratePhysicalDeviceGroupsKHX(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupPropertiesKHX* pPhysicalDeviceGroupProperties) => vkEnumeratePhysicalDeviceGroupsKHX_0(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
	private delegate VkResult vkEnumeratePhysicalDeviceGroupsKHXDelegate_0(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupPropertiesKHX* pPhysicalDeviceGroupProperties);
	private static IntPtr vkEnumeratePhysicalDeviceGroupsKHXPointer;
	private static vkEnumeratePhysicalDeviceGroupsKHXDelegate_0 vkEnumeratePhysicalDeviceGroupsKHX_0;
	public static void vkGetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* pExternalBufferInfo, VkExternalBufferPropertiesKHR* pExternalBufferProperties) => vkGetPhysicalDeviceExternalBufferPropertiesKHR_0(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
	private delegate void vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* pExternalBufferInfo, VkExternalBufferPropertiesKHR* pExternalBufferProperties);
	private static IntPtr vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalBufferPropertiesKHR_0;
	public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => vkGetMemoryWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr vkGetMemoryWin32HandleKHRPointer;
	private static vkGetMemoryWin32HandleKHRDelegate_0 vkGetMemoryWin32HandleKHR_0;
	public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties) => vkGetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, pMemoryWin32HandleProperties);
	private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
	private static IntPtr vkGetMemoryWin32HandlePropertiesKHRPointer;
	private static vkGetMemoryWin32HandlePropertiesKHRDelegate_0 vkGetMemoryWin32HandlePropertiesKHR_0;
	public static VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd) => vkGetMemoryFdKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult vkGetMemoryFdKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr vkGetMemoryFdKHRPointer;
	private static vkGetMemoryFdKHRDelegate_0 vkGetMemoryFdKHR_0;
	public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties) => vkGetMemoryFdPropertiesKHR_0(device, handleType, fd, pMemoryFdProperties);
	private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);
	private static IntPtr vkGetMemoryFdPropertiesKHRPointer;
	private static vkGetMemoryFdPropertiesKHRDelegate_0 vkGetMemoryFdPropertiesKHR_0;
	public static void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* pExternalSemaphoreInfo, VkExternalSemaphorePropertiesKHR* pExternalSemaphoreProperties) => vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_0(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
	private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* pExternalSemaphoreInfo, VkExternalSemaphorePropertiesKHR* pExternalSemaphoreProperties);
	private static IntPtr vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_0;
	public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo) => vkImportSemaphoreWin32HandleKHR_0(device, pImportSemaphoreWin32HandleInfo);
	private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
	private static IntPtr vkImportSemaphoreWin32HandleKHRPointer;
	private static vkImportSemaphoreWin32HandleKHRDelegate_0 vkImportSemaphoreWin32HandleKHR_0;
	public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => vkGetSemaphoreWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr vkGetSemaphoreWin32HandleKHRPointer;
	private static vkGetSemaphoreWin32HandleKHRDelegate_0 vkGetSemaphoreWin32HandleKHR_0;
	public static VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo) => vkImportSemaphoreFdKHR_0(device, pImportSemaphoreFdInfo);
	private delegate VkResult vkImportSemaphoreFdKHRDelegate_0(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);
	private static IntPtr vkImportSemaphoreFdKHRPointer;
	private static vkImportSemaphoreFdKHRDelegate_0 vkImportSemaphoreFdKHR_0;
	public static VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd) => vkGetSemaphoreFdKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult vkGetSemaphoreFdKHRDelegate_0(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr vkGetSemaphoreFdKHRPointer;
	private static vkGetSemaphoreFdKHRDelegate_0 vkGetSemaphoreFdKHR_0;
	public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites) => vkCmdPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
	private delegate void vkCmdPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
	private static IntPtr vkCmdPushDescriptorSetKHRPointer;
	private static vkCmdPushDescriptorSetKHRDelegate_0 vkCmdPushDescriptorSetKHR_0;
	public static VkResult vkCreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplateKHR* pDescriptorUpdateTemplate) => vkCreateDescriptorUpdateTemplateKHR_0(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
	private delegate VkResult vkCreateDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplateKHR* pDescriptorUpdateTemplate);
	private static IntPtr vkCreateDescriptorUpdateTemplateKHRPointer;
	private static vkCreateDescriptorUpdateTemplateKHRDelegate_0 vkCreateDescriptorUpdateTemplateKHR_0;
	public static void vkDestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator) => vkDestroyDescriptorUpdateTemplateKHR_0(device, descriptorUpdateTemplate, pAllocator);
	private delegate void vkDestroyDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDescriptorUpdateTemplateKHRPointer;
	private static vkDestroyDescriptorUpdateTemplateKHRDelegate_0 vkDestroyDescriptorUpdateTemplateKHR_0;
	public static void vkUpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* pData) => vkUpdateDescriptorSetWithTemplateKHR_0(device, descriptorSet, descriptorUpdateTemplate, pData);
	private delegate void vkUpdateDescriptorSetWithTemplateKHRDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* pData);
	private static IntPtr vkUpdateDescriptorSetWithTemplateKHRPointer;
	private static vkUpdateDescriptorSetWithTemplateKHRDelegate_0 vkUpdateDescriptorSetWithTemplateKHR_0;
	public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData) => vkCmdPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
	private delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
	private static IntPtr vkCmdPushDescriptorSetWithTemplateKHRPointer;
	private static vkCmdPushDescriptorSetWithTemplateKHRDelegate_0 vkCmdPushDescriptorSetWithTemplateKHR_0;
	public static void vkCmdProcessCommandsNVX(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo) => vkCmdProcessCommandsNVX_0(commandBuffer, pProcessCommandsInfo);
	private delegate void vkCmdProcessCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo);
	private static IntPtr vkCmdProcessCommandsNVXPointer;
	private static vkCmdProcessCommandsNVXDelegate_0 vkCmdProcessCommandsNVX_0;
	public static void vkCmdReserveSpaceForCommandsNVX(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo) => vkCmdReserveSpaceForCommandsNVX_0(commandBuffer, pReserveSpaceInfo);
	private delegate void vkCmdReserveSpaceForCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo);
	private static IntPtr vkCmdReserveSpaceForCommandsNVXPointer;
	private static vkCmdReserveSpaceForCommandsNVXDelegate_0 vkCmdReserveSpaceForCommandsNVX_0;
	public static VkResult vkCreateIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout) => vkCreateIndirectCommandsLayoutNVX_0(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
	private delegate VkResult vkCreateIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout);
	private static IntPtr vkCreateIndirectCommandsLayoutNVXPointer;
	private static vkCreateIndirectCommandsLayoutNVXDelegate_0 vkCreateIndirectCommandsLayoutNVX_0;
	public static void vkDestroyIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator) => vkDestroyIndirectCommandsLayoutNVX_0(device, indirectCommandsLayout, pAllocator);
	private delegate void vkDestroyIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyIndirectCommandsLayoutNVXPointer;
	private static vkDestroyIndirectCommandsLayoutNVXDelegate_0 vkDestroyIndirectCommandsLayoutNVX_0;
	public static VkResult vkCreateObjectTableNVX(VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable) => vkCreateObjectTableNVX_0(device, pCreateInfo, pAllocator, pObjectTable);
	private delegate VkResult vkCreateObjectTableNVXDelegate_0(VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable);
	private static IntPtr vkCreateObjectTableNVXPointer;
	private static vkCreateObjectTableNVXDelegate_0 vkCreateObjectTableNVX_0;
	public static void vkDestroyObjectTableNVX(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator) => vkDestroyObjectTableNVX_0(device, objectTable, pAllocator);
	private delegate void vkDestroyObjectTableNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyObjectTableNVXPointer;
	private static vkDestroyObjectTableNVXDelegate_0 vkDestroyObjectTableNVX_0;
	public static VkResult vkRegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint* pObjectIndices) => vkRegisterObjectsNVX_0(device, objectTable, objectCount, ppObjectTableEntries, pObjectIndices);
	private delegate VkResult vkRegisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint* pObjectIndices);
	private static IntPtr vkRegisterObjectsNVXPointer;
	private static vkRegisterObjectsNVXDelegate_0 vkRegisterObjectsNVX_0;
	public static VkResult vkUnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices) => vkUnregisterObjectsNVX_0(device, objectTable, objectCount, pObjectEntryTypes, pObjectIndices);
	private delegate VkResult vkUnregisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices);
	private static IntPtr vkUnregisterObjectsNVXPointer;
	private static vkUnregisterObjectsNVXDelegate_0 vkUnregisterObjectsNVX_0;
	public static void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits) => vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_0(physicalDevice, pFeatures, pLimits);
	private delegate void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits);
	private static IntPtr vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer;
	private static vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0 vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_0;
	public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings) => vkCmdSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
	private delegate void vkCmdSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings);
	private static IntPtr vkCmdSetViewportWScalingNVPointer;
	private static vkCmdSetViewportWScalingNVDelegate_0 vkCmdSetViewportWScalingNV_0;
	public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => vkReleaseDisplayEXT_0(physicalDevice, display);
	private delegate VkResult vkReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static IntPtr vkReleaseDisplayEXTPointer;
	private static vkReleaseDisplayEXTDelegate_0 vkReleaseDisplayEXT_0;
	public static VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, void* dpy, VkDisplayKHR display) => vkAcquireXlibDisplayEXT_0(physicalDevice, dpy, display);
	private delegate VkResult vkAcquireXlibDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, void* dpy, VkDisplayKHR display);
	private static IntPtr vkAcquireXlibDisplayEXTPointer;
	private static vkAcquireXlibDisplayEXTDelegate_0 vkAcquireXlibDisplayEXT_0;
	public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, void* dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay) => vkGetRandROutputDisplayEXT_0(physicalDevice, dpy, rrOutput, pDisplay);
	private delegate VkResult vkGetRandROutputDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, void* dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay);
	private static IntPtr vkGetRandROutputDisplayEXTPointer;
	private static vkGetRandROutputDisplayEXTDelegate_0 vkGetRandROutputDisplayEXT_0;
	public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, pSurfaceCapabilities);
	private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities);
	private static IntPtr vkGetPhysicalDeviceSurfaceCapabilities2EXTPointer;
	private static vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0 vkGetPhysicalDeviceSurfaceCapabilities2EXT_0;
	public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo) => vkDisplayPowerControlEXT_0(device, display, pDisplayPowerInfo);
	private delegate VkResult vkDisplayPowerControlEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo);
	private static IntPtr vkDisplayPowerControlEXTPointer;
	private static vkDisplayPowerControlEXTDelegate_0 vkDisplayPowerControlEXT_0;
	public static VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => vkRegisterDeviceEventEXT_0(device, pDeviceEventInfo, pAllocator, pFence);
	private delegate VkResult vkRegisterDeviceEventEXTDelegate_0(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr vkRegisterDeviceEventEXTPointer;
	private static vkRegisterDeviceEventEXTDelegate_0 vkRegisterDeviceEventEXT_0;
	public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => vkRegisterDisplayEventEXT_0(device, display, pDisplayEventInfo, pAllocator, pFence);
	private delegate VkResult vkRegisterDisplayEventEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr vkRegisterDisplayEventEXTPointer;
	private static vkRegisterDisplayEventEXTDelegate_0 vkRegisterDisplayEventEXT_0;
	public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue) => vkGetSwapchainCounterEXT_0(device, swapchain, counter, pCounterValue);
	private delegate VkResult vkGetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue);
	private static IntPtr vkGetSwapchainCounterEXTPointer;
	private static vkGetSwapchainCounterEXTDelegate_0 vkGetSwapchainCounterEXT_0;
	public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties) => vkGetRefreshCycleDurationGOOGLE_0(device, swapchain, pDisplayTimingProperties);
	private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
	private static IntPtr vkGetRefreshCycleDurationGOOGLEPointer;
	private static vkGetRefreshCycleDurationGOOGLEDelegate_0 vkGetRefreshCycleDurationGOOGLE_0;
	public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings) => vkGetPastPresentationTimingGOOGLE_0(device, swapchain, pPresentationTimingCount, pPresentationTimings);
	private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
	private static IntPtr vkGetPastPresentationTimingGOOGLEPointer;
	private static vkGetPastPresentationTimingGOOGLEDelegate_0 vkGetPastPresentationTimingGOOGLE_0;
	public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles) => vkCmdSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
	private delegate void vkCmdSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles);
	private static IntPtr vkCmdSetDiscardRectangleEXTPointer;
	private static vkCmdSetDiscardRectangleEXTDelegate_0 vkCmdSetDiscardRectangleEXT_0;
	public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata) => vkSetHdrMetadataEXT_0(device, swapchainCount, pSwapchains, pMetadata);
	private delegate void vkSetHdrMetadataEXTDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata);
	private static IntPtr vkSetHdrMetadataEXTPointer;
	private static vkSetHdrMetadataEXTDelegate_0 vkSetHdrMetadataEXT_0;
	public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => vkGetSwapchainStatusKHR_0(device, swapchain);
	private delegate VkResult vkGetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr vkGetSwapchainStatusKHRPointer;
	private static vkGetSwapchainStatusKHRDelegate_0 vkGetSwapchainStatusKHR_0;
	public static void vkGetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* pExternalFenceInfo, VkExternalFencePropertiesKHR* pExternalFenceProperties) => vkGetPhysicalDeviceExternalFencePropertiesKHR_0(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
	private delegate void vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* pExternalFenceInfo, VkExternalFencePropertiesKHR* pExternalFenceProperties);
	private static IntPtr vkGetPhysicalDeviceExternalFencePropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalFencePropertiesKHR_0;
	public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo) => vkImportFenceWin32HandleKHR_0(device, pImportFenceWin32HandleInfo);
	private delegate VkResult vkImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
	private static IntPtr vkImportFenceWin32HandleKHRPointer;
	private static vkImportFenceWin32HandleKHRDelegate_0 vkImportFenceWin32HandleKHR_0;
	public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => vkGetFenceWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr vkGetFenceWin32HandleKHRPointer;
	private static vkGetFenceWin32HandleKHRDelegate_0 vkGetFenceWin32HandleKHR_0;
	public static VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo) => vkImportFenceFdKHR_0(device, pImportFenceFdInfo);
	private delegate VkResult vkImportFenceFdKHRDelegate_0(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo);
	private static IntPtr vkImportFenceFdKHRPointer;
	private static vkImportFenceFdKHRDelegate_0 vkImportFenceFdKHR_0;
	public static VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd) => vkGetFenceFdKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult vkGetFenceFdKHRDelegate_0(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr vkGetFenceFdKHRPointer;
	private static vkGetFenceFdKHRDelegate_0 vkGetFenceFdKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
	private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
	private static IntPtr vkGetPhysicalDeviceSurfaceCapabilities2KHRPointer;
	private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 vkGetPhysicalDeviceSurfaceCapabilities2KHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats) => vkGetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
	private static IntPtr vkGetPhysicalDeviceSurfaceFormats2KHRPointer;
	private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate_0 vkGetPhysicalDeviceSurfaceFormats2KHR_0;
	public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateIOSSurfaceMVK_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateIOSSurfaceMVKDelegate_0(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateIOSSurfaceMVKPointer;
	private static vkCreateIOSSurfaceMVKDelegate_0 vkCreateIOSSurfaceMVK_0;
	public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateMacOSSurfaceMVK_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateMacOSSurfaceMVKPointer;
	private static vkCreateMacOSSurfaceMVKDelegate_0 vkCreateMacOSSurfaceMVK_0;
	public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo) => vkCmdSetSampleLocationsEXT_0(commandBuffer, pSampleLocationsInfo);
	private delegate void vkCmdSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo);
	private static IntPtr vkCmdSetSampleLocationsEXTPointer;
	private static vkCmdSetSampleLocationsEXTDelegate_0 vkCmdSetSampleLocationsEXT_0;
	public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties) => vkGetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, pMultisampleProperties);
	private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties);
	private static IntPtr vkGetPhysicalDeviceMultisamplePropertiesEXTPointer;
	private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 vkGetPhysicalDeviceMultisamplePropertiesEXT_0;
	public static void vkGetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2KHR* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements) => vkGetImageMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetImageMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageMemoryRequirementsInfo2KHR* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements);
	private static IntPtr vkGetImageMemoryRequirements2KHRPointer;
	private static vkGetImageMemoryRequirements2KHRDelegate_0 vkGetImageMemoryRequirements2KHR_0;
	public static void vkGetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements) => vkGetBufferMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetBufferMemoryRequirements2KHRDelegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements);
	private static IntPtr vkGetBufferMemoryRequirements2KHRPointer;
	private static vkGetBufferMemoryRequirements2KHRDelegate_0 vkGetBufferMemoryRequirements2KHR_0;
	public static void vkGetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2KHR* pSparseMemoryRequirements) => vkGetImageSparseMemoryRequirements2KHR_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetImageSparseMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2KHR* pSparseMemoryRequirements);
	private static IntPtr vkGetImageSparseMemoryRequirements2KHRPointer;
	private static vkGetImageSparseMemoryRequirements2KHRDelegate_0 vkGetImageSparseMemoryRequirements2KHR_0;
	public static VkResult vkCreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversionKHR* pYcbcrConversion) => vkCreateSamplerYcbcrConversionKHR_0(device, pCreateInfo, pAllocator, pYcbcrConversion);
	private delegate VkResult vkCreateSamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversionKHR* pYcbcrConversion);
	private static IntPtr vkCreateSamplerYcbcrConversionKHRPointer;
	private static vkCreateSamplerYcbcrConversionKHRDelegate_0 vkCreateSamplerYcbcrConversionKHR_0;
	public static void vkDestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* pAllocator) => vkDestroySamplerYcbcrConversionKHR_0(device, ycbcrConversion, pAllocator);
	private delegate void vkDestroySamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySamplerYcbcrConversionKHRPointer;
	private static vkDestroySamplerYcbcrConversionKHRDelegate_0 vkDestroySamplerYcbcrConversionKHR_0;
	public static VkResult vkBindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR* pBindInfos) => vkBindBufferMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult vkBindBufferMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR* pBindInfos);
	private static IntPtr vkBindBufferMemory2KHRPointer;
	private static vkBindBufferMemory2KHRDelegate_0 vkBindBufferMemory2KHR_0;
	public static VkResult vkBindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR* pBindInfos) => vkBindImageMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult vkBindImageMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR* pBindInfos);
	private static IntPtr vkBindImageMemory2KHRPointer;
	private static vkBindImageMemory2KHRDelegate_0 vkBindImageMemory2KHR_0;
	public static VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache) => vkCreateValidationCacheEXT_0(device, pCreateInfo, pAllocator, pValidationCache);
	private delegate VkResult vkCreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);
	private static IntPtr vkCreateValidationCacheEXTPointer;
	private static vkCreateValidationCacheEXTDelegate_0 vkCreateValidationCacheEXT_0;
	public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator) => vkDestroyValidationCacheEXT_0(device, validationCache, pAllocator);
	private delegate void vkDestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyValidationCacheEXTPointer;
	private static vkDestroyValidationCacheEXTDelegate_0 vkDestroyValidationCacheEXT_0;
	public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches) => vkMergeValidationCachesEXT_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult vkMergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches);
	private static IntPtr vkMergeValidationCachesEXTPointer;
	private static vkMergeValidationCachesEXTDelegate_0 vkMergeValidationCachesEXT_0;
	public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData) => vkGetValidationCacheDataEXT_0(device, validationCache, pDataSize, pData);
	private delegate VkResult vkGetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData);
	private static IntPtr vkGetValidationCacheDataEXTPointer;
	private static vkGetValidationCacheDataEXTDelegate_0 vkGetValidationCacheDataEXT_0;
	public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) => vkGetMemoryHostPointerPropertiesEXT_0(device, handleType, pHostPointer, pMemoryHostPointerProperties);
	private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBitsKHR handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
	private static IntPtr vkGetMemoryHostPointerPropertiesEXTPointer;
	private static vkGetMemoryHostPointerPropertiesEXTDelegate_0 vkGetMemoryHostPointerPropertiesEXT_0;
	public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker) => vkCmdWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
	private delegate void vkCmdWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker);
	private static IntPtr vkCmdWriteBufferMarkerAMDPointer;
	private static vkCmdWriteBufferMarkerAMDDelegate_0 vkCmdWriteBufferMarkerAMD_0;
	private static readonly OSVulkanLibraryBase VulkanLibrary;
	static VK()
	{
		VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();
		InitialiseRequiredMethods();
	}
	private static void InitialiseRequiredMethods()
	{
		vkCreateInstancePointer = VulkanLibrary.GetFunctionPointer("vkCreateInstance");
		vkCreateInstance_0 = Marshal.GetDelegateForFunctionPointer<vkCreateInstanceDelegate_0>(vkCreateInstancePointer);
		vkGetInstanceProcAddrPointer = VulkanLibrary.GetFunctionPointer("vkGetInstanceProcAddr");
		vkGetInstanceProcAddr_0 = Marshal.GetDelegateForFunctionPointer<vkGetInstanceProcAddrDelegate_0>(vkGetInstanceProcAddrPointer);
		vkEnumerateInstanceExtensionPropertiesPointer = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceExtensionProperties");
		vkEnumerateInstanceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<vkEnumerateInstanceExtensionPropertiesDelegate_0>(vkEnumerateInstanceExtensionPropertiesPointer);
		vkEnumerateInstanceLayerPropertiesPointer = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceLayerProperties");
		vkEnumerateInstanceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<vkEnumerateInstanceLayerPropertiesDelegate_0>(vkEnumerateInstanceLayerPropertiesPointer);
	}
	public static void InitialiseInstanceMethods(VkInstance instance)
	{
		vkDestroyInstancePointer = vkGetInstanceProcAddr(instance, "vkDestroyInstance");
		if (vkDestroyInstancePointer != IntPtr.Zero)
		{
			vkDestroyInstance_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyInstanceDelegate_0>(vkDestroyInstancePointer);
		}
		vkEnumeratePhysicalDevicesPointer = vkGetInstanceProcAddr(instance, "vkEnumeratePhysicalDevices");
		if (vkEnumeratePhysicalDevicesPointer != IntPtr.Zero)
		{
			vkEnumeratePhysicalDevices_0 = Marshal.GetDelegateForFunctionPointer<vkEnumeratePhysicalDevicesDelegate_0>(vkEnumeratePhysicalDevicesPointer);
		}
		vkGetPhysicalDeviceFeaturesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFeatures");
		if (vkGetPhysicalDeviceFeaturesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFeatures_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFeaturesDelegate_0>(vkGetPhysicalDeviceFeaturesPointer);
		}
		vkGetPhysicalDeviceFormatPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFormatProperties");
		if (vkGetPhysicalDeviceFormatPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFormatPropertiesDelegate_0>(vkGetPhysicalDeviceFormatPropertiesPointer);
		}
		vkGetPhysicalDeviceImageFormatPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceImageFormatProperties");
		if (vkGetPhysicalDeviceImageFormatPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceImageFormatPropertiesDelegate_0>(vkGetPhysicalDeviceImageFormatPropertiesPointer);
		}
		vkGetPhysicalDevicePropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceProperties");
		if (vkGetPhysicalDevicePropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDevicePropertiesDelegate_0>(vkGetPhysicalDevicePropertiesPointer);
		}
		vkGetPhysicalDeviceQueueFamilyPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyProperties");
		if (vkGetPhysicalDeviceQueueFamilyPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceQueueFamilyProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceQueueFamilyPropertiesDelegate_0>(vkGetPhysicalDeviceQueueFamilyPropertiesPointer);
		}
		vkGetPhysicalDeviceMemoryPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMemoryProperties");
		if (vkGetPhysicalDeviceMemoryPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMemoryProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMemoryPropertiesDelegate_0>(vkGetPhysicalDeviceMemoryPropertiesPointer);
		}
		vkGetDeviceProcAddrPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceProcAddr");
		if (vkGetDeviceProcAddrPointer != IntPtr.Zero)
		{
			vkGetDeviceProcAddr_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceProcAddrDelegate_0>(vkGetDeviceProcAddrPointer);
		}
		vkCreateDevicePointer = vkGetInstanceProcAddr(instance, "vkCreateDevice");
		if (vkCreateDevicePointer != IntPtr.Zero)
		{
			vkCreateDevice_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDeviceDelegate_0>(vkCreateDevicePointer);
		}
		vkDestroyDevicePointer = vkGetInstanceProcAddr(instance, "vkDestroyDevice");
		if (vkDestroyDevicePointer != IntPtr.Zero)
		{
			vkDestroyDevice_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDeviceDelegate_0>(vkDestroyDevicePointer);
		}
		vkEnumerateDeviceExtensionPropertiesPointer = vkGetInstanceProcAddr(instance, "vkEnumerateDeviceExtensionProperties");
		if (vkEnumerateDeviceExtensionPropertiesPointer != IntPtr.Zero)
		{
			vkEnumerateDeviceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<vkEnumerateDeviceExtensionPropertiesDelegate_0>(vkEnumerateDeviceExtensionPropertiesPointer);
		}
		vkEnumerateDeviceLayerPropertiesPointer = vkGetInstanceProcAddr(instance, "vkEnumerateDeviceLayerProperties");
		if (vkEnumerateDeviceLayerPropertiesPointer != IntPtr.Zero)
		{
			vkEnumerateDeviceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<vkEnumerateDeviceLayerPropertiesDelegate_0>(vkEnumerateDeviceLayerPropertiesPointer);
		}
		vkGetDeviceQueuePointer = vkGetInstanceProcAddr(instance, "vkGetDeviceQueue");
		if (vkGetDeviceQueuePointer != IntPtr.Zero)
		{
			vkGetDeviceQueue_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceQueueDelegate_0>(vkGetDeviceQueuePointer);
		}
		vkQueueSubmitPointer = vkGetInstanceProcAddr(instance, "vkQueueSubmit");
		if (vkQueueSubmitPointer != IntPtr.Zero)
		{
			vkQueueSubmit_0 = Marshal.GetDelegateForFunctionPointer<vkQueueSubmitDelegate_0>(vkQueueSubmitPointer);
		}
		vkQueueWaitIdlePointer = vkGetInstanceProcAddr(instance, "vkQueueWaitIdle");
		if (vkQueueWaitIdlePointer != IntPtr.Zero)
		{
			vkQueueWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<vkQueueWaitIdleDelegate_0>(vkQueueWaitIdlePointer);
		}
		vkDeviceWaitIdlePointer = vkGetInstanceProcAddr(instance, "vkDeviceWaitIdle");
		if (vkDeviceWaitIdlePointer != IntPtr.Zero)
		{
			vkDeviceWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<vkDeviceWaitIdleDelegate_0>(vkDeviceWaitIdlePointer);
		}
		vkAllocateMemoryPointer = vkGetInstanceProcAddr(instance, "vkAllocateMemory");
		if (vkAllocateMemoryPointer != IntPtr.Zero)
		{
			vkAllocateMemory_0 = Marshal.GetDelegateForFunctionPointer<vkAllocateMemoryDelegate_0>(vkAllocateMemoryPointer);
		}
		vkFreeMemoryPointer = vkGetInstanceProcAddr(instance, "vkFreeMemory");
		if (vkFreeMemoryPointer != IntPtr.Zero)
		{
			vkFreeMemory_0 = Marshal.GetDelegateForFunctionPointer<vkFreeMemoryDelegate_0>(vkFreeMemoryPointer);
		}
		vkMapMemoryPointer = vkGetInstanceProcAddr(instance, "vkMapMemory");
		if (vkMapMemoryPointer != IntPtr.Zero)
		{
			vkMapMemory_0 = Marshal.GetDelegateForFunctionPointer<vkMapMemoryDelegate_0>(vkMapMemoryPointer);
		}
		vkUnmapMemoryPointer = vkGetInstanceProcAddr(instance, "vkUnmapMemory");
		if (vkUnmapMemoryPointer != IntPtr.Zero)
		{
			vkUnmapMemory_0 = Marshal.GetDelegateForFunctionPointer<vkUnmapMemoryDelegate_0>(vkUnmapMemoryPointer);
		}
		vkFlushMappedMemoryRangesPointer = vkGetInstanceProcAddr(instance, "vkFlushMappedMemoryRanges");
		if (vkFlushMappedMemoryRangesPointer != IntPtr.Zero)
		{
			vkFlushMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<vkFlushMappedMemoryRangesDelegate_0>(vkFlushMappedMemoryRangesPointer);
		}
		vkInvalidateMappedMemoryRangesPointer = vkGetInstanceProcAddr(instance, "vkInvalidateMappedMemoryRanges");
		if (vkInvalidateMappedMemoryRangesPointer != IntPtr.Zero)
		{
			vkInvalidateMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<vkInvalidateMappedMemoryRangesDelegate_0>(vkInvalidateMappedMemoryRangesPointer);
		}
		vkGetDeviceMemoryCommitmentPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceMemoryCommitment");
		if (vkGetDeviceMemoryCommitmentPointer != IntPtr.Zero)
		{
			vkGetDeviceMemoryCommitment_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceMemoryCommitmentDelegate_0>(vkGetDeviceMemoryCommitmentPointer);
		}
		vkBindBufferMemoryPointer = vkGetInstanceProcAddr(instance, "vkBindBufferMemory");
		if (vkBindBufferMemoryPointer != IntPtr.Zero)
		{
			vkBindBufferMemory_0 = Marshal.GetDelegateForFunctionPointer<vkBindBufferMemoryDelegate_0>(vkBindBufferMemoryPointer);
		}
		vkBindImageMemoryPointer = vkGetInstanceProcAddr(instance, "vkBindImageMemory");
		if (vkBindImageMemoryPointer != IntPtr.Zero)
		{
			vkBindImageMemory_0 = Marshal.GetDelegateForFunctionPointer<vkBindImageMemoryDelegate_0>(vkBindImageMemoryPointer);
		}
		vkGetBufferMemoryRequirementsPointer = vkGetInstanceProcAddr(instance, "vkGetBufferMemoryRequirements");
		if (vkGetBufferMemoryRequirementsPointer != IntPtr.Zero)
		{
			vkGetBufferMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferMemoryRequirementsDelegate_0>(vkGetBufferMemoryRequirementsPointer);
		}
		vkGetImageMemoryRequirementsPointer = vkGetInstanceProcAddr(instance, "vkGetImageMemoryRequirements");
		if (vkGetImageMemoryRequirementsPointer != IntPtr.Zero)
		{
			vkGetImageMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageMemoryRequirementsDelegate_0>(vkGetImageMemoryRequirementsPointer);
		}
		vkGetImageSparseMemoryRequirementsPointer = vkGetInstanceProcAddr(instance, "vkGetImageSparseMemoryRequirements");
		if (vkGetImageSparseMemoryRequirementsPointer != IntPtr.Zero)
		{
			vkGetImageSparseMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageSparseMemoryRequirementsDelegate_0>(vkGetImageSparseMemoryRequirementsPointer);
		}
		vkGetPhysicalDeviceSparseImageFormatPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSparseImageFormatProperties");
		if (vkGetPhysicalDeviceSparseImageFormatPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate_0>(vkGetPhysicalDeviceSparseImageFormatPropertiesPointer);
		}
		vkQueueBindSparsePointer = vkGetInstanceProcAddr(instance, "vkQueueBindSparse");
		if (vkQueueBindSparsePointer != IntPtr.Zero)
		{
			vkQueueBindSparse_0 = Marshal.GetDelegateForFunctionPointer<vkQueueBindSparseDelegate_0>(vkQueueBindSparsePointer);
		}
		vkCreateFencePointer = vkGetInstanceProcAddr(instance, "vkCreateFence");
		if (vkCreateFencePointer != IntPtr.Zero)
		{
			vkCreateFence_0 = Marshal.GetDelegateForFunctionPointer<vkCreateFenceDelegate_0>(vkCreateFencePointer);
		}
		vkDestroyFencePointer = vkGetInstanceProcAddr(instance, "vkDestroyFence");
		if (vkDestroyFencePointer != IntPtr.Zero)
		{
			vkDestroyFence_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyFenceDelegate_0>(vkDestroyFencePointer);
		}
		vkResetFencesPointer = vkGetInstanceProcAddr(instance, "vkResetFences");
		if (vkResetFencesPointer != IntPtr.Zero)
		{
			vkResetFences_0 = Marshal.GetDelegateForFunctionPointer<vkResetFencesDelegate_0>(vkResetFencesPointer);
		}
		vkGetFenceStatusPointer = vkGetInstanceProcAddr(instance, "vkGetFenceStatus");
		if (vkGetFenceStatusPointer != IntPtr.Zero)
		{
			vkGetFenceStatus_0 = Marshal.GetDelegateForFunctionPointer<vkGetFenceStatusDelegate_0>(vkGetFenceStatusPointer);
		}
		vkWaitForFencesPointer = vkGetInstanceProcAddr(instance, "vkWaitForFences");
		if (vkWaitForFencesPointer != IntPtr.Zero)
		{
			vkWaitForFences_0 = Marshal.GetDelegateForFunctionPointer<vkWaitForFencesDelegate_0>(vkWaitForFencesPointer);
		}
		vkCreateSemaphorePointer = vkGetInstanceProcAddr(instance, "vkCreateSemaphore");
		if (vkCreateSemaphorePointer != IntPtr.Zero)
		{
			vkCreateSemaphore_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSemaphoreDelegate_0>(vkCreateSemaphorePointer);
		}
		vkDestroySemaphorePointer = vkGetInstanceProcAddr(instance, "vkDestroySemaphore");
		if (vkDestroySemaphorePointer != IntPtr.Zero)
		{
			vkDestroySemaphore_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySemaphoreDelegate_0>(vkDestroySemaphorePointer);
		}
		vkCreateEventPointer = vkGetInstanceProcAddr(instance, "vkCreateEvent");
		if (vkCreateEventPointer != IntPtr.Zero)
		{
			vkCreateEvent_0 = Marshal.GetDelegateForFunctionPointer<vkCreateEventDelegate_0>(vkCreateEventPointer);
		}
		vkDestroyEventPointer = vkGetInstanceProcAddr(instance, "vkDestroyEvent");
		if (vkDestroyEventPointer != IntPtr.Zero)
		{
			vkDestroyEvent_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyEventDelegate_0>(vkDestroyEventPointer);
		}
		vkGetEventStatusPointer = vkGetInstanceProcAddr(instance, "vkGetEventStatus");
		if (vkGetEventStatusPointer != IntPtr.Zero)
		{
			vkGetEventStatus_0 = Marshal.GetDelegateForFunctionPointer<vkGetEventStatusDelegate_0>(vkGetEventStatusPointer);
		}
		vkSetEventPointer = vkGetInstanceProcAddr(instance, "vkSetEvent");
		if (vkSetEventPointer != IntPtr.Zero)
		{
			vkSetEvent_0 = Marshal.GetDelegateForFunctionPointer<vkSetEventDelegate_0>(vkSetEventPointer);
		}
		vkResetEventPointer = vkGetInstanceProcAddr(instance, "vkResetEvent");
		if (vkResetEventPointer != IntPtr.Zero)
		{
			vkResetEvent_0 = Marshal.GetDelegateForFunctionPointer<vkResetEventDelegate_0>(vkResetEventPointer);
		}
		vkCreateQueryPoolPointer = vkGetInstanceProcAddr(instance, "vkCreateQueryPool");
		if (vkCreateQueryPoolPointer != IntPtr.Zero)
		{
			vkCreateQueryPool_0 = Marshal.GetDelegateForFunctionPointer<vkCreateQueryPoolDelegate_0>(vkCreateQueryPoolPointer);
		}
		vkDestroyQueryPoolPointer = vkGetInstanceProcAddr(instance, "vkDestroyQueryPool");
		if (vkDestroyQueryPoolPointer != IntPtr.Zero)
		{
			vkDestroyQueryPool_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyQueryPoolDelegate_0>(vkDestroyQueryPoolPointer);
		}
		vkGetQueryPoolResultsPointer = vkGetInstanceProcAddr(instance, "vkGetQueryPoolResults");
		if (vkGetQueryPoolResultsPointer != IntPtr.Zero)
		{
			vkGetQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<vkGetQueryPoolResultsDelegate_0>(vkGetQueryPoolResultsPointer);
		}
		vkCreateBufferPointer = vkGetInstanceProcAddr(instance, "vkCreateBuffer");
		if (vkCreateBufferPointer != IntPtr.Zero)
		{
			vkCreateBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCreateBufferDelegate_0>(vkCreateBufferPointer);
		}
		vkDestroyBufferPointer = vkGetInstanceProcAddr(instance, "vkDestroyBuffer");
		if (vkDestroyBufferPointer != IntPtr.Zero)
		{
			vkDestroyBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyBufferDelegate_0>(vkDestroyBufferPointer);
		}
		vkCreateBufferViewPointer = vkGetInstanceProcAddr(instance, "vkCreateBufferView");
		if (vkCreateBufferViewPointer != IntPtr.Zero)
		{
			vkCreateBufferView_0 = Marshal.GetDelegateForFunctionPointer<vkCreateBufferViewDelegate_0>(vkCreateBufferViewPointer);
		}
		vkDestroyBufferViewPointer = vkGetInstanceProcAddr(instance, "vkDestroyBufferView");
		if (vkDestroyBufferViewPointer != IntPtr.Zero)
		{
			vkDestroyBufferView_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyBufferViewDelegate_0>(vkDestroyBufferViewPointer);
		}
		vkCreateImagePointer = vkGetInstanceProcAddr(instance, "vkCreateImage");
		if (vkCreateImagePointer != IntPtr.Zero)
		{
			vkCreateImage_0 = Marshal.GetDelegateForFunctionPointer<vkCreateImageDelegate_0>(vkCreateImagePointer);
		}
		vkDestroyImagePointer = vkGetInstanceProcAddr(instance, "vkDestroyImage");
		if (vkDestroyImagePointer != IntPtr.Zero)
		{
			vkDestroyImage_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyImageDelegate_0>(vkDestroyImagePointer);
		}
		vkGetImageSubresourceLayoutPointer = vkGetInstanceProcAddr(instance, "vkGetImageSubresourceLayout");
		if (vkGetImageSubresourceLayoutPointer != IntPtr.Zero)
		{
			vkGetImageSubresourceLayout_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageSubresourceLayoutDelegate_0>(vkGetImageSubresourceLayoutPointer);
		}
		vkCreateImageViewPointer = vkGetInstanceProcAddr(instance, "vkCreateImageView");
		if (vkCreateImageViewPointer != IntPtr.Zero)
		{
			vkCreateImageView_0 = Marshal.GetDelegateForFunctionPointer<vkCreateImageViewDelegate_0>(vkCreateImageViewPointer);
		}
		vkDestroyImageViewPointer = vkGetInstanceProcAddr(instance, "vkDestroyImageView");
		if (vkDestroyImageViewPointer != IntPtr.Zero)
		{
			vkDestroyImageView_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyImageViewDelegate_0>(vkDestroyImageViewPointer);
		}
		vkCreateShaderModulePointer = vkGetInstanceProcAddr(instance, "vkCreateShaderModule");
		if (vkCreateShaderModulePointer != IntPtr.Zero)
		{
			vkCreateShaderModule_0 = Marshal.GetDelegateForFunctionPointer<vkCreateShaderModuleDelegate_0>(vkCreateShaderModulePointer);
		}
		vkDestroyShaderModulePointer = vkGetInstanceProcAddr(instance, "vkDestroyShaderModule");
		if (vkDestroyShaderModulePointer != IntPtr.Zero)
		{
			vkDestroyShaderModule_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyShaderModuleDelegate_0>(vkDestroyShaderModulePointer);
		}
		vkCreatePipelineCachePointer = vkGetInstanceProcAddr(instance, "vkCreatePipelineCache");
		if (vkCreatePipelineCachePointer != IntPtr.Zero)
		{
			vkCreatePipelineCache_0 = Marshal.GetDelegateForFunctionPointer<vkCreatePipelineCacheDelegate_0>(vkCreatePipelineCachePointer);
		}
		vkDestroyPipelineCachePointer = vkGetInstanceProcAddr(instance, "vkDestroyPipelineCache");
		if (vkDestroyPipelineCachePointer != IntPtr.Zero)
		{
			vkDestroyPipelineCache_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyPipelineCacheDelegate_0>(vkDestroyPipelineCachePointer);
		}
		vkGetPipelineCacheDataPointer = vkGetInstanceProcAddr(instance, "vkGetPipelineCacheData");
		if (vkGetPipelineCacheDataPointer != IntPtr.Zero)
		{
			vkGetPipelineCacheData_0 = Marshal.GetDelegateForFunctionPointer<vkGetPipelineCacheDataDelegate_0>(vkGetPipelineCacheDataPointer);
		}
		vkMergePipelineCachesPointer = vkGetInstanceProcAddr(instance, "vkMergePipelineCaches");
		if (vkMergePipelineCachesPointer != IntPtr.Zero)
		{
			vkMergePipelineCaches_0 = Marshal.GetDelegateForFunctionPointer<vkMergePipelineCachesDelegate_0>(vkMergePipelineCachesPointer);
		}
		vkCreateGraphicsPipelinesPointer = vkGetInstanceProcAddr(instance, "vkCreateGraphicsPipelines");
		if (vkCreateGraphicsPipelinesPointer != IntPtr.Zero)
		{
			vkCreateGraphicsPipelines_0 = Marshal.GetDelegateForFunctionPointer<vkCreateGraphicsPipelinesDelegate_0>(vkCreateGraphicsPipelinesPointer);
		}
		vkCreateComputePipelinesPointer = vkGetInstanceProcAddr(instance, "vkCreateComputePipelines");
		if (vkCreateComputePipelinesPointer != IntPtr.Zero)
		{
			vkCreateComputePipelines_0 = Marshal.GetDelegateForFunctionPointer<vkCreateComputePipelinesDelegate_0>(vkCreateComputePipelinesPointer);
		}
		vkDestroyPipelinePointer = vkGetInstanceProcAddr(instance, "vkDestroyPipeline");
		if (vkDestroyPipelinePointer != IntPtr.Zero)
		{
			vkDestroyPipeline_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyPipelineDelegate_0>(vkDestroyPipelinePointer);
		}
		vkCreatePipelineLayoutPointer = vkGetInstanceProcAddr(instance, "vkCreatePipelineLayout");
		if (vkCreatePipelineLayoutPointer != IntPtr.Zero)
		{
			vkCreatePipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<vkCreatePipelineLayoutDelegate_0>(vkCreatePipelineLayoutPointer);
		}
		vkDestroyPipelineLayoutPointer = vkGetInstanceProcAddr(instance, "vkDestroyPipelineLayout");
		if (vkDestroyPipelineLayoutPointer != IntPtr.Zero)
		{
			vkDestroyPipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyPipelineLayoutDelegate_0>(vkDestroyPipelineLayoutPointer);
		}
		vkCreateSamplerPointer = vkGetInstanceProcAddr(instance, "vkCreateSampler");
		if (vkCreateSamplerPointer != IntPtr.Zero)
		{
			vkCreateSampler_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSamplerDelegate_0>(vkCreateSamplerPointer);
		}
		vkDestroySamplerPointer = vkGetInstanceProcAddr(instance, "vkDestroySampler");
		if (vkDestroySamplerPointer != IntPtr.Zero)
		{
			vkDestroySampler_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySamplerDelegate_0>(vkDestroySamplerPointer);
		}
		vkCreateDescriptorSetLayoutPointer = vkGetInstanceProcAddr(instance, "vkCreateDescriptorSetLayout");
		if (vkCreateDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			vkCreateDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDescriptorSetLayoutDelegate_0>(vkCreateDescriptorSetLayoutPointer);
		}
		vkDestroyDescriptorSetLayoutPointer = vkGetInstanceProcAddr(instance, "vkDestroyDescriptorSetLayout");
		if (vkDestroyDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			vkDestroyDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDescriptorSetLayoutDelegate_0>(vkDestroyDescriptorSetLayoutPointer);
		}
		vkCreateDescriptorPoolPointer = vkGetInstanceProcAddr(instance, "vkCreateDescriptorPool");
		if (vkCreateDescriptorPoolPointer != IntPtr.Zero)
		{
			vkCreateDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDescriptorPoolDelegate_0>(vkCreateDescriptorPoolPointer);
		}
		vkDestroyDescriptorPoolPointer = vkGetInstanceProcAddr(instance, "vkDestroyDescriptorPool");
		if (vkDestroyDescriptorPoolPointer != IntPtr.Zero)
		{
			vkDestroyDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDescriptorPoolDelegate_0>(vkDestroyDescriptorPoolPointer);
		}
		vkResetDescriptorPoolPointer = vkGetInstanceProcAddr(instance, "vkResetDescriptorPool");
		if (vkResetDescriptorPoolPointer != IntPtr.Zero)
		{
			vkResetDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<vkResetDescriptorPoolDelegate_0>(vkResetDescriptorPoolPointer);
		}
		vkAllocateDescriptorSetsPointer = vkGetInstanceProcAddr(instance, "vkAllocateDescriptorSets");
		if (vkAllocateDescriptorSetsPointer != IntPtr.Zero)
		{
			vkAllocateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<vkAllocateDescriptorSetsDelegate_0>(vkAllocateDescriptorSetsPointer);
		}
		vkFreeDescriptorSetsPointer = vkGetInstanceProcAddr(instance, "vkFreeDescriptorSets");
		if (vkFreeDescriptorSetsPointer != IntPtr.Zero)
		{
			vkFreeDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<vkFreeDescriptorSetsDelegate_0>(vkFreeDescriptorSetsPointer);
		}
		vkUpdateDescriptorSetsPointer = vkGetInstanceProcAddr(instance, "vkUpdateDescriptorSets");
		if (vkUpdateDescriptorSetsPointer != IntPtr.Zero)
		{
			vkUpdateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<vkUpdateDescriptorSetsDelegate_0>(vkUpdateDescriptorSetsPointer);
		}
		vkCreateFramebufferPointer = vkGetInstanceProcAddr(instance, "vkCreateFramebuffer");
		if (vkCreateFramebufferPointer != IntPtr.Zero)
		{
			vkCreateFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCreateFramebufferDelegate_0>(vkCreateFramebufferPointer);
		}
		vkDestroyFramebufferPointer = vkGetInstanceProcAddr(instance, "vkDestroyFramebuffer");
		if (vkDestroyFramebufferPointer != IntPtr.Zero)
		{
			vkDestroyFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyFramebufferDelegate_0>(vkDestroyFramebufferPointer);
		}
		vkCreateRenderPassPointer = vkGetInstanceProcAddr(instance, "vkCreateRenderPass");
		if (vkCreateRenderPassPointer != IntPtr.Zero)
		{
			vkCreateRenderPass_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRenderPassDelegate_0>(vkCreateRenderPassPointer);
		}
		vkDestroyRenderPassPointer = vkGetInstanceProcAddr(instance, "vkDestroyRenderPass");
		if (vkDestroyRenderPassPointer != IntPtr.Zero)
		{
			vkDestroyRenderPass_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyRenderPassDelegate_0>(vkDestroyRenderPassPointer);
		}
		vkGetRenderAreaGranularityPointer = vkGetInstanceProcAddr(instance, "vkGetRenderAreaGranularity");
		if (vkGetRenderAreaGranularityPointer != IntPtr.Zero)
		{
			vkGetRenderAreaGranularity_0 = Marshal.GetDelegateForFunctionPointer<vkGetRenderAreaGranularityDelegate_0>(vkGetRenderAreaGranularityPointer);
		}
		vkCreateCommandPoolPointer = vkGetInstanceProcAddr(instance, "vkCreateCommandPool");
		if (vkCreateCommandPoolPointer != IntPtr.Zero)
		{
			vkCreateCommandPool_0 = Marshal.GetDelegateForFunctionPointer<vkCreateCommandPoolDelegate_0>(vkCreateCommandPoolPointer);
		}
		vkDestroyCommandPoolPointer = vkGetInstanceProcAddr(instance, "vkDestroyCommandPool");
		if (vkDestroyCommandPoolPointer != IntPtr.Zero)
		{
			vkDestroyCommandPool_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyCommandPoolDelegate_0>(vkDestroyCommandPoolPointer);
		}
		vkResetCommandPoolPointer = vkGetInstanceProcAddr(instance, "vkResetCommandPool");
		if (vkResetCommandPoolPointer != IntPtr.Zero)
		{
			vkResetCommandPool_0 = Marshal.GetDelegateForFunctionPointer<vkResetCommandPoolDelegate_0>(vkResetCommandPoolPointer);
		}
		vkAllocateCommandBuffersPointer = vkGetInstanceProcAddr(instance, "vkAllocateCommandBuffers");
		if (vkAllocateCommandBuffersPointer != IntPtr.Zero)
		{
			vkAllocateCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<vkAllocateCommandBuffersDelegate_0>(vkAllocateCommandBuffersPointer);
		}
		vkFreeCommandBuffersPointer = vkGetInstanceProcAddr(instance, "vkFreeCommandBuffers");
		if (vkFreeCommandBuffersPointer != IntPtr.Zero)
		{
			vkFreeCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<vkFreeCommandBuffersDelegate_0>(vkFreeCommandBuffersPointer);
		}
		vkBeginCommandBufferPointer = vkGetInstanceProcAddr(instance, "vkBeginCommandBuffer");
		if (vkBeginCommandBufferPointer != IntPtr.Zero)
		{
			vkBeginCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkBeginCommandBufferDelegate_0>(vkBeginCommandBufferPointer);
		}
		vkEndCommandBufferPointer = vkGetInstanceProcAddr(instance, "vkEndCommandBuffer");
		if (vkEndCommandBufferPointer != IntPtr.Zero)
		{
			vkEndCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkEndCommandBufferDelegate_0>(vkEndCommandBufferPointer);
		}
		vkResetCommandBufferPointer = vkGetInstanceProcAddr(instance, "vkResetCommandBuffer");
		if (vkResetCommandBufferPointer != IntPtr.Zero)
		{
			vkResetCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkResetCommandBufferDelegate_0>(vkResetCommandBufferPointer);
		}
		vkCmdBindPipelinePointer = vkGetInstanceProcAddr(instance, "vkCmdBindPipeline");
		if (vkCmdBindPipelinePointer != IntPtr.Zero)
		{
			vkCmdBindPipeline_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindPipelineDelegate_0>(vkCmdBindPipelinePointer);
		}
		vkCmdSetViewportPointer = vkGetInstanceProcAddr(instance, "vkCmdSetViewport");
		if (vkCmdSetViewportPointer != IntPtr.Zero)
		{
			vkCmdSetViewport_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetViewportDelegate_0>(vkCmdSetViewportPointer);
		}
		vkCmdSetScissorPointer = vkGetInstanceProcAddr(instance, "vkCmdSetScissor");
		if (vkCmdSetScissorPointer != IntPtr.Zero)
		{
			vkCmdSetScissor_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetScissorDelegate_0>(vkCmdSetScissorPointer);
		}
		vkCmdSetLineWidthPointer = vkGetInstanceProcAddr(instance, "vkCmdSetLineWidth");
		if (vkCmdSetLineWidthPointer != IntPtr.Zero)
		{
			vkCmdSetLineWidth_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetLineWidthDelegate_0>(vkCmdSetLineWidthPointer);
		}
		vkCmdSetDepthBiasPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthBias");
		if (vkCmdSetDepthBiasPointer != IntPtr.Zero)
		{
			vkCmdSetDepthBias_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthBiasDelegate_0>(vkCmdSetDepthBiasPointer);
		}
		vkCmdSetBlendConstantsPointer = vkGetInstanceProcAddr(instance, "vkCmdSetBlendConstants");
		if (vkCmdSetBlendConstantsPointer != IntPtr.Zero)
		{
			vkCmdSetBlendConstants_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetBlendConstantsDelegate_0>(vkCmdSetBlendConstantsPointer);
		}
		vkCmdSetDepthBoundsPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthBounds");
		if (vkCmdSetDepthBoundsPointer != IntPtr.Zero)
		{
			vkCmdSetDepthBounds_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthBoundsDelegate_0>(vkCmdSetDepthBoundsPointer);
		}
		vkCmdSetStencilCompareMaskPointer = vkGetInstanceProcAddr(instance, "vkCmdSetStencilCompareMask");
		if (vkCmdSetStencilCompareMaskPointer != IntPtr.Zero)
		{
			vkCmdSetStencilCompareMask_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetStencilCompareMaskDelegate_0>(vkCmdSetStencilCompareMaskPointer);
		}
		vkCmdSetStencilWriteMaskPointer = vkGetInstanceProcAddr(instance, "vkCmdSetStencilWriteMask");
		if (vkCmdSetStencilWriteMaskPointer != IntPtr.Zero)
		{
			vkCmdSetStencilWriteMask_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetStencilWriteMaskDelegate_0>(vkCmdSetStencilWriteMaskPointer);
		}
		vkCmdSetStencilReferencePointer = vkGetInstanceProcAddr(instance, "vkCmdSetStencilReference");
		if (vkCmdSetStencilReferencePointer != IntPtr.Zero)
		{
			vkCmdSetStencilReference_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetStencilReferenceDelegate_0>(vkCmdSetStencilReferencePointer);
		}
		vkCmdBindDescriptorSetsPointer = vkGetInstanceProcAddr(instance, "vkCmdBindDescriptorSets");
		if (vkCmdBindDescriptorSetsPointer != IntPtr.Zero)
		{
			vkCmdBindDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindDescriptorSetsDelegate_0>(vkCmdBindDescriptorSetsPointer);
		}
		vkCmdBindIndexBufferPointer = vkGetInstanceProcAddr(instance, "vkCmdBindIndexBuffer");
		if (vkCmdBindIndexBufferPointer != IntPtr.Zero)
		{
			vkCmdBindIndexBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindIndexBufferDelegate_0>(vkCmdBindIndexBufferPointer);
		}
		vkCmdBindVertexBuffersPointer = vkGetInstanceProcAddr(instance, "vkCmdBindVertexBuffers");
		if (vkCmdBindVertexBuffersPointer != IntPtr.Zero)
		{
			vkCmdBindVertexBuffers_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindVertexBuffersDelegate_0>(vkCmdBindVertexBuffersPointer);
		}
		vkCmdDrawPointer = vkGetInstanceProcAddr(instance, "vkCmdDraw");
		if (vkCmdDrawPointer != IntPtr.Zero)
		{
			vkCmdDraw_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawDelegate_0>(vkCmdDrawPointer);
		}
		vkCmdDrawIndexedPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexed");
		if (vkCmdDrawIndexedPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexed_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedDelegate_0>(vkCmdDrawIndexedPointer);
		}
		vkCmdDrawIndirectPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirect");
		if (vkCmdDrawIndirectPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirect_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectDelegate_0>(vkCmdDrawIndirectPointer);
		}
		vkCmdDrawIndexedIndirectPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirect");
		if (vkCmdDrawIndexedIndirectPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexedIndirect_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedIndirectDelegate_0>(vkCmdDrawIndexedIndirectPointer);
		}
		vkCmdDispatchPointer = vkGetInstanceProcAddr(instance, "vkCmdDispatch");
		if (vkCmdDispatchPointer != IntPtr.Zero)
		{
			vkCmdDispatch_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDispatchDelegate_0>(vkCmdDispatchPointer);
		}
		vkCmdDispatchIndirectPointer = vkGetInstanceProcAddr(instance, "vkCmdDispatchIndirect");
		if (vkCmdDispatchIndirectPointer != IntPtr.Zero)
		{
			vkCmdDispatchIndirect_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDispatchIndirectDelegate_0>(vkCmdDispatchIndirectPointer);
		}
		vkCmdCopyBufferPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyBuffer");
		if (vkCmdCopyBufferPointer != IntPtr.Zero)
		{
			vkCmdCopyBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyBufferDelegate_0>(vkCmdCopyBufferPointer);
		}
		vkCmdCopyImagePointer = vkGetInstanceProcAddr(instance, "vkCmdCopyImage");
		if (vkCmdCopyImagePointer != IntPtr.Zero)
		{
			vkCmdCopyImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyImageDelegate_0>(vkCmdCopyImagePointer);
		}
		vkCmdBlitImagePointer = vkGetInstanceProcAddr(instance, "vkCmdBlitImage");
		if (vkCmdBlitImagePointer != IntPtr.Zero)
		{
			vkCmdBlitImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBlitImageDelegate_0>(vkCmdBlitImagePointer);
		}
		vkCmdCopyBufferToImagePointer = vkGetInstanceProcAddr(instance, "vkCmdCopyBufferToImage");
		if (vkCmdCopyBufferToImagePointer != IntPtr.Zero)
		{
			vkCmdCopyBufferToImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyBufferToImageDelegate_0>(vkCmdCopyBufferToImagePointer);
		}
		vkCmdCopyImageToBufferPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyImageToBuffer");
		if (vkCmdCopyImageToBufferPointer != IntPtr.Zero)
		{
			vkCmdCopyImageToBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyImageToBufferDelegate_0>(vkCmdCopyImageToBufferPointer);
		}
		vkCmdUpdateBufferPointer = vkGetInstanceProcAddr(instance, "vkCmdUpdateBuffer");
		if (vkCmdUpdateBufferPointer != IntPtr.Zero)
		{
			vkCmdUpdateBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCmdUpdateBufferDelegate_0>(vkCmdUpdateBufferPointer);
		}
		vkCmdFillBufferPointer = vkGetInstanceProcAddr(instance, "vkCmdFillBuffer");
		if (vkCmdFillBufferPointer != IntPtr.Zero)
		{
			vkCmdFillBuffer_0 = Marshal.GetDelegateForFunctionPointer<vkCmdFillBufferDelegate_0>(vkCmdFillBufferPointer);
		}
		vkCmdClearColorImagePointer = vkGetInstanceProcAddr(instance, "vkCmdClearColorImage");
		if (vkCmdClearColorImagePointer != IntPtr.Zero)
		{
			vkCmdClearColorImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdClearColorImageDelegate_0>(vkCmdClearColorImagePointer);
		}
		vkCmdClearDepthStencilImagePointer = vkGetInstanceProcAddr(instance, "vkCmdClearDepthStencilImage");
		if (vkCmdClearDepthStencilImagePointer != IntPtr.Zero)
		{
			vkCmdClearDepthStencilImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdClearDepthStencilImageDelegate_0>(vkCmdClearDepthStencilImagePointer);
		}
		vkCmdClearAttachmentsPointer = vkGetInstanceProcAddr(instance, "vkCmdClearAttachments");
		if (vkCmdClearAttachmentsPointer != IntPtr.Zero)
		{
			vkCmdClearAttachments_0 = Marshal.GetDelegateForFunctionPointer<vkCmdClearAttachmentsDelegate_0>(vkCmdClearAttachmentsPointer);
		}
		vkCmdResolveImagePointer = vkGetInstanceProcAddr(instance, "vkCmdResolveImage");
		if (vkCmdResolveImagePointer != IntPtr.Zero)
		{
			vkCmdResolveImage_0 = Marshal.GetDelegateForFunctionPointer<vkCmdResolveImageDelegate_0>(vkCmdResolveImagePointer);
		}
		vkCmdSetEventPointer = vkGetInstanceProcAddr(instance, "vkCmdSetEvent");
		if (vkCmdSetEventPointer != IntPtr.Zero)
		{
			vkCmdSetEvent_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetEventDelegate_0>(vkCmdSetEventPointer);
		}
		vkCmdResetEventPointer = vkGetInstanceProcAddr(instance, "vkCmdResetEvent");
		if (vkCmdResetEventPointer != IntPtr.Zero)
		{
			vkCmdResetEvent_0 = Marshal.GetDelegateForFunctionPointer<vkCmdResetEventDelegate_0>(vkCmdResetEventPointer);
		}
		vkCmdWaitEventsPointer = vkGetInstanceProcAddr(instance, "vkCmdWaitEvents");
		if (vkCmdWaitEventsPointer != IntPtr.Zero)
		{
			vkCmdWaitEvents_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWaitEventsDelegate_0>(vkCmdWaitEventsPointer);
		}
		vkCmdPipelineBarrierPointer = vkGetInstanceProcAddr(instance, "vkCmdPipelineBarrier");
		if (vkCmdPipelineBarrierPointer != IntPtr.Zero)
		{
			vkCmdPipelineBarrier_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPipelineBarrierDelegate_0>(vkCmdPipelineBarrierPointer);
		}
		vkCmdBeginQueryPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginQuery");
		if (vkCmdBeginQueryPointer != IntPtr.Zero)
		{
			vkCmdBeginQuery_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginQueryDelegate_0>(vkCmdBeginQueryPointer);
		}
		vkCmdEndQueryPointer = vkGetInstanceProcAddr(instance, "vkCmdEndQuery");
		if (vkCmdEndQueryPointer != IntPtr.Zero)
		{
			vkCmdEndQuery_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndQueryDelegate_0>(vkCmdEndQueryPointer);
		}
		vkCmdResetQueryPoolPointer = vkGetInstanceProcAddr(instance, "vkCmdResetQueryPool");
		if (vkCmdResetQueryPoolPointer != IntPtr.Zero)
		{
			vkCmdResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<vkCmdResetQueryPoolDelegate_0>(vkCmdResetQueryPoolPointer);
		}
		vkCmdWriteTimestampPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteTimestamp");
		if (vkCmdWriteTimestampPointer != IntPtr.Zero)
		{
			vkCmdWriteTimestamp_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteTimestampDelegate_0>(vkCmdWriteTimestampPointer);
		}
		vkCmdCopyQueryPoolResultsPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyQueryPoolResults");
		if (vkCmdCopyQueryPoolResultsPointer != IntPtr.Zero)
		{
			vkCmdCopyQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyQueryPoolResultsDelegate_0>(vkCmdCopyQueryPoolResultsPointer);
		}
		vkCmdPushConstantsPointer = vkGetInstanceProcAddr(instance, "vkCmdPushConstants");
		if (vkCmdPushConstantsPointer != IntPtr.Zero)
		{
			vkCmdPushConstants_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPushConstantsDelegate_0>(vkCmdPushConstantsPointer);
		}
		vkCmdBeginRenderPassPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginRenderPass");
		if (vkCmdBeginRenderPassPointer != IntPtr.Zero)
		{
			vkCmdBeginRenderPass_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginRenderPassDelegate_0>(vkCmdBeginRenderPassPointer);
		}
		vkCmdNextSubpassPointer = vkGetInstanceProcAddr(instance, "vkCmdNextSubpass");
		if (vkCmdNextSubpassPointer != IntPtr.Zero)
		{
			vkCmdNextSubpass_0 = Marshal.GetDelegateForFunctionPointer<vkCmdNextSubpassDelegate_0>(vkCmdNextSubpassPointer);
		}
		vkCmdEndRenderPassPointer = vkGetInstanceProcAddr(instance, "vkCmdEndRenderPass");
		if (vkCmdEndRenderPassPointer != IntPtr.Zero)
		{
			vkCmdEndRenderPass_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndRenderPassDelegate_0>(vkCmdEndRenderPassPointer);
		}
		vkCmdExecuteCommandsPointer = vkGetInstanceProcAddr(instance, "vkCmdExecuteCommands");
		if (vkCmdExecuteCommandsPointer != IntPtr.Zero)
		{
			vkCmdExecuteCommands_0 = Marshal.GetDelegateForFunctionPointer<vkCmdExecuteCommandsDelegate_0>(vkCmdExecuteCommandsPointer);
		}
		vkDestroySurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroySurfaceKHR");
		if (vkDestroySurfaceKHRPointer != IntPtr.Zero)
		{
			vkDestroySurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySurfaceKHRDelegate_0>(vkDestroySurfaceKHRPointer);
		}
		vkGetPhysicalDeviceSurfaceSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
		if (vkGetPhysicalDeviceSurfaceSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceSupportKHRDelegate_0>(vkGetPhysicalDeviceSurfaceSupportKHRPointer);
		}
		vkGetPhysicalDeviceSurfaceCapabilitiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
		if (vkGetPhysicalDeviceSurfaceCapabilitiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0>(vkGetPhysicalDeviceSurfaceCapabilitiesKHRPointer);
		}
		vkGetPhysicalDeviceSurfaceFormatsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
		if (vkGetPhysicalDeviceSurfaceFormatsKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceFormatsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceFormatsKHRDelegate_0>(vkGetPhysicalDeviceSurfaceFormatsKHRPointer);
		}
		vkGetPhysicalDeviceSurfacePresentModesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
		if (vkGetPhysicalDeviceSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfacePresentModesKHRDelegate_0>(vkGetPhysicalDeviceSurfacePresentModesKHRPointer);
		}
		vkCreateSwapchainKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateSwapchainKHR");
		if (vkCreateSwapchainKHRPointer != IntPtr.Zero)
		{
			vkCreateSwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSwapchainKHRDelegate_0>(vkCreateSwapchainKHRPointer);
		}
		vkDestroySwapchainKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroySwapchainKHR");
		if (vkDestroySwapchainKHRPointer != IntPtr.Zero)
		{
			vkDestroySwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySwapchainKHRDelegate_0>(vkDestroySwapchainKHRPointer);
		}
		vkGetSwapchainImagesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSwapchainImagesKHR");
		if (vkGetSwapchainImagesKHRPointer != IntPtr.Zero)
		{
			vkGetSwapchainImagesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSwapchainImagesKHRDelegate_0>(vkGetSwapchainImagesKHRPointer);
		}
		vkAcquireNextImageKHRPointer = vkGetInstanceProcAddr(instance, "vkAcquireNextImageKHR");
		if (vkAcquireNextImageKHRPointer != IntPtr.Zero)
		{
			vkAcquireNextImageKHR_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireNextImageKHRDelegate_0>(vkAcquireNextImageKHRPointer);
		}
		vkQueuePresentKHRPointer = vkGetInstanceProcAddr(instance, "vkQueuePresentKHR");
		if (vkQueuePresentKHRPointer != IntPtr.Zero)
		{
			vkQueuePresentKHR_0 = Marshal.GetDelegateForFunctionPointer<vkQueuePresentKHRDelegate_0>(vkQueuePresentKHRPointer);
		}
		vkGetPhysicalDeviceDisplayPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
		if (vkGetPhysicalDeviceDisplayPropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceDisplayPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceDisplayPropertiesKHRDelegate_0>(vkGetPhysicalDeviceDisplayPropertiesKHRPointer);
		}
		vkGetPhysicalDeviceDisplayPlanePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
		if (vkGetPhysicalDeviceDisplayPlanePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceDisplayPlanePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0>(vkGetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
		}
		vkGetDisplayPlaneSupportedDisplaysKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
		if (vkGetDisplayPlaneSupportedDisplaysKHRPointer != IntPtr.Zero)
		{
			vkGetDisplayPlaneSupportedDisplaysKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDisplayPlaneSupportedDisplaysKHRDelegate_0>(vkGetDisplayPlaneSupportedDisplaysKHRPointer);
		}
		vkGetDisplayModePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDisplayModePropertiesKHR");
		if (vkGetDisplayModePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetDisplayModePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDisplayModePropertiesKHRDelegate_0>(vkGetDisplayModePropertiesKHRPointer);
		}
		vkCreateDisplayModeKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateDisplayModeKHR");
		if (vkCreateDisplayModeKHRPointer != IntPtr.Zero)
		{
			vkCreateDisplayModeKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDisplayModeKHRDelegate_0>(vkCreateDisplayModeKHRPointer);
		}
		vkGetDisplayPlaneCapabilitiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilitiesKHR");
		if (vkGetDisplayPlaneCapabilitiesKHRPointer != IntPtr.Zero)
		{
			vkGetDisplayPlaneCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDisplayPlaneCapabilitiesKHRDelegate_0>(vkGetDisplayPlaneCapabilitiesKHRPointer);
		}
		vkCreateDisplayPlaneSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateDisplayPlaneSurfaceKHR");
		if (vkCreateDisplayPlaneSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateDisplayPlaneSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDisplayPlaneSurfaceKHRDelegate_0>(vkCreateDisplayPlaneSurfaceKHRPointer);
		}
		vkCreateSharedSwapchainsKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateSharedSwapchainsKHR");
		if (vkCreateSharedSwapchainsKHRPointer != IntPtr.Zero)
		{
			vkCreateSharedSwapchainsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSharedSwapchainsKHRDelegate_0>(vkCreateSharedSwapchainsKHRPointer);
		}
		vkCreateXlibSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateXlibSurfaceKHR");
		if (vkCreateXlibSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateXlibSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateXlibSurfaceKHRDelegate_0>(vkCreateXlibSurfaceKHRPointer);
		}
		vkGetPhysicalDeviceXlibPresentationSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR");
		if (vkGetPhysicalDeviceXlibPresentationSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceXlibPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate_0>(vkGetPhysicalDeviceXlibPresentationSupportKHRPointer);
		}
		vkCreateXcbSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateXcbSurfaceKHR");
		if (vkCreateXcbSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateXcbSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateXcbSurfaceKHRDelegate_0>(vkCreateXcbSurfaceKHRPointer);
		}
		vkGetPhysicalDeviceXcbPresentationSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR");
		if (vkGetPhysicalDeviceXcbPresentationSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceXcbPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate_0>(vkGetPhysicalDeviceXcbPresentationSupportKHRPointer);
		}
		vkCreateWaylandSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateWaylandSurfaceKHR");
		if (vkCreateWaylandSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateWaylandSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateWaylandSurfaceKHRDelegate_0>(vkCreateWaylandSurfaceKHRPointer);
		}
		vkGetPhysicalDeviceWaylandPresentationSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR");
		if (vkGetPhysicalDeviceWaylandPresentationSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceWaylandPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0>(vkGetPhysicalDeviceWaylandPresentationSupportKHRPointer);
		}
		vkCreateMirSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateMirSurfaceKHR");
		if (vkCreateMirSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateMirSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateMirSurfaceKHRDelegate_0>(vkCreateMirSurfaceKHRPointer);
		}
		vkGetPhysicalDeviceMirPresentationSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMirPresentationSupportKHR");
		if (vkGetPhysicalDeviceMirPresentationSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMirPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMirPresentationSupportKHRDelegate_0>(vkGetPhysicalDeviceMirPresentationSupportKHRPointer);
		}
		vkCreateAndroidSurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateAndroidSurfaceKHR");
		if (vkCreateAndroidSurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateAndroidSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateAndroidSurfaceKHRDelegate_0>(vkCreateAndroidSurfaceKHRPointer);
		}
		vkCreateWin32SurfaceKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateWin32SurfaceKHR");
		if (vkCreateWin32SurfaceKHRPointer != IntPtr.Zero)
		{
			vkCreateWin32SurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateWin32SurfaceKHRDelegate_0>(vkCreateWin32SurfaceKHRPointer);
		}
		vkGetPhysicalDeviceWin32PresentationSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
		if (vkGetPhysicalDeviceWin32PresentationSupportKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceWin32PresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate_0>(vkGetPhysicalDeviceWin32PresentationSupportKHRPointer);
		}
		vkCreateDebugReportCallbackEXTPointer = vkGetInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT");
		if (vkCreateDebugReportCallbackEXTPointer != IntPtr.Zero)
		{
			vkCreateDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDebugReportCallbackEXTDelegate_0>(vkCreateDebugReportCallbackEXTPointer);
		}
		vkDestroyDebugReportCallbackEXTPointer = vkGetInstanceProcAddr(instance, "vkDestroyDebugReportCallbackEXT");
		if (vkDestroyDebugReportCallbackEXTPointer != IntPtr.Zero)
		{
			vkDestroyDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDebugReportCallbackEXTDelegate_0>(vkDestroyDebugReportCallbackEXTPointer);
		}
		vkDebugReportMessageEXTPointer = vkGetInstanceProcAddr(instance, "vkDebugReportMessageEXT");
		if (vkDebugReportMessageEXTPointer != IntPtr.Zero)
		{
			vkDebugReportMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDebugReportMessageEXTDelegate_0>(vkDebugReportMessageEXTPointer);
		}
		vkDebugMarkerSetObjectTagEXTPointer = vkGetInstanceProcAddr(instance, "vkDebugMarkerSetObjectTagEXT");
		if (vkDebugMarkerSetObjectTagEXTPointer != IntPtr.Zero)
		{
			vkDebugMarkerSetObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDebugMarkerSetObjectTagEXTDelegate_0>(vkDebugMarkerSetObjectTagEXTPointer);
		}
		vkDebugMarkerSetObjectNameEXTPointer = vkGetInstanceProcAddr(instance, "vkDebugMarkerSetObjectNameEXT");
		if (vkDebugMarkerSetObjectNameEXTPointer != IntPtr.Zero)
		{
			vkDebugMarkerSetObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDebugMarkerSetObjectNameEXTDelegate_0>(vkDebugMarkerSetObjectNameEXTPointer);
		}
		vkCmdDebugMarkerBeginEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDebugMarkerBeginEXT");
		if (vkCmdDebugMarkerBeginEXTPointer != IntPtr.Zero)
		{
			vkCmdDebugMarkerBeginEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDebugMarkerBeginEXTDelegate_0>(vkCmdDebugMarkerBeginEXTPointer);
		}
		vkCmdDebugMarkerEndEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDebugMarkerEndEXT");
		if (vkCmdDebugMarkerEndEXTPointer != IntPtr.Zero)
		{
			vkCmdDebugMarkerEndEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDebugMarkerEndEXTDelegate_0>(vkCmdDebugMarkerEndEXTPointer);
		}
		vkCmdDebugMarkerInsertEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDebugMarkerInsertEXT");
		if (vkCmdDebugMarkerInsertEXTPointer != IntPtr.Zero)
		{
			vkCmdDebugMarkerInsertEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDebugMarkerInsertEXTDelegate_0>(vkCmdDebugMarkerInsertEXTPointer);
		}
		vkCmdDrawIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCountAMD");
		if (vkCmdDrawIndirectCountAMDPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountAMDDelegate_0>(vkCmdDrawIndirectCountAMDPointer);
		}
		vkCmdDrawIndexedIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCountAMD");
		if (vkCmdDrawIndexedIndirectCountAMDPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexedIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedIndirectCountAMDDelegate_0>(vkCmdDrawIndexedIndirectCountAMDPointer);
		}
		vkGetShaderInfoAMDPointer = vkGetInstanceProcAddr(instance, "vkGetShaderInfoAMD");
		if (vkGetShaderInfoAMDPointer != IntPtr.Zero)
		{
			vkGetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<vkGetShaderInfoAMDDelegate_0>(vkGetShaderInfoAMDPointer);
		}
		vkGetPhysicalDeviceExternalImageFormatPropertiesNVPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
		if (vkGetPhysicalDeviceExternalImageFormatPropertiesNVPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalImageFormatPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0>(vkGetPhysicalDeviceExternalImageFormatPropertiesNVPointer);
		}
		vkGetMemoryWin32HandleNVPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryWin32HandleNV");
		if (vkGetMemoryWin32HandleNVPointer != IntPtr.Zero)
		{
			vkGetMemoryWin32HandleNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryWin32HandleNVDelegate_0>(vkGetMemoryWin32HandleNVPointer);
		}
		vkGetPhysicalDeviceFeatures2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFeatures2KHR");
		if (vkGetPhysicalDeviceFeatures2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFeatures2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFeatures2KHRDelegate_0>(vkGetPhysicalDeviceFeatures2KHRPointer);
		}
		vkGetPhysicalDeviceProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceProperties2KHR");
		if (vkGetPhysicalDeviceProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceProperties2KHRDelegate_0>(vkGetPhysicalDeviceProperties2KHRPointer);
		}
		vkGetPhysicalDeviceFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFormatProperties2KHR");
		if (vkGetPhysicalDeviceFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceFormatProperties2KHRPointer);
		}
		vkGetPhysicalDeviceImageFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceImageFormatProperties2KHR");
		if (vkGetPhysicalDeviceImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceImageFormatProperties2KHRPointer);
		}
		vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyProperties2KHR");
		if (vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceQueueFamilyProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0>(vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer);
		}
		vkGetPhysicalDeviceMemoryProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMemoryProperties2KHR");
		if (vkGetPhysicalDeviceMemoryProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMemoryProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0>(vkGetPhysicalDeviceMemoryProperties2KHRPointer);
		}
		vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2KHR");
		if (vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
		}
		vkGetDeviceGroupPeerMemoryFeaturesKHXPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPeerMemoryFeaturesKHX");
		if (vkGetDeviceGroupPeerMemoryFeaturesKHXPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPeerMemoryFeaturesKHX_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPeerMemoryFeaturesKHXDelegate_0>(vkGetDeviceGroupPeerMemoryFeaturesKHXPointer);
		}
		vkCmdSetDeviceMaskKHXPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDeviceMaskKHX");
		if (vkCmdSetDeviceMaskKHXPointer != IntPtr.Zero)
		{
			vkCmdSetDeviceMaskKHX_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDeviceMaskKHXDelegate_0>(vkCmdSetDeviceMaskKHXPointer);
		}
		vkCmdDispatchBaseKHXPointer = vkGetInstanceProcAddr(instance, "vkCmdDispatchBaseKHX");
		if (vkCmdDispatchBaseKHXPointer != IntPtr.Zero)
		{
			vkCmdDispatchBaseKHX_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDispatchBaseKHXDelegate_0>(vkCmdDispatchBaseKHXPointer);
		}
		vkGetDeviceGroupPresentCapabilitiesKHXPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPresentCapabilitiesKHX");
		if (vkGetDeviceGroupPresentCapabilitiesKHXPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPresentCapabilitiesKHX_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPresentCapabilitiesKHXDelegate_0>(vkGetDeviceGroupPresentCapabilitiesKHXPointer);
		}
		vkGetDeviceGroupSurfacePresentModesKHXPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupSurfacePresentModesKHX");
		if (vkGetDeviceGroupSurfacePresentModesKHXPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupSurfacePresentModesKHX_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupSurfacePresentModesKHXDelegate_0>(vkGetDeviceGroupSurfacePresentModesKHXPointer);
		}
		vkGetPhysicalDevicePresentRectanglesKHXPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDevicePresentRectanglesKHX");
		if (vkGetPhysicalDevicePresentRectanglesKHXPointer != IntPtr.Zero)
		{
			vkGetPhysicalDevicePresentRectanglesKHX_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDevicePresentRectanglesKHXDelegate_0>(vkGetPhysicalDevicePresentRectanglesKHXPointer);
		}
		vkAcquireNextImage2KHXPointer = vkGetInstanceProcAddr(instance, "vkAcquireNextImage2KHX");
		if (vkAcquireNextImage2KHXPointer != IntPtr.Zero)
		{
			vkAcquireNextImage2KHX_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireNextImage2KHXDelegate_0>(vkAcquireNextImage2KHXPointer);
		}
		vkCreateViSurfaceNNPointer = vkGetInstanceProcAddr(instance, "vkCreateViSurfaceNN");
		if (vkCreateViSurfaceNNPointer != IntPtr.Zero)
		{
			vkCreateViSurfaceNN_0 = Marshal.GetDelegateForFunctionPointer<vkCreateViSurfaceNNDelegate_0>(vkCreateViSurfaceNNPointer);
		}
		vkTrimCommandPoolKHRPointer = vkGetInstanceProcAddr(instance, "vkTrimCommandPoolKHR");
		if (vkTrimCommandPoolKHRPointer != IntPtr.Zero)
		{
			vkTrimCommandPoolKHR_0 = Marshal.GetDelegateForFunctionPointer<vkTrimCommandPoolKHRDelegate_0>(vkTrimCommandPoolKHRPointer);
		}
		vkEnumeratePhysicalDeviceGroupsKHXPointer = vkGetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceGroupsKHX");
		if (vkEnumeratePhysicalDeviceGroupsKHXPointer != IntPtr.Zero)
		{
			vkEnumeratePhysicalDeviceGroupsKHX_0 = Marshal.GetDelegateForFunctionPointer<vkEnumeratePhysicalDeviceGroupsKHXDelegate_0>(vkEnumeratePhysicalDeviceGroupsKHXPointer);
		}
		vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalBufferPropertiesKHR");
		if (vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalBufferPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0>(vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer);
		}
		vkGetMemoryWin32HandleKHRPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryWin32HandleKHR");
		if (vkGetMemoryWin32HandleKHRPointer != IntPtr.Zero)
		{
			vkGetMemoryWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryWin32HandleKHRDelegate_0>(vkGetMemoryWin32HandleKHRPointer);
		}
		vkGetMemoryWin32HandlePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryWin32HandlePropertiesKHR");
		if (vkGetMemoryWin32HandlePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetMemoryWin32HandlePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryWin32HandlePropertiesKHRDelegate_0>(vkGetMemoryWin32HandlePropertiesKHRPointer);
		}
		vkGetMemoryFdKHRPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryFdKHR");
		if (vkGetMemoryFdKHRPointer != IntPtr.Zero)
		{
			vkGetMemoryFdKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryFdKHRDelegate_0>(vkGetMemoryFdKHRPointer);
		}
		vkGetMemoryFdPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryFdPropertiesKHR");
		if (vkGetMemoryFdPropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetMemoryFdPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryFdPropertiesKHRDelegate_0>(vkGetMemoryFdPropertiesKHRPointer);
		}
		vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR");
		if (vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0>(vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer);
		}
		vkImportSemaphoreWin32HandleKHRPointer = vkGetInstanceProcAddr(instance, "vkImportSemaphoreWin32HandleKHR");
		if (vkImportSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			vkImportSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<vkImportSemaphoreWin32HandleKHRDelegate_0>(vkImportSemaphoreWin32HandleKHRPointer);
		}
		vkGetSemaphoreWin32HandleKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSemaphoreWin32HandleKHR");
		if (vkGetSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			vkGetSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSemaphoreWin32HandleKHRDelegate_0>(vkGetSemaphoreWin32HandleKHRPointer);
		}
		vkImportSemaphoreFdKHRPointer = vkGetInstanceProcAddr(instance, "vkImportSemaphoreFdKHR");
		if (vkImportSemaphoreFdKHRPointer != IntPtr.Zero)
		{
			vkImportSemaphoreFdKHR_0 = Marshal.GetDelegateForFunctionPointer<vkImportSemaphoreFdKHRDelegate_0>(vkImportSemaphoreFdKHRPointer);
		}
		vkGetSemaphoreFdKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSemaphoreFdKHR");
		if (vkGetSemaphoreFdKHRPointer != IntPtr.Zero)
		{
			vkGetSemaphoreFdKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSemaphoreFdKHRDelegate_0>(vkGetSemaphoreFdKHRPointer);
		}
		vkCmdPushDescriptorSetKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdPushDescriptorSetKHR");
		if (vkCmdPushDescriptorSetKHRPointer != IntPtr.Zero)
		{
			vkCmdPushDescriptorSetKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPushDescriptorSetKHRDelegate_0>(vkCmdPushDescriptorSetKHRPointer);
		}
		vkCreateDescriptorUpdateTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateDescriptorUpdateTemplateKHR");
		if (vkCreateDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			vkCreateDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDescriptorUpdateTemplateKHRDelegate_0>(vkCreateDescriptorUpdateTemplateKHRPointer);
		}
		vkDestroyDescriptorUpdateTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroyDescriptorUpdateTemplateKHR");
		if (vkDestroyDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			vkDestroyDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDescriptorUpdateTemplateKHRDelegate_0>(vkDestroyDescriptorUpdateTemplateKHRPointer);
		}
		vkUpdateDescriptorSetWithTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkUpdateDescriptorSetWithTemplateKHR");
		if (vkUpdateDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			vkUpdateDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkUpdateDescriptorSetWithTemplateKHRDelegate_0>(vkUpdateDescriptorSetWithTemplateKHRPointer);
		}
		vkCmdPushDescriptorSetWithTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdPushDescriptorSetWithTemplateKHR");
		if (vkCmdPushDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			vkCmdPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPushDescriptorSetWithTemplateKHRDelegate_0>(vkCmdPushDescriptorSetWithTemplateKHRPointer);
		}
		vkCmdProcessCommandsNVXPointer = vkGetInstanceProcAddr(instance, "vkCmdProcessCommandsNVX");
		if (vkCmdProcessCommandsNVXPointer != IntPtr.Zero)
		{
			vkCmdProcessCommandsNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCmdProcessCommandsNVXDelegate_0>(vkCmdProcessCommandsNVXPointer);
		}
		vkCmdReserveSpaceForCommandsNVXPointer = vkGetInstanceProcAddr(instance, "vkCmdReserveSpaceForCommandsNVX");
		if (vkCmdReserveSpaceForCommandsNVXPointer != IntPtr.Zero)
		{
			vkCmdReserveSpaceForCommandsNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCmdReserveSpaceForCommandsNVXDelegate_0>(vkCmdReserveSpaceForCommandsNVXPointer);
		}
		vkCreateIndirectCommandsLayoutNVXPointer = vkGetInstanceProcAddr(instance, "vkCreateIndirectCommandsLayoutNVX");
		if (vkCreateIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			vkCreateIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCreateIndirectCommandsLayoutNVXDelegate_0>(vkCreateIndirectCommandsLayoutNVXPointer);
		}
		vkDestroyIndirectCommandsLayoutNVXPointer = vkGetInstanceProcAddr(instance, "vkDestroyIndirectCommandsLayoutNVX");
		if (vkDestroyIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			vkDestroyIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyIndirectCommandsLayoutNVXDelegate_0>(vkDestroyIndirectCommandsLayoutNVXPointer);
		}
		vkCreateObjectTableNVXPointer = vkGetInstanceProcAddr(instance, "vkCreateObjectTableNVX");
		if (vkCreateObjectTableNVXPointer != IntPtr.Zero)
		{
			vkCreateObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCreateObjectTableNVXDelegate_0>(vkCreateObjectTableNVXPointer);
		}
		vkDestroyObjectTableNVXPointer = vkGetInstanceProcAddr(instance, "vkDestroyObjectTableNVX");
		if (vkDestroyObjectTableNVXPointer != IntPtr.Zero)
		{
			vkDestroyObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyObjectTableNVXDelegate_0>(vkDestroyObjectTableNVXPointer);
		}
		vkRegisterObjectsNVXPointer = vkGetInstanceProcAddr(instance, "vkRegisterObjectsNVX");
		if (vkRegisterObjectsNVXPointer != IntPtr.Zero)
		{
			vkRegisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<vkRegisterObjectsNVXDelegate_0>(vkRegisterObjectsNVXPointer);
		}
		vkUnregisterObjectsNVXPointer = vkGetInstanceProcAddr(instance, "vkUnregisterObjectsNVX");
		if (vkUnregisterObjectsNVXPointer != IntPtr.Zero)
		{
			vkUnregisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<vkUnregisterObjectsNVXDelegate_0>(vkUnregisterObjectsNVXPointer);
		}
		vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX");
		if (vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0>(vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer);
		}
		vkCmdSetViewportWScalingNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetViewportWScalingNV");
		if (vkCmdSetViewportWScalingNVPointer != IntPtr.Zero)
		{
			vkCmdSetViewportWScalingNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetViewportWScalingNVDelegate_0>(vkCmdSetViewportWScalingNVPointer);
		}
		vkReleaseDisplayEXTPointer = vkGetInstanceProcAddr(instance, "vkReleaseDisplayEXT");
		if (vkReleaseDisplayEXTPointer != IntPtr.Zero)
		{
			vkReleaseDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<vkReleaseDisplayEXTDelegate_0>(vkReleaseDisplayEXTPointer);
		}
		vkAcquireXlibDisplayEXTPointer = vkGetInstanceProcAddr(instance, "vkAcquireXlibDisplayEXT");
		if (vkAcquireXlibDisplayEXTPointer != IntPtr.Zero)
		{
			vkAcquireXlibDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireXlibDisplayEXTDelegate_0>(vkAcquireXlibDisplayEXTPointer);
		}
		vkGetRandROutputDisplayEXTPointer = vkGetInstanceProcAddr(instance, "vkGetRandROutputDisplayEXT");
		if (vkGetRandROutputDisplayEXTPointer != IntPtr.Zero)
		{
			vkGetRandROutputDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetRandROutputDisplayEXTDelegate_0>(vkGetRandROutputDisplayEXTPointer);
		}
		vkGetPhysicalDeviceSurfaceCapabilities2EXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
		if (vkGetPhysicalDeviceSurfaceCapabilities2EXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceCapabilities2EXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0>(vkGetPhysicalDeviceSurfaceCapabilities2EXTPointer);
		}
		vkDisplayPowerControlEXTPointer = vkGetInstanceProcAddr(instance, "vkDisplayPowerControlEXT");
		if (vkDisplayPowerControlEXTPointer != IntPtr.Zero)
		{
			vkDisplayPowerControlEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDisplayPowerControlEXTDelegate_0>(vkDisplayPowerControlEXTPointer);
		}
		vkRegisterDeviceEventEXTPointer = vkGetInstanceProcAddr(instance, "vkRegisterDeviceEventEXT");
		if (vkRegisterDeviceEventEXTPointer != IntPtr.Zero)
		{
			vkRegisterDeviceEventEXT_0 = Marshal.GetDelegateForFunctionPointer<vkRegisterDeviceEventEXTDelegate_0>(vkRegisterDeviceEventEXTPointer);
		}
		vkRegisterDisplayEventEXTPointer = vkGetInstanceProcAddr(instance, "vkRegisterDisplayEventEXT");
		if (vkRegisterDisplayEventEXTPointer != IntPtr.Zero)
		{
			vkRegisterDisplayEventEXT_0 = Marshal.GetDelegateForFunctionPointer<vkRegisterDisplayEventEXTDelegate_0>(vkRegisterDisplayEventEXTPointer);
		}
		vkGetSwapchainCounterEXTPointer = vkGetInstanceProcAddr(instance, "vkGetSwapchainCounterEXT");
		if (vkGetSwapchainCounterEXTPointer != IntPtr.Zero)
		{
			vkGetSwapchainCounterEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetSwapchainCounterEXTDelegate_0>(vkGetSwapchainCounterEXTPointer);
		}
		vkGetRefreshCycleDurationGOOGLEPointer = vkGetInstanceProcAddr(instance, "vkGetRefreshCycleDurationGOOGLE");
		if (vkGetRefreshCycleDurationGOOGLEPointer != IntPtr.Zero)
		{
			vkGetRefreshCycleDurationGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<vkGetRefreshCycleDurationGOOGLEDelegate_0>(vkGetRefreshCycleDurationGOOGLEPointer);
		}
		vkGetPastPresentationTimingGOOGLEPointer = vkGetInstanceProcAddr(instance, "vkGetPastPresentationTimingGOOGLE");
		if (vkGetPastPresentationTimingGOOGLEPointer != IntPtr.Zero)
		{
			vkGetPastPresentationTimingGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<vkGetPastPresentationTimingGOOGLEDelegate_0>(vkGetPastPresentationTimingGOOGLEPointer);
		}
		vkCmdSetDiscardRectangleEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDiscardRectangleEXT");
		if (vkCmdSetDiscardRectangleEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDiscardRectangleEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDiscardRectangleEXTDelegate_0>(vkCmdSetDiscardRectangleEXTPointer);
		}
		vkSetHdrMetadataEXTPointer = vkGetInstanceProcAddr(instance, "vkSetHdrMetadataEXT");
		if (vkSetHdrMetadataEXTPointer != IntPtr.Zero)
		{
			vkSetHdrMetadataEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSetHdrMetadataEXTDelegate_0>(vkSetHdrMetadataEXTPointer);
		}
		vkGetSwapchainStatusKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSwapchainStatusKHR");
		if (vkGetSwapchainStatusKHRPointer != IntPtr.Zero)
		{
			vkGetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSwapchainStatusKHRDelegate_0>(vkGetSwapchainStatusKHRPointer);
		}
		vkGetPhysicalDeviceExternalFencePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalFencePropertiesKHR");
		if (vkGetPhysicalDeviceExternalFencePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalFencePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate_0>(vkGetPhysicalDeviceExternalFencePropertiesKHRPointer);
		}
		vkImportFenceWin32HandleKHRPointer = vkGetInstanceProcAddr(instance, "vkImportFenceWin32HandleKHR");
		if (vkImportFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			vkImportFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<vkImportFenceWin32HandleKHRDelegate_0>(vkImportFenceWin32HandleKHRPointer);
		}
		vkGetFenceWin32HandleKHRPointer = vkGetInstanceProcAddr(instance, "vkGetFenceWin32HandleKHR");
		if (vkGetFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			vkGetFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetFenceWin32HandleKHRDelegate_0>(vkGetFenceWin32HandleKHRPointer);
		}
		vkImportFenceFdKHRPointer = vkGetInstanceProcAddr(instance, "vkImportFenceFdKHR");
		if (vkImportFenceFdKHRPointer != IntPtr.Zero)
		{
			vkImportFenceFdKHR_0 = Marshal.GetDelegateForFunctionPointer<vkImportFenceFdKHRDelegate_0>(vkImportFenceFdKHRPointer);
		}
		vkGetFenceFdKHRPointer = vkGetInstanceProcAddr(instance, "vkGetFenceFdKHR");
		if (vkGetFenceFdKHRPointer != IntPtr.Zero)
		{
			vkGetFenceFdKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetFenceFdKHRDelegate_0>(vkGetFenceFdKHRPointer);
		}
		vkGetPhysicalDeviceSurfaceCapabilities2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
		if (vkGetPhysicalDeviceSurfaceCapabilities2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0>(vkGetPhysicalDeviceSurfaceCapabilities2KHRPointer);
		}
		vkGetPhysicalDeviceSurfaceFormats2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR");
		if (vkGetPhysicalDeviceSurfaceFormats2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfaceFormats2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfaceFormats2KHRDelegate_0>(vkGetPhysicalDeviceSurfaceFormats2KHRPointer);
		}
		vkCreateIOSSurfaceMVKPointer = vkGetInstanceProcAddr(instance, "vkCreateIOSSurfaceMVK");
		if (vkCreateIOSSurfaceMVKPointer != IntPtr.Zero)
		{
			vkCreateIOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<vkCreateIOSSurfaceMVKDelegate_0>(vkCreateIOSSurfaceMVKPointer);
		}
		vkCreateMacOSSurfaceMVKPointer = vkGetInstanceProcAddr(instance, "vkCreateMacOSSurfaceMVK");
		if (vkCreateMacOSSurfaceMVKPointer != IntPtr.Zero)
		{
			vkCreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<vkCreateMacOSSurfaceMVKDelegate_0>(vkCreateMacOSSurfaceMVKPointer);
		}
		vkCmdSetSampleLocationsEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetSampleLocationsEXT");
		if (vkCmdSetSampleLocationsEXTPointer != IntPtr.Zero)
		{
			vkCmdSetSampleLocationsEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetSampleLocationsEXTDelegate_0>(vkCmdSetSampleLocationsEXTPointer);
		}
		vkGetPhysicalDeviceMultisamplePropertiesEXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
		if (vkGetPhysicalDeviceMultisamplePropertiesEXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMultisamplePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate_0>(vkGetPhysicalDeviceMultisamplePropertiesEXTPointer);
		}
		vkGetImageMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetImageMemoryRequirements2KHR");
		if (vkGetImageMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetImageMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageMemoryRequirements2KHRDelegate_0>(vkGetImageMemoryRequirements2KHRPointer);
		}
		vkGetBufferMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferMemoryRequirements2KHR");
		if (vkGetBufferMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetBufferMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferMemoryRequirements2KHRDelegate_0>(vkGetBufferMemoryRequirements2KHRPointer);
		}
		vkGetImageSparseMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetImageSparseMemoryRequirements2KHR");
		if (vkGetImageSparseMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetImageSparseMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageSparseMemoryRequirements2KHRDelegate_0>(vkGetImageSparseMemoryRequirements2KHRPointer);
		}
		vkCreateSamplerYcbcrConversionKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateSamplerYcbcrConversionKHR");
		if (vkCreateSamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			vkCreateSamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSamplerYcbcrConversionKHRDelegate_0>(vkCreateSamplerYcbcrConversionKHRPointer);
		}
		vkDestroySamplerYcbcrConversionKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroySamplerYcbcrConversionKHR");
		if (vkDestroySamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			vkDestroySamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySamplerYcbcrConversionKHRDelegate_0>(vkDestroySamplerYcbcrConversionKHRPointer);
		}
		vkBindBufferMemory2KHRPointer = vkGetInstanceProcAddr(instance, "vkBindBufferMemory2KHR");
		if (vkBindBufferMemory2KHRPointer != IntPtr.Zero)
		{
			vkBindBufferMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkBindBufferMemory2KHRDelegate_0>(vkBindBufferMemory2KHRPointer);
		}
		vkBindImageMemory2KHRPointer = vkGetInstanceProcAddr(instance, "vkBindImageMemory2KHR");
		if (vkBindImageMemory2KHRPointer != IntPtr.Zero)
		{
			vkBindImageMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkBindImageMemory2KHRDelegate_0>(vkBindImageMemory2KHRPointer);
		}
		vkCreateValidationCacheEXTPointer = vkGetInstanceProcAddr(instance, "vkCreateValidationCacheEXT");
		if (vkCreateValidationCacheEXTPointer != IntPtr.Zero)
		{
			vkCreateValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCreateValidationCacheEXTDelegate_0>(vkCreateValidationCacheEXTPointer);
		}
		vkDestroyValidationCacheEXTPointer = vkGetInstanceProcAddr(instance, "vkDestroyValidationCacheEXT");
		if (vkDestroyValidationCacheEXTPointer != IntPtr.Zero)
		{
			vkDestroyValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyValidationCacheEXTDelegate_0>(vkDestroyValidationCacheEXTPointer);
		}
		vkMergeValidationCachesEXTPointer = vkGetInstanceProcAddr(instance, "vkMergeValidationCachesEXT");
		if (vkMergeValidationCachesEXTPointer != IntPtr.Zero)
		{
			vkMergeValidationCachesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkMergeValidationCachesEXTDelegate_0>(vkMergeValidationCachesEXTPointer);
		}
		vkGetValidationCacheDataEXTPointer = vkGetInstanceProcAddr(instance, "vkGetValidationCacheDataEXT");
		if (vkGetValidationCacheDataEXTPointer != IntPtr.Zero)
		{
			vkGetValidationCacheDataEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetValidationCacheDataEXTDelegate_0>(vkGetValidationCacheDataEXTPointer);
		}
		vkGetMemoryHostPointerPropertiesEXTPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryHostPointerPropertiesEXT");
		if (vkGetMemoryHostPointerPropertiesEXTPointer != IntPtr.Zero)
		{
			vkGetMemoryHostPointerPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryHostPointerPropertiesEXTDelegate_0>(vkGetMemoryHostPointerPropertiesEXTPointer);
		}
		vkCmdWriteBufferMarkerAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteBufferMarkerAMD");
		if (vkCmdWriteBufferMarkerAMDPointer != IntPtr.Zero)
		{
			vkCmdWriteBufferMarkerAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteBufferMarkerAMDDelegate_0>(vkCmdWriteBufferMarkerAMDPointer);
		}
	}
}
