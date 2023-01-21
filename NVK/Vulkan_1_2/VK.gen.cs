// This file was generated, don't manually edit
namespace Vulkan_1_2;

public static unsafe class VK
{
	public const UInt VK_UUID_SIZE = 16;
	public const UInt VK_ATTACHMENT_UNUSED = (~0U);
	public const UInt VK_FALSE = 0;
	public const Single VK_LOD_CLAMP_NONE = 1000.0F;
	public const UInt VK_QUEUE_FAMILY_IGNORED = (~0U);
	public const UInt VK_REMAINING_ARRAY_LAYERS = (~0U);
	public const UInt VK_REMAINING_MIP_LEVELS = (~0U);
	public const UInt VK_SUBPASS_EXTERNAL = (~0U);
	public const UInt VK_TRUE = 1;
	public const ULong VK_WHOLE_SIZE = (~0ULL);
	public const UInt VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;
	public const UInt VK_MAX_MEMORY_TYPES = 32;
	public const UInt VK_MAX_MEMORY_HEAPS = 16;
	public const UInt VK_MAX_EXTENSION_NAME_SIZE = 256;
	public const UInt VK_MAX_DESCRIPTION_SIZE = 256;
	public const UInt VK_MAX_DEVICE_GROUP_SIZE = 32;
	public const UInt VK_LUID_SIZE = 8;
	public const UInt VK_QUEUE_FAMILY_EXTERNAL = (~1U);
	public const UInt VK_MAX_DRIVER_NAME_SIZE = 256;
	public const UInt VK_MAX_DRIVER_INFO_SIZE = 256;
	public const UInt VK_KHR_SURFACE_SPEC_VERSION = 25;
	public const String VK_KHR_SURFACE_EXTENSION_NAME = "VK_KHR_surface";
	public const UInt VK_KHR_SWAPCHAIN_SPEC_VERSION = 70;
	public const String VK_KHR_SWAPCHAIN_EXTENSION_NAME = "VK_KHR_swapchain";
	public const UInt VK_KHR_DISPLAY_SPEC_VERSION = 23;
	public const String VK_KHR_DISPLAY_EXTENSION_NAME = "VK_KHR_display";
	public const UInt VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = 10;
	public const String VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME = "VK_KHR_display_swapchain";
	public const UInt VK_KHR_XLIB_SURFACE_SPEC_VERSION = 6;
	public const String VK_KHR_XLIB_SURFACE_EXTENSION_NAME = "VK_KHR_xlib_surface";
	public const UInt VK_KHR_XCB_SURFACE_SPEC_VERSION = 6;
	public const String VK_KHR_XCB_SURFACE_EXTENSION_NAME = "VK_KHR_xcb_surface";
	public const UInt VK_KHR_WAYLAND_SURFACE_SPEC_VERSION = 6;
	public const String VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME = "VK_KHR_wayland_surface";
	public const UInt VK_KHR_ANDROID_SURFACE_SPEC_VERSION = 6;
	public const String VK_KHR_ANDROID_SURFACE_EXTENSION_NAME = "VK_KHR_android_surface";
	public const UInt VK_KHR_WIN32_SURFACE_SPEC_VERSION = 6;
	public const String VK_KHR_WIN32_SURFACE_EXTENSION_NAME = "VK_KHR_win32_surface";
	public const UInt VK_EXT_DEBUG_REPORT_SPEC_VERSION = 10;
	public const String VK_EXT_DEBUG_REPORT_EXTENSION_NAME = "VK_EXT_debug_report";
	public const UInt VK_NV_GLSL_SHADER_SPEC_VERSION = 1;
	public const String VK_NV_GLSL_SHADER_EXTENSION_NAME = "VK_NV_glsl_shader";
	public const UInt VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = 1;
	public const String VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME = "VK_EXT_depth_range_unrestricted";
	public const UInt VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION = 3;
	public const String VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME = "VK_KHR_sampler_mirror_clamp_to_edge";
	public const UInt VK_IMG_FILTER_CUBIC_SPEC_VERSION = 1;
	public const String VK_IMG_FILTER_CUBIC_EXTENSION_NAME = "VK_IMG_filter_cubic";
	public const UInt VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = 1;
	public const String VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME = "VK_AMD_rasterization_order";
	public const UInt VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME = "VK_AMD_shader_trinary_minmax";
	public const UInt VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME = "VK_AMD_shader_explicit_vertex_parameter";
	public const UInt VK_EXT_DEBUG_MARKER_SPEC_VERSION = 4;
	public const String VK_EXT_DEBUG_MARKER_EXTENSION_NAME = "VK_EXT_debug_marker";
	public const UInt VK_AMD_GCN_SHADER_SPEC_VERSION = 1;
	public const String VK_AMD_GCN_SHADER_EXTENSION_NAME = "VK_AMD_gcn_shader";
	public const UInt VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION = 1;
	public const String VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME = "VK_NV_dedicated_allocation";
	public const UInt VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION = 1;
	public const String VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME = "VK_EXT_transform_feedback";
	public const UInt VK_NVX_BINARY_IMPORT_SPEC_VERSION = 1;
	public const String VK_NVX_BINARY_IMPORT_EXTENSION_NAME = "VK_NVX_binary_import";
	public const UInt VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = 2;
	public const String VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME = "VK_NVX_image_view_handle";
	public const UInt VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION = 2;
	public const String VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME = "VK_AMD_draw_indirect_count";
	public const UInt VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;
	public const String VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME = "VK_AMD_negative_viewport_height";
	public const UInt VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = 2;
	public const String VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME = "VK_AMD_gpu_shader_half_float";
	public const UInt VK_AMD_SHADER_BALLOT_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_BALLOT_EXTENSION_NAME = "VK_AMD_shader_ballot";
	public const UInt VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION = 1;
	public const String VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME = "VK_AMD_texture_gather_bias_lod";
	public const UInt VK_AMD_SHADER_INFO_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_INFO_EXTENSION_NAME = "VK_AMD_shader_info";
	public const UInt VK_KHR_DYNAMIC_RENDERING_SPEC_VERSION = 1;
	public const String VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME = "VK_KHR_dynamic_rendering";
	public const UInt VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME = "VK_AMD_shader_image_load_store_lod";
	public const UInt VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = 2;
	public const String VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME = "VK_NV_corner_sampled_image";
	public const UInt VK_KHR_MULTIVIEW_SPEC_VERSION = 1;
	public const String VK_KHR_MULTIVIEW_EXTENSION_NAME = "VK_KHR_multiview";
	public const UInt VK_IMG_FORMAT_PVRTC_SPEC_VERSION = 1;
	public const String VK_IMG_FORMAT_PVRTC_EXTENSION_NAME = "VK_IMG_format_pvrtc";
	public const UInt VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;
	public const String VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = "VK_NV_external_memory_capabilities";
	public const UInt VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = 1;
	public const String VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_NV_external_memory";
	public const UInt VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;
	public const String VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = "VK_NV_external_memory_win32";
	public const UInt VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = 2;
	public const String VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME = "VK_NV_win32_keyed_mutex";
	public const UInt VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = 2;
	public const String VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME = "VK_KHR_get_physical_device_properties2";
	public const UInt VK_KHR_DEVICE_GROUP_SPEC_VERSION = 4;
	public const String VK_KHR_DEVICE_GROUP_EXTENSION_NAME = "VK_KHR_device_group";
	public const UInt VK_EXT_VALIDATION_FLAGS_SPEC_VERSION = 2;
	public const String VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME = "VK_EXT_validation_flags";
	public const UInt VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME = "VK_KHR_shader_draw_parameters";
	public const UInt VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME = "VK_EXT_shader_subgroup_ballot";
	public const UInt VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME = "VK_EXT_shader_subgroup_vote";
	public const UInt VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION = 1;
	public const String VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME = "VK_EXT_texture_compression_astc_hdr";
	public const UInt VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION = 1;
	public const String VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME = "VK_EXT_astc_decode_mode";
	public const UInt VK_KHR_MAINTENANCE_1_SPEC_VERSION = 2;
	public const String VK_KHR_MAINTENANCE_1_EXTENSION_NAME = "VK_KHR_maintenance1";
	[Obsolete("Use VK_KHR_MAINTENANCE_1_SPEC_VERSION")]
	public const UInt VK_KHR_MAINTENANCE1_SPEC_VERSION = VK_KHR_MAINTENANCE_1_SPEC_VERSION;
	[Obsolete("Use VK_KHR_MAINTENANCE_1_EXTENSION_NAME")]
	public const UInt VK_KHR_MAINTENANCE1_EXTENSION_NAME = VK_KHR_MAINTENANCE_1_EXTENSION_NAME;
	[Obsolete("Use VK_MAX_DEVICE_GROUP_SIZE")]
	public const UInt VK_MAX_DEVICE_GROUP_SIZE_KHR = VK_MAX_DEVICE_GROUP_SIZE;
	public const UInt VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = 1;
	public const String VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME = "VK_KHR_device_group_creation";
	[Obsolete("Use VK_LUID_SIZE")]
	public const UInt VK_LUID_SIZE_KHR = VK_LUID_SIZE;
	public const UInt VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = "VK_KHR_external_memory_capabilities";
	[Obsolete("Use VK_QUEUE_FAMILY_EXTERNAL")]
	public const UInt VK_QUEUE_FAMILY_EXTERNAL_KHR = VK_QUEUE_FAMILY_EXTERNAL;
	public const UInt VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_KHR_external_memory";
	public const UInt VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = "VK_KHR_external_memory_win32";
	public const UInt VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME = "VK_KHR_external_memory_fd";
	public const UInt VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = 1;
	public const String VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME = "VK_KHR_win32_keyed_mutex";
	public const UInt VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME = "VK_KHR_external_semaphore_capabilities";
	public const UInt VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME = "VK_KHR_external_semaphore";
	public const UInt VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME = "VK_KHR_external_semaphore_win32";
	public const UInt VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME = "VK_KHR_external_semaphore_fd";
	public const UInt VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = 2;
	public const String VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME = "VK_KHR_push_descriptor";
	public const UInt VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = 2;
	public const String VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME = "VK_EXT_conditional_rendering";
	public const UInt VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME = "VK_KHR_shader_float16_int8";
	public const UInt VK_KHR_16BIT_STORAGE_SPEC_VERSION = 1;
	public const String VK_KHR_16BIT_STORAGE_EXTENSION_NAME = "VK_KHR_16bit_storage";
	public const UInt VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 2;
	public const String VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME = "VK_KHR_incremental_present";
	public const UInt VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION = 1;
	public const String VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME = "VK_KHR_descriptor_update_template";
	public const UInt VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = 1;
	public const String VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME = "VK_NV_clip_space_w_scaling";
	public const UInt VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = 1;
	public const String VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME = "VK_EXT_direct_mode_display";
	public const UInt VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION = 1;
	public const String VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME = "VK_EXT_display_surface_counter";
	public const UInt VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = 1;
	public const String VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME = "VK_EXT_display_control";
	public const UInt VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION = 1;
	public const String VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME = "VK_GOOGLE_display_timing";
	public const UInt VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = 1;
	public const String VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME = "VK_NV_sample_mask_override_coverage";
	public const UInt VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION = 1;
	public const String VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME = "VK_NV_geometry_shader_passthrough";
	public const UInt VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION = 1;
	public const String VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME = "VK_NV_viewport_array2";
	[Obsolete("Use VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION")]
	public const UInt VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION = VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION;
	[Obsolete("Use VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME")]
	public const UInt VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME = VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME;
	public const UInt VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = 1;
	public const String VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME = "VK_NVX_multiview_per_view_attributes";
	public const UInt VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION = 1;
	public const String VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME = "VK_NV_viewport_swizzle";
	public const UInt VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = 1;
	public const String VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME = "VK_EXT_discard_rectangles";
	public const UInt VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION = 1;
	public const String VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME = "VK_EXT_conservative_rasterization";
	public const UInt VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION = 1;
	public const String VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME = "VK_EXT_depth_clip_enable";
	public const UInt VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = 4;
	public const String VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME = "VK_EXT_swapchain_colorspace";
	public const UInt VK_EXT_HDR_METADATA_SPEC_VERSION = 2;
	public const String VK_EXT_HDR_METADATA_EXTENSION_NAME = "VK_EXT_hdr_metadata";
	public const UInt VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = 1;
	public const String VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME = "VK_KHR_imageless_framebuffer";
	public const UInt VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = 1;
	public const String VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME = "VK_KHR_create_renderpass2";
	public const UInt VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = 1;
	public const String VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME = "VK_KHR_shared_presentable_image";
	public const UInt VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME = "VK_KHR_external_fence_capabilities";
	public const UInt VK_KHR_EXTERNAL_FENCE_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME = "VK_KHR_external_fence";
	public const UInt VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME = "VK_KHR_external_fence_win32";
	public const UInt VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = 1;
	public const String VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME = "VK_KHR_external_fence_fd";
	public const UInt VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = 1;
	public const String VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME = "VK_KHR_performance_query";
	public const UInt VK_KHR_MAINTENANCE_2_SPEC_VERSION = 1;
	public const String VK_KHR_MAINTENANCE_2_EXTENSION_NAME = "VK_KHR_maintenance2";
	[Obsolete("Use VK_KHR_MAINTENANCE_2_SPEC_VERSION")]
	public const UInt VK_KHR_MAINTENANCE2_SPEC_VERSION = VK_KHR_MAINTENANCE_2_SPEC_VERSION;
	[Obsolete("Use VK_KHR_MAINTENANCE_2_EXTENSION_NAME")]
	public const UInt VK_KHR_MAINTENANCE2_EXTENSION_NAME = VK_KHR_MAINTENANCE_2_EXTENSION_NAME;
	public const UInt VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = 1;
	public const String VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME = "VK_KHR_get_surface_capabilities2";
	public const UInt VK_KHR_VARIABLE_POINTERS_SPEC_VERSION = 1;
	public const String VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME = "VK_KHR_variable_pointers";
	public const UInt VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = 1;
	public const String VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME = "VK_KHR_get_display_properties2";
	public const UInt VK_MVK_MACOS_SURFACE_SPEC_VERSION = 3;
	public const String VK_MVK_MACOS_SURFACE_EXTENSION_NAME = "VK_MVK_macos_surface";
	public const UInt VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = 1;
	public const String VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME = "VK_EXT_external_memory_dma_buf";
	public const UInt VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);
	public const UInt VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = 1;
	public const String VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME = "VK_EXT_queue_family_foreign";
	public const UInt VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION = 3;
	public const String VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME = "VK_KHR_dedicated_allocation";
	public const UInt VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;
	public const String VK_EXT_DEBUG_UTILS_EXTENSION_NAME = "VK_EXT_debug_utils";
	public const UInt VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = 4;
	public const String VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME = "VK_ANDROID_external_memory_android_hardware_buffer";
	public const UInt VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = 2;
	public const String VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME = "VK_EXT_sampler_filter_minmax";
	public const UInt VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION = 1;
	public const String VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME = "VK_KHR_storage_buffer_storage_class";
	public const UInt VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = 2;
	public const String VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME = "VK_AMD_gpu_shader_int16";
	public const UInt VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION = 1;
	public const String VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME = "VK_AMD_mixed_attachment_samples";
	public const UInt VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME = "VK_AMD_shader_fragment_mask";
	public const UInt VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = 1;
	public const String VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME = "VK_EXT_inline_uniform_block";
	public const UInt VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME = "VK_EXT_shader_stencil_export";
	public const UInt VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = 1;
	public const String VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME = "VK_EXT_sample_locations";
	public const UInt VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION = 1;
	public const String VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME = "VK_KHR_relaxed_block_layout";
	public const UInt VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = 1;
	public const String VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME = "VK_KHR_get_memory_requirements2";
	public const UInt VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION = 1;
	public const String VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME = "VK_KHR_image_format_list";
	public const UInt VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION = 2;
	public const String VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME = "VK_EXT_blend_operation_advanced";
	public const UInt VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION = 1;
	public const String VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME = "VK_NV_fragment_coverage_to_color";
	public const UInt VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = 13;
	public const String VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME = "VK_KHR_acceleration_structure";
	public const UInt VK_SHADER_UNUSED_KHR = (~0U);
	public const UInt VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION = 1;
	public const String VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME = "VK_KHR_ray_tracing_pipeline";
	public const UInt VK_KHR_RAY_QUERY_SPEC_VERSION = 1;
	public const String VK_KHR_RAY_QUERY_EXTENSION_NAME = "VK_KHR_ray_query";
	public const UInt VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION = 1;
	public const String VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME = "VK_NV_framebuffer_mixed_samples";
	public const UInt VK_NV_FILL_RECTANGLE_SPEC_VERSION = 1;
	public const String VK_NV_FILL_RECTANGLE_EXTENSION_NAME = "VK_NV_fill_rectangle";
	public const UInt VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION = 1;
	public const String VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME = "VK_NV_shader_sm_builtins";
	public const UInt VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = 1;
	public const String VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME = "VK_EXT_post_depth_coverage";
	public const UInt VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = 14;
	public const String VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME = "VK_KHR_sampler_ycbcr_conversion";
	public const UInt VK_KHR_BIND_MEMORY_2_SPEC_VERSION = 1;
	public const String VK_KHR_BIND_MEMORY_2_EXTENSION_NAME = "VK_KHR_bind_memory2";
	public const UInt VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = 2;
	public const String VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME = "VK_EXT_image_drm_format_modifier";
	public const UInt VK_EXT_VALIDATION_CACHE_SPEC_VERSION = 1;
	public const String VK_EXT_VALIDATION_CACHE_EXTENSION_NAME = "VK_EXT_validation_cache";
	public const UInt VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = 2;
	public const String VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME = "VK_EXT_descriptor_indexing";
	public const UInt VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME = "VK_EXT_shader_viewport_index_layer";
	public const UInt VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = 3;
	public const String VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME = "VK_NV_shading_rate_image";
	[Obsolete("Use VK_SHADER_UNUSED_KHR")]
	public const UInt VK_SHADER_UNUSED_NV = VK_SHADER_UNUSED_KHR;
	public const UInt VK_NV_RAY_TRACING_SPEC_VERSION = 3;
	public const String VK_NV_RAY_TRACING_EXTENSION_NAME = "VK_NV_ray_tracing";
	public const UInt VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION = 2;
	public const String VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME = "VK_NV_representative_fragment_test";
	public const UInt VK_KHR_MAINTENANCE_3_SPEC_VERSION = 1;
	public const String VK_KHR_MAINTENANCE_3_EXTENSION_NAME = "VK_KHR_maintenance3";
	[Obsolete("Use VK_KHR_MAINTENANCE_3_SPEC_VERSION")]
	public const UInt VK_KHR_MAINTENANCE3_SPEC_VERSION = VK_KHR_MAINTENANCE_3_SPEC_VERSION;
	[Obsolete("Use VK_KHR_MAINTENANCE_3_EXTENSION_NAME")]
	public const UInt VK_KHR_MAINTENANCE3_EXTENSION_NAME = VK_KHR_MAINTENANCE_3_EXTENSION_NAME;
	public const UInt VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = 1;
	public const String VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME = "VK_KHR_draw_indirect_count";
	public const UInt VK_EXT_FILTER_CUBIC_SPEC_VERSION = 3;
	public const String VK_EXT_FILTER_CUBIC_EXTENSION_NAME = "VK_EXT_filter_cubic";
	public const UInt VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION = 4;
	public const String VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME = "VK_QCOM_render_pass_shader_resolve";
	public const UInt VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION = 2;
	public const String VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME = "VK_EXT_global_priority";
	public const UInt VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME = "VK_KHR_shader_subgroup_extended_types";
	public const UInt VK_KHR_8BIT_STORAGE_SPEC_VERSION = 1;
	public const String VK_KHR_8BIT_STORAGE_EXTENSION_NAME = "VK_KHR_8bit_storage";
	public const UInt VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = 1;
	public const String VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME = "VK_EXT_external_memory_host";
	public const UInt VK_AMD_BUFFER_MARKER_SPEC_VERSION = 1;
	public const String VK_AMD_BUFFER_MARKER_EXTENSION_NAME = "VK_AMD_buffer_marker";
	public const UInt VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME = "VK_KHR_shader_atomic_int64";
	public const UInt VK_KHR_SHADER_CLOCK_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_CLOCK_EXTENSION_NAME = "VK_KHR_shader_clock";
	public const UInt VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION = 1;
	public const String VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME = "VK_AMD_pipeline_compiler_control";
	public const UInt VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 2;
	public const String VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME = "VK_EXT_calibrated_timestamps";
	public const UInt VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION = 2;
	public const String VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME = "VK_AMD_shader_core_properties";
	public const UInt VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = 1;
	public const String VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME = "VK_AMD_memory_overallocation_behavior";
	public const UInt VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = 3;
	public const String VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME = "VK_EXT_vertex_attribute_divisor";
	public const UInt VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION = 1;
	public const String VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME = "VK_EXT_pipeline_creation_feedback";
	[Obsolete("Use VK_MAX_DRIVER_NAME_SIZE")]
	public const UInt VK_MAX_DRIVER_NAME_SIZE_KHR = VK_MAX_DRIVER_NAME_SIZE;
	[Obsolete("Use VK_MAX_DRIVER_INFO_SIZE")]
	public const UInt VK_MAX_DRIVER_INFO_SIZE_KHR = VK_MAX_DRIVER_INFO_SIZE;
	public const UInt VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = 1;
	public const String VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME = "VK_KHR_driver_properties";
	public const UInt VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION = 4;
	public const String VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME = "VK_KHR_shader_float_controls";
	public const UInt VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION = 1;
	public const String VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME = "VK_NV_shader_subgroup_partitioned";
	public const UInt VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = 1;
	public const String VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME = "VK_KHR_depth_stencil_resolve";
	public const UInt VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = 1;
	public const String VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME = "VK_KHR_swapchain_mutable_format";
	public const UInt VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = 1;
	public const String VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME = "VK_NV_compute_shader_derivatives";
	public const UInt VK_NV_MESH_SHADER_SPEC_VERSION = 1;
	public const String VK_NV_MESH_SHADER_EXTENSION_NAME = "VK_NV_mesh_shader";
	public const UInt VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;
	public const String VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME = "VK_NV_fragment_shader_barycentric";
	public const UInt VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION = 2;
	public const String VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME = "VK_NV_shader_image_footprint";
	public const UInt VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = 1;
	public const String VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME = "VK_NV_scissor_exclusive";
	public const UInt VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = 2;
	public const String VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME = "VK_NV_device_diagnostic_checkpoints";
	public const UInt VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION = 2;
	public const String VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME = "VK_KHR_timeline_semaphore";
	public const UInt VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION = 1;
	public const String VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME = "VK_INTEL_shader_integer_functions2";
	public const UInt VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = 2;
	public const String VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME = "VK_INTEL_performance_query";
	public const UInt VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION = 3;
	public const String VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME = "VK_KHR_vulkan_memory_model";
	public const UInt VK_EXT_PCI_BUS_INFO_SPEC_VERSION = 2;
	public const String VK_EXT_PCI_BUS_INFO_EXTENSION_NAME = "VK_EXT_pci_bus_info";
	public const UInt VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = 1;
	public const String VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME = "VK_AMD_display_native_hdr";
	public const UInt VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME = "VK_KHR_shader_terminate_invocation";
	public const UInt VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION = 2;
	public const String VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME = "VK_EXT_fragment_density_map";
	public const UInt VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = 1;
	public const String VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME = "VK_EXT_scalar_block_layout";
	public const UInt VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION = 1;
	public const String VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME = "VK_GOOGLE_hlsl_functionality1";
	[Obsolete("Use VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION")]
	public const UInt VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION;
	[Obsolete("Use VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME")]
	public const UInt VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME = VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME;
	public const UInt VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = 1;
	public const String VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME = "VK_GOOGLE_decorate_string";
	public const UInt VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION = 2;
	public const String VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME = "VK_EXT_subgroup_size_control";
	public const UInt VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = 2;
	public const String VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME = "VK_KHR_fragment_shading_rate";
	public const UInt VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION = 1;
	public const String VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME = "VK_AMD_shader_core_properties2";
	public const UInt VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = 1;
	public const String VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME = "VK_AMD_device_coherent_memory";
	public const UInt VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME = "VK_EXT_shader_image_atomic_int64";
	public const UInt VK_KHR_SPIRV_1_4_SPEC_VERSION = 1;
	public const String VK_KHR_SPIRV_1_4_EXTENSION_NAME = "VK_KHR_spirv_1_4";
	public const UInt VK_EXT_MEMORY_BUDGET_SPEC_VERSION = 1;
	public const String VK_EXT_MEMORY_BUDGET_EXTENSION_NAME = "VK_EXT_memory_budget";
	public const UInt VK_EXT_MEMORY_PRIORITY_SPEC_VERSION = 1;
	public const String VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME = "VK_EXT_memory_priority";
	public const UInt VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = 1;
	public const String VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME = "VK_KHR_surface_protected_capabilities";
	public const UInt VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = 1;
	public const String VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME = "VK_NV_dedicated_allocation_image_aliasing";
	public const UInt VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION = 1;
	public const String VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME = "VK_KHR_separate_depth_stencil_layouts";
	public const UInt VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 2;
	public const String VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = "VK_EXT_buffer_device_address";
	public const UInt VK_EXT_TOOLING_INFO_SPEC_VERSION = 1;
	public const String VK_EXT_TOOLING_INFO_EXTENSION_NAME = "VK_EXT_tooling_info";
	public const UInt VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = 1;
	public const String VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME = "VK_EXT_separate_stencil_usage";
	public const UInt VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = 5;
	public const String VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME = "VK_EXT_validation_features";
	public const UInt VK_KHR_PRESENT_WAIT_SPEC_VERSION = 1;
	public const String VK_KHR_PRESENT_WAIT_EXTENSION_NAME = "VK_KHR_present_wait";
	public const UInt VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = 1;
	public const String VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME = "VK_NV_cooperative_matrix";
	public const UInt VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = 1;
	public const String VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME = "VK_NV_coverage_reduction_mode";
	public const UInt VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION = 1;
	public const String VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME = "VK_EXT_fragment_shader_interlock";
	public const UInt VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = 1;
	public const String VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME = "VK_EXT_ycbcr_image_arrays";
	public const UInt VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = 1;
	public const String VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME = "VK_KHR_uniform_buffer_standard_layout";
	public const UInt VK_EXT_PROVOKING_VERTEX_SPEC_VERSION = 1;
	public const String VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME = "VK_EXT_provoking_vertex";
	public const UInt VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;
	public const String VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME = "VK_EXT_full_screen_exclusive";
	public const UInt VK_EXT_HEADLESS_SURFACE_SPEC_VERSION = 1;
	public const String VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME = "VK_EXT_headless_surface";
	public const UInt VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 1;
	public const String VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = "VK_KHR_buffer_device_address";
	public const UInt VK_EXT_LINE_RASTERIZATION_SPEC_VERSION = 1;
	public const String VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME = "VK_EXT_line_rasterization";
	public const UInt VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME = "VK_EXT_shader_atomic_float";
	public const UInt VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;
	public const String VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME = "VK_EXT_host_query_reset";
	public const UInt VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION = 1;
	public const String VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME = "VK_EXT_index_type_uint8";
	public const UInt VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = 1;
	public const String VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_extended_dynamic_state";
	public const UInt VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 4;
	public const String VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME = "VK_KHR_deferred_host_operations";
	public const UInt VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;
	public const String VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME = "VK_KHR_pipeline_executable_properties";
	public const UInt VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME = "VK_EXT_shader_atomic_float2";
	public const UInt VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION = 1;
	public const String VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME = "VK_EXT_shader_demote_to_helper_invocation";
	public const UInt VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 3;
	public const String VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = "VK_NV_device_generated_commands";
	public const UInt VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION = 1;
	public const String VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME = "VK_NV_inherited_viewport_scissor";
	public const UInt VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME = "VK_KHR_shader_integer_dot_product";
	public const UInt VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = 1;
	public const String VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME = "VK_EXT_texel_buffer_alignment";
	public const UInt VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION = 2;
	public const String VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME = "VK_QCOM_render_pass_transform";
	public const UInt VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION = 2;
	public const String VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME = "VK_EXT_device_memory_report";
	public const UInt VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION = 1;
	public const String VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_EXT_acquire_drm_display";
	public const UInt VK_EXT_ROBUSTNESS_2_SPEC_VERSION = 1;
	public const String VK_EXT_ROBUSTNESS_2_EXTENSION_NAME = "VK_EXT_robustness2";
	public const UInt VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = 12;
	public const String VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME = "VK_EXT_custom_border_color";
	public const UInt VK_GOOGLE_USER_TYPE_SPEC_VERSION = 1;
	public const String VK_GOOGLE_USER_TYPE_EXTENSION_NAME = "VK_GOOGLE_user_type";
	public const UInt VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = 1;
	public const String VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME = "VK_KHR_pipeline_library";
	public const UInt VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME = "VK_KHR_shader_non_semantic_info";
	public const UInt VK_KHR_PRESENT_ID_SPEC_VERSION = 1;
	public const String VK_KHR_PRESENT_ID_EXTENSION_NAME = "VK_KHR_present_id";
	public const UInt VK_EXT_PRIVATE_DATA_SPEC_VERSION = 1;
	public const String VK_EXT_PRIVATE_DATA_EXTENSION_NAME = "VK_EXT_private_data";
	public const UInt VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = 3;
	public const String VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME = "VK_EXT_pipeline_creation_cache_control";
	public const UInt VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = 1;
	public const String VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME = "VK_NV_device_diagnostics_config";
	public const UInt VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION = 2;
	public const String VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME = "VK_QCOM_render_pass_store_ops";
	public const UInt VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION = 1;
	public const String VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME = "VK_KHR_synchronization2";
	public const UInt VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION = 1;
	public const String VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME = "VK_KHR_shader_subgroup_uniform_control_flow";
	public const UInt VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION = 1;
	public const String VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME = "VK_KHR_zero_initialize_workgroup_memory";
	public const UInt VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = 1;
	public const String VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME = "VK_NV_fragment_shading_rate_enums";
	public const UInt VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION = 1;
	public const String VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME = "VK_NV_ray_tracing_motion_blur";
	public const UInt VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION = 1;
	public const String VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME = "VK_EXT_ycbcr_2plane_444_formats";
	public const UInt VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = 1;
	public const String VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME = "VK_EXT_fragment_density_map2";
	public const UInt VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION = 1;
	public const String VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME = "VK_QCOM_rotated_copy_commands";
	public const UInt VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION = 1;
	public const String VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME = "VK_EXT_image_robustness";
	public const UInt VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION = 1;
	public const String VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME = "VK_KHR_workgroup_memory_explicit_layout";
	public const UInt VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;
	public const String VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME = "VK_KHR_copy_commands2";
	public const UInt VK_EXT_4444_FORMATS_SPEC_VERSION = 1;
	public const String VK_EXT_4444_FORMATS_EXTENSION_NAME = "VK_EXT_4444_formats";
	public const UInt VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION = 1;
	public const String VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME = "VK_ARM_rasterization_order_attachment_access";
	public const UInt VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION = 1;
	public const String VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME = "VK_EXT_rgba10x6_formats";
	public const UInt VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = 1;
	public const String VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME = "VK_NV_acquire_winrt_display";
	public const UInt VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = 1;
	public const String VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME = "VK_VALVE_mutable_descriptor_type";
	public const UInt VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION = 2;
	public const String VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_vertex_input_dynamic_state";
	public const UInt VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION = 1;
	public const String VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME = "VK_EXT_physical_device_drm";
	public const UInt VK_EXT_DEPTH_CLIP_CONTROL_SPEC_VERSION = 1;
	public const String VK_EXT_DEPTH_CLIP_CONTROL_EXTENSION_NAME = "VK_EXT_depth_clip_control";
	public const UInt VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_SPEC_VERSION = 1;
	public const String VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME = "VK_EXT_primitive_topology_list_restart";
	public const UInt VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION = 1;
	public const String VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME = "VK_KHR_format_feature_flags2";
	public const UInt VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION = 2;
	public const String VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME = "VK_HUAWEI_subpass_shading";
	public const UInt VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION = 1;
	public const String VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME = "VK_HUAWEI_invocation_mask";
	public const UInt VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;
	public const String VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME = "VK_NV_external_memory_rdma";
	public const UInt VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION = 1;
	public const String VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME = "VK_EXT_extended_dynamic_state2";
	public const UInt VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION = 1;
	public const String VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME = "VK_EXT_color_write_enable";
	public const UInt VK_MAX_GLOBAL_PRIORITY_SIZE_EXT = 16;
	public const UInt VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION = 1;
	public const String VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME = "VK_EXT_global_priority_query";
	public const UInt VK_EXT_IMAGE_VIEW_MIN_LOD_SPEC_VERSION = 1;
	public const String VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME = "VK_EXT_image_view_min_lod";
	public const UInt VK_EXT_MULTI_DRAW_SPEC_VERSION = 1;
	public const String VK_EXT_MULTI_DRAW_EXTENSION_NAME = "VK_EXT_multi_draw";
	public const UInt VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;
	public const String VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME = "VK_EXT_load_store_op_none";
	public const UInt VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION = 1;
	public const String VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME = "VK_EXT_border_color_swizzle";
	public const UInt VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION = 1;
	public const String VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME = "VK_EXT_pageable_device_local_memory";
	public const UInt VK_KHR_MAINTENANCE_4_SPEC_VERSION = 2;
	public const String VK_KHR_MAINTENANCE_4_EXTENSION_NAME = "VK_KHR_maintenance4";
	public const UInt VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION = 1;
	public const String VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME = "VK_QCOM_fragment_density_map_offset";
	public const UInt VK_NV_LINEAR_COLOR_ATTACHMENT_SPEC_VERSION = 1;
	public const String VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME = "VK_NV_linear_color_attachment";
	public const UInt VK_GOOGLE_SURFACELESS_QUERY_SPEC_VERSION = 1;
	public const String VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME = "VK_GOOGLE_surfaceless_query";
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
	public static void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectCountPointer;
	private static vkCmdDrawIndirectCountDelegate_0 vkCmdDrawIndirectCount_0;
	public static void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndexedIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndexedIndirectCountPointer;
	private static vkCmdDrawIndexedIndirectCountDelegate_0 vkCmdDrawIndexedIndirectCount_0;
	public static VkResult vkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => vkCreateRenderPass2_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate VkResult vkCreateRenderPass2Delegate_0(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr vkCreateRenderPass2Pointer;
	private static vkCreateRenderPass2Delegate_0 vkCreateRenderPass2_0;
	public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo) => vkCmdBeginRenderPass2_0(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
	private delegate void vkCmdBeginRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo);
	private static IntPtr vkCmdBeginRenderPass2Pointer;
	private static vkCmdBeginRenderPass2Delegate_0 vkCmdBeginRenderPass2_0;
	public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo) => vkCmdNextSubpass2_0(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
	private delegate void vkCmdNextSubpass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo);
	private static IntPtr vkCmdNextSubpass2Pointer;
	private static vkCmdNextSubpass2Delegate_0 vkCmdNextSubpass2_0;
	public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo) => vkCmdEndRenderPass2_0(commandBuffer, pSubpassEndInfo);
	private delegate void vkCmdEndRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo);
	private static IntPtr vkCmdEndRenderPass2Pointer;
	private static vkCmdEndRenderPass2Delegate_0 vkCmdEndRenderPass2_0;
	public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount) => vkResetQueryPool_0(device, queryPool, firstQuery, queryCount);
	private delegate void vkResetQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount);
	private static IntPtr vkResetQueryPoolPointer;
	private static vkResetQueryPoolDelegate_0 vkResetQueryPool_0;
	public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, uint64_t* pValue) => vkGetSemaphoreCounterValue_0(device, semaphore, pValue);
	private delegate VkResult vkGetSemaphoreCounterValueDelegate_0(VkDevice device, VkSemaphore semaphore, uint64_t* pValue);
	private static IntPtr vkGetSemaphoreCounterValuePointer;
	private static vkGetSemaphoreCounterValueDelegate_0 vkGetSemaphoreCounterValue_0;
	public static VkResult vkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, uint64_t timeout) => vkWaitSemaphores_0(device, pWaitInfo, timeout);
	private delegate VkResult vkWaitSemaphoresDelegate_0(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, uint64_t timeout);
	private static IntPtr vkWaitSemaphoresPointer;
	private static vkWaitSemaphoresDelegate_0 vkWaitSemaphores_0;
	public static VkResult vkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo) => vkSignalSemaphore_0(device, pSignalInfo);
	private delegate VkResult vkSignalSemaphoreDelegate_0(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo);
	private static IntPtr vkSignalSemaphorePointer;
	private static vkSignalSemaphoreDelegate_0 vkSignalSemaphore_0;
	public static VkDeviceAddress vkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo) => vkGetBufferDeviceAddress_0(device, pInfo);
	private delegate VkDeviceAddress vkGetBufferDeviceAddressDelegate_0(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
	private static IntPtr vkGetBufferDeviceAddressPointer;
	private static vkGetBufferDeviceAddressDelegate_0 vkGetBufferDeviceAddress_0;
	public static uint64_t vkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo) => vkGetBufferOpaqueCaptureAddress_0(device, pInfo);
	private delegate uint64_t vkGetBufferOpaqueCaptureAddressDelegate_0(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
	private static IntPtr vkGetBufferOpaqueCaptureAddressPointer;
	private static vkGetBufferOpaqueCaptureAddressDelegate_0 vkGetBufferOpaqueCaptureAddress_0;
	public static uint64_t vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo) => vkGetDeviceMemoryOpaqueCaptureAddress_0(device, pInfo);
	private delegate uint64_t vkGetDeviceMemoryOpaqueCaptureAddressDelegate_0(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);
	private static IntPtr vkGetDeviceMemoryOpaqueCaptureAddressPointer;
	private static vkGetDeviceMemoryOpaqueCaptureAddressDelegate_0 vkGetDeviceMemoryOpaqueCaptureAddress_0;
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
	public static VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule) => vkCreateCuModuleNVX_0(device, pCreateInfo, pAllocator, pModule);
	private delegate VkResult vkCreateCuModuleNVXDelegate_0(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule);
	private static IntPtr vkCreateCuModuleNVXPointer;
	private static vkCreateCuModuleNVXDelegate_0 vkCreateCuModuleNVX_0;
	public static VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction) => vkCreateCuFunctionNVX_0(device, pCreateInfo, pAllocator, pFunction);
	private delegate VkResult vkCreateCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction);
	private static IntPtr vkCreateCuFunctionNVXPointer;
	private static vkCreateCuFunctionNVXDelegate_0 vkCreateCuFunctionNVX_0;
	public static void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator) => vkDestroyCuModuleNVX_0(device, module, pAllocator);
	private delegate void vkDestroyCuModuleNVXDelegate_0(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyCuModuleNVXPointer;
	private static vkDestroyCuModuleNVXDelegate_0 vkDestroyCuModuleNVX_0;
	public static void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator) => vkDestroyCuFunctionNVX_0(device, function, pAllocator);
	private delegate void vkDestroyCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyCuFunctionNVXPointer;
	private static vkDestroyCuFunctionNVXDelegate_0 vkDestroyCuFunctionNVX_0;
	public static void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo) => vkCmdCuLaunchKernelNVX_0(commandBuffer, pLaunchInfo);
	private delegate void vkCmdCuLaunchKernelNVXDelegate_0(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo);
	private static IntPtr vkCmdCuLaunchKernelNVXPointer;
	private static vkCmdCuLaunchKernelNVXDelegate_0 vkCmdCuLaunchKernelNVX_0;
	public static uint32_t vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo) => vkGetImageViewHandleNVX_0(device, pInfo);
	private delegate uint32_t vkGetImageViewHandleNVXDelegate_0(VkDevice device, VkImageViewHandleInfoNVX* pInfo);
	private static IntPtr vkGetImageViewHandleNVXPointer;
	private static vkGetImageViewHandleNVXDelegate_0 vkGetImageViewHandleNVX_0;
	public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties) => vkGetImageViewAddressNVX_0(device, imageView, pProperties);
	private delegate VkResult vkGetImageViewAddressNVXDelegate_0(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties);
	private static IntPtr vkGetImageViewAddressNVXPointer;
	private static vkGetImageViewAddressNVXDelegate_0 vkGetImageViewAddressNVX_0;
	[Obsolete("Use vkCmdDrawIndirectCount")]
	public static void vkCmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectCountAMDPointer;
	private static vkCmdDrawIndirectCountAMDDelegate_0 vkCmdDrawIndirectCountAMD_0;
	[Obsolete("Use vkCmdDrawIndexedIndirectCount")]
	public static void vkCmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndexedIndirectCountAMDPointer;
	private static vkCmdDrawIndexedIndirectCountAMDDelegate_0 vkCmdDrawIndexedIndirectCountAMD_0;
	public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, size_t* pInfoSize, void* pInfo) => vkGetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
	private delegate VkResult vkGetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, size_t* pInfoSize, void* pInfo);
	private static IntPtr vkGetShaderInfoAMDPointer;
	private static vkGetShaderInfoAMDDelegate_0 vkGetShaderInfoAMD_0;
	public static void vkCmdBeginRenderingKHR(VkCommandBuffer commandBuffer, VkRenderingInfoKHR* pRenderingInfo) => vkCmdBeginRenderingKHR_0(commandBuffer, pRenderingInfo);
	private delegate void vkCmdBeginRenderingKHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderingInfoKHR* pRenderingInfo);
	private static IntPtr vkCmdBeginRenderingKHRPointer;
	private static vkCmdBeginRenderingKHRDelegate_0 vkCmdBeginRenderingKHR_0;
	public static void vkCmdEndRenderingKHR(VkCommandBuffer commandBuffer) => vkCmdEndRenderingKHR_0(commandBuffer);
	private delegate void vkCmdEndRenderingKHRDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdEndRenderingKHRPointer;
	private static vkCmdEndRenderingKHRDelegate_0 vkCmdEndRenderingKHR_0;
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
	[Obsolete("Use vkCreateRenderPass2")]
	public static void vkCreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass) => vkCreateRenderPass2KHR_0(device, pCreateInfo, pAllocator, pRenderPass);
	private delegate void vkCreateRenderPass2KHRDelegate_0(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
	private static IntPtr vkCreateRenderPass2KHRPointer;
	private static vkCreateRenderPass2KHRDelegate_0 vkCreateRenderPass2KHR_0;
	[Obsolete("Use vkCmdBeginRenderPass2")]
	public static void vkCmdBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo) => vkCmdBeginRenderPass2KHR_0(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
	private delegate void vkCmdBeginRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo);
	private static IntPtr vkCmdBeginRenderPass2KHRPointer;
	private static vkCmdBeginRenderPass2KHRDelegate_0 vkCmdBeginRenderPass2KHR_0;
	[Obsolete("Use vkCmdNextSubpass2")]
	public static void vkCmdNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo) => vkCmdNextSubpass2KHR_0(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
	private delegate void vkCmdNextSubpass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo);
	private static IntPtr vkCmdNextSubpass2KHRPointer;
	private static vkCmdNextSubpass2KHRDelegate_0 vkCmdNextSubpass2KHR_0;
	[Obsolete("Use vkCmdEndRenderPass2")]
	public static void vkCmdEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo) => vkCmdEndRenderPass2KHR_0(commandBuffer, pSubpassEndInfo);
	private delegate void vkCmdEndRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo);
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
	public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure) => vkCreateAccelerationStructureKHR_0(device, pCreateInfo, pAllocator, pAccelerationStructure);
	private delegate VkResult vkCreateAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure);
	private static IntPtr vkCreateAccelerationStructureKHRPointer;
	private static vkCreateAccelerationStructureKHRDelegate_0 vkCreateAccelerationStructureKHR_0;
	public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator) => vkDestroyAccelerationStructureKHR_0(device, accelerationStructure, pAllocator);
	private delegate void vkDestroyAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyAccelerationStructureKHRPointer;
	private static vkDestroyAccelerationStructureKHRDelegate_0 vkDestroyAccelerationStructureKHR_0;
	public static void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos) => vkCmdBuildAccelerationStructuresKHR_0(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
	private delegate void vkCmdBuildAccelerationStructuresKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
	private static IntPtr vkCmdBuildAccelerationStructuresKHRPointer;
	private static vkCmdBuildAccelerationStructuresKHRDelegate_0 vkCmdBuildAccelerationStructuresKHR_0;
	public static void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkDeviceAddress* pIndirectDeviceAddresses, uint32_t* pIndirectStrides, uint32_t** ppMaxPrimitiveCounts) => vkCmdBuildAccelerationStructuresIndirectKHR_0(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
	private delegate void vkCmdBuildAccelerationStructuresIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkDeviceAddress* pIndirectDeviceAddresses, uint32_t* pIndirectStrides, uint32_t** ppMaxPrimitiveCounts);
	private static IntPtr vkCmdBuildAccelerationStructuresIndirectKHRPointer;
	private static vkCmdBuildAccelerationStructuresIndirectKHRDelegate_0 vkCmdBuildAccelerationStructuresIndirectKHR_0;
	public static VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos) => vkBuildAccelerationStructuresKHR_0(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
	private delegate VkResult vkBuildAccelerationStructuresKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, uint32_t infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
	private static IntPtr vkBuildAccelerationStructuresKHRPointer;
	private static vkBuildAccelerationStructuresKHRDelegate_0 vkBuildAccelerationStructuresKHR_0;
	public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo) => vkCopyAccelerationStructureKHR_0(device, deferredOperation, pInfo);
	private delegate VkResult vkCopyAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo);
	private static IntPtr vkCopyAccelerationStructureKHRPointer;
	private static vkCopyAccelerationStructureKHRDelegate_0 vkCopyAccelerationStructureKHR_0;
	public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo) => vkCopyAccelerationStructureToMemoryKHR_0(device, deferredOperation, pInfo);
	private delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
	private static IntPtr vkCopyAccelerationStructureToMemoryKHRPointer;
	private static vkCopyAccelerationStructureToMemoryKHRDelegate_0 vkCopyAccelerationStructureToMemoryKHR_0;
	public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo) => vkCopyMemoryToAccelerationStructureKHR_0(device, deferredOperation, pInfo);
	private delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
	private static IntPtr vkCopyMemoryToAccelerationStructureKHRPointer;
	private static vkCopyMemoryToAccelerationStructureKHRDelegate_0 vkCopyMemoryToAccelerationStructureKHR_0;
	public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint32_t accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, size_t dataSize, void* pData, size_t stride) => vkWriteAccelerationStructuresPropertiesKHR_0(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
	private delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate_0(VkDevice device, uint32_t accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, size_t dataSize, void* pData, size_t stride);
	private static IntPtr vkWriteAccelerationStructuresPropertiesKHRPointer;
	private static vkWriteAccelerationStructuresPropertiesKHRDelegate_0 vkWriteAccelerationStructuresPropertiesKHR_0;
	public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo) => vkCmdCopyAccelerationStructureKHR_0(commandBuffer, pInfo);
	private delegate void vkCmdCopyAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo);
	private static IntPtr vkCmdCopyAccelerationStructureKHRPointer;
	private static vkCmdCopyAccelerationStructureKHRDelegate_0 vkCmdCopyAccelerationStructureKHR_0;
	public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo) => vkCmdCopyAccelerationStructureToMemoryKHR_0(commandBuffer, pInfo);
	private delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
	private static IntPtr vkCmdCopyAccelerationStructureToMemoryKHRPointer;
	private static vkCmdCopyAccelerationStructureToMemoryKHRDelegate_0 vkCmdCopyAccelerationStructureToMemoryKHR_0;
	public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo) => vkCmdCopyMemoryToAccelerationStructureKHR_0(commandBuffer, pInfo);
	private delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
	private static IntPtr vkCmdCopyMemoryToAccelerationStructureKHRPointer;
	private static vkCmdCopyMemoryToAccelerationStructureKHRDelegate_0 vkCmdCopyMemoryToAccelerationStructureKHR_0;
	public static VkDeviceAddress vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo) => vkGetAccelerationStructureDeviceAddressKHR_0(device, pInfo);
	private delegate VkDeviceAddress vkGetAccelerationStructureDeviceAddressKHRDelegate_0(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo);
	private static IntPtr vkGetAccelerationStructureDeviceAddressKHRPointer;
	private static vkGetAccelerationStructureDeviceAddressKHRDelegate_0 vkGetAccelerationStructureDeviceAddressKHR_0;
	public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint32_t accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint32_t firstQuery) => vkCmdWriteAccelerationStructuresPropertiesKHR_0(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
	private delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint32_t firstQuery);
	private static IntPtr vkCmdWriteAccelerationStructuresPropertiesKHRPointer;
	private static vkCmdWriteAccelerationStructuresPropertiesKHRDelegate_0 vkCmdWriteAccelerationStructuresPropertiesKHR_0;
	public static void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility) => vkGetDeviceAccelerationStructureCompatibilityKHR_0(device, pVersionInfo, pCompatibility);
	private delegate void vkGetDeviceAccelerationStructureCompatibilityKHRDelegate_0(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility);
	private static IntPtr vkGetDeviceAccelerationStructureCompatibilityKHRPointer;
	private static vkGetDeviceAccelerationStructureCompatibilityKHRDelegate_0 vkGetDeviceAccelerationStructureCompatibilityKHR_0;
	public static void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint32_t* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo) => vkGetAccelerationStructureBuildSizesKHR_0(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
	private delegate void vkGetAccelerationStructureBuildSizesKHRDelegate_0(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint32_t* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo);
	private static IntPtr vkGetAccelerationStructureBuildSizesKHRPointer;
	private static vkGetAccelerationStructureBuildSizesKHRDelegate_0 vkGetAccelerationStructureBuildSizesKHR_0;
	public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint32_t width, uint32_t height, uint32_t depth) => vkCmdTraceRaysKHR_0(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
	private delegate void vkCmdTraceRaysKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint32_t width, uint32_t height, uint32_t depth);
	private static IntPtr vkCmdTraceRaysKHRPointer;
	private static vkCmdTraceRaysKHRDelegate_0 vkCmdTraceRaysKHR_0;
	public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines) => vkCreateRayTracingPipelinesKHR_0(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
	private delegate VkResult vkCreateRayTracingPipelinesKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
	private static IntPtr vkCreateRayTracingPipelinesKHRPointer;
	private static vkCreateRayTracingPipelinesKHRDelegate_0 vkCreateRayTracingPipelinesKHR_0;
	public static VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData) => vkGetRayTracingShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, pData);
	private delegate VkResult vkGetRayTracingShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData);
	private static IntPtr vkGetRayTracingShaderGroupHandlesKHRPointer;
	private static vkGetRayTracingShaderGroupHandlesKHRDelegate_0 vkGetRayTracingShaderGroupHandlesKHR_0;
	public static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData) => vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, pData);
	private delegate VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData);
	private static IntPtr vkGetRayTracingCaptureReplayShaderGroupHandlesKHRPointer;
	private static vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0 vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_0;
	public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => vkCmdTraceRaysIndirectKHR_0(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
	private delegate void vkCmdTraceRaysIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static IntPtr vkCmdTraceRaysIndirectKHRPointer;
	private static vkCmdTraceRaysIndirectKHRDelegate_0 vkCmdTraceRaysIndirectKHR_0;
	public static VkDeviceSize vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint32_t group, VkShaderGroupShaderKHR groupShader) => vkGetRayTracingShaderGroupStackSizeKHR_0(device, pipeline, group, groupShader);
	private delegate VkDeviceSize vkGetRayTracingShaderGroupStackSizeKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t group, VkShaderGroupShaderKHR groupShader);
	private static IntPtr vkGetRayTracingShaderGroupStackSizeKHRPointer;
	private static vkGetRayTracingShaderGroupStackSizeKHRDelegate_0 vkGetRayTracingShaderGroupStackSizeKHR_0;
	public static void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint32_t pipelineStackSize) => vkCmdSetRayTracingPipelineStackSizeKHR_0(commandBuffer, pipelineStackSize);
	private delegate void vkCmdSetRayTracingPipelineStackSizeKHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t pipelineStackSize);
	private static IntPtr vkCmdSetRayTracingPipelineStackSizeKHRPointer;
	private static vkCmdSetRayTracingPipelineStackSizeKHRDelegate_0 vkCmdSetRayTracingPipelineStackSizeKHR_0;
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
	public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode) => vkCmdCopyAccelerationStructureNV_0(commandBuffer, dst, src, mode);
	private delegate void vkCmdCopyAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode);
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
	[Obsolete("Use vkGetRayTracingShaderGroupHandlesKHR")]
	public static void vkGetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData) => vkGetRayTracingShaderGroupHandlesNV_0(device, pipeline, firstGroup, groupCount, dataSize, pData);
	private delegate void vkGetRayTracingShaderGroupHandlesNVDelegate_0(VkDevice device, VkPipeline pipeline, uint32_t firstGroup, uint32_t groupCount, size_t dataSize, void* pData);
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
	[Obsolete("Use vkCmdDrawIndirectCount")]
	public static void vkCmdDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride) => vkCmdDrawIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void vkCmdDrawIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride);
	private static IntPtr vkCmdDrawIndirectCountKHRPointer;
	private static vkCmdDrawIndirectCountKHRDelegate_0 vkCmdDrawIndirectCountKHR_0;
	[Obsolete("Use vkCmdDrawIndexedIndirectCount")]
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
	[Obsolete("Use vkGetSemaphoreCounterValue")]
	public static void vkGetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, uint64_t* pValue) => vkGetSemaphoreCounterValueKHR_0(device, semaphore, pValue);
	private delegate void vkGetSemaphoreCounterValueKHRDelegate_0(VkDevice device, VkSemaphore semaphore, uint64_t* pValue);
	private static IntPtr vkGetSemaphoreCounterValueKHRPointer;
	private static vkGetSemaphoreCounterValueKHRDelegate_0 vkGetSemaphoreCounterValueKHR_0;
	[Obsolete("Use vkWaitSemaphores")]
	public static void vkWaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, uint64_t timeout) => vkWaitSemaphoresKHR_0(device, pWaitInfo, timeout);
	private delegate void vkWaitSemaphoresKHRDelegate_0(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, uint64_t timeout);
	private static IntPtr vkWaitSemaphoresKHRPointer;
	private static vkWaitSemaphoresKHRDelegate_0 vkWaitSemaphoresKHR_0;
	[Obsolete("Use vkSignalSemaphore")]
	public static void vkSignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo) => vkSignalSemaphoreKHR_0(device, pSignalInfo);
	private delegate void vkSignalSemaphoreKHRDelegate_0(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo);
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
	public static VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint32_t* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates) => vkGetPhysicalDeviceFragmentShadingRatesKHR_0(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
	private delegate VkResult vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);
	private static IntPtr vkGetPhysicalDeviceFragmentShadingRatesKHRPointer;
	private static vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate_0 vkGetPhysicalDeviceFragmentShadingRatesKHR_0;
	public static void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps) => vkCmdSetFragmentShadingRateKHR_0(commandBuffer, pFragmentSize, combinerOps);
	private delegate void vkCmdSetFragmentShadingRateKHRDelegate_0(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
	private static IntPtr vkCmdSetFragmentShadingRateKHRPointer;
	private static vkCmdSetFragmentShadingRateKHRDelegate_0 vkCmdSetFragmentShadingRateKHR_0;
	[Obsolete("Use vkGetBufferDeviceAddress")]
	public static void vkGetBufferDeviceAddressEXT(VkDevice device, VkBufferDeviceAddressInfo* pInfo) => vkGetBufferDeviceAddressEXT_0(device, pInfo);
	private delegate void vkGetBufferDeviceAddressEXTDelegate_0(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
	private static IntPtr vkGetBufferDeviceAddressEXTPointer;
	private static vkGetBufferDeviceAddressEXTDelegate_0 vkGetBufferDeviceAddressEXT_0;
	public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint32_t* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties) => vkGetPhysicalDeviceToolPropertiesEXT_0(physicalDevice, pToolCount, pToolProperties);
	private delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, uint32_t* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);
	private static IntPtr vkGetPhysicalDeviceToolPropertiesEXTPointer;
	private static vkGetPhysicalDeviceToolPropertiesEXTDelegate_0 vkGetPhysicalDeviceToolPropertiesEXT_0;
	public static VkResult vkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, uint64_t presentId, uint64_t timeout) => vkWaitForPresentKHR_0(device, swapchain, presentId, timeout);
	private delegate VkResult vkWaitForPresentKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint64_t presentId, uint64_t timeout);
	private static IntPtr vkWaitForPresentKHRPointer;
	private static vkWaitForPresentKHRDelegate_0 vkWaitForPresentKHR_0;
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
	[Obsolete("Use vkGetBufferDeviceAddress")]
	public static void vkGetBufferDeviceAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo) => vkGetBufferDeviceAddressKHR_0(device, pInfo);
	private delegate void vkGetBufferDeviceAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
	private static IntPtr vkGetBufferDeviceAddressKHRPointer;
	private static vkGetBufferDeviceAddressKHRDelegate_0 vkGetBufferDeviceAddressKHR_0;
	[Obsolete("Use vkGetBufferOpaqueCaptureAddress")]
	public static void vkGetBufferOpaqueCaptureAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo) => vkGetBufferOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate void vkGetBufferOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
	private static IntPtr vkGetBufferOpaqueCaptureAddressKHRPointer;
	private static vkGetBufferOpaqueCaptureAddressKHRDelegate_0 vkGetBufferOpaqueCaptureAddressKHR_0;
	[Obsolete("Use vkGetDeviceMemoryOpaqueCaptureAddress")]
	public static void vkGetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo) => vkGetDeviceMemoryOpaqueCaptureAddressKHR_0(device, pInfo);
	private delegate void vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);
	private static IntPtr vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer;
	private static vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0 vkGetDeviceMemoryOpaqueCaptureAddressKHR_0;
	public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint32_t lineStippleFactor, uint16_t lineStipplePattern) => vkCmdSetLineStippleEXT_0(commandBuffer, lineStippleFactor, lineStipplePattern);
	private delegate void vkCmdSetLineStippleEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t lineStippleFactor, uint16_t lineStipplePattern);
	private static IntPtr vkCmdSetLineStippleEXTPointer;
	private static vkCmdSetLineStippleEXTDelegate_0 vkCmdSetLineStippleEXT_0;
	[Obsolete("Use vkResetQueryPool")]
	public static void vkResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount) => vkResetQueryPoolEXT_0(device, queryPool, firstQuery, queryCount);
	private delegate void vkResetQueryPoolEXTDelegate_0(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount);
	private static IntPtr vkResetQueryPoolEXTPointer;
	private static vkResetQueryPoolEXTDelegate_0 vkResetQueryPoolEXT_0;
	public static void vkCmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode) => vkCmdSetCullModeEXT_0(commandBuffer, cullMode);
	private delegate void vkCmdSetCullModeEXTDelegate_0(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
	private static IntPtr vkCmdSetCullModeEXTPointer;
	private static vkCmdSetCullModeEXTDelegate_0 vkCmdSetCullModeEXT_0;
	public static void vkCmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace) => vkCmdSetFrontFaceEXT_0(commandBuffer, frontFace);
	private delegate void vkCmdSetFrontFaceEXTDelegate_0(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
	private static IntPtr vkCmdSetFrontFaceEXTPointer;
	private static vkCmdSetFrontFaceEXTDelegate_0 vkCmdSetFrontFaceEXT_0;
	public static void vkCmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology) => vkCmdSetPrimitiveTopologyEXT_0(commandBuffer, primitiveTopology);
	private delegate void vkCmdSetPrimitiveTopologyEXTDelegate_0(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
	private static IntPtr vkCmdSetPrimitiveTopologyEXTPointer;
	private static vkCmdSetPrimitiveTopologyEXTDelegate_0 vkCmdSetPrimitiveTopologyEXT_0;
	public static void vkCmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint32_t viewportCount, VkViewport* pViewports) => vkCmdSetViewportWithCountEXT_0(commandBuffer, viewportCount, pViewports);
	private delegate void vkCmdSetViewportWithCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t viewportCount, VkViewport* pViewports);
	private static IntPtr vkCmdSetViewportWithCountEXTPointer;
	private static vkCmdSetViewportWithCountEXTDelegate_0 vkCmdSetViewportWithCountEXT_0;
	public static void vkCmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint32_t scissorCount, VkRect2D* pScissors) => vkCmdSetScissorWithCountEXT_0(commandBuffer, scissorCount, pScissors);
	private delegate void vkCmdSetScissorWithCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t scissorCount, VkRect2D* pScissors);
	private static IntPtr vkCmdSetScissorWithCountEXTPointer;
	private static vkCmdSetScissorWithCountEXTDelegate_0 vkCmdSetScissorWithCountEXT_0;
	public static void vkCmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides) => vkCmdBindVertexBuffers2EXT_0(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
	private delegate void vkCmdBindVertexBuffers2EXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides);
	private static IntPtr vkCmdBindVertexBuffers2EXTPointer;
	private static vkCmdBindVertexBuffers2EXTDelegate_0 vkCmdBindVertexBuffers2EXT_0;
	public static void vkCmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable) => vkCmdSetDepthTestEnableEXT_0(commandBuffer, depthTestEnable);
	private delegate void vkCmdSetDepthTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
	private static IntPtr vkCmdSetDepthTestEnableEXTPointer;
	private static vkCmdSetDepthTestEnableEXTDelegate_0 vkCmdSetDepthTestEnableEXT_0;
	public static void vkCmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable) => vkCmdSetDepthWriteEnableEXT_0(commandBuffer, depthWriteEnable);
	private delegate void vkCmdSetDepthWriteEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
	private static IntPtr vkCmdSetDepthWriteEnableEXTPointer;
	private static vkCmdSetDepthWriteEnableEXTDelegate_0 vkCmdSetDepthWriteEnableEXT_0;
	public static void vkCmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp) => vkCmdSetDepthCompareOpEXT_0(commandBuffer, depthCompareOp);
	private delegate void vkCmdSetDepthCompareOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
	private static IntPtr vkCmdSetDepthCompareOpEXTPointer;
	private static vkCmdSetDepthCompareOpEXTDelegate_0 vkCmdSetDepthCompareOpEXT_0;
	public static void vkCmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable) => vkCmdSetDepthBoundsTestEnableEXT_0(commandBuffer, depthBoundsTestEnable);
	private delegate void vkCmdSetDepthBoundsTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
	private static IntPtr vkCmdSetDepthBoundsTestEnableEXTPointer;
	private static vkCmdSetDepthBoundsTestEnableEXTDelegate_0 vkCmdSetDepthBoundsTestEnableEXT_0;
	public static void vkCmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable) => vkCmdSetStencilTestEnableEXT_0(commandBuffer, stencilTestEnable);
	private delegate void vkCmdSetStencilTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
	private static IntPtr vkCmdSetStencilTestEnableEXTPointer;
	private static vkCmdSetStencilTestEnableEXTDelegate_0 vkCmdSetStencilTestEnableEXT_0;
	public static void vkCmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp) => vkCmdSetStencilOpEXT_0(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
	private delegate void vkCmdSetStencilOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
	private static IntPtr vkCmdSetStencilOpEXTPointer;
	private static vkCmdSetStencilOpEXTDelegate_0 vkCmdSetStencilOpEXT_0;
	public static VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation) => vkCreateDeferredOperationKHR_0(device, pAllocator, pDeferredOperation);
	private delegate VkResult vkCreateDeferredOperationKHRDelegate_0(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation);
	private static IntPtr vkCreateDeferredOperationKHRPointer;
	private static vkCreateDeferredOperationKHRDelegate_0 vkCreateDeferredOperationKHR_0;
	public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator) => vkDestroyDeferredOperationKHR_0(device, operation, pAllocator);
	private delegate void vkDestroyDeferredOperationKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyDeferredOperationKHRPointer;
	private static vkDestroyDeferredOperationKHRDelegate_0 vkDestroyDeferredOperationKHR_0;
	public static uint32_t vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation) => vkGetDeferredOperationMaxConcurrencyKHR_0(device, operation);
	private delegate uint32_t vkGetDeferredOperationMaxConcurrencyKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static IntPtr vkGetDeferredOperationMaxConcurrencyKHRPointer;
	private static vkGetDeferredOperationMaxConcurrencyKHRDelegate_0 vkGetDeferredOperationMaxConcurrencyKHR_0;
	public static VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation) => vkGetDeferredOperationResultKHR_0(device, operation);
	private delegate VkResult vkGetDeferredOperationResultKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static IntPtr vkGetDeferredOperationResultKHRPointer;
	private static vkGetDeferredOperationResultKHRDelegate_0 vkGetDeferredOperationResultKHR_0;
	public static VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation) => vkDeferredOperationJoinKHR_0(device, operation);
	private delegate VkResult vkDeferredOperationJoinKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static IntPtr vkDeferredOperationJoinKHRPointer;
	private static vkDeferredOperationJoinKHRDelegate_0 vkDeferredOperationJoinKHR_0;
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
	public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetGeneratedCommandsMemoryRequirementsNV_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate_0(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetGeneratedCommandsMemoryRequirementsNVPointer;
	private static vkGetGeneratedCommandsMemoryRequirementsNVDelegate_0 vkGetGeneratedCommandsMemoryRequirementsNV_0;
	public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo) => vkCmdPreprocessGeneratedCommandsNV_0(commandBuffer, pGeneratedCommandsInfo);
	private delegate void vkCmdPreprocessGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
	private static IntPtr vkCmdPreprocessGeneratedCommandsNVPointer;
	private static vkCmdPreprocessGeneratedCommandsNVDelegate_0 vkCmdPreprocessGeneratedCommandsNV_0;
	public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo) => vkCmdExecuteGeneratedCommandsNV_0(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
	private delegate void vkCmdExecuteGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
	private static IntPtr vkCmdExecuteGeneratedCommandsNVPointer;
	private static vkCmdExecuteGeneratedCommandsNVDelegate_0 vkCmdExecuteGeneratedCommandsNV_0;
	public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint32_t groupIndex) => vkCmdBindPipelineShaderGroupNV_0(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
	private delegate void vkCmdBindPipelineShaderGroupNVDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint32_t groupIndex);
	private static IntPtr vkCmdBindPipelineShaderGroupNVPointer;
	private static vkCmdBindPipelineShaderGroupNVDelegate_0 vkCmdBindPipelineShaderGroupNV_0;
	public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout) => vkCreateIndirectCommandsLayoutNV_0(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
	private delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout);
	private static IntPtr vkCreateIndirectCommandsLayoutNVPointer;
	private static vkCreateIndirectCommandsLayoutNVDelegate_0 vkCreateIndirectCommandsLayoutNV_0;
	public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator) => vkDestroyIndirectCommandsLayoutNV_0(device, indirectCommandsLayout, pAllocator);
	private delegate void vkDestroyIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyIndirectCommandsLayoutNVPointer;
	private static vkDestroyIndirectCommandsLayoutNVDelegate_0 vkDestroyIndirectCommandsLayoutNV_0;
	public static VkResult vkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int32_t drmFd, VkDisplayKHR display) => vkAcquireDrmDisplayEXT_0(physicalDevice, drmFd, display);
	private delegate VkResult vkAcquireDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int32_t drmFd, VkDisplayKHR display);
	private static IntPtr vkAcquireDrmDisplayEXTPointer;
	private static vkAcquireDrmDisplayEXTDelegate_0 vkAcquireDrmDisplayEXT_0;
	public static VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int32_t drmFd, uint32_t connectorId, VkDisplayKHR* display) => vkGetDrmDisplayEXT_0(physicalDevice, drmFd, connectorId, display);
	private delegate VkResult vkGetDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int32_t drmFd, uint32_t connectorId, VkDisplayKHR* display);
	private static IntPtr vkGetDrmDisplayEXTPointer;
	private static vkGetDrmDisplayEXTDelegate_0 vkGetDrmDisplayEXT_0;
	public static VkResult vkCreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlotEXT* pPrivateDataSlot) => vkCreatePrivateDataSlotEXT_0(device, pCreateInfo, pAllocator, pPrivateDataSlot);
	private delegate VkResult vkCreatePrivateDataSlotEXTDelegate_0(VkDevice device, VkPrivateDataSlotCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlotEXT* pPrivateDataSlot);
	private static IntPtr vkCreatePrivateDataSlotEXTPointer;
	private static vkCreatePrivateDataSlotEXTDelegate_0 vkCreatePrivateDataSlotEXT_0;
	public static void vkDestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* pAllocator) => vkDestroyPrivateDataSlotEXT_0(device, privateDataSlot, pAllocator);
	private delegate void vkDestroyPrivateDataSlotEXTDelegate_0(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* pAllocator);
	private static IntPtr vkDestroyPrivateDataSlotEXTPointer;
	private static vkDestroyPrivateDataSlotEXTDelegate_0 vkDestroyPrivateDataSlotEXT_0;
	public static VkResult vkSetPrivateDataEXT(VkDevice device, VkObjectType objectType, uint64_t objectHandle, VkPrivateDataSlotEXT privateDataSlot, uint64_t data) => vkSetPrivateDataEXT_0(device, objectType, objectHandle, privateDataSlot, data);
	private delegate VkResult vkSetPrivateDataEXTDelegate_0(VkDevice device, VkObjectType objectType, uint64_t objectHandle, VkPrivateDataSlotEXT privateDataSlot, uint64_t data);
	private static IntPtr vkSetPrivateDataEXTPointer;
	private static vkSetPrivateDataEXTDelegate_0 vkSetPrivateDataEXT_0;
	public static void vkGetPrivateDataEXT(VkDevice device, VkObjectType objectType, uint64_t objectHandle, VkPrivateDataSlotEXT privateDataSlot, uint64_t* pData) => vkGetPrivateDataEXT_0(device, objectType, objectHandle, privateDataSlot, pData);
	private delegate void vkGetPrivateDataEXTDelegate_0(VkDevice device, VkObjectType objectType, uint64_t objectHandle, VkPrivateDataSlotEXT privateDataSlot, uint64_t* pData);
	private static IntPtr vkGetPrivateDataEXTPointer;
	private static vkGetPrivateDataEXTDelegate_0 vkGetPrivateDataEXT_0;
	public static void vkCmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent event, VkDependencyInfoKHR* pDependencyInfo) => vkCmdSetEvent2KHR_0(commandBuffer, event, pDependencyInfo);
	private delegate void vkCmdSetEvent2KHRDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkDependencyInfoKHR* pDependencyInfo);
	private static IntPtr vkCmdSetEvent2KHRPointer;
	private static vkCmdSetEvent2KHRDelegate_0 vkCmdSetEvent2KHR_0;
	public static void vkCmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags2KHR stageMask) => vkCmdResetEvent2KHR_0(commandBuffer, event, stageMask);
	private delegate void vkCmdResetEvent2KHRDelegate_0(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags2KHR stageMask);
	private static IntPtr vkCmdResetEvent2KHRPointer;
	private static vkCmdResetEvent2KHRDelegate_0 vkCmdResetEvent2KHR_0;
	public static void vkCmdWaitEvents2KHR(VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkDependencyInfoKHR* pDependencyInfos) => vkCmdWaitEvents2KHR_0(commandBuffer, eventCount, pEvents, pDependencyInfos);
	private delegate void vkCmdWaitEvents2KHRDelegate_0(VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkDependencyInfoKHR* pDependencyInfos);
	private static IntPtr vkCmdWaitEvents2KHRPointer;
	private static vkCmdWaitEvents2KHRDelegate_0 vkCmdWaitEvents2KHR_0;
	public static void vkCmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* pDependencyInfo) => vkCmdPipelineBarrier2KHR_0(commandBuffer, pDependencyInfo);
	private delegate void vkCmdPipelineBarrier2KHRDelegate_0(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* pDependencyInfo);
	private static IntPtr vkCmdPipelineBarrier2KHRPointer;
	private static vkCmdPipelineBarrier2KHRDelegate_0 vkCmdPipelineBarrier2KHR_0;
	public static void vkCmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint32_t query) => vkCmdWriteTimestamp2KHR_0(commandBuffer, stage, queryPool, query);
	private delegate void vkCmdWriteTimestamp2KHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint32_t query);
	private static IntPtr vkCmdWriteTimestamp2KHRPointer;
	private static vkCmdWriteTimestamp2KHRDelegate_0 vkCmdWriteTimestamp2KHR_0;
	public static VkResult vkQueueSubmit2KHR(VkQueue queue, uint32_t submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence) => vkQueueSubmit2KHR_0(queue, submitCount, pSubmits, fence);
	private delegate VkResult vkQueueSubmit2KHRDelegate_0(VkQueue queue, uint32_t submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence);
	private static IntPtr vkQueueSubmit2KHRPointer;
	private static vkQueueSubmit2KHRDelegate_0 vkQueueSubmit2KHR_0;
	public static void vkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint32_t marker) => vkCmdWriteBufferMarker2AMD_0(commandBuffer, stage, dstBuffer, dstOffset, marker);
	private delegate void vkCmdWriteBufferMarker2AMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint32_t marker);
	private static IntPtr vkCmdWriteBufferMarker2AMDPointer;
	private static vkCmdWriteBufferMarker2AMDDelegate_0 vkCmdWriteBufferMarker2AMD_0;
	public static void vkGetQueueCheckpointData2NV(VkQueue queue, uint32_t* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData) => vkGetQueueCheckpointData2NV_0(queue, pCheckpointDataCount, pCheckpointData);
	private delegate void vkGetQueueCheckpointData2NVDelegate_0(VkQueue queue, uint32_t* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData);
	private static IntPtr vkGetQueueCheckpointData2NVPointer;
	private static vkGetQueueCheckpointData2NVDelegate_0 vkGetQueueCheckpointData2NV_0;
	public static void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps) => vkCmdSetFragmentShadingRateEnumNV_0(commandBuffer, shadingRate, combinerOps);
	private delegate void vkCmdSetFragmentShadingRateEnumNVDelegate_0(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps);
	private static IntPtr vkCmdSetFragmentShadingRateEnumNVPointer;
	private static vkCmdSetFragmentShadingRateEnumNVDelegate_0 vkCmdSetFragmentShadingRateEnumNV_0;
	public static void vkCmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* pCopyBufferInfo) => vkCmdCopyBuffer2KHR_0(commandBuffer, pCopyBufferInfo);
	private delegate void vkCmdCopyBuffer2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* pCopyBufferInfo);
	private static IntPtr vkCmdCopyBuffer2KHRPointer;
	private static vkCmdCopyBuffer2KHRDelegate_0 vkCmdCopyBuffer2KHR_0;
	public static void vkCmdCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* pCopyImageInfo) => vkCmdCopyImage2KHR_0(commandBuffer, pCopyImageInfo);
	private delegate void vkCmdCopyImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* pCopyImageInfo);
	private static IntPtr vkCmdCopyImage2KHRPointer;
	private static vkCmdCopyImage2KHRDelegate_0 vkCmdCopyImage2KHR_0;
	public static void vkCmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo) => vkCmdCopyBufferToImage2KHR_0(commandBuffer, pCopyBufferToImageInfo);
	private delegate void vkCmdCopyBufferToImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);
	private static IntPtr vkCmdCopyBufferToImage2KHRPointer;
	private static vkCmdCopyBufferToImage2KHRDelegate_0 vkCmdCopyBufferToImage2KHR_0;
	public static void vkCmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo) => vkCmdCopyImageToBuffer2KHR_0(commandBuffer, pCopyImageToBufferInfo);
	private delegate void vkCmdCopyImageToBuffer2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);
	private static IntPtr vkCmdCopyImageToBuffer2KHRPointer;
	private static vkCmdCopyImageToBuffer2KHRDelegate_0 vkCmdCopyImageToBuffer2KHR_0;
	public static void vkCmdBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* pBlitImageInfo) => vkCmdBlitImage2KHR_0(commandBuffer, pBlitImageInfo);
	private delegate void vkCmdBlitImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* pBlitImageInfo);
	private static IntPtr vkCmdBlitImage2KHRPointer;
	private static vkCmdBlitImage2KHRDelegate_0 vkCmdBlitImage2KHR_0;
	public static void vkCmdResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* pResolveImageInfo) => vkCmdResolveImage2KHR_0(commandBuffer, pResolveImageInfo);
	private delegate void vkCmdResolveImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* pResolveImageInfo);
	private static IntPtr vkCmdResolveImage2KHRPointer;
	private static vkCmdResolveImage2KHRDelegate_0 vkCmdResolveImage2KHR_0;
	public static VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => vkAcquireWinrtDisplayNV_0(physicalDevice, display);
	private delegate VkResult vkAcquireWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static IntPtr vkAcquireWinrtDisplayNVPointer;
	private static vkAcquireWinrtDisplayNVDelegate_0 vkAcquireWinrtDisplayNV_0;
	public static VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint32_t deviceRelativeId, VkDisplayKHR* pDisplay) => vkGetWinrtDisplayNV_0(physicalDevice, deviceRelativeId, pDisplay);
	private delegate VkResult vkGetWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, uint32_t deviceRelativeId, VkDisplayKHR* pDisplay);
	private static IntPtr vkGetWinrtDisplayNVPointer;
	private static vkGetWinrtDisplayNVDelegate_0 vkGetWinrtDisplayNV_0;
	public static void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint32_t vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint32_t vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions) => vkCmdSetVertexInputEXT_0(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
	private delegate void vkCmdSetVertexInputEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint32_t vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);
	private static IntPtr vkCmdSetVertexInputEXTPointer;
	private static vkCmdSetVertexInputEXTDelegate_0 vkCmdSetVertexInputEXT_0;
	public static VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize) => vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0(device, renderpass, pMaxWorkgroupSize);
	private delegate VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize);
	private static IntPtr vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer;
	private static vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0 vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0;
	public static void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer) => vkCmdSubpassShadingHUAWEI_0(commandBuffer);
	private delegate void vkCmdSubpassShadingHUAWEIDelegate_0(VkCommandBuffer commandBuffer);
	private static IntPtr vkCmdSubpassShadingHUAWEIPointer;
	private static vkCmdSubpassShadingHUAWEIDelegate_0 vkCmdSubpassShadingHUAWEI_0;
	public static void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => vkCmdBindInvocationMaskHUAWEI_0(commandBuffer, imageView, imageLayout);
	private delegate void vkCmdBindInvocationMaskHUAWEIDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
	private static IntPtr vkCmdBindInvocationMaskHUAWEIPointer;
	private static vkCmdBindInvocationMaskHUAWEIDelegate_0 vkCmdBindInvocationMaskHUAWEI_0;
	public static VkResult vkGetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, VkRemoteAddressNV* pAddress) => vkGetMemoryRemoteAddressNV_0(device, pMemoryGetRemoteAddressInfo, pAddress);
	private delegate VkResult vkGetMemoryRemoteAddressNVDelegate_0(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, VkRemoteAddressNV* pAddress);
	private static IntPtr vkGetMemoryRemoteAddressNVPointer;
	private static vkGetMemoryRemoteAddressNVDelegate_0 vkGetMemoryRemoteAddressNV_0;
	public static void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint32_t patchControlPoints) => vkCmdSetPatchControlPointsEXT_0(commandBuffer, patchControlPoints);
	private delegate void vkCmdSetPatchControlPointsEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t patchControlPoints);
	private static IntPtr vkCmdSetPatchControlPointsEXTPointer;
	private static vkCmdSetPatchControlPointsEXTDelegate_0 vkCmdSetPatchControlPointsEXT_0;
	public static void vkCmdSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable) => vkCmdSetRasterizerDiscardEnableEXT_0(commandBuffer, rasterizerDiscardEnable);
	private delegate void vkCmdSetRasterizerDiscardEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
	private static IntPtr vkCmdSetRasterizerDiscardEnableEXTPointer;
	private static vkCmdSetRasterizerDiscardEnableEXTDelegate_0 vkCmdSetRasterizerDiscardEnableEXT_0;
	public static void vkCmdSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable) => vkCmdSetDepthBiasEnableEXT_0(commandBuffer, depthBiasEnable);
	private delegate void vkCmdSetDepthBiasEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
	private static IntPtr vkCmdSetDepthBiasEnableEXTPointer;
	private static vkCmdSetDepthBiasEnableEXTDelegate_0 vkCmdSetDepthBiasEnableEXT_0;
	public static void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp) => vkCmdSetLogicOpEXT_0(commandBuffer, logicOp);
	private delegate void vkCmdSetLogicOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
	private static IntPtr vkCmdSetLogicOpEXTPointer;
	private static vkCmdSetLogicOpEXTDelegate_0 vkCmdSetLogicOpEXT_0;
	public static void vkCmdSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable) => vkCmdSetPrimitiveRestartEnableEXT_0(commandBuffer, primitiveRestartEnable);
	private delegate void vkCmdSetPrimitiveRestartEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
	private static IntPtr vkCmdSetPrimitiveRestartEnableEXTPointer;
	private static vkCmdSetPrimitiveRestartEnableEXTDelegate_0 vkCmdSetPrimitiveRestartEnableEXT_0;
	public static void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkBool32* pColorWriteEnables) => vkCmdSetColorWriteEnableEXT_0(commandBuffer, attachmentCount, pColorWriteEnables);
	private delegate void vkCmdSetColorWriteEnableEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkBool32* pColorWriteEnables);
	private static IntPtr vkCmdSetColorWriteEnableEXTPointer;
	private static vkCmdSetColorWriteEnableEXTDelegate_0 vkCmdSetColorWriteEnableEXT_0;
	public static void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint32_t drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint32_t instanceCount, uint32_t firstInstance, uint32_t stride) => vkCmdDrawMultiEXT_0(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
	private delegate void vkCmdDrawMultiEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint32_t instanceCount, uint32_t firstInstance, uint32_t stride);
	private static IntPtr vkCmdDrawMultiEXTPointer;
	private static vkCmdDrawMultiEXTDelegate_0 vkCmdDrawMultiEXT_0;
	public static void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint32_t drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint32_t instanceCount, uint32_t firstInstance, uint32_t stride, int32_t* pVertexOffset) => vkCmdDrawMultiIndexedEXT_0(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
	private delegate void vkCmdDrawMultiIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, uint32_t drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint32_t instanceCount, uint32_t firstInstance, uint32_t stride, int32_t* pVertexOffset);
	private static IntPtr vkCmdDrawMultiIndexedEXTPointer;
	private static vkCmdDrawMultiIndexedEXTDelegate_0 vkCmdDrawMultiIndexedEXT_0;
	public static void vkSetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority) => vkSetDeviceMemoryPriorityEXT_0(device, memory, priority);
	private delegate void vkSetDeviceMemoryPriorityEXTDelegate_0(VkDevice device, VkDeviceMemory memory, float priority);
	private static IntPtr vkSetDeviceMemoryPriorityEXTPointer;
	private static vkSetDeviceMemoryPriorityEXTDelegate_0 vkSetDeviceMemoryPriorityEXT_0;
	public static void vkGetDeviceBufferMemoryRequirementsKHR(VkDevice device, VkDeviceBufferMemoryRequirementsKHR* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetDeviceBufferMemoryRequirementsKHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetDeviceBufferMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceBufferMemoryRequirementsKHR* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetDeviceBufferMemoryRequirementsKHRPointer;
	private static vkGetDeviceBufferMemoryRequirementsKHRDelegate_0 vkGetDeviceBufferMemoryRequirementsKHR_0;
	public static void vkGetDeviceImageMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirementsKHR* pInfo, VkMemoryRequirements2* pMemoryRequirements) => vkGetDeviceImageMemoryRequirementsKHR_0(device, pInfo, pMemoryRequirements);
	private delegate void vkGetDeviceImageMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceImageMemoryRequirementsKHR* pInfo, VkMemoryRequirements2* pMemoryRequirements);
	private static IntPtr vkGetDeviceImageMemoryRequirementsKHRPointer;
	private static vkGetDeviceImageMemoryRequirementsKHRDelegate_0 vkGetDeviceImageMemoryRequirementsKHR_0;
	public static void vkGetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirementsKHR* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements) => vkGetDeviceImageSparseMemoryRequirementsKHR_0(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
	private delegate void vkGetDeviceImageSparseMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceImageMemoryRequirementsKHR* pInfo, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
	private static IntPtr vkGetDeviceImageSparseMemoryRequirementsKHRPointer;
	private static vkGetDeviceImageSparseMemoryRequirementsKHRDelegate_0 vkGetDeviceImageSparseMemoryRequirementsKHR_0;
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
		vkCmdDrawIndirectCountPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCount");
		if (vkCmdDrawIndirectCountPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountDelegate_0>(vkCmdDrawIndirectCountPointer);
		}
		vkCmdDrawIndexedIndirectCountPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCount");
		if (vkCmdDrawIndexedIndirectCountPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexedIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedIndirectCountDelegate_0>(vkCmdDrawIndexedIndirectCountPointer);
		}
		vkCreateRenderPass2Pointer = vkGetInstanceProcAddr(instance, "vkCreateRenderPass2");
		if (vkCreateRenderPass2Pointer != IntPtr.Zero)
		{
			vkCreateRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRenderPass2Delegate_0>(vkCreateRenderPass2Pointer);
		}
		vkCmdBeginRenderPass2Pointer = vkGetInstanceProcAddr(instance, "vkCmdBeginRenderPass2");
		if (vkCmdBeginRenderPass2Pointer != IntPtr.Zero)
		{
			vkCmdBeginRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginRenderPass2Delegate_0>(vkCmdBeginRenderPass2Pointer);
		}
		vkCmdNextSubpass2Pointer = vkGetInstanceProcAddr(instance, "vkCmdNextSubpass2");
		if (vkCmdNextSubpass2Pointer != IntPtr.Zero)
		{
			vkCmdNextSubpass2_0 = Marshal.GetDelegateForFunctionPointer<vkCmdNextSubpass2Delegate_0>(vkCmdNextSubpass2Pointer);
		}
		vkCmdEndRenderPass2Pointer = vkGetInstanceProcAddr(instance, "vkCmdEndRenderPass2");
		if (vkCmdEndRenderPass2Pointer != IntPtr.Zero)
		{
			vkCmdEndRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndRenderPass2Delegate_0>(vkCmdEndRenderPass2Pointer);
		}
		vkResetQueryPoolPointer = vkGetInstanceProcAddr(instance, "vkResetQueryPool");
		if (vkResetQueryPoolPointer != IntPtr.Zero)
		{
			vkResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<vkResetQueryPoolDelegate_0>(vkResetQueryPoolPointer);
		}
		vkGetSemaphoreCounterValuePointer = vkGetInstanceProcAddr(instance, "vkGetSemaphoreCounterValue");
		if (vkGetSemaphoreCounterValuePointer != IntPtr.Zero)
		{
			vkGetSemaphoreCounterValue_0 = Marshal.GetDelegateForFunctionPointer<vkGetSemaphoreCounterValueDelegate_0>(vkGetSemaphoreCounterValuePointer);
		}
		vkWaitSemaphoresPointer = vkGetInstanceProcAddr(instance, "vkWaitSemaphores");
		if (vkWaitSemaphoresPointer != IntPtr.Zero)
		{
			vkWaitSemaphores_0 = Marshal.GetDelegateForFunctionPointer<vkWaitSemaphoresDelegate_0>(vkWaitSemaphoresPointer);
		}
		vkSignalSemaphorePointer = vkGetInstanceProcAddr(instance, "vkSignalSemaphore");
		if (vkSignalSemaphorePointer != IntPtr.Zero)
		{
			vkSignalSemaphore_0 = Marshal.GetDelegateForFunctionPointer<vkSignalSemaphoreDelegate_0>(vkSignalSemaphorePointer);
		}
		vkGetBufferDeviceAddressPointer = vkGetInstanceProcAddr(instance, "vkGetBufferDeviceAddress");
		if (vkGetBufferDeviceAddressPointer != IntPtr.Zero)
		{
			vkGetBufferDeviceAddress_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferDeviceAddressDelegate_0>(vkGetBufferDeviceAddressPointer);
		}
		vkGetBufferOpaqueCaptureAddressPointer = vkGetInstanceProcAddr(instance, "vkGetBufferOpaqueCaptureAddress");
		if (vkGetBufferOpaqueCaptureAddressPointer != IntPtr.Zero)
		{
			vkGetBufferOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferOpaqueCaptureAddressDelegate_0>(vkGetBufferOpaqueCaptureAddressPointer);
		}
		vkGetDeviceMemoryOpaqueCaptureAddressPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceMemoryOpaqueCaptureAddress");
		if (vkGetDeviceMemoryOpaqueCaptureAddressPointer != IntPtr.Zero)
		{
			vkGetDeviceMemoryOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceMemoryOpaqueCaptureAddressDelegate_0>(vkGetDeviceMemoryOpaqueCaptureAddressPointer);
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
		vkCreateCuModuleNVXPointer = vkGetInstanceProcAddr(instance, "vkCreateCuModuleNVX");
		if (vkCreateCuModuleNVXPointer != IntPtr.Zero)
		{
			vkCreateCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCreateCuModuleNVXDelegate_0>(vkCreateCuModuleNVXPointer);
		}
		vkCreateCuFunctionNVXPointer = vkGetInstanceProcAddr(instance, "vkCreateCuFunctionNVX");
		if (vkCreateCuFunctionNVXPointer != IntPtr.Zero)
		{
			vkCreateCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCreateCuFunctionNVXDelegate_0>(vkCreateCuFunctionNVXPointer);
		}
		vkDestroyCuModuleNVXPointer = vkGetInstanceProcAddr(instance, "vkDestroyCuModuleNVX");
		if (vkDestroyCuModuleNVXPointer != IntPtr.Zero)
		{
			vkDestroyCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyCuModuleNVXDelegate_0>(vkDestroyCuModuleNVXPointer);
		}
		vkDestroyCuFunctionNVXPointer = vkGetInstanceProcAddr(instance, "vkDestroyCuFunctionNVX");
		if (vkDestroyCuFunctionNVXPointer != IntPtr.Zero)
		{
			vkDestroyCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyCuFunctionNVXDelegate_0>(vkDestroyCuFunctionNVXPointer);
		}
		vkCmdCuLaunchKernelNVXPointer = vkGetInstanceProcAddr(instance, "vkCmdCuLaunchKernelNVX");
		if (vkCmdCuLaunchKernelNVXPointer != IntPtr.Zero)
		{
			vkCmdCuLaunchKernelNVX_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCuLaunchKernelNVXDelegate_0>(vkCmdCuLaunchKernelNVXPointer);
		}
		vkGetImageViewHandleNVXPointer = vkGetInstanceProcAddr(instance, "vkGetImageViewHandleNVX");
		if (vkGetImageViewHandleNVXPointer != IntPtr.Zero)
		{
			vkGetImageViewHandleNVX_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageViewHandleNVXDelegate_0>(vkGetImageViewHandleNVXPointer);
		}
		vkGetImageViewAddressNVXPointer = vkGetInstanceProcAddr(instance, "vkGetImageViewAddressNVX");
		if (vkGetImageViewAddressNVXPointer != IntPtr.Zero)
		{
			vkGetImageViewAddressNVX_0 = Marshal.GetDelegateForFunctionPointer<vkGetImageViewAddressNVXDelegate_0>(vkGetImageViewAddressNVXPointer);
		}
		vkCmdDrawIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCount");
		if (vkCmdDrawIndirectCountAMDPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountAMDDelegate_0>(vkCmdDrawIndirectCountAMDPointer);
		}
		vkCmdDrawIndexedIndirectCountAMDPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCount");
		if (vkCmdDrawIndexedIndirectCountAMDPointer != IntPtr.Zero)
		{
			vkCmdDrawIndexedIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndexedIndirectCountAMDDelegate_0>(vkCmdDrawIndexedIndirectCountAMDPointer);
		}
		vkGetShaderInfoAMDPointer = vkGetInstanceProcAddr(instance, "vkGetShaderInfoAMD");
		if (vkGetShaderInfoAMDPointer != IntPtr.Zero)
		{
			vkGetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<vkGetShaderInfoAMDDelegate_0>(vkGetShaderInfoAMDPointer);
		}
		vkCmdBeginRenderingKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginRenderingKHR");
		if (vkCmdBeginRenderingKHRPointer != IntPtr.Zero)
		{
			vkCmdBeginRenderingKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginRenderingKHRDelegate_0>(vkCmdBeginRenderingKHRPointer);
		}
		vkCmdEndRenderingKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdEndRenderingKHR");
		if (vkCmdEndRenderingKHRPointer != IntPtr.Zero)
		{
			vkCmdEndRenderingKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdEndRenderingKHRDelegate_0>(vkCmdEndRenderingKHRPointer);
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
		vkCreateRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCreateRenderPass2");
		if (vkCreateRenderPass2KHRPointer != IntPtr.Zero)
		{
			vkCreateRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRenderPass2KHRDelegate_0>(vkCreateRenderPass2KHRPointer);
		}
		vkCmdBeginRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBeginRenderPass2");
		if (vkCmdBeginRenderPass2KHRPointer != IntPtr.Zero)
		{
			vkCmdBeginRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBeginRenderPass2KHRDelegate_0>(vkCmdBeginRenderPass2KHRPointer);
		}
		vkCmdNextSubpass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdNextSubpass2");
		if (vkCmdNextSubpass2KHRPointer != IntPtr.Zero)
		{
			vkCmdNextSubpass2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdNextSubpass2KHRDelegate_0>(vkCmdNextSubpass2KHRPointer);
		}
		vkCmdEndRenderPass2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdEndRenderPass2");
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
		vkCreateAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateAccelerationStructureKHR");
		if (vkCreateAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkCreateAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateAccelerationStructureKHRDelegate_0>(vkCreateAccelerationStructureKHRPointer);
		}
		vkDestroyAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroyAccelerationStructureKHR");
		if (vkDestroyAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkDestroyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyAccelerationStructureKHRDelegate_0>(vkDestroyAccelerationStructureKHRPointer);
		}
		vkCmdBuildAccelerationStructuresKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBuildAccelerationStructuresKHR");
		if (vkCmdBuildAccelerationStructuresKHRPointer != IntPtr.Zero)
		{
			vkCmdBuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBuildAccelerationStructuresKHRDelegate_0>(vkCmdBuildAccelerationStructuresKHRPointer);
		}
		vkCmdBuildAccelerationStructuresIndirectKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBuildAccelerationStructuresIndirectKHR");
		if (vkCmdBuildAccelerationStructuresIndirectKHRPointer != IntPtr.Zero)
		{
			vkCmdBuildAccelerationStructuresIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBuildAccelerationStructuresIndirectKHRDelegate_0>(vkCmdBuildAccelerationStructuresIndirectKHRPointer);
		}
		vkBuildAccelerationStructuresKHRPointer = vkGetInstanceProcAddr(instance, "vkBuildAccelerationStructuresKHR");
		if (vkBuildAccelerationStructuresKHRPointer != IntPtr.Zero)
		{
			vkBuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<vkBuildAccelerationStructuresKHRDelegate_0>(vkBuildAccelerationStructuresKHRPointer);
		}
		vkCopyAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkCopyAccelerationStructureKHR");
		if (vkCopyAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkCopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCopyAccelerationStructureKHRDelegate_0>(vkCopyAccelerationStructureKHRPointer);
		}
		vkCopyAccelerationStructureToMemoryKHRPointer = vkGetInstanceProcAddr(instance, "vkCopyAccelerationStructureToMemoryKHR");
		if (vkCopyAccelerationStructureToMemoryKHRPointer != IntPtr.Zero)
		{
			vkCopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCopyAccelerationStructureToMemoryKHRDelegate_0>(vkCopyAccelerationStructureToMemoryKHRPointer);
		}
		vkCopyMemoryToAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkCopyMemoryToAccelerationStructureKHR");
		if (vkCopyMemoryToAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkCopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCopyMemoryToAccelerationStructureKHRDelegate_0>(vkCopyMemoryToAccelerationStructureKHRPointer);
		}
		vkWriteAccelerationStructuresPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkWriteAccelerationStructuresPropertiesKHR");
		if (vkWriteAccelerationStructuresPropertiesKHRPointer != IntPtr.Zero)
		{
			vkWriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkWriteAccelerationStructuresPropertiesKHRDelegate_0>(vkWriteAccelerationStructuresPropertiesKHRPointer);
		}
		vkCmdCopyAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyAccelerationStructureKHR");
		if (vkCmdCopyAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkCmdCopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyAccelerationStructureKHRDelegate_0>(vkCmdCopyAccelerationStructureKHRPointer);
		}
		vkCmdCopyAccelerationStructureToMemoryKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyAccelerationStructureToMemoryKHR");
		if (vkCmdCopyAccelerationStructureToMemoryKHRPointer != IntPtr.Zero)
		{
			vkCmdCopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyAccelerationStructureToMemoryKHRDelegate_0>(vkCmdCopyAccelerationStructureToMemoryKHRPointer);
		}
		vkCmdCopyMemoryToAccelerationStructureKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyMemoryToAccelerationStructureKHR");
		if (vkCmdCopyMemoryToAccelerationStructureKHRPointer != IntPtr.Zero)
		{
			vkCmdCopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyMemoryToAccelerationStructureKHRDelegate_0>(vkCmdCopyMemoryToAccelerationStructureKHRPointer);
		}
		vkGetAccelerationStructureDeviceAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetAccelerationStructureDeviceAddressKHR");
		if (vkGetAccelerationStructureDeviceAddressKHRPointer != IntPtr.Zero)
		{
			vkGetAccelerationStructureDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetAccelerationStructureDeviceAddressKHRDelegate_0>(vkGetAccelerationStructureDeviceAddressKHRPointer);
		}
		vkCmdWriteAccelerationStructuresPropertiesKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteAccelerationStructuresPropertiesKHR");
		if (vkCmdWriteAccelerationStructuresPropertiesKHRPointer != IntPtr.Zero)
		{
			vkCmdWriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteAccelerationStructuresPropertiesKHRDelegate_0>(vkCmdWriteAccelerationStructuresPropertiesKHRPointer);
		}
		vkGetDeviceAccelerationStructureCompatibilityKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceAccelerationStructureCompatibilityKHR");
		if (vkGetDeviceAccelerationStructureCompatibilityKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceAccelerationStructureCompatibilityKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceAccelerationStructureCompatibilityKHRDelegate_0>(vkGetDeviceAccelerationStructureCompatibilityKHRPointer);
		}
		vkGetAccelerationStructureBuildSizesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetAccelerationStructureBuildSizesKHR");
		if (vkGetAccelerationStructureBuildSizesKHRPointer != IntPtr.Zero)
		{
			vkGetAccelerationStructureBuildSizesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetAccelerationStructureBuildSizesKHRDelegate_0>(vkGetAccelerationStructureBuildSizesKHRPointer);
		}
		vkCmdTraceRaysKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdTraceRaysKHR");
		if (vkCmdTraceRaysKHRPointer != IntPtr.Zero)
		{
			vkCmdTraceRaysKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdTraceRaysKHRDelegate_0>(vkCmdTraceRaysKHRPointer);
		}
		vkCreateRayTracingPipelinesKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateRayTracingPipelinesKHR");
		if (vkCreateRayTracingPipelinesKHRPointer != IntPtr.Zero)
		{
			vkCreateRayTracingPipelinesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateRayTracingPipelinesKHRDelegate_0>(vkCreateRayTracingPipelinesKHRPointer);
		}
		vkGetRayTracingShaderGroupHandlesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetRayTracingShaderGroupHandlesKHR");
		if (vkGetRayTracingShaderGroupHandlesKHRPointer != IntPtr.Zero)
		{
			vkGetRayTracingShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetRayTracingShaderGroupHandlesKHRDelegate_0>(vkGetRayTracingShaderGroupHandlesKHRPointer);
		}
		vkGetRayTracingCaptureReplayShaderGroupHandlesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
		if (vkGetRayTracingCaptureReplayShaderGroupHandlesKHRPointer != IntPtr.Zero)
		{
			vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0>(vkGetRayTracingCaptureReplayShaderGroupHandlesKHRPointer);
		}
		vkCmdTraceRaysIndirectKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdTraceRaysIndirectKHR");
		if (vkCmdTraceRaysIndirectKHRPointer != IntPtr.Zero)
		{
			vkCmdTraceRaysIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdTraceRaysIndirectKHRDelegate_0>(vkCmdTraceRaysIndirectKHRPointer);
		}
		vkGetRayTracingShaderGroupStackSizeKHRPointer = vkGetInstanceProcAddr(instance, "vkGetRayTracingShaderGroupStackSizeKHR");
		if (vkGetRayTracingShaderGroupStackSizeKHRPointer != IntPtr.Zero)
		{
			vkGetRayTracingShaderGroupStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetRayTracingShaderGroupStackSizeKHRDelegate_0>(vkGetRayTracingShaderGroupStackSizeKHRPointer);
		}
		vkCmdSetRayTracingPipelineStackSizeKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdSetRayTracingPipelineStackSizeKHR");
		if (vkCmdSetRayTracingPipelineStackSizeKHRPointer != IntPtr.Zero)
		{
			vkCmdSetRayTracingPipelineStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetRayTracingPipelineStackSizeKHRDelegate_0>(vkCmdSetRayTracingPipelineStackSizeKHRPointer);
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
		vkGetRayTracingShaderGroupHandlesNVPointer = vkGetInstanceProcAddr(instance, "vkGetRayTracingShaderGroupHandlesKHR");
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
		vkCmdDrawIndirectCountKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndirectCount");
		if (vkCmdDrawIndirectCountKHRPointer != IntPtr.Zero)
		{
			vkCmdDrawIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawIndirectCountKHRDelegate_0>(vkCmdDrawIndirectCountKHRPointer);
		}
		vkCmdDrawIndexedIndirectCountKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawIndexedIndirectCount");
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
		vkGetSemaphoreCounterValueKHRPointer = vkGetInstanceProcAddr(instance, "vkGetSemaphoreCounterValue");
		if (vkGetSemaphoreCounterValueKHRPointer != IntPtr.Zero)
		{
			vkGetSemaphoreCounterValueKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetSemaphoreCounterValueKHRDelegate_0>(vkGetSemaphoreCounterValueKHRPointer);
		}
		vkWaitSemaphoresKHRPointer = vkGetInstanceProcAddr(instance, "vkWaitSemaphores");
		if (vkWaitSemaphoresKHRPointer != IntPtr.Zero)
		{
			vkWaitSemaphoresKHR_0 = Marshal.GetDelegateForFunctionPointer<vkWaitSemaphoresKHRDelegate_0>(vkWaitSemaphoresKHRPointer);
		}
		vkSignalSemaphoreKHRPointer = vkGetInstanceProcAddr(instance, "vkSignalSemaphore");
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
		vkGetPhysicalDeviceFragmentShadingRatesKHRPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
		if (vkGetPhysicalDeviceFragmentShadingRatesKHRPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceFragmentShadingRatesKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate_0>(vkGetPhysicalDeviceFragmentShadingRatesKHRPointer);
		}
		vkCmdSetFragmentShadingRateKHRPointer = vkGetInstanceProcAddr(instance, "vkCmdSetFragmentShadingRateKHR");
		if (vkCmdSetFragmentShadingRateKHRPointer != IntPtr.Zero)
		{
			vkCmdSetFragmentShadingRateKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetFragmentShadingRateKHRDelegate_0>(vkCmdSetFragmentShadingRateKHRPointer);
		}
		vkGetBufferDeviceAddressEXTPointer = vkGetInstanceProcAddr(instance, "vkGetBufferDeviceAddress");
		if (vkGetBufferDeviceAddressEXTPointer != IntPtr.Zero)
		{
			vkGetBufferDeviceAddressEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferDeviceAddressEXTDelegate_0>(vkGetBufferDeviceAddressEXTPointer);
		}
		vkGetPhysicalDeviceToolPropertiesEXTPointer = vkGetInstanceProcAddr(instance, "vkGetPhysicalDeviceToolPropertiesEXT");
		if (vkGetPhysicalDeviceToolPropertiesEXTPointer != IntPtr.Zero)
		{
			vkGetPhysicalDeviceToolPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPhysicalDeviceToolPropertiesEXTDelegate_0>(vkGetPhysicalDeviceToolPropertiesEXTPointer);
		}
		vkWaitForPresentKHRPointer = vkGetInstanceProcAddr(instance, "vkWaitForPresentKHR");
		if (vkWaitForPresentKHRPointer != IntPtr.Zero)
		{
			vkWaitForPresentKHR_0 = Marshal.GetDelegateForFunctionPointer<vkWaitForPresentKHRDelegate_0>(vkWaitForPresentKHRPointer);
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
		vkGetBufferDeviceAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferDeviceAddress");
		if (vkGetBufferDeviceAddressKHRPointer != IntPtr.Zero)
		{
			vkGetBufferDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferDeviceAddressKHRDelegate_0>(vkGetBufferDeviceAddressKHRPointer);
		}
		vkGetBufferOpaqueCaptureAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetBufferOpaqueCaptureAddress");
		if (vkGetBufferOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			vkGetBufferOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetBufferOpaqueCaptureAddressKHRDelegate_0>(vkGetBufferOpaqueCaptureAddressKHRPointer);
		}
		vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceMemoryOpaqueCaptureAddress");
		if (vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceMemoryOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0>(vkGetDeviceMemoryOpaqueCaptureAddressKHRPointer);
		}
		vkCmdSetLineStippleEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetLineStippleEXT");
		if (vkCmdSetLineStippleEXTPointer != IntPtr.Zero)
		{
			vkCmdSetLineStippleEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetLineStippleEXTDelegate_0>(vkCmdSetLineStippleEXTPointer);
		}
		vkResetQueryPoolEXTPointer = vkGetInstanceProcAddr(instance, "vkResetQueryPool");
		if (vkResetQueryPoolEXTPointer != IntPtr.Zero)
		{
			vkResetQueryPoolEXT_0 = Marshal.GetDelegateForFunctionPointer<vkResetQueryPoolEXTDelegate_0>(vkResetQueryPoolEXTPointer);
		}
		vkCmdSetCullModeEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetCullModeEXT");
		if (vkCmdSetCullModeEXTPointer != IntPtr.Zero)
		{
			vkCmdSetCullModeEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetCullModeEXTDelegate_0>(vkCmdSetCullModeEXTPointer);
		}
		vkCmdSetFrontFaceEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetFrontFaceEXT");
		if (vkCmdSetFrontFaceEXTPointer != IntPtr.Zero)
		{
			vkCmdSetFrontFaceEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetFrontFaceEXTDelegate_0>(vkCmdSetFrontFaceEXTPointer);
		}
		vkCmdSetPrimitiveTopologyEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPrimitiveTopologyEXT");
		if (vkCmdSetPrimitiveTopologyEXTPointer != IntPtr.Zero)
		{
			vkCmdSetPrimitiveTopologyEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPrimitiveTopologyEXTDelegate_0>(vkCmdSetPrimitiveTopologyEXTPointer);
		}
		vkCmdSetViewportWithCountEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetViewportWithCountEXT");
		if (vkCmdSetViewportWithCountEXTPointer != IntPtr.Zero)
		{
			vkCmdSetViewportWithCountEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetViewportWithCountEXTDelegate_0>(vkCmdSetViewportWithCountEXTPointer);
		}
		vkCmdSetScissorWithCountEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetScissorWithCountEXT");
		if (vkCmdSetScissorWithCountEXTPointer != IntPtr.Zero)
		{
			vkCmdSetScissorWithCountEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetScissorWithCountEXTDelegate_0>(vkCmdSetScissorWithCountEXTPointer);
		}
		vkCmdBindVertexBuffers2EXTPointer = vkGetInstanceProcAddr(instance, "vkCmdBindVertexBuffers2EXT");
		if (vkCmdBindVertexBuffers2EXTPointer != IntPtr.Zero)
		{
			vkCmdBindVertexBuffers2EXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindVertexBuffers2EXTDelegate_0>(vkCmdBindVertexBuffers2EXTPointer);
		}
		vkCmdSetDepthTestEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthTestEnableEXT");
		if (vkCmdSetDepthTestEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDepthTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthTestEnableEXTDelegate_0>(vkCmdSetDepthTestEnableEXTPointer);
		}
		vkCmdSetDepthWriteEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthWriteEnableEXT");
		if (vkCmdSetDepthWriteEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDepthWriteEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthWriteEnableEXTDelegate_0>(vkCmdSetDepthWriteEnableEXTPointer);
		}
		vkCmdSetDepthCompareOpEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthCompareOpEXT");
		if (vkCmdSetDepthCompareOpEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDepthCompareOpEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthCompareOpEXTDelegate_0>(vkCmdSetDepthCompareOpEXTPointer);
		}
		vkCmdSetDepthBoundsTestEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthBoundsTestEnableEXT");
		if (vkCmdSetDepthBoundsTestEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDepthBoundsTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthBoundsTestEnableEXTDelegate_0>(vkCmdSetDepthBoundsTestEnableEXTPointer);
		}
		vkCmdSetStencilTestEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetStencilTestEnableEXT");
		if (vkCmdSetStencilTestEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetStencilTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetStencilTestEnableEXTDelegate_0>(vkCmdSetStencilTestEnableEXTPointer);
		}
		vkCmdSetStencilOpEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetStencilOpEXT");
		if (vkCmdSetStencilOpEXTPointer != IntPtr.Zero)
		{
			vkCmdSetStencilOpEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetStencilOpEXTDelegate_0>(vkCmdSetStencilOpEXTPointer);
		}
		vkCreateDeferredOperationKHRPointer = vkGetInstanceProcAddr(instance, "vkCreateDeferredOperationKHR");
		if (vkCreateDeferredOperationKHRPointer != IntPtr.Zero)
		{
			vkCreateDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<vkCreateDeferredOperationKHRDelegate_0>(vkCreateDeferredOperationKHRPointer);
		}
		vkDestroyDeferredOperationKHRPointer = vkGetInstanceProcAddr(instance, "vkDestroyDeferredOperationKHR");
		if (vkDestroyDeferredOperationKHRPointer != IntPtr.Zero)
		{
			vkDestroyDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyDeferredOperationKHRDelegate_0>(vkDestroyDeferredOperationKHRPointer);
		}
		vkGetDeferredOperationMaxConcurrencyKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeferredOperationMaxConcurrencyKHR");
		if (vkGetDeferredOperationMaxConcurrencyKHRPointer != IntPtr.Zero)
		{
			vkGetDeferredOperationMaxConcurrencyKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeferredOperationMaxConcurrencyKHRDelegate_0>(vkGetDeferredOperationMaxConcurrencyKHRPointer);
		}
		vkGetDeferredOperationResultKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeferredOperationResultKHR");
		if (vkGetDeferredOperationResultKHRPointer != IntPtr.Zero)
		{
			vkGetDeferredOperationResultKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeferredOperationResultKHRDelegate_0>(vkGetDeferredOperationResultKHRPointer);
		}
		vkDeferredOperationJoinKHRPointer = vkGetInstanceProcAddr(instance, "vkDeferredOperationJoinKHR");
		if (vkDeferredOperationJoinKHRPointer != IntPtr.Zero)
		{
			vkDeferredOperationJoinKHR_0 = Marshal.GetDelegateForFunctionPointer<vkDeferredOperationJoinKHRDelegate_0>(vkDeferredOperationJoinKHRPointer);
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
		vkGetGeneratedCommandsMemoryRequirementsNVPointer = vkGetInstanceProcAddr(instance, "vkGetGeneratedCommandsMemoryRequirementsNV");
		if (vkGetGeneratedCommandsMemoryRequirementsNVPointer != IntPtr.Zero)
		{
			vkGetGeneratedCommandsMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetGeneratedCommandsMemoryRequirementsNVDelegate_0>(vkGetGeneratedCommandsMemoryRequirementsNVPointer);
		}
		vkCmdPreprocessGeneratedCommandsNVPointer = vkGetInstanceProcAddr(instance, "vkCmdPreprocessGeneratedCommandsNV");
		if (vkCmdPreprocessGeneratedCommandsNVPointer != IntPtr.Zero)
		{
			vkCmdPreprocessGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPreprocessGeneratedCommandsNVDelegate_0>(vkCmdPreprocessGeneratedCommandsNVPointer);
		}
		vkCmdExecuteGeneratedCommandsNVPointer = vkGetInstanceProcAddr(instance, "vkCmdExecuteGeneratedCommandsNV");
		if (vkCmdExecuteGeneratedCommandsNVPointer != IntPtr.Zero)
		{
			vkCmdExecuteGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdExecuteGeneratedCommandsNVDelegate_0>(vkCmdExecuteGeneratedCommandsNVPointer);
		}
		vkCmdBindPipelineShaderGroupNVPointer = vkGetInstanceProcAddr(instance, "vkCmdBindPipelineShaderGroupNV");
		if (vkCmdBindPipelineShaderGroupNVPointer != IntPtr.Zero)
		{
			vkCmdBindPipelineShaderGroupNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindPipelineShaderGroupNVDelegate_0>(vkCmdBindPipelineShaderGroupNVPointer);
		}
		vkCreateIndirectCommandsLayoutNVPointer = vkGetInstanceProcAddr(instance, "vkCreateIndirectCommandsLayoutNV");
		if (vkCreateIndirectCommandsLayoutNVPointer != IntPtr.Zero)
		{
			vkCreateIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<vkCreateIndirectCommandsLayoutNVDelegate_0>(vkCreateIndirectCommandsLayoutNVPointer);
		}
		vkDestroyIndirectCommandsLayoutNVPointer = vkGetInstanceProcAddr(instance, "vkDestroyIndirectCommandsLayoutNV");
		if (vkDestroyIndirectCommandsLayoutNVPointer != IntPtr.Zero)
		{
			vkDestroyIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyIndirectCommandsLayoutNVDelegate_0>(vkDestroyIndirectCommandsLayoutNVPointer);
		}
		vkAcquireDrmDisplayEXTPointer = vkGetInstanceProcAddr(instance, "vkAcquireDrmDisplayEXT");
		if (vkAcquireDrmDisplayEXTPointer != IntPtr.Zero)
		{
			vkAcquireDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireDrmDisplayEXTDelegate_0>(vkAcquireDrmDisplayEXTPointer);
		}
		vkGetDrmDisplayEXTPointer = vkGetInstanceProcAddr(instance, "vkGetDrmDisplayEXT");
		if (vkGetDrmDisplayEXTPointer != IntPtr.Zero)
		{
			vkGetDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetDrmDisplayEXTDelegate_0>(vkGetDrmDisplayEXTPointer);
		}
		vkCreatePrivateDataSlotEXTPointer = vkGetInstanceProcAddr(instance, "vkCreatePrivateDataSlotEXT");
		if (vkCreatePrivateDataSlotEXTPointer != IntPtr.Zero)
		{
			vkCreatePrivateDataSlotEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCreatePrivateDataSlotEXTDelegate_0>(vkCreatePrivateDataSlotEXTPointer);
		}
		vkDestroyPrivateDataSlotEXTPointer = vkGetInstanceProcAddr(instance, "vkDestroyPrivateDataSlotEXT");
		if (vkDestroyPrivateDataSlotEXTPointer != IntPtr.Zero)
		{
			vkDestroyPrivateDataSlotEXT_0 = Marshal.GetDelegateForFunctionPointer<vkDestroyPrivateDataSlotEXTDelegate_0>(vkDestroyPrivateDataSlotEXTPointer);
		}
		vkSetPrivateDataEXTPointer = vkGetInstanceProcAddr(instance, "vkSetPrivateDataEXT");
		if (vkSetPrivateDataEXTPointer != IntPtr.Zero)
		{
			vkSetPrivateDataEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSetPrivateDataEXTDelegate_0>(vkSetPrivateDataEXTPointer);
		}
		vkGetPrivateDataEXTPointer = vkGetInstanceProcAddr(instance, "vkGetPrivateDataEXT");
		if (vkGetPrivateDataEXTPointer != IntPtr.Zero)
		{
			vkGetPrivateDataEXT_0 = Marshal.GetDelegateForFunctionPointer<vkGetPrivateDataEXTDelegate_0>(vkGetPrivateDataEXTPointer);
		}
		vkCmdSetEvent2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdSetEvent2KHR");
		if (vkCmdSetEvent2KHRPointer != IntPtr.Zero)
		{
			vkCmdSetEvent2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetEvent2KHRDelegate_0>(vkCmdSetEvent2KHRPointer);
		}
		vkCmdResetEvent2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdResetEvent2KHR");
		if (vkCmdResetEvent2KHRPointer != IntPtr.Zero)
		{
			vkCmdResetEvent2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdResetEvent2KHRDelegate_0>(vkCmdResetEvent2KHRPointer);
		}
		vkCmdWaitEvents2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdWaitEvents2KHR");
		if (vkCmdWaitEvents2KHRPointer != IntPtr.Zero)
		{
			vkCmdWaitEvents2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWaitEvents2KHRDelegate_0>(vkCmdWaitEvents2KHRPointer);
		}
		vkCmdPipelineBarrier2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdPipelineBarrier2KHR");
		if (vkCmdPipelineBarrier2KHRPointer != IntPtr.Zero)
		{
			vkCmdPipelineBarrier2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdPipelineBarrier2KHRDelegate_0>(vkCmdPipelineBarrier2KHRPointer);
		}
		vkCmdWriteTimestamp2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteTimestamp2KHR");
		if (vkCmdWriteTimestamp2KHRPointer != IntPtr.Zero)
		{
			vkCmdWriteTimestamp2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteTimestamp2KHRDelegate_0>(vkCmdWriteTimestamp2KHRPointer);
		}
		vkQueueSubmit2KHRPointer = vkGetInstanceProcAddr(instance, "vkQueueSubmit2KHR");
		if (vkQueueSubmit2KHRPointer != IntPtr.Zero)
		{
			vkQueueSubmit2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkQueueSubmit2KHRDelegate_0>(vkQueueSubmit2KHRPointer);
		}
		vkCmdWriteBufferMarker2AMDPointer = vkGetInstanceProcAddr(instance, "vkCmdWriteBufferMarker2AMD");
		if (vkCmdWriteBufferMarker2AMDPointer != IntPtr.Zero)
		{
			vkCmdWriteBufferMarker2AMD_0 = Marshal.GetDelegateForFunctionPointer<vkCmdWriteBufferMarker2AMDDelegate_0>(vkCmdWriteBufferMarker2AMDPointer);
		}
		vkGetQueueCheckpointData2NVPointer = vkGetInstanceProcAddr(instance, "vkGetQueueCheckpointData2NV");
		if (vkGetQueueCheckpointData2NVPointer != IntPtr.Zero)
		{
			vkGetQueueCheckpointData2NV_0 = Marshal.GetDelegateForFunctionPointer<vkGetQueueCheckpointData2NVDelegate_0>(vkGetQueueCheckpointData2NVPointer);
		}
		vkCmdSetFragmentShadingRateEnumNVPointer = vkGetInstanceProcAddr(instance, "vkCmdSetFragmentShadingRateEnumNV");
		if (vkCmdSetFragmentShadingRateEnumNVPointer != IntPtr.Zero)
		{
			vkCmdSetFragmentShadingRateEnumNV_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetFragmentShadingRateEnumNVDelegate_0>(vkCmdSetFragmentShadingRateEnumNVPointer);
		}
		vkCmdCopyBuffer2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyBuffer2KHR");
		if (vkCmdCopyBuffer2KHRPointer != IntPtr.Zero)
		{
			vkCmdCopyBuffer2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyBuffer2KHRDelegate_0>(vkCmdCopyBuffer2KHRPointer);
		}
		vkCmdCopyImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyImage2KHR");
		if (vkCmdCopyImage2KHRPointer != IntPtr.Zero)
		{
			vkCmdCopyImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyImage2KHRDelegate_0>(vkCmdCopyImage2KHRPointer);
		}
		vkCmdCopyBufferToImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyBufferToImage2KHR");
		if (vkCmdCopyBufferToImage2KHRPointer != IntPtr.Zero)
		{
			vkCmdCopyBufferToImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyBufferToImage2KHRDelegate_0>(vkCmdCopyBufferToImage2KHRPointer);
		}
		vkCmdCopyImageToBuffer2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdCopyImageToBuffer2KHR");
		if (vkCmdCopyImageToBuffer2KHRPointer != IntPtr.Zero)
		{
			vkCmdCopyImageToBuffer2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdCopyImageToBuffer2KHRDelegate_0>(vkCmdCopyImageToBuffer2KHRPointer);
		}
		vkCmdBlitImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdBlitImage2KHR");
		if (vkCmdBlitImage2KHRPointer != IntPtr.Zero)
		{
			vkCmdBlitImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBlitImage2KHRDelegate_0>(vkCmdBlitImage2KHRPointer);
		}
		vkCmdResolveImage2KHRPointer = vkGetInstanceProcAddr(instance, "vkCmdResolveImage2KHR");
		if (vkCmdResolveImage2KHRPointer != IntPtr.Zero)
		{
			vkCmdResolveImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<vkCmdResolveImage2KHRDelegate_0>(vkCmdResolveImage2KHRPointer);
		}
		vkAcquireWinrtDisplayNVPointer = vkGetInstanceProcAddr(instance, "vkAcquireWinrtDisplayNV");
		if (vkAcquireWinrtDisplayNVPointer != IntPtr.Zero)
		{
			vkAcquireWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<vkAcquireWinrtDisplayNVDelegate_0>(vkAcquireWinrtDisplayNVPointer);
		}
		vkGetWinrtDisplayNVPointer = vkGetInstanceProcAddr(instance, "vkGetWinrtDisplayNV");
		if (vkGetWinrtDisplayNVPointer != IntPtr.Zero)
		{
			vkGetWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetWinrtDisplayNVDelegate_0>(vkGetWinrtDisplayNVPointer);
		}
		vkCmdSetVertexInputEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetVertexInputEXT");
		if (vkCmdSetVertexInputEXTPointer != IntPtr.Zero)
		{
			vkCmdSetVertexInputEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetVertexInputEXTDelegate_0>(vkCmdSetVertexInputEXTPointer);
		}
		vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
		if (vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer != IntPtr.Zero)
		{
			vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0>(vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIPointer);
		}
		vkCmdSubpassShadingHUAWEIPointer = vkGetInstanceProcAddr(instance, "vkCmdSubpassShadingHUAWEI");
		if (vkCmdSubpassShadingHUAWEIPointer != IntPtr.Zero)
		{
			vkCmdSubpassShadingHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSubpassShadingHUAWEIDelegate_0>(vkCmdSubpassShadingHUAWEIPointer);
		}
		vkCmdBindInvocationMaskHUAWEIPointer = vkGetInstanceProcAddr(instance, "vkCmdBindInvocationMaskHUAWEI");
		if (vkCmdBindInvocationMaskHUAWEIPointer != IntPtr.Zero)
		{
			vkCmdBindInvocationMaskHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<vkCmdBindInvocationMaskHUAWEIDelegate_0>(vkCmdBindInvocationMaskHUAWEIPointer);
		}
		vkGetMemoryRemoteAddressNVPointer = vkGetInstanceProcAddr(instance, "vkGetMemoryRemoteAddressNV");
		if (vkGetMemoryRemoteAddressNVPointer != IntPtr.Zero)
		{
			vkGetMemoryRemoteAddressNV_0 = Marshal.GetDelegateForFunctionPointer<vkGetMemoryRemoteAddressNVDelegate_0>(vkGetMemoryRemoteAddressNVPointer);
		}
		vkCmdSetPatchControlPointsEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPatchControlPointsEXT");
		if (vkCmdSetPatchControlPointsEXTPointer != IntPtr.Zero)
		{
			vkCmdSetPatchControlPointsEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPatchControlPointsEXTDelegate_0>(vkCmdSetPatchControlPointsEXTPointer);
		}
		vkCmdSetRasterizerDiscardEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetRasterizerDiscardEnableEXT");
		if (vkCmdSetRasterizerDiscardEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetRasterizerDiscardEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetRasterizerDiscardEnableEXTDelegate_0>(vkCmdSetRasterizerDiscardEnableEXTPointer);
		}
		vkCmdSetDepthBiasEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetDepthBiasEnableEXT");
		if (vkCmdSetDepthBiasEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetDepthBiasEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetDepthBiasEnableEXTDelegate_0>(vkCmdSetDepthBiasEnableEXTPointer);
		}
		vkCmdSetLogicOpEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetLogicOpEXT");
		if (vkCmdSetLogicOpEXTPointer != IntPtr.Zero)
		{
			vkCmdSetLogicOpEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetLogicOpEXTDelegate_0>(vkCmdSetLogicOpEXTPointer);
		}
		vkCmdSetPrimitiveRestartEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetPrimitiveRestartEnableEXT");
		if (vkCmdSetPrimitiveRestartEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetPrimitiveRestartEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetPrimitiveRestartEnableEXTDelegate_0>(vkCmdSetPrimitiveRestartEnableEXTPointer);
		}
		vkCmdSetColorWriteEnableEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdSetColorWriteEnableEXT");
		if (vkCmdSetColorWriteEnableEXTPointer != IntPtr.Zero)
		{
			vkCmdSetColorWriteEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdSetColorWriteEnableEXTDelegate_0>(vkCmdSetColorWriteEnableEXTPointer);
		}
		vkCmdDrawMultiEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawMultiEXT");
		if (vkCmdDrawMultiEXTPointer != IntPtr.Zero)
		{
			vkCmdDrawMultiEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawMultiEXTDelegate_0>(vkCmdDrawMultiEXTPointer);
		}
		vkCmdDrawMultiIndexedEXTPointer = vkGetInstanceProcAddr(instance, "vkCmdDrawMultiIndexedEXT");
		if (vkCmdDrawMultiIndexedEXTPointer != IntPtr.Zero)
		{
			vkCmdDrawMultiIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<vkCmdDrawMultiIndexedEXTDelegate_0>(vkCmdDrawMultiIndexedEXTPointer);
		}
		vkSetDeviceMemoryPriorityEXTPointer = vkGetInstanceProcAddr(instance, "vkSetDeviceMemoryPriorityEXT");
		if (vkSetDeviceMemoryPriorityEXTPointer != IntPtr.Zero)
		{
			vkSetDeviceMemoryPriorityEXT_0 = Marshal.GetDelegateForFunctionPointer<vkSetDeviceMemoryPriorityEXTDelegate_0>(vkSetDeviceMemoryPriorityEXTPointer);
		}
		vkGetDeviceBufferMemoryRequirementsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceBufferMemoryRequirementsKHR");
		if (vkGetDeviceBufferMemoryRequirementsKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceBufferMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceBufferMemoryRequirementsKHRDelegate_0>(vkGetDeviceBufferMemoryRequirementsKHRPointer);
		}
		vkGetDeviceImageMemoryRequirementsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceImageMemoryRequirementsKHR");
		if (vkGetDeviceImageMemoryRequirementsKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceImageMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceImageMemoryRequirementsKHRDelegate_0>(vkGetDeviceImageMemoryRequirementsKHRPointer);
		}
		vkGetDeviceImageSparseMemoryRequirementsKHRPointer = vkGetInstanceProcAddr(instance, "vkGetDeviceImageSparseMemoryRequirementsKHR");
		if (vkGetDeviceImageSparseMemoryRequirementsKHRPointer != IntPtr.Zero)
		{
			vkGetDeviceImageSparseMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<vkGetDeviceImageSparseMemoryRequirementsKHRDelegate_0>(vkGetDeviceImageSparseMemoryRequirementsKHRPointer);
		}
	}
}
