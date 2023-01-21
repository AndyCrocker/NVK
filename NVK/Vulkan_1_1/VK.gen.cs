// This file was generated, don't manually edit
namespace Vulkan_1_1;

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
	public const uint MaxDeviceGroupSize = 32;
	public const uint LuidSize = 8;
	public const uint QueueFamilyExternal = ~0U-1;
	public const uint KhrSurfaceSpecVersion = 25;
	public const string KhrSurfaceExtensionName = "VK_KHR_surface";
	public const uint KhrSwapchainSpecVersion = 70;
	public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
	public const uint KhrDisplaySpecVersion = 23;
	public const string KhrDisplayExtensionName = "VK_KHR_display";
	public const uint KhrDisplaySwapchainSpecVersion = 10;
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
	public const uint KhrSamplerMirrorClampToEdgeSpecVersion = 3;
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
	public const uint ExtTransformFeedbackSpecVersion = 1;
	public const string ExtTransformFeedbackExtensionName = "VK_EXT_transform_feedback";
	public const uint NvxImageViewHandleSpecVersion = 1;
	public const string NvxImageViewHandleExtensionName = "VK_NVX_image_view_handle";
	public const uint AmdDrawIndirectCountSpecVersion = 2;
	public const string AmdDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
	public const uint AmdNegativeViewportHeightSpecVersion = 1;
	public const string AmdNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
	public const uint AmdGpuShaderHalfFloatSpecVersion = 2;
	public const string AmdGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
	public const uint AmdShaderBallotSpecVersion = 1;
	public const string AmdShaderBallotExtensionName = "VK_AMD_shader_ballot";
	public const uint AmdTextureGatherBiasLodSpecVersion = 1;
	public const string AmdTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
	public const uint AmdShaderInfoSpecVersion = 1;
	public const string AmdShaderInfoExtensionName = "VK_AMD_shader_info";
	public const uint AmdShaderImageLoadStoreLodSpecVersion = 1;
	public const string AmdShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
	public const uint NvCornerSampledImageSpecVersion = 2;
	public const string NvCornerSampledImageExtensionName = "VK_NV_corner_sampled_image";
	public const uint KhrMultiviewSpecVersion = 1;
	public const string KhrMultiviewExtensionName = "VK_KHR_multiview";
	public const uint ImgFormatPvrtcSpecVersion = 1;
	public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
	public const uint NvExternalMemoryCapabilitiesSpecVersion = 1;
	public const string NvExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
	public const uint NvExternalMemorySpecVersion = 1;
	public const string NvExternalMemoryExtensionName = "VK_NV_external_memory";
	public const uint NvExternalMemoryWin32SpecVersion = 1;
	public const string NvExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
	public const uint NvWin32KeyedMutexSpecVersion = 2;
	public const string NvWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
	public const uint KhrGetPhysicalDeviceProperties2SpecVersion = 2;
	public const string KhrGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
	public const uint KhrDeviceGroupSpecVersion = 4;
	public const string KhrDeviceGroupExtensionName = "VK_KHR_device_group";
	public const uint ExtValidationFlagsSpecVersion = 2;
	public const string ExtValidationFlagsExtensionName = "VK_EXT_validation_flags";
	public const uint KhrShaderDrawParametersSpecVersion = 1;
	public const string KhrShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
	public const uint ExtShaderSubgroupBallotSpecVersion = 1;
	public const string ExtShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
	public const uint ExtShaderSubgroupVoteSpecVersion = 1;
	public const string ExtShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
	public const uint ExtTextureCompressionAstcHdrSpecVersion = 1;
	public const string ExtTextureCompressionAstcHdrExtensionName = "VK_EXT_texture_compression_astc_hdr";
	public const uint ExtAstcDecodeModeSpecVersion = 1;
	public const string ExtAstcDecodeModeExtensionName = "VK_EXT_astc_decode_mode";
	public const uint KhrMaintenance1SpecVersion = 2;
	public const string KhrMaintenance1ExtensionName = "VK_KHR_maintenance1";
	[Obsolete("Use MaxDeviceGroupSize")]
	public const uint MaxDeviceGroupSizeKhr = MaxDeviceGroupSize;
	public const uint KhrDeviceGroupCreationSpecVersion = 1;
	public const string KhrDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
	[Obsolete("Use LuidSize")]
	public const uint LuidSizeKhr = LuidSize;
	public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
	public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
	[Obsolete("Use QueueFamilyExternal")]
	public const uint QueueFamilyExternalKhr = QueueFamilyExternal;
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
	public const uint KhrPushDescriptorSpecVersion = 2;
	public const string KhrPushDescriptorExtensionName = "VK_KHR_push_descriptor";
	public const uint ExtConditionalRenderingSpecVersion = 2;
	public const string ExtConditionalRenderingExtensionName = "VK_EXT_conditional_rendering";
	public const uint KhrShaderFloat16Int8SpecVersion = 1;
	public const string KhrShaderFloat16Int8ExtensionName = "VK_KHR_shader_float16_int8";
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
	public const uint ExtDepthClipEnableSpecVersion = 1;
	public const string ExtDepthClipEnableExtensionName = "VK_EXT_depth_clip_enable";
	public const uint ExtSwapchainColorSpaceSpecVersion = 4;
	public const string ExtSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
	public const uint ExtHdrMetadataSpecVersion = 2;
	public const string ExtHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
	public const uint KhrImagelessFramebufferSpecVersion = 1;
	public const string KhrImagelessFramebufferExtensionName = "VK_KHR_imageless_framebuffer";
	public const uint KhrCreateRenderpass2SpecVersion = 1;
	public const string KhrCreateRenderpass2ExtensionName = "VK_KHR_create_renderpass2";
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
	public const uint KhrPerformanceQuerySpecVersion = 1;
	public const string KhrPerformanceQueryExtensionName = "VK_KHR_performance_query";
	public const uint KhrMaintenance2SpecVersion = 1;
	public const string KhrMaintenance2ExtensionName = "VK_KHR_maintenance2";
	public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
	public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
	public const uint KhrVariablePointersSpecVersion = 1;
	public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
	public const uint KhrGetDisplayProperties2SpecVersion = 1;
	public const string KhrGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
	public const uint MvkMacosSurfaceSpecVersion = 2;
	public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
	public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
	public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
	public const uint QueueFamilyForeignExt = ~0U-2;
	public const uint ExtQueueFamilyForeignSpecVersion = 1;
	public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
	public const uint KhrDedicatedAllocationSpecVersion = 3;
	public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
	public const uint ExtDebugUtilsSpecVersion = 1;
	public const string ExtDebugUtilsExtensionName = "VK_EXT_debug_utils";
	public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 3;
	public const string AndroidExternalMemoryAndroidHardwareBufferExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
	public const uint ExtSamplerFilterMinmaxSpecVersion = 2;
	public const string ExtSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
	public const uint KhrStorageBufferStorageClassSpecVersion = 1;
	public const string KhrStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
	public const uint AmdGpuShaderInt16SpecVersion = 2;
	public const string AmdGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
	public const uint AmdMixedAttachmentSamplesSpecVersion = 1;
	public const string AmdMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
	public const uint AmdShaderFragmentMaskSpecVersion = 1;
	public const string AmdShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
	public const uint ExtInlineUniformBlockSpecVersion = 1;
	public const string ExtInlineUniformBlockExtensionName = "VK_EXT_inline_uniform_block";
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
	public const uint NvShaderSmBuiltinsSpecVersion = 1;
	public const string NvShaderSmBuiltinsExtensionName = "VK_NV_shader_sm_builtins";
	public const uint ExtPostDepthCoverageSpecVersion = 1;
	public const string ExtPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
	public const uint KhrSamplerYcbcrConversionSpecVersion = 14;
	public const string KhrSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
	public const uint KhrBindMemory2SpecVersion = 1;
	public const string KhrBindMemory2ExtensionName = "VK_KHR_bind_memory2";
	public const uint ExtImageDrmFormatModifierSpecVersion = 1;
	public const string ExtImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
	public const uint ExtValidationCacheSpecVersion = 1;
	public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
	public const uint ExtDescriptorIndexingSpecVersion = 2;
	public const string ExtDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
	public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
	public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
	public const uint NvShadingRateImageSpecVersion = 3;
	public const string NvShadingRateImageExtensionName = "VK_NV_shading_rate_image";
	public const uint ShaderUnusedNv = ~0U;
	public const uint NvRayTracingSpecVersion = 3;
	public const string NvRayTracingExtensionName = "VK_NV_ray_tracing";
	public const uint NvRepresentativeFragmentTestSpecVersion = 2;
	public const string NvRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
	public const uint KhrMaintenance3SpecVersion = 1;
	public const string KhrMaintenance3ExtensionName = "VK_KHR_maintenance3";
	public const uint KhrDrawIndirectCountSpecVersion = 1;
	public const string KhrDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
	public const uint ExtFilterCubicSpecVersion = 2;
	public const string ExtFilterCubicExtensionName = "VK_EXT_filter_cubic";
	public const uint ExtGlobalPrioritySpecVersion = 2;
	public const string ExtGlobalPriorityExtensionName = "VK_EXT_global_priority";
	public const uint KhrShaderSubgroupExtendedTypesSpecVersion = 1;
	public const string KhrShaderSubgroupExtendedTypesExtensionName = "VK_KHR_shader_subgroup_extended_types";
	public const uint Khr8bitStorageSpecVersion = 1;
	public const string Khr8bitStorageExtensionName = "VK_KHR_8bit_storage";
	public const uint ExtExternalMemoryHostSpecVersion = 1;
	public const string ExtExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
	public const uint AmdBufferMarkerSpecVersion = 1;
	public const string AmdBufferMarkerExtensionName = "VK_AMD_buffer_marker";
	public const uint KhrShaderAtomicInt64SpecVersion = 1;
	public const string KhrShaderAtomicInt64ExtensionName = "VK_KHR_shader_atomic_int64";
	public const uint KhrShaderClockSpecVersion = 1;
	public const string KhrShaderClockExtensionName = "VK_KHR_shader_clock";
	public const uint AmdPipelineCompilerControlSpecVersion = 1;
	public const string AmdPipelineCompilerControlExtensionName = "VK_AMD_pipeline_compiler_control";
	public const uint ExtCalibratedTimestampsSpecVersion = 1;
	public const string ExtCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
	public const uint AmdShaderCorePropertiesSpecVersion = 2;
	public const string AmdShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
	public const uint AmdMemoryOverallocationBehaviorSpecVersion = 1;
	public const string AmdMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
	public const uint ExtVertexAttributeDivisorSpecVersion = 3;
	public const string ExtVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
	public const uint ExtPipelineCreationFeedbackSpecVersion = 1;
	public const string ExtPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
	public const uint MaxDriverNameSizeKhr = 256;
	public const uint MaxDriverInfoSizeKhr = 256;
	public const uint KhrDriverPropertiesSpecVersion = 1;
	public const string KhrDriverPropertiesExtensionName = "VK_KHR_driver_properties";
	public const uint KhrShaderFloatControlsSpecVersion = 4;
	public const string KhrShaderFloatControlsExtensionName = "VK_KHR_shader_float_controls";
	public const uint NvShaderSubgroupPartitionedSpecVersion = 1;
	public const string NvShaderSubgroupPartitionedExtensionName = "VK_NV_shader_subgroup_partitioned";
	public const uint KhrDepthStencilResolveSpecVersion = 1;
	public const string KhrDepthStencilResolveExtensionName = "VK_KHR_depth_stencil_resolve";
	public const uint KhrSwapchainMutableFormatSpecVersion = 1;
	public const string KhrSwapchainMutableFormatExtensionName = "VK_KHR_swapchain_mutable_format";
	public const uint NvComputeShaderDerivativesSpecVersion = 1;
	public const string NvComputeShaderDerivativesExtensionName = "VK_NV_compute_shader_derivatives";
	public const uint NvMeshShaderSpecVersion = 1;
	public const string NvMeshShaderExtensionName = "VK_NV_mesh_shader";
	public const uint NvFragmentShaderBarycentricSpecVersion = 1;
	public const string NvFragmentShaderBarycentricExtensionName = "VK_NV_fragment_shader_barycentric";
	public const uint NvShaderImageFootprintSpecVersion = 2;
	public const string NvShaderImageFootprintExtensionName = "VK_NV_shader_image_footprint";
	public const uint NvScissorExclusiveSpecVersion = 1;
	public const string NvScissorExclusiveExtensionName = "VK_NV_scissor_exclusive";
	public const uint NvDeviceDiagnosticCheckpointsSpecVersion = 2;
	public const string NvDeviceDiagnosticCheckpointsExtensionName = "VK_NV_device_diagnostic_checkpoints";
	public const uint KhrTimelineSemaphoreSpecVersion = 2;
	public const string KhrTimelineSemaphoreExtensionName = "VK_KHR_timeline_semaphore";
	public const uint IntelShaderIntegerFunctions2SpecVersion = 1;
	public const string IntelShaderIntegerFunctions2ExtensionName = "VK_INTEL_shader_integer_functions2";
	public const uint IntelPerformanceQuerySpecVersion = 1;
	public const string IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
	public const uint KhrVulkanMemoryModelSpecVersion = 3;
	public const string KhrVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
	public const uint ExtPciBusInfoSpecVersion = 2;
	public const string ExtPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
	public const uint AmdDisplayNativeHdrSpecVersion = 1;
	public const string AmdDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
	public const uint ExtFragmentDensityMapSpecVersion = 1;
	public const string ExtFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
	public const uint ExtScalarBlockLayoutSpecVersion = 1;
	public const string ExtScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
	public const uint GoogleHlslFunctionality1SpecVersion = 1;
	public const string GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
	public const uint GoogleDecorateStringSpecVersion = 1;
	public const string GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
	public const uint ExtSubgroupSizeControlSpecVersion = 2;
	public const string ExtSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
	public const uint AmdShaderCoreProperties2SpecVersion = 1;
	public const string AmdShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
	public const uint AmdDeviceCoherentMemorySpecVersion = 1;
	public const string AmdDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
	public const uint KhrSpirv14SpecVersion = 1;
	public const string KhrSpirv14ExtensionName = "VK_KHR_spirv_1_4";
	public const uint ExtMemoryBudgetSpecVersion = 1;
	public const string ExtMemoryBudgetExtensionName = "VK_EXT_memory_budget";
	public const uint ExtMemoryPrioritySpecVersion = 1;
	public const string ExtMemoryPriorityExtensionName = "VK_EXT_memory_priority";
	public const uint KhrSurfaceProtectedCapabilitiesSpecVersion = 1;
	public const string KhrSurfaceProtectedCapabilitiesExtensionName = "VK_KHR_surface_protected_capabilities";
	public const uint NvDedicatedAllocationImageAliasingSpecVersion = 1;
	public const string NvDedicatedAllocationImageAliasingExtensionName = "VK_NV_dedicated_allocation_image_aliasing";
	public const uint KhrSeparateDepthStencilLayoutsSpecVersion = 1;
	public const string KhrSeparateDepthStencilLayoutsExtensionName = "VK_KHR_separate_depth_stencil_layouts";
	public const uint ExtBufferDeviceAddressSpecVersion = 2;
	public const string ExtBufferDeviceAddressExtensionName = "VK_EXT_buffer_device_address";
	public const uint ExtToolingInfoSpecVersion = 1;
	public const string ExtToolingInfoExtensionName = "VK_EXT_tooling_info";
	public const uint ExtSeparateStencilUsageSpecVersion = 1;
	public const string ExtSeparateStencilUsageExtensionName = "VK_EXT_separate_stencil_usage";
	public const uint ExtValidationFeaturesSpecVersion = 2;
	public const string ExtValidationFeaturesExtensionName = "VK_EXT_validation_features";
	public const uint NvCooperativeMatrixSpecVersion = 1;
	public const string NvCooperativeMatrixExtensionName = "VK_NV_cooperative_matrix";
	public const uint NvCoverageReductionModeSpecVersion = 1;
	public const string NvCoverageReductionModeExtensionName = "VK_NV_coverage_reduction_mode";
	public const uint ExtFragmentShaderInterlockSpecVersion = 1;
	public const string ExtFragmentShaderInterlockExtensionName = "VK_EXT_fragment_shader_interlock";
	public const uint ExtYcbcrImageArraysSpecVersion = 1;
	public const string ExtYcbcrImageArraysExtensionName = "VK_EXT_ycbcr_image_arrays";
	public const uint KhrUniformBufferStandardLayoutSpecVersion = 1;
	public const string KhrUniformBufferStandardLayoutExtensionName = "VK_KHR_uniform_buffer_standard_layout";
	public const uint ExtFullScreenExclusiveSpecVersion = 4;
	public const string ExtFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
	public const uint ExtHeadlessSurfaceSpecVersion = 1;
	public const string ExtHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
	public const uint KhrBufferDeviceAddressSpecVersion = 1;
	public const string KhrBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
	public const uint ExtLineRasterizationSpecVersion = 1;
	public const string ExtLineRasterizationExtensionName = "VK_EXT_line_rasterization";
	public const uint ExtHostQueryResetSpecVersion = 1;
	public const string ExtHostQueryResetExtensionName = "VK_EXT_host_query_reset";
	public const uint ExtIndexTypeUint8SpecVersion = 1;
	public const string ExtIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
	public const uint KhrPipelineExecutablePropertiesSpecVersion = 1;
	public const string KhrPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
	public const uint ExtShaderDemoteToHelperInvocationSpecVersion = 1;
	public const string ExtShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
	public const uint ExtTexelBufferAlignmentSpecVersion = 1;
	public const string ExtTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
	public const uint GoogleUserTypeSpecVersion = 1;
	public const string GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
	public static VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance) => vkCreateInstance_0(pCreateInfo, pAllocator, pInstance);
	private delegate VkResult vkCreateInstanceDelegate_0(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
	private static IntPtr vkCreateInstancePointer;
	private static vkCreateInstanceDelegate_0 vkCreateInstance_0;
	public static void vkDestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator) => vkDestroyInstance_0(instance, pAllocator);
	private delegate void vkDestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyInstancePointer;
	private static vkDestroyInstanceDelegate_0 vkDestroyInstance_0;
	public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices) => vkEnumeratePhysicalDevices_0(instance, pPhysicalDeviceCount, pPhysicalDevices);
	private delegate VkResult vkEnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
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
	public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) => vkGetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyPropertiesPointer;
	private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate_0 vkGetPhysicalDeviceQueueFamilyProperties_0;
	public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties) => vkGetPhysicalDeviceMemoryProperties_0(physicalDevice, pMemoryProperties);
	private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
	private static IntPtr vkGetPhysicalDeviceMemoryPropertiesPointer;
	private static vkGetPhysicalDeviceMemoryPropertiesDelegate_0 vkGetPhysicalDeviceMemoryProperties_0;
	public static PFN_vkVoidFunction vkGetInstanceProcAddr(VkInstance instance, char* pName) => vkGetInstanceProcAddr_0(instance, pName);
	private delegate PFN_vkVoidFunction vkGetInstanceProcAddrDelegate_0(VkInstance instance, char* pName);
	private static IntPtr vkGetInstanceProcAddrPointer;
	private static vkGetInstanceProcAddrDelegate_0 vkGetInstanceProcAddr_0;
	public static PFN_vkVoidFunction vkGetDeviceProcAddr(VkDevice device, char* pName) => vkGetDeviceProcAddr_0(device, pName);
	private delegate PFN_vkVoidFunction vkGetDeviceProcAddrDelegate_0(VkDevice device, char* pName);
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
	public static VkResult vkEnumerateInstanceExtensionProperties(char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties) => vkEnumerateInstanceExtensionProperties_0(pLayerName, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate_0(char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr vkEnumerateInstanceExtensionPropertiesPointer;
	private static vkEnumerateInstanceExtensionPropertiesDelegate_0 vkEnumerateInstanceExtensionProperties_0;
	public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties) => vkEnumerateDeviceExtensionProperties_0(physicalDevice, pLayerName, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr vkEnumerateDeviceExtensionPropertiesPointer;
	private static vkEnumerateDeviceExtensionPropertiesDelegate_0 vkEnumerateDeviceExtensionProperties_0;
	public static VkResult vkEnumerateInstanceLayerProperties(uint32_t* pPropertyCount, VkLayerProperties* pProperties) => vkEnumerateInstanceLayerProperties_0(pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate_0(uint32_t* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr vkEnumerateInstanceLayerPropertiesPointer;
	private static vkEnumerateInstanceLayerPropertiesDelegate_0 vkEnumerateInstanceLayerProperties_0;
	public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkLayerProperties* pProperties) => vkEnumerateDeviceLayerProperties_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr vkEnumerateDeviceLayerPropertiesPointer;
	private static vkEnumerateDeviceLayerPropertiesDelegate_0 vkEnumerateDeviceLayerProperties_0;
	public static void vkGetDeviceQueue(VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue) => vkGetDeviceQueue_0(device, queueFamilyIndex, queueIndex, pQueue);
	private delegate void vkGetDeviceQueueDelegate_0(VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue);
	private static IntPtr vkGetDeviceQueuePointer;
	private static vkGetDeviceQueueDelegate_0 vkGetDeviceQueue_0;
	public static VkResult vkQueueSubmit(VkQueue queue, uint32_t submitCount, VkSubmitInfo* pSubmits, VkFence fence) => vkQueueSubmit_0(queue, submitCount, pSubmits, fence);
	private delegate VkResult vkQueueSubmitDelegate_0(VkQueue queue, uint32_t submitCount, VkSubmitInfo* pSubmits, VkFence fence);
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
	public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => vkFlushMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult vkFlushMappedMemoryRangesDelegate_0(VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
	private static IntPtr vkFlushMappedMemoryRangesPointer;
	private static vkFlushMappedMemoryRangesDelegate_0 vkFlushMappedMemoryRanges_0;
	public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => vkInvalidateMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult vkInvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
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
	public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements) => vkGetImageSparseMemoryRequirements_0(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
	private static IntPtr vkGetImageSparseMemoryRequirementsPointer;
	private static vkGetImageSparseMemoryRequirementsDelegate_0 vkGetImageSparseMemoryRequirements_0;
	public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint32_t* pPropertyCount, VkSparseImageFormatProperties* pProperties) => vkGetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
	private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint32_t* pPropertyCount, VkSparseImageFormatProperties* pProperties);
	private static IntPtr vkGetPhysicalDeviceSparseImageFormatPropertiesPointer;
	private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 vkGetPhysicalDeviceSparseImageFormatProperties_0;
	public static VkResult vkQueueBindSparse(VkQueue queue, uint32_t bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence) => vkQueueBindSparse_0(queue, bindInfoCount, pBindInfo, fence);
	private delegate VkResult vkQueueBindSparseDelegate_0(VkQueue queue, uint32_t bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
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
	public static VkResult vkResetFences(VkDevice device, uint32_t fenceCount, VkFence* pFences) => vkResetFences_0(device, fenceCount, pFences);
	private delegate VkResult vkResetFencesDelegate_0(VkDevice device, uint32_t fenceCount, VkFence* pFences);
	private static IntPtr vkResetFencesPointer;
	private static vkResetFencesDelegate_0 vkResetFences_0;
	public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence) => vkGetFenceStatus_0(device, fence);
	private delegate VkResult vkGetFenceStatusDelegate_0(VkDevice device, VkFence fence);
	private static IntPtr vkGetFenceStatusPointer;
	private static vkGetFenceStatusDelegate_0 vkGetFenceStatus_0;
	public static VkResult vkWaitForFences(VkDevice device, uint32_t fenceCount, VkFence* pFences, VkBool32 waitAll, uint64_t timeout) => vkWaitForFences_0(device, fenceCount, pFences, waitAll, timeout);
	private delegate VkResult vkWaitForFencesDelegate_0(VkDevice device, uint32_t fenceCount, VkFence* pFences, VkBool32 waitAll, uint64_t timeout);
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
	public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, size_t dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags) => vkGetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
	private delegate VkResult vkGetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, size_t dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags);
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
	public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, size_t* pDataSize, void* pData) => vkGetPipelineCacheData_0(device, pipelineCache, pDataSize, pData);
	private delegate VkResult vkGetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, size_t* pDataSize, void* pData);
	private static IntPtr vkGetPipelineCacheDataPointer;
	private static vkGetPipelineCacheDataDelegate_0 vkGetPipelineCacheData_0;
	public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint32_t srcCacheCount, VkPipelineCache* pSrcCaches) => vkMergePipelineCaches_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult vkMergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache dstCache, uint32_t srcCacheCount, VkPipelineCache* pSrcCaches);
	private static IntPtr vkMergePipelineCachesPointer;
	private static vkMergePipelineCachesDelegate_0 vkMergePipelineCaches_0;
	public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr vkCreateGraphicsPipelinesPointer;
	private static vkCreateGraphicsPipelinesDelegate_0 vkCreateGraphicsPipelines_0;
	public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateComputePipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
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
	public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets) => vkFreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, pDescriptorSets);
	private delegate VkResult vkFreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets);
	private static IntPtr vkFreeDescriptorSetsPointer;
	private static vkFreeDescriptorSetsDelegate_0 vkFreeDescriptorSets_0;
	public static void vkUpdateDescriptorSets(VkDevice device, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint32_t descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies) => vkUpdateDescriptorSets_0(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
	private delegate void vkUpdateDescriptorSetsDelegate_0(VkDevice device, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint32_t descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
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
	public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers) => vkFreeCommandBuffers_0(device, commandPool, commandBufferCount, pCommandBuffers);
	private delegate void vkFreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers);
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
	public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewport* pViewports) => vkCmdSetViewport_0(commandBuffer, firstViewport, viewportCount, pViewports);
	private delegate void vkCmdSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewport* pViewports);
	private static IntPtr vkCmdSetViewportPointer;
	private static vkCmdSetViewportDelegate_0 vkCmdSetViewport_0;
	public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint32_t firstScissor, uint32_t scissorCount, VkRect2D* pScissors) => vkCmdSetScissor_0(commandBuffer, firstScissor, scissorCount, pScissors);
	private delegate void vkCmdSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstScissor, uint32_t scissorCount, VkRect2D* pScissors);
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
	public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t compareMask) => vkCmdSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
	private delegate void vkCmdSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t compareMask);
	private static IntPtr vkCmdSetStencilCompareMaskPointer;
	private static vkCmdSetStencilCompareMaskDelegate_0 vkCmdSetStencilCompareMask_0;
	public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t writeMask) => vkCmdSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
	private delegate void vkCmdSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t writeMask);
	private static IntPtr vkCmdSetStencilWriteMaskPointer;
	private static vkCmdSetStencilWriteMaskDelegate_0 vkCmdSetStencilWriteMask_0;
	public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t reference) => vkCmdSetStencilReference_0(commandBuffer, faceMask, reference);
	private delegate void vkCmdSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t reference);
	private static IntPtr vkCmdSetStencilReferencePointer;
	private static vkCmdSetStencilReferenceDelegate_0 vkCmdSetStencilReference_0;
	public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t firstSet, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint32_t dynamicOffsetCount, uint32_t* pDynamicOffsets) => vkCmdBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
	private delegate void vkCmdBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t firstSet, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint32_t dynamicOffsetCount, uint32_t* pDynamicOffsets);
	private static IntPtr vkCmdBindDescriptorSetsPointer;
	private static vkCmdBindDescriptorSetsDelegate_0 vkCmdBindDescriptorSets_0;
	public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => vkCmdBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
	private delegate void vkCmdBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
	private static IntPtr vkCmdBindIndexBufferPointer;
	private static vkCmdBindIndexBufferDelegate_0 vkCmdBindIndexBuffer_0;
	public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets) => vkCmdBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
	private delegate void vkCmdBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets);
	private static IntPtr vkCmdBindVertexBuffersPointer;
	private static vkCmdBindVertexBuffersDelegate_0 vkCmdBindVertexBuffers_0;
	public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint32_t vertexCount, uint32_t instanceCount, uint32_t firstVertex, uint32_t firstInstance) => vkCmdDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
	private delegate void vkCmdDrawDelegate_0(VkCommandBuffer commandBuffer, uint32_t vertexCount, uint32_t instanceCount, uint32_t firstVertex, uint32_t firstInstance);
	private static IntPtr vkCmdDrawPointer;
	private static vkCmdDrawDelegate_0 vkCmdDraw_0;
	public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint32_t indexCount, uint32_t instanceCount, uint32_t firstIndex, int32_t vertexOffset, uint32_t firstInstance) => vkCmdDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
	private delegate void vkCmdDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint32_t indexCount, uint32_t instanceCount, uint32_t firstIndex, int32_t vertexOffset, uint32_t firstInstance);
	private static IntPtr vkCmdDrawIndexedPointer;
	private static vkCmdDrawIndexedDelegate_0 vkCmdDrawIndexed_0;
	public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride) => vkCmdDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void vkCmdDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectPointer;
	private static vkCmdDrawIndirectDelegate_0 vkCmdDrawIndirect_0;
	public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride) => vkCmdDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndexedIndirectPointer;
	private static vkCmdDrawIndexedIndirectDelegate_0 vkCmdDrawIndexedIndirect_0;
	public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ) => vkCmdDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
	private delegate void vkCmdDispatchDelegate_0(VkCommandBuffer commandBuffer, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ);
	private static IntPtr vkCmdDispatchPointer;
	private static vkCmdDispatchDelegate_0 vkCmdDispatch_0;
	public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => vkCmdDispatchIndirect_0(commandBuffer, buffer, offset);
	private delegate void vkCmdDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
	private static IntPtr vkCmdDispatchIndirectPointer;
	private static vkCmdDispatchIndirectDelegate_0 vkCmdDispatchIndirect_0;
	public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint32_t regionCount, VkBufferCopy* pRegions) => vkCmdCopyBuffer_0(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
	private delegate void vkCmdCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint32_t regionCount, VkBufferCopy* pRegions);
	private static IntPtr vkCmdCopyBufferPointer;
	private static vkCmdCopyBufferDelegate_0 vkCmdCopyBuffer_0;
	public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageCopy* pRegions) => vkCmdCopyImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageCopy* pRegions);
	private static IntPtr vkCmdCopyImagePointer;
	private static vkCmdCopyImageDelegate_0 vkCmdCopyImage_0;
	public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageBlit* pRegions, VkFilter filter) => vkCmdBlitImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
	private delegate void vkCmdBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageBlit* pRegions, VkFilter filter);
	private static IntPtr vkCmdBlitImagePointer;
	private static vkCmdBlitImageDelegate_0 vkCmdBlitImage_0;
	public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkBufferImageCopy* pRegions) => vkCmdCopyBufferToImage_0(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr vkCmdCopyBufferToImagePointer;
	private static vkCmdCopyBufferToImageDelegate_0 vkCmdCopyBufferToImage_0;
	public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint32_t regionCount, VkBufferImageCopy* pRegions) => vkCmdCopyImageToBuffer_0(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
	private delegate void vkCmdCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint32_t regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr vkCmdCopyImageToBufferPointer;
	private static vkCmdCopyImageToBufferDelegate_0 vkCmdCopyImageToBuffer_0;
	public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData) => vkCmdUpdateBuffer_0(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
	private delegate void vkCmdUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData);
	private static IntPtr vkCmdUpdateBufferPointer;
	private static vkCmdUpdateBufferDelegate_0 vkCmdUpdateBuffer_0;
	public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint32_t data) => vkCmdFillBuffer_0(commandBuffer, dstBuffer, dstOffset, size, data);
	private delegate void vkCmdFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint32_t data);
	private static IntPtr vkCmdFillBufferPointer;
	private static vkCmdFillBufferDelegate_0 vkCmdFillBuffer_0;
	public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint32_t rangeCount, VkImageSubresourceRange* pRanges) => vkCmdClearColorImage_0(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
	private delegate void vkCmdClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint32_t rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr vkCmdClearColorImagePointer;
	private static vkCmdClearColorImageDelegate_0 vkCmdClearColorImage_0;
	public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint32_t rangeCount, VkImageSubresourceRange* pRanges) => vkCmdClearDepthStencilImage_0(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
	private delegate void vkCmdClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint32_t rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr vkCmdClearDepthStencilImagePointer;
	private static vkCmdClearDepthStencilImageDelegate_0 vkCmdClearDepthStencilImage_0;
	public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkClearAttachment* pAttachments, uint32_t rectCount, VkClearRect* pRects) => vkCmdClearAttachments_0(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
	private delegate void vkCmdClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkClearAttachment* pAttachments, uint32_t rectCount, VkClearRect* pRects);
	private static IntPtr vkCmdClearAttachmentsPointer;
	private static vkCmdClearAttachmentsDelegate_0 vkCmdClearAttachments_0;
	public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageResolve* pRegions) => vkCmdResolveImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void vkCmdResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageResolve* pRegions);
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
	public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => vkCmdWaitEvents_0(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void vkCmdWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr vkCmdWaitEventsPointer;
	private static vkCmdWaitEventsDelegate_0 vkCmdWaitEvents_0;
	public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => vkCmdPipelineBarrier_0(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void vkCmdPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr vkCmdPipelineBarrierPointer;
	private static vkCmdPipelineBarrierDelegate_0 vkCmdPipelineBarrier_0;
	public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags) => vkCmdBeginQuery_0(commandBuffer, queryPool, query, flags);
	private delegate void vkCmdBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags);
	private static IntPtr vkCmdBeginQueryPointer;
	private static vkCmdBeginQueryDelegate_0 vkCmdBeginQuery_0;
	public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query) => vkCmdEndQuery_0(commandBuffer, queryPool, query);
	private delegate void vkCmdEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query);
	private static IntPtr vkCmdEndQueryPointer;
	private static vkCmdEndQueryDelegate_0 vkCmdEndQuery_0;
	public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount) => vkCmdResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
	private delegate void vkCmdResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount);
	private static IntPtr vkCmdResetQueryPoolPointer;
	private static vkCmdResetQueryPoolDelegate_0 vkCmdResetQueryPool_0;
	public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint32_t query) => vkCmdWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
	private delegate void vkCmdWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint32_t query);
	private static IntPtr vkCmdWriteTimestampPointer;
	private static vkCmdWriteTimestampDelegate_0 vkCmdWriteTimestamp_0;
	public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags) => vkCmdCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
	private delegate void vkCmdCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags);
	private static IntPtr vkCmdCopyQueryPoolResultsPointer;
	private static vkCmdCopyQueryPoolResultsDelegate_0 vkCmdCopyQueryPoolResults_0;
	public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint32_t offset, uint32_t size, void* pValues) => vkCmdPushConstants_0(commandBuffer, layout, stageFlags, offset, size, pValues);
	private delegate void vkCmdPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint32_t offset, uint32_t size, void* pValues);
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
	public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers) => vkCmdExecuteCommands_0(commandBuffer, commandBufferCount, pCommandBuffers);
	private delegate void vkCmdExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers);
	private static IntPtr vkCmdExecuteCommandsPointer;
	private static vkCmdExecuteCommandsDelegate_0 vkCmdExecuteCommands_0;
	public static VkResult vkEnumerateInstanceVersion(uint32_t* pApiVersion) => vkEnumerateInstanceVersion_0(pApiVersion);
	private delegate VkResult vkEnumerateInstanceVersionDelegate_0(uint32_t* pApiVersion);
	private static IntPtr vkEnumerateInstanceVersionPointer;
	private static vkEnumerateInstanceVersionDelegate_0 vkEnumerateInstanceVersion_0;
	public static VkResult vkBindBufferMemory2(VkDevice device, uint32_t bindInfoCount, VkBindBufferMemoryInfo* pBindInfos) => vkBindBufferMemory2_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult vkBindBufferMemory2Delegate_0(VkDevice device, uint32_t bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
	private static IntPtr vkBindBufferMemory2Pointer;
	private static vkBindBufferMemory2Delegate_0 vkBindBufferMemory2_0;
	public static VkResult vkBindImageMemory2(VkDevice device, uint32_t bindInfoCount, VkBindImageMemoryInfo* pBindInfos) => vkBindImageMemory2_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult vkBindImageMemory2Delegate_0(VkDevice device, uint32_t bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
	private static IntPtr vkBindImageMemory2Pointer;
	private static vkBindImageMemory2Delegate_0 vkBindImageMemory2_0;
	public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint32_t heapIndex, uint32_t localDeviceIndex, uint32_t remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures) => vkGetDeviceGroupPeerMemoryFeatures_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
	private delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate_0(VkDevice device, uint32_t heapIndex, uint32_t localDeviceIndex, uint32_t remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
	private static IntPtr vkGetDeviceGroupPeerMemoryFeaturesPointer;
	private static vkGetDeviceGroupPeerMemoryFeaturesDelegate_0 vkGetDeviceGroupPeerMemoryFeatures_0;
	public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint32_t deviceMask) => vkCmdSetDeviceMask_0(commandBuffer, deviceMask);
	private delegate void vkCmdSetDeviceMaskDelegate_0(VkCommandBuffer commandBuffer, uint32_t deviceMask);
	private static IntPtr vkCmdSetDeviceMaskPointer;
	private static vkCmdSetDeviceMaskDelegate_0 vkCmdSetDeviceMask_0;
	public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint32_t baseGroupX, uint32_t baseGroupY, uint32_t baseGroupZ, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ) => vkCmdDispatchBase_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void vkCmdDispatchBaseDelegate_0(VkCommandBuffer commandBuffer, uint32_t baseGroupX, uint32_t baseGroupY, uint32_t baseGroupZ, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ);
	private static IntPtr vkCmdDispatchBasePointer;
	private static vkCmdDispatchBaseDelegate_0 vkCmdDispatchBase_0;
	public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint32_t* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties) => vkEnumeratePhysicalDeviceGroups_0(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
	private delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate_0(VkInstance instance, uint32_t* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
	private static IntPtr vkEnumeratePhysicalDeviceGroupsPointer;
	private static vkEnumeratePhysicalDeviceGroupsDelegate_0 vkEnumeratePhysicalDeviceGroups_0;
	public static void vkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetImageMemoryRequirements2_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetImageMemoryRequirements2Delegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetImageMemoryRequirements2Pointer;
	private static vkGetImageMemoryRequirements2Delegate_0 vkGetImageMemoryRequirements2_0;
	public static void vkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetBufferMemoryRequirements2_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetBufferMemoryRequirements2Delegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetBufferMemoryRequirements2Pointer;
	private static vkGetBufferMemoryRequirements2Delegate_0 vkGetBufferMemoryRequirements2_0;
	public static void vkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements) => vkGetImageSparseMemoryRequirements2_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetImageSparseMemoryRequirements2Delegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
	private static IntPtr vkGetImageSparseMemoryRequirements2Pointer;
	private static vkGetImageSparseMemoryRequirements2Delegate_0 vkGetImageSparseMemoryRequirements2_0;
	public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures) => vkGetPhysicalDeviceFeatures2_0(physicalDevice, pFeatures);
	private delegate void vkGetPhysicalDeviceFeatures2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
	private static IntPtr vkGetPhysicalDeviceFeatures2Pointer;
	private static vkGetPhysicalDeviceFeatures2Delegate_0 vkGetPhysicalDeviceFeatures2_0;
	public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties) => vkGetPhysicalDeviceProperties2_0(physicalDevice, pProperties);
	private delegate void vkGetPhysicalDeviceProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
	private static IntPtr vkGetPhysicalDeviceProperties2Pointer;
	private static vkGetPhysicalDeviceProperties2Delegate_0 vkGetPhysicalDeviceProperties2_0;
	public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties) => vkGetPhysicalDeviceFormatProperties2_0(physicalDevice, format, pFormatProperties);
	private delegate void vkGetPhysicalDeviceFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
	private static IntPtr vkGetPhysicalDeviceFormatProperties2Pointer;
	private static vkGetPhysicalDeviceFormatProperties2Delegate_0 vkGetPhysicalDeviceFormatProperties2_0;
	public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) => vkGetPhysicalDeviceImageFormatProperties2_0(physicalDevice, pImageFormatInfo, pImageFormatProperties);
	private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceImageFormatProperties2Pointer;
	private static vkGetPhysicalDeviceImageFormatProperties2Delegate_0 vkGetPhysicalDeviceImageFormatProperties2_0;
	public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) => vkGetPhysicalDeviceQueueFamilyProperties2_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate_0(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyProperties2Pointer;
	private static vkGetPhysicalDeviceQueueFamilyProperties2Delegate_0 vkGetPhysicalDeviceQueueFamilyProperties2_0;
	public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties) => vkGetPhysicalDeviceMemoryProperties2_0(physicalDevice, pMemoryProperties);
	private delegate void vkGetPhysicalDeviceMemoryProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
	private static IntPtr vkGetPhysicalDeviceMemoryProperties2Pointer;
	private static vkGetPhysicalDeviceMemoryProperties2Delegate_0 vkGetPhysicalDeviceMemoryProperties2_0;
	public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint32_t* pPropertyCount, VkSparseImageFormatProperties2* pProperties) => vkGetPhysicalDeviceSparseImageFormatProperties2_0(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
	private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint32_t* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
	private static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties2Pointer;
	private static vkGetPhysicalDeviceSparseImageFormatProperties2Delegate_0 vkGetPhysicalDeviceSparseImageFormatProperties2_0;
	public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags) => vkTrimCommandPool_0(device, commandPool, flags);
	private delegate void vkTrimCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
	private static IntPtr vkTrimCommandPoolPointer;
	private static vkTrimCommandPoolDelegate_0 vkTrimCommandPool_0;
	public static void vkGetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue) => vkGetDeviceQueue2_0(device, pQueueInfo, pQueue);
	private delegate void vkGetDeviceQueue2Delegate_0(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue);
	private static IntPtr vkGetDeviceQueue2Pointer;
	private static vkGetDeviceQueue2Delegate_0 vkGetDeviceQueue2_0;
	public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion) => vkCreateSamplerYcbcrConversion_0(device, pCreateInfo, pAllocator, pYcbcrConversion);
	private delegate VkResult vkCreateSamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
	private static IntPtr vkCreateSamplerYcbcrConversionPointer;
	private static vkCreateSamplerYcbcrConversionDelegate_0 vkCreateSamplerYcbcrConversion_0;
	public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator) => vkDestroySamplerYcbcrConversion_0(device, ycbcrConversion, pAllocator);
	private delegate void vkDestroySamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySamplerYcbcrConversionPointer;
	private static vkDestroySamplerYcbcrConversionDelegate_0 vkDestroySamplerYcbcrConversion_0;
	public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate) => vkCreateDescriptorUpdateTemplate_0(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
	private delegate VkResult vkCreateDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
	private static IntPtr vkCreateDescriptorUpdateTemplatePointer;
	private static vkCreateDescriptorUpdateTemplateDelegate_0 vkCreateDescriptorUpdateTemplate_0;
	public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator) => vkDestroyDescriptorUpdateTemplate_0(device, descriptorUpdateTemplate, pAllocator);
	private delegate void vkDestroyDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDescriptorUpdateTemplatePointer;
	private static vkDestroyDescriptorUpdateTemplateDelegate_0 vkDestroyDescriptorUpdateTemplate_0;
	public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData) => vkUpdateDescriptorSetWithTemplate_0(device, descriptorSet, descriptorUpdateTemplate, pData);
	private delegate void vkUpdateDescriptorSetWithTemplateDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
	private static IntPtr vkUpdateDescriptorSetWithTemplatePointer;
	private static vkUpdateDescriptorSetWithTemplateDelegate_0 vkUpdateDescriptorSetWithTemplate_0;
	public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) => vkGetPhysicalDeviceExternalBufferProperties_0(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
	private delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
	private static IntPtr vkGetPhysicalDeviceExternalBufferPropertiesPointer;
	private static vkGetPhysicalDeviceExternalBufferPropertiesDelegate_0 vkGetPhysicalDeviceExternalBufferProperties_0;
	public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) => vkGetPhysicalDeviceExternalFenceProperties_0(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
	private delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
	private static IntPtr vkGetPhysicalDeviceExternalFencePropertiesPointer;
	private static vkGetPhysicalDeviceExternalFencePropertiesDelegate_0 vkGetPhysicalDeviceExternalFenceProperties_0;
	public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) => vkGetPhysicalDeviceExternalSemaphoreProperties_0(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
	private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
	private static IntPtr vkGetPhysicalDeviceExternalSemaphorePropertiesPointer;
	private static vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate_0 vkGetPhysicalDeviceExternalSemaphoreProperties_0;
	public static void vkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport) => vkGetDescriptorSetLayoutSupport_0(device, pCreateInfo, pSupport);
	private delegate void vkGetDescriptorSetLayoutSupportDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
	private static IntPtr vkGetDescriptorSetLayoutSupportPointer;
	private static vkGetDescriptorSetLayoutSupportDelegate_0 vkGetDescriptorSetLayoutSupport_0;
	public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator) => vkDestroySurfaceKHR_0(instance, surface, pAllocator);
	private delegate void vkDestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySurfaceKHRPointer;
	private static vkDestroySurfaceKHRDelegate_0 vkDestroySurfaceKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported) => vkGetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, pSupported);
	private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);
	private static IntPtr vkGetPhysicalDeviceSurfaceSupportKHRPointer;
	private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate_0 vkGetPhysicalDeviceSurfaceSupportKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, pSurfaceCapabilities);
	private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
	private static IntPtr vkGetPhysicalDeviceSurfaceCapabilitiesKHRPointer;
	private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 vkGetPhysicalDeviceSurfaceCapabilitiesKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats) => vkGetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
	private static IntPtr vkGetPhysicalDeviceSurfaceFormatsKHRPointer;
	private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate_0 vkGetPhysicalDeviceSurfaceFormatsKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes) => vkGetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, pPresentModeCount, pPresentModes);
	private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes);
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
	public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint32_t* pSwapchainImageCount, VkImage* pSwapchainImages) => vkGetSwapchainImagesKHR_0(device, swapchain, pSwapchainImageCount, pSwapchainImages);
	private delegate VkResult vkGetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint32_t* pSwapchainImageCount, VkImage* pSwapchainImages);
	private static IntPtr vkGetSwapchainImagesKHRPointer;
	private static vkGetSwapchainImagesKHRDelegate_0 vkGetSwapchainImagesKHR_0;
	public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, uint64_t timeout, VkSemaphore semaphore, VkFence fence, uint32_t* pImageIndex) => vkAcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, pImageIndex);
	private delegate VkResult vkAcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint64_t timeout, VkSemaphore semaphore, VkFence fence, uint32_t* pImageIndex);
	private static IntPtr vkAcquireNextImageKHRPointer;
	private static vkAcquireNextImageKHRDelegate_0 vkAcquireNextImageKHR_0;
	public static VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo) => vkQueuePresentKHR_0(queue, pPresentInfo);
	private delegate VkResult vkQueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* pPresentInfo);
	private static IntPtr vkQueuePresentKHRPointer;
	private static vkQueuePresentKHRDelegate_0 vkQueuePresentKHR_0;
	public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities) => vkGetDeviceGroupPresentCapabilitiesKHR_0(device, pDeviceGroupPresentCapabilities);
	private delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);
	private static IntPtr vkGetDeviceGroupPresentCapabilitiesKHRPointer;
	private static vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0 vkGetDeviceGroupPresentCapabilitiesKHR_0;
	public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes) => vkGetDeviceGroupSurfacePresentModesKHR_0(device, surface, pModes);
	private delegate VkResult vkGetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr vkGetDeviceGroupSurfacePresentModesKHRPointer;
	private static vkGetDeviceGroupSurfacePresentModesKHRDelegate_0 vkGetDeviceGroupSurfacePresentModesKHR_0;
	public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pRectCount, VkRect2D* pRects) => vkGetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, pRectCount, pRects);
	private delegate VkResult vkGetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pRectCount, VkRect2D* pRects);
	private static IntPtr vkGetPhysicalDevicePresentRectanglesKHRPointer;
	private static vkGetPhysicalDevicePresentRectanglesKHRDelegate_0 vkGetPhysicalDevicePresentRectanglesKHR_0;
	public static VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint32_t* pImageIndex) => vkAcquireNextImage2KHR_0(device, pAcquireInfo, pImageIndex);
	private delegate VkResult vkAcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint32_t* pImageIndex);
	private static IntPtr vkAcquireNextImage2KHRPointer;
	private static vkAcquireNextImage2KHRDelegate_0 vkAcquireNextImage2KHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPropertiesKHR* pProperties) => vkGetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPropertiesKHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayPropertiesKHRPointer;
	private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate_0 vkGetPhysicalDeviceDisplayPropertiesKHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties) => vkGetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayPlanePropertiesKHRPointer;
	private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 vkGetPhysicalDeviceDisplayPlanePropertiesKHR_0;
	public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint32_t planeIndex, uint32_t* pDisplayCount, VkDisplayKHR* pDisplays) => vkGetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, pDisplayCount, pDisplays);
	private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t planeIndex, uint32_t* pDisplayCount, VkDisplayKHR* pDisplays);
	private static IntPtr vkGetDisplayPlaneSupportedDisplaysKHRPointer;
	private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate_0 vkGetDisplayPlaneSupportedDisplaysKHR_0;
	public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModePropertiesKHR* pProperties) => vkGetDisplayModePropertiesKHR_0(physicalDevice, display, pPropertyCount, pProperties);
	private delegate VkResult vkGetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
	private static IntPtr vkGetDisplayModePropertiesKHRPointer;
	private static vkGetDisplayModePropertiesKHRDelegate_0 vkGetDisplayModePropertiesKHR_0;
	public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode) => vkCreateDisplayModeKHR_0(physicalDevice, display, pCreateInfo, pAllocator, pMode);
	private delegate VkResult vkCreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);
	private static IntPtr vkCreateDisplayModeKHRPointer;
	private static vkCreateDisplayModeKHRDelegate_0 vkCreateDisplayModeKHR_0;
	public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint32_t planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities) => vkGetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, pCapabilities);
	private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint32_t planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);
	private static IntPtr vkGetDisplayPlaneCapabilitiesKHRPointer;
	private static vkGetDisplayPlaneCapabilitiesKHRDelegate_0 vkGetDisplayPlaneCapabilitiesKHR_0;
	public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateDisplayPlaneSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateDisplayPlaneSurfaceKHRPointer;
	private static vkCreateDisplayPlaneSurfaceKHRDelegate_0 vkCreateDisplayPlaneSurfaceKHR_0;
	public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint32_t swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains) => vkCreateSharedSwapchainsKHR_0(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
	private delegate VkResult vkCreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint32_t swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);
	private static IntPtr vkCreateSharedSwapchainsKHRPointer;
	private static vkCreateSharedSwapchainsKHRDelegate_0 vkCreateSharedSwapchainsKHR_0;
	public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateXlibSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateXlibSurfaceKHRPointer;
	private static vkCreateXlibSurfaceKHRDelegate_0 vkCreateXlibSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, Display* dpy, VisualID visualID) => vkGetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
	private delegate VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, Display* dpy, VisualID visualID);
	private static IntPtr vkGetPhysicalDeviceXlibPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceXlibPresentationSupportKHR_0;
	public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateXcbSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateXcbSurfaceKHRDelegate_0(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateXcbSurfaceKHRPointer;
	private static vkCreateXcbSurfaceKHRDelegate_0 vkCreateXcbSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, xcb_connection_t* connection, xcb_visualid_t visual_id) => vkGetPhysicalDeviceXcbPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection, visual_id);
	private delegate VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, xcb_connection_t* connection, xcb_visualid_t visual_id);
	private static IntPtr vkGetPhysicalDeviceXcbPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceXcbPresentationSupportKHR_0;
	public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateWaylandSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateWaylandSurfaceKHRDelegate_0(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateWaylandSurfaceKHRPointer;
	private static vkCreateWaylandSurfaceKHRDelegate_0 vkCreateWaylandSurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, wl_display* display) => vkGetPhysicalDeviceWaylandPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, display);
	private delegate VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, wl_display* display);
	private static IntPtr vkGetPhysicalDeviceWaylandPresentationSupportKHRPointer;
	private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0 vkGetPhysicalDeviceWaylandPresentationSupportKHR_0;
	public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateAndroidSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateAndroidSurfaceKHRPointer;
	private static vkCreateAndroidSurfaceKHRDelegate_0 vkCreateAndroidSurfaceKHR_0;
	public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateWin32SurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateWin32SurfaceKHRPointer;
	private static vkCreateWin32SurfaceKHRDelegate_0 vkCreateWin32SurfaceKHR_0;
	public static VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex) => vkGetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
	private delegate VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex);
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
	public static void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage) => vkDebugReportMessageEXT_0(instance, flags, objectType, object, location, messageCode, pLayerPrefix, pMessage);
	private delegate void vkDebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage);
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
	public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes) => vkCmdBindTransformFeedbackBuffersEXT_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
	private delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes);
	private static IntPtr vkCmdBindTransformFeedbackBuffersEXTPointer;
	private static vkCmdBindTransformFeedbackBuffersEXTDelegate_0 vkCmdBindTransformFeedbackBuffersEXT_0;
	public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint32_t firstCounterBuffer, uint32_t counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets) => vkCmdBeginTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
	private delegate void vkCmdBeginTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstCounterBuffer, uint32_t counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets);
	private static IntPtr vkCmdBeginTransformFeedbackEXTPointer;
	private static vkCmdBeginTransformFeedbackEXTDelegate_0 vkCmdBeginTransformFeedbackEXT_0;
	public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint32_t firstCounterBuffer, uint32_t counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets) => vkCmdEndTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
	private delegate void vkCmdEndTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstCounterBuffer, uint32_t counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets);
	private static IntPtr vkCmdEndTransformFeedbackEXTPointer;
	private static vkCmdEndTransformFeedbackEXTDelegate_0 vkCmdEndTransformFeedbackEXT_0;
	public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags, uint32_t index) => vkCmdBeginQueryIndexedEXT_0(commandBuffer, queryPool, query, flags, index);
	private delegate void vkCmdBeginQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags, uint32_t index);
	private static IntPtr vkCmdBeginQueryIndexedEXTPointer;
	private static vkCmdBeginQueryIndexedEXTDelegate_0 vkCmdBeginQueryIndexedEXT_0;
	public static void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, uint32_t index) => vkCmdEndQueryIndexedEXT_0(commandBuffer, queryPool, query, index);
	private delegate void vkCmdEndQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, uint32_t index);
	private static IntPtr vkCmdEndQueryIndexedEXTPointer;
	private static vkCmdEndQueryIndexedEXTDelegate_0 vkCmdEndQueryIndexedEXT_0;
	public static void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint32_t instanceCount, uint32_t firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint32_t counterOffset, uint32_t vertexStride) => vkCmdDrawIndirectByteCountEXT_0(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
	private delegate void vkCmdDrawIndirectByteCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t instanceCount, uint32_t firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint32_t counterOffset, uint32_t vertexStride);
	private static IntPtr vkCmdDrawIndirectByteCountEXTPointer;
	private static vkCmdDrawIndirectByteCountEXTDelegate_0 vkCmdDrawIndirectByteCountEXT_0;
	public static uint32_t vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo) => vkGetImageViewHandleNVX_0(device, pInfo);
	private delegate uint32_t vkGetImageViewHandleNVXDelegate_0(VkDevice device, VkImageViewHandleInfoNVX* pInfo);
	private static IntPtr vkGetImageViewHandleNVXPointer;
	private static vkGetImageViewHandleNVXDelegate_0 vkGetImageViewHandleNVX_0;
	[Obsolete("Use vkCmdDrawIndirectCountKHR")]
	public static void vkCmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectCountAMDPointer;
	private static vkCmdDrawIndirectCountAMDDelegate_0 vkCmdDrawIndirectCountAMD_0;
	[Obsolete("Use vkCmdDrawIndexedIndirectCountKHR")]
	public static void vkCmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndexedIndirectCountAMDPointer;
	private static vkCmdDrawIndexedIndirectCountAMDDelegate_0 vkCmdDrawIndexedIndirectCountAMD_0;
	public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, size_t* pInfoSize, void* pInfo) => vkGetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
	private delegate VkResult vkGetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, size_t* pInfoSize, void* pInfo);
	private static IntPtr vkGetShaderInfoAMDPointer;
	private static vkGetShaderInfoAMDDelegate_0 vkGetShaderInfoAMD_0;
	public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties) => vkGetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
	private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceExternalImageFormatPropertiesNVPointer;
	private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 vkGetPhysicalDeviceExternalImageFormatPropertiesNV_0;
	public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, HANDLE* pHandle) => vkGetMemoryWin32HandleNV_0(device, memory, handleType, pHandle);
	private delegate VkResult vkGetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, HANDLE* pHandle);
	private static IntPtr vkGetMemoryWin32HandleNVPointer;
	private static vkGetMemoryWin32HandleNVDelegate_0 vkGetMemoryWin32HandleNV_0;
	[Obsolete("Use vkGetPhysicalDeviceFeatures2")]
	public static void vkGetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures) => vkGetPhysicalDeviceFeatures2KHR_0(physicalDevice, pFeatures);
	private delegate void vkGetPhysicalDeviceFeatures2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
	private static IntPtr vkGetPhysicalDeviceFeatures2KHRPointer;
	private static vkGetPhysicalDeviceFeatures2KHRDelegate_0 vkGetPhysicalDeviceFeatures2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceProperties2")]
	public static void vkGetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties) => vkGetPhysicalDeviceProperties2KHR_0(physicalDevice, pProperties);
	private delegate void vkGetPhysicalDeviceProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
	private static IntPtr vkGetPhysicalDeviceProperties2KHRPointer;
	private static vkGetPhysicalDeviceProperties2KHRDelegate_0 vkGetPhysicalDeviceProperties2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceFormatProperties2")]
	public static void vkGetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties) => vkGetPhysicalDeviceFormatProperties2KHR_0(physicalDevice, format, pFormatProperties);
	private delegate void vkGetPhysicalDeviceFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
	private static IntPtr vkGetPhysicalDeviceFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceFormatProperties2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceImageFormatProperties2")]
	public static void vkGetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) => vkGetPhysicalDeviceImageFormatProperties2KHR_0(physicalDevice, pImageFormatInfo, pImageFormatProperties);
	private delegate void vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
	private static IntPtr vkGetPhysicalDeviceImageFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceImageFormatProperties2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceQueueFamilyProperties2")]
	public static void vkGetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) => vkGetPhysicalDeviceQueueFamilyProperties2KHR_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer;
	private static vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0 vkGetPhysicalDeviceQueueFamilyProperties2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceMemoryProperties2")]
	public static void vkGetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties) => vkGetPhysicalDeviceMemoryProperties2KHR_0(physicalDevice, pMemoryProperties);
	private delegate void vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
	private static IntPtr vkGetPhysicalDeviceMemoryProperties2KHRPointer;
	private static vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0 vkGetPhysicalDeviceMemoryProperties2KHR_0;
	[Obsolete("Use vkGetPhysicalDeviceSparseImageFormatProperties2")]
	public static void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint32_t* pPropertyCount, VkSparseImageFormatProperties2* pProperties) => vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
	private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint32_t* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
	private static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer;
	private static vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0 vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0;
	[Obsolete("Use vkGetDeviceGroupPeerMemoryFeatures")]
	public static void vkGetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint32_t heapIndex, uint32_t localDeviceIndex, uint32_t remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures) => vkGetDeviceGroupPeerMemoryFeaturesKHR_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
	private delegate void vkGetDeviceGroupPeerMemoryFeaturesKHRDelegate_0(VkDevice device, uint32_t heapIndex, uint32_t localDeviceIndex, uint32_t remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
	private static IntPtr vkGetDeviceGroupPeerMemoryFeaturesKHRPointer;
	private static vkGetDeviceGroupPeerMemoryFeaturesKHRDelegate_0 vkGetDeviceGroupPeerMemoryFeaturesKHR_0;
	[Obsolete("Use vkCmdSetDeviceMask")]
	public static void vkCmdSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint32_t deviceMask) => vkCmdSetDeviceMaskKHR_0(commandBuffer, deviceMask);
	private delegate void vkCmdSetDeviceMaskKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t deviceMask);
	private static IntPtr vkCmdSetDeviceMaskKHRPointer;
	private static vkCmdSetDeviceMaskKHRDelegate_0 vkCmdSetDeviceMaskKHR_0;
	[Obsolete("Use vkCmdDispatchBase")]
	public static void vkCmdDispatchBaseKHR(VkCommandBuffer commandBuffer, uint32_t baseGroupX, uint32_t baseGroupY, uint32_t baseGroupZ, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ) => vkCmdDispatchBaseKHR_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void vkCmdDispatchBaseKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t baseGroupX, uint32_t baseGroupY, uint32_t baseGroupZ, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ);
	private static IntPtr vkCmdDispatchBaseKHRPointer;
	private static vkCmdDispatchBaseKHRDelegate_0 vkCmdDispatchBaseKHR_0;
	public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities) => vkGetDeviceGroupPresentCapabilitiesKHR_0(device, pDeviceGroupPresentCapabilities);
	private delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);
	private static IntPtr vkGetDeviceGroupPresentCapabilitiesKHRPointer;
	private static vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0 vkGetDeviceGroupPresentCapabilitiesKHR_0;
	public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes) => vkGetDeviceGroupSurfacePresentModesKHR_0(device, surface, pModes);
	private delegate VkResult vkGetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr vkGetDeviceGroupSurfacePresentModesKHRPointer;
	private static vkGetDeviceGroupSurfacePresentModesKHRDelegate_0 vkGetDeviceGroupSurfacePresentModesKHR_0;
	public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pRectCount, VkRect2D* pRects) => vkGetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, pRectCount, pRects);
	private delegate VkResult vkGetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pRectCount, VkRect2D* pRects);
	private static IntPtr vkGetPhysicalDevicePresentRectanglesKHRPointer;
	private static vkGetPhysicalDevicePresentRectanglesKHRDelegate_0 vkGetPhysicalDevicePresentRectanglesKHR_0;
	public static VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint32_t* pImageIndex) => vkAcquireNextImage2KHR_0(device, pAcquireInfo, pImageIndex);
	private delegate VkResult vkAcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint32_t* pImageIndex);
	private static IntPtr vkAcquireNextImage2KHRPointer;
	private static vkAcquireNextImage2KHRDelegate_0 vkAcquireNextImage2KHR_0;
	[Obsolete("Use vkTrimCommandPool")]
	public static void vkTrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags) => vkTrimCommandPoolKHR_0(device, commandPool, flags);
	private delegate void vkTrimCommandPoolKHRDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
	private static IntPtr vkTrimCommandPoolKHRPointer;
	private static vkTrimCommandPoolKHRDelegate_0 vkTrimCommandPoolKHR_0;
	[Obsolete("Use vkEnumeratePhysicalDeviceGroups")]
	public static void vkEnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint32_t* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties) => vkEnumeratePhysicalDeviceGroupsKHR_0(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
	private delegate void vkEnumeratePhysicalDeviceGroupsKHRDelegate_0(VkInstance instance, uint32_t* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
	private static IntPtr vkEnumeratePhysicalDeviceGroupsKHRPointer;
	private static vkEnumeratePhysicalDeviceGroupsKHRDelegate_0 vkEnumeratePhysicalDeviceGroupsKHR_0;
	[Obsolete("Use vkGetPhysicalDeviceExternalBufferProperties")]
	public static void vkGetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) => vkGetPhysicalDeviceExternalBufferPropertiesKHR_0(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
	private delegate void vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
	private static IntPtr vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalBufferPropertiesKHR_0;
	public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle) => vkGetMemoryWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle);
	private static IntPtr vkGetMemoryWin32HandleKHRPointer;
	private static vkGetMemoryWin32HandleKHRDelegate_0 vkGetMemoryWin32HandleKHR_0;
	public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, HANDLE handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties) => vkGetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, pMemoryWin32HandleProperties);
	private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, HANDLE handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
	private static IntPtr vkGetMemoryWin32HandlePropertiesKHRPointer;
	private static vkGetMemoryWin32HandlePropertiesKHRDelegate_0 vkGetMemoryWin32HandlePropertiesKHR_0;
	public static VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd) => vkGetMemoryFdKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult vkGetMemoryFdKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr vkGetMemoryFdKHRPointer;
	private static vkGetMemoryFdKHRDelegate_0 vkGetMemoryFdKHR_0;
	public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties) => vkGetMemoryFdPropertiesKHR_0(device, handleType, fd, pMemoryFdProperties);
	private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);
	private static IntPtr vkGetMemoryFdPropertiesKHRPointer;
	private static vkGetMemoryFdPropertiesKHRDelegate_0 vkGetMemoryFdPropertiesKHR_0;
	[Obsolete("Use vkGetPhysicalDeviceExternalSemaphoreProperties")]
	public static void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) => vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_0(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
	private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
	private static IntPtr vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_0;
	public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo) => vkImportSemaphoreWin32HandleKHR_0(device, pImportSemaphoreWin32HandleInfo);
	private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
	private static IntPtr vkImportSemaphoreWin32HandleKHRPointer;
	private static vkImportSemaphoreWin32HandleKHRDelegate_0 vkImportSemaphoreWin32HandleKHR_0;
	public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle) => vkGetSemaphoreWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle);
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
	public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t set, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites) => vkCmdPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
	private delegate void vkCmdPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t set, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
	private static IntPtr vkCmdPushDescriptorSetKHRPointer;
	private static vkCmdPushDescriptorSetKHRDelegate_0 vkCmdPushDescriptorSetKHR_0;
	public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint32_t set, void* pData) => vkCmdPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
	private delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint32_t set, void* pData);
	private static IntPtr vkCmdPushDescriptorSetWithTemplateKHRPointer;
	private static vkCmdPushDescriptorSetWithTemplateKHRDelegate_0 vkCmdPushDescriptorSetWithTemplateKHR_0;
	public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin) => vkCmdBeginConditionalRenderingEXT_0(commandBuffer, pConditionalRenderingBegin);
	private delegate void vkCmdBeginConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);
	private static IntPtr vkCmdBeginConditionalRenderingEXTPointer;
	private static vkCmdBeginConditionalRenderingEXTDelegate_0 vkCmdBeginConditionalRenderingEXT_0;
	public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer) => vkCmdEndConditionalRenderingEXT_0(commandBuffer);
	private delegate void vkCmdEndConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdEndConditionalRenderingEXTPointer;
	private static vkCmdEndConditionalRenderingEXTDelegate_0 vkCmdEndConditionalRenderingEXT_0;
	[Obsolete("Use vkCreateDescriptorUpdateTemplate")]
	public static void vkCreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate) => vkCreateDescriptorUpdateTemplateKHR_0(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
	private delegate void vkCreateDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
	private static IntPtr vkCreateDescriptorUpdateTemplateKHRPointer;
	private static vkCreateDescriptorUpdateTemplateKHRDelegate_0 vkCreateDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use vkDestroyDescriptorUpdateTemplate")]
	public static void vkDestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator) => vkDestroyDescriptorUpdateTemplateKHR_0(device, descriptorUpdateTemplate, pAllocator);
	private delegate void vkDestroyDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDescriptorUpdateTemplateKHRPointer;
	private static vkDestroyDescriptorUpdateTemplateKHRDelegate_0 vkDestroyDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use vkUpdateDescriptorSetWithTemplate")]
	public static void vkUpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData) => vkUpdateDescriptorSetWithTemplateKHR_0(device, descriptorSet, descriptorUpdateTemplate, pData);
	private delegate void vkUpdateDescriptorSetWithTemplateKHRDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
	private static IntPtr vkUpdateDescriptorSetWithTemplateKHRPointer;
	private static vkUpdateDescriptorSetWithTemplateKHRDelegate_0 vkUpdateDescriptorSetWithTemplateKHR_0;
	public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint32_t set, void* pData) => vkCmdPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
	private delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint32_t set, void* pData);
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
	public static VkResult vkRegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint32_t* pObjectIndices) => vkRegisterObjectsNVX_0(device, objectTable, objectCount, ppObjectTableEntries, pObjectIndices);
	private delegate VkResult vkRegisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint32_t* pObjectIndices);
	private static IntPtr vkRegisterObjectsNVXPointer;
	private static vkRegisterObjectsNVXDelegate_0 vkRegisterObjectsNVX_0;
	public static VkResult vkUnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint32_t* pObjectIndices) => vkUnregisterObjectsNVX_0(device, objectTable, objectCount, pObjectEntryTypes, pObjectIndices);
	private delegate VkResult vkUnregisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint32_t* pObjectIndices);
	private static IntPtr vkUnregisterObjectsNVXPointer;
	private static vkUnregisterObjectsNVXDelegate_0 vkUnregisterObjectsNVX_0;
	public static void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits) => vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_0(physicalDevice, pFeatures, pLimits);
	private delegate void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits);
	private static IntPtr vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer;
	private static vkGetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0 vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_0;
	public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewportWScalingNV* pViewportWScalings) => vkCmdSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
	private delegate void vkCmdSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewportWScalingNV* pViewportWScalings);
	private static IntPtr vkCmdSetViewportWScalingNVPointer;
	private static vkCmdSetViewportWScalingNVDelegate_0 vkCmdSetViewportWScalingNV_0;
	public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => vkReleaseDisplayEXT_0(physicalDevice, display);
	private delegate VkResult vkReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static IntPtr vkReleaseDisplayEXTPointer;
	private static vkReleaseDisplayEXTDelegate_0 vkReleaseDisplayEXT_0;
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
	public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, uint64_t* pCounterValue) => vkGetSwapchainCounterEXT_0(device, swapchain, counter, pCounterValue);
	private delegate VkResult vkGetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, uint64_t* pCounterValue);
	private static IntPtr vkGetSwapchainCounterEXTPointer;
	private static vkGetSwapchainCounterEXTDelegate_0 vkGetSwapchainCounterEXT_0;
	public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties) => vkGetRefreshCycleDurationGOOGLE_0(device, swapchain, pDisplayTimingProperties);
	private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
	private static IntPtr vkGetRefreshCycleDurationGOOGLEPointer;
	private static vkGetRefreshCycleDurationGOOGLEDelegate_0 vkGetRefreshCycleDurationGOOGLE_0;
	public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint32_t* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings) => vkGetPastPresentationTimingGOOGLE_0(device, swapchain, pPresentationTimingCount, pPresentationTimings);
	private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint32_t* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
	private static IntPtr vkGetPastPresentationTimingGOOGLEPointer;
	private static vkGetPastPresentationTimingGOOGLEDelegate_0 vkGetPastPresentationTimingGOOGLE_0;
	public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint32_t firstDiscardRectangle, uint32_t discardRectangleCount, VkRect2D* pDiscardRectangles) => vkCmdSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
	private delegate void vkCmdSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstDiscardRectangle, uint32_t discardRectangleCount, VkRect2D* pDiscardRectangles);
	private static IntPtr vkCmdSetDiscardRectangleEXTPointer;
	private static vkCmdSetDiscardRectangleEXTDelegate_0 vkCmdSetDiscardRectangleEXT_0;
	public static void vkSetHdrMetadataEXT(VkDevice device, uint32_t swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata) => vkSetHdrMetadataEXT_0(device, swapchainCount, pSwapchains, pMetadata);
	private delegate void vkSetHdrMetadataEXTDelegate_0(VkDevice device, uint32_t swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata);
	private static IntPtr vkSetHdrMetadataEXTPointer;
	private static vkSetHdrMetadataEXTDelegate_0 vkSetHdrMetadataEXT_0;
	public static VkResult vkCreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2KHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => vkCreateRenderPass2KHR_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate VkResult vkCreateRenderPass2KHRDelegate_0(VkDevice device, VkRenderPassCreateInfo2KHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr vkCreateRenderPass2KHRPointer;
	private static vkCreateRenderPass2KHRDelegate_0 vkCreateRenderPass2KHR_0;
	public static void vkCmdBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfoKHR* pSubpassBeginInfo) => vkCmdBeginRenderPass2KHR_0(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
	private delegate void vkCmdBeginRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfoKHR* pSubpassBeginInfo);
	private static IntPtr vkCmdBeginRenderPass2KHRPointer;
	private static vkCmdBeginRenderPass2KHRDelegate_0 vkCmdBeginRenderPass2KHR_0;
	public static void vkCmdNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* pSubpassBeginInfo, VkSubpassEndInfoKHR* pSubpassEndInfo) => vkCmdNextSubpass2KHR_0(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
	private delegate void vkCmdNextSubpass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* pSubpassBeginInfo, VkSubpassEndInfoKHR* pSubpassEndInfo);
	private static IntPtr vkCmdNextSubpass2KHRPointer;
	private static vkCmdNextSubpass2KHRDelegate_0 vkCmdNextSubpass2KHR_0;
	public static void vkCmdEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* pSubpassEndInfo) => vkCmdEndRenderPass2KHR_0(commandBuffer, pSubpassEndInfo);
	private delegate void vkCmdEndRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* pSubpassEndInfo);
	private static IntPtr vkCmdEndRenderPass2KHRPointer;
	private static vkCmdEndRenderPass2KHRDelegate_0 vkCmdEndRenderPass2KHR_0;
	public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => vkGetSwapchainStatusKHR_0(device, swapchain);
	private delegate VkResult vkGetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr vkGetSwapchainStatusKHRPointer;
	private static vkGetSwapchainStatusKHRDelegate_0 vkGetSwapchainStatusKHR_0;
	[Obsolete("Use vkGetPhysicalDeviceExternalFenceProperties")]
	public static void vkGetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) => vkGetPhysicalDeviceExternalFencePropertiesKHR_0(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
	private delegate void vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
	private static IntPtr vkGetPhysicalDeviceExternalFencePropertiesKHRPointer;
	private static vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate_0 vkGetPhysicalDeviceExternalFencePropertiesKHR_0;
	public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo) => vkImportFenceWin32HandleKHR_0(device, pImportFenceWin32HandleInfo);
	private delegate VkResult vkImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
	private static IntPtr vkImportFenceWin32HandleKHRPointer;
	private static vkImportFenceWin32HandleKHRDelegate_0 vkImportFenceWin32HandleKHR_0;
	public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle) => vkGetFenceWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult vkGetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, HANDLE* pHandle);
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
	public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, uint32_t* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions) => vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
	private delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, uint32_t* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions);
	private static IntPtr vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer;
	private static vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0 vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0;
	public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint32_t* pNumPasses) => vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
	private delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint32_t* pNumPasses);
	private static IntPtr vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer;
	private static vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0 vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0;
	public static VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo) => vkAcquireProfilingLockKHR_0(device, pInfo);
	private delegate VkResult vkAcquireProfilingLockKHRDelegate_0(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo);
	private static IntPtr vkAcquireProfilingLockKHRPointer;
	private static vkAcquireProfilingLockKHRDelegate_0 vkAcquireProfilingLockKHR_0;
	public static void vkReleaseProfilingLockKHR(VkDevice device) => vkReleaseProfilingLockKHR_0(device);
	private delegate void vkReleaseProfilingLockKHRDelegate_0(VkDevice device);
	private static IntPtr vkReleaseProfilingLockKHRPointer;
	private static vkReleaseProfilingLockKHRDelegate_0 vkReleaseProfilingLockKHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
	private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
	private static IntPtr vkGetPhysicalDeviceSurfaceCapabilities2KHRPointer;
	private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 vkGetPhysicalDeviceSurfaceCapabilities2KHR_0;
	public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint32_t* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats) => vkGetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint32_t* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
	private static IntPtr vkGetPhysicalDeviceSurfaceFormats2KHRPointer;
	private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate_0 vkGetPhysicalDeviceSurfaceFormats2KHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayProperties2KHR* pProperties) => vkGetPhysicalDeviceDisplayProperties2KHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayProperties2KHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayProperties2KHRPointer;
	private static vkGetPhysicalDeviceDisplayProperties2KHRDelegate_0 vkGetPhysicalDeviceDisplayProperties2KHR_0;
	public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties) => vkGetPhysicalDeviceDisplayPlaneProperties2KHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);
	private static IntPtr vkGetPhysicalDeviceDisplayPlaneProperties2KHRPointer;
	private static vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0 vkGetPhysicalDeviceDisplayPlaneProperties2KHR_0;
	public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModeProperties2KHR* pProperties) => vkGetDisplayModeProperties2KHR_0(physicalDevice, display, pPropertyCount, pProperties);
	private delegate VkResult vkGetDisplayModeProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);
	private static IntPtr vkGetDisplayModeProperties2KHRPointer;
	private static vkGetDisplayModeProperties2KHRDelegate_0 vkGetDisplayModeProperties2KHR_0;
	public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities) => vkGetDisplayPlaneCapabilities2KHR_0(physicalDevice, pDisplayPlaneInfo, pCapabilities);
	private delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);
	private static IntPtr vkGetDisplayPlaneCapabilities2KHRPointer;
	private static vkGetDisplayPlaneCapabilities2KHRDelegate_0 vkGetDisplayPlaneCapabilities2KHR_0;
	public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateMacOSSurfaceMVK_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateMacOSSurfaceMVKPointer;
	private static vkCreateMacOSSurfaceMVKDelegate_0 vkCreateMacOSSurfaceMVK_0;
	public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo) => vkSetDebugUtilsObjectNameEXT_0(device, pNameInfo);
	private delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate_0(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo);
	private static IntPtr vkSetDebugUtilsObjectNameEXTPointer;
	private static vkSetDebugUtilsObjectNameEXTDelegate_0 vkSetDebugUtilsObjectNameEXT_0;
	public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo) => vkSetDebugUtilsObjectTagEXT_0(device, pTagInfo);
	private delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate_0(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo);
	private static IntPtr vkSetDebugUtilsObjectTagEXTPointer;
	private static vkSetDebugUtilsObjectTagEXTDelegate_0 vkSetDebugUtilsObjectTagEXT_0;
	public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo) => vkQueueBeginDebugUtilsLabelEXT_0(queue, pLabelInfo);
	private delegate void vkQueueBeginDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr vkQueueBeginDebugUtilsLabelEXTPointer;
	private static vkQueueBeginDebugUtilsLabelEXTDelegate_0 vkQueueBeginDebugUtilsLabelEXT_0;
	public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue) => vkQueueEndDebugUtilsLabelEXT_0(queue);
	private delegate void vkQueueEndDebugUtilsLabelEXTDelegate_0(VkQueue queue);
	private static IntPtr vkQueueEndDebugUtilsLabelEXTPointer;
	private static vkQueueEndDebugUtilsLabelEXTDelegate_0 vkQueueEndDebugUtilsLabelEXT_0;
	public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo) => vkQueueInsertDebugUtilsLabelEXT_0(queue, pLabelInfo);
	private delegate void vkQueueInsertDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr vkQueueInsertDebugUtilsLabelEXTPointer;
	private static vkQueueInsertDebugUtilsLabelEXTDelegate_0 vkQueueInsertDebugUtilsLabelEXT_0;
	public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo) => vkCmdBeginDebugUtilsLabelEXT_0(commandBuffer, pLabelInfo);
	private delegate void vkCmdBeginDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr vkCmdBeginDebugUtilsLabelEXTPointer;
	private static vkCmdBeginDebugUtilsLabelEXTDelegate_0 vkCmdBeginDebugUtilsLabelEXT_0;
	public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer) => vkCmdEndDebugUtilsLabelEXT_0(commandBuffer);
	private delegate void vkCmdEndDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdEndDebugUtilsLabelEXTPointer;
	private static vkCmdEndDebugUtilsLabelEXTDelegate_0 vkCmdEndDebugUtilsLabelEXT_0;
	public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo) => vkCmdInsertDebugUtilsLabelEXT_0(commandBuffer, pLabelInfo);
	private delegate void vkCmdInsertDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr vkCmdInsertDebugUtilsLabelEXTPointer;
	private static vkCmdInsertDebugUtilsLabelEXTDelegate_0 vkCmdInsertDebugUtilsLabelEXT_0;
	public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger) => vkCreateDebugUtilsMessengerEXT_0(instance, pCreateInfo, pAllocator, pMessenger);
	private delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger);
	private static IntPtr vkCreateDebugUtilsMessengerEXTPointer;
	private static vkCreateDebugUtilsMessengerEXTDelegate_0 vkCreateDebugUtilsMessengerEXT_0;
	public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator) => vkDestroyDebugUtilsMessengerEXT_0(instance, messenger, pAllocator);
	private delegate void vkDestroyDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDebugUtilsMessengerEXTPointer;
	private static vkDestroyDebugUtilsMessengerEXTDelegate_0 vkDestroyDebugUtilsMessengerEXT_0;
	public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData) => vkSubmitDebugUtilsMessageEXT_0(instance, messageSeverity, messageTypes, pCallbackData);
	private delegate void vkSubmitDebugUtilsMessageEXTDelegate_0(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
	private static IntPtr vkSubmitDebugUtilsMessageEXTPointer;
	private static vkSubmitDebugUtilsMessageEXTDelegate_0 vkSubmitDebugUtilsMessageEXT_0;
	public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, AHardwareBuffer* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties) => vkGetAndroidHardwareBufferPropertiesANDROID_0(device, buffer, pProperties);
	private delegate VkResult vkGetAndroidHardwareBufferPropertiesANDROIDDelegate_0(VkDevice device, AHardwareBuffer* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties);
	private static IntPtr vkGetAndroidHardwareBufferPropertiesANDROIDPointer;
	private static vkGetAndroidHardwareBufferPropertiesANDROIDDelegate_0 vkGetAndroidHardwareBufferPropertiesANDROID_0;
	public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, AHardwareBuffer** pBuffer) => vkGetMemoryAndroidHardwareBufferANDROID_0(device, pInfo, pBuffer);
	private delegate VkResult vkGetMemoryAndroidHardwareBufferANDROIDDelegate_0(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, AHardwareBuffer** pBuffer);
	private static IntPtr vkGetMemoryAndroidHardwareBufferANDROIDPointer;
	private static vkGetMemoryAndroidHardwareBufferANDROIDDelegate_0 vkGetMemoryAndroidHardwareBufferANDROID_0;
	public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo) => vkCmdSetSampleLocationsEXT_0(commandBuffer, pSampleLocationsInfo);
	private delegate void vkCmdSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo);
	private static IntPtr vkCmdSetSampleLocationsEXTPointer;
	private static vkCmdSetSampleLocationsEXTDelegate_0 vkCmdSetSampleLocationsEXT_0;
	public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties) => vkGetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, pMultisampleProperties);
	private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties);
	private static IntPtr vkGetPhysicalDeviceMultisamplePropertiesEXTPointer;
	private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 vkGetPhysicalDeviceMultisamplePropertiesEXT_0;
	[Obsolete("Use vkGetImageMemoryRequirements2")]
	public static void vkGetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetImageMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetImageMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetImageMemoryRequirements2KHRPointer;
	private static vkGetImageMemoryRequirements2KHRDelegate_0 vkGetImageMemoryRequirements2KHR_0;
	[Obsolete("Use vkGetBufferMemoryRequirements2")]
	public static void vkGetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetBufferMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetBufferMemoryRequirements2KHRDelegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetBufferMemoryRequirements2KHRPointer;
	private static vkGetBufferMemoryRequirements2KHRDelegate_0 vkGetBufferMemoryRequirements2KHR_0;
	[Obsolete("Use vkGetImageSparseMemoryRequirements2")]
	public static void vkGetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements) => vkGetImageSparseMemoryRequirements2KHR_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetImageSparseMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
	private static IntPtr vkGetImageSparseMemoryRequirements2KHRPointer;
	private static vkGetImageSparseMemoryRequirements2KHRDelegate_0 vkGetImageSparseMemoryRequirements2KHR_0;
	[Obsolete("Use vkCreateSamplerYcbcrConversion")]
	public static void vkCreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion) => vkCreateSamplerYcbcrConversionKHR_0(device, pCreateInfo, pAllocator, pYcbcrConversion);
	private delegate void vkCreateSamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
	private static IntPtr vkCreateSamplerYcbcrConversionKHRPointer;
	private static vkCreateSamplerYcbcrConversionKHRDelegate_0 vkCreateSamplerYcbcrConversionKHR_0;
	[Obsolete("Use vkDestroySamplerYcbcrConversion")]
	public static void vkDestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator) => vkDestroySamplerYcbcrConversionKHR_0(device, ycbcrConversion, pAllocator);
	private delegate void vkDestroySamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroySamplerYcbcrConversionKHRPointer;
	private static vkDestroySamplerYcbcrConversionKHRDelegate_0 vkDestroySamplerYcbcrConversionKHR_0;
	[Obsolete("Use vkBindBufferMemory2")]
	public static void vkBindBufferMemory2KHR(VkDevice device, uint32_t bindInfoCount, VkBindBufferMemoryInfo* pBindInfos) => vkBindBufferMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate void vkBindBufferMemory2KHRDelegate_0(VkDevice device, uint32_t bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
	private static IntPtr vkBindBufferMemory2KHRPointer;
	private static vkBindBufferMemory2KHRDelegate_0 vkBindBufferMemory2KHR_0;
	[Obsolete("Use vkBindImageMemory2")]
	public static void vkBindImageMemory2KHR(VkDevice device, uint32_t bindInfoCount, VkBindImageMemoryInfo* pBindInfos) => vkBindImageMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate void vkBindImageMemory2KHRDelegate_0(VkDevice device, uint32_t bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
	private static IntPtr vkBindImageMemory2KHRPointer;
	private static vkBindImageMemory2KHRDelegate_0 vkBindImageMemory2KHR_0;
	public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties) => vkGetImageDrmFormatModifierPropertiesEXT_0(device, image, pProperties);
	private delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate_0(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties);
	private static IntPtr vkGetImageDrmFormatModifierPropertiesEXTPointer;
	private static vkGetImageDrmFormatModifierPropertiesEXTDelegate_0 vkGetImageDrmFormatModifierPropertiesEXT_0;
	public static VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache) => vkCreateValidationCacheEXT_0(device, pCreateInfo, pAllocator, pValidationCache);
	private delegate VkResult vkCreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);
	private static IntPtr vkCreateValidationCacheEXTPointer;
	private static vkCreateValidationCacheEXTDelegate_0 vkCreateValidationCacheEXT_0;
	public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator) => vkDestroyValidationCacheEXT_0(device, validationCache, pAllocator);
	private delegate void vkDestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyValidationCacheEXTPointer;
	private static vkDestroyValidationCacheEXTDelegate_0 vkDestroyValidationCacheEXT_0;
	public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint32_t srcCacheCount, VkValidationCacheEXT* pSrcCaches) => vkMergeValidationCachesEXT_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult vkMergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT dstCache, uint32_t srcCacheCount, VkValidationCacheEXT* pSrcCaches);
	private static IntPtr vkMergeValidationCachesEXTPointer;
	private static vkMergeValidationCachesEXTDelegate_0 vkMergeValidationCachesEXT_0;
	public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, size_t* pDataSize, void* pData) => vkGetValidationCacheDataEXT_0(device, validationCache, pDataSize, pData);
	private delegate VkResult vkGetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, size_t* pDataSize, void* pData);
	private static IntPtr vkGetValidationCacheDataEXTPointer;
	private static vkGetValidationCacheDataEXTDelegate_0 vkGetValidationCacheDataEXT_0;
	public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => vkCmdBindShadingRateImageNV_0(commandBuffer, imageView, imageLayout);
	private delegate void vkCmdBindShadingRateImageNVDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
	private static IntPtr vkCmdBindShadingRateImageNVPointer;
	private static vkCmdBindShadingRateImageNVDelegate_0 vkCmdBindShadingRateImageNV_0;
	public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes) => vkCmdSetViewportShadingRatePaletteNV_0(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
	private delegate void vkCmdSetViewportShadingRatePaletteNVDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes);
	private static IntPtr vkCmdSetViewportShadingRatePaletteNVPointer;
	private static vkCmdSetViewportShadingRatePaletteNVDelegate_0 vkCmdSetViewportShadingRatePaletteNV_0;
	public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint32_t customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders) => vkCmdSetCoarseSampleOrderNV_0(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
	private delegate void vkCmdSetCoarseSampleOrderNVDelegate_0(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint32_t customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
	private static IntPtr vkCmdSetCoarseSampleOrderNVPointer;
	private static vkCmdSetCoarseSampleOrderNVDelegate_0 vkCmdSetCoarseSampleOrderNV_0;
	public static VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure) => vkCreateAccelerationStructureNV_0(device, pCreateInfo, pAllocator, pAccelerationStructure);
	private delegate VkResult vkCreateAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure);
	private static IntPtr vkCreateAccelerationStructureNVPointer;
	private static vkCreateAccelerationStructureNVDelegate_0 vkCreateAccelerationStructureNV_0;
	public static void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator) => vkDestroyAccelerationStructureNV_0(device, accelerationStructure, pAllocator);
	private delegate void vkDestroyAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyAccelerationStructureNVPointer;
	private static vkDestroyAccelerationStructureNVDelegate_0 vkDestroyAccelerationStructureNV_0;
	public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements) => vkGetAccelerationStructureMemoryRequirementsNV_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate_0(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements);
	private static IntPtr vkGetAccelerationStructureMemoryRequirementsNVPointer;
	private static vkGetAccelerationStructureMemoryRequirementsNVDelegate_0 vkGetAccelerationStructureMemoryRequirementsNV_0;
	public static VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint32_t bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos) => vkBindAccelerationStructureMemoryNV_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult vkBindAccelerationStructureMemoryNVDelegate_0(VkDevice device, uint32_t bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
	private static IntPtr vkBindAccelerationStructureMemoryNVPointer;
	private static vkBindAccelerationStructureMemoryNVDelegate_0 vkBindAccelerationStructureMemoryNV_0;
	public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset) => vkCmdBuildAccelerationStructureNV_0(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
	private delegate void vkCmdBuildAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset);
	private static IntPtr vkCmdBuildAccelerationStructureNVPointer;
	private static vkCmdBuildAccelerationStructureNVDelegate_0 vkCmdBuildAccelerationStructureNV_0;
	public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeNV mode) => vkCmdCopyAccelerationStructureNV_0(commandBuffer, dst, src, mode);
	private delegate void vkCmdCopyAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeNV mode);
	private static IntPtr vkCmdCopyAccelerationStructureNVPointer;
	private static vkCmdCopyAccelerationStructureNVDelegate_0 vkCmdCopyAccelerationStructureNV_0;
	public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint32_t width, uint32_t height, uint32_t depth) => vkCmdTraceRaysNV_0(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
	private delegate void vkCmdTraceRaysNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint32_t width, uint32_t height, uint32_t depth);
	private static IntPtr vkCmdTraceRaysNVPointer;
	private static vkCmdTraceRaysNVDelegate_0 vkCmdTraceRaysNV_0;
	public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateRayTracingPipelinesNV_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateRayTracingPipelinesNVDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr vkCreateRayTracingPipelinesNVPointer;
	private static vkCreateRayTracingPipelinesNVDelegate_0 vkCreateRayTracingPipelinesNV_0;
	public static VkResult vkGetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData) => vkGetRayTracingShaderGroupHandlesNV_0(device, pipeline, firstGroup, groupCount, dataSize, pData);
	private delegate VkResult vkGetRayTracingShaderGroupHandlesNVDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData);
	private static IntPtr vkGetRayTracingShaderGroupHandlesNVPointer;
	private static vkGetRayTracingShaderGroupHandlesNVDelegate_0 vkGetRayTracingShaderGroupHandlesNV_0;
	public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, size_t dataSize, void* pData) => vkGetAccelerationStructureHandleNV_0(device, accelerationStructure, dataSize, pData);
	private delegate VkResult vkGetAccelerationStructureHandleNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, size_t dataSize, void* pData);
	private static IntPtr vkGetAccelerationStructureHandleNVPointer;
	private static vkGetAccelerationStructureHandleNVDelegate_0 vkGetAccelerationStructureHandleNV_0;
	public static void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint32_t accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint32_t firstQuery) => vkCmdWriteAccelerationStructuresPropertiesNV_0(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
	private delegate void vkCmdWriteAccelerationStructuresPropertiesNVDelegate_0(VkCommandBuffer commandBuffer, uint32_t accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint32_t firstQuery);
	private static IntPtr vkCmdWriteAccelerationStructuresPropertiesNVPointer;
	private static vkCmdWriteAccelerationStructuresPropertiesNVDelegate_0 vkCmdWriteAccelerationStructuresPropertiesNV_0;
	public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint32_t shader) => vkCompileDeferredNV_0(device, pipeline, shader);
	private delegate VkResult vkCompileDeferredNVDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t shader);
	private static IntPtr vkCompileDeferredNVPointer;
	private static vkCompileDeferredNVDelegate_0 vkCompileDeferredNV_0;
	[Obsolete("Use vkGetDescriptorSetLayoutSupport")]
	public static void vkGetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport) => vkGetDescriptorSetLayoutSupportKHR_0(device, pCreateInfo, pSupport);
	private delegate void vkGetDescriptorSetLayoutSupportKHRDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
	private static IntPtr vkGetDescriptorSetLayoutSupportKHRPointer;
	private static vkGetDescriptorSetLayoutSupportKHRDelegate_0 vkGetDescriptorSetLayoutSupportKHR_0;
	public static void vkCmdDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectCountKHRPointer;
	private static vkCmdDrawIndirectCountKHRDelegate_0 vkCmdDrawIndirectCountKHR_0;
	public static void vkCmdDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndexedIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndexedIndirectCountKHRPointer;
	private static vkCmdDrawIndexedIndirectCountKHRDelegate_0 vkCmdDrawIndexedIndirectCountKHR_0;
	public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) => vkGetMemoryHostPointerPropertiesEXT_0(device, handleType, pHostPointer, pMemoryHostPointerProperties);
	private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
	private static IntPtr vkGetMemoryHostPointerPropertiesEXTPointer;
	private static vkGetMemoryHostPointerPropertiesEXTDelegate_0 vkGetMemoryHostPointerPropertiesEXT_0;
	public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint32_t marker) => vkCmdWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
	private delegate void vkCmdWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint32_t marker);
	private static IntPtr vkCmdWriteBufferMarkerAMDPointer;
	private static vkCmdWriteBufferMarkerAMDDelegate_0 vkCmdWriteBufferMarkerAMD_0;
	public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint32_t* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains) => vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_0(physicalDevice, pTimeDomainCount, pTimeDomains);
	private delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
	private static IntPtr vkGetPhysicalDeviceCalibrateableTimeDomainsEXTPointer;
	private static vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0 vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_0;
	public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint32_t timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, uint64_t* pTimestamps, uint64_t* pMaxDeviation) => vkGetCalibratedTimestampsEXT_0(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
	private delegate VkResult vkGetCalibratedTimestampsEXTDelegate_0(VkDevice device, uint32_t timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, uint64_t* pTimestamps, uint64_t* pMaxDeviation);
	private static IntPtr vkGetCalibratedTimestampsEXTPointer;
	private static vkGetCalibratedTimestampsEXTDelegate_0 vkGetCalibratedTimestampsEXT_0;
	public static void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint32_t taskCount, uint32_t firstTask) => vkCmdDrawMeshTasksNV_0(commandBuffer, taskCount, firstTask);
	private delegate void vkCmdDrawMeshTasksNVDelegate_0(VkCommandBuffer commandBuffer, uint32_t taskCount, uint32_t firstTask);
	private static IntPtr vkCmdDrawMeshTasksNVPointer;
	private static vkCmdDrawMeshTasksNVDelegate_0 vkCmdDrawMeshTasksNV_0;
	public static void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride) => vkCmdDrawMeshTasksIndirectNV_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void vkCmdDrawMeshTasksIndirectNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride);
	private static IntPtr vkCmdDrawMeshTasksIndirectNVPointer;
	private static vkCmdDrawMeshTasksIndirectNVDelegate_0 vkCmdDrawMeshTasksIndirectNV_0;
	public static void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawMeshTasksIndirectCountNV_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawMeshTasksIndirectCountNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawMeshTasksIndirectCountNVPointer;
	private static vkCmdDrawMeshTasksIndirectCountNVDelegate_0 vkCmdDrawMeshTasksIndirectCountNV_0;
	public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint32_t firstExclusiveScissor, uint32_t exclusiveScissorCount, VkRect2D* pExclusiveScissors) => vkCmdSetExclusiveScissorNV_0(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
	private delegate void vkCmdSetExclusiveScissorNVDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstExclusiveScissor, uint32_t exclusiveScissorCount, VkRect2D* pExclusiveScissors);
	private static IntPtr vkCmdSetExclusiveScissorNVPointer;
	private static vkCmdSetExclusiveScissorNVDelegate_0 vkCmdSetExclusiveScissorNV_0;
	public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker) => vkCmdSetCheckpointNV_0(commandBuffer, pCheckpointMarker);
	private delegate void vkCmdSetCheckpointNVDelegate_0(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
	private static IntPtr vkCmdSetCheckpointNVPointer;
	private static vkCmdSetCheckpointNVDelegate_0 vkCmdSetCheckpointNV_0;
	public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint32_t* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData) => vkGetQueueCheckpointDataNV_0(queue, pCheckpointDataCount, pCheckpointData);
	private delegate void vkGetQueueCheckpointDataNVDelegate_0(VkQueue queue, uint32_t* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);
	private static IntPtr vkGetQueueCheckpointDataNVPointer;
	private static vkGetQueueCheckpointDataNVDelegate_0 vkGetQueueCheckpointDataNV_0;
	public static VkResult vkGetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, uint64_t* pValue) => vkGetSemaphoreCounterValueKHR_0(device, semaphore, pValue);
	private delegate VkResult vkGetSemaphoreCounterValueKHRDelegate_0(VkDevice device, VkSemaphore semaphore, uint64_t* pValue);
	private static IntPtr vkGetSemaphoreCounterValueKHRPointer;
	private static vkGetSemaphoreCounterValueKHRDelegate_0 vkGetSemaphoreCounterValueKHR_0;
	public static VkResult vkWaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfoKHR* pWaitInfo, uint64_t timeout) => vkWaitSemaphoresKHR_0(device, pWaitInfo, timeout);
	private delegate VkResult vkWaitSemaphoresKHRDelegate_0(VkDevice device, VkSemaphoreWaitInfoKHR* pWaitInfo, uint64_t timeout);
	private static IntPtr vkWaitSemaphoresKHRPointer;
	private static vkWaitSemaphoresKHRDelegate_0 vkWaitSemaphoresKHR_0;
	public static VkResult vkSignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfoKHR* pSignalInfo) => vkSignalSemaphoreKHR_0(device, pSignalInfo);
	private delegate VkResult vkSignalSemaphoreKHRDelegate_0(VkDevice device, VkSemaphoreSignalInfoKHR* pSignalInfo);
	private static IntPtr vkSignalSemaphoreKHRPointer;
	private static vkSignalSemaphoreKHRDelegate_0 vkSignalSemaphoreKHR_0;
	public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo) => vkInitializePerformanceApiINTEL_0(device, pInitializeInfo);
	private delegate VkResult vkInitializePerformanceApiINTELDelegate_0(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo);
	private static IntPtr vkInitializePerformanceApiINTELPointer;
	private static vkInitializePerformanceApiINTELDelegate_0 vkInitializePerformanceApiINTEL_0;
	public static void vkUninitializePerformanceApiINTEL(VkDevice device) => vkUninitializePerformanceApiINTEL_0(device);
	private delegate void vkUninitializePerformanceApiINTELDelegate_0(VkDevice device);
	private static IntPtr vkUninitializePerformanceApiINTELPointer;
	private static vkUninitializePerformanceApiINTELDelegate_0 vkUninitializePerformanceApiINTEL_0;
	public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo) => vkCmdSetPerformanceMarkerINTEL_0(commandBuffer, pMarkerInfo);
	private delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo);
	private static IntPtr vkCmdSetPerformanceMarkerINTELPointer;
	private static vkCmdSetPerformanceMarkerINTELDelegate_0 vkCmdSetPerformanceMarkerINTEL_0;
	public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo) => vkCmdSetPerformanceStreamMarkerINTEL_0(commandBuffer, pMarkerInfo);
	private delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);
	private static IntPtr vkCmdSetPerformanceStreamMarkerINTELPointer;
	private static vkCmdSetPerformanceStreamMarkerINTELDelegate_0 vkCmdSetPerformanceStreamMarkerINTEL_0;
	public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo) => vkCmdSetPerformanceOverrideINTEL_0(commandBuffer, pOverrideInfo);
	private delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo);
	private static IntPtr vkCmdSetPerformanceOverrideINTELPointer;
	private static vkCmdSetPerformanceOverrideINTELDelegate_0 vkCmdSetPerformanceOverrideINTEL_0;
	public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration) => vkAcquirePerformanceConfigurationINTEL_0(device, pAcquireInfo, pConfiguration);
	private delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration);
	private static IntPtr vkAcquirePerformanceConfigurationINTELPointer;
	private static vkAcquirePerformanceConfigurationINTELDelegate_0 vkAcquirePerformanceConfigurationINTEL_0;
	public static VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration) => vkReleasePerformanceConfigurationINTEL_0(device, configuration);
	private delegate VkResult vkReleasePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationINTEL configuration);
	private static IntPtr vkReleasePerformanceConfigurationINTELPointer;
	private static vkReleasePerformanceConfigurationINTELDelegate_0 vkReleasePerformanceConfigurationINTEL_0;
	public static VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration) => vkQueueSetPerformanceConfigurationINTEL_0(queue, configuration);
	private delegate VkResult vkQueueSetPerformanceConfigurationINTELDelegate_0(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
	private static IntPtr vkQueueSetPerformanceConfigurationINTELPointer;
	private static vkQueueSetPerformanceConfigurationINTELDelegate_0 vkQueueSetPerformanceConfigurationINTEL_0;
	public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue) => vkGetPerformanceParameterINTEL_0(device, parameter, pValue);
	private delegate VkResult vkGetPerformanceParameterINTELDelegate_0(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue);
	private static IntPtr vkGetPerformanceParameterINTELPointer;
	private static vkGetPerformanceParameterINTELDelegate_0 vkGetPerformanceParameterINTEL_0;
	public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable) => vkSetLocalDimmingAMD_0(device, swapChain, localDimmingEnable);
	private delegate void vkSetLocalDimmingAMDDelegate_0(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
	private static IntPtr vkSetLocalDimmingAMDPointer;
	private static vkSetLocalDimmingAMDDelegate_0 vkSetLocalDimmingAMD_0;
	[Obsolete("Use vkGetBufferDeviceAddressKHR")]
	public static void vkGetBufferDeviceAddressEXT(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => vkGetBufferDeviceAddressEXT_0(device, pInfo);
	private delegate void vkGetBufferDeviceAddressEXTDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr vkGetBufferDeviceAddressEXTPointer;
	private static vkGetBufferDeviceAddressEXTDelegate_0 vkGetBufferDeviceAddressEXT_0;
	public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint32_t* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties) => vkGetPhysicalDeviceToolPropertiesEXT_0(physicalDevice, pToolCount, pToolProperties);
	private delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);
	private static IntPtr vkGetPhysicalDeviceToolPropertiesEXTPointer;
	private static vkGetPhysicalDeviceToolPropertiesEXTDelegate_0 vkGetPhysicalDeviceToolPropertiesEXT_0;
	public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties) => vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);
	private static IntPtr vkGetPhysicalDeviceCooperativeMatrixPropertiesNVPointer;
	private static vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0 vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_0;
	public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint32_t* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations) => vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0(physicalDevice, pCombinationCount, pCombinations);
	private delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);
	private static IntPtr vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer;
	private static vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0 vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0;
	public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes) => vkGetPhysicalDeviceSurfacePresentModes2EXT_0(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
	private delegate VkResult vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes);
	private static IntPtr vkGetPhysicalDeviceSurfacePresentModes2EXTPointer;
	private static vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate_0 vkGetPhysicalDeviceSurfacePresentModes2EXT_0;
	public static VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => vkAcquireFullScreenExclusiveModeEXT_0(device, swapchain);
	private delegate VkResult vkAcquireFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr vkAcquireFullScreenExclusiveModeEXTPointer;
	private static vkAcquireFullScreenExclusiveModeEXTDelegate_0 vkAcquireFullScreenExclusiveModeEXT_0;
	public static VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => vkReleaseFullScreenExclusiveModeEXT_0(device, swapchain);
	private delegate VkResult vkReleaseFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr vkReleaseFullScreenExclusiveModeEXTPointer;
	private static vkReleaseFullScreenExclusiveModeEXTDelegate_0 vkReleaseFullScreenExclusiveModeEXT_0;
	public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes) => vkGetDeviceGroupSurfacePresentModes2EXT_0(device, pSurfaceInfo, pModes);
	private delegate VkResult vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr vkGetDeviceGroupSurfacePresentModes2EXTPointer;
	private static vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0 vkGetDeviceGroupSurfacePresentModes2EXT_0;
	public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes) => vkGetDeviceGroupSurfacePresentModes2EXT_0(device, pSurfaceInfo, pModes);
	private delegate VkResult vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr vkGetDeviceGroupSurfacePresentModes2EXTPointer;
	private static vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0 vkGetDeviceGroupSurfacePresentModes2EXT_0;
	public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => vkCreateHeadlessSurfaceEXT_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult vkCreateHeadlessSurfaceEXTDelegate_0(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr vkCreateHeadlessSurfaceEXTPointer;
	private static vkCreateHeadlessSurfaceEXTDelegate_0 vkCreateHeadlessSurfaceEXT_0;
	public static VkDeviceAddress vkGetBufferDeviceAddressKHR(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => vkGetBufferDeviceAddressKHR_0(device, pInfo);
	private delegate VkDeviceAddress vkGetBufferDeviceAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr vkGetBufferDeviceAddressKHRPointer;
	private static vkGetBufferDeviceAddressKHRDelegate_0 vkGetBufferDeviceAddressKHR_0;
	public static uint64_t vkGetBufferOpaqueCaptureAddressKHR(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => vkGetBufferOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate uint64_t vkGetBufferOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr vkGetBufferOpaqueCaptureAddressKHRPointer;
	private static vkGetBufferOpaqueCaptureAddressKHRDelegate_0 vkGetBufferOpaqueCaptureAddressKHR_0;
	public static uint64_t vkGetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfoKHR* pInfo) => vkGetDeviceMemoryOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate uint64_t vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfoKHR* pInfo);
	private static IntPtr vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer;
	private static vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0 vkGetDeviceMemoryOpaqueCaptureAddressKHR_0;
	public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint32_t lineStippleFactor, uint16_t lineStipplePattern) => vkCmdSetLineStippleEXT_0(commandBuffer, lineStippleFactor, lineStipplePattern);
	private delegate void vkCmdSetLineStippleEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t lineStippleFactor, uint16_t lineStipplePattern);
	private static IntPtr vkCmdSetLineStippleEXTPointer;
	private static vkCmdSetLineStippleEXTDelegate_0 vkCmdSetLineStippleEXT_0;
	public static void vkResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount) => vkResetQueryPoolEXT_0(device, queryPool, firstQuery, queryCount);
	private delegate void vkResetQueryPoolEXTDelegate_0(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount);
	private static IntPtr vkResetQueryPoolEXTPointer;
	private static vkResetQueryPoolEXTDelegate_0 vkResetQueryPoolEXT_0;
	public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint32_t* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties) => vkGetPipelineExecutablePropertiesKHR_0(device, pPipelineInfo, pExecutableCount, pProperties);
	private delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate_0(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint32_t* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);
	private static IntPtr vkGetPipelineExecutablePropertiesKHRPointer;
	private static vkGetPipelineExecutablePropertiesKHRDelegate_0 vkGetPipelineExecutablePropertiesKHR_0;
	public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint32_t* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics) => vkGetPipelineExecutableStatisticsKHR_0(device, pExecutableInfo, pStatisticCount, pStatistics);
	private delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint32_t* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);
	private static IntPtr vkGetPipelineExecutableStatisticsKHRPointer;
	private static vkGetPipelineExecutableStatisticsKHRDelegate_0 vkGetPipelineExecutableStatisticsKHR_0;
	public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint32_t* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations) => vkGetPipelineExecutableInternalRepresentationsKHR_0(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
	private delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint32_t* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);
	private static IntPtr vkGetPipelineExecutableInternalRepresentationsKHRPointer;
	private static vkGetPipelineExecutableInternalRepresentationsKHRDelegate_0 vkGetPipelineExecutableInternalRepresentationsKHR_0;
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
		vkEnumerateInstanceVersionPointer = vkGetInstanceProcAddr(instance, "vkEnumerateInstanceVersion");
		if (vkEnumerateInstanceVersionPointer != IntPtr.Zero)
		{
			vkEnumerateInstanceVersion_0 = Marshal.GetDelegateForFunctionPointer<vkEnumerateInstanceVersionDelegate_0>(vkEnumerateInstanceVersionPointer);
		}
		vkBindBufferMemory2Pointer = vkGetInstanceProcAddr(instance, "vkBindBufferMemory2");
		if (vkBindBufferMemory2Pointer != IntPtr.Zero)
		{
			vkBindBufferMemory2_0 = Marshal.GetDelegateForFunctionPointer<vkBindBufferMemory2Delegate_0>(vkBindBufferMemory2Pointer);
		}
		vkBindImageMemory2Pointer = vkGetInstanceProcAddr(instance, "vkBindImageMemory2");
		if (vkBindImageMemory2Pointer != IntPtr.Zero)
		{
			vkBindImageMemory2_0 = Marshal.GetDelegateForFunctionPointer<vkBindImageMemory2Delegate_0>(vkBindImageMemory2Pointer);
		}
		vkGetDeviceGroupPeerMemoryFeaturesPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPeerMemoryFeatures");
		if (vkGetDeviceGroupPeerMemoryFeaturesPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPeerMemoryFeatures_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPeerMemoryFeaturesDelegate_0>(vkGetDeviceGroupPeerMemoryFeaturesPointer);
		}
		vkCmdSetDeviceMaskPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDeviceMask");
		if (vkCmdSetDeviceMaskPointer != IntPtr.Zero)
		{
			vkCmdSetDeviceMask_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDeviceMaskDelegate_0>(vkCmdSetDeviceMaskPointer);
		}
		vkCmdDispatchBasePointer = vkGetInstanceProcAddr(instance, "vkCmdDispatchBase");
		if (vkCmdDispatchBasePointer != IntPtr.Zero)
		{
			vkCmdDispatchBase_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDispatchBaseDelegate_0>(vkCmdDispatchBasePointer);
		}
		vkEnumeratePhysicalDeviceGroupsPointer = vkGetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceGroups");
		if (vkEnumeratePhysicalDeviceGroupsPointer != IntPtr.Zero)
		{
			vkEnumeratePhysicalDeviceGroups_0 = Marshal.GetDelegateForFunctionPointer<vkEnumeratePhysicalDeviceGroupsDelegate_0>(vkEnumeratePhysicalDeviceGroupsPointer);
		}
		vkGetImageMemoryRequirements2Pointer = vkGetInstanceProcAddr(instance, "vkGetImageMemoryRequirements2");
		if (vkGetImageMemoryRequirements2Pointer != IntPtr.Zero)
		{
			vkGetImageMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageMemoryRequirements2Delegate_0>(vkGetImageMemoryRequirements2Pointer);
		}
		vkGetBufferMemoryRequirements2Pointer = vkGetInstanceProcAddr(instance, "vkGetBufferMemoryRequirements2");
		if (vkGetBufferMemoryRequirements2Pointer != IntPtr.Zero)
		{
			vkGetBufferMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferMemoryRequirements2Delegate_0>(vkGetBufferMemoryRequirements2Pointer);
		}
		vkGetImageSparseMemoryRequirements2Pointer = vkGetInstanceProcAddr(instance, "vkGetImageSparseMemoryRequirements2");
		if (vkGetImageSparseMemoryRequirements2Pointer != IntPtr.Zero)
		{
			vkGetImageSparseMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageSparseMemoryRequirements2Delegate_0>(vkGetImageSparseMemoryRequirements2Pointer);
		}
		vkGetPhysicalDeviceFeatures2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFeatures2");
		if (vkGetPhysicalDeviceFeatures2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFeatures2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFeatures2Delegate_0>(vkGetPhysicalDeviceFeatures2Pointer);
		}
		vkGetPhysicalDeviceProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceProperties2");
		if (vkGetPhysicalDeviceProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceProperties2Delegate_0>(vkGetPhysicalDeviceProperties2Pointer);
		}
		vkGetPhysicalDeviceFormatProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFormatProperties2");
		if (vkGetPhysicalDeviceFormatProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFormatProperties2Delegate_0>(vkGetPhysicalDeviceFormatProperties2Pointer);
		}
		vkGetPhysicalDeviceImageFormatProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceImageFormatProperties2");
		if (vkGetPhysicalDeviceImageFormatProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceImageFormatProperties2Delegate_0>(vkGetPhysicalDeviceImageFormatProperties2Pointer);
		}
		vkGetPhysicalDeviceQueueFamilyProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
		if (vkGetPhysicalDeviceQueueFamilyProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceQueueFamilyProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceQueueFamilyProperties2Delegate_0>(vkGetPhysicalDeviceQueueFamilyProperties2Pointer);
		}
		vkGetPhysicalDeviceMemoryProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMemoryProperties2");
		if (vkGetPhysicalDeviceMemoryProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMemoryProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMemoryProperties2Delegate_0>(vkGetPhysicalDeviceMemoryProperties2Pointer);
		}
		vkGetPhysicalDeviceSparseImageFormatProperties2Pointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
		if (vkGetPhysicalDeviceSparseImageFormatProperties2Pointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSparseImageFormatProperties2Delegate_0>(vkGetPhysicalDeviceSparseImageFormatProperties2Pointer);
		}
		vkTrimCommandPoolPointer = vkGetInstanceProcAddr(instance, "vkTrimCommandPool");
		if (vkTrimCommandPoolPointer != IntPtr.Zero)
		{
			vkTrimCommandPool_0 = Marshal.GetDelegateForFunctionPointer<vkTrimCommandPoolDelegate_0>(vkTrimCommandPoolPointer);
		}
		vkGetDeviceQueue2Pointer = vkGetInstanceProcAddr(instance, "vkGetDeviceQueue2");
		if (vkGetDeviceQueue2Pointer != IntPtr.Zero)
		{
			vkGetDeviceQueue2_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceQueue2Delegate_0>(vkGetDeviceQueue2Pointer);
		}
		vkCreateSamplerYcbcrConversionPointer = vkGetInstanceProcAddr(instance, "vkCreateSamplerYcbcrConversion");
		if (vkCreateSamplerYcbcrConversionPointer != IntPtr.Zero)
		{
			vkCreateSamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSamplerYcbcrConversionDelegate_0>(vkCreateSamplerYcbcrConversionPointer);
		}
		vkDestroySamplerYcbcrConversionPointer = vkGetInstanceProcAddr(instance, "vkDestroySamplerYcbcrConversion");
		if (vkDestroySamplerYcbcrConversionPointer != IntPtr.Zero)
		{
			vkDestroySamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySamplerYcbcrConversionDelegate_0>(vkDestroySamplerYcbcrConversionPointer);
		}
		vkCreateDescriptorUpdateTemplatePointer = vkGetInstanceProcAddr(instance, "vkCreateDescriptorUpdateTemplate");
		if (vkCreateDescriptorUpdateTemplatePointer != IntPtr.Zero)
		{
			vkCreateDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDescriptorUpdateTemplateDelegate_0>(vkCreateDescriptorUpdateTemplatePointer);
		}
		vkDestroyDescriptorUpdateTemplatePointer = vkGetInstanceProcAddr(instance, "vkDestroyDescriptorUpdateTemplate");
		if (vkDestroyDescriptorUpdateTemplatePointer != IntPtr.Zero)
		{
			vkDestroyDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDescriptorUpdateTemplateDelegate_0>(vkDestroyDescriptorUpdateTemplatePointer);
		}
		vkUpdateDescriptorSetWithTemplatePointer = vkGetInstanceProcAddr(instance, "vkUpdateDescriptorSetWithTemplate");
		if (vkUpdateDescriptorSetWithTemplatePointer != IntPtr.Zero)
		{
			vkUpdateDescriptorSetWithTemplate_0 = Marshal.GetDelegateForFunctionPointer<vkUpdateDescriptorSetWithTemplateDelegate_0>(vkUpdateDescriptorSetWithTemplatePointer);
		}
		vkGetPhysicalDeviceExternalBufferPropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalBufferProperties");
		if (vkGetPhysicalDeviceExternalBufferPropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalBufferProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalBufferPropertiesDelegate_0>(vkGetPhysicalDeviceExternalBufferPropertiesPointer);
		}
		vkGetPhysicalDeviceExternalFencePropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalFenceProperties");
		if (vkGetPhysicalDeviceExternalFencePropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalFenceProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalFencePropertiesDelegate_0>(vkGetPhysicalDeviceExternalFencePropertiesPointer);
		}
		vkGetPhysicalDeviceExternalSemaphorePropertiesPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
		if (vkGetPhysicalDeviceExternalSemaphorePropertiesPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceExternalSemaphoreProperties_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate_0>(vkGetPhysicalDeviceExternalSemaphorePropertiesPointer);
		}
		vkGetDescriptorSetLayoutSupportPointer = vkGetInstanceProcAddr(instance, "vkGetDescriptorSetLayoutSupport");
		if (vkGetDescriptorSetLayoutSupportPointer != IntPtr.Zero)
		{
			vkGetDescriptorSetLayoutSupport_0 = Marshal.GetDelegateForFunctionPointer<vkGetDescriptorSetLayoutSupportDelegate_0>(vkGetDescriptorSetLayoutSupportPointer);
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
		vkGetDeviceGroupPresentCapabilitiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPresentCapabilitiesKHR");
		if (vkGetDeviceGroupPresentCapabilitiesKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0>(vkGetDeviceGroupPresentCapabilitiesKHRPointer);
		}
		vkGetDeviceGroupSurfacePresentModesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupSurfacePresentModesKHR");
		if (vkGetDeviceGroupSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupSurfacePresentModesKHRDelegate_0>(vkGetDeviceGroupSurfacePresentModesKHRPointer);
		}
		vkGetPhysicalDevicePresentRectanglesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDevicePresentRectanglesKHR");
		if (vkGetPhysicalDevicePresentRectanglesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDevicePresentRectanglesKHRDelegate_0>(vkGetPhysicalDevicePresentRectanglesKHRPointer);
		}
		vkAcquireNextImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkAcquireNextImage2KHR");
		if (vkAcquireNextImage2KHRPointer != IntPtr.Zero)
		{
			vkAcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireNextImage2KHRDelegate_0>(vkAcquireNextImage2KHRPointer);
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
		vkCmdBindTransformFeedbackBuffersEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBindTransformFeedbackBuffersEXT");
		if (vkCmdBindTransformFeedbackBuffersEXTPointer != IntPtr.Zero)
		{
			vkCmdBindTransformFeedbackBuffersEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindTransformFeedbackBuffersEXTDelegate_0>(vkCmdBindTransformFeedbackBuffersEXTPointer);
		}
		vkCmdBeginTransformFeedbackEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginTransformFeedbackEXT");
		if (vkCmdBeginTransformFeedbackEXTPointer != IntPtr.Zero)
		{
			vkCmdBeginTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginTransformFeedbackEXTDelegate_0>(vkCmdBeginTransformFeedbackEXTPointer);
		}
		vkCmdEndTransformFeedbackEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdEndTransformFeedbackEXT");
		if (vkCmdEndTransformFeedbackEXTPointer != IntPtr.Zero)
		{
			vkCmdEndTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndTransformFeedbackEXTDelegate_0>(vkCmdEndTransformFeedbackEXTPointer);
		}
		vkCmdBeginQueryIndexedEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginQueryIndexedEXT");
		if (vkCmdBeginQueryIndexedEXTPointer != IntPtr.Zero)
		{
			vkCmdBeginQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginQueryIndexedEXTDelegate_0>(vkCmdBeginQueryIndexedEXTPointer);
		}
		vkCmdEndQueryIndexedEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdEndQueryIndexedEXT");
		if (vkCmdEndQueryIndexedEXTPointer != IntPtr.Zero)
		{
			vkCmdEndQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndQueryIndexedEXTDelegate_0>(vkCmdEndQueryIndexedEXTPointer);
		}
		vkCmdDrawIndirectByteCountEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectByteCountEXT");
		if (vkCmdDrawIndirectByteCountEXTPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectByteCountEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectByteCountEXTDelegate_0>(vkCmdDrawIndirectByteCountEXTPointer);
		}
		vkGetImageViewHandleNVXPointer = vkGetInstanceProcAddr(instance, "vkGetImageViewHandleNVX");
		if (vkGetImageViewHandleNVXPointer != IntPtr.Zero)
		{
			vkGetImageViewHandleNVX_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageViewHandleNVXDelegate_0>(vkGetImageViewHandleNVXPointer);
		}
		vkCmdDrawIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCountKHR");
		if (vkCmdDrawIndirectCountAMDPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountAMDDelegate_0>(vkCmdDrawIndirectCountAMDPointer);
		}
		vkCmdDrawIndexedIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCountKHR");
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
		vkGetPhysicalDeviceFeatures2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFeatures2");
		if (vkGetPhysicalDeviceFeatures2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFeatures2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFeatures2KHRDelegate_0>(vkGetPhysicalDeviceFeatures2KHRPointer);
		}
		vkGetPhysicalDeviceProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceProperties2");
		if (vkGetPhysicalDeviceProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceProperties2KHRDelegate_0>(vkGetPhysicalDeviceProperties2KHRPointer);
		}
		vkGetPhysicalDeviceFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFormatProperties2");
		if (vkGetPhysicalDeviceFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceFormatProperties2KHRPointer);
		}
		vkGetPhysicalDeviceImageFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceImageFormatProperties2");
		if (vkGetPhysicalDeviceImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceImageFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceImageFormatProperties2KHRPointer);
		}
		vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
		if (vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceQueueFamilyProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0>(vkGetPhysicalDeviceQueueFamilyProperties2KHRPointer);
		}
		vkGetPhysicalDeviceMemoryProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceMemoryProperties2");
		if (vkGetPhysicalDeviceMemoryProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceMemoryProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceMemoryProperties2KHRDelegate_0>(vkGetPhysicalDeviceMemoryProperties2KHRPointer);
		}
		vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
		if (vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0>(vkGetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
		}
		vkGetDeviceGroupPeerMemoryFeaturesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPeerMemoryFeatures");
		if (vkGetDeviceGroupPeerMemoryFeaturesKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPeerMemoryFeaturesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPeerMemoryFeaturesKHRDelegate_0>(vkGetDeviceGroupPeerMemoryFeaturesKHRPointer);
		}
		vkCmdSetDeviceMaskKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDeviceMask");
		if (vkCmdSetDeviceMaskKHRPointer != IntPtr.Zero)
		{
			vkCmdSetDeviceMaskKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDeviceMaskKHRDelegate_0>(vkCmdSetDeviceMaskKHRPointer);
		}
		vkCmdDispatchBaseKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdDispatchBase");
		if (vkCmdDispatchBaseKHRPointer != IntPtr.Zero)
		{
			vkCmdDispatchBaseKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDispatchBaseKHRDelegate_0>(vkCmdDispatchBaseKHRPointer);
		}
		vkGetDeviceGroupPresentCapabilitiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupPresentCapabilitiesKHR");
		if (vkGetDeviceGroupPresentCapabilitiesKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupPresentCapabilitiesKHRDelegate_0>(vkGetDeviceGroupPresentCapabilitiesKHRPointer);
		}
		vkGetDeviceGroupSurfacePresentModesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupSurfacePresentModesKHR");
		if (vkGetDeviceGroupSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupSurfacePresentModesKHRDelegate_0>(vkGetDeviceGroupSurfacePresentModesKHRPointer);
		}
		vkGetPhysicalDevicePresentRectanglesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDevicePresentRectanglesKHR");
		if (vkGetPhysicalDevicePresentRectanglesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDevicePresentRectanglesKHRDelegate_0>(vkGetPhysicalDevicePresentRectanglesKHRPointer);
		}
		vkAcquireNextImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkAcquireNextImage2KHR");
		if (vkAcquireNextImage2KHRPointer != IntPtr.Zero)
		{
			vkAcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireNextImage2KHRDelegate_0>(vkAcquireNextImage2KHRPointer);
		}
		vkTrimCommandPoolKHRPointer = vkGetInstanceProcAddr(instance, "vkTrimCommandPool");
		if (vkTrimCommandPoolKHRPointer != IntPtr.Zero)
		{
			vkTrimCommandPoolKHR_0 = Marshal.GetDelegateForFunctionPointer<vkTrimCommandPoolKHRDelegate_0>(vkTrimCommandPoolKHRPointer);
		}
		vkEnumeratePhysicalDeviceGroupsKHRPointer = vkGetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceGroups");
		if (vkEnumeratePhysicalDeviceGroupsKHRPointer != IntPtr.Zero)
		{
			vkEnumeratePhysicalDeviceGroupsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkEnumeratePhysicalDeviceGroupsKHRDelegate_0>(vkEnumeratePhysicalDeviceGroupsKHRPointer);
		}
		vkGetPhysicalDeviceExternalBufferPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalBufferProperties");
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
		vkGetPhysicalDeviceExternalSemaphorePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
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
		vkCmdPushDescriptorSetWithTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdPushDescriptorSetWithTemplateKHR");
		if (vkCmdPushDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			vkCmdPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPushDescriptorSetWithTemplateKHRDelegate_0>(vkCmdPushDescriptorSetWithTemplateKHRPointer);
		}
		vkCmdBeginConditionalRenderingEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginConditionalRenderingEXT");
		if (vkCmdBeginConditionalRenderingEXTPointer != IntPtr.Zero)
		{
			vkCmdBeginConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginConditionalRenderingEXTDelegate_0>(vkCmdBeginConditionalRenderingEXTPointer);
		}
		vkCmdEndConditionalRenderingEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdEndConditionalRenderingEXT");
		if (vkCmdEndConditionalRenderingEXTPointer != IntPtr.Zero)
		{
			vkCmdEndConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndConditionalRenderingEXTDelegate_0>(vkCmdEndConditionalRenderingEXTPointer);
		}
		vkCreateDescriptorUpdateTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateDescriptorUpdateTemplate");
		if (vkCreateDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			vkCreateDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDescriptorUpdateTemplateKHRDelegate_0>(vkCreateDescriptorUpdateTemplateKHRPointer);
		}
		vkDestroyDescriptorUpdateTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroyDescriptorUpdateTemplate");
		if (vkDestroyDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			vkDestroyDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDescriptorUpdateTemplateKHRDelegate_0>(vkDestroyDescriptorUpdateTemplateKHRPointer);
		}
		vkUpdateDescriptorSetWithTemplateKHRPointer = vkGetInstanceProcAddr(instance, "vkUpdateDescriptorSetWithTemplate");
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
		vkCreateRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCreateRenderPass2KHR");
		if (vkCreateRenderPass2KHRPointer != IntPtr.Zero)
		{
			vkCreateRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRenderPass2KHRDelegate_0>(vkCreateRenderPass2KHRPointer);
		}
		vkCmdBeginRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginRenderPass2KHR");
		if (vkCmdBeginRenderPass2KHRPointer != IntPtr.Zero)
		{
			vkCmdBeginRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginRenderPass2KHRDelegate_0>(vkCmdBeginRenderPass2KHRPointer);
		}
		vkCmdNextSubpass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdNextSubpass2KHR");
		if (vkCmdNextSubpass2KHRPointer != IntPtr.Zero)
		{
			vkCmdNextSubpass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdNextSubpass2KHRDelegate_0>(vkCmdNextSubpass2KHRPointer);
		}
		vkCmdEndRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdEndRenderPass2KHR");
		if (vkCmdEndRenderPass2KHRPointer != IntPtr.Zero)
		{
			vkCmdEndRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndRenderPass2KHRDelegate_0>(vkCmdEndRenderPass2KHRPointer);
		}
		vkGetSwapchainStatusKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSwapchainStatusKHR");
		if (vkGetSwapchainStatusKHRPointer != IntPtr.Zero)
		{
			vkGetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSwapchainStatusKHRDelegate_0>(vkGetSwapchainStatusKHRPointer);
		}
		vkGetPhysicalDeviceExternalFencePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalFenceProperties");
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
		vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer = vkGetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
		if (vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer != IntPtr.Zero)
		{
			vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0 = Marshal.GetDelegateForFunctionPointer<vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0>(vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer);
		}
		vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
		if (vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0>(vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer);
		}
		vkAcquireProfilingLockKHRPointer = vkGetInstanceProcAddr(instance, "vkAcquireProfilingLockKHR");
		if (vkAcquireProfilingLockKHRPointer != IntPtr.Zero)
		{
			vkAcquireProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireProfilingLockKHRDelegate_0>(vkAcquireProfilingLockKHRPointer);
		}
		vkReleaseProfilingLockKHRPointer = vkGetInstanceProcAddr(instance, "vkReleaseProfilingLockKHR");
		if (vkReleaseProfilingLockKHRPointer != IntPtr.Zero)
		{
			vkReleaseProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<vkReleaseProfilingLockKHRDelegate_0>(vkReleaseProfilingLockKHRPointer);
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
		vkGetPhysicalDeviceDisplayProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
		if (vkGetPhysicalDeviceDisplayProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceDisplayProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceDisplayProperties2KHRDelegate_0>(vkGetPhysicalDeviceDisplayProperties2KHRPointer);
		}
		vkGetPhysicalDeviceDisplayPlaneProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
		if (vkGetPhysicalDeviceDisplayPlaneProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceDisplayPlaneProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0>(vkGetPhysicalDeviceDisplayPlaneProperties2KHRPointer);
		}
		vkGetDisplayModeProperties2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetDisplayModeProperties2KHR");
		if (vkGetDisplayModeProperties2KHRPointer != IntPtr.Zero)
		{
			vkGetDisplayModeProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDisplayModeProperties2KHRDelegate_0>(vkGetDisplayModeProperties2KHRPointer);
		}
		vkGetDisplayPlaneCapabilities2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilities2KHR");
		if (vkGetDisplayPlaneCapabilities2KHRPointer != IntPtr.Zero)
		{
			vkGetDisplayPlaneCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDisplayPlaneCapabilities2KHRDelegate_0>(vkGetDisplayPlaneCapabilities2KHRPointer);
		}
		vkCreateMacOSSurfaceMVKPointer = vkGetInstanceProcAddr(instance, "vkCreateMacOSSurfaceMVK");
		if (vkCreateMacOSSurfaceMVKPointer != IntPtr.Zero)
		{
			vkCreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<vkCreateMacOSSurfaceMVKDelegate_0>(vkCreateMacOSSurfaceMVKPointer);
		}
		vkSetDebugUtilsObjectNameEXTPointer = vkGetInstanceProcAddr(instance, "vkSetDebugUtilsObjectNameEXT");
		if (vkSetDebugUtilsObjectNameEXTPointer != IntPtr.Zero)
		{
			vkSetDebugUtilsObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSetDebugUtilsObjectNameEXTDelegate_0>(vkSetDebugUtilsObjectNameEXTPointer);
		}
		vkSetDebugUtilsObjectTagEXTPointer = vkGetInstanceProcAddr(instance, "vkSetDebugUtilsObjectTagEXT");
		if (vkSetDebugUtilsObjectTagEXTPointer != IntPtr.Zero)
		{
			vkSetDebugUtilsObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSetDebugUtilsObjectTagEXTDelegate_0>(vkSetDebugUtilsObjectTagEXTPointer);
		}
		vkQueueBeginDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkQueueBeginDebugUtilsLabelEXT");
		if (vkQueueBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkQueueBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkQueueBeginDebugUtilsLabelEXTDelegate_0>(vkQueueBeginDebugUtilsLabelEXTPointer);
		}
		vkQueueEndDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkQueueEndDebugUtilsLabelEXT");
		if (vkQueueEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkQueueEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkQueueEndDebugUtilsLabelEXTDelegate_0>(vkQueueEndDebugUtilsLabelEXTPointer);
		}
		vkQueueInsertDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkQueueInsertDebugUtilsLabelEXT");
		if (vkQueueInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkQueueInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkQueueInsertDebugUtilsLabelEXTDelegate_0>(vkQueueInsertDebugUtilsLabelEXTPointer);
		}
		vkCmdBeginDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginDebugUtilsLabelEXT");
		if (vkCmdBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkCmdBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginDebugUtilsLabelEXTDelegate_0>(vkCmdBeginDebugUtilsLabelEXTPointer);
		}
		vkCmdEndDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdEndDebugUtilsLabelEXT");
		if (vkCmdEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkCmdEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndDebugUtilsLabelEXTDelegate_0>(vkCmdEndDebugUtilsLabelEXTPointer);
		}
		vkCmdInsertDebugUtilsLabelEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdInsertDebugUtilsLabelEXT");
		if (vkCmdInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			vkCmdInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdInsertDebugUtilsLabelEXTDelegate_0>(vkCmdInsertDebugUtilsLabelEXTPointer);
		}
		vkCreateDebugUtilsMessengerEXTPointer = vkGetInstanceProcAddr(instance, "vkCreateDebugUtilsMessengerEXT");
		if (vkCreateDebugUtilsMessengerEXTPointer != IntPtr.Zero)
		{
			vkCreateDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDebugUtilsMessengerEXTDelegate_0>(vkCreateDebugUtilsMessengerEXTPointer);
		}
		vkDestroyDebugUtilsMessengerEXTPointer = vkGetInstanceProcAddr(instance, "vkDestroyDebugUtilsMessengerEXT");
		if (vkDestroyDebugUtilsMessengerEXTPointer != IntPtr.Zero)
		{
			vkDestroyDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDebugUtilsMessengerEXTDelegate_0>(vkDestroyDebugUtilsMessengerEXTPointer);
		}
		vkSubmitDebugUtilsMessageEXTPointer = vkGetInstanceProcAddr(instance, "vkSubmitDebugUtilsMessageEXT");
		if (vkSubmitDebugUtilsMessageEXTPointer != IntPtr.Zero)
		{
			vkSubmitDebugUtilsMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSubmitDebugUtilsMessageEXTDelegate_0>(vkSubmitDebugUtilsMessageEXTPointer);
		}
		vkGetAndroidHardwareBufferPropertiesANDROIDPointer = vkGetInstanceProcAddr(instance, "vkGetAndroidHardwareBufferPropertiesANDROID");
		if (vkGetAndroidHardwareBufferPropertiesANDROIDPointer != IntPtr.Zero)
		{
			vkGetAndroidHardwareBufferPropertiesANDROID_0 = Marshal.GetDelegateForFunctionPointer<vkGetAndroidHardwareBufferPropertiesANDROIDDelegate_0>(vkGetAndroidHardwareBufferPropertiesANDROIDPointer);
		}
		vkGetMemoryAndroidHardwareBufferANDROIDPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryAndroidHardwareBufferANDROID");
		if (vkGetMemoryAndroidHardwareBufferANDROIDPointer != IntPtr.Zero)
		{
			vkGetMemoryAndroidHardwareBufferANDROID_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryAndroidHardwareBufferANDROIDDelegate_0>(vkGetMemoryAndroidHardwareBufferANDROIDPointer);
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
		vkGetImageMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetImageMemoryRequirements2");
		if (vkGetImageMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetImageMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageMemoryRequirements2KHRDelegate_0>(vkGetImageMemoryRequirements2KHRPointer);
		}
		vkGetBufferMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferMemoryRequirements2");
		if (vkGetBufferMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetBufferMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferMemoryRequirements2KHRDelegate_0>(vkGetBufferMemoryRequirements2KHRPointer);
		}
		vkGetImageSparseMemoryRequirements2KHRPointer = vkGetInstanceProcAddr(instance, "vkGetImageSparseMemoryRequirements2");
		if (vkGetImageSparseMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			vkGetImageSparseMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageSparseMemoryRequirements2KHRDelegate_0>(vkGetImageSparseMemoryRequirements2KHRPointer);
		}
		vkCreateSamplerYcbcrConversionKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateSamplerYcbcrConversion");
		if (vkCreateSamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			vkCreateSamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateSamplerYcbcrConversionKHRDelegate_0>(vkCreateSamplerYcbcrConversionKHRPointer);
		}
		vkDestroySamplerYcbcrConversionKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroySamplerYcbcrConversion");
		if (vkDestroySamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			vkDestroySamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroySamplerYcbcrConversionKHRDelegate_0>(vkDestroySamplerYcbcrConversionKHRPointer);
		}
		vkBindBufferMemory2KHRPointer = vkGetInstanceProcAddr(instance, "vkBindBufferMemory2");
		if (vkBindBufferMemory2KHRPointer != IntPtr.Zero)
		{
			vkBindBufferMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkBindBufferMemory2KHRDelegate_0>(vkBindBufferMemory2KHRPointer);
		}
		vkBindImageMemory2KHRPointer = vkGetInstanceProcAddr(instance, "vkBindImageMemory2");
		if (vkBindImageMemory2KHRPointer != IntPtr.Zero)
		{
			vkBindImageMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkBindImageMemory2KHRDelegate_0>(vkBindImageMemory2KHRPointer);
		}
		vkGetImageDrmFormatModifierPropertiesEXTPointer = vkGetInstanceProcAddr(instance, "vkGetImageDrmFormatModifierPropertiesEXT");
		if (vkGetImageDrmFormatModifierPropertiesEXTPointer != IntPtr.Zero)
		{
			vkGetImageDrmFormatModifierPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageDrmFormatModifierPropertiesEXTDelegate_0>(vkGetImageDrmFormatModifierPropertiesEXTPointer);
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
		vkCmdBindShadingRateImageNVPointer = vkGetInstanceProcAddr(instance, "vkCmdBindShadingRateImageNV");
		if (vkCmdBindShadingRateImageNVPointer != IntPtr.Zero)
		{
			vkCmdBindShadingRateImageNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindShadingRateImageNVDelegate_0>(vkCmdBindShadingRateImageNVPointer);
		}
		vkCmdSetViewportShadingRatePaletteNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetViewportShadingRatePaletteNV");
		if (vkCmdSetViewportShadingRatePaletteNVPointer != IntPtr.Zero)
		{
			vkCmdSetViewportShadingRatePaletteNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetViewportShadingRatePaletteNVDelegate_0>(vkCmdSetViewportShadingRatePaletteNVPointer);
		}
		vkCmdSetCoarseSampleOrderNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetCoarseSampleOrderNV");
		if (vkCmdSetCoarseSampleOrderNVPointer != IntPtr.Zero)
		{
			vkCmdSetCoarseSampleOrderNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetCoarseSampleOrderNVDelegate_0>(vkCmdSetCoarseSampleOrderNVPointer);
		}
		vkCreateAccelerationStructureNVPointer = vkGetInstanceProcAddr(instance, "vkCreateAccelerationStructureNV");
		if (vkCreateAccelerationStructureNVPointer != IntPtr.Zero)
		{
			vkCreateAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<vkCreateAccelerationStructureNVDelegate_0>(vkCreateAccelerationStructureNVPointer);
		}
		vkDestroyAccelerationStructureNVPointer = vkGetInstanceProcAddr(instance, "vkDestroyAccelerationStructureNV");
		if (vkDestroyAccelerationStructureNVPointer != IntPtr.Zero)
		{
			vkDestroyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyAccelerationStructureNVDelegate_0>(vkDestroyAccelerationStructureNVPointer);
		}
		vkGetAccelerationStructureMemoryRequirementsNVPointer = vkGetInstanceProcAddr(instance, "vkGetAccelerationStructureMemoryRequirementsNV");
		if (vkGetAccelerationStructureMemoryRequirementsNVPointer != IntPtr.Zero)
		{
			vkGetAccelerationStructureMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetAccelerationStructureMemoryRequirementsNVDelegate_0>(vkGetAccelerationStructureMemoryRequirementsNVPointer);
		}
		vkBindAccelerationStructureMemoryNVPointer = vkGetInstanceProcAddr(instance, "vkBindAccelerationStructureMemoryNV");
		if (vkBindAccelerationStructureMemoryNVPointer != IntPtr.Zero)
		{
			vkBindAccelerationStructureMemoryNV_0 = Marshal.GetDelegateForFunctionPointer<vkBindAccelerationStructureMemoryNVDelegate_0>(vkBindAccelerationStructureMemoryNVPointer);
		}
		vkCmdBuildAccelerationStructureNVPointer = vkGetInstanceProcAddr(instance, "vkCmdBuildAccelerationStructureNV");
		if (vkCmdBuildAccelerationStructureNVPointer != IntPtr.Zero)
		{
			vkCmdBuildAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBuildAccelerationStructureNVDelegate_0>(vkCmdBuildAccelerationStructureNVPointer);
		}
		vkCmdCopyAccelerationStructureNVPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyAccelerationStructureNV");
		if (vkCmdCopyAccelerationStructureNVPointer != IntPtr.Zero)
		{
			vkCmdCopyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyAccelerationStructureNVDelegate_0>(vkCmdCopyAccelerationStructureNVPointer);
		}
		vkCmdTraceRaysNVPointer = vkGetInstanceProcAddr(instance, "vkCmdTraceRaysNV");
		if (vkCmdTraceRaysNVPointer != IntPtr.Zero)
		{
			vkCmdTraceRaysNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdTraceRaysNVDelegate_0>(vkCmdTraceRaysNVPointer);
		}
		vkCreateRayTracingPipelinesNVPointer = vkGetInstanceProcAddr(instance, "vkCreateRayTracingPipelinesNV");
		if (vkCreateRayTracingPipelinesNVPointer != IntPtr.Zero)
		{
			vkCreateRayTracingPipelinesNV_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRayTracingPipelinesNVDelegate_0>(vkCreateRayTracingPipelinesNVPointer);
		}
		vkGetRayTracingShaderGroupHandlesNVPointer = vkGetInstanceProcAddr(instance, "vkGetRayTracingShaderGroupHandlesNV");
		if (vkGetRayTracingShaderGroupHandlesNVPointer != IntPtr.Zero)
		{
			vkGetRayTracingShaderGroupHandlesNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetRayTracingShaderGroupHandlesNVDelegate_0>(vkGetRayTracingShaderGroupHandlesNVPointer);
		}
		vkGetAccelerationStructureHandleNVPointer = vkGetInstanceProcAddr(instance, "vkGetAccelerationStructureHandleNV");
		if (vkGetAccelerationStructureHandleNVPointer != IntPtr.Zero)
		{
			vkGetAccelerationStructureHandleNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetAccelerationStructureHandleNVDelegate_0>(vkGetAccelerationStructureHandleNVPointer);
		}
		vkCmdWriteAccelerationStructuresPropertiesNVPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteAccelerationStructuresPropertiesNV");
		if (vkCmdWriteAccelerationStructuresPropertiesNVPointer != IntPtr.Zero)
		{
			vkCmdWriteAccelerationStructuresPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteAccelerationStructuresPropertiesNVDelegate_0>(vkCmdWriteAccelerationStructuresPropertiesNVPointer);
		}
		vkCompileDeferredNVPointer = vkGetInstanceProcAddr(instance, "vkCompileDeferredNV");
		if (vkCompileDeferredNVPointer != IntPtr.Zero)
		{
			vkCompileDeferredNV_0 = Marshal.GetDelegateForFunctionPointer<vkCompileDeferredNVDelegate_0>(vkCompileDeferredNVPointer);
		}
		vkGetDescriptorSetLayoutSupportKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDescriptorSetLayoutSupport");
		if (vkGetDescriptorSetLayoutSupportKHRPointer != IntPtr.Zero)
		{
			vkGetDescriptorSetLayoutSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDescriptorSetLayoutSupportKHRDelegate_0>(vkGetDescriptorSetLayoutSupportKHRPointer);
		}
		vkCmdDrawIndirectCountKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCountKHR");
		if (vkCmdDrawIndirectCountKHRPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountKHRDelegate_0>(vkCmdDrawIndirectCountKHRPointer);
		}
		vkCmdDrawIndexedIndirectCountKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCountKHR");
		if (vkCmdDrawIndexedIndirectCountKHRPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexedIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedIndirectCountKHRDelegate_0>(vkCmdDrawIndexedIndirectCountKHRPointer);
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
		vkGetPhysicalDeviceCalibrateableTimeDomainsEXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT");
		if (vkGetPhysicalDeviceCalibrateableTimeDomainsEXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0>(vkGetPhysicalDeviceCalibrateableTimeDomainsEXTPointer);
		}
		vkGetCalibratedTimestampsEXTPointer = vkGetInstanceProcAddr(instance, "vkGetCalibratedTimestampsEXT");
		if (vkGetCalibratedTimestampsEXTPointer != IntPtr.Zero)
		{
			vkGetCalibratedTimestampsEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetCalibratedTimestampsEXTDelegate_0>(vkGetCalibratedTimestampsEXTPointer);
		}
		vkCmdDrawMeshTasksNVPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawMeshTasksNV");
		if (vkCmdDrawMeshTasksNVPointer != IntPtr.Zero)
		{
			vkCmdDrawMeshTasksNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawMeshTasksNVDelegate_0>(vkCmdDrawMeshTasksNVPointer);
		}
		vkCmdDrawMeshTasksIndirectNVPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawMeshTasksIndirectNV");
		if (vkCmdDrawMeshTasksIndirectNVPointer != IntPtr.Zero)
		{
			vkCmdDrawMeshTasksIndirectNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawMeshTasksIndirectNVDelegate_0>(vkCmdDrawMeshTasksIndirectNVPointer);
		}
		vkCmdDrawMeshTasksIndirectCountNVPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawMeshTasksIndirectCountNV");
		if (vkCmdDrawMeshTasksIndirectCountNVPointer != IntPtr.Zero)
		{
			vkCmdDrawMeshTasksIndirectCountNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawMeshTasksIndirectCountNVDelegate_0>(vkCmdDrawMeshTasksIndirectCountNVPointer);
		}
		vkCmdSetExclusiveScissorNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetExclusiveScissorNV");
		if (vkCmdSetExclusiveScissorNVPointer != IntPtr.Zero)
		{
			vkCmdSetExclusiveScissorNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetExclusiveScissorNVDelegate_0>(vkCmdSetExclusiveScissorNVPointer);
		}
		vkCmdSetCheckpointNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetCheckpointNV");
		if (vkCmdSetCheckpointNVPointer != IntPtr.Zero)
		{
			vkCmdSetCheckpointNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetCheckpointNVDelegate_0>(vkCmdSetCheckpointNVPointer);
		}
		vkGetQueueCheckpointDataNVPointer = vkGetInstanceProcAddr(instance, "vkGetQueueCheckpointDataNV");
		if (vkGetQueueCheckpointDataNVPointer != IntPtr.Zero)
		{
			vkGetQueueCheckpointDataNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetQueueCheckpointDataNVDelegate_0>(vkGetQueueCheckpointDataNVPointer);
		}
		vkGetSemaphoreCounterValueKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSemaphoreCounterValueKHR");
		if (vkGetSemaphoreCounterValueKHRPointer != IntPtr.Zero)
		{
			vkGetSemaphoreCounterValueKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSemaphoreCounterValueKHRDelegate_0>(vkGetSemaphoreCounterValueKHRPointer);
		}
		vkWaitSemaphoresKHRPointer = vkGetInstanceProcAddr(instance, "vkWaitSemaphoresKHR");
		if (vkWaitSemaphoresKHRPointer != IntPtr.Zero)
		{
			vkWaitSemaphoresKHR_0 = Marshal.GetDelegateForFunctionPointer<vkWaitSemaphoresKHRDelegate_0>(vkWaitSemaphoresKHRPointer);
		}
		vkSignalSemaphoreKHRPointer = vkGetInstanceProcAddr(instance, "vkSignalSemaphoreKHR");
		if (vkSignalSemaphoreKHRPointer != IntPtr.Zero)
		{
			vkSignalSemaphoreKHR_0 = Marshal.GetDelegateForFunctionPointer<vkSignalSemaphoreKHRDelegate_0>(vkSignalSemaphoreKHRPointer);
		}
		vkInitializePerformanceApiINTELPointer = vkGetInstanceProcAddr(instance, "vkInitializePerformanceApiINTEL");
		if (vkInitializePerformanceApiINTELPointer != IntPtr.Zero)
		{
			vkInitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkInitializePerformanceApiINTELDelegate_0>(vkInitializePerformanceApiINTELPointer);
		}
		vkUninitializePerformanceApiINTELPointer = vkGetInstanceProcAddr(instance, "vkUninitializePerformanceApiINTEL");
		if (vkUninitializePerformanceApiINTELPointer != IntPtr.Zero)
		{
			vkUninitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkUninitializePerformanceApiINTELDelegate_0>(vkUninitializePerformanceApiINTELPointer);
		}
		vkCmdSetPerformanceMarkerINTELPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPerformanceMarkerINTEL");
		if (vkCmdSetPerformanceMarkerINTELPointer != IntPtr.Zero)
		{
			vkCmdSetPerformanceMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPerformanceMarkerINTELDelegate_0>(vkCmdSetPerformanceMarkerINTELPointer);
		}
		vkCmdSetPerformanceStreamMarkerINTELPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPerformanceStreamMarkerINTEL");
		if (vkCmdSetPerformanceStreamMarkerINTELPointer != IntPtr.Zero)
		{
			vkCmdSetPerformanceStreamMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPerformanceStreamMarkerINTELDelegate_0>(vkCmdSetPerformanceStreamMarkerINTELPointer);
		}
		vkCmdSetPerformanceOverrideINTELPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPerformanceOverrideINTEL");
		if (vkCmdSetPerformanceOverrideINTELPointer != IntPtr.Zero)
		{
			vkCmdSetPerformanceOverrideINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPerformanceOverrideINTELDelegate_0>(vkCmdSetPerformanceOverrideINTELPointer);
		}
		vkAcquirePerformanceConfigurationINTELPointer = vkGetInstanceProcAddr(instance, "vkAcquirePerformanceConfigurationINTEL");
		if (vkAcquirePerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			vkAcquirePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkAcquirePerformanceConfigurationINTELDelegate_0>(vkAcquirePerformanceConfigurationINTELPointer);
		}
		vkReleasePerformanceConfigurationINTELPointer = vkGetInstanceProcAddr(instance, "vkReleasePerformanceConfigurationINTEL");
		if (vkReleasePerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			vkReleasePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkReleasePerformanceConfigurationINTELDelegate_0>(vkReleasePerformanceConfigurationINTELPointer);
		}
		vkQueueSetPerformanceConfigurationINTELPointer = vkGetInstanceProcAddr(instance, "vkQueueSetPerformanceConfigurationINTEL");
		if (vkQueueSetPerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			vkQueueSetPerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkQueueSetPerformanceConfigurationINTELDelegate_0>(vkQueueSetPerformanceConfigurationINTELPointer);
		}
		vkGetPerformanceParameterINTELPointer = vkGetInstanceProcAddr(instance, "vkGetPerformanceParameterINTEL");
		if (vkGetPerformanceParameterINTELPointer != IntPtr.Zero)
		{
			vkGetPerformanceParameterINTEL_0 = Marshal.GetDelegateForFunctionPointer<vkGetPerformanceParameterINTELDelegate_0>(vkGetPerformanceParameterINTELPointer);
		}
		vkSetLocalDimmingAMDPointer = vkGetInstanceProcAddr(instance, "vkSetLocalDimmingAMD");
		if (vkSetLocalDimmingAMDPointer != IntPtr.Zero)
		{
			vkSetLocalDimmingAMD_0 = Marshal.GetDelegateForFunctionPointer<vkSetLocalDimmingAMDDelegate_0>(vkSetLocalDimmingAMDPointer);
		}
		vkGetBufferDeviceAddressEXTPointer = vkGetInstanceProcAddr(instance, "vkGetBufferDeviceAddressKHR");
		if (vkGetBufferDeviceAddressEXTPointer != IntPtr.Zero)
		{
			vkGetBufferDeviceAddressEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferDeviceAddressEXTDelegate_0>(vkGetBufferDeviceAddressEXTPointer);
		}
		vkGetPhysicalDeviceToolPropertiesEXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceToolPropertiesEXT");
		if (vkGetPhysicalDeviceToolPropertiesEXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceToolPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceToolPropertiesEXTDelegate_0>(vkGetPhysicalDeviceToolPropertiesEXTPointer);
		}
		vkGetPhysicalDeviceCooperativeMatrixPropertiesNVPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
		if (vkGetPhysicalDeviceCooperativeMatrixPropertiesNVPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0>(vkGetPhysicalDeviceCooperativeMatrixPropertiesNVPointer);
		}
		vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
		if (vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0>(vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer);
		}
		vkGetPhysicalDeviceSurfacePresentModes2EXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfacePresentModes2EXT");
		if (vkGetPhysicalDeviceSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate_0>(vkGetPhysicalDeviceSurfacePresentModes2EXTPointer);
		}
		vkAcquireFullScreenExclusiveModeEXTPointer = vkGetInstanceProcAddr(instance, "vkAcquireFullScreenExclusiveModeEXT");
		if (vkAcquireFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
		{
			vkAcquireFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireFullScreenExclusiveModeEXTDelegate_0>(vkAcquireFullScreenExclusiveModeEXTPointer);
		}
		vkReleaseFullScreenExclusiveModeEXTPointer = vkGetInstanceProcAddr(instance, "vkReleaseFullScreenExclusiveModeEXT");
		if (vkReleaseFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
		{
			vkReleaseFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<vkReleaseFullScreenExclusiveModeEXTDelegate_0>(vkReleaseFullScreenExclusiveModeEXTPointer);
		}
		vkGetDeviceGroupSurfacePresentModes2EXTPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupSurfacePresentModes2EXT");
		if (vkGetDeviceGroupSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0>(vkGetDeviceGroupSurfacePresentModes2EXTPointer);
		}
		vkGetDeviceGroupSurfacePresentModes2EXTPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceGroupSurfacePresentModes2EXT");
		if (vkGetDeviceGroupSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			vkGetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceGroupSurfacePresentModes2EXTDelegate_0>(vkGetDeviceGroupSurfacePresentModes2EXTPointer);
		}
		vkCreateHeadlessSurfaceEXTPointer = vkGetInstanceProcAddr(instance, "vkCreateHeadlessSurfaceEXT");
		if (vkCreateHeadlessSurfaceEXTPointer != IntPtr.Zero)
		{
			vkCreateHeadlessSurfaceEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCreateHeadlessSurfaceEXTDelegate_0>(vkCreateHeadlessSurfaceEXTPointer);
		}
		vkGetBufferDeviceAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferDeviceAddressKHR");
		if (vkGetBufferDeviceAddressKHRPointer != IntPtr.Zero)
		{
			vkGetBufferDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferDeviceAddressKHRDelegate_0>(vkGetBufferDeviceAddressKHRPointer);
		}
		vkGetBufferOpaqueCaptureAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferOpaqueCaptureAddressKHR");
		if (vkGetBufferOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			vkGetBufferOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferOpaqueCaptureAddressKHRDelegate_0>(vkGetBufferOpaqueCaptureAddressKHRPointer);
		}
		vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceMemoryOpaqueCaptureAddressKHR");
		if (vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceMemoryOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0>(vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer);
		}
		vkCmdSetLineStippleEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetLineStippleEXT");
		if (vkCmdSetLineStippleEXTPointer != IntPtr.Zero)
		{
			vkCmdSetLineStippleEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetLineStippleEXTDelegate_0>(vkCmdSetLineStippleEXTPointer);
		}
		vkResetQueryPoolEXTPointer = vkGetInstanceProcAddr(instance, "vkResetQueryPoolEXT");
		if (vkResetQueryPoolEXTPointer != IntPtr.Zero)
		{
			vkResetQueryPoolEXT_0 = Marshal.GetDelegateForFunctionPointer<vkResetQueryPoolEXTDelegate_0>(vkResetQueryPoolEXTPointer);
		}
		vkGetPipelineExecutablePropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPipelineExecutablePropertiesKHR");
		if (vkGetPipelineExecutablePropertiesKHRPointer != IntPtr.Zero)
		{
			vkGetPipelineExecutablePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPipelineExecutablePropertiesKHRDelegate_0>(vkGetPipelineExecutablePropertiesKHRPointer);
		}
		vkGetPipelineExecutableStatisticsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPipelineExecutableStatisticsKHR");
		if (vkGetPipelineExecutableStatisticsKHRPointer != IntPtr.Zero)
		{
			vkGetPipelineExecutableStatisticsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPipelineExecutableStatisticsKHRDelegate_0>(vkGetPipelineExecutableStatisticsKHRPointer);
		}
		vkGetPipelineExecutableInternalRepresentationsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPipelineExecutableInternalRepresentationsKHR");
		if (vkGetPipelineExecutableInternalRepresentationsKHRPointer != IntPtr.Zero)
		{
			vkGetPipelineExecutableInternalRepresentationsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPipelineExecutableInternalRepresentationsKHRDelegate_0>(vkGetPipelineExecutableInternalRepresentationsKHRPointer);
		}
	}
}
