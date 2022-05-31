// this file was generated, don't edit manually

using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
	public static class VK
	{
		public const uint MaxPhysicalDeviceNameSize = 256;
		public const uint UuidSize = 16;
		public const uint LuidSize = 8;
		public const uint LuidSizeKhr = LuidSize;
		public const uint MaxExtensionNameSize = 256;
		public const uint MaxDescriptionSize = 256;
		public const uint MaxMemoryTypes = 32;
		public const uint MaxMemoryHeaps = 16;
		public const uint LodClampNone = 1000.0F;
		public const uint RemainingMipLevels = ~0U;
		public const uint RemainingArrayLayers = ~0U;
		public const ulong WholeSize = ~0UL;
		public const uint AttachmentUnused = ~0U;
		public const uint True = 1;
		public const uint False = 0;
		public const uint QueueFamilyIgnored = ~0U;
		public const uint QueueFamilyExternal = ~1U;
		public const uint QueueFamilyExternalKhr = QueueFamilyExternal;
		public const uint QueueFamilyForeignExt = ~2U;
		public const uint SubpassExternal = ~0U;
		public const uint MaxDeviceGroupSize = 32;
		public const uint MaxDeviceGroupSizeKhr = MaxDeviceGroupSize;
		public const uint MaxDriverNameSize = 256;
		public const uint MaxDriverNameSizeKhr = MaxDriverNameSize;
		public const uint MaxDriverInfoSize = 256;
		public const uint MaxDriverInfoSizeKhr = MaxDriverInfoSize;
		public const uint ShaderUnusedKhr = ~0U;
		public const uint ShaderUnusedNv = ShaderUnusedKhr;
		public const uint MaxGlobalPrioritySizeKhr = 16;
		public const uint MaxGlobalPrioritySizeExt = MaxGlobalPrioritySizeKhr;
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
		public const uint KhrAndroidSurfaceSpecVersion = 6;
		public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
		public const uint KhrWin32SurfaceSpecVersion = 6;
		public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
		public const uint ExtDebugReportSpecVersion = 10;
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
		public const uint NvxBinaryImportSpecVersion = 1;
		public const string NvxBinaryImportExtensionName = "VK_NVX_binary_import";
		public const uint NvxImageViewHandleSpecVersion = 2;
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
		public const uint KhrDynamicRenderingSpecVersion = 1;
		public const string KhrDynamicRenderingExtensionName = "VK_KHR_dynamic_rendering";
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
		public const uint KhrMaintenance1SpecVersion = KhrMaintenance1SpecVersion;
		public const uint KhrMaintenance1ExtensionName = KhrMaintenance1ExtensionName;
		public const uint KhrDeviceGroupCreationSpecVersion = 1;
		public const string KhrDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
		public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
		public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
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
		public const uint KhrIncrementalPresentSpecVersion = 2;
		public const string KhrIncrementalPresentExtensionName = "VK_KHR_incremental_present";
		public const uint KhrDescriptorUpdateTemplateSpecVersion = 1;
		public const string KhrDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
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
		public const uint NvViewportArray2SpecVersion = NvViewportArray2SpecVersion;
		public const uint NvViewportArray2ExtensionName = NvViewportArray2ExtensionName;
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
		public const uint KhrMaintenance2SpecVersion = KhrMaintenance2SpecVersion;
		public const uint KhrMaintenance2ExtensionName = KhrMaintenance2ExtensionName;
		public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
		public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
		public const uint KhrVariablePointersSpecVersion = 1;
		public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
		public const uint KhrGetDisplayProperties2SpecVersion = 1;
		public const string KhrGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
		public const uint MvkMacosSurfaceSpecVersion = 3;
		public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
		public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
		public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
		public const uint ExtQueueFamilyForeignSpecVersion = 1;
		public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
		public const uint KhrDedicatedAllocationSpecVersion = 3;
		public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
		public const uint ExtDebugUtilsSpecVersion = 2;
		public const string ExtDebugUtilsExtensionName = "VK_EXT_debug_utils";
		public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 5;
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
		public const uint KhrAccelerationStructureSpecVersion = 13;
		public const string KhrAccelerationStructureExtensionName = "VK_KHR_acceleration_structure";
		public const uint KhrRayTracingPipelineSpecVersion = 1;
		public const string KhrRayTracingPipelineExtensionName = "VK_KHR_ray_tracing_pipeline";
		public const uint KhrRayQuerySpecVersion = 1;
		public const string KhrRayQueryExtensionName = "VK_KHR_ray_query";
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
		public const uint ExtImageDrmFormatModifierSpecVersion = 2;
		public const string ExtImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
		public const uint ExtValidationCacheSpecVersion = 1;
		public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
		public const uint ExtDescriptorIndexingSpecVersion = 2;
		public const string ExtDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
		public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
		public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
		public const uint NvShadingRateImageSpecVersion = 3;
		public const string NvShadingRateImageExtensionName = "VK_NV_shading_rate_image";
		public const uint NvRayTracingSpecVersion = 3;
		public const string NvRayTracingExtensionName = "VK_NV_ray_tracing";
		public const uint NvRepresentativeFragmentTestSpecVersion = 2;
		public const string NvRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
		public const uint KhrMaintenance3SpecVersion = 1;
		public const string KhrMaintenance3ExtensionName = "VK_KHR_maintenance3";
		public const uint KhrMaintenance3SpecVersion = KhrMaintenance3SpecVersion;
		public const uint KhrMaintenance3ExtensionName = KhrMaintenance3ExtensionName;
		public const uint KhrDrawIndirectCountSpecVersion = 1;
		public const string KhrDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
		public const uint ExtFilterCubicSpecVersion = 3;
		public const string ExtFilterCubicExtensionName = "VK_EXT_filter_cubic";
		public const uint QcomRenderPassShaderResolveSpecVersion = 4;
		public const string QcomRenderPassShaderResolveExtensionName = "VK_QCOM_render_pass_shader_resolve";
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
		public const uint ExtCalibratedTimestampsSpecVersion = 2;
		public const string ExtCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
		public const uint AmdShaderCorePropertiesSpecVersion = 2;
		public const string AmdShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
		public const uint KhrGlobalPrioritySpecVersion = 1;
		public const string KhrGlobalPriorityExtensionName = "VK_KHR_global_priority";
		public const uint AmdMemoryOverallocationBehaviorSpecVersion = 1;
		public const string AmdMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
		public const uint ExtVertexAttributeDivisorSpecVersion = 3;
		public const string ExtVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
		public const uint ExtPipelineCreationFeedbackSpecVersion = 1;
		public const string ExtPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
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
		public const uint IntelPerformanceQuerySpecVersion = 2;
		public const string IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
		public const uint KhrVulkanMemoryModelSpecVersion = 3;
		public const string KhrVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
		public const uint ExtPciBusInfoSpecVersion = 2;
		public const string ExtPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
		public const uint AmdDisplayNativeHdrSpecVersion = 1;
		public const string AmdDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
		public const uint KhrShaderTerminateInvocationSpecVersion = 1;
		public const string KhrShaderTerminateInvocationExtensionName = "VK_KHR_shader_terminate_invocation";
		public const uint ExtFragmentDensityMapSpecVersion = 2;
		public const string ExtFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
		public const uint ExtScalarBlockLayoutSpecVersion = 1;
		public const string ExtScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
		public const uint GoogleHlslFunctionality1SpecVersion = 1;
		public const string GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
		public const uint GoogleHlslFunctionality1SpecVersion = GoogleHlslFunctionality1SpecVersion;
		public const uint GoogleHlslFunctionality1ExtensionName = GoogleHlslFunctionality1ExtensionName;
		public const uint GoogleDecorateStringSpecVersion = 1;
		public const string GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
		public const uint ExtSubgroupSizeControlSpecVersion = 2;
		public const string ExtSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
		public const uint KhrFragmentShadingRateSpecVersion = 2;
		public const string KhrFragmentShadingRateExtensionName = "VK_KHR_fragment_shading_rate";
		public const uint AmdShaderCoreProperties2SpecVersion = 1;
		public const string AmdShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
		public const uint AmdDeviceCoherentMemorySpecVersion = 1;
		public const string AmdDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
		public const uint ExtShaderImageAtomicInt64SpecVersion = 1;
		public const string ExtShaderImageAtomicInt64ExtensionName = "VK_EXT_shader_image_atomic_int64";
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
		public const uint ExtValidationFeaturesSpecVersion = 5;
		public const string ExtValidationFeaturesExtensionName = "VK_EXT_validation_features";
		public const uint KhrPresentWaitSpecVersion = 1;
		public const string KhrPresentWaitExtensionName = "VK_KHR_present_wait";
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
		public const uint ExtProvokingVertexSpecVersion = 1;
		public const string ExtProvokingVertexExtensionName = "VK_EXT_provoking_vertex";
		public const uint ExtFullScreenExclusiveSpecVersion = 4;
		public const string ExtFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
		public const uint ExtHeadlessSurfaceSpecVersion = 1;
		public const string ExtHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
		public const uint KhrBufferDeviceAddressSpecVersion = 1;
		public const string KhrBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
		public const uint ExtLineRasterizationSpecVersion = 1;
		public const string ExtLineRasterizationExtensionName = "VK_EXT_line_rasterization";
		public const uint ExtShaderAtomicFloatSpecVersion = 1;
		public const string ExtShaderAtomicFloatExtensionName = "VK_EXT_shader_atomic_float";
		public const uint ExtHostQueryResetSpecVersion = 1;
		public const string ExtHostQueryResetExtensionName = "VK_EXT_host_query_reset";
		public const uint ExtIndexTypeUint8SpecVersion = 1;
		public const string ExtIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
		public const uint ExtExtendedDynamicStateSpecVersion = 1;
		public const string ExtExtendedDynamicStateExtensionName = "VK_EXT_extended_dynamic_state";
		public const uint KhrDeferredHostOperationsSpecVersion = 4;
		public const string KhrDeferredHostOperationsExtensionName = "VK_KHR_deferred_host_operations";
		public const uint KhrPipelineExecutablePropertiesSpecVersion = 1;
		public const string KhrPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
		public const uint ExtShaderAtomicFloat2SpecVersion = 1;
		public const string ExtShaderAtomicFloat2ExtensionName = "VK_EXT_shader_atomic_float2";
		public const uint ExtShaderDemoteToHelperInvocationSpecVersion = 1;
		public const string ExtShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
		public const uint NvDeviceGeneratedCommandsSpecVersion = 3;
		public const string NvDeviceGeneratedCommandsExtensionName = "VK_NV_device_generated_commands";
		public const uint NvInheritedViewportScissorSpecVersion = 1;
		public const string NvInheritedViewportScissorExtensionName = "VK_NV_inherited_viewport_scissor";
		public const uint KhrShaderIntegerDotProductSpecVersion = 1;
		public const string KhrShaderIntegerDotProductExtensionName = "VK_KHR_shader_integer_dot_product";
		public const uint ExtTexelBufferAlignmentSpecVersion = 1;
		public const string ExtTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
		public const uint QcomRenderPassTransformSpecVersion = 2;
		public const string QcomRenderPassTransformExtensionName = "VK_QCOM_render_pass_transform";
		public const uint ExtDeviceMemoryReportSpecVersion = 2;
		public const string ExtDeviceMemoryReportExtensionName = "VK_EXT_device_memory_report";
		public const uint ExtAcquireDrmDisplaySpecVersion = 1;
		public const string ExtAcquireDrmDisplayExtensionName = "VK_EXT_acquire_drm_display";
		public const uint ExtRobustness2SpecVersion = 1;
		public const string ExtRobustness2ExtensionName = "VK_EXT_robustness2";
		public const uint ExtCustomBorderColorSpecVersion = 12;
		public const string ExtCustomBorderColorExtensionName = "VK_EXT_custom_border_color";
		public const uint GoogleUserTypeSpecVersion = 1;
		public const string GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
		public const uint KhrPipelineLibrarySpecVersion = 1;
		public const string KhrPipelineLibraryExtensionName = "VK_KHR_pipeline_library";
		public const uint KhrShaderNonSemanticInfoSpecVersion = 1;
		public const string KhrShaderNonSemanticInfoExtensionName = "VK_KHR_shader_non_semantic_info";
		public const uint KhrPresentIdSpecVersion = 1;
		public const string KhrPresentIdExtensionName = "VK_KHR_present_id";
		public const uint ExtPrivateDataSpecVersion = 1;
		public const string ExtPrivateDataExtensionName = "VK_EXT_private_data";
		public const uint ExtPipelineCreationCacheControlSpecVersion = 3;
		public const string ExtPipelineCreationCacheControlExtensionName = "VK_EXT_pipeline_creation_cache_control";
		public const uint NvDeviceDiagnosticsConfigSpecVersion = 2;
		public const string NvDeviceDiagnosticsConfigExtensionName = "VK_NV_device_diagnostics_config";
		public const uint QcomRenderPassStoreOpsSpecVersion = 2;
		public const string QcomRenderPassStoreOpsExtensionName = "VK_QCOM_render_pass_store_ops";
		public const uint KhrSynchronization2SpecVersion = 1;
		public const string KhrSynchronization2ExtensionName = "VK_KHR_synchronization2";
		public const uint ExtGraphicsPipelineLibrarySpecVersion = 1;
		public const string ExtGraphicsPipelineLibraryExtensionName = "VK_EXT_graphics_pipeline_library";
		public const uint AmdShaderEarlyAndLateFragmentTestsSpecVersion = 1;
		public const string AmdShaderEarlyAndLateFragmentTestsExtensionName = "VK_AMD_shader_early_and_late_fragment_tests";
		public const uint KhrFragmentShaderBarycentricSpecVersion = 1;
		public const string KhrFragmentShaderBarycentricExtensionName = "VK_KHR_fragment_shader_barycentric";
		public const uint KhrShaderSubgroupUniformControlFlowSpecVersion = 1;
		public const string KhrShaderSubgroupUniformControlFlowExtensionName = "VK_KHR_shader_subgroup_uniform_control_flow";
		public const uint KhrZeroInitializeWorkgroupMemorySpecVersion = 1;
		public const string KhrZeroInitializeWorkgroupMemoryExtensionName = "VK_KHR_zero_initialize_workgroup_memory";
		public const uint NvFragmentShadingRateEnumsSpecVersion = 1;
		public const string NvFragmentShadingRateEnumsExtensionName = "VK_NV_fragment_shading_rate_enums";
		public const uint NvRayTracingMotionBlurSpecVersion = 1;
		public const string NvRayTracingMotionBlurExtensionName = "VK_NV_ray_tracing_motion_blur";
		public const uint ExtYcbcr2plane444FormatsSpecVersion = 1;
		public const string ExtYcbcr2plane444FormatsExtensionName = "VK_EXT_ycbcr_2plane_444_formats";
		public const uint ExtFragmentDensityMap2SpecVersion = 1;
		public const string ExtFragmentDensityMap2ExtensionName = "VK_EXT_fragment_density_map2";
		public const uint QcomRotatedCopyCommandsSpecVersion = 1;
		public const string QcomRotatedCopyCommandsExtensionName = "VK_QCOM_rotated_copy_commands";
		public const uint ExtImageRobustnessSpecVersion = 1;
		public const string ExtImageRobustnessExtensionName = "VK_EXT_image_robustness";
		public const uint KhrWorkgroupMemoryExplicitLayoutSpecVersion = 1;
		public const string KhrWorkgroupMemoryExplicitLayoutExtensionName = "VK_KHR_workgroup_memory_explicit_layout";
		public const uint KhrCopyCommands2SpecVersion = 1;
		public const string KhrCopyCommands2ExtensionName = "VK_KHR_copy_commands2";
		public const uint ExtImageCompressionControlSpecVersion = 1;
		public const string ExtImageCompressionControlExtensionName = "VK_EXT_image_compression_control";
		public const uint Ext4444FormatsSpecVersion = 1;
		public const string Ext4444FormatsExtensionName = "VK_EXT_4444_formats";
		public const uint ArmRasterizationOrderAttachmentAccessSpecVersion = 1;
		public const string ArmRasterizationOrderAttachmentAccessExtensionName = "VK_ARM_rasterization_order_attachment_access";
		public const uint ExtRgba10x6FormatsSpecVersion = 1;
		public const string ExtRgba10x6FormatsExtensionName = "VK_EXT_rgba10x6_formats";
		public const uint NvAcquireWinrtDisplaySpecVersion = 1;
		public const string NvAcquireWinrtDisplayExtensionName = "VK_NV_acquire_winrt_display";
		public const uint ValveMutableDescriptorTypeSpecVersion = 1;
		public const string ValveMutableDescriptorTypeExtensionName = "VK_VALVE_mutable_descriptor_type";
		public const uint ExtVertexInputDynamicStateSpecVersion = 2;
		public const string ExtVertexInputDynamicStateExtensionName = "VK_EXT_vertex_input_dynamic_state";
		public const uint ExtPhysicalDeviceDrmSpecVersion = 1;
		public const string ExtPhysicalDeviceDrmExtensionName = "VK_EXT_physical_device_drm";
		public const uint ExtDepthClipControlSpecVersion = 1;
		public const string ExtDepthClipControlExtensionName = "VK_EXT_depth_clip_control";
		public const uint ExtPrimitiveTopologyListRestartSpecVersion = 1;
		public const string ExtPrimitiveTopologyListRestartExtensionName = "VK_EXT_primitive_topology_list_restart";
		public const uint KhrFormatFeatureFlags2SpecVersion = 1;
		public const string KhrFormatFeatureFlags2ExtensionName = "VK_KHR_format_feature_flags2";
		public const uint HuaweiSubpassShadingSpecVersion = 2;
		public const string HuaweiSubpassShadingExtensionName = "VK_HUAWEI_subpass_shading";
		public const uint HuaweiInvocationMaskSpecVersion = 1;
		public const string HuaweiInvocationMaskExtensionName = "VK_HUAWEI_invocation_mask";
		public const uint NvExternalMemoryRdmaSpecVersion = 1;
		public const string NvExternalMemoryRdmaExtensionName = "VK_NV_external_memory_rdma";
		public const uint ExtPipelinePropertiesSpecVersion = 1;
		public const string ExtPipelinePropertiesExtensionName = "VK_EXT_pipeline_properties";
		public const uint ExtExtendedDynamicState2SpecVersion = 1;
		public const string ExtExtendedDynamicState2ExtensionName = "VK_EXT_extended_dynamic_state2";
		public const uint ExtColorWriteEnableSpecVersion = 1;
		public const string ExtColorWriteEnableExtensionName = "VK_EXT_color_write_enable";
		public const uint ExtPrimitivesGeneratedQuerySpecVersion = 1;
		public const string ExtPrimitivesGeneratedQueryExtensionName = "VK_EXT_primitives_generated_query";
		public const uint KhrRayTracingMaintenance1SpecVersion = 1;
		public const string KhrRayTracingMaintenance1ExtensionName = "VK_KHR_ray_tracing_maintenance1";
		public const uint ExtGlobalPriorityQuerySpecVersion = 1;
		public const string ExtGlobalPriorityQueryExtensionName = "VK_EXT_global_priority_query";
		public const uint ExtImageViewMinLodSpecVersion = 1;
		public const string ExtImageViewMinLodExtensionName = "VK_EXT_image_view_min_lod";
		public const uint ExtMultiDrawSpecVersion = 1;
		public const string ExtMultiDrawExtensionName = "VK_EXT_multi_draw";
		public const uint ExtImage2dViewOf3dSpecVersion = 1;
		public const string ExtImage2dViewOf3dExtensionName = "VK_EXT_image_2d_view_of_3d";
		public const uint KhrPortabilityEnumerationSpecVersion = 1;
		public const string KhrPortabilityEnumerationExtensionName = "VK_KHR_portability_enumeration";
		public const uint ExtLoadStoreOpNoneSpecVersion = 1;
		public const string ExtLoadStoreOpNoneExtensionName = "VK_EXT_load_store_op_none";
		public const uint ExtBorderColorSwizzleSpecVersion = 1;
		public const string ExtBorderColorSwizzleExtensionName = "VK_EXT_border_color_swizzle";
		public const uint ExtPageableDeviceLocalMemorySpecVersion = 1;
		public const string ExtPageableDeviceLocalMemoryExtensionName = "VK_EXT_pageable_device_local_memory";
		public const uint KhrMaintenance4SpecVersion = 2;
		public const string KhrMaintenance4ExtensionName = "VK_KHR_maintenance4";
		public const uint ValveDescriptorSetHostMappingSpecVersion = 1;
		public const string ValveDescriptorSetHostMappingExtensionName = "VK_VALVE_descriptor_set_host_mapping";
		public const uint QcomFragmentDensityMapOffsetSpecVersion = 1;
		public const string QcomFragmentDensityMapOffsetExtensionName = "VK_QCOM_fragment_density_map_offset";
		public const uint NvLinearColorAttachmentSpecVersion = 1;
		public const string NvLinearColorAttachmentExtensionName = "VK_NV_linear_color_attachment";
		public const uint GoogleSurfacelessQuerySpecVersion = 1;
		public const string GoogleSurfacelessQueryExtensionName = "VK_GOOGLE_surfaceless_query";
		public const uint ExtImageCompressionControlSwapchainSpecVersion = 1;
		public const string ExtImageCompressionControlSwapchainExtensionName = "VK_EXT_image_compression_control_swapchain";
		public const uint ExtSubpassMergeFeedbackSpecVersion = 1;
		public const string ExtSubpassMergeFeedbackExtensionName = "VK_EXT_subpass_merge_feedback";
		private unsafe delegate VkResult CreateInstanceDelegate_0(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
		private unsafe delegate VkResult CreateInstanceDelegate_1(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
		private unsafe delegate VkResult CreateInstanceDelegate_2(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
		private unsafe delegate VkResult CreateInstanceDelegate_3(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
		private unsafe delegate void DestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyInstanceDelegate_1(VkInstance instance, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult EnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
		private unsafe delegate VkResult EnumeratePhysicalDevicesDelegate_1(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
		private unsafe delegate IntPtr GetDevicePrecedureAddressDelegate_0(VkDevice device, byte* name);
		private unsafe delegate IntPtr GetDevicePrecedureAddressDelegate_1(VkDevice device, string name);
		private unsafe delegate IntPtr GetInstancePrecedureAddressDelegate_0(VkInstance instance, byte* name);
		private unsafe delegate IntPtr GetInstancePrecedureAddressDelegate_1(VkInstance instance, string name);
		private unsafe delegate void GetPhysicalDevicePropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
		private unsafe delegate void GetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties);
		private unsafe delegate void GetPhysicalDeviceFeaturesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features);
		private unsafe delegate void GetPhysicalDeviceFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties);
		private unsafe delegate VkResult GetPhysicalDeviceImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties);
		private unsafe delegate VkResult CreateDeviceDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
		private unsafe delegate VkResult CreateDeviceDelegate_1(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
		private unsafe delegate VkResult CreateDeviceDelegate_2(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
		private unsafe delegate VkResult CreateDeviceDelegate_3(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
		private unsafe delegate void DestroyDeviceDelegate_0(VkDevice device, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDeviceDelegate_1(VkDevice device, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult EnumerateInstanceVersionDelegate_0([In, Out] uint[] apiVersion);
		private unsafe delegate VkResult EnumerateInstanceLayerPropertiesDelegate_0(uint* propertyCount, [In, Out] VkLayerProperties[] properties);
		private unsafe delegate VkResult EnumerateInstanceLayerPropertiesDelegate_1(ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
		private unsafe delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_0(byte* layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_1(byte* layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_2(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_3(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceLayerPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_1(VkPhysicalDevice physicalDevice, byte* layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_2(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_3(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
		private unsafe delegate void GetDeviceQueueDelegate_0(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue);
		private unsafe delegate VkResult QueueSubmitDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence);
		private unsafe delegate VkResult QueueWaitIdleDelegate_0(VkQueue queue);
		private unsafe delegate VkResult DeviceWaitIdleDelegate_0(VkDevice device);
		private unsafe delegate VkResult AllocateMemoryDelegate_0(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
		private unsafe delegate VkResult AllocateMemoryDelegate_1(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
		private unsafe delegate VkResult AllocateMemoryDelegate_2(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
		private unsafe delegate VkResult AllocateMemoryDelegate_3(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
		private unsafe delegate void FreeMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator);
		private unsafe delegate void FreeMemoryDelegate_1(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult MapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, uint flags, void** data);
		private unsafe delegate void UnmapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory);
		private unsafe delegate VkResult FlushMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
		private unsafe delegate VkResult InvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
		private unsafe delegate void GetDeviceMemoryCommitmentDelegate_0(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes);
		private unsafe delegate void GetBufferMemoryRequirementsDelegate_0(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements);
		private unsafe delegate VkResult BindBufferMemoryDelegate_0(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
		private unsafe delegate void GetImageMemoryRequirementsDelegate_0(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements);
		private unsafe delegate VkResult BindImageMemoryDelegate_0(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
		private unsafe delegate void GetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
		private unsafe delegate void GetImageSparseMemoryRequirementsDelegate_1(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
		private unsafe delegate VkResult QueueBindSparseDelegate_0(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence);
		private unsafe delegate VkResult QueueBindSparseDelegate_1(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence);
		private unsafe delegate VkResult CreateFenceDelegate_0(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
		private unsafe delegate VkResult CreateFenceDelegate_1(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
		private unsafe delegate VkResult CreateFenceDelegate_2(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
		private unsafe delegate VkResult CreateFenceDelegate_3(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
		private unsafe delegate void DestroyFenceDelegate_0(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyFenceDelegate_1(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult ResetFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences);
		private unsafe delegate VkResult GetFenceStatusDelegate_0(VkDevice device, VkFence fence);
		private unsafe delegate VkResult WaitForFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout);
		private unsafe delegate VkResult CreateSemaphoreDelegate_0(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
		private unsafe delegate VkResult CreateSemaphoreDelegate_1(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
		private unsafe delegate VkResult CreateSemaphoreDelegate_2(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
		private unsafe delegate VkResult CreateSemaphoreDelegate_3(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
		private unsafe delegate void DestroySemaphoreDelegate_0(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroySemaphoreDelegate_1(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateEventDelegate_0(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
		private unsafe delegate VkResult CreateEventDelegate_1(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
		private unsafe delegate VkResult CreateEventDelegate_2(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
		private unsafe delegate VkResult CreateEventDelegate_3(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
		private unsafe delegate void DestroyEventDelegate_0(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyEventDelegate_1(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetEventStatusDelegate_0(VkDevice device, VkEvent @event);
		private unsafe delegate VkResult SetEventDelegate_0(VkDevice device, VkEvent @event);
		private unsafe delegate VkResult ResetEventDelegate_0(VkDevice device, VkEvent @event);
		private unsafe delegate VkResult CreateQueryPoolDelegate_0(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
		private unsafe delegate VkResult CreateQueryPoolDelegate_1(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
		private unsafe delegate VkResult CreateQueryPoolDelegate_2(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
		private unsafe delegate VkResult CreateQueryPoolDelegate_3(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
		private unsafe delegate void DestroyQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyQueryPoolDelegate_1(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags);
		private unsafe delegate void ResetQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private unsafe delegate VkResult CreateBufferDelegate_0(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
		private unsafe delegate VkResult CreateBufferDelegate_1(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
		private unsafe delegate VkResult CreateBufferDelegate_2(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
		private unsafe delegate VkResult CreateBufferDelegate_3(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
		private unsafe delegate void DestroyBufferDelegate_0(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyBufferDelegate_1(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateBufferViewDelegate_0(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
		private unsafe delegate VkResult CreateBufferViewDelegate_1(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
		private unsafe delegate VkResult CreateBufferViewDelegate_2(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
		private unsafe delegate VkResult CreateBufferViewDelegate_3(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
		private unsafe delegate void DestroyBufferViewDelegate_0(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyBufferViewDelegate_1(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateImageDelegate_0(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image);
		private unsafe delegate VkResult CreateImageDelegate_1(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
		private unsafe delegate VkResult CreateImageDelegate_2(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image);
		private unsafe delegate VkResult CreateImageDelegate_3(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
		private unsafe delegate void DestroyImageDelegate_0(VkDevice device, VkImage image, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyImageDelegate_1(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator);
		private unsafe delegate void GetImageSubresourceLayoutDelegate_0(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout);
		private unsafe delegate void GetImageSubresourceLayoutDelegate_1(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout);
		private unsafe delegate VkResult CreateImageViewDelegate_0(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
		private unsafe delegate VkResult CreateImageViewDelegate_1(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
		private unsafe delegate VkResult CreateImageViewDelegate_2(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
		private unsafe delegate VkResult CreateImageViewDelegate_3(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
		private unsafe delegate void DestroyImageViewDelegate_0(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyImageViewDelegate_1(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateShaderModuleDelegate_0(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
		private unsafe delegate VkResult CreateShaderModuleDelegate_1(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
		private unsafe delegate VkResult CreateShaderModuleDelegate_2(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
		private unsafe delegate VkResult CreateShaderModuleDelegate_3(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
		private unsafe delegate void DestroyShaderModuleDelegate_0(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyShaderModuleDelegate_1(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreatePipelineCacheDelegate_0(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
		private unsafe delegate VkResult CreatePipelineCacheDelegate_1(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
		private unsafe delegate VkResult CreatePipelineCacheDelegate_2(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
		private unsafe delegate VkResult CreatePipelineCacheDelegate_3(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
		private unsafe delegate void DestroyPipelineCacheDelegate_0(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyPipelineCacheDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data);
		private unsafe delegate VkResult GetPipelineCacheDataDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data);
		private unsafe delegate VkResult MergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches);
		private unsafe delegate VkResult CreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateGraphicsPipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateComputePipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0(VkDevice device, VkRenderPass renderpass, out VkExtent2D maxWorkgroupSize);
		private unsafe delegate void DestroyPipelineDelegate_0(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyPipelineDelegate_1(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreatePipelineLayoutDelegate_0(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
		private unsafe delegate VkResult CreatePipelineLayoutDelegate_1(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
		private unsafe delegate VkResult CreatePipelineLayoutDelegate_2(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
		private unsafe delegate VkResult CreatePipelineLayoutDelegate_3(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
		private unsafe delegate void DestroyPipelineLayoutDelegate_0(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyPipelineLayoutDelegate_1(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateSamplerDelegate_0(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
		private unsafe delegate VkResult CreateSamplerDelegate_1(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
		private unsafe delegate VkResult CreateSamplerDelegate_2(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
		private unsafe delegate VkResult CreateSamplerDelegate_3(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
		private unsafe delegate void DestroySamplerDelegate_0(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroySamplerDelegate_1(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
		private unsafe delegate VkResult CreateDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
		private unsafe delegate VkResult CreateDescriptorSetLayoutDelegate_2(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
		private unsafe delegate VkResult CreateDescriptorSetLayoutDelegate_3(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
		private unsafe delegate void DestroyDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
		private unsafe delegate VkResult CreateDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
		private unsafe delegate VkResult CreateDescriptorPoolDelegate_2(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
		private unsafe delegate VkResult CreateDescriptorPoolDelegate_3(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
		private unsafe delegate void DestroyDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult ResetDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint flags);
		private unsafe delegate VkResult AllocateDescriptorSetsDelegate_0(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
		private unsafe delegate VkResult AllocateDescriptorSetsDelegate_1(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
		private unsafe delegate VkResult FreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets);
		private unsafe delegate void UpdateDescriptorSetsDelegate_0(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies);
		private unsafe delegate VkResult CreateFramebufferDelegate_0(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
		private unsafe delegate VkResult CreateFramebufferDelegate_1(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
		private unsafe delegate VkResult CreateFramebufferDelegate_2(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
		private unsafe delegate VkResult CreateFramebufferDelegate_3(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
		private unsafe delegate void DestroyFramebufferDelegate_0(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyFramebufferDelegate_1(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult CreateRenderPassDelegate_0(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPassDelegate_1(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPassDelegate_2(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPassDelegate_3(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
		private unsafe delegate void DestroyRenderPassDelegate_0(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyRenderPassDelegate_1(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator);
		private unsafe delegate void GetRenderAreaGranularityDelegate_0(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity);
		private unsafe delegate VkResult CreateCommandPoolDelegate_0(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
		private unsafe delegate VkResult CreateCommandPoolDelegate_1(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
		private unsafe delegate VkResult CreateCommandPoolDelegate_2(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
		private unsafe delegate VkResult CreateCommandPoolDelegate_3(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
		private unsafe delegate void DestroyCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyCommandPoolDelegate_1(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult ResetCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
		private unsafe delegate VkResult AllocateCommandBuffersDelegate_0(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
		private unsafe delegate VkResult AllocateCommandBuffersDelegate_1(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
		private unsafe delegate void FreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
		private unsafe delegate VkResult BeginCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo);
		private unsafe delegate VkResult BeginCommandBufferDelegate_1(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo);
		private unsafe delegate VkResult EndCommandBufferDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate VkResult ResetCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
		private unsafe delegate void CommandBindPipelineDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
		private unsafe delegate void CommandSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports);
		private unsafe delegate void CommandSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors);
		private unsafe delegate void CommandSetLineWidthDelegate_0(VkCommandBuffer commandBuffer, float lineWidth);
		private unsafe delegate void CommandSetDepthBiasDelegate_0(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		private unsafe delegate void CommandSetBlendConstantsDelegate_0(VkCommandBuffer commandBuffer, float blendConstants);
		private unsafe delegate void CommandSetDepthBoundsDelegate_0(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		private unsafe delegate void CommandSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
		private unsafe delegate void CommandSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
		private unsafe delegate void CommandSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
		private unsafe delegate void CommandBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets);
		private unsafe delegate void CommandBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
		private unsafe delegate void CommandBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets);
		private unsafe delegate void CommandBindVertexBuffersDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets);
		private unsafe delegate void CommandBindVertexBuffersDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets);
		private unsafe delegate void CommandBindVertexBuffersDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets);
		private unsafe delegate void CommandDrawDelegate_0(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private unsafe delegate void CommandDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		private unsafe delegate void CommandDrawMultiEXTDelegate_0(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* vertexInfo, uint instanceCount, uint firstInstance, uint stride);
		private unsafe delegate void CommandDrawMultiEXTDelegate_1(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT vertexInfo, uint instanceCount, uint firstInstance, uint stride);
		private unsafe delegate void CommandDrawMultiIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset);
		private unsafe delegate void CommandDrawMultiIndexedEXTDelegate_1(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset);
		private unsafe delegate void CommandDrawMultiIndexedEXTDelegate_2(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset);
		private unsafe delegate void CommandDrawMultiIndexedEXTDelegate_3(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset);
		private unsafe delegate void CommandDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
		private unsafe delegate void CommandDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
		private unsafe delegate void CommandDispatchDelegate_0(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private unsafe delegate void CommandDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
		private unsafe delegate void CommandSubpassShadingHUAWEIDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void CommandCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions);
		private unsafe delegate void CommandCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions);
		private unsafe delegate void CommandBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter);
		private unsafe delegate void CommandCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions);
		private unsafe delegate void CommandCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions);
		private unsafe delegate void CommandUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data);
		private unsafe delegate void CommandFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data);
		private unsafe delegate void CommandClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges);
		private unsafe delegate void CommandClearColorImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges);
		private unsafe delegate void CommandClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
		private unsafe delegate void CommandClearDepthStencilImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
		private unsafe delegate void CommandClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects);
		private unsafe delegate void CommandResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions);
		private unsafe delegate void CommandSetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
		private unsafe delegate void CommandResetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
		private unsafe delegate void CommandWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
		private unsafe delegate void CommandPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
		private unsafe delegate void CommandBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
		private unsafe delegate void CommandEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
		private unsafe delegate void CommandBeginConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* conditionalRenderingBegin);
		private unsafe delegate void CommandBeginConditionalRenderingEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT conditionalRenderingBegin);
		private unsafe delegate void CommandEndConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void CommandResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private unsafe delegate void CommandWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
		private unsafe delegate void CommandCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags);
		private unsafe delegate void CommandPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values);
		private unsafe delegate void CommandBeginRenderPassDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents);
		private unsafe delegate void CommandBeginRenderPassDelegate_1(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents);
		private unsafe delegate void CommandNextSubpassDelegate_0(VkCommandBuffer commandBuffer, VkSubpassContents contents);
		private unsafe delegate void CommandEndRenderPassDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void CommandExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
		private unsafe delegate VkResult CreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateAndroidSurfaceKHRDelegate_1(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateAndroidSurfaceKHRDelegate_2(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateAndroidSurfaceKHRDelegate_3(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
		private unsafe delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays);
		private unsafe delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_1(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays);
		private unsafe delegate VkResult GetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
		private unsafe delegate VkResult GetDisplayModePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
		private unsafe delegate VkResult CreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
		private unsafe delegate VkResult CreateDisplayModeKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
		private unsafe delegate VkResult CreateDisplayModeKHRDelegate_2(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
		private unsafe delegate VkResult CreateDisplayModeKHRDelegate_3(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
		private unsafe delegate VkResult GetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities);
		private unsafe delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_1(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_2(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_3(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains);
		private unsafe delegate VkResult CreateSharedSwapchainsKHRDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains);
		private unsafe delegate void DestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroySurfaceKHRDelegate_1(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult CreateSwapchainKHRDelegate_0(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
		private unsafe delegate VkResult CreateSwapchainKHRDelegate_1(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
		private unsafe delegate VkResult CreateSwapchainKHRDelegate_2(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
		private unsafe delegate VkResult CreateSwapchainKHRDelegate_3(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
		private unsafe delegate void DestroySwapchainKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroySwapchainKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages);
		private unsafe delegate VkResult GetSwapchainImagesKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages);
		private unsafe delegate VkResult AcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex);
		private unsafe delegate VkResult QueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* presentInfo);
		private unsafe delegate VkResult QueuePresentKHRDelegate_1(VkQueue queue, ref VkPresentInfoKHR presentInfo);
		private unsafe delegate VkResult CreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateWin32SurfaceKHRDelegate_1(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateWin32SurfaceKHRDelegate_2(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateWin32SurfaceKHRDelegate_3(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkBool32 GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
		private unsafe delegate VkResult CreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateXlibSurfaceKHRDelegate_1(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateXlibSurfaceKHRDelegate_2(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateXlibSurfaceKHRDelegate_3(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkBool32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);
		private unsafe delegate VkBool32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate_1(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref IntPtr dpy, IntPtr visualID);
		private unsafe delegate VkResult CreateDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
		private unsafe delegate VkResult CreateDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
		private unsafe delegate VkResult CreateDebugReportCallbackEXTDelegate_2(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
		private unsafe delegate VkResult CreateDebugReportCallbackEXTDelegate_3(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
		private unsafe delegate void DestroyDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator);
		private unsafe delegate void DebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message);
		private unsafe delegate void DebugReportMessageEXTDelegate_1(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, string message);
		private unsafe delegate void DebugReportMessageEXTDelegate_2(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, byte* message);
		private unsafe delegate void DebugReportMessageEXTDelegate_3(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message);
		private unsafe delegate VkResult DebugMarkerSetObjectNameEXTDelegate_0(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo);
		private unsafe delegate VkResult DebugMarkerSetObjectNameEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo);
		private unsafe delegate VkResult DebugMarkerSetObjectTagEXTDelegate_0(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo);
		private unsafe delegate VkResult DebugMarkerSetObjectTagEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo);
		private unsafe delegate void CommandDebugMarkerBeginEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
		private unsafe delegate void CommandDebugMarkerBeginEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
		private unsafe delegate void CommandDebugMarkerEndEXTDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void CommandDebugMarkerInsertEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
		private unsafe delegate void CommandDebugMarkerInsertEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
		private unsafe delegate VkResult GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties);
		private unsafe delegate VkResult GetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle);
		private unsafe delegate void CommandExecuteGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* generatedCommandsInfo);
		private unsafe delegate void CommandExecuteGeneratedCommandsNVDelegate_1(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV generatedCommandsInfo);
		private unsafe delegate void CommandPreprocessGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* generatedCommandsInfo);
		private unsafe delegate void CommandPreprocessGeneratedCommandsNVDelegate_1(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV generatedCommandsInfo);
		private unsafe delegate void CommandBindPipelineShaderGroupNVDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
		private unsafe delegate void GetGeneratedCommandsMemoryRequirementsNVDelegate_0(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetGeneratedCommandsMemoryRequirementsNVDelegate_1(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate VkResult CreateIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
		private unsafe delegate VkResult CreateIndirectCommandsLayoutNVDelegate_1(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
		private unsafe delegate VkResult CreateIndirectCommandsLayoutNVDelegate_2(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
		private unsafe delegate VkResult CreateIndirectCommandsLayoutNVDelegate_3(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
		private unsafe delegate void DestroyIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyIndirectCommandsLayoutNVDelegate_1(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks allocator);
		private unsafe delegate void GetPhysicalDeviceFeatures2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 features);
		private unsafe delegate void GetPhysicalDeviceProperties2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 properties);
		private unsafe delegate void GetPhysicalDeviceFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 formatProperties);
		private unsafe delegate VkResult GetPhysicalDeviceImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties);
		private unsafe delegate VkResult GetPhysicalDeviceImageFormatProperties2Delegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyProperties2Delegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyProperties2Delegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties);
		private unsafe delegate void GetPhysicalDeviceMemoryProperties2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 memoryProperties);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
		private unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
		private unsafe delegate void CommandPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites);
		private unsafe delegate void TrimCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, uint flags);
		private unsafe delegate void GetPhysicalDeviceExternalBufferPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* externalBufferInfo, out VkExternalBufferProperties externalBufferProperties);
		private unsafe delegate void GetPhysicalDeviceExternalBufferPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfo externalBufferInfo, out VkExternalBufferProperties externalBufferProperties);
		private unsafe delegate VkResult GetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult GetMemoryWin32HandleKHRDelegate_1(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult GetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties);
		private unsafe delegate VkResult GetMemoryFileDescriptorKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult GetMemoryFileDescriptorKHRDelegate_1(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult GetMemoryFileDescriptorPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties);
		private unsafe delegate VkResult GetMemoryRemoteAddressNVDelegate_0(VkDevice device, VkMemoryGetRemoteAddressInfoNV* memoryGetRemoteAddressInfo, void* address);
		private unsafe delegate VkResult GetMemoryRemoteAddressNVDelegate_1(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV memoryGetRemoteAddressInfo, void* address);
		private unsafe delegate void GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties);
		private unsafe delegate void GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties);
		private unsafe delegate VkResult GetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult GetSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo);
		private unsafe delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo);
		private unsafe delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo);
		private unsafe delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo);
		private unsafe delegate void GetPhysicalDeviceExternalFencePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* externalFenceInfo, out VkExternalFenceProperties externalFenceProperties);
		private unsafe delegate void GetPhysicalDeviceExternalFencePropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfo externalFenceInfo, out VkExternalFenceProperties externalFenceProperties);
		private unsafe delegate VkResult GetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult GetFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
		private unsafe delegate VkResult ImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo);
		private unsafe delegate VkResult ImportFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo);
		private unsafe delegate VkResult GetFenceFileDescriptorKHRDelegate_0(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult GetFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
		private unsafe delegate VkResult ImportFenceFileDescriptorKHRDelegate_0(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo);
		private unsafe delegate VkResult ImportFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo);
		private unsafe delegate VkResult ReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private unsafe delegate VkResult AcquireWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private unsafe delegate VkResult GetWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR display);
		private unsafe delegate VkResult DisplayPowerControlEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo);
		private unsafe delegate VkResult DisplayPowerControlEXTDelegate_1(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_0(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_1(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_2(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_3(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_4(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_5(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_6(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDeviceEventEXTDelegate_7(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_1(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_2(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_3(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_4(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_5(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_6(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
		private unsafe delegate VkResult RegisterDisplayEventEXTDelegate_7(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
		private unsafe delegate VkResult GetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities);
		private unsafe delegate VkResult EnumeratePhysicalDeviceGroupsDelegate_0(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties);
		private unsafe delegate VkResult EnumeratePhysicalDeviceGroupsDelegate_1(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties);
		private unsafe delegate void GetDeviceGroupPeerMemoryFeaturesDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlags peerMemoryFeatures);
		private unsafe delegate VkResult BindBufferMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos);
		private unsafe delegate VkResult BindImageMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos);
		private unsafe delegate void CommandSetDeviceMaskDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
		private unsafe delegate VkResult GetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR deviceGroupPresentCapabilities);
		private unsafe delegate VkResult GetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR modes);
		private unsafe delegate VkResult AcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* acquireInfo, out uint imageIndex);
		private unsafe delegate VkResult AcquireNextImage2KHRDelegate_1(VkDevice device, ref VkAcquireNextImageInfoKHR acquireInfo, out uint imageIndex);
		private unsafe delegate void CommandDispatchBaseDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		private unsafe delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects);
		private unsafe delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects);
		private unsafe delegate VkResult CreateDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
		private unsafe delegate VkResult CreateDescriptorUpdateTemplateDelegate_1(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
		private unsafe delegate VkResult CreateDescriptorUpdateTemplateDelegate_2(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
		private unsafe delegate VkResult CreateDescriptorUpdateTemplateDelegate_3(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
		private unsafe delegate void DestroyDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDescriptorUpdateTemplateDelegate_1(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, ref VkAllocationCallbacks allocator);
		private unsafe delegate void UpdateDescriptorSetWithTemplateDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* data);
		private unsafe delegate void CommandPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data);
		private unsafe delegate void SetHdrMetadataEXTDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata);
		private unsafe delegate void SetHdrMetadataEXTDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata);
		private unsafe delegate VkResult GetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
		private unsafe delegate VkResult GetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties);
		private unsafe delegate VkResult GetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
		private unsafe delegate VkResult GetPastPresentationTimingGOOGLEDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
		private unsafe delegate VkResult CreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateMacOSSurfaceMVKDelegate_1(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateMacOSSurfaceMVKDelegate_2(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateMacOSSurfaceMVKDelegate_3(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate void CommandSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings);
		private unsafe delegate void CommandSetViewportWScalingNVDelegate_1(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings);
		private unsafe delegate void CommandSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles);
		private unsafe delegate void CommandSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo);
		private unsafe delegate void CommandSetSampleLocationsEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo);
		private unsafe delegate void GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayProperties2KHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayProperties2KHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties);
		private unsafe delegate VkResult GetDisplayModeProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties);
		private unsafe delegate VkResult GetDisplayModeProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties);
		private unsafe delegate VkResult GetDisplayPlaneCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities);
		private unsafe delegate VkResult GetDisplayPlaneCapabilities2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities);
		private unsafe delegate void GetBufferMemoryRequirements2Delegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetBufferMemoryRequirements2Delegate_1(VkDevice device, ref VkBufferMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetImageMemoryRequirements2Delegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetImageMemoryRequirements2Delegate_1(VkDevice device, ref VkImageMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetImageSparseMemoryRequirements2Delegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetImageSparseMemoryRequirements2Delegate_1(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetImageSparseMemoryRequirements2Delegate_2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetImageSparseMemoryRequirements2Delegate_3(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetDeviceBufferMemoryRequirementsDelegate_0(VkDevice device, VkDeviceBufferMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetDeviceBufferMemoryRequirementsDelegate_1(VkDevice device, ref VkDeviceBufferMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetDeviceImageMemoryRequirementsDelegate_0(VkDevice device, VkDeviceImageMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetDeviceImageMemoryRequirementsDelegate_1(VkDevice device, ref VkDeviceImageMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetDeviceImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkDeviceImageMemoryRequirements* info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetDeviceImageSparseMemoryRequirementsDelegate_1(VkDevice device, VkDeviceImageMemoryRequirements* info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetDeviceImageSparseMemoryRequirementsDelegate_2(VkDevice device, ref VkDeviceImageMemoryRequirements info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate void GetDeviceImageSparseMemoryRequirementsDelegate_3(VkDevice device, ref VkDeviceImageMemoryRequirements info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
		private unsafe delegate VkResult CreateSamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion);
		private unsafe delegate VkResult CreateSamplerYcbcrConversionDelegate_1(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion);
		private unsafe delegate VkResult CreateSamplerYcbcrConversionDelegate_2(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion);
		private unsafe delegate VkResult CreateSamplerYcbcrConversionDelegate_3(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion);
		private unsafe delegate void DestroySamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroySamplerYcbcrConversionDelegate_1(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, ref VkAllocationCallbacks allocator);
		private unsafe delegate void GetDeviceQueue2Delegate_0(VkDevice device, VkDeviceQueueInfo2* queueInfo, out VkQueue queue);
		private unsafe delegate void GetDeviceQueue2Delegate_1(VkDevice device, ref VkDeviceQueueInfo2 queueInfo, out VkQueue queue);
		private unsafe delegate VkResult CreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
		private unsafe delegate VkResult CreateValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
		private unsafe delegate VkResult CreateValidationCacheEXTDelegate_2(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
		private unsafe delegate VkResult CreateValidationCacheEXTDelegate_3(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
		private unsafe delegate void DestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult GetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data);
		private unsafe delegate VkResult GetValidationCacheDataEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data);
		private unsafe delegate VkResult MergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches);
		private unsafe delegate void GetDescriptorSetLayoutSupportDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupport support);
		private unsafe delegate void GetDescriptorSetLayoutSupportDelegate_1(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupport support);
		private unsafe delegate VkResult GetSwapchainGrallocUsageANDROIDDelegate_0(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, out int grallocUsage);
		private unsafe delegate VkResult GetSwapchainGrallocUsage2ANDROIDDelegate_0(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, out ulong grallocProducerUsage);
		private unsafe delegate VkResult GetSwapchainGrallocUsage2ANDROIDDelegate_1(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, out ulong grallocProducerUsage);
		private unsafe delegate VkResult AcquireImageANDROIDDelegate_0(VkDevice device, VkImage image, int nativeFenceFileDescriptor, VkSemaphore semaphore, VkFence fence);
		private unsafe delegate VkResult QueueSignalReleaseImageANDROIDDelegate_0(VkQueue queue, uint waitSemaphoreCount, VkSemaphore[] waitSemaphores, VkImage image, int* nativeFenceFileDescriptor);
		private unsafe delegate VkResult QueueSignalReleaseImageANDROIDDelegate_1(VkQueue queue, uint waitSemaphoreCount, VkSemaphore[] waitSemaphores, VkImage image, ref int nativeFenceFileDescriptor);
		private unsafe delegate VkResult GetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info);
		private unsafe delegate VkResult GetShaderInfoAMDDelegate_1(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info);
		private unsafe delegate void SetLocalDimmingAMDDelegate_0(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
		private unsafe delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0(VkPhysicalDevice physicalDevice, uint* timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains);
		private unsafe delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1(VkPhysicalDevice physicalDevice, ref uint timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains);
		private unsafe delegate VkResult GetCalibratedTimestampsEXTDelegate_0(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ulong* timestamps, out ulong maxDeviation);
		private unsafe delegate VkResult GetCalibratedTimestampsEXTDelegate_1(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ref ulong timestamps, out ulong maxDeviation);
		private unsafe delegate VkResult SetDebugUtilsObjectNameEXTDelegate_0(VkDevice device, VkDebugUtilsObjectNameInfoEXT* nameInfo);
		private unsafe delegate VkResult SetDebugUtilsObjectNameEXTDelegate_1(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT nameInfo);
		private unsafe delegate VkResult SetDebugUtilsObjectTagEXTDelegate_0(VkDevice device, VkDebugUtilsObjectTagInfoEXT* tagInfo);
		private unsafe delegate VkResult SetDebugUtilsObjectTagEXTDelegate_1(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT tagInfo);
		private unsafe delegate void QueueBeginDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo);
		private unsafe delegate void QueueBeginDebugUtilsLabelEXTDelegate_1(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo);
		private unsafe delegate void QueueEndDebugUtilsLabelEXTDelegate_0(VkQueue queue);
		private unsafe delegate void QueueInsertDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo);
		private unsafe delegate void QueueInsertDebugUtilsLabelEXTDelegate_1(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo);
		private unsafe delegate void CommandBeginDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo);
		private unsafe delegate void CommandBeginDebugUtilsLabelEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo);
		private unsafe delegate void CommandEndDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void CommandInsertDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo);
		private unsafe delegate void CommandInsertDebugUtilsLabelEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo);
		private unsafe delegate VkResult CreateDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger);
		private unsafe delegate VkResult CreateDebugUtilsMessengerEXTDelegate_1(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger);
		private unsafe delegate VkResult CreateDebugUtilsMessengerEXTDelegate_2(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger);
		private unsafe delegate VkResult CreateDebugUtilsMessengerEXTDelegate_3(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger);
		private unsafe delegate void DestroyDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDebugUtilsMessengerEXTDelegate_1(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks allocator);
		private unsafe delegate void SubmitDebugUtilsMessageEXTDelegate_0(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData);
		private unsafe delegate void SubmitDebugUtilsMessageEXTDelegate_1(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT callbackData);
		private unsafe delegate VkResult GetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties);
		private unsafe delegate void CommandWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker);
		private unsafe delegate VkResult CreateRenderPass2Delegate_0(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPass2Delegate_1(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPass2Delegate_2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
		private unsafe delegate VkResult CreateRenderPass2Delegate_3(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
		private unsafe delegate void CommandBeginRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo);
		private unsafe delegate void CommandBeginRenderPass2Delegate_1(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo);
		private unsafe delegate void CommandBeginRenderPass2Delegate_2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo);
		private unsafe delegate void CommandBeginRenderPass2Delegate_3(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo);
		private unsafe delegate void CommandNextSubpass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo);
		private unsafe delegate void CommandNextSubpass2Delegate_1(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo);
		private unsafe delegate void CommandNextSubpass2Delegate_2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo);
		private unsafe delegate void CommandNextSubpass2Delegate_3(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo);
		private unsafe delegate void CommandEndRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfo* subpassEndInfo);
		private unsafe delegate void CommandEndRenderPass2Delegate_1(VkCommandBuffer commandBuffer, ref VkSubpassEndInfo subpassEndInfo);
		private unsafe delegate VkResult GetSemaphoreCounterValueDelegate_0(VkDevice device, VkSemaphore semaphore, out ulong value);
		private unsafe delegate VkResult WaitSemaphoresDelegate_0(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout);
		private unsafe delegate VkResult WaitSemaphoresDelegate_1(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout);
		private unsafe delegate VkResult SignalSemaphoreDelegate_0(VkDevice device, VkSemaphoreSignalInfo* signalInfo);
		private unsafe delegate VkResult SignalSemaphoreDelegate_1(VkDevice device, ref VkSemaphoreSignalInfo signalInfo);
		private unsafe delegate VkResult GetAndroidHardwareBufferPropertiesANDROIDDelegate_0(VkDevice device, IntPtr* buffer, out VkAndroidHardwareBufferPropertiesANDROID properties);
		private unsafe delegate VkResult GetAndroidHardwareBufferPropertiesANDROIDDelegate_1(VkDevice device, ref IntPtr buffer, out VkAndroidHardwareBufferPropertiesANDROID properties);
		private unsafe delegate VkResult GetMemoryAndroidHardwareBufferANDROIDDelegate_0(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* info, out IntPtr buffer);
		private unsafe delegate VkResult GetMemoryAndroidHardwareBufferANDROIDDelegate_1(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID info, out IntPtr buffer);
		private unsafe delegate void CommandDrawIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
		private unsafe delegate void CommandDrawIndexedIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
		private unsafe delegate void CommandSetCheckpointNVDelegate_0(VkCommandBuffer commandBuffer, void* checkpointMarker);
		private unsafe delegate void GetQueueCheckpointDataNVDelegate_0(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData);
		private unsafe delegate void GetQueueCheckpointDataNVDelegate_1(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_4(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_5(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_6(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes);
		private unsafe delegate void CommandBindTransformFeedbackBuffersEXTDelegate_7(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes);
		private unsafe delegate void CommandBeginTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets);
		private unsafe delegate void CommandBeginTransformFeedbackEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets);
		private unsafe delegate void CommandEndTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets);
		private unsafe delegate void CommandEndTransformFeedbackEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets);
		private unsafe delegate void CommandBeginQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
		private unsafe delegate void CommandEndQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
		private unsafe delegate void CommandDrawIndirectByteCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride);
		private unsafe delegate void CommandSetExclusiveScissorNVDelegate_0(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D[] exclusiveScissors);
		private unsafe delegate void CommandBindShadingRateImageNVDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private unsafe delegate void CommandSetViewportShadingRatePaletteNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* shadingRatePalettes);
		private unsafe delegate void CommandSetViewportShadingRatePaletteNVDelegate_1(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV shadingRatePalettes);
		private unsafe delegate void CommandSetCoarseSampleOrderNVDelegate_0(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV[] customSampleOrders);
		private unsafe delegate void CommandDrawMeshTasksNVDelegate_0(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
		private unsafe delegate void CommandDrawMeshTasksIndirectNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
		private unsafe delegate void CommandDrawMeshTasksIndirectCountNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
		private unsafe delegate VkResult CompileDeferredNVDelegate_0(VkDevice device, VkPipeline pipeline, uint shader);
		private unsafe delegate VkResult CreateAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureNVDelegate_1(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureNVDelegate_2(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureNVDelegate_3(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure);
		private unsafe delegate void CommandBindInvocationMaskHUAWEIDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private unsafe delegate void DestroyAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyAccelerationStructureKHRDelegate_1(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks allocator);
		private unsafe delegate void DestroyAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyAccelerationStructureNVDelegate_1(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks allocator);
		private unsafe delegate void GetAccelerationStructureMemoryRequirementsNVDelegate_0(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate void GetAccelerationStructureMemoryRequirementsNVDelegate_1(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements);
		private unsafe delegate VkResult BindAccelerationStructureMemoryNVDelegate_0(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] bindInfos);
		private unsafe delegate void CommandCopyAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkCopyAccelerationStructureModeKHR mode);
		private unsafe delegate void CommandCopyAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* info);
		private unsafe delegate void CommandCopyAccelerationStructureKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR info);
		private unsafe delegate VkResult CopyAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* info);
		private unsafe delegate VkResult CopyAccelerationStructureKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR info);
		private unsafe delegate void CommandCopyAccelerationStructureToMemoryKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* info);
		private unsafe delegate void CommandCopyAccelerationStructureToMemoryKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR info);
		private unsafe delegate VkResult CopyAccelerationStructureToMemoryKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* info);
		private unsafe delegate VkResult CopyAccelerationStructureToMemoryKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR info);
		private unsafe delegate void CommandCopyMemoryToAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* info);
		private unsafe delegate void CommandCopyMemoryToAccelerationStructureKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR info);
		private unsafe delegate VkResult CopyMemoryToAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* info);
		private unsafe delegate VkResult CopyMemoryToAccelerationStructureKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR info);
		private unsafe delegate void CommandWriteAccelerationStructuresPropertiesKHRDelegate_0(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private unsafe delegate void CommandWriteAccelerationStructuresPropertiesNVDelegate_0(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private unsafe delegate void CommandBuildAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset);
		private unsafe delegate void CommandBuildAccelerationStructureNVDelegate_1(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset);
		private unsafe delegate VkResult WriteAccelerationStructuresPropertiesKHRDelegate_0(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, nuint dataSize, void* data, nuint stride);
		private unsafe delegate void CommandTraceRaysKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_1(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_2(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_3(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_4(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_5(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_6(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_7(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_8(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_9(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_10(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_11(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_12(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_13(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_14(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysKHRDelegate_15(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
		private unsafe delegate void CommandTraceRaysNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth);
		private unsafe delegate VkResult GetRayTracingShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data);
		private unsafe delegate VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data);
		private unsafe delegate VkResult GetAccelerationStructureHandleNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* data);
		private unsafe delegate VkResult CreateRayTracingPipelinesNVDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateRayTracingPipelinesNVDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateRayTracingPipelinesKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult CreateRayTracingPipelinesKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
		private unsafe delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties);
		private unsafe delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_1(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_2(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_3(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_4(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_5(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_6(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_7(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_8(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_9(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_10(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_11(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_12(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_13(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_14(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirectKHRDelegate_15(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void CommandTraceRaysIndirect2KHRDelegate_0(VkCommandBuffer commandBuffer, VkDeviceAddress indirectDeviceAddress);
		private unsafe delegate void GetDeviceAccelerationStructureCompatibilityKHRDelegate_0(VkDevice device, VkAccelerationStructureVersionInfoKHR* versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility);
		private unsafe delegate void GetDeviceAccelerationStructureCompatibilityKHRDelegate_1(VkDevice device, ref VkAccelerationStructureVersionInfoKHR versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility);
		private unsafe delegate VkDeviceSize GetRayTracingShaderGroupStackSizeKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader);
		private unsafe delegate void CommandSetRayTracingPipelineStackSizeKHRDelegate_0(VkCommandBuffer commandBuffer, uint pipelineStackSize);
		private unsafe delegate uint GetImageViewHandleNVXDelegate_0(VkDevice device, out VkImageViewHandleInfoNVX info);
		private unsafe delegate VkResult GetImageViewAddressNVXDelegate_0(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX properties);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
		private unsafe delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes);
		private unsafe delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_1(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes);
		private unsafe delegate VkResult AcquireFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
		private unsafe delegate VkResult ReleaseFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
		private unsafe delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions);
		private unsafe delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* performanceQueryCreateInfo, out uint numPasses);
		private unsafe delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR performanceQueryCreateInfo, out uint numPasses);
		private unsafe delegate VkResult AcquireProfilingLockKHRDelegate_0(VkDevice device, VkAcquireProfilingLockInfoKHR* info);
		private unsafe delegate VkResult AcquireProfilingLockKHRDelegate_1(VkDevice device, ref VkAcquireProfilingLockInfoKHR info);
		private unsafe delegate void ReleaseProfilingLockKHRDelegate_0(VkDevice device);
		private unsafe delegate VkResult GetImageDrmFormatModifierPropertiesEXTDelegate_0(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT properties);
		private unsafe delegate ulong GetBufferOpaqueCaptureAddressDelegate_0(VkDevice device, out VkBufferDeviceAddressInfo info);
		private unsafe delegate VkDeviceAddress GetBufferDeviceAddressDelegate_0(VkDevice device, out VkBufferDeviceAddressInfo info);
		private unsafe delegate VkResult CreateHeadlessSurfaceEXTDelegate_0(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateHeadlessSurfaceEXTDelegate_1(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateHeadlessSurfaceEXTDelegate_2(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult CreateHeadlessSurfaceEXTDelegate_3(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
		private unsafe delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0(VkPhysicalDevice physicalDevice, uint* combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations);
		private unsafe delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1(VkPhysicalDevice physicalDevice, ref uint combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations);
		private unsafe delegate VkResult InitializePerformanceApiINTELDelegate_0(VkDevice device, VkInitializePerformanceApiInfoINTEL* initializeInfo);
		private unsafe delegate VkResult InitializePerformanceApiINTELDelegate_1(VkDevice device, ref VkInitializePerformanceApiInfoINTEL initializeInfo);
		private unsafe delegate void UninitializePerformanceApiINTELDelegate_0(VkDevice device);
		private unsafe delegate VkResult CommandSetPerformanceMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* markerInfo);
		private unsafe delegate VkResult CommandSetPerformanceMarkerINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL markerInfo);
		private unsafe delegate VkResult CommandSetPerformanceStreamMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* markerInfo);
		private unsafe delegate VkResult CommandSetPerformanceStreamMarkerINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL markerInfo);
		private unsafe delegate VkResult CommandSetPerformanceOverrideINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* overrideInfo);
		private unsafe delegate VkResult CommandSetPerformanceOverrideINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL overrideInfo);
		private unsafe delegate VkResult AcquirePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, VkPerformanceConfigurationINTEL* configuration);
		private unsafe delegate VkResult AcquirePerformanceConfigurationINTELDelegate_1(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, ref VkPerformanceConfigurationINTEL configuration);
		private unsafe delegate VkResult AcquirePerformanceConfigurationINTELDelegate_2(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, VkPerformanceConfigurationINTEL* configuration);
		private unsafe delegate VkResult AcquirePerformanceConfigurationINTELDelegate_3(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, ref VkPerformanceConfigurationINTEL configuration);
		private unsafe delegate VkResult ReleasePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationINTEL configuration);
		private unsafe delegate VkResult QueueSetPerformanceConfigurationINTELDelegate_0(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
		private unsafe delegate VkResult GetPerformanceParameterINTELDelegate_0(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL value);
		private unsafe delegate ulong GetDeviceMemoryOpaqueCaptureAddressDelegate_0(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfo info);
		private unsafe delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_0(VkDevice device, VkPipelineInfoKHR* pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
		private unsafe delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_1(VkDevice device, VkPipelineInfoKHR* pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
		private unsafe delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_2(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
		private unsafe delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_3(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
		private unsafe delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
		private unsafe delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_1(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
		private unsafe delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_2(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
		private unsafe delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_3(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
		private unsafe delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
		private unsafe delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_1(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
		private unsafe delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_2(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
		private unsafe delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_3(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
		private unsafe delegate void CommandSetLineStippleEXTDelegate_0(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		private unsafe delegate VkResult GetPhysicalDeviceToolPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* toolCount, out VkPhysicalDeviceToolProperties toolProperties);
		private unsafe delegate VkResult GetPhysicalDeviceToolPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint toolCount, out VkPhysicalDeviceToolProperties toolProperties);
		private unsafe delegate VkResult CreateAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureKHRDelegate_1(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureKHRDelegate_2(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure);
		private unsafe delegate VkResult CreateAccelerationStructureKHRDelegate_3(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure);
		private unsafe delegate void CommandBuildAccelerationStructuresKHRDelegate_0(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] pBuildRangeInfos);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_1(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, ref uint pMaxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_2(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_3(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, ref uint pMaxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_4(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_5(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, ref uint pMaxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_6(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts);
		private unsafe delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_7(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, ref uint pMaxPrimitiveCounts);
		private unsafe delegate VkResult BuildAccelerationStructuresKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] pBuildRangeInfos);
		private unsafe delegate VkDeviceAddress GetAccelerationStructureDeviceAddressKHRDelegate_0(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR info);
		private unsafe delegate VkResult CreateDeferredOperationKHRDelegate_0(VkDevice device, VkAllocationCallbacks* allocator, out VkDeferredOperationKHR deferredOperation);
		private unsafe delegate VkResult CreateDeferredOperationKHRDelegate_1(VkDevice device, ref VkAllocationCallbacks allocator, out VkDeferredOperationKHR deferredOperation);
		private unsafe delegate void DestroyDeferredOperationKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyDeferredOperationKHRDelegate_1(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks allocator);
		private unsafe delegate uint GetDeferredOperationMaxConcurrencyKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
		private unsafe delegate VkResult GetDeferredOperationResultKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
		private unsafe delegate VkResult DeferredOperationJoinKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
		private unsafe delegate void CommandSetCullModeDelegate_0(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
		private unsafe delegate void CommandSetFrontFaceDelegate_0(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
		private unsafe delegate void CommandSetPrimitiveTopologyDelegate_0(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
		private unsafe delegate void CommandSetViewportWithCountDelegate_0(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport[] viewports);
		private unsafe delegate void CommandSetScissorWithCountDelegate_0(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D[] scissors);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_4(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_5(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_6(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_7(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_8(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_9(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_10(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_11(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_12(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_13(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_14(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
		private unsafe delegate void CommandBindVertexBuffers2Delegate_15(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
		private unsafe delegate void CommandSetDepthTestEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
		private unsafe delegate void CommandSetDepthWriteEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
		private unsafe delegate void CommandSetDepthCompareOpDelegate_0(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
		private unsafe delegate void CommandSetDepthBoundsTestEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
		private unsafe delegate void CommandSetStencilTestEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
		private unsafe delegate void CommandSetStencilOpDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
		private unsafe delegate void CommandSetPatchControlPointsEXTDelegate_0(VkCommandBuffer commandBuffer, uint patchControlPoints);
		private unsafe delegate void CommandSetRasterizerDiscardEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
		private unsafe delegate void CommandSetDepthBiasEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
		private unsafe delegate void CommandSetLogicOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
		private unsafe delegate void CommandSetPrimitiveRestartEnableDelegate_0(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
		private unsafe delegate VkResult CreatePrivateDataSlotDelegate_0(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot);
		private unsafe delegate VkResult CreatePrivateDataSlotDelegate_1(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot);
		private unsafe delegate VkResult CreatePrivateDataSlotDelegate_2(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot);
		private unsafe delegate VkResult CreatePrivateDataSlotDelegate_3(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot);
		private unsafe delegate void DestroyPrivateDataSlotDelegate_0(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyPrivateDataSlotDelegate_1(VkDevice device, VkPrivateDataSlot privateDataSlot, ref VkAllocationCallbacks allocator);
		private unsafe delegate VkResult SetPrivateDataDelegate_0(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data);
		private unsafe delegate void GetPrivateDataDelegate_0(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, out ulong data);
		private unsafe delegate void CommandCopyBuffer2Delegate_0(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* copyBufferInfo);
		private unsafe delegate void CommandCopyBuffer2Delegate_1(VkCommandBuffer commandBuffer, ref VkCopyBufferInfo2 copyBufferInfo);
		private unsafe delegate void CommandCopyImage2Delegate_0(VkCommandBuffer commandBuffer, VkCopyImageInfo2* copyImageInfo);
		private unsafe delegate void CommandCopyImage2Delegate_1(VkCommandBuffer commandBuffer, ref VkCopyImageInfo2 copyImageInfo);
		private unsafe delegate void CommandBlitImage2Delegate_0(VkCommandBuffer commandBuffer, VkBlitImageInfo2* blitImageInfo);
		private unsafe delegate void CommandBlitImage2Delegate_1(VkCommandBuffer commandBuffer, ref VkBlitImageInfo2 blitImageInfo);
		private unsafe delegate void CommandCopyBufferToImage2Delegate_0(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* copyBufferToImageInfo);
		private unsafe delegate void CommandCopyBufferToImage2Delegate_1(VkCommandBuffer commandBuffer, ref VkCopyBufferToImageInfo2 copyBufferToImageInfo);
		private unsafe delegate void CommandCopyImageToBuffer2Delegate_0(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* copyImageToBufferInfo);
		private unsafe delegate void CommandCopyImageToBuffer2Delegate_1(VkCommandBuffer commandBuffer, ref VkCopyImageToBufferInfo2 copyImageToBufferInfo);
		private unsafe delegate void CommandResolveImage2Delegate_0(VkCommandBuffer commandBuffer, VkResolveImageInfo2* resolveImageInfo);
		private unsafe delegate void CommandResolveImage2Delegate_1(VkCommandBuffer commandBuffer, ref VkResolveImageInfo2 resolveImageInfo);
		private unsafe delegate void CommandSetFragmentShadingRateKHRDelegate_0(VkCommandBuffer commandBuffer, VkExtent2D* fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private unsafe delegate void CommandSetFragmentShadingRateKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkExtent2D fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private unsafe delegate VkResult GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates);
		private unsafe delegate VkResult GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates);
		private unsafe delegate void CommandSetFragmentShadingRateEnumNVDelegate_0(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private unsafe delegate void GetAccelerationStructureBuildSizesKHRDelegate_0(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, uint* maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo);
		private unsafe delegate void GetAccelerationStructureBuildSizesKHRDelegate_1(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, ref uint maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo);
		private unsafe delegate void GetAccelerationStructureBuildSizesKHRDelegate_2(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, uint* maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo);
		private unsafe delegate void GetAccelerationStructureBuildSizesKHRDelegate_3(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, ref uint maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo);
		private unsafe delegate void CommandSetVertexInputEXTDelegate_0(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT[] vertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT[] vertexAttributeDescriptions);
		private unsafe delegate void CommandSetColorWriteEnableEXTDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* colorWriteEnables);
		private unsafe delegate void CommandSetColorWriteEnableEXTDelegate_1(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 colorWriteEnables);
		private unsafe delegate void CommandSetEvent2Delegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* dependencyInfo);
		private unsafe delegate void CommandSetEvent2Delegate_1(VkCommandBuffer commandBuffer, VkEvent @event, ref VkDependencyInfo dependencyInfo);
		private unsafe delegate void CommandResetEvent2Delegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask);
		private unsafe delegate void CommandWaitEvents2Delegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkDependencyInfo[] dependencyInfos);
		private unsafe delegate void CommandPipelineBarrier2Delegate_0(VkCommandBuffer commandBuffer, VkDependencyInfo* dependencyInfo);
		private unsafe delegate void CommandPipelineBarrier2Delegate_1(VkCommandBuffer commandBuffer, ref VkDependencyInfo dependencyInfo);
		private unsafe delegate VkResult QueueSubmit2Delegate_0(VkQueue queue, uint submitCount, VkSubmitInfo2[] submits, VkFence fence);
		private unsafe delegate void CommandWriteTimestamp2Delegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, uint query);
		private unsafe delegate void CommandWriteBufferMarker2AMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker);
		private unsafe delegate void GetQueueCheckpointData2NVDelegate_0(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData);
		private unsafe delegate void GetQueueCheckpointData2NVDelegate_1(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData);
		private unsafe delegate VkResult CreateCuModuleNVXDelegate_0(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module);
		private unsafe delegate VkResult CreateCuModuleNVXDelegate_1(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module);
		private unsafe delegate VkResult CreateCuModuleNVXDelegate_2(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module);
		private unsafe delegate VkResult CreateCuModuleNVXDelegate_3(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module);
		private unsafe delegate VkResult CreateCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function);
		private unsafe delegate VkResult CreateCuFunctionNVXDelegate_1(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function);
		private unsafe delegate VkResult CreateCuFunctionNVXDelegate_2(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function);
		private unsafe delegate VkResult CreateCuFunctionNVXDelegate_3(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function);
		private unsafe delegate void DestroyCuModuleNVXDelegate_0(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyCuModuleNVXDelegate_1(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks allocator);
		private unsafe delegate void DestroyCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* allocator);
		private unsafe delegate void DestroyCuFunctionNVXDelegate_1(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks allocator);
		private unsafe delegate void CommandCuLaunchKernelNVXDelegate_0(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* launchInfo);
		private unsafe delegate void CommandCuLaunchKernelNVXDelegate_1(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX launchInfo);
		private unsafe delegate void SetDeviceMemoryPriorityEXTDelegate_0(VkDevice device, VkDeviceMemory memory, float priority);
		private unsafe delegate VkResult AcquireDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int drmFileDescriptor, VkDisplayKHR display);
		private unsafe delegate VkResult GetDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int drmFileDescriptor, uint connectorId, out VkDisplayKHR display);
		private unsafe delegate VkResult WaitForPresentKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout);
		private unsafe delegate void CommandBeginRenderingDelegate_0(VkCommandBuffer commandBuffer, VkRenderingInfo* renderingInfo);
		private unsafe delegate void CommandBeginRenderingDelegate_1(VkCommandBuffer commandBuffer, ref VkRenderingInfo renderingInfo);
		private unsafe delegate void CommandEndRenderingDelegate_0(VkCommandBuffer commandBuffer);
		private unsafe delegate void GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_0(VkDevice device, VkDescriptorSetBindingReferenceVALVE* bindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE hostMapping);
		private unsafe delegate void GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_1(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE bindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE hostMapping);
		private unsafe delegate void GetDescriptorSetHostMappingVALVEDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, void** data);
		private unsafe delegate void GetImageSubresourceLayout2EXTDelegate_0(VkDevice device, VkImage image, VkImageSubresource2EXT* subresource, out VkSubresourceLayout2EXT layout);
		private unsafe delegate void GetImageSubresourceLayout2EXTDelegate_1(VkDevice device, VkImage image, ref VkImageSubresource2EXT subresource, out VkSubresourceLayout2EXT layout);
		private unsafe delegate VkResult GetPipelinePropertiesEXTDelegate_0(VkDevice device, VkPipelineInfoEXT* pipelineInfo, out VkBaseOutStructure pipelineProperties);
		private unsafe delegate VkResult GetPipelinePropertiesEXTDelegate_1(VkDevice device, ref VkPipelineInfoEXT pipelineInfo, out VkBaseOutStructure pipelineProperties);
		private static readonly OSVulkanLibraryBase VulkanLibrary;
		private static IntPtr CreateInstancePointer;
		private static CreateInstanceDelegate_0 CreateInstance_0;
		private static CreateInstanceDelegate_1 CreateInstance_1;
		private static CreateInstanceDelegate_2 CreateInstance_2;
		private static CreateInstanceDelegate_3 CreateInstance_3;
		private static IntPtr DestroyInstancePointer;
		private static DestroyInstanceDelegate_0 DestroyInstance_0;
		private static DestroyInstanceDelegate_1 DestroyInstance_1;
		private static IntPtr EnumeratePhysicalDevicesPointer;
		private static EnumeratePhysicalDevicesDelegate_0 EnumeratePhysicalDevices_0;
		private static EnumeratePhysicalDevicesDelegate_1 EnumeratePhysicalDevices_1;
		private static IntPtr GetDevicePrecedureAddressPointer;
		private static GetDevicePrecedureAddressDelegate_0 GetDevicePrecedureAddress_0;
		private static GetDevicePrecedureAddressDelegate_1 GetDevicePrecedureAddress_1;
		private static IntPtr GetInstancePrecedureAddressPointer;
		private static GetInstancePrecedureAddressDelegate_0 GetInstancePrecedureAddress_0;
		private static GetInstancePrecedureAddressDelegate_1 GetInstancePrecedureAddress_1;
		private static IntPtr GetPhysicalDevicePropertiesPointer;
		private static GetPhysicalDevicePropertiesDelegate_0 GetPhysicalDeviceProperties_0;
		private static IntPtr GetPhysicalDeviceQueueFamilyPropertiesPointer;
		private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_0 GetPhysicalDeviceQueueFamilyProperties_0;
		private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_1 GetPhysicalDeviceQueueFamilyProperties_1;
		private static IntPtr GetPhysicalDeviceMemoryPropertiesPointer;
		private static GetPhysicalDeviceMemoryPropertiesDelegate_0 GetPhysicalDeviceMemoryProperties_0;
		private static IntPtr GetPhysicalDeviceFeaturesPointer;
		private static GetPhysicalDeviceFeaturesDelegate_0 GetPhysicalDeviceFeatures_0;
		private static IntPtr GetPhysicalDeviceFormatPropertiesPointer;
		private static GetPhysicalDeviceFormatPropertiesDelegate_0 GetPhysicalDeviceFormatProperties_0;
		private static IntPtr GetPhysicalDeviceImageFormatPropertiesPointer;
		private static GetPhysicalDeviceImageFormatPropertiesDelegate_0 GetPhysicalDeviceImageFormatProperties_0;
		private static IntPtr CreateDevicePointer;
		private static CreateDeviceDelegate_0 CreateDevice_0;
		private static CreateDeviceDelegate_1 CreateDevice_1;
		private static CreateDeviceDelegate_2 CreateDevice_2;
		private static CreateDeviceDelegate_3 CreateDevice_3;
		private static IntPtr DestroyDevicePointer;
		private static DestroyDeviceDelegate_0 DestroyDevice_0;
		private static DestroyDeviceDelegate_1 DestroyDevice_1;
		private static IntPtr EnumerateInstanceVersionPointer;
		private static EnumerateInstanceVersionDelegate_0 EnumerateInstanceVersion_0;
		private static IntPtr EnumerateInstanceLayerPropertiesPointer;
		private static EnumerateInstanceLayerPropertiesDelegate_0 EnumerateInstanceLayerProperties_0;
		private static EnumerateInstanceLayerPropertiesDelegate_1 EnumerateInstanceLayerProperties_1;
		private static IntPtr EnumerateInstanceExtensionPropertiesPointer;
		private static EnumerateInstanceExtensionPropertiesDelegate_0 EnumerateInstanceExtensionProperties_0;
		private static EnumerateInstanceExtensionPropertiesDelegate_1 EnumerateInstanceExtensionProperties_1;
		private static EnumerateInstanceExtensionPropertiesDelegate_2 EnumerateInstanceExtensionProperties_2;
		private static EnumerateInstanceExtensionPropertiesDelegate_3 EnumerateInstanceExtensionProperties_3;
		private static IntPtr EnumerateDeviceLayerPropertiesPointer;
		private static EnumerateDeviceLayerPropertiesDelegate_0 EnumerateDeviceLayerProperties_0;
		private static EnumerateDeviceLayerPropertiesDelegate_1 EnumerateDeviceLayerProperties_1;
		private static IntPtr EnumerateDeviceExtensionPropertiesPointer;
		private static EnumerateDeviceExtensionPropertiesDelegate_0 EnumerateDeviceExtensionProperties_0;
		private static EnumerateDeviceExtensionPropertiesDelegate_1 EnumerateDeviceExtensionProperties_1;
		private static EnumerateDeviceExtensionPropertiesDelegate_2 EnumerateDeviceExtensionProperties_2;
		private static EnumerateDeviceExtensionPropertiesDelegate_3 EnumerateDeviceExtensionProperties_3;
		private static IntPtr GetDeviceQueuePointer;
		private static GetDeviceQueueDelegate_0 GetDeviceQueue_0;
		private static IntPtr QueueSubmitPointer;
		private static QueueSubmitDelegate_0 QueueSubmit_0;
		private static IntPtr QueueWaitIdlePointer;
		private static QueueWaitIdleDelegate_0 QueueWaitIdle_0;
		private static IntPtr DeviceWaitIdlePointer;
		private static DeviceWaitIdleDelegate_0 DeviceWaitIdle_0;
		private static IntPtr AllocateMemoryPointer;
		private static AllocateMemoryDelegate_0 AllocateMemory_0;
		private static AllocateMemoryDelegate_1 AllocateMemory_1;
		private static AllocateMemoryDelegate_2 AllocateMemory_2;
		private static AllocateMemoryDelegate_3 AllocateMemory_3;
		private static IntPtr FreeMemoryPointer;
		private static FreeMemoryDelegate_0 FreeMemory_0;
		private static FreeMemoryDelegate_1 FreeMemory_1;
		private static IntPtr MapMemoryPointer;
		private static MapMemoryDelegate_0 MapMemory_0;
		private static IntPtr UnmapMemoryPointer;
		private static UnmapMemoryDelegate_0 UnmapMemory_0;
		private static IntPtr FlushMappedMemoryRangesPointer;
		private static FlushMappedMemoryRangesDelegate_0 FlushMappedMemoryRanges_0;
		private static IntPtr InvalidateMappedMemoryRangesPointer;
		private static InvalidateMappedMemoryRangesDelegate_0 InvalidateMappedMemoryRanges_0;
		private static IntPtr GetDeviceMemoryCommitmentPointer;
		private static GetDeviceMemoryCommitmentDelegate_0 GetDeviceMemoryCommitment_0;
		private static IntPtr GetBufferMemoryRequirementsPointer;
		private static GetBufferMemoryRequirementsDelegate_0 GetBufferMemoryRequirements_0;
		private static IntPtr BindBufferMemoryPointer;
		private static BindBufferMemoryDelegate_0 BindBufferMemory_0;
		private static IntPtr GetImageMemoryRequirementsPointer;
		private static GetImageMemoryRequirementsDelegate_0 GetImageMemoryRequirements_0;
		private static IntPtr BindImageMemoryPointer;
		private static BindImageMemoryDelegate_0 BindImageMemory_0;
		private static IntPtr GetImageSparseMemoryRequirementsPointer;
		private static GetImageSparseMemoryRequirementsDelegate_0 GetImageSparseMemoryRequirements_0;
		private static GetImageSparseMemoryRequirementsDelegate_1 GetImageSparseMemoryRequirements_1;
		private static IntPtr GetPhysicalDeviceSparseImageFormatPropertiesPointer;
		private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 GetPhysicalDeviceSparseImageFormatProperties_0;
		private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1 GetPhysicalDeviceSparseImageFormatProperties_1;
		private static IntPtr QueueBindSparsePointer;
		private static QueueBindSparseDelegate_0 QueueBindSparse_0;
		private static QueueBindSparseDelegate_1 QueueBindSparse_1;
		private static IntPtr CreateFencePointer;
		private static CreateFenceDelegate_0 CreateFence_0;
		private static CreateFenceDelegate_1 CreateFence_1;
		private static CreateFenceDelegate_2 CreateFence_2;
		private static CreateFenceDelegate_3 CreateFence_3;
		private static IntPtr DestroyFencePointer;
		private static DestroyFenceDelegate_0 DestroyFence_0;
		private static DestroyFenceDelegate_1 DestroyFence_1;
		private static IntPtr ResetFencesPointer;
		private static ResetFencesDelegate_0 ResetFences_0;
		private static IntPtr GetFenceStatusPointer;
		private static GetFenceStatusDelegate_0 GetFenceStatus_0;
		private static IntPtr WaitForFencesPointer;
		private static WaitForFencesDelegate_0 WaitForFences_0;
		private static IntPtr CreateSemaphorePointer;
		private static CreateSemaphoreDelegate_0 CreateSemaphore_0;
		private static CreateSemaphoreDelegate_1 CreateSemaphore_1;
		private static CreateSemaphoreDelegate_2 CreateSemaphore_2;
		private static CreateSemaphoreDelegate_3 CreateSemaphore_3;
		private static IntPtr DestroySemaphorePointer;
		private static DestroySemaphoreDelegate_0 DestroySemaphore_0;
		private static DestroySemaphoreDelegate_1 DestroySemaphore_1;
		private static IntPtr CreateEventPointer;
		private static CreateEventDelegate_0 CreateEvent_0;
		private static CreateEventDelegate_1 CreateEvent_1;
		private static CreateEventDelegate_2 CreateEvent_2;
		private static CreateEventDelegate_3 CreateEvent_3;
		private static IntPtr DestroyEventPointer;
		private static DestroyEventDelegate_0 DestroyEvent_0;
		private static DestroyEventDelegate_1 DestroyEvent_1;
		private static IntPtr GetEventStatusPointer;
		private static GetEventStatusDelegate_0 GetEventStatus_0;
		private static IntPtr SetEventPointer;
		private static SetEventDelegate_0 SetEvent_0;
		private static IntPtr ResetEventPointer;
		private static ResetEventDelegate_0 ResetEvent_0;
		private static IntPtr CreateQueryPoolPointer;
		private static CreateQueryPoolDelegate_0 CreateQueryPool_0;
		private static CreateQueryPoolDelegate_1 CreateQueryPool_1;
		private static CreateQueryPoolDelegate_2 CreateQueryPool_2;
		private static CreateQueryPoolDelegate_3 CreateQueryPool_3;
		private static IntPtr DestroyQueryPoolPointer;
		private static DestroyQueryPoolDelegate_0 DestroyQueryPool_0;
		private static DestroyQueryPoolDelegate_1 DestroyQueryPool_1;
		private static IntPtr GetQueryPoolResultsPointer;
		private static GetQueryPoolResultsDelegate_0 GetQueryPoolResults_0;
		private static IntPtr ResetQueryPoolPointer;
		private static ResetQueryPoolDelegate_0 ResetQueryPool_0;
		private static IntPtr CreateBufferPointer;
		private static CreateBufferDelegate_0 CreateBuffer_0;
		private static CreateBufferDelegate_1 CreateBuffer_1;
		private static CreateBufferDelegate_2 CreateBuffer_2;
		private static CreateBufferDelegate_3 CreateBuffer_3;
		private static IntPtr DestroyBufferPointer;
		private static DestroyBufferDelegate_0 DestroyBuffer_0;
		private static DestroyBufferDelegate_1 DestroyBuffer_1;
		private static IntPtr CreateBufferViewPointer;
		private static CreateBufferViewDelegate_0 CreateBufferView_0;
		private static CreateBufferViewDelegate_1 CreateBufferView_1;
		private static CreateBufferViewDelegate_2 CreateBufferView_2;
		private static CreateBufferViewDelegate_3 CreateBufferView_3;
		private static IntPtr DestroyBufferViewPointer;
		private static DestroyBufferViewDelegate_0 DestroyBufferView_0;
		private static DestroyBufferViewDelegate_1 DestroyBufferView_1;
		private static IntPtr CreateImagePointer;
		private static CreateImageDelegate_0 CreateImage_0;
		private static CreateImageDelegate_1 CreateImage_1;
		private static CreateImageDelegate_2 CreateImage_2;
		private static CreateImageDelegate_3 CreateImage_3;
		private static IntPtr DestroyImagePointer;
		private static DestroyImageDelegate_0 DestroyImage_0;
		private static DestroyImageDelegate_1 DestroyImage_1;
		private static IntPtr GetImageSubresourceLayoutPointer;
		private static GetImageSubresourceLayoutDelegate_0 GetImageSubresourceLayout_0;
		private static GetImageSubresourceLayoutDelegate_1 GetImageSubresourceLayout_1;
		private static IntPtr CreateImageViewPointer;
		private static CreateImageViewDelegate_0 CreateImageView_0;
		private static CreateImageViewDelegate_1 CreateImageView_1;
		private static CreateImageViewDelegate_2 CreateImageView_2;
		private static CreateImageViewDelegate_3 CreateImageView_3;
		private static IntPtr DestroyImageViewPointer;
		private static DestroyImageViewDelegate_0 DestroyImageView_0;
		private static DestroyImageViewDelegate_1 DestroyImageView_1;
		private static IntPtr CreateShaderModulePointer;
		private static CreateShaderModuleDelegate_0 CreateShaderModule_0;
		private static CreateShaderModuleDelegate_1 CreateShaderModule_1;
		private static CreateShaderModuleDelegate_2 CreateShaderModule_2;
		private static CreateShaderModuleDelegate_3 CreateShaderModule_3;
		private static IntPtr DestroyShaderModulePointer;
		private static DestroyShaderModuleDelegate_0 DestroyShaderModule_0;
		private static DestroyShaderModuleDelegate_1 DestroyShaderModule_1;
		private static IntPtr CreatePipelineCachePointer;
		private static CreatePipelineCacheDelegate_0 CreatePipelineCache_0;
		private static CreatePipelineCacheDelegate_1 CreatePipelineCache_1;
		private static CreatePipelineCacheDelegate_2 CreatePipelineCache_2;
		private static CreatePipelineCacheDelegate_3 CreatePipelineCache_3;
		private static IntPtr DestroyPipelineCachePointer;
		private static DestroyPipelineCacheDelegate_0 DestroyPipelineCache_0;
		private static DestroyPipelineCacheDelegate_1 DestroyPipelineCache_1;
		private static IntPtr GetPipelineCacheDataPointer;
		private static GetPipelineCacheDataDelegate_0 GetPipelineCacheData_0;
		private static GetPipelineCacheDataDelegate_1 GetPipelineCacheData_1;
		private static IntPtr MergePipelineCachesPointer;
		private static MergePipelineCachesDelegate_0 MergePipelineCaches_0;
		private static IntPtr CreateGraphicsPipelinesPointer;
		private static CreateGraphicsPipelinesDelegate_0 CreateGraphicsPipelines_0;
		private static CreateGraphicsPipelinesDelegate_1 CreateGraphicsPipelines_1;
		private static IntPtr CreateComputePipelinesPointer;
		private static CreateComputePipelinesDelegate_0 CreateComputePipelines_0;
		private static CreateComputePipelinesDelegate_1 CreateComputePipelines_1;
		private static IntPtr GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer;
		private static GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0 GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0;
		private static IntPtr DestroyPipelinePointer;
		private static DestroyPipelineDelegate_0 DestroyPipeline_0;
		private static DestroyPipelineDelegate_1 DestroyPipeline_1;
		private static IntPtr CreatePipelineLayoutPointer;
		private static CreatePipelineLayoutDelegate_0 CreatePipelineLayout_0;
		private static CreatePipelineLayoutDelegate_1 CreatePipelineLayout_1;
		private static CreatePipelineLayoutDelegate_2 CreatePipelineLayout_2;
		private static CreatePipelineLayoutDelegate_3 CreatePipelineLayout_3;
		private static IntPtr DestroyPipelineLayoutPointer;
		private static DestroyPipelineLayoutDelegate_0 DestroyPipelineLayout_0;
		private static DestroyPipelineLayoutDelegate_1 DestroyPipelineLayout_1;
		private static IntPtr CreateSamplerPointer;
		private static CreateSamplerDelegate_0 CreateSampler_0;
		private static CreateSamplerDelegate_1 CreateSampler_1;
		private static CreateSamplerDelegate_2 CreateSampler_2;
		private static CreateSamplerDelegate_3 CreateSampler_3;
		private static IntPtr DestroySamplerPointer;
		private static DestroySamplerDelegate_0 DestroySampler_0;
		private static DestroySamplerDelegate_1 DestroySampler_1;
		private static IntPtr CreateDescriptorSetLayoutPointer;
		private static CreateDescriptorSetLayoutDelegate_0 CreateDescriptorSetLayout_0;
		private static CreateDescriptorSetLayoutDelegate_1 CreateDescriptorSetLayout_1;
		private static CreateDescriptorSetLayoutDelegate_2 CreateDescriptorSetLayout_2;
		private static CreateDescriptorSetLayoutDelegate_3 CreateDescriptorSetLayout_3;
		private static IntPtr DestroyDescriptorSetLayoutPointer;
		private static DestroyDescriptorSetLayoutDelegate_0 DestroyDescriptorSetLayout_0;
		private static DestroyDescriptorSetLayoutDelegate_1 DestroyDescriptorSetLayout_1;
		private static IntPtr CreateDescriptorPoolPointer;
		private static CreateDescriptorPoolDelegate_0 CreateDescriptorPool_0;
		private static CreateDescriptorPoolDelegate_1 CreateDescriptorPool_1;
		private static CreateDescriptorPoolDelegate_2 CreateDescriptorPool_2;
		private static CreateDescriptorPoolDelegate_3 CreateDescriptorPool_3;
		private static IntPtr DestroyDescriptorPoolPointer;
		private static DestroyDescriptorPoolDelegate_0 DestroyDescriptorPool_0;
		private static DestroyDescriptorPoolDelegate_1 DestroyDescriptorPool_1;
		private static IntPtr ResetDescriptorPoolPointer;
		private static ResetDescriptorPoolDelegate_0 ResetDescriptorPool_0;
		private static IntPtr AllocateDescriptorSetsPointer;
		private static AllocateDescriptorSetsDelegate_0 AllocateDescriptorSets_0;
		private static AllocateDescriptorSetsDelegate_1 AllocateDescriptorSets_1;
		private static IntPtr FreeDescriptorSetsPointer;
		private static FreeDescriptorSetsDelegate_0 FreeDescriptorSets_0;
		private static IntPtr UpdateDescriptorSetsPointer;
		private static UpdateDescriptorSetsDelegate_0 UpdateDescriptorSets_0;
		private static IntPtr CreateFramebufferPointer;
		private static CreateFramebufferDelegate_0 CreateFramebuffer_0;
		private static CreateFramebufferDelegate_1 CreateFramebuffer_1;
		private static CreateFramebufferDelegate_2 CreateFramebuffer_2;
		private static CreateFramebufferDelegate_3 CreateFramebuffer_3;
		private static IntPtr DestroyFramebufferPointer;
		private static DestroyFramebufferDelegate_0 DestroyFramebuffer_0;
		private static DestroyFramebufferDelegate_1 DestroyFramebuffer_1;
		private static IntPtr CreateRenderPassPointer;
		private static CreateRenderPassDelegate_0 CreateRenderPass_0;
		private static CreateRenderPassDelegate_1 CreateRenderPass_1;
		private static CreateRenderPassDelegate_2 CreateRenderPass_2;
		private static CreateRenderPassDelegate_3 CreateRenderPass_3;
		private static IntPtr DestroyRenderPassPointer;
		private static DestroyRenderPassDelegate_0 DestroyRenderPass_0;
		private static DestroyRenderPassDelegate_1 DestroyRenderPass_1;
		private static IntPtr GetRenderAreaGranularityPointer;
		private static GetRenderAreaGranularityDelegate_0 GetRenderAreaGranularity_0;
		private static IntPtr CreateCommandPoolPointer;
		private static CreateCommandPoolDelegate_0 CreateCommandPool_0;
		private static CreateCommandPoolDelegate_1 CreateCommandPool_1;
		private static CreateCommandPoolDelegate_2 CreateCommandPool_2;
		private static CreateCommandPoolDelegate_3 CreateCommandPool_3;
		private static IntPtr DestroyCommandPoolPointer;
		private static DestroyCommandPoolDelegate_0 DestroyCommandPool_0;
		private static DestroyCommandPoolDelegate_1 DestroyCommandPool_1;
		private static IntPtr ResetCommandPoolPointer;
		private static ResetCommandPoolDelegate_0 ResetCommandPool_0;
		private static IntPtr AllocateCommandBuffersPointer;
		private static AllocateCommandBuffersDelegate_0 AllocateCommandBuffers_0;
		private static AllocateCommandBuffersDelegate_1 AllocateCommandBuffers_1;
		private static IntPtr FreeCommandBuffersPointer;
		private static FreeCommandBuffersDelegate_0 FreeCommandBuffers_0;
		private static IntPtr BeginCommandBufferPointer;
		private static BeginCommandBufferDelegate_0 BeginCommandBuffer_0;
		private static BeginCommandBufferDelegate_1 BeginCommandBuffer_1;
		private static IntPtr EndCommandBufferPointer;
		private static EndCommandBufferDelegate_0 EndCommandBuffer_0;
		private static IntPtr ResetCommandBufferPointer;
		private static ResetCommandBufferDelegate_0 ResetCommandBuffer_0;
		private static IntPtr CommandBindPipelinePointer;
		private static CommandBindPipelineDelegate_0 CommandBindPipeline_0;
		private static IntPtr CommandSetViewportPointer;
		private static CommandSetViewportDelegate_0 CommandSetViewport_0;
		private static IntPtr CommandSetScissorPointer;
		private static CommandSetScissorDelegate_0 CommandSetScissor_0;
		private static IntPtr CommandSetLineWidthPointer;
		private static CommandSetLineWidthDelegate_0 CommandSetLineWidth_0;
		private static IntPtr CommandSetDepthBiasPointer;
		private static CommandSetDepthBiasDelegate_0 CommandSetDepthBias_0;
		private static IntPtr CommandSetBlendConstantsPointer;
		private static CommandSetBlendConstantsDelegate_0 CommandSetBlendConstants_0;
		private static IntPtr CommandSetDepthBoundsPointer;
		private static CommandSetDepthBoundsDelegate_0 CommandSetDepthBounds_0;
		private static IntPtr CommandSetStencilCompareMaskPointer;
		private static CommandSetStencilCompareMaskDelegate_0 CommandSetStencilCompareMask_0;
		private static IntPtr CommandSetStencilWriteMaskPointer;
		private static CommandSetStencilWriteMaskDelegate_0 CommandSetStencilWriteMask_0;
		private static IntPtr CommandSetStencilReferencePointer;
		private static CommandSetStencilReferenceDelegate_0 CommandSetStencilReference_0;
		private static IntPtr CommandBindDescriptorSetsPointer;
		private static CommandBindDescriptorSetsDelegate_0 CommandBindDescriptorSets_0;
		private static IntPtr CommandBindIndexBufferPointer;
		private static CommandBindIndexBufferDelegate_0 CommandBindIndexBuffer_0;
		private static IntPtr CommandBindVertexBuffersPointer;
		private static CommandBindVertexBuffersDelegate_0 CommandBindVertexBuffers_0;
		private static CommandBindVertexBuffersDelegate_1 CommandBindVertexBuffers_1;
		private static CommandBindVertexBuffersDelegate_2 CommandBindVertexBuffers_2;
		private static CommandBindVertexBuffersDelegate_3 CommandBindVertexBuffers_3;
		private static IntPtr CommandDrawPointer;
		private static CommandDrawDelegate_0 CommandDraw_0;
		private static IntPtr CommandDrawIndexedPointer;
		private static CommandDrawIndexedDelegate_0 CommandDrawIndexed_0;
		private static IntPtr CommandDrawMultiEXTPointer;
		private static CommandDrawMultiEXTDelegate_0 CommandDrawMultiEXT_0;
		private static CommandDrawMultiEXTDelegate_1 CommandDrawMultiEXT_1;
		private static IntPtr CommandDrawMultiIndexedEXTPointer;
		private static CommandDrawMultiIndexedEXTDelegate_0 CommandDrawMultiIndexedEXT_0;
		private static CommandDrawMultiIndexedEXTDelegate_1 CommandDrawMultiIndexedEXT_1;
		private static CommandDrawMultiIndexedEXTDelegate_2 CommandDrawMultiIndexedEXT_2;
		private static CommandDrawMultiIndexedEXTDelegate_3 CommandDrawMultiIndexedEXT_3;
		private static IntPtr CommandDrawIndirectPointer;
		private static CommandDrawIndirectDelegate_0 CommandDrawIndirect_0;
		private static IntPtr CommandDrawIndexedIndirectPointer;
		private static CommandDrawIndexedIndirectDelegate_0 CommandDrawIndexedIndirect_0;
		private static IntPtr CommandDispatchPointer;
		private static CommandDispatchDelegate_0 CommandDispatch_0;
		private static IntPtr CommandDispatchIndirectPointer;
		private static CommandDispatchIndirectDelegate_0 CommandDispatchIndirect_0;
		private static IntPtr CommandSubpassShadingHUAWEIPointer;
		private static CommandSubpassShadingHUAWEIDelegate_0 CommandSubpassShadingHUAWEI_0;
		private static IntPtr CommandCopyBufferPointer;
		private static CommandCopyBufferDelegate_0 CommandCopyBuffer_0;
		private static IntPtr CommandCopyImagePointer;
		private static CommandCopyImageDelegate_0 CommandCopyImage_0;
		private static IntPtr CommandBlitImagePointer;
		private static CommandBlitImageDelegate_0 CommandBlitImage_0;
		private static IntPtr CommandCopyBufferToImagePointer;
		private static CommandCopyBufferToImageDelegate_0 CommandCopyBufferToImage_0;
		private static IntPtr CommandCopyImageToBufferPointer;
		private static CommandCopyImageToBufferDelegate_0 CommandCopyImageToBuffer_0;
		private static IntPtr CommandUpdateBufferPointer;
		private static CommandUpdateBufferDelegate_0 CommandUpdateBuffer_0;
		private static IntPtr CommandFillBufferPointer;
		private static CommandFillBufferDelegate_0 CommandFillBuffer_0;
		private static IntPtr CommandClearColorImagePointer;
		private static CommandClearColorImageDelegate_0 CommandClearColorImage_0;
		private static CommandClearColorImageDelegate_1 CommandClearColorImage_1;
		private static IntPtr CommandClearDepthStencilImagePointer;
		private static CommandClearDepthStencilImageDelegate_0 CommandClearDepthStencilImage_0;
		private static CommandClearDepthStencilImageDelegate_1 CommandClearDepthStencilImage_1;
		private static IntPtr CommandClearAttachmentsPointer;
		private static CommandClearAttachmentsDelegate_0 CommandClearAttachments_0;
		private static IntPtr CommandResolveImagePointer;
		private static CommandResolveImageDelegate_0 CommandResolveImage_0;
		private static IntPtr CommandSetEventPointer;
		private static CommandSetEventDelegate_0 CommandSetEvent_0;
		private static IntPtr CommandResetEventPointer;
		private static CommandResetEventDelegate_0 CommandResetEvent_0;
		private static IntPtr CommandWaitEventsPointer;
		private static CommandWaitEventsDelegate_0 CommandWaitEvents_0;
		private static IntPtr CommandPipelineBarrierPointer;
		private static CommandPipelineBarrierDelegate_0 CommandPipelineBarrier_0;
		private static IntPtr CommandBeginQueryPointer;
		private static CommandBeginQueryDelegate_0 CommandBeginQuery_0;
		private static IntPtr CommandEndQueryPointer;
		private static CommandEndQueryDelegate_0 CommandEndQuery_0;
		private static IntPtr CommandBeginConditionalRenderingEXTPointer;
		private static CommandBeginConditionalRenderingEXTDelegate_0 CommandBeginConditionalRenderingEXT_0;
		private static CommandBeginConditionalRenderingEXTDelegate_1 CommandBeginConditionalRenderingEXT_1;
		private static IntPtr CommandEndConditionalRenderingEXTPointer;
		private static CommandEndConditionalRenderingEXTDelegate_0 CommandEndConditionalRenderingEXT_0;
		private static IntPtr CommandResetQueryPoolPointer;
		private static CommandResetQueryPoolDelegate_0 CommandResetQueryPool_0;
		private static IntPtr CommandWriteTimestampPointer;
		private static CommandWriteTimestampDelegate_0 CommandWriteTimestamp_0;
		private static IntPtr CommandCopyQueryPoolResultsPointer;
		private static CommandCopyQueryPoolResultsDelegate_0 CommandCopyQueryPoolResults_0;
		private static IntPtr CommandPushConstantsPointer;
		private static CommandPushConstantsDelegate_0 CommandPushConstants_0;
		private static IntPtr CommandBeginRenderPassPointer;
		private static CommandBeginRenderPassDelegate_0 CommandBeginRenderPass_0;
		private static CommandBeginRenderPassDelegate_1 CommandBeginRenderPass_1;
		private static IntPtr CommandNextSubpassPointer;
		private static CommandNextSubpassDelegate_0 CommandNextSubpass_0;
		private static IntPtr CommandEndRenderPassPointer;
		private static CommandEndRenderPassDelegate_0 CommandEndRenderPass_0;
		private static IntPtr CommandExecuteCommandsPointer;
		private static CommandExecuteCommandsDelegate_0 CommandExecuteCommands_0;
		private static IntPtr CreateAndroidSurfaceKHRPointer;
		private static CreateAndroidSurfaceKHRDelegate_0 CreateAndroidSurfaceKHR_0;
		private static CreateAndroidSurfaceKHRDelegate_1 CreateAndroidSurfaceKHR_1;
		private static CreateAndroidSurfaceKHRDelegate_2 CreateAndroidSurfaceKHR_2;
		private static CreateAndroidSurfaceKHRDelegate_3 CreateAndroidSurfaceKHR_3;
		private static IntPtr GetPhysicalDeviceDisplayPropertiesKHRPointer;
		private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPropertiesKHR_0;
		private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPropertiesKHR_1;
		private static IntPtr GetPhysicalDeviceDisplayPlanePropertiesKHRPointer;
		private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPlanePropertiesKHR_0;
		private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPlanePropertiesKHR_1;
		private static IntPtr GetDisplayPlaneSupportedDisplaysKHRPointer;
		private static GetDisplayPlaneSupportedDisplaysKHRDelegate_0 GetDisplayPlaneSupportedDisplaysKHR_0;
		private static GetDisplayPlaneSupportedDisplaysKHRDelegate_1 GetDisplayPlaneSupportedDisplaysKHR_1;
		private static IntPtr GetDisplayModePropertiesKHRPointer;
		private static GetDisplayModePropertiesKHRDelegate_0 GetDisplayModePropertiesKHR_0;
		private static GetDisplayModePropertiesKHRDelegate_1 GetDisplayModePropertiesKHR_1;
		private static IntPtr CreateDisplayModeKHRPointer;
		private static CreateDisplayModeKHRDelegate_0 CreateDisplayModeKHR_0;
		private static CreateDisplayModeKHRDelegate_1 CreateDisplayModeKHR_1;
		private static CreateDisplayModeKHRDelegate_2 CreateDisplayModeKHR_2;
		private static CreateDisplayModeKHRDelegate_3 CreateDisplayModeKHR_3;
		private static IntPtr GetDisplayPlaneCapabilitiesKHRPointer;
		private static GetDisplayPlaneCapabilitiesKHRDelegate_0 GetDisplayPlaneCapabilitiesKHR_0;
		private static IntPtr CreateDisplayPlaneSurfaceKHRPointer;
		private static CreateDisplayPlaneSurfaceKHRDelegate_0 CreateDisplayPlaneSurfaceKHR_0;
		private static CreateDisplayPlaneSurfaceKHRDelegate_1 CreateDisplayPlaneSurfaceKHR_1;
		private static CreateDisplayPlaneSurfaceKHRDelegate_2 CreateDisplayPlaneSurfaceKHR_2;
		private static CreateDisplayPlaneSurfaceKHRDelegate_3 CreateDisplayPlaneSurfaceKHR_3;
		private static IntPtr CreateSharedSwapchainsKHRPointer;
		private static CreateSharedSwapchainsKHRDelegate_0 CreateSharedSwapchainsKHR_0;
		private static CreateSharedSwapchainsKHRDelegate_1 CreateSharedSwapchainsKHR_1;
		private static IntPtr DestroySurfaceKHRPointer;
		private static DestroySurfaceKHRDelegate_0 DestroySurfaceKHR_0;
		private static DestroySurfaceKHRDelegate_1 DestroySurfaceKHR_1;
		private static IntPtr GetPhysicalDeviceSurfaceSupportKHRPointer;
		private static GetPhysicalDeviceSurfaceSupportKHRDelegate_0 GetPhysicalDeviceSurfaceSupportKHR_0;
		private static IntPtr GetPhysicalDeviceSurfaceCapabilitiesKHRPointer;
		private static GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 GetPhysicalDeviceSurfaceCapabilitiesKHR_0;
		private static IntPtr GetPhysicalDeviceSurfaceFormatsKHRPointer;
		private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_0 GetPhysicalDeviceSurfaceFormatsKHR_0;
		private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_1 GetPhysicalDeviceSurfaceFormatsKHR_1;
		private static IntPtr GetPhysicalDeviceSurfacePresentModesKHRPointer;
		private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_0 GetPhysicalDeviceSurfacePresentModesKHR_0;
		private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_1 GetPhysicalDeviceSurfacePresentModesKHR_1;
		private static IntPtr CreateSwapchainKHRPointer;
		private static CreateSwapchainKHRDelegate_0 CreateSwapchainKHR_0;
		private static CreateSwapchainKHRDelegate_1 CreateSwapchainKHR_1;
		private static CreateSwapchainKHRDelegate_2 CreateSwapchainKHR_2;
		private static CreateSwapchainKHRDelegate_3 CreateSwapchainKHR_3;
		private static IntPtr DestroySwapchainKHRPointer;
		private static DestroySwapchainKHRDelegate_0 DestroySwapchainKHR_0;
		private static DestroySwapchainKHRDelegate_1 DestroySwapchainKHR_1;
		private static IntPtr GetSwapchainImagesKHRPointer;
		private static GetSwapchainImagesKHRDelegate_0 GetSwapchainImagesKHR_0;
		private static GetSwapchainImagesKHRDelegate_1 GetSwapchainImagesKHR_1;
		private static IntPtr AcquireNextImageKHRPointer;
		private static AcquireNextImageKHRDelegate_0 AcquireNextImageKHR_0;
		private static IntPtr QueuePresentKHRPointer;
		private static QueuePresentKHRDelegate_0 QueuePresentKHR_0;
		private static QueuePresentKHRDelegate_1 QueuePresentKHR_1;
		private static IntPtr CreateWin32SurfaceKHRPointer;
		private static CreateWin32SurfaceKHRDelegate_0 CreateWin32SurfaceKHR_0;
		private static CreateWin32SurfaceKHRDelegate_1 CreateWin32SurfaceKHR_1;
		private static CreateWin32SurfaceKHRDelegate_2 CreateWin32SurfaceKHR_2;
		private static CreateWin32SurfaceKHRDelegate_3 CreateWin32SurfaceKHR_3;
		private static IntPtr GetPhysicalDeviceWin32PresentationSupportKHRPointer;
		private static GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0 GetPhysicalDeviceWin32PresentationSupportKHR_0;
		private static IntPtr CreateXlibSurfaceKHRPointer;
		private static CreateXlibSurfaceKHRDelegate_0 CreateXlibSurfaceKHR_0;
		private static CreateXlibSurfaceKHRDelegate_1 CreateXlibSurfaceKHR_1;
		private static CreateXlibSurfaceKHRDelegate_2 CreateXlibSurfaceKHR_2;
		private static CreateXlibSurfaceKHRDelegate_3 CreateXlibSurfaceKHR_3;
		private static IntPtr GetPhysicalDeviceXlibPresentationSupportKHRPointer;
		private static GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 GetPhysicalDeviceXlibPresentationSupportKHR_0;
		private static GetPhysicalDeviceXlibPresentationSupportKHRDelegate_1 GetPhysicalDeviceXlibPresentationSupportKHR_1;
		private static IntPtr CreateDebugReportCallbackEXTPointer;
		private static CreateDebugReportCallbackEXTDelegate_0 CreateDebugReportCallbackEXT_0;
		private static CreateDebugReportCallbackEXTDelegate_1 CreateDebugReportCallbackEXT_1;
		private static CreateDebugReportCallbackEXTDelegate_2 CreateDebugReportCallbackEXT_2;
		private static CreateDebugReportCallbackEXTDelegate_3 CreateDebugReportCallbackEXT_3;
		private static IntPtr DestroyDebugReportCallbackEXTPointer;
		private static DestroyDebugReportCallbackEXTDelegate_0 DestroyDebugReportCallbackEXT_0;
		private static DestroyDebugReportCallbackEXTDelegate_1 DestroyDebugReportCallbackEXT_1;
		private static IntPtr DebugReportMessageEXTPointer;
		private static DebugReportMessageEXTDelegate_0 DebugReportMessageEXT_0;
		private static DebugReportMessageEXTDelegate_1 DebugReportMessageEXT_1;
		private static DebugReportMessageEXTDelegate_2 DebugReportMessageEXT_2;
		private static DebugReportMessageEXTDelegate_3 DebugReportMessageEXT_3;
		private static IntPtr DebugMarkerSetObjectNameEXTPointer;
		private static DebugMarkerSetObjectNameEXTDelegate_0 DebugMarkerSetObjectNameEXT_0;
		private static DebugMarkerSetObjectNameEXTDelegate_1 DebugMarkerSetObjectNameEXT_1;
		private static IntPtr DebugMarkerSetObjectTagEXTPointer;
		private static DebugMarkerSetObjectTagEXTDelegate_0 DebugMarkerSetObjectTagEXT_0;
		private static DebugMarkerSetObjectTagEXTDelegate_1 DebugMarkerSetObjectTagEXT_1;
		private static IntPtr CommandDebugMarkerBeginEXTPointer;
		private static CommandDebugMarkerBeginEXTDelegate_0 CommandDebugMarkerBeginEXT_0;
		private static CommandDebugMarkerBeginEXTDelegate_1 CommandDebugMarkerBeginEXT_1;
		private static IntPtr CommandDebugMarkerEndEXTPointer;
		private static CommandDebugMarkerEndEXTDelegate_0 CommandDebugMarkerEndEXT_0;
		private static IntPtr CommandDebugMarkerInsertEXTPointer;
		private static CommandDebugMarkerInsertEXTDelegate_0 CommandDebugMarkerInsertEXT_0;
		private static CommandDebugMarkerInsertEXTDelegate_1 CommandDebugMarkerInsertEXT_1;
		private static IntPtr GetPhysicalDeviceExternalImageFormatPropertiesNVPointer;
		private static GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 GetPhysicalDeviceExternalImageFormatPropertiesNV_0;
		private static IntPtr GetMemoryWin32HandleNVPointer;
		private static GetMemoryWin32HandleNVDelegate_0 GetMemoryWin32HandleNV_0;
		private static IntPtr CommandExecuteGeneratedCommandsNVPointer;
		private static CommandExecuteGeneratedCommandsNVDelegate_0 CommandExecuteGeneratedCommandsNV_0;
		private static CommandExecuteGeneratedCommandsNVDelegate_1 CommandExecuteGeneratedCommandsNV_1;
		private static IntPtr CommandPreprocessGeneratedCommandsNVPointer;
		private static CommandPreprocessGeneratedCommandsNVDelegate_0 CommandPreprocessGeneratedCommandsNV_0;
		private static CommandPreprocessGeneratedCommandsNVDelegate_1 CommandPreprocessGeneratedCommandsNV_1;
		private static IntPtr CommandBindPipelineShaderGroupNVPointer;
		private static CommandBindPipelineShaderGroupNVDelegate_0 CommandBindPipelineShaderGroupNV_0;
		private static IntPtr GetGeneratedCommandsMemoryRequirementsNVPointer;
		private static GetGeneratedCommandsMemoryRequirementsNVDelegate_0 GetGeneratedCommandsMemoryRequirementsNV_0;
		private static GetGeneratedCommandsMemoryRequirementsNVDelegate_1 GetGeneratedCommandsMemoryRequirementsNV_1;
		private static IntPtr CreateIndirectCommandsLayoutNVPointer;
		private static CreateIndirectCommandsLayoutNVDelegate_0 CreateIndirectCommandsLayoutNV_0;
		private static CreateIndirectCommandsLayoutNVDelegate_1 CreateIndirectCommandsLayoutNV_1;
		private static CreateIndirectCommandsLayoutNVDelegate_2 CreateIndirectCommandsLayoutNV_2;
		private static CreateIndirectCommandsLayoutNVDelegate_3 CreateIndirectCommandsLayoutNV_3;
		private static IntPtr DestroyIndirectCommandsLayoutNVPointer;
		private static DestroyIndirectCommandsLayoutNVDelegate_0 DestroyIndirectCommandsLayoutNV_0;
		private static DestroyIndirectCommandsLayoutNVDelegate_1 DestroyIndirectCommandsLayoutNV_1;
		private static IntPtr GetPhysicalDeviceFeatures2Pointer;
		private static GetPhysicalDeviceFeatures2Delegate_0 GetPhysicalDeviceFeatures2_0;
		private static IntPtr GetPhysicalDeviceProperties2Pointer;
		private static GetPhysicalDeviceProperties2Delegate_0 GetPhysicalDeviceProperties2_0;
		private static IntPtr GetPhysicalDeviceFormatProperties2Pointer;
		private static GetPhysicalDeviceFormatProperties2Delegate_0 GetPhysicalDeviceFormatProperties2_0;
		private static IntPtr GetPhysicalDeviceImageFormatProperties2Pointer;
		private static GetPhysicalDeviceImageFormatProperties2Delegate_0 GetPhysicalDeviceImageFormatProperties2_0;
		private static GetPhysicalDeviceImageFormatProperties2Delegate_1 GetPhysicalDeviceImageFormatProperties2_1;
		private static IntPtr GetPhysicalDeviceQueueFamilyProperties2Pointer;
		private static GetPhysicalDeviceQueueFamilyProperties2Delegate_0 GetPhysicalDeviceQueueFamilyProperties2_0;
		private static GetPhysicalDeviceQueueFamilyProperties2Delegate_1 GetPhysicalDeviceQueueFamilyProperties2_1;
		private static IntPtr GetPhysicalDeviceMemoryProperties2Pointer;
		private static GetPhysicalDeviceMemoryProperties2Delegate_0 GetPhysicalDeviceMemoryProperties2_0;
		private static IntPtr GetPhysicalDeviceSparseImageFormatProperties2Pointer;
		private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_0 GetPhysicalDeviceSparseImageFormatProperties2_0;
		private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_1 GetPhysicalDeviceSparseImageFormatProperties2_1;
		private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_2 GetPhysicalDeviceSparseImageFormatProperties2_2;
		private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_3 GetPhysicalDeviceSparseImageFormatProperties2_3;
		private static IntPtr CommandPushDescriptorSetKHRPointer;
		private static CommandPushDescriptorSetKHRDelegate_0 CommandPushDescriptorSetKHR_0;
		private static IntPtr TrimCommandPoolPointer;
		private static TrimCommandPoolDelegate_0 TrimCommandPool_0;
		private static IntPtr GetPhysicalDeviceExternalBufferPropertiesPointer;
		private static GetPhysicalDeviceExternalBufferPropertiesDelegate_0 GetPhysicalDeviceExternalBufferProperties_0;
		private static GetPhysicalDeviceExternalBufferPropertiesDelegate_1 GetPhysicalDeviceExternalBufferProperties_1;
		private static IntPtr GetMemoryWin32HandleKHRPointer;
		private static GetMemoryWin32HandleKHRDelegate_0 GetMemoryWin32HandleKHR_0;
		private static GetMemoryWin32HandleKHRDelegate_1 GetMemoryWin32HandleKHR_1;
		private static IntPtr GetMemoryWin32HandlePropertiesKHRPointer;
		private static GetMemoryWin32HandlePropertiesKHRDelegate_0 GetMemoryWin32HandlePropertiesKHR_0;
		private static IntPtr GetMemoryFileDescriptorKHRPointer;
		private static GetMemoryFileDescriptorKHRDelegate_0 GetMemoryFileDescriptorKHR_0;
		private static GetMemoryFileDescriptorKHRDelegate_1 GetMemoryFileDescriptorKHR_1;
		private static IntPtr GetMemoryFileDescriptorPropertiesKHRPointer;
		private static GetMemoryFileDescriptorPropertiesKHRDelegate_0 GetMemoryFileDescriptorPropertiesKHR_0;
		private static IntPtr GetMemoryRemoteAddressNVPointer;
		private static GetMemoryRemoteAddressNVDelegate_0 GetMemoryRemoteAddressNV_0;
		private static GetMemoryRemoteAddressNVDelegate_1 GetMemoryRemoteAddressNV_1;
		private static IntPtr GetPhysicalDeviceExternalSemaphorePropertiesPointer;
		private static GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0 GetPhysicalDeviceExternalSemaphoreProperties_0;
		private static GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1 GetPhysicalDeviceExternalSemaphoreProperties_1;
		private static IntPtr GetSemaphoreWin32HandleKHRPointer;
		private static GetSemaphoreWin32HandleKHRDelegate_0 GetSemaphoreWin32HandleKHR_0;
		private static GetSemaphoreWin32HandleKHRDelegate_1 GetSemaphoreWin32HandleKHR_1;
		private static IntPtr ImportSemaphoreWin32HandleKHRPointer;
		private static ImportSemaphoreWin32HandleKHRDelegate_0 ImportSemaphoreWin32HandleKHR_0;
		private static ImportSemaphoreWin32HandleKHRDelegate_1 ImportSemaphoreWin32HandleKHR_1;
		private static IntPtr GetSemaphoreFileDescriptorKHRPointer;
		private static GetSemaphoreFileDescriptorKHRDelegate_0 GetSemaphoreFileDescriptorKHR_0;
		private static GetSemaphoreFileDescriptorKHRDelegate_1 GetSemaphoreFileDescriptorKHR_1;
		private static IntPtr ImportSemaphoreFileDescriptorKHRPointer;
		private static ImportSemaphoreFileDescriptorKHRDelegate_0 ImportSemaphoreFileDescriptorKHR_0;
		private static ImportSemaphoreFileDescriptorKHRDelegate_1 ImportSemaphoreFileDescriptorKHR_1;
		private static IntPtr GetPhysicalDeviceExternalFencePropertiesPointer;
		private static GetPhysicalDeviceExternalFencePropertiesDelegate_0 GetPhysicalDeviceExternalFenceProperties_0;
		private static GetPhysicalDeviceExternalFencePropertiesDelegate_1 GetPhysicalDeviceExternalFenceProperties_1;
		private static IntPtr GetFenceWin32HandleKHRPointer;
		private static GetFenceWin32HandleKHRDelegate_0 GetFenceWin32HandleKHR_0;
		private static GetFenceWin32HandleKHRDelegate_1 GetFenceWin32HandleKHR_1;
		private static IntPtr ImportFenceWin32HandleKHRPointer;
		private static ImportFenceWin32HandleKHRDelegate_0 ImportFenceWin32HandleKHR_0;
		private static ImportFenceWin32HandleKHRDelegate_1 ImportFenceWin32HandleKHR_1;
		private static IntPtr GetFenceFileDescriptorKHRPointer;
		private static GetFenceFileDescriptorKHRDelegate_0 GetFenceFileDescriptorKHR_0;
		private static GetFenceFileDescriptorKHRDelegate_1 GetFenceFileDescriptorKHR_1;
		private static IntPtr ImportFenceFileDescriptorKHRPointer;
		private static ImportFenceFileDescriptorKHRDelegate_0 ImportFenceFileDescriptorKHR_0;
		private static ImportFenceFileDescriptorKHRDelegate_1 ImportFenceFileDescriptorKHR_1;
		private static IntPtr ReleaseDisplayEXTPointer;
		private static ReleaseDisplayEXTDelegate_0 ReleaseDisplayEXT_0;
		private static IntPtr AcquireWinrtDisplayNVPointer;
		private static AcquireWinrtDisplayNVDelegate_0 AcquireWinrtDisplayNV_0;
		private static IntPtr GetWinrtDisplayNVPointer;
		private static GetWinrtDisplayNVDelegate_0 GetWinrtDisplayNV_0;
		private static IntPtr DisplayPowerControlEXTPointer;
		private static DisplayPowerControlEXTDelegate_0 DisplayPowerControlEXT_0;
		private static DisplayPowerControlEXTDelegate_1 DisplayPowerControlEXT_1;
		private static IntPtr RegisterDeviceEventEXTPointer;
		private static RegisterDeviceEventEXTDelegate_0 RegisterDeviceEventEXT_0;
		private static RegisterDeviceEventEXTDelegate_1 RegisterDeviceEventEXT_1;
		private static RegisterDeviceEventEXTDelegate_2 RegisterDeviceEventEXT_2;
		private static RegisterDeviceEventEXTDelegate_3 RegisterDeviceEventEXT_3;
		private static RegisterDeviceEventEXTDelegate_4 RegisterDeviceEventEXT_4;
		private static RegisterDeviceEventEXTDelegate_5 RegisterDeviceEventEXT_5;
		private static RegisterDeviceEventEXTDelegate_6 RegisterDeviceEventEXT_6;
		private static RegisterDeviceEventEXTDelegate_7 RegisterDeviceEventEXT_7;
		private static IntPtr RegisterDisplayEventEXTPointer;
		private static RegisterDisplayEventEXTDelegate_0 RegisterDisplayEventEXT_0;
		private static RegisterDisplayEventEXTDelegate_1 RegisterDisplayEventEXT_1;
		private static RegisterDisplayEventEXTDelegate_2 RegisterDisplayEventEXT_2;
		private static RegisterDisplayEventEXTDelegate_3 RegisterDisplayEventEXT_3;
		private static RegisterDisplayEventEXTDelegate_4 RegisterDisplayEventEXT_4;
		private static RegisterDisplayEventEXTDelegate_5 RegisterDisplayEventEXT_5;
		private static RegisterDisplayEventEXTDelegate_6 RegisterDisplayEventEXT_6;
		private static RegisterDisplayEventEXTDelegate_7 RegisterDisplayEventEXT_7;
		private static IntPtr GetSwapchainCounterEXTPointer;
		private static GetSwapchainCounterEXTDelegate_0 GetSwapchainCounterEXT_0;
		private static IntPtr GetPhysicalDeviceSurfaceCapabilities2EXTPointer;
		private static GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0 GetPhysicalDeviceSurfaceCapabilities2EXT_0;
		private static IntPtr EnumeratePhysicalDeviceGroupsPointer;
		private static EnumeratePhysicalDeviceGroupsDelegate_0 EnumeratePhysicalDeviceGroups_0;
		private static EnumeratePhysicalDeviceGroupsDelegate_1 EnumeratePhysicalDeviceGroups_1;
		private static IntPtr GetDeviceGroupPeerMemoryFeaturesPointer;
		private static GetDeviceGroupPeerMemoryFeaturesDelegate_0 GetDeviceGroupPeerMemoryFeatures_0;
		private static IntPtr BindBufferMemory2Pointer;
		private static BindBufferMemory2Delegate_0 BindBufferMemory2_0;
		private static IntPtr BindImageMemory2Pointer;
		private static BindImageMemory2Delegate_0 BindImageMemory2_0;
		private static IntPtr CommandSetDeviceMaskPointer;
		private static CommandSetDeviceMaskDelegate_0 CommandSetDeviceMask_0;
		private static IntPtr GetDeviceGroupPresentCapabilitiesKHRPointer;
		private static GetDeviceGroupPresentCapabilitiesKHRDelegate_0 GetDeviceGroupPresentCapabilitiesKHR_0;
		private static IntPtr GetDeviceGroupSurfacePresentModesKHRPointer;
		private static GetDeviceGroupSurfacePresentModesKHRDelegate_0 GetDeviceGroupSurfacePresentModesKHR_0;
		private static IntPtr AcquireNextImage2KHRPointer;
		private static AcquireNextImage2KHRDelegate_0 AcquireNextImage2KHR_0;
		private static AcquireNextImage2KHRDelegate_1 AcquireNextImage2KHR_1;
		private static IntPtr CommandDispatchBasePointer;
		private static CommandDispatchBaseDelegate_0 CommandDispatchBase_0;
		private static IntPtr GetPhysicalDevicePresentRectanglesKHRPointer;
		private static GetPhysicalDevicePresentRectanglesKHRDelegate_0 GetPhysicalDevicePresentRectanglesKHR_0;
		private static GetPhysicalDevicePresentRectanglesKHRDelegate_1 GetPhysicalDevicePresentRectanglesKHR_1;
		private static IntPtr CreateDescriptorUpdateTemplatePointer;
		private static CreateDescriptorUpdateTemplateDelegate_0 CreateDescriptorUpdateTemplate_0;
		private static CreateDescriptorUpdateTemplateDelegate_1 CreateDescriptorUpdateTemplate_1;
		private static CreateDescriptorUpdateTemplateDelegate_2 CreateDescriptorUpdateTemplate_2;
		private static CreateDescriptorUpdateTemplateDelegate_3 CreateDescriptorUpdateTemplate_3;
		private static IntPtr DestroyDescriptorUpdateTemplatePointer;
		private static DestroyDescriptorUpdateTemplateDelegate_0 DestroyDescriptorUpdateTemplate_0;
		private static DestroyDescriptorUpdateTemplateDelegate_1 DestroyDescriptorUpdateTemplate_1;
		private static IntPtr UpdateDescriptorSetWithTemplatePointer;
		private static UpdateDescriptorSetWithTemplateDelegate_0 UpdateDescriptorSetWithTemplate_0;
		private static IntPtr CommandPushDescriptorSetWithTemplateKHRPointer;
		private static CommandPushDescriptorSetWithTemplateKHRDelegate_0 CommandPushDescriptorSetWithTemplateKHR_0;
		private static IntPtr SetHdrMetadataEXTPointer;
		private static SetHdrMetadataEXTDelegate_0 SetHdrMetadataEXT_0;
		private static SetHdrMetadataEXTDelegate_1 SetHdrMetadataEXT_1;
		private static IntPtr GetSwapchainStatusKHRPointer;
		private static GetSwapchainStatusKHRDelegate_0 GetSwapchainStatusKHR_0;
		private static IntPtr GetRefreshCycleDurationGOOGLEPointer;
		private static GetRefreshCycleDurationGOOGLEDelegate_0 GetRefreshCycleDurationGOOGLE_0;
		private static IntPtr GetPastPresentationTimingGOOGLEPointer;
		private static GetPastPresentationTimingGOOGLEDelegate_0 GetPastPresentationTimingGOOGLE_0;
		private static GetPastPresentationTimingGOOGLEDelegate_1 GetPastPresentationTimingGOOGLE_1;
		private static IntPtr CreateMacOSSurfaceMVKPointer;
		private static CreateMacOSSurfaceMVKDelegate_0 CreateMacOSSurfaceMVK_0;
		private static CreateMacOSSurfaceMVKDelegate_1 CreateMacOSSurfaceMVK_1;
		private static CreateMacOSSurfaceMVKDelegate_2 CreateMacOSSurfaceMVK_2;
		private static CreateMacOSSurfaceMVKDelegate_3 CreateMacOSSurfaceMVK_3;
		private static IntPtr CommandSetViewportWScalingNVPointer;
		private static CommandSetViewportWScalingNVDelegate_0 CommandSetViewportWScalingNV_0;
		private static CommandSetViewportWScalingNVDelegate_1 CommandSetViewportWScalingNV_1;
		private static IntPtr CommandSetDiscardRectangleEXTPointer;
		private static CommandSetDiscardRectangleEXTDelegate_0 CommandSetDiscardRectangleEXT_0;
		private static IntPtr CommandSetSampleLocationsEXTPointer;
		private static CommandSetSampleLocationsEXTDelegate_0 CommandSetSampleLocationsEXT_0;
		private static CommandSetSampleLocationsEXTDelegate_1 CommandSetSampleLocationsEXT_1;
		private static IntPtr GetPhysicalDeviceMultisamplePropertiesEXTPointer;
		private static GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 GetPhysicalDeviceMultisamplePropertiesEXT_0;
		private static IntPtr GetPhysicalDeviceSurfaceCapabilities2KHRPointer;
		private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 GetPhysicalDeviceSurfaceCapabilities2KHR_0;
		private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1 GetPhysicalDeviceSurfaceCapabilities2KHR_1;
		private static IntPtr GetPhysicalDeviceSurfaceFormats2KHRPointer;
		private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_0 GetPhysicalDeviceSurfaceFormats2KHR_0;
		private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_1 GetPhysicalDeviceSurfaceFormats2KHR_1;
		private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_2 GetPhysicalDeviceSurfaceFormats2KHR_2;
		private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_3 GetPhysicalDeviceSurfaceFormats2KHR_3;
		private static IntPtr GetPhysicalDeviceDisplayProperties2KHRPointer;
		private static GetPhysicalDeviceDisplayProperties2KHRDelegate_0 GetPhysicalDeviceDisplayProperties2KHR_0;
		private static GetPhysicalDeviceDisplayProperties2KHRDelegate_1 GetPhysicalDeviceDisplayProperties2KHR_1;
		private static IntPtr GetPhysicalDeviceDisplayPlaneProperties2KHRPointer;
		private static GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0 GetPhysicalDeviceDisplayPlaneProperties2KHR_0;
		private static GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1 GetPhysicalDeviceDisplayPlaneProperties2KHR_1;
		private static IntPtr GetDisplayModeProperties2KHRPointer;
		private static GetDisplayModeProperties2KHRDelegate_0 GetDisplayModeProperties2KHR_0;
		private static GetDisplayModeProperties2KHRDelegate_1 GetDisplayModeProperties2KHR_1;
		private static IntPtr GetDisplayPlaneCapabilities2KHRPointer;
		private static GetDisplayPlaneCapabilities2KHRDelegate_0 GetDisplayPlaneCapabilities2KHR_0;
		private static GetDisplayPlaneCapabilities2KHRDelegate_1 GetDisplayPlaneCapabilities2KHR_1;
		private static IntPtr GetBufferMemoryRequirements2Pointer;
		private static GetBufferMemoryRequirements2Delegate_0 GetBufferMemoryRequirements2_0;
		private static GetBufferMemoryRequirements2Delegate_1 GetBufferMemoryRequirements2_1;
		private static IntPtr GetImageMemoryRequirements2Pointer;
		private static GetImageMemoryRequirements2Delegate_0 GetImageMemoryRequirements2_0;
		private static GetImageMemoryRequirements2Delegate_1 GetImageMemoryRequirements2_1;
		private static IntPtr GetImageSparseMemoryRequirements2Pointer;
		private static GetImageSparseMemoryRequirements2Delegate_0 GetImageSparseMemoryRequirements2_0;
		private static GetImageSparseMemoryRequirements2Delegate_1 GetImageSparseMemoryRequirements2_1;
		private static GetImageSparseMemoryRequirements2Delegate_2 GetImageSparseMemoryRequirements2_2;
		private static GetImageSparseMemoryRequirements2Delegate_3 GetImageSparseMemoryRequirements2_3;
		private static IntPtr GetDeviceBufferMemoryRequirementsPointer;
		private static GetDeviceBufferMemoryRequirementsDelegate_0 GetDeviceBufferMemoryRequirements_0;
		private static GetDeviceBufferMemoryRequirementsDelegate_1 GetDeviceBufferMemoryRequirements_1;
		private static IntPtr GetDeviceImageMemoryRequirementsPointer;
		private static GetDeviceImageMemoryRequirementsDelegate_0 GetDeviceImageMemoryRequirements_0;
		private static GetDeviceImageMemoryRequirementsDelegate_1 GetDeviceImageMemoryRequirements_1;
		private static IntPtr GetDeviceImageSparseMemoryRequirementsPointer;
		private static GetDeviceImageSparseMemoryRequirementsDelegate_0 GetDeviceImageSparseMemoryRequirements_0;
		private static GetDeviceImageSparseMemoryRequirementsDelegate_1 GetDeviceImageSparseMemoryRequirements_1;
		private static GetDeviceImageSparseMemoryRequirementsDelegate_2 GetDeviceImageSparseMemoryRequirements_2;
		private static GetDeviceImageSparseMemoryRequirementsDelegate_3 GetDeviceImageSparseMemoryRequirements_3;
		private static IntPtr CreateSamplerYcbcrConversionPointer;
		private static CreateSamplerYcbcrConversionDelegate_0 CreateSamplerYcbcrConversion_0;
		private static CreateSamplerYcbcrConversionDelegate_1 CreateSamplerYcbcrConversion_1;
		private static CreateSamplerYcbcrConversionDelegate_2 CreateSamplerYcbcrConversion_2;
		private static CreateSamplerYcbcrConversionDelegate_3 CreateSamplerYcbcrConversion_3;
		private static IntPtr DestroySamplerYcbcrConversionPointer;
		private static DestroySamplerYcbcrConversionDelegate_0 DestroySamplerYcbcrConversion_0;
		private static DestroySamplerYcbcrConversionDelegate_1 DestroySamplerYcbcrConversion_1;
		private static IntPtr GetDeviceQueue2Pointer;
		private static GetDeviceQueue2Delegate_0 GetDeviceQueue2_0;
		private static GetDeviceQueue2Delegate_1 GetDeviceQueue2_1;
		private static IntPtr CreateValidationCacheEXTPointer;
		private static CreateValidationCacheEXTDelegate_0 CreateValidationCacheEXT_0;
		private static CreateValidationCacheEXTDelegate_1 CreateValidationCacheEXT_1;
		private static CreateValidationCacheEXTDelegate_2 CreateValidationCacheEXT_2;
		private static CreateValidationCacheEXTDelegate_3 CreateValidationCacheEXT_3;
		private static IntPtr DestroyValidationCacheEXTPointer;
		private static DestroyValidationCacheEXTDelegate_0 DestroyValidationCacheEXT_0;
		private static DestroyValidationCacheEXTDelegate_1 DestroyValidationCacheEXT_1;
		private static IntPtr GetValidationCacheDataEXTPointer;
		private static GetValidationCacheDataEXTDelegate_0 GetValidationCacheDataEXT_0;
		private static GetValidationCacheDataEXTDelegate_1 GetValidationCacheDataEXT_1;
		private static IntPtr MergeValidationCachesEXTPointer;
		private static MergeValidationCachesEXTDelegate_0 MergeValidationCachesEXT_0;
		private static IntPtr GetDescriptorSetLayoutSupportPointer;
		private static GetDescriptorSetLayoutSupportDelegate_0 GetDescriptorSetLayoutSupport_0;
		private static GetDescriptorSetLayoutSupportDelegate_1 GetDescriptorSetLayoutSupport_1;
		private static IntPtr GetSwapchainGrallocUsageANDROIDPointer;
		private static GetSwapchainGrallocUsageANDROIDDelegate_0 GetSwapchainGrallocUsageANDROID_0;
		private static IntPtr GetSwapchainGrallocUsage2ANDROIDPointer;
		private static GetSwapchainGrallocUsage2ANDROIDDelegate_0 GetSwapchainGrallocUsage2ANDROID_0;
		private static GetSwapchainGrallocUsage2ANDROIDDelegate_1 GetSwapchainGrallocUsage2ANDROID_1;
		private static IntPtr AcquireImageANDROIDPointer;
		private static AcquireImageANDROIDDelegate_0 AcquireImageANDROID_0;
		private static IntPtr QueueSignalReleaseImageANDROIDPointer;
		private static QueueSignalReleaseImageANDROIDDelegate_0 QueueSignalReleaseImageANDROID_0;
		private static QueueSignalReleaseImageANDROIDDelegate_1 QueueSignalReleaseImageANDROID_1;
		private static IntPtr GetShaderInfoAMDPointer;
		private static GetShaderInfoAMDDelegate_0 GetShaderInfoAMD_0;
		private static GetShaderInfoAMDDelegate_1 GetShaderInfoAMD_1;
		private static IntPtr SetLocalDimmingAMDPointer;
		private static SetLocalDimmingAMDDelegate_0 SetLocalDimmingAMD_0;
		private static IntPtr GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer;
		private static GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0 GetPhysicalDeviceCalibrateableTimeDomainsEXT_0;
		private static GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1 GetPhysicalDeviceCalibrateableTimeDomainsEXT_1;
		private static IntPtr GetCalibratedTimestampsEXTPointer;
		private static GetCalibratedTimestampsEXTDelegate_0 GetCalibratedTimestampsEXT_0;
		private static GetCalibratedTimestampsEXTDelegate_1 GetCalibratedTimestampsEXT_1;
		private static IntPtr SetDebugUtilsObjectNameEXTPointer;
		private static SetDebugUtilsObjectNameEXTDelegate_0 SetDebugUtilsObjectNameEXT_0;
		private static SetDebugUtilsObjectNameEXTDelegate_1 SetDebugUtilsObjectNameEXT_1;
		private static IntPtr SetDebugUtilsObjectTagEXTPointer;
		private static SetDebugUtilsObjectTagEXTDelegate_0 SetDebugUtilsObjectTagEXT_0;
		private static SetDebugUtilsObjectTagEXTDelegate_1 SetDebugUtilsObjectTagEXT_1;
		private static IntPtr QueueBeginDebugUtilsLabelEXTPointer;
		private static QueueBeginDebugUtilsLabelEXTDelegate_0 QueueBeginDebugUtilsLabelEXT_0;
		private static QueueBeginDebugUtilsLabelEXTDelegate_1 QueueBeginDebugUtilsLabelEXT_1;
		private static IntPtr QueueEndDebugUtilsLabelEXTPointer;
		private static QueueEndDebugUtilsLabelEXTDelegate_0 QueueEndDebugUtilsLabelEXT_0;
		private static IntPtr QueueInsertDebugUtilsLabelEXTPointer;
		private static QueueInsertDebugUtilsLabelEXTDelegate_0 QueueInsertDebugUtilsLabelEXT_0;
		private static QueueInsertDebugUtilsLabelEXTDelegate_1 QueueInsertDebugUtilsLabelEXT_1;
		private static IntPtr CommandBeginDebugUtilsLabelEXTPointer;
		private static CommandBeginDebugUtilsLabelEXTDelegate_0 CommandBeginDebugUtilsLabelEXT_0;
		private static CommandBeginDebugUtilsLabelEXTDelegate_1 CommandBeginDebugUtilsLabelEXT_1;
		private static IntPtr CommandEndDebugUtilsLabelEXTPointer;
		private static CommandEndDebugUtilsLabelEXTDelegate_0 CommandEndDebugUtilsLabelEXT_0;
		private static IntPtr CommandInsertDebugUtilsLabelEXTPointer;
		private static CommandInsertDebugUtilsLabelEXTDelegate_0 CommandInsertDebugUtilsLabelEXT_0;
		private static CommandInsertDebugUtilsLabelEXTDelegate_1 CommandInsertDebugUtilsLabelEXT_1;
		private static IntPtr CreateDebugUtilsMessengerEXTPointer;
		private static CreateDebugUtilsMessengerEXTDelegate_0 CreateDebugUtilsMessengerEXT_0;
		private static CreateDebugUtilsMessengerEXTDelegate_1 CreateDebugUtilsMessengerEXT_1;
		private static CreateDebugUtilsMessengerEXTDelegate_2 CreateDebugUtilsMessengerEXT_2;
		private static CreateDebugUtilsMessengerEXTDelegate_3 CreateDebugUtilsMessengerEXT_3;
		private static IntPtr DestroyDebugUtilsMessengerEXTPointer;
		private static DestroyDebugUtilsMessengerEXTDelegate_0 DestroyDebugUtilsMessengerEXT_0;
		private static DestroyDebugUtilsMessengerEXTDelegate_1 DestroyDebugUtilsMessengerEXT_1;
		private static IntPtr SubmitDebugUtilsMessageEXTPointer;
		private static SubmitDebugUtilsMessageEXTDelegate_0 SubmitDebugUtilsMessageEXT_0;
		private static SubmitDebugUtilsMessageEXTDelegate_1 SubmitDebugUtilsMessageEXT_1;
		private static IntPtr GetMemoryHostPointerPropertiesEXTPointer;
		private static GetMemoryHostPointerPropertiesEXTDelegate_0 GetMemoryHostPointerPropertiesEXT_0;
		private static IntPtr CommandWriteBufferMarkerAMDPointer;
		private static CommandWriteBufferMarkerAMDDelegate_0 CommandWriteBufferMarkerAMD_0;
		private static IntPtr CreateRenderPass2Pointer;
		private static CreateRenderPass2Delegate_0 CreateRenderPass2_0;
		private static CreateRenderPass2Delegate_1 CreateRenderPass2_1;
		private static CreateRenderPass2Delegate_2 CreateRenderPass2_2;
		private static CreateRenderPass2Delegate_3 CreateRenderPass2_3;
		private static IntPtr CommandBeginRenderPass2Pointer;
		private static CommandBeginRenderPass2Delegate_0 CommandBeginRenderPass2_0;
		private static CommandBeginRenderPass2Delegate_1 CommandBeginRenderPass2_1;
		private static CommandBeginRenderPass2Delegate_2 CommandBeginRenderPass2_2;
		private static CommandBeginRenderPass2Delegate_3 CommandBeginRenderPass2_3;
		private static IntPtr CommandNextSubpass2Pointer;
		private static CommandNextSubpass2Delegate_0 CommandNextSubpass2_0;
		private static CommandNextSubpass2Delegate_1 CommandNextSubpass2_1;
		private static CommandNextSubpass2Delegate_2 CommandNextSubpass2_2;
		private static CommandNextSubpass2Delegate_3 CommandNextSubpass2_3;
		private static IntPtr CommandEndRenderPass2Pointer;
		private static CommandEndRenderPass2Delegate_0 CommandEndRenderPass2_0;
		private static CommandEndRenderPass2Delegate_1 CommandEndRenderPass2_1;
		private static IntPtr GetSemaphoreCounterValuePointer;
		private static GetSemaphoreCounterValueDelegate_0 GetSemaphoreCounterValue_0;
		private static IntPtr WaitSemaphoresPointer;
		private static WaitSemaphoresDelegate_0 WaitSemaphores_0;
		private static WaitSemaphoresDelegate_1 WaitSemaphores_1;
		private static IntPtr SignalSemaphorePointer;
		private static SignalSemaphoreDelegate_0 SignalSemaphore_0;
		private static SignalSemaphoreDelegate_1 SignalSemaphore_1;
		private static IntPtr GetAndroidHardwareBufferPropertiesANDROIDPointer;
		private static GetAndroidHardwareBufferPropertiesANDROIDDelegate_0 GetAndroidHardwareBufferPropertiesANDROID_0;
		private static GetAndroidHardwareBufferPropertiesANDROIDDelegate_1 GetAndroidHardwareBufferPropertiesANDROID_1;
		private static IntPtr GetMemoryAndroidHardwareBufferANDROIDPointer;
		private static GetMemoryAndroidHardwareBufferANDROIDDelegate_0 GetMemoryAndroidHardwareBufferANDROID_0;
		private static GetMemoryAndroidHardwareBufferANDROIDDelegate_1 GetMemoryAndroidHardwareBufferANDROID_1;
		private static IntPtr CommandDrawIndirectCountPointer;
		private static CommandDrawIndirectCountDelegate_0 CommandDrawIndirectCount_0;
		private static IntPtr CommandDrawIndexedIndirectCountPointer;
		private static CommandDrawIndexedIndirectCountDelegate_0 CommandDrawIndexedIndirectCount_0;
		private static IntPtr CommandSetCheckpointNVPointer;
		private static CommandSetCheckpointNVDelegate_0 CommandSetCheckpointNV_0;
		private static IntPtr GetQueueCheckpointDataNVPointer;
		private static GetQueueCheckpointDataNVDelegate_0 GetQueueCheckpointDataNV_0;
		private static GetQueueCheckpointDataNVDelegate_1 GetQueueCheckpointDataNV_1;
		private static IntPtr CommandBindTransformFeedbackBuffersEXTPointer;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_0 CommandBindTransformFeedbackBuffersEXT_0;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_1 CommandBindTransformFeedbackBuffersEXT_1;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_2 CommandBindTransformFeedbackBuffersEXT_2;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_3 CommandBindTransformFeedbackBuffersEXT_3;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_4 CommandBindTransformFeedbackBuffersEXT_4;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_5 CommandBindTransformFeedbackBuffersEXT_5;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_6 CommandBindTransformFeedbackBuffersEXT_6;
		private static CommandBindTransformFeedbackBuffersEXTDelegate_7 CommandBindTransformFeedbackBuffersEXT_7;
		private static IntPtr CommandBeginTransformFeedbackEXTPointer;
		private static CommandBeginTransformFeedbackEXTDelegate_0 CommandBeginTransformFeedbackEXT_0;
		private static CommandBeginTransformFeedbackEXTDelegate_1 CommandBeginTransformFeedbackEXT_1;
		private static IntPtr CommandEndTransformFeedbackEXTPointer;
		private static CommandEndTransformFeedbackEXTDelegate_0 CommandEndTransformFeedbackEXT_0;
		private static CommandEndTransformFeedbackEXTDelegate_1 CommandEndTransformFeedbackEXT_1;
		private static IntPtr CommandBeginQueryIndexedEXTPointer;
		private static CommandBeginQueryIndexedEXTDelegate_0 CommandBeginQueryIndexedEXT_0;
		private static IntPtr CommandEndQueryIndexedEXTPointer;
		private static CommandEndQueryIndexedEXTDelegate_0 CommandEndQueryIndexedEXT_0;
		private static IntPtr CommandDrawIndirectByteCountEXTPointer;
		private static CommandDrawIndirectByteCountEXTDelegate_0 CommandDrawIndirectByteCountEXT_0;
		private static IntPtr CommandSetExclusiveScissorNVPointer;
		private static CommandSetExclusiveScissorNVDelegate_0 CommandSetExclusiveScissorNV_0;
		private static IntPtr CommandBindShadingRateImageNVPointer;
		private static CommandBindShadingRateImageNVDelegate_0 CommandBindShadingRateImageNV_0;
		private static IntPtr CommandSetViewportShadingRatePaletteNVPointer;
		private static CommandSetViewportShadingRatePaletteNVDelegate_0 CommandSetViewportShadingRatePaletteNV_0;
		private static CommandSetViewportShadingRatePaletteNVDelegate_1 CommandSetViewportShadingRatePaletteNV_1;
		private static IntPtr CommandSetCoarseSampleOrderNVPointer;
		private static CommandSetCoarseSampleOrderNVDelegate_0 CommandSetCoarseSampleOrderNV_0;
		private static IntPtr CommandDrawMeshTasksNVPointer;
		private static CommandDrawMeshTasksNVDelegate_0 CommandDrawMeshTasksNV_0;
		private static IntPtr CommandDrawMeshTasksIndirectNVPointer;
		private static CommandDrawMeshTasksIndirectNVDelegate_0 CommandDrawMeshTasksIndirectNV_0;
		private static IntPtr CommandDrawMeshTasksIndirectCountNVPointer;
		private static CommandDrawMeshTasksIndirectCountNVDelegate_0 CommandDrawMeshTasksIndirectCountNV_0;
		private static IntPtr CompileDeferredNVPointer;
		private static CompileDeferredNVDelegate_0 CompileDeferredNV_0;
		private static IntPtr CreateAccelerationStructureNVPointer;
		private static CreateAccelerationStructureNVDelegate_0 CreateAccelerationStructureNV_0;
		private static CreateAccelerationStructureNVDelegate_1 CreateAccelerationStructureNV_1;
		private static CreateAccelerationStructureNVDelegate_2 CreateAccelerationStructureNV_2;
		private static CreateAccelerationStructureNVDelegate_3 CreateAccelerationStructureNV_3;
		private static IntPtr CommandBindInvocationMaskHUAWEIPointer;
		private static CommandBindInvocationMaskHUAWEIDelegate_0 CommandBindInvocationMaskHUAWEI_0;
		private static IntPtr DestroyAccelerationStructureKHRPointer;
		private static DestroyAccelerationStructureKHRDelegate_0 DestroyAccelerationStructureKHR_0;
		private static DestroyAccelerationStructureKHRDelegate_1 DestroyAccelerationStructureKHR_1;
		private static IntPtr DestroyAccelerationStructureNVPointer;
		private static DestroyAccelerationStructureNVDelegate_0 DestroyAccelerationStructureNV_0;
		private static DestroyAccelerationStructureNVDelegate_1 DestroyAccelerationStructureNV_1;
		private static IntPtr GetAccelerationStructureMemoryRequirementsNVPointer;
		private static GetAccelerationStructureMemoryRequirementsNVDelegate_0 GetAccelerationStructureMemoryRequirementsNV_0;
		private static GetAccelerationStructureMemoryRequirementsNVDelegate_1 GetAccelerationStructureMemoryRequirementsNV_1;
		private static IntPtr BindAccelerationStructureMemoryNVPointer;
		private static BindAccelerationStructureMemoryNVDelegate_0 BindAccelerationStructureMemoryNV_0;
		private static IntPtr CommandCopyAccelerationStructureNVPointer;
		private static CommandCopyAccelerationStructureNVDelegate_0 CommandCopyAccelerationStructureNV_0;
		private static IntPtr CommandCopyAccelerationStructureKHRPointer;
		private static CommandCopyAccelerationStructureKHRDelegate_0 CommandCopyAccelerationStructureKHR_0;
		private static CommandCopyAccelerationStructureKHRDelegate_1 CommandCopyAccelerationStructureKHR_1;
		private static IntPtr CopyAccelerationStructureKHRPointer;
		private static CopyAccelerationStructureKHRDelegate_0 CopyAccelerationStructureKHR_0;
		private static CopyAccelerationStructureKHRDelegate_1 CopyAccelerationStructureKHR_1;
		private static IntPtr CommandCopyAccelerationStructureToMemoryKHRPointer;
		private static CommandCopyAccelerationStructureToMemoryKHRDelegate_0 CommandCopyAccelerationStructureToMemoryKHR_0;
		private static CommandCopyAccelerationStructureToMemoryKHRDelegate_1 CommandCopyAccelerationStructureToMemoryKHR_1;
		private static IntPtr CopyAccelerationStructureToMemoryKHRPointer;
		private static CopyAccelerationStructureToMemoryKHRDelegate_0 CopyAccelerationStructureToMemoryKHR_0;
		private static CopyAccelerationStructureToMemoryKHRDelegate_1 CopyAccelerationStructureToMemoryKHR_1;
		private static IntPtr CommandCopyMemoryToAccelerationStructureKHRPointer;
		private static CommandCopyMemoryToAccelerationStructureKHRDelegate_0 CommandCopyMemoryToAccelerationStructureKHR_0;
		private static CommandCopyMemoryToAccelerationStructureKHRDelegate_1 CommandCopyMemoryToAccelerationStructureKHR_1;
		private static IntPtr CopyMemoryToAccelerationStructureKHRPointer;
		private static CopyMemoryToAccelerationStructureKHRDelegate_0 CopyMemoryToAccelerationStructureKHR_0;
		private static CopyMemoryToAccelerationStructureKHRDelegate_1 CopyMemoryToAccelerationStructureKHR_1;
		private static IntPtr CommandWriteAccelerationStructuresPropertiesKHRPointer;
		private static CommandWriteAccelerationStructuresPropertiesKHRDelegate_0 CommandWriteAccelerationStructuresPropertiesKHR_0;
		private static IntPtr CommandWriteAccelerationStructuresPropertiesNVPointer;
		private static CommandWriteAccelerationStructuresPropertiesNVDelegate_0 CommandWriteAccelerationStructuresPropertiesNV_0;
		private static IntPtr CommandBuildAccelerationStructureNVPointer;
		private static CommandBuildAccelerationStructureNVDelegate_0 CommandBuildAccelerationStructureNV_0;
		private static CommandBuildAccelerationStructureNVDelegate_1 CommandBuildAccelerationStructureNV_1;
		private static IntPtr WriteAccelerationStructuresPropertiesKHRPointer;
		private static WriteAccelerationStructuresPropertiesKHRDelegate_0 WriteAccelerationStructuresPropertiesKHR_0;
		private static IntPtr CommandTraceRaysKHRPointer;
		private static CommandTraceRaysKHRDelegate_0 CommandTraceRaysKHR_0;
		private static CommandTraceRaysKHRDelegate_1 CommandTraceRaysKHR_1;
		private static CommandTraceRaysKHRDelegate_2 CommandTraceRaysKHR_2;
		private static CommandTraceRaysKHRDelegate_3 CommandTraceRaysKHR_3;
		private static CommandTraceRaysKHRDelegate_4 CommandTraceRaysKHR_4;
		private static CommandTraceRaysKHRDelegate_5 CommandTraceRaysKHR_5;
		private static CommandTraceRaysKHRDelegate_6 CommandTraceRaysKHR_6;
		private static CommandTraceRaysKHRDelegate_7 CommandTraceRaysKHR_7;
		private static CommandTraceRaysKHRDelegate_8 CommandTraceRaysKHR_8;
		private static CommandTraceRaysKHRDelegate_9 CommandTraceRaysKHR_9;
		private static CommandTraceRaysKHRDelegate_10 CommandTraceRaysKHR_10;
		private static CommandTraceRaysKHRDelegate_11 CommandTraceRaysKHR_11;
		private static CommandTraceRaysKHRDelegate_12 CommandTraceRaysKHR_12;
		private static CommandTraceRaysKHRDelegate_13 CommandTraceRaysKHR_13;
		private static CommandTraceRaysKHRDelegate_14 CommandTraceRaysKHR_14;
		private static CommandTraceRaysKHRDelegate_15 CommandTraceRaysKHR_15;
		private static IntPtr CommandTraceRaysNVPointer;
		private static CommandTraceRaysNVDelegate_0 CommandTraceRaysNV_0;
		private static IntPtr GetRayTracingShaderGroupHandlesKHRPointer;
		private static GetRayTracingShaderGroupHandlesKHRDelegate_0 GetRayTracingShaderGroupHandlesKHR_0;
		private static IntPtr GetRayTracingCaptureReplayShaderGroupHandlesKHRPointer;
		private static GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0 GetRayTracingCaptureReplayShaderGroupHandlesKHR_0;
		private static IntPtr GetAccelerationStructureHandleNVPointer;
		private static GetAccelerationStructureHandleNVDelegate_0 GetAccelerationStructureHandleNV_0;
		private static IntPtr CreateRayTracingPipelinesNVPointer;
		private static CreateRayTracingPipelinesNVDelegate_0 CreateRayTracingPipelinesNV_0;
		private static CreateRayTracingPipelinesNVDelegate_1 CreateRayTracingPipelinesNV_1;
		private static IntPtr CreateRayTracingPipelinesKHRPointer;
		private static CreateRayTracingPipelinesKHRDelegate_0 CreateRayTracingPipelinesKHR_0;
		private static CreateRayTracingPipelinesKHRDelegate_1 CreateRayTracingPipelinesKHR_1;
		private static IntPtr GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer;
		private static GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0 GetPhysicalDeviceCooperativeMatrixPropertiesNV_0;
		private static GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1 GetPhysicalDeviceCooperativeMatrixPropertiesNV_1;
		private static IntPtr CommandTraceRaysIndirectKHRPointer;
		private static CommandTraceRaysIndirectKHRDelegate_0 CommandTraceRaysIndirectKHR_0;
		private static CommandTraceRaysIndirectKHRDelegate_1 CommandTraceRaysIndirectKHR_1;
		private static CommandTraceRaysIndirectKHRDelegate_2 CommandTraceRaysIndirectKHR_2;
		private static CommandTraceRaysIndirectKHRDelegate_3 CommandTraceRaysIndirectKHR_3;
		private static CommandTraceRaysIndirectKHRDelegate_4 CommandTraceRaysIndirectKHR_4;
		private static CommandTraceRaysIndirectKHRDelegate_5 CommandTraceRaysIndirectKHR_5;
		private static CommandTraceRaysIndirectKHRDelegate_6 CommandTraceRaysIndirectKHR_6;
		private static CommandTraceRaysIndirectKHRDelegate_7 CommandTraceRaysIndirectKHR_7;
		private static CommandTraceRaysIndirectKHRDelegate_8 CommandTraceRaysIndirectKHR_8;
		private static CommandTraceRaysIndirectKHRDelegate_9 CommandTraceRaysIndirectKHR_9;
		private static CommandTraceRaysIndirectKHRDelegate_10 CommandTraceRaysIndirectKHR_10;
		private static CommandTraceRaysIndirectKHRDelegate_11 CommandTraceRaysIndirectKHR_11;
		private static CommandTraceRaysIndirectKHRDelegate_12 CommandTraceRaysIndirectKHR_12;
		private static CommandTraceRaysIndirectKHRDelegate_13 CommandTraceRaysIndirectKHR_13;
		private static CommandTraceRaysIndirectKHRDelegate_14 CommandTraceRaysIndirectKHR_14;
		private static CommandTraceRaysIndirectKHRDelegate_15 CommandTraceRaysIndirectKHR_15;
		private static IntPtr CommandTraceRaysIndirect2KHRPointer;
		private static CommandTraceRaysIndirect2KHRDelegate_0 CommandTraceRaysIndirect2KHR_0;
		private static IntPtr GetDeviceAccelerationStructureCompatibilityKHRPointer;
		private static GetDeviceAccelerationStructureCompatibilityKHRDelegate_0 GetDeviceAccelerationStructureCompatibilityKHR_0;
		private static GetDeviceAccelerationStructureCompatibilityKHRDelegate_1 GetDeviceAccelerationStructureCompatibilityKHR_1;
		private static IntPtr GetRayTracingShaderGroupStackSizeKHRPointer;
		private static GetRayTracingShaderGroupStackSizeKHRDelegate_0 GetRayTracingShaderGroupStackSizeKHR_0;
		private static IntPtr CommandSetRayTracingPipelineStackSizeKHRPointer;
		private static CommandSetRayTracingPipelineStackSizeKHRDelegate_0 CommandSetRayTracingPipelineStackSizeKHR_0;
		private static IntPtr GetImageViewHandleNVXPointer;
		private static GetImageViewHandleNVXDelegate_0 GetImageViewHandleNVX_0;
		private static IntPtr GetImageViewAddressNVXPointer;
		private static GetImageViewAddressNVXDelegate_0 GetImageViewAddressNVX_0;
		private static IntPtr GetPhysicalDeviceSurfacePresentModes2EXTPointer;
		private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0 GetPhysicalDeviceSurfacePresentModes2EXT_0;
		private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1 GetPhysicalDeviceSurfacePresentModes2EXT_1;
		private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2 GetPhysicalDeviceSurfacePresentModes2EXT_2;
		private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3 GetPhysicalDeviceSurfacePresentModes2EXT_3;
		private static IntPtr GetDeviceGroupSurfacePresentModes2EXTPointer;
		private static GetDeviceGroupSurfacePresentModes2EXTDelegate_0 GetDeviceGroupSurfacePresentModes2EXT_0;
		private static GetDeviceGroupSurfacePresentModes2EXTDelegate_1 GetDeviceGroupSurfacePresentModes2EXT_1;
		private static IntPtr AcquireFullScreenExclusiveModeEXTPointer;
		private static AcquireFullScreenExclusiveModeEXTDelegate_0 AcquireFullScreenExclusiveModeEXT_0;
		private static IntPtr ReleaseFullScreenExclusiveModeEXTPointer;
		private static ReleaseFullScreenExclusiveModeEXTDelegate_0 ReleaseFullScreenExclusiveModeEXT_0;
		private static IntPtr EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer;
		private static EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0 EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0;
		private static EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1 EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1;
		private static IntPtr GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer;
		private static GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0 GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0;
		private static GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1 GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1;
		private static IntPtr AcquireProfilingLockKHRPointer;
		private static AcquireProfilingLockKHRDelegate_0 AcquireProfilingLockKHR_0;
		private static AcquireProfilingLockKHRDelegate_1 AcquireProfilingLockKHR_1;
		private static IntPtr ReleaseProfilingLockKHRPointer;
		private static ReleaseProfilingLockKHRDelegate_0 ReleaseProfilingLockKHR_0;
		private static IntPtr GetImageDrmFormatModifierPropertiesEXTPointer;
		private static GetImageDrmFormatModifierPropertiesEXTDelegate_0 GetImageDrmFormatModifierPropertiesEXT_0;
		private static IntPtr GetBufferOpaqueCaptureAddressPointer;
		private static GetBufferOpaqueCaptureAddressDelegate_0 GetBufferOpaqueCaptureAddress_0;
		private static IntPtr GetBufferDeviceAddressPointer;
		private static GetBufferDeviceAddressDelegate_0 GetBufferDeviceAddress_0;
		private static IntPtr CreateHeadlessSurfaceEXTPointer;
		private static CreateHeadlessSurfaceEXTDelegate_0 CreateHeadlessSurfaceEXT_0;
		private static CreateHeadlessSurfaceEXTDelegate_1 CreateHeadlessSurfaceEXT_1;
		private static CreateHeadlessSurfaceEXTDelegate_2 CreateHeadlessSurfaceEXT_2;
		private static CreateHeadlessSurfaceEXTDelegate_3 CreateHeadlessSurfaceEXT_3;
		private static IntPtr GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer;
		private static GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0 GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0;
		private static GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1 GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1;
		private static IntPtr InitializePerformanceApiINTELPointer;
		private static InitializePerformanceApiINTELDelegate_0 InitializePerformanceApiINTEL_0;
		private static InitializePerformanceApiINTELDelegate_1 InitializePerformanceApiINTEL_1;
		private static IntPtr UninitializePerformanceApiINTELPointer;
		private static UninitializePerformanceApiINTELDelegate_0 UninitializePerformanceApiINTEL_0;
		private static IntPtr CommandSetPerformanceMarkerINTELPointer;
		private static CommandSetPerformanceMarkerINTELDelegate_0 CommandSetPerformanceMarkerINTEL_0;
		private static CommandSetPerformanceMarkerINTELDelegate_1 CommandSetPerformanceMarkerINTEL_1;
		private static IntPtr CommandSetPerformanceStreamMarkerINTELPointer;
		private static CommandSetPerformanceStreamMarkerINTELDelegate_0 CommandSetPerformanceStreamMarkerINTEL_0;
		private static CommandSetPerformanceStreamMarkerINTELDelegate_1 CommandSetPerformanceStreamMarkerINTEL_1;
		private static IntPtr CommandSetPerformanceOverrideINTELPointer;
		private static CommandSetPerformanceOverrideINTELDelegate_0 CommandSetPerformanceOverrideINTEL_0;
		private static CommandSetPerformanceOverrideINTELDelegate_1 CommandSetPerformanceOverrideINTEL_1;
		private static IntPtr AcquirePerformanceConfigurationINTELPointer;
		private static AcquirePerformanceConfigurationINTELDelegate_0 AcquirePerformanceConfigurationINTEL_0;
		private static AcquirePerformanceConfigurationINTELDelegate_1 AcquirePerformanceConfigurationINTEL_1;
		private static AcquirePerformanceConfigurationINTELDelegate_2 AcquirePerformanceConfigurationINTEL_2;
		private static AcquirePerformanceConfigurationINTELDelegate_3 AcquirePerformanceConfigurationINTEL_3;
		private static IntPtr ReleasePerformanceConfigurationINTELPointer;
		private static ReleasePerformanceConfigurationINTELDelegate_0 ReleasePerformanceConfigurationINTEL_0;
		private static IntPtr QueueSetPerformanceConfigurationINTELPointer;
		private static QueueSetPerformanceConfigurationINTELDelegate_0 QueueSetPerformanceConfigurationINTEL_0;
		private static IntPtr GetPerformanceParameterINTELPointer;
		private static GetPerformanceParameterINTELDelegate_0 GetPerformanceParameterINTEL_0;
		private static IntPtr GetDeviceMemoryOpaqueCaptureAddressPointer;
		private static GetDeviceMemoryOpaqueCaptureAddressDelegate_0 GetDeviceMemoryOpaqueCaptureAddress_0;
		private static IntPtr GetPipelineExecutablePropertiesKHRPointer;
		private static GetPipelineExecutablePropertiesKHRDelegate_0 GetPipelineExecutablePropertiesKHR_0;
		private static GetPipelineExecutablePropertiesKHRDelegate_1 GetPipelineExecutablePropertiesKHR_1;
		private static GetPipelineExecutablePropertiesKHRDelegate_2 GetPipelineExecutablePropertiesKHR_2;
		private static GetPipelineExecutablePropertiesKHRDelegate_3 GetPipelineExecutablePropertiesKHR_3;
		private static IntPtr GetPipelineExecutableStatisticsKHRPointer;
		private static GetPipelineExecutableStatisticsKHRDelegate_0 GetPipelineExecutableStatisticsKHR_0;
		private static GetPipelineExecutableStatisticsKHRDelegate_1 GetPipelineExecutableStatisticsKHR_1;
		private static GetPipelineExecutableStatisticsKHRDelegate_2 GetPipelineExecutableStatisticsKHR_2;
		private static GetPipelineExecutableStatisticsKHRDelegate_3 GetPipelineExecutableStatisticsKHR_3;
		private static IntPtr GetPipelineExecutableInternalRepresentationsKHRPointer;
		private static GetPipelineExecutableInternalRepresentationsKHRDelegate_0 GetPipelineExecutableInternalRepresentationsKHR_0;
		private static GetPipelineExecutableInternalRepresentationsKHRDelegate_1 GetPipelineExecutableInternalRepresentationsKHR_1;
		private static GetPipelineExecutableInternalRepresentationsKHRDelegate_2 GetPipelineExecutableInternalRepresentationsKHR_2;
		private static GetPipelineExecutableInternalRepresentationsKHRDelegate_3 GetPipelineExecutableInternalRepresentationsKHR_3;
		private static IntPtr CommandSetLineStippleEXTPointer;
		private static CommandSetLineStippleEXTDelegate_0 CommandSetLineStippleEXT_0;
		private static IntPtr GetPhysicalDeviceToolPropertiesPointer;
		private static GetPhysicalDeviceToolPropertiesDelegate_0 GetPhysicalDeviceToolProperties_0;
		private static GetPhysicalDeviceToolPropertiesDelegate_1 GetPhysicalDeviceToolProperties_1;
		private static IntPtr CreateAccelerationStructureKHRPointer;
		private static CreateAccelerationStructureKHRDelegate_0 CreateAccelerationStructureKHR_0;
		private static CreateAccelerationStructureKHRDelegate_1 CreateAccelerationStructureKHR_1;
		private static CreateAccelerationStructureKHRDelegate_2 CreateAccelerationStructureKHR_2;
		private static CreateAccelerationStructureKHRDelegate_3 CreateAccelerationStructureKHR_3;
		private static IntPtr CommandBuildAccelerationStructuresKHRPointer;
		private static CommandBuildAccelerationStructuresKHRDelegate_0 CommandBuildAccelerationStructuresKHR_0;
		private static IntPtr CommandBuildAccelerationStructuresIndirectKHRPointer;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_0 CommandBuildAccelerationStructuresIndirectKHR_0;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_1 CommandBuildAccelerationStructuresIndirectKHR_1;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_2 CommandBuildAccelerationStructuresIndirectKHR_2;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_3 CommandBuildAccelerationStructuresIndirectKHR_3;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_4 CommandBuildAccelerationStructuresIndirectKHR_4;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_5 CommandBuildAccelerationStructuresIndirectKHR_5;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_6 CommandBuildAccelerationStructuresIndirectKHR_6;
		private static CommandBuildAccelerationStructuresIndirectKHRDelegate_7 CommandBuildAccelerationStructuresIndirectKHR_7;
		private static IntPtr BuildAccelerationStructuresKHRPointer;
		private static BuildAccelerationStructuresKHRDelegate_0 BuildAccelerationStructuresKHR_0;
		private static IntPtr GetAccelerationStructureDeviceAddressKHRPointer;
		private static GetAccelerationStructureDeviceAddressKHRDelegate_0 GetAccelerationStructureDeviceAddressKHR_0;
		private static IntPtr CreateDeferredOperationKHRPointer;
		private static CreateDeferredOperationKHRDelegate_0 CreateDeferredOperationKHR_0;
		private static CreateDeferredOperationKHRDelegate_1 CreateDeferredOperationKHR_1;
		private static IntPtr DestroyDeferredOperationKHRPointer;
		private static DestroyDeferredOperationKHRDelegate_0 DestroyDeferredOperationKHR_0;
		private static DestroyDeferredOperationKHRDelegate_1 DestroyDeferredOperationKHR_1;
		private static IntPtr GetDeferredOperationMaxConcurrencyKHRPointer;
		private static GetDeferredOperationMaxConcurrencyKHRDelegate_0 GetDeferredOperationMaxConcurrencyKHR_0;
		private static IntPtr GetDeferredOperationResultKHRPointer;
		private static GetDeferredOperationResultKHRDelegate_0 GetDeferredOperationResultKHR_0;
		private static IntPtr DeferredOperationJoinKHRPointer;
		private static DeferredOperationJoinKHRDelegate_0 DeferredOperationJoinKHR_0;
		private static IntPtr CommandSetCullModePointer;
		private static CommandSetCullModeDelegate_0 CommandSetCullMode_0;
		private static IntPtr CommandSetFrontFacePointer;
		private static CommandSetFrontFaceDelegate_0 CommandSetFrontFace_0;
		private static IntPtr CommandSetPrimitiveTopologyPointer;
		private static CommandSetPrimitiveTopologyDelegate_0 CommandSetPrimitiveTopology_0;
		private static IntPtr CommandSetViewportWithCountPointer;
		private static CommandSetViewportWithCountDelegate_0 CommandSetViewportWithCount_0;
		private static IntPtr CommandSetScissorWithCountPointer;
		private static CommandSetScissorWithCountDelegate_0 CommandSetScissorWithCount_0;
		private static IntPtr CommandBindVertexBuffers2Pointer;
		private static CommandBindVertexBuffers2Delegate_0 CommandBindVertexBuffers2_0;
		private static CommandBindVertexBuffers2Delegate_1 CommandBindVertexBuffers2_1;
		private static CommandBindVertexBuffers2Delegate_2 CommandBindVertexBuffers2_2;
		private static CommandBindVertexBuffers2Delegate_3 CommandBindVertexBuffers2_3;
		private static CommandBindVertexBuffers2Delegate_4 CommandBindVertexBuffers2_4;
		private static CommandBindVertexBuffers2Delegate_5 CommandBindVertexBuffers2_5;
		private static CommandBindVertexBuffers2Delegate_6 CommandBindVertexBuffers2_6;
		private static CommandBindVertexBuffers2Delegate_7 CommandBindVertexBuffers2_7;
		private static CommandBindVertexBuffers2Delegate_8 CommandBindVertexBuffers2_8;
		private static CommandBindVertexBuffers2Delegate_9 CommandBindVertexBuffers2_9;
		private static CommandBindVertexBuffers2Delegate_10 CommandBindVertexBuffers2_10;
		private static CommandBindVertexBuffers2Delegate_11 CommandBindVertexBuffers2_11;
		private static CommandBindVertexBuffers2Delegate_12 CommandBindVertexBuffers2_12;
		private static CommandBindVertexBuffers2Delegate_13 CommandBindVertexBuffers2_13;
		private static CommandBindVertexBuffers2Delegate_14 CommandBindVertexBuffers2_14;
		private static CommandBindVertexBuffers2Delegate_15 CommandBindVertexBuffers2_15;
		private static IntPtr CommandSetDepthTestEnablePointer;
		private static CommandSetDepthTestEnableDelegate_0 CommandSetDepthTestEnable_0;
		private static IntPtr CommandSetDepthWriteEnablePointer;
		private static CommandSetDepthWriteEnableDelegate_0 CommandSetDepthWriteEnable_0;
		private static IntPtr CommandSetDepthCompareOpPointer;
		private static CommandSetDepthCompareOpDelegate_0 CommandSetDepthCompareOp_0;
		private static IntPtr CommandSetDepthBoundsTestEnablePointer;
		private static CommandSetDepthBoundsTestEnableDelegate_0 CommandSetDepthBoundsTestEnable_0;
		private static IntPtr CommandSetStencilTestEnablePointer;
		private static CommandSetStencilTestEnableDelegate_0 CommandSetStencilTestEnable_0;
		private static IntPtr CommandSetStencilOpPointer;
		private static CommandSetStencilOpDelegate_0 CommandSetStencilOp_0;
		private static IntPtr CommandSetPatchControlPointsEXTPointer;
		private static CommandSetPatchControlPointsEXTDelegate_0 CommandSetPatchControlPointsEXT_0;
		private static IntPtr CommandSetRasterizerDiscardEnablePointer;
		private static CommandSetRasterizerDiscardEnableDelegate_0 CommandSetRasterizerDiscardEnable_0;
		private static IntPtr CommandSetDepthBiasEnablePointer;
		private static CommandSetDepthBiasEnableDelegate_0 CommandSetDepthBiasEnable_0;
		private static IntPtr CommandSetLogicOpEXTPointer;
		private static CommandSetLogicOpEXTDelegate_0 CommandSetLogicOpEXT_0;
		private static IntPtr CommandSetPrimitiveRestartEnablePointer;
		private static CommandSetPrimitiveRestartEnableDelegate_0 CommandSetPrimitiveRestartEnable_0;
		private static IntPtr CreatePrivateDataSlotPointer;
		private static CreatePrivateDataSlotDelegate_0 CreatePrivateDataSlot_0;
		private static CreatePrivateDataSlotDelegate_1 CreatePrivateDataSlot_1;
		private static CreatePrivateDataSlotDelegate_2 CreatePrivateDataSlot_2;
		private static CreatePrivateDataSlotDelegate_3 CreatePrivateDataSlot_3;
		private static IntPtr DestroyPrivateDataSlotPointer;
		private static DestroyPrivateDataSlotDelegate_0 DestroyPrivateDataSlot_0;
		private static DestroyPrivateDataSlotDelegate_1 DestroyPrivateDataSlot_1;
		private static IntPtr SetPrivateDataPointer;
		private static SetPrivateDataDelegate_0 SetPrivateData_0;
		private static IntPtr GetPrivateDataPointer;
		private static GetPrivateDataDelegate_0 GetPrivateData_0;
		private static IntPtr CommandCopyBuffer2Pointer;
		private static CommandCopyBuffer2Delegate_0 CommandCopyBuffer2_0;
		private static CommandCopyBuffer2Delegate_1 CommandCopyBuffer2_1;
		private static IntPtr CommandCopyImage2Pointer;
		private static CommandCopyImage2Delegate_0 CommandCopyImage2_0;
		private static CommandCopyImage2Delegate_1 CommandCopyImage2_1;
		private static IntPtr CommandBlitImage2Pointer;
		private static CommandBlitImage2Delegate_0 CommandBlitImage2_0;
		private static CommandBlitImage2Delegate_1 CommandBlitImage2_1;
		private static IntPtr CommandCopyBufferToImage2Pointer;
		private static CommandCopyBufferToImage2Delegate_0 CommandCopyBufferToImage2_0;
		private static CommandCopyBufferToImage2Delegate_1 CommandCopyBufferToImage2_1;
		private static IntPtr CommandCopyImageToBuffer2Pointer;
		private static CommandCopyImageToBuffer2Delegate_0 CommandCopyImageToBuffer2_0;
		private static CommandCopyImageToBuffer2Delegate_1 CommandCopyImageToBuffer2_1;
		private static IntPtr CommandResolveImage2Pointer;
		private static CommandResolveImage2Delegate_0 CommandResolveImage2_0;
		private static CommandResolveImage2Delegate_1 CommandResolveImage2_1;
		private static IntPtr CommandSetFragmentShadingRateKHRPointer;
		private static CommandSetFragmentShadingRateKHRDelegate_0 CommandSetFragmentShadingRateKHR_0;
		private static CommandSetFragmentShadingRateKHRDelegate_1 CommandSetFragmentShadingRateKHR_1;
		private static IntPtr GetPhysicalDeviceFragmentShadingRatesKHRPointer;
		private static GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0 GetPhysicalDeviceFragmentShadingRatesKHR_0;
		private static GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1 GetPhysicalDeviceFragmentShadingRatesKHR_1;
		private static IntPtr CommandSetFragmentShadingRateEnumNVPointer;
		private static CommandSetFragmentShadingRateEnumNVDelegate_0 CommandSetFragmentShadingRateEnumNV_0;
		private static IntPtr GetAccelerationStructureBuildSizesKHRPointer;
		private static GetAccelerationStructureBuildSizesKHRDelegate_0 GetAccelerationStructureBuildSizesKHR_0;
		private static GetAccelerationStructureBuildSizesKHRDelegate_1 GetAccelerationStructureBuildSizesKHR_1;
		private static GetAccelerationStructureBuildSizesKHRDelegate_2 GetAccelerationStructureBuildSizesKHR_2;
		private static GetAccelerationStructureBuildSizesKHRDelegate_3 GetAccelerationStructureBuildSizesKHR_3;
		private static IntPtr CommandSetVertexInputEXTPointer;
		private static CommandSetVertexInputEXTDelegate_0 CommandSetVertexInputEXT_0;
		private static IntPtr CommandSetColorWriteEnableEXTPointer;
		private static CommandSetColorWriteEnableEXTDelegate_0 CommandSetColorWriteEnableEXT_0;
		private static CommandSetColorWriteEnableEXTDelegate_1 CommandSetColorWriteEnableEXT_1;
		private static IntPtr CommandSetEvent2Pointer;
		private static CommandSetEvent2Delegate_0 CommandSetEvent2_0;
		private static CommandSetEvent2Delegate_1 CommandSetEvent2_1;
		private static IntPtr CommandResetEvent2Pointer;
		private static CommandResetEvent2Delegate_0 CommandResetEvent2_0;
		private static IntPtr CommandWaitEvents2Pointer;
		private static CommandWaitEvents2Delegate_0 CommandWaitEvents2_0;
		private static IntPtr CommandPipelineBarrier2Pointer;
		private static CommandPipelineBarrier2Delegate_0 CommandPipelineBarrier2_0;
		private static CommandPipelineBarrier2Delegate_1 CommandPipelineBarrier2_1;
		private static IntPtr QueueSubmit2Pointer;
		private static QueueSubmit2Delegate_0 QueueSubmit2_0;
		private static IntPtr CommandWriteTimestamp2Pointer;
		private static CommandWriteTimestamp2Delegate_0 CommandWriteTimestamp2_0;
		private static IntPtr CommandWriteBufferMarker2AMDPointer;
		private static CommandWriteBufferMarker2AMDDelegate_0 CommandWriteBufferMarker2AMD_0;
		private static IntPtr GetQueueCheckpointData2NVPointer;
		private static GetQueueCheckpointData2NVDelegate_0 GetQueueCheckpointData2NV_0;
		private static GetQueueCheckpointData2NVDelegate_1 GetQueueCheckpointData2NV_1;
		private static IntPtr CreateCuModuleNVXPointer;
		private static CreateCuModuleNVXDelegate_0 CreateCuModuleNVX_0;
		private static CreateCuModuleNVXDelegate_1 CreateCuModuleNVX_1;
		private static CreateCuModuleNVXDelegate_2 CreateCuModuleNVX_2;
		private static CreateCuModuleNVXDelegate_3 CreateCuModuleNVX_3;
		private static IntPtr CreateCuFunctionNVXPointer;
		private static CreateCuFunctionNVXDelegate_0 CreateCuFunctionNVX_0;
		private static CreateCuFunctionNVXDelegate_1 CreateCuFunctionNVX_1;
		private static CreateCuFunctionNVXDelegate_2 CreateCuFunctionNVX_2;
		private static CreateCuFunctionNVXDelegate_3 CreateCuFunctionNVX_3;
		private static IntPtr DestroyCuModuleNVXPointer;
		private static DestroyCuModuleNVXDelegate_0 DestroyCuModuleNVX_0;
		private static DestroyCuModuleNVXDelegate_1 DestroyCuModuleNVX_1;
		private static IntPtr DestroyCuFunctionNVXPointer;
		private static DestroyCuFunctionNVXDelegate_0 DestroyCuFunctionNVX_0;
		private static DestroyCuFunctionNVXDelegate_1 DestroyCuFunctionNVX_1;
		private static IntPtr CommandCuLaunchKernelNVXPointer;
		private static CommandCuLaunchKernelNVXDelegate_0 CommandCuLaunchKernelNVX_0;
		private static CommandCuLaunchKernelNVXDelegate_1 CommandCuLaunchKernelNVX_1;
		private static IntPtr SetDeviceMemoryPriorityEXTPointer;
		private static SetDeviceMemoryPriorityEXTDelegate_0 SetDeviceMemoryPriorityEXT_0;
		private static IntPtr AcquireDrmDisplayEXTPointer;
		private static AcquireDrmDisplayEXTDelegate_0 AcquireDrmDisplayEXT_0;
		private static IntPtr GetDrmDisplayEXTPointer;
		private static GetDrmDisplayEXTDelegate_0 GetDrmDisplayEXT_0;
		private static IntPtr WaitForPresentKHRPointer;
		private static WaitForPresentKHRDelegate_0 WaitForPresentKHR_0;
		private static IntPtr CommandBeginRenderingPointer;
		private static CommandBeginRenderingDelegate_0 CommandBeginRendering_0;
		private static CommandBeginRenderingDelegate_1 CommandBeginRendering_1;
		private static IntPtr CommandEndRenderingPointer;
		private static CommandEndRenderingDelegate_0 CommandEndRendering_0;
		private static IntPtr GetDescriptorSetLayoutHostMappingInfoVALVEPointer;
		private static GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_0 GetDescriptorSetLayoutHostMappingInfoVALVE_0;
		private static GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_1 GetDescriptorSetLayoutHostMappingInfoVALVE_1;
		private static IntPtr GetDescriptorSetHostMappingVALVEPointer;
		private static GetDescriptorSetHostMappingVALVEDelegate_0 GetDescriptorSetHostMappingVALVE_0;
		private static IntPtr GetImageSubresourceLayout2EXTPointer;
		private static GetImageSubresourceLayout2EXTDelegate_0 GetImageSubresourceLayout2EXT_0;
		private static GetImageSubresourceLayout2EXTDelegate_1 GetImageSubresourceLayout2EXT_1;
		private static IntPtr GetPipelinePropertiesEXTPointer;
		private static GetPipelinePropertiesEXTDelegate_0 GetPipelinePropertiesEXT_0;
		private static GetPipelinePropertiesEXTDelegate_1 GetPipelinePropertiesEXT_1;
		static VK()
		{
			VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();
			InitialiseRequiredMethods();
		}
		private static void InitialiseRequiredMethods()
		{
			CreateInstancePointer = VulkanLibrary.GetFunctionPointer("vkCreateInstance");
			CreateInstance_0 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_0>(CreateInstancePointer);
			CreateInstance_1 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_1>(CreateInstancePointer);
			CreateInstance_2 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_2>(CreateInstancePointer);
			CreateInstance_3 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_3>(CreateInstancePointer);
			GetInstancePrecedureAddressPointer = VulkanLibrary.GetFunctionPointer("vkGetInstanceProcAddr");
			GetInstancePrecedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetInstancePrecedureAddressDelegate_0>(GetInstancePrecedureAddressPointer);
			GetInstancePrecedureAddress_1 = Marshal.GetDelegateForFunctionPointer<GetInstancePrecedureAddressDelegate_1>(GetInstancePrecedureAddressPointer);
			EnumerateInstanceLayerPropertiesPointer = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceLayerProperties");
			EnumerateInstanceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_0>(EnumerateInstanceLayerPropertiesPointer);
			EnumerateInstanceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_1>(EnumerateInstanceLayerPropertiesPointer);
			EnumerateInstanceExtensionPropertiesPointer = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceExtensionProperties");
			EnumerateInstanceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_0>(EnumerateInstanceExtensionPropertiesPointer);
			EnumerateInstanceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_1>(EnumerateInstanceExtensionPropertiesPointer);
			EnumerateInstanceExtensionProperties_2 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_2>(EnumerateInstanceExtensionPropertiesPointer);
			EnumerateInstanceExtensionProperties_3 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_3>(EnumerateInstanceExtensionPropertiesPointer);
		}
		public static void InitialiseInstanceMethods(VkInstance instance)
		{
			DestroyInstancePointer = GetInstancePrecedureAddress(instance, "vkDestroyInstance");
			if (DestroyInstancePointer != IntPtr.Zero)
			{
				DestroyInstance_0 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_0>(DestroyInstancePointer);
				DestroyInstance_1 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_1>(DestroyInstancePointer);
			}
			EnumeratePhysicalDevicesPointer = GetInstancePrecedureAddress(instance, "vkEnumeratePhysicalDevices");
			if (EnumeratePhysicalDevicesPointer != IntPtr.Zero)
			{
				EnumeratePhysicalDevices_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_0>(EnumeratePhysicalDevicesPointer);
				EnumeratePhysicalDevices_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_1>(EnumeratePhysicalDevicesPointer);
			}
			GetDevicePrecedureAddressPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceProcAddr");
			if (GetDevicePrecedureAddressPointer != IntPtr.Zero)
			{
				GetDevicePrecedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetDevicePrecedureAddressDelegate_0>(GetDevicePrecedureAddressPointer);
				GetDevicePrecedureAddress_1 = Marshal.GetDelegateForFunctionPointer<GetDevicePrecedureAddressDelegate_1>(GetDevicePrecedureAddressPointer);
			}
			GetPhysicalDevicePropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceProperties");
			if (GetPhysicalDevicePropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePropertiesDelegate_0>(GetPhysicalDevicePropertiesPointer);
			}
			GetPhysicalDeviceQueueFamilyPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties");
			if (GetPhysicalDeviceQueueFamilyPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceQueueFamilyProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_0>(GetPhysicalDeviceQueueFamilyPropertiesPointer);
				GetPhysicalDeviceQueueFamilyProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_1>(GetPhysicalDeviceQueueFamilyPropertiesPointer);
			}
			GetPhysicalDeviceMemoryPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceMemoryProperties");
			if (GetPhysicalDeviceMemoryPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceMemoryProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryPropertiesDelegate_0>(GetPhysicalDeviceMemoryPropertiesPointer);
			}
			GetPhysicalDeviceFeaturesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceFeatures");
			if (GetPhysicalDeviceFeaturesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeaturesDelegate_0>(GetPhysicalDeviceFeaturesPointer);
			}
			GetPhysicalDeviceFormatPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceFormatProperties");
			if (GetPhysicalDeviceFormatPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatPropertiesDelegate_0>(GetPhysicalDeviceFormatPropertiesPointer);
			}
			GetPhysicalDeviceImageFormatPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceImageFormatProperties");
			if (GetPhysicalDeviceImageFormatPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatPropertiesDelegate_0>(GetPhysicalDeviceImageFormatPropertiesPointer);
			}
			CreateDevicePointer = GetInstancePrecedureAddress(instance, "vkCreateDevice");
			if (CreateDevicePointer != IntPtr.Zero)
			{
				CreateDevice_0 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_0>(CreateDevicePointer);
				CreateDevice_1 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_1>(CreateDevicePointer);
				CreateDevice_2 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_2>(CreateDevicePointer);
				CreateDevice_3 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_3>(CreateDevicePointer);
			}
			DestroyDevicePointer = GetInstancePrecedureAddress(instance, "vkDestroyDevice");
			if (DestroyDevicePointer != IntPtr.Zero)
			{
				DestroyDevice_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_0>(DestroyDevicePointer);
				DestroyDevice_1 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_1>(DestroyDevicePointer);
			}
			EnumerateInstanceVersionPointer = GetInstancePrecedureAddress(instance, "vkEnumerateInstanceVersion");
			if (EnumerateInstanceVersionPointer != IntPtr.Zero)
			{
				EnumerateInstanceVersion_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceVersionDelegate_0>(EnumerateInstanceVersionPointer);
			}
			EnumerateDeviceLayerPropertiesPointer = GetInstancePrecedureAddress(instance, "vkEnumerateDeviceLayerProperties");
			if (EnumerateDeviceLayerPropertiesPointer != IntPtr.Zero)
			{
				EnumerateDeviceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_0>(EnumerateDeviceLayerPropertiesPointer);
				EnumerateDeviceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_1>(EnumerateDeviceLayerPropertiesPointer);
			}
			EnumerateDeviceExtensionPropertiesPointer = GetInstancePrecedureAddress(instance, "vkEnumerateDeviceExtensionProperties");
			if (EnumerateDeviceExtensionPropertiesPointer != IntPtr.Zero)
			{
				EnumerateDeviceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_0>(EnumerateDeviceExtensionPropertiesPointer);
				EnumerateDeviceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_1>(EnumerateDeviceExtensionPropertiesPointer);
				EnumerateDeviceExtensionProperties_2 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_2>(EnumerateDeviceExtensionPropertiesPointer);
				EnumerateDeviceExtensionProperties_3 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_3>(EnumerateDeviceExtensionPropertiesPointer);
			}
			GetDeviceQueuePointer = GetInstancePrecedureAddress(instance, "vkGetDeviceQueue");
			if (GetDeviceQueuePointer != IntPtr.Zero)
			{
				GetDeviceQueue_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueueDelegate_0>(GetDeviceQueuePointer);
			}
			QueueSubmitPointer = GetInstancePrecedureAddress(instance, "vkQueueSubmit");
			if (QueueSubmitPointer != IntPtr.Zero)
			{
				QueueSubmit_0 = Marshal.GetDelegateForFunctionPointer<QueueSubmitDelegate_0>(QueueSubmitPointer);
			}
			QueueWaitIdlePointer = GetInstancePrecedureAddress(instance, "vkQueueWaitIdle");
			if (QueueWaitIdlePointer != IntPtr.Zero)
			{
				QueueWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<QueueWaitIdleDelegate_0>(QueueWaitIdlePointer);
			}
			DeviceWaitIdlePointer = GetInstancePrecedureAddress(instance, "vkDeviceWaitIdle");
			if (DeviceWaitIdlePointer != IntPtr.Zero)
			{
				DeviceWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<DeviceWaitIdleDelegate_0>(DeviceWaitIdlePointer);
			}
			AllocateMemoryPointer = GetInstancePrecedureAddress(instance, "vkAllocateMemory");
			if (AllocateMemoryPointer != IntPtr.Zero)
			{
				AllocateMemory_0 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_0>(AllocateMemoryPointer);
				AllocateMemory_1 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_1>(AllocateMemoryPointer);
				AllocateMemory_2 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_2>(AllocateMemoryPointer);
				AllocateMemory_3 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_3>(AllocateMemoryPointer);
			}
			FreeMemoryPointer = GetInstancePrecedureAddress(instance, "vkFreeMemory");
			if (FreeMemoryPointer != IntPtr.Zero)
			{
				FreeMemory_0 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_0>(FreeMemoryPointer);
				FreeMemory_1 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_1>(FreeMemoryPointer);
			}
			MapMemoryPointer = GetInstancePrecedureAddress(instance, "vkMapMemory");
			if (MapMemoryPointer != IntPtr.Zero)
			{
				MapMemory_0 = Marshal.GetDelegateForFunctionPointer<MapMemoryDelegate_0>(MapMemoryPointer);
			}
			UnmapMemoryPointer = GetInstancePrecedureAddress(instance, "vkUnmapMemory");
			if (UnmapMemoryPointer != IntPtr.Zero)
			{
				UnmapMemory_0 = Marshal.GetDelegateForFunctionPointer<UnmapMemoryDelegate_0>(UnmapMemoryPointer);
			}
			FlushMappedMemoryRangesPointer = GetInstancePrecedureAddress(instance, "vkFlushMappedMemoryRanges");
			if (FlushMappedMemoryRangesPointer != IntPtr.Zero)
			{
				FlushMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<FlushMappedMemoryRangesDelegate_0>(FlushMappedMemoryRangesPointer);
			}
			InvalidateMappedMemoryRangesPointer = GetInstancePrecedureAddress(instance, "vkInvalidateMappedMemoryRanges");
			if (InvalidateMappedMemoryRangesPointer != IntPtr.Zero)
			{
				InvalidateMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<InvalidateMappedMemoryRangesDelegate_0>(InvalidateMappedMemoryRangesPointer);
			}
			GetDeviceMemoryCommitmentPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceMemoryCommitment");
			if (GetDeviceMemoryCommitmentPointer != IntPtr.Zero)
			{
				GetDeviceMemoryCommitment_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryCommitmentDelegate_0>(GetDeviceMemoryCommitmentPointer);
			}
			GetBufferMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetBufferMemoryRequirements");
			if (GetBufferMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetBufferMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirementsDelegate_0>(GetBufferMemoryRequirementsPointer);
			}
			BindBufferMemoryPointer = GetInstancePrecedureAddress(instance, "vkBindBufferMemory");
			if (BindBufferMemoryPointer != IntPtr.Zero)
			{
				BindBufferMemory_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemoryDelegate_0>(BindBufferMemoryPointer);
			}
			GetImageMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetImageMemoryRequirements");
			if (GetImageMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetImageMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirementsDelegate_0>(GetImageMemoryRequirementsPointer);
			}
			BindImageMemoryPointer = GetInstancePrecedureAddress(instance, "vkBindImageMemory");
			if (BindImageMemoryPointer != IntPtr.Zero)
			{
				BindImageMemory_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemoryDelegate_0>(BindImageMemoryPointer);
			}
			GetImageSparseMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetImageSparseMemoryRequirements");
			if (GetImageSparseMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetImageSparseMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_0>(GetImageSparseMemoryRequirementsPointer);
				GetImageSparseMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_1>(GetImageSparseMemoryRequirementsPointer);
			}
			GetPhysicalDeviceSparseImageFormatPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties");
			if (GetPhysicalDeviceSparseImageFormatPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSparseImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0>(GetPhysicalDeviceSparseImageFormatPropertiesPointer);
				GetPhysicalDeviceSparseImageFormatProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1>(GetPhysicalDeviceSparseImageFormatPropertiesPointer);
			}
			QueueBindSparsePointer = GetInstancePrecedureAddress(instance, "vkQueueBindSparse");
			if (QueueBindSparsePointer != IntPtr.Zero)
			{
				QueueBindSparse_0 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_0>(QueueBindSparsePointer);
				QueueBindSparse_1 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_1>(QueueBindSparsePointer);
			}
			CreateFencePointer = GetInstancePrecedureAddress(instance, "vkCreateFence");
			if (CreateFencePointer != IntPtr.Zero)
			{
				CreateFence_0 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_0>(CreateFencePointer);
				CreateFence_1 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_1>(CreateFencePointer);
				CreateFence_2 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_2>(CreateFencePointer);
				CreateFence_3 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_3>(CreateFencePointer);
			}
			DestroyFencePointer = GetInstancePrecedureAddress(instance, "vkDestroyFence");
			if (DestroyFencePointer != IntPtr.Zero)
			{
				DestroyFence_0 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_0>(DestroyFencePointer);
				DestroyFence_1 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_1>(DestroyFencePointer);
			}
			ResetFencesPointer = GetInstancePrecedureAddress(instance, "vkResetFences");
			if (ResetFencesPointer != IntPtr.Zero)
			{
				ResetFences_0 = Marshal.GetDelegateForFunctionPointer<ResetFencesDelegate_0>(ResetFencesPointer);
			}
			GetFenceStatusPointer = GetInstancePrecedureAddress(instance, "vkGetFenceStatus");
			if (GetFenceStatusPointer != IntPtr.Zero)
			{
				GetFenceStatus_0 = Marshal.GetDelegateForFunctionPointer<GetFenceStatusDelegate_0>(GetFenceStatusPointer);
			}
			WaitForFencesPointer = GetInstancePrecedureAddress(instance, "vkWaitForFences");
			if (WaitForFencesPointer != IntPtr.Zero)
			{
				WaitForFences_0 = Marshal.GetDelegateForFunctionPointer<WaitForFencesDelegate_0>(WaitForFencesPointer);
			}
			CreateSemaphorePointer = GetInstancePrecedureAddress(instance, "vkCreateSemaphore");
			if (CreateSemaphorePointer != IntPtr.Zero)
			{
				CreateSemaphore_0 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_0>(CreateSemaphorePointer);
				CreateSemaphore_1 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_1>(CreateSemaphorePointer);
				CreateSemaphore_2 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_2>(CreateSemaphorePointer);
				CreateSemaphore_3 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_3>(CreateSemaphorePointer);
			}
			DestroySemaphorePointer = GetInstancePrecedureAddress(instance, "vkDestroySemaphore");
			if (DestroySemaphorePointer != IntPtr.Zero)
			{
				DestroySemaphore_0 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_0>(DestroySemaphorePointer);
				DestroySemaphore_1 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_1>(DestroySemaphorePointer);
			}
			CreateEventPointer = GetInstancePrecedureAddress(instance, "vkCreateEvent");
			if (CreateEventPointer != IntPtr.Zero)
			{
				CreateEvent_0 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_0>(CreateEventPointer);
				CreateEvent_1 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_1>(CreateEventPointer);
				CreateEvent_2 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_2>(CreateEventPointer);
				CreateEvent_3 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_3>(CreateEventPointer);
			}
			DestroyEventPointer = GetInstancePrecedureAddress(instance, "vkDestroyEvent");
			if (DestroyEventPointer != IntPtr.Zero)
			{
				DestroyEvent_0 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_0>(DestroyEventPointer);
				DestroyEvent_1 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_1>(DestroyEventPointer);
			}
			GetEventStatusPointer = GetInstancePrecedureAddress(instance, "vkGetEventStatus");
			if (GetEventStatusPointer != IntPtr.Zero)
			{
				GetEventStatus_0 = Marshal.GetDelegateForFunctionPointer<GetEventStatusDelegate_0>(GetEventStatusPointer);
			}
			SetEventPointer = GetInstancePrecedureAddress(instance, "vkSetEvent");
			if (SetEventPointer != IntPtr.Zero)
			{
				SetEvent_0 = Marshal.GetDelegateForFunctionPointer<SetEventDelegate_0>(SetEventPointer);
			}
			ResetEventPointer = GetInstancePrecedureAddress(instance, "vkResetEvent");
			if (ResetEventPointer != IntPtr.Zero)
			{
				ResetEvent_0 = Marshal.GetDelegateForFunctionPointer<ResetEventDelegate_0>(ResetEventPointer);
			}
			CreateQueryPoolPointer = GetInstancePrecedureAddress(instance, "vkCreateQueryPool");
			if (CreateQueryPoolPointer != IntPtr.Zero)
			{
				CreateQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_0>(CreateQueryPoolPointer);
				CreateQueryPool_1 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_1>(CreateQueryPoolPointer);
				CreateQueryPool_2 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_2>(CreateQueryPoolPointer);
				CreateQueryPool_3 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_3>(CreateQueryPoolPointer);
			}
			DestroyQueryPoolPointer = GetInstancePrecedureAddress(instance, "vkDestroyQueryPool");
			if (DestroyQueryPoolPointer != IntPtr.Zero)
			{
				DestroyQueryPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_0>(DestroyQueryPoolPointer);
				DestroyQueryPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_1>(DestroyQueryPoolPointer);
			}
			GetQueryPoolResultsPointer = GetInstancePrecedureAddress(instance, "vkGetQueryPoolResults");
			if (GetQueryPoolResultsPointer != IntPtr.Zero)
			{
				GetQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<GetQueryPoolResultsDelegate_0>(GetQueryPoolResultsPointer);
			}
			ResetQueryPoolPointer = GetInstancePrecedureAddress(instance, "vkResetQueryPool");
			if (ResetQueryPoolPointer != IntPtr.Zero)
			{
				ResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<ResetQueryPoolDelegate_0>(ResetQueryPoolPointer);
			}
			CreateBufferPointer = GetInstancePrecedureAddress(instance, "vkCreateBuffer");
			if (CreateBufferPointer != IntPtr.Zero)
			{
				CreateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_0>(CreateBufferPointer);
				CreateBuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_1>(CreateBufferPointer);
				CreateBuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_2>(CreateBufferPointer);
				CreateBuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_3>(CreateBufferPointer);
			}
			DestroyBufferPointer = GetInstancePrecedureAddress(instance, "vkDestroyBuffer");
			if (DestroyBufferPointer != IntPtr.Zero)
			{
				DestroyBuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_0>(DestroyBufferPointer);
				DestroyBuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_1>(DestroyBufferPointer);
			}
			CreateBufferViewPointer = GetInstancePrecedureAddress(instance, "vkCreateBufferView");
			if (CreateBufferViewPointer != IntPtr.Zero)
			{
				CreateBufferView_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_0>(CreateBufferViewPointer);
				CreateBufferView_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_1>(CreateBufferViewPointer);
				CreateBufferView_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_2>(CreateBufferViewPointer);
				CreateBufferView_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_3>(CreateBufferViewPointer);
			}
			DestroyBufferViewPointer = GetInstancePrecedureAddress(instance, "vkDestroyBufferView");
			if (DestroyBufferViewPointer != IntPtr.Zero)
			{
				DestroyBufferView_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_0>(DestroyBufferViewPointer);
				DestroyBufferView_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_1>(DestroyBufferViewPointer);
			}
			CreateImagePointer = GetInstancePrecedureAddress(instance, "vkCreateImage");
			if (CreateImagePointer != IntPtr.Zero)
			{
				CreateImage_0 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_0>(CreateImagePointer);
				CreateImage_1 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_1>(CreateImagePointer);
				CreateImage_2 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_2>(CreateImagePointer);
				CreateImage_3 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_3>(CreateImagePointer);
			}
			DestroyImagePointer = GetInstancePrecedureAddress(instance, "vkDestroyImage");
			if (DestroyImagePointer != IntPtr.Zero)
			{
				DestroyImage_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_0>(DestroyImagePointer);
				DestroyImage_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_1>(DestroyImagePointer);
			}
			GetImageSubresourceLayoutPointer = GetInstancePrecedureAddress(instance, "vkGetImageSubresourceLayout");
			if (GetImageSubresourceLayoutPointer != IntPtr.Zero)
			{
				GetImageSubresourceLayout_0 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_0>(GetImageSubresourceLayoutPointer);
				GetImageSubresourceLayout_1 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_1>(GetImageSubresourceLayoutPointer);
			}
			CreateImageViewPointer = GetInstancePrecedureAddress(instance, "vkCreateImageView");
			if (CreateImageViewPointer != IntPtr.Zero)
			{
				CreateImageView_0 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_0>(CreateImageViewPointer);
				CreateImageView_1 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_1>(CreateImageViewPointer);
				CreateImageView_2 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_2>(CreateImageViewPointer);
				CreateImageView_3 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_3>(CreateImageViewPointer);
			}
			DestroyImageViewPointer = GetInstancePrecedureAddress(instance, "vkDestroyImageView");
			if (DestroyImageViewPointer != IntPtr.Zero)
			{
				DestroyImageView_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_0>(DestroyImageViewPointer);
				DestroyImageView_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_1>(DestroyImageViewPointer);
			}
			CreateShaderModulePointer = GetInstancePrecedureAddress(instance, "vkCreateShaderModule");
			if (CreateShaderModulePointer != IntPtr.Zero)
			{
				CreateShaderModule_0 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_0>(CreateShaderModulePointer);
				CreateShaderModule_1 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_1>(CreateShaderModulePointer);
				CreateShaderModule_2 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_2>(CreateShaderModulePointer);
				CreateShaderModule_3 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_3>(CreateShaderModulePointer);
			}
			DestroyShaderModulePointer = GetInstancePrecedureAddress(instance, "vkDestroyShaderModule");
			if (DestroyShaderModulePointer != IntPtr.Zero)
			{
				DestroyShaderModule_0 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_0>(DestroyShaderModulePointer);
				DestroyShaderModule_1 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_1>(DestroyShaderModulePointer);
			}
			CreatePipelineCachePointer = GetInstancePrecedureAddress(instance, "vkCreatePipelineCache");
			if (CreatePipelineCachePointer != IntPtr.Zero)
			{
				CreatePipelineCache_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_0>(CreatePipelineCachePointer);
				CreatePipelineCache_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_1>(CreatePipelineCachePointer);
				CreatePipelineCache_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_2>(CreatePipelineCachePointer);
				CreatePipelineCache_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_3>(CreatePipelineCachePointer);
			}
			DestroyPipelineCachePointer = GetInstancePrecedureAddress(instance, "vkDestroyPipelineCache");
			if (DestroyPipelineCachePointer != IntPtr.Zero)
			{
				DestroyPipelineCache_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_0>(DestroyPipelineCachePointer);
				DestroyPipelineCache_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_1>(DestroyPipelineCachePointer);
			}
			GetPipelineCacheDataPointer = GetInstancePrecedureAddress(instance, "vkGetPipelineCacheData");
			if (GetPipelineCacheDataPointer != IntPtr.Zero)
			{
				GetPipelineCacheData_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_0>(GetPipelineCacheDataPointer);
				GetPipelineCacheData_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_1>(GetPipelineCacheDataPointer);
			}
			MergePipelineCachesPointer = GetInstancePrecedureAddress(instance, "vkMergePipelineCaches");
			if (MergePipelineCachesPointer != IntPtr.Zero)
			{
				MergePipelineCaches_0 = Marshal.GetDelegateForFunctionPointer<MergePipelineCachesDelegate_0>(MergePipelineCachesPointer);
			}
			CreateGraphicsPipelinesPointer = GetInstancePrecedureAddress(instance, "vkCreateGraphicsPipelines");
			if (CreateGraphicsPipelinesPointer != IntPtr.Zero)
			{
				CreateGraphicsPipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_0>(CreateGraphicsPipelinesPointer);
				CreateGraphicsPipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_1>(CreateGraphicsPipelinesPointer);
			}
			CreateComputePipelinesPointer = GetInstancePrecedureAddress(instance, "vkCreateComputePipelines");
			if (CreateComputePipelinesPointer != IntPtr.Zero)
			{
				CreateComputePipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_0>(CreateComputePipelinesPointer);
				CreateComputePipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_1>(CreateComputePipelinesPointer);
			}
			GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
			if (GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer != IntPtr.Zero)
			{
				GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0>(GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer);
			}
			DestroyPipelinePointer = GetInstancePrecedureAddress(instance, "vkDestroyPipeline");
			if (DestroyPipelinePointer != IntPtr.Zero)
			{
				DestroyPipeline_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_0>(DestroyPipelinePointer);
				DestroyPipeline_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_1>(DestroyPipelinePointer);
			}
			CreatePipelineLayoutPointer = GetInstancePrecedureAddress(instance, "vkCreatePipelineLayout");
			if (CreatePipelineLayoutPointer != IntPtr.Zero)
			{
				CreatePipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_0>(CreatePipelineLayoutPointer);
				CreatePipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_1>(CreatePipelineLayoutPointer);
				CreatePipelineLayout_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_2>(CreatePipelineLayoutPointer);
				CreatePipelineLayout_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_3>(CreatePipelineLayoutPointer);
			}
			DestroyPipelineLayoutPointer = GetInstancePrecedureAddress(instance, "vkDestroyPipelineLayout");
			if (DestroyPipelineLayoutPointer != IntPtr.Zero)
			{
				DestroyPipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_0>(DestroyPipelineLayoutPointer);
				DestroyPipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_1>(DestroyPipelineLayoutPointer);
			}
			CreateSamplerPointer = GetInstancePrecedureAddress(instance, "vkCreateSampler");
			if (CreateSamplerPointer != IntPtr.Zero)
			{
				CreateSampler_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_0>(CreateSamplerPointer);
				CreateSampler_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_1>(CreateSamplerPointer);
				CreateSampler_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_2>(CreateSamplerPointer);
				CreateSampler_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_3>(CreateSamplerPointer);
			}
			DestroySamplerPointer = GetInstancePrecedureAddress(instance, "vkDestroySampler");
			if (DestroySamplerPointer != IntPtr.Zero)
			{
				DestroySampler_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_0>(DestroySamplerPointer);
				DestroySampler_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_1>(DestroySamplerPointer);
			}
			CreateDescriptorSetLayoutPointer = GetInstancePrecedureAddress(instance, "vkCreateDescriptorSetLayout");
			if (CreateDescriptorSetLayoutPointer != IntPtr.Zero)
			{
				CreateDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_0>(CreateDescriptorSetLayoutPointer);
				CreateDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_1>(CreateDescriptorSetLayoutPointer);
				CreateDescriptorSetLayout_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_2>(CreateDescriptorSetLayoutPointer);
				CreateDescriptorSetLayout_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_3>(CreateDescriptorSetLayoutPointer);
			}
			DestroyDescriptorSetLayoutPointer = GetInstancePrecedureAddress(instance, "vkDestroyDescriptorSetLayout");
			if (DestroyDescriptorSetLayoutPointer != IntPtr.Zero)
			{
				DestroyDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_0>(DestroyDescriptorSetLayoutPointer);
				DestroyDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_1>(DestroyDescriptorSetLayoutPointer);
			}
			CreateDescriptorPoolPointer = GetInstancePrecedureAddress(instance, "vkCreateDescriptorPool");
			if (CreateDescriptorPoolPointer != IntPtr.Zero)
			{
				CreateDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_0>(CreateDescriptorPoolPointer);
				CreateDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_1>(CreateDescriptorPoolPointer);
				CreateDescriptorPool_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_2>(CreateDescriptorPoolPointer);
				CreateDescriptorPool_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_3>(CreateDescriptorPoolPointer);
			}
			DestroyDescriptorPoolPointer = GetInstancePrecedureAddress(instance, "vkDestroyDescriptorPool");
			if (DestroyDescriptorPoolPointer != IntPtr.Zero)
			{
				DestroyDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_0>(DestroyDescriptorPoolPointer);
				DestroyDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_1>(DestroyDescriptorPoolPointer);
			}
			ResetDescriptorPoolPointer = GetInstancePrecedureAddress(instance, "vkResetDescriptorPool");
			if (ResetDescriptorPoolPointer != IntPtr.Zero)
			{
				ResetDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<ResetDescriptorPoolDelegate_0>(ResetDescriptorPoolPointer);
			}
			AllocateDescriptorSetsPointer = GetInstancePrecedureAddress(instance, "vkAllocateDescriptorSets");
			if (AllocateDescriptorSetsPointer != IntPtr.Zero)
			{
				AllocateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_0>(AllocateDescriptorSetsPointer);
				AllocateDescriptorSets_1 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_1>(AllocateDescriptorSetsPointer);
			}
			FreeDescriptorSetsPointer = GetInstancePrecedureAddress(instance, "vkFreeDescriptorSets");
			if (FreeDescriptorSetsPointer != IntPtr.Zero)
			{
				FreeDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<FreeDescriptorSetsDelegate_0>(FreeDescriptorSetsPointer);
			}
			UpdateDescriptorSetsPointer = GetInstancePrecedureAddress(instance, "vkUpdateDescriptorSets");
			if (UpdateDescriptorSetsPointer != IntPtr.Zero)
			{
				UpdateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetsDelegate_0>(UpdateDescriptorSetsPointer);
			}
			CreateFramebufferPointer = GetInstancePrecedureAddress(instance, "vkCreateFramebuffer");
			if (CreateFramebufferPointer != IntPtr.Zero)
			{
				CreateFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_0>(CreateFramebufferPointer);
				CreateFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_1>(CreateFramebufferPointer);
				CreateFramebuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_2>(CreateFramebufferPointer);
				CreateFramebuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_3>(CreateFramebufferPointer);
			}
			DestroyFramebufferPointer = GetInstancePrecedureAddress(instance, "vkDestroyFramebuffer");
			if (DestroyFramebufferPointer != IntPtr.Zero)
			{
				DestroyFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_0>(DestroyFramebufferPointer);
				DestroyFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_1>(DestroyFramebufferPointer);
			}
			CreateRenderPassPointer = GetInstancePrecedureAddress(instance, "vkCreateRenderPass");
			if (CreateRenderPassPointer != IntPtr.Zero)
			{
				CreateRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_0>(CreateRenderPassPointer);
				CreateRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_1>(CreateRenderPassPointer);
				CreateRenderPass_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_2>(CreateRenderPassPointer);
				CreateRenderPass_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_3>(CreateRenderPassPointer);
			}
			DestroyRenderPassPointer = GetInstancePrecedureAddress(instance, "vkDestroyRenderPass");
			if (DestroyRenderPassPointer != IntPtr.Zero)
			{
				DestroyRenderPass_0 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_0>(DestroyRenderPassPointer);
				DestroyRenderPass_1 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_1>(DestroyRenderPassPointer);
			}
			GetRenderAreaGranularityPointer = GetInstancePrecedureAddress(instance, "vkGetRenderAreaGranularity");
			if (GetRenderAreaGranularityPointer != IntPtr.Zero)
			{
				GetRenderAreaGranularity_0 = Marshal.GetDelegateForFunctionPointer<GetRenderAreaGranularityDelegate_0>(GetRenderAreaGranularityPointer);
			}
			CreateCommandPoolPointer = GetInstancePrecedureAddress(instance, "vkCreateCommandPool");
			if (CreateCommandPoolPointer != IntPtr.Zero)
			{
				CreateCommandPool_0 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_0>(CreateCommandPoolPointer);
				CreateCommandPool_1 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_1>(CreateCommandPoolPointer);
				CreateCommandPool_2 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_2>(CreateCommandPoolPointer);
				CreateCommandPool_3 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_3>(CreateCommandPoolPointer);
			}
			DestroyCommandPoolPointer = GetInstancePrecedureAddress(instance, "vkDestroyCommandPool");
			if (DestroyCommandPoolPointer != IntPtr.Zero)
			{
				DestroyCommandPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_0>(DestroyCommandPoolPointer);
				DestroyCommandPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_1>(DestroyCommandPoolPointer);
			}
			ResetCommandPoolPointer = GetInstancePrecedureAddress(instance, "vkResetCommandPool");
			if (ResetCommandPoolPointer != IntPtr.Zero)
			{
				ResetCommandPool_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandPoolDelegate_0>(ResetCommandPoolPointer);
			}
			AllocateCommandBuffersPointer = GetInstancePrecedureAddress(instance, "vkAllocateCommandBuffers");
			if (AllocateCommandBuffersPointer != IntPtr.Zero)
			{
				AllocateCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_0>(AllocateCommandBuffersPointer);
				AllocateCommandBuffers_1 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_1>(AllocateCommandBuffersPointer);
			}
			FreeCommandBuffersPointer = GetInstancePrecedureAddress(instance, "vkFreeCommandBuffers");
			if (FreeCommandBuffersPointer != IntPtr.Zero)
			{
				FreeCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<FreeCommandBuffersDelegate_0>(FreeCommandBuffersPointer);
			}
			BeginCommandBufferPointer = GetInstancePrecedureAddress(instance, "vkBeginCommandBuffer");
			if (BeginCommandBufferPointer != IntPtr.Zero)
			{
				BeginCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_0>(BeginCommandBufferPointer);
				BeginCommandBuffer_1 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_1>(BeginCommandBufferPointer);
			}
			EndCommandBufferPointer = GetInstancePrecedureAddress(instance, "vkEndCommandBuffer");
			if (EndCommandBufferPointer != IntPtr.Zero)
			{
				EndCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<EndCommandBufferDelegate_0>(EndCommandBufferPointer);
			}
			ResetCommandBufferPointer = GetInstancePrecedureAddress(instance, "vkResetCommandBuffer");
			if (ResetCommandBufferPointer != IntPtr.Zero)
			{
				ResetCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandBufferDelegate_0>(ResetCommandBufferPointer);
			}
			CommandBindPipelinePointer = GetInstancePrecedureAddress(instance, "vkCmdBindPipeline");
			if (CommandBindPipelinePointer != IntPtr.Zero)
			{
				CommandBindPipeline_0 = Marshal.GetDelegateForFunctionPointer<CommandBindPipelineDelegate_0>(CommandBindPipelinePointer);
			}
			CommandSetViewportPointer = GetInstancePrecedureAddress(instance, "vkCmdSetViewport");
			if (CommandSetViewportPointer != IntPtr.Zero)
			{
				CommandSetViewport_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportDelegate_0>(CommandSetViewportPointer);
			}
			CommandSetScissorPointer = GetInstancePrecedureAddress(instance, "vkCmdSetScissor");
			if (CommandSetScissorPointer != IntPtr.Zero)
			{
				CommandSetScissor_0 = Marshal.GetDelegateForFunctionPointer<CommandSetScissorDelegate_0>(CommandSetScissorPointer);
			}
			CommandSetLineWidthPointer = GetInstancePrecedureAddress(instance, "vkCmdSetLineWidth");
			if (CommandSetLineWidthPointer != IntPtr.Zero)
			{
				CommandSetLineWidth_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineWidthDelegate_0>(CommandSetLineWidthPointer);
			}
			CommandSetDepthBiasPointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthBias");
			if (CommandSetDepthBiasPointer != IntPtr.Zero)
			{
				CommandSetDepthBias_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBiasDelegate_0>(CommandSetDepthBiasPointer);
			}
			CommandSetBlendConstantsPointer = GetInstancePrecedureAddress(instance, "vkCmdSetBlendConstants");
			if (CommandSetBlendConstantsPointer != IntPtr.Zero)
			{
				CommandSetBlendConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandSetBlendConstantsDelegate_0>(CommandSetBlendConstantsPointer);
			}
			CommandSetDepthBoundsPointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthBounds");
			if (CommandSetDepthBoundsPointer != IntPtr.Zero)
			{
				CommandSetDepthBounds_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBoundsDelegate_0>(CommandSetDepthBoundsPointer);
			}
			CommandSetStencilCompareMaskPointer = GetInstancePrecedureAddress(instance, "vkCmdSetStencilCompareMask");
			if (CommandSetStencilCompareMaskPointer != IntPtr.Zero)
			{
				CommandSetStencilCompareMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilCompareMaskDelegate_0>(CommandSetStencilCompareMaskPointer);
			}
			CommandSetStencilWriteMaskPointer = GetInstancePrecedureAddress(instance, "vkCmdSetStencilWriteMask");
			if (CommandSetStencilWriteMaskPointer != IntPtr.Zero)
			{
				CommandSetStencilWriteMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilWriteMaskDelegate_0>(CommandSetStencilWriteMaskPointer);
			}
			CommandSetStencilReferencePointer = GetInstancePrecedureAddress(instance, "vkCmdSetStencilReference");
			if (CommandSetStencilReferencePointer != IntPtr.Zero)
			{
				CommandSetStencilReference_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilReferenceDelegate_0>(CommandSetStencilReferencePointer);
			}
			CommandBindDescriptorSetsPointer = GetInstancePrecedureAddress(instance, "vkCmdBindDescriptorSets");
			if (CommandBindDescriptorSetsPointer != IntPtr.Zero)
			{
				CommandBindDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<CommandBindDescriptorSetsDelegate_0>(CommandBindDescriptorSetsPointer);
			}
			CommandBindIndexBufferPointer = GetInstancePrecedureAddress(instance, "vkCmdBindIndexBuffer");
			if (CommandBindIndexBufferPointer != IntPtr.Zero)
			{
				CommandBindIndexBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandBindIndexBufferDelegate_0>(CommandBindIndexBufferPointer);
			}
			CommandBindVertexBuffersPointer = GetInstancePrecedureAddress(instance, "vkCmdBindVertexBuffers");
			if (CommandBindVertexBuffersPointer != IntPtr.Zero)
			{
				CommandBindVertexBuffers_0 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_0>(CommandBindVertexBuffersPointer);
				CommandBindVertexBuffers_1 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_1>(CommandBindVertexBuffersPointer);
				CommandBindVertexBuffers_2 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_2>(CommandBindVertexBuffersPointer);
				CommandBindVertexBuffers_3 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_3>(CommandBindVertexBuffersPointer);
			}
			CommandDrawPointer = GetInstancePrecedureAddress(instance, "vkCmdDraw");
			if (CommandDrawPointer != IntPtr.Zero)
			{
				CommandDraw_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawDelegate_0>(CommandDrawPointer);
			}
			CommandDrawIndexedPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndexed");
			if (CommandDrawIndexedPointer != IntPtr.Zero)
			{
				CommandDrawIndexed_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedDelegate_0>(CommandDrawIndexedPointer);
			}
			CommandDrawMultiEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawMultiEXT");
			if (CommandDrawMultiEXTPointer != IntPtr.Zero)
			{
				CommandDrawMultiEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiEXTDelegate_0>(CommandDrawMultiEXTPointer);
				CommandDrawMultiEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiEXTDelegate_1>(CommandDrawMultiEXTPointer);
			}
			CommandDrawMultiIndexedEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawMultiIndexedEXT");
			if (CommandDrawMultiIndexedEXTPointer != IntPtr.Zero)
			{
				CommandDrawMultiIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_0>(CommandDrawMultiIndexedEXTPointer);
				CommandDrawMultiIndexedEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_1>(CommandDrawMultiIndexedEXTPointer);
				CommandDrawMultiIndexedEXT_2 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_2>(CommandDrawMultiIndexedEXTPointer);
				CommandDrawMultiIndexedEXT_3 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_3>(CommandDrawMultiIndexedEXTPointer);
			}
			CommandDrawIndirectPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndirect");
			if (CommandDrawIndirectPointer != IntPtr.Zero)
			{
				CommandDrawIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectDelegate_0>(CommandDrawIndirectPointer);
			}
			CommandDrawIndexedIndirectPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndexedIndirect");
			if (CommandDrawIndexedIndirectPointer != IntPtr.Zero)
			{
				CommandDrawIndexedIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectDelegate_0>(CommandDrawIndexedIndirectPointer);
			}
			CommandDispatchPointer = GetInstancePrecedureAddress(instance, "vkCmdDispatch");
			if (CommandDispatchPointer != IntPtr.Zero)
			{
				CommandDispatch_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchDelegate_0>(CommandDispatchPointer);
			}
			CommandDispatchIndirectPointer = GetInstancePrecedureAddress(instance, "vkCmdDispatchIndirect");
			if (CommandDispatchIndirectPointer != IntPtr.Zero)
			{
				CommandDispatchIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchIndirectDelegate_0>(CommandDispatchIndirectPointer);
			}
			CommandSubpassShadingHUAWEIPointer = GetInstancePrecedureAddress(instance, "vkCmdSubpassShadingHUAWEI");
			if (CommandSubpassShadingHUAWEIPointer != IntPtr.Zero)
			{
				CommandSubpassShadingHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<CommandSubpassShadingHUAWEIDelegate_0>(CommandSubpassShadingHUAWEIPointer);
			}
			CommandCopyBufferPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyBuffer");
			if (CommandCopyBufferPointer != IntPtr.Zero)
			{
				CommandCopyBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferDelegate_0>(CommandCopyBufferPointer);
			}
			CommandCopyImagePointer = GetInstancePrecedureAddress(instance, "vkCmdCopyImage");
			if (CommandCopyImagePointer != IntPtr.Zero)
			{
				CommandCopyImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageDelegate_0>(CommandCopyImagePointer);
			}
			CommandBlitImagePointer = GetInstancePrecedureAddress(instance, "vkCmdBlitImage");
			if (CommandBlitImagePointer != IntPtr.Zero)
			{
				CommandBlitImage_0 = Marshal.GetDelegateForFunctionPointer<CommandBlitImageDelegate_0>(CommandBlitImagePointer);
			}
			CommandCopyBufferToImagePointer = GetInstancePrecedureAddress(instance, "vkCmdCopyBufferToImage");
			if (CommandCopyBufferToImagePointer != IntPtr.Zero)
			{
				CommandCopyBufferToImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImageDelegate_0>(CommandCopyBufferToImagePointer);
			}
			CommandCopyImageToBufferPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyImageToBuffer");
			if (CommandCopyImageToBufferPointer != IntPtr.Zero)
			{
				CommandCopyImageToBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBufferDelegate_0>(CommandCopyImageToBufferPointer);
			}
			CommandUpdateBufferPointer = GetInstancePrecedureAddress(instance, "vkCmdUpdateBuffer");
			if (CommandUpdateBufferPointer != IntPtr.Zero)
			{
				CommandUpdateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandUpdateBufferDelegate_0>(CommandUpdateBufferPointer);
			}
			CommandFillBufferPointer = GetInstancePrecedureAddress(instance, "vkCmdFillBuffer");
			if (CommandFillBufferPointer != IntPtr.Zero)
			{
				CommandFillBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandFillBufferDelegate_0>(CommandFillBufferPointer);
			}
			CommandClearColorImagePointer = GetInstancePrecedureAddress(instance, "vkCmdClearColorImage");
			if (CommandClearColorImagePointer != IntPtr.Zero)
			{
				CommandClearColorImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_0>(CommandClearColorImagePointer);
				CommandClearColorImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_1>(CommandClearColorImagePointer);
			}
			CommandClearDepthStencilImagePointer = GetInstancePrecedureAddress(instance, "vkCmdClearDepthStencilImage");
			if (CommandClearDepthStencilImagePointer != IntPtr.Zero)
			{
				CommandClearDepthStencilImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_0>(CommandClearDepthStencilImagePointer);
				CommandClearDepthStencilImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_1>(CommandClearDepthStencilImagePointer);
			}
			CommandClearAttachmentsPointer = GetInstancePrecedureAddress(instance, "vkCmdClearAttachments");
			if (CommandClearAttachmentsPointer != IntPtr.Zero)
			{
				CommandClearAttachments_0 = Marshal.GetDelegateForFunctionPointer<CommandClearAttachmentsDelegate_0>(CommandClearAttachmentsPointer);
			}
			CommandResolveImagePointer = GetInstancePrecedureAddress(instance, "vkCmdResolveImage");
			if (CommandResolveImagePointer != IntPtr.Zero)
			{
				CommandResolveImage_0 = Marshal.GetDelegateForFunctionPointer<CommandResolveImageDelegate_0>(CommandResolveImagePointer);
			}
			CommandSetEventPointer = GetInstancePrecedureAddress(instance, "vkCmdSetEvent");
			if (CommandSetEventPointer != IntPtr.Zero)
			{
				CommandSetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandSetEventDelegate_0>(CommandSetEventPointer);
			}
			CommandResetEventPointer = GetInstancePrecedureAddress(instance, "vkCmdResetEvent");
			if (CommandResetEventPointer != IntPtr.Zero)
			{
				CommandResetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandResetEventDelegate_0>(CommandResetEventPointer);
			}
			CommandWaitEventsPointer = GetInstancePrecedureAddress(instance, "vkCmdWaitEvents");
			if (CommandWaitEventsPointer != IntPtr.Zero)
			{
				CommandWaitEvents_0 = Marshal.GetDelegateForFunctionPointer<CommandWaitEventsDelegate_0>(CommandWaitEventsPointer);
			}
			CommandPipelineBarrierPointer = GetInstancePrecedureAddress(instance, "vkCmdPipelineBarrier");
			if (CommandPipelineBarrierPointer != IntPtr.Zero)
			{
				CommandPipelineBarrier_0 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrierDelegate_0>(CommandPipelineBarrierPointer);
			}
			CommandBeginQueryPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginQuery");
			if (CommandBeginQueryPointer != IntPtr.Zero)
			{
				CommandBeginQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryDelegate_0>(CommandBeginQueryPointer);
			}
			CommandEndQueryPointer = GetInstancePrecedureAddress(instance, "vkCmdEndQuery");
			if (CommandEndQueryPointer != IntPtr.Zero)
			{
				CommandEndQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryDelegate_0>(CommandEndQueryPointer);
			}
			CommandBeginConditionalRenderingEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginConditionalRenderingEXT");
			if (CommandBeginConditionalRenderingEXTPointer != IntPtr.Zero)
			{
				CommandBeginConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginConditionalRenderingEXTDelegate_0>(CommandBeginConditionalRenderingEXTPointer);
				CommandBeginConditionalRenderingEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginConditionalRenderingEXTDelegate_1>(CommandBeginConditionalRenderingEXTPointer);
			}
			CommandEndConditionalRenderingEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdEndConditionalRenderingEXT");
			if (CommandEndConditionalRenderingEXTPointer != IntPtr.Zero)
			{
				CommandEndConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndConditionalRenderingEXTDelegate_0>(CommandEndConditionalRenderingEXTPointer);
			}
			CommandResetQueryPoolPointer = GetInstancePrecedureAddress(instance, "vkCmdResetQueryPool");
			if (CommandResetQueryPoolPointer != IntPtr.Zero)
			{
				CommandResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CommandResetQueryPoolDelegate_0>(CommandResetQueryPoolPointer);
			}
			CommandWriteTimestampPointer = GetInstancePrecedureAddress(instance, "vkCmdWriteTimestamp");
			if (CommandWriteTimestampPointer != IntPtr.Zero)
			{
				CommandWriteTimestamp_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteTimestampDelegate_0>(CommandWriteTimestampPointer);
			}
			CommandCopyQueryPoolResultsPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyQueryPoolResults");
			if (CommandCopyQueryPoolResultsPointer != IntPtr.Zero)
			{
				CommandCopyQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyQueryPoolResultsDelegate_0>(CommandCopyQueryPoolResultsPointer);
			}
			CommandPushConstantsPointer = GetInstancePrecedureAddress(instance, "vkCmdPushConstants");
			if (CommandPushConstantsPointer != IntPtr.Zero)
			{
				CommandPushConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandPushConstantsDelegate_0>(CommandPushConstantsPointer);
			}
			CommandBeginRenderPassPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginRenderPass");
			if (CommandBeginRenderPassPointer != IntPtr.Zero)
			{
				CommandBeginRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_0>(CommandBeginRenderPassPointer);
				CommandBeginRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_1>(CommandBeginRenderPassPointer);
			}
			CommandNextSubpassPointer = GetInstancePrecedureAddress(instance, "vkCmdNextSubpass");
			if (CommandNextSubpassPointer != IntPtr.Zero)
			{
				CommandNextSubpass_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpassDelegate_0>(CommandNextSubpassPointer);
			}
			CommandEndRenderPassPointer = GetInstancePrecedureAddress(instance, "vkCmdEndRenderPass");
			if (CommandEndRenderPassPointer != IntPtr.Zero)
			{
				CommandEndRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPassDelegate_0>(CommandEndRenderPassPointer);
			}
			CommandExecuteCommandsPointer = GetInstancePrecedureAddress(instance, "vkCmdExecuteCommands");
			if (CommandExecuteCommandsPointer != IntPtr.Zero)
			{
				CommandExecuteCommands_0 = Marshal.GetDelegateForFunctionPointer<CommandExecuteCommandsDelegate_0>(CommandExecuteCommandsPointer);
			}
			CreateAndroidSurfaceKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateAndroidSurfaceKHR");
			if (CreateAndroidSurfaceKHRPointer != IntPtr.Zero)
			{
				CreateAndroidSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_0>(CreateAndroidSurfaceKHRPointer);
				CreateAndroidSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_1>(CreateAndroidSurfaceKHRPointer);
				CreateAndroidSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_2>(CreateAndroidSurfaceKHRPointer);
				CreateAndroidSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_3>(CreateAndroidSurfaceKHRPointer);
			}
			GetPhysicalDeviceDisplayPropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
			if (GetPhysicalDeviceDisplayPropertiesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceDisplayPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPropertiesKHRPointer);
				GetPhysicalDeviceDisplayPropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_1>(GetPhysicalDeviceDisplayPropertiesKHRPointer);
			}
			GetPhysicalDeviceDisplayPlanePropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
			if (GetPhysicalDeviceDisplayPlanePropertiesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceDisplayPlanePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0>(GetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
				GetPhysicalDeviceDisplayPlanePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1>(GetPhysicalDeviceDisplayPlanePropertiesKHRPointer);
			}
			GetDisplayPlaneSupportedDisplaysKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
			if (GetDisplayPlaneSupportedDisplaysKHRPointer != IntPtr.Zero)
			{
				GetDisplayPlaneSupportedDisplaysKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_0>(GetDisplayPlaneSupportedDisplaysKHRPointer);
				GetDisplayPlaneSupportedDisplaysKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_1>(GetDisplayPlaneSupportedDisplaysKHRPointer);
			}
			GetDisplayModePropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDisplayModePropertiesKHR");
			if (GetDisplayModePropertiesKHRPointer != IntPtr.Zero)
			{
				GetDisplayModePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_0>(GetDisplayModePropertiesKHRPointer);
				GetDisplayModePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_1>(GetDisplayModePropertiesKHRPointer);
			}
			CreateDisplayModeKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateDisplayModeKHR");
			if (CreateDisplayModeKHRPointer != IntPtr.Zero)
			{
				CreateDisplayModeKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_0>(CreateDisplayModeKHRPointer);
				CreateDisplayModeKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_1>(CreateDisplayModeKHRPointer);
				CreateDisplayModeKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_2>(CreateDisplayModeKHRPointer);
				CreateDisplayModeKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_3>(CreateDisplayModeKHRPointer);
			}
			GetDisplayPlaneCapabilitiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDisplayPlaneCapabilitiesKHR");
			if (GetDisplayPlaneCapabilitiesKHRPointer != IntPtr.Zero)
			{
				GetDisplayPlaneCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilitiesKHRDelegate_0>(GetDisplayPlaneCapabilitiesKHRPointer);
			}
			CreateDisplayPlaneSurfaceKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateDisplayPlaneSurfaceKHR");
			if (CreateDisplayPlaneSurfaceKHRPointer != IntPtr.Zero)
			{
				CreateDisplayPlaneSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_0>(CreateDisplayPlaneSurfaceKHRPointer);
				CreateDisplayPlaneSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_1>(CreateDisplayPlaneSurfaceKHRPointer);
				CreateDisplayPlaneSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_2>(CreateDisplayPlaneSurfaceKHRPointer);
				CreateDisplayPlaneSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_3>(CreateDisplayPlaneSurfaceKHRPointer);
			}
			CreateSharedSwapchainsKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateSharedSwapchainsKHR");
			if (CreateSharedSwapchainsKHRPointer != IntPtr.Zero)
			{
				CreateSharedSwapchainsKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_0>(CreateSharedSwapchainsKHRPointer);
				CreateSharedSwapchainsKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_1>(CreateSharedSwapchainsKHRPointer);
			}
			DestroySurfaceKHRPointer = GetInstancePrecedureAddress(instance, "vkDestroySurfaceKHR");
			if (DestroySurfaceKHRPointer != IntPtr.Zero)
			{
				DestroySurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_0>(DestroySurfaceKHRPointer);
				DestroySurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_1>(DestroySurfaceKHRPointer);
			}
			GetPhysicalDeviceSurfaceSupportKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
			if (GetPhysicalDeviceSurfaceSupportKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceSupportKHRDelegate_0>(GetPhysicalDeviceSurfaceSupportKHRPointer);
			}
			GetPhysicalDeviceSurfaceCapabilitiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
			if (GetPhysicalDeviceSurfaceCapabilitiesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0>(GetPhysicalDeviceSurfaceCapabilitiesKHRPointer);
			}
			GetPhysicalDeviceSurfaceFormatsKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
			if (GetPhysicalDeviceSurfaceFormatsKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceFormatsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_0>(GetPhysicalDeviceSurfaceFormatsKHRPointer);
				GetPhysicalDeviceSurfaceFormatsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_1>(GetPhysicalDeviceSurfaceFormatsKHRPointer);
			}
			GetPhysicalDeviceSurfacePresentModesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
			if (GetPhysicalDeviceSurfacePresentModesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_0>(GetPhysicalDeviceSurfacePresentModesKHRPointer);
				GetPhysicalDeviceSurfacePresentModesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_1>(GetPhysicalDeviceSurfacePresentModesKHRPointer);
			}
			CreateSwapchainKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateSwapchainKHR");
			if (CreateSwapchainKHRPointer != IntPtr.Zero)
			{
				CreateSwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_0>(CreateSwapchainKHRPointer);
				CreateSwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_1>(CreateSwapchainKHRPointer);
				CreateSwapchainKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_2>(CreateSwapchainKHRPointer);
				CreateSwapchainKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_3>(CreateSwapchainKHRPointer);
			}
			DestroySwapchainKHRPointer = GetInstancePrecedureAddress(instance, "vkDestroySwapchainKHR");
			if (DestroySwapchainKHRPointer != IntPtr.Zero)
			{
				DestroySwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_0>(DestroySwapchainKHRPointer);
				DestroySwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_1>(DestroySwapchainKHRPointer);
			}
			GetSwapchainImagesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetSwapchainImagesKHR");
			if (GetSwapchainImagesKHRPointer != IntPtr.Zero)
			{
				GetSwapchainImagesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_0>(GetSwapchainImagesKHRPointer);
				GetSwapchainImagesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_1>(GetSwapchainImagesKHRPointer);
			}
			AcquireNextImageKHRPointer = GetInstancePrecedureAddress(instance, "vkAcquireNextImageKHR");
			if (AcquireNextImageKHRPointer != IntPtr.Zero)
			{
				AcquireNextImageKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImageKHRDelegate_0>(AcquireNextImageKHRPointer);
			}
			QueuePresentKHRPointer = GetInstancePrecedureAddress(instance, "vkQueuePresentKHR");
			if (QueuePresentKHRPointer != IntPtr.Zero)
			{
				QueuePresentKHR_0 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_0>(QueuePresentKHRPointer);
				QueuePresentKHR_1 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_1>(QueuePresentKHRPointer);
			}
			CreateWin32SurfaceKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateWin32SurfaceKHR");
			if (CreateWin32SurfaceKHRPointer != IntPtr.Zero)
			{
				CreateWin32SurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_0>(CreateWin32SurfaceKHRPointer);
				CreateWin32SurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_1>(CreateWin32SurfaceKHRPointer);
				CreateWin32SurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_2>(CreateWin32SurfaceKHRPointer);
				CreateWin32SurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_3>(CreateWin32SurfaceKHRPointer);
			}
			GetPhysicalDeviceWin32PresentationSupportKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
			if (GetPhysicalDeviceWin32PresentationSupportKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceWin32PresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0>(GetPhysicalDeviceWin32PresentationSupportKHRPointer);
			}
			CreateXlibSurfaceKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateXlibSurfaceKHR");
			if (CreateXlibSurfaceKHRPointer != IntPtr.Zero)
			{
				CreateXlibSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_0>(CreateXlibSurfaceKHRPointer);
				CreateXlibSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_1>(CreateXlibSurfaceKHRPointer);
				CreateXlibSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_2>(CreateXlibSurfaceKHRPointer);
				CreateXlibSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_3>(CreateXlibSurfaceKHRPointer);
			}
			GetPhysicalDeviceXlibPresentationSupportKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR");
			if (GetPhysicalDeviceXlibPresentationSupportKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceXlibPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0>(GetPhysicalDeviceXlibPresentationSupportKHRPointer);
				GetPhysicalDeviceXlibPresentationSupportKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXlibPresentationSupportKHRDelegate_1>(GetPhysicalDeviceXlibPresentationSupportKHRPointer);
			}
			CreateDebugReportCallbackEXTPointer = GetInstancePrecedureAddress(instance, "vkCreateDebugReportCallbackEXT");
			if (CreateDebugReportCallbackEXTPointer != IntPtr.Zero)
			{
				CreateDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_0>(CreateDebugReportCallbackEXTPointer);
				CreateDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_1>(CreateDebugReportCallbackEXTPointer);
				CreateDebugReportCallbackEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_2>(CreateDebugReportCallbackEXTPointer);
				CreateDebugReportCallbackEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_3>(CreateDebugReportCallbackEXTPointer);
			}
			DestroyDebugReportCallbackEXTPointer = GetInstancePrecedureAddress(instance, "vkDestroyDebugReportCallbackEXT");
			if (DestroyDebugReportCallbackEXTPointer != IntPtr.Zero)
			{
				DestroyDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_0>(DestroyDebugReportCallbackEXTPointer);
				DestroyDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_1>(DestroyDebugReportCallbackEXTPointer);
			}
			DebugReportMessageEXTPointer = GetInstancePrecedureAddress(instance, "vkDebugReportMessageEXT");
			if (DebugReportMessageEXTPointer != IntPtr.Zero)
			{
				DebugReportMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_0>(DebugReportMessageEXTPointer);
				DebugReportMessageEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_1>(DebugReportMessageEXTPointer);
				DebugReportMessageEXT_2 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_2>(DebugReportMessageEXTPointer);
				DebugReportMessageEXT_3 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_3>(DebugReportMessageEXTPointer);
			}
			DebugMarkerSetObjectNameEXTPointer = GetInstancePrecedureAddress(instance, "vkDebugMarkerSetObjectNameEXT");
			if (DebugMarkerSetObjectNameEXTPointer != IntPtr.Zero)
			{
				DebugMarkerSetObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_0>(DebugMarkerSetObjectNameEXTPointer);
				DebugMarkerSetObjectNameEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_1>(DebugMarkerSetObjectNameEXTPointer);
			}
			DebugMarkerSetObjectTagEXTPointer = GetInstancePrecedureAddress(instance, "vkDebugMarkerSetObjectTagEXT");
			if (DebugMarkerSetObjectTagEXTPointer != IntPtr.Zero)
			{
				DebugMarkerSetObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_0>(DebugMarkerSetObjectTagEXTPointer);
				DebugMarkerSetObjectTagEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_1>(DebugMarkerSetObjectTagEXTPointer);
			}
			CommandDebugMarkerBeginEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDebugMarkerBeginEXT");
			if (CommandDebugMarkerBeginEXTPointer != IntPtr.Zero)
			{
				CommandDebugMarkerBeginEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_0>(CommandDebugMarkerBeginEXTPointer);
				CommandDebugMarkerBeginEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_1>(CommandDebugMarkerBeginEXTPointer);
			}
			CommandDebugMarkerEndEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDebugMarkerEndEXT");
			if (CommandDebugMarkerEndEXTPointer != IntPtr.Zero)
			{
				CommandDebugMarkerEndEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerEndEXTDelegate_0>(CommandDebugMarkerEndEXTPointer);
			}
			CommandDebugMarkerInsertEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDebugMarkerInsertEXT");
			if (CommandDebugMarkerInsertEXTPointer != IntPtr.Zero)
			{
				CommandDebugMarkerInsertEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_0>(CommandDebugMarkerInsertEXTPointer);
				CommandDebugMarkerInsertEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_1>(CommandDebugMarkerInsertEXTPointer);
			}
			GetPhysicalDeviceExternalImageFormatPropertiesNVPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
			if (GetPhysicalDeviceExternalImageFormatPropertiesNVPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceExternalImageFormatPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0>(GetPhysicalDeviceExternalImageFormatPropertiesNVPointer);
			}
			GetMemoryWin32HandleNVPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryWin32HandleNV");
			if (GetMemoryWin32HandleNVPointer != IntPtr.Zero)
			{
				GetMemoryWin32HandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleNVDelegate_0>(GetMemoryWin32HandleNVPointer);
			}
			CommandExecuteGeneratedCommandsNVPointer = GetInstancePrecedureAddress(instance, "vkCmdExecuteGeneratedCommandsNV");
			if (CommandExecuteGeneratedCommandsNVPointer != IntPtr.Zero)
			{
				CommandExecuteGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<CommandExecuteGeneratedCommandsNVDelegate_0>(CommandExecuteGeneratedCommandsNVPointer);
				CommandExecuteGeneratedCommandsNV_1 = Marshal.GetDelegateForFunctionPointer<CommandExecuteGeneratedCommandsNVDelegate_1>(CommandExecuteGeneratedCommandsNVPointer);
			}
			CommandPreprocessGeneratedCommandsNVPointer = GetInstancePrecedureAddress(instance, "vkCmdPreprocessGeneratedCommandsNV");
			if (CommandPreprocessGeneratedCommandsNVPointer != IntPtr.Zero)
			{
				CommandPreprocessGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<CommandPreprocessGeneratedCommandsNVDelegate_0>(CommandPreprocessGeneratedCommandsNVPointer);
				CommandPreprocessGeneratedCommandsNV_1 = Marshal.GetDelegateForFunctionPointer<CommandPreprocessGeneratedCommandsNVDelegate_1>(CommandPreprocessGeneratedCommandsNVPointer);
			}
			CommandBindPipelineShaderGroupNVPointer = GetInstancePrecedureAddress(instance, "vkCmdBindPipelineShaderGroupNV");
			if (CommandBindPipelineShaderGroupNVPointer != IntPtr.Zero)
			{
				CommandBindPipelineShaderGroupNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBindPipelineShaderGroupNVDelegate_0>(CommandBindPipelineShaderGroupNVPointer);
			}
			GetGeneratedCommandsMemoryRequirementsNVPointer = GetInstancePrecedureAddress(instance, "vkGetGeneratedCommandsMemoryRequirementsNV");
			if (GetGeneratedCommandsMemoryRequirementsNVPointer != IntPtr.Zero)
			{
				GetGeneratedCommandsMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<GetGeneratedCommandsMemoryRequirementsNVDelegate_0>(GetGeneratedCommandsMemoryRequirementsNVPointer);
				GetGeneratedCommandsMemoryRequirementsNV_1 = Marshal.GetDelegateForFunctionPointer<GetGeneratedCommandsMemoryRequirementsNVDelegate_1>(GetGeneratedCommandsMemoryRequirementsNVPointer);
			}
			CreateIndirectCommandsLayoutNVPointer = GetInstancePrecedureAddress(instance, "vkCreateIndirectCommandsLayoutNV");
			if (CreateIndirectCommandsLayoutNVPointer != IntPtr.Zero)
			{
				CreateIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_0>(CreateIndirectCommandsLayoutNVPointer);
				CreateIndirectCommandsLayoutNV_1 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_1>(CreateIndirectCommandsLayoutNVPointer);
				CreateIndirectCommandsLayoutNV_2 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_2>(CreateIndirectCommandsLayoutNVPointer);
				CreateIndirectCommandsLayoutNV_3 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_3>(CreateIndirectCommandsLayoutNVPointer);
			}
			DestroyIndirectCommandsLayoutNVPointer = GetInstancePrecedureAddress(instance, "vkDestroyIndirectCommandsLayoutNV");
			if (DestroyIndirectCommandsLayoutNVPointer != IntPtr.Zero)
			{
				DestroyIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVDelegate_0>(DestroyIndirectCommandsLayoutNVPointer);
				DestroyIndirectCommandsLayoutNV_1 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVDelegate_1>(DestroyIndirectCommandsLayoutNVPointer);
			}
			GetPhysicalDeviceFeatures2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceFeatures2");
			if (GetPhysicalDeviceFeatures2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceFeatures2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2Delegate_0>(GetPhysicalDeviceFeatures2Pointer);
			}
			GetPhysicalDeviceProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceProperties2");
			if (GetPhysicalDeviceProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2Delegate_0>(GetPhysicalDeviceProperties2Pointer);
			}
			GetPhysicalDeviceFormatProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceFormatProperties2");
			if (GetPhysicalDeviceFormatProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2Delegate_0>(GetPhysicalDeviceFormatProperties2Pointer);
			}
			GetPhysicalDeviceImageFormatProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceImageFormatProperties2");
			if (GetPhysicalDeviceImageFormatProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2Delegate_0>(GetPhysicalDeviceImageFormatProperties2Pointer);
				GetPhysicalDeviceImageFormatProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2Delegate_1>(GetPhysicalDeviceImageFormatProperties2Pointer);
			}
			GetPhysicalDeviceQueueFamilyProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
			if (GetPhysicalDeviceQueueFamilyProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceQueueFamilyProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2Delegate_0>(GetPhysicalDeviceQueueFamilyProperties2Pointer);
				GetPhysicalDeviceQueueFamilyProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2Delegate_1>(GetPhysicalDeviceQueueFamilyProperties2Pointer);
			}
			GetPhysicalDeviceMemoryProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceMemoryProperties2");
			if (GetPhysicalDeviceMemoryProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceMemoryProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2Delegate_0>(GetPhysicalDeviceMemoryProperties2Pointer);
			}
			GetPhysicalDeviceSparseImageFormatProperties2Pointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
			if (GetPhysicalDeviceSparseImageFormatProperties2Pointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSparseImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_0>(GetPhysicalDeviceSparseImageFormatProperties2Pointer);
				GetPhysicalDeviceSparseImageFormatProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_1>(GetPhysicalDeviceSparseImageFormatProperties2Pointer);
				GetPhysicalDeviceSparseImageFormatProperties2_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_2>(GetPhysicalDeviceSparseImageFormatProperties2Pointer);
				GetPhysicalDeviceSparseImageFormatProperties2_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_3>(GetPhysicalDeviceSparseImageFormatProperties2Pointer);
			}
			CommandPushDescriptorSetKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdPushDescriptorSetKHR");
			if (CommandPushDescriptorSetKHRPointer != IntPtr.Zero)
			{
				CommandPushDescriptorSetKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetKHRDelegate_0>(CommandPushDescriptorSetKHRPointer);
			}
			TrimCommandPoolPointer = GetInstancePrecedureAddress(instance, "vkTrimCommandPool");
			if (TrimCommandPoolPointer != IntPtr.Zero)
			{
				TrimCommandPool_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolDelegate_0>(TrimCommandPoolPointer);
			}
			GetPhysicalDeviceExternalBufferPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceExternalBufferProperties");
			if (GetPhysicalDeviceExternalBufferPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceExternalBufferProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesDelegate_0>(GetPhysicalDeviceExternalBufferPropertiesPointer);
				GetPhysicalDeviceExternalBufferProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesDelegate_1>(GetPhysicalDeviceExternalBufferPropertiesPointer);
			}
			GetMemoryWin32HandleKHRPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryWin32HandleKHR");
			if (GetMemoryWin32HandleKHRPointer != IntPtr.Zero)
			{
				GetMemoryWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_0>(GetMemoryWin32HandleKHRPointer);
				GetMemoryWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_1>(GetMemoryWin32HandleKHRPointer);
			}
			GetMemoryWin32HandlePropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryWin32HandlePropertiesKHR");
			if (GetMemoryWin32HandlePropertiesKHRPointer != IntPtr.Zero)
			{
				GetMemoryWin32HandlePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandlePropertiesKHRDelegate_0>(GetMemoryWin32HandlePropertiesKHRPointer);
			}
			GetMemoryFileDescriptorKHRPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryFdKHR");
			if (GetMemoryFileDescriptorKHRPointer != IntPtr.Zero)
			{
				GetMemoryFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_0>(GetMemoryFileDescriptorKHRPointer);
				GetMemoryFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_1>(GetMemoryFileDescriptorKHRPointer);
			}
			GetMemoryFileDescriptorPropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryFdPropertiesKHR");
			if (GetMemoryFileDescriptorPropertiesKHRPointer != IntPtr.Zero)
			{
				GetMemoryFileDescriptorPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorPropertiesKHRDelegate_0>(GetMemoryFileDescriptorPropertiesKHRPointer);
			}
			GetMemoryRemoteAddressNVPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryRemoteAddressNV");
			if (GetMemoryRemoteAddressNVPointer != IntPtr.Zero)
			{
				GetMemoryRemoteAddressNV_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryRemoteAddressNVDelegate_0>(GetMemoryRemoteAddressNVPointer);
				GetMemoryRemoteAddressNV_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryRemoteAddressNVDelegate_1>(GetMemoryRemoteAddressNVPointer);
			}
			GetPhysicalDeviceExternalSemaphorePropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
			if (GetPhysicalDeviceExternalSemaphorePropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceExternalSemaphoreProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0>(GetPhysicalDeviceExternalSemaphorePropertiesPointer);
				GetPhysicalDeviceExternalSemaphoreProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1>(GetPhysicalDeviceExternalSemaphorePropertiesPointer);
			}
			GetSemaphoreWin32HandleKHRPointer = GetInstancePrecedureAddress(instance, "vkGetSemaphoreWin32HandleKHR");
			if (GetSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
			{
				GetSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_0>(GetSemaphoreWin32HandleKHRPointer);
				GetSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_1>(GetSemaphoreWin32HandleKHRPointer);
			}
			ImportSemaphoreWin32HandleKHRPointer = GetInstancePrecedureAddress(instance, "vkImportSemaphoreWin32HandleKHR");
			if (ImportSemaphoreWin32HandleKHRPointer != IntPtr.Zero)
			{
				ImportSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_0>(ImportSemaphoreWin32HandleKHRPointer);
				ImportSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_1>(ImportSemaphoreWin32HandleKHRPointer);
			}
			GetSemaphoreFileDescriptorKHRPointer = GetInstancePrecedureAddress(instance, "vkGetSemaphoreFdKHR");
			if (GetSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
			{
				GetSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_0>(GetSemaphoreFileDescriptorKHRPointer);
				GetSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_1>(GetSemaphoreFileDescriptorKHRPointer);
			}
			ImportSemaphoreFileDescriptorKHRPointer = GetInstancePrecedureAddress(instance, "vkImportSemaphoreFdKHR");
			if (ImportSemaphoreFileDescriptorKHRPointer != IntPtr.Zero)
			{
				ImportSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_0>(ImportSemaphoreFileDescriptorKHRPointer);
				ImportSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_1>(ImportSemaphoreFileDescriptorKHRPointer);
			}
			GetPhysicalDeviceExternalFencePropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceExternalFenceProperties");
			if (GetPhysicalDeviceExternalFencePropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceExternalFenceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesDelegate_0>(GetPhysicalDeviceExternalFencePropertiesPointer);
				GetPhysicalDeviceExternalFenceProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesDelegate_1>(GetPhysicalDeviceExternalFencePropertiesPointer);
			}
			GetFenceWin32HandleKHRPointer = GetInstancePrecedureAddress(instance, "vkGetFenceWin32HandleKHR");
			if (GetFenceWin32HandleKHRPointer != IntPtr.Zero)
			{
				GetFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_0>(GetFenceWin32HandleKHRPointer);
				GetFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_1>(GetFenceWin32HandleKHRPointer);
			}
			ImportFenceWin32HandleKHRPointer = GetInstancePrecedureAddress(instance, "vkImportFenceWin32HandleKHR");
			if (ImportFenceWin32HandleKHRPointer != IntPtr.Zero)
			{
				ImportFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_0>(ImportFenceWin32HandleKHRPointer);
				ImportFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_1>(ImportFenceWin32HandleKHRPointer);
			}
			GetFenceFileDescriptorKHRPointer = GetInstancePrecedureAddress(instance, "vkGetFenceFdKHR");
			if (GetFenceFileDescriptorKHRPointer != IntPtr.Zero)
			{
				GetFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_0>(GetFenceFileDescriptorKHRPointer);
				GetFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_1>(GetFenceFileDescriptorKHRPointer);
			}
			ImportFenceFileDescriptorKHRPointer = GetInstancePrecedureAddress(instance, "vkImportFenceFdKHR");
			if (ImportFenceFileDescriptorKHRPointer != IntPtr.Zero)
			{
				ImportFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_0>(ImportFenceFileDescriptorKHRPointer);
				ImportFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_1>(ImportFenceFileDescriptorKHRPointer);
			}
			ReleaseDisplayEXTPointer = GetInstancePrecedureAddress(instance, "vkReleaseDisplayEXT");
			if (ReleaseDisplayEXTPointer != IntPtr.Zero)
			{
				ReleaseDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseDisplayEXTDelegate_0>(ReleaseDisplayEXTPointer);
			}
			AcquireWinrtDisplayNVPointer = GetInstancePrecedureAddress(instance, "vkAcquireWinrtDisplayNV");
			if (AcquireWinrtDisplayNVPointer != IntPtr.Zero)
			{
				AcquireWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<AcquireWinrtDisplayNVDelegate_0>(AcquireWinrtDisplayNVPointer);
			}
			GetWinrtDisplayNVPointer = GetInstancePrecedureAddress(instance, "vkGetWinrtDisplayNV");
			if (GetWinrtDisplayNVPointer != IntPtr.Zero)
			{
				GetWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<GetWinrtDisplayNVDelegate_0>(GetWinrtDisplayNVPointer);
			}
			DisplayPowerControlEXTPointer = GetInstancePrecedureAddress(instance, "vkDisplayPowerControlEXT");
			if (DisplayPowerControlEXTPointer != IntPtr.Zero)
			{
				DisplayPowerControlEXT_0 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_0>(DisplayPowerControlEXTPointer);
				DisplayPowerControlEXT_1 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_1>(DisplayPowerControlEXTPointer);
			}
			RegisterDeviceEventEXTPointer = GetInstancePrecedureAddress(instance, "vkRegisterDeviceEventEXT");
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
			RegisterDisplayEventEXTPointer = GetInstancePrecedureAddress(instance, "vkRegisterDisplayEventEXT");
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
			GetSwapchainCounterEXTPointer = GetInstancePrecedureAddress(instance, "vkGetSwapchainCounterEXT");
			if (GetSwapchainCounterEXTPointer != IntPtr.Zero)
			{
				GetSwapchainCounterEXT_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainCounterEXTDelegate_0>(GetSwapchainCounterEXTPointer);
			}
			GetPhysicalDeviceSurfaceCapabilities2EXTPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
			if (GetPhysicalDeviceSurfaceCapabilities2EXTPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceCapabilities2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0>(GetPhysicalDeviceSurfaceCapabilities2EXTPointer);
			}
			EnumeratePhysicalDeviceGroupsPointer = GetInstancePrecedureAddress(instance, "vkEnumeratePhysicalDeviceGroups");
			if (EnumeratePhysicalDeviceGroupsPointer != IntPtr.Zero)
			{
				EnumeratePhysicalDeviceGroups_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsDelegate_0>(EnumeratePhysicalDeviceGroupsPointer);
				EnumeratePhysicalDeviceGroups_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsDelegate_1>(EnumeratePhysicalDeviceGroupsPointer);
			}
			GetDeviceGroupPeerMemoryFeaturesPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceGroupPeerMemoryFeatures");
			if (GetDeviceGroupPeerMemoryFeaturesPointer != IntPtr.Zero)
			{
				GetDeviceGroupPeerMemoryFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesDelegate_0>(GetDeviceGroupPeerMemoryFeaturesPointer);
			}
			BindBufferMemory2Pointer = GetInstancePrecedureAddress(instance, "vkBindBufferMemory2");
			if (BindBufferMemory2Pointer != IntPtr.Zero)
			{
				BindBufferMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2Delegate_0>(BindBufferMemory2Pointer);
			}
			BindImageMemory2Pointer = GetInstancePrecedureAddress(instance, "vkBindImageMemory2");
			if (BindImageMemory2Pointer != IntPtr.Zero)
			{
				BindImageMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2Delegate_0>(BindImageMemory2Pointer);
			}
			CommandSetDeviceMaskPointer = GetInstancePrecedureAddress(instance, "vkCmdSetDeviceMask");
			if (CommandSetDeviceMaskPointer != IntPtr.Zero)
			{
				CommandSetDeviceMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskDelegate_0>(CommandSetDeviceMaskPointer);
			}
			GetDeviceGroupPresentCapabilitiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceGroupPresentCapabilitiesKHR");
			if (GetDeviceGroupPresentCapabilitiesKHRPointer != IntPtr.Zero)
			{
				GetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPresentCapabilitiesKHRDelegate_0>(GetDeviceGroupPresentCapabilitiesKHRPointer);
			}
			GetDeviceGroupSurfacePresentModesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceGroupSurfacePresentModesKHR");
			if (GetDeviceGroupSurfacePresentModesKHRPointer != IntPtr.Zero)
			{
				GetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModesKHRDelegate_0>(GetDeviceGroupSurfacePresentModesKHRPointer);
			}
			AcquireNextImage2KHRPointer = GetInstancePrecedureAddress(instance, "vkAcquireNextImage2KHR");
			if (AcquireNextImage2KHRPointer != IntPtr.Zero)
			{
				AcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_0>(AcquireNextImage2KHRPointer);
				AcquireNextImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_1>(AcquireNextImage2KHRPointer);
			}
			CommandDispatchBasePointer = GetInstancePrecedureAddress(instance, "vkCmdDispatchBase");
			if (CommandDispatchBasePointer != IntPtr.Zero)
			{
				CommandDispatchBase_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseDelegate_0>(CommandDispatchBasePointer);
			}
			GetPhysicalDevicePresentRectanglesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDevicePresentRectanglesKHR");
			if (GetPhysicalDevicePresentRectanglesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_0>(GetPhysicalDevicePresentRectanglesKHRPointer);
				GetPhysicalDevicePresentRectanglesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_1>(GetPhysicalDevicePresentRectanglesKHRPointer);
			}
			CreateDescriptorUpdateTemplatePointer = GetInstancePrecedureAddress(instance, "vkCreateDescriptorUpdateTemplate");
			if (CreateDescriptorUpdateTemplatePointer != IntPtr.Zero)
			{
				CreateDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_0>(CreateDescriptorUpdateTemplatePointer);
				CreateDescriptorUpdateTemplate_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_1>(CreateDescriptorUpdateTemplatePointer);
				CreateDescriptorUpdateTemplate_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_2>(CreateDescriptorUpdateTemplatePointer);
				CreateDescriptorUpdateTemplate_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_3>(CreateDescriptorUpdateTemplatePointer);
			}
			DestroyDescriptorUpdateTemplatePointer = GetInstancePrecedureAddress(instance, "vkDestroyDescriptorUpdateTemplate");
			if (DestroyDescriptorUpdateTemplatePointer != IntPtr.Zero)
			{
				DestroyDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateDelegate_0>(DestroyDescriptorUpdateTemplatePointer);
				DestroyDescriptorUpdateTemplate_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateDelegate_1>(DestroyDescriptorUpdateTemplatePointer);
			}
			UpdateDescriptorSetWithTemplatePointer = GetInstancePrecedureAddress(instance, "vkUpdateDescriptorSetWithTemplate");
			if (UpdateDescriptorSetWithTemplatePointer != IntPtr.Zero)
			{
				UpdateDescriptorSetWithTemplate_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetWithTemplateDelegate_0>(UpdateDescriptorSetWithTemplatePointer);
			}
			CommandPushDescriptorSetWithTemplateKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdPushDescriptorSetWithTemplateKHR");
			if (CommandPushDescriptorSetWithTemplateKHRPointer != IntPtr.Zero)
			{
				CommandPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetWithTemplateKHRDelegate_0>(CommandPushDescriptorSetWithTemplateKHRPointer);
			}
			SetHdrMetadataEXTPointer = GetInstancePrecedureAddress(instance, "vkSetHdrMetadataEXT");
			if (SetHdrMetadataEXTPointer != IntPtr.Zero)
			{
				SetHdrMetadataEXT_0 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_0>(SetHdrMetadataEXTPointer);
				SetHdrMetadataEXT_1 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_1>(SetHdrMetadataEXTPointer);
			}
			GetSwapchainStatusKHRPointer = GetInstancePrecedureAddress(instance, "vkGetSwapchainStatusKHR");
			if (GetSwapchainStatusKHRPointer != IntPtr.Zero)
			{
				GetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainStatusKHRDelegate_0>(GetSwapchainStatusKHRPointer);
			}
			GetRefreshCycleDurationGOOGLEPointer = GetInstancePrecedureAddress(instance, "vkGetRefreshCycleDurationGOOGLE");
			if (GetRefreshCycleDurationGOOGLEPointer != IntPtr.Zero)
			{
				GetRefreshCycleDurationGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetRefreshCycleDurationGOOGLEDelegate_0>(GetRefreshCycleDurationGOOGLEPointer);
			}
			GetPastPresentationTimingGOOGLEPointer = GetInstancePrecedureAddress(instance, "vkGetPastPresentationTimingGOOGLE");
			if (GetPastPresentationTimingGOOGLEPointer != IntPtr.Zero)
			{
				GetPastPresentationTimingGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_0>(GetPastPresentationTimingGOOGLEPointer);
				GetPastPresentationTimingGOOGLE_1 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_1>(GetPastPresentationTimingGOOGLEPointer);
			}
			CreateMacOSSurfaceMVKPointer = GetInstancePrecedureAddress(instance, "vkCreateMacOSSurfaceMVK");
			if (CreateMacOSSurfaceMVKPointer != IntPtr.Zero)
			{
				CreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_0>(CreateMacOSSurfaceMVKPointer);
				CreateMacOSSurfaceMVK_1 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_1>(CreateMacOSSurfaceMVKPointer);
				CreateMacOSSurfaceMVK_2 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_2>(CreateMacOSSurfaceMVKPointer);
				CreateMacOSSurfaceMVK_3 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_3>(CreateMacOSSurfaceMVKPointer);
			}
			CommandSetViewportWScalingNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetViewportWScalingNV");
			if (CommandSetViewportWScalingNVPointer != IntPtr.Zero)
			{
				CommandSetViewportWScalingNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_0>(CommandSetViewportWScalingNVPointer);
				CommandSetViewportWScalingNV_1 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_1>(CommandSetViewportWScalingNVPointer);
			}
			CommandSetDiscardRectangleEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetDiscardRectangleEXT");
			if (CommandSetDiscardRectangleEXTPointer != IntPtr.Zero)
			{
				CommandSetDiscardRectangleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDiscardRectangleEXTDelegate_0>(CommandSetDiscardRectangleEXTPointer);
			}
			CommandSetSampleLocationsEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetSampleLocationsEXT");
			if (CommandSetSampleLocationsEXTPointer != IntPtr.Zero)
			{
				CommandSetSampleLocationsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_0>(CommandSetSampleLocationsEXTPointer);
				CommandSetSampleLocationsEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_1>(CommandSetSampleLocationsEXTPointer);
			}
			GetPhysicalDeviceMultisamplePropertiesEXTPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
			if (GetPhysicalDeviceMultisamplePropertiesEXTPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceMultisamplePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0>(GetPhysicalDeviceMultisamplePropertiesEXTPointer);
			}
			GetPhysicalDeviceSurfaceCapabilities2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
			if (GetPhysicalDeviceSurfaceCapabilities2KHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0>(GetPhysicalDeviceSurfaceCapabilities2KHRPointer);
				GetPhysicalDeviceSurfaceCapabilities2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1>(GetPhysicalDeviceSurfaceCapabilities2KHRPointer);
			}
			GetPhysicalDeviceSurfaceFormats2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR");
			if (GetPhysicalDeviceSurfaceFormats2KHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfaceFormats2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_0>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
				GetPhysicalDeviceSurfaceFormats2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_1>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
				GetPhysicalDeviceSurfaceFormats2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_2>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
				GetPhysicalDeviceSurfaceFormats2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_3>(GetPhysicalDeviceSurfaceFormats2KHRPointer);
			}
			GetPhysicalDeviceDisplayProperties2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
			if (GetPhysicalDeviceDisplayProperties2KHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceDisplayProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayProperties2KHRDelegate_0>(GetPhysicalDeviceDisplayProperties2KHRPointer);
				GetPhysicalDeviceDisplayProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayProperties2KHRDelegate_1>(GetPhysicalDeviceDisplayProperties2KHRPointer);
			}
			GetPhysicalDeviceDisplayPlaneProperties2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
			if (GetPhysicalDeviceDisplayPlaneProperties2KHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceDisplayPlaneProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0>(GetPhysicalDeviceDisplayPlaneProperties2KHRPointer);
				GetPhysicalDeviceDisplayPlaneProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1>(GetPhysicalDeviceDisplayPlaneProperties2KHRPointer);
			}
			GetDisplayModeProperties2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetDisplayModeProperties2KHR");
			if (GetDisplayModeProperties2KHRPointer != IntPtr.Zero)
			{
				GetDisplayModeProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModeProperties2KHRDelegate_0>(GetDisplayModeProperties2KHRPointer);
				GetDisplayModeProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayModeProperties2KHRDelegate_1>(GetDisplayModeProperties2KHRPointer);
			}
			GetDisplayPlaneCapabilities2KHRPointer = GetInstancePrecedureAddress(instance, "vkGetDisplayPlaneCapabilities2KHR");
			if (GetDisplayPlaneCapabilities2KHRPointer != IntPtr.Zero)
			{
				GetDisplayPlaneCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilities2KHRDelegate_0>(GetDisplayPlaneCapabilities2KHRPointer);
				GetDisplayPlaneCapabilities2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilities2KHRDelegate_1>(GetDisplayPlaneCapabilities2KHRPointer);
			}
			GetBufferMemoryRequirements2Pointer = GetInstancePrecedureAddress(instance, "vkGetBufferMemoryRequirements2");
			if (GetBufferMemoryRequirements2Pointer != IntPtr.Zero)
			{
				GetBufferMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2Delegate_0>(GetBufferMemoryRequirements2Pointer);
				GetBufferMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2Delegate_1>(GetBufferMemoryRequirements2Pointer);
			}
			GetImageMemoryRequirements2Pointer = GetInstancePrecedureAddress(instance, "vkGetImageMemoryRequirements2");
			if (GetImageMemoryRequirements2Pointer != IntPtr.Zero)
			{
				GetImageMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2Delegate_0>(GetImageMemoryRequirements2Pointer);
				GetImageMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2Delegate_1>(GetImageMemoryRequirements2Pointer);
			}
			GetImageSparseMemoryRequirements2Pointer = GetInstancePrecedureAddress(instance, "vkGetImageSparseMemoryRequirements2");
			if (GetImageSparseMemoryRequirements2Pointer != IntPtr.Zero)
			{
				GetImageSparseMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_0>(GetImageSparseMemoryRequirements2Pointer);
				GetImageSparseMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_1>(GetImageSparseMemoryRequirements2Pointer);
				GetImageSparseMemoryRequirements2_2 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_2>(GetImageSparseMemoryRequirements2Pointer);
				GetImageSparseMemoryRequirements2_3 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_3>(GetImageSparseMemoryRequirements2Pointer);
			}
			GetDeviceBufferMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceBufferMemoryRequirements");
			if (GetDeviceBufferMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetDeviceBufferMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceBufferMemoryRequirementsDelegate_0>(GetDeviceBufferMemoryRequirementsPointer);
				GetDeviceBufferMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceBufferMemoryRequirementsDelegate_1>(GetDeviceBufferMemoryRequirementsPointer);
			}
			GetDeviceImageMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceImageMemoryRequirements");
			if (GetDeviceImageMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetDeviceImageMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageMemoryRequirementsDelegate_0>(GetDeviceImageMemoryRequirementsPointer);
				GetDeviceImageMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageMemoryRequirementsDelegate_1>(GetDeviceImageMemoryRequirementsPointer);
			}
			GetDeviceImageSparseMemoryRequirementsPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceImageSparseMemoryRequirements");
			if (GetDeviceImageSparseMemoryRequirementsPointer != IntPtr.Zero)
			{
				GetDeviceImageSparseMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsDelegate_0>(GetDeviceImageSparseMemoryRequirementsPointer);
				GetDeviceImageSparseMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsDelegate_1>(GetDeviceImageSparseMemoryRequirementsPointer);
				GetDeviceImageSparseMemoryRequirements_2 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsDelegate_2>(GetDeviceImageSparseMemoryRequirementsPointer);
				GetDeviceImageSparseMemoryRequirements_3 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsDelegate_3>(GetDeviceImageSparseMemoryRequirementsPointer);
			}
			CreateSamplerYcbcrConversionPointer = GetInstancePrecedureAddress(instance, "vkCreateSamplerYcbcrConversion");
			if (CreateSamplerYcbcrConversionPointer != IntPtr.Zero)
			{
				CreateSamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_0>(CreateSamplerYcbcrConversionPointer);
				CreateSamplerYcbcrConversion_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_1>(CreateSamplerYcbcrConversionPointer);
				CreateSamplerYcbcrConversion_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_2>(CreateSamplerYcbcrConversionPointer);
				CreateSamplerYcbcrConversion_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_3>(CreateSamplerYcbcrConversionPointer);
			}
			DestroySamplerYcbcrConversionPointer = GetInstancePrecedureAddress(instance, "vkDestroySamplerYcbcrConversion");
			if (DestroySamplerYcbcrConversionPointer != IntPtr.Zero)
			{
				DestroySamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionDelegate_0>(DestroySamplerYcbcrConversionPointer);
				DestroySamplerYcbcrConversion_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionDelegate_1>(DestroySamplerYcbcrConversionPointer);
			}
			GetDeviceQueue2Pointer = GetInstancePrecedureAddress(instance, "vkGetDeviceQueue2");
			if (GetDeviceQueue2Pointer != IntPtr.Zero)
			{
				GetDeviceQueue2_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueue2Delegate_0>(GetDeviceQueue2Pointer);
				GetDeviceQueue2_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueue2Delegate_1>(GetDeviceQueue2Pointer);
			}
			CreateValidationCacheEXTPointer = GetInstancePrecedureAddress(instance, "vkCreateValidationCacheEXT");
			if (CreateValidationCacheEXTPointer != IntPtr.Zero)
			{
				CreateValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_0>(CreateValidationCacheEXTPointer);
				CreateValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_1>(CreateValidationCacheEXTPointer);
				CreateValidationCacheEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_2>(CreateValidationCacheEXTPointer);
				CreateValidationCacheEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_3>(CreateValidationCacheEXTPointer);
			}
			DestroyValidationCacheEXTPointer = GetInstancePrecedureAddress(instance, "vkDestroyValidationCacheEXT");
			if (DestroyValidationCacheEXTPointer != IntPtr.Zero)
			{
				DestroyValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_0>(DestroyValidationCacheEXTPointer);
				DestroyValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_1>(DestroyValidationCacheEXTPointer);
			}
			GetValidationCacheDataEXTPointer = GetInstancePrecedureAddress(instance, "vkGetValidationCacheDataEXT");
			if (GetValidationCacheDataEXTPointer != IntPtr.Zero)
			{
				GetValidationCacheDataEXT_0 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_0>(GetValidationCacheDataEXTPointer);
				GetValidationCacheDataEXT_1 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_1>(GetValidationCacheDataEXTPointer);
			}
			MergeValidationCachesEXTPointer = GetInstancePrecedureAddress(instance, "vkMergeValidationCachesEXT");
			if (MergeValidationCachesEXTPointer != IntPtr.Zero)
			{
				MergeValidationCachesEXT_0 = Marshal.GetDelegateForFunctionPointer<MergeValidationCachesEXTDelegate_0>(MergeValidationCachesEXTPointer);
			}
			GetDescriptorSetLayoutSupportPointer = GetInstancePrecedureAddress(instance, "vkGetDescriptorSetLayoutSupport");
			if (GetDescriptorSetLayoutSupportPointer != IntPtr.Zero)
			{
				GetDescriptorSetLayoutSupport_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportDelegate_0>(GetDescriptorSetLayoutSupportPointer);
				GetDescriptorSetLayoutSupport_1 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportDelegate_1>(GetDescriptorSetLayoutSupportPointer);
			}
			GetSwapchainGrallocUsageANDROIDPointer = GetInstancePrecedureAddress(instance, "vkGetSwapchainGrallocUsageANDROID");
			if (GetSwapchainGrallocUsageANDROIDPointer != IntPtr.Zero)
			{
				GetSwapchainGrallocUsageANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainGrallocUsageANDROIDDelegate_0>(GetSwapchainGrallocUsageANDROIDPointer);
			}
			GetSwapchainGrallocUsage2ANDROIDPointer = GetInstancePrecedureAddress(instance, "vkGetSwapchainGrallocUsage2ANDROID");
			if (GetSwapchainGrallocUsage2ANDROIDPointer != IntPtr.Zero)
			{
				GetSwapchainGrallocUsage2ANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainGrallocUsage2ANDROIDDelegate_0>(GetSwapchainGrallocUsage2ANDROIDPointer);
				GetSwapchainGrallocUsage2ANDROID_1 = Marshal.GetDelegateForFunctionPointer<GetSwapchainGrallocUsage2ANDROIDDelegate_1>(GetSwapchainGrallocUsage2ANDROIDPointer);
			}
			AcquireImageANDROIDPointer = GetInstancePrecedureAddress(instance, "vkAcquireImageANDROID");
			if (AcquireImageANDROIDPointer != IntPtr.Zero)
			{
				AcquireImageANDROID_0 = Marshal.GetDelegateForFunctionPointer<AcquireImageANDROIDDelegate_0>(AcquireImageANDROIDPointer);
			}
			QueueSignalReleaseImageANDROIDPointer = GetInstancePrecedureAddress(instance, "vkQueueSignalReleaseImageANDROID");
			if (QueueSignalReleaseImageANDROIDPointer != IntPtr.Zero)
			{
				QueueSignalReleaseImageANDROID_0 = Marshal.GetDelegateForFunctionPointer<QueueSignalReleaseImageANDROIDDelegate_0>(QueueSignalReleaseImageANDROIDPointer);
				QueueSignalReleaseImageANDROID_1 = Marshal.GetDelegateForFunctionPointer<QueueSignalReleaseImageANDROIDDelegate_1>(QueueSignalReleaseImageANDROIDPointer);
			}
			GetShaderInfoAMDPointer = GetInstancePrecedureAddress(instance, "vkGetShaderInfoAMD");
			if (GetShaderInfoAMDPointer != IntPtr.Zero)
			{
				GetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_0>(GetShaderInfoAMDPointer);
				GetShaderInfoAMD_1 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_1>(GetShaderInfoAMDPointer);
			}
			SetLocalDimmingAMDPointer = GetInstancePrecedureAddress(instance, "vkSetLocalDimmingAMD");
			if (SetLocalDimmingAMDPointer != IntPtr.Zero)
			{
				SetLocalDimmingAMD_0 = Marshal.GetDelegateForFunctionPointer<SetLocalDimmingAMDDelegate_0>(SetLocalDimmingAMDPointer);
			}
			GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT");
			if (GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceCalibrateableTimeDomainsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0>(GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer);
				GetPhysicalDeviceCalibrateableTimeDomainsEXT_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1>(GetPhysicalDeviceCalibrateableTimeDomainsEXTPointer);
			}
			GetCalibratedTimestampsEXTPointer = GetInstancePrecedureAddress(instance, "vkGetCalibratedTimestampsEXT");
			if (GetCalibratedTimestampsEXTPointer != IntPtr.Zero)
			{
				GetCalibratedTimestampsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetCalibratedTimestampsEXTDelegate_0>(GetCalibratedTimestampsEXTPointer);
				GetCalibratedTimestampsEXT_1 = Marshal.GetDelegateForFunctionPointer<GetCalibratedTimestampsEXTDelegate_1>(GetCalibratedTimestampsEXTPointer);
			}
			SetDebugUtilsObjectNameEXTPointer = GetInstancePrecedureAddress(instance, "vkSetDebugUtilsObjectNameEXT");
			if (SetDebugUtilsObjectNameEXTPointer != IntPtr.Zero)
			{
				SetDebugUtilsObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectNameEXTDelegate_0>(SetDebugUtilsObjectNameEXTPointer);
				SetDebugUtilsObjectNameEXT_1 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectNameEXTDelegate_1>(SetDebugUtilsObjectNameEXTPointer);
			}
			SetDebugUtilsObjectTagEXTPointer = GetInstancePrecedureAddress(instance, "vkSetDebugUtilsObjectTagEXT");
			if (SetDebugUtilsObjectTagEXTPointer != IntPtr.Zero)
			{
				SetDebugUtilsObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectTagEXTDelegate_0>(SetDebugUtilsObjectTagEXTPointer);
				SetDebugUtilsObjectTagEXT_1 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectTagEXTDelegate_1>(SetDebugUtilsObjectTagEXTPointer);
			}
			QueueBeginDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkQueueBeginDebugUtilsLabelEXT");
			if (QueueBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				QueueBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueBeginDebugUtilsLabelEXTDelegate_0>(QueueBeginDebugUtilsLabelEXTPointer);
				QueueBeginDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<QueueBeginDebugUtilsLabelEXTDelegate_1>(QueueBeginDebugUtilsLabelEXTPointer);
			}
			QueueEndDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkQueueEndDebugUtilsLabelEXT");
			if (QueueEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				QueueEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueEndDebugUtilsLabelEXTDelegate_0>(QueueEndDebugUtilsLabelEXTPointer);
			}
			QueueInsertDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkQueueInsertDebugUtilsLabelEXT");
			if (QueueInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				QueueInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueInsertDebugUtilsLabelEXTDelegate_0>(QueueInsertDebugUtilsLabelEXTPointer);
				QueueInsertDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<QueueInsertDebugUtilsLabelEXTDelegate_1>(QueueInsertDebugUtilsLabelEXTPointer);
			}
			CommandBeginDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginDebugUtilsLabelEXT");
			if (CommandBeginDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				CommandBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginDebugUtilsLabelEXTDelegate_0>(CommandBeginDebugUtilsLabelEXTPointer);
				CommandBeginDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginDebugUtilsLabelEXTDelegate_1>(CommandBeginDebugUtilsLabelEXTPointer);
			}
			CommandEndDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdEndDebugUtilsLabelEXT");
			if (CommandEndDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				CommandEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndDebugUtilsLabelEXTDelegate_0>(CommandEndDebugUtilsLabelEXTPointer);
			}
			CommandInsertDebugUtilsLabelEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdInsertDebugUtilsLabelEXT");
			if (CommandInsertDebugUtilsLabelEXTPointer != IntPtr.Zero)
			{
				CommandInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandInsertDebugUtilsLabelEXTDelegate_0>(CommandInsertDebugUtilsLabelEXTPointer);
				CommandInsertDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandInsertDebugUtilsLabelEXTDelegate_1>(CommandInsertDebugUtilsLabelEXTPointer);
			}
			CreateDebugUtilsMessengerEXTPointer = GetInstancePrecedureAddress(instance, "vkCreateDebugUtilsMessengerEXT");
			if (CreateDebugUtilsMessengerEXTPointer != IntPtr.Zero)
			{
				CreateDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_0>(CreateDebugUtilsMessengerEXTPointer);
				CreateDebugUtilsMessengerEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_1>(CreateDebugUtilsMessengerEXTPointer);
				CreateDebugUtilsMessengerEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_2>(CreateDebugUtilsMessengerEXTPointer);
				CreateDebugUtilsMessengerEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_3>(CreateDebugUtilsMessengerEXTPointer);
			}
			DestroyDebugUtilsMessengerEXTPointer = GetInstancePrecedureAddress(instance, "vkDestroyDebugUtilsMessengerEXT");
			if (DestroyDebugUtilsMessengerEXTPointer != IntPtr.Zero)
			{
				DestroyDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugUtilsMessengerEXTDelegate_0>(DestroyDebugUtilsMessengerEXTPointer);
				DestroyDebugUtilsMessengerEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyDebugUtilsMessengerEXTDelegate_1>(DestroyDebugUtilsMessengerEXTPointer);
			}
			SubmitDebugUtilsMessageEXTPointer = GetInstancePrecedureAddress(instance, "vkSubmitDebugUtilsMessageEXT");
			if (SubmitDebugUtilsMessageEXTPointer != IntPtr.Zero)
			{
				SubmitDebugUtilsMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<SubmitDebugUtilsMessageEXTDelegate_0>(SubmitDebugUtilsMessageEXTPointer);
				SubmitDebugUtilsMessageEXT_1 = Marshal.GetDelegateForFunctionPointer<SubmitDebugUtilsMessageEXTDelegate_1>(SubmitDebugUtilsMessageEXTPointer);
			}
			GetMemoryHostPointerPropertiesEXTPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryHostPointerPropertiesEXT");
			if (GetMemoryHostPointerPropertiesEXTPointer != IntPtr.Zero)
			{
				GetMemoryHostPointerPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryHostPointerPropertiesEXTDelegate_0>(GetMemoryHostPointerPropertiesEXTPointer);
			}
			CommandWriteBufferMarkerAMDPointer = GetInstancePrecedureAddress(instance, "vkCmdWriteBufferMarkerAMD");
			if (CommandWriteBufferMarkerAMDPointer != IntPtr.Zero)
			{
				CommandWriteBufferMarkerAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteBufferMarkerAMDDelegate_0>(CommandWriteBufferMarkerAMDPointer);
			}
			CreateRenderPass2Pointer = GetInstancePrecedureAddress(instance, "vkCreateRenderPass2");
			if (CreateRenderPass2Pointer != IntPtr.Zero)
			{
				CreateRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_0>(CreateRenderPass2Pointer);
				CreateRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_1>(CreateRenderPass2Pointer);
				CreateRenderPass2_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_2>(CreateRenderPass2Pointer);
				CreateRenderPass2_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_3>(CreateRenderPass2Pointer);
			}
			CommandBeginRenderPass2Pointer = GetInstancePrecedureAddress(instance, "vkCmdBeginRenderPass2");
			if (CommandBeginRenderPass2Pointer != IntPtr.Zero)
			{
				CommandBeginRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_0>(CommandBeginRenderPass2Pointer);
				CommandBeginRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_1>(CommandBeginRenderPass2Pointer);
				CommandBeginRenderPass2_2 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_2>(CommandBeginRenderPass2Pointer);
				CommandBeginRenderPass2_3 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_3>(CommandBeginRenderPass2Pointer);
			}
			CommandNextSubpass2Pointer = GetInstancePrecedureAddress(instance, "vkCmdNextSubpass2");
			if (CommandNextSubpass2Pointer != IntPtr.Zero)
			{
				CommandNextSubpass2_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_0>(CommandNextSubpass2Pointer);
				CommandNextSubpass2_1 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_1>(CommandNextSubpass2Pointer);
				CommandNextSubpass2_2 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_2>(CommandNextSubpass2Pointer);
				CommandNextSubpass2_3 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_3>(CommandNextSubpass2Pointer);
			}
			CommandEndRenderPass2Pointer = GetInstancePrecedureAddress(instance, "vkCmdEndRenderPass2");
			if (CommandEndRenderPass2Pointer != IntPtr.Zero)
			{
				CommandEndRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2Delegate_0>(CommandEndRenderPass2Pointer);
				CommandEndRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2Delegate_1>(CommandEndRenderPass2Pointer);
			}
			GetSemaphoreCounterValuePointer = GetInstancePrecedureAddress(instance, "vkGetSemaphoreCounterValue");
			if (GetSemaphoreCounterValuePointer != IntPtr.Zero)
			{
				GetSemaphoreCounterValue_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreCounterValueDelegate_0>(GetSemaphoreCounterValuePointer);
			}
			WaitSemaphoresPointer = GetInstancePrecedureAddress(instance, "vkWaitSemaphores");
			if (WaitSemaphoresPointer != IntPtr.Zero)
			{
				WaitSemaphores_0 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresDelegate_0>(WaitSemaphoresPointer);
				WaitSemaphores_1 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresDelegate_1>(WaitSemaphoresPointer);
			}
			SignalSemaphorePointer = GetInstancePrecedureAddress(instance, "vkSignalSemaphore");
			if (SignalSemaphorePointer != IntPtr.Zero)
			{
				SignalSemaphore_0 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreDelegate_0>(SignalSemaphorePointer);
				SignalSemaphore_1 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreDelegate_1>(SignalSemaphorePointer);
			}
			GetAndroidHardwareBufferPropertiesANDROIDPointer = GetInstancePrecedureAddress(instance, "vkGetAndroidHardwareBufferPropertiesANDROID");
			if (GetAndroidHardwareBufferPropertiesANDROIDPointer != IntPtr.Zero)
			{
				GetAndroidHardwareBufferPropertiesANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetAndroidHardwareBufferPropertiesANDROIDDelegate_0>(GetAndroidHardwareBufferPropertiesANDROIDPointer);
				GetAndroidHardwareBufferPropertiesANDROID_1 = Marshal.GetDelegateForFunctionPointer<GetAndroidHardwareBufferPropertiesANDROIDDelegate_1>(GetAndroidHardwareBufferPropertiesANDROIDPointer);
			}
			GetMemoryAndroidHardwareBufferANDROIDPointer = GetInstancePrecedureAddress(instance, "vkGetMemoryAndroidHardwareBufferANDROID");
			if (GetMemoryAndroidHardwareBufferANDROIDPointer != IntPtr.Zero)
			{
				GetMemoryAndroidHardwareBufferANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryAndroidHardwareBufferANDROIDDelegate_0>(GetMemoryAndroidHardwareBufferANDROIDPointer);
				GetMemoryAndroidHardwareBufferANDROID_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryAndroidHardwareBufferANDROIDDelegate_1>(GetMemoryAndroidHardwareBufferANDROIDPointer);
			}
			CommandDrawIndirectCountPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndirectCount");
			if (CommandDrawIndirectCountPointer != IntPtr.Zero)
			{
				CommandDrawIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountDelegate_0>(CommandDrawIndirectCountPointer);
			}
			CommandDrawIndexedIndirectCountPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndexedIndirectCount");
			if (CommandDrawIndexedIndirectCountPointer != IntPtr.Zero)
			{
				CommandDrawIndexedIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountDelegate_0>(CommandDrawIndexedIndirectCountPointer);
			}
			CommandSetCheckpointNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetCheckpointNV");
			if (CommandSetCheckpointNVPointer != IntPtr.Zero)
			{
				CommandSetCheckpointNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCheckpointNVDelegate_0>(CommandSetCheckpointNVPointer);
			}
			GetQueueCheckpointDataNVPointer = GetInstancePrecedureAddress(instance, "vkGetQueueCheckpointDataNV");
			if (GetQueueCheckpointDataNVPointer != IntPtr.Zero)
			{
				GetQueueCheckpointDataNV_0 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointDataNVDelegate_0>(GetQueueCheckpointDataNVPointer);
				GetQueueCheckpointDataNV_1 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointDataNVDelegate_1>(GetQueueCheckpointDataNVPointer);
			}
			CommandBindTransformFeedbackBuffersEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdBindTransformFeedbackBuffersEXT");
			if (CommandBindTransformFeedbackBuffersEXTPointer != IntPtr.Zero)
			{
				CommandBindTransformFeedbackBuffersEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_0>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_1>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_2 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_2>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_3 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_3>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_4 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_4>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_5 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_5>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_6 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_6>(CommandBindTransformFeedbackBuffersEXTPointer);
				CommandBindTransformFeedbackBuffersEXT_7 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_7>(CommandBindTransformFeedbackBuffersEXTPointer);
			}
			CommandBeginTransformFeedbackEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginTransformFeedbackEXT");
			if (CommandBeginTransformFeedbackEXTPointer != IntPtr.Zero)
			{
				CommandBeginTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginTransformFeedbackEXTDelegate_0>(CommandBeginTransformFeedbackEXTPointer);
				CommandBeginTransformFeedbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginTransformFeedbackEXTDelegate_1>(CommandBeginTransformFeedbackEXTPointer);
			}
			CommandEndTransformFeedbackEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdEndTransformFeedbackEXT");
			if (CommandEndTransformFeedbackEXTPointer != IntPtr.Zero)
			{
				CommandEndTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndTransformFeedbackEXTDelegate_0>(CommandEndTransformFeedbackEXTPointer);
				CommandEndTransformFeedbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandEndTransformFeedbackEXTDelegate_1>(CommandEndTransformFeedbackEXTPointer);
			}
			CommandBeginQueryIndexedEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginQueryIndexedEXT");
			if (CommandBeginQueryIndexedEXTPointer != IntPtr.Zero)
			{
				CommandBeginQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryIndexedEXTDelegate_0>(CommandBeginQueryIndexedEXTPointer);
			}
			CommandEndQueryIndexedEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdEndQueryIndexedEXT");
			if (CommandEndQueryIndexedEXTPointer != IntPtr.Zero)
			{
				CommandEndQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryIndexedEXTDelegate_0>(CommandEndQueryIndexedEXTPointer);
			}
			CommandDrawIndirectByteCountEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawIndirectByteCountEXT");
			if (CommandDrawIndirectByteCountEXTPointer != IntPtr.Zero)
			{
				CommandDrawIndirectByteCountEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectByteCountEXTDelegate_0>(CommandDrawIndirectByteCountEXTPointer);
			}
			CommandSetExclusiveScissorNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetExclusiveScissorNV");
			if (CommandSetExclusiveScissorNVPointer != IntPtr.Zero)
			{
				CommandSetExclusiveScissorNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetExclusiveScissorNVDelegate_0>(CommandSetExclusiveScissorNVPointer);
			}
			CommandBindShadingRateImageNVPointer = GetInstancePrecedureAddress(instance, "vkCmdBindShadingRateImageNV");
			if (CommandBindShadingRateImageNVPointer != IntPtr.Zero)
			{
				CommandBindShadingRateImageNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBindShadingRateImageNVDelegate_0>(CommandBindShadingRateImageNVPointer);
			}
			CommandSetViewportShadingRatePaletteNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetViewportShadingRatePaletteNV");
			if (CommandSetViewportShadingRatePaletteNVPointer != IntPtr.Zero)
			{
				CommandSetViewportShadingRatePaletteNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportShadingRatePaletteNVDelegate_0>(CommandSetViewportShadingRatePaletteNVPointer);
				CommandSetViewportShadingRatePaletteNV_1 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportShadingRatePaletteNVDelegate_1>(CommandSetViewportShadingRatePaletteNVPointer);
			}
			CommandSetCoarseSampleOrderNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetCoarseSampleOrderNV");
			if (CommandSetCoarseSampleOrderNVPointer != IntPtr.Zero)
			{
				CommandSetCoarseSampleOrderNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCoarseSampleOrderNVDelegate_0>(CommandSetCoarseSampleOrderNVPointer);
			}
			CommandDrawMeshTasksNVPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawMeshTasksNV");
			if (CommandDrawMeshTasksNVPointer != IntPtr.Zero)
			{
				CommandDrawMeshTasksNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksNVDelegate_0>(CommandDrawMeshTasksNVPointer);
			}
			CommandDrawMeshTasksIndirectNVPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawMeshTasksIndirectNV");
			if (CommandDrawMeshTasksIndirectNVPointer != IntPtr.Zero)
			{
				CommandDrawMeshTasksIndirectNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectNVDelegate_0>(CommandDrawMeshTasksIndirectNVPointer);
			}
			CommandDrawMeshTasksIndirectCountNVPointer = GetInstancePrecedureAddress(instance, "vkCmdDrawMeshTasksIndirectCountNV");
			if (CommandDrawMeshTasksIndirectCountNVPointer != IntPtr.Zero)
			{
				CommandDrawMeshTasksIndirectCountNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectCountNVDelegate_0>(CommandDrawMeshTasksIndirectCountNVPointer);
			}
			CompileDeferredNVPointer = GetInstancePrecedureAddress(instance, "vkCompileDeferredNV");
			if (CompileDeferredNVPointer != IntPtr.Zero)
			{
				CompileDeferredNV_0 = Marshal.GetDelegateForFunctionPointer<CompileDeferredNVDelegate_0>(CompileDeferredNVPointer);
			}
			CreateAccelerationStructureNVPointer = GetInstancePrecedureAddress(instance, "vkCreateAccelerationStructureNV");
			if (CreateAccelerationStructureNVPointer != IntPtr.Zero)
			{
				CreateAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_0>(CreateAccelerationStructureNVPointer);
				CreateAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_1>(CreateAccelerationStructureNVPointer);
				CreateAccelerationStructureNV_2 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_2>(CreateAccelerationStructureNVPointer);
				CreateAccelerationStructureNV_3 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_3>(CreateAccelerationStructureNVPointer);
			}
			CommandBindInvocationMaskHUAWEIPointer = GetInstancePrecedureAddress(instance, "vkCmdBindInvocationMaskHUAWEI");
			if (CommandBindInvocationMaskHUAWEIPointer != IntPtr.Zero)
			{
				CommandBindInvocationMaskHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<CommandBindInvocationMaskHUAWEIDelegate_0>(CommandBindInvocationMaskHUAWEIPointer);
			}
			DestroyAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkDestroyAccelerationStructureKHR");
			if (DestroyAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				DestroyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureKHRDelegate_0>(DestroyAccelerationStructureKHRPointer);
				DestroyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureKHRDelegate_1>(DestroyAccelerationStructureKHRPointer);
			}
			DestroyAccelerationStructureNVPointer = GetInstancePrecedureAddress(instance, "vkDestroyAccelerationStructureNV");
			if (DestroyAccelerationStructureNVPointer != IntPtr.Zero)
			{
				DestroyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureNVDelegate_0>(DestroyAccelerationStructureNVPointer);
				DestroyAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureNVDelegate_1>(DestroyAccelerationStructureNVPointer);
			}
			GetAccelerationStructureMemoryRequirementsNVPointer = GetInstancePrecedureAddress(instance, "vkGetAccelerationStructureMemoryRequirementsNV");
			if (GetAccelerationStructureMemoryRequirementsNVPointer != IntPtr.Zero)
			{
				GetAccelerationStructureMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureMemoryRequirementsNVDelegate_0>(GetAccelerationStructureMemoryRequirementsNVPointer);
				GetAccelerationStructureMemoryRequirementsNV_1 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureMemoryRequirementsNVDelegate_1>(GetAccelerationStructureMemoryRequirementsNVPointer);
			}
			BindAccelerationStructureMemoryNVPointer = GetInstancePrecedureAddress(instance, "vkBindAccelerationStructureMemoryNV");
			if (BindAccelerationStructureMemoryNVPointer != IntPtr.Zero)
			{
				BindAccelerationStructureMemoryNV_0 = Marshal.GetDelegateForFunctionPointer<BindAccelerationStructureMemoryNVDelegate_0>(BindAccelerationStructureMemoryNVPointer);
			}
			CommandCopyAccelerationStructureNVPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyAccelerationStructureNV");
			if (CommandCopyAccelerationStructureNVPointer != IntPtr.Zero)
			{
				CommandCopyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureNVDelegate_0>(CommandCopyAccelerationStructureNVPointer);
			}
			CommandCopyAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyAccelerationStructureKHR");
			if (CommandCopyAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				CommandCopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureKHRDelegate_0>(CommandCopyAccelerationStructureKHRPointer);
				CommandCopyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureKHRDelegate_1>(CommandCopyAccelerationStructureKHRPointer);
			}
			CopyAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkCopyAccelerationStructureKHR");
			if (CopyAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				CopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureKHRDelegate_0>(CopyAccelerationStructureKHRPointer);
				CopyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureKHRDelegate_1>(CopyAccelerationStructureKHRPointer);
			}
			CommandCopyAccelerationStructureToMemoryKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyAccelerationStructureToMemoryKHR");
			if (CommandCopyAccelerationStructureToMemoryKHRPointer != IntPtr.Zero)
			{
				CommandCopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureToMemoryKHRDelegate_0>(CommandCopyAccelerationStructureToMemoryKHRPointer);
				CommandCopyAccelerationStructureToMemoryKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureToMemoryKHRDelegate_1>(CommandCopyAccelerationStructureToMemoryKHRPointer);
			}
			CopyAccelerationStructureToMemoryKHRPointer = GetInstancePrecedureAddress(instance, "vkCopyAccelerationStructureToMemoryKHR");
			if (CopyAccelerationStructureToMemoryKHRPointer != IntPtr.Zero)
			{
				CopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureToMemoryKHRDelegate_0>(CopyAccelerationStructureToMemoryKHRPointer);
				CopyAccelerationStructureToMemoryKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureToMemoryKHRDelegate_1>(CopyAccelerationStructureToMemoryKHRPointer);
			}
			CommandCopyMemoryToAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdCopyMemoryToAccelerationStructureKHR");
			if (CommandCopyMemoryToAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				CommandCopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyMemoryToAccelerationStructureKHRDelegate_0>(CommandCopyMemoryToAccelerationStructureKHRPointer);
				CommandCopyMemoryToAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyMemoryToAccelerationStructureKHRDelegate_1>(CommandCopyMemoryToAccelerationStructureKHRPointer);
			}
			CopyMemoryToAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkCopyMemoryToAccelerationStructureKHR");
			if (CopyMemoryToAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				CopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyMemoryToAccelerationStructureKHRDelegate_0>(CopyMemoryToAccelerationStructureKHRPointer);
				CopyMemoryToAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyMemoryToAccelerationStructureKHRDelegate_1>(CopyMemoryToAccelerationStructureKHRPointer);
			}
			CommandWriteAccelerationStructuresPropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdWriteAccelerationStructuresPropertiesKHR");
			if (CommandWriteAccelerationStructuresPropertiesKHRPointer != IntPtr.Zero)
			{
				CommandWriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteAccelerationStructuresPropertiesKHRDelegate_0>(CommandWriteAccelerationStructuresPropertiesKHRPointer);
			}
			CommandWriteAccelerationStructuresPropertiesNVPointer = GetInstancePrecedureAddress(instance, "vkCmdWriteAccelerationStructuresPropertiesNV");
			if (CommandWriteAccelerationStructuresPropertiesNVPointer != IntPtr.Zero)
			{
				CommandWriteAccelerationStructuresPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteAccelerationStructuresPropertiesNVDelegate_0>(CommandWriteAccelerationStructuresPropertiesNVPointer);
			}
			CommandBuildAccelerationStructureNVPointer = GetInstancePrecedureAddress(instance, "vkCmdBuildAccelerationStructureNV");
			if (CommandBuildAccelerationStructureNVPointer != IntPtr.Zero)
			{
				CommandBuildAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructureNVDelegate_0>(CommandBuildAccelerationStructureNVPointer);
				CommandBuildAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructureNVDelegate_1>(CommandBuildAccelerationStructureNVPointer);
			}
			WriteAccelerationStructuresPropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkWriteAccelerationStructuresPropertiesKHR");
			if (WriteAccelerationStructuresPropertiesKHRPointer != IntPtr.Zero)
			{
				WriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<WriteAccelerationStructuresPropertiesKHRDelegate_0>(WriteAccelerationStructuresPropertiesKHRPointer);
			}
			CommandTraceRaysKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdTraceRaysKHR");
			if (CommandTraceRaysKHRPointer != IntPtr.Zero)
			{
				CommandTraceRaysKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_0>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_1>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_2>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_3>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_4>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_5>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_6>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_7>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_8 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_8>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_9 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_9>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_10 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_10>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_11 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_11>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_12 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_12>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_13 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_13>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_14 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_14>(CommandTraceRaysKHRPointer);
				CommandTraceRaysKHR_15 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_15>(CommandTraceRaysKHRPointer);
			}
			CommandTraceRaysNVPointer = GetInstancePrecedureAddress(instance, "vkCmdTraceRaysNV");
			if (CommandTraceRaysNVPointer != IntPtr.Zero)
			{
				CommandTraceRaysNV_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysNVDelegate_0>(CommandTraceRaysNVPointer);
			}
			GetRayTracingShaderGroupHandlesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetRayTracingShaderGroupHandlesKHR");
			if (GetRayTracingShaderGroupHandlesKHRPointer != IntPtr.Zero)
			{
				GetRayTracingShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupHandlesKHRDelegate_0>(GetRayTracingShaderGroupHandlesKHRPointer);
			}
			GetRayTracingCaptureReplayShaderGroupHandlesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
			if (GetRayTracingCaptureReplayShaderGroupHandlesKHRPointer != IntPtr.Zero)
			{
				GetRayTracingCaptureReplayShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0>(GetRayTracingCaptureReplayShaderGroupHandlesKHRPointer);
			}
			GetAccelerationStructureHandleNVPointer = GetInstancePrecedureAddress(instance, "vkGetAccelerationStructureHandleNV");
			if (GetAccelerationStructureHandleNVPointer != IntPtr.Zero)
			{
				GetAccelerationStructureHandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureHandleNVDelegate_0>(GetAccelerationStructureHandleNVPointer);
			}
			CreateRayTracingPipelinesNVPointer = GetInstancePrecedureAddress(instance, "vkCreateRayTracingPipelinesNV");
			if (CreateRayTracingPipelinesNVPointer != IntPtr.Zero)
			{
				CreateRayTracingPipelinesNV_0 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesNVDelegate_0>(CreateRayTracingPipelinesNVPointer);
				CreateRayTracingPipelinesNV_1 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesNVDelegate_1>(CreateRayTracingPipelinesNVPointer);
			}
			CreateRayTracingPipelinesKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateRayTracingPipelinesKHR");
			if (CreateRayTracingPipelinesKHRPointer != IntPtr.Zero)
			{
				CreateRayTracingPipelinesKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesKHRDelegate_0>(CreateRayTracingPipelinesKHRPointer);
				CreateRayTracingPipelinesKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesKHRDelegate_1>(CreateRayTracingPipelinesKHRPointer);
			}
			GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
			if (GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceCooperativeMatrixPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0>(GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer);
				GetPhysicalDeviceCooperativeMatrixPropertiesNV_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1>(GetPhysicalDeviceCooperativeMatrixPropertiesNVPointer);
			}
			CommandTraceRaysIndirectKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdTraceRaysIndirectKHR");
			if (CommandTraceRaysIndirectKHRPointer != IntPtr.Zero)
			{
				CommandTraceRaysIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_0>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_1>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_2>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_3>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_4>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_5>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_6>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_7>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_8 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_8>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_9 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_9>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_10 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_10>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_11 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_11>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_12 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_12>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_13 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_13>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_14 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_14>(CommandTraceRaysIndirectKHRPointer);
				CommandTraceRaysIndirectKHR_15 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_15>(CommandTraceRaysIndirectKHRPointer);
			}
			CommandTraceRaysIndirect2KHRPointer = GetInstancePrecedureAddress(instance, "vkCmdTraceRaysIndirect2KHR");
			if (CommandTraceRaysIndirect2KHRPointer != IntPtr.Zero)
			{
				CommandTraceRaysIndirect2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirect2KHRDelegate_0>(CommandTraceRaysIndirect2KHRPointer);
			}
			GetDeviceAccelerationStructureCompatibilityKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceAccelerationStructureCompatibilityKHR");
			if (GetDeviceAccelerationStructureCompatibilityKHRPointer != IntPtr.Zero)
			{
				GetDeviceAccelerationStructureCompatibilityKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceAccelerationStructureCompatibilityKHRDelegate_0>(GetDeviceAccelerationStructureCompatibilityKHRPointer);
				GetDeviceAccelerationStructureCompatibilityKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceAccelerationStructureCompatibilityKHRDelegate_1>(GetDeviceAccelerationStructureCompatibilityKHRPointer);
			}
			GetRayTracingShaderGroupStackSizeKHRPointer = GetInstancePrecedureAddress(instance, "vkGetRayTracingShaderGroupStackSizeKHR");
			if (GetRayTracingShaderGroupStackSizeKHRPointer != IntPtr.Zero)
			{
				GetRayTracingShaderGroupStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupStackSizeKHRDelegate_0>(GetRayTracingShaderGroupStackSizeKHRPointer);
			}
			CommandSetRayTracingPipelineStackSizeKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdSetRayTracingPipelineStackSizeKHR");
			if (CommandSetRayTracingPipelineStackSizeKHRPointer != IntPtr.Zero)
			{
				CommandSetRayTracingPipelineStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetRayTracingPipelineStackSizeKHRDelegate_0>(CommandSetRayTracingPipelineStackSizeKHRPointer);
			}
			GetImageViewHandleNVXPointer = GetInstancePrecedureAddress(instance, "vkGetImageViewHandleNVX");
			if (GetImageViewHandleNVXPointer != IntPtr.Zero)
			{
				GetImageViewHandleNVX_0 = Marshal.GetDelegateForFunctionPointer<GetImageViewHandleNVXDelegate_0>(GetImageViewHandleNVXPointer);
			}
			GetImageViewAddressNVXPointer = GetInstancePrecedureAddress(instance, "vkGetImageViewAddressNVX");
			if (GetImageViewAddressNVXPointer != IntPtr.Zero)
			{
				GetImageViewAddressNVX_0 = Marshal.GetDelegateForFunctionPointer<GetImageViewAddressNVXDelegate_0>(GetImageViewAddressNVXPointer);
			}
			GetPhysicalDeviceSurfacePresentModes2EXTPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSurfacePresentModes2EXT");
			if (GetPhysicalDeviceSurfacePresentModes2EXTPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0>(GetPhysicalDeviceSurfacePresentModes2EXTPointer);
				GetPhysicalDeviceSurfacePresentModes2EXT_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1>(GetPhysicalDeviceSurfacePresentModes2EXTPointer);
				GetPhysicalDeviceSurfacePresentModes2EXT_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2>(GetPhysicalDeviceSurfacePresentModes2EXTPointer);
				GetPhysicalDeviceSurfacePresentModes2EXT_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3>(GetPhysicalDeviceSurfacePresentModes2EXTPointer);
			}
			GetDeviceGroupSurfacePresentModes2EXTPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceGroupSurfacePresentModes2EXT");
			if (GetDeviceGroupSurfacePresentModes2EXTPointer != IntPtr.Zero)
			{
				GetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_0>(GetDeviceGroupSurfacePresentModes2EXTPointer);
				GetDeviceGroupSurfacePresentModes2EXT_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_1>(GetDeviceGroupSurfacePresentModes2EXTPointer);
			}
			AcquireFullScreenExclusiveModeEXTPointer = GetInstancePrecedureAddress(instance, "vkAcquireFullScreenExclusiveModeEXT");
			if (AcquireFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
			{
				AcquireFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireFullScreenExclusiveModeEXTDelegate_0>(AcquireFullScreenExclusiveModeEXTPointer);
			}
			ReleaseFullScreenExclusiveModeEXTPointer = GetInstancePrecedureAddress(instance, "vkReleaseFullScreenExclusiveModeEXT");
			if (ReleaseFullScreenExclusiveModeEXTPointer != IntPtr.Zero)
			{
				ReleaseFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseFullScreenExclusiveModeEXTDelegate_0>(ReleaseFullScreenExclusiveModeEXTPointer);
			}
			EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer = GetInstancePrecedureAddress(instance, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
			if (EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer != IntPtr.Zero)
			{
				EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0>(EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer);
				EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1>(EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRPointer);
			}
			GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
			if (GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0>(GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer);
				GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1>(GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRPointer);
			}
			AcquireProfilingLockKHRPointer = GetInstancePrecedureAddress(instance, "vkAcquireProfilingLockKHR");
			if (AcquireProfilingLockKHRPointer != IntPtr.Zero)
			{
				AcquireProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireProfilingLockKHRDelegate_0>(AcquireProfilingLockKHRPointer);
				AcquireProfilingLockKHR_1 = Marshal.GetDelegateForFunctionPointer<AcquireProfilingLockKHRDelegate_1>(AcquireProfilingLockKHRPointer);
			}
			ReleaseProfilingLockKHRPointer = GetInstancePrecedureAddress(instance, "vkReleaseProfilingLockKHR");
			if (ReleaseProfilingLockKHRPointer != IntPtr.Zero)
			{
				ReleaseProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<ReleaseProfilingLockKHRDelegate_0>(ReleaseProfilingLockKHRPointer);
			}
			GetImageDrmFormatModifierPropertiesEXTPointer = GetInstancePrecedureAddress(instance, "vkGetImageDrmFormatModifierPropertiesEXT");
			if (GetImageDrmFormatModifierPropertiesEXTPointer != IntPtr.Zero)
			{
				GetImageDrmFormatModifierPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetImageDrmFormatModifierPropertiesEXTDelegate_0>(GetImageDrmFormatModifierPropertiesEXTPointer);
			}
			GetBufferOpaqueCaptureAddressPointer = GetInstancePrecedureAddress(instance, "vkGetBufferOpaqueCaptureAddress");
			if (GetBufferOpaqueCaptureAddressPointer != IntPtr.Zero)
			{
				GetBufferOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetBufferOpaqueCaptureAddressDelegate_0>(GetBufferOpaqueCaptureAddressPointer);
			}
			GetBufferDeviceAddressPointer = GetInstancePrecedureAddress(instance, "vkGetBufferDeviceAddress");
			if (GetBufferDeviceAddressPointer != IntPtr.Zero)
			{
				GetBufferDeviceAddress_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressDelegate_0>(GetBufferDeviceAddressPointer);
			}
			CreateHeadlessSurfaceEXTPointer = GetInstancePrecedureAddress(instance, "vkCreateHeadlessSurfaceEXT");
			if (CreateHeadlessSurfaceEXTPointer != IntPtr.Zero)
			{
				CreateHeadlessSurfaceEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_0>(CreateHeadlessSurfaceEXTPointer);
				CreateHeadlessSurfaceEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_1>(CreateHeadlessSurfaceEXTPointer);
				CreateHeadlessSurfaceEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_2>(CreateHeadlessSurfaceEXTPointer);
				CreateHeadlessSurfaceEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_3>(CreateHeadlessSurfaceEXTPointer);
			}
			GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
			if (GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0>(GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer);
				GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1>(GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVPointer);
			}
			InitializePerformanceApiINTELPointer = GetInstancePrecedureAddress(instance, "vkInitializePerformanceApiINTEL");
			if (InitializePerformanceApiINTELPointer != IntPtr.Zero)
			{
				InitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<InitializePerformanceApiINTELDelegate_0>(InitializePerformanceApiINTELPointer);
				InitializePerformanceApiINTEL_1 = Marshal.GetDelegateForFunctionPointer<InitializePerformanceApiINTELDelegate_1>(InitializePerformanceApiINTELPointer);
			}
			UninitializePerformanceApiINTELPointer = GetInstancePrecedureAddress(instance, "vkUninitializePerformanceApiINTEL");
			if (UninitializePerformanceApiINTELPointer != IntPtr.Zero)
			{
				UninitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<UninitializePerformanceApiINTELDelegate_0>(UninitializePerformanceApiINTELPointer);
			}
			CommandSetPerformanceMarkerINTELPointer = GetInstancePrecedureAddress(instance, "vkCmdSetPerformanceMarkerINTEL");
			if (CommandSetPerformanceMarkerINTELPointer != IntPtr.Zero)
			{
				CommandSetPerformanceMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceMarkerINTELDelegate_0>(CommandSetPerformanceMarkerINTELPointer);
				CommandSetPerformanceMarkerINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceMarkerINTELDelegate_1>(CommandSetPerformanceMarkerINTELPointer);
			}
			CommandSetPerformanceStreamMarkerINTELPointer = GetInstancePrecedureAddress(instance, "vkCmdSetPerformanceStreamMarkerINTEL");
			if (CommandSetPerformanceStreamMarkerINTELPointer != IntPtr.Zero)
			{
				CommandSetPerformanceStreamMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceStreamMarkerINTELDelegate_0>(CommandSetPerformanceStreamMarkerINTELPointer);
				CommandSetPerformanceStreamMarkerINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceStreamMarkerINTELDelegate_1>(CommandSetPerformanceStreamMarkerINTELPointer);
			}
			CommandSetPerformanceOverrideINTELPointer = GetInstancePrecedureAddress(instance, "vkCmdSetPerformanceOverrideINTEL");
			if (CommandSetPerformanceOverrideINTELPointer != IntPtr.Zero)
			{
				CommandSetPerformanceOverrideINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceOverrideINTELDelegate_0>(CommandSetPerformanceOverrideINTELPointer);
				CommandSetPerformanceOverrideINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceOverrideINTELDelegate_1>(CommandSetPerformanceOverrideINTELPointer);
			}
			AcquirePerformanceConfigurationINTELPointer = GetInstancePrecedureAddress(instance, "vkAcquirePerformanceConfigurationINTEL");
			if (AcquirePerformanceConfigurationINTELPointer != IntPtr.Zero)
			{
				AcquirePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_0>(AcquirePerformanceConfigurationINTELPointer);
				AcquirePerformanceConfigurationINTEL_1 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_1>(AcquirePerformanceConfigurationINTELPointer);
				AcquirePerformanceConfigurationINTEL_2 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_2>(AcquirePerformanceConfigurationINTELPointer);
				AcquirePerformanceConfigurationINTEL_3 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_3>(AcquirePerformanceConfigurationINTELPointer);
			}
			ReleasePerformanceConfigurationINTELPointer = GetInstancePrecedureAddress(instance, "vkReleasePerformanceConfigurationINTEL");
			if (ReleasePerformanceConfigurationINTELPointer != IntPtr.Zero)
			{
				ReleasePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<ReleasePerformanceConfigurationINTELDelegate_0>(ReleasePerformanceConfigurationINTELPointer);
			}
			QueueSetPerformanceConfigurationINTELPointer = GetInstancePrecedureAddress(instance, "vkQueueSetPerformanceConfigurationINTEL");
			if (QueueSetPerformanceConfigurationINTELPointer != IntPtr.Zero)
			{
				QueueSetPerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<QueueSetPerformanceConfigurationINTELDelegate_0>(QueueSetPerformanceConfigurationINTELPointer);
			}
			GetPerformanceParameterINTELPointer = GetInstancePrecedureAddress(instance, "vkGetPerformanceParameterINTEL");
			if (GetPerformanceParameterINTELPointer != IntPtr.Zero)
			{
				GetPerformanceParameterINTEL_0 = Marshal.GetDelegateForFunctionPointer<GetPerformanceParameterINTELDelegate_0>(GetPerformanceParameterINTELPointer);
			}
			GetDeviceMemoryOpaqueCaptureAddressPointer = GetInstancePrecedureAddress(instance, "vkGetDeviceMemoryOpaqueCaptureAddress");
			if (GetDeviceMemoryOpaqueCaptureAddressPointer != IntPtr.Zero)
			{
				GetDeviceMemoryOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryOpaqueCaptureAddressDelegate_0>(GetDeviceMemoryOpaqueCaptureAddressPointer);
			}
			GetPipelineExecutablePropertiesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPipelineExecutablePropertiesKHR");
			if (GetPipelineExecutablePropertiesKHRPointer != IntPtr.Zero)
			{
				GetPipelineExecutablePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_0>(GetPipelineExecutablePropertiesKHRPointer);
				GetPipelineExecutablePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_1>(GetPipelineExecutablePropertiesKHRPointer);
				GetPipelineExecutablePropertiesKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_2>(GetPipelineExecutablePropertiesKHRPointer);
				GetPipelineExecutablePropertiesKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_3>(GetPipelineExecutablePropertiesKHRPointer);
			}
			GetPipelineExecutableStatisticsKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPipelineExecutableStatisticsKHR");
			if (GetPipelineExecutableStatisticsKHRPointer != IntPtr.Zero)
			{
				GetPipelineExecutableStatisticsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_0>(GetPipelineExecutableStatisticsKHRPointer);
				GetPipelineExecutableStatisticsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_1>(GetPipelineExecutableStatisticsKHRPointer);
				GetPipelineExecutableStatisticsKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_2>(GetPipelineExecutableStatisticsKHRPointer);
				GetPipelineExecutableStatisticsKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_3>(GetPipelineExecutableStatisticsKHRPointer);
			}
			GetPipelineExecutableInternalRepresentationsKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPipelineExecutableInternalRepresentationsKHR");
			if (GetPipelineExecutableInternalRepresentationsKHRPointer != IntPtr.Zero)
			{
				GetPipelineExecutableInternalRepresentationsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_0>(GetPipelineExecutableInternalRepresentationsKHRPointer);
				GetPipelineExecutableInternalRepresentationsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_1>(GetPipelineExecutableInternalRepresentationsKHRPointer);
				GetPipelineExecutableInternalRepresentationsKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_2>(GetPipelineExecutableInternalRepresentationsKHRPointer);
				GetPipelineExecutableInternalRepresentationsKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_3>(GetPipelineExecutableInternalRepresentationsKHRPointer);
			}
			CommandSetLineStippleEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetLineStippleEXT");
			if (CommandSetLineStippleEXTPointer != IntPtr.Zero)
			{
				CommandSetLineStippleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineStippleEXTDelegate_0>(CommandSetLineStippleEXTPointer);
			}
			GetPhysicalDeviceToolPropertiesPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceToolProperties");
			if (GetPhysicalDeviceToolPropertiesPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceToolProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceToolPropertiesDelegate_0>(GetPhysicalDeviceToolPropertiesPointer);
				GetPhysicalDeviceToolProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceToolPropertiesDelegate_1>(GetPhysicalDeviceToolPropertiesPointer);
			}
			CreateAccelerationStructureKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateAccelerationStructureKHR");
			if (CreateAccelerationStructureKHRPointer != IntPtr.Zero)
			{
				CreateAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_0>(CreateAccelerationStructureKHRPointer);
				CreateAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_1>(CreateAccelerationStructureKHRPointer);
				CreateAccelerationStructureKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_2>(CreateAccelerationStructureKHRPointer);
				CreateAccelerationStructureKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_3>(CreateAccelerationStructureKHRPointer);
			}
			CommandBuildAccelerationStructuresKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdBuildAccelerationStructuresKHR");
			if (CommandBuildAccelerationStructuresKHRPointer != IntPtr.Zero)
			{
				CommandBuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresKHRDelegate_0>(CommandBuildAccelerationStructuresKHRPointer);
			}
			CommandBuildAccelerationStructuresIndirectKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdBuildAccelerationStructuresIndirectKHR");
			if (CommandBuildAccelerationStructuresIndirectKHRPointer != IntPtr.Zero)
			{
				CommandBuildAccelerationStructuresIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_0>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_1>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_2>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_3>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_4>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_5>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_6>(CommandBuildAccelerationStructuresIndirectKHRPointer);
				CommandBuildAccelerationStructuresIndirectKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_7>(CommandBuildAccelerationStructuresIndirectKHRPointer);
			}
			BuildAccelerationStructuresKHRPointer = GetInstancePrecedureAddress(instance, "vkBuildAccelerationStructuresKHR");
			if (BuildAccelerationStructuresKHRPointer != IntPtr.Zero)
			{
				BuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<BuildAccelerationStructuresKHRDelegate_0>(BuildAccelerationStructuresKHRPointer);
			}
			GetAccelerationStructureDeviceAddressKHRPointer = GetInstancePrecedureAddress(instance, "vkGetAccelerationStructureDeviceAddressKHR");
			if (GetAccelerationStructureDeviceAddressKHRPointer != IntPtr.Zero)
			{
				GetAccelerationStructureDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureDeviceAddressKHRDelegate_0>(GetAccelerationStructureDeviceAddressKHRPointer);
			}
			CreateDeferredOperationKHRPointer = GetInstancePrecedureAddress(instance, "vkCreateDeferredOperationKHR");
			if (CreateDeferredOperationKHRPointer != IntPtr.Zero)
			{
				CreateDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDeferredOperationKHRDelegate_0>(CreateDeferredOperationKHRPointer);
				CreateDeferredOperationKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDeferredOperationKHRDelegate_1>(CreateDeferredOperationKHRPointer);
			}
			DestroyDeferredOperationKHRPointer = GetInstancePrecedureAddress(instance, "vkDestroyDeferredOperationKHR");
			if (DestroyDeferredOperationKHRPointer != IntPtr.Zero)
			{
				DestroyDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeferredOperationKHRDelegate_0>(DestroyDeferredOperationKHRPointer);
				DestroyDeferredOperationKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyDeferredOperationKHRDelegate_1>(DestroyDeferredOperationKHRPointer);
			}
			GetDeferredOperationMaxConcurrencyKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDeferredOperationMaxConcurrencyKHR");
			if (GetDeferredOperationMaxConcurrencyKHRPointer != IntPtr.Zero)
			{
				GetDeferredOperationMaxConcurrencyKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeferredOperationMaxConcurrencyKHRDelegate_0>(GetDeferredOperationMaxConcurrencyKHRPointer);
			}
			GetDeferredOperationResultKHRPointer = GetInstancePrecedureAddress(instance, "vkGetDeferredOperationResultKHR");
			if (GetDeferredOperationResultKHRPointer != IntPtr.Zero)
			{
				GetDeferredOperationResultKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeferredOperationResultKHRDelegate_0>(GetDeferredOperationResultKHRPointer);
			}
			DeferredOperationJoinKHRPointer = GetInstancePrecedureAddress(instance, "vkDeferredOperationJoinKHR");
			if (DeferredOperationJoinKHRPointer != IntPtr.Zero)
			{
				DeferredOperationJoinKHR_0 = Marshal.GetDelegateForFunctionPointer<DeferredOperationJoinKHRDelegate_0>(DeferredOperationJoinKHRPointer);
			}
			CommandSetCullModePointer = GetInstancePrecedureAddress(instance, "vkCmdSetCullMode");
			if (CommandSetCullModePointer != IntPtr.Zero)
			{
				CommandSetCullMode_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCullModeDelegate_0>(CommandSetCullModePointer);
			}
			CommandSetFrontFacePointer = GetInstancePrecedureAddress(instance, "vkCmdSetFrontFace");
			if (CommandSetFrontFacePointer != IntPtr.Zero)
			{
				CommandSetFrontFace_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFrontFaceDelegate_0>(CommandSetFrontFacePointer);
			}
			CommandSetPrimitiveTopologyPointer = GetInstancePrecedureAddress(instance, "vkCmdSetPrimitiveTopology");
			if (CommandSetPrimitiveTopologyPointer != IntPtr.Zero)
			{
				CommandSetPrimitiveTopology_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPrimitiveTopologyDelegate_0>(CommandSetPrimitiveTopologyPointer);
			}
			CommandSetViewportWithCountPointer = GetInstancePrecedureAddress(instance, "vkCmdSetViewportWithCount");
			if (CommandSetViewportWithCountPointer != IntPtr.Zero)
			{
				CommandSetViewportWithCount_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWithCountDelegate_0>(CommandSetViewportWithCountPointer);
			}
			CommandSetScissorWithCountPointer = GetInstancePrecedureAddress(instance, "vkCmdSetScissorWithCount");
			if (CommandSetScissorWithCountPointer != IntPtr.Zero)
			{
				CommandSetScissorWithCount_0 = Marshal.GetDelegateForFunctionPointer<CommandSetScissorWithCountDelegate_0>(CommandSetScissorWithCountPointer);
			}
			CommandBindVertexBuffers2Pointer = GetInstancePrecedureAddress(instance, "vkCmdBindVertexBuffers2");
			if (CommandBindVertexBuffers2Pointer != IntPtr.Zero)
			{
				CommandBindVertexBuffers2_0 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_0>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_1 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_1>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_2 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_2>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_3 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_3>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_4 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_4>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_5 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_5>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_6 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_6>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_7 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_7>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_8 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_8>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_9 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_9>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_10 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_10>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_11 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_11>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_12 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_12>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_13 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_13>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_14 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_14>(CommandBindVertexBuffers2Pointer);
				CommandBindVertexBuffers2_15 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2Delegate_15>(CommandBindVertexBuffers2Pointer);
			}
			CommandSetDepthTestEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthTestEnable");
			if (CommandSetDepthTestEnablePointer != IntPtr.Zero)
			{
				CommandSetDepthTestEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthTestEnableDelegate_0>(CommandSetDepthTestEnablePointer);
			}
			CommandSetDepthWriteEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthWriteEnable");
			if (CommandSetDepthWriteEnablePointer != IntPtr.Zero)
			{
				CommandSetDepthWriteEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthWriteEnableDelegate_0>(CommandSetDepthWriteEnablePointer);
			}
			CommandSetDepthCompareOpPointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthCompareOp");
			if (CommandSetDepthCompareOpPointer != IntPtr.Zero)
			{
				CommandSetDepthCompareOp_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthCompareOpDelegate_0>(CommandSetDepthCompareOpPointer);
			}
			CommandSetDepthBoundsTestEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthBoundsTestEnable");
			if (CommandSetDepthBoundsTestEnablePointer != IntPtr.Zero)
			{
				CommandSetDepthBoundsTestEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBoundsTestEnableDelegate_0>(CommandSetDepthBoundsTestEnablePointer);
			}
			CommandSetStencilTestEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetStencilTestEnable");
			if (CommandSetStencilTestEnablePointer != IntPtr.Zero)
			{
				CommandSetStencilTestEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilTestEnableDelegate_0>(CommandSetStencilTestEnablePointer);
			}
			CommandSetStencilOpPointer = GetInstancePrecedureAddress(instance, "vkCmdSetStencilOp");
			if (CommandSetStencilOpPointer != IntPtr.Zero)
			{
				CommandSetStencilOp_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilOpDelegate_0>(CommandSetStencilOpPointer);
			}
			CommandSetPatchControlPointsEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetPatchControlPointsEXT");
			if (CommandSetPatchControlPointsEXTPointer != IntPtr.Zero)
			{
				CommandSetPatchControlPointsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPatchControlPointsEXTDelegate_0>(CommandSetPatchControlPointsEXTPointer);
			}
			CommandSetRasterizerDiscardEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetRasterizerDiscardEnable");
			if (CommandSetRasterizerDiscardEnablePointer != IntPtr.Zero)
			{
				CommandSetRasterizerDiscardEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetRasterizerDiscardEnableDelegate_0>(CommandSetRasterizerDiscardEnablePointer);
			}
			CommandSetDepthBiasEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetDepthBiasEnable");
			if (CommandSetDepthBiasEnablePointer != IntPtr.Zero)
			{
				CommandSetDepthBiasEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBiasEnableDelegate_0>(CommandSetDepthBiasEnablePointer);
			}
			CommandSetLogicOpEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetLogicOpEXT");
			if (CommandSetLogicOpEXTPointer != IntPtr.Zero)
			{
				CommandSetLogicOpEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLogicOpEXTDelegate_0>(CommandSetLogicOpEXTPointer);
			}
			CommandSetPrimitiveRestartEnablePointer = GetInstancePrecedureAddress(instance, "vkCmdSetPrimitiveRestartEnable");
			if (CommandSetPrimitiveRestartEnablePointer != IntPtr.Zero)
			{
				CommandSetPrimitiveRestartEnable_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPrimitiveRestartEnableDelegate_0>(CommandSetPrimitiveRestartEnablePointer);
			}
			CreatePrivateDataSlotPointer = GetInstancePrecedureAddress(instance, "vkCreatePrivateDataSlot");
			if (CreatePrivateDataSlotPointer != IntPtr.Zero)
			{
				CreatePrivateDataSlot_0 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotDelegate_0>(CreatePrivateDataSlotPointer);
				CreatePrivateDataSlot_1 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotDelegate_1>(CreatePrivateDataSlotPointer);
				CreatePrivateDataSlot_2 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotDelegate_2>(CreatePrivateDataSlotPointer);
				CreatePrivateDataSlot_3 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotDelegate_3>(CreatePrivateDataSlotPointer);
			}
			DestroyPrivateDataSlotPointer = GetInstancePrecedureAddress(instance, "vkDestroyPrivateDataSlot");
			if (DestroyPrivateDataSlotPointer != IntPtr.Zero)
			{
				DestroyPrivateDataSlot_0 = Marshal.GetDelegateForFunctionPointer<DestroyPrivateDataSlotDelegate_0>(DestroyPrivateDataSlotPointer);
				DestroyPrivateDataSlot_1 = Marshal.GetDelegateForFunctionPointer<DestroyPrivateDataSlotDelegate_1>(DestroyPrivateDataSlotPointer);
			}
			SetPrivateDataPointer = GetInstancePrecedureAddress(instance, "vkSetPrivateData");
			if (SetPrivateDataPointer != IntPtr.Zero)
			{
				SetPrivateData_0 = Marshal.GetDelegateForFunctionPointer<SetPrivateDataDelegate_0>(SetPrivateDataPointer);
			}
			GetPrivateDataPointer = GetInstancePrecedureAddress(instance, "vkGetPrivateData");
			if (GetPrivateDataPointer != IntPtr.Zero)
			{
				GetPrivateData_0 = Marshal.GetDelegateForFunctionPointer<GetPrivateDataDelegate_0>(GetPrivateDataPointer);
			}
			CommandCopyBuffer2Pointer = GetInstancePrecedureAddress(instance, "vkCmdCopyBuffer2");
			if (CommandCopyBuffer2Pointer != IntPtr.Zero)
			{
				CommandCopyBuffer2_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBuffer2Delegate_0>(CommandCopyBuffer2Pointer);
				CommandCopyBuffer2_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyBuffer2Delegate_1>(CommandCopyBuffer2Pointer);
			}
			CommandCopyImage2Pointer = GetInstancePrecedureAddress(instance, "vkCmdCopyImage2");
			if (CommandCopyImage2Pointer != IntPtr.Zero)
			{
				CommandCopyImage2_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImage2Delegate_0>(CommandCopyImage2Pointer);
				CommandCopyImage2_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyImage2Delegate_1>(CommandCopyImage2Pointer);
			}
			CommandBlitImage2Pointer = GetInstancePrecedureAddress(instance, "vkCmdBlitImage2");
			if (CommandBlitImage2Pointer != IntPtr.Zero)
			{
				CommandBlitImage2_0 = Marshal.GetDelegateForFunctionPointer<CommandBlitImage2Delegate_0>(CommandBlitImage2Pointer);
				CommandBlitImage2_1 = Marshal.GetDelegateForFunctionPointer<CommandBlitImage2Delegate_1>(CommandBlitImage2Pointer);
			}
			CommandCopyBufferToImage2Pointer = GetInstancePrecedureAddress(instance, "vkCmdCopyBufferToImage2");
			if (CommandCopyBufferToImage2Pointer != IntPtr.Zero)
			{
				CommandCopyBufferToImage2_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImage2Delegate_0>(CommandCopyBufferToImage2Pointer);
				CommandCopyBufferToImage2_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImage2Delegate_1>(CommandCopyBufferToImage2Pointer);
			}
			CommandCopyImageToBuffer2Pointer = GetInstancePrecedureAddress(instance, "vkCmdCopyImageToBuffer2");
			if (CommandCopyImageToBuffer2Pointer != IntPtr.Zero)
			{
				CommandCopyImageToBuffer2_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBuffer2Delegate_0>(CommandCopyImageToBuffer2Pointer);
				CommandCopyImageToBuffer2_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBuffer2Delegate_1>(CommandCopyImageToBuffer2Pointer);
			}
			CommandResolveImage2Pointer = GetInstancePrecedureAddress(instance, "vkCmdResolveImage2");
			if (CommandResolveImage2Pointer != IntPtr.Zero)
			{
				CommandResolveImage2_0 = Marshal.GetDelegateForFunctionPointer<CommandResolveImage2Delegate_0>(CommandResolveImage2Pointer);
				CommandResolveImage2_1 = Marshal.GetDelegateForFunctionPointer<CommandResolveImage2Delegate_1>(CommandResolveImage2Pointer);
			}
			CommandSetFragmentShadingRateKHRPointer = GetInstancePrecedureAddress(instance, "vkCmdSetFragmentShadingRateKHR");
			if (CommandSetFragmentShadingRateKHRPointer != IntPtr.Zero)
			{
				CommandSetFragmentShadingRateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateKHRDelegate_0>(CommandSetFragmentShadingRateKHRPointer);
				CommandSetFragmentShadingRateKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateKHRDelegate_1>(CommandSetFragmentShadingRateKHRPointer);
			}
			GetPhysicalDeviceFragmentShadingRatesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
			if (GetPhysicalDeviceFragmentShadingRatesKHRPointer != IntPtr.Zero)
			{
				GetPhysicalDeviceFragmentShadingRatesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0>(GetPhysicalDeviceFragmentShadingRatesKHRPointer);
				GetPhysicalDeviceFragmentShadingRatesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1>(GetPhysicalDeviceFragmentShadingRatesKHRPointer);
			}
			CommandSetFragmentShadingRateEnumNVPointer = GetInstancePrecedureAddress(instance, "vkCmdSetFragmentShadingRateEnumNV");
			if (CommandSetFragmentShadingRateEnumNVPointer != IntPtr.Zero)
			{
				CommandSetFragmentShadingRateEnumNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateEnumNVDelegate_0>(CommandSetFragmentShadingRateEnumNVPointer);
			}
			GetAccelerationStructureBuildSizesKHRPointer = GetInstancePrecedureAddress(instance, "vkGetAccelerationStructureBuildSizesKHR");
			if (GetAccelerationStructureBuildSizesKHRPointer != IntPtr.Zero)
			{
				GetAccelerationStructureBuildSizesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_0>(GetAccelerationStructureBuildSizesKHRPointer);
				GetAccelerationStructureBuildSizesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_1>(GetAccelerationStructureBuildSizesKHRPointer);
				GetAccelerationStructureBuildSizesKHR_2 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_2>(GetAccelerationStructureBuildSizesKHRPointer);
				GetAccelerationStructureBuildSizesKHR_3 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_3>(GetAccelerationStructureBuildSizesKHRPointer);
			}
			CommandSetVertexInputEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetVertexInputEXT");
			if (CommandSetVertexInputEXTPointer != IntPtr.Zero)
			{
				CommandSetVertexInputEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetVertexInputEXTDelegate_0>(CommandSetVertexInputEXTPointer);
			}
			CommandSetColorWriteEnableEXTPointer = GetInstancePrecedureAddress(instance, "vkCmdSetColorWriteEnableEXT");
			if (CommandSetColorWriteEnableEXTPointer != IntPtr.Zero)
			{
				CommandSetColorWriteEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetColorWriteEnableEXTDelegate_0>(CommandSetColorWriteEnableEXTPointer);
				CommandSetColorWriteEnableEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandSetColorWriteEnableEXTDelegate_1>(CommandSetColorWriteEnableEXTPointer);
			}
			CommandSetEvent2Pointer = GetInstancePrecedureAddress(instance, "vkCmdSetEvent2");
			if (CommandSetEvent2Pointer != IntPtr.Zero)
			{
				CommandSetEvent2_0 = Marshal.GetDelegateForFunctionPointer<CommandSetEvent2Delegate_0>(CommandSetEvent2Pointer);
				CommandSetEvent2_1 = Marshal.GetDelegateForFunctionPointer<CommandSetEvent2Delegate_1>(CommandSetEvent2Pointer);
			}
			CommandResetEvent2Pointer = GetInstancePrecedureAddress(instance, "vkCmdResetEvent2");
			if (CommandResetEvent2Pointer != IntPtr.Zero)
			{
				CommandResetEvent2_0 = Marshal.GetDelegateForFunctionPointer<CommandResetEvent2Delegate_0>(CommandResetEvent2Pointer);
			}
			CommandWaitEvents2Pointer = GetInstancePrecedureAddress(instance, "vkCmdWaitEvents2");
			if (CommandWaitEvents2Pointer != IntPtr.Zero)
			{
				CommandWaitEvents2_0 = Marshal.GetDelegateForFunctionPointer<CommandWaitEvents2Delegate_0>(CommandWaitEvents2Pointer);
			}
			CommandPipelineBarrier2Pointer = GetInstancePrecedureAddress(instance, "vkCmdPipelineBarrier2");
			if (CommandPipelineBarrier2Pointer != IntPtr.Zero)
			{
				CommandPipelineBarrier2_0 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrier2Delegate_0>(CommandPipelineBarrier2Pointer);
				CommandPipelineBarrier2_1 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrier2Delegate_1>(CommandPipelineBarrier2Pointer);
			}
			QueueSubmit2Pointer = GetInstancePrecedureAddress(instance, "vkQueueSubmit2");
			if (QueueSubmit2Pointer != IntPtr.Zero)
			{
				QueueSubmit2_0 = Marshal.GetDelegateForFunctionPointer<QueueSubmit2Delegate_0>(QueueSubmit2Pointer);
			}
			CommandWriteTimestamp2Pointer = GetInstancePrecedureAddress(instance, "vkCmdWriteTimestamp2");
			if (CommandWriteTimestamp2Pointer != IntPtr.Zero)
			{
				CommandWriteTimestamp2_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteTimestamp2Delegate_0>(CommandWriteTimestamp2Pointer);
			}
			CommandWriteBufferMarker2AMDPointer = GetInstancePrecedureAddress(instance, "vkCmdWriteBufferMarker2AMD");
			if (CommandWriteBufferMarker2AMDPointer != IntPtr.Zero)
			{
				CommandWriteBufferMarker2AMD_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteBufferMarker2AMDDelegate_0>(CommandWriteBufferMarker2AMDPointer);
			}
			GetQueueCheckpointData2NVPointer = GetInstancePrecedureAddress(instance, "vkGetQueueCheckpointData2NV");
			if (GetQueueCheckpointData2NVPointer != IntPtr.Zero)
			{
				GetQueueCheckpointData2NV_0 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointData2NVDelegate_0>(GetQueueCheckpointData2NVPointer);
				GetQueueCheckpointData2NV_1 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointData2NVDelegate_1>(GetQueueCheckpointData2NVPointer);
			}
			CreateCuModuleNVXPointer = GetInstancePrecedureAddress(instance, "vkCreateCuModuleNVX");
			if (CreateCuModuleNVXPointer != IntPtr.Zero)
			{
				CreateCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_0>(CreateCuModuleNVXPointer);
				CreateCuModuleNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_1>(CreateCuModuleNVXPointer);
				CreateCuModuleNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_2>(CreateCuModuleNVXPointer);
				CreateCuModuleNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_3>(CreateCuModuleNVXPointer);
			}
			CreateCuFunctionNVXPointer = GetInstancePrecedureAddress(instance, "vkCreateCuFunctionNVX");
			if (CreateCuFunctionNVXPointer != IntPtr.Zero)
			{
				CreateCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_0>(CreateCuFunctionNVXPointer);
				CreateCuFunctionNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_1>(CreateCuFunctionNVXPointer);
				CreateCuFunctionNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_2>(CreateCuFunctionNVXPointer);
				CreateCuFunctionNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_3>(CreateCuFunctionNVXPointer);
			}
			DestroyCuModuleNVXPointer = GetInstancePrecedureAddress(instance, "vkDestroyCuModuleNVX");
			if (DestroyCuModuleNVXPointer != IntPtr.Zero)
			{
				DestroyCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyCuModuleNVXDelegate_0>(DestroyCuModuleNVXPointer);
				DestroyCuModuleNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyCuModuleNVXDelegate_1>(DestroyCuModuleNVXPointer);
			}
			DestroyCuFunctionNVXPointer = GetInstancePrecedureAddress(instance, "vkDestroyCuFunctionNVX");
			if (DestroyCuFunctionNVXPointer != IntPtr.Zero)
			{
				DestroyCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyCuFunctionNVXDelegate_0>(DestroyCuFunctionNVXPointer);
				DestroyCuFunctionNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyCuFunctionNVXDelegate_1>(DestroyCuFunctionNVXPointer);
			}
			CommandCuLaunchKernelNVXPointer = GetInstancePrecedureAddress(instance, "vkCmdCuLaunchKernelNVX");
			if (CommandCuLaunchKernelNVXPointer != IntPtr.Zero)
			{
				CommandCuLaunchKernelNVX_0 = Marshal.GetDelegateForFunctionPointer<CommandCuLaunchKernelNVXDelegate_0>(CommandCuLaunchKernelNVXPointer);
				CommandCuLaunchKernelNVX_1 = Marshal.GetDelegateForFunctionPointer<CommandCuLaunchKernelNVXDelegate_1>(CommandCuLaunchKernelNVXPointer);
			}
			SetDeviceMemoryPriorityEXTPointer = GetInstancePrecedureAddress(instance, "vkSetDeviceMemoryPriorityEXT");
			if (SetDeviceMemoryPriorityEXTPointer != IntPtr.Zero)
			{
				SetDeviceMemoryPriorityEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDeviceMemoryPriorityEXTDelegate_0>(SetDeviceMemoryPriorityEXTPointer);
			}
			AcquireDrmDisplayEXTPointer = GetInstancePrecedureAddress(instance, "vkAcquireDrmDisplayEXT");
			if (AcquireDrmDisplayEXTPointer != IntPtr.Zero)
			{
				AcquireDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireDrmDisplayEXTDelegate_0>(AcquireDrmDisplayEXTPointer);
			}
			GetDrmDisplayEXTPointer = GetInstancePrecedureAddress(instance, "vkGetDrmDisplayEXT");
			if (GetDrmDisplayEXTPointer != IntPtr.Zero)
			{
				GetDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<GetDrmDisplayEXTDelegate_0>(GetDrmDisplayEXTPointer);
			}
			WaitForPresentKHRPointer = GetInstancePrecedureAddress(instance, "vkWaitForPresentKHR");
			if (WaitForPresentKHRPointer != IntPtr.Zero)
			{
				WaitForPresentKHR_0 = Marshal.GetDelegateForFunctionPointer<WaitForPresentKHRDelegate_0>(WaitForPresentKHRPointer);
			}
			CommandBeginRenderingPointer = GetInstancePrecedureAddress(instance, "vkCmdBeginRendering");
			if (CommandBeginRenderingPointer != IntPtr.Zero)
			{
				CommandBeginRendering_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderingDelegate_0>(CommandBeginRenderingPointer);
				CommandBeginRendering_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderingDelegate_1>(CommandBeginRenderingPointer);
			}
			CommandEndRenderingPointer = GetInstancePrecedureAddress(instance, "vkCmdEndRendering");
			if (CommandEndRenderingPointer != IntPtr.Zero)
			{
				CommandEndRendering_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderingDelegate_0>(CommandEndRenderingPointer);
			}
			GetDescriptorSetLayoutHostMappingInfoVALVEPointer = GetInstancePrecedureAddress(instance, "vkGetDescriptorSetLayoutHostMappingInfoVALVE");
			if (GetDescriptorSetLayoutHostMappingInfoVALVEPointer != IntPtr.Zero)
			{
				GetDescriptorSetLayoutHostMappingInfoVALVE_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_0>(GetDescriptorSetLayoutHostMappingInfoVALVEPointer);
				GetDescriptorSetLayoutHostMappingInfoVALVE_1 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutHostMappingInfoVALVEDelegate_1>(GetDescriptorSetLayoutHostMappingInfoVALVEPointer);
			}
			GetDescriptorSetHostMappingVALVEPointer = GetInstancePrecedureAddress(instance, "vkGetDescriptorSetHostMappingVALVE");
			if (GetDescriptorSetHostMappingVALVEPointer != IntPtr.Zero)
			{
				GetDescriptorSetHostMappingVALVE_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetHostMappingVALVEDelegate_0>(GetDescriptorSetHostMappingVALVEPointer);
			}
			GetImageSubresourceLayout2EXTPointer = GetInstancePrecedureAddress(instance, "vkGetImageSubresourceLayout2EXT");
			if (GetImageSubresourceLayout2EXTPointer != IntPtr.Zero)
			{
				GetImageSubresourceLayout2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayout2EXTDelegate_0>(GetImageSubresourceLayout2EXTPointer);
				GetImageSubresourceLayout2EXT_1 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayout2EXTDelegate_1>(GetImageSubresourceLayout2EXTPointer);
			}
			GetPipelinePropertiesEXTPointer = GetInstancePrecedureAddress(instance, "vkGetPipelinePropertiesEXT");
			if (GetPipelinePropertiesEXTPointer != IntPtr.Zero)
			{
				GetPipelinePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPipelinePropertiesEXTDelegate_0>(GetPipelinePropertiesEXTPointer);
				GetPipelinePropertiesEXT_1 = Marshal.GetDelegateForFunctionPointer<GetPipelinePropertiesEXTDelegate_1>(GetPipelinePropertiesEXTPointer);
			}
		}
		public static unsafe VkResult CreateInstance(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_0(createInfo, allocator, out instance);
		public static unsafe VkResult CreateInstance(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_1(createInfo, ref allocator, out instance);
		public static unsafe VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_2(ref createInfo, allocator, out instance);
		public static unsafe VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_3(ref createInfo, ref allocator, out instance);
		public static unsafe void DestroyInstance(VkInstance instance, VkAllocationCallbacks* allocator) => DestroyInstance_0(instance, allocator);
		public static unsafe void DestroyInstance(VkInstance instance, ref VkAllocationCallbacks allocator) => DestroyInstance_1(instance, ref allocator);
		public static unsafe VkResult EnumeratePhysicalDevices(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_0(instance, physicalDeviceCount, physicalDevices);
		public static unsafe VkResult EnumeratePhysicalDevices(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_1(instance, ref physicalDeviceCount, physicalDevices);
		public static unsafe IntPtr GetDevicePrecedureAddress(VkDevice device, byte* name) => GetDevicePrecedureAddress_0(device, name);
		public static unsafe IntPtr GetDevicePrecedureAddress(VkDevice device, string name) => GetDevicePrecedureAddress_1(device, name);
		public static unsafe IntPtr GetInstancePrecedureAddress(VkInstance instance, byte* name) => GetInstancePrecedureAddress_0(instance, name);
		public static unsafe IntPtr GetInstancePrecedureAddress(VkInstance instance, string name) => GetInstancePrecedureAddress_1(instance, name);
		public static unsafe void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties) => GetPhysicalDeviceProperties_0(physicalDevice, out properties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties) => GetPhysicalDeviceMemoryProperties_0(physicalDevice, out memoryProperties);
		public static unsafe void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features) => GetPhysicalDeviceFeatures_0(physicalDevice, out features);
		public static unsafe void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties) => GetPhysicalDeviceFormatProperties_0(physicalDevice, format, out formatProperties);
		public static unsafe VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties) => GetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, out imageFormatProperties);
		public static unsafe VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_0(physicalDevice, createInfo, allocator, out device);
		public static unsafe VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_1(physicalDevice, createInfo, ref allocator, out device);
		public static unsafe VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_2(physicalDevice, ref createInfo, allocator, out device);
		public static unsafe VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_3(physicalDevice, ref createInfo, ref allocator, out device);
		public static unsafe void DestroyDevice(VkDevice device, VkAllocationCallbacks* allocator) => DestroyDevice_0(device, allocator);
		public static unsafe void DestroyDevice(VkDevice device, ref VkAllocationCallbacks allocator) => DestroyDevice_1(device, ref allocator);
		public static unsafe VkResult EnumerateInstanceVersion([In, Out] uint[] apiVersion) => EnumerateInstanceVersion_0(apiVersion);
		public static unsafe VkResult EnumerateInstanceLayerProperties(uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_0(propertyCount, properties);
		public static unsafe VkResult EnumerateInstanceLayerProperties(ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_1(ref propertyCount, properties);
		public static unsafe VkResult EnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_0(layerName, propertyCount, properties);
		public static unsafe VkResult EnumerateInstanceExtensionProperties(byte* layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_1(layerName, ref propertyCount, properties);
		public static unsafe VkResult EnumerateInstanceExtensionProperties(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_2(layerName, propertyCount, properties);
		public static unsafe VkResult EnumerateInstanceExtensionProperties(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_3(layerName, ref propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_1(physicalDevice, ref propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_0(physicalDevice, layerName, propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_1(physicalDevice, layerName, ref propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_2(physicalDevice, layerName, propertyCount, properties);
		public static unsafe VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_3(physicalDevice, layerName, ref propertyCount, properties);
		public static unsafe void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue) => GetDeviceQueue_0(device, queueFamilyIndex, queueIndex, out queue);
		public static unsafe VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence) => QueueSubmit_0(queue, submitCount, submits, fence);
		public static unsafe VkResult QueueWaitIdle(VkQueue queue) => QueueWaitIdle_0(queue);
		public static unsafe VkResult DeviceWaitIdle(VkDevice device) => DeviceWaitIdle_0(device);
		public static unsafe VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_0(device, allocateInfo, allocator, out memory);
		public static unsafe VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_1(device, allocateInfo, ref allocator, out memory);
		public static unsafe VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_2(device, ref allocateInfo, allocator, out memory);
		public static unsafe VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_3(device, ref allocateInfo, ref allocator, out memory);
		public static unsafe void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator) => FreeMemory_0(device, memory, allocator);
		public static unsafe void FreeMemory(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator) => FreeMemory_1(device, memory, ref allocator);
		public static unsafe VkResult MapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, uint flags, void** data) => MapMemory_0(device, memory, offset, size, flags, data);
		public static unsafe void UnmapMemory(VkDevice device, VkDeviceMemory memory) => UnmapMemory_0(device, memory);
		public static unsafe VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => FlushMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
		public static unsafe VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => InvalidateMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
		public static unsafe void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes) => GetDeviceMemoryCommitment_0(device, memory, out committedMemoryInBytes);
		public static unsafe void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements) => GetBufferMemoryRequirements_0(device, buffer, out memoryRequirements);
		public static unsafe VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindBufferMemory_0(device, buffer, memory, memoryOffset);
		public static unsafe void GetImageMemoryRequirements(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements) => GetImageMemoryRequirements_0(device, image, out memoryRequirements);
		public static unsafe VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindImageMemory_0(device, image, memory, memoryOffset);
		public static unsafe void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_0(device, image, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_1(device, image, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_1(physicalDevice, format, type, samples, usage, tiling, ref propertyCount, properties);
		public static unsafe VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence) => QueueBindSparse_0(queue, bindInfoCount, bindInfo, fence);
		public static unsafe VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence) => QueueBindSparse_1(queue, bindInfoCount, ref bindInfo, fence);
		public static unsafe VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_0(device, createInfo, allocator, out fence);
		public static unsafe VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_1(device, createInfo, ref allocator, out fence);
		public static unsafe VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_2(device, ref createInfo, allocator, out fence);
		public static unsafe VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_3(device, ref createInfo, ref allocator, out fence);
		public static unsafe void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator) => DestroyFence_0(device, fence, allocator);
		public static unsafe void DestroyFence(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator) => DestroyFence_1(device, fence, ref allocator);
		public static unsafe VkResult ResetFences(VkDevice device, uint fenceCount, VkFence[] fences) => ResetFences_0(device, fenceCount, fences);
		public static unsafe VkResult GetFenceStatus(VkDevice device, VkFence fence) => GetFenceStatus_0(device, fence);
		public static unsafe VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout) => WaitForFences_0(device, fenceCount, fences, waitAll, timeout);
		public static unsafe VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_0(device, createInfo, allocator, out semaphore);
		public static unsafe VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_1(device, createInfo, ref allocator, out semaphore);
		public static unsafe VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_2(device, ref createInfo, allocator, out semaphore);
		public static unsafe VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_3(device, ref createInfo, ref allocator, out semaphore);
		public static unsafe void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator) => DestroySemaphore_0(device, semaphore, allocator);
		public static unsafe void DestroySemaphore(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator) => DestroySemaphore_1(device, semaphore, ref allocator);
		public static unsafe VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_0(device, createInfo, allocator, out @event);
		public static unsafe VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_1(device, createInfo, ref allocator, out @event);
		public static unsafe VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_2(device, ref createInfo, allocator, out @event);
		public static unsafe VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_3(device, ref createInfo, ref allocator, out @event);
		public static unsafe void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator) => DestroyEvent_0(device, @event, allocator);
		public static unsafe void DestroyEvent(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator) => DestroyEvent_1(device, @event, ref allocator);
		public static unsafe VkResult GetEventStatus(VkDevice device, VkEvent @event) => GetEventStatus_0(device, @event);
		public static unsafe VkResult SetEvent(VkDevice device, VkEvent @event) => SetEvent_0(device, @event);
		public static unsafe VkResult ResetEvent(VkDevice device, VkEvent @event) => ResetEvent_0(device, @event);
		public static unsafe VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_0(device, createInfo, allocator, out queryPool);
		public static unsafe VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_1(device, createInfo, ref allocator, out queryPool);
		public static unsafe VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_2(device, ref createInfo, allocator, out queryPool);
		public static unsafe VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_3(device, ref createInfo, ref allocator, out queryPool);
		public static unsafe void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator) => DestroyQueryPool_0(device, queryPool, allocator);
		public static unsafe void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator) => DestroyQueryPool_1(device, queryPool, ref allocator);
		public static unsafe VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags) => GetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, data, stride, flags);
		public static unsafe void ResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount) => ResetQueryPool_0(device, queryPool, firstQuery, queryCount);
		public static unsafe void ResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount) => ResetQueryPool(device, queryPool, firstQuery, queryCount);
		public static unsafe VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_0(device, createInfo, allocator, out buffer);
		public static unsafe VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_1(device, createInfo, ref allocator, out buffer);
		public static unsafe VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_2(device, ref createInfo, allocator, out buffer);
		public static unsafe VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_3(device, ref createInfo, ref allocator, out buffer);
		public static unsafe void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator) => DestroyBuffer_0(device, buffer, allocator);
		public static unsafe void DestroyBuffer(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator) => DestroyBuffer_1(device, buffer, ref allocator);
		public static unsafe VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_0(device, createInfo, allocator, out view);
		public static unsafe VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_1(device, createInfo, ref allocator, out view);
		public static unsafe VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_2(device, ref createInfo, allocator, out view);
		public static unsafe VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_3(device, ref createInfo, ref allocator, out view);
		public static unsafe void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator) => DestroyBufferView_0(device, bufferView, allocator);
		public static unsafe void DestroyBufferView(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator) => DestroyBufferView_1(device, bufferView, ref allocator);
		public static unsafe VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_0(device, createInfo, allocator, out image);
		public static unsafe VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_1(device, createInfo, ref allocator, out image);
		public static unsafe VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_2(device, ref createInfo, allocator, out image);
		public static unsafe VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_3(device, ref createInfo, ref allocator, out image);
		public static unsafe void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* allocator) => DestroyImage_0(device, image, allocator);
		public static unsafe void DestroyImage(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator) => DestroyImage_1(device, image, ref allocator);
		public static unsafe void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_0(device, image, subresource, out layout);
		public static unsafe void GetImageSubresourceLayout(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_1(device, image, ref subresource, out layout);
		public static unsafe VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_0(device, createInfo, allocator, out view);
		public static unsafe VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_1(device, createInfo, ref allocator, out view);
		public static unsafe VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_2(device, ref createInfo, allocator, out view);
		public static unsafe VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_3(device, ref createInfo, ref allocator, out view);
		public static unsafe void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator) => DestroyImageView_0(device, imageView, allocator);
		public static unsafe void DestroyImageView(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator) => DestroyImageView_1(device, imageView, ref allocator);
		public static unsafe VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_0(device, createInfo, allocator, out shaderModule);
		public static unsafe VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_1(device, createInfo, ref allocator, out shaderModule);
		public static unsafe VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_2(device, ref createInfo, allocator, out shaderModule);
		public static unsafe VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_3(device, ref createInfo, ref allocator, out shaderModule);
		public static unsafe void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator) => DestroyShaderModule_0(device, shaderModule, allocator);
		public static unsafe void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator) => DestroyShaderModule_1(device, shaderModule, ref allocator);
		public static unsafe VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_0(device, createInfo, allocator, out pipelineCache);
		public static unsafe VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_1(device, createInfo, ref allocator, out pipelineCache);
		public static unsafe VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_2(device, ref createInfo, allocator, out pipelineCache);
		public static unsafe VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_3(device, ref createInfo, ref allocator, out pipelineCache);
		public static unsafe void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator) => DestroyPipelineCache_0(device, pipelineCache, allocator);
		public static unsafe void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator) => DestroyPipelineCache_1(device, pipelineCache, ref allocator);
		public static unsafe VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data) => GetPipelineCacheData_0(device, pipelineCache, dataSize, data);
		public static unsafe VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data) => GetPipelineCacheData_1(device, pipelineCache, ref dataSize, data);
		public static unsafe VkResult MergePipelineCaches(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches) => MergePipelineCaches_0(device, destinationCache, sourceCacheCount, sourceCaches);
		public static unsafe VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		public static unsafe VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		public static unsafe VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateComputePipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		public static unsafe VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateComputePipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		public static unsafe VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, out VkExtent2D maxWorkgroupSize) => GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0(device, renderpass, out maxWorkgroupSize);
		public static unsafe void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator) => DestroyPipeline_0(device, pipeline, allocator);
		public static unsafe void DestroyPipeline(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator) => DestroyPipeline_1(device, pipeline, ref allocator);
		public static unsafe VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_0(device, createInfo, allocator, out pipelineLayout);
		public static unsafe VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_1(device, createInfo, ref allocator, out pipelineLayout);
		public static unsafe VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_2(device, ref createInfo, allocator, out pipelineLayout);
		public static unsafe VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_3(device, ref createInfo, ref allocator, out pipelineLayout);
		public static unsafe void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator) => DestroyPipelineLayout_0(device, pipelineLayout, allocator);
		public static unsafe void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator) => DestroyPipelineLayout_1(device, pipelineLayout, ref allocator);
		public static unsafe VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_0(device, createInfo, allocator, out sampler);
		public static unsafe VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_1(device, createInfo, ref allocator, out sampler);
		public static unsafe VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_2(device, ref createInfo, allocator, out sampler);
		public static unsafe VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_3(device, ref createInfo, ref allocator, out sampler);
		public static unsafe void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator) => DestroySampler_0(device, sampler, allocator);
		public static unsafe void DestroySampler(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator) => DestroySampler_1(device, sampler, ref allocator);
		public static unsafe VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_0(device, createInfo, allocator, out setLayout);
		public static unsafe VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_1(device, createInfo, ref allocator, out setLayout);
		public static unsafe VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_2(device, ref createInfo, allocator, out setLayout);
		public static unsafe VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_3(device, ref createInfo, ref allocator, out setLayout);
		public static unsafe void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator) => DestroyDescriptorSetLayout_0(device, descriptorSetLayout, allocator);
		public static unsafe void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator) => DestroyDescriptorSetLayout_1(device, descriptorSetLayout, ref allocator);
		public static unsafe VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_0(device, createInfo, allocator, out descriptorPool);
		public static unsafe VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_1(device, createInfo, ref allocator, out descriptorPool);
		public static unsafe VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_2(device, ref createInfo, allocator, out descriptorPool);
		public static unsafe VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_3(device, ref createInfo, ref allocator, out descriptorPool);
		public static unsafe void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator) => DestroyDescriptorPool_0(device, descriptorPool, allocator);
		public static unsafe void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator) => DestroyDescriptorPool_1(device, descriptorPool, ref allocator);
		public static unsafe VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, uint flags) => ResetDescriptorPool_0(device, descriptorPool, flags);
		public static unsafe VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_0(device, allocateInfo, descriptorSets);
		public static unsafe VkResult AllocateDescriptorSets(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_1(device, ref allocateInfo, descriptorSets);
		public static unsafe VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets) => FreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, descriptorSets);
		public static unsafe void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies) => UpdateDescriptorSets_0(device, descriptorWriteCount, descriptorWrites, descriptorCopyCount, descriptorCopies);
		public static unsafe VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_0(device, createInfo, allocator, out framebuffer);
		public static unsafe VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_1(device, createInfo, ref allocator, out framebuffer);
		public static unsafe VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_2(device, ref createInfo, allocator, out framebuffer);
		public static unsafe VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_3(device, ref createInfo, ref allocator, out framebuffer);
		public static unsafe void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator) => DestroyFramebuffer_0(device, framebuffer, allocator);
		public static unsafe void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator) => DestroyFramebuffer_1(device, framebuffer, ref allocator);
		public static unsafe VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_0(device, createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_1(device, createInfo, ref allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_2(device, ref createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_3(device, ref createInfo, ref allocator, out renderPass);
		public static unsafe void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator) => DestroyRenderPass_0(device, renderPass, allocator);
		public static unsafe void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator) => DestroyRenderPass_1(device, renderPass, ref allocator);
		public static unsafe void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity) => GetRenderAreaGranularity_0(device, renderPass, out granularity);
		public static unsafe VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_0(device, createInfo, allocator, out commandPool);
		public static unsafe VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_1(device, createInfo, ref allocator, out commandPool);
		public static unsafe VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_2(device, ref createInfo, allocator, out commandPool);
		public static unsafe VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_3(device, ref createInfo, ref allocator, out commandPool);
		public static unsafe void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator) => DestroyCommandPool_0(device, commandPool, allocator);
		public static unsafe void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator) => DestroyCommandPool_1(device, commandPool, ref allocator);
		public static unsafe VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags) => ResetCommandPool_0(device, commandPool, flags);
		public static unsafe VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_0(device, allocateInfo, commandBuffers);
		public static unsafe VkResult AllocateCommandBuffers(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_1(device, ref allocateInfo, commandBuffers);
		public static unsafe void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => FreeCommandBuffers_0(device, commandPool, commandBufferCount, commandBuffers);
		public static unsafe VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo) => BeginCommandBuffer_0(commandBuffer, beginInfo);
		public static unsafe VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo) => BeginCommandBuffer_1(commandBuffer, ref beginInfo);
		public static unsafe VkResult EndCommandBuffer(VkCommandBuffer commandBuffer) => EndCommandBuffer_0(commandBuffer);
		public static unsafe VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags) => ResetCommandBuffer_0(commandBuffer, flags);
		public static unsafe void CommandBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline) => CommandBindPipeline_0(commandBuffer, pipelineBindPoint, pipeline);
		public static unsafe void CommandSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports) => CommandSetViewport_0(commandBuffer, firstViewport, viewportCount, viewports);
		public static unsafe void CommandSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors) => CommandSetScissor_0(commandBuffer, firstScissor, scissorCount, scissors);
		public static unsafe void CommandSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth) => CommandSetLineWidth_0(commandBuffer, lineWidth);
		public static unsafe void CommandSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) => CommandSetDepthBias_0(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
		public static unsafe void CommandSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants) => CommandSetBlendConstants_0(commandBuffer, blendConstants);
		public static unsafe void CommandSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds) => CommandSetDepthBounds_0(commandBuffer, minDepthBounds, maxDepthBounds);
		public static unsafe void CommandSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask) => CommandSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
		public static unsafe void CommandSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask) => CommandSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
		public static unsafe void CommandSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference) => CommandSetStencilReference_0(commandBuffer, faceMask, reference);
		public static unsafe void CommandBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets) => CommandBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, descriptorSets, dynamicOffsetCount, dynamicOffsets);
		public static unsafe void CommandBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => CommandBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
		public static unsafe void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, buffers, offsets);
		public static unsafe void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_1(commandBuffer, firstBinding, bindingCount, buffers, ref offsets);
		public static unsafe void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets);
		public static unsafe void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_3(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets);
		public static unsafe void CommandDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) => CommandDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
		public static unsafe void CommandDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) => CommandDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
		public static unsafe void CommandDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* vertexInfo, uint instanceCount, uint firstInstance, uint stride) => CommandDrawMultiEXT_0(commandBuffer, drawCount, vertexInfo, instanceCount, firstInstance, stride);
		public static unsafe void CommandDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT vertexInfo, uint instanceCount, uint firstInstance, uint stride) => CommandDrawMultiEXT_1(commandBuffer, drawCount, ref vertexInfo, instanceCount, firstInstance, stride);
		public static unsafe void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset) => CommandDrawMultiIndexedEXT_0(commandBuffer, drawCount, indexInfo, instanceCount, firstInstance, stride, vertexOffset);
		public static unsafe void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset) => CommandDrawMultiIndexedEXT_1(commandBuffer, drawCount, indexInfo, instanceCount, firstInstance, stride, ref vertexOffset);
		public static unsafe void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset) => CommandDrawMultiIndexedEXT_2(commandBuffer, drawCount, ref indexInfo, instanceCount, firstInstance, stride, vertexOffset);
		public static unsafe void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset) => CommandDrawMultiIndexedEXT_3(commandBuffer, drawCount, ref indexInfo, instanceCount, firstInstance, stride, ref vertexOffset);
		public static unsafe void CommandDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
		public static unsafe void CommandDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
		public static unsafe void CommandDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
		public static unsafe void CommandDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => CommandDispatchIndirect_0(commandBuffer, buffer, offset);
		public static unsafe void CommandSubpassShadingHUAWEI(VkCommandBuffer commandBuffer) => CommandSubpassShadingHUAWEI_0(commandBuffer);
		public static unsafe void CommandCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions) => CommandCopyBuffer_0(commandBuffer, sourceBuffer, destinationBuffer, regionCount, regions);
		public static unsafe void CommandCopyImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions) => CommandCopyImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
		public static unsafe void CommandBlitImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter) => CommandBlitImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions, filter);
		public static unsafe void CommandCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyBufferToImage_0(commandBuffer, sourceBuffer, destinationImage, destinationImageLayout, regionCount, regions);
		public static unsafe void CommandCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyImageToBuffer_0(commandBuffer, sourceImage, sourceImageLayout, destinationBuffer, regionCount, regions);
		public static unsafe void CommandUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data) => CommandUpdateBuffer_0(commandBuffer, destinationBuffer, destinationOffset, dataSize, data);
		public static unsafe void CommandFillBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data) => CommandFillBuffer_0(commandBuffer, destinationBuffer, destinationOffset, size, data);
		public static unsafe void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_0(commandBuffer, image, imageLayout, color, rangeCount, ranges);
		public static unsafe void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_1(commandBuffer, image, imageLayout, ref color, rangeCount, ranges);
		public static unsafe void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_0(commandBuffer, image, imageLayout, depthStencil, rangeCount, ranges);
		public static unsafe void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_1(commandBuffer, image, imageLayout, ref depthStencil, rangeCount, ranges);
		public static unsafe void CommandClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects) => CommandClearAttachments_0(commandBuffer, attachmentCount, attachments, rectCount, rects);
		public static unsafe void CommandResolveImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions) => CommandResolveImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
		public static unsafe void CommandSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandSetEvent_0(commandBuffer, @event, stageMask);
		public static unsafe void CommandResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandResetEvent_0(commandBuffer, @event, stageMask);
		public static unsafe void CommandWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandWaitEvents_0(commandBuffer, eventCount, events, sourceStageMask, destinationStageMask, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
		public static unsafe void CommandPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandPipelineBarrier_0(commandBuffer, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
		public static unsafe void CommandBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags) => CommandBeginQuery_0(commandBuffer, queryPool, query, flags);
		public static unsafe void CommandEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query) => CommandEndQuery_0(commandBuffer, queryPool, query);
		public static unsafe void CommandBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* conditionalRenderingBegin) => CommandBeginConditionalRenderingEXT_0(commandBuffer, conditionalRenderingBegin);
		public static unsafe void CommandBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT conditionalRenderingBegin) => CommandBeginConditionalRenderingEXT_1(commandBuffer, ref conditionalRenderingBegin);
		public static unsafe void CommandEndConditionalRenderingEXT(VkCommandBuffer commandBuffer) => CommandEndConditionalRenderingEXT_0(commandBuffer);
		public static unsafe void CommandResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount) => CommandResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
		public static unsafe void CommandWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
		public static unsafe void CommandCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags) => CommandCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, destinationBuffer, destinationOffset, stride, flags);
		public static unsafe void CommandPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values) => CommandPushConstants_0(commandBuffer, layout, stageFlags, offset, size, values);
		public static unsafe void CommandBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_0(commandBuffer, renderPassBegin, contents);
		public static unsafe void CommandBeginRenderPass(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_1(commandBuffer, ref renderPassBegin, contents);
		public static unsafe void CommandNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents) => CommandNextSubpass_0(commandBuffer, contents);
		public static unsafe void CommandEndRenderPass(VkCommandBuffer commandBuffer) => CommandEndRenderPass_0(commandBuffer);
		public static unsafe void CommandExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => CommandExecuteCommands_0(commandBuffer, commandBufferCount, commandBuffers);
		public static unsafe VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_1(physicalDevice, ref propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_1(physicalDevice, ref propertyCount, properties);
		public static unsafe VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, displayCount, displays);
		public static unsafe VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_1(physicalDevice, planeIndex, ref displayCount, displays);
		public static unsafe VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_0(physicalDevice, display, propertyCount, properties);
		public static unsafe VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_1(physicalDevice, display, ref propertyCount, properties);
		public static unsafe VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_0(physicalDevice, display, createInfo, allocator, out mode);
		public static unsafe VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_1(physicalDevice, display, createInfo, ref allocator, out mode);
		public static unsafe VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_2(physicalDevice, display, ref createInfo, allocator, out mode);
		public static unsafe VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_3(physicalDevice, display, ref createInfo, ref allocator, out mode);
		public static unsafe VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities) => GetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, out capabilities);
		public static unsafe VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_0(device, swapchainCount, createInfos, allocator, out swapchains);
		public static unsafe VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_1(device, swapchainCount, createInfos, ref allocator, out swapchains);
		public static unsafe void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator) => DestroySurfaceKHR_0(instance, surface, allocator);
		public static unsafe void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator) => DestroySurfaceKHR_1(instance, surface, ref allocator);
		public static unsafe VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported) => GetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, out supported);
		public static unsafe VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, out surfaceCapabilities);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_1(physicalDevice, surface, ref surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, presentModeCount, presentModes);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_1(physicalDevice, surface, ref presentModeCount, presentModes);
		public static unsafe VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_0(device, createInfo, allocator, out swapchain);
		public static unsafe VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_1(device, createInfo, ref allocator, out swapchain);
		public static unsafe VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_2(device, ref createInfo, allocator, out swapchain);
		public static unsafe VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_3(device, ref createInfo, ref allocator, out swapchain);
		public static unsafe void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator) => DestroySwapchainKHR_0(device, swapchain, allocator);
		public static unsafe void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator) => DestroySwapchainKHR_1(device, swapchain, ref allocator);
		public static unsafe VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_0(device, swapchain, swapchainImageCount, swapchainImages);
		public static unsafe VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_1(device, swapchain, ref swapchainImageCount, swapchainImages);
		public static unsafe VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex) => AcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, out imageIndex);
		public static unsafe VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* presentInfo) => QueuePresentKHR_0(queue, presentInfo);
		public static unsafe VkResult QueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR presentInfo) => QueuePresentKHR_1(queue, ref presentInfo);
		public static unsafe VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe VkBool32 GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex) => GetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
		public static unsafe VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe VkBool32 GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID) => GetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
		public static unsafe VkBool32 GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref IntPtr dpy, IntPtr visualID) => GetPhysicalDeviceXlibPresentationSupportKHR_1(physicalDevice, queueFamilyIndex, ref dpy, visualID);
		public static unsafe VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_0(instance, createInfo, allocator, out callback);
		public static unsafe VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_1(instance, createInfo, ref allocator, out callback);
		public static unsafe VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_2(instance, ref createInfo, allocator, out callback);
		public static unsafe VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_3(instance, ref createInfo, ref allocator, out callback);
		public static unsafe void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator) => DestroyDebugReportCallbackEXT_0(instance, callback, allocator);
		public static unsafe void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator) => DestroyDebugReportCallbackEXT_1(instance, callback, ref allocator);
		public static unsafe void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message) => DebugReportMessageEXT_0(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
		public static unsafe void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* layerPrefix, string message) => DebugReportMessageEXT_1(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
		public static unsafe void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, byte* message) => DebugReportMessageEXT_2(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
		public static unsafe void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message) => DebugReportMessageEXT_3(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
		public static unsafe VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo) => DebugMarkerSetObjectNameEXT_0(device, nameInfo);
		public static unsafe VkResult DebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo) => DebugMarkerSetObjectNameEXT_1(device, ref nameInfo);
		public static unsafe VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo) => DebugMarkerSetObjectTagEXT_0(device, tagInfo);
		public static unsafe VkResult DebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo) => DebugMarkerSetObjectTagEXT_1(device, ref tagInfo);
		public static unsafe void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerBeginEXT_0(commandBuffer, markerInfo);
		public static unsafe void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerBeginEXT_1(commandBuffer, ref markerInfo);
		public static unsafe void CommandDebugMarkerEndEXT(VkCommandBuffer commandBuffer) => CommandDebugMarkerEndEXT_0(commandBuffer);
		public static unsafe void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerInsertEXT_0(commandBuffer, markerInfo);
		public static unsafe void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerInsertEXT_1(commandBuffer, ref markerInfo);
		public static unsafe VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties) => GetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out externalImageFormatProperties);
		public static unsafe VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle) => GetMemoryWin32HandleNV_0(device, memory, handleType, out handle);
		public static unsafe void CommandExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* generatedCommandsInfo) => CommandExecuteGeneratedCommandsNV_0(commandBuffer, isPreprocessed, generatedCommandsInfo);
		public static unsafe void CommandExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV generatedCommandsInfo) => CommandExecuteGeneratedCommandsNV_1(commandBuffer, isPreprocessed, ref generatedCommandsInfo);
		public static unsafe void CommandPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* generatedCommandsInfo) => CommandPreprocessGeneratedCommandsNV_0(commandBuffer, generatedCommandsInfo);
		public static unsafe void CommandPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV generatedCommandsInfo) => CommandPreprocessGeneratedCommandsNV_1(commandBuffer, ref generatedCommandsInfo);
		public static unsafe void CommandBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex) => CommandBindPipelineShaderGroupNV_0(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
		public static unsafe void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements) => GetGeneratedCommandsMemoryRequirementsNV_0(device, info, out memoryRequirements);
		public static unsafe void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements) => GetGeneratedCommandsMemoryRequirementsNV_1(device, ref info, out memoryRequirements);
		public static unsafe VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_0(device, createInfo, allocator, out indirectCommandsLayout);
		public static unsafe VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_1(device, createInfo, ref allocator, out indirectCommandsLayout);
		public static unsafe VkResult CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_2(device, ref createInfo, allocator, out indirectCommandsLayout);
		public static unsafe VkResult CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_3(device, ref createInfo, ref allocator, out indirectCommandsLayout);
		public static unsafe void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* allocator) => DestroyIndirectCommandsLayoutNV_0(device, indirectCommandsLayout, allocator);
		public static unsafe void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks allocator) => DestroyIndirectCommandsLayoutNV_1(device, indirectCommandsLayout, ref allocator);
		public static unsafe void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 features) => GetPhysicalDeviceFeatures2_0(physicalDevice, out features);
		public static unsafe void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 features) => GetPhysicalDeviceFeatures2(physicalDevice, out features);
		public static unsafe void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 properties) => GetPhysicalDeviceProperties2_0(physicalDevice, out properties);
		public static unsafe void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 properties) => GetPhysicalDeviceProperties2(physicalDevice, out properties);
		public static unsafe void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 formatProperties) => GetPhysicalDeviceFormatProperties2_0(physicalDevice, format, out formatProperties);
		public static unsafe void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 formatProperties) => GetPhysicalDeviceFormatProperties2(physicalDevice, format, out formatProperties);
		public static unsafe VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2_0(physicalDevice, imageFormatInfo, out imageFormatProperties);
		public static unsafe VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2_1(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
		public static unsafe VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2(physicalDevice, imageFormatInfo, out imageFormatProperties);
		public static unsafe VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
		public static unsafe void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 memoryProperties) => GetPhysicalDeviceMemoryProperties2_0(physicalDevice, out memoryProperties);
		public static unsafe void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 memoryProperties) => GetPhysicalDeviceMemoryProperties2(physicalDevice, out memoryProperties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_0(physicalDevice, formatInfo, propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_1(physicalDevice, formatInfo, ref propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_2(physicalDevice, ref formatInfo, propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_3(physicalDevice, ref formatInfo, ref propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, ref propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, ref formatInfo, propertyCount, properties);
		public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, ref formatInfo, ref propertyCount, properties);
		public static unsafe void CommandPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites) => CommandPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, descriptorWrites);
		public static unsafe void TrimCommandPool(VkDevice device, VkCommandPool commandPool, uint flags) => TrimCommandPool_0(device, commandPool, flags);
		public static unsafe void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, uint flags) => TrimCommandPool(device, commandPool, flags);
		public static unsafe void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties_0(physicalDevice, externalBufferInfo, out externalBufferProperties);
		public static unsafe void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfo externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties_1(physicalDevice, ref externalBufferInfo, out externalBufferProperties);
		public static unsafe void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties(physicalDevice, externalBufferInfo, out externalBufferProperties);
		public static unsafe void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfo externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties(physicalDevice, ref externalBufferInfo, out externalBufferProperties);
		public static unsafe VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		public static unsafe VkResult GetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		public static unsafe VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties) => GetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, out memoryWin32HandleProperties);
		public static unsafe VkResult GetMemoryFileDescriptorKHR(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult GetMemoryFileDescriptorKHR(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult GetMemoryFileDescriptorPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties) => GetMemoryFileDescriptorPropertiesKHR_0(device, handleType, fileDescriptor, out memoryFileDescriptorProperties);
		public static unsafe VkResult GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* memoryGetRemoteAddressInfo, void* address) => GetMemoryRemoteAddressNV_0(device, memoryGetRemoteAddressInfo, address);
		public static unsafe VkResult GetMemoryRemoteAddressNV(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV memoryGetRemoteAddressInfo, void* address) => GetMemoryRemoteAddressNV_1(device, ref memoryGetRemoteAddressInfo, address);
		public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties_0(physicalDevice, externalSemaphoreInfo, out externalSemaphoreProperties);
		public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties_1(physicalDevice, ref externalSemaphoreInfo, out externalSemaphoreProperties);
		public static unsafe void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, externalSemaphoreInfo, out externalSemaphoreProperties);
		public static unsafe void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, ref externalSemaphoreInfo, out externalSemaphoreProperties);
		public static unsafe VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		public static unsafe VkResult GetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		public static unsafe VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_0(device, importSemaphoreWin32HandleInfo);
		public static unsafe VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_1(device, ref importSemaphoreWin32HandleInfo);
		public static unsafe VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_0(device, importSemaphoreFileDescriptorInfo);
		public static unsafe VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_1(device, ref importSemaphoreFileDescriptorInfo);
		public static unsafe void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties_0(physicalDevice, externalFenceInfo, out externalFenceProperties);
		public static unsafe void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfo externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties_1(physicalDevice, ref externalFenceInfo, out externalFenceProperties);
		public static unsafe void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties(physicalDevice, externalFenceInfo, out externalFenceProperties);
		public static unsafe void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfo externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties(physicalDevice, ref externalFenceInfo, out externalFenceProperties);
		public static unsafe VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		public static unsafe VkResult GetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		public static unsafe VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_0(device, importFenceWin32HandleInfo);
		public static unsafe VkResult ImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_1(device, ref importFenceWin32HandleInfo);
		public static unsafe VkResult GetFenceFileDescriptorKHR(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult GetFenceFileDescriptorKHR(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		public static unsafe VkResult ImportFenceFileDescriptorKHR(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_0(device, importFenceFileDescriptorInfo);
		public static unsafe VkResult ImportFenceFileDescriptorKHR(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_1(device, ref importFenceFileDescriptorInfo);
		public static unsafe VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => ReleaseDisplayEXT_0(physicalDevice, display);
		public static unsafe VkResult AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => AcquireWinrtDisplayNV_0(physicalDevice, display);
		public static unsafe VkResult GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR display) => GetWinrtDisplayNV_0(physicalDevice, deviceRelativeId, out display);
		public static unsafe VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo) => DisplayPowerControlEXT_0(device, display, displayPowerInfo);
		public static unsafe VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo) => DisplayPowerControlEXT_1(device, display, ref displayPowerInfo);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_0(device, deviceEventInfo, allocator, fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_1(device, deviceEventInfo, allocator, ref fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_2(device, deviceEventInfo, ref allocator, fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_3(device, deviceEventInfo, ref allocator, ref fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_4(device, ref deviceEventInfo, allocator, fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_5(device, ref deviceEventInfo, allocator, ref fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_6(device, ref deviceEventInfo, ref allocator, fence);
		public static unsafe VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_7(device, ref deviceEventInfo, ref allocator, ref fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_0(device, display, displayEventInfo, allocator, fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_1(device, display, displayEventInfo, allocator, ref fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_2(device, display, displayEventInfo, ref allocator, fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_3(device, display, displayEventInfo, ref allocator, ref fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_4(device, display, ref displayEventInfo, allocator, fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_5(device, display, ref displayEventInfo, allocator, ref fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_6(device, display, ref displayEventInfo, ref allocator, fence);
		public static unsafe VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_7(device, display, ref displayEventInfo, ref allocator, ref fence);
		public static unsafe VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue) => GetSwapchainCounterEXT_0(device, swapchain, counter, out counterValue);
		public static unsafe VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, out surfaceCapabilities);
		public static unsafe VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups_0(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
		public static unsafe VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups_1(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
		public static unsafe VkResult EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
		public static unsafe VkResult EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
		public static unsafe void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlags peerMemoryFeatures) => GetDeviceGroupPeerMemoryFeatures_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out peerMemoryFeatures);
		public static unsafe void GetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlags peerMemoryFeatures) => GetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out peerMemoryFeatures);
		public static unsafe VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos) => BindBufferMemory2_0(device, bindInfoCount, bindInfos);
		public static unsafe VkResult BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos) => BindBufferMemory2(device, bindInfoCount, bindInfos);
		public static unsafe VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos) => BindImageMemory2_0(device, bindInfoCount, bindInfos);
		public static unsafe VkResult BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos) => BindImageMemory2(device, bindInfoCount, bindInfos);
		public static unsafe void CommandSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMask_0(commandBuffer, deviceMask);
		public static unsafe void CommandSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMask(commandBuffer, deviceMask);
		public static unsafe VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR deviceGroupPresentCapabilities) => GetDeviceGroupPresentCapabilitiesKHR_0(device, out deviceGroupPresentCapabilities);
		public static unsafe VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModesKHR_0(device, surface, out modes);
		public static unsafe VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* acquireInfo, out uint imageIndex) => AcquireNextImage2KHR_0(device, acquireInfo, out imageIndex);
		public static unsafe VkResult AcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR acquireInfo, out uint imageIndex) => AcquireNextImage2KHR_1(device, ref acquireInfo, out imageIndex);
		public static unsafe void CommandDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBase_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
		public static unsafe void CommandDispatchBaseKHR(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
		public static unsafe VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, rectCount, rects);
		public static unsafe VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHR_1(physicalDevice, surface, ref rectCount, rects);
		public static unsafe VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_0(device, createInfo, allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_1(device, createInfo, ref allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_2(device, ref createInfo, allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_3(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate(device, createInfo, allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate(device, createInfo, ref allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate(device, ref createInfo, allocator, out descriptorUpdateTemplate);
		public static unsafe VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
		public static unsafe void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* allocator) => DestroyDescriptorUpdateTemplate_0(device, descriptorUpdateTemplate, allocator);
		public static unsafe void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, ref VkAllocationCallbacks allocator) => DestroyDescriptorUpdateTemplate_1(device, descriptorUpdateTemplate, ref allocator);
		public static unsafe void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* allocator) => DestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, allocator);
		public static unsafe void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, ref VkAllocationCallbacks allocator) => DestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, ref allocator);
		public static unsafe void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* data) => UpdateDescriptorSetWithTemplate_0(device, descriptorSet, descriptorUpdateTemplate, data);
		public static unsafe void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* data) => UpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, data);
		public static unsafe void CommandPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data) => CommandPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, data);
		public static unsafe void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata) => SetHdrMetadataEXT_0(device, swapchainCount, swapchains, metadata);
		public static unsafe void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata) => SetHdrMetadataEXT_1(device, swapchainCount, swapchains, ref metadata);
		public static unsafe VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => GetSwapchainStatusKHR_0(device, swapchain);
		public static unsafe VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties) => GetRefreshCycleDurationGOOGLE_0(device, swapchain, out displayTimingProperties);
		public static unsafe VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_0(device, swapchain, presentationTimingCount, presentationTimings);
		public static unsafe VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_1(device, swapchain, ref presentationTimingCount, presentationTimings);
		public static unsafe VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings) => CommandSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, viewportWScalings);
		public static unsafe void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings) => CommandSetViewportWScalingNV_1(commandBuffer, firstViewport, viewportCount, ref viewportWScalings);
		public static unsafe void CommandSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles) => CommandSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, discardRectangles);
		public static unsafe void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo) => CommandSetSampleLocationsEXT_0(commandBuffer, sampleLocationsInfo);
		public static unsafe void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo) => CommandSetSampleLocationsEXT_1(commandBuffer, ref sampleLocationsInfo);
		public static unsafe void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties) => GetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, out multisampleProperties);
		public static unsafe VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, surfaceInfo, out surfaceCapabilities);
		public static unsafe VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_1(physicalDevice, ref surfaceInfo, out surfaceCapabilities);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, surfaceInfo, surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_1(physicalDevice, surfaceInfo, ref surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_2(physicalDevice, ref surfaceInfo, surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_3(physicalDevice, ref surfaceInfo, ref surfaceFormatCount, surfaceFormats);
		public static unsafe VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayProperties2KHR[] properties) => GetPhysicalDeviceDisplayProperties2KHR_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayProperties2KHR[] properties) => GetPhysicalDeviceDisplayProperties2KHR_1(physicalDevice, ref propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties) => GetPhysicalDeviceDisplayPlaneProperties2KHR_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties) => GetPhysicalDeviceDisplayPlaneProperties2KHR_1(physicalDevice, ref propertyCount, properties);
		public static unsafe VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties) => GetDisplayModeProperties2KHR_0(physicalDevice, display, propertyCount, properties);
		public static unsafe VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties) => GetDisplayModeProperties2KHR_1(physicalDevice, display, ref propertyCount, properties);
		public static unsafe VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities) => GetDisplayPlaneCapabilities2KHR_0(physicalDevice, displayPlaneInfo, out capabilities);
		public static unsafe VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities) => GetDisplayPlaneCapabilities2KHR_1(physicalDevice, ref displayPlaneInfo, out capabilities);
		public static unsafe void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2_0(device, info, out memoryRequirements);
		public static unsafe void GetBufferMemoryRequirements2(VkDevice device, ref VkBufferMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2_1(device, ref info, out memoryRequirements);
		public static unsafe void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2(device, info, out memoryRequirements);
		public static unsafe void GetBufferMemoryRequirements2KHR(VkDevice device, ref VkBufferMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2(device, ref info, out memoryRequirements);
		public static unsafe void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2_0(device, info, out memoryRequirements);
		public static unsafe void GetImageMemoryRequirements2(VkDevice device, ref VkImageMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2_1(device, ref info, out memoryRequirements);
		public static unsafe void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2(device, info, out memoryRequirements);
		public static unsafe void GetImageMemoryRequirements2KHR(VkDevice device, ref VkImageMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2(device, ref info, out memoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirements_0(device, info, out memoryRequirements);
		public static unsafe void GetDeviceBufferMemoryRequirements(VkDevice device, ref VkDeviceBufferMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirements_1(device, ref info, out memoryRequirements);
		public static unsafe void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, VkDeviceBufferMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirements(device, info, out memoryRequirements);
		public static unsafe void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, ref VkDeviceBufferMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirements(device, ref info, out memoryRequirements);
		public static unsafe void GetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirements_0(device, info, out memoryRequirements);
		public static unsafe void GetDeviceImageMemoryRequirements(VkDevice device, ref VkDeviceImageMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirements_1(device, ref info, out memoryRequirements);
		public static unsafe void GetDeviceImageMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirements(device, info, out memoryRequirements);
		public static unsafe void GetDeviceImageMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirements info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirements(device, ref info, out memoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirements(VkDevice device, ref VkDeviceImageMemoryRequirements info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirements(VkDevice device, ref VkDeviceImageMemoryRequirements info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirements info, uint* sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirements info, ref uint sparseMemoryRequirementCount, VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirements(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
		public static unsafe VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_0(device, createInfo, allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_1(device, createInfo, ref allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_2(device, ref createInfo, allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_3(device, ref createInfo, ref allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion(device, createInfo, allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion(device, createInfo, ref allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion(device, ref createInfo, allocator, out ycbcrConversion);
		public static unsafe VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion(device, ref createInfo, ref allocator, out ycbcrConversion);
		public static unsafe void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* allocator) => DestroySamplerYcbcrConversion_0(device, ycbcrConversion, allocator);
		public static unsafe void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, ref VkAllocationCallbacks allocator) => DestroySamplerYcbcrConversion_1(device, ycbcrConversion, ref allocator);
		public static unsafe void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* allocator) => DestroySamplerYcbcrConversion(device, ycbcrConversion, allocator);
		public static unsafe void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, ref VkAllocationCallbacks allocator) => DestroySamplerYcbcrConversion(device, ycbcrConversion, ref allocator);
		public static unsafe void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* queueInfo, out VkQueue queue) => GetDeviceQueue2_0(device, queueInfo, out queue);
		public static unsafe void GetDeviceQueue2(VkDevice device, ref VkDeviceQueueInfo2 queueInfo, out VkQueue queue) => GetDeviceQueue2_1(device, ref queueInfo, out queue);
		public static unsafe VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_0(device, createInfo, allocator, out validationCache);
		public static unsafe VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_1(device, createInfo, ref allocator, out validationCache);
		public static unsafe VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_2(device, ref createInfo, allocator, out validationCache);
		public static unsafe VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_3(device, ref createInfo, ref allocator, out validationCache);
		public static unsafe void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator) => DestroyValidationCacheEXT_0(device, validationCache, allocator);
		public static unsafe void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator) => DestroyValidationCacheEXT_1(device, validationCache, ref allocator);
		public static unsafe VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data) => GetValidationCacheDataEXT_0(device, validationCache, dataSize, data);
		public static unsafe VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data) => GetValidationCacheDataEXT_1(device, validationCache, ref dataSize, data);
		public static unsafe VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches) => MergeValidationCachesEXT_0(device, destinationCache, sourceCacheCount, sourceCaches);
		public static unsafe void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport_0(device, createInfo, out support);
		public static unsafe void GetDescriptorSetLayoutSupport(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport_1(device, ref createInfo, out support);
		public static unsafe void GetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport(device, createInfo, out support);
		public static unsafe void GetDescriptorSetLayoutSupportKHR(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport(device, ref createInfo, out support);
		public static unsafe VkResult GetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, out int grallocUsage) => GetSwapchainGrallocUsageANDROID_0(device, format, imageUsage, out grallocUsage);
		public static unsafe VkResult GetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, out ulong grallocProducerUsage) => GetSwapchainGrallocUsage2ANDROID_0(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, out grallocProducerUsage);
		public static unsafe VkResult GetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, out ulong grallocProducerUsage) => GetSwapchainGrallocUsage2ANDROID_1(device, format, imageUsage, swapchainImageUsage, ref grallocConsumerUsage, out grallocProducerUsage);
		public static unsafe VkResult AcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFileDescriptor, VkSemaphore semaphore, VkFence fence) => AcquireImageANDROID_0(device, image, nativeFenceFileDescriptor, semaphore, fence);
		public static unsafe VkResult QueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore[] waitSemaphores, VkImage image, int* nativeFenceFileDescriptor) => QueueSignalReleaseImageANDROID_0(queue, waitSemaphoreCount, waitSemaphores, image, nativeFenceFileDescriptor);
		public static unsafe VkResult QueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore[] waitSemaphores, VkImage image, ref int nativeFenceFileDescriptor) => QueueSignalReleaseImageANDROID_1(queue, waitSemaphoreCount, waitSemaphores, image, ref nativeFenceFileDescriptor);
		public static unsafe VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info) => GetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, infoSize, info);
		public static unsafe VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info) => GetShaderInfoAMD_1(device, pipeline, shaderStage, infoType, ref infoSize, info);
		public static unsafe void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable) => SetLocalDimmingAMD_0(device, swapChain, localDimmingEnable);
		public static unsafe VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains) => GetPhysicalDeviceCalibrateableTimeDomainsEXT_0(physicalDevice, timeDomainCount, timeDomains);
		public static unsafe VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains) => GetPhysicalDeviceCalibrateableTimeDomainsEXT_1(physicalDevice, ref timeDomainCount, timeDomains);
		public static unsafe VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ulong* timestamps, out ulong maxDeviation) => GetCalibratedTimestampsEXT_0(device, timestampCount, timestampInfos, timestamps, out maxDeviation);
		public static unsafe VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ref ulong timestamps, out ulong maxDeviation) => GetCalibratedTimestampsEXT_1(device, timestampCount, timestampInfos, ref timestamps, out maxDeviation);
		public static unsafe VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* nameInfo) => SetDebugUtilsObjectNameEXT_0(device, nameInfo);
		public static unsafe VkResult SetDebugUtilsObjectNameEXT(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT nameInfo) => SetDebugUtilsObjectNameEXT_1(device, ref nameInfo);
		public static unsafe VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* tagInfo) => SetDebugUtilsObjectTagEXT_0(device, tagInfo);
		public static unsafe VkResult SetDebugUtilsObjectTagEXT(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT tagInfo) => SetDebugUtilsObjectTagEXT_1(device, ref tagInfo);
		public static unsafe void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo) => QueueBeginDebugUtilsLabelEXT_0(queue, labelInfo);
		public static unsafe void QueueBeginDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo) => QueueBeginDebugUtilsLabelEXT_1(queue, ref labelInfo);
		public static unsafe void QueueEndDebugUtilsLabelEXT(VkQueue queue) => QueueEndDebugUtilsLabelEXT_0(queue);
		public static unsafe void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo) => QueueInsertDebugUtilsLabelEXT_0(queue, labelInfo);
		public static unsafe void QueueInsertDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo) => QueueInsertDebugUtilsLabelEXT_1(queue, ref labelInfo);
		public static unsafe void CommandBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo) => CommandBeginDebugUtilsLabelEXT_0(commandBuffer, labelInfo);
		public static unsafe void CommandBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo) => CommandBeginDebugUtilsLabelEXT_1(commandBuffer, ref labelInfo);
		public static unsafe void CommandEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer) => CommandEndDebugUtilsLabelEXT_0(commandBuffer);
		public static unsafe void CommandInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo) => CommandInsertDebugUtilsLabelEXT_0(commandBuffer, labelInfo);
		public static unsafe void CommandInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo) => CommandInsertDebugUtilsLabelEXT_1(commandBuffer, ref labelInfo);
		public static unsafe VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_0(instance, createInfo, allocator, out messenger);
		public static unsafe VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_1(instance, createInfo, ref allocator, out messenger);
		public static unsafe VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_2(instance, ref createInfo, allocator, out messenger);
		public static unsafe VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_3(instance, ref createInfo, ref allocator, out messenger);
		public static unsafe void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* allocator) => DestroyDebugUtilsMessengerEXT_0(instance, messenger, allocator);
		public static unsafe void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks allocator) => DestroyDebugUtilsMessengerEXT_1(instance, messenger, ref allocator);
		public static unsafe void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData) => SubmitDebugUtilsMessageEXT_0(instance, messageSeverity, messageTypes, callbackData);
		public static unsafe void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT callbackData) => SubmitDebugUtilsMessageEXT_1(instance, messageSeverity, messageTypes, ref callbackData);
		public static unsafe VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties) => GetMemoryHostPointerPropertiesEXT_0(device, handleType, hostPointer, out memoryHostPointerProperties);
		public static unsafe void CommandWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker) => CommandWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, destinationBuffer, destinationOffset, marker);
		public static unsafe VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2_0(device, createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2_1(device, createInfo, ref allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2_2(device, ref createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2_3(device, ref createInfo, ref allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2(device, createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2(device, createInfo, ref allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2KHR(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2(device, ref createInfo, allocator, out renderPass);
		public static unsafe VkResult CreateRenderPass2KHR(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2(device, ref createInfo, ref allocator, out renderPass);
		public static unsafe void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2_0(commandBuffer, renderPassBegin, subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2_1(commandBuffer, renderPassBegin, ref subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2_2(commandBuffer, ref renderPassBegin, subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2_3(commandBuffer, ref renderPassBegin, ref subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2(commandBuffer, renderPassBegin, subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2(commandBuffer, renderPassBegin, ref subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2(commandBuffer, ref renderPassBegin, subpassBeginInfo);
		public static unsafe void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2(commandBuffer, ref renderPassBegin, ref subpassBeginInfo);
		public static unsafe void CommandNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2_0(commandBuffer, subpassBeginInfo, subpassEndInfo);
		public static unsafe void CommandNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2_1(commandBuffer, subpassBeginInfo, ref subpassEndInfo);
		public static unsafe void CommandNextSubpass2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2_2(commandBuffer, ref subpassBeginInfo, subpassEndInfo);
		public static unsafe void CommandNextSubpass2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2_3(commandBuffer, ref subpassBeginInfo, ref subpassEndInfo);
		public static unsafe void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2(commandBuffer, subpassBeginInfo, subpassEndInfo);
		public static unsafe void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2(commandBuffer, subpassBeginInfo, ref subpassEndInfo);
		public static unsafe void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2(commandBuffer, ref subpassBeginInfo, subpassEndInfo);
		public static unsafe void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2(commandBuffer, ref subpassBeginInfo, ref subpassEndInfo);
		public static unsafe void CommandEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* subpassEndInfo) => CommandEndRenderPass2_0(commandBuffer, subpassEndInfo);
		public static unsafe void CommandEndRenderPass2(VkCommandBuffer commandBuffer, ref VkSubpassEndInfo subpassEndInfo) => CommandEndRenderPass2_1(commandBuffer, ref subpassEndInfo);
		public static unsafe void CommandEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfo* subpassEndInfo) => CommandEndRenderPass2(commandBuffer, subpassEndInfo);
		public static unsafe void CommandEndRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassEndInfo subpassEndInfo) => CommandEndRenderPass2(commandBuffer, ref subpassEndInfo);
		public static unsafe VkResult GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, out ulong value) => GetSemaphoreCounterValue_0(device, semaphore, out value);
		public static unsafe VkResult GetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, out ulong value) => GetSemaphoreCounterValue(device, semaphore, out value);
		public static unsafe VkResult WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout) => WaitSemaphores_0(device, waitInfo, timeout);
		public static unsafe VkResult WaitSemaphores(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout) => WaitSemaphores_1(device, ref waitInfo, timeout);
		public static unsafe VkResult WaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout) => WaitSemaphores(device, waitInfo, timeout);
		public static unsafe VkResult WaitSemaphoresKHR(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout) => WaitSemaphores(device, ref waitInfo, timeout);
		public static unsafe VkResult SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* signalInfo) => SignalSemaphore_0(device, signalInfo);
		public static unsafe VkResult SignalSemaphore(VkDevice device, ref VkSemaphoreSignalInfo signalInfo) => SignalSemaphore_1(device, ref signalInfo);
		public static unsafe VkResult SignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfo* signalInfo) => SignalSemaphore(device, signalInfo);
		public static unsafe VkResult SignalSemaphoreKHR(VkDevice device, ref VkSemaphoreSignalInfo signalInfo) => SignalSemaphore(device, ref signalInfo);
		public static unsafe VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr* buffer, out VkAndroidHardwareBufferPropertiesANDROID properties) => GetAndroidHardwareBufferPropertiesANDROID_0(device, buffer, out properties);
		public static unsafe VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, ref IntPtr buffer, out VkAndroidHardwareBufferPropertiesANDROID properties) => GetAndroidHardwareBufferPropertiesANDROID_1(device, ref buffer, out properties);
		public static unsafe VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* info, out IntPtr buffer) => GetMemoryAndroidHardwareBufferANDROID_0(device, info, out buffer);
		public static unsafe VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID info, out IntPtr buffer) => GetMemoryAndroidHardwareBufferANDROID_1(device, ref info, out buffer);
		public static unsafe void CommandDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe void CommandSetCheckpointNV(VkCommandBuffer commandBuffer, void* checkpointMarker) => CommandSetCheckpointNV_0(commandBuffer, checkpointMarker);
		public static unsafe void GetQueueCheckpointDataNV(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData) => GetQueueCheckpointDataNV_0(queue, checkpointDataCount, checkpointData);
		public static unsafe void GetQueueCheckpointDataNV(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData) => GetQueueCheckpointDataNV_1(queue, ref checkpointDataCount, checkpointData);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_0(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_1(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_3(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_4(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_5(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_6(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes);
		public static unsafe void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_7(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes);
		public static unsafe void CommandBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets) => CommandBeginTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
		public static unsafe void CommandBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets) => CommandBeginTransformFeedbackEXT_1(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, ref counterBufferOffsets);
		public static unsafe void CommandEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets) => CommandEndTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
		public static unsafe void CommandEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets) => CommandEndTransformFeedbackEXT_1(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, ref counterBufferOffsets);
		public static unsafe void CommandBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index) => CommandBeginQueryIndexedEXT_0(commandBuffer, queryPool, query, flags, index);
		public static unsafe void CommandEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index) => CommandEndQueryIndexedEXT_0(commandBuffer, queryPool, query, index);
		public static unsafe void CommandDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride) => CommandDrawIndirectByteCountEXT_0(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
		public static unsafe void CommandSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D[] exclusiveScissors) => CommandSetExclusiveScissorNV_0(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, exclusiveScissors);
		public static unsafe void CommandBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => CommandBindShadingRateImageNV_0(commandBuffer, imageView, imageLayout);
		public static unsafe void CommandSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* shadingRatePalettes) => CommandSetViewportShadingRatePaletteNV_0(commandBuffer, firstViewport, viewportCount, shadingRatePalettes);
		public static unsafe void CommandSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV shadingRatePalettes) => CommandSetViewportShadingRatePaletteNV_1(commandBuffer, firstViewport, viewportCount, ref shadingRatePalettes);
		public static unsafe void CommandSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV[] customSampleOrders) => CommandSetCoarseSampleOrderNV_0(commandBuffer, sampleOrderType, customSampleOrderCount, customSampleOrders);
		public static unsafe void CommandDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask) => CommandDrawMeshTasksNV_0(commandBuffer, taskCount, firstTask);
		public static unsafe void CommandDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawMeshTasksIndirectNV_0(commandBuffer, buffer, offset, drawCount, stride);
		public static unsafe void CommandDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawMeshTasksIndirectCountNV_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		public static unsafe VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader) => CompileDeferredNV_0(device, pipeline, shader);
		public static unsafe VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_0(device, createInfo, allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_1(device, createInfo, ref allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_2(device, ref createInfo, allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_3(device, ref createInfo, ref allocator, out accelerationStructure);
		public static unsafe void CommandBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => CommandBindInvocationMaskHUAWEI_0(commandBuffer, imageView, imageLayout);
		public static unsafe void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* allocator) => DestroyAccelerationStructureKHR_0(device, accelerationStructure, allocator);
		public static unsafe void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks allocator) => DestroyAccelerationStructureKHR_1(device, accelerationStructure, ref allocator);
		public static unsafe void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* allocator) => DestroyAccelerationStructureNV_0(device, accelerationStructure, allocator);
		public static unsafe void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks allocator) => DestroyAccelerationStructureNV_1(device, accelerationStructure, ref allocator);
		public static unsafe void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements) => GetAccelerationStructureMemoryRequirementsNV_0(device, info, out memoryRequirements);
		public static unsafe void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements) => GetAccelerationStructureMemoryRequirementsNV_1(device, ref info, out memoryRequirements);
		public static unsafe VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] bindInfos) => BindAccelerationStructureMemoryNV_0(device, bindInfoCount, bindInfos);
		public static unsafe void CommandCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkCopyAccelerationStructureModeKHR mode) => CommandCopyAccelerationStructureNV_0(commandBuffer, destination, source, mode);
		public static unsafe void CommandCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* info) => CommandCopyAccelerationStructureKHR_0(commandBuffer, info);
		public static unsafe void CommandCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR info) => CommandCopyAccelerationStructureKHR_1(commandBuffer, ref info);
		public static unsafe VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* info) => CopyAccelerationStructureKHR_0(device, deferredOperation, info);
		public static unsafe VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR info) => CopyAccelerationStructureKHR_1(device, deferredOperation, ref info);
		public static unsafe void CommandCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* info) => CommandCopyAccelerationStructureToMemoryKHR_0(commandBuffer, info);
		public static unsafe void CommandCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR info) => CommandCopyAccelerationStructureToMemoryKHR_1(commandBuffer, ref info);
		public static unsafe VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* info) => CopyAccelerationStructureToMemoryKHR_0(device, deferredOperation, info);
		public static unsafe VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR info) => CopyAccelerationStructureToMemoryKHR_1(device, deferredOperation, ref info);
		public static unsafe void CommandCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* info) => CommandCopyMemoryToAccelerationStructureKHR_0(commandBuffer, info);
		public static unsafe void CommandCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR info) => CommandCopyMemoryToAccelerationStructureKHR_1(commandBuffer, ref info);
		public static unsafe VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* info) => CopyMemoryToAccelerationStructureKHR_0(device, deferredOperation, info);
		public static unsafe VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR info) => CopyMemoryToAccelerationStructureKHR_1(device, deferredOperation, ref info);
		public static unsafe void CommandWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery) => CommandWriteAccelerationStructuresPropertiesKHR_0(commandBuffer, accelerationStructureCount, accelerationStructures, queryType, queryPool, firstQuery);
		public static unsafe void CommandWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery) => CommandWriteAccelerationStructuresPropertiesNV_0(commandBuffer, accelerationStructureCount, accelerationStructures, queryType, queryPool, firstQuery);
		public static unsafe void CommandBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset) => CommandBuildAccelerationStructureNV_0(commandBuffer, info, instanceData, instanceOffset, update, destination, source, scratch, scratchOffset);
		public static unsafe void CommandBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset) => CommandBuildAccelerationStructureNV_1(commandBuffer, ref info, instanceData, instanceOffset, update, destination, source, scratch, scratchOffset);
		public static unsafe VkResult WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, nuint dataSize, void* data, nuint stride) => WriteAccelerationStructuresPropertiesKHR_0(device, accelerationStructureCount, accelerationStructures, queryType, dataSize, data, stride);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_0(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_1(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_2(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_3(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_4(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_5(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_6(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_7(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_8(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_9(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_10(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_11(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_12(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_13(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_14(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_15(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
		public static unsafe void CommandTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth) => CommandTraceRaysNV_0(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
		public static unsafe VkResult GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
		public static unsafe VkResult GetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingShaderGroupHandlesKHR(device, pipeline, firstGroup, groupCount, dataSize, data);
		public static unsafe VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingCaptureReplayShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
		public static unsafe VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* data) => GetAccelerationStructureHandleNV_0(device, accelerationStructure, dataSize, data);
		public static unsafe VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesNV_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		public static unsafe VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesNV_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		public static unsafe VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesKHR_0(device, deferredOperation, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		public static unsafe VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesKHR_1(device, deferredOperation, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		public static unsafe VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties) => GetPhysicalDeviceCooperativeMatrixPropertiesNV_0(physicalDevice, propertyCount, properties);
		public static unsafe VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties) => GetPhysicalDeviceCooperativeMatrixPropertiesNV_1(physicalDevice, ref propertyCount, properties);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_0(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_1(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_2(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_3(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_4(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_5(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_6(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_7(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_8(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_9(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_10(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_11(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_12(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_13(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_14(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_15(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
		public static unsafe void CommandTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirect2KHR_0(commandBuffer, indirectDeviceAddress);
		public static unsafe void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility) => GetDeviceAccelerationStructureCompatibilityKHR_0(device, versionInfo, out compatibility);
		public static unsafe void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility) => GetDeviceAccelerationStructureCompatibilityKHR_1(device, ref versionInfo, out compatibility);
		public static unsafe VkDeviceSize GetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader) => GetRayTracingShaderGroupStackSizeKHR_0(device, pipeline, group, groupShader);
		public static unsafe void CommandSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize) => CommandSetRayTracingPipelineStackSizeKHR_0(commandBuffer, pipelineStackSize);
		public static unsafe uint GetImageViewHandleNVX(VkDevice device, out VkImageViewHandleInfoNVX info) => GetImageViewHandleNVX_0(device, out info);
		public static unsafe VkResult GetImageViewAddressNVX(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX properties) => GetImageViewAddressNVX_0(device, imageView, out properties);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_0(physicalDevice, surfaceInfo, presentModeCount, presentModes);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_1(physicalDevice, surfaceInfo, ref presentModeCount, presentModes);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_2(physicalDevice, ref surfaceInfo, presentModeCount, presentModes);
		public static unsafe VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_3(physicalDevice, ref surfaceInfo, ref presentModeCount, presentModes);
		public static unsafe VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModes2EXT_0(device, surfaceInfo, out modes);
		public static unsafe VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModes2EXT_1(device, ref surfaceInfo, out modes);
		public static unsafe VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => AcquireFullScreenExclusiveModeEXT_0(device, swapchain);
		public static unsafe VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => ReleaseFullScreenExclusiveModeEXT_0(device, swapchain);
		public static unsafe VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions) => EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0(physicalDevice, queueFamilyIndex, counterCount, counters, counterDescriptions);
		public static unsafe VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions) => EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1(physicalDevice, queueFamilyIndex, ref counterCount, counters, counterDescriptions);
		public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* performanceQueryCreateInfo, out uint numPasses) => GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0(physicalDevice, performanceQueryCreateInfo, out numPasses);
		public static unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR performanceQueryCreateInfo, out uint numPasses) => GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1(physicalDevice, ref performanceQueryCreateInfo, out numPasses);
		public static unsafe VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* info) => AcquireProfilingLockKHR_0(device, info);
		public static unsafe VkResult AcquireProfilingLockKHR(VkDevice device, ref VkAcquireProfilingLockInfoKHR info) => AcquireProfilingLockKHR_1(device, ref info);
		public static unsafe void ReleaseProfilingLockKHR(VkDevice device) => ReleaseProfilingLockKHR_0(device);
		public static unsafe VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT properties) => GetImageDrmFormatModifierPropertiesEXT_0(device, image, out properties);
		public static unsafe ulong GetBufferOpaqueCaptureAddress(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferOpaqueCaptureAddress_0(device, out info);
		public static unsafe ulong GetBufferOpaqueCaptureAddressKHR(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferOpaqueCaptureAddress(device, out info);
		public static unsafe VkDeviceAddress GetBufferDeviceAddress(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferDeviceAddress_0(device, out info);
		public static unsafe VkDeviceAddress GetBufferDeviceAddressKHR(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferDeviceAddress(device, out info);
		public static unsafe VkDeviceAddress GetBufferDeviceAddressEXT(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferDeviceAddress(device, out info);
		public static unsafe VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_0(instance, createInfo, allocator, out surface);
		public static unsafe VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_1(instance, createInfo, ref allocator, out surface);
		public static unsafe VkResult CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_2(instance, ref createInfo, allocator, out surface);
		public static unsafe VkResult CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_3(instance, ref createInfo, ref allocator, out surface);
		public static unsafe VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations) => GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0(physicalDevice, combinationCount, combinations);
		public static unsafe VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations) => GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1(physicalDevice, ref combinationCount, combinations);
		public static unsafe VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* initializeInfo) => InitializePerformanceApiINTEL_0(device, initializeInfo);
		public static unsafe VkResult InitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfoINTEL initializeInfo) => InitializePerformanceApiINTEL_1(device, ref initializeInfo);
		public static unsafe void UninitializePerformanceApiINTEL(VkDevice device) => UninitializePerformanceApiINTEL_0(device);
		public static unsafe VkResult CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* markerInfo) => CommandSetPerformanceMarkerINTEL_0(commandBuffer, markerInfo);
		public static unsafe VkResult CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL markerInfo) => CommandSetPerformanceMarkerINTEL_1(commandBuffer, ref markerInfo);
		public static unsafe VkResult CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* markerInfo) => CommandSetPerformanceStreamMarkerINTEL_0(commandBuffer, markerInfo);
		public static unsafe VkResult CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL markerInfo) => CommandSetPerformanceStreamMarkerINTEL_1(commandBuffer, ref markerInfo);
		public static unsafe VkResult CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* overrideInfo) => CommandSetPerformanceOverrideINTEL_0(commandBuffer, overrideInfo);
		public static unsafe VkResult CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL overrideInfo) => CommandSetPerformanceOverrideINTEL_1(commandBuffer, ref overrideInfo);
		public static unsafe VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, VkPerformanceConfigurationINTEL* configuration) => AcquirePerformanceConfigurationINTEL_0(device, acquireInfo, configuration);
		public static unsafe VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, ref VkPerformanceConfigurationINTEL configuration) => AcquirePerformanceConfigurationINTEL_1(device, acquireInfo, ref configuration);
		public static unsafe VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, VkPerformanceConfigurationINTEL* configuration) => AcquirePerformanceConfigurationINTEL_2(device, ref acquireInfo, configuration);
		public static unsafe VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, ref VkPerformanceConfigurationINTEL configuration) => AcquirePerformanceConfigurationINTEL_3(device, ref acquireInfo, ref configuration);
		public static unsafe VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration) => ReleasePerformanceConfigurationINTEL_0(device, configuration);
		public static unsafe VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration) => QueueSetPerformanceConfigurationINTEL_0(queue, configuration);
		public static unsafe VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL value) => GetPerformanceParameterINTEL_0(device, parameter, out value);
		public static unsafe ulong GetDeviceMemoryOpaqueCaptureAddress(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfo info) => GetDeviceMemoryOpaqueCaptureAddress_0(device, out info);
		public static unsafe ulong GetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfo info) => GetDeviceMemoryOpaqueCaptureAddress(device, out info);
		public static unsafe VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_0(device, pipelineInfo, executableCount, properties);
		public static unsafe VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_1(device, pipelineInfo, ref executableCount, properties);
		public static unsafe VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_2(device, ref pipelineInfo, executableCount, properties);
		public static unsafe VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_3(device, ref pipelineInfo, ref executableCount, properties);
		public static unsafe VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_0(device, executableInfo, statisticCount, statistics);
		public static unsafe VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_1(device, executableInfo, ref statisticCount, statistics);
		public static unsafe VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_2(device, ref executableInfo, statisticCount, statistics);
		public static unsafe VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_3(device, ref executableInfo, ref statisticCount, statistics);
		public static unsafe VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_0(device, executableInfo, internalRepresentationCount, internalRepresentations);
		public static unsafe VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_1(device, executableInfo, ref internalRepresentationCount, internalRepresentations);
		public static unsafe VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_2(device, ref executableInfo, internalRepresentationCount, internalRepresentations);
		public static unsafe VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_3(device, ref executableInfo, ref internalRepresentationCount, internalRepresentations);
		public static unsafe void CommandSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern) => CommandSetLineStippleEXT_0(commandBuffer, lineStippleFactor, lineStipplePattern);
		public static unsafe VkResult GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* toolCount, out VkPhysicalDeviceToolProperties toolProperties) => GetPhysicalDeviceToolProperties_0(physicalDevice, toolCount, out toolProperties);
		public static unsafe VkResult GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, ref uint toolCount, out VkPhysicalDeviceToolProperties toolProperties) => GetPhysicalDeviceToolProperties_1(physicalDevice, ref toolCount, out toolProperties);
		public static unsafe VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* toolCount, [In, Out] VkPhysicalDeviceToolProperties[] toolProperties) => GetPhysicalDeviceToolProperties(physicalDevice, toolCount, toolProperties);
		public static unsafe VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, ref uint toolCount, [In, Out] VkPhysicalDeviceToolProperties[] toolProperties) => GetPhysicalDeviceToolProperties(physicalDevice, ref toolCount, toolProperties);
		public static unsafe VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_0(device, createInfo, allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_1(device, createInfo, ref allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_2(device, ref createInfo, allocator, out accelerationStructure);
		public static unsafe VkResult CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_3(device, ref createInfo, ref allocator, out accelerationStructure);
		public static unsafe void CommandBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] pBuildRangeInfos) => CommandBuildAccelerationStructuresKHR_0(commandBuffer, infoCount, infos, pBuildRangeInfos);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_0(commandBuffer, infoCount, infos, indirectDeviceAddresses, indirectStrides, maxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, ref uint pMaxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_1(commandBuffer, infoCount, infos, indirectDeviceAddresses, indirectStrides, ref pMaxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_2(commandBuffer, infoCount, infos, indirectDeviceAddresses, ref indirectStrides, maxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, ref uint pMaxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_3(commandBuffer, infoCount, infos, indirectDeviceAddresses, ref indirectStrides, ref pMaxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_4(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, indirectStrides, maxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, ref uint pMaxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_5(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, indirectStrides, ref pMaxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_6(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, ref indirectStrides, maxPrimitiveCounts);
		public static unsafe void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, ref uint pMaxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_7(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, ref indirectStrides, ref pMaxPrimitiveCounts);
		public static unsafe VkResult BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] pBuildRangeInfos) => BuildAccelerationStructuresKHR_0(device, deferredOperation, infoCount, infos, pBuildRangeInfos);
		public static unsafe VkDeviceAddress GetAccelerationStructureDeviceAddressKHR(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR info) => GetAccelerationStructureDeviceAddressKHR_0(device, out info);
		public static unsafe VkResult CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* allocator, out VkDeferredOperationKHR deferredOperation) => CreateDeferredOperationKHR_0(device, allocator, out deferredOperation);
		public static unsafe VkResult CreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks allocator, out VkDeferredOperationKHR deferredOperation) => CreateDeferredOperationKHR_1(device, ref allocator, out deferredOperation);
		public static unsafe void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* allocator) => DestroyDeferredOperationKHR_0(device, operation, allocator);
		public static unsafe void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks allocator) => DestroyDeferredOperationKHR_1(device, operation, ref allocator);
		public static unsafe uint GetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation) => GetDeferredOperationMaxConcurrencyKHR_0(device, operation);
		public static unsafe VkResult GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation) => GetDeferredOperationResultKHR_0(device, operation);
		public static unsafe VkResult DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation) => DeferredOperationJoinKHR_0(device, operation);
		public static unsafe void CommandSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode) => CommandSetCullMode_0(commandBuffer, cullMode);
		public static unsafe void CommandSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode) => CommandSetCullMode(commandBuffer, cullMode);
		public static unsafe void CommandSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace) => CommandSetFrontFace_0(commandBuffer, frontFace);
		public static unsafe void CommandSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace) => CommandSetFrontFace(commandBuffer, frontFace);
		public static unsafe void CommandSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology) => CommandSetPrimitiveTopology_0(commandBuffer, primitiveTopology);
		public static unsafe void CommandSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology) => CommandSetPrimitiveTopology(commandBuffer, primitiveTopology);
		public static unsafe void CommandSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport[] viewports) => CommandSetViewportWithCount_0(commandBuffer, viewportCount, viewports);
		public static unsafe void CommandSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport[] viewports) => CommandSetViewportWithCount(commandBuffer, viewportCount, viewports);
		public static unsafe void CommandSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D[] scissors) => CommandSetScissorWithCount_0(commandBuffer, scissorCount, scissors);
		public static unsafe void CommandSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D[] scissors) => CommandSetScissorWithCount(commandBuffer, scissorCount, scissors);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_0(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_1(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_2(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_3(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_4(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_5(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_6(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_7(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_8(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_9(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_10(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_11(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_12(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_13(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2_14(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2_15(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, ref strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, strides);
		public static unsafe void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, ref strides);
		public static unsafe void CommandSetDepthTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable) => CommandSetDepthTestEnable_0(commandBuffer, depthTestEnable);
		public static unsafe void CommandSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable) => CommandSetDepthTestEnable(commandBuffer, depthTestEnable);
		public static unsafe void CommandSetDepthWriteEnable(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable) => CommandSetDepthWriteEnable_0(commandBuffer, depthWriteEnable);
		public static unsafe void CommandSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable) => CommandSetDepthWriteEnable(commandBuffer, depthWriteEnable);
		public static unsafe void CommandSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp) => CommandSetDepthCompareOp_0(commandBuffer, depthCompareOp);
		public static unsafe void CommandSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp) => CommandSetDepthCompareOp(commandBuffer, depthCompareOp);
		public static unsafe void CommandSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable) => CommandSetDepthBoundsTestEnable_0(commandBuffer, depthBoundsTestEnable);
		public static unsafe void CommandSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable) => CommandSetDepthBoundsTestEnable(commandBuffer, depthBoundsTestEnable);
		public static unsafe void CommandSetStencilTestEnable(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable) => CommandSetStencilTestEnable_0(commandBuffer, stencilTestEnable);
		public static unsafe void CommandSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable) => CommandSetStencilTestEnable(commandBuffer, stencilTestEnable);
		public static unsafe void CommandSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp) => CommandSetStencilOp_0(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
		public static unsafe void CommandSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp) => CommandSetStencilOp(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
		public static unsafe void CommandSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints) => CommandSetPatchControlPointsEXT_0(commandBuffer, patchControlPoints);
		public static unsafe void CommandSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable) => CommandSetRasterizerDiscardEnable_0(commandBuffer, rasterizerDiscardEnable);
		public static unsafe void CommandSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable) => CommandSetRasterizerDiscardEnable(commandBuffer, rasterizerDiscardEnable);
		public static unsafe void CommandSetDepthBiasEnable(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable) => CommandSetDepthBiasEnable_0(commandBuffer, depthBiasEnable);
		public static unsafe void CommandSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable) => CommandSetDepthBiasEnable(commandBuffer, depthBiasEnable);
		public static unsafe void CommandSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp) => CommandSetLogicOpEXT_0(commandBuffer, logicOp);
		public static unsafe void CommandSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable) => CommandSetPrimitiveRestartEnable_0(commandBuffer, primitiveRestartEnable);
		public static unsafe void CommandSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable) => CommandSetPrimitiveRestartEnable(commandBuffer, primitiveRestartEnable);
		public static unsafe VkResult CreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot_0(device, createInfo, allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot_1(device, createInfo, ref allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlot(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot_2(device, ref createInfo, allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlot(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot_3(device, ref createInfo, ref allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot(device, createInfo, allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot(device, createInfo, ref allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot(device, ref createInfo, allocator, out privateDataSlot);
		public static unsafe VkResult CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlot privateDataSlot) => CreatePrivateDataSlot(device, ref createInfo, ref allocator, out privateDataSlot);
		public static unsafe void DestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* allocator) => DestroyPrivateDataSlot_0(device, privateDataSlot, allocator);
		public static unsafe void DestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, ref VkAllocationCallbacks allocator) => DestroyPrivateDataSlot_1(device, privateDataSlot, ref allocator);
		public static unsafe void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* allocator) => DestroyPrivateDataSlot(device, privateDataSlot, allocator);
		public static unsafe void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlot privateDataSlot, ref VkAllocationCallbacks allocator) => DestroyPrivateDataSlot(device, privateDataSlot, ref allocator);
		public static unsafe VkResult SetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data) => SetPrivateData_0(device, objectType, objectHandle, privateDataSlot, data);
		public static unsafe VkResult SetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data) => SetPrivateData(device, objectType, objectHandle, privateDataSlot, data);
		public static unsafe void GetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, out ulong data) => GetPrivateData_0(device, objectType, objectHandle, privateDataSlot, out data);
		public static unsafe void GetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, out ulong data) => GetPrivateData(device, objectType, objectHandle, privateDataSlot, out data);
		public static unsafe void CommandCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* copyBufferInfo) => CommandCopyBuffer2_0(commandBuffer, copyBufferInfo);
		public static unsafe void CommandCopyBuffer2(VkCommandBuffer commandBuffer, ref VkCopyBufferInfo2 copyBufferInfo) => CommandCopyBuffer2_1(commandBuffer, ref copyBufferInfo);
		public static unsafe void CommandCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* copyBufferInfo) => CommandCopyBuffer2(commandBuffer, copyBufferInfo);
		public static unsafe void CommandCopyBuffer2KHR(VkCommandBuffer commandBuffer, ref VkCopyBufferInfo2 copyBufferInfo) => CommandCopyBuffer2(commandBuffer, ref copyBufferInfo);
		public static unsafe void CommandCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* copyImageInfo) => CommandCopyImage2_0(commandBuffer, copyImageInfo);
		public static unsafe void CommandCopyImage2(VkCommandBuffer commandBuffer, ref VkCopyImageInfo2 copyImageInfo) => CommandCopyImage2_1(commandBuffer, ref copyImageInfo);
		public static unsafe void CommandCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2* copyImageInfo) => CommandCopyImage2(commandBuffer, copyImageInfo);
		public static unsafe void CommandCopyImage2KHR(VkCommandBuffer commandBuffer, ref VkCopyImageInfo2 copyImageInfo) => CommandCopyImage2(commandBuffer, ref copyImageInfo);
		public static unsafe void CommandBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* blitImageInfo) => CommandBlitImage2_0(commandBuffer, blitImageInfo);
		public static unsafe void CommandBlitImage2(VkCommandBuffer commandBuffer, ref VkBlitImageInfo2 blitImageInfo) => CommandBlitImage2_1(commandBuffer, ref blitImageInfo);
		public static unsafe void CommandBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2* blitImageInfo) => CommandBlitImage2(commandBuffer, blitImageInfo);
		public static unsafe void CommandBlitImage2KHR(VkCommandBuffer commandBuffer, ref VkBlitImageInfo2 blitImageInfo) => CommandBlitImage2(commandBuffer, ref blitImageInfo);
		public static unsafe void CommandCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* copyBufferToImageInfo) => CommandCopyBufferToImage2_0(commandBuffer, copyBufferToImageInfo);
		public static unsafe void CommandCopyBufferToImage2(VkCommandBuffer commandBuffer, ref VkCopyBufferToImageInfo2 copyBufferToImageInfo) => CommandCopyBufferToImage2_1(commandBuffer, ref copyBufferToImageInfo);
		public static unsafe void CommandCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* copyBufferToImageInfo) => CommandCopyBufferToImage2(commandBuffer, copyBufferToImageInfo);
		public static unsafe void CommandCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, ref VkCopyBufferToImageInfo2 copyBufferToImageInfo) => CommandCopyBufferToImage2(commandBuffer, ref copyBufferToImageInfo);
		public static unsafe void CommandCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* copyImageToBufferInfo) => CommandCopyImageToBuffer2_0(commandBuffer, copyImageToBufferInfo);
		public static unsafe void CommandCopyImageToBuffer2(VkCommandBuffer commandBuffer, ref VkCopyImageToBufferInfo2 copyImageToBufferInfo) => CommandCopyImageToBuffer2_1(commandBuffer, ref copyImageToBufferInfo);
		public static unsafe void CommandCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* copyImageToBufferInfo) => CommandCopyImageToBuffer2(commandBuffer, copyImageToBufferInfo);
		public static unsafe void CommandCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, ref VkCopyImageToBufferInfo2 copyImageToBufferInfo) => CommandCopyImageToBuffer2(commandBuffer, ref copyImageToBufferInfo);
		public static unsafe void CommandResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* resolveImageInfo) => CommandResolveImage2_0(commandBuffer, resolveImageInfo);
		public static unsafe void CommandResolveImage2(VkCommandBuffer commandBuffer, ref VkResolveImageInfo2 resolveImageInfo) => CommandResolveImage2_1(commandBuffer, ref resolveImageInfo);
		public static unsafe void CommandResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2* resolveImageInfo) => CommandResolveImage2(commandBuffer, resolveImageInfo);
		public static unsafe void CommandResolveImage2KHR(VkCommandBuffer commandBuffer, ref VkResolveImageInfo2 resolveImageInfo) => CommandResolveImage2(commandBuffer, ref resolveImageInfo);
		public static unsafe void CommandSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateKHR_0(commandBuffer, fragmentSize, combinerOps);
		public static unsafe void CommandSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, ref VkExtent2D fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateKHR_1(commandBuffer, ref fragmentSize, combinerOps);
		public static unsafe VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates) => GetPhysicalDeviceFragmentShadingRatesKHR_0(physicalDevice, fragmentShadingRateCount, fragmentShadingRates);
		public static unsafe VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates) => GetPhysicalDeviceFragmentShadingRatesKHR_1(physicalDevice, ref fragmentShadingRateCount, fragmentShadingRates);
		public static unsafe void CommandSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateEnumNV_0(commandBuffer, shadingRate, combinerOps);
		public static unsafe void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, uint* maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo) => GetAccelerationStructureBuildSizesKHR_0(device, buildType, buildInfo, maxPrimitiveCounts, sizeInfo);
		public static unsafe void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, ref uint maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo) => GetAccelerationStructureBuildSizesKHR_1(device, buildType, buildInfo, ref maxPrimitiveCounts, sizeInfo);
		public static unsafe void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, uint* maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo) => GetAccelerationStructureBuildSizesKHR_2(device, buildType, ref buildInfo, maxPrimitiveCounts, sizeInfo);
		public static unsafe void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, ref uint maxPrimitiveCounts, [In, Out] VkAccelerationStructureBuildSizesInfoKHR[] sizeInfo) => GetAccelerationStructureBuildSizesKHR_3(device, buildType, ref buildInfo, ref maxPrimitiveCounts, sizeInfo);
		public static unsafe void CommandSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT[] vertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT[] vertexAttributeDescriptions) => CommandSetVertexInputEXT_0(commandBuffer, vertexBindingDescriptionCount, vertexBindingDescriptions, vertexAttributeDescriptionCount, vertexAttributeDescriptions);
		public static unsafe void CommandSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* colorWriteEnables) => CommandSetColorWriteEnableEXT_0(commandBuffer, attachmentCount, colorWriteEnables);
		public static unsafe void CommandSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 colorWriteEnables) => CommandSetColorWriteEnableEXT_1(commandBuffer, attachmentCount, ref colorWriteEnables);
		public static unsafe void CommandSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* dependencyInfo) => CommandSetEvent2_0(commandBuffer, @event, dependencyInfo);
		public static unsafe void CommandSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, ref VkDependencyInfo dependencyInfo) => CommandSetEvent2_1(commandBuffer, @event, ref dependencyInfo);
		public static unsafe void CommandSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* dependencyInfo) => CommandSetEvent2(commandBuffer, @event, dependencyInfo);
		public static unsafe void CommandSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, ref VkDependencyInfo dependencyInfo) => CommandSetEvent2(commandBuffer, @event, ref dependencyInfo);
		public static unsafe void CommandResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask) => CommandResetEvent2_0(commandBuffer, @event, stageMask);
		public static unsafe void CommandResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask) => CommandResetEvent2(commandBuffer, @event, stageMask);
		public static unsafe void CommandWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkDependencyInfo[] dependencyInfos) => CommandWaitEvents2_0(commandBuffer, eventCount, events, dependencyInfos);
		public static unsafe void CommandWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkDependencyInfo[] dependencyInfos) => CommandWaitEvents2(commandBuffer, eventCount, events, dependencyInfos);
		public static unsafe void CommandPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* dependencyInfo) => CommandPipelineBarrier2_0(commandBuffer, dependencyInfo);
		public static unsafe void CommandPipelineBarrier2(VkCommandBuffer commandBuffer, ref VkDependencyInfo dependencyInfo) => CommandPipelineBarrier2_1(commandBuffer, ref dependencyInfo);
		public static unsafe void CommandPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfo* dependencyInfo) => CommandPipelineBarrier2(commandBuffer, dependencyInfo);
		public static unsafe void CommandPipelineBarrier2KHR(VkCommandBuffer commandBuffer, ref VkDependencyInfo dependencyInfo) => CommandPipelineBarrier2(commandBuffer, ref dependencyInfo);
		public static unsafe VkResult QueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2[] submits, VkFence fence) => QueueSubmit2_0(queue, submitCount, submits, fence);
		public static unsafe VkResult QueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2[] submits, VkFence fence) => QueueSubmit2(queue, submitCount, submits, fence);
		public static unsafe void CommandWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp2_0(commandBuffer, stage, queryPool, query);
		public static unsafe void CommandWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp2(commandBuffer, stage, queryPool, query);
		public static unsafe void CommandWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker) => CommandWriteBufferMarker2AMD_0(commandBuffer, stage, destinationBuffer, destinationOffset, marker);
		public static unsafe void GetQueueCheckpointData2NV(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData) => GetQueueCheckpointData2NV_0(queue, checkpointDataCount, checkpointData);
		public static unsafe void GetQueueCheckpointData2NV(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData) => GetQueueCheckpointData2NV_1(queue, ref checkpointDataCount, checkpointData);
		public static unsafe VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_0(device, createInfo, allocator, out module);
		public static unsafe VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_1(device, createInfo, ref allocator, out module);
		public static unsafe VkResult CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_2(device, ref createInfo, allocator, out module);
		public static unsafe VkResult CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_3(device, ref createInfo, ref allocator, out module);
		public static unsafe VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_0(device, createInfo, allocator, out function);
		public static unsafe VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_1(device, createInfo, ref allocator, out function);
		public static unsafe VkResult CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_2(device, ref createInfo, allocator, out function);
		public static unsafe VkResult CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_3(device, ref createInfo, ref allocator, out function);
		public static unsafe void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* allocator) => DestroyCuModuleNVX_0(device, module, allocator);
		public static unsafe void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks allocator) => DestroyCuModuleNVX_1(device, module, ref allocator);
		public static unsafe void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* allocator) => DestroyCuFunctionNVX_0(device, function, allocator);
		public static unsafe void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks allocator) => DestroyCuFunctionNVX_1(device, function, ref allocator);
		public static unsafe void CommandCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* launchInfo) => CommandCuLaunchKernelNVX_0(commandBuffer, launchInfo);
		public static unsafe void CommandCuLaunchKernelNVX(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX launchInfo) => CommandCuLaunchKernelNVX_1(commandBuffer, ref launchInfo);
		public static unsafe void SetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority) => SetDeviceMemoryPriorityEXT_0(device, memory, priority);
		public static unsafe VkResult AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, VkDisplayKHR display) => AcquireDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, display);
		public static unsafe VkResult GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, uint connectorId, out VkDisplayKHR display) => GetDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, connectorId, out display);
		public static unsafe VkResult WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout) => WaitForPresentKHR_0(device, swapchain, presentId, timeout);
		public static unsafe void CommandBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* renderingInfo) => CommandBeginRendering_0(commandBuffer, renderingInfo);
		public static unsafe void CommandBeginRendering(VkCommandBuffer commandBuffer, ref VkRenderingInfo renderingInfo) => CommandBeginRendering_1(commandBuffer, ref renderingInfo);
		public static unsafe void CommandBeginRenderingKHR(VkCommandBuffer commandBuffer, VkRenderingInfo* renderingInfo) => CommandBeginRendering(commandBuffer, renderingInfo);
		public static unsafe void CommandBeginRenderingKHR(VkCommandBuffer commandBuffer, ref VkRenderingInfo renderingInfo) => CommandBeginRendering(commandBuffer, ref renderingInfo);
		public static unsafe void CommandEndRendering(VkCommandBuffer commandBuffer) => CommandEndRendering_0(commandBuffer);
		public static unsafe void CommandEndRenderingKHR(VkCommandBuffer commandBuffer) => CommandEndRendering(commandBuffer);
		public static unsafe void GetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* bindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE hostMapping) => GetDescriptorSetLayoutHostMappingInfoVALVE_0(device, bindingReference, out hostMapping);
		public static unsafe void GetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE bindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE hostMapping) => GetDescriptorSetLayoutHostMappingInfoVALVE_1(device, ref bindingReference, out hostMapping);
		public static unsafe void GetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** data) => GetDescriptorSetHostMappingVALVE_0(device, descriptorSet, data);
		public static unsafe void GetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* subresource, out VkSubresourceLayout2EXT layout) => GetImageSubresourceLayout2EXT_0(device, image, subresource, out layout);
		public static unsafe void GetImageSubresourceLayout2EXT(VkDevice device, VkImage image, ref VkImageSubresource2EXT subresource, out VkSubresourceLayout2EXT layout) => GetImageSubresourceLayout2EXT_1(device, image, ref subresource, out layout);
		public static unsafe VkResult GetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoEXT* pipelineInfo, out VkBaseOutStructure pipelineProperties) => GetPipelinePropertiesEXT_0(device, pipelineInfo, out pipelineProperties);
		public static unsafe VkResult GetPipelinePropertiesEXT(VkDevice device, ref VkPipelineInfoEXT pipelineInfo, out VkBaseOutStructure pipelineProperties) => GetPipelinePropertiesEXT_1(device, ref pipelineInfo, out pipelineProperties);
	}
}
