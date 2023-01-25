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
	public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_0(createInfo, allocator, out instance);
	private delegate VkResult CreateInstanceDelegate_0(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
	private static CreateInstanceDelegate_0 CreateInstance_0;
	public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_1(createInfo, ref allocator, out instance);
	private delegate VkResult CreateInstanceDelegate_1(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
	private static CreateInstanceDelegate_1 CreateInstance_1;
	public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_2(ref createInfo, allocator, out instance);
	private delegate VkResult CreateInstanceDelegate_2(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
	private static CreateInstanceDelegate_2 CreateInstance_2;
	public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_3(ref createInfo, ref allocator, out instance);
	private delegate VkResult CreateInstanceDelegate_3(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
	private static CreateInstanceDelegate_3 CreateInstance_3;
	private static IntPtr CreateInstancePointer;
	public static void DestroyInstance(VkInstance instance, VkAllocationCallbacks* allocator) => DestroyInstance_0(instance, allocator);
	private delegate void DestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* allocator);
	private static DestroyInstanceDelegate_0 DestroyInstance_0;
	public static void DestroyInstance(VkInstance instance, ref VkAllocationCallbacks allocator) => DestroyInstance_1(instance, ref allocator);
	private delegate void DestroyInstanceDelegate_1(VkInstance instance, ref VkAllocationCallbacks allocator);
	private static DestroyInstanceDelegate_1 DestroyInstance_1;
	private static IntPtr DestroyInstancePointer;
	public static VkResult EnumeratePhysicalDevices(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_0(instance, physicalDeviceCount, physicalDevices);
	private delegate VkResult EnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
	private static EnumeratePhysicalDevicesDelegate_0 EnumeratePhysicalDevices_0;
	public static VkResult EnumeratePhysicalDevices(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_1(instance, ref physicalDeviceCount, physicalDevices);
	private delegate VkResult EnumeratePhysicalDevicesDelegate_1(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
	private static EnumeratePhysicalDevicesDelegate_1 EnumeratePhysicalDevices_1;
	private static IntPtr EnumeratePhysicalDevicesPointer;
	public static void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features) => GetPhysicalDeviceFeatures_0(physicalDevice, out features);
	private delegate void GetPhysicalDeviceFeaturesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features);
	private static GetPhysicalDeviceFeaturesDelegate_0 GetPhysicalDeviceFeatures_0;
	private static IntPtr GetPhysicalDeviceFeaturesPointer;
	public static void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties) => GetPhysicalDeviceFormatProperties_0(physicalDevice, format, out formatProperties);
	private delegate void GetPhysicalDeviceFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties);
	private static GetPhysicalDeviceFormatPropertiesDelegate_0 GetPhysicalDeviceFormatProperties_0;
	private static IntPtr GetPhysicalDeviceFormatPropertiesPointer;
	public static VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties) => GetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, out imageFormatProperties);
	private delegate VkResult GetPhysicalDeviceImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties);
	private static GetPhysicalDeviceImageFormatPropertiesDelegate_0 GetPhysicalDeviceImageFormatProperties_0;
	private static IntPtr GetPhysicalDeviceImageFormatPropertiesPointer;
	public static void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties) => GetPhysicalDeviceProperties_0(physicalDevice, out properties);
	private delegate void GetPhysicalDevicePropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties);
	private static GetPhysicalDevicePropertiesDelegate_0 GetPhysicalDeviceProperties_0;
	private static IntPtr GetPhysicalDevicePropertiesPointer;
	public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_0 GetPhysicalDeviceQueueFamilyProperties_0;
	public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_1 GetPhysicalDeviceQueueFamilyProperties_1;
	private static IntPtr GetPhysicalDeviceQueueFamilyPropertiesPointer;
	public static void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties) => GetPhysicalDeviceMemoryProperties_0(physicalDevice, out memoryProperties);
	private delegate void GetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties);
	private static GetPhysicalDeviceMemoryPropertiesDelegate_0 GetPhysicalDeviceMemoryProperties_0;
	private static IntPtr GetPhysicalDeviceMemoryPropertiesPointer;
	public static IntPtr GetInstanceProcedureAddress(VkInstance instance, string name) => GetInstanceProcedureAddress_0(instance, name);
	private delegate IntPtr GetInstanceProcedureAddressDelegate_0(VkInstance instance, string name);
	private static GetInstanceProcedureAddressDelegate_0 GetInstanceProcedureAddress_0;
	private static IntPtr GetInstanceProcedureAddressPointer;
	public static IntPtr GetDeviceProcedureAddress(VkDevice device, string name) => GetDeviceProcedureAddress_0(device, name);
	private delegate IntPtr GetDeviceProcedureAddressDelegate_0(VkDevice device, string name);
	private static GetDeviceProcedureAddressDelegate_0 GetDeviceProcedureAddress_0;
	private static IntPtr GetDeviceProcedureAddressPointer;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_0(physicalDevice, createInfo, allocator, out device);
	private delegate VkResult CreateDeviceDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
	private static CreateDeviceDelegate_0 CreateDevice_0;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_1(physicalDevice, createInfo, ref allocator, out device);
	private delegate VkResult CreateDeviceDelegate_1(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
	private static CreateDeviceDelegate_1 CreateDevice_1;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_2(physicalDevice, ref createInfo, allocator, out device);
	private delegate VkResult CreateDeviceDelegate_2(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
	private static CreateDeviceDelegate_2 CreateDevice_2;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_3(physicalDevice, ref createInfo, ref allocator, out device);
	private delegate VkResult CreateDeviceDelegate_3(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
	private static CreateDeviceDelegate_3 CreateDevice_3;
	private static IntPtr CreateDevicePointer;
	public static void DestroyDevice(VkDevice device, VkAllocationCallbacks* allocator) => DestroyDevice_0(device, allocator);
	private delegate void DestroyDeviceDelegate_0(VkDevice device, VkAllocationCallbacks* allocator);
	private static DestroyDeviceDelegate_0 DestroyDevice_0;
	public static void DestroyDevice(VkDevice device, ref VkAllocationCallbacks allocator) => DestroyDevice_1(device, ref allocator);
	private delegate void DestroyDeviceDelegate_1(VkDevice device, ref VkAllocationCallbacks allocator);
	private static DestroyDeviceDelegate_1 DestroyDevice_1;
	private static IntPtr DestroyDevicePointer;
	public static VkResult EnumerateInstanceExtensionProperties(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_0(layerName, propertyCount, properties);
	private delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_0(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateInstanceExtensionPropertiesDelegate_0 EnumerateInstanceExtensionProperties_0;
	public static VkResult EnumerateInstanceExtensionProperties(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_1(layerName, ref propertyCount, properties);
	private delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_1(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateInstanceExtensionPropertiesDelegate_1 EnumerateInstanceExtensionProperties_1;
	private static IntPtr EnumerateInstanceExtensionPropertiesPointer;
	public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_0(physicalDevice, layerName, propertyCount, properties);
	private delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateDeviceExtensionPropertiesDelegate_0 EnumerateDeviceExtensionProperties_0;
	public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_1(physicalDevice, layerName, ref propertyCount, properties);
	private delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_1(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateDeviceExtensionPropertiesDelegate_1 EnumerateDeviceExtensionProperties_1;
	private static IntPtr EnumerateDeviceExtensionPropertiesPointer;
	public static VkResult EnumerateInstanceLayerProperties(uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_0(propertyCount, properties);
	private delegate VkResult EnumerateInstanceLayerPropertiesDelegate_0(uint* propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateInstanceLayerPropertiesDelegate_0 EnumerateInstanceLayerProperties_0;
	public static VkResult EnumerateInstanceLayerProperties(ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_1(ref propertyCount, properties);
	private delegate VkResult EnumerateInstanceLayerPropertiesDelegate_1(ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateInstanceLayerPropertiesDelegate_1 EnumerateInstanceLayerProperties_1;
	private static IntPtr EnumerateInstanceLayerPropertiesPointer;
	public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_0(physicalDevice, propertyCount, properties);
	private delegate VkResult EnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateDeviceLayerPropertiesDelegate_0 EnumerateDeviceLayerProperties_0;
	public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_1(physicalDevice, ref propertyCount, properties);
	private delegate VkResult EnumerateDeviceLayerPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateDeviceLayerPropertiesDelegate_1 EnumerateDeviceLayerProperties_1;
	private static IntPtr EnumerateDeviceLayerPropertiesPointer;
	public static void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue) => GetDeviceQueue_0(device, queueFamilyIndex, queueIndex, out queue);
	private delegate void GetDeviceQueueDelegate_0(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue);
	private static GetDeviceQueueDelegate_0 GetDeviceQueue_0;
	private static IntPtr GetDeviceQueuePointer;
	public static VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence) => QueueSubmit_0(queue, submitCount, submits, fence);
	private delegate VkResult QueueSubmitDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence);
	private static QueueSubmitDelegate_0 QueueSubmit_0;
	private static IntPtr QueueSubmitPointer;
	public static VkResult QueueWaitIdle(VkQueue queue) => QueueWaitIdle_0(queue);
	private delegate VkResult QueueWaitIdleDelegate_0(VkQueue queue);
	private static QueueWaitIdleDelegate_0 QueueWaitIdle_0;
	private static IntPtr QueueWaitIdlePointer;
	public static VkResult DeviceWaitIdle(VkDevice device) => DeviceWaitIdle_0(device);
	private delegate VkResult DeviceWaitIdleDelegate_0(VkDevice device);
	private static DeviceWaitIdleDelegate_0 DeviceWaitIdle_0;
	private static IntPtr DeviceWaitIdlePointer;
	public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_0(device, allocateInfo, allocator, out memory);
	private delegate VkResult AllocateMemoryDelegate_0(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_0 AllocateMemory_0;
	public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_1(device, allocateInfo, ref allocator, out memory);
	private delegate VkResult AllocateMemoryDelegate_1(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_1 AllocateMemory_1;
	public static VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_2(device, ref allocateInfo, allocator, out memory);
	private delegate VkResult AllocateMemoryDelegate_2(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_2 AllocateMemory_2;
	public static VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_3(device, ref allocateInfo, ref allocator, out memory);
	private delegate VkResult AllocateMemoryDelegate_3(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_3 AllocateMemory_3;
	private static IntPtr AllocateMemoryPointer;
	public static void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator) => FreeMemory_0(device, memory, allocator);
	private delegate void FreeMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator);
	private static FreeMemoryDelegate_0 FreeMemory_0;
	public static void FreeMemory(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator) => FreeMemory_1(device, memory, ref allocator);
	private delegate void FreeMemoryDelegate_1(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator);
	private static FreeMemoryDelegate_1 FreeMemory_1;
	private static IntPtr FreeMemoryPointer;
	public static VkResult MapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** data) => MapMemory_0(device, memory, offset, size, flags, data);
	private delegate VkResult MapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** data);
	private static MapMemoryDelegate_0 MapMemory_0;
	private static IntPtr MapMemoryPointer;
	public static void UnmapMemory(VkDevice device, VkDeviceMemory memory) => UnmapMemory_0(device, memory);
	private delegate void UnmapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory);
	private static UnmapMemoryDelegate_0 UnmapMemory_0;
	private static IntPtr UnmapMemoryPointer;
	public static VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => FlushMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
	private delegate VkResult FlushMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
	private static FlushMappedMemoryRangesDelegate_0 FlushMappedMemoryRanges_0;
	private static IntPtr FlushMappedMemoryRangesPointer;
	public static VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => InvalidateMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
	private delegate VkResult InvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
	private static InvalidateMappedMemoryRangesDelegate_0 InvalidateMappedMemoryRanges_0;
	private static IntPtr InvalidateMappedMemoryRangesPointer;
	public static void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes) => GetDeviceMemoryCommitment_0(device, memory, out committedMemoryInBytes);
	private delegate void GetDeviceMemoryCommitmentDelegate_0(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes);
	private static GetDeviceMemoryCommitmentDelegate_0 GetDeviceMemoryCommitment_0;
	private static IntPtr GetDeviceMemoryCommitmentPointer;
	public static VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindBufferMemory_0(device, buffer, memory, memoryOffset);
	private delegate VkResult BindBufferMemoryDelegate_0(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static BindBufferMemoryDelegate_0 BindBufferMemory_0;
	private static IntPtr BindBufferMemoryPointer;
	public static VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindImageMemory_0(device, image, memory, memoryOffset);
	private delegate VkResult BindImageMemoryDelegate_0(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static BindImageMemoryDelegate_0 BindImageMemory_0;
	private static IntPtr BindImageMemoryPointer;
	public static void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements) => GetBufferMemoryRequirements_0(device, buffer, out memoryRequirements);
	private delegate void GetBufferMemoryRequirementsDelegate_0(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements);
	private static GetBufferMemoryRequirementsDelegate_0 GetBufferMemoryRequirements_0;
	private static IntPtr GetBufferMemoryRequirementsPointer;
	public static void GetImageMemoryRequirements(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements) => GetImageMemoryRequirements_0(device, image, out memoryRequirements);
	private delegate void GetImageMemoryRequirementsDelegate_0(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements);
	private static GetImageMemoryRequirementsDelegate_0 GetImageMemoryRequirements_0;
	private static IntPtr GetImageMemoryRequirementsPointer;
	public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_0(device, image, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirementsDelegate_0 GetImageSparseMemoryRequirements_0;
	public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_1(device, image, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirementsDelegate_1(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirementsDelegate_1 GetImageSparseMemoryRequirements_1;
	private static IntPtr GetImageSparseMemoryRequirementsPointer;
	public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
	private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 GetPhysicalDeviceSparseImageFormatProperties_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_1(physicalDevice, format, type, samples, usage, tiling, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
	private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1 GetPhysicalDeviceSparseImageFormatProperties_1;
	private static IntPtr GetPhysicalDeviceSparseImageFormatPropertiesPointer;
	public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence) => QueueBindSparse_0(queue, bindInfoCount, bindInfo, fence);
	private delegate VkResult QueueBindSparseDelegate_0(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence);
	private static QueueBindSparseDelegate_0 QueueBindSparse_0;
	public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence) => QueueBindSparse_1(queue, bindInfoCount, ref bindInfo, fence);
	private delegate VkResult QueueBindSparseDelegate_1(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence);
	private static QueueBindSparseDelegate_1 QueueBindSparse_1;
	private static IntPtr QueueBindSparsePointer;
	public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_0(device, createInfo, allocator, out fence);
	private delegate VkResult CreateFenceDelegate_0(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
	private static CreateFenceDelegate_0 CreateFence_0;
	public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_1(device, createInfo, ref allocator, out fence);
	private delegate VkResult CreateFenceDelegate_1(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
	private static CreateFenceDelegate_1 CreateFence_1;
	public static VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_2(device, ref createInfo, allocator, out fence);
	private delegate VkResult CreateFenceDelegate_2(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
	private static CreateFenceDelegate_2 CreateFence_2;
	public static VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_3(device, ref createInfo, ref allocator, out fence);
	private delegate VkResult CreateFenceDelegate_3(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
	private static CreateFenceDelegate_3 CreateFence_3;
	private static IntPtr CreateFencePointer;
	public static void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator) => DestroyFence_0(device, fence, allocator);
	private delegate void DestroyFenceDelegate_0(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator);
	private static DestroyFenceDelegate_0 DestroyFence_0;
	public static void DestroyFence(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator) => DestroyFence_1(device, fence, ref allocator);
	private delegate void DestroyFenceDelegate_1(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator);
	private static DestroyFenceDelegate_1 DestroyFence_1;
	private static IntPtr DestroyFencePointer;
	public static VkResult ResetFences(VkDevice device, uint fenceCount, VkFence[] fences) => ResetFences_0(device, fenceCount, fences);
	private delegate VkResult ResetFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences);
	private static ResetFencesDelegate_0 ResetFences_0;
	private static IntPtr ResetFencesPointer;
	public static VkResult GetFenceStatus(VkDevice device, VkFence fence) => GetFenceStatus_0(device, fence);
	private delegate VkResult GetFenceStatusDelegate_0(VkDevice device, VkFence fence);
	private static GetFenceStatusDelegate_0 GetFenceStatus_0;
	private static IntPtr GetFenceStatusPointer;
	public static VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout) => WaitForFences_0(device, fenceCount, fences, waitAll, timeout);
	private delegate VkResult WaitForFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout);
	private static WaitForFencesDelegate_0 WaitForFences_0;
	private static IntPtr WaitForFencesPointer;
	public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_0(device, createInfo, allocator, out semaphore);
	private delegate VkResult CreateSemaphoreDelegate_0(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_0 CreateSemaphore_0;
	public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_1(device, createInfo, ref allocator, out semaphore);
	private delegate VkResult CreateSemaphoreDelegate_1(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_1 CreateSemaphore_1;
	public static VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_2(device, ref createInfo, allocator, out semaphore);
	private delegate VkResult CreateSemaphoreDelegate_2(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_2 CreateSemaphore_2;
	public static VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_3(device, ref createInfo, ref allocator, out semaphore);
	private delegate VkResult CreateSemaphoreDelegate_3(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_3 CreateSemaphore_3;
	private static IntPtr CreateSemaphorePointer;
	public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator) => DestroySemaphore_0(device, semaphore, allocator);
	private delegate void DestroySemaphoreDelegate_0(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator);
	private static DestroySemaphoreDelegate_0 DestroySemaphore_0;
	public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator) => DestroySemaphore_1(device, semaphore, ref allocator);
	private delegate void DestroySemaphoreDelegate_1(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator);
	private static DestroySemaphoreDelegate_1 DestroySemaphore_1;
	private static IntPtr DestroySemaphorePointer;
	public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_0(device, createInfo, allocator, out @event);
	private delegate VkResult CreateEventDelegate_0(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
	private static CreateEventDelegate_0 CreateEvent_0;
	public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_1(device, createInfo, ref allocator, out @event);
	private delegate VkResult CreateEventDelegate_1(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
	private static CreateEventDelegate_1 CreateEvent_1;
	public static VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_2(device, ref createInfo, allocator, out @event);
	private delegate VkResult CreateEventDelegate_2(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
	private static CreateEventDelegate_2 CreateEvent_2;
	public static VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_3(device, ref createInfo, ref allocator, out @event);
	private delegate VkResult CreateEventDelegate_3(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
	private static CreateEventDelegate_3 CreateEvent_3;
	private static IntPtr CreateEventPointer;
	public static void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator) => DestroyEvent_0(device, @event, allocator);
	private delegate void DestroyEventDelegate_0(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator);
	private static DestroyEventDelegate_0 DestroyEvent_0;
	public static void DestroyEvent(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator) => DestroyEvent_1(device, @event, ref allocator);
	private delegate void DestroyEventDelegate_1(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator);
	private static DestroyEventDelegate_1 DestroyEvent_1;
	private static IntPtr DestroyEventPointer;
	public static VkResult GetEventStatus(VkDevice device, VkEvent @event) => GetEventStatus_0(device, @event);
	private delegate VkResult GetEventStatusDelegate_0(VkDevice device, VkEvent @event);
	private static GetEventStatusDelegate_0 GetEventStatus_0;
	private static IntPtr GetEventStatusPointer;
	public static VkResult SetEvent(VkDevice device, VkEvent @event) => SetEvent_0(device, @event);
	private delegate VkResult SetEventDelegate_0(VkDevice device, VkEvent @event);
	private static SetEventDelegate_0 SetEvent_0;
	private static IntPtr SetEventPointer;
	public static VkResult ResetEvent(VkDevice device, VkEvent @event) => ResetEvent_0(device, @event);
	private delegate VkResult ResetEventDelegate_0(VkDevice device, VkEvent @event);
	private static ResetEventDelegate_0 ResetEvent_0;
	private static IntPtr ResetEventPointer;
	public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_0(device, createInfo, allocator, out queryPool);
	private delegate VkResult CreateQueryPoolDelegate_0(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_0 CreateQueryPool_0;
	public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_1(device, createInfo, ref allocator, out queryPool);
	private delegate VkResult CreateQueryPoolDelegate_1(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_1 CreateQueryPool_1;
	public static VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_2(device, ref createInfo, allocator, out queryPool);
	private delegate VkResult CreateQueryPoolDelegate_2(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_2 CreateQueryPool_2;
	public static VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_3(device, ref createInfo, ref allocator, out queryPool);
	private delegate VkResult CreateQueryPoolDelegate_3(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_3 CreateQueryPool_3;
	private static IntPtr CreateQueryPoolPointer;
	public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator) => DestroyQueryPool_0(device, queryPool, allocator);
	private delegate void DestroyQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator);
	private static DestroyQueryPoolDelegate_0 DestroyQueryPool_0;
	public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator) => DestroyQueryPool_1(device, queryPool, ref allocator);
	private delegate void DestroyQueryPoolDelegate_1(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator);
	private static DestroyQueryPoolDelegate_1 DestroyQueryPool_1;
	private static IntPtr DestroyQueryPoolPointer;
	public static VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags) => GetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, data, stride, flags);
	private delegate VkResult GetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags);
	private static GetQueryPoolResultsDelegate_0 GetQueryPoolResults_0;
	private static IntPtr GetQueryPoolResultsPointer;
	public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_0(device, createInfo, allocator, out buffer);
	private delegate VkResult CreateBufferDelegate_0(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_0 CreateBuffer_0;
	public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_1(device, createInfo, ref allocator, out buffer);
	private delegate VkResult CreateBufferDelegate_1(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_1 CreateBuffer_1;
	public static VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_2(device, ref createInfo, allocator, out buffer);
	private delegate VkResult CreateBufferDelegate_2(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_2 CreateBuffer_2;
	public static VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_3(device, ref createInfo, ref allocator, out buffer);
	private delegate VkResult CreateBufferDelegate_3(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_3 CreateBuffer_3;
	private static IntPtr CreateBufferPointer;
	public static void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator) => DestroyBuffer_0(device, buffer, allocator);
	private delegate void DestroyBufferDelegate_0(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator);
	private static DestroyBufferDelegate_0 DestroyBuffer_0;
	public static void DestroyBuffer(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator) => DestroyBuffer_1(device, buffer, ref allocator);
	private delegate void DestroyBufferDelegate_1(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator);
	private static DestroyBufferDelegate_1 DestroyBuffer_1;
	private static IntPtr DestroyBufferPointer;
	public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_0(device, createInfo, allocator, out view);
	private delegate VkResult CreateBufferViewDelegate_0(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_0 CreateBufferView_0;
	public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_1(device, createInfo, ref allocator, out view);
	private delegate VkResult CreateBufferViewDelegate_1(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_1 CreateBufferView_1;
	public static VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_2(device, ref createInfo, allocator, out view);
	private delegate VkResult CreateBufferViewDelegate_2(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_2 CreateBufferView_2;
	public static VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_3(device, ref createInfo, ref allocator, out view);
	private delegate VkResult CreateBufferViewDelegate_3(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_3 CreateBufferView_3;
	private static IntPtr CreateBufferViewPointer;
	public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator) => DestroyBufferView_0(device, bufferView, allocator);
	private delegate void DestroyBufferViewDelegate_0(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator);
	private static DestroyBufferViewDelegate_0 DestroyBufferView_0;
	public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator) => DestroyBufferView_1(device, bufferView, ref allocator);
	private delegate void DestroyBufferViewDelegate_1(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator);
	private static DestroyBufferViewDelegate_1 DestroyBufferView_1;
	private static IntPtr DestroyBufferViewPointer;
	public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_0(device, createInfo, allocator, out image);
	private delegate VkResult CreateImageDelegate_0(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image);
	private static CreateImageDelegate_0 CreateImage_0;
	public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_1(device, createInfo, ref allocator, out image);
	private delegate VkResult CreateImageDelegate_1(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
	private static CreateImageDelegate_1 CreateImage_1;
	public static VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_2(device, ref createInfo, allocator, out image);
	private delegate VkResult CreateImageDelegate_2(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image);
	private static CreateImageDelegate_2 CreateImage_2;
	public static VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_3(device, ref createInfo, ref allocator, out image);
	private delegate VkResult CreateImageDelegate_3(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
	private static CreateImageDelegate_3 CreateImage_3;
	private static IntPtr CreateImagePointer;
	public static void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* allocator) => DestroyImage_0(device, image, allocator);
	private delegate void DestroyImageDelegate_0(VkDevice device, VkImage image, VkAllocationCallbacks* allocator);
	private static DestroyImageDelegate_0 DestroyImage_0;
	public static void DestroyImage(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator) => DestroyImage_1(device, image, ref allocator);
	private delegate void DestroyImageDelegate_1(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator);
	private static DestroyImageDelegate_1 DestroyImage_1;
	private static IntPtr DestroyImagePointer;
	public static void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_0(device, image, subresource, out layout);
	private delegate void GetImageSubresourceLayoutDelegate_0(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout);
	private static GetImageSubresourceLayoutDelegate_0 GetImageSubresourceLayout_0;
	public static void GetImageSubresourceLayout(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_1(device, image, ref subresource, out layout);
	private delegate void GetImageSubresourceLayoutDelegate_1(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout);
	private static GetImageSubresourceLayoutDelegate_1 GetImageSubresourceLayout_1;
	private static IntPtr GetImageSubresourceLayoutPointer;
	public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_0(device, createInfo, allocator, out view);
	private delegate VkResult CreateImageViewDelegate_0(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
	private static CreateImageViewDelegate_0 CreateImageView_0;
	public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_1(device, createInfo, ref allocator, out view);
	private delegate VkResult CreateImageViewDelegate_1(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
	private static CreateImageViewDelegate_1 CreateImageView_1;
	public static VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_2(device, ref createInfo, allocator, out view);
	private delegate VkResult CreateImageViewDelegate_2(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
	private static CreateImageViewDelegate_2 CreateImageView_2;
	public static VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_3(device, ref createInfo, ref allocator, out view);
	private delegate VkResult CreateImageViewDelegate_3(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
	private static CreateImageViewDelegate_3 CreateImageView_3;
	private static IntPtr CreateImageViewPointer;
	public static void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator) => DestroyImageView_0(device, imageView, allocator);
	private delegate void DestroyImageViewDelegate_0(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator);
	private static DestroyImageViewDelegate_0 DestroyImageView_0;
	public static void DestroyImageView(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator) => DestroyImageView_1(device, imageView, ref allocator);
	private delegate void DestroyImageViewDelegate_1(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator);
	private static DestroyImageViewDelegate_1 DestroyImageView_1;
	private static IntPtr DestroyImageViewPointer;
	public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_0(device, createInfo, allocator, out shaderModule);
	private delegate VkResult CreateShaderModuleDelegate_0(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_0 CreateShaderModule_0;
	public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_1(device, createInfo, ref allocator, out shaderModule);
	private delegate VkResult CreateShaderModuleDelegate_1(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_1 CreateShaderModule_1;
	public static VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_2(device, ref createInfo, allocator, out shaderModule);
	private delegate VkResult CreateShaderModuleDelegate_2(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_2 CreateShaderModule_2;
	public static VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_3(device, ref createInfo, ref allocator, out shaderModule);
	private delegate VkResult CreateShaderModuleDelegate_3(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_3 CreateShaderModule_3;
	private static IntPtr CreateShaderModulePointer;
	public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator) => DestroyShaderModule_0(device, shaderModule, allocator);
	private delegate void DestroyShaderModuleDelegate_0(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator);
	private static DestroyShaderModuleDelegate_0 DestroyShaderModule_0;
	public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator) => DestroyShaderModule_1(device, shaderModule, ref allocator);
	private delegate void DestroyShaderModuleDelegate_1(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator);
	private static DestroyShaderModuleDelegate_1 DestroyShaderModule_1;
	private static IntPtr DestroyShaderModulePointer;
	public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_0(device, createInfo, allocator, out pipelineCache);
	private delegate VkResult CreatePipelineCacheDelegate_0(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_0 CreatePipelineCache_0;
	public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_1(device, createInfo, ref allocator, out pipelineCache);
	private delegate VkResult CreatePipelineCacheDelegate_1(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_1 CreatePipelineCache_1;
	public static VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_2(device, ref createInfo, allocator, out pipelineCache);
	private delegate VkResult CreatePipelineCacheDelegate_2(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_2 CreatePipelineCache_2;
	public static VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_3(device, ref createInfo, ref allocator, out pipelineCache);
	private delegate VkResult CreatePipelineCacheDelegate_3(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_3 CreatePipelineCache_3;
	private static IntPtr CreatePipelineCachePointer;
	public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator) => DestroyPipelineCache_0(device, pipelineCache, allocator);
	private delegate void DestroyPipelineCacheDelegate_0(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator);
	private static DestroyPipelineCacheDelegate_0 DestroyPipelineCache_0;
	public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator) => DestroyPipelineCache_1(device, pipelineCache, ref allocator);
	private delegate void DestroyPipelineCacheDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineCacheDelegate_1 DestroyPipelineCache_1;
	private static IntPtr DestroyPipelineCachePointer;
	public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data) => GetPipelineCacheData_0(device, pipelineCache, dataSize, data);
	private delegate VkResult GetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data);
	private static GetPipelineCacheDataDelegate_0 GetPipelineCacheData_0;
	public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data) => GetPipelineCacheData_1(device, pipelineCache, ref dataSize, data);
	private delegate VkResult GetPipelineCacheDataDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data);
	private static GetPipelineCacheDataDelegate_1 GetPipelineCacheData_1;
	private static IntPtr GetPipelineCacheDataPointer;
	public static VkResult MergePipelineCaches(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches) => MergePipelineCaches_0(device, destinationCache, sourceCacheCount, sourceCaches);
	private delegate VkResult MergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches);
	private static MergePipelineCachesDelegate_0 MergePipelineCaches_0;
	private static IntPtr MergePipelineCachesPointer;
	public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	private delegate VkResult CreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateGraphicsPipelinesDelegate_0 CreateGraphicsPipelines_0;
	public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	private delegate VkResult CreateGraphicsPipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateGraphicsPipelinesDelegate_1 CreateGraphicsPipelines_1;
	private static IntPtr CreateGraphicsPipelinesPointer;
	public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateComputePipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	private delegate VkResult CreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateComputePipelinesDelegate_0 CreateComputePipelines_0;
	public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateComputePipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	private delegate VkResult CreateComputePipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateComputePipelinesDelegate_1 CreateComputePipelines_1;
	private static IntPtr CreateComputePipelinesPointer;
	public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator) => DestroyPipeline_0(device, pipeline, allocator);
	private delegate void DestroyPipelineDelegate_0(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator);
	private static DestroyPipelineDelegate_0 DestroyPipeline_0;
	public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator) => DestroyPipeline_1(device, pipeline, ref allocator);
	private delegate void DestroyPipelineDelegate_1(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineDelegate_1 DestroyPipeline_1;
	private static IntPtr DestroyPipelinePointer;
	public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_0(device, createInfo, allocator, out pipelineLayout);
	private delegate VkResult CreatePipelineLayoutDelegate_0(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_0 CreatePipelineLayout_0;
	public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_1(device, createInfo, ref allocator, out pipelineLayout);
	private delegate VkResult CreatePipelineLayoutDelegate_1(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_1 CreatePipelineLayout_1;
	public static VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_2(device, ref createInfo, allocator, out pipelineLayout);
	private delegate VkResult CreatePipelineLayoutDelegate_2(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_2 CreatePipelineLayout_2;
	public static VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_3(device, ref createInfo, ref allocator, out pipelineLayout);
	private delegate VkResult CreatePipelineLayoutDelegate_3(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_3 CreatePipelineLayout_3;
	private static IntPtr CreatePipelineLayoutPointer;
	public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator) => DestroyPipelineLayout_0(device, pipelineLayout, allocator);
	private delegate void DestroyPipelineLayoutDelegate_0(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator);
	private static DestroyPipelineLayoutDelegate_0 DestroyPipelineLayout_0;
	public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator) => DestroyPipelineLayout_1(device, pipelineLayout, ref allocator);
	private delegate void DestroyPipelineLayoutDelegate_1(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineLayoutDelegate_1 DestroyPipelineLayout_1;
	private static IntPtr DestroyPipelineLayoutPointer;
	public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_0(device, createInfo, allocator, out sampler);
	private delegate VkResult CreateSamplerDelegate_0(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_0 CreateSampler_0;
	public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_1(device, createInfo, ref allocator, out sampler);
	private delegate VkResult CreateSamplerDelegate_1(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_1 CreateSampler_1;
	public static VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_2(device, ref createInfo, allocator, out sampler);
	private delegate VkResult CreateSamplerDelegate_2(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_2 CreateSampler_2;
	public static VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_3(device, ref createInfo, ref allocator, out sampler);
	private delegate VkResult CreateSamplerDelegate_3(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_3 CreateSampler_3;
	private static IntPtr CreateSamplerPointer;
	public static void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator) => DestroySampler_0(device, sampler, allocator);
	private delegate void DestroySamplerDelegate_0(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator);
	private static DestroySamplerDelegate_0 DestroySampler_0;
	public static void DestroySampler(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator) => DestroySampler_1(device, sampler, ref allocator);
	private delegate void DestroySamplerDelegate_1(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator);
	private static DestroySamplerDelegate_1 DestroySampler_1;
	private static IntPtr DestroySamplerPointer;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_0(device, createInfo, allocator, out setLayout);
	private delegate VkResult CreateDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_0 CreateDescriptorSetLayout_0;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_1(device, createInfo, ref allocator, out setLayout);
	private delegate VkResult CreateDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_1 CreateDescriptorSetLayout_1;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_2(device, ref createInfo, allocator, out setLayout);
	private delegate VkResult CreateDescriptorSetLayoutDelegate_2(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_2 CreateDescriptorSetLayout_2;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_3(device, ref createInfo, ref allocator, out setLayout);
	private delegate VkResult CreateDescriptorSetLayoutDelegate_3(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_3 CreateDescriptorSetLayout_3;
	private static IntPtr CreateDescriptorSetLayoutPointer;
	public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator) => DestroyDescriptorSetLayout_0(device, descriptorSetLayout, allocator);
	private delegate void DestroyDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorSetLayoutDelegate_0 DestroyDescriptorSetLayout_0;
	public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator) => DestroyDescriptorSetLayout_1(device, descriptorSetLayout, ref allocator);
	private delegate void DestroyDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorSetLayoutDelegate_1 DestroyDescriptorSetLayout_1;
	private static IntPtr DestroyDescriptorSetLayoutPointer;
	public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_0(device, createInfo, allocator, out descriptorPool);
	private delegate VkResult CreateDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_0 CreateDescriptorPool_0;
	public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_1(device, createInfo, ref allocator, out descriptorPool);
	private delegate VkResult CreateDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_1 CreateDescriptorPool_1;
	public static VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_2(device, ref createInfo, allocator, out descriptorPool);
	private delegate VkResult CreateDescriptorPoolDelegate_2(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_2 CreateDescriptorPool_2;
	public static VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_3(device, ref createInfo, ref allocator, out descriptorPool);
	private delegate VkResult CreateDescriptorPoolDelegate_3(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_3 CreateDescriptorPool_3;
	private static IntPtr CreateDescriptorPoolPointer;
	public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator) => DestroyDescriptorPool_0(device, descriptorPool, allocator);
	private delegate void DestroyDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorPoolDelegate_0 DestroyDescriptorPool_0;
	public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator) => DestroyDescriptorPool_1(device, descriptorPool, ref allocator);
	private delegate void DestroyDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorPoolDelegate_1 DestroyDescriptorPool_1;
	private static IntPtr DestroyDescriptorPoolPointer;
	public static VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags) => ResetDescriptorPool_0(device, descriptorPool, flags);
	private delegate VkResult ResetDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
	private static ResetDescriptorPoolDelegate_0 ResetDescriptorPool_0;
	private static IntPtr ResetDescriptorPoolPointer;
	public static VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_0(device, allocateInfo, descriptorSets);
	private delegate VkResult AllocateDescriptorSetsDelegate_0(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
	private static AllocateDescriptorSetsDelegate_0 AllocateDescriptorSets_0;
	public static VkResult AllocateDescriptorSets(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_1(device, ref allocateInfo, descriptorSets);
	private delegate VkResult AllocateDescriptorSetsDelegate_1(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
	private static AllocateDescriptorSetsDelegate_1 AllocateDescriptorSets_1;
	private static IntPtr AllocateDescriptorSetsPointer;
	public static VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets) => FreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, descriptorSets);
	private delegate VkResult FreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets);
	private static FreeDescriptorSetsDelegate_0 FreeDescriptorSets_0;
	private static IntPtr FreeDescriptorSetsPointer;
	public static void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies) => UpdateDescriptorSets_0(device, descriptorWriteCount, descriptorWrites, descriptorCopyCount, descriptorCopies);
	private delegate void UpdateDescriptorSetsDelegate_0(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies);
	private static UpdateDescriptorSetsDelegate_0 UpdateDescriptorSets_0;
	private static IntPtr UpdateDescriptorSetsPointer;
	public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_0(device, createInfo, allocator, out framebuffer);
	private delegate VkResult CreateFramebufferDelegate_0(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_0 CreateFramebuffer_0;
	public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_1(device, createInfo, ref allocator, out framebuffer);
	private delegate VkResult CreateFramebufferDelegate_1(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_1 CreateFramebuffer_1;
	public static VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_2(device, ref createInfo, allocator, out framebuffer);
	private delegate VkResult CreateFramebufferDelegate_2(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_2 CreateFramebuffer_2;
	public static VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_3(device, ref createInfo, ref allocator, out framebuffer);
	private delegate VkResult CreateFramebufferDelegate_3(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_3 CreateFramebuffer_3;
	private static IntPtr CreateFramebufferPointer;
	public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator) => DestroyFramebuffer_0(device, framebuffer, allocator);
	private delegate void DestroyFramebufferDelegate_0(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator);
	private static DestroyFramebufferDelegate_0 DestroyFramebuffer_0;
	public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator) => DestroyFramebuffer_1(device, framebuffer, ref allocator);
	private delegate void DestroyFramebufferDelegate_1(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator);
	private static DestroyFramebufferDelegate_1 DestroyFramebuffer_1;
	private static IntPtr DestroyFramebufferPointer;
	public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_0(device, createInfo, allocator, out renderPass);
	private delegate VkResult CreateRenderPassDelegate_0(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_0 CreateRenderPass_0;
	public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_1(device, createInfo, ref allocator, out renderPass);
	private delegate VkResult CreateRenderPassDelegate_1(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_1 CreateRenderPass_1;
	public static VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_2(device, ref createInfo, allocator, out renderPass);
	private delegate VkResult CreateRenderPassDelegate_2(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_2 CreateRenderPass_2;
	public static VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_3(device, ref createInfo, ref allocator, out renderPass);
	private delegate VkResult CreateRenderPassDelegate_3(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_3 CreateRenderPass_3;
	private static IntPtr CreateRenderPassPointer;
	public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator) => DestroyRenderPass_0(device, renderPass, allocator);
	private delegate void DestroyRenderPassDelegate_0(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator);
	private static DestroyRenderPassDelegate_0 DestroyRenderPass_0;
	public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator) => DestroyRenderPass_1(device, renderPass, ref allocator);
	private delegate void DestroyRenderPassDelegate_1(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator);
	private static DestroyRenderPassDelegate_1 DestroyRenderPass_1;
	private static IntPtr DestroyRenderPassPointer;
	public static void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity) => GetRenderAreaGranularity_0(device, renderPass, out granularity);
	private delegate void GetRenderAreaGranularityDelegate_0(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity);
	private static GetRenderAreaGranularityDelegate_0 GetRenderAreaGranularity_0;
	private static IntPtr GetRenderAreaGranularityPointer;
	public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_0(device, createInfo, allocator, out commandPool);
	private delegate VkResult CreateCommandPoolDelegate_0(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_0 CreateCommandPool_0;
	public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_1(device, createInfo, ref allocator, out commandPool);
	private delegate VkResult CreateCommandPoolDelegate_1(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_1 CreateCommandPool_1;
	public static VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_2(device, ref createInfo, allocator, out commandPool);
	private delegate VkResult CreateCommandPoolDelegate_2(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_2 CreateCommandPool_2;
	public static VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_3(device, ref createInfo, ref allocator, out commandPool);
	private delegate VkResult CreateCommandPoolDelegate_3(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_3 CreateCommandPool_3;
	private static IntPtr CreateCommandPoolPointer;
	public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator) => DestroyCommandPool_0(device, commandPool, allocator);
	private delegate void DestroyCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator);
	private static DestroyCommandPoolDelegate_0 DestroyCommandPool_0;
	public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator) => DestroyCommandPool_1(device, commandPool, ref allocator);
	private delegate void DestroyCommandPoolDelegate_1(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator);
	private static DestroyCommandPoolDelegate_1 DestroyCommandPool_1;
	private static IntPtr DestroyCommandPoolPointer;
	public static VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags) => ResetCommandPool_0(device, commandPool, flags);
	private delegate VkResult ResetCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
	private static ResetCommandPoolDelegate_0 ResetCommandPool_0;
	private static IntPtr ResetCommandPoolPointer;
	public static VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_0(device, allocateInfo, commandBuffers);
	private delegate VkResult AllocateCommandBuffersDelegate_0(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
	private static AllocateCommandBuffersDelegate_0 AllocateCommandBuffers_0;
	public static VkResult AllocateCommandBuffers(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_1(device, ref allocateInfo, commandBuffers);
	private delegate VkResult AllocateCommandBuffersDelegate_1(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
	private static AllocateCommandBuffersDelegate_1 AllocateCommandBuffers_1;
	private static IntPtr AllocateCommandBuffersPointer;
	public static void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => FreeCommandBuffers_0(device, commandPool, commandBufferCount, commandBuffers);
	private delegate void FreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
	private static FreeCommandBuffersDelegate_0 FreeCommandBuffers_0;
	private static IntPtr FreeCommandBuffersPointer;
	public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo) => BeginCommandBuffer_0(commandBuffer, beginInfo);
	private delegate VkResult BeginCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo);
	private static BeginCommandBufferDelegate_0 BeginCommandBuffer_0;
	public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo) => BeginCommandBuffer_1(commandBuffer, ref beginInfo);
	private delegate VkResult BeginCommandBufferDelegate_1(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo);
	private static BeginCommandBufferDelegate_1 BeginCommandBuffer_1;
	private static IntPtr BeginCommandBufferPointer;
	public static VkResult EndCommandBuffer(VkCommandBuffer commandBuffer) => EndCommandBuffer_0(commandBuffer);
	private delegate VkResult EndCommandBufferDelegate_0(VkCommandBuffer commandBuffer);
	private static EndCommandBufferDelegate_0 EndCommandBuffer_0;
	private static IntPtr EndCommandBufferPointer;
	public static VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags) => ResetCommandBuffer_0(commandBuffer, flags);
	private delegate VkResult ResetCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
	private static ResetCommandBufferDelegate_0 ResetCommandBuffer_0;
	private static IntPtr ResetCommandBufferPointer;
	public static void CommandBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline) => CommandBindPipeline_0(commandBuffer, pipelineBindPoint, pipeline);
	private delegate void CommandBindPipelineDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
	private static CommandBindPipelineDelegate_0 CommandBindPipeline_0;
	private static IntPtr CommandBindPipelinePointer;
	public static void CommandSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports) => CommandSetViewport_0(commandBuffer, firstViewport, viewportCount, viewports);
	private delegate void CommandSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports);
	private static CommandSetViewportDelegate_0 CommandSetViewport_0;
	private static IntPtr CommandSetViewportPointer;
	public static void CommandSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors) => CommandSetScissor_0(commandBuffer, firstScissor, scissorCount, scissors);
	private delegate void CommandSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors);
	private static CommandSetScissorDelegate_0 CommandSetScissor_0;
	private static IntPtr CommandSetScissorPointer;
	public static void CommandSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth) => CommandSetLineWidth_0(commandBuffer, lineWidth);
	private delegate void CommandSetLineWidthDelegate_0(VkCommandBuffer commandBuffer, float lineWidth);
	private static CommandSetLineWidthDelegate_0 CommandSetLineWidth_0;
	private static IntPtr CommandSetLineWidthPointer;
	public static void CommandSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) => CommandSetDepthBias_0(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
	private delegate void CommandSetDepthBiasDelegate_0(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
	private static CommandSetDepthBiasDelegate_0 CommandSetDepthBias_0;
	private static IntPtr CommandSetDepthBiasPointer;
	public static void CommandSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants) => CommandSetBlendConstants_0(commandBuffer, blendConstants);
	private delegate void CommandSetBlendConstantsDelegate_0(VkCommandBuffer commandBuffer, float blendConstants);
	private static CommandSetBlendConstantsDelegate_0 CommandSetBlendConstants_0;
	private static IntPtr CommandSetBlendConstantsPointer;
	public static void CommandSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds) => CommandSetDepthBounds_0(commandBuffer, minDepthBounds, maxDepthBounds);
	private delegate void CommandSetDepthBoundsDelegate_0(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
	private static CommandSetDepthBoundsDelegate_0 CommandSetDepthBounds_0;
	private static IntPtr CommandSetDepthBoundsPointer;
	public static void CommandSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask) => CommandSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
	private delegate void CommandSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
	private static CommandSetStencilCompareMaskDelegate_0 CommandSetStencilCompareMask_0;
	private static IntPtr CommandSetStencilCompareMaskPointer;
	public static void CommandSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask) => CommandSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
	private delegate void CommandSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
	private static CommandSetStencilWriteMaskDelegate_0 CommandSetStencilWriteMask_0;
	private static IntPtr CommandSetStencilWriteMaskPointer;
	public static void CommandSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference) => CommandSetStencilReference_0(commandBuffer, faceMask, reference);
	private delegate void CommandSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
	private static CommandSetStencilReferenceDelegate_0 CommandSetStencilReference_0;
	private static IntPtr CommandSetStencilReferencePointer;
	public static void CommandBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets) => CommandBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, descriptorSets, dynamicOffsetCount, dynamicOffsets);
	private delegate void CommandBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets);
	private static CommandBindDescriptorSetsDelegate_0 CommandBindDescriptorSets_0;
	private static IntPtr CommandBindDescriptorSetsPointer;
	public static void CommandBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => CommandBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
	private delegate void CommandBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
	private static CommandBindIndexBufferDelegate_0 CommandBindIndexBuffer_0;
	private static IntPtr CommandBindIndexBufferPointer;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, buffers, offsets);
	private delegate void CommandBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets);
	private static CommandBindVertexBuffersDelegate_0 CommandBindVertexBuffers_0;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_1(commandBuffer, firstBinding, bindingCount, buffers, ref offsets);
	private delegate void CommandBindVertexBuffersDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets);
	private static CommandBindVertexBuffersDelegate_1 CommandBindVertexBuffers_1;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets);
	private delegate void CommandBindVertexBuffersDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets);
	private static CommandBindVertexBuffersDelegate_2 CommandBindVertexBuffers_2;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_3(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets);
	private delegate void CommandBindVertexBuffersDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets);
	private static CommandBindVertexBuffersDelegate_3 CommandBindVertexBuffers_3;
	private static IntPtr CommandBindVertexBuffersPointer;
	public static void CommandDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) => CommandDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
	private delegate void CommandDrawDelegate_0(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
	private static CommandDrawDelegate_0 CommandDraw_0;
	private static IntPtr CommandDrawPointer;
	public static void CommandDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) => CommandDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
	private delegate void CommandDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
	private static CommandDrawIndexedDelegate_0 CommandDrawIndexed_0;
	private static IntPtr CommandDrawIndexedPointer;
	public static void CommandDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static CommandDrawIndirectDelegate_0 CommandDrawIndirect_0;
	private static IntPtr CommandDrawIndirectPointer;
	public static void CommandDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static CommandDrawIndexedIndirectDelegate_0 CommandDrawIndexedIndirect_0;
	private static IntPtr CommandDrawIndexedIndirectPointer;
	public static void CommandDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchDelegate_0(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static CommandDispatchDelegate_0 CommandDispatch_0;
	private static IntPtr CommandDispatchPointer;
	public static void CommandDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => CommandDispatchIndirect_0(commandBuffer, buffer, offset);
	private delegate void CommandDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
	private static CommandDispatchIndirectDelegate_0 CommandDispatchIndirect_0;
	private static IntPtr CommandDispatchIndirectPointer;
	public static void CommandCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions) => CommandCopyBuffer_0(commandBuffer, sourceBuffer, destinationBuffer, regionCount, regions);
	private delegate void CommandCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions);
	private static CommandCopyBufferDelegate_0 CommandCopyBuffer_0;
	private static IntPtr CommandCopyBufferPointer;
	public static void CommandCopyImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions) => CommandCopyImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions);
	private static CommandCopyImageDelegate_0 CommandCopyImage_0;
	private static IntPtr CommandCopyImagePointer;
	public static void CommandBlitImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter) => CommandBlitImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions, filter);
	private delegate void CommandBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter);
	private static CommandBlitImageDelegate_0 CommandBlitImage_0;
	private static IntPtr CommandBlitImagePointer;
	public static void CommandCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyBufferToImage_0(commandBuffer, sourceBuffer, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions);
	private static CommandCopyBufferToImageDelegate_0 CommandCopyBufferToImage_0;
	private static IntPtr CommandCopyBufferToImagePointer;
	public static void CommandCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyImageToBuffer_0(commandBuffer, sourceImage, sourceImageLayout, destinationBuffer, regionCount, regions);
	private delegate void CommandCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions);
	private static CommandCopyImageToBufferDelegate_0 CommandCopyImageToBuffer_0;
	private static IntPtr CommandCopyImageToBufferPointer;
	public static void CommandUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data) => CommandUpdateBuffer_0(commandBuffer, destinationBuffer, destinationOffset, dataSize, data);
	private delegate void CommandUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data);
	private static CommandUpdateBufferDelegate_0 CommandUpdateBuffer_0;
	private static IntPtr CommandUpdateBufferPointer;
	public static void CommandFillBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data) => CommandFillBuffer_0(commandBuffer, destinationBuffer, destinationOffset, size, data);
	private delegate void CommandFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data);
	private static CommandFillBufferDelegate_0 CommandFillBuffer_0;
	private static IntPtr CommandFillBufferPointer;
	public static void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_0(commandBuffer, image, imageLayout, color, rangeCount, ranges);
	private delegate void CommandClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearColorImageDelegate_0 CommandClearColorImage_0;
	public static void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_1(commandBuffer, image, imageLayout, ref color, rangeCount, ranges);
	private delegate void CommandClearColorImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearColorImageDelegate_1 CommandClearColorImage_1;
	private static IntPtr CommandClearColorImagePointer;
	public static void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_0(commandBuffer, image, imageLayout, depthStencil, rangeCount, ranges);
	private delegate void CommandClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearDepthStencilImageDelegate_0 CommandClearDepthStencilImage_0;
	public static void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_1(commandBuffer, image, imageLayout, ref depthStencil, rangeCount, ranges);
	private delegate void CommandClearDepthStencilImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearDepthStencilImageDelegate_1 CommandClearDepthStencilImage_1;
	private static IntPtr CommandClearDepthStencilImagePointer;
	public static void CommandClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects) => CommandClearAttachments_0(commandBuffer, attachmentCount, attachments, rectCount, rects);
	private delegate void CommandClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects);
	private static CommandClearAttachmentsDelegate_0 CommandClearAttachments_0;
	private static IntPtr CommandClearAttachmentsPointer;
	public static void CommandResolveImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions) => CommandResolveImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions);
	private static CommandResolveImageDelegate_0 CommandResolveImage_0;
	private static IntPtr CommandResolveImagePointer;
	public static void CommandSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandSetEvent_0(commandBuffer, @event, stageMask);
	private delegate void CommandSetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
	private static CommandSetEventDelegate_0 CommandSetEvent_0;
	private static IntPtr CommandSetEventPointer;
	public static void CommandResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandResetEvent_0(commandBuffer, @event, stageMask);
	private delegate void CommandResetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
	private static CommandResetEventDelegate_0 CommandResetEvent_0;
	private static IntPtr CommandResetEventPointer;
	public static void CommandWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandWaitEvents_0(commandBuffer, eventCount, events, sourceStageMask, destinationStageMask, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
	private delegate void CommandWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
	private static CommandWaitEventsDelegate_0 CommandWaitEvents_0;
	private static IntPtr CommandWaitEventsPointer;
	public static void CommandPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandPipelineBarrier_0(commandBuffer, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
	private delegate void CommandPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
	private static CommandPipelineBarrierDelegate_0 CommandPipelineBarrier_0;
	private static IntPtr CommandPipelineBarrierPointer;
	public static void CommandBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags) => CommandBeginQuery_0(commandBuffer, queryPool, query, flags);
	private delegate void CommandBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
	private static CommandBeginQueryDelegate_0 CommandBeginQuery_0;
	private static IntPtr CommandBeginQueryPointer;
	public static void CommandEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query) => CommandEndQuery_0(commandBuffer, queryPool, query);
	private delegate void CommandEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
	private static CommandEndQueryDelegate_0 CommandEndQuery_0;
	private static IntPtr CommandEndQueryPointer;
	public static void CommandResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount) => CommandResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
	private delegate void CommandResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static CommandResetQueryPoolDelegate_0 CommandResetQueryPool_0;
	private static IntPtr CommandResetQueryPoolPointer;
	public static void CommandWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
	private delegate void CommandWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
	private static CommandWriteTimestampDelegate_0 CommandWriteTimestamp_0;
	private static IntPtr CommandWriteTimestampPointer;
	public static void CommandCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags) => CommandCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, destinationBuffer, destinationOffset, stride, flags);
	private delegate void CommandCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags);
	private static CommandCopyQueryPoolResultsDelegate_0 CommandCopyQueryPoolResults_0;
	private static IntPtr CommandCopyQueryPoolResultsPointer;
	public static void CommandPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values) => CommandPushConstants_0(commandBuffer, layout, stageFlags, offset, size, values);
	private delegate void CommandPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values);
	private static CommandPushConstantsDelegate_0 CommandPushConstants_0;
	private static IntPtr CommandPushConstantsPointer;
	public static void CommandBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_0(commandBuffer, renderPassBegin, contents);
	private delegate void CommandBeginRenderPassDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents);
	private static CommandBeginRenderPassDelegate_0 CommandBeginRenderPass_0;
	public static void CommandBeginRenderPass(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_1(commandBuffer, ref renderPassBegin, contents);
	private delegate void CommandBeginRenderPassDelegate_1(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents);
	private static CommandBeginRenderPassDelegate_1 CommandBeginRenderPass_1;
	private static IntPtr CommandBeginRenderPassPointer;
	public static void CommandNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents) => CommandNextSubpass_0(commandBuffer, contents);
	private delegate void CommandNextSubpassDelegate_0(VkCommandBuffer commandBuffer, VkSubpassContents contents);
	private static CommandNextSubpassDelegate_0 CommandNextSubpass_0;
	private static IntPtr CommandNextSubpassPointer;
	public static void CommandEndRenderPass(VkCommandBuffer commandBuffer) => CommandEndRenderPass_0(commandBuffer);
	private delegate void CommandEndRenderPassDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandEndRenderPassDelegate_0 CommandEndRenderPass_0;
	private static IntPtr CommandEndRenderPassPointer;
	public static void CommandExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => CommandExecuteCommands_0(commandBuffer, commandBufferCount, commandBuffers);
	private delegate void CommandExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
	private static CommandExecuteCommandsDelegate_0 CommandExecuteCommands_0;
	private static IntPtr CommandExecuteCommandsPointer;
	public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator) => DestroySurfaceKHR_0(instance, surface, allocator);
	private delegate void DestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator);
	private static DestroySurfaceKHRDelegate_0 DestroySurfaceKHR_0;
	public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator) => DestroySurfaceKHR_1(instance, surface, ref allocator);
	private delegate void DestroySurfaceKHRDelegate_1(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator);
	private static DestroySurfaceKHRDelegate_1 DestroySurfaceKHR_1;
	private static IntPtr DestroySurfaceKHRPointer;
	public static VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported) => GetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, out supported);
	private delegate VkResult GetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported);
	private static GetPhysicalDeviceSurfaceSupportKHRDelegate_0 GetPhysicalDeviceSurfaceSupportKHR_0;
	private static IntPtr GetPhysicalDeviceSurfaceSupportKHRPointer;
	public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, out surfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 GetPhysicalDeviceSurfaceCapabilitiesKHR_0;
	private static IntPtr GetPhysicalDeviceSurfaceCapabilitiesKHRPointer;
	public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_0 GetPhysicalDeviceSurfaceFormatsKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_1(physicalDevice, surface, ref surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_1 GetPhysicalDeviceSurfaceFormatsKHR_1;
	private static IntPtr GetPhysicalDeviceSurfaceFormatsKHRPointer;
	public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, presentModeCount, presentModes);
	private delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_0 GetPhysicalDeviceSurfacePresentModesKHR_0;
	public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_1(physicalDevice, surface, ref presentModeCount, presentModes);
	private delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_1 GetPhysicalDeviceSurfacePresentModesKHR_1;
	private static IntPtr GetPhysicalDeviceSurfacePresentModesKHRPointer;
	public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_0(device, createInfo, allocator, out swapchain);
	private delegate VkResult CreateSwapchainKHRDelegate_0(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_0 CreateSwapchainKHR_0;
	public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_1(device, createInfo, ref allocator, out swapchain);
	private delegate VkResult CreateSwapchainKHRDelegate_1(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_1 CreateSwapchainKHR_1;
	public static VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_2(device, ref createInfo, allocator, out swapchain);
	private delegate VkResult CreateSwapchainKHRDelegate_2(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_2 CreateSwapchainKHR_2;
	public static VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_3(device, ref createInfo, ref allocator, out swapchain);
	private delegate VkResult CreateSwapchainKHRDelegate_3(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_3 CreateSwapchainKHR_3;
	private static IntPtr CreateSwapchainKHRPointer;
	public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator) => DestroySwapchainKHR_0(device, swapchain, allocator);
	private delegate void DestroySwapchainKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator);
	private static DestroySwapchainKHRDelegate_0 DestroySwapchainKHR_0;
	public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator) => DestroySwapchainKHR_1(device, swapchain, ref allocator);
	private delegate void DestroySwapchainKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator);
	private static DestroySwapchainKHRDelegate_1 DestroySwapchainKHR_1;
	private static IntPtr DestroySwapchainKHRPointer;
	public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_0(device, swapchain, swapchainImageCount, swapchainImages);
	private delegate VkResult GetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages);
	private static GetSwapchainImagesKHRDelegate_0 GetSwapchainImagesKHR_0;
	public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_1(device, swapchain, ref swapchainImageCount, swapchainImages);
	private delegate VkResult GetSwapchainImagesKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages);
	private static GetSwapchainImagesKHRDelegate_1 GetSwapchainImagesKHR_1;
	private static IntPtr GetSwapchainImagesKHRPointer;
	public static VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex) => AcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, out imageIndex);
	private delegate VkResult AcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex);
	private static AcquireNextImageKHRDelegate_0 AcquireNextImageKHR_0;
	private static IntPtr AcquireNextImageKHRPointer;
	public static VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* presentInfo) => QueuePresentKHR_0(queue, presentInfo);
	private delegate VkResult QueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* presentInfo);
	private static QueuePresentKHRDelegate_0 QueuePresentKHR_0;
	public static VkResult QueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR presentInfo) => QueuePresentKHR_1(queue, ref presentInfo);
	private delegate VkResult QueuePresentKHRDelegate_1(VkQueue queue, ref VkPresentInfoKHR presentInfo);
	private static QueuePresentKHRDelegate_1 QueuePresentKHR_1;
	private static IntPtr QueuePresentKHRPointer;
	public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, propertyCount, properties);
	private delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPropertiesKHR_0;
	public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_1(physicalDevice, ref propertyCount, properties);
	private delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPropertiesKHR_1;
	private static IntPtr GetPhysicalDeviceDisplayPropertiesKHRPointer;
	public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, propertyCount, properties);
	private delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPlanePropertiesKHR_0;
	public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_1(physicalDevice, ref propertyCount, properties);
	private delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPlanePropertiesKHR_1;
	private static IntPtr GetPhysicalDeviceDisplayPlanePropertiesKHRPointer;
	public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, displayCount, displays);
	private delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays);
	private static GetDisplayPlaneSupportedDisplaysKHRDelegate_0 GetDisplayPlaneSupportedDisplaysKHR_0;
	public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_1(physicalDevice, planeIndex, ref displayCount, displays);
	private delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_1(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays);
	private static GetDisplayPlaneSupportedDisplaysKHRDelegate_1 GetDisplayPlaneSupportedDisplaysKHR_1;
	private static IntPtr GetDisplayPlaneSupportedDisplaysKHRPointer;
	public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_0(physicalDevice, display, propertyCount, properties);
	private delegate VkResult GetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
	private static GetDisplayModePropertiesKHRDelegate_0 GetDisplayModePropertiesKHR_0;
	public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_1(physicalDevice, display, ref propertyCount, properties);
	private delegate VkResult GetDisplayModePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
	private static GetDisplayModePropertiesKHRDelegate_1 GetDisplayModePropertiesKHR_1;
	private static IntPtr GetDisplayModePropertiesKHRPointer;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_0(physicalDevice, display, createInfo, allocator, out mode);
	private delegate VkResult CreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_0 CreateDisplayModeKHR_0;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_1(physicalDevice, display, createInfo, ref allocator, out mode);
	private delegate VkResult CreateDisplayModeKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_1 CreateDisplayModeKHR_1;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_2(physicalDevice, display, ref createInfo, allocator, out mode);
	private delegate VkResult CreateDisplayModeKHRDelegate_2(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_2 CreateDisplayModeKHR_2;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_3(physicalDevice, display, ref createInfo, ref allocator, out mode);
	private delegate VkResult CreateDisplayModeKHRDelegate_3(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_3 CreateDisplayModeKHR_3;
	private static IntPtr CreateDisplayModeKHRPointer;
	public static VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities) => GetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, out capabilities);
	private delegate VkResult GetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities);
	private static GetDisplayPlaneCapabilitiesKHRDelegate_0 GetDisplayPlaneCapabilitiesKHR_0;
	private static IntPtr GetDisplayPlaneCapabilitiesKHRPointer;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_0 CreateDisplayPlaneSurfaceKHR_0;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_1(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_1 CreateDisplayPlaneSurfaceKHR_1;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_2(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_2 CreateDisplayPlaneSurfaceKHR_2;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_3(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_3 CreateDisplayPlaneSurfaceKHR_3;
	private static IntPtr CreateDisplayPlaneSurfaceKHRPointer;
	public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_0(device, swapchainCount, createInfos, allocator, out swapchains);
	private delegate VkResult CreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains);
	private static CreateSharedSwapchainsKHRDelegate_0 CreateSharedSwapchainsKHR_0;
	public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_1(device, swapchainCount, createInfos, ref allocator, out swapchains);
	private delegate VkResult CreateSharedSwapchainsKHRDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains);
	private static CreateSharedSwapchainsKHRDelegate_1 CreateSharedSwapchainsKHR_1;
	private static IntPtr CreateSharedSwapchainsKHRPointer;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_0 CreateXlibSurfaceKHR_0;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateXlibSurfaceKHRDelegate_1(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_1 CreateXlibSurfaceKHR_1;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateXlibSurfaceKHRDelegate_2(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_2 CreateXlibSurfaceKHR_2;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateXlibSurfaceKHRDelegate_3(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_3 CreateXlibSurfaceKHR_3;
	private static IntPtr CreateXlibSurfaceKHRPointer;
	public static VkBool32 GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID) => GetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
	private delegate VkBool32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID);
	private static GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 GetPhysicalDeviceXlibPresentationSupportKHR_0;
	private static IntPtr GetPhysicalDeviceXlibPresentationSupportKHRPointer;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateXcbSurfaceKHRDelegate_0(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_0 CreateXcbSurfaceKHR_0;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateXcbSurfaceKHRDelegate_1(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_1 CreateXcbSurfaceKHR_1;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateXcbSurfaceKHRDelegate_2(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_2 CreateXcbSurfaceKHR_2;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateXcbSurfaceKHRDelegate_3(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_3 CreateXcbSurfaceKHR_3;
	private static IntPtr CreateXcbSurfaceKHRPointer;
	public static VkBool32 GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id) => GetPhysicalDeviceXcbPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection, visual_id);
	private delegate VkBool32 GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id);
	private static GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0 GetPhysicalDeviceXcbPresentationSupportKHR_0;
	private static IntPtr GetPhysicalDeviceXcbPresentationSupportKHRPointer;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_0(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_0 CreateWaylandSurfaceKHR_0;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_1(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_1 CreateWaylandSurfaceKHR_1;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_2(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_2 CreateWaylandSurfaceKHR_2;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_3(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_3 CreateWaylandSurfaceKHR_3;
	private static IntPtr CreateWaylandSurfaceKHRPointer;
	public static VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display) => GetPhysicalDeviceWaylandPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, display);
	private delegate VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display);
	private static GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0 GetPhysicalDeviceWaylandPresentationSupportKHR_0;
	private static IntPtr GetPhysicalDeviceWaylandPresentationSupportKHRPointer;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_0 CreateAndroidSurfaceKHR_0;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_1(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_1 CreateAndroidSurfaceKHR_1;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_2(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_2 CreateAndroidSurfaceKHR_2;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_3(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_3 CreateAndroidSurfaceKHR_3;
	private static IntPtr CreateAndroidSurfaceKHRPointer;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_0 CreateWin32SurfaceKHR_0;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateWin32SurfaceKHRDelegate_1(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_1 CreateWin32SurfaceKHR_1;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateWin32SurfaceKHRDelegate_2(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_2 CreateWin32SurfaceKHR_2;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateWin32SurfaceKHRDelegate_3(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_3 CreateWin32SurfaceKHR_3;
	private static IntPtr CreateWin32SurfaceKHRPointer;
	public static VkBool32 GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex) => GetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
	private delegate VkBool32 GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
	private static GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0 GetPhysicalDeviceWin32PresentationSupportKHR_0;
	private static IntPtr GetPhysicalDeviceWin32PresentationSupportKHRPointer;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_0(instance, createInfo, allocator, out callback);
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_0 CreateDebugReportCallbackEXT_0;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_1(instance, createInfo, ref allocator, out callback);
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_1 CreateDebugReportCallbackEXT_1;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_2(instance, ref createInfo, allocator, out callback);
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_2(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_2 CreateDebugReportCallbackEXT_2;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_3(instance, ref createInfo, ref allocator, out callback);
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_3(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_3 CreateDebugReportCallbackEXT_3;
	private static IntPtr CreateDebugReportCallbackEXTPointer;
	public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator) => DestroyDebugReportCallbackEXT_0(instance, callback, allocator);
	private delegate void DestroyDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator);
	private static DestroyDebugReportCallbackEXTDelegate_0 DestroyDebugReportCallbackEXT_0;
	public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator) => DestroyDebugReportCallbackEXT_1(instance, callback, ref allocator);
	private delegate void DestroyDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator);
	private static DestroyDebugReportCallbackEXTDelegate_1 DestroyDebugReportCallbackEXT_1;
	private static IntPtr DestroyDebugReportCallbackEXTPointer;
	public static void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message) => DebugReportMessageEXT_0(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
	private delegate void DebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message);
	private static DebugReportMessageEXTDelegate_0 DebugReportMessageEXT_0;
	private static IntPtr DebugReportMessageEXTPointer;
	public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo) => DebugMarkerSetObjectTagEXT_0(device, tagInfo);
	private delegate VkResult DebugMarkerSetObjectTagEXTDelegate_0(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo);
	private static DebugMarkerSetObjectTagEXTDelegate_0 DebugMarkerSetObjectTagEXT_0;
	public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo) => DebugMarkerSetObjectTagEXT_1(device, ref tagInfo);
	private delegate VkResult DebugMarkerSetObjectTagEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo);
	private static DebugMarkerSetObjectTagEXTDelegate_1 DebugMarkerSetObjectTagEXT_1;
	private static IntPtr DebugMarkerSetObjectTagEXTPointer;
	public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo) => DebugMarkerSetObjectNameEXT_0(device, nameInfo);
	private delegate VkResult DebugMarkerSetObjectNameEXTDelegate_0(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo);
	private static DebugMarkerSetObjectNameEXTDelegate_0 DebugMarkerSetObjectNameEXT_0;
	public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo) => DebugMarkerSetObjectNameEXT_1(device, ref nameInfo);
	private delegate VkResult DebugMarkerSetObjectNameEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo);
	private static DebugMarkerSetObjectNameEXTDelegate_1 DebugMarkerSetObjectNameEXT_1;
	private static IntPtr DebugMarkerSetObjectNameEXTPointer;
	public static void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerBeginEXT_0(commandBuffer, markerInfo);
	private delegate void CommandDebugMarkerBeginEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
	private static CommandDebugMarkerBeginEXTDelegate_0 CommandDebugMarkerBeginEXT_0;
	public static void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerBeginEXT_1(commandBuffer, ref markerInfo);
	private delegate void CommandDebugMarkerBeginEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
	private static CommandDebugMarkerBeginEXTDelegate_1 CommandDebugMarkerBeginEXT_1;
	private static IntPtr CommandDebugMarkerBeginEXTPointer;
	public static void CommandDebugMarkerEndEXT(VkCommandBuffer commandBuffer) => CommandDebugMarkerEndEXT_0(commandBuffer);
	private delegate void CommandDebugMarkerEndEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandDebugMarkerEndEXTDelegate_0 CommandDebugMarkerEndEXT_0;
	private static IntPtr CommandDebugMarkerEndEXTPointer;
	public static void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerInsertEXT_0(commandBuffer, markerInfo);
	private delegate void CommandDebugMarkerInsertEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
	private static CommandDebugMarkerInsertEXTDelegate_0 CommandDebugMarkerInsertEXT_0;
	public static void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerInsertEXT_1(commandBuffer, ref markerInfo);
	private delegate void CommandDebugMarkerInsertEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
	private static CommandDebugMarkerInsertEXTDelegate_1 CommandDebugMarkerInsertEXT_1;
	private static IntPtr CommandDebugMarkerInsertEXTPointer;
	public static void CommandDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndirectCountAMDDelegate_0 CommandDrawIndirectCountAMD_0;
	private static IntPtr CommandDrawIndirectCountAMDPointer;
	public static void CommandDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndexedIndirectCountAMDDelegate_0 CommandDrawIndexedIndirectCountAMD_0;
	private static IntPtr CommandDrawIndexedIndirectCountAMDPointer;
	public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info) => GetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, infoSize, info);
	private delegate VkResult GetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info);
	private static GetShaderInfoAMDDelegate_0 GetShaderInfoAMD_0;
	public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info) => GetShaderInfoAMD_1(device, pipeline, shaderStage, infoType, ref infoSize, info);
	private delegate VkResult GetShaderInfoAMDDelegate_1(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info);
	private static GetShaderInfoAMDDelegate_1 GetShaderInfoAMD_1;
	private static IntPtr GetShaderInfoAMDPointer;
	public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties) => GetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out externalImageFormatProperties);
	private delegate VkResult GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties);
	private static GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 GetPhysicalDeviceExternalImageFormatPropertiesNV_0;
	private static IntPtr GetPhysicalDeviceExternalImageFormatPropertiesNVPointer;
	public static VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle) => GetMemoryWin32HandleNV_0(device, memory, handleType, out handle);
	private delegate VkResult GetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle);
	private static GetMemoryWin32HandleNVDelegate_0 GetMemoryWin32HandleNV_0;
	private static IntPtr GetMemoryWin32HandleNVPointer;
	public static void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2KHR features) => GetPhysicalDeviceFeatures2KHR_0(physicalDevice, out features);
	private delegate void GetPhysicalDeviceFeatures2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2KHR features);
	private static GetPhysicalDeviceFeatures2KHRDelegate_0 GetPhysicalDeviceFeatures2KHR_0;
	private static IntPtr GetPhysicalDeviceFeatures2KHRPointer;
	public static void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2KHR properties) => GetPhysicalDeviceProperties2KHR_0(physicalDevice, out properties);
	private delegate void GetPhysicalDeviceProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2KHR properties);
	private static GetPhysicalDeviceProperties2KHRDelegate_0 GetPhysicalDeviceProperties2KHR_0;
	private static IntPtr GetPhysicalDeviceProperties2KHRPointer;
	public static void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2KHR formatProperties) => GetPhysicalDeviceFormatProperties2KHR_0(physicalDevice, format, out formatProperties);
	private delegate void GetPhysicalDeviceFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2KHR formatProperties);
	private static GetPhysicalDeviceFormatProperties2KHRDelegate_0 GetPhysicalDeviceFormatProperties2KHR_0;
	private static IntPtr GetPhysicalDeviceFormatProperties2KHRPointer;
	public static VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2KHR_0(physicalDevice, imageFormatInfo, out imageFormatProperties);
	private delegate VkResult GetPhysicalDeviceImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceImageFormatProperties2KHR_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2KHR imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2KHR_1(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
	private delegate VkResult GetPhysicalDeviceImageFormatProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2KHR imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2KHRDelegate_1 GetPhysicalDeviceImageFormatProperties2KHR_1;
	private static IntPtr GetPhysicalDeviceImageFormatProperties2KHRPointer;
	public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2KHR_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0 GetPhysicalDeviceQueueFamilyProperties2KHR_0;
	public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2KHR_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1 GetPhysicalDeviceQueueFamilyProperties2KHR_1;
	private static IntPtr GetPhysicalDeviceQueueFamilyProperties2KHRPointer;
	public static void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2KHR memoryProperties) => GetPhysicalDeviceMemoryProperties2KHR_0(physicalDevice, out memoryProperties);
	private delegate void GetPhysicalDeviceMemoryProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2KHR memoryProperties);
	private static GetPhysicalDeviceMemoryProperties2KHRDelegate_0 GetPhysicalDeviceMemoryProperties2KHR_0;
	private static IntPtr GetPhysicalDeviceMemoryProperties2KHRPointer;
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_0(physicalDevice, formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceSparseImageFormatProperties2KHR_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_1(physicalDevice, formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1 GetPhysicalDeviceSparseImageFormatProperties2KHR_1;
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_2(physicalDevice, ref formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2 GetPhysicalDeviceSparseImageFormatProperties2KHR_2;
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_3(physicalDevice, ref formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3 GetPhysicalDeviceSparseImageFormatProperties2KHR_3;
	private static IntPtr GetPhysicalDeviceSparseImageFormatProperties2KHRPointer;
	public static void GetDeviceGroupPeerMemoryFeaturesKHX(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlagsKHX peerMemoryFeatures) => GetDeviceGroupPeerMemoryFeaturesKHX_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out peerMemoryFeatures);
	private delegate void GetDeviceGroupPeerMemoryFeaturesKHXDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlagsKHX peerMemoryFeatures);
	private static GetDeviceGroupPeerMemoryFeaturesKHXDelegate_0 GetDeviceGroupPeerMemoryFeaturesKHX_0;
	private static IntPtr GetDeviceGroupPeerMemoryFeaturesKHXPointer;
	public static void CommandSetDeviceMaskKHX(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMaskKHX_0(commandBuffer, deviceMask);
	private delegate void CommandSetDeviceMaskKHXDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static CommandSetDeviceMaskKHXDelegate_0 CommandSetDeviceMaskKHX_0;
	private static IntPtr CommandSetDeviceMaskKHXPointer;
	public static void CommandDispatchBaseKHX(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBaseKHX_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchBaseKHXDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static CommandDispatchBaseKHXDelegate_0 CommandDispatchBaseKHX_0;
	private static IntPtr CommandDispatchBaseKHXPointer;
	public static VkResult GetDeviceGroupPresentCapabilitiesKHX(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHX deviceGroupPresentCapabilities) => GetDeviceGroupPresentCapabilitiesKHX_0(device, out deviceGroupPresentCapabilities);
	private delegate VkResult GetDeviceGroupPresentCapabilitiesKHXDelegate_0(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHX deviceGroupPresentCapabilities);
	private static GetDeviceGroupPresentCapabilitiesKHXDelegate_0 GetDeviceGroupPresentCapabilitiesKHX_0;
	private static IntPtr GetDeviceGroupPresentCapabilitiesKHXPointer;
	public static VkResult GetDeviceGroupSurfacePresentModesKHX(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHX modes) => GetDeviceGroupSurfacePresentModesKHX_0(device, surface, out modes);
	private delegate VkResult GetDeviceGroupSurfacePresentModesKHXDelegate_0(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHX modes);
	private static GetDeviceGroupSurfacePresentModesKHXDelegate_0 GetDeviceGroupSurfacePresentModesKHX_0;
	private static IntPtr GetDeviceGroupSurfacePresentModesKHXPointer;
	public static VkResult GetPhysicalDevicePresentRectanglesKHX(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHX_0(physicalDevice, surface, rectCount, rects);
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHXDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects);
	private static GetPhysicalDevicePresentRectanglesKHXDelegate_0 GetPhysicalDevicePresentRectanglesKHX_0;
	public static VkResult GetPhysicalDevicePresentRectanglesKHX(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHX_1(physicalDevice, surface, ref rectCount, rects);
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHXDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects);
	private static GetPhysicalDevicePresentRectanglesKHXDelegate_1 GetPhysicalDevicePresentRectanglesKHX_1;
	private static IntPtr GetPhysicalDevicePresentRectanglesKHXPointer;
	public static VkResult AcquireNextImage2KHX(VkDevice device, VkAcquireNextImageInfoKHX* acquireInfo, out uint imageIndex) => AcquireNextImage2KHX_0(device, acquireInfo, out imageIndex);
	private delegate VkResult AcquireNextImage2KHXDelegate_0(VkDevice device, VkAcquireNextImageInfoKHX* acquireInfo, out uint imageIndex);
	private static AcquireNextImage2KHXDelegate_0 AcquireNextImage2KHX_0;
	public static VkResult AcquireNextImage2KHX(VkDevice device, ref VkAcquireNextImageInfoKHX acquireInfo, out uint imageIndex) => AcquireNextImage2KHX_1(device, ref acquireInfo, out imageIndex);
	private delegate VkResult AcquireNextImage2KHXDelegate_1(VkDevice device, ref VkAcquireNextImageInfoKHX acquireInfo, out uint imageIndex);
	private static AcquireNextImage2KHXDelegate_1 AcquireNextImage2KHX_1;
	private static IntPtr AcquireNextImage2KHXPointer;
	public static VkResult CreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateViSurfaceNN_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateViSurfaceNNDelegate_0(VkInstance instance, VkViSurfaceCreateInfoNN* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateViSurfaceNNDelegate_0 CreateViSurfaceNN_0;
	public static VkResult CreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateViSurfaceNN_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateViSurfaceNNDelegate_1(VkInstance instance, VkViSurfaceCreateInfoNN* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateViSurfaceNNDelegate_1 CreateViSurfaceNN_1;
	public static VkResult CreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateViSurfaceNN_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateViSurfaceNNDelegate_2(VkInstance instance, ref VkViSurfaceCreateInfoNN createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateViSurfaceNNDelegate_2 CreateViSurfaceNN_2;
	public static VkResult CreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateViSurfaceNN_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateViSurfaceNNDelegate_3(VkInstance instance, ref VkViSurfaceCreateInfoNN createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateViSurfaceNNDelegate_3 CreateViSurfaceNN_3;
	private static IntPtr CreateViSurfaceNNPointer;
	public static void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags) => TrimCommandPoolKHR_0(device, commandPool, flags);
	private delegate void TrimCommandPoolKHRDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags);
	private static TrimCommandPoolKHRDelegate_0 TrimCommandPoolKHR_0;
	private static IntPtr TrimCommandPoolKHRPointer;
	public static VkResult EnumeratePhysicalDeviceGroupsKHX(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHX[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroupsKHX_0(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
	private delegate VkResult EnumeratePhysicalDeviceGroupsKHXDelegate_0(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHX[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsKHXDelegate_0 EnumeratePhysicalDeviceGroupsKHX_0;
	public static VkResult EnumeratePhysicalDeviceGroupsKHX(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHX[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroupsKHX_1(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
	private delegate VkResult EnumeratePhysicalDeviceGroupsKHXDelegate_1(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHX[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsKHXDelegate_1 EnumeratePhysicalDeviceGroupsKHX_1;
	private static IntPtr EnumeratePhysicalDeviceGroupsKHXPointer;
	public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties) => GetPhysicalDeviceExternalBufferPropertiesKHR_0(physicalDevice, externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0 GetPhysicalDeviceExternalBufferPropertiesKHR_0;
	public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfoKHR externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties) => GetPhysicalDeviceExternalBufferPropertiesKHR_1(physicalDevice, ref externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfoKHR externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1 GetPhysicalDeviceExternalBufferPropertiesKHR_1;
	private static IntPtr GetPhysicalDeviceExternalBufferPropertiesKHRPointer;
	public static VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	private delegate VkResult GetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetMemoryWin32HandleKHRDelegate_0 GetMemoryWin32HandleKHR_0;
	public static VkResult GetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	private delegate VkResult GetMemoryWin32HandleKHRDelegate_1(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetMemoryWin32HandleKHRDelegate_1 GetMemoryWin32HandleKHR_1;
	private static IntPtr GetMemoryWin32HandleKHRPointer;
	public static VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties) => GetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, out memoryWin32HandleProperties);
	private delegate VkResult GetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties);
	private static GetMemoryWin32HandlePropertiesKHRDelegate_0 GetMemoryWin32HandlePropertiesKHR_0;
	private static IntPtr GetMemoryWin32HandlePropertiesKHRPointer;
	public static VkResult GetMemoryFileDescriptorKHR(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetMemoryFileDescriptorKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetMemoryFileDescriptorKHRDelegate_0 GetMemoryFileDescriptorKHR_0;
	public static VkResult GetMemoryFileDescriptorKHR(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetMemoryFileDescriptorKHRDelegate_1(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetMemoryFileDescriptorKHRDelegate_1 GetMemoryFileDescriptorKHR_1;
	private static IntPtr GetMemoryFileDescriptorKHRPointer;
	public static VkResult GetMemoryFileDescriptorPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties) => GetMemoryFileDescriptorPropertiesKHR_0(device, handleType, fileDescriptor, out memoryFileDescriptorProperties);
	private delegate VkResult GetMemoryFileDescriptorPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties);
	private static GetMemoryFileDescriptorPropertiesKHRDelegate_0 GetMemoryFileDescriptorPropertiesKHR_0;
	private static IntPtr GetMemoryFileDescriptorPropertiesKHRPointer;
	public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphorePropertiesKHR_0(physicalDevice, externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0 GetPhysicalDeviceExternalSemaphorePropertiesKHR_0;
	public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfoKHR externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphorePropertiesKHR_1(physicalDevice, ref externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfoKHR externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1 GetPhysicalDeviceExternalSemaphorePropertiesKHR_1;
	private static IntPtr GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer;
	public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_0(device, importSemaphoreWin32HandleInfo);
	private delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo);
	private static ImportSemaphoreWin32HandleKHRDelegate_0 ImportSemaphoreWin32HandleKHR_0;
	public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_1(device, ref importSemaphoreWin32HandleInfo);
	private delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo);
	private static ImportSemaphoreWin32HandleKHRDelegate_1 ImportSemaphoreWin32HandleKHR_1;
	private static IntPtr ImportSemaphoreWin32HandleKHRPointer;
	public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	private delegate VkResult GetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetSemaphoreWin32HandleKHRDelegate_0 GetSemaphoreWin32HandleKHR_0;
	public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	private delegate VkResult GetSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetSemaphoreWin32HandleKHRDelegate_1 GetSemaphoreWin32HandleKHR_1;
	private static IntPtr GetSemaphoreWin32HandleKHRPointer;
	public static VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_0(device, importSemaphoreFileDescriptorInfo);
	private delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo);
	private static ImportSemaphoreFileDescriptorKHRDelegate_0 ImportSemaphoreFileDescriptorKHR_0;
	public static VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_1(device, ref importSemaphoreFileDescriptorInfo);
	private delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo);
	private static ImportSemaphoreFileDescriptorKHRDelegate_1 ImportSemaphoreFileDescriptorKHR_1;
	private static IntPtr ImportSemaphoreFileDescriptorKHRPointer;
	public static VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetSemaphoreFileDescriptorKHRDelegate_0 GetSemaphoreFileDescriptorKHR_0;
	public static VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetSemaphoreFileDescriptorKHRDelegate_1 GetSemaphoreFileDescriptorKHR_1;
	private static IntPtr GetSemaphoreFileDescriptorKHRPointer;
	public static void CommandPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites) => CommandPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, descriptorWrites);
	private delegate void CommandPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites);
	private static CommandPushDescriptorSetKHRDelegate_0 CommandPushDescriptorSetKHR_0;
	private static IntPtr CommandPushDescriptorSetKHRPointer;
	public static VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_0(device, createInfo, allocator, out descriptorUpdateTemplate);
	private delegate VkResult CreateDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_0 CreateDescriptorUpdateTemplateKHR_0;
	public static VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_1(device, createInfo, ref allocator, out descriptorUpdateTemplate);
	private delegate VkResult CreateDescriptorUpdateTemplateKHRDelegate_1(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_1 CreateDescriptorUpdateTemplateKHR_1;
	public static VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_2(device, ref createInfo, allocator, out descriptorUpdateTemplate);
	private delegate VkResult CreateDescriptorUpdateTemplateKHRDelegate_2(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_2 CreateDescriptorUpdateTemplateKHR_2;
	public static VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_3(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
	private delegate VkResult CreateDescriptorUpdateTemplateKHRDelegate_3(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_3 CreateDescriptorUpdateTemplateKHR_3;
	private static IntPtr CreateDescriptorUpdateTemplateKHRPointer;
	public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* allocator) => DestroyDescriptorUpdateTemplateKHR_0(device, descriptorUpdateTemplate, allocator);
	private delegate void DestroyDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorUpdateTemplateKHRDelegate_0 DestroyDescriptorUpdateTemplateKHR_0;
	public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, ref VkAllocationCallbacks allocator) => DestroyDescriptorUpdateTemplateKHR_1(device, descriptorUpdateTemplate, ref allocator);
	private delegate void DestroyDescriptorUpdateTemplateKHRDelegate_1(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorUpdateTemplateKHRDelegate_1 DestroyDescriptorUpdateTemplateKHR_1;
	private static IntPtr DestroyDescriptorUpdateTemplateKHRPointer;
	public static void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* data) => UpdateDescriptorSetWithTemplateKHR_0(device, descriptorSet, descriptorUpdateTemplate, data);
	private delegate void UpdateDescriptorSetWithTemplateKHRDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* data);
	private static UpdateDescriptorSetWithTemplateKHRDelegate_0 UpdateDescriptorSetWithTemplateKHR_0;
	private static IntPtr UpdateDescriptorSetWithTemplateKHRPointer;
	public static void CommandPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data) => CommandPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, data);
	private delegate void CommandPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data);
	private static CommandPushDescriptorSetWithTemplateKHRDelegate_0 CommandPushDescriptorSetWithTemplateKHR_0;
	private static IntPtr CommandPushDescriptorSetWithTemplateKHRPointer;
	public static void CommandProcessCommandsNVX(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* processCommandsInfo) => CommandProcessCommandsNVX_0(commandBuffer, processCommandsInfo);
	private delegate void CommandProcessCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* processCommandsInfo);
	private static CommandProcessCommandsNVXDelegate_0 CommandProcessCommandsNVX_0;
	public static void CommandProcessCommandsNVX(VkCommandBuffer commandBuffer, ref VkCmdProcessCommandsInfoNVX processCommandsInfo) => CommandProcessCommandsNVX_1(commandBuffer, ref processCommandsInfo);
	private delegate void CommandProcessCommandsNVXDelegate_1(VkCommandBuffer commandBuffer, ref VkCmdProcessCommandsInfoNVX processCommandsInfo);
	private static CommandProcessCommandsNVXDelegate_1 CommandProcessCommandsNVX_1;
	private static IntPtr CommandProcessCommandsNVXPointer;
	public static void CommandReserveSpaceForCommandsNVX(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* reserveSpaceInfo) => CommandReserveSpaceForCommandsNVX_0(commandBuffer, reserveSpaceInfo);
	private delegate void CommandReserveSpaceForCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* reserveSpaceInfo);
	private static CommandReserveSpaceForCommandsNVXDelegate_0 CommandReserveSpaceForCommandsNVX_0;
	public static void CommandReserveSpaceForCommandsNVX(VkCommandBuffer commandBuffer, ref VkCmdReserveSpaceForCommandsInfoNVX reserveSpaceInfo) => CommandReserveSpaceForCommandsNVX_1(commandBuffer, ref reserveSpaceInfo);
	private delegate void CommandReserveSpaceForCommandsNVXDelegate_1(VkCommandBuffer commandBuffer, ref VkCmdReserveSpaceForCommandsInfoNVX reserveSpaceInfo);
	private static CommandReserveSpaceForCommandsNVXDelegate_1 CommandReserveSpaceForCommandsNVX_1;
	private static IntPtr CommandReserveSpaceForCommandsNVXPointer;
	public static VkResult CreateIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout) => CreateIndirectCommandsLayoutNVX_0(device, createInfo, allocator, out indirectCommandsLayout);
	private delegate VkResult CreateIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVXDelegate_0 CreateIndirectCommandsLayoutNVX_0;
	public static VkResult CreateIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout) => CreateIndirectCommandsLayoutNVX_1(device, createInfo, ref allocator, out indirectCommandsLayout);
	private delegate VkResult CreateIndirectCommandsLayoutNVXDelegate_1(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVXDelegate_1 CreateIndirectCommandsLayoutNVX_1;
	public static VkResult CreateIndirectCommandsLayoutNVX(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout) => CreateIndirectCommandsLayoutNVX_2(device, ref createInfo, allocator, out indirectCommandsLayout);
	private delegate VkResult CreateIndirectCommandsLayoutNVXDelegate_2(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVXDelegate_2 CreateIndirectCommandsLayoutNVX_2;
	public static VkResult CreateIndirectCommandsLayoutNVX(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout) => CreateIndirectCommandsLayoutNVX_3(device, ref createInfo, ref allocator, out indirectCommandsLayout);
	private delegate VkResult CreateIndirectCommandsLayoutNVXDelegate_3(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNVX indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVXDelegate_3 CreateIndirectCommandsLayoutNVX_3;
	private static IntPtr CreateIndirectCommandsLayoutNVXPointer;
	public static void DestroyIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* allocator) => DestroyIndirectCommandsLayoutNVX_0(device, indirectCommandsLayout, allocator);
	private delegate void DestroyIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* allocator);
	private static DestroyIndirectCommandsLayoutNVXDelegate_0 DestroyIndirectCommandsLayoutNVX_0;
	public static void DestroyIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, ref VkAllocationCallbacks allocator) => DestroyIndirectCommandsLayoutNVX_1(device, indirectCommandsLayout, ref allocator);
	private delegate void DestroyIndirectCommandsLayoutNVXDelegate_1(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, ref VkAllocationCallbacks allocator);
	private static DestroyIndirectCommandsLayoutNVXDelegate_1 DestroyIndirectCommandsLayoutNVX_1;
	private static IntPtr DestroyIndirectCommandsLayoutNVXPointer;
	public static VkResult CreateObjectTableNVX(VkDevice device, VkObjectTableCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkObjectTableNVX objectTable) => CreateObjectTableNVX_0(device, createInfo, allocator, out objectTable);
	private delegate VkResult CreateObjectTableNVXDelegate_0(VkDevice device, VkObjectTableCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkObjectTableNVX objectTable);
	private static CreateObjectTableNVXDelegate_0 CreateObjectTableNVX_0;
	public static VkResult CreateObjectTableNVX(VkDevice device, VkObjectTableCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkObjectTableNVX objectTable) => CreateObjectTableNVX_1(device, createInfo, ref allocator, out objectTable);
	private delegate VkResult CreateObjectTableNVXDelegate_1(VkDevice device, VkObjectTableCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkObjectTableNVX objectTable);
	private static CreateObjectTableNVXDelegate_1 CreateObjectTableNVX_1;
	public static VkResult CreateObjectTableNVX(VkDevice device, ref VkObjectTableCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkObjectTableNVX objectTable) => CreateObjectTableNVX_2(device, ref createInfo, allocator, out objectTable);
	private delegate VkResult CreateObjectTableNVXDelegate_2(VkDevice device, ref VkObjectTableCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkObjectTableNVX objectTable);
	private static CreateObjectTableNVXDelegate_2 CreateObjectTableNVX_2;
	public static VkResult CreateObjectTableNVX(VkDevice device, ref VkObjectTableCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkObjectTableNVX objectTable) => CreateObjectTableNVX_3(device, ref createInfo, ref allocator, out objectTable);
	private delegate VkResult CreateObjectTableNVXDelegate_3(VkDevice device, ref VkObjectTableCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkObjectTableNVX objectTable);
	private static CreateObjectTableNVXDelegate_3 CreateObjectTableNVX_3;
	private static IntPtr CreateObjectTableNVXPointer;
	public static void DestroyObjectTableNVX(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* allocator) => DestroyObjectTableNVX_0(device, objectTable, allocator);
	private delegate void DestroyObjectTableNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* allocator);
	private static DestroyObjectTableNVXDelegate_0 DestroyObjectTableNVX_0;
	public static void DestroyObjectTableNVX(VkDevice device, VkObjectTableNVX objectTable, ref VkAllocationCallbacks allocator) => DestroyObjectTableNVX_1(device, objectTable, ref allocator);
	private delegate void DestroyObjectTableNVXDelegate_1(VkDevice device, VkObjectTableNVX objectTable, ref VkAllocationCallbacks allocator);
	private static DestroyObjectTableNVXDelegate_1 DestroyObjectTableNVX_1;
	private static IntPtr DestroyObjectTableNVXPointer;
	public static VkResult RegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** objectTableEntries, uint* objectIndices) => RegisterObjectsNVX_0(device, objectTable, objectCount, objectTableEntries, objectIndices);
	private delegate VkResult RegisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** objectTableEntries, uint* objectIndices);
	private static RegisterObjectsNVXDelegate_0 RegisterObjectsNVX_0;
	public static VkResult RegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** objectTableEntries, ref uint objectIndices) => RegisterObjectsNVX_1(device, objectTable, objectCount, objectTableEntries, ref objectIndices);
	private delegate VkResult RegisterObjectsNVXDelegate_1(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** objectTableEntries, ref uint objectIndices);
	private static RegisterObjectsNVXDelegate_1 RegisterObjectsNVX_1;
	public static VkResult RegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectTableEntryNVX objectTableEntries, uint* objectIndices) => RegisterObjectsNVX_2(device, objectTable, objectCount, ref objectTableEntries, objectIndices);
	private delegate VkResult RegisterObjectsNVXDelegate_2(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectTableEntryNVX objectTableEntries, uint* objectIndices);
	private static RegisterObjectsNVXDelegate_2 RegisterObjectsNVX_2;
	public static VkResult RegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectTableEntryNVX objectTableEntries, ref uint objectIndices) => RegisterObjectsNVX_3(device, objectTable, objectCount, ref objectTableEntries, ref objectIndices);
	private delegate VkResult RegisterObjectsNVXDelegate_3(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectTableEntryNVX objectTableEntries, ref uint objectIndices);
	private static RegisterObjectsNVXDelegate_3 RegisterObjectsNVX_3;
	private static IntPtr RegisterObjectsNVXPointer;
	public static VkResult UnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* objectEntryTypes, uint* objectIndices) => UnregisterObjectsNVX_0(device, objectTable, objectCount, objectEntryTypes, objectIndices);
	private delegate VkResult UnregisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* objectEntryTypes, uint* objectIndices);
	private static UnregisterObjectsNVXDelegate_0 UnregisterObjectsNVX_0;
	public static VkResult UnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* objectEntryTypes, ref uint objectIndices) => UnregisterObjectsNVX_1(device, objectTable, objectCount, objectEntryTypes, ref objectIndices);
	private delegate VkResult UnregisterObjectsNVXDelegate_1(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* objectEntryTypes, ref uint objectIndices);
	private static UnregisterObjectsNVXDelegate_1 UnregisterObjectsNVX_1;
	public static VkResult UnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectEntryTypeNVX objectEntryTypes, uint* objectIndices) => UnregisterObjectsNVX_2(device, objectTable, objectCount, ref objectEntryTypes, objectIndices);
	private delegate VkResult UnregisterObjectsNVXDelegate_2(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectEntryTypeNVX objectEntryTypes, uint* objectIndices);
	private static UnregisterObjectsNVXDelegate_2 UnregisterObjectsNVX_2;
	public static VkResult UnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectEntryTypeNVX objectEntryTypes, ref uint objectIndices) => UnregisterObjectsNVX_3(device, objectTable, objectCount, ref objectEntryTypes, ref objectIndices);
	private delegate VkResult UnregisterObjectsNVXDelegate_3(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, ref VkObjectEntryTypeNVX objectEntryTypes, ref uint objectIndices);
	private static UnregisterObjectsNVXDelegate_3 UnregisterObjectsNVX_3;
	private static IntPtr UnregisterObjectsNVXPointer;
	public static void GetPhysicalDeviceGeneratedCommandsPropertiesNVX(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* features, out VkDeviceGeneratedCommandsLimitsNVX limits) => GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0(physicalDevice, features, out limits);
	private delegate void GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* features, out VkDeviceGeneratedCommandsLimitsNVX limits);
	private static GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0 GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0;
	public static void GetPhysicalDeviceGeneratedCommandsPropertiesNVX(VkPhysicalDevice physicalDevice, ref VkDeviceGeneratedCommandsFeaturesNVX features, out VkDeviceGeneratedCommandsLimitsNVX limits) => GetPhysicalDeviceGeneratedCommandsPropertiesNVX_1(physicalDevice, ref features, out limits);
	private delegate void GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_1(VkPhysicalDevice physicalDevice, ref VkDeviceGeneratedCommandsFeaturesNVX features, out VkDeviceGeneratedCommandsLimitsNVX limits);
	private static GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_1 GetPhysicalDeviceGeneratedCommandsPropertiesNVX_1;
	private static IntPtr GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer;
	public static void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings) => CommandSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, viewportWScalings);
	private delegate void CommandSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings);
	private static CommandSetViewportWScalingNVDelegate_0 CommandSetViewportWScalingNV_0;
	public static void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings) => CommandSetViewportWScalingNV_1(commandBuffer, firstViewport, viewportCount, ref viewportWScalings);
	private delegate void CommandSetViewportWScalingNVDelegate_1(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings);
	private static CommandSetViewportWScalingNVDelegate_1 CommandSetViewportWScalingNV_1;
	private static IntPtr CommandSetViewportWScalingNVPointer;
	public static VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => ReleaseDisplayEXT_0(physicalDevice, display);
	private delegate VkResult ReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static ReleaseDisplayEXTDelegate_0 ReleaseDisplayEXT_0;
	private static IntPtr ReleaseDisplayEXTPointer;
	public static VkResult AcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, void* dpy, VkDisplayKHR display) => AcquireXlibDisplayEXT_0(physicalDevice, dpy, display);
	private delegate VkResult AcquireXlibDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, void* dpy, VkDisplayKHR display);
	private static AcquireXlibDisplayEXTDelegate_0 AcquireXlibDisplayEXT_0;
	private static IntPtr AcquireXlibDisplayEXTPointer;
	public static VkResult GetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, void* dpy, IntPtr rrOutput, out VkDisplayKHR display) => GetRandROutputDisplayEXT_0(physicalDevice, dpy, rrOutput, out display);
	private delegate VkResult GetRandROutputDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, void* dpy, IntPtr rrOutput, out VkDisplayKHR display);
	private static GetRandROutputDisplayEXTDelegate_0 GetRandROutputDisplayEXT_0;
	private static IntPtr GetRandROutputDisplayEXTPointer;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, out surfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0 GetPhysicalDeviceSurfaceCapabilities2EXT_0;
	private static IntPtr GetPhysicalDeviceSurfaceCapabilities2EXTPointer;
	public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo) => DisplayPowerControlEXT_0(device, display, displayPowerInfo);
	private delegate VkResult DisplayPowerControlEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo);
	private static DisplayPowerControlEXTDelegate_0 DisplayPowerControlEXT_0;
	public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo) => DisplayPowerControlEXT_1(device, display, ref displayPowerInfo);
	private delegate VkResult DisplayPowerControlEXTDelegate_1(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo);
	private static DisplayPowerControlEXTDelegate_1 DisplayPowerControlEXT_1;
	private static IntPtr DisplayPowerControlEXTPointer;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_0(device, deviceEventInfo, allocator, fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_0(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_0 RegisterDeviceEventEXT_0;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_1(device, deviceEventInfo, allocator, ref fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_1(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_1 RegisterDeviceEventEXT_1;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_2(device, deviceEventInfo, ref allocator, fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_2(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_2 RegisterDeviceEventEXT_2;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_3(device, deviceEventInfo, ref allocator, ref fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_3(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_3 RegisterDeviceEventEXT_3;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_4(device, ref deviceEventInfo, allocator, fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_4(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_4 RegisterDeviceEventEXT_4;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_5(device, ref deviceEventInfo, allocator, ref fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_5(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_5 RegisterDeviceEventEXT_5;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_6(device, ref deviceEventInfo, ref allocator, fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_6(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_6 RegisterDeviceEventEXT_6;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_7(device, ref deviceEventInfo, ref allocator, ref fence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_7(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_7 RegisterDeviceEventEXT_7;
	private static IntPtr RegisterDeviceEventEXTPointer;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_0(device, display, displayEventInfo, allocator, fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_0 RegisterDisplayEventEXT_0;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_1(device, display, displayEventInfo, allocator, ref fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_1(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_1 RegisterDisplayEventEXT_1;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_2(device, display, displayEventInfo, ref allocator, fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_2(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_2 RegisterDisplayEventEXT_2;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_3(device, display, displayEventInfo, ref allocator, ref fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_3(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_3 RegisterDisplayEventEXT_3;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_4(device, display, ref displayEventInfo, allocator, fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_4(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_4 RegisterDisplayEventEXT_4;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_5(device, display, ref displayEventInfo, allocator, ref fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_5(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_5 RegisterDisplayEventEXT_5;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_6(device, display, ref displayEventInfo, ref allocator, fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_6(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_6 RegisterDisplayEventEXT_6;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_7(device, display, ref displayEventInfo, ref allocator, ref fence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_7(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_7 RegisterDisplayEventEXT_7;
	private static IntPtr RegisterDisplayEventEXTPointer;
	public static VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue) => GetSwapchainCounterEXT_0(device, swapchain, counter, out counterValue);
	private delegate VkResult GetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue);
	private static GetSwapchainCounterEXTDelegate_0 GetSwapchainCounterEXT_0;
	private static IntPtr GetSwapchainCounterEXTPointer;
	public static VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties) => GetRefreshCycleDurationGOOGLE_0(device, swapchain, out displayTimingProperties);
	private delegate VkResult GetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties);
	private static GetRefreshCycleDurationGOOGLEDelegate_0 GetRefreshCycleDurationGOOGLE_0;
	private static IntPtr GetRefreshCycleDurationGOOGLEPointer;
	public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_0(device, swapchain, presentationTimingCount, presentationTimings);
	private delegate VkResult GetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
	private static GetPastPresentationTimingGOOGLEDelegate_0 GetPastPresentationTimingGOOGLE_0;
	public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_1(device, swapchain, ref presentationTimingCount, presentationTimings);
	private delegate VkResult GetPastPresentationTimingGOOGLEDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
	private static GetPastPresentationTimingGOOGLEDelegate_1 GetPastPresentationTimingGOOGLE_1;
	private static IntPtr GetPastPresentationTimingGOOGLEPointer;
	public static void CommandSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles) => CommandSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, discardRectangles);
	private delegate void CommandSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles);
	private static CommandSetDiscardRectangleEXTDelegate_0 CommandSetDiscardRectangleEXT_0;
	private static IntPtr CommandSetDiscardRectangleEXTPointer;
	public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata) => SetHdrMetadataEXT_0(device, swapchainCount, swapchains, metadata);
	private delegate void SetHdrMetadataEXTDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata);
	private static SetHdrMetadataEXTDelegate_0 SetHdrMetadataEXT_0;
	public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata) => SetHdrMetadataEXT_1(device, swapchainCount, swapchains, ref metadata);
	private delegate void SetHdrMetadataEXTDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata);
	private static SetHdrMetadataEXTDelegate_1 SetHdrMetadataEXT_1;
	private static IntPtr SetHdrMetadataEXTPointer;
	public static VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => GetSwapchainStatusKHR_0(device, swapchain);
	private delegate VkResult GetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static GetSwapchainStatusKHRDelegate_0 GetSwapchainStatusKHR_0;
	private static IntPtr GetSwapchainStatusKHRPointer;
	public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties) => GetPhysicalDeviceExternalFencePropertiesKHR_0(physicalDevice, externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0 GetPhysicalDeviceExternalFencePropertiesKHR_0;
	public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfoKHR externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties) => GetPhysicalDeviceExternalFencePropertiesKHR_1(physicalDevice, ref externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfoKHR externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1 GetPhysicalDeviceExternalFencePropertiesKHR_1;
	private static IntPtr GetPhysicalDeviceExternalFencePropertiesKHRPointer;
	public static VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_0(device, importFenceWin32HandleInfo);
	private delegate VkResult ImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo);
	private static ImportFenceWin32HandleKHRDelegate_0 ImportFenceWin32HandleKHR_0;
	public static VkResult ImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_1(device, ref importFenceWin32HandleInfo);
	private delegate VkResult ImportFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo);
	private static ImportFenceWin32HandleKHRDelegate_1 ImportFenceWin32HandleKHR_1;
	private static IntPtr ImportFenceWin32HandleKHRPointer;
	public static VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	private delegate VkResult GetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetFenceWin32HandleKHRDelegate_0 GetFenceWin32HandleKHR_0;
	public static VkResult GetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	private delegate VkResult GetFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetFenceWin32HandleKHRDelegate_1 GetFenceWin32HandleKHR_1;
	private static IntPtr GetFenceWin32HandleKHRPointer;
	public static VkResult ImportFenceFileDescriptorKHR(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_0(device, importFenceFileDescriptorInfo);
	private delegate VkResult ImportFenceFileDescriptorKHRDelegate_0(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo);
	private static ImportFenceFileDescriptorKHRDelegate_0 ImportFenceFileDescriptorKHR_0;
	public static VkResult ImportFenceFileDescriptorKHR(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_1(device, ref importFenceFileDescriptorInfo);
	private delegate VkResult ImportFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo);
	private static ImportFenceFileDescriptorKHRDelegate_1 ImportFenceFileDescriptorKHR_1;
	private static IntPtr ImportFenceFileDescriptorKHRPointer;
	public static VkResult GetFenceFileDescriptorKHR(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetFenceFileDescriptorKHRDelegate_0(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetFenceFileDescriptorKHRDelegate_0 GetFenceFileDescriptorKHR_0;
	public static VkResult GetFenceFileDescriptorKHR(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	private delegate VkResult GetFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetFenceFileDescriptorKHRDelegate_1 GetFenceFileDescriptorKHR_1;
	private static IntPtr GetFenceFileDescriptorKHRPointer;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, surfaceInfo, out surfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 GetPhysicalDeviceSurfaceCapabilities2KHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_1(physicalDevice, ref surfaceInfo, out surfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1 GetPhysicalDeviceSurfaceCapabilities2KHR_1;
	private static IntPtr GetPhysicalDeviceSurfaceCapabilities2KHRPointer;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, surfaceInfo, surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_0 GetPhysicalDeviceSurfaceFormats2KHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_1(physicalDevice, surfaceInfo, ref surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_1 GetPhysicalDeviceSurfaceFormats2KHR_1;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_2(physicalDevice, ref surfaceInfo, surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_2 GetPhysicalDeviceSurfaceFormats2KHR_2;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_3(physicalDevice, ref surfaceInfo, ref surfaceFormatCount, surfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_3 GetPhysicalDeviceSurfaceFormats2KHR_3;
	private static IntPtr GetPhysicalDeviceSurfaceFormats2KHRPointer;
	public static VkResult CreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateIOSSurfaceMVK_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateIOSSurfaceMVKDelegate_0(VkInstance instance, VkIOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateIOSSurfaceMVKDelegate_0 CreateIOSSurfaceMVK_0;
	public static VkResult CreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateIOSSurfaceMVK_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateIOSSurfaceMVKDelegate_1(VkInstance instance, VkIOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateIOSSurfaceMVKDelegate_1 CreateIOSSurfaceMVK_1;
	public static VkResult CreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateIOSSurfaceMVK_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateIOSSurfaceMVKDelegate_2(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateIOSSurfaceMVKDelegate_2 CreateIOSSurfaceMVK_2;
	public static VkResult CreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateIOSSurfaceMVK_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateIOSSurfaceMVKDelegate_3(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateIOSSurfaceMVKDelegate_3 CreateIOSSurfaceMVK_3;
	private static IntPtr CreateIOSSurfaceMVKPointer;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_0(instance, createInfo, allocator, out surface);
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_0 CreateMacOSSurfaceMVK_0;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_1(instance, createInfo, ref allocator, out surface);
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_1(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_1 CreateMacOSSurfaceMVK_1;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_2(instance, ref createInfo, allocator, out surface);
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_2(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_2 CreateMacOSSurfaceMVK_2;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_3(instance, ref createInfo, ref allocator, out surface);
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_3(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_3 CreateMacOSSurfaceMVK_3;
	private static IntPtr CreateMacOSSurfaceMVKPointer;
	public static void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo) => CommandSetSampleLocationsEXT_0(commandBuffer, sampleLocationsInfo);
	private delegate void CommandSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo);
	private static CommandSetSampleLocationsEXTDelegate_0 CommandSetSampleLocationsEXT_0;
	public static void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo) => CommandSetSampleLocationsEXT_1(commandBuffer, ref sampleLocationsInfo);
	private delegate void CommandSetSampleLocationsEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo);
	private static CommandSetSampleLocationsEXTDelegate_1 CommandSetSampleLocationsEXT_1;
	private static IntPtr CommandSetSampleLocationsEXTPointer;
	public static void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties) => GetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, out multisampleProperties);
	private delegate void GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties);
	private static GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 GetPhysicalDeviceMultisamplePropertiesEXT_0;
	private static IntPtr GetPhysicalDeviceMultisamplePropertiesEXTPointer;
	public static void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements) => GetImageMemoryRequirements2KHR_0(device, info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetImageMemoryRequirements2KHRDelegate_0 GetImageMemoryRequirements2KHR_0;
	public static void GetImageMemoryRequirements2KHR(VkDevice device, ref VkImageMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements) => GetImageMemoryRequirements2KHR_1(device, ref info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2KHRDelegate_1(VkDevice device, ref VkImageMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetImageMemoryRequirements2KHRDelegate_1 GetImageMemoryRequirements2KHR_1;
	private static IntPtr GetImageMemoryRequirements2KHRPointer;
	public static void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements) => GetBufferMemoryRequirements2KHR_0(device, info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2KHRDelegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetBufferMemoryRequirements2KHRDelegate_0 GetBufferMemoryRequirements2KHR_0;
	public static void GetBufferMemoryRequirements2KHR(VkDevice device, ref VkBufferMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements) => GetBufferMemoryRequirements2KHR_1(device, ref info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2KHRDelegate_1(VkDevice device, ref VkBufferMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetBufferMemoryRequirements2KHRDelegate_1 GetBufferMemoryRequirements2KHR_1;
	private static IntPtr GetBufferMemoryRequirements2KHRPointer;
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_0 GetImageSparseMemoryRequirements2KHR_0;
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_1(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_1 GetImageSparseMemoryRequirements2KHR_1;
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_2 GetImageSparseMemoryRequirements2KHR_2;
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_3(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_3 GetImageSparseMemoryRequirements2KHR_3;
	private static IntPtr GetImageSparseMemoryRequirements2KHRPointer;
	public static VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_0(device, createInfo, allocator, out ycbcrConversion);
	private delegate VkResult CreateSamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_0 CreateSamplerYcbcrConversionKHR_0;
	public static VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_1(device, createInfo, ref allocator, out ycbcrConversion);
	private delegate VkResult CreateSamplerYcbcrConversionKHRDelegate_1(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_1 CreateSamplerYcbcrConversionKHR_1;
	public static VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_2(device, ref createInfo, allocator, out ycbcrConversion);
	private delegate VkResult CreateSamplerYcbcrConversionKHRDelegate_2(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_2 CreateSamplerYcbcrConversionKHR_2;
	public static VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_3(device, ref createInfo, ref allocator, out ycbcrConversion);
	private delegate VkResult CreateSamplerYcbcrConversionKHRDelegate_3(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_3 CreateSamplerYcbcrConversionKHR_3;
	private static IntPtr CreateSamplerYcbcrConversionKHRPointer;
	public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* allocator) => DestroySamplerYcbcrConversionKHR_0(device, ycbcrConversion, allocator);
	private delegate void DestroySamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* allocator);
	private static DestroySamplerYcbcrConversionKHRDelegate_0 DestroySamplerYcbcrConversionKHR_0;
	public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, ref VkAllocationCallbacks allocator) => DestroySamplerYcbcrConversionKHR_1(device, ycbcrConversion, ref allocator);
	private delegate void DestroySamplerYcbcrConversionKHRDelegate_1(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, ref VkAllocationCallbacks allocator);
	private static DestroySamplerYcbcrConversionKHRDelegate_1 DestroySamplerYcbcrConversionKHR_1;
	private static IntPtr DestroySamplerYcbcrConversionKHRPointer;
	public static VkResult BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR[] bindInfos) => BindBufferMemory2KHR_0(device, bindInfoCount, bindInfos);
	private delegate VkResult BindBufferMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR[] bindInfos);
	private static BindBufferMemory2KHRDelegate_0 BindBufferMemory2KHR_0;
	private static IntPtr BindBufferMemory2KHRPointer;
	public static VkResult BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR[] bindInfos) => BindImageMemory2KHR_0(device, bindInfoCount, bindInfos);
	private delegate VkResult BindImageMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR[] bindInfos);
	private static BindImageMemory2KHRDelegate_0 BindImageMemory2KHR_0;
	private static IntPtr BindImageMemory2KHRPointer;
	public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_0(device, createInfo, allocator, out validationCache);
	private delegate VkResult CreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_0 CreateValidationCacheEXT_0;
	public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_1(device, createInfo, ref allocator, out validationCache);
	private delegate VkResult CreateValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_1 CreateValidationCacheEXT_1;
	public static VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_2(device, ref createInfo, allocator, out validationCache);
	private delegate VkResult CreateValidationCacheEXTDelegate_2(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_2 CreateValidationCacheEXT_2;
	public static VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_3(device, ref createInfo, ref allocator, out validationCache);
	private delegate VkResult CreateValidationCacheEXTDelegate_3(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_3 CreateValidationCacheEXT_3;
	private static IntPtr CreateValidationCacheEXTPointer;
	public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator) => DestroyValidationCacheEXT_0(device, validationCache, allocator);
	private delegate void DestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator);
	private static DestroyValidationCacheEXTDelegate_0 DestroyValidationCacheEXT_0;
	public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator) => DestroyValidationCacheEXT_1(device, validationCache, ref allocator);
	private delegate void DestroyValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator);
	private static DestroyValidationCacheEXTDelegate_1 DestroyValidationCacheEXT_1;
	private static IntPtr DestroyValidationCacheEXTPointer;
	public static VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches) => MergeValidationCachesEXT_0(device, destinationCache, sourceCacheCount, sourceCaches);
	private delegate VkResult MergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches);
	private static MergeValidationCachesEXTDelegate_0 MergeValidationCachesEXT_0;
	private static IntPtr MergeValidationCachesEXTPointer;
	public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data) => GetValidationCacheDataEXT_0(device, validationCache, dataSize, data);
	private delegate VkResult GetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data);
	private static GetValidationCacheDataEXTDelegate_0 GetValidationCacheDataEXT_0;
	public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data) => GetValidationCacheDataEXT_1(device, validationCache, ref dataSize, data);
	private delegate VkResult GetValidationCacheDataEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data);
	private static GetValidationCacheDataEXTDelegate_1 GetValidationCacheDataEXT_1;
	private static IntPtr GetValidationCacheDataEXTPointer;
	public static VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties) => GetMemoryHostPointerPropertiesEXT_0(device, handleType, hostPointer, out memoryHostPointerProperties);
	private delegate VkResult GetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagsKHR handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties);
	private static GetMemoryHostPointerPropertiesEXTDelegate_0 GetMemoryHostPointerPropertiesEXT_0;
	private static IntPtr GetMemoryHostPointerPropertiesEXTPointer;
	public static void CommandWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker) => CommandWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, destinationBuffer, destinationOffset, marker);
	private delegate void CommandWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker);
	private static CommandWriteBufferMarkerAMDDelegate_0 CommandWriteBufferMarkerAMD_0;
	private static IntPtr CommandWriteBufferMarkerAMDPointer;
	private static readonly OSVulkanLibraryBase VulkanLibrary;
	static VK()
	{
		VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();
		InitialiseRequiredMethods();
	}
	private static void InitialiseRequiredMethods()
	{
		CreateInstancePointer = VulkanLibrary.GetFunctionPointer("CreateInstance");
		CreateInstance_0 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_0>(CreateInstancePointer);
		CreateInstance_1 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_1>(CreateInstancePointer);
		CreateInstance_2 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_2>(CreateInstancePointer);
		CreateInstance_3 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_3>(CreateInstancePointer);
		GetInstanceProcedureAddressPointer = VulkanLibrary.GetFunctionPointer("GetInstanceProcedureAddress");
		GetInstanceProcedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetInstanceProcedureAddressDelegate_0>(GetInstanceProcedureAddressPointer);
		EnumerateInstanceExtensionPropertiesPointer = VulkanLibrary.GetFunctionPointer("EnumerateInstanceExtensionProperties");
		EnumerateInstanceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_0>(EnumerateInstanceExtensionPropertiesPointer);
		EnumerateInstanceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_1>(EnumerateInstanceExtensionPropertiesPointer);
		EnumerateInstanceLayerPropertiesPointer = VulkanLibrary.GetFunctionPointer("EnumerateInstanceLayerProperties");
		EnumerateInstanceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_0>(EnumerateInstanceLayerPropertiesPointer);
		EnumerateInstanceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_1>(EnumerateInstanceLayerPropertiesPointer);
	}
	public static void InitialiseInstanceMethods(VkInstance instance)
	{
		DestroyInstancePointer = GetInstanceProcedureAddress(instance, "DestroyInstance");
		if (DestroyInstancePointer != IntPtr.Zero)
		{
			DestroyInstance_0 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_0>(DestroyInstancePointer);
			DestroyInstance_1 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_1>(DestroyInstancePointer);
		}
		EnumeratePhysicalDevicesPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDevices");
		if (EnumeratePhysicalDevicesPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDevices_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_0>(EnumeratePhysicalDevicesPointer);
			EnumeratePhysicalDevices_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_1>(EnumeratePhysicalDevicesPointer);
		}
		GetPhysicalDeviceFeaturesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFeatures");
		if (GetPhysicalDeviceFeaturesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeaturesDelegate_0>(GetPhysicalDeviceFeaturesPointer);
		}
		GetPhysicalDeviceFormatPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFormatProperties");
		if (GetPhysicalDeviceFormatPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatPropertiesDelegate_0>(GetPhysicalDeviceFormatPropertiesPointer);
		}
		GetPhysicalDeviceImageFormatPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceImageFormatProperties");
		if (GetPhysicalDeviceImageFormatPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatPropertiesDelegate_0>(GetPhysicalDeviceImageFormatPropertiesPointer);
		}
		GetPhysicalDevicePropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceProperties");
		if (GetPhysicalDevicePropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePropertiesDelegate_0>(GetPhysicalDevicePropertiesPointer);
		}
		GetPhysicalDeviceQueueFamilyPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceQueueFamilyProperties");
		if (GetPhysicalDeviceQueueFamilyPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_0>(GetPhysicalDeviceQueueFamilyPropertiesPointer);
			GetPhysicalDeviceQueueFamilyProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_1>(GetPhysicalDeviceQueueFamilyPropertiesPointer);
		}
		GetPhysicalDeviceMemoryPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMemoryProperties");
		if (GetPhysicalDeviceMemoryPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMemoryProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryPropertiesDelegate_0>(GetPhysicalDeviceMemoryPropertiesPointer);
		}
		GetDeviceProcedureAddressPointer = GetInstanceProcedureAddress(instance, "GetDeviceProcedureAddress");
		if (GetDeviceProcedureAddressPointer != IntPtr.Zero)
		{
			GetDeviceProcedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceProcedureAddressDelegate_0>(GetDeviceProcedureAddressPointer);
		}
		CreateDevicePointer = GetInstanceProcedureAddress(instance, "CreateDevice");
		if (CreateDevicePointer != IntPtr.Zero)
		{
			CreateDevice_0 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_0>(CreateDevicePointer);
			CreateDevice_1 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_1>(CreateDevicePointer);
			CreateDevice_2 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_2>(CreateDevicePointer);
			CreateDevice_3 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_3>(CreateDevicePointer);
		}
		DestroyDevicePointer = GetInstanceProcedureAddress(instance, "DestroyDevice");
		if (DestroyDevicePointer != IntPtr.Zero)
		{
			DestroyDevice_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_0>(DestroyDevicePointer);
			DestroyDevice_1 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_1>(DestroyDevicePointer);
		}
		EnumerateDeviceExtensionPropertiesPointer = GetInstanceProcedureAddress(instance, "EnumerateDeviceExtensionProperties");
		if (EnumerateDeviceExtensionPropertiesPointer != IntPtr.Zero)
		{
			EnumerateDeviceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_0>(EnumerateDeviceExtensionPropertiesPointer);
			EnumerateDeviceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_1>(EnumerateDeviceExtensionPropertiesPointer);
		}
		EnumerateDeviceLayerPropertiesPointer = GetInstanceProcedureAddress(instance, "EnumerateDeviceLayerProperties");
		if (EnumerateDeviceLayerPropertiesPointer != IntPtr.Zero)
		{
			EnumerateDeviceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_0>(EnumerateDeviceLayerPropertiesPointer);
			EnumerateDeviceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_1>(EnumerateDeviceLayerPropertiesPointer);
		}
		GetDeviceQueuePointer = GetInstanceProcedureAddress(instance, "GetDeviceQueue");
		if (GetDeviceQueuePointer != IntPtr.Zero)
		{
			GetDeviceQueue_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueueDelegate_0>(GetDeviceQueuePointer);
		}
		QueueSubmitPointer = GetInstanceProcedureAddress(instance, "QueueSubmit");
		if (QueueSubmitPointer != IntPtr.Zero)
		{
			QueueSubmit_0 = Marshal.GetDelegateForFunctionPointer<QueueSubmitDelegate_0>(QueueSubmitPointer);
		}
		QueueWaitIdlePointer = GetInstanceProcedureAddress(instance, "QueueWaitIdle");
		if (QueueWaitIdlePointer != IntPtr.Zero)
		{
			QueueWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<QueueWaitIdleDelegate_0>(QueueWaitIdlePointer);
		}
		DeviceWaitIdlePointer = GetInstanceProcedureAddress(instance, "DeviceWaitIdle");
		if (DeviceWaitIdlePointer != IntPtr.Zero)
		{
			DeviceWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<DeviceWaitIdleDelegate_0>(DeviceWaitIdlePointer);
		}
		AllocateMemoryPointer = GetInstanceProcedureAddress(instance, "AllocateMemory");
		if (AllocateMemoryPointer != IntPtr.Zero)
		{
			AllocateMemory_0 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_0>(AllocateMemoryPointer);
			AllocateMemory_1 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_1>(AllocateMemoryPointer);
			AllocateMemory_2 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_2>(AllocateMemoryPointer);
			AllocateMemory_3 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_3>(AllocateMemoryPointer);
		}
		FreeMemoryPointer = GetInstanceProcedureAddress(instance, "FreeMemory");
		if (FreeMemoryPointer != IntPtr.Zero)
		{
			FreeMemory_0 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_0>(FreeMemoryPointer);
			FreeMemory_1 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_1>(FreeMemoryPointer);
		}
		MapMemoryPointer = GetInstanceProcedureAddress(instance, "MapMemory");
		if (MapMemoryPointer != IntPtr.Zero)
		{
			MapMemory_0 = Marshal.GetDelegateForFunctionPointer<MapMemoryDelegate_0>(MapMemoryPointer);
		}
		UnmapMemoryPointer = GetInstanceProcedureAddress(instance, "UnmapMemory");
		if (UnmapMemoryPointer != IntPtr.Zero)
		{
			UnmapMemory_0 = Marshal.GetDelegateForFunctionPointer<UnmapMemoryDelegate_0>(UnmapMemoryPointer);
		}
		FlushMappedMemoryRangesPointer = GetInstanceProcedureAddress(instance, "FlushMappedMemoryRanges");
		if (FlushMappedMemoryRangesPointer != IntPtr.Zero)
		{
			FlushMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<FlushMappedMemoryRangesDelegate_0>(FlushMappedMemoryRangesPointer);
		}
		InvalidateMappedMemoryRangesPointer = GetInstanceProcedureAddress(instance, "InvalidateMappedMemoryRanges");
		if (InvalidateMappedMemoryRangesPointer != IntPtr.Zero)
		{
			InvalidateMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<InvalidateMappedMemoryRangesDelegate_0>(InvalidateMappedMemoryRangesPointer);
		}
		GetDeviceMemoryCommitmentPointer = GetInstanceProcedureAddress(instance, "GetDeviceMemoryCommitment");
		if (GetDeviceMemoryCommitmentPointer != IntPtr.Zero)
		{
			GetDeviceMemoryCommitment_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryCommitmentDelegate_0>(GetDeviceMemoryCommitmentPointer);
		}
		BindBufferMemoryPointer = GetInstanceProcedureAddress(instance, "BindBufferMemory");
		if (BindBufferMemoryPointer != IntPtr.Zero)
		{
			BindBufferMemory_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemoryDelegate_0>(BindBufferMemoryPointer);
		}
		BindImageMemoryPointer = GetInstanceProcedureAddress(instance, "BindImageMemory");
		if (BindImageMemoryPointer != IntPtr.Zero)
		{
			BindImageMemory_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemoryDelegate_0>(BindImageMemoryPointer);
		}
		GetBufferMemoryRequirementsPointer = GetInstanceProcedureAddress(instance, "GetBufferMemoryRequirements");
		if (GetBufferMemoryRequirementsPointer != IntPtr.Zero)
		{
			GetBufferMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirementsDelegate_0>(GetBufferMemoryRequirementsPointer);
		}
		GetImageMemoryRequirementsPointer = GetInstanceProcedureAddress(instance, "GetImageMemoryRequirements");
		if (GetImageMemoryRequirementsPointer != IntPtr.Zero)
		{
			GetImageMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirementsDelegate_0>(GetImageMemoryRequirementsPointer);
		}
		GetImageSparseMemoryRequirementsPointer = GetInstanceProcedureAddress(instance, "GetImageSparseMemoryRequirements");
		if (GetImageSparseMemoryRequirementsPointer != IntPtr.Zero)
		{
			GetImageSparseMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_0>(GetImageSparseMemoryRequirementsPointer);
			GetImageSparseMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_1>(GetImageSparseMemoryRequirementsPointer);
		}
		GetPhysicalDeviceSparseImageFormatPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSparseImageFormatProperties");
		if (GetPhysicalDeviceSparseImageFormatPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0>(GetPhysicalDeviceSparseImageFormatPropertiesPointer);
			GetPhysicalDeviceSparseImageFormatProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1>(GetPhysicalDeviceSparseImageFormatPropertiesPointer);
		}
		QueueBindSparsePointer = GetInstanceProcedureAddress(instance, "QueueBindSparse");
		if (QueueBindSparsePointer != IntPtr.Zero)
		{
			QueueBindSparse_0 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_0>(QueueBindSparsePointer);
			QueueBindSparse_1 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_1>(QueueBindSparsePointer);
		}
		CreateFencePointer = GetInstanceProcedureAddress(instance, "CreateFence");
		if (CreateFencePointer != IntPtr.Zero)
		{
			CreateFence_0 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_0>(CreateFencePointer);
			CreateFence_1 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_1>(CreateFencePointer);
			CreateFence_2 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_2>(CreateFencePointer);
			CreateFence_3 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_3>(CreateFencePointer);
		}
		DestroyFencePointer = GetInstanceProcedureAddress(instance, "DestroyFence");
		if (DestroyFencePointer != IntPtr.Zero)
		{
			DestroyFence_0 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_0>(DestroyFencePointer);
			DestroyFence_1 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_1>(DestroyFencePointer);
		}
		ResetFencesPointer = GetInstanceProcedureAddress(instance, "ResetFences");
		if (ResetFencesPointer != IntPtr.Zero)
		{
			ResetFences_0 = Marshal.GetDelegateForFunctionPointer<ResetFencesDelegate_0>(ResetFencesPointer);
		}
		GetFenceStatusPointer = GetInstanceProcedureAddress(instance, "GetFenceStatus");
		if (GetFenceStatusPointer != IntPtr.Zero)
		{
			GetFenceStatus_0 = Marshal.GetDelegateForFunctionPointer<GetFenceStatusDelegate_0>(GetFenceStatusPointer);
		}
		WaitForFencesPointer = GetInstanceProcedureAddress(instance, "WaitForFences");
		if (WaitForFencesPointer != IntPtr.Zero)
		{
			WaitForFences_0 = Marshal.GetDelegateForFunctionPointer<WaitForFencesDelegate_0>(WaitForFencesPointer);
		}
		CreateSemaphorePointer = GetInstanceProcedureAddress(instance, "CreateSemaphore");
		if (CreateSemaphorePointer != IntPtr.Zero)
		{
			CreateSemaphore_0 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_0>(CreateSemaphorePointer);
			CreateSemaphore_1 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_1>(CreateSemaphorePointer);
			CreateSemaphore_2 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_2>(CreateSemaphorePointer);
			CreateSemaphore_3 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_3>(CreateSemaphorePointer);
		}
		DestroySemaphorePointer = GetInstanceProcedureAddress(instance, "DestroySemaphore");
		if (DestroySemaphorePointer != IntPtr.Zero)
		{
			DestroySemaphore_0 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_0>(DestroySemaphorePointer);
			DestroySemaphore_1 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_1>(DestroySemaphorePointer);
		}
		CreateEventPointer = GetInstanceProcedureAddress(instance, "CreateEvent");
		if (CreateEventPointer != IntPtr.Zero)
		{
			CreateEvent_0 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_0>(CreateEventPointer);
			CreateEvent_1 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_1>(CreateEventPointer);
			CreateEvent_2 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_2>(CreateEventPointer);
			CreateEvent_3 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_3>(CreateEventPointer);
		}
		DestroyEventPointer = GetInstanceProcedureAddress(instance, "DestroyEvent");
		if (DestroyEventPointer != IntPtr.Zero)
		{
			DestroyEvent_0 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_0>(DestroyEventPointer);
			DestroyEvent_1 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_1>(DestroyEventPointer);
		}
		GetEventStatusPointer = GetInstanceProcedureAddress(instance, "GetEventStatus");
		if (GetEventStatusPointer != IntPtr.Zero)
		{
			GetEventStatus_0 = Marshal.GetDelegateForFunctionPointer<GetEventStatusDelegate_0>(GetEventStatusPointer);
		}
		SetEventPointer = GetInstanceProcedureAddress(instance, "SetEvent");
		if (SetEventPointer != IntPtr.Zero)
		{
			SetEvent_0 = Marshal.GetDelegateForFunctionPointer<SetEventDelegate_0>(SetEventPointer);
		}
		ResetEventPointer = GetInstanceProcedureAddress(instance, "ResetEvent");
		if (ResetEventPointer != IntPtr.Zero)
		{
			ResetEvent_0 = Marshal.GetDelegateForFunctionPointer<ResetEventDelegate_0>(ResetEventPointer);
		}
		CreateQueryPoolPointer = GetInstanceProcedureAddress(instance, "CreateQueryPool");
		if (CreateQueryPoolPointer != IntPtr.Zero)
		{
			CreateQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_0>(CreateQueryPoolPointer);
			CreateQueryPool_1 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_1>(CreateQueryPoolPointer);
			CreateQueryPool_2 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_2>(CreateQueryPoolPointer);
			CreateQueryPool_3 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_3>(CreateQueryPoolPointer);
		}
		DestroyQueryPoolPointer = GetInstanceProcedureAddress(instance, "DestroyQueryPool");
		if (DestroyQueryPoolPointer != IntPtr.Zero)
		{
			DestroyQueryPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_0>(DestroyQueryPoolPointer);
			DestroyQueryPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_1>(DestroyQueryPoolPointer);
		}
		GetQueryPoolResultsPointer = GetInstanceProcedureAddress(instance, "GetQueryPoolResults");
		if (GetQueryPoolResultsPointer != IntPtr.Zero)
		{
			GetQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<GetQueryPoolResultsDelegate_0>(GetQueryPoolResultsPointer);
		}
		CreateBufferPointer = GetInstanceProcedureAddress(instance, "CreateBuffer");
		if (CreateBufferPointer != IntPtr.Zero)
		{
			CreateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_0>(CreateBufferPointer);
			CreateBuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_1>(CreateBufferPointer);
			CreateBuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_2>(CreateBufferPointer);
			CreateBuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_3>(CreateBufferPointer);
		}
		DestroyBufferPointer = GetInstanceProcedureAddress(instance, "DestroyBuffer");
		if (DestroyBufferPointer != IntPtr.Zero)
		{
			DestroyBuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_0>(DestroyBufferPointer);
			DestroyBuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_1>(DestroyBufferPointer);
		}
		CreateBufferViewPointer = GetInstanceProcedureAddress(instance, "CreateBufferView");
		if (CreateBufferViewPointer != IntPtr.Zero)
		{
			CreateBufferView_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_0>(CreateBufferViewPointer);
			CreateBufferView_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_1>(CreateBufferViewPointer);
			CreateBufferView_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_2>(CreateBufferViewPointer);
			CreateBufferView_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_3>(CreateBufferViewPointer);
		}
		DestroyBufferViewPointer = GetInstanceProcedureAddress(instance, "DestroyBufferView");
		if (DestroyBufferViewPointer != IntPtr.Zero)
		{
			DestroyBufferView_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_0>(DestroyBufferViewPointer);
			DestroyBufferView_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_1>(DestroyBufferViewPointer);
		}
		CreateImagePointer = GetInstanceProcedureAddress(instance, "CreateImage");
		if (CreateImagePointer != IntPtr.Zero)
		{
			CreateImage_0 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_0>(CreateImagePointer);
			CreateImage_1 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_1>(CreateImagePointer);
			CreateImage_2 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_2>(CreateImagePointer);
			CreateImage_3 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_3>(CreateImagePointer);
		}
		DestroyImagePointer = GetInstanceProcedureAddress(instance, "DestroyImage");
		if (DestroyImagePointer != IntPtr.Zero)
		{
			DestroyImage_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_0>(DestroyImagePointer);
			DestroyImage_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_1>(DestroyImagePointer);
		}
		GetImageSubresourceLayoutPointer = GetInstanceProcedureAddress(instance, "GetImageSubresourceLayout");
		if (GetImageSubresourceLayoutPointer != IntPtr.Zero)
		{
			GetImageSubresourceLayout_0 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_0>(GetImageSubresourceLayoutPointer);
			GetImageSubresourceLayout_1 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_1>(GetImageSubresourceLayoutPointer);
		}
		CreateImageViewPointer = GetInstanceProcedureAddress(instance, "CreateImageView");
		if (CreateImageViewPointer != IntPtr.Zero)
		{
			CreateImageView_0 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_0>(CreateImageViewPointer);
			CreateImageView_1 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_1>(CreateImageViewPointer);
			CreateImageView_2 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_2>(CreateImageViewPointer);
			CreateImageView_3 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_3>(CreateImageViewPointer);
		}
		DestroyImageViewPointer = GetInstanceProcedureAddress(instance, "DestroyImageView");
		if (DestroyImageViewPointer != IntPtr.Zero)
		{
			DestroyImageView_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_0>(DestroyImageViewPointer);
			DestroyImageView_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_1>(DestroyImageViewPointer);
		}
		CreateShaderModulePointer = GetInstanceProcedureAddress(instance, "CreateShaderModule");
		if (CreateShaderModulePointer != IntPtr.Zero)
		{
			CreateShaderModule_0 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_0>(CreateShaderModulePointer);
			CreateShaderModule_1 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_1>(CreateShaderModulePointer);
			CreateShaderModule_2 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_2>(CreateShaderModulePointer);
			CreateShaderModule_3 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_3>(CreateShaderModulePointer);
		}
		DestroyShaderModulePointer = GetInstanceProcedureAddress(instance, "DestroyShaderModule");
		if (DestroyShaderModulePointer != IntPtr.Zero)
		{
			DestroyShaderModule_0 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_0>(DestroyShaderModulePointer);
			DestroyShaderModule_1 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_1>(DestroyShaderModulePointer);
		}
		CreatePipelineCachePointer = GetInstanceProcedureAddress(instance, "CreatePipelineCache");
		if (CreatePipelineCachePointer != IntPtr.Zero)
		{
			CreatePipelineCache_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_0>(CreatePipelineCachePointer);
			CreatePipelineCache_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_1>(CreatePipelineCachePointer);
			CreatePipelineCache_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_2>(CreatePipelineCachePointer);
			CreatePipelineCache_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_3>(CreatePipelineCachePointer);
		}
		DestroyPipelineCachePointer = GetInstanceProcedureAddress(instance, "DestroyPipelineCache");
		if (DestroyPipelineCachePointer != IntPtr.Zero)
		{
			DestroyPipelineCache_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_0>(DestroyPipelineCachePointer);
			DestroyPipelineCache_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_1>(DestroyPipelineCachePointer);
		}
		GetPipelineCacheDataPointer = GetInstanceProcedureAddress(instance, "GetPipelineCacheData");
		if (GetPipelineCacheDataPointer != IntPtr.Zero)
		{
			GetPipelineCacheData_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_0>(GetPipelineCacheDataPointer);
			GetPipelineCacheData_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_1>(GetPipelineCacheDataPointer);
		}
		MergePipelineCachesPointer = GetInstanceProcedureAddress(instance, "MergePipelineCaches");
		if (MergePipelineCachesPointer != IntPtr.Zero)
		{
			MergePipelineCaches_0 = Marshal.GetDelegateForFunctionPointer<MergePipelineCachesDelegate_0>(MergePipelineCachesPointer);
		}
		CreateGraphicsPipelinesPointer = GetInstanceProcedureAddress(instance, "CreateGraphicsPipelines");
		if (CreateGraphicsPipelinesPointer != IntPtr.Zero)
		{
			CreateGraphicsPipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_0>(CreateGraphicsPipelinesPointer);
			CreateGraphicsPipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_1>(CreateGraphicsPipelinesPointer);
		}
		CreateComputePipelinesPointer = GetInstanceProcedureAddress(instance, "CreateComputePipelines");
		if (CreateComputePipelinesPointer != IntPtr.Zero)
		{
			CreateComputePipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_0>(CreateComputePipelinesPointer);
			CreateComputePipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_1>(CreateComputePipelinesPointer);
		}
		DestroyPipelinePointer = GetInstanceProcedureAddress(instance, "DestroyPipeline");
		if (DestroyPipelinePointer != IntPtr.Zero)
		{
			DestroyPipeline_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_0>(DestroyPipelinePointer);
			DestroyPipeline_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_1>(DestroyPipelinePointer);
		}
		CreatePipelineLayoutPointer = GetInstanceProcedureAddress(instance, "CreatePipelineLayout");
		if (CreatePipelineLayoutPointer != IntPtr.Zero)
		{
			CreatePipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_0>(CreatePipelineLayoutPointer);
			CreatePipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_1>(CreatePipelineLayoutPointer);
			CreatePipelineLayout_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_2>(CreatePipelineLayoutPointer);
			CreatePipelineLayout_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_3>(CreatePipelineLayoutPointer);
		}
		DestroyPipelineLayoutPointer = GetInstanceProcedureAddress(instance, "DestroyPipelineLayout");
		if (DestroyPipelineLayoutPointer != IntPtr.Zero)
		{
			DestroyPipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_0>(DestroyPipelineLayoutPointer);
			DestroyPipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_1>(DestroyPipelineLayoutPointer);
		}
		CreateSamplerPointer = GetInstanceProcedureAddress(instance, "CreateSampler");
		if (CreateSamplerPointer != IntPtr.Zero)
		{
			CreateSampler_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_0>(CreateSamplerPointer);
			CreateSampler_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_1>(CreateSamplerPointer);
			CreateSampler_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_2>(CreateSamplerPointer);
			CreateSampler_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_3>(CreateSamplerPointer);
		}
		DestroySamplerPointer = GetInstanceProcedureAddress(instance, "DestroySampler");
		if (DestroySamplerPointer != IntPtr.Zero)
		{
			DestroySampler_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_0>(DestroySamplerPointer);
			DestroySampler_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_1>(DestroySamplerPointer);
		}
		CreateDescriptorSetLayoutPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorSetLayout");
		if (CreateDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			CreateDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_0>(CreateDescriptorSetLayoutPointer);
			CreateDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_1>(CreateDescriptorSetLayoutPointer);
			CreateDescriptorSetLayout_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_2>(CreateDescriptorSetLayoutPointer);
			CreateDescriptorSetLayout_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_3>(CreateDescriptorSetLayoutPointer);
		}
		DestroyDescriptorSetLayoutPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorSetLayout");
		if (DestroyDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			DestroyDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_0>(DestroyDescriptorSetLayoutPointer);
			DestroyDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_1>(DestroyDescriptorSetLayoutPointer);
		}
		CreateDescriptorPoolPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorPool");
		if (CreateDescriptorPoolPointer != IntPtr.Zero)
		{
			CreateDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_0>(CreateDescriptorPoolPointer);
			CreateDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_1>(CreateDescriptorPoolPointer);
			CreateDescriptorPool_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_2>(CreateDescriptorPoolPointer);
			CreateDescriptorPool_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_3>(CreateDescriptorPoolPointer);
		}
		DestroyDescriptorPoolPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorPool");
		if (DestroyDescriptorPoolPointer != IntPtr.Zero)
		{
			DestroyDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_0>(DestroyDescriptorPoolPointer);
			DestroyDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_1>(DestroyDescriptorPoolPointer);
		}
		ResetDescriptorPoolPointer = GetInstanceProcedureAddress(instance, "ResetDescriptorPool");
		if (ResetDescriptorPoolPointer != IntPtr.Zero)
		{
			ResetDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<ResetDescriptorPoolDelegate_0>(ResetDescriptorPoolPointer);
		}
		AllocateDescriptorSetsPointer = GetInstanceProcedureAddress(instance, "AllocateDescriptorSets");
		if (AllocateDescriptorSetsPointer != IntPtr.Zero)
		{
			AllocateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_0>(AllocateDescriptorSetsPointer);
			AllocateDescriptorSets_1 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_1>(AllocateDescriptorSetsPointer);
		}
		FreeDescriptorSetsPointer = GetInstanceProcedureAddress(instance, "FreeDescriptorSets");
		if (FreeDescriptorSetsPointer != IntPtr.Zero)
		{
			FreeDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<FreeDescriptorSetsDelegate_0>(FreeDescriptorSetsPointer);
		}
		UpdateDescriptorSetsPointer = GetInstanceProcedureAddress(instance, "UpdateDescriptorSets");
		if (UpdateDescriptorSetsPointer != IntPtr.Zero)
		{
			UpdateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetsDelegate_0>(UpdateDescriptorSetsPointer);
		}
		CreateFramebufferPointer = GetInstanceProcedureAddress(instance, "CreateFramebuffer");
		if (CreateFramebufferPointer != IntPtr.Zero)
		{
			CreateFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_0>(CreateFramebufferPointer);
			CreateFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_1>(CreateFramebufferPointer);
			CreateFramebuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_2>(CreateFramebufferPointer);
			CreateFramebuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_3>(CreateFramebufferPointer);
		}
		DestroyFramebufferPointer = GetInstanceProcedureAddress(instance, "DestroyFramebuffer");
		if (DestroyFramebufferPointer != IntPtr.Zero)
		{
			DestroyFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_0>(DestroyFramebufferPointer);
			DestroyFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_1>(DestroyFramebufferPointer);
		}
		CreateRenderPassPointer = GetInstanceProcedureAddress(instance, "CreateRenderPass");
		if (CreateRenderPassPointer != IntPtr.Zero)
		{
			CreateRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_0>(CreateRenderPassPointer);
			CreateRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_1>(CreateRenderPassPointer);
			CreateRenderPass_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_2>(CreateRenderPassPointer);
			CreateRenderPass_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_3>(CreateRenderPassPointer);
		}
		DestroyRenderPassPointer = GetInstanceProcedureAddress(instance, "DestroyRenderPass");
		if (DestroyRenderPassPointer != IntPtr.Zero)
		{
			DestroyRenderPass_0 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_0>(DestroyRenderPassPointer);
			DestroyRenderPass_1 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_1>(DestroyRenderPassPointer);
		}
		GetRenderAreaGranularityPointer = GetInstanceProcedureAddress(instance, "GetRenderAreaGranularity");
		if (GetRenderAreaGranularityPointer != IntPtr.Zero)
		{
			GetRenderAreaGranularity_0 = Marshal.GetDelegateForFunctionPointer<GetRenderAreaGranularityDelegate_0>(GetRenderAreaGranularityPointer);
		}
		CreateCommandPoolPointer = GetInstanceProcedureAddress(instance, "CreateCommandPool");
		if (CreateCommandPoolPointer != IntPtr.Zero)
		{
			CreateCommandPool_0 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_0>(CreateCommandPoolPointer);
			CreateCommandPool_1 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_1>(CreateCommandPoolPointer);
			CreateCommandPool_2 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_2>(CreateCommandPoolPointer);
			CreateCommandPool_3 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_3>(CreateCommandPoolPointer);
		}
		DestroyCommandPoolPointer = GetInstanceProcedureAddress(instance, "DestroyCommandPool");
		if (DestroyCommandPoolPointer != IntPtr.Zero)
		{
			DestroyCommandPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_0>(DestroyCommandPoolPointer);
			DestroyCommandPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_1>(DestroyCommandPoolPointer);
		}
		ResetCommandPoolPointer = GetInstanceProcedureAddress(instance, "ResetCommandPool");
		if (ResetCommandPoolPointer != IntPtr.Zero)
		{
			ResetCommandPool_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandPoolDelegate_0>(ResetCommandPoolPointer);
		}
		AllocateCommandBuffersPointer = GetInstanceProcedureAddress(instance, "AllocateCommandBuffers");
		if (AllocateCommandBuffersPointer != IntPtr.Zero)
		{
			AllocateCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_0>(AllocateCommandBuffersPointer);
			AllocateCommandBuffers_1 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_1>(AllocateCommandBuffersPointer);
		}
		FreeCommandBuffersPointer = GetInstanceProcedureAddress(instance, "FreeCommandBuffers");
		if (FreeCommandBuffersPointer != IntPtr.Zero)
		{
			FreeCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<FreeCommandBuffersDelegate_0>(FreeCommandBuffersPointer);
		}
		BeginCommandBufferPointer = GetInstanceProcedureAddress(instance, "BeginCommandBuffer");
		if (BeginCommandBufferPointer != IntPtr.Zero)
		{
			BeginCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_0>(BeginCommandBufferPointer);
			BeginCommandBuffer_1 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_1>(BeginCommandBufferPointer);
		}
		EndCommandBufferPointer = GetInstanceProcedureAddress(instance, "EndCommandBuffer");
		if (EndCommandBufferPointer != IntPtr.Zero)
		{
			EndCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<EndCommandBufferDelegate_0>(EndCommandBufferPointer);
		}
		ResetCommandBufferPointer = GetInstanceProcedureAddress(instance, "ResetCommandBuffer");
		if (ResetCommandBufferPointer != IntPtr.Zero)
		{
			ResetCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandBufferDelegate_0>(ResetCommandBufferPointer);
		}
		CommandBindPipelinePointer = GetInstanceProcedureAddress(instance, "CommandBindPipeline");
		if (CommandBindPipelinePointer != IntPtr.Zero)
		{
			CommandBindPipeline_0 = Marshal.GetDelegateForFunctionPointer<CommandBindPipelineDelegate_0>(CommandBindPipelinePointer);
		}
		CommandSetViewportPointer = GetInstanceProcedureAddress(instance, "CommandSetViewport");
		if (CommandSetViewportPointer != IntPtr.Zero)
		{
			CommandSetViewport_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportDelegate_0>(CommandSetViewportPointer);
		}
		CommandSetScissorPointer = GetInstanceProcedureAddress(instance, "CommandSetScissor");
		if (CommandSetScissorPointer != IntPtr.Zero)
		{
			CommandSetScissor_0 = Marshal.GetDelegateForFunctionPointer<CommandSetScissorDelegate_0>(CommandSetScissorPointer);
		}
		CommandSetLineWidthPointer = GetInstanceProcedureAddress(instance, "CommandSetLineWidth");
		if (CommandSetLineWidthPointer != IntPtr.Zero)
		{
			CommandSetLineWidth_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineWidthDelegate_0>(CommandSetLineWidthPointer);
		}
		CommandSetDepthBiasPointer = GetInstanceProcedureAddress(instance, "CommandSetDepthBias");
		if (CommandSetDepthBiasPointer != IntPtr.Zero)
		{
			CommandSetDepthBias_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBiasDelegate_0>(CommandSetDepthBiasPointer);
		}
		CommandSetBlendConstantsPointer = GetInstanceProcedureAddress(instance, "CommandSetBlendConstants");
		if (CommandSetBlendConstantsPointer != IntPtr.Zero)
		{
			CommandSetBlendConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandSetBlendConstantsDelegate_0>(CommandSetBlendConstantsPointer);
		}
		CommandSetDepthBoundsPointer = GetInstanceProcedureAddress(instance, "CommandSetDepthBounds");
		if (CommandSetDepthBoundsPointer != IntPtr.Zero)
		{
			CommandSetDepthBounds_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBoundsDelegate_0>(CommandSetDepthBoundsPointer);
		}
		CommandSetStencilCompareMaskPointer = GetInstanceProcedureAddress(instance, "CommandSetStencilCompareMask");
		if (CommandSetStencilCompareMaskPointer != IntPtr.Zero)
		{
			CommandSetStencilCompareMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilCompareMaskDelegate_0>(CommandSetStencilCompareMaskPointer);
		}
		CommandSetStencilWriteMaskPointer = GetInstanceProcedureAddress(instance, "CommandSetStencilWriteMask");
		if (CommandSetStencilWriteMaskPointer != IntPtr.Zero)
		{
			CommandSetStencilWriteMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilWriteMaskDelegate_0>(CommandSetStencilWriteMaskPointer);
		}
		CommandSetStencilReferencePointer = GetInstanceProcedureAddress(instance, "CommandSetStencilReference");
		if (CommandSetStencilReferencePointer != IntPtr.Zero)
		{
			CommandSetStencilReference_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilReferenceDelegate_0>(CommandSetStencilReferencePointer);
		}
		CommandBindDescriptorSetsPointer = GetInstanceProcedureAddress(instance, "CommandBindDescriptorSets");
		if (CommandBindDescriptorSetsPointer != IntPtr.Zero)
		{
			CommandBindDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<CommandBindDescriptorSetsDelegate_0>(CommandBindDescriptorSetsPointer);
		}
		CommandBindIndexBufferPointer = GetInstanceProcedureAddress(instance, "CommandBindIndexBuffer");
		if (CommandBindIndexBufferPointer != IntPtr.Zero)
		{
			CommandBindIndexBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandBindIndexBufferDelegate_0>(CommandBindIndexBufferPointer);
		}
		CommandBindVertexBuffersPointer = GetInstanceProcedureAddress(instance, "CommandBindVertexBuffers");
		if (CommandBindVertexBuffersPointer != IntPtr.Zero)
		{
			CommandBindVertexBuffers_0 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_0>(CommandBindVertexBuffersPointer);
			CommandBindVertexBuffers_1 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_1>(CommandBindVertexBuffersPointer);
			CommandBindVertexBuffers_2 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_2>(CommandBindVertexBuffersPointer);
			CommandBindVertexBuffers_3 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_3>(CommandBindVertexBuffersPointer);
		}
		CommandDrawPointer = GetInstanceProcedureAddress(instance, "CommandDraw");
		if (CommandDrawPointer != IntPtr.Zero)
		{
			CommandDraw_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawDelegate_0>(CommandDrawPointer);
		}
		CommandDrawIndexedPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndexed");
		if (CommandDrawIndexedPointer != IntPtr.Zero)
		{
			CommandDrawIndexed_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedDelegate_0>(CommandDrawIndexedPointer);
		}
		CommandDrawIndirectPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndirect");
		if (CommandDrawIndirectPointer != IntPtr.Zero)
		{
			CommandDrawIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectDelegate_0>(CommandDrawIndirectPointer);
		}
		CommandDrawIndexedIndirectPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndexedIndirect");
		if (CommandDrawIndexedIndirectPointer != IntPtr.Zero)
		{
			CommandDrawIndexedIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectDelegate_0>(CommandDrawIndexedIndirectPointer);
		}
		CommandDispatchPointer = GetInstanceProcedureAddress(instance, "CommandDispatch");
		if (CommandDispatchPointer != IntPtr.Zero)
		{
			CommandDispatch_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchDelegate_0>(CommandDispatchPointer);
		}
		CommandDispatchIndirectPointer = GetInstanceProcedureAddress(instance, "CommandDispatchIndirect");
		if (CommandDispatchIndirectPointer != IntPtr.Zero)
		{
			CommandDispatchIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchIndirectDelegate_0>(CommandDispatchIndirectPointer);
		}
		CommandCopyBufferPointer = GetInstanceProcedureAddress(instance, "CommandCopyBuffer");
		if (CommandCopyBufferPointer != IntPtr.Zero)
		{
			CommandCopyBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferDelegate_0>(CommandCopyBufferPointer);
		}
		CommandCopyImagePointer = GetInstanceProcedureAddress(instance, "CommandCopyImage");
		if (CommandCopyImagePointer != IntPtr.Zero)
		{
			CommandCopyImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageDelegate_0>(CommandCopyImagePointer);
		}
		CommandBlitImagePointer = GetInstanceProcedureAddress(instance, "CommandBlitImage");
		if (CommandBlitImagePointer != IntPtr.Zero)
		{
			CommandBlitImage_0 = Marshal.GetDelegateForFunctionPointer<CommandBlitImageDelegate_0>(CommandBlitImagePointer);
		}
		CommandCopyBufferToImagePointer = GetInstanceProcedureAddress(instance, "CommandCopyBufferToImage");
		if (CommandCopyBufferToImagePointer != IntPtr.Zero)
		{
			CommandCopyBufferToImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImageDelegate_0>(CommandCopyBufferToImagePointer);
		}
		CommandCopyImageToBufferPointer = GetInstanceProcedureAddress(instance, "CommandCopyImageToBuffer");
		if (CommandCopyImageToBufferPointer != IntPtr.Zero)
		{
			CommandCopyImageToBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBufferDelegate_0>(CommandCopyImageToBufferPointer);
		}
		CommandUpdateBufferPointer = GetInstanceProcedureAddress(instance, "CommandUpdateBuffer");
		if (CommandUpdateBufferPointer != IntPtr.Zero)
		{
			CommandUpdateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandUpdateBufferDelegate_0>(CommandUpdateBufferPointer);
		}
		CommandFillBufferPointer = GetInstanceProcedureAddress(instance, "CommandFillBuffer");
		if (CommandFillBufferPointer != IntPtr.Zero)
		{
			CommandFillBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandFillBufferDelegate_0>(CommandFillBufferPointer);
		}
		CommandClearColorImagePointer = GetInstanceProcedureAddress(instance, "CommandClearColorImage");
		if (CommandClearColorImagePointer != IntPtr.Zero)
		{
			CommandClearColorImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_0>(CommandClearColorImagePointer);
			CommandClearColorImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_1>(CommandClearColorImagePointer);
		}
		CommandClearDepthStencilImagePointer = GetInstanceProcedureAddress(instance, "CommandClearDepthStencilImage");
		if (CommandClearDepthStencilImagePointer != IntPtr.Zero)
		{
			CommandClearDepthStencilImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_0>(CommandClearDepthStencilImagePointer);
			CommandClearDepthStencilImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_1>(CommandClearDepthStencilImagePointer);
		}
		CommandClearAttachmentsPointer = GetInstanceProcedureAddress(instance, "CommandClearAttachments");
		if (CommandClearAttachmentsPointer != IntPtr.Zero)
		{
			CommandClearAttachments_0 = Marshal.GetDelegateForFunctionPointer<CommandClearAttachmentsDelegate_0>(CommandClearAttachmentsPointer);
		}
		CommandResolveImagePointer = GetInstanceProcedureAddress(instance, "CommandResolveImage");
		if (CommandResolveImagePointer != IntPtr.Zero)
		{
			CommandResolveImage_0 = Marshal.GetDelegateForFunctionPointer<CommandResolveImageDelegate_0>(CommandResolveImagePointer);
		}
		CommandSetEventPointer = GetInstanceProcedureAddress(instance, "CommandSetEvent");
		if (CommandSetEventPointer != IntPtr.Zero)
		{
			CommandSetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandSetEventDelegate_0>(CommandSetEventPointer);
		}
		CommandResetEventPointer = GetInstanceProcedureAddress(instance, "CommandResetEvent");
		if (CommandResetEventPointer != IntPtr.Zero)
		{
			CommandResetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandResetEventDelegate_0>(CommandResetEventPointer);
		}
		CommandWaitEventsPointer = GetInstanceProcedureAddress(instance, "CommandWaitEvents");
		if (CommandWaitEventsPointer != IntPtr.Zero)
		{
			CommandWaitEvents_0 = Marshal.GetDelegateForFunctionPointer<CommandWaitEventsDelegate_0>(CommandWaitEventsPointer);
		}
		CommandPipelineBarrierPointer = GetInstanceProcedureAddress(instance, "CommandPipelineBarrier");
		if (CommandPipelineBarrierPointer != IntPtr.Zero)
		{
			CommandPipelineBarrier_0 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrierDelegate_0>(CommandPipelineBarrierPointer);
		}
		CommandBeginQueryPointer = GetInstanceProcedureAddress(instance, "CommandBeginQuery");
		if (CommandBeginQueryPointer != IntPtr.Zero)
		{
			CommandBeginQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryDelegate_0>(CommandBeginQueryPointer);
		}
		CommandEndQueryPointer = GetInstanceProcedureAddress(instance, "CommandEndQuery");
		if (CommandEndQueryPointer != IntPtr.Zero)
		{
			CommandEndQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryDelegate_0>(CommandEndQueryPointer);
		}
		CommandResetQueryPoolPointer = GetInstanceProcedureAddress(instance, "CommandResetQueryPool");
		if (CommandResetQueryPoolPointer != IntPtr.Zero)
		{
			CommandResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CommandResetQueryPoolDelegate_0>(CommandResetQueryPoolPointer);
		}
		CommandWriteTimestampPointer = GetInstanceProcedureAddress(instance, "CommandWriteTimestamp");
		if (CommandWriteTimestampPointer != IntPtr.Zero)
		{
			CommandWriteTimestamp_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteTimestampDelegate_0>(CommandWriteTimestampPointer);
		}
		CommandCopyQueryPoolResultsPointer = GetInstanceProcedureAddress(instance, "CommandCopyQueryPoolResults");
		if (CommandCopyQueryPoolResultsPointer != IntPtr.Zero)
		{
			CommandCopyQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyQueryPoolResultsDelegate_0>(CommandCopyQueryPoolResultsPointer);
		}
		CommandPushConstantsPointer = GetInstanceProcedureAddress(instance, "CommandPushConstants");
		if (CommandPushConstantsPointer != IntPtr.Zero)
		{
			CommandPushConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandPushConstantsDelegate_0>(CommandPushConstantsPointer);
		}
		CommandBeginRenderPassPointer = GetInstanceProcedureAddress(instance, "CommandBeginRenderPass");
		if (CommandBeginRenderPassPointer != IntPtr.Zero)
		{
			CommandBeginRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_0>(CommandBeginRenderPassPointer);
			CommandBeginRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_1>(CommandBeginRenderPassPointer);
		}
		CommandNextSubpassPointer = GetInstanceProcedureAddress(instance, "CommandNextSubpass");
		if (CommandNextSubpassPointer != IntPtr.Zero)
		{
			CommandNextSubpass_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpassDelegate_0>(CommandNextSubpassPointer);
		}
		CommandEndRenderPassPointer = GetInstanceProcedureAddress(instance, "CommandEndRenderPass");
		if (CommandEndRenderPassPointer != IntPtr.Zero)
		{
			CommandEndRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPassDelegate_0>(CommandEndRenderPassPointer);
		}
		CommandExecuteCommandsPointer = GetInstanceProcedureAddress(instance, "CommandExecuteCommands");
		if (CommandExecuteCommandsPointer != IntPtr.Zero)
		{
			CommandExecuteCommands_0 = Marshal.GetDelegateForFunctionPointer<CommandExecuteCommandsDelegate_0>(CommandExecuteCommandsPointer);
		}
		DestroySurfaceKHRPointer = GetInstanceProcedureAddress(instance, "DestroySurfaceKHR");
		if (DestroySurfaceKHRPointer != IntPtr.Zero)
		{
			DestroySurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_0>(DestroySurfaceKHRPointer);
			DestroySurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_1>(DestroySurfaceKHRPointer);
		}
		GetPhysicalDeviceSurfaceSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceSupportKHR");
		if (GetPhysicalDeviceSurfaceSupportKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceSupportKHRDelegate_0>(GetPhysicalDeviceSurfaceSupportKHRPointer);
		}
		GetPhysicalDeviceSurfaceCapabilitiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceCapabilitiesKHR");
		if (GetPhysicalDeviceSurfaceCapabilitiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0>(GetPhysicalDeviceSurfaceCapabilitiesKHRPointer);
		}
		GetPhysicalDeviceSurfaceFormatsKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceFormatsKHR");
		if (GetPhysicalDeviceSurfaceFormatsKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceFormatsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_0>(GetPhysicalDeviceSurfaceFormatsKHRPointer);
			GetPhysicalDeviceSurfaceFormatsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_1>(GetPhysicalDeviceSurfaceFormatsKHRPointer);
		}
		GetPhysicalDeviceSurfacePresentModesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfacePresentModesKHR");
		if (GetPhysicalDeviceSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_0>(GetPhysicalDeviceSurfacePresentModesKHRPointer);
			GetPhysicalDeviceSurfacePresentModesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_1>(GetPhysicalDeviceSurfacePresentModesKHRPointer);
		}
		CreateSwapchainKHRPointer = GetInstanceProcedureAddress(instance, "CreateSwapchainKHR");
		if (CreateSwapchainKHRPointer != IntPtr.Zero)
		{
			CreateSwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_0>(CreateSwapchainKHRPointer);
			CreateSwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_1>(CreateSwapchainKHRPointer);
			CreateSwapchainKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_2>(CreateSwapchainKHRPointer);
			CreateSwapchainKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_3>(CreateSwapchainKHRPointer);
		}
		DestroySwapchainKHRPointer = GetInstanceProcedureAddress(instance, "DestroySwapchainKHR");
		if (DestroySwapchainKHRPointer != IntPtr.Zero)
		{
			DestroySwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_0>(DestroySwapchainKHRPointer);
			DestroySwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_1>(DestroySwapchainKHRPointer);
		}
		GetSwapchainImagesKHRPointer = GetInstanceProcedureAddress(instance, "GetSwapchainImagesKHR");
		if (GetSwapchainImagesKHRPointer != IntPtr.Zero)
		{
			GetSwapchainImagesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_0>(GetSwapchainImagesKHRPointer);
			GetSwapchainImagesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_1>(GetSwapchainImagesKHRPointer);
		}
		AcquireNextImageKHRPointer = GetInstanceProcedureAddress(instance, "AcquireNextImageKHR");
		if (AcquireNextImageKHRPointer != IntPtr.Zero)
		{
			AcquireNextImageKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImageKHRDelegate_0>(AcquireNextImageKHRPointer);
		}
		QueuePresentKHRPointer = GetInstanceProcedureAddress(instance, "QueuePresentKHR");
		if (QueuePresentKHRPointer != IntPtr.Zero)
		{
			QueuePresentKHR_0 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_0>(QueuePresentKHRPointer);
			QueuePresentKHR_1 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_1>(QueuePresentKHRPointer);
		}
		GetPhysicalDeviceDisplayPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayPropertiesKHR");
		if (GetPhysicalDeviceDisplayPropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPropertiesKHRPointer);
			GetPhysicalDeviceDisplayPropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_1>(GetPhysicalDeviceDisplayPropertiesKHRPointer);
		}
		GetPhysicalDeviceDisplayPlanePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayPlanePropertiesKHR");
		if (GetPhysicalDeviceDisplayPlanePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayPlanePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
			GetPhysicalDeviceDisplayPlanePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1>(GetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
		}
		GetDisplayPlaneSupportedDisplaysKHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayPlaneSupportedDisplaysKHR");
		if (GetDisplayPlaneSupportedDisplaysKHRPointer != IntPtr.Zero)
		{
			GetDisplayPlaneSupportedDisplaysKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_0>(GetDisplayPlaneSupportedDisplaysKHRPointer);
			GetDisplayPlaneSupportedDisplaysKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_1>(GetDisplayPlaneSupportedDisplaysKHRPointer);
		}
		GetDisplayModePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayModePropertiesKHR");
		if (GetDisplayModePropertiesKHRPointer != IntPtr.Zero)
		{
			GetDisplayModePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_0>(GetDisplayModePropertiesKHRPointer);
			GetDisplayModePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_1>(GetDisplayModePropertiesKHRPointer);
		}
		CreateDisplayModeKHRPointer = GetInstanceProcedureAddress(instance, "CreateDisplayModeKHR");
		if (CreateDisplayModeKHRPointer != IntPtr.Zero)
		{
			CreateDisplayModeKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_0>(CreateDisplayModeKHRPointer);
			CreateDisplayModeKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_1>(CreateDisplayModeKHRPointer);
			CreateDisplayModeKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_2>(CreateDisplayModeKHRPointer);
			CreateDisplayModeKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_3>(CreateDisplayModeKHRPointer);
		}
		GetDisplayPlaneCapabilitiesKHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayPlaneCapabilitiesKHR");
		if (GetDisplayPlaneCapabilitiesKHRPointer != IntPtr.Zero)
		{
			GetDisplayPlaneCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilitiesKHRDelegate_0>(GetDisplayPlaneCapabilitiesKHRPointer);
		}
		CreateDisplayPlaneSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateDisplayPlaneSurfaceKHR");
		if (CreateDisplayPlaneSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateDisplayPlaneSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_0>(CreateDisplayPlaneSurfaceKHRPointer);
			CreateDisplayPlaneSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_1>(CreateDisplayPlaneSurfaceKHRPointer);
			CreateDisplayPlaneSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_2>(CreateDisplayPlaneSurfaceKHRPointer);
			CreateDisplayPlaneSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_3>(CreateDisplayPlaneSurfaceKHRPointer);
		}
		CreateSharedSwapchainsKHRPointer = GetInstanceProcedureAddress(instance, "CreateSharedSwapchainsKHR");
		if (CreateSharedSwapchainsKHRPointer != IntPtr.Zero)
		{
			CreateSharedSwapchainsKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_0>(CreateSharedSwapchainsKHRPointer);
			CreateSharedSwapchainsKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_1>(CreateSharedSwapchainsKHRPointer);
		}
		CreateXlibSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateXlibSurfaceKHR");
		if (CreateXlibSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateXlibSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_0>(CreateXlibSurfaceKHRPointer);
			CreateXlibSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_1>(CreateXlibSurfaceKHRPointer);
			CreateXlibSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_2>(CreateXlibSurfaceKHRPointer);
			CreateXlibSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_3>(CreateXlibSurfaceKHRPointer);
		}
		GetPhysicalDeviceXlibPresentationSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceXlibPresentationSupportKHR");
		if (GetPhysicalDeviceXlibPresentationSupportKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceXlibPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0>(GetPhysicalDeviceXlibPresentationSupportKHRPointer);
		}
		CreateXcbSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateXcbSurfaceKHR");
		if (CreateXcbSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateXcbSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_0>(CreateXcbSurfaceKHRPointer);
			CreateXcbSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_1>(CreateXcbSurfaceKHRPointer);
			CreateXcbSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_2>(CreateXcbSurfaceKHRPointer);
			CreateXcbSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_3>(CreateXcbSurfaceKHRPointer);
		}
		GetPhysicalDeviceXcbPresentationSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceXcbPresentationSupportKHR");
		if (GetPhysicalDeviceXcbPresentationSupportKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceXcbPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0>(GetPhysicalDeviceXcbPresentationSupportKHRPointer);
		}
		CreateWaylandSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateWaylandSurfaceKHR");
		if (CreateWaylandSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateWaylandSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_0>(CreateWaylandSurfaceKHRPointer);
			CreateWaylandSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_1>(CreateWaylandSurfaceKHRPointer);
			CreateWaylandSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_2>(CreateWaylandSurfaceKHRPointer);
			CreateWaylandSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_3>(CreateWaylandSurfaceKHRPointer);
		}
		GetPhysicalDeviceWaylandPresentationSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceWaylandPresentationSupportKHR");
		if (GetPhysicalDeviceWaylandPresentationSupportKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceWaylandPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0>(GetPhysicalDeviceWaylandPresentationSupportKHRPointer);
		}
		CreateAndroidSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateAndroidSurfaceKHR");
		if (CreateAndroidSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateAndroidSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_0>(CreateAndroidSurfaceKHRPointer);
			CreateAndroidSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_1>(CreateAndroidSurfaceKHRPointer);
			CreateAndroidSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_2>(CreateAndroidSurfaceKHRPointer);
			CreateAndroidSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_3>(CreateAndroidSurfaceKHRPointer);
		}
		CreateWin32SurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateWin32SurfaceKHR");
		if (CreateWin32SurfaceKHRPointer != IntPtr.Zero)
		{
			CreateWin32SurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_0>(CreateWin32SurfaceKHRPointer);
			CreateWin32SurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_1>(CreateWin32SurfaceKHRPointer);
			CreateWin32SurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_2>(CreateWin32SurfaceKHRPointer);
			CreateWin32SurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_3>(CreateWin32SurfaceKHRPointer);
		}
		GetPhysicalDeviceWin32PresentationSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceWin32PresentationSupportKHR");
		if (GetPhysicalDeviceWin32PresentationSupportKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceWin32PresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0>(GetPhysicalDeviceWin32PresentationSupportKHRPointer);
		}
		CreateDebugReportCallbackEXTPointer = GetInstanceProcedureAddress(instance, "CreateDebugReportCallbackEXT");
		if (CreateDebugReportCallbackEXTPointer != IntPtr.Zero)
		{
			CreateDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_0>(CreateDebugReportCallbackEXTPointer);
			CreateDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_1>(CreateDebugReportCallbackEXTPointer);
			CreateDebugReportCallbackEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_2>(CreateDebugReportCallbackEXTPointer);
			CreateDebugReportCallbackEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_3>(CreateDebugReportCallbackEXTPointer);
		}
		DestroyDebugReportCallbackEXTPointer = GetInstanceProcedureAddress(instance, "DestroyDebugReportCallbackEXT");
		if (DestroyDebugReportCallbackEXTPointer != IntPtr.Zero)
		{
			DestroyDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_0>(DestroyDebugReportCallbackEXTPointer);
			DestroyDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_1>(DestroyDebugReportCallbackEXTPointer);
		}
		DebugReportMessageEXTPointer = GetInstanceProcedureAddress(instance, "DebugReportMessageEXT");
		if (DebugReportMessageEXTPointer != IntPtr.Zero)
		{
			DebugReportMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_0>(DebugReportMessageEXTPointer);
		}
		DebugMarkerSetObjectTagEXTPointer = GetInstanceProcedureAddress(instance, "DebugMarkerSetObjectTagEXT");
		if (DebugMarkerSetObjectTagEXTPointer != IntPtr.Zero)
		{
			DebugMarkerSetObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_0>(DebugMarkerSetObjectTagEXTPointer);
			DebugMarkerSetObjectTagEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_1>(DebugMarkerSetObjectTagEXTPointer);
		}
		DebugMarkerSetObjectNameEXTPointer = GetInstanceProcedureAddress(instance, "DebugMarkerSetObjectNameEXT");
		if (DebugMarkerSetObjectNameEXTPointer != IntPtr.Zero)
		{
			DebugMarkerSetObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_0>(DebugMarkerSetObjectNameEXTPointer);
			DebugMarkerSetObjectNameEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_1>(DebugMarkerSetObjectNameEXTPointer);
		}
		CommandDebugMarkerBeginEXTPointer = GetInstanceProcedureAddress(instance, "CommandDebugMarkerBeginEXT");
		if (CommandDebugMarkerBeginEXTPointer != IntPtr.Zero)
		{
			CommandDebugMarkerBeginEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_0>(CommandDebugMarkerBeginEXTPointer);
			CommandDebugMarkerBeginEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_1>(CommandDebugMarkerBeginEXTPointer);
		}
		CommandDebugMarkerEndEXTPointer = GetInstanceProcedureAddress(instance, "CommandDebugMarkerEndEXT");
		if (CommandDebugMarkerEndEXTPointer != IntPtr.Zero)
		{
			CommandDebugMarkerEndEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerEndEXTDelegate_0>(CommandDebugMarkerEndEXTPointer);
		}
		CommandDebugMarkerInsertEXTPointer = GetInstanceProcedureAddress(instance, "CommandDebugMarkerInsertEXT");
		if (CommandDebugMarkerInsertEXTPointer != IntPtr.Zero)
		{
			CommandDebugMarkerInsertEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_0>(CommandDebugMarkerInsertEXTPointer);
			CommandDebugMarkerInsertEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_1>(CommandDebugMarkerInsertEXTPointer);
		}
		CommandDrawIndirectCountAMDPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndirectCountAMD");
		if (CommandDrawIndirectCountAMDPointer != IntPtr.Zero)
		{
			CommandDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountAMDDelegate_0>(CommandDrawIndirectCountAMDPointer);
		}
		CommandDrawIndexedIndirectCountAMDPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndexedIndirectCountAMD");
		if (CommandDrawIndexedIndirectCountAMDPointer != IntPtr.Zero)
		{
			CommandDrawIndexedIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountAMDDelegate_0>(CommandDrawIndexedIndirectCountAMDPointer);
		}
		GetShaderInfoAMDPointer = GetInstanceProcedureAddress(instance, "GetShaderInfoAMD");
		if (GetShaderInfoAMDPointer != IntPtr.Zero)
		{
			GetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_0>(GetShaderInfoAMDPointer);
			GetShaderInfoAMD_1 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_1>(GetShaderInfoAMDPointer);
		}
		GetPhysicalDeviceExternalImageFormatPropertiesNVPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalImageFormatPropertiesNV");
		if (GetPhysicalDeviceExternalImageFormatPropertiesNVPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalImageFormatPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0>(GetPhysicalDeviceExternalImageFormatPropertiesNVPointer);
		}
		GetMemoryWin32HandleNVPointer = GetInstanceProcedureAddress(instance, "GetMemoryWin32HandleNV");
		if (GetMemoryWin32HandleNVPointer != IntPtr.Zero)
		{
			GetMemoryWin32HandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleNVDelegate_0>(GetMemoryWin32HandleNVPointer);
		}
		GetPhysicalDeviceFeatures2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFeatures2KHR");
		if (GetPhysicalDeviceFeatures2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFeatures2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2KHRDelegate_0>(GetPhysicalDeviceFeatures2KHRPointer);
		}
		GetPhysicalDeviceProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceProperties2KHR");
		if (GetPhysicalDeviceProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2KHRDelegate_0>(GetPhysicalDeviceProperties2KHRPointer);
		}
		GetPhysicalDeviceFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFormatProperties2KHR");
		if (GetPhysicalDeviceFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2KHRDelegate_0>(GetPhysicalDeviceFormatProperties2KHRPointer);
		}
		GetPhysicalDeviceImageFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceImageFormatProperties2KHR");
		if (GetPhysicalDeviceImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2KHRDelegate_0>(GetPhysicalDeviceImageFormatProperties2KHRPointer);
			GetPhysicalDeviceImageFormatProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2KHRDelegate_1>(GetPhysicalDeviceImageFormatProperties2KHRPointer);
		}
		GetPhysicalDeviceQueueFamilyProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceQueueFamilyProperties2KHR");
		if (GetPhysicalDeviceQueueFamilyProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0>(GetPhysicalDeviceQueueFamilyProperties2KHRPointer);
			GetPhysicalDeviceQueueFamilyProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1>(GetPhysicalDeviceQueueFamilyProperties2KHRPointer);
		}
		GetPhysicalDeviceMemoryProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMemoryProperties2KHR");
		if (GetPhysicalDeviceMemoryProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMemoryProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2KHRDelegate_0>(GetPhysicalDeviceMemoryProperties2KHRPointer);
		}
		GetPhysicalDeviceSparseImageFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSparseImageFormatProperties2KHR");
		if (GetPhysicalDeviceSparseImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0>(GetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1>(GetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2>(GetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3>(GetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
		}
		GetDeviceGroupPeerMemoryFeaturesKHXPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPeerMemoryFeaturesKHX");
		if (GetDeviceGroupPeerMemoryFeaturesKHXPointer != IntPtr.Zero)
		{
			GetDeviceGroupPeerMemoryFeaturesKHX_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesKHXDelegate_0>(GetDeviceGroupPeerMemoryFeaturesKHXPointer);
		}
		CommandSetDeviceMaskKHXPointer = GetInstanceProcedureAddress(instance, "CommandSetDeviceMaskKHX");
		if (CommandSetDeviceMaskKHXPointer != IntPtr.Zero)
		{
			CommandSetDeviceMaskKHX_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskKHXDelegate_0>(CommandSetDeviceMaskKHXPointer);
		}
		CommandDispatchBaseKHXPointer = GetInstanceProcedureAddress(instance, "CommandDispatchBaseKHX");
		if (CommandDispatchBaseKHXPointer != IntPtr.Zero)
		{
			CommandDispatchBaseKHX_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseKHXDelegate_0>(CommandDispatchBaseKHXPointer);
		}
		GetDeviceGroupPresentCapabilitiesKHXPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPresentCapabilitiesKHX");
		if (GetDeviceGroupPresentCapabilitiesKHXPointer != IntPtr.Zero)
		{
			GetDeviceGroupPresentCapabilitiesKHX_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPresentCapabilitiesKHXDelegate_0>(GetDeviceGroupPresentCapabilitiesKHXPointer);
		}
		GetDeviceGroupSurfacePresentModesKHXPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupSurfacePresentModesKHX");
		if (GetDeviceGroupSurfacePresentModesKHXPointer != IntPtr.Zero)
		{
			GetDeviceGroupSurfacePresentModesKHX_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModesKHXDelegate_0>(GetDeviceGroupSurfacePresentModesKHXPointer);
		}
		GetPhysicalDevicePresentRectanglesKHXPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDevicePresentRectanglesKHX");
		if (GetPhysicalDevicePresentRectanglesKHXPointer != IntPtr.Zero)
		{
			GetPhysicalDevicePresentRectanglesKHX_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHXDelegate_0>(GetPhysicalDevicePresentRectanglesKHXPointer);
			GetPhysicalDevicePresentRectanglesKHX_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHXDelegate_1>(GetPhysicalDevicePresentRectanglesKHXPointer);
		}
		AcquireNextImage2KHXPointer = GetInstanceProcedureAddress(instance, "AcquireNextImage2KHX");
		if (AcquireNextImage2KHXPointer != IntPtr.Zero)
		{
			AcquireNextImage2KHX_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHXDelegate_0>(AcquireNextImage2KHXPointer);
			AcquireNextImage2KHX_1 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHXDelegate_1>(AcquireNextImage2KHXPointer);
		}
		CreateViSurfaceNNPointer = GetInstanceProcedureAddress(instance, "CreateViSurfaceNN");
		if (CreateViSurfaceNNPointer != IntPtr.Zero)
		{
			CreateViSurfaceNN_0 = Marshal.GetDelegateForFunctionPointer<CreateViSurfaceNNDelegate_0>(CreateViSurfaceNNPointer);
			CreateViSurfaceNN_1 = Marshal.GetDelegateForFunctionPointer<CreateViSurfaceNNDelegate_1>(CreateViSurfaceNNPointer);
			CreateViSurfaceNN_2 = Marshal.GetDelegateForFunctionPointer<CreateViSurfaceNNDelegate_2>(CreateViSurfaceNNPointer);
			CreateViSurfaceNN_3 = Marshal.GetDelegateForFunctionPointer<CreateViSurfaceNNDelegate_3>(CreateViSurfaceNNPointer);
		}
		TrimCommandPoolKHRPointer = GetInstanceProcedureAddress(instance, "TrimCommandPoolKHR");
		if (TrimCommandPoolKHRPointer != IntPtr.Zero)
		{
			TrimCommandPoolKHR_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolKHRDelegate_0>(TrimCommandPoolKHRPointer);
		}
		EnumeratePhysicalDeviceGroupsKHXPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDeviceGroupsKHX");
		if (EnumeratePhysicalDeviceGroupsKHXPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDeviceGroupsKHX_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsKHXDelegate_0>(EnumeratePhysicalDeviceGroupsKHXPointer);
			EnumeratePhysicalDeviceGroupsKHX_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsKHXDelegate_1>(EnumeratePhysicalDeviceGroupsKHXPointer);
		}
		GetPhysicalDeviceExternalBufferPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalBufferPropertiesKHR");
		if (GetPhysicalDeviceExternalBufferPropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalBufferPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0>(GetPhysicalDeviceExternalBufferPropertiesKHRPointer);
			GetPhysicalDeviceExternalBufferPropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1>(GetPhysicalDeviceExternalBufferPropertiesKHRPointer);
		}
		GetMemoryWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryWin32HandleKHR");
		if (GetMemoryWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetMemoryWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_0>(GetMemoryWin32HandleKHRPointer);
			GetMemoryWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_1>(GetMemoryWin32HandleKHRPointer);
		}
		GetMemoryWin32HandlePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryWin32HandlePropertiesKHR");
		if (GetMemoryWin32HandlePropertiesKHRPointer != IntPtr.Zero)
		{
			GetMemoryWin32HandlePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandlePropertiesKHRDelegate_0>(GetMemoryWin32HandlePropertiesKHRPointer);
		}
		GetMemoryFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryFileDescriptorKHR");
		if (GetMemoryFileDescriptorKHRPointer != IntPtr.Zero)
		{
			GetMemoryFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_0>(GetMemoryFileDescriptorKHRPointer);
			GetMemoryFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_1>(GetMemoryFileDescriptorKHRPointer);
		}
		GetMemoryFileDescriptorPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryFileDescriptorPropertiesKHR");
		if (GetMemoryFileDescriptorPropertiesKHRPointer != IntPtr.Zero)
		{
			GetMemoryFileDescriptorPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorPropertiesKHRDelegate_0>(GetMemoryFileDescriptorPropertiesKHRPointer);
		}
		GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalSemaphorePropertiesKHR");
		if (GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalSemaphorePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0>(GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer);
			GetPhysicalDeviceExternalSemaphorePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1>(GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer);
		}
		ImportSemaphoreWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "ImportSemaphoreWin32HandleKHR");
		if (ImportSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			ImportSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_0>(ImportSemaphoreWin32HandleKHRPointer);
			ImportSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_1>(ImportSemaphoreWin32HandleKHRPointer);
		}
		GetSemaphoreWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetSemaphoreWin32HandleKHR");
		if (GetSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_0>(GetSemaphoreWin32HandleKHRPointer);
			GetSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_1>(GetSemaphoreWin32HandleKHRPointer);
		}
		ImportSemaphoreFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "ImportSemaphoreFileDescriptorKHR");
		if (ImportSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
		{
			ImportSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_0>(ImportSemaphoreFileDescriptorKHRPointer);
			ImportSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_1>(ImportSemaphoreFileDescriptorKHRPointer);
		}
		GetSemaphoreFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "GetSemaphoreFileDescriptorKHR");
		if (GetSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
		{
			GetSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_0>(GetSemaphoreFileDescriptorKHRPointer);
			GetSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_1>(GetSemaphoreFileDescriptorKHRPointer);
		}
		CommandPushDescriptorSetKHRPointer = GetInstanceProcedureAddress(instance, "CommandPushDescriptorSetKHR");
		if (CommandPushDescriptorSetKHRPointer != IntPtr.Zero)
		{
			CommandPushDescriptorSetKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetKHRDelegate_0>(CommandPushDescriptorSetKHRPointer);
		}
		CreateDescriptorUpdateTemplateKHRPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorUpdateTemplateKHR");
		if (CreateDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			CreateDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_0>(CreateDescriptorUpdateTemplateKHRPointer);
			CreateDescriptorUpdateTemplateKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_1>(CreateDescriptorUpdateTemplateKHRPointer);
			CreateDescriptorUpdateTemplateKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_2>(CreateDescriptorUpdateTemplateKHRPointer);
			CreateDescriptorUpdateTemplateKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_3>(CreateDescriptorUpdateTemplateKHRPointer);
		}
		DestroyDescriptorUpdateTemplateKHRPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorUpdateTemplateKHR");
		if (DestroyDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			DestroyDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateKHRDelegate_0>(DestroyDescriptorUpdateTemplateKHRPointer);
			DestroyDescriptorUpdateTemplateKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateKHRDelegate_1>(DestroyDescriptorUpdateTemplateKHRPointer);
		}
		UpdateDescriptorSetWithTemplateKHRPointer = GetInstanceProcedureAddress(instance, "UpdateDescriptorSetWithTemplateKHR");
		if (UpdateDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			UpdateDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetWithTemplateKHRDelegate_0>(UpdateDescriptorSetWithTemplateKHRPointer);
		}
		CommandPushDescriptorSetWithTemplateKHRPointer = GetInstanceProcedureAddress(instance, "CommandPushDescriptorSetWithTemplateKHR");
		if (CommandPushDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			CommandPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetWithTemplateKHRDelegate_0>(CommandPushDescriptorSetWithTemplateKHRPointer);
		}
		CommandProcessCommandsNVXPointer = GetInstanceProcedureAddress(instance, "CommandProcessCommandsNVX");
		if (CommandProcessCommandsNVXPointer != IntPtr.Zero)
		{
			CommandProcessCommandsNVX_0 = Marshal.GetDelegateForFunctionPointer<CommandProcessCommandsNVXDelegate_0>(CommandProcessCommandsNVXPointer);
			CommandProcessCommandsNVX_1 = Marshal.GetDelegateForFunctionPointer<CommandProcessCommandsNVXDelegate_1>(CommandProcessCommandsNVXPointer);
		}
		CommandReserveSpaceForCommandsNVXPointer = GetInstanceProcedureAddress(instance, "CommandReserveSpaceForCommandsNVX");
		if (CommandReserveSpaceForCommandsNVXPointer != IntPtr.Zero)
		{
			CommandReserveSpaceForCommandsNVX_0 = Marshal.GetDelegateForFunctionPointer<CommandReserveSpaceForCommandsNVXDelegate_0>(CommandReserveSpaceForCommandsNVXPointer);
			CommandReserveSpaceForCommandsNVX_1 = Marshal.GetDelegateForFunctionPointer<CommandReserveSpaceForCommandsNVXDelegate_1>(CommandReserveSpaceForCommandsNVXPointer);
		}
		CreateIndirectCommandsLayoutNVXPointer = GetInstanceProcedureAddress(instance, "CreateIndirectCommandsLayoutNVX");
		if (CreateIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			CreateIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVXDelegate_0>(CreateIndirectCommandsLayoutNVXPointer);
			CreateIndirectCommandsLayoutNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVXDelegate_1>(CreateIndirectCommandsLayoutNVXPointer);
			CreateIndirectCommandsLayoutNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVXDelegate_2>(CreateIndirectCommandsLayoutNVXPointer);
			CreateIndirectCommandsLayoutNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVXDelegate_3>(CreateIndirectCommandsLayoutNVXPointer);
		}
		DestroyIndirectCommandsLayoutNVXPointer = GetInstanceProcedureAddress(instance, "DestroyIndirectCommandsLayoutNVX");
		if (DestroyIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			DestroyIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVXDelegate_0>(DestroyIndirectCommandsLayoutNVXPointer);
			DestroyIndirectCommandsLayoutNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVXDelegate_1>(DestroyIndirectCommandsLayoutNVXPointer);
		}
		CreateObjectTableNVXPointer = GetInstanceProcedureAddress(instance, "CreateObjectTableNVX");
		if (CreateObjectTableNVXPointer != IntPtr.Zero)
		{
			CreateObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateObjectTableNVXDelegate_0>(CreateObjectTableNVXPointer);
			CreateObjectTableNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateObjectTableNVXDelegate_1>(CreateObjectTableNVXPointer);
			CreateObjectTableNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateObjectTableNVXDelegate_2>(CreateObjectTableNVXPointer);
			CreateObjectTableNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateObjectTableNVXDelegate_3>(CreateObjectTableNVXPointer);
		}
		DestroyObjectTableNVXPointer = GetInstanceProcedureAddress(instance, "DestroyObjectTableNVX");
		if (DestroyObjectTableNVXPointer != IntPtr.Zero)
		{
			DestroyObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyObjectTableNVXDelegate_0>(DestroyObjectTableNVXPointer);
			DestroyObjectTableNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyObjectTableNVXDelegate_1>(DestroyObjectTableNVXPointer);
		}
		RegisterObjectsNVXPointer = GetInstanceProcedureAddress(instance, "RegisterObjectsNVX");
		if (RegisterObjectsNVXPointer != IntPtr.Zero)
		{
			RegisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<RegisterObjectsNVXDelegate_0>(RegisterObjectsNVXPointer);
			RegisterObjectsNVX_1 = Marshal.GetDelegateForFunctionPointer<RegisterObjectsNVXDelegate_1>(RegisterObjectsNVXPointer);
			RegisterObjectsNVX_2 = Marshal.GetDelegateForFunctionPointer<RegisterObjectsNVXDelegate_2>(RegisterObjectsNVXPointer);
			RegisterObjectsNVX_3 = Marshal.GetDelegateForFunctionPointer<RegisterObjectsNVXDelegate_3>(RegisterObjectsNVXPointer);
		}
		UnregisterObjectsNVXPointer = GetInstanceProcedureAddress(instance, "UnregisterObjectsNVX");
		if (UnregisterObjectsNVXPointer != IntPtr.Zero)
		{
			UnregisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<UnregisterObjectsNVXDelegate_0>(UnregisterObjectsNVXPointer);
			UnregisterObjectsNVX_1 = Marshal.GetDelegateForFunctionPointer<UnregisterObjectsNVXDelegate_1>(UnregisterObjectsNVXPointer);
			UnregisterObjectsNVX_2 = Marshal.GetDelegateForFunctionPointer<UnregisterObjectsNVXDelegate_2>(UnregisterObjectsNVXPointer);
			UnregisterObjectsNVX_3 = Marshal.GetDelegateForFunctionPointer<UnregisterObjectsNVXDelegate_3>(UnregisterObjectsNVXPointer);
		}
		GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceGeneratedCommandsPropertiesNVX");
		if (GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0>(GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer);
			GetPhysicalDeviceGeneratedCommandsPropertiesNVX_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_1>(GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer);
		}
		CommandSetViewportWScalingNVPointer = GetInstanceProcedureAddress(instance, "CommandSetViewportWScalingNV");
		if (CommandSetViewportWScalingNVPointer != IntPtr.Zero)
		{
			CommandSetViewportWScalingNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_0>(CommandSetViewportWScalingNVPointer);
			CommandSetViewportWScalingNV_1 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_1>(CommandSetViewportWScalingNVPointer);
		}
		ReleaseDisplayEXTPointer = GetInstanceProcedureAddress(instance, "ReleaseDisplayEXT");
		if (ReleaseDisplayEXTPointer != IntPtr.Zero)
		{
			ReleaseDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseDisplayEXTDelegate_0>(ReleaseDisplayEXTPointer);
		}
		AcquireXlibDisplayEXTPointer = GetInstanceProcedureAddress(instance, "AcquireXlibDisplayEXT");
		if (AcquireXlibDisplayEXTPointer != IntPtr.Zero)
		{
			AcquireXlibDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireXlibDisplayEXTDelegate_0>(AcquireXlibDisplayEXTPointer);
		}
		GetRandROutputDisplayEXTPointer = GetInstanceProcedureAddress(instance, "GetRandROutputDisplayEXT");
		if (GetRandROutputDisplayEXTPointer != IntPtr.Zero)
		{
			GetRandROutputDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<GetRandROutputDisplayEXTDelegate_0>(GetRandROutputDisplayEXTPointer);
		}
		GetPhysicalDeviceSurfaceCapabilities2EXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceCapabilities2EXT");
		if (GetPhysicalDeviceSurfaceCapabilities2EXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilities2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0>(GetPhysicalDeviceSurfaceCapabilities2EXTPointer);
		}
		DisplayPowerControlEXTPointer = GetInstanceProcedureAddress(instance, "DisplayPowerControlEXT");
		if (DisplayPowerControlEXTPointer != IntPtr.Zero)
		{
			DisplayPowerControlEXT_0 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_0>(DisplayPowerControlEXTPointer);
			DisplayPowerControlEXT_1 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_1>(DisplayPowerControlEXTPointer);
		}
		RegisterDeviceEventEXTPointer = GetInstanceProcedureAddress(instance, "RegisterDeviceEventEXT");
		if (RegisterDeviceEventEXTPointer != IntPtr.Zero)
		{
			RegisterDeviceEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_0>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_1 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_1>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_2 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_2>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_3 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_3>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_4 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_4>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_5 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_5>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_6 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_6>(RegisterDeviceEventEXTPointer);
			RegisterDeviceEventEXT_7 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_7>(RegisterDeviceEventEXTPointer);
		}
		RegisterDisplayEventEXTPointer = GetInstanceProcedureAddress(instance, "RegisterDisplayEventEXT");
		if (RegisterDisplayEventEXTPointer != IntPtr.Zero)
		{
			RegisterDisplayEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_0>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_1 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_1>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_2 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_2>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_3 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_3>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_4 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_4>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_5 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_5>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_6 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_6>(RegisterDisplayEventEXTPointer);
			RegisterDisplayEventEXT_7 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_7>(RegisterDisplayEventEXTPointer);
		}
		GetSwapchainCounterEXTPointer = GetInstanceProcedureAddress(instance, "GetSwapchainCounterEXT");
		if (GetSwapchainCounterEXTPointer != IntPtr.Zero)
		{
			GetSwapchainCounterEXT_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainCounterEXTDelegate_0>(GetSwapchainCounterEXTPointer);
		}
		GetRefreshCycleDurationGOOGLEPointer = GetInstanceProcedureAddress(instance, "GetRefreshCycleDurationGOOGLE");
		if (GetRefreshCycleDurationGOOGLEPointer != IntPtr.Zero)
		{
			GetRefreshCycleDurationGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetRefreshCycleDurationGOOGLEDelegate_0>(GetRefreshCycleDurationGOOGLEPointer);
		}
		GetPastPresentationTimingGOOGLEPointer = GetInstanceProcedureAddress(instance, "GetPastPresentationTimingGOOGLE");
		if (GetPastPresentationTimingGOOGLEPointer != IntPtr.Zero)
		{
			GetPastPresentationTimingGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_0>(GetPastPresentationTimingGOOGLEPointer);
			GetPastPresentationTimingGOOGLE_1 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_1>(GetPastPresentationTimingGOOGLEPointer);
		}
		CommandSetDiscardRectangleEXTPointer = GetInstanceProcedureAddress(instance, "CommandSetDiscardRectangleEXT");
		if (CommandSetDiscardRectangleEXTPointer != IntPtr.Zero)
		{
			CommandSetDiscardRectangleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDiscardRectangleEXTDelegate_0>(CommandSetDiscardRectangleEXTPointer);
		}
		SetHdrMetadataEXTPointer = GetInstanceProcedureAddress(instance, "SetHdrMetadataEXT");
		if (SetHdrMetadataEXTPointer != IntPtr.Zero)
		{
			SetHdrMetadataEXT_0 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_0>(SetHdrMetadataEXTPointer);
			SetHdrMetadataEXT_1 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_1>(SetHdrMetadataEXTPointer);
		}
		GetSwapchainStatusKHRPointer = GetInstanceProcedureAddress(instance, "GetSwapchainStatusKHR");
		if (GetSwapchainStatusKHRPointer != IntPtr.Zero)
		{
			GetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainStatusKHRDelegate_0>(GetSwapchainStatusKHRPointer);
		}
		GetPhysicalDeviceExternalFencePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalFencePropertiesKHR");
		if (GetPhysicalDeviceExternalFencePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalFencePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0>(GetPhysicalDeviceExternalFencePropertiesKHRPointer);
			GetPhysicalDeviceExternalFencePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1>(GetPhysicalDeviceExternalFencePropertiesKHRPointer);
		}
		ImportFenceWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "ImportFenceWin32HandleKHR");
		if (ImportFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			ImportFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_0>(ImportFenceWin32HandleKHRPointer);
			ImportFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_1>(ImportFenceWin32HandleKHRPointer);
		}
		GetFenceWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetFenceWin32HandleKHR");
		if (GetFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_0>(GetFenceWin32HandleKHRPointer);
			GetFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_1>(GetFenceWin32HandleKHRPointer);
		}
		ImportFenceFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "ImportFenceFileDescriptorKHR");
		if (ImportFenceFileDescriptorKHRPointer != IntPtr.Zero)
		{
			ImportFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_0>(ImportFenceFileDescriptorKHRPointer);
			ImportFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_1>(ImportFenceFileDescriptorKHRPointer);
		}
		GetFenceFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "GetFenceFileDescriptorKHR");
		if (GetFenceFileDescriptorKHRPointer != IntPtr.Zero)
		{
			GetFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_0>(GetFenceFileDescriptorKHRPointer);
			GetFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_1>(GetFenceFileDescriptorKHRPointer);
		}
		GetPhysicalDeviceSurfaceCapabilities2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceCapabilities2KHR");
		if (GetPhysicalDeviceSurfaceCapabilities2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0>(GetPhysicalDeviceSurfaceCapabilities2KHRPointer);
			GetPhysicalDeviceSurfaceCapabilities2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1>(GetPhysicalDeviceSurfaceCapabilities2KHRPointer);
		}
		GetPhysicalDeviceSurfaceFormats2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceFormats2KHR");
		if (GetPhysicalDeviceSurfaceFormats2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceFormats2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_0>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
			GetPhysicalDeviceSurfaceFormats2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_1>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
			GetPhysicalDeviceSurfaceFormats2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_2>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
			GetPhysicalDeviceSurfaceFormats2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_3>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
		}
		CreateIOSSurfaceMVKPointer = GetInstanceProcedureAddress(instance, "CreateIOSSurfaceMVK");
		if (CreateIOSSurfaceMVKPointer != IntPtr.Zero)
		{
			CreateIOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<CreateIOSSurfaceMVKDelegate_0>(CreateIOSSurfaceMVKPointer);
			CreateIOSSurfaceMVK_1 = Marshal.GetDelegateForFunctionPointer<CreateIOSSurfaceMVKDelegate_1>(CreateIOSSurfaceMVKPointer);
			CreateIOSSurfaceMVK_2 = Marshal.GetDelegateForFunctionPointer<CreateIOSSurfaceMVKDelegate_2>(CreateIOSSurfaceMVKPointer);
			CreateIOSSurfaceMVK_3 = Marshal.GetDelegateForFunctionPointer<CreateIOSSurfaceMVKDelegate_3>(CreateIOSSurfaceMVKPointer);
		}
		CreateMacOSSurfaceMVKPointer = GetInstanceProcedureAddress(instance, "CreateMacOSSurfaceMVK");
		if (CreateMacOSSurfaceMVKPointer != IntPtr.Zero)
		{
			CreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_0>(CreateMacOSSurfaceMVKPointer);
			CreateMacOSSurfaceMVK_1 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_1>(CreateMacOSSurfaceMVKPointer);
			CreateMacOSSurfaceMVK_2 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_2>(CreateMacOSSurfaceMVKPointer);
			CreateMacOSSurfaceMVK_3 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_3>(CreateMacOSSurfaceMVKPointer);
		}
		CommandSetSampleLocationsEXTPointer = GetInstanceProcedureAddress(instance, "CommandSetSampleLocationsEXT");
		if (CommandSetSampleLocationsEXTPointer != IntPtr.Zero)
		{
			CommandSetSampleLocationsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_0>(CommandSetSampleLocationsEXTPointer);
			CommandSetSampleLocationsEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_1>(CommandSetSampleLocationsEXTPointer);
		}
		GetPhysicalDeviceMultisamplePropertiesEXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMultisamplePropertiesEXT");
		if (GetPhysicalDeviceMultisamplePropertiesEXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMultisamplePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0>(GetPhysicalDeviceMultisamplePropertiesEXTPointer);
		}
		GetImageMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetImageMemoryRequirements2KHR");
		if (GetImageMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetImageMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2KHRDelegate_0>(GetImageMemoryRequirements2KHRPointer);
			GetImageMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2KHRDelegate_1>(GetImageMemoryRequirements2KHRPointer);
		}
		GetBufferMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetBufferMemoryRequirements2KHR");
		if (GetBufferMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetBufferMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2KHRDelegate_0>(GetBufferMemoryRequirements2KHRPointer);
			GetBufferMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2KHRDelegate_1>(GetBufferMemoryRequirements2KHRPointer);
		}
		GetImageSparseMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetImageSparseMemoryRequirements2KHR");
		if (GetImageSparseMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetImageSparseMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_0>(GetImageSparseMemoryRequirements2KHRPointer);
			GetImageSparseMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_1>(GetImageSparseMemoryRequirements2KHRPointer);
			GetImageSparseMemoryRequirements2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_2>(GetImageSparseMemoryRequirements2KHRPointer);
			GetImageSparseMemoryRequirements2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_3>(GetImageSparseMemoryRequirements2KHRPointer);
		}
		CreateSamplerYcbcrConversionKHRPointer = GetInstanceProcedureAddress(instance, "CreateSamplerYcbcrConversionKHR");
		if (CreateSamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			CreateSamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_0>(CreateSamplerYcbcrConversionKHRPointer);
			CreateSamplerYcbcrConversionKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_1>(CreateSamplerYcbcrConversionKHRPointer);
			CreateSamplerYcbcrConversionKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_2>(CreateSamplerYcbcrConversionKHRPointer);
			CreateSamplerYcbcrConversionKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_3>(CreateSamplerYcbcrConversionKHRPointer);
		}
		DestroySamplerYcbcrConversionKHRPointer = GetInstanceProcedureAddress(instance, "DestroySamplerYcbcrConversionKHR");
		if (DestroySamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			DestroySamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionKHRDelegate_0>(DestroySamplerYcbcrConversionKHRPointer);
			DestroySamplerYcbcrConversionKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionKHRDelegate_1>(DestroySamplerYcbcrConversionKHRPointer);
		}
		BindBufferMemory2KHRPointer = GetInstanceProcedureAddress(instance, "BindBufferMemory2KHR");
		if (BindBufferMemory2KHRPointer != IntPtr.Zero)
		{
			BindBufferMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2KHRDelegate_0>(BindBufferMemory2KHRPointer);
		}
		BindImageMemory2KHRPointer = GetInstanceProcedureAddress(instance, "BindImageMemory2KHR");
		if (BindImageMemory2KHRPointer != IntPtr.Zero)
		{
			BindImageMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2KHRDelegate_0>(BindImageMemory2KHRPointer);
		}
		CreateValidationCacheEXTPointer = GetInstanceProcedureAddress(instance, "CreateValidationCacheEXT");
		if (CreateValidationCacheEXTPointer != IntPtr.Zero)
		{
			CreateValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_0>(CreateValidationCacheEXTPointer);
			CreateValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_1>(CreateValidationCacheEXTPointer);
			CreateValidationCacheEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_2>(CreateValidationCacheEXTPointer);
			CreateValidationCacheEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_3>(CreateValidationCacheEXTPointer);
		}
		DestroyValidationCacheEXTPointer = GetInstanceProcedureAddress(instance, "DestroyValidationCacheEXT");
		if (DestroyValidationCacheEXTPointer != IntPtr.Zero)
		{
			DestroyValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_0>(DestroyValidationCacheEXTPointer);
			DestroyValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_1>(DestroyValidationCacheEXTPointer);
		}
		MergeValidationCachesEXTPointer = GetInstanceProcedureAddress(instance, "MergeValidationCachesEXT");
		if (MergeValidationCachesEXTPointer != IntPtr.Zero)
		{
			MergeValidationCachesEXT_0 = Marshal.GetDelegateForFunctionPointer<MergeValidationCachesEXTDelegate_0>(MergeValidationCachesEXTPointer);
		}
		GetValidationCacheDataEXTPointer = GetInstanceProcedureAddress(instance, "GetValidationCacheDataEXT");
		if (GetValidationCacheDataEXTPointer != IntPtr.Zero)
		{
			GetValidationCacheDataEXT_0 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_0>(GetValidationCacheDataEXTPointer);
			GetValidationCacheDataEXT_1 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_1>(GetValidationCacheDataEXTPointer);
		}
		GetMemoryHostPointerPropertiesEXTPointer = GetInstanceProcedureAddress(instance, "GetMemoryHostPointerPropertiesEXT");
		if (GetMemoryHostPointerPropertiesEXTPointer != IntPtr.Zero)
		{
			GetMemoryHostPointerPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryHostPointerPropertiesEXTDelegate_0>(GetMemoryHostPointerPropertiesEXTPointer);
		}
		CommandWriteBufferMarkerAMDPointer = GetInstanceProcedureAddress(instance, "CommandWriteBufferMarkerAMD");
		if (CommandWriteBufferMarkerAMDPointer != IntPtr.Zero)
		{
			CommandWriteBufferMarkerAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteBufferMarkerAMDDelegate_0>(CommandWriteBufferMarkerAMDPointer);
		}
	}
}
