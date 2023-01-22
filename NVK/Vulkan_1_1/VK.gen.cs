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
	public static VkResult CreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance) => CreateInstance_0(pCreateInfo, pAllocator, pInstance);
	private delegate VkResult CreateInstanceDelegate_0(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
	private static IntPtr CreateInstancePointer;
	private static CreateInstanceDelegate_0 CreateInstance_0;
	public static void DestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator) => DestroyInstance_0(instance, pAllocator);
	private delegate void DestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyInstancePointer;
	private static DestroyInstanceDelegate_0 DestroyInstance_0;
	public static VkResult EnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices) => EnumeratePhysicalDevices_0(instance, pPhysicalDeviceCount, pPhysicalDevices);
	private delegate VkResult EnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
	private static IntPtr EnumeratePhysicalDevicesPointer;
	private static EnumeratePhysicalDevicesDelegate_0 EnumeratePhysicalDevices_0;
	public static void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures) => GetPhysicalDeviceFeatures_0(physicalDevice, pFeatures);
	private delegate void GetPhysicalDeviceFeaturesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);
	private static IntPtr GetPhysicalDeviceFeaturesPointer;
	private static GetPhysicalDeviceFeaturesDelegate_0 GetPhysicalDeviceFeatures_0;
	public static void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties) => GetPhysicalDeviceFormatProperties_0(physicalDevice, format, pFormatProperties);
	private delegate void GetPhysicalDeviceFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);
	private static IntPtr GetPhysicalDeviceFormatPropertiesPointer;
	private static GetPhysicalDeviceFormatPropertiesDelegate_0 GetPhysicalDeviceFormatProperties_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties) => GetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
	private delegate VkResult GetPhysicalDeviceImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);
	private static IntPtr GetPhysicalDeviceImageFormatPropertiesPointer;
	private static GetPhysicalDeviceImageFormatPropertiesDelegate_0 GetPhysicalDeviceImageFormatProperties_0;
	public static void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties) => GetPhysicalDeviceProperties_0(physicalDevice, pProperties);
	private delegate void GetPhysicalDevicePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);
	private static IntPtr GetPhysicalDevicePropertiesPointer;
	private static GetPhysicalDevicePropertiesDelegate_0 GetPhysicalDeviceProperties_0;
	public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
	private static IntPtr GetPhysicalDeviceQueueFamilyPropertiesPointer;
	private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_0 GetPhysicalDeviceQueueFamilyProperties_0;
	public static void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties) => GetPhysicalDeviceMemoryProperties_0(physicalDevice, pMemoryProperties);
	private delegate void GetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
	private static IntPtr GetPhysicalDeviceMemoryPropertiesPointer;
	private static GetPhysicalDeviceMemoryPropertiesDelegate_0 GetPhysicalDeviceMemoryProperties_0;
	public static PFN_vkVoidFunction GetInstanceProcedureAddress(VkInstance instance, byte* pName) => GetInstanceProcedureAddress_0(instance, pName);
	private delegate PFN_vkVoidFunction GetInstanceProcedureAddressDelegate_0(VkInstance instance, byte* pName);
	private static IntPtr GetInstanceProcedureAddressPointer;
	private static GetInstanceProcedureAddressDelegate_0 GetInstanceProcedureAddress_0;
	public static PFN_vkVoidFunction GetDeviceProcedureAddress(VkDevice device, byte* pName) => GetDeviceProcedureAddress_0(device, pName);
	private delegate PFN_vkVoidFunction GetDeviceProcedureAddressDelegate_0(VkDevice device, byte* pName);
	private static IntPtr GetDeviceProcedureAddressPointer;
	private static GetDeviceProcedureAddressDelegate_0 GetDeviceProcedureAddress_0;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice) => CreateDevice_0(physicalDevice, pCreateInfo, pAllocator, pDevice);
	private delegate VkResult CreateDeviceDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice);
	private static IntPtr CreateDevicePointer;
	private static CreateDeviceDelegate_0 CreateDevice_0;
	public static void DestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator) => DestroyDevice_0(device, pAllocator);
	private delegate void DestroyDeviceDelegate_0(VkDevice device, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDevicePointer;
	private static DestroyDeviceDelegate_0 DestroyDevice_0;
	public static VkResult EnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties) => EnumerateInstanceExtensionProperties_0(pLayerName, pPropertyCount, pProperties);
	private delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_0(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr EnumerateInstanceExtensionPropertiesPointer;
	private static EnumerateInstanceExtensionPropertiesDelegate_0 EnumerateInstanceExtensionProperties_0;
	public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties) => EnumerateDeviceExtensionProperties_0(physicalDevice, pLayerName, pPropertyCount, pProperties);
	private delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
	private static IntPtr EnumerateDeviceExtensionPropertiesPointer;
	private static EnumerateDeviceExtensionPropertiesDelegate_0 EnumerateDeviceExtensionProperties_0;
	public static VkResult EnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties) => EnumerateInstanceLayerProperties_0(pPropertyCount, pProperties);
	private delegate VkResult EnumerateInstanceLayerPropertiesDelegate_0(uint* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr EnumerateInstanceLayerPropertiesPointer;
	private static EnumerateInstanceLayerPropertiesDelegate_0 EnumerateInstanceLayerProperties_0;
	public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties) => EnumerateDeviceLayerProperties_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult EnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties);
	private static IntPtr EnumerateDeviceLayerPropertiesPointer;
	private static EnumerateDeviceLayerPropertiesDelegate_0 EnumerateDeviceLayerProperties_0;
	public static void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue) => GetDeviceQueue_0(device, queueFamilyIndex, queueIndex, pQueue);
	private delegate void GetDeviceQueueDelegate_0(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue);
	private static IntPtr GetDeviceQueuePointer;
	private static GetDeviceQueueDelegate_0 GetDeviceQueue_0;
	public static VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence) => QueueSubmit_0(queue, submitCount, pSubmits, fence);
	private delegate VkResult QueueSubmitDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence);
	private static IntPtr QueueSubmitPointer;
	private static QueueSubmitDelegate_0 QueueSubmit_0;
	public static VkResult QueueWaitIdle(VkQueue queue) => QueueWaitIdle_0(queue);
	private delegate VkResult QueueWaitIdleDelegate_0(VkQueue queue);
	private static IntPtr QueueWaitIdlePointer;
	private static QueueWaitIdleDelegate_0 QueueWaitIdle_0;
	public static VkResult DeviceWaitIdle(VkDevice device) => DeviceWaitIdle_0(device);
	private delegate VkResult DeviceWaitIdleDelegate_0(VkDevice device);
	private static IntPtr DeviceWaitIdlePointer;
	private static DeviceWaitIdleDelegate_0 DeviceWaitIdle_0;
	public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory) => AllocateMemory_0(device, pAllocateInfo, pAllocator, pMemory);
	private delegate VkResult AllocateMemoryDelegate_0(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);
	private static IntPtr AllocateMemoryPointer;
	private static AllocateMemoryDelegate_0 AllocateMemory_0;
	public static void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator) => FreeMemory_0(device, memory, pAllocator);
	private delegate void FreeMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator);
	private static IntPtr FreeMemoryPointer;
	private static FreeMemoryDelegate_0 FreeMemory_0;
	public static VkResult MapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** ppData) => MapMemory_0(device, memory, offset, size, flags, ppData);
	private delegate VkResult MapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** ppData);
	private static IntPtr MapMemoryPointer;
	private static MapMemoryDelegate_0 MapMemory_0;
	public static void UnmapMemory(VkDevice device, VkDeviceMemory memory) => UnmapMemory_0(device, memory);
	private delegate void UnmapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory);
	private static IntPtr UnmapMemoryPointer;
	private static UnmapMemoryDelegate_0 UnmapMemory_0;
	public static VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => FlushMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult FlushMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
	private static IntPtr FlushMappedMemoryRangesPointer;
	private static FlushMappedMemoryRangesDelegate_0 FlushMappedMemoryRanges_0;
	public static VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges) => InvalidateMappedMemoryRanges_0(device, memoryRangeCount, pMemoryRanges);
	private delegate VkResult InvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
	private static IntPtr InvalidateMappedMemoryRangesPointer;
	private static InvalidateMappedMemoryRangesDelegate_0 InvalidateMappedMemoryRanges_0;
	public static void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes) => GetDeviceMemoryCommitment_0(device, memory, pCommittedMemoryInBytes);
	private delegate void GetDeviceMemoryCommitmentDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes);
	private static IntPtr GetDeviceMemoryCommitmentPointer;
	private static GetDeviceMemoryCommitmentDelegate_0 GetDeviceMemoryCommitment_0;
	public static VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindBufferMemory_0(device, buffer, memory, memoryOffset);
	private delegate VkResult BindBufferMemoryDelegate_0(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static IntPtr BindBufferMemoryPointer;
	private static BindBufferMemoryDelegate_0 BindBufferMemory_0;
	public static VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindImageMemory_0(device, image, memory, memoryOffset);
	private delegate VkResult BindImageMemoryDelegate_0(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static IntPtr BindImageMemoryPointer;
	private static BindImageMemoryDelegate_0 BindImageMemory_0;
	public static void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements) => GetBufferMemoryRequirements_0(device, buffer, pMemoryRequirements);
	private delegate void GetBufferMemoryRequirementsDelegate_0(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);
	private static IntPtr GetBufferMemoryRequirementsPointer;
	private static GetBufferMemoryRequirementsDelegate_0 GetBufferMemoryRequirements_0;
	public static void GetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements) => GetImageMemoryRequirements_0(device, image, pMemoryRequirements);
	private delegate void GetImageMemoryRequirementsDelegate_0(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);
	private static IntPtr GetImageMemoryRequirementsPointer;
	private static GetImageMemoryRequirementsDelegate_0 GetImageMemoryRequirements_0;
	public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements) => GetImageSparseMemoryRequirements_0(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
	private static IntPtr GetImageSparseMemoryRequirementsPointer;
	private static GetImageSparseMemoryRequirementsDelegate_0 GetImageSparseMemoryRequirements_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties) => GetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
	private delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties);
	private static IntPtr GetPhysicalDeviceSparseImageFormatPropertiesPointer;
	private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 GetPhysicalDeviceSparseImageFormatProperties_0;
	public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence) => QueueBindSparse_0(queue, bindInfoCount, pBindInfo, fence);
	private delegate VkResult QueueBindSparseDelegate_0(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
	private static IntPtr QueueBindSparsePointer;
	private static QueueBindSparseDelegate_0 QueueBindSparse_0;
	public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => CreateFence_0(device, pCreateInfo, pAllocator, pFence);
	private delegate VkResult CreateFenceDelegate_0(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr CreateFencePointer;
	private static CreateFenceDelegate_0 CreateFence_0;
	public static void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator) => DestroyFence_0(device, fence, pAllocator);
	private delegate void DestroyFenceDelegate_0(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyFencePointer;
	private static DestroyFenceDelegate_0 DestroyFence_0;
	public static VkResult ResetFences(VkDevice device, uint fenceCount, VkFence* pFences) => ResetFences_0(device, fenceCount, pFences);
	private delegate VkResult ResetFencesDelegate_0(VkDevice device, uint fenceCount, VkFence* pFences);
	private static IntPtr ResetFencesPointer;
	private static ResetFencesDelegate_0 ResetFences_0;
	public static VkResult GetFenceStatus(VkDevice device, VkFence fence) => GetFenceStatus_0(device, fence);
	private delegate VkResult GetFenceStatusDelegate_0(VkDevice device, VkFence fence);
	private static IntPtr GetFenceStatusPointer;
	private static GetFenceStatusDelegate_0 GetFenceStatus_0;
	public static VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout) => WaitForFences_0(device, fenceCount, pFences, waitAll, timeout);
	private delegate VkResult WaitForFencesDelegate_0(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout);
	private static IntPtr WaitForFencesPointer;
	private static WaitForFencesDelegate_0 WaitForFences_0;
	public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore) => CreateSemaphore_0(device, pCreateInfo, pAllocator, pSemaphore);
	private delegate VkResult CreateSemaphoreDelegate_0(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);
	private static IntPtr CreateSemaphorePointer;
	private static CreateSemaphoreDelegate_0 CreateSemaphore_0;
	public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator) => DestroySemaphore_0(device, semaphore, pAllocator);
	private delegate void DestroySemaphoreDelegate_0(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySemaphorePointer;
	private static DestroySemaphoreDelegate_0 DestroySemaphore_0;
	public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent) => CreateEvent_0(device, pCreateInfo, pAllocator, pEvent);
	private delegate VkResult CreateEventDelegate_0(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent);
	private static IntPtr CreateEventPointer;
	private static CreateEventDelegate_0 CreateEvent_0;
	public static void DestroyEvent(VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator) => DestroyEvent_0(device, event, pAllocator);
	private delegate void DestroyEventDelegate_0(VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyEventPointer;
	private static DestroyEventDelegate_0 DestroyEvent_0;
	public static VkResult GetEventStatus(VkDevice device, VkEvent event) => GetEventStatus_0(device, event);
	private delegate VkResult GetEventStatusDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr GetEventStatusPointer;
	private static GetEventStatusDelegate_0 GetEventStatus_0;
	public static VkResult SetEvent(VkDevice device, VkEvent event) => SetEvent_0(device, event);
	private delegate VkResult SetEventDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr SetEventPointer;
	private static SetEventDelegate_0 SetEvent_0;
	public static VkResult ResetEvent(VkDevice device, VkEvent event) => ResetEvent_0(device, event);
	private delegate VkResult ResetEventDelegate_0(VkDevice device, VkEvent event);
	private static IntPtr ResetEventPointer;
	private static ResetEventDelegate_0 ResetEvent_0;
	public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool) => CreateQueryPool_0(device, pCreateInfo, pAllocator, pQueryPool);
	private delegate VkResult CreateQueryPoolDelegate_0(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);
	private static IntPtr CreateQueryPoolPointer;
	private static CreateQueryPoolDelegate_0 CreateQueryPool_0;
	public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator) => DestroyQueryPool_0(device, queryPool, pAllocator);
	private delegate void DestroyQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyQueryPoolPointer;
	private static DestroyQueryPoolDelegate_0 DestroyQueryPool_0;
	public static VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags) => GetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
	private delegate VkResult GetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags);
	private static IntPtr GetQueryPoolResultsPointer;
	private static GetQueryPoolResultsDelegate_0 GetQueryPoolResults_0;
	public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer) => CreateBuffer_0(device, pCreateInfo, pAllocator, pBuffer);
	private delegate VkResult CreateBufferDelegate_0(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);
	private static IntPtr CreateBufferPointer;
	private static CreateBufferDelegate_0 CreateBuffer_0;
	public static void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator) => DestroyBuffer_0(device, buffer, pAllocator);
	private delegate void DestroyBufferDelegate_0(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyBufferPointer;
	private static DestroyBufferDelegate_0 DestroyBuffer_0;
	public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView) => CreateBufferView_0(device, pCreateInfo, pAllocator, pView);
	private delegate VkResult CreateBufferViewDelegate_0(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView);
	private static IntPtr CreateBufferViewPointer;
	private static CreateBufferViewDelegate_0 CreateBufferView_0;
	public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator) => DestroyBufferView_0(device, bufferView, pAllocator);
	private delegate void DestroyBufferViewDelegate_0(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyBufferViewPointer;
	private static DestroyBufferViewDelegate_0 DestroyBufferView_0;
	public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage) => CreateImage_0(device, pCreateInfo, pAllocator, pImage);
	private delegate VkResult CreateImageDelegate_0(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage);
	private static IntPtr CreateImagePointer;
	private static CreateImageDelegate_0 CreateImage_0;
	public static void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator) => DestroyImage_0(device, image, pAllocator);
	private delegate void DestroyImageDelegate_0(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyImagePointer;
	private static DestroyImageDelegate_0 DestroyImage_0;
	public static void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout) => GetImageSubresourceLayout_0(device, image, pSubresource, pLayout);
	private delegate void GetImageSubresourceLayoutDelegate_0(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);
	private static IntPtr GetImageSubresourceLayoutPointer;
	private static GetImageSubresourceLayoutDelegate_0 GetImageSubresourceLayout_0;
	public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView) => CreateImageView_0(device, pCreateInfo, pAllocator, pView);
	private delegate VkResult CreateImageViewDelegate_0(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView);
	private static IntPtr CreateImageViewPointer;
	private static CreateImageViewDelegate_0 CreateImageView_0;
	public static void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator) => DestroyImageView_0(device, imageView, pAllocator);
	private delegate void DestroyImageViewDelegate_0(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyImageViewPointer;
	private static DestroyImageViewDelegate_0 DestroyImageView_0;
	public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule) => CreateShaderModule_0(device, pCreateInfo, pAllocator, pShaderModule);
	private delegate VkResult CreateShaderModuleDelegate_0(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);
	private static IntPtr CreateShaderModulePointer;
	private static CreateShaderModuleDelegate_0 CreateShaderModule_0;
	public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator) => DestroyShaderModule_0(device, shaderModule, pAllocator);
	private delegate void DestroyShaderModuleDelegate_0(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyShaderModulePointer;
	private static DestroyShaderModuleDelegate_0 DestroyShaderModule_0;
	public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache) => CreatePipelineCache_0(device, pCreateInfo, pAllocator, pPipelineCache);
	private delegate VkResult CreatePipelineCacheDelegate_0(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);
	private static IntPtr CreatePipelineCachePointer;
	private static CreatePipelineCacheDelegate_0 CreatePipelineCache_0;
	public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator) => DestroyPipelineCache_0(device, pipelineCache, pAllocator);
	private delegate void DestroyPipelineCacheDelegate_0(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyPipelineCachePointer;
	private static DestroyPipelineCacheDelegate_0 DestroyPipelineCache_0;
	public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData) => GetPipelineCacheData_0(device, pipelineCache, pDataSize, pData);
	private delegate VkResult GetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData);
	private static IntPtr GetPipelineCacheDataPointer;
	private static GetPipelineCacheDataDelegate_0 GetPipelineCacheData_0;
	public static VkResult MergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches) => MergePipelineCaches_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult MergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches);
	private static IntPtr MergePipelineCachesPointer;
	private static MergePipelineCachesDelegate_0 MergePipelineCaches_0;
	public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => CreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult CreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr CreateGraphicsPipelinesPointer;
	private static CreateGraphicsPipelinesDelegate_0 CreateGraphicsPipelines_0;
	public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => CreateComputePipelines_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult CreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr CreateComputePipelinesPointer;
	private static CreateComputePipelinesDelegate_0 CreateComputePipelines_0;
	public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator) => DestroyPipeline_0(device, pipeline, pAllocator);
	private delegate void DestroyPipelineDelegate_0(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyPipelinePointer;
	private static DestroyPipelineDelegate_0 DestroyPipeline_0;
	public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout) => CreatePipelineLayout_0(device, pCreateInfo, pAllocator, pPipelineLayout);
	private delegate VkResult CreatePipelineLayoutDelegate_0(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);
	private static IntPtr CreatePipelineLayoutPointer;
	private static CreatePipelineLayoutDelegate_0 CreatePipelineLayout_0;
	public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator) => DestroyPipelineLayout_0(device, pipelineLayout, pAllocator);
	private delegate void DestroyPipelineLayoutDelegate_0(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyPipelineLayoutPointer;
	private static DestroyPipelineLayoutDelegate_0 DestroyPipelineLayout_0;
	public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler) => CreateSampler_0(device, pCreateInfo, pAllocator, pSampler);
	private delegate VkResult CreateSamplerDelegate_0(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler);
	private static IntPtr CreateSamplerPointer;
	private static CreateSamplerDelegate_0 CreateSampler_0;
	public static void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator) => DestroySampler_0(device, sampler, pAllocator);
	private delegate void DestroySamplerDelegate_0(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySamplerPointer;
	private static DestroySamplerDelegate_0 DestroySampler_0;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout) => CreateDescriptorSetLayout_0(device, pCreateInfo, pAllocator, pSetLayout);
	private delegate VkResult CreateDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);
	private static IntPtr CreateDescriptorSetLayoutPointer;
	private static CreateDescriptorSetLayoutDelegate_0 CreateDescriptorSetLayout_0;
	public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator) => DestroyDescriptorSetLayout_0(device, descriptorSetLayout, pAllocator);
	private delegate void DestroyDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDescriptorSetLayoutPointer;
	private static DestroyDescriptorSetLayoutDelegate_0 DestroyDescriptorSetLayout_0;
	public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool) => CreateDescriptorPool_0(device, pCreateInfo, pAllocator, pDescriptorPool);
	private delegate VkResult CreateDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);
	private static IntPtr CreateDescriptorPoolPointer;
	private static CreateDescriptorPoolDelegate_0 CreateDescriptorPool_0;
	public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator) => DestroyDescriptorPool_0(device, descriptorPool, pAllocator);
	private delegate void DestroyDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDescriptorPoolPointer;
	private static DestroyDescriptorPoolDelegate_0 DestroyDescriptorPool_0;
	public static VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags) => ResetDescriptorPool_0(device, descriptorPool, flags);
	private delegate VkResult ResetDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
	private static IntPtr ResetDescriptorPoolPointer;
	private static ResetDescriptorPoolDelegate_0 ResetDescriptorPool_0;
	public static VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets) => AllocateDescriptorSets_0(device, pAllocateInfo, pDescriptorSets);
	private delegate VkResult AllocateDescriptorSetsDelegate_0(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);
	private static IntPtr AllocateDescriptorSetsPointer;
	private static AllocateDescriptorSetsDelegate_0 AllocateDescriptorSets_0;
	public static VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets) => FreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, pDescriptorSets);
	private delegate VkResult FreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets);
	private static IntPtr FreeDescriptorSetsPointer;
	private static FreeDescriptorSetsDelegate_0 FreeDescriptorSets_0;
	public static void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies) => UpdateDescriptorSets_0(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
	private delegate void UpdateDescriptorSetsDelegate_0(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
	private static IntPtr UpdateDescriptorSetsPointer;
	private static UpdateDescriptorSetsDelegate_0 UpdateDescriptorSets_0;
	public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer) => CreateFramebuffer_0(device, pCreateInfo, pAllocator, pFramebuffer);
	private delegate VkResult CreateFramebufferDelegate_0(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);
	private static IntPtr CreateFramebufferPointer;
	private static CreateFramebufferDelegate_0 CreateFramebuffer_0;
	public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator) => DestroyFramebuffer_0(device, framebuffer, pAllocator);
	private delegate void DestroyFramebufferDelegate_0(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyFramebufferPointer;
	private static DestroyFramebufferDelegate_0 DestroyFramebuffer_0;
	public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => CreateRenderPass_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate VkResult CreateRenderPassDelegate_0(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr CreateRenderPassPointer;
	private static CreateRenderPassDelegate_0 CreateRenderPass_0;
	public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator) => DestroyRenderPass_0(device, renderPass, pAllocator);
	private delegate void DestroyRenderPassDelegate_0(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyRenderPassPointer;
	private static DestroyRenderPassDelegate_0 DestroyRenderPass_0;
	public static void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity) => GetRenderAreaGranularity_0(device, renderPass, pGranularity);
	private delegate void GetRenderAreaGranularityDelegate_0(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);
	private static IntPtr GetRenderAreaGranularityPointer;
	private static GetRenderAreaGranularityDelegate_0 GetRenderAreaGranularity_0;
	public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool) => CreateCommandPool_0(device, pCreateInfo, pAllocator, pCommandPool);
	private delegate VkResult CreateCommandPoolDelegate_0(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);
	private static IntPtr CreateCommandPoolPointer;
	private static CreateCommandPoolDelegate_0 CreateCommandPool_0;
	public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator) => DestroyCommandPool_0(device, commandPool, pAllocator);
	private delegate void DestroyCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyCommandPoolPointer;
	private static DestroyCommandPoolDelegate_0 DestroyCommandPool_0;
	public static VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags) => ResetCommandPool_0(device, commandPool, flags);
	private delegate VkResult ResetCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
	private static IntPtr ResetCommandPoolPointer;
	private static ResetCommandPoolDelegate_0 ResetCommandPool_0;
	public static VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers) => AllocateCommandBuffers_0(device, pAllocateInfo, pCommandBuffers);
	private delegate VkResult AllocateCommandBuffersDelegate_0(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);
	private static IntPtr AllocateCommandBuffersPointer;
	private static AllocateCommandBuffersDelegate_0 AllocateCommandBuffers_0;
	public static void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers) => FreeCommandBuffers_0(device, commandPool, commandBufferCount, pCommandBuffers);
	private delegate void FreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
	private static IntPtr FreeCommandBuffersPointer;
	private static FreeCommandBuffersDelegate_0 FreeCommandBuffers_0;
	public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo) => BeginCommandBuffer_0(commandBuffer, pBeginInfo);
	private delegate VkResult BeginCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo);
	private static IntPtr BeginCommandBufferPointer;
	private static BeginCommandBufferDelegate_0 BeginCommandBuffer_0;
	public static VkResult EndCommandBuffer(VkCommandBuffer commandBuffer) => EndCommandBuffer_0(commandBuffer);
	private delegate VkResult EndCommandBufferDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr EndCommandBufferPointer;
	private static EndCommandBufferDelegate_0 EndCommandBuffer_0;
	public static VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags) => ResetCommandBuffer_0(commandBuffer, flags);
	private delegate VkResult ResetCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
	private static IntPtr ResetCommandBufferPointer;
	private static ResetCommandBufferDelegate_0 ResetCommandBuffer_0;
	public static void CommandBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline) => CommandBindPipeline_0(commandBuffer, pipelineBindPoint, pipeline);
	private delegate void CommandBindPipelineDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
	private static IntPtr CommandBindPipelinePointer;
	private static CommandBindPipelineDelegate_0 CommandBindPipeline_0;
	public static void CommandSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports) => CommandSetViewport_0(commandBuffer, firstViewport, viewportCount, pViewports);
	private delegate void CommandSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports);
	private static IntPtr CommandSetViewportPointer;
	private static CommandSetViewportDelegate_0 CommandSetViewport_0;
	public static void CommandSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors) => CommandSetScissor_0(commandBuffer, firstScissor, scissorCount, pScissors);
	private delegate void CommandSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors);
	private static IntPtr CommandSetScissorPointer;
	private static CommandSetScissorDelegate_0 CommandSetScissor_0;
	public static void CommandSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth) => CommandSetLineWidth_0(commandBuffer, lineWidth);
	private delegate void CommandSetLineWidthDelegate_0(VkCommandBuffer commandBuffer, float lineWidth);
	private static IntPtr CommandSetLineWidthPointer;
	private static CommandSetLineWidthDelegate_0 CommandSetLineWidth_0;
	public static void CommandSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) => CommandSetDepthBias_0(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
	private delegate void CommandSetDepthBiasDelegate_0(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
	private static IntPtr CommandSetDepthBiasPointer;
	private static CommandSetDepthBiasDelegate_0 CommandSetDepthBias_0;
	public static void CommandSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants) => CommandSetBlendConstants_0(commandBuffer, blendConstants);
	private delegate void CommandSetBlendConstantsDelegate_0(VkCommandBuffer commandBuffer, float blendConstants);
	private static IntPtr CommandSetBlendConstantsPointer;
	private static CommandSetBlendConstantsDelegate_0 CommandSetBlendConstants_0;
	public static void CommandSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds) => CommandSetDepthBounds_0(commandBuffer, minDepthBounds, maxDepthBounds);
	private delegate void CommandSetDepthBoundsDelegate_0(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
	private static IntPtr CommandSetDepthBoundsPointer;
	private static CommandSetDepthBoundsDelegate_0 CommandSetDepthBounds_0;
	public static void CommandSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask) => CommandSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
	private delegate void CommandSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
	private static IntPtr CommandSetStencilCompareMaskPointer;
	private static CommandSetStencilCompareMaskDelegate_0 CommandSetStencilCompareMask_0;
	public static void CommandSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask) => CommandSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
	private delegate void CommandSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
	private static IntPtr CommandSetStencilWriteMaskPointer;
	private static CommandSetStencilWriteMaskDelegate_0 CommandSetStencilWriteMask_0;
	public static void CommandSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference) => CommandSetStencilReference_0(commandBuffer, faceMask, reference);
	private delegate void CommandSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
	private static IntPtr CommandSetStencilReferencePointer;
	private static CommandSetStencilReferenceDelegate_0 CommandSetStencilReference_0;
	public static void CommandBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets) => CommandBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
	private delegate void CommandBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
	private static IntPtr CommandBindDescriptorSetsPointer;
	private static CommandBindDescriptorSetsDelegate_0 CommandBindDescriptorSets_0;
	public static void CommandBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => CommandBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
	private delegate void CommandBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
	private static IntPtr CommandBindIndexBufferPointer;
	private static CommandBindIndexBufferDelegate_0 CommandBindIndexBuffer_0;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets) => CommandBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
	private delegate void CommandBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets);
	private static IntPtr CommandBindVertexBuffersPointer;
	private static CommandBindVertexBuffersDelegate_0 CommandBindVertexBuffers_0;
	public static void CommandDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) => CommandDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
	private delegate void CommandDrawDelegate_0(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
	private static IntPtr CommandDrawPointer;
	private static CommandDrawDelegate_0 CommandDraw_0;
	public static void CommandDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) => CommandDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
	private delegate void CommandDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
	private static IntPtr CommandDrawIndexedPointer;
	private static CommandDrawIndexedDelegate_0 CommandDrawIndexed_0;
	public static void CommandDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static IntPtr CommandDrawIndirectPointer;
	private static CommandDrawIndirectDelegate_0 CommandDrawIndirect_0;
	public static void CommandDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static IntPtr CommandDrawIndexedIndirectPointer;
	private static CommandDrawIndexedIndirectDelegate_0 CommandDrawIndexedIndirect_0;
	public static void CommandDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchDelegate_0(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static IntPtr CommandDispatchPointer;
	private static CommandDispatchDelegate_0 CommandDispatch_0;
	public static void CommandDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => CommandDispatchIndirect_0(commandBuffer, buffer, offset);
	private delegate void CommandDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
	private static IntPtr CommandDispatchIndirectPointer;
	private static CommandDispatchIndirectDelegate_0 CommandDispatchIndirect_0;
	public static void CommandCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions) => CommandCopyBuffer_0(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
	private delegate void CommandCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions);
	private static IntPtr CommandCopyBufferPointer;
	private static CommandCopyBufferDelegate_0 CommandCopyBuffer_0;
	public static void CommandCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions) => CommandCopyImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void CommandCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions);
	private static IntPtr CommandCopyImagePointer;
	private static CommandCopyImageDelegate_0 CommandCopyImage_0;
	public static void CommandBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter) => CommandBlitImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
	private delegate void CommandBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter);
	private static IntPtr CommandBlitImagePointer;
	private static CommandBlitImageDelegate_0 CommandBlitImage_0;
	public static void CommandCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions) => CommandCopyBufferToImage_0(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void CommandCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr CommandCopyBufferToImagePointer;
	private static CommandCopyBufferToImageDelegate_0 CommandCopyBufferToImage_0;
	public static void CommandCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions) => CommandCopyImageToBuffer_0(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
	private delegate void CommandCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions);
	private static IntPtr CommandCopyImageToBufferPointer;
	private static CommandCopyImageToBufferDelegate_0 CommandCopyImageToBuffer_0;
	public static void CommandUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData) => CommandUpdateBuffer_0(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
	private delegate void CommandUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData);
	private static IntPtr CommandUpdateBufferPointer;
	private static CommandUpdateBufferDelegate_0 CommandUpdateBuffer_0;
	public static void CommandFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint data) => CommandFillBuffer_0(commandBuffer, dstBuffer, dstOffset, size, data);
	private delegate void CommandFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint data);
	private static IntPtr CommandFillBufferPointer;
	private static CommandFillBufferDelegate_0 CommandFillBuffer_0;
	public static void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges) => CommandClearColorImage_0(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
	private delegate void CommandClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr CommandClearColorImagePointer;
	private static CommandClearColorImageDelegate_0 CommandClearColorImage_0;
	public static void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges) => CommandClearDepthStencilImage_0(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
	private delegate void CommandClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges);
	private static IntPtr CommandClearDepthStencilImagePointer;
	private static CommandClearDepthStencilImageDelegate_0 CommandClearDepthStencilImage_0;
	public static void CommandClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects) => CommandClearAttachments_0(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
	private delegate void CommandClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects);
	private static IntPtr CommandClearAttachmentsPointer;
	private static CommandClearAttachmentsDelegate_0 CommandClearAttachments_0;
	public static void CommandResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions) => CommandResolveImage_0(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
	private delegate void CommandResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions);
	private static IntPtr CommandResolveImagePointer;
	private static CommandResolveImageDelegate_0 CommandResolveImage_0;
	public static void CommandSetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask) => CommandSetEvent_0(commandBuffer, event, stageMask);
	private delegate void CommandSetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
	private static IntPtr CommandSetEventPointer;
	private static CommandSetEventDelegate_0 CommandSetEvent_0;
	public static void CommandResetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask) => CommandResetEvent_0(commandBuffer, event, stageMask);
	private delegate void CommandResetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
	private static IntPtr CommandResetEventPointer;
	private static CommandResetEventDelegate_0 CommandResetEvent_0;
	public static void CommandWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => CommandWaitEvents_0(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void CommandWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr CommandWaitEventsPointer;
	private static CommandWaitEventsDelegate_0 CommandWaitEvents_0;
	public static void CommandPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers) => CommandPipelineBarrier_0(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
	private delegate void CommandPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
	private static IntPtr CommandPipelineBarrierPointer;
	private static CommandPipelineBarrierDelegate_0 CommandPipelineBarrier_0;
	public static void CommandBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags) => CommandBeginQuery_0(commandBuffer, queryPool, query, flags);
	private delegate void CommandBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
	private static IntPtr CommandBeginQueryPointer;
	private static CommandBeginQueryDelegate_0 CommandBeginQuery_0;
	public static void CommandEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query) => CommandEndQuery_0(commandBuffer, queryPool, query);
	private delegate void CommandEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
	private static IntPtr CommandEndQueryPointer;
	private static CommandEndQueryDelegate_0 CommandEndQuery_0;
	public static void CommandResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount) => CommandResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
	private delegate void CommandResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static IntPtr CommandResetQueryPoolPointer;
	private static CommandResetQueryPoolDelegate_0 CommandResetQueryPool_0;
	public static void CommandWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
	private delegate void CommandWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query);
	private static IntPtr CommandWriteTimestampPointer;
	private static CommandWriteTimestampDelegate_0 CommandWriteTimestamp_0;
	public static void CommandCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags) => CommandCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
	private delegate void CommandCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags);
	private static IntPtr CommandCopyQueryPoolResultsPointer;
	private static CommandCopyQueryPoolResultsDelegate_0 CommandCopyQueryPoolResults_0;
	public static void CommandPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues) => CommandPushConstants_0(commandBuffer, layout, stageFlags, offset, size, pValues);
	private delegate void CommandPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
	private static IntPtr CommandPushConstantsPointer;
	private static CommandPushConstantsDelegate_0 CommandPushConstants_0;
	public static void CommandBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_0(commandBuffer, pRenderPassBegin, contents);
	private delegate void CommandBeginRenderPassDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);
	private static IntPtr CommandBeginRenderPassPointer;
	private static CommandBeginRenderPassDelegate_0 CommandBeginRenderPass_0;
	public static void CommandNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents) => CommandNextSubpass_0(commandBuffer, contents);
	private delegate void CommandNextSubpassDelegate_0(VkCommandBuffer commandBuffer, VkSubpassContents contents);
	private static IntPtr CommandNextSubpassPointer;
	private static CommandNextSubpassDelegate_0 CommandNextSubpass_0;
	public static void CommandEndRenderPass(VkCommandBuffer commandBuffer) => CommandEndRenderPass_0(commandBuffer);
	private delegate void CommandEndRenderPassDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr CommandEndRenderPassPointer;
	private static CommandEndRenderPassDelegate_0 CommandEndRenderPass_0;
	public static void CommandExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers) => CommandExecuteCommands_0(commandBuffer, commandBufferCount, pCommandBuffers);
	private delegate void CommandExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
	private static IntPtr CommandExecuteCommandsPointer;
	private static CommandExecuteCommandsDelegate_0 CommandExecuteCommands_0;
	public static VkResult EnumerateInstanceVersion(uint* pApiVersion) => EnumerateInstanceVersion_0(pApiVersion);
	private delegate VkResult EnumerateInstanceVersionDelegate_0(uint* pApiVersion);
	private static IntPtr EnumerateInstanceVersionPointer;
	private static EnumerateInstanceVersionDelegate_0 EnumerateInstanceVersion_0;
	public static VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos) => BindBufferMemory2_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult BindBufferMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
	private static IntPtr BindBufferMemory2Pointer;
	private static BindBufferMemory2Delegate_0 BindBufferMemory2_0;
	public static VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos) => BindImageMemory2_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult BindImageMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
	private static IntPtr BindImageMemory2Pointer;
	private static BindImageMemory2Delegate_0 BindImageMemory2_0;
	public static void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures) => GetDeviceGroupPeerMemoryFeatures_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
	private delegate void GetDeviceGroupPeerMemoryFeaturesDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
	private static IntPtr GetDeviceGroupPeerMemoryFeaturesPointer;
	private static GetDeviceGroupPeerMemoryFeaturesDelegate_0 GetDeviceGroupPeerMemoryFeatures_0;
	public static void CommandSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMask_0(commandBuffer, deviceMask);
	private delegate void CommandSetDeviceMaskDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static IntPtr CommandSetDeviceMaskPointer;
	private static CommandSetDeviceMaskDelegate_0 CommandSetDeviceMask_0;
	public static void CommandDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBase_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchBaseDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static IntPtr CommandDispatchBasePointer;
	private static CommandDispatchBaseDelegate_0 CommandDispatchBase_0;
	public static VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups_0(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
	private delegate VkResult EnumeratePhysicalDeviceGroupsDelegate_0(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
	private static IntPtr EnumeratePhysicalDeviceGroupsPointer;
	private static EnumeratePhysicalDeviceGroupsDelegate_0 EnumeratePhysicalDeviceGroups_0;
	public static void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => GetImageMemoryRequirements2_0(device, pInfo, pMemoryRequirements);
	private delegate void GetImageMemoryRequirements2Delegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr GetImageMemoryRequirements2Pointer;
	private static GetImageMemoryRequirements2Delegate_0 GetImageMemoryRequirements2_0;
	public static void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => GetBufferMemoryRequirements2_0(device, pInfo, pMemoryRequirements);
	private delegate void GetBufferMemoryRequirements2Delegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr GetBufferMemoryRequirements2Pointer;
	private static GetBufferMemoryRequirements2Delegate_0 GetBufferMemoryRequirements2_0;
	public static void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements) => GetImageSparseMemoryRequirements2_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2Delegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
	private static IntPtr GetImageSparseMemoryRequirements2Pointer;
	private static GetImageSparseMemoryRequirements2Delegate_0 GetImageSparseMemoryRequirements2_0;
	public static void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures) => GetPhysicalDeviceFeatures2_0(physicalDevice, pFeatures);
	private delegate void GetPhysicalDeviceFeatures2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
	private static IntPtr GetPhysicalDeviceFeatures2Pointer;
	private static GetPhysicalDeviceFeatures2Delegate_0 GetPhysicalDeviceFeatures2_0;
	public static void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties) => GetPhysicalDeviceProperties2_0(physicalDevice, pProperties);
	private delegate void GetPhysicalDeviceProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
	private static IntPtr GetPhysicalDeviceProperties2Pointer;
	private static GetPhysicalDeviceProperties2Delegate_0 GetPhysicalDeviceProperties2_0;
	public static void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties) => GetPhysicalDeviceFormatProperties2_0(physicalDevice, format, pFormatProperties);
	private delegate void GetPhysicalDeviceFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
	private static IntPtr GetPhysicalDeviceFormatProperties2Pointer;
	private static GetPhysicalDeviceFormatProperties2Delegate_0 GetPhysicalDeviceFormatProperties2_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) => GetPhysicalDeviceImageFormatProperties2_0(physicalDevice, pImageFormatInfo, pImageFormatProperties);
	private delegate VkResult GetPhysicalDeviceImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
	private static IntPtr GetPhysicalDeviceImageFormatProperties2Pointer;
	private static GetPhysicalDeviceImageFormatProperties2Delegate_0 GetPhysicalDeviceImageFormatProperties2_0;
	public static void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2Delegate_0(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
	private static IntPtr GetPhysicalDeviceQueueFamilyProperties2Pointer;
	private static GetPhysicalDeviceQueueFamilyProperties2Delegate_0 GetPhysicalDeviceQueueFamilyProperties2_0;
	public static void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties) => GetPhysicalDeviceMemoryProperties2_0(physicalDevice, pMemoryProperties);
	private delegate void GetPhysicalDeviceMemoryProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
	private static IntPtr GetPhysicalDeviceMemoryProperties2Pointer;
	private static GetPhysicalDeviceMemoryProperties2Delegate_0 GetPhysicalDeviceMemoryProperties2_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties) => GetPhysicalDeviceSparseImageFormatProperties2_0(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
	private static IntPtr GetPhysicalDeviceSparseImageFormatProperties2Pointer;
	private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_0 GetPhysicalDeviceSparseImageFormatProperties2_0;
	public static void TrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags) => TrimCommandPool_0(device, commandPool, flags);
	private delegate void TrimCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
	private static IntPtr TrimCommandPoolPointer;
	private static TrimCommandPoolDelegate_0 TrimCommandPool_0;
	public static void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue) => GetDeviceQueue2_0(device, pQueueInfo, pQueue);
	private delegate void GetDeviceQueue2Delegate_0(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue);
	private static IntPtr GetDeviceQueue2Pointer;
	private static GetDeviceQueue2Delegate_0 GetDeviceQueue2_0;
	public static VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion) => CreateSamplerYcbcrConversion_0(device, pCreateInfo, pAllocator, pYcbcrConversion);
	private delegate VkResult CreateSamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
	private static IntPtr CreateSamplerYcbcrConversionPointer;
	private static CreateSamplerYcbcrConversionDelegate_0 CreateSamplerYcbcrConversion_0;
	public static void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator) => DestroySamplerYcbcrConversion_0(device, ycbcrConversion, pAllocator);
	private delegate void DestroySamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySamplerYcbcrConversionPointer;
	private static DestroySamplerYcbcrConversionDelegate_0 DestroySamplerYcbcrConversion_0;
	public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_0(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
	private delegate VkResult CreateDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
	private static IntPtr CreateDescriptorUpdateTemplatePointer;
	private static CreateDescriptorUpdateTemplateDelegate_0 CreateDescriptorUpdateTemplate_0;
	public static void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator) => DestroyDescriptorUpdateTemplate_0(device, descriptorUpdateTemplate, pAllocator);
	private delegate void DestroyDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDescriptorUpdateTemplatePointer;
	private static DestroyDescriptorUpdateTemplateDelegate_0 DestroyDescriptorUpdateTemplate_0;
	public static void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData) => UpdateDescriptorSetWithTemplate_0(device, descriptorSet, descriptorUpdateTemplate, pData);
	private delegate void UpdateDescriptorSetWithTemplateDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
	private static IntPtr UpdateDescriptorSetWithTemplatePointer;
	private static UpdateDescriptorSetWithTemplateDelegate_0 UpdateDescriptorSetWithTemplate_0;
	public static void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) => GetPhysicalDeviceExternalBufferProperties_0(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
	private static IntPtr GetPhysicalDeviceExternalBufferPropertiesPointer;
	private static GetPhysicalDeviceExternalBufferPropertiesDelegate_0 GetPhysicalDeviceExternalBufferProperties_0;
	public static void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) => GetPhysicalDeviceExternalFenceProperties_0(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
	private static IntPtr GetPhysicalDeviceExternalFencePropertiesPointer;
	private static GetPhysicalDeviceExternalFencePropertiesDelegate_0 GetPhysicalDeviceExternalFenceProperties_0;
	public static void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties_0(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
	private static IntPtr GetPhysicalDeviceExternalSemaphorePropertiesPointer;
	private static GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0 GetPhysicalDeviceExternalSemaphoreProperties_0;
	public static void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport) => GetDescriptorSetLayoutSupport_0(device, pCreateInfo, pSupport);
	private delegate void GetDescriptorSetLayoutSupportDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
	private static IntPtr GetDescriptorSetLayoutSupportPointer;
	private static GetDescriptorSetLayoutSupportDelegate_0 GetDescriptorSetLayoutSupport_0;
	public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator) => DestroySurfaceKHR_0(instance, surface, pAllocator);
	private delegate void DestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySurfaceKHRPointer;
	private static DestroySurfaceKHRDelegate_0 DestroySurfaceKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported) => GetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, pSupported);
	private delegate VkResult GetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);
	private static IntPtr GetPhysicalDeviceSurfaceSupportKHRPointer;
	private static GetPhysicalDeviceSurfaceSupportKHRDelegate_0 GetPhysicalDeviceSurfaceSupportKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, pSurfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
	private static IntPtr GetPhysicalDeviceSurfaceCapabilitiesKHRPointer;
	private static GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 GetPhysicalDeviceSurfaceCapabilitiesKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
	private static IntPtr GetPhysicalDeviceSurfaceFormatsKHRPointer;
	private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_0 GetPhysicalDeviceSurfaceFormatsKHR_0;
	public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) => GetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, pPresentModeCount, pPresentModes);
	private delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
	private static IntPtr GetPhysicalDeviceSurfacePresentModesKHRPointer;
	private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_0 GetPhysicalDeviceSurfacePresentModesKHR_0;
	public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain) => CreateSwapchainKHR_0(device, pCreateInfo, pAllocator, pSwapchain);
	private delegate VkResult CreateSwapchainKHRDelegate_0(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain);
	private static IntPtr CreateSwapchainKHRPointer;
	private static CreateSwapchainKHRDelegate_0 CreateSwapchainKHR_0;
	public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator) => DestroySwapchainKHR_0(device, swapchain, pAllocator);
	private delegate void DestroySwapchainKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySwapchainKHRPointer;
	private static DestroySwapchainKHRDelegate_0 DestroySwapchainKHR_0;
	public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages) => GetSwapchainImagesKHR_0(device, swapchain, pSwapchainImageCount, pSwapchainImages);
	private delegate VkResult GetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages);
	private static IntPtr GetSwapchainImagesKHRPointer;
	private static GetSwapchainImagesKHRDelegate_0 GetSwapchainImagesKHR_0;
	public static VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex) => AcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, pImageIndex);
	private delegate VkResult AcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
	private static IntPtr AcquireNextImageKHRPointer;
	private static AcquireNextImageKHRDelegate_0 AcquireNextImageKHR_0;
	public static VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo) => QueuePresentKHR_0(queue, pPresentInfo);
	private delegate VkResult QueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* pPresentInfo);
	private static IntPtr QueuePresentKHRPointer;
	private static QueuePresentKHRDelegate_0 QueuePresentKHR_0;
	public static VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities) => GetDeviceGroupPresentCapabilitiesKHR_0(device, pDeviceGroupPresentCapabilities);
	private delegate VkResult GetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);
	private static IntPtr GetDeviceGroupPresentCapabilitiesKHRPointer;
	private static GetDeviceGroupPresentCapabilitiesKHRDelegate_0 GetDeviceGroupPresentCapabilitiesKHR_0;
	public static VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes) => GetDeviceGroupSurfacePresentModesKHR_0(device, surface, pModes);
	private delegate VkResult GetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr GetDeviceGroupSurfacePresentModesKHRPointer;
	private static GetDeviceGroupSurfacePresentModesKHRDelegate_0 GetDeviceGroupSurfacePresentModesKHR_0;
	public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects) => GetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, pRectCount, pRects);
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects);
	private static IntPtr GetPhysicalDevicePresentRectanglesKHRPointer;
	private static GetPhysicalDevicePresentRectanglesKHRDelegate_0 GetPhysicalDevicePresentRectanglesKHR_0;
	public static VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex) => AcquireNextImage2KHR_0(device, pAcquireInfo, pImageIndex);
	private delegate VkResult AcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex);
	private static IntPtr AcquireNextImage2KHRPointer;
	private static AcquireNextImage2KHRDelegate_0 AcquireNextImage2KHR_0;
	public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties) => GetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties);
	private static IntPtr GetPhysicalDeviceDisplayPropertiesKHRPointer;
	private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPropertiesKHR_0;
	public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
	private static IntPtr GetPhysicalDeviceDisplayPlanePropertiesKHRPointer;
	private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPlanePropertiesKHR_0;
	public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays) => GetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, pDisplayCount, pDisplays);
	private delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays);
	private static IntPtr GetDisplayPlaneSupportedDisplaysKHRPointer;
	private static GetDisplayPlaneSupportedDisplaysKHRDelegate_0 GetDisplayPlaneSupportedDisplaysKHR_0;
	public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties) => GetDisplayModePropertiesKHR_0(physicalDevice, display, pPropertyCount, pProperties);
	private delegate VkResult GetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
	private static IntPtr GetDisplayModePropertiesKHRPointer;
	private static GetDisplayModePropertiesKHRDelegate_0 GetDisplayModePropertiesKHR_0;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode) => CreateDisplayModeKHR_0(physicalDevice, display, pCreateInfo, pAllocator, pMode);
	private delegate VkResult CreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);
	private static IntPtr CreateDisplayModeKHRPointer;
	private static CreateDisplayModeKHRDelegate_0 CreateDisplayModeKHR_0;
	public static VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities) => GetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, pCapabilities);
	private delegate VkResult GetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);
	private static IntPtr GetDisplayPlaneCapabilitiesKHRPointer;
	private static GetDisplayPlaneCapabilitiesKHRDelegate_0 GetDisplayPlaneCapabilitiesKHR_0;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateDisplayPlaneSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateDisplayPlaneSurfaceKHRPointer;
	private static CreateDisplayPlaneSurfaceKHRDelegate_0 CreateDisplayPlaneSurfaceKHR_0;
	public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains) => CreateSharedSwapchainsKHR_0(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
	private delegate VkResult CreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);
	private static IntPtr CreateSharedSwapchainsKHRPointer;
	private static CreateSharedSwapchainsKHRDelegate_0 CreateSharedSwapchainsKHR_0;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateXlibSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateXlibSurfaceKHRPointer;
	private static CreateXlibSurfaceKHRDelegate_0 CreateXlibSurfaceKHR_0;
	public static VkBool32 GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID) => GetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
	private delegate VkBool32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID);
	private static IntPtr GetPhysicalDeviceXlibPresentationSupportKHRPointer;
	private static GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 GetPhysicalDeviceXlibPresentationSupportKHR_0;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateXcbSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateXcbSurfaceKHRDelegate_0(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateXcbSurfaceKHRPointer;
	private static CreateXcbSurfaceKHRDelegate_0 CreateXcbSurfaceKHR_0;
	public static VkBool32 GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id) => GetPhysicalDeviceXcbPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection, visual_id);
	private delegate VkBool32 GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id);
	private static IntPtr GetPhysicalDeviceXcbPresentationSupportKHRPointer;
	private static GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0 GetPhysicalDeviceXcbPresentationSupportKHR_0;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateWaylandSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_0(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateWaylandSurfaceKHRPointer;
	private static CreateWaylandSurfaceKHRDelegate_0 CreateWaylandSurfaceKHR_0;
	public static VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display) => GetPhysicalDeviceWaylandPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, display);
	private delegate VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display);
	private static IntPtr GetPhysicalDeviceWaylandPresentationSupportKHRPointer;
	private static GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0 GetPhysicalDeviceWaylandPresentationSupportKHR_0;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateAndroidSurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateAndroidSurfaceKHRPointer;
	private static CreateAndroidSurfaceKHRDelegate_0 CreateAndroidSurfaceKHR_0;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateWin32SurfaceKHR_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateWin32SurfaceKHRPointer;
	private static CreateWin32SurfaceKHRDelegate_0 CreateWin32SurfaceKHR_0;
	public static VkBool32 GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex) => GetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
	private delegate VkBool32 GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
	private static IntPtr GetPhysicalDeviceWin32PresentationSupportKHRPointer;
	private static GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0 GetPhysicalDeviceWin32PresentationSupportKHR_0;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback) => CreateDebugReportCallbackEXT_0(instance, pCreateInfo, pAllocator, pCallback);
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback);
	private static IntPtr CreateDebugReportCallbackEXTPointer;
	private static CreateDebugReportCallbackEXTDelegate_0 CreateDebugReportCallbackEXT_0;
	public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator) => DestroyDebugReportCallbackEXT_0(instance, callback, pAllocator);
	private delegate void DestroyDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDebugReportCallbackEXTPointer;
	private static DestroyDebugReportCallbackEXTDelegate_0 DestroyDebugReportCallbackEXT_0;
	public static void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage) => DebugReportMessageEXT_0(instance, flags, objectType, object, location, messageCode, pLayerPrefix, pMessage);
	private delegate void DebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage);
	private static IntPtr DebugReportMessageEXTPointer;
	private static DebugReportMessageEXTDelegate_0 DebugReportMessageEXT_0;
	public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo) => DebugMarkerSetObjectTagEXT_0(device, pTagInfo);
	private delegate VkResult DebugMarkerSetObjectTagEXTDelegate_0(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo);
	private static IntPtr DebugMarkerSetObjectTagEXTPointer;
	private static DebugMarkerSetObjectTagEXTDelegate_0 DebugMarkerSetObjectTagEXT_0;
	public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo) => DebugMarkerSetObjectNameEXT_0(device, pNameInfo);
	private delegate VkResult DebugMarkerSetObjectNameEXTDelegate_0(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo);
	private static IntPtr DebugMarkerSetObjectNameEXTPointer;
	private static DebugMarkerSetObjectNameEXTDelegate_0 DebugMarkerSetObjectNameEXT_0;
	public static void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo) => CommandDebugMarkerBeginEXT_0(commandBuffer, pMarkerInfo);
	private delegate void CommandDebugMarkerBeginEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
	private static IntPtr CommandDebugMarkerBeginEXTPointer;
	private static CommandDebugMarkerBeginEXTDelegate_0 CommandDebugMarkerBeginEXT_0;
	public static void CommandDebugMarkerEndEXT(VkCommandBuffer commandBuffer) => CommandDebugMarkerEndEXT_0(commandBuffer);
	private delegate void CommandDebugMarkerEndEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr CommandDebugMarkerEndEXTPointer;
	private static CommandDebugMarkerEndEXTDelegate_0 CommandDebugMarkerEndEXT_0;
	public static void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo) => CommandDebugMarkerInsertEXT_0(commandBuffer, pMarkerInfo);
	private delegate void CommandDebugMarkerInsertEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
	private static IntPtr CommandDebugMarkerInsertEXTPointer;
	private static CommandDebugMarkerInsertEXTDelegate_0 CommandDebugMarkerInsertEXT_0;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes) => CommandBindTransformFeedbackBuffersEXT_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes);
	private static IntPtr CommandBindTransformFeedbackBuffersEXTPointer;
	private static CommandBindTransformFeedbackBuffersEXTDelegate_0 CommandBindTransformFeedbackBuffersEXT_0;
	public static void CommandBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets) => CommandBeginTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
	private delegate void CommandBeginTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets);
	private static IntPtr CommandBeginTransformFeedbackEXTPointer;
	private static CommandBeginTransformFeedbackEXTDelegate_0 CommandBeginTransformFeedbackEXT_0;
	public static void CommandEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets) => CommandEndTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
	private delegate void CommandEndTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets);
	private static IntPtr CommandEndTransformFeedbackEXTPointer;
	private static CommandEndTransformFeedbackEXTDelegate_0 CommandEndTransformFeedbackEXT_0;
	public static void CommandBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index) => CommandBeginQueryIndexedEXT_0(commandBuffer, queryPool, query, flags, index);
	private delegate void CommandBeginQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
	private static IntPtr CommandBeginQueryIndexedEXTPointer;
	private static CommandBeginQueryIndexedEXTDelegate_0 CommandBeginQueryIndexedEXT_0;
	public static void CommandEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index) => CommandEndQueryIndexedEXT_0(commandBuffer, queryPool, query, index);
	private delegate void CommandEndQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
	private static IntPtr CommandEndQueryIndexedEXTPointer;
	private static CommandEndQueryIndexedEXTDelegate_0 CommandEndQueryIndexedEXT_0;
	public static void CommandDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride) => CommandDrawIndirectByteCountEXT_0(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
	private delegate void CommandDrawIndirectByteCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride);
	private static IntPtr CommandDrawIndirectByteCountEXTPointer;
	private static CommandDrawIndirectByteCountEXTDelegate_0 CommandDrawIndirectByteCountEXT_0;
	public static uint GetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo) => GetImageViewHandleNVX_0(device, pInfo);
	private delegate uint GetImageViewHandleNVXDelegate_0(VkDevice device, VkImageViewHandleInfoNVX* pInfo);
	private static IntPtr GetImageViewHandleNVXPointer;
	private static GetImageViewHandleNVXDelegate_0 GetImageViewHandleNVX_0;
	[Obsolete("Use CommandDrawIndirectCountKHR")]
	public static void CommandDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr CommandDrawIndirectCountAMDPointer;
	private static CommandDrawIndirectCountAMDDelegate_0 CommandDrawIndirectCountAMD_0;
	[Obsolete("Use CommandDrawIndexedIndirectCountKHR")]
	public static void CommandDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr CommandDrawIndexedIndirectCountAMDPointer;
	private static CommandDrawIndexedIndirectCountAMDDelegate_0 CommandDrawIndexedIndirectCountAMD_0;
	public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo) => GetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
	private delegate VkResult GetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo);
	private static IntPtr GetShaderInfoAMDPointer;
	private static GetShaderInfoAMDDelegate_0 GetShaderInfoAMD_0;
	public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties) => GetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
	private delegate VkResult GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
	private static IntPtr GetPhysicalDeviceExternalImageFormatPropertiesNVPointer;
	private static GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 GetPhysicalDeviceExternalImageFormatPropertiesNV_0;
	public static VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle) => GetMemoryWin32HandleNV_0(device, memory, handleType, pHandle);
	private delegate VkResult GetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle);
	private static IntPtr GetMemoryWin32HandleNVPointer;
	private static GetMemoryWin32HandleNVDelegate_0 GetMemoryWin32HandleNV_0;
	[Obsolete("Use GetPhysicalDeviceFeatures2")]
	public static void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures) => GetPhysicalDeviceFeatures2KHR_0(physicalDevice, pFeatures);
	private delegate void GetPhysicalDeviceFeatures2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
	private static IntPtr GetPhysicalDeviceFeatures2KHRPointer;
	private static GetPhysicalDeviceFeatures2KHRDelegate_0 GetPhysicalDeviceFeatures2KHR_0;
	[Obsolete("Use GetPhysicalDeviceProperties2")]
	public static void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties) => GetPhysicalDeviceProperties2KHR_0(physicalDevice, pProperties);
	private delegate void GetPhysicalDeviceProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
	private static IntPtr GetPhysicalDeviceProperties2KHRPointer;
	private static GetPhysicalDeviceProperties2KHRDelegate_0 GetPhysicalDeviceProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceFormatProperties2")]
	public static void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties) => GetPhysicalDeviceFormatProperties2KHR_0(physicalDevice, format, pFormatProperties);
	private delegate void GetPhysicalDeviceFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
	private static IntPtr GetPhysicalDeviceFormatProperties2KHRPointer;
	private static GetPhysicalDeviceFormatProperties2KHRDelegate_0 GetPhysicalDeviceFormatProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceImageFormatProperties2")]
	public static void GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) => GetPhysicalDeviceImageFormatProperties2KHR_0(physicalDevice, pImageFormatInfo, pImageFormatProperties);
	private delegate void GetPhysicalDeviceImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
	private static IntPtr GetPhysicalDeviceImageFormatProperties2KHRPointer;
	private static GetPhysicalDeviceImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceImageFormatProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceQueueFamilyProperties2")]
	public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2KHR_0(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
	private static IntPtr GetPhysicalDeviceQueueFamilyProperties2KHRPointer;
	private static GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0 GetPhysicalDeviceQueueFamilyProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceMemoryProperties2")]
	public static void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties) => GetPhysicalDeviceMemoryProperties2KHR_0(physicalDevice, pMemoryProperties);
	private delegate void GetPhysicalDeviceMemoryProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
	private static IntPtr GetPhysicalDeviceMemoryProperties2KHRPointer;
	private static GetPhysicalDeviceMemoryProperties2KHRDelegate_0 GetPhysicalDeviceMemoryProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceSparseImageFormatProperties2")]
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_0(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
	private static IntPtr GetPhysicalDeviceSparseImageFormatProperties2KHRPointer;
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceSparseImageFormatProperties2KHR_0;
	[Obsolete("Use GetDeviceGroupPeerMemoryFeatures")]
	public static void GetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures) => GetDeviceGroupPeerMemoryFeaturesKHR_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
	private delegate void GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
	private static IntPtr GetDeviceGroupPeerMemoryFeaturesKHRPointer;
	private static GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0 GetDeviceGroupPeerMemoryFeaturesKHR_0;
	[Obsolete("Use CommandSetDeviceMask")]
	public static void CommandSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMaskKHR_0(commandBuffer, deviceMask);
	private delegate void CommandSetDeviceMaskKHRDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static IntPtr CommandSetDeviceMaskKHRPointer;
	private static CommandSetDeviceMaskKHRDelegate_0 CommandSetDeviceMaskKHR_0;
	[Obsolete("Use CommandDispatchBase")]
	public static void CommandDispatchBaseKHR(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBaseKHR_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchBaseKHRDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static IntPtr CommandDispatchBaseKHRPointer;
	private static CommandDispatchBaseKHRDelegate_0 CommandDispatchBaseKHR_0;
	public static VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities) => GetDeviceGroupPresentCapabilitiesKHR_0(device, pDeviceGroupPresentCapabilities);
	private delegate VkResult GetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);
	private static IntPtr GetDeviceGroupPresentCapabilitiesKHRPointer;
	private static GetDeviceGroupPresentCapabilitiesKHRDelegate_0 GetDeviceGroupPresentCapabilitiesKHR_0;
	public static VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes) => GetDeviceGroupSurfacePresentModesKHR_0(device, surface, pModes);
	private delegate VkResult GetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr GetDeviceGroupSurfacePresentModesKHRPointer;
	private static GetDeviceGroupSurfacePresentModesKHRDelegate_0 GetDeviceGroupSurfacePresentModesKHR_0;
	public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects) => GetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, pRectCount, pRects);
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects);
	private static IntPtr GetPhysicalDevicePresentRectanglesKHRPointer;
	private static GetPhysicalDevicePresentRectanglesKHRDelegate_0 GetPhysicalDevicePresentRectanglesKHR_0;
	public static VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex) => AcquireNextImage2KHR_0(device, pAcquireInfo, pImageIndex);
	private delegate VkResult AcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex);
	private static IntPtr AcquireNextImage2KHRPointer;
	private static AcquireNextImage2KHRDelegate_0 AcquireNextImage2KHR_0;
	[Obsolete("Use TrimCommandPool")]
	public static void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags) => TrimCommandPoolKHR_0(device, commandPool, flags);
	private delegate void TrimCommandPoolKHRDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
	private static IntPtr TrimCommandPoolKHRPointer;
	private static TrimCommandPoolKHRDelegate_0 TrimCommandPoolKHR_0;
	[Obsolete("Use EnumeratePhysicalDeviceGroups")]
	public static void EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroupsKHR_0(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
	private delegate void EnumeratePhysicalDeviceGroupsKHRDelegate_0(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
	private static IntPtr EnumeratePhysicalDeviceGroupsKHRPointer;
	private static EnumeratePhysicalDeviceGroupsKHRDelegate_0 EnumeratePhysicalDeviceGroupsKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalBufferProperties")]
	public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) => GetPhysicalDeviceExternalBufferPropertiesKHR_0(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
	private static IntPtr GetPhysicalDeviceExternalBufferPropertiesKHRPointer;
	private static GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0 GetPhysicalDeviceExternalBufferPropertiesKHR_0;
	public static VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => GetMemoryWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult GetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr GetMemoryWin32HandleKHRPointer;
	private static GetMemoryWin32HandleKHRDelegate_0 GetMemoryWin32HandleKHR_0;
	public static VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties) => GetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, pMemoryWin32HandleProperties);
	private delegate VkResult GetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
	private static IntPtr GetMemoryWin32HandlePropertiesKHRPointer;
	private static GetMemoryWin32HandlePropertiesKHRDelegate_0 GetMemoryWin32HandlePropertiesKHR_0;
	public static VkResult GetMemoryFileDescriptorKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd) => GetMemoryFileDescriptorKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult GetMemoryFileDescriptorKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr GetMemoryFileDescriptorKHRPointer;
	private static GetMemoryFileDescriptorKHRDelegate_0 GetMemoryFileDescriptorKHR_0;
	public static VkResult GetMemoryFileDescriptorPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties) => GetMemoryFileDescriptorPropertiesKHR_0(device, handleType, fd, pMemoryFdProperties);
	private delegate VkResult GetMemoryFileDescriptorPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);
	private static IntPtr GetMemoryFileDescriptorPropertiesKHRPointer;
	private static GetMemoryFileDescriptorPropertiesKHRDelegate_0 GetMemoryFileDescriptorPropertiesKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalSemaphoreProperties")]
	public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphorePropertiesKHR_0(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
	private static IntPtr GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer;
	private static GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0 GetPhysicalDeviceExternalSemaphorePropertiesKHR_0;
	public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_0(device, pImportSemaphoreWin32HandleInfo);
	private delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
	private static IntPtr ImportSemaphoreWin32HandleKHRPointer;
	private static ImportSemaphoreWin32HandleKHRDelegate_0 ImportSemaphoreWin32HandleKHR_0;
	public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => GetSemaphoreWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult GetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr GetSemaphoreWin32HandleKHRPointer;
	private static GetSemaphoreWin32HandleKHRDelegate_0 GetSemaphoreWin32HandleKHR_0;
	public static VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo) => ImportSemaphoreFileDescriptorKHR_0(device, pImportSemaphoreFdInfo);
	private delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);
	private static IntPtr ImportSemaphoreFileDescriptorKHRPointer;
	private static ImportSemaphoreFileDescriptorKHRDelegate_0 ImportSemaphoreFileDescriptorKHR_0;
	public static VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd) => GetSemaphoreFileDescriptorKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr GetSemaphoreFileDescriptorKHRPointer;
	private static GetSemaphoreFileDescriptorKHRDelegate_0 GetSemaphoreFileDescriptorKHR_0;
	public static void CommandPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites) => CommandPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
	private delegate void CommandPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
	private static IntPtr CommandPushDescriptorSetKHRPointer;
	private static CommandPushDescriptorSetKHRDelegate_0 CommandPushDescriptorSetKHR_0;
	public static void CommandPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData) => CommandPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
	private delegate void CommandPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
	private static IntPtr CommandPushDescriptorSetWithTemplateKHRPointer;
	private static CommandPushDescriptorSetWithTemplateKHRDelegate_0 CommandPushDescriptorSetWithTemplateKHR_0;
	public static void CommandBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin) => CommandBeginConditionalRenderingEXT_0(commandBuffer, pConditionalRenderingBegin);
	private delegate void CommandBeginConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);
	private static IntPtr CommandBeginConditionalRenderingEXTPointer;
	private static CommandBeginConditionalRenderingEXTDelegate_0 CommandBeginConditionalRenderingEXT_0;
	public static void CommandEndConditionalRenderingEXT(VkCommandBuffer commandBuffer) => CommandEndConditionalRenderingEXT_0(commandBuffer);
	private delegate void CommandEndConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr CommandEndConditionalRenderingEXTPointer;
	private static CommandEndConditionalRenderingEXTDelegate_0 CommandEndConditionalRenderingEXT_0;
	[Obsolete("Use CreateDescriptorUpdateTemplate")]
	public static void CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_0(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
	private delegate void CreateDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
	private static IntPtr CreateDescriptorUpdateTemplateKHRPointer;
	private static CreateDescriptorUpdateTemplateKHRDelegate_0 CreateDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use DestroyDescriptorUpdateTemplate")]
	public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator) => DestroyDescriptorUpdateTemplateKHR_0(device, descriptorUpdateTemplate, pAllocator);
	private delegate void DestroyDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDescriptorUpdateTemplateKHRPointer;
	private static DestroyDescriptorUpdateTemplateKHRDelegate_0 DestroyDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use UpdateDescriptorSetWithTemplate")]
	public static void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData) => UpdateDescriptorSetWithTemplateKHR_0(device, descriptorSet, descriptorUpdateTemplate, pData);
	private delegate void UpdateDescriptorSetWithTemplateKHRDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
	private static IntPtr UpdateDescriptorSetWithTemplateKHRPointer;
	private static UpdateDescriptorSetWithTemplateKHRDelegate_0 UpdateDescriptorSetWithTemplateKHR_0;
	public static void CommandPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData) => CommandPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
	private delegate void CommandPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
	private static IntPtr CommandPushDescriptorSetWithTemplateKHRPointer;
	private static CommandPushDescriptorSetWithTemplateKHRDelegate_0 CommandPushDescriptorSetWithTemplateKHR_0;
	public static void CommandProcessCommandsNVX(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo) => CommandProcessCommandsNVX_0(commandBuffer, pProcessCommandsInfo);
	private delegate void CommandProcessCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo);
	private static IntPtr CommandProcessCommandsNVXPointer;
	private static CommandProcessCommandsNVXDelegate_0 CommandProcessCommandsNVX_0;
	public static void CommandReserveSpaceForCommandsNVX(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo) => CommandReserveSpaceForCommandsNVX_0(commandBuffer, pReserveSpaceInfo);
	private delegate void CommandReserveSpaceForCommandsNVXDelegate_0(VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo);
	private static IntPtr CommandReserveSpaceForCommandsNVXPointer;
	private static CommandReserveSpaceForCommandsNVXDelegate_0 CommandReserveSpaceForCommandsNVX_0;
	public static VkResult CreateIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout) => CreateIndirectCommandsLayoutNVX_0(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
	private delegate VkResult CreateIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout);
	private static IntPtr CreateIndirectCommandsLayoutNVXPointer;
	private static CreateIndirectCommandsLayoutNVXDelegate_0 CreateIndirectCommandsLayoutNVX_0;
	public static void DestroyIndirectCommandsLayoutNVX(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator) => DestroyIndirectCommandsLayoutNVX_0(device, indirectCommandsLayout, pAllocator);
	private delegate void DestroyIndirectCommandsLayoutNVXDelegate_0(VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyIndirectCommandsLayoutNVXPointer;
	private static DestroyIndirectCommandsLayoutNVXDelegate_0 DestroyIndirectCommandsLayoutNVX_0;
	public static VkResult CreateObjectTableNVX(VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable) => CreateObjectTableNVX_0(device, pCreateInfo, pAllocator, pObjectTable);
	private delegate VkResult CreateObjectTableNVXDelegate_0(VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable);
	private static IntPtr CreateObjectTableNVXPointer;
	private static CreateObjectTableNVXDelegate_0 CreateObjectTableNVX_0;
	public static void DestroyObjectTableNVX(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator) => DestroyObjectTableNVX_0(device, objectTable, pAllocator);
	private delegate void DestroyObjectTableNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyObjectTableNVXPointer;
	private static DestroyObjectTableNVXDelegate_0 DestroyObjectTableNVX_0;
	public static VkResult RegisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint* pObjectIndices) => RegisterObjectsNVX_0(device, objectTable, objectCount, ppObjectTableEntries, pObjectIndices);
	private delegate VkResult RegisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint* pObjectIndices);
	private static IntPtr RegisterObjectsNVXPointer;
	private static RegisterObjectsNVXDelegate_0 RegisterObjectsNVX_0;
	public static VkResult UnregisterObjectsNVX(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices) => UnregisterObjectsNVX_0(device, objectTable, objectCount, pObjectEntryTypes, pObjectIndices);
	private delegate VkResult UnregisterObjectsNVXDelegate_0(VkDevice device, VkObjectTableNVX objectTable, uint objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices);
	private static IntPtr UnregisterObjectsNVXPointer;
	private static UnregisterObjectsNVXDelegate_0 UnregisterObjectsNVX_0;
	public static void GetPhysicalDeviceGeneratedCommandsPropertiesNVX(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits) => GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0(physicalDevice, pFeatures, pLimits);
	private delegate void GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits);
	private static IntPtr GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer;
	private static GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0 GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0;
	public static void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings) => CommandSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
	private delegate void CommandSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings);
	private static IntPtr CommandSetViewportWScalingNVPointer;
	private static CommandSetViewportWScalingNVDelegate_0 CommandSetViewportWScalingNV_0;
	public static VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => ReleaseDisplayEXT_0(physicalDevice, display);
	private delegate VkResult ReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static IntPtr ReleaseDisplayEXTPointer;
	private static ReleaseDisplayEXTDelegate_0 ReleaseDisplayEXT_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, pSurfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities);
	private static IntPtr GetPhysicalDeviceSurfaceCapabilities2EXTPointer;
	private static GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0 GetPhysicalDeviceSurfaceCapabilities2EXT_0;
	public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo) => DisplayPowerControlEXT_0(device, display, pDisplayPowerInfo);
	private delegate VkResult DisplayPowerControlEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo);
	private static IntPtr DisplayPowerControlEXTPointer;
	private static DisplayPowerControlEXTDelegate_0 DisplayPowerControlEXT_0;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => RegisterDeviceEventEXT_0(device, pDeviceEventInfo, pAllocator, pFence);
	private delegate VkResult RegisterDeviceEventEXTDelegate_0(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr RegisterDeviceEventEXTPointer;
	private static RegisterDeviceEventEXTDelegate_0 RegisterDeviceEventEXT_0;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence) => RegisterDisplayEventEXT_0(device, display, pDisplayEventInfo, pAllocator, pFence);
	private delegate VkResult RegisterDisplayEventEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
	private static IntPtr RegisterDisplayEventEXTPointer;
	private static RegisterDisplayEventEXTDelegate_0 RegisterDisplayEventEXT_0;
	public static VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue) => GetSwapchainCounterEXT_0(device, swapchain, counter, pCounterValue);
	private delegate VkResult GetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue);
	private static IntPtr GetSwapchainCounterEXTPointer;
	private static GetSwapchainCounterEXTDelegate_0 GetSwapchainCounterEXT_0;
	public static VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties) => GetRefreshCycleDurationGOOGLE_0(device, swapchain, pDisplayTimingProperties);
	private delegate VkResult GetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
	private static IntPtr GetRefreshCycleDurationGOOGLEPointer;
	private static GetRefreshCycleDurationGOOGLEDelegate_0 GetRefreshCycleDurationGOOGLE_0;
	public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings) => GetPastPresentationTimingGOOGLE_0(device, swapchain, pPresentationTimingCount, pPresentationTimings);
	private delegate VkResult GetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
	private static IntPtr GetPastPresentationTimingGOOGLEPointer;
	private static GetPastPresentationTimingGOOGLEDelegate_0 GetPastPresentationTimingGOOGLE_0;
	public static void CommandSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles) => CommandSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
	private delegate void CommandSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles);
	private static IntPtr CommandSetDiscardRectangleEXTPointer;
	private static CommandSetDiscardRectangleEXTDelegate_0 CommandSetDiscardRectangleEXT_0;
	public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata) => SetHdrMetadataEXT_0(device, swapchainCount, pSwapchains, pMetadata);
	private delegate void SetHdrMetadataEXTDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata);
	private static IntPtr SetHdrMetadataEXTPointer;
	private static SetHdrMetadataEXTDelegate_0 SetHdrMetadataEXT_0;
	public static VkResult CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2KHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => CreateRenderPass2KHR_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate VkResult CreateRenderPass2KHRDelegate_0(VkDevice device, VkRenderPassCreateInfo2KHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr CreateRenderPass2KHRPointer;
	private static CreateRenderPass2KHRDelegate_0 CreateRenderPass2KHR_0;
	public static void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfoKHR* pSubpassBeginInfo) => CommandBeginRenderPass2KHR_0(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
	private delegate void CommandBeginRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfoKHR* pSubpassBeginInfo);
	private static IntPtr CommandBeginRenderPass2KHRPointer;
	private static CommandBeginRenderPass2KHRDelegate_0 CommandBeginRenderPass2KHR_0;
	public static void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* pSubpassBeginInfo, VkSubpassEndInfoKHR* pSubpassEndInfo) => CommandNextSubpass2KHR_0(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
	private delegate void CommandNextSubpass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* pSubpassBeginInfo, VkSubpassEndInfoKHR* pSubpassEndInfo);
	private static IntPtr CommandNextSubpass2KHRPointer;
	private static CommandNextSubpass2KHRDelegate_0 CommandNextSubpass2KHR_0;
	public static void CommandEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* pSubpassEndInfo) => CommandEndRenderPass2KHR_0(commandBuffer, pSubpassEndInfo);
	private delegate void CommandEndRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* pSubpassEndInfo);
	private static IntPtr CommandEndRenderPass2KHRPointer;
	private static CommandEndRenderPass2KHRDelegate_0 CommandEndRenderPass2KHR_0;
	public static VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => GetSwapchainStatusKHR_0(device, swapchain);
	private delegate VkResult GetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr GetSwapchainStatusKHRPointer;
	private static GetSwapchainStatusKHRDelegate_0 GetSwapchainStatusKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalFenceProperties")]
	public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) => GetPhysicalDeviceExternalFencePropertiesKHR_0(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
	private static IntPtr GetPhysicalDeviceExternalFencePropertiesKHRPointer;
	private static GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0 GetPhysicalDeviceExternalFencePropertiesKHR_0;
	public static VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_0(device, pImportFenceWin32HandleInfo);
	private delegate VkResult ImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
	private static IntPtr ImportFenceWin32HandleKHRPointer;
	private static ImportFenceWin32HandleKHRDelegate_0 ImportFenceWin32HandleKHR_0;
	public static VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle) => GetFenceWin32HandleKHR_0(device, pGetWin32HandleInfo, pHandle);
	private delegate VkResult GetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle);
	private static IntPtr GetFenceWin32HandleKHRPointer;
	private static GetFenceWin32HandleKHRDelegate_0 GetFenceWin32HandleKHR_0;
	public static VkResult ImportFenceFileDescriptorKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo) => ImportFenceFileDescriptorKHR_0(device, pImportFenceFdInfo);
	private delegate VkResult ImportFenceFileDescriptorKHRDelegate_0(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo);
	private static IntPtr ImportFenceFileDescriptorKHRPointer;
	private static ImportFenceFileDescriptorKHRDelegate_0 ImportFenceFileDescriptorKHR_0;
	public static VkResult GetFenceFileDescriptorKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd) => GetFenceFileDescriptorKHR_0(device, pGetFdInfo, pFd);
	private delegate VkResult GetFenceFileDescriptorKHRDelegate_0(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd);
	private static IntPtr GetFenceFileDescriptorKHRPointer;
	private static GetFenceFileDescriptorKHRDelegate_0 GetFenceFileDescriptorKHR_0;
	public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions) => EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
	private delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions);
	private static IntPtr EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer;
	private static EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0 EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0;
	public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses) => GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
	private delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses);
	private static IntPtr GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer;
	private static GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0 GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0;
	public static VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo) => AcquireProfilingLockKHR_0(device, pInfo);
	private delegate VkResult AcquireProfilingLockKHRDelegate_0(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo);
	private static IntPtr AcquireProfilingLockKHRPointer;
	private static AcquireProfilingLockKHRDelegate_0 AcquireProfilingLockKHR_0;
	public static void ReleaseProfilingLockKHR(VkDevice device) => ReleaseProfilingLockKHR_0(device);
	private delegate void ReleaseProfilingLockKHRDelegate_0(VkDevice device);
	private static IntPtr ReleaseProfilingLockKHRPointer;
	private static ReleaseProfilingLockKHRDelegate_0 ReleaseProfilingLockKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
	private static IntPtr GetPhysicalDeviceSurfaceCapabilities2KHRPointer;
	private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 GetPhysicalDeviceSurfaceCapabilities2KHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
	private static IntPtr GetPhysicalDeviceSurfaceFormats2KHRPointer;
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_0 GetPhysicalDeviceSurfaceFormats2KHR_0;
	public static VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties) => GetPhysicalDeviceDisplayProperties2KHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult GetPhysicalDeviceDisplayProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties);
	private static IntPtr GetPhysicalDeviceDisplayProperties2KHRPointer;
	private static GetPhysicalDeviceDisplayProperties2KHRDelegate_0 GetPhysicalDeviceDisplayProperties2KHR_0;
	public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties) => GetPhysicalDeviceDisplayPlaneProperties2KHR_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);
	private static IntPtr GetPhysicalDeviceDisplayPlaneProperties2KHRPointer;
	private static GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0 GetPhysicalDeviceDisplayPlaneProperties2KHR_0;
	public static VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties) => GetDisplayModeProperties2KHR_0(physicalDevice, display, pPropertyCount, pProperties);
	private delegate VkResult GetDisplayModeProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);
	private static IntPtr GetDisplayModeProperties2KHRPointer;
	private static GetDisplayModeProperties2KHRDelegate_0 GetDisplayModeProperties2KHR_0;
	public static VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities) => GetDisplayPlaneCapabilities2KHR_0(physicalDevice, pDisplayPlaneInfo, pCapabilities);
	private delegate VkResult GetDisplayPlaneCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);
	private static IntPtr GetDisplayPlaneCapabilities2KHRPointer;
	private static GetDisplayPlaneCapabilities2KHRDelegate_0 GetDisplayPlaneCapabilities2KHR_0;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateMacOSSurfaceMVK_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateMacOSSurfaceMVKPointer;
	private static CreateMacOSSurfaceMVKDelegate_0 CreateMacOSSurfaceMVK_0;
	public static VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo) => SetDebugUtilsObjectNameEXT_0(device, pNameInfo);
	private delegate VkResult SetDebugUtilsObjectNameEXTDelegate_0(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo);
	private static IntPtr SetDebugUtilsObjectNameEXTPointer;
	private static SetDebugUtilsObjectNameEXTDelegate_0 SetDebugUtilsObjectNameEXT_0;
	public static VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo) => SetDebugUtilsObjectTagEXT_0(device, pTagInfo);
	private delegate VkResult SetDebugUtilsObjectTagEXTDelegate_0(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo);
	private static IntPtr SetDebugUtilsObjectTagEXTPointer;
	private static SetDebugUtilsObjectTagEXTDelegate_0 SetDebugUtilsObjectTagEXT_0;
	public static void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo) => QueueBeginDebugUtilsLabelEXT_0(queue, pLabelInfo);
	private delegate void QueueBeginDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr QueueBeginDebugUtilsLabelEXTPointer;
	private static QueueBeginDebugUtilsLabelEXTDelegate_0 QueueBeginDebugUtilsLabelEXT_0;
	public static void QueueEndDebugUtilsLabelEXT(VkQueue queue) => QueueEndDebugUtilsLabelEXT_0(queue);
	private delegate void QueueEndDebugUtilsLabelEXTDelegate_0(VkQueue queue);
	private static IntPtr QueueEndDebugUtilsLabelEXTPointer;
	private static QueueEndDebugUtilsLabelEXTDelegate_0 QueueEndDebugUtilsLabelEXT_0;
	public static void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo) => QueueInsertDebugUtilsLabelEXT_0(queue, pLabelInfo);
	private delegate void QueueInsertDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr QueueInsertDebugUtilsLabelEXTPointer;
	private static QueueInsertDebugUtilsLabelEXTDelegate_0 QueueInsertDebugUtilsLabelEXT_0;
	public static void CommandBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo) => CommandBeginDebugUtilsLabelEXT_0(commandBuffer, pLabelInfo);
	private delegate void CommandBeginDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr CommandBeginDebugUtilsLabelEXTPointer;
	private static CommandBeginDebugUtilsLabelEXTDelegate_0 CommandBeginDebugUtilsLabelEXT_0;
	public static void CommandEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer) => CommandEndDebugUtilsLabelEXT_0(commandBuffer);
	private delegate void CommandEndDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr CommandEndDebugUtilsLabelEXTPointer;
	private static CommandEndDebugUtilsLabelEXTDelegate_0 CommandEndDebugUtilsLabelEXT_0;
	public static void CommandInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo) => CommandInsertDebugUtilsLabelEXT_0(commandBuffer, pLabelInfo);
	private delegate void CommandInsertDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
	private static IntPtr CommandInsertDebugUtilsLabelEXTPointer;
	private static CommandInsertDebugUtilsLabelEXTDelegate_0 CommandInsertDebugUtilsLabelEXT_0;
	public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger) => CreateDebugUtilsMessengerEXT_0(instance, pCreateInfo, pAllocator, pMessenger);
	private delegate VkResult CreateDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger);
	private static IntPtr CreateDebugUtilsMessengerEXTPointer;
	private static CreateDebugUtilsMessengerEXTDelegate_0 CreateDebugUtilsMessengerEXT_0;
	public static void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator) => DestroyDebugUtilsMessengerEXT_0(instance, messenger, pAllocator);
	private delegate void DestroyDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyDebugUtilsMessengerEXTPointer;
	private static DestroyDebugUtilsMessengerEXTDelegate_0 DestroyDebugUtilsMessengerEXT_0;
	public static void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData) => SubmitDebugUtilsMessageEXT_0(instance, messageSeverity, messageTypes, pCallbackData);
	private delegate void SubmitDebugUtilsMessageEXTDelegate_0(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
	private static IntPtr SubmitDebugUtilsMessageEXTPointer;
	private static SubmitDebugUtilsMessageEXTDelegate_0 SubmitDebugUtilsMessageEXT_0;
	public static VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, void* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties) => GetAndroidHardwareBufferPropertiesANDROID_0(device, buffer, pProperties);
	private delegate VkResult GetAndroidHardwareBufferPropertiesANDROIDDelegate_0(VkDevice device, void* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties);
	private static IntPtr GetAndroidHardwareBufferPropertiesANDROIDPointer;
	private static GetAndroidHardwareBufferPropertiesANDROIDDelegate_0 GetAndroidHardwareBufferPropertiesANDROID_0;
	public static VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, void** pBuffer) => GetMemoryAndroidHardwareBufferANDROID_0(device, pInfo, pBuffer);
	private delegate VkResult GetMemoryAndroidHardwareBufferANDROIDDelegate_0(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, void** pBuffer);
	private static IntPtr GetMemoryAndroidHardwareBufferANDROIDPointer;
	private static GetMemoryAndroidHardwareBufferANDROIDDelegate_0 GetMemoryAndroidHardwareBufferANDROID_0;
	public static void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo) => CommandSetSampleLocationsEXT_0(commandBuffer, pSampleLocationsInfo);
	private delegate void CommandSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo);
	private static IntPtr CommandSetSampleLocationsEXTPointer;
	private static CommandSetSampleLocationsEXTDelegate_0 CommandSetSampleLocationsEXT_0;
	public static void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties) => GetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, pMultisampleProperties);
	private delegate void GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties);
	private static IntPtr GetPhysicalDeviceMultisamplePropertiesEXTPointer;
	private static GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 GetPhysicalDeviceMultisamplePropertiesEXT_0;
	[Obsolete("Use GetImageMemoryRequirements2")]
	public static void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => GetImageMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void GetImageMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr GetImageMemoryRequirements2KHRPointer;
	private static GetImageMemoryRequirements2KHRDelegate_0 GetImageMemoryRequirements2KHR_0;
	[Obsolete("Use GetBufferMemoryRequirements2")]
	public static void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements) => GetBufferMemoryRequirements2KHR_0(device, pInfo, pMemoryRequirements);
	private delegate void GetBufferMemoryRequirements2KHRDelegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr GetBufferMemoryRequirements2KHRPointer;
	private static GetBufferMemoryRequirements2KHRDelegate_0 GetBufferMemoryRequirements2KHR_0;
	[Obsolete("Use GetImageSparseMemoryRequirements2")]
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
	private static IntPtr GetImageSparseMemoryRequirements2KHRPointer;
	private static GetImageSparseMemoryRequirements2KHRDelegate_0 GetImageSparseMemoryRequirements2KHR_0;
	[Obsolete("Use CreateSamplerYcbcrConversion")]
	public static void CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion) => CreateSamplerYcbcrConversionKHR_0(device, pCreateInfo, pAllocator, pYcbcrConversion);
	private delegate void CreateSamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
	private static IntPtr CreateSamplerYcbcrConversionKHRPointer;
	private static CreateSamplerYcbcrConversionKHRDelegate_0 CreateSamplerYcbcrConversionKHR_0;
	[Obsolete("Use DestroySamplerYcbcrConversion")]
	public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator) => DestroySamplerYcbcrConversionKHR_0(device, ycbcrConversion, pAllocator);
	private delegate void DestroySamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroySamplerYcbcrConversionKHRPointer;
	private static DestroySamplerYcbcrConversionKHRDelegate_0 DestroySamplerYcbcrConversionKHR_0;
	[Obsolete("Use BindBufferMemory2")]
	public static void BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos) => BindBufferMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate void BindBufferMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
	private static IntPtr BindBufferMemory2KHRPointer;
	private static BindBufferMemory2KHRDelegate_0 BindBufferMemory2KHR_0;
	[Obsolete("Use BindImageMemory2")]
	public static void BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos) => BindImageMemory2KHR_0(device, bindInfoCount, pBindInfos);
	private delegate void BindImageMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
	private static IntPtr BindImageMemory2KHRPointer;
	private static BindImageMemory2KHRDelegate_0 BindImageMemory2KHR_0;
	public static VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties) => GetImageDrmFormatModifierPropertiesEXT_0(device, image, pProperties);
	private delegate VkResult GetImageDrmFormatModifierPropertiesEXTDelegate_0(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties);
	private static IntPtr GetImageDrmFormatModifierPropertiesEXTPointer;
	private static GetImageDrmFormatModifierPropertiesEXTDelegate_0 GetImageDrmFormatModifierPropertiesEXT_0;
	public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache) => CreateValidationCacheEXT_0(device, pCreateInfo, pAllocator, pValidationCache);
	private delegate VkResult CreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);
	private static IntPtr CreateValidationCacheEXTPointer;
	private static CreateValidationCacheEXTDelegate_0 CreateValidationCacheEXT_0;
	public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator) => DestroyValidationCacheEXT_0(device, validationCache, pAllocator);
	private delegate void DestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyValidationCacheEXTPointer;
	private static DestroyValidationCacheEXTDelegate_0 DestroyValidationCacheEXT_0;
	public static VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches) => MergeValidationCachesEXT_0(device, dstCache, srcCacheCount, pSrcCaches);
	private delegate VkResult MergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches);
	private static IntPtr MergeValidationCachesEXTPointer;
	private static MergeValidationCachesEXTDelegate_0 MergeValidationCachesEXT_0;
	public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData) => GetValidationCacheDataEXT_0(device, validationCache, pDataSize, pData);
	private delegate VkResult GetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData);
	private static IntPtr GetValidationCacheDataEXTPointer;
	private static GetValidationCacheDataEXTDelegate_0 GetValidationCacheDataEXT_0;
	public static void CommandBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => CommandBindShadingRateImageNV_0(commandBuffer, imageView, imageLayout);
	private delegate void CommandBindShadingRateImageNVDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
	private static IntPtr CommandBindShadingRateImageNVPointer;
	private static CommandBindShadingRateImageNVDelegate_0 CommandBindShadingRateImageNV_0;
	public static void CommandSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes) => CommandSetViewportShadingRatePaletteNV_0(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
	private delegate void CommandSetViewportShadingRatePaletteNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes);
	private static IntPtr CommandSetViewportShadingRatePaletteNVPointer;
	private static CommandSetViewportShadingRatePaletteNVDelegate_0 CommandSetViewportShadingRatePaletteNV_0;
	public static void CommandSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders) => CommandSetCoarseSampleOrderNV_0(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
	private delegate void CommandSetCoarseSampleOrderNVDelegate_0(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
	private static IntPtr CommandSetCoarseSampleOrderNVPointer;
	private static CommandSetCoarseSampleOrderNVDelegate_0 CommandSetCoarseSampleOrderNV_0;
	public static VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure) => CreateAccelerationStructureNV_0(device, pCreateInfo, pAllocator, pAccelerationStructure);
	private delegate VkResult CreateAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure);
	private static IntPtr CreateAccelerationStructureNVPointer;
	private static CreateAccelerationStructureNVDelegate_0 CreateAccelerationStructureNV_0;
	public static void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator) => DestroyAccelerationStructureNV_0(device, accelerationStructure, pAllocator);
	private delegate void DestroyAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator);
	private static IntPtr DestroyAccelerationStructureNVPointer;
	private static DestroyAccelerationStructureNVDelegate_0 DestroyAccelerationStructureNV_0;
	public static void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements) => GetAccelerationStructureMemoryRequirementsNV_0(device, pInfo, pMemoryRequirements);
	private delegate void GetAccelerationStructureMemoryRequirementsNVDelegate_0(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements);
	private static IntPtr GetAccelerationStructureMemoryRequirementsNVPointer;
	private static GetAccelerationStructureMemoryRequirementsNVDelegate_0 GetAccelerationStructureMemoryRequirementsNV_0;
	public static VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos) => BindAccelerationStructureMemoryNV_0(device, bindInfoCount, pBindInfos);
	private delegate VkResult BindAccelerationStructureMemoryNVDelegate_0(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
	private static IntPtr BindAccelerationStructureMemoryNVPointer;
	private static BindAccelerationStructureMemoryNVDelegate_0 BindAccelerationStructureMemoryNV_0;
	public static void CommandBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset) => CommandBuildAccelerationStructureNV_0(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
	private delegate void CommandBuildAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset);
	private static IntPtr CommandBuildAccelerationStructureNVPointer;
	private static CommandBuildAccelerationStructureNVDelegate_0 CommandBuildAccelerationStructureNV_0;
	public static void CommandCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeNV mode) => CommandCopyAccelerationStructureNV_0(commandBuffer, dst, src, mode);
	private delegate void CommandCopyAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeNV mode);
	private static IntPtr CommandCopyAccelerationStructureNVPointer;
	private static CommandCopyAccelerationStructureNVDelegate_0 CommandCopyAccelerationStructureNV_0;
	public static void CommandTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth) => CommandTraceRaysNV_0(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
	private delegate void CommandTraceRaysNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth);
	private static IntPtr CommandTraceRaysNVPointer;
	private static CommandTraceRaysNVDelegate_0 CommandTraceRaysNV_0;
	public static VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => CreateRayTracingPipelinesNV_0(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult CreateRayTracingPipelinesNVDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr CreateRayTracingPipelinesNVPointer;
	private static CreateRayTracingPipelinesNVDelegate_0 CreateRayTracingPipelinesNV_0;
	public static VkResult GetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData) => GetRayTracingShaderGroupHandlesNV_0(device, pipeline, firstGroup, groupCount, dataSize, pData);
	private delegate VkResult GetRayTracingShaderGroupHandlesNVDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData);
	private static IntPtr GetRayTracingShaderGroupHandlesNVPointer;
	private static GetRayTracingShaderGroupHandlesNVDelegate_0 GetRayTracingShaderGroupHandlesNV_0;
	public static VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData) => GetAccelerationStructureHandleNV_0(device, accelerationStructure, dataSize, pData);
	private delegate VkResult GetAccelerationStructureHandleNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData);
	private static IntPtr GetAccelerationStructureHandleNVPointer;
	private static GetAccelerationStructureHandleNVDelegate_0 GetAccelerationStructureHandleNV_0;
	public static void CommandWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery) => CommandWriteAccelerationStructuresPropertiesNV_0(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
	private delegate void CommandWriteAccelerationStructuresPropertiesNVDelegate_0(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
	private static IntPtr CommandWriteAccelerationStructuresPropertiesNVPointer;
	private static CommandWriteAccelerationStructuresPropertiesNVDelegate_0 CommandWriteAccelerationStructuresPropertiesNV_0;
	public static VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader) => CompileDeferredNV_0(device, pipeline, shader);
	private delegate VkResult CompileDeferredNVDelegate_0(VkDevice device, VkPipeline pipeline, uint shader);
	private static IntPtr CompileDeferredNVPointer;
	private static CompileDeferredNVDelegate_0 CompileDeferredNV_0;
	[Obsolete("Use GetDescriptorSetLayoutSupport")]
	public static void GetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport) => GetDescriptorSetLayoutSupportKHR_0(device, pCreateInfo, pSupport);
	private delegate void GetDescriptorSetLayoutSupportKHRDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
	private static IntPtr GetDescriptorSetLayoutSupportKHRPointer;
	private static GetDescriptorSetLayoutSupportKHRDelegate_0 GetDescriptorSetLayoutSupportKHR_0;
	public static void CommandDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr CommandDrawIndirectCountKHRPointer;
	private static CommandDrawIndirectCountKHRDelegate_0 CommandDrawIndirectCountKHR_0;
	public static void CommandDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr CommandDrawIndexedIndirectCountKHRPointer;
	private static CommandDrawIndexedIndirectCountKHRDelegate_0 CommandDrawIndexedIndirectCountKHR_0;
	public static VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) => GetMemoryHostPointerPropertiesEXT_0(device, handleType, pHostPointer, pMemoryHostPointerProperties);
	private delegate VkResult GetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
	private static IntPtr GetMemoryHostPointerPropertiesEXTPointer;
	private static GetMemoryHostPointerPropertiesEXTDelegate_0 GetMemoryHostPointerPropertiesEXT_0;
	public static void CommandWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker) => CommandWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
	private delegate void CommandWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker);
	private static IntPtr CommandWriteBufferMarkerAMDPointer;
	private static CommandWriteBufferMarkerAMDDelegate_0 CommandWriteBufferMarkerAMD_0;
	public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains) => GetPhysicalDeviceCalibrateableTimeDomainsEXT_0(physicalDevice, pTimeDomainCount, pTimeDomains);
	private delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
	private static IntPtr GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer;
	private static GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0 GetPhysicalDeviceCalibrateableTimeDomainsEXT_0;
	public static VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation) => GetCalibratedTimestampsEXT_0(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
	private delegate VkResult GetCalibratedTimestampsEXTDelegate_0(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
	private static IntPtr GetCalibratedTimestampsEXTPointer;
	private static GetCalibratedTimestampsEXTDelegate_0 GetCalibratedTimestampsEXT_0;
	public static void CommandDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask) => CommandDrawMeshTasksNV_0(commandBuffer, taskCount, firstTask);
	private delegate void CommandDrawMeshTasksNVDelegate_0(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
	private static IntPtr CommandDrawMeshTasksNVPointer;
	private static CommandDrawMeshTasksNVDelegate_0 CommandDrawMeshTasksNV_0;
	public static void CommandDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawMeshTasksIndirectNV_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawMeshTasksIndirectNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static IntPtr CommandDrawMeshTasksIndirectNVPointer;
	private static CommandDrawMeshTasksIndirectNVDelegate_0 CommandDrawMeshTasksIndirectNV_0;
	public static void CommandDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawMeshTasksIndirectCountNV_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawMeshTasksIndirectCountNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static IntPtr CommandDrawMeshTasksIndirectCountNVPointer;
	private static CommandDrawMeshTasksIndirectCountNVDelegate_0 CommandDrawMeshTasksIndirectCountNV_0;
	public static void CommandSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors) => CommandSetExclusiveScissorNV_0(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
	private delegate void CommandSetExclusiveScissorNVDelegate_0(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors);
	private static IntPtr CommandSetExclusiveScissorNVPointer;
	private static CommandSetExclusiveScissorNVDelegate_0 CommandSetExclusiveScissorNV_0;
	public static void CommandSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker) => CommandSetCheckpointNV_0(commandBuffer, pCheckpointMarker);
	private delegate void CommandSetCheckpointNVDelegate_0(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
	private static IntPtr CommandSetCheckpointNVPointer;
	private static CommandSetCheckpointNVDelegate_0 CommandSetCheckpointNV_0;
	public static void GetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData) => GetQueueCheckpointDataNV_0(queue, pCheckpointDataCount, pCheckpointData);
	private delegate void GetQueueCheckpointDataNVDelegate_0(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);
	private static IntPtr GetQueueCheckpointDataNVPointer;
	private static GetQueueCheckpointDataNVDelegate_0 GetQueueCheckpointDataNV_0;
	public static VkResult GetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, ulong* pValue) => GetSemaphoreCounterValueKHR_0(device, semaphore, pValue);
	private delegate VkResult GetSemaphoreCounterValueKHRDelegate_0(VkDevice device, VkSemaphore semaphore, ulong* pValue);
	private static IntPtr GetSemaphoreCounterValueKHRPointer;
	private static GetSemaphoreCounterValueKHRDelegate_0 GetSemaphoreCounterValueKHR_0;
	public static VkResult WaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfoKHR* pWaitInfo, ulong timeout) => WaitSemaphoresKHR_0(device, pWaitInfo, timeout);
	private delegate VkResult WaitSemaphoresKHRDelegate_0(VkDevice device, VkSemaphoreWaitInfoKHR* pWaitInfo, ulong timeout);
	private static IntPtr WaitSemaphoresKHRPointer;
	private static WaitSemaphoresKHRDelegate_0 WaitSemaphoresKHR_0;
	public static VkResult SignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfoKHR* pSignalInfo) => SignalSemaphoreKHR_0(device, pSignalInfo);
	private delegate VkResult SignalSemaphoreKHRDelegate_0(VkDevice device, VkSemaphoreSignalInfoKHR* pSignalInfo);
	private static IntPtr SignalSemaphoreKHRPointer;
	private static SignalSemaphoreKHRDelegate_0 SignalSemaphoreKHR_0;
	public static VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo) => InitializePerformanceApiINTEL_0(device, pInitializeInfo);
	private delegate VkResult InitializePerformanceApiINTELDelegate_0(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo);
	private static IntPtr InitializePerformanceApiINTELPointer;
	private static InitializePerformanceApiINTELDelegate_0 InitializePerformanceApiINTEL_0;
	public static void UninitializePerformanceApiINTEL(VkDevice device) => UninitializePerformanceApiINTEL_0(device);
	private delegate void UninitializePerformanceApiINTELDelegate_0(VkDevice device);
	private static IntPtr UninitializePerformanceApiINTELPointer;
	private static UninitializePerformanceApiINTELDelegate_0 UninitializePerformanceApiINTEL_0;
	public static VkResult CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo) => CommandSetPerformanceMarkerINTEL_0(commandBuffer, pMarkerInfo);
	private delegate VkResult CommandSetPerformanceMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo);
	private static IntPtr CommandSetPerformanceMarkerINTELPointer;
	private static CommandSetPerformanceMarkerINTELDelegate_0 CommandSetPerformanceMarkerINTEL_0;
	public static VkResult CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo) => CommandSetPerformanceStreamMarkerINTEL_0(commandBuffer, pMarkerInfo);
	private delegate VkResult CommandSetPerformanceStreamMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);
	private static IntPtr CommandSetPerformanceStreamMarkerINTELPointer;
	private static CommandSetPerformanceStreamMarkerINTELDelegate_0 CommandSetPerformanceStreamMarkerINTEL_0;
	public static VkResult CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo) => CommandSetPerformanceOverrideINTEL_0(commandBuffer, pOverrideInfo);
	private delegate VkResult CommandSetPerformanceOverrideINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo);
	private static IntPtr CommandSetPerformanceOverrideINTELPointer;
	private static CommandSetPerformanceOverrideINTELDelegate_0 CommandSetPerformanceOverrideINTEL_0;
	public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration) => AcquirePerformanceConfigurationINTEL_0(device, pAcquireInfo, pConfiguration);
	private delegate VkResult AcquirePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration);
	private static IntPtr AcquirePerformanceConfigurationINTELPointer;
	private static AcquirePerformanceConfigurationINTELDelegate_0 AcquirePerformanceConfigurationINTEL_0;
	public static VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration) => ReleasePerformanceConfigurationINTEL_0(device, configuration);
	private delegate VkResult ReleasePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationINTEL configuration);
	private static IntPtr ReleasePerformanceConfigurationINTELPointer;
	private static ReleasePerformanceConfigurationINTELDelegate_0 ReleasePerformanceConfigurationINTEL_0;
	public static VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration) => QueueSetPerformanceConfigurationINTEL_0(queue, configuration);
	private delegate VkResult QueueSetPerformanceConfigurationINTELDelegate_0(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
	private static IntPtr QueueSetPerformanceConfigurationINTELPointer;
	private static QueueSetPerformanceConfigurationINTELDelegate_0 QueueSetPerformanceConfigurationINTEL_0;
	public static VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue) => GetPerformanceParameterINTEL_0(device, parameter, pValue);
	private delegate VkResult GetPerformanceParameterINTELDelegate_0(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue);
	private static IntPtr GetPerformanceParameterINTELPointer;
	private static GetPerformanceParameterINTELDelegate_0 GetPerformanceParameterINTEL_0;
	public static void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable) => SetLocalDimmingAMD_0(device, swapChain, localDimmingEnable);
	private delegate void SetLocalDimmingAMDDelegate_0(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
	private static IntPtr SetLocalDimmingAMDPointer;
	private static SetLocalDimmingAMDDelegate_0 SetLocalDimmingAMD_0;
	[Obsolete("Use GetBufferDeviceAddressKHR")]
	public static void GetBufferDeviceAddressEXT(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => GetBufferDeviceAddressEXT_0(device, pInfo);
	private delegate void GetBufferDeviceAddressEXTDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr GetBufferDeviceAddressEXTPointer;
	private static GetBufferDeviceAddressEXTDelegate_0 GetBufferDeviceAddressEXT_0;
	public static VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties) => GetPhysicalDeviceToolPropertiesEXT_0(physicalDevice, pToolCount, pToolProperties);
	private delegate VkResult GetPhysicalDeviceToolPropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);
	private static IntPtr GetPhysicalDeviceToolPropertiesEXTPointer;
	private static GetPhysicalDeviceToolPropertiesEXTDelegate_0 GetPhysicalDeviceToolPropertiesEXT_0;
	public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties) => GetPhysicalDeviceCooperativeMatrixPropertiesNV_0(physicalDevice, pPropertyCount, pProperties);
	private delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);
	private static IntPtr GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer;
	private static GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0 GetPhysicalDeviceCooperativeMatrixPropertiesNV_0;
	public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations) => GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0(physicalDevice, pCombinationCount, pCombinations);
	private delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);
	private static IntPtr GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer;
	private static GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0 GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0;
	public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_0(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
	private delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
	private static IntPtr GetPhysicalDeviceSurfacePresentModes2EXTPointer;
	private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0 GetPhysicalDeviceSurfacePresentModes2EXT_0;
	public static VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => AcquireFullScreenExclusiveModeEXT_0(device, swapchain);
	private delegate VkResult AcquireFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr AcquireFullScreenExclusiveModeEXTPointer;
	private static AcquireFullScreenExclusiveModeEXTDelegate_0 AcquireFullScreenExclusiveModeEXT_0;
	public static VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => ReleaseFullScreenExclusiveModeEXT_0(device, swapchain);
	private delegate VkResult ReleaseFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static IntPtr ReleaseFullScreenExclusiveModeEXTPointer;
	private static ReleaseFullScreenExclusiveModeEXTDelegate_0 ReleaseFullScreenExclusiveModeEXT_0;
	public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes) => GetDeviceGroupSurfacePresentModes2EXT_0(device, pSurfaceInfo, pModes);
	private delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr GetDeviceGroupSurfacePresentModes2EXTPointer;
	private static GetDeviceGroupSurfacePresentModes2EXTDelegate_0 GetDeviceGroupSurfacePresentModes2EXT_0;
	public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes) => GetDeviceGroupSurfacePresentModes2EXT_0(device, pSurfaceInfo, pModes);
	private delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);
	private static IntPtr GetDeviceGroupSurfacePresentModes2EXTPointer;
	private static GetDeviceGroupSurfacePresentModes2EXTDelegate_0 GetDeviceGroupSurfacePresentModes2EXT_0;
	public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface) => CreateHeadlessSurfaceEXT_0(instance, pCreateInfo, pAllocator, pSurface);
	private delegate VkResult CreateHeadlessSurfaceEXTDelegate_0(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
	private static IntPtr CreateHeadlessSurfaceEXTPointer;
	private static CreateHeadlessSurfaceEXTDelegate_0 CreateHeadlessSurfaceEXT_0;
	public static VkDeviceAddress GetBufferDeviceAddressKHR(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => GetBufferDeviceAddressKHR_0(device, pInfo);
	private delegate VkDeviceAddress GetBufferDeviceAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr GetBufferDeviceAddressKHRPointer;
	private static GetBufferDeviceAddressKHRDelegate_0 GetBufferDeviceAddressKHR_0;
	public static ulong GetBufferOpaqueCaptureAddressKHR(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo) => GetBufferOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate ulong GetBufferOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfoKHR* pInfo);
	private static IntPtr GetBufferOpaqueCaptureAddressKHRPointer;
	private static GetBufferOpaqueCaptureAddressKHRDelegate_0 GetBufferOpaqueCaptureAddressKHR_0;
	public static ulong GetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfoKHR* pInfo) => GetDeviceMemoryOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate ulong GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfoKHR* pInfo);
	private static IntPtr GetDeviceMemoryOpaqueCaptureAddressKHRPointer;
	private static GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0 GetDeviceMemoryOpaqueCaptureAddressKHR_0;
	public static void CommandSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern) => CommandSetLineStippleEXT_0(commandBuffer, lineStippleFactor, lineStipplePattern);
	private delegate void CommandSetLineStippleEXTDelegate_0(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
	private static IntPtr CommandSetLineStippleEXTPointer;
	private static CommandSetLineStippleEXTDelegate_0 CommandSetLineStippleEXT_0;
	public static void ResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount) => ResetQueryPoolEXT_0(device, queryPool, firstQuery, queryCount);
	private delegate void ResetQueryPoolEXTDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static IntPtr ResetQueryPoolEXTPointer;
	private static ResetQueryPoolEXTDelegate_0 ResetQueryPoolEXT_0;
	public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties) => GetPipelineExecutablePropertiesKHR_0(device, pPipelineInfo, pExecutableCount, pProperties);
	private delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_0(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);
	private static IntPtr GetPipelineExecutablePropertiesKHRPointer;
	private static GetPipelineExecutablePropertiesKHRDelegate_0 GetPipelineExecutablePropertiesKHR_0;
	public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics) => GetPipelineExecutableStatisticsKHR_0(device, pExecutableInfo, pStatisticCount, pStatistics);
	private delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);
	private static IntPtr GetPipelineExecutableStatisticsKHRPointer;
	private static GetPipelineExecutableStatisticsKHRDelegate_0 GetPipelineExecutableStatisticsKHR_0;
	public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_0(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
	private delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);
	private static IntPtr GetPipelineExecutableInternalRepresentationsKHRPointer;
	private static GetPipelineExecutableInternalRepresentationsKHRDelegate_0 GetPipelineExecutableInternalRepresentationsKHR_0;
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
		GetInstanceProcedureAddressPointer = VulkanLibrary.GetFunctionPointer("GetInstanceProcedureAddress");
		GetInstanceProcedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetInstanceProcedureAddressDelegate_0>(GetInstanceProcedureAddressPointer);
		EnumerateInstanceExtensionPropertiesPointer = VulkanLibrary.GetFunctionPointer("EnumerateInstanceExtensionProperties");
		EnumerateInstanceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_0>(EnumerateInstanceExtensionPropertiesPointer);
		EnumerateInstanceLayerPropertiesPointer = VulkanLibrary.GetFunctionPointer("EnumerateInstanceLayerProperties");
		EnumerateInstanceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_0>(EnumerateInstanceLayerPropertiesPointer);
	}
	public static void InitialiseInstanceMethods(VkInstance instance)
	{
		DestroyInstancePointer = GetInstanceProcedureAddress(instance, "DestroyInstance");
		if (DestroyInstancePointer != IntPtr.Zero)
		{
			DestroyInstance_0 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_0>(DestroyInstancePointer);
		}
		EnumeratePhysicalDevicesPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDevices");
		if (EnumeratePhysicalDevicesPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDevices_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_0>(EnumeratePhysicalDevicesPointer);
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
		}
		DestroyDevicePointer = GetInstanceProcedureAddress(instance, "DestroyDevice");
		if (DestroyDevicePointer != IntPtr.Zero)
		{
			DestroyDevice_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_0>(DestroyDevicePointer);
		}
		EnumerateDeviceExtensionPropertiesPointer = GetInstanceProcedureAddress(instance, "EnumerateDeviceExtensionProperties");
		if (EnumerateDeviceExtensionPropertiesPointer != IntPtr.Zero)
		{
			EnumerateDeviceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_0>(EnumerateDeviceExtensionPropertiesPointer);
		}
		EnumerateDeviceLayerPropertiesPointer = GetInstanceProcedureAddress(instance, "EnumerateDeviceLayerProperties");
		if (EnumerateDeviceLayerPropertiesPointer != IntPtr.Zero)
		{
			EnumerateDeviceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_0>(EnumerateDeviceLayerPropertiesPointer);
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
		}
		FreeMemoryPointer = GetInstanceProcedureAddress(instance, "FreeMemory");
		if (FreeMemoryPointer != IntPtr.Zero)
		{
			FreeMemory_0 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_0>(FreeMemoryPointer);
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
		}
		GetPhysicalDeviceSparseImageFormatPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSparseImageFormatProperties");
		if (GetPhysicalDeviceSparseImageFormatPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0>(GetPhysicalDeviceSparseImageFormatPropertiesPointer);
		}
		QueueBindSparsePointer = GetInstanceProcedureAddress(instance, "QueueBindSparse");
		if (QueueBindSparsePointer != IntPtr.Zero)
		{
			QueueBindSparse_0 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_0>(QueueBindSparsePointer);
		}
		CreateFencePointer = GetInstanceProcedureAddress(instance, "CreateFence");
		if (CreateFencePointer != IntPtr.Zero)
		{
			CreateFence_0 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_0>(CreateFencePointer);
		}
		DestroyFencePointer = GetInstanceProcedureAddress(instance, "DestroyFence");
		if (DestroyFencePointer != IntPtr.Zero)
		{
			DestroyFence_0 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_0>(DestroyFencePointer);
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
		}
		DestroySemaphorePointer = GetInstanceProcedureAddress(instance, "DestroySemaphore");
		if (DestroySemaphorePointer != IntPtr.Zero)
		{
			DestroySemaphore_0 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_0>(DestroySemaphorePointer);
		}
		CreateEventPointer = GetInstanceProcedureAddress(instance, "CreateEvent");
		if (CreateEventPointer != IntPtr.Zero)
		{
			CreateEvent_0 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_0>(CreateEventPointer);
		}
		DestroyEventPointer = GetInstanceProcedureAddress(instance, "DestroyEvent");
		if (DestroyEventPointer != IntPtr.Zero)
		{
			DestroyEvent_0 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_0>(DestroyEventPointer);
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
		}
		DestroyQueryPoolPointer = GetInstanceProcedureAddress(instance, "DestroyQueryPool");
		if (DestroyQueryPoolPointer != IntPtr.Zero)
		{
			DestroyQueryPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_0>(DestroyQueryPoolPointer);
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
		}
		DestroyBufferPointer = GetInstanceProcedureAddress(instance, "DestroyBuffer");
		if (DestroyBufferPointer != IntPtr.Zero)
		{
			DestroyBuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_0>(DestroyBufferPointer);
		}
		CreateBufferViewPointer = GetInstanceProcedureAddress(instance, "CreateBufferView");
		if (CreateBufferViewPointer != IntPtr.Zero)
		{
			CreateBufferView_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_0>(CreateBufferViewPointer);
		}
		DestroyBufferViewPointer = GetInstanceProcedureAddress(instance, "DestroyBufferView");
		if (DestroyBufferViewPointer != IntPtr.Zero)
		{
			DestroyBufferView_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_0>(DestroyBufferViewPointer);
		}
		CreateImagePointer = GetInstanceProcedureAddress(instance, "CreateImage");
		if (CreateImagePointer != IntPtr.Zero)
		{
			CreateImage_0 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_0>(CreateImagePointer);
		}
		DestroyImagePointer = GetInstanceProcedureAddress(instance, "DestroyImage");
		if (DestroyImagePointer != IntPtr.Zero)
		{
			DestroyImage_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_0>(DestroyImagePointer);
		}
		GetImageSubresourceLayoutPointer = GetInstanceProcedureAddress(instance, "GetImageSubresourceLayout");
		if (GetImageSubresourceLayoutPointer != IntPtr.Zero)
		{
			GetImageSubresourceLayout_0 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_0>(GetImageSubresourceLayoutPointer);
		}
		CreateImageViewPointer = GetInstanceProcedureAddress(instance, "CreateImageView");
		if (CreateImageViewPointer != IntPtr.Zero)
		{
			CreateImageView_0 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_0>(CreateImageViewPointer);
		}
		DestroyImageViewPointer = GetInstanceProcedureAddress(instance, "DestroyImageView");
		if (DestroyImageViewPointer != IntPtr.Zero)
		{
			DestroyImageView_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_0>(DestroyImageViewPointer);
		}
		CreateShaderModulePointer = GetInstanceProcedureAddress(instance, "CreateShaderModule");
		if (CreateShaderModulePointer != IntPtr.Zero)
		{
			CreateShaderModule_0 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_0>(CreateShaderModulePointer);
		}
		DestroyShaderModulePointer = GetInstanceProcedureAddress(instance, "DestroyShaderModule");
		if (DestroyShaderModulePointer != IntPtr.Zero)
		{
			DestroyShaderModule_0 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_0>(DestroyShaderModulePointer);
		}
		CreatePipelineCachePointer = GetInstanceProcedureAddress(instance, "CreatePipelineCache");
		if (CreatePipelineCachePointer != IntPtr.Zero)
		{
			CreatePipelineCache_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_0>(CreatePipelineCachePointer);
		}
		DestroyPipelineCachePointer = GetInstanceProcedureAddress(instance, "DestroyPipelineCache");
		if (DestroyPipelineCachePointer != IntPtr.Zero)
		{
			DestroyPipelineCache_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_0>(DestroyPipelineCachePointer);
		}
		GetPipelineCacheDataPointer = GetInstanceProcedureAddress(instance, "GetPipelineCacheData");
		if (GetPipelineCacheDataPointer != IntPtr.Zero)
		{
			GetPipelineCacheData_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_0>(GetPipelineCacheDataPointer);
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
		}
		CreateComputePipelinesPointer = GetInstanceProcedureAddress(instance, "CreateComputePipelines");
		if (CreateComputePipelinesPointer != IntPtr.Zero)
		{
			CreateComputePipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_0>(CreateComputePipelinesPointer);
		}
		DestroyPipelinePointer = GetInstanceProcedureAddress(instance, "DestroyPipeline");
		if (DestroyPipelinePointer != IntPtr.Zero)
		{
			DestroyPipeline_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_0>(DestroyPipelinePointer);
		}
		CreatePipelineLayoutPointer = GetInstanceProcedureAddress(instance, "CreatePipelineLayout");
		if (CreatePipelineLayoutPointer != IntPtr.Zero)
		{
			CreatePipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_0>(CreatePipelineLayoutPointer);
		}
		DestroyPipelineLayoutPointer = GetInstanceProcedureAddress(instance, "DestroyPipelineLayout");
		if (DestroyPipelineLayoutPointer != IntPtr.Zero)
		{
			DestroyPipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_0>(DestroyPipelineLayoutPointer);
		}
		CreateSamplerPointer = GetInstanceProcedureAddress(instance, "CreateSampler");
		if (CreateSamplerPointer != IntPtr.Zero)
		{
			CreateSampler_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_0>(CreateSamplerPointer);
		}
		DestroySamplerPointer = GetInstanceProcedureAddress(instance, "DestroySampler");
		if (DestroySamplerPointer != IntPtr.Zero)
		{
			DestroySampler_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_0>(DestroySamplerPointer);
		}
		CreateDescriptorSetLayoutPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorSetLayout");
		if (CreateDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			CreateDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_0>(CreateDescriptorSetLayoutPointer);
		}
		DestroyDescriptorSetLayoutPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorSetLayout");
		if (DestroyDescriptorSetLayoutPointer != IntPtr.Zero)
		{
			DestroyDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_0>(DestroyDescriptorSetLayoutPointer);
		}
		CreateDescriptorPoolPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorPool");
		if (CreateDescriptorPoolPointer != IntPtr.Zero)
		{
			CreateDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_0>(CreateDescriptorPoolPointer);
		}
		DestroyDescriptorPoolPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorPool");
		if (DestroyDescriptorPoolPointer != IntPtr.Zero)
		{
			DestroyDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_0>(DestroyDescriptorPoolPointer);
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
		}
		DestroyFramebufferPointer = GetInstanceProcedureAddress(instance, "DestroyFramebuffer");
		if (DestroyFramebufferPointer != IntPtr.Zero)
		{
			DestroyFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_0>(DestroyFramebufferPointer);
		}
		CreateRenderPassPointer = GetInstanceProcedureAddress(instance, "CreateRenderPass");
		if (CreateRenderPassPointer != IntPtr.Zero)
		{
			CreateRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_0>(CreateRenderPassPointer);
		}
		DestroyRenderPassPointer = GetInstanceProcedureAddress(instance, "DestroyRenderPass");
		if (DestroyRenderPassPointer != IntPtr.Zero)
		{
			DestroyRenderPass_0 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_0>(DestroyRenderPassPointer);
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
		}
		DestroyCommandPoolPointer = GetInstanceProcedureAddress(instance, "DestroyCommandPool");
		if (DestroyCommandPoolPointer != IntPtr.Zero)
		{
			DestroyCommandPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_0>(DestroyCommandPoolPointer);
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
		}
		CommandClearDepthStencilImagePointer = GetInstanceProcedureAddress(instance, "CommandClearDepthStencilImage");
		if (CommandClearDepthStencilImagePointer != IntPtr.Zero)
		{
			CommandClearDepthStencilImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_0>(CommandClearDepthStencilImagePointer);
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
		EnumerateInstanceVersionPointer = GetInstanceProcedureAddress(instance, "EnumerateInstanceVersion");
		if (EnumerateInstanceVersionPointer != IntPtr.Zero)
		{
			EnumerateInstanceVersion_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceVersionDelegate_0>(EnumerateInstanceVersionPointer);
		}
		BindBufferMemory2Pointer = GetInstanceProcedureAddress(instance, "BindBufferMemory2");
		if (BindBufferMemory2Pointer != IntPtr.Zero)
		{
			BindBufferMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2Delegate_0>(BindBufferMemory2Pointer);
		}
		BindImageMemory2Pointer = GetInstanceProcedureAddress(instance, "BindImageMemory2");
		if (BindImageMemory2Pointer != IntPtr.Zero)
		{
			BindImageMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2Delegate_0>(BindImageMemory2Pointer);
		}
		GetDeviceGroupPeerMemoryFeaturesPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPeerMemoryFeatures");
		if (GetDeviceGroupPeerMemoryFeaturesPointer != IntPtr.Zero)
		{
			GetDeviceGroupPeerMemoryFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesDelegate_0>(GetDeviceGroupPeerMemoryFeaturesPointer);
		}
		CommandSetDeviceMaskPointer = GetInstanceProcedureAddress(instance, "CommandSetDeviceMask");
		if (CommandSetDeviceMaskPointer != IntPtr.Zero)
		{
			CommandSetDeviceMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskDelegate_0>(CommandSetDeviceMaskPointer);
		}
		CommandDispatchBasePointer = GetInstanceProcedureAddress(instance, "CommandDispatchBase");
		if (CommandDispatchBasePointer != IntPtr.Zero)
		{
			CommandDispatchBase_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseDelegate_0>(CommandDispatchBasePointer);
		}
		EnumeratePhysicalDeviceGroupsPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDeviceGroups");
		if (EnumeratePhysicalDeviceGroupsPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDeviceGroups_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsDelegate_0>(EnumeratePhysicalDeviceGroupsPointer);
		}
		GetImageMemoryRequirements2Pointer = GetInstanceProcedureAddress(instance, "GetImageMemoryRequirements2");
		if (GetImageMemoryRequirements2Pointer != IntPtr.Zero)
		{
			GetImageMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2Delegate_0>(GetImageMemoryRequirements2Pointer);
		}
		GetBufferMemoryRequirements2Pointer = GetInstanceProcedureAddress(instance, "GetBufferMemoryRequirements2");
		if (GetBufferMemoryRequirements2Pointer != IntPtr.Zero)
		{
			GetBufferMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2Delegate_0>(GetBufferMemoryRequirements2Pointer);
		}
		GetImageSparseMemoryRequirements2Pointer = GetInstanceProcedureAddress(instance, "GetImageSparseMemoryRequirements2");
		if (GetImageSparseMemoryRequirements2Pointer != IntPtr.Zero)
		{
			GetImageSparseMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_0>(GetImageSparseMemoryRequirements2Pointer);
		}
		GetPhysicalDeviceFeatures2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFeatures2");
		if (GetPhysicalDeviceFeatures2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFeatures2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2Delegate_0>(GetPhysicalDeviceFeatures2Pointer);
		}
		GetPhysicalDeviceProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceProperties2");
		if (GetPhysicalDeviceProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2Delegate_0>(GetPhysicalDeviceProperties2Pointer);
		}
		GetPhysicalDeviceFormatProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFormatProperties2");
		if (GetPhysicalDeviceFormatProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2Delegate_0>(GetPhysicalDeviceFormatProperties2Pointer);
		}
		GetPhysicalDeviceImageFormatProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceImageFormatProperties2");
		if (GetPhysicalDeviceImageFormatProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2Delegate_0>(GetPhysicalDeviceImageFormatProperties2Pointer);
		}
		GetPhysicalDeviceQueueFamilyProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceQueueFamilyProperties2");
		if (GetPhysicalDeviceQueueFamilyProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2Delegate_0>(GetPhysicalDeviceQueueFamilyProperties2Pointer);
		}
		GetPhysicalDeviceMemoryProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMemoryProperties2");
		if (GetPhysicalDeviceMemoryProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMemoryProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2Delegate_0>(GetPhysicalDeviceMemoryProperties2Pointer);
		}
		GetPhysicalDeviceSparseImageFormatProperties2Pointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSparseImageFormatProperties2");
		if (GetPhysicalDeviceSparseImageFormatProperties2Pointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_0>(GetPhysicalDeviceSparseImageFormatProperties2Pointer);
		}
		TrimCommandPoolPointer = GetInstanceProcedureAddress(instance, "TrimCommandPool");
		if (TrimCommandPoolPointer != IntPtr.Zero)
		{
			TrimCommandPool_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolDelegate_0>(TrimCommandPoolPointer);
		}
		GetDeviceQueue2Pointer = GetInstanceProcedureAddress(instance, "GetDeviceQueue2");
		if (GetDeviceQueue2Pointer != IntPtr.Zero)
		{
			GetDeviceQueue2_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueue2Delegate_0>(GetDeviceQueue2Pointer);
		}
		CreateSamplerYcbcrConversionPointer = GetInstanceProcedureAddress(instance, "CreateSamplerYcbcrConversion");
		if (CreateSamplerYcbcrConversionPointer != IntPtr.Zero)
		{
			CreateSamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_0>(CreateSamplerYcbcrConversionPointer);
		}
		DestroySamplerYcbcrConversionPointer = GetInstanceProcedureAddress(instance, "DestroySamplerYcbcrConversion");
		if (DestroySamplerYcbcrConversionPointer != IntPtr.Zero)
		{
			DestroySamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionDelegate_0>(DestroySamplerYcbcrConversionPointer);
		}
		CreateDescriptorUpdateTemplatePointer = GetInstanceProcedureAddress(instance, "CreateDescriptorUpdateTemplate");
		if (CreateDescriptorUpdateTemplatePointer != IntPtr.Zero)
		{
			CreateDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_0>(CreateDescriptorUpdateTemplatePointer);
		}
		DestroyDescriptorUpdateTemplatePointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorUpdateTemplate");
		if (DestroyDescriptorUpdateTemplatePointer != IntPtr.Zero)
		{
			DestroyDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateDelegate_0>(DestroyDescriptorUpdateTemplatePointer);
		}
		UpdateDescriptorSetWithTemplatePointer = GetInstanceProcedureAddress(instance, "UpdateDescriptorSetWithTemplate");
		if (UpdateDescriptorSetWithTemplatePointer != IntPtr.Zero)
		{
			UpdateDescriptorSetWithTemplate_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetWithTemplateDelegate_0>(UpdateDescriptorSetWithTemplatePointer);
		}
		GetPhysicalDeviceExternalBufferPropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalBufferProperties");
		if (GetPhysicalDeviceExternalBufferPropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalBufferProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesDelegate_0>(GetPhysicalDeviceExternalBufferPropertiesPointer);
		}
		GetPhysicalDeviceExternalFencePropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalFenceProperties");
		if (GetPhysicalDeviceExternalFencePropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalFenceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesDelegate_0>(GetPhysicalDeviceExternalFencePropertiesPointer);
		}
		GetPhysicalDeviceExternalSemaphorePropertiesPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalSemaphoreProperties");
		if (GetPhysicalDeviceExternalSemaphorePropertiesPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalSemaphoreProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0>(GetPhysicalDeviceExternalSemaphorePropertiesPointer);
		}
		GetDescriptorSetLayoutSupportPointer = GetInstanceProcedureAddress(instance, "GetDescriptorSetLayoutSupport");
		if (GetDescriptorSetLayoutSupportPointer != IntPtr.Zero)
		{
			GetDescriptorSetLayoutSupport_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportDelegate_0>(GetDescriptorSetLayoutSupportPointer);
		}
		DestroySurfaceKHRPointer = GetInstanceProcedureAddress(instance, "DestroySurfaceKHR");
		if (DestroySurfaceKHRPointer != IntPtr.Zero)
		{
			DestroySurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_0>(DestroySurfaceKHRPointer);
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
		}
		GetPhysicalDeviceSurfacePresentModesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfacePresentModesKHR");
		if (GetPhysicalDeviceSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_0>(GetPhysicalDeviceSurfacePresentModesKHRPointer);
		}
		CreateSwapchainKHRPointer = GetInstanceProcedureAddress(instance, "CreateSwapchainKHR");
		if (CreateSwapchainKHRPointer != IntPtr.Zero)
		{
			CreateSwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_0>(CreateSwapchainKHRPointer);
		}
		DestroySwapchainKHRPointer = GetInstanceProcedureAddress(instance, "DestroySwapchainKHR");
		if (DestroySwapchainKHRPointer != IntPtr.Zero)
		{
			DestroySwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_0>(DestroySwapchainKHRPointer);
		}
		GetSwapchainImagesKHRPointer = GetInstanceProcedureAddress(instance, "GetSwapchainImagesKHR");
		if (GetSwapchainImagesKHRPointer != IntPtr.Zero)
		{
			GetSwapchainImagesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_0>(GetSwapchainImagesKHRPointer);
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
		}
		GetDeviceGroupPresentCapabilitiesKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPresentCapabilitiesKHR");
		if (GetDeviceGroupPresentCapabilitiesKHRPointer != IntPtr.Zero)
		{
			GetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPresentCapabilitiesKHRDelegate_0>(GetDeviceGroupPresentCapabilitiesKHRPointer);
		}
		GetDeviceGroupSurfacePresentModesKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupSurfacePresentModesKHR");
		if (GetDeviceGroupSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			GetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModesKHRDelegate_0>(GetDeviceGroupSurfacePresentModesKHRPointer);
		}
		GetPhysicalDevicePresentRectanglesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDevicePresentRectanglesKHR");
		if (GetPhysicalDevicePresentRectanglesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_0>(GetPhysicalDevicePresentRectanglesKHRPointer);
		}
		AcquireNextImage2KHRPointer = GetInstanceProcedureAddress(instance, "AcquireNextImage2KHR");
		if (AcquireNextImage2KHRPointer != IntPtr.Zero)
		{
			AcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_0>(AcquireNextImage2KHRPointer);
		}
		GetPhysicalDeviceDisplayPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayPropertiesKHR");
		if (GetPhysicalDeviceDisplayPropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPropertiesKHRPointer);
		}
		GetPhysicalDeviceDisplayPlanePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayPlanePropertiesKHR");
		if (GetPhysicalDeviceDisplayPlanePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayPlanePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
		}
		GetDisplayPlaneSupportedDisplaysKHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayPlaneSupportedDisplaysKHR");
		if (GetDisplayPlaneSupportedDisplaysKHRPointer != IntPtr.Zero)
		{
			GetDisplayPlaneSupportedDisplaysKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_0>(GetDisplayPlaneSupportedDisplaysKHRPointer);
		}
		GetDisplayModePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayModePropertiesKHR");
		if (GetDisplayModePropertiesKHRPointer != IntPtr.Zero)
		{
			GetDisplayModePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_0>(GetDisplayModePropertiesKHRPointer);
		}
		CreateDisplayModeKHRPointer = GetInstanceProcedureAddress(instance, "CreateDisplayModeKHR");
		if (CreateDisplayModeKHRPointer != IntPtr.Zero)
		{
			CreateDisplayModeKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_0>(CreateDisplayModeKHRPointer);
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
		}
		CreateSharedSwapchainsKHRPointer = GetInstanceProcedureAddress(instance, "CreateSharedSwapchainsKHR");
		if (CreateSharedSwapchainsKHRPointer != IntPtr.Zero)
		{
			CreateSharedSwapchainsKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_0>(CreateSharedSwapchainsKHRPointer);
		}
		CreateXlibSurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateXlibSurfaceKHR");
		if (CreateXlibSurfaceKHRPointer != IntPtr.Zero)
		{
			CreateXlibSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_0>(CreateXlibSurfaceKHRPointer);
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
		}
		CreateWin32SurfaceKHRPointer = GetInstanceProcedureAddress(instance, "CreateWin32SurfaceKHR");
		if (CreateWin32SurfaceKHRPointer != IntPtr.Zero)
		{
			CreateWin32SurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_0>(CreateWin32SurfaceKHRPointer);
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
		}
		DestroyDebugReportCallbackEXTPointer = GetInstanceProcedureAddress(instance, "DestroyDebugReportCallbackEXT");
		if (DestroyDebugReportCallbackEXTPointer != IntPtr.Zero)
		{
			DestroyDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_0>(DestroyDebugReportCallbackEXTPointer);
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
		}
		DebugMarkerSetObjectNameEXTPointer = GetInstanceProcedureAddress(instance, "DebugMarkerSetObjectNameEXT");
		if (DebugMarkerSetObjectNameEXTPointer != IntPtr.Zero)
		{
			DebugMarkerSetObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_0>(DebugMarkerSetObjectNameEXTPointer);
		}
		CommandDebugMarkerBeginEXTPointer = GetInstanceProcedureAddress(instance, "CommandDebugMarkerBeginEXT");
		if (CommandDebugMarkerBeginEXTPointer != IntPtr.Zero)
		{
			CommandDebugMarkerBeginEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_0>(CommandDebugMarkerBeginEXTPointer);
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
		}
		CommandBindTransformFeedbackBuffersEXTPointer = GetInstanceProcedureAddress(instance, "CommandBindTransformFeedbackBuffersEXT");
		if (CommandBindTransformFeedbackBuffersEXTPointer != IntPtr.Zero)
		{
			CommandBindTransformFeedbackBuffersEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_0>(CommandBindTransformFeedbackBuffersEXTPointer);
		}
		CommandBeginTransformFeedbackEXTPointer = GetInstanceProcedureAddress(instance, "CommandBeginTransformFeedbackEXT");
		if (CommandBeginTransformFeedbackEXTPointer != IntPtr.Zero)
		{
			CommandBeginTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginTransformFeedbackEXTDelegate_0>(CommandBeginTransformFeedbackEXTPointer);
		}
		CommandEndTransformFeedbackEXTPointer = GetInstanceProcedureAddress(instance, "CommandEndTransformFeedbackEXT");
		if (CommandEndTransformFeedbackEXTPointer != IntPtr.Zero)
		{
			CommandEndTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndTransformFeedbackEXTDelegate_0>(CommandEndTransformFeedbackEXTPointer);
		}
		CommandBeginQueryIndexedEXTPointer = GetInstanceProcedureAddress(instance, "CommandBeginQueryIndexedEXT");
		if (CommandBeginQueryIndexedEXTPointer != IntPtr.Zero)
		{
			CommandBeginQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryIndexedEXTDelegate_0>(CommandBeginQueryIndexedEXTPointer);
		}
		CommandEndQueryIndexedEXTPointer = GetInstanceProcedureAddress(instance, "CommandEndQueryIndexedEXT");
		if (CommandEndQueryIndexedEXTPointer != IntPtr.Zero)
		{
			CommandEndQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryIndexedEXTDelegate_0>(CommandEndQueryIndexedEXTPointer);
		}
		CommandDrawIndirectByteCountEXTPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndirectByteCountEXT");
		if (CommandDrawIndirectByteCountEXTPointer != IntPtr.Zero)
		{
			CommandDrawIndirectByteCountEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectByteCountEXTDelegate_0>(CommandDrawIndirectByteCountEXTPointer);
		}
		GetImageViewHandleNVXPointer = GetInstanceProcedureAddress(instance, "GetImageViewHandleNVX");
		if (GetImageViewHandleNVXPointer != IntPtr.Zero)
		{
			GetImageViewHandleNVX_0 = Marshal.GetDelegateForFunctionPointer<GetImageViewHandleNVXDelegate_0>(GetImageViewHandleNVXPointer);
		}
		CommandDrawIndirectCountAMDPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndirectCountKHR");
		if (CommandDrawIndirectCountAMDPointer != IntPtr.Zero)
		{
			CommandDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountAMDDelegate_0>(CommandDrawIndirectCountAMDPointer);
		}
		CommandDrawIndexedIndirectCountAMDPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndexedIndirectCountKHR");
		if (CommandDrawIndexedIndirectCountAMDPointer != IntPtr.Zero)
		{
			CommandDrawIndexedIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountAMDDelegate_0>(CommandDrawIndexedIndirectCountAMDPointer);
		}
		GetShaderInfoAMDPointer = GetInstanceProcedureAddress(instance, "GetShaderInfoAMD");
		if (GetShaderInfoAMDPointer != IntPtr.Zero)
		{
			GetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_0>(GetShaderInfoAMDPointer);
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
		GetPhysicalDeviceFeatures2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFeatures2");
		if (GetPhysicalDeviceFeatures2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFeatures2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2KHRDelegate_0>(GetPhysicalDeviceFeatures2KHRPointer);
		}
		GetPhysicalDeviceProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceProperties2");
		if (GetPhysicalDeviceProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2KHRDelegate_0>(GetPhysicalDeviceProperties2KHRPointer);
		}
		GetPhysicalDeviceFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceFormatProperties2");
		if (GetPhysicalDeviceFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2KHRDelegate_0>(GetPhysicalDeviceFormatProperties2KHRPointer);
		}
		GetPhysicalDeviceImageFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceImageFormatProperties2");
		if (GetPhysicalDeviceImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2KHRDelegate_0>(GetPhysicalDeviceImageFormatProperties2KHRPointer);
		}
		GetPhysicalDeviceQueueFamilyProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceQueueFamilyProperties2");
		if (GetPhysicalDeviceQueueFamilyProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0>(GetPhysicalDeviceQueueFamilyProperties2KHRPointer);
		}
		GetPhysicalDeviceMemoryProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMemoryProperties2");
		if (GetPhysicalDeviceMemoryProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMemoryProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2KHRDelegate_0>(GetPhysicalDeviceMemoryProperties2KHRPointer);
		}
		GetPhysicalDeviceSparseImageFormatProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSparseImageFormatProperties2");
		if (GetPhysicalDeviceSparseImageFormatProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0>(GetPhysicalDeviceSparseImageFormatProperties2KHRPointer);
		}
		GetDeviceGroupPeerMemoryFeaturesKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPeerMemoryFeatures");
		if (GetDeviceGroupPeerMemoryFeaturesKHRPointer != IntPtr.Zero)
		{
			GetDeviceGroupPeerMemoryFeaturesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0>(GetDeviceGroupPeerMemoryFeaturesKHRPointer);
		}
		CommandSetDeviceMaskKHRPointer = GetInstanceProcedureAddress(instance, "CommandSetDeviceMask");
		if (CommandSetDeviceMaskKHRPointer != IntPtr.Zero)
		{
			CommandSetDeviceMaskKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskKHRDelegate_0>(CommandSetDeviceMaskKHRPointer);
		}
		CommandDispatchBaseKHRPointer = GetInstanceProcedureAddress(instance, "CommandDispatchBase");
		if (CommandDispatchBaseKHRPointer != IntPtr.Zero)
		{
			CommandDispatchBaseKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseKHRDelegate_0>(CommandDispatchBaseKHRPointer);
		}
		GetDeviceGroupPresentCapabilitiesKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupPresentCapabilitiesKHR");
		if (GetDeviceGroupPresentCapabilitiesKHRPointer != IntPtr.Zero)
		{
			GetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPresentCapabilitiesKHRDelegate_0>(GetDeviceGroupPresentCapabilitiesKHRPointer);
		}
		GetDeviceGroupSurfacePresentModesKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupSurfacePresentModesKHR");
		if (GetDeviceGroupSurfacePresentModesKHRPointer != IntPtr.Zero)
		{
			GetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModesKHRDelegate_0>(GetDeviceGroupSurfacePresentModesKHRPointer);
		}
		GetPhysicalDevicePresentRectanglesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDevicePresentRectanglesKHR");
		if (GetPhysicalDevicePresentRectanglesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_0>(GetPhysicalDevicePresentRectanglesKHRPointer);
		}
		AcquireNextImage2KHRPointer = GetInstanceProcedureAddress(instance, "AcquireNextImage2KHR");
		if (AcquireNextImage2KHRPointer != IntPtr.Zero)
		{
			AcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_0>(AcquireNextImage2KHRPointer);
		}
		TrimCommandPoolKHRPointer = GetInstanceProcedureAddress(instance, "TrimCommandPool");
		if (TrimCommandPoolKHRPointer != IntPtr.Zero)
		{
			TrimCommandPoolKHR_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolKHRDelegate_0>(TrimCommandPoolKHRPointer);
		}
		EnumeratePhysicalDeviceGroupsKHRPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDeviceGroups");
		if (EnumeratePhysicalDeviceGroupsKHRPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDeviceGroupsKHR_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsKHRDelegate_0>(EnumeratePhysicalDeviceGroupsKHRPointer);
		}
		GetPhysicalDeviceExternalBufferPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalBufferProperties");
		if (GetPhysicalDeviceExternalBufferPropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalBufferPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0>(GetPhysicalDeviceExternalBufferPropertiesKHRPointer);
		}
		GetMemoryWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryWin32HandleKHR");
		if (GetMemoryWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetMemoryWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_0>(GetMemoryWin32HandleKHRPointer);
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
		}
		GetMemoryFileDescriptorPropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetMemoryFileDescriptorPropertiesKHR");
		if (GetMemoryFileDescriptorPropertiesKHRPointer != IntPtr.Zero)
		{
			GetMemoryFileDescriptorPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorPropertiesKHRDelegate_0>(GetMemoryFileDescriptorPropertiesKHRPointer);
		}
		GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalSemaphoreProperties");
		if (GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalSemaphorePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0>(GetPhysicalDeviceExternalSemaphorePropertiesKHRPointer);
		}
		ImportSemaphoreWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "ImportSemaphoreWin32HandleKHR");
		if (ImportSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			ImportSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_0>(ImportSemaphoreWin32HandleKHRPointer);
		}
		GetSemaphoreWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetSemaphoreWin32HandleKHR");
		if (GetSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_0>(GetSemaphoreWin32HandleKHRPointer);
		}
		ImportSemaphoreFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "ImportSemaphoreFileDescriptorKHR");
		if (ImportSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
		{
			ImportSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_0>(ImportSemaphoreFileDescriptorKHRPointer);
		}
		GetSemaphoreFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "GetSemaphoreFileDescriptorKHR");
		if (GetSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
		{
			GetSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_0>(GetSemaphoreFileDescriptorKHRPointer);
		}
		CommandPushDescriptorSetKHRPointer = GetInstanceProcedureAddress(instance, "CommandPushDescriptorSetKHR");
		if (CommandPushDescriptorSetKHRPointer != IntPtr.Zero)
		{
			CommandPushDescriptorSetKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetKHRDelegate_0>(CommandPushDescriptorSetKHRPointer);
		}
		CommandPushDescriptorSetWithTemplateKHRPointer = GetInstanceProcedureAddress(instance, "CommandPushDescriptorSetWithTemplateKHR");
		if (CommandPushDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
		{
			CommandPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetWithTemplateKHRDelegate_0>(CommandPushDescriptorSetWithTemplateKHRPointer);
		}
		CommandBeginConditionalRenderingEXTPointer = GetInstanceProcedureAddress(instance, "CommandBeginConditionalRenderingEXT");
		if (CommandBeginConditionalRenderingEXTPointer != IntPtr.Zero)
		{
			CommandBeginConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginConditionalRenderingEXTDelegate_0>(CommandBeginConditionalRenderingEXTPointer);
		}
		CommandEndConditionalRenderingEXTPointer = GetInstanceProcedureAddress(instance, "CommandEndConditionalRenderingEXT");
		if (CommandEndConditionalRenderingEXTPointer != IntPtr.Zero)
		{
			CommandEndConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndConditionalRenderingEXTDelegate_0>(CommandEndConditionalRenderingEXTPointer);
		}
		CreateDescriptorUpdateTemplateKHRPointer = GetInstanceProcedureAddress(instance, "CreateDescriptorUpdateTemplate");
		if (CreateDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			CreateDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_0>(CreateDescriptorUpdateTemplateKHRPointer);
		}
		DestroyDescriptorUpdateTemplateKHRPointer = GetInstanceProcedureAddress(instance, "DestroyDescriptorUpdateTemplate");
		if (DestroyDescriptorUpdateTemplateKHRPointer != IntPtr.Zero)
		{
			DestroyDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateKHRDelegate_0>(DestroyDescriptorUpdateTemplateKHRPointer);
		}
		UpdateDescriptorSetWithTemplateKHRPointer = GetInstanceProcedureAddress(instance, "UpdateDescriptorSetWithTemplate");
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
		}
		CommandReserveSpaceForCommandsNVXPointer = GetInstanceProcedureAddress(instance, "CommandReserveSpaceForCommandsNVX");
		if (CommandReserveSpaceForCommandsNVXPointer != IntPtr.Zero)
		{
			CommandReserveSpaceForCommandsNVX_0 = Marshal.GetDelegateForFunctionPointer<CommandReserveSpaceForCommandsNVXDelegate_0>(CommandReserveSpaceForCommandsNVXPointer);
		}
		CreateIndirectCommandsLayoutNVXPointer = GetInstanceProcedureAddress(instance, "CreateIndirectCommandsLayoutNVX");
		if (CreateIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			CreateIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVXDelegate_0>(CreateIndirectCommandsLayoutNVXPointer);
		}
		DestroyIndirectCommandsLayoutNVXPointer = GetInstanceProcedureAddress(instance, "DestroyIndirectCommandsLayoutNVX");
		if (DestroyIndirectCommandsLayoutNVXPointer != IntPtr.Zero)
		{
			DestroyIndirectCommandsLayoutNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVXDelegate_0>(DestroyIndirectCommandsLayoutNVXPointer);
		}
		CreateObjectTableNVXPointer = GetInstanceProcedureAddress(instance, "CreateObjectTableNVX");
		if (CreateObjectTableNVXPointer != IntPtr.Zero)
		{
			CreateObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateObjectTableNVXDelegate_0>(CreateObjectTableNVXPointer);
		}
		DestroyObjectTableNVXPointer = GetInstanceProcedureAddress(instance, "DestroyObjectTableNVX");
		if (DestroyObjectTableNVXPointer != IntPtr.Zero)
		{
			DestroyObjectTableNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyObjectTableNVXDelegate_0>(DestroyObjectTableNVXPointer);
		}
		RegisterObjectsNVXPointer = GetInstanceProcedureAddress(instance, "RegisterObjectsNVX");
		if (RegisterObjectsNVXPointer != IntPtr.Zero)
		{
			RegisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<RegisterObjectsNVXDelegate_0>(RegisterObjectsNVXPointer);
		}
		UnregisterObjectsNVXPointer = GetInstanceProcedureAddress(instance, "UnregisterObjectsNVX");
		if (UnregisterObjectsNVXPointer != IntPtr.Zero)
		{
			UnregisterObjectsNVX_0 = Marshal.GetDelegateForFunctionPointer<UnregisterObjectsNVXDelegate_0>(UnregisterObjectsNVXPointer);
		}
		GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceGeneratedCommandsPropertiesNVX");
		if (GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceGeneratedCommandsPropertiesNVX_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate_0>(GetPhysicalDeviceGeneratedCommandsPropertiesNVXPointer);
		}
		CommandSetViewportWScalingNVPointer = GetInstanceProcedureAddress(instance, "CommandSetViewportWScalingNV");
		if (CommandSetViewportWScalingNVPointer != IntPtr.Zero)
		{
			CommandSetViewportWScalingNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_0>(CommandSetViewportWScalingNVPointer);
		}
		ReleaseDisplayEXTPointer = GetInstanceProcedureAddress(instance, "ReleaseDisplayEXT");
		if (ReleaseDisplayEXTPointer != IntPtr.Zero)
		{
			ReleaseDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseDisplayEXTDelegate_0>(ReleaseDisplayEXTPointer);
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
		}
		RegisterDeviceEventEXTPointer = GetInstanceProcedureAddress(instance, "RegisterDeviceEventEXT");
		if (RegisterDeviceEventEXTPointer != IntPtr.Zero)
		{
			RegisterDeviceEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_0>(RegisterDeviceEventEXTPointer);
		}
		RegisterDisplayEventEXTPointer = GetInstanceProcedureAddress(instance, "RegisterDisplayEventEXT");
		if (RegisterDisplayEventEXTPointer != IntPtr.Zero)
		{
			RegisterDisplayEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_0>(RegisterDisplayEventEXTPointer);
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
		}
		CreateRenderPass2KHRPointer = GetInstanceProcedureAddress(instance, "CreateRenderPass2KHR");
		if (CreateRenderPass2KHRPointer != IntPtr.Zero)
		{
			CreateRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2KHRDelegate_0>(CreateRenderPass2KHRPointer);
		}
		CommandBeginRenderPass2KHRPointer = GetInstanceProcedureAddress(instance, "CommandBeginRenderPass2KHR");
		if (CommandBeginRenderPass2KHRPointer != IntPtr.Zero)
		{
			CommandBeginRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2KHRDelegate_0>(CommandBeginRenderPass2KHRPointer);
		}
		CommandNextSubpass2KHRPointer = GetInstanceProcedureAddress(instance, "CommandNextSubpass2KHR");
		if (CommandNextSubpass2KHRPointer != IntPtr.Zero)
		{
			CommandNextSubpass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2KHRDelegate_0>(CommandNextSubpass2KHRPointer);
		}
		CommandEndRenderPass2KHRPointer = GetInstanceProcedureAddress(instance, "CommandEndRenderPass2KHR");
		if (CommandEndRenderPass2KHRPointer != IntPtr.Zero)
		{
			CommandEndRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2KHRDelegate_0>(CommandEndRenderPass2KHRPointer);
		}
		GetSwapchainStatusKHRPointer = GetInstanceProcedureAddress(instance, "GetSwapchainStatusKHR");
		if (GetSwapchainStatusKHRPointer != IntPtr.Zero)
		{
			GetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainStatusKHRDelegate_0>(GetSwapchainStatusKHRPointer);
		}
		GetPhysicalDeviceExternalFencePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceExternalFenceProperties");
		if (GetPhysicalDeviceExternalFencePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceExternalFencePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0>(GetPhysicalDeviceExternalFencePropertiesKHRPointer);
		}
		ImportFenceWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "ImportFenceWin32HandleKHR");
		if (ImportFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			ImportFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_0>(ImportFenceWin32HandleKHRPointer);
		}
		GetFenceWin32HandleKHRPointer = GetInstanceProcedureAddress(instance, "GetFenceWin32HandleKHR");
		if (GetFenceWin32HandleKHRPointer != IntPtr.Zero)
		{
			GetFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_0>(GetFenceWin32HandleKHRPointer);
		}
		ImportFenceFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "ImportFenceFileDescriptorKHR");
		if (ImportFenceFileDescriptorKHRPointer != IntPtr.Zero)
		{
			ImportFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_0>(ImportFenceFileDescriptorKHRPointer);
		}
		GetFenceFileDescriptorKHRPointer = GetInstanceProcedureAddress(instance, "GetFenceFileDescriptorKHR");
		if (GetFenceFileDescriptorKHRPointer != IntPtr.Zero)
		{
			GetFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_0>(GetFenceFileDescriptorKHRPointer);
		}
		EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer = GetInstanceProcedureAddress(instance, "EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
		if (EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer != IntPtr.Zero)
		{
			EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0>(EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer);
		}
		GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
		if (GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0>(GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer);
		}
		AcquireProfilingLockKHRPointer = GetInstanceProcedureAddress(instance, "AcquireProfilingLockKHR");
		if (AcquireProfilingLockKHRPointer != IntPtr.Zero)
		{
			AcquireProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireProfilingLockKHRDelegate_0>(AcquireProfilingLockKHRPointer);
		}
		ReleaseProfilingLockKHRPointer = GetInstanceProcedureAddress(instance, "ReleaseProfilingLockKHR");
		if (ReleaseProfilingLockKHRPointer != IntPtr.Zero)
		{
			ReleaseProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<ReleaseProfilingLockKHRDelegate_0>(ReleaseProfilingLockKHRPointer);
		}
		GetPhysicalDeviceSurfaceCapabilities2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceCapabilities2KHR");
		if (GetPhysicalDeviceSurfaceCapabilities2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0>(GetPhysicalDeviceSurfaceCapabilities2KHRPointer);
		}
		GetPhysicalDeviceSurfaceFormats2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfaceFormats2KHR");
		if (GetPhysicalDeviceSurfaceFormats2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfaceFormats2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_0>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
		}
		GetPhysicalDeviceDisplayProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayProperties2KHR");
		if (GetPhysicalDeviceDisplayProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayProperties2KHRDelegate_0>(GetPhysicalDeviceDisplayProperties2KHRPointer);
		}
		GetPhysicalDeviceDisplayPlaneProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceDisplayPlaneProperties2KHR");
		if (GetPhysicalDeviceDisplayPlaneProperties2KHRPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceDisplayPlaneProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0>(GetPhysicalDeviceDisplayPlaneProperties2KHRPointer);
		}
		GetDisplayModeProperties2KHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayModeProperties2KHR");
		if (GetDisplayModeProperties2KHRPointer != IntPtr.Zero)
		{
			GetDisplayModeProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModeProperties2KHRDelegate_0>(GetDisplayModeProperties2KHRPointer);
		}
		GetDisplayPlaneCapabilities2KHRPointer = GetInstanceProcedureAddress(instance, "GetDisplayPlaneCapabilities2KHR");
		if (GetDisplayPlaneCapabilities2KHRPointer != IntPtr.Zero)
		{
			GetDisplayPlaneCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilities2KHRDelegate_0>(GetDisplayPlaneCapabilities2KHRPointer);
		}
		CreateMacOSSurfaceMVKPointer = GetInstanceProcedureAddress(instance, "CreateMacOSSurfaceMVK");
		if (CreateMacOSSurfaceMVKPointer != IntPtr.Zero)
		{
			CreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_0>(CreateMacOSSurfaceMVKPointer);
		}
		SetDebugUtilsObjectNameEXTPointer = GetInstanceProcedureAddress(instance, "SetDebugUtilsObjectNameEXT");
		if (SetDebugUtilsObjectNameEXTPointer != IntPtr.Zero)
		{
			SetDebugUtilsObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectNameEXTDelegate_0>(SetDebugUtilsObjectNameEXTPointer);
		}
		SetDebugUtilsObjectTagEXTPointer = GetInstanceProcedureAddress(instance, "SetDebugUtilsObjectTagEXT");
		if (SetDebugUtilsObjectTagEXTPointer != IntPtr.Zero)
		{
			SetDebugUtilsObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectTagEXTDelegate_0>(SetDebugUtilsObjectTagEXTPointer);
		}
		QueueBeginDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "QueueBeginDebugUtilsLabelEXT");
		if (QueueBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			QueueBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueBeginDebugUtilsLabelEXTDelegate_0>(QueueBeginDebugUtilsLabelEXTPointer);
		}
		QueueEndDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "QueueEndDebugUtilsLabelEXT");
		if (QueueEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			QueueEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueEndDebugUtilsLabelEXTDelegate_0>(QueueEndDebugUtilsLabelEXTPointer);
		}
		QueueInsertDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "QueueInsertDebugUtilsLabelEXT");
		if (QueueInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			QueueInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueInsertDebugUtilsLabelEXTDelegate_0>(QueueInsertDebugUtilsLabelEXTPointer);
		}
		CommandBeginDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "CommandBeginDebugUtilsLabelEXT");
		if (CommandBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			CommandBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginDebugUtilsLabelEXTDelegate_0>(CommandBeginDebugUtilsLabelEXTPointer);
		}
		CommandEndDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "CommandEndDebugUtilsLabelEXT");
		if (CommandEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			CommandEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndDebugUtilsLabelEXTDelegate_0>(CommandEndDebugUtilsLabelEXTPointer);
		}
		CommandInsertDebugUtilsLabelEXTPointer = GetInstanceProcedureAddress(instance, "CommandInsertDebugUtilsLabelEXT");
		if (CommandInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
		{
			CommandInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandInsertDebugUtilsLabelEXTDelegate_0>(CommandInsertDebugUtilsLabelEXTPointer);
		}
		CreateDebugUtilsMessengerEXTPointer = GetInstanceProcedureAddress(instance, "CreateDebugUtilsMessengerEXT");
		if (CreateDebugUtilsMessengerEXTPointer != IntPtr.Zero)
		{
			CreateDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_0>(CreateDebugUtilsMessengerEXTPointer);
		}
		DestroyDebugUtilsMessengerEXTPointer = GetInstanceProcedureAddress(instance, "DestroyDebugUtilsMessengerEXT");
		if (DestroyDebugUtilsMessengerEXTPointer != IntPtr.Zero)
		{
			DestroyDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugUtilsMessengerEXTDelegate_0>(DestroyDebugUtilsMessengerEXTPointer);
		}
		SubmitDebugUtilsMessageEXTPointer = GetInstanceProcedureAddress(instance, "SubmitDebugUtilsMessageEXT");
		if (SubmitDebugUtilsMessageEXTPointer != IntPtr.Zero)
		{
			SubmitDebugUtilsMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<SubmitDebugUtilsMessageEXTDelegate_0>(SubmitDebugUtilsMessageEXTPointer);
		}
		GetAndroidHardwareBufferPropertiesANDROIDPointer = GetInstanceProcedureAddress(instance, "GetAndroidHardwareBufferPropertiesANDROID");
		if (GetAndroidHardwareBufferPropertiesANDROIDPointer != IntPtr.Zero)
		{
			GetAndroidHardwareBufferPropertiesANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetAndroidHardwareBufferPropertiesANDROIDDelegate_0>(GetAndroidHardwareBufferPropertiesANDROIDPointer);
		}
		GetMemoryAndroidHardwareBufferANDROIDPointer = GetInstanceProcedureAddress(instance, "GetMemoryAndroidHardwareBufferANDROID");
		if (GetMemoryAndroidHardwareBufferANDROIDPointer != IntPtr.Zero)
		{
			GetMemoryAndroidHardwareBufferANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryAndroidHardwareBufferANDROIDDelegate_0>(GetMemoryAndroidHardwareBufferANDROIDPointer);
		}
		CommandSetSampleLocationsEXTPointer = GetInstanceProcedureAddress(instance, "CommandSetSampleLocationsEXT");
		if (CommandSetSampleLocationsEXTPointer != IntPtr.Zero)
		{
			CommandSetSampleLocationsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_0>(CommandSetSampleLocationsEXTPointer);
		}
		GetPhysicalDeviceMultisamplePropertiesEXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceMultisamplePropertiesEXT");
		if (GetPhysicalDeviceMultisamplePropertiesEXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceMultisamplePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0>(GetPhysicalDeviceMultisamplePropertiesEXTPointer);
		}
		GetImageMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetImageMemoryRequirements2");
		if (GetImageMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetImageMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2KHRDelegate_0>(GetImageMemoryRequirements2KHRPointer);
		}
		GetBufferMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetBufferMemoryRequirements2");
		if (GetBufferMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetBufferMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2KHRDelegate_0>(GetBufferMemoryRequirements2KHRPointer);
		}
		GetImageSparseMemoryRequirements2KHRPointer = GetInstanceProcedureAddress(instance, "GetImageSparseMemoryRequirements2");
		if (GetImageSparseMemoryRequirements2KHRPointer != IntPtr.Zero)
		{
			GetImageSparseMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_0>(GetImageSparseMemoryRequirements2KHRPointer);
		}
		CreateSamplerYcbcrConversionKHRPointer = GetInstanceProcedureAddress(instance, "CreateSamplerYcbcrConversion");
		if (CreateSamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			CreateSamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_0>(CreateSamplerYcbcrConversionKHRPointer);
		}
		DestroySamplerYcbcrConversionKHRPointer = GetInstanceProcedureAddress(instance, "DestroySamplerYcbcrConversion");
		if (DestroySamplerYcbcrConversionKHRPointer != IntPtr.Zero)
		{
			DestroySamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionKHRDelegate_0>(DestroySamplerYcbcrConversionKHRPointer);
		}
		BindBufferMemory2KHRPointer = GetInstanceProcedureAddress(instance, "BindBufferMemory2");
		if (BindBufferMemory2KHRPointer != IntPtr.Zero)
		{
			BindBufferMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2KHRDelegate_0>(BindBufferMemory2KHRPointer);
		}
		BindImageMemory2KHRPointer = GetInstanceProcedureAddress(instance, "BindImageMemory2");
		if (BindImageMemory2KHRPointer != IntPtr.Zero)
		{
			BindImageMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2KHRDelegate_0>(BindImageMemory2KHRPointer);
		}
		GetImageDrmFormatModifierPropertiesEXTPointer = GetInstanceProcedureAddress(instance, "GetImageDrmFormatModifierPropertiesEXT");
		if (GetImageDrmFormatModifierPropertiesEXTPointer != IntPtr.Zero)
		{
			GetImageDrmFormatModifierPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetImageDrmFormatModifierPropertiesEXTDelegate_0>(GetImageDrmFormatModifierPropertiesEXTPointer);
		}
		CreateValidationCacheEXTPointer = GetInstanceProcedureAddress(instance, "CreateValidationCacheEXT");
		if (CreateValidationCacheEXTPointer != IntPtr.Zero)
		{
			CreateValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_0>(CreateValidationCacheEXTPointer);
		}
		DestroyValidationCacheEXTPointer = GetInstanceProcedureAddress(instance, "DestroyValidationCacheEXT");
		if (DestroyValidationCacheEXTPointer != IntPtr.Zero)
		{
			DestroyValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_0>(DestroyValidationCacheEXTPointer);
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
		}
		CommandBindShadingRateImageNVPointer = GetInstanceProcedureAddress(instance, "CommandBindShadingRateImageNV");
		if (CommandBindShadingRateImageNVPointer != IntPtr.Zero)
		{
			CommandBindShadingRateImageNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBindShadingRateImageNVDelegate_0>(CommandBindShadingRateImageNVPointer);
		}
		CommandSetViewportShadingRatePaletteNVPointer = GetInstanceProcedureAddress(instance, "CommandSetViewportShadingRatePaletteNV");
		if (CommandSetViewportShadingRatePaletteNVPointer != IntPtr.Zero)
		{
			CommandSetViewportShadingRatePaletteNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportShadingRatePaletteNVDelegate_0>(CommandSetViewportShadingRatePaletteNVPointer);
		}
		CommandSetCoarseSampleOrderNVPointer = GetInstanceProcedureAddress(instance, "CommandSetCoarseSampleOrderNV");
		if (CommandSetCoarseSampleOrderNVPointer != IntPtr.Zero)
		{
			CommandSetCoarseSampleOrderNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCoarseSampleOrderNVDelegate_0>(CommandSetCoarseSampleOrderNVPointer);
		}
		CreateAccelerationStructureNVPointer = GetInstanceProcedureAddress(instance, "CreateAccelerationStructureNV");
		if (CreateAccelerationStructureNVPointer != IntPtr.Zero)
		{
			CreateAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_0>(CreateAccelerationStructureNVPointer);
		}
		DestroyAccelerationStructureNVPointer = GetInstanceProcedureAddress(instance, "DestroyAccelerationStructureNV");
		if (DestroyAccelerationStructureNVPointer != IntPtr.Zero)
		{
			DestroyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureNVDelegate_0>(DestroyAccelerationStructureNVPointer);
		}
		GetAccelerationStructureMemoryRequirementsNVPointer = GetInstanceProcedureAddress(instance, "GetAccelerationStructureMemoryRequirementsNV");
		if (GetAccelerationStructureMemoryRequirementsNVPointer != IntPtr.Zero)
		{
			GetAccelerationStructureMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureMemoryRequirementsNVDelegate_0>(GetAccelerationStructureMemoryRequirementsNVPointer);
		}
		BindAccelerationStructureMemoryNVPointer = GetInstanceProcedureAddress(instance, "BindAccelerationStructureMemoryNV");
		if (BindAccelerationStructureMemoryNVPointer != IntPtr.Zero)
		{
			BindAccelerationStructureMemoryNV_0 = Marshal.GetDelegateForFunctionPointer<BindAccelerationStructureMemoryNVDelegate_0>(BindAccelerationStructureMemoryNVPointer);
		}
		CommandBuildAccelerationStructureNVPointer = GetInstanceProcedureAddress(instance, "CommandBuildAccelerationStructureNV");
		if (CommandBuildAccelerationStructureNVPointer != IntPtr.Zero)
		{
			CommandBuildAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructureNVDelegate_0>(CommandBuildAccelerationStructureNVPointer);
		}
		CommandCopyAccelerationStructureNVPointer = GetInstanceProcedureAddress(instance, "CommandCopyAccelerationStructureNV");
		if (CommandCopyAccelerationStructureNVPointer != IntPtr.Zero)
		{
			CommandCopyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureNVDelegate_0>(CommandCopyAccelerationStructureNVPointer);
		}
		CommandTraceRaysNVPointer = GetInstanceProcedureAddress(instance, "CommandTraceRaysNV");
		if (CommandTraceRaysNVPointer != IntPtr.Zero)
		{
			CommandTraceRaysNV_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysNVDelegate_0>(CommandTraceRaysNVPointer);
		}
		CreateRayTracingPipelinesNVPointer = GetInstanceProcedureAddress(instance, "CreateRayTracingPipelinesNV");
		if (CreateRayTracingPipelinesNVPointer != IntPtr.Zero)
		{
			CreateRayTracingPipelinesNV_0 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesNVDelegate_0>(CreateRayTracingPipelinesNVPointer);
		}
		GetRayTracingShaderGroupHandlesNVPointer = GetInstanceProcedureAddress(instance, "GetRayTracingShaderGroupHandlesNV");
		if (GetRayTracingShaderGroupHandlesNVPointer != IntPtr.Zero)
		{
			GetRayTracingShaderGroupHandlesNV_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupHandlesNVDelegate_0>(GetRayTracingShaderGroupHandlesNVPointer);
		}
		GetAccelerationStructureHandleNVPointer = GetInstanceProcedureAddress(instance, "GetAccelerationStructureHandleNV");
		if (GetAccelerationStructureHandleNVPointer != IntPtr.Zero)
		{
			GetAccelerationStructureHandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureHandleNVDelegate_0>(GetAccelerationStructureHandleNVPointer);
		}
		CommandWriteAccelerationStructuresPropertiesNVPointer = GetInstanceProcedureAddress(instance, "CommandWriteAccelerationStructuresPropertiesNV");
		if (CommandWriteAccelerationStructuresPropertiesNVPointer != IntPtr.Zero)
		{
			CommandWriteAccelerationStructuresPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteAccelerationStructuresPropertiesNVDelegate_0>(CommandWriteAccelerationStructuresPropertiesNVPointer);
		}
		CompileDeferredNVPointer = GetInstanceProcedureAddress(instance, "CompileDeferredNV");
		if (CompileDeferredNVPointer != IntPtr.Zero)
		{
			CompileDeferredNV_0 = Marshal.GetDelegateForFunctionPointer<CompileDeferredNVDelegate_0>(CompileDeferredNVPointer);
		}
		GetDescriptorSetLayoutSupportKHRPointer = GetInstanceProcedureAddress(instance, "GetDescriptorSetLayoutSupport");
		if (GetDescriptorSetLayoutSupportKHRPointer != IntPtr.Zero)
		{
			GetDescriptorSetLayoutSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportKHRDelegate_0>(GetDescriptorSetLayoutSupportKHRPointer);
		}
		CommandDrawIndirectCountKHRPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndirectCountKHR");
		if (CommandDrawIndirectCountKHRPointer != IntPtr.Zero)
		{
			CommandDrawIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountKHRDelegate_0>(CommandDrawIndirectCountKHRPointer);
		}
		CommandDrawIndexedIndirectCountKHRPointer = GetInstanceProcedureAddress(instance, "CommandDrawIndexedIndirectCountKHR");
		if (CommandDrawIndexedIndirectCountKHRPointer != IntPtr.Zero)
		{
			CommandDrawIndexedIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountKHRDelegate_0>(CommandDrawIndexedIndirectCountKHRPointer);
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
		GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceCalibrateableTimeDomainsEXT");
		if (GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceCalibrateableTimeDomainsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0>(GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer);
		}
		GetCalibratedTimestampsEXTPointer = GetInstanceProcedureAddress(instance, "GetCalibratedTimestampsEXT");
		if (GetCalibratedTimestampsEXTPointer != IntPtr.Zero)
		{
			GetCalibratedTimestampsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetCalibratedTimestampsEXTDelegate_0>(GetCalibratedTimestampsEXTPointer);
		}
		CommandDrawMeshTasksNVPointer = GetInstanceProcedureAddress(instance, "CommandDrawMeshTasksNV");
		if (CommandDrawMeshTasksNVPointer != IntPtr.Zero)
		{
			CommandDrawMeshTasksNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksNVDelegate_0>(CommandDrawMeshTasksNVPointer);
		}
		CommandDrawMeshTasksIndirectNVPointer = GetInstanceProcedureAddress(instance, "CommandDrawMeshTasksIndirectNV");
		if (CommandDrawMeshTasksIndirectNVPointer != IntPtr.Zero)
		{
			CommandDrawMeshTasksIndirectNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectNVDelegate_0>(CommandDrawMeshTasksIndirectNVPointer);
		}
		CommandDrawMeshTasksIndirectCountNVPointer = GetInstanceProcedureAddress(instance, "CommandDrawMeshTasksIndirectCountNV");
		if (CommandDrawMeshTasksIndirectCountNVPointer != IntPtr.Zero)
		{
			CommandDrawMeshTasksIndirectCountNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectCountNVDelegate_0>(CommandDrawMeshTasksIndirectCountNVPointer);
		}
		CommandSetExclusiveScissorNVPointer = GetInstanceProcedureAddress(instance, "CommandSetExclusiveScissorNV");
		if (CommandSetExclusiveScissorNVPointer != IntPtr.Zero)
		{
			CommandSetExclusiveScissorNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetExclusiveScissorNVDelegate_0>(CommandSetExclusiveScissorNVPointer);
		}
		CommandSetCheckpointNVPointer = GetInstanceProcedureAddress(instance, "CommandSetCheckpointNV");
		if (CommandSetCheckpointNVPointer != IntPtr.Zero)
		{
			CommandSetCheckpointNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCheckpointNVDelegate_0>(CommandSetCheckpointNVPointer);
		}
		GetQueueCheckpointDataNVPointer = GetInstanceProcedureAddress(instance, "GetQueueCheckpointDataNV");
		if (GetQueueCheckpointDataNVPointer != IntPtr.Zero)
		{
			GetQueueCheckpointDataNV_0 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointDataNVDelegate_0>(GetQueueCheckpointDataNVPointer);
		}
		GetSemaphoreCounterValueKHRPointer = GetInstanceProcedureAddress(instance, "GetSemaphoreCounterValueKHR");
		if (GetSemaphoreCounterValueKHRPointer != IntPtr.Zero)
		{
			GetSemaphoreCounterValueKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreCounterValueKHRDelegate_0>(GetSemaphoreCounterValueKHRPointer);
		}
		WaitSemaphoresKHRPointer = GetInstanceProcedureAddress(instance, "WaitSemaphoresKHR");
		if (WaitSemaphoresKHRPointer != IntPtr.Zero)
		{
			WaitSemaphoresKHR_0 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresKHRDelegate_0>(WaitSemaphoresKHRPointer);
		}
		SignalSemaphoreKHRPointer = GetInstanceProcedureAddress(instance, "SignalSemaphoreKHR");
		if (SignalSemaphoreKHRPointer != IntPtr.Zero)
		{
			SignalSemaphoreKHR_0 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreKHRDelegate_0>(SignalSemaphoreKHRPointer);
		}
		InitializePerformanceApiINTELPointer = GetInstanceProcedureAddress(instance, "InitializePerformanceApiINTEL");
		if (InitializePerformanceApiINTELPointer != IntPtr.Zero)
		{
			InitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<InitializePerformanceApiINTELDelegate_0>(InitializePerformanceApiINTELPointer);
		}
		UninitializePerformanceApiINTELPointer = GetInstanceProcedureAddress(instance, "UninitializePerformanceApiINTEL");
		if (UninitializePerformanceApiINTELPointer != IntPtr.Zero)
		{
			UninitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<UninitializePerformanceApiINTELDelegate_0>(UninitializePerformanceApiINTELPointer);
		}
		CommandSetPerformanceMarkerINTELPointer = GetInstanceProcedureAddress(instance, "CommandSetPerformanceMarkerINTEL");
		if (CommandSetPerformanceMarkerINTELPointer != IntPtr.Zero)
		{
			CommandSetPerformanceMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceMarkerINTELDelegate_0>(CommandSetPerformanceMarkerINTELPointer);
		}
		CommandSetPerformanceStreamMarkerINTELPointer = GetInstanceProcedureAddress(instance, "CommandSetPerformanceStreamMarkerINTEL");
		if (CommandSetPerformanceStreamMarkerINTELPointer != IntPtr.Zero)
		{
			CommandSetPerformanceStreamMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceStreamMarkerINTELDelegate_0>(CommandSetPerformanceStreamMarkerINTELPointer);
		}
		CommandSetPerformanceOverrideINTELPointer = GetInstanceProcedureAddress(instance, "CommandSetPerformanceOverrideINTEL");
		if (CommandSetPerformanceOverrideINTELPointer != IntPtr.Zero)
		{
			CommandSetPerformanceOverrideINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceOverrideINTELDelegate_0>(CommandSetPerformanceOverrideINTELPointer);
		}
		AcquirePerformanceConfigurationINTELPointer = GetInstanceProcedureAddress(instance, "AcquirePerformanceConfigurationINTEL");
		if (AcquirePerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			AcquirePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_0>(AcquirePerformanceConfigurationINTELPointer);
		}
		ReleasePerformanceConfigurationINTELPointer = GetInstanceProcedureAddress(instance, "ReleasePerformanceConfigurationINTEL");
		if (ReleasePerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			ReleasePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<ReleasePerformanceConfigurationINTELDelegate_0>(ReleasePerformanceConfigurationINTELPointer);
		}
		QueueSetPerformanceConfigurationINTELPointer = GetInstanceProcedureAddress(instance, "QueueSetPerformanceConfigurationINTEL");
		if (QueueSetPerformanceConfigurationINTELPointer != IntPtr.Zero)
		{
			QueueSetPerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<QueueSetPerformanceConfigurationINTELDelegate_0>(QueueSetPerformanceConfigurationINTELPointer);
		}
		GetPerformanceParameterINTELPointer = GetInstanceProcedureAddress(instance, "GetPerformanceParameterINTEL");
		if (GetPerformanceParameterINTELPointer != IntPtr.Zero)
		{
			GetPerformanceParameterINTEL_0 = Marshal.GetDelegateForFunctionPointer<GetPerformanceParameterINTELDelegate_0>(GetPerformanceParameterINTELPointer);
		}
		SetLocalDimmingAMDPointer = GetInstanceProcedureAddress(instance, "SetLocalDimmingAMD");
		if (SetLocalDimmingAMDPointer != IntPtr.Zero)
		{
			SetLocalDimmingAMD_0 = Marshal.GetDelegateForFunctionPointer<SetLocalDimmingAMDDelegate_0>(SetLocalDimmingAMDPointer);
		}
		GetBufferDeviceAddressEXTPointer = GetInstanceProcedureAddress(instance, "GetBufferDeviceAddressKHR");
		if (GetBufferDeviceAddressEXTPointer != IntPtr.Zero)
		{
			GetBufferDeviceAddressEXT_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressEXTDelegate_0>(GetBufferDeviceAddressEXTPointer);
		}
		GetPhysicalDeviceToolPropertiesEXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceToolPropertiesEXT");
		if (GetPhysicalDeviceToolPropertiesEXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceToolPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceToolPropertiesEXTDelegate_0>(GetPhysicalDeviceToolPropertiesEXTPointer);
		}
		GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceCooperativeMatrixPropertiesNV");
		if (GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceCooperativeMatrixPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0>(GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer);
		}
		GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
		if (GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0>(GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer);
		}
		GetPhysicalDeviceSurfacePresentModes2EXTPointer = GetInstanceProcedureAddress(instance, "GetPhysicalDeviceSurfacePresentModes2EXT");
		if (GetPhysicalDeviceSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			GetPhysicalDeviceSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0>(GetPhysicalDeviceSurfacePresentModes2EXTPointer);
		}
		AcquireFullScreenExclusiveModeEXTPointer = GetInstanceProcedureAddress(instance, "AcquireFullScreenExclusiveModeEXT");
		if (AcquireFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
		{
			AcquireFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireFullScreenExclusiveModeEXTDelegate_0>(AcquireFullScreenExclusiveModeEXTPointer);
		}
		ReleaseFullScreenExclusiveModeEXTPointer = GetInstanceProcedureAddress(instance, "ReleaseFullScreenExclusiveModeEXT");
		if (ReleaseFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
		{
			ReleaseFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseFullScreenExclusiveModeEXTDelegate_0>(ReleaseFullScreenExclusiveModeEXTPointer);
		}
		GetDeviceGroupSurfacePresentModes2EXTPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupSurfacePresentModes2EXT");
		if (GetDeviceGroupSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			GetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_0>(GetDeviceGroupSurfacePresentModes2EXTPointer);
		}
		GetDeviceGroupSurfacePresentModes2EXTPointer = GetInstanceProcedureAddress(instance, "GetDeviceGroupSurfacePresentModes2EXT");
		if (GetDeviceGroupSurfacePresentModes2EXTPointer != IntPtr.Zero)
		{
			GetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_0>(GetDeviceGroupSurfacePresentModes2EXTPointer);
		}
		CreateHeadlessSurfaceEXTPointer = GetInstanceProcedureAddress(instance, "CreateHeadlessSurfaceEXT");
		if (CreateHeadlessSurfaceEXTPointer != IntPtr.Zero)
		{
			CreateHeadlessSurfaceEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_0>(CreateHeadlessSurfaceEXTPointer);
		}
		GetBufferDeviceAddressKHRPointer = GetInstanceProcedureAddress(instance, "GetBufferDeviceAddressKHR");
		if (GetBufferDeviceAddressKHRPointer != IntPtr.Zero)
		{
			GetBufferDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressKHRDelegate_0>(GetBufferDeviceAddressKHRPointer);
		}
		GetBufferOpaqueCaptureAddressKHRPointer = GetInstanceProcedureAddress(instance, "GetBufferOpaqueCaptureAddressKHR");
		if (GetBufferOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			GetBufferOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferOpaqueCaptureAddressKHRDelegate_0>(GetBufferOpaqueCaptureAddressKHRPointer);
		}
		GetDeviceMemoryOpaqueCaptureAddressKHRPointer = GetInstanceProcedureAddress(instance, "GetDeviceMemoryOpaqueCaptureAddressKHR");
		if (GetDeviceMemoryOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			GetDeviceMemoryOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0>(GetDeviceMemoryOpaqueCaptureAddressKHRPointer);
		}
		CommandSetLineStippleEXTPointer = GetInstanceProcedureAddress(instance, "CommandSetLineStippleEXT");
		if (CommandSetLineStippleEXTPointer != IntPtr.Zero)
		{
			CommandSetLineStippleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineStippleEXTDelegate_0>(CommandSetLineStippleEXTPointer);
		}
		ResetQueryPoolEXTPointer = GetInstanceProcedureAddress(instance, "ResetQueryPoolEXT");
		if (ResetQueryPoolEXTPointer != IntPtr.Zero)
		{
			ResetQueryPoolEXT_0 = Marshal.GetDelegateForFunctionPointer<ResetQueryPoolEXTDelegate_0>(ResetQueryPoolEXTPointer);
		}
		GetPipelineExecutablePropertiesKHRPointer = GetInstanceProcedureAddress(instance, "GetPipelineExecutablePropertiesKHR");
		if (GetPipelineExecutablePropertiesKHRPointer != IntPtr.Zero)
		{
			GetPipelineExecutablePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_0>(GetPipelineExecutablePropertiesKHRPointer);
		}
		GetPipelineExecutableStatisticsKHRPointer = GetInstanceProcedureAddress(instance, "GetPipelineExecutableStatisticsKHR");
		if (GetPipelineExecutableStatisticsKHRPointer != IntPtr.Zero)
		{
			GetPipelineExecutableStatisticsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_0>(GetPipelineExecutableStatisticsKHRPointer);
		}
		GetPipelineExecutableInternalRepresentationsKHRPointer = GetInstanceProcedureAddress(instance, "GetPipelineExecutableInternalRepresentationsKHR");
		if (GetPipelineExecutableInternalRepresentationsKHRPointer != IntPtr.Zero)
		{
			GetPipelineExecutableInternalRepresentationsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_0>(GetPipelineExecutableInternalRepresentationsKHRPointer);
		}
	}
}
