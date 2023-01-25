// This file was generated, don't manually edit
namespace Vulkan_1_0;

public enum VkPipelineCacheHeaderVersion
{
	One = 1,
}
public enum VkResult
{
	Success = 0,
	NotReady = 1,
	Timeout = 2,
	EventSet = 3,
	EventReset = 4,
	Incomplete = 5,
	ErrorOutOfHostMemory = -1,
	ErrorOutOfDeviceMemory = -2,
	ErrorInitializationFailed = -3,
	ErrorDeviceLost = -4,
	ErrorMemoryMapFailed = -5,
	ErrorLayerNotPresent = -6,
	ErrorExtensionNotPresent = -7,
	ErrorFeatureNotPresent = -8,
	ErrorIncompatibleDriver = -9,
	ErrorTooManyObjects = -10,
	ErrorFormatNotSupported = -11,
	ErrorFragmentedPool = -12,
	ErrorSurfaceLostKhr = -1000000000,
	ErrorNativeWindowInUseKhr = -1000000001,
	SuboptimalKhr = 1000001003,
	ErrorOutOfDateKhr = -1000001004,
	ErrorIncompatibleDisplayKhr = -1000003001,
	ErrorValidationFailedExt = -1000011001,
	ErrorInvalidShaderNv = -1000012000,
	ErrorOutOfPoolMemoryKhr = -1000069000,
	ErrorInvalidExternalHandleKhr = -1000072003,
	ErrorNotPermittedExt = -1000174001,
}
public enum VkStructureType
{
	ApplicationInfo = 0,
	InstanceCreateInfo = 1,
	DeviceQueueCreateInfo = 2,
	DeviceCreateInfo = 3,
	SubmitInfo = 4,
	MemoryAllocateInfo = 5,
	MappedMemoryRange = 6,
	BindSparseInfo = 7,
	FenceCreateInfo = 8,
	SemaphoreCreateInfo = 9,
	EventCreateInfo = 10,
	QueryPoolCreateInfo = 11,
	BufferCreateInfo = 12,
	BufferViewCreateInfo = 13,
	ImageCreateInfo = 14,
	ImageViewCreateInfo = 15,
	ShaderModuleCreateInfo = 16,
	PipelineCacheCreateInfo = 17,
	PipelineShaderStageCreateInfo = 18,
	PipelineVertexInputStateCreateInfo = 19,
	PipelineInputAssemblyStateCreateInfo = 20,
	PipelineTessellationStateCreateInfo = 21,
	PipelineViewportStateCreateInfo = 22,
	PipelineRasterizationStateCreateInfo = 23,
	PipelineMultisampleStateCreateInfo = 24,
	PipelineDepthStencilStateCreateInfo = 25,
	PipelineColorBlendStateCreateInfo = 26,
	PipelineDynamicStateCreateInfo = 27,
	GraphicsPipelineCreateInfo = 28,
	ComputePipelineCreateInfo = 29,
	PipelineLayoutCreateInfo = 30,
	SamplerCreateInfo = 31,
	DescriptorSetLayoutCreateInfo = 32,
	DescriptorPoolCreateInfo = 33,
	DescriptorSetAllocateInfo = 34,
	WriteDescriptorSet = 35,
	CopyDescriptorSet = 36,
	FramebufferCreateInfo = 37,
	RenderPassCreateInfo = 38,
	CommandPoolCreateInfo = 39,
	CommandBufferAllocateInfo = 40,
	CommandBufferInheritanceInfo = 41,
	CommandBufferBeginInfo = 42,
	RenderPassBeginInfo = 43,
	BufferMemoryBarrier = 44,
	ImageMemoryBarrier = 45,
	MemoryBarrier = 46,
	LoaderInstanceCreateInfo = 47,
	LoaderDeviceCreateInfo = 48,
	SwapchainCreateInfoKhr = 1000001000,
	PresentInfoKhr = 1000001001,
	DisplayModeCreateInfoKhr = 1000002000,
	DisplaySurfaceCreateInfoKhr = 1000002001,
	DisplayPresentInfoKhr = 1000003000,
	XlibSurfaceCreateInfoKhr = 1000004000,
	XcbSurfaceCreateInfoKhr = 1000005000,
	WaylandSurfaceCreateInfoKhr = 1000006000,
	AndroidSurfaceCreateInfoKhr = 1000008000,
	Win32SurfaceCreateInfoKhr = 1000009000,
	DebugReportCallbackCreateInfoExt = 1000011000,
	[Obsolete("Use VkStructureType.DebugReportCallbackCreateInfoExt")]
	DebugReportCreateInfoExt = DebugReportCallbackCreateInfoExt,
	PipelineRasterizationStateRasterizationOrderAmd = 1000018000,
	DebugMarkerObjectNameInfoExt = 1000022000,
	DebugMarkerObjectTagInfoExt = 1000022001,
	DebugMarkerMarkerInfoExt = 1000022002,
	DedicatedAllocationImageCreateInfoNv = 1000026000,
	DedicatedAllocationBufferCreateInfoNv = 1000026001,
	DedicatedAllocationMemoryAllocateInfoNv = 1000026002,
	TextureLodGatherFormatPropertiesAmd = 1000041000,
	RenderPassMultiviewCreateInfoKhx = 1000053000,
	PhysicalDeviceMultiviewFeaturesKhx = 1000053001,
	PhysicalDeviceMultiviewPropertiesKhx = 1000053002,
	ExternalMemoryImageCreateInfoNv = 1000056000,
	ExportMemoryAllocateInfoNv = 1000056001,
	ImportMemoryWin32HandleInfoNv = 1000057000,
	ExportMemoryWin32HandleInfoNv = 1000057001,
	Win32KeyedMutexAcquireReleaseInfoNv = 1000058000,
	PhysicalDeviceFeatures2Khr = 1000059000,
	PhysicalDeviceProperties2Khr = 1000059001,
	FormatProperties2Khr = 1000059002,
	ImageFormatProperties2Khr = 1000059003,
	PhysicalDeviceImageFormatInfo2Khr = 1000059004,
	QueueFamilyProperties2Khr = 1000059005,
	PhysicalDeviceMemoryProperties2Khr = 1000059006,
	SparseImageFormatProperties2Khr = 1000059007,
	PhysicalDeviceSparseImageFormatInfo2Khr = 1000059008,
	MemoryAllocateFlagsInfoKhx = 1000060000,
	DeviceGroupRenderPassBeginInfoKhx = 1000060003,
	DeviceGroupCommandBufferBeginInfoKhx = 1000060004,
	DeviceGroupSubmitInfoKhx = 1000060005,
	DeviceGroupBindSparseInfoKhx = 1000060006,
	AcquireNextImageInfoKhx = 1000060010,
	BindBufferMemoryDeviceGroupInfoKhx = 1000060013,
	BindImageMemoryDeviceGroupInfoKhx = 1000060014,
	DeviceGroupPresentCapabilitiesKhx = 1000060007,
	ImageSwapchainCreateInfoKhx = 1000060008,
	BindImageMemorySwapchainInfoKhx = 1000060009,
	DeviceGroupPresentInfoKhx = 1000060011,
	DeviceGroupSwapchainCreateInfoKhx = 1000060012,
	ValidationFlagsExt = 1000061000,
	ViSurfaceCreateInfoNn = 1000062000,
	PhysicalDeviceGroupPropertiesKhx = 1000070000,
	DeviceGroupDeviceCreateInfoKhx = 1000070001,
	PhysicalDeviceExternalImageFormatInfoKhr = 1000071000,
	ExternalImageFormatPropertiesKhr = 1000071001,
	PhysicalDeviceExternalBufferInfoKhr = 1000071002,
	ExternalBufferPropertiesKhr = 1000071003,
	PhysicalDeviceIdPropertiesKhr = 1000071004,
	ExternalMemoryBufferCreateInfoKhr = 1000072000,
	ExternalMemoryImageCreateInfoKhr = 1000072001,
	ExportMemoryAllocateInfoKhr = 1000072002,
	ImportMemoryWin32HandleInfoKhr = 1000073000,
	ExportMemoryWin32HandleInfoKhr = 1000073001,
	MemoryWin32HandlePropertiesKhr = 1000073002,
	MemoryGetWin32HandleInfoKhr = 1000073003,
	ImportMemoryFileDescriptorInfoKhr = 1000074000,
	MemoryFileDescriptorPropertiesKhr = 1000074001,
	MemoryGetFileDescriptorInfoKhr = 1000074002,
	Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
	PhysicalDeviceExternalSemaphoreInfoKhr = 1000076000,
	ExternalSemaphorePropertiesKhr = 1000076001,
	ExportSemaphoreCreateInfoKhr = 1000077000,
	ImportSemaphoreWin32HandleInfoKhr = 1000078000,
	ExportSemaphoreWin32HandleInfoKhr = 1000078001,
	D3d12FenceSubmitInfoKhr = 1000078002,
	SemaphoreGetWin32HandleInfoKhr = 1000078003,
	ImportSemaphoreFileDescriptorInfoKhr = 1000079000,
	SemaphoreGetFileDescriptorInfoKhr = 1000079001,
	PhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
	PhysicalDevice16bitStorageFeaturesKhr = 1000083000,
	PresentRegionsKhr = 1000084000,
	DescriptorUpdateTemplateCreateInfoKhr = 1000085000,
	ObjectTableCreateInfoNvx = 1000086000,
	IndirectCommandsLayoutCreateInfoNvx = 1000086001,
	CommandProcessCommandsInfoNvx = 1000086002,
	CommandReserveSpaceForCommandsInfoNvx = 1000086003,
	DeviceGeneratedCommandsLimitsNvx = 1000086004,
	DeviceGeneratedCommandsFeaturesNvx = 1000086005,
	PipelineViewportWScalingStateCreateInfoNv = 1000087000,
	SurfaceCapabilities2Ext = 1000090000,
	DisplayPowerInfoExt = 1000091000,
	DeviceEventInfoExt = 1000091001,
	DisplayEventInfoExt = 1000091002,
	SwapchainCounterCreateInfoExt = 1000091003,
	PresentTimesInfoGoogle = 1000092000,
	PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
	PipelineViewportSwizzleStateCreateInfoNv = 1000098000,
	PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
	PipelineDiscardRectangleStateCreateInfoExt = 1000099001,
	PhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
	PipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
	HdrMetadataExt = 1000105000,
	SharedPresentSurfaceCapabilitiesKhr = 1000111000,
	PhysicalDeviceExternalFenceInfoKhr = 1000112000,
	ExternalFencePropertiesKhr = 1000112001,
	ExportFenceCreateInfoKhr = 1000113000,
	ImportFenceWin32HandleInfoKhr = 1000114000,
	ExportFenceWin32HandleInfoKhr = 1000114001,
	FenceGetWin32HandleInfoKhr = 1000114002,
	ImportFenceFileDescriptorInfoKhr = 1000115000,
	FenceGetFileDescriptorInfoKhr = 1000115001,
	PhysicalDevicePointClippingPropertiesKhr = 1000117000,
	RenderPassInputAttachmentAspectCreateInfoKhr = 1000117001,
	ImageViewUsageCreateInfoKhr = 1000117002,
	PipelineTessellationDomainOriginStateCreateInfoKhr = 1000117003,
	PhysicalDeviceSurfaceInfo2Khr = 1000119000,
	SurfaceCapabilities2Khr = 1000119001,
	SurfaceFormat2Khr = 1000119002,
	PhysicalDeviceVariablePointerFeaturesKhr = 1000120000,
	IosSurfaceCreateInfoMvk = 1000122000,
	MacosSurfaceCreateInfoMvk = 1000123000,
	MemoryDedicatedRequirementsKhr = 1000127000,
	MemoryDedicatedAllocateInfoKhr = 1000127001,
	PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
	SamplerReductionModeCreateInfoExt = 1000130001,
	SampleLocationsInfoExt = 1000143000,
	RenderPassSampleLocationsBeginInfoExt = 1000143001,
	PipelineSampleLocationsStateCreateInfoExt = 1000143002,
	PhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
	MultisamplePropertiesExt = 1000143004,
	BufferMemoryRequirementsInfo2Khr = 1000146000,
	ImageMemoryRequirementsInfo2Khr = 1000146001,
	ImageSparseMemoryRequirementsInfo2Khr = 1000146002,
	MemoryRequirements2Khr = 1000146003,
	SparseImageMemoryRequirements2Khr = 1000146004,
	ImageFormatListCreateInfoKhr = 1000147000,
	PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
	PipelineCoverageToColorStateCreateInfoNv = 1000149000,
	PipelineCoverageModulationStateCreateInfoNv = 1000152000,
	SamplerYcbcrConversionCreateInfoKhr = 1000156000,
	SamplerYcbcrConversionInfoKhr = 1000156001,
	BindImagePlaneMemoryInfoKhr = 1000156002,
	ImagePlaneMemoryRequirementsInfoKhr = 1000156003,
	PhysicalDeviceSamplerYcbcrConversionFeaturesKhr = 1000156004,
	SamplerYcbcrConversionImageFormatPropertiesKhr = 1000156005,
	BindBufferMemoryInfoKhr = 1000157000,
	BindImageMemoryInfoKhr = 1000157001,
	ValidationCacheCreateInfoExt = 1000160000,
	ShaderModuleValidationCacheCreateInfoExt = 1000160001,
	DeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
	ImportMemoryHostPointerInfoExt = 1000178000,
	MemoryHostPointerPropertiesExt = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
}
[Flags]
public enum VkInstanceCreateFlags
{
}
public enum VkFormat
{
	Undefined = 0,
	R4g4UnormPack8 = 1,
	R4g4b4a4UnormPack16 = 2,
	B4g4r4a4UnormPack16 = 3,
	R5g6b5UnormPack16 = 4,
	B5g6r5UnormPack16 = 5,
	R5g5b5a1UnormPack16 = 6,
	B5g5r5a1UnormPack16 = 7,
	A1r5g5b5UnormPack16 = 8,
	R8Unorm = 9,
	R8Snorm = 10,
	R8Uscaled = 11,
	R8Sscaled = 12,
	R8Uint = 13,
	R8Sint = 14,
	R8Srgb = 15,
	R8g8Unorm = 16,
	R8g8Snorm = 17,
	R8g8Uscaled = 18,
	R8g8Sscaled = 19,
	R8g8Uint = 20,
	R8g8Sint = 21,
	R8g8Srgb = 22,
	R8g8b8Unorm = 23,
	R8g8b8Snorm = 24,
	R8g8b8Uscaled = 25,
	R8g8b8Sscaled = 26,
	R8g8b8Uint = 27,
	R8g8b8Sint = 28,
	R8g8b8Srgb = 29,
	B8g8r8Unorm = 30,
	B8g8r8Snorm = 31,
	B8g8r8Uscaled = 32,
	B8g8r8Sscaled = 33,
	B8g8r8Uint = 34,
	B8g8r8Sint = 35,
	B8g8r8Srgb = 36,
	R8g8b8a8Unorm = 37,
	R8g8b8a8Snorm = 38,
	R8g8b8a8Uscaled = 39,
	R8g8b8a8Sscaled = 40,
	R8g8b8a8Uint = 41,
	R8g8b8a8Sint = 42,
	R8g8b8a8Srgb = 43,
	B8g8r8a8Unorm = 44,
	B8g8r8a8Snorm = 45,
	B8g8r8a8Uscaled = 46,
	B8g8r8a8Sscaled = 47,
	B8g8r8a8Uint = 48,
	B8g8r8a8Sint = 49,
	B8g8r8a8Srgb = 50,
	A8b8g8r8UnormPack32 = 51,
	A8b8g8r8SnormPack32 = 52,
	A8b8g8r8UscaledPack32 = 53,
	A8b8g8r8SscaledPack32 = 54,
	A8b8g8r8UintPack32 = 55,
	A8b8g8r8SintPack32 = 56,
	A8b8g8r8SrgbPack32 = 57,
	A2r10g10b10UnormPack32 = 58,
	A2r10g10b10SnormPack32 = 59,
	A2r10g10b10UscaledPack32 = 60,
	A2r10g10b10SscaledPack32 = 61,
	A2r10g10b10UintPack32 = 62,
	A2r10g10b10SintPack32 = 63,
	A2b10g10r10UnormPack32 = 64,
	A2b10g10r10SnormPack32 = 65,
	A2b10g10r10UscaledPack32 = 66,
	A2b10g10r10SscaledPack32 = 67,
	A2b10g10r10UintPack32 = 68,
	A2b10g10r10SintPack32 = 69,
	R16Unorm = 70,
	R16Snorm = 71,
	R16Uscaled = 72,
	R16Sscaled = 73,
	R16Uint = 74,
	R16Sint = 75,
	R16Sfloat = 76,
	R16g16Unorm = 77,
	R16g16Snorm = 78,
	R16g16Uscaled = 79,
	R16g16Sscaled = 80,
	R16g16Uint = 81,
	R16g16Sint = 82,
	R16g16Sfloat = 83,
	R16g16b16Unorm = 84,
	R16g16b16Snorm = 85,
	R16g16b16Uscaled = 86,
	R16g16b16Sscaled = 87,
	R16g16b16Uint = 88,
	R16g16b16Sint = 89,
	R16g16b16Sfloat = 90,
	R16g16b16a16Unorm = 91,
	R16g16b16a16Snorm = 92,
	R16g16b16a16Uscaled = 93,
	R16g16b16a16Sscaled = 94,
	R16g16b16a16Uint = 95,
	R16g16b16a16Sint = 96,
	R16g16b16a16Sfloat = 97,
	R32Uint = 98,
	R32Sint = 99,
	R32Sfloat = 100,
	R32g32Uint = 101,
	R32g32Sint = 102,
	R32g32Sfloat = 103,
	R32g32b32Uint = 104,
	R32g32b32Sint = 105,
	R32g32b32Sfloat = 106,
	R32g32b32a32Uint = 107,
	R32g32b32a32Sint = 108,
	R32g32b32a32Sfloat = 109,
	R64Uint = 110,
	R64Sint = 111,
	R64Sfloat = 112,
	R64g64Uint = 113,
	R64g64Sint = 114,
	R64g64Sfloat = 115,
	R64g64b64Uint = 116,
	R64g64b64Sint = 117,
	R64g64b64Sfloat = 118,
	R64g64b64a64Uint = 119,
	R64g64b64a64Sint = 120,
	R64g64b64a64Sfloat = 121,
	B10g11r11UfloatPack32 = 122,
	E5b9g9r9UfloatPack32 = 123,
	D16Unorm = 124,
	X8D24UnormPack32 = 125,
	D32Sfloat = 126,
	S8Uint = 127,
	D16UnormS8Uint = 128,
	D24UnormS8Uint = 129,
	D32SfloatS8Uint = 130,
	Bc1RgbUnormBlock = 131,
	Bc1RgbSrgbBlock = 132,
	Bc1RgbaUnormBlock = 133,
	Bc1RgbaSrgbBlock = 134,
	Bc2UnormBlock = 135,
	Bc2SrgbBlock = 136,
	Bc3UnormBlock = 137,
	Bc3SrgbBlock = 138,
	Bc4UnormBlock = 139,
	Bc4SnormBlock = 140,
	Bc5UnormBlock = 141,
	Bc5SnormBlock = 142,
	Bc6hUfloatBlock = 143,
	Bc6hSfloatBlock = 144,
	Bc7UnormBlock = 145,
	Bc7SrgbBlock = 146,
	Etc2R8g8b8UnormBlock = 147,
	Etc2R8g8b8SrgbBlock = 148,
	Etc2R8g8b8a1UnormBlock = 149,
	Etc2R8g8b8a1SrgbBlock = 150,
	Etc2R8g8b8a8UnormBlock = 151,
	Etc2R8g8b8a8SrgbBlock = 152,
	EacR11UnormBlock = 153,
	EacR11SnormBlock = 154,
	EacR11g11UnormBlock = 155,
	EacR11g11SnormBlock = 156,
	Astc4x4UnormBlock = 157,
	Astc4x4SrgbBlock = 158,
	Astc5x4UnormBlock = 159,
	Astc5x4SrgbBlock = 160,
	Astc5x5UnormBlock = 161,
	Astc5x5SrgbBlock = 162,
	Astc6x5UnormBlock = 163,
	Astc6x5SrgbBlock = 164,
	Astc6x6UnormBlock = 165,
	Astc6x6SrgbBlock = 166,
	Astc8x5UnormBlock = 167,
	Astc8x5SrgbBlock = 168,
	Astc8x6UnormBlock = 169,
	Astc8x6SrgbBlock = 170,
	Astc8x8UnormBlock = 171,
	Astc8x8SrgbBlock = 172,
	Astc10x5UnormBlock = 173,
	Astc10x5SrgbBlock = 174,
	Astc10x6UnormBlock = 175,
	Astc10x6SrgbBlock = 176,
	Astc10x8UnormBlock = 177,
	Astc10x8SrgbBlock = 178,
	Astc10x10UnormBlock = 179,
	Astc10x10SrgbBlock = 180,
	Astc12x10UnormBlock = 181,
	Astc12x10SrgbBlock = 182,
	Astc12x12UnormBlock = 183,
	Astc12x12SrgbBlock = 184,
	Pvrtc12bppUnormBlockImg = 1000054000,
	Pvrtc14bppUnormBlockImg = 1000054001,
	Pvrtc22bppUnormBlockImg = 1000054002,
	Pvrtc24bppUnormBlockImg = 1000054003,
	Pvrtc12bppSrgbBlockImg = 1000054004,
	Pvrtc14bppSrgbBlockImg = 1000054005,
	Pvrtc22bppSrgbBlockImg = 1000054006,
	Pvrtc24bppSrgbBlockImg = 1000054007,
	G8b8g8r8422UnormKhr = 1000156000,
	B8g8r8g8422UnormKhr = 1000156001,
	G8B8R83plane420UnormKhr = 1000156002,
	G8B8r82plane420UnormKhr = 1000156003,
	G8B8R83plane422UnormKhr = 1000156004,
	G8B8r82plane422UnormKhr = 1000156005,
	G8B8R83plane444UnormKhr = 1000156006,
	R10x6UnormPack16Khr = 1000156007,
	R10x6g10x6Unorm2pack16Khr = 1000156008,
	R10x6g10x6b10x6a10x6Unorm4pack16Khr = 1000156009,
	G10x6b10x6g10x6r10x6422Unorm4pack16Khr = 1000156010,
	B10x6g10x6r10x6g10x6422Unorm4pack16Khr = 1000156011,
	G10x6B10x6R10x63plane420Unorm3pack16Khr = 1000156012,
	G10x6B10x6r10x62plane420Unorm3pack16Khr = 1000156013,
	G10x6B10x6R10x63plane422Unorm3pack16Khr = 1000156014,
	G10x6B10x6r10x62plane422Unorm3pack16Khr = 1000156015,
	G10x6B10x6R10x63plane444Unorm3pack16Khr = 1000156016,
	R12x4UnormPack16Khr = 1000156017,
	R12x4g12x4Unorm2pack16Khr = 1000156018,
	R12x4g12x4b12x4a12x4Unorm4pack16Khr = 1000156019,
	G12x4b12x4g12x4r12x4422Unorm4pack16Khr = 1000156020,
	B12x4g12x4r12x4g12x4422Unorm4pack16Khr = 1000156021,
	G12x4B12x4R12x43plane420Unorm3pack16Khr = 1000156022,
	G12x4B12x4r12x42plane420Unorm3pack16Khr = 1000156023,
	G12x4B12x4R12x43plane422Unorm3pack16Khr = 1000156024,
	G12x4B12x4r12x42plane422Unorm3pack16Khr = 1000156025,
	G12x4B12x4R12x43plane444Unorm3pack16Khr = 1000156026,
	G16b16g16r16422UnormKhr = 1000156027,
	B16g16r16g16422UnormKhr = 1000156028,
	G16B16R163plane420UnormKhr = 1000156029,
	G16B16r162plane420UnormKhr = 1000156030,
	G16B16R163plane422UnormKhr = 1000156031,
	G16B16r162plane422UnormKhr = 1000156032,
	G16B16R163plane444UnormKhr = 1000156033,
}
[Flags]
public enum VkFormatFeatureFlags
{
	SampledImage = 1 << 0,
	StorageImage = 1 << 1,
	StorageImageAtomic = 1 << 2,
	UniformTexelBuffer = 1 << 3,
	StorageTexelBuffer = 1 << 4,
	StorageTexelBufferAtomic = 1 << 5,
	VertexBuffer = 1 << 6,
	ColorAttachment = 1 << 7,
	ColorAttachmentBlend = 1 << 8,
	DepthStencilAttachment = 1 << 9,
	BlitSource = 1 << 10,
	BlitDestination = 1 << 11,
	SampledImageFilterLinear = 1 << 12,
	SampledImageFilterCubicImg = 1 << 13,
	TransferSourceKhr = 1 << 14,
	TransferDestinationKhr = 1 << 15,
	SampledImageFilterMinmaxExt = 1 << 16,
	MidpointChromaSamplesKhr = 1 << 17,
	SampledImageYcbcrConversionLinearFilterKhr = 1 << 18,
	SampledImageYcbcrConversionSeparateReconstructionFilterKhr = 1 << 19,
	SampledImageYcbcrConversionChromaReconstructionExplicitKhr = 1 << 20,
	SampledImageYcbcrConversionChromaReconstructionExplicitForceableKhr = 1 << 21,
	DisjointKhr = 1 << 22,
	CositedChromaSamplesKhr = 1 << 23,
}
public enum VkImageType
{
	_1d = 0,
	_2d = 1,
	_3d = 2,
}
public enum VkImageTiling
{
	Optimal = 0,
	Linear = 1,
}
[Flags]
public enum VkImageUsageFlags
{
	TransferSource = 1 << 0,
	TransferDestination = 1 << 1,
	Sampled = 1 << 2,
	Storage = 1 << 3,
	ColorAttachment = 1 << 4,
	DepthStencilAttachment = 1 << 5,
	TransientAttachment = 1 << 6,
	InputAttachment = 1 << 7,
}
[Flags]
public enum VkImageCreateFlags
{
	SparseBinding = 1 << 0,
	SparseResidency = 1 << 1,
	SparseAliased = 1 << 2,
	MutableFormat = 1 << 3,
	CubeCompatible = 1 << 4,
	BindSfrKhx = 1 << 6,
	_2dArrayCompatibleKhr = 1 << 5,
	BlockTexelViewCompatibleKhr = 1 << 7,
	ExtendedUsageKhr = 1 << 8,
	SampleLocationsCompatibleDepthExt = 1 << 12,
	DisjointKhr = 1 << 9,
	AliasKhr = 1 << 10,
}
[Flags]
public enum VkSampleCountFlags
{
	_1 = 1 << 0,
	_2 = 1 << 1,
	_4 = 1 << 2,
	_8 = 1 << 3,
	_16 = 1 << 4,
	_32 = 1 << 5,
	_64 = 1 << 6,
}
public enum VkPhysicalDeviceType
{
	Other = 0,
	IntegratedGpu = 1,
	DiscreteGpu = 2,
	VirtualGpu = 3,
	Cpu = 4,
}
[Flags]
public enum VkQueueFlags
{
	Graphics = 1 << 0,
	Compute = 1 << 1,
	Transfer = 1 << 2,
	SparseBinding = 1 << 3,
}
[Flags]
public enum VkMemoryPropertyFlags
{
	DeviceLocal = 1 << 0,
	HostVisible = 1 << 1,
	HostCoherent = 1 << 2,
	HostCached = 1 << 3,
	LazilyAllocated = 1 << 4,
}
[Flags]
public enum VkMemoryHeapFlags
{
	DeviceLocal = 1 << 0,
	MultiInstanceKhx = 1 << 1,
}
[Flags]
public enum VkDeviceCreateFlags
{
}
[Flags]
public enum VkDeviceQueueCreateFlags
{
}
[Flags]
public enum VkPipelineStageFlags
{
	TopOfPipe = 1 << 0,
	DrawIndirect = 1 << 1,
	VertexInput = 1 << 2,
	VertexShader = 1 << 3,
	TessellationControlShader = 1 << 4,
	TessellationEvaluationShader = 1 << 5,
	GeometryShader = 1 << 6,
	FragmentShader = 1 << 7,
	EarlyFragmentTests = 1 << 8,
	LateFragmentTests = 1 << 9,
	ColorAttachmentOutput = 1 << 10,
	ComputeShader = 1 << 11,
	Transfer = 1 << 12,
	BottomOfPipe = 1 << 13,
	Host = 1 << 14,
	AllGraphics = 1 << 15,
	AllCommands = 1 << 16,
	CommandProcessNvx = 1 << 17,
}
[Flags]
public enum VkMemoryMapFlags
{
}
[Flags]
public enum VkImageAspectFlags
{
	Color = 1 << 0,
	Depth = 1 << 1,
	Stencil = 1 << 2,
	Metadata = 1 << 3,
	Plane0Khr = 1 << 4,
	Plane1Khr = 1 << 5,
	Plane2Khr = 1 << 6,
}
[Flags]
public enum VkSparseImageFormatFlags
{
	SingleMiptail = 1 << 0,
	AlignedMipSize = 1 << 1,
	NonstandardBlockSize = 1 << 2,
}
[Flags]
public enum VkSparseMemoryBindFlags
{
	Metadata = 1 << 0,
}
[Flags]
public enum VkFenceCreateFlags
{
	Signaled = 1 << 0,
}
[Flags]
public enum VkSemaphoreCreateFlags
{
}
[Flags]
public enum VkEventCreateFlags
{
}
[Flags]
public enum VkQueryPoolCreateFlags
{
}
public enum VkQueryType
{
	Occlusion = 0,
	PipelineStatistics = 1,
	Timestamp = 2,
}
[Flags]
public enum VkQueryPipelineStatisticFlags
{
	InputAssemblyVertices = 1 << 0,
	InputAssemblyPrimitives = 1 << 1,
	VertexShaderInvocations = 1 << 2,
	GeometryShaderInvocations = 1 << 3,
	GeometryShaderPrimitives = 1 << 4,
	ClippingInvocations = 1 << 5,
	ClippingPrimitives = 1 << 6,
	FragmentShaderInvocations = 1 << 7,
	TessellationControlShaderPatches = 1 << 8,
	TessellationEvaluationShaderInvocations = 1 << 9,
	ComputeShaderInvocations = 1 << 10,
}
[Flags]
public enum VkQueryResultFlags
{
	_64 = 1 << 0,
	Wait = 1 << 1,
	WithAvailability = 1 << 2,
	Partial = 1 << 3,
}
[Flags]
public enum VkBufferCreateFlags
{
	SparseBinding = 1 << 0,
	SparseResidency = 1 << 1,
	SparseAliased = 1 << 2,
}
[Flags]
public enum VkBufferUsageFlags
{
	TransferSource = 1 << 0,
	TransferDestination = 1 << 1,
	UniformTexelBuffer = 1 << 2,
	StorageTexelBuffer = 1 << 3,
	UniformBuffer = 1 << 4,
	StorageBuffer = 1 << 5,
	IndexBuffer = 1 << 6,
	VertexBuffer = 1 << 7,
	IndirectBuffer = 1 << 8,
}
public enum VkSharingMode
{
	Exclusive = 0,
	Concurrent = 1,
}
[Flags]
public enum VkBufferViewCreateFlags
{
}
public enum VkImageLayout
{
	Undefined = 0,
	General = 1,
	ColorAttachmentOptimal = 2,
	DepthStencilAttachmentOptimal = 3,
	DepthStencilReadOnlyOptimal = 4,
	ShaderReadOnlyOptimal = 5,
	TransferSourceOptimal = 6,
	TransferDestinationOptimal = 7,
	Preinitialized = 8,
	PresentSourceKhr = 1000001002,
	SharedPresentKhr = 1000111000,
	DepthReadOnlyStencilAttachmentOptimalKhr = 1000117000,
	DepthAttachmentStencilReadOnlyOptimalKhr = 1000117001,
}
[Flags]
public enum VkImageViewCreateFlags
{
}
public enum VkImageViewType
{
	_1d = 0,
	_2d = 1,
	_3d = 2,
	Cube = 3,
	_1dArray = 4,
	_2dArray = 5,
	CubeArray = 6,
}
public enum VkComponentSwizzle
{
	Identity = 0,
	Zero = 1,
	One = 2,
	R = 3,
	G = 4,
	B = 5,
	A = 6,
}
[Flags]
public enum VkShaderModuleCreateFlags
{
}
[Flags]
public enum VkPipelineCacheCreateFlags
{
}
[Flags]
public enum VkPipelineCreateFlags
{
	DisableOptimization = 1 << 0,
	AllowDerivatives = 1 << 1,
	Derivative = 1 << 2,
	ViewIndexFromDeviceIndexKhx = 1 << 3,
	DispatchBaseKhx = 1 << 4,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags
{
}
[Flags]
public enum VkShaderStageFlags
{
	Vertex = 1 << 0,
	TessellationControl = 1 << 1,
	TessellationEvaluation = 1 << 2,
	Geometry = 1 << 3,
	Fragment = 1 << 4,
	Compute = 1 << 5,
	AllGraphics = 0x0000001F,
	All = 0x7FFFFFFF,
}
[Flags]
public enum VkPipelineVertexInputStateCreateFlags
{
}
public enum VkVertexInputRate
{
	Vertex = 0,
	Instance = 1,
}
[Flags]
public enum VkPipelineInputAssemblyStateCreateFlags
{
}
public enum VkPrimitiveTopology
{
	PointList = 0,
	LineList = 1,
	LineStrip = 2,
	TriangleList = 3,
	TriangleStrip = 4,
	TriangleFan = 5,
	LineListWithAdjacency = 6,
	LineStripWithAdjacency = 7,
	TriangleListWithAdjacency = 8,
	TriangleStripWithAdjacency = 9,
	PatchList = 10,
}
[Flags]
public enum VkPipelineTessellationStateCreateFlags
{
}
[Flags]
public enum VkPipelineViewportStateCreateFlags
{
}
[Flags]
public enum VkPipelineRasterizationStateCreateFlags
{
}
public enum VkPolygonMode
{
	Fill = 0,
	Line = 1,
	Point = 2,
	FillRectangleNv = 1000153000,
}
[Flags]
public enum VkCullModeFlags
{
	None = 0,
	Front = 1 << 0,
	Back = 1 << 1,
	FrontAndBack = 0x00000003,
}
public enum VkFrontFace
{
	CounterClockwise = 0,
	Clockwise = 1,
}
[Flags]
public enum VkPipelineMultisampleStateCreateFlags
{
}
[Flags]
public enum VkPipelineDepthStencilStateCreateFlags
{
}
public enum VkCompareOp
{
	Never = 0,
	Less = 1,
	Equal = 2,
	LessOrEqual = 3,
	Greater = 4,
	NotEqual = 5,
	GreaterOrEqual = 6,
	Always = 7,
}
public enum VkStencilOp
{
	Keep = 0,
	Zero = 1,
	Replace = 2,
	IncrementAndClamp = 3,
	DecrementAndClamp = 4,
	Invert = 5,
	IncrementAndWrap = 6,
	DecrementAndWrap = 7,
}
[Flags]
public enum VkPipelineColorBlendStateCreateFlags
{
}
public enum VkLogicOp
{
	Clear = 0,
	And = 1,
	AndReverse = 2,
	Copy = 3,
	AndInverted = 4,
	NoOp = 5,
	Xor = 6,
	Or = 7,
	Nor = 8,
	Equivalent = 9,
	Invert = 10,
	OrReverse = 11,
	CopyInverted = 12,
	OrInverted = 13,
	Nand = 14,
	Set = 15,
}
public enum VkBlendFactor
{
	Zero = 0,
	One = 1,
	SourceColor = 2,
	OneMinusSourceColor = 3,
	DestinationColor = 4,
	OneMinusDestinationColor = 5,
	SourceAlpha = 6,
	OneMinusSourceAlpha = 7,
	DestinationAlpha = 8,
	OneMinusDestinationAlpha = 9,
	ConstantColor = 10,
	OneMinusConstantColor = 11,
	ConstantAlpha = 12,
	OneMinusConstantAlpha = 13,
	SourceAlphaSaturate = 14,
	Source1Color = 15,
	OneMinusSource1Color = 16,
	Source1Alpha = 17,
	OneMinusSource1Alpha = 18,
}
public enum VkBlendOp
{
	Add = 0,
	Subtract = 1,
	ReverseSubtract = 2,
	Min = 3,
	Max = 4,
	ZeroExt = 1000148000,
	SourceExt = 1000148001,
	DestinationExt = 1000148002,
	SourceOverExt = 1000148003,
	DestinationOverExt = 1000148004,
	SourceInExt = 1000148005,
	DestinationInExt = 1000148006,
	SourceOutExt = 1000148007,
	DestinationOutExt = 1000148008,
	SourceAtopExt = 1000148009,
	DestinationAtopExt = 1000148010,
	XorExt = 1000148011,
	MultiplyExt = 1000148012,
	ScreenExt = 1000148013,
	OverlayExt = 1000148014,
	DarkenExt = 1000148015,
	LightenExt = 1000148016,
	ColordodgeExt = 1000148017,
	ColorburnExt = 1000148018,
	HardlightExt = 1000148019,
	SoftlightExt = 1000148020,
	DifferenceExt = 1000148021,
	ExclusionExt = 1000148022,
	InvertExt = 1000148023,
	InvertRgbExt = 1000148024,
	LineardodgeExt = 1000148025,
	LinearburnExt = 1000148026,
	VividlightExt = 1000148027,
	LinearlightExt = 1000148028,
	PinlightExt = 1000148029,
	HardmixExt = 1000148030,
	HslHueExt = 1000148031,
	HslSaturationExt = 1000148032,
	HslColorExt = 1000148033,
	HslLuminosityExt = 1000148034,
	PlusExt = 1000148035,
	PlusClampedExt = 1000148036,
	PlusClampedAlphaExt = 1000148037,
	PlusDarkerExt = 1000148038,
	MinusExt = 1000148039,
	MinusClampedExt = 1000148040,
	ContrastExt = 1000148041,
	InvertOvgExt = 1000148042,
	RedExt = 1000148043,
	GreenExt = 1000148044,
	BlueExt = 1000148045,
}
[Flags]
public enum VkColorComponentFlags
{
	R = 1 << 0,
	G = 1 << 1,
	B = 1 << 2,
	A = 1 << 3,
}
[Flags]
public enum VkPipelineDynamicStateCreateFlags
{
}
public enum VkDynamicState
{
	Viewport = 0,
	Scissor = 1,
	LineWidth = 2,
	DepthBias = 3,
	BlendConstants = 4,
	DepthBounds = 5,
	StencilCompareMask = 6,
	StencilWriteMask = 7,
	StencilReference = 8,
	ViewportWScalingNv = 1000087000,
	DiscardRectangleExt = 1000099000,
	SampleLocationsExt = 1000143000,
}
[Flags]
public enum VkPipelineLayoutCreateFlags
{
}
[Flags]
public enum VkSamplerCreateFlags
{
}
public enum VkFilter
{
	Nearest = 0,
	Linear = 1,
	CubicImg = 1000015000,
}
public enum VkSamplerMipmapMode
{
	Nearest = 0,
	Linear = 1,
}
public enum VkSamplerAddressMode
{
	Repeat = 0,
	MirroredRepeat = 1,
	ClampToEdge = 2,
	ClampToBorder = 3,
	MirrorClampToEdge = 4,
}
public enum VkBorderColor
{
	FloatTransparentBlack = 0,
	IntTransparentBlack = 1,
	FloatOpaqueBlack = 2,
	IntOpaqueBlack = 3,
	FloatOpaqueWhite = 4,
	IntOpaqueWhite = 5,
}
[Flags]
public enum VkDescriptorSetLayoutCreateFlags
{
	PushDescriptorKhr = 1 << 0,
}
public enum VkDescriptorType
{
	Sampler = 0,
	CombinedImageSampler = 1,
	SampledImage = 2,
	StorageImage = 3,
	UniformTexelBuffer = 4,
	StorageTexelBuffer = 5,
	UniformBuffer = 6,
	StorageBuffer = 7,
	UniformBufferDynamic = 8,
	StorageBufferDynamic = 9,
	InputAttachment = 10,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
}
[Flags]
public enum VkDescriptorPoolResetFlags
{
}
[Flags]
public enum VkFramebufferCreateFlags
{
}
[Flags]
public enum VkRenderPassCreateFlags
{
}
[Flags]
public enum VkAttachmentDescriptionFlags
{
	MayAlias = 1 << 0,
}
public enum VkAttachmentLoadOp
{
	Load = 0,
	Clear = 1,
	DontCare = 2,
}
public enum VkAttachmentStoreOp
{
	Store = 0,
	DontCare = 1,
}
[Flags]
public enum VkSubpassDescriptionFlags
{
	PerViewAttributesNvx = 1 << 0,
	PerViewPositionXOnlyNvx = 1 << 1,
}
public enum VkPipelineBindPoint
{
	Graphics = 0,
	Compute = 1,
}
[Flags]
public enum VkAccessFlags
{
	IndirectCommandRead = 1 << 0,
	IndexRead = 1 << 1,
	VertexAttributeRead = 1 << 2,
	UniformRead = 1 << 3,
	InputAttachmentRead = 1 << 4,
	ShaderRead = 1 << 5,
	ShaderWrite = 1 << 6,
	ColorAttachmentRead = 1 << 7,
	ColorAttachmentWrite = 1 << 8,
	DepthStencilAttachmentRead = 1 << 9,
	DepthStencilAttachmentWrite = 1 << 10,
	TransferRead = 1 << 11,
	TransferWrite = 1 << 12,
	HostRead = 1 << 13,
	HostWrite = 1 << 14,
	MemoryRead = 1 << 15,
	MemoryWrite = 1 << 16,
	CommandProcessReadNvx = 1 << 17,
	CommandProcessWriteNvx = 1 << 18,
	ColorAttachmentReadNoncoherentExt = 1 << 19,
}
[Flags]
public enum VkDependencyFlags
{
	ByRegion = 1 << 0,
	ViewLocalKhx = 1 << 1,
	DeviceGroupKhx = 1 << 2,
}
[Flags]
public enum VkCommandPoolCreateFlags
{
	Transient = 1 << 0,
	ResetCommandBuffer = 1 << 1,
}
[Flags]
public enum VkCommandPoolResetFlags
{
	ReleaseResources = 1 << 0,
}
public enum VkCommandBufferLevel
{
	Primary = 0,
	Secondary = 1,
}
[Flags]
public enum VkCommandBufferUsageFlags
{
	OneTimeSubmit = 1 << 0,
	RenderPassContinue = 1 << 1,
	SimultaneousUse = 1 << 2,
}
[Flags]
public enum VkQueryControlFlags
{
	Precise = 1 << 0,
}
[Flags]
public enum VkCommandBufferResetFlags
{
	ReleaseResources = 1 << 0,
}
[Flags]
public enum VkStencilFaceFlags
{
	Front = 1 << 0,
	Back = 1 << 1,
	FrontAndBack = 0x00000003,
}
public enum VkIndexType
{
	Uint16 = 0,
	Uint32 = 1,
}
public enum VkSubpassContents
{
	Inline = 0,
	SecondaryCommandBuffers = 1,
}
public enum VkObjectType
{
	Unknown = 0,
	Instance = 1,
	PhysicalDevice = 2,
	Device = 3,
	Queue = 4,
	Semaphore = 5,
	CommandBuffer = 6,
	Fence = 7,
	DeviceMemory = 8,
	Buffer = 9,
	Image = 10,
	Event = 11,
	QueryPool = 12,
	BufferView = 13,
	ImageView = 14,
	ShaderModule = 15,
	PipelineCache = 16,
	PipelineLayout = 17,
	RenderPass = 18,
	Pipeline = 19,
	DescriptorSetLayout = 20,
	Sampler = 21,
	DescriptorPool = 22,
	DescriptorSet = 23,
	Framebuffer = 24,
	CommandPool = 25,
	SurfaceKhr = 1000000000,
	SwapchainKhr = 1000001000,
	DisplayKhr = 1000002000,
	DisplayModeKhr = 1000002001,
	DebugReportCallbackExt = 1000011000,
	DescriptorUpdateTemplateKhr = 1000085000,
	ObjectTableNvx = 1000086000,
	IndirectCommandsLayoutNvx = 1000086001,
	SamplerYcbcrConversionKhr = 1000156000,
	ValidationCacheExt = 1000160000,
}
[Flags]
public enum VkSurfaceTransformFlagsKHR
{
	IdentityKhr = 1 << 0,
	Rotate90Khr = 1 << 1,
	Rotate180Khr = 1 << 2,
	Rotate270Khr = 1 << 3,
	HorizontalMirrorKhr = 1 << 4,
	HorizontalMirrorRotate90Khr = 1 << 5,
	HorizontalMirrorRotate180Khr = 1 << 6,
	HorizontalMirrorRotate270Khr = 1 << 7,
	InheritKhr = 1 << 8,
}
[Flags]
public enum VkCompositeAlphaFlagsKHR
{
	OpaqueKhr = 1 << 0,
	PreMultipliedKhr = 1 << 1,
	PostMultipliedKhr = 1 << 2,
	InheritKhr = 1 << 3,
}
public enum VkColorSpaceKHR
{
	SrgbNonlinearKhr = 0,
	[Obsolete("Use VkColorSpaceKHR.SrgbNonlinearKhr")]
	ColorspaceSrgbNonlinearKhr = SrgbNonlinearKhr,
	DisplayP3NonlinearExt = 1000104001,
	ExtendedSrgbLinearExt = 1000104002,
	DciP3LinearExt = 1000104003,
	DciP3NonlinearExt = 1000104004,
	Bt709LinearExt = 1000104005,
	Bt709NonlinearExt = 1000104006,
	Bt2020LinearExt = 1000104007,
	Hdr10St2084Ext = 1000104008,
	DolbyvisionExt = 1000104009,
	Hdr10HlgExt = 1000104010,
	AdobergbLinearExt = 1000104011,
	AdobergbNonlinearExt = 1000104012,
	PassThroughExt = 1000104013,
	ExtendedSrgbNonlinearExt = 1000104014,
}
public enum VkPresentModeKHR
{
	ImmediateKhr = 0,
	MailboxKhr = 1,
	FifoKhr = 2,
	FifoRelaxedKhr = 3,
	SharedDemandRefreshKhr = 1000111000,
	SharedContinuousRefreshKhr = 1000111001,
}
[Flags]
public enum VkSwapchainCreateFlagsKHR
{
	BindSfrKhx = 1 << 0,
}
[Flags]
public enum VkDisplayModeCreateFlagsKHR
{
}
[Flags]
public enum VkDisplayPlaneAlphaFlagsKHR
{
	OpaqueKhr = 1 << 0,
	GlobalKhr = 1 << 1,
	PerPixelKhr = 1 << 2,
	PerPixelPremultipliedKhr = 1 << 3,
}
[Flags]
public enum VkDisplaySurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkXlibSurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkXcbSurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkWaylandSurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkAndroidSurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkWin32SurfaceCreateFlagsKHR
{
}
[Flags]
public enum VkDebugReportFlagsEXT
{
	InformationExt = 1 << 0,
	WarningExt = 1 << 1,
	PerformanceWarningExt = 1 << 2,
	ErrorExt = 1 << 3,
	DebugExt = 1 << 4,
}
public enum VkDebugReportObjectTypeEXT
{
	UnknownExt = 0,
	InstanceExt = 1,
	PhysicalDeviceExt = 2,
	DeviceExt = 3,
	QueueExt = 4,
	SemaphoreExt = 5,
	CommandBufferExt = 6,
	FenceExt = 7,
	DeviceMemoryExt = 8,
	BufferExt = 9,
	ImageExt = 10,
	EventExt = 11,
	QueryPoolExt = 12,
	BufferViewExt = 13,
	ImageViewExt = 14,
	ShaderModuleExt = 15,
	PipelineCacheExt = 16,
	PipelineLayoutExt = 17,
	RenderPassExt = 18,
	PipelineExt = 19,
	DescriptorSetLayoutExt = 20,
	SamplerExt = 21,
	DescriptorPoolExt = 22,
	DescriptorSetExt = 23,
	FramebufferExt = 24,
	CommandPoolExt = 25,
	SurfaceKhrExt = 26,
	SwapchainKhrExt = 27,
	DebugReportCallbackExtExt = 28,
	DisplayKhrExt = 29,
	DisplayModeKhrExt = 30,
	ObjectTableNvxExt = 31,
	IndirectCommandsLayoutNvxExt = 32,
	ValidationCacheExtExt = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DebugReportCallbackExtExt")]
	DebugReportExt = DebugReportCallbackExtExt,
	DescriptorUpdateTemplateKhrExt = 1000085000,
	SamplerYcbcrConversionKhrExt = 1000156000,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheExtExt")]
	ValidationCacheExt = ValidationCacheExtExt,
}
public enum VkRasterizationOrderAMD
{
	StrictAmd = 0,
	RelaxedAmd = 1,
}
public enum VkShaderInfoTypeAMD
{
	StatisticsAmd = 0,
	BinaryAmd = 1,
	DisassemblyAmd = 2,
}
[Flags]
public enum VkExternalMemoryHandleTypeFlagsNV
{
	OpaqueWin32Nv = 1 << 0,
	OpaqueWin32KmtNv = 1 << 1,
	D3d11ImageNv = 1 << 2,
	D3d11ImageKmtNv = 1 << 3,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsNV
{
	DedicatedOnlyNv = 1 << 0,
	ExportableNv = 1 << 1,
	ImportableNv = 1 << 2,
}
[Flags]
public enum VkPeerMemoryFeatureFlagsKHX
{
	CopySourceKhx = 1 << 0,
	CopyDestinationKhx = 1 << 1,
	GenericSourceKhx = 1 << 2,
	GenericDestinationKhx = 1 << 3,
}
[Flags]
public enum VkMemoryAllocateFlagsKHX
{
	DeviceMaskKhx = 1 << 0,
}
[Flags]
public enum VkDeviceGroupPresentModeFlagsKHX
{
	LocalKhx = 1 << 0,
	RemoteKhx = 1 << 1,
	SumKhx = 1 << 2,
	LocalMultiDeviceKhx = 1 << 3,
}
public enum VkValidationCheckEXT
{
	AllExt = 0,
	ShadersExt = 1,
}
[Flags]
public enum VkViSurfaceCreateFlagsNN
{
}
[Flags]
public enum VkCommandPoolTrimFlagsKHR
{
}
[Flags]
public enum VkExternalMemoryHandleTypeFlagsKHR
{
	OpaqueFileDescriptorKhr = 1 << 0,
	OpaqueWin32Khr = 1 << 1,
	OpaqueWin32KmtKhr = 1 << 2,
	D3d11TextureKhr = 1 << 3,
	D3d11TextureKmtKhr = 1 << 4,
	D3d12HeapKhr = 1 << 5,
	D3d12ResourceKhr = 1 << 6,
	DmaBufExt = 1 << 9,
	HostAllocationExt = 1 << 7,
	HostMappedForeignMemoryExt = 1 << 8,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsKHR
{
	DedicatedOnlyKhr = 1 << 0,
	ExportableKhr = 1 << 1,
	ImportableKhr = 1 << 2,
}
[Flags]
public enum VkExternalSemaphoreHandleTypeFlagsKHR
{
	OpaqueFileDescriptorKhr = 1 << 0,
	OpaqueWin32Khr = 1 << 1,
	OpaqueWin32KmtKhr = 1 << 2,
	D3d12FenceKhr = 1 << 3,
	SyncFileDescriptorKhr = 1 << 4,
}
[Flags]
public enum VkExternalSemaphoreFeatureFlagsKHR
{
	ExportableKhr = 1 << 0,
	ImportableKhr = 1 << 1,
}
[Flags]
public enum VkSemaphoreImportFlagsKHR
{
	TemporaryKhr = 1 << 0,
}
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlagsKHR
{
}
public enum VkDescriptorUpdateTemplateTypeKHR
{
	DescriptorSetKhr = 0,
	PushDescriptorsKhr = 1,
}
public enum VkIndirectCommandsTokenTypeNVX
{
	PipelineNvx = 0,
	DescriptorSetNvx = 1,
	IndexBufferNvx = 2,
	VertexBufferNvx = 3,
	PushConstantNvx = 4,
	DrawIndexedNvx = 5,
	DrawNvx = 6,
	DispatchNvx = 7,
}
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagsNVX
{
	UnorderedSequencesNvx = 1 << 0,
	SparseSequencesNvx = 1 << 1,
	EmptyExecutionsNvx = 1 << 2,
	IndexedSequencesNvx = 1 << 3,
}
public enum VkObjectEntryTypeNVX
{
	DescriptorSetNvx = 0,
	PipelineNvx = 1,
	IndexBufferNvx = 2,
	VertexBufferNvx = 3,
	PushConstantNvx = 4,
}
[Flags]
public enum VkObjectEntryUsageFlagsNVX
{
	GraphicsNvx = 1 << 0,
	ComputeNvx = 1 << 1,
}
[Flags]
public enum VkSurfaceCounterFlagsEXT
{
	VblankExt = 1 << 0,
}
public enum VkDisplayPowerStateEXT
{
	OffExt = 0,
	SuspendExt = 1,
	OnExt = 2,
}
public enum VkDeviceEventTypeEXT
{
	DisplayHotplugExt = 0,
}
public enum VkDisplayEventTypeEXT
{
	FirstPixelOutExt = 0,
}
public enum VkViewportCoordinateSwizzleNV
{
	PositiveXNv = 0,
	NegativeXNv = 1,
	PositiveYNv = 2,
	NegativeYNv = 3,
	PositiveZNv = 4,
	NegativeZNv = 5,
	PositiveWNv = 6,
	NegativeWNv = 7,
}
[Flags]
public enum VkPipelineViewportSwizzleStateCreateFlagsNV
{
}
[Flags]
public enum VkPipelineDiscardRectangleStateCreateFlagsEXT
{
}
public enum VkDiscardRectangleModeEXT
{
	InclusiveExt = 0,
	ExclusiveExt = 1,
}
[Flags]
public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT
{
}
public enum VkConservativeRasterizationModeEXT
{
	DisabledExt = 0,
	OverestimateExt = 1,
	UnderestimateExt = 2,
}
[Flags]
public enum VkExternalFenceHandleTypeFlagsKHR
{
	OpaqueFileDescriptorKhr = 1 << 0,
	OpaqueWin32Khr = 1 << 1,
	OpaqueWin32KmtKhr = 1 << 2,
	SyncFileDescriptorKhr = 1 << 3,
}
[Flags]
public enum VkExternalFenceFeatureFlagsKHR
{
	ExportableKhr = 1 << 0,
	ImportableKhr = 1 << 1,
}
[Flags]
public enum VkFenceImportFlagsKHR
{
	TemporaryKhr = 1 << 0,
}
public enum VkPointClippingBehaviorKHR
{
	AllClipPlanesKhr = 0,
	UserClipPlanesOnlyKhr = 1,
}
public enum VkTessellationDomainOriginKHR
{
	UpperLeftKhr = 0,
	LowerLeftKhr = 1,
}
[Flags]
public enum VkIOSSurfaceCreateFlagsMVK
{
}
[Flags]
public enum VkMacOSSurfaceCreateFlagsMVK
{
}
public enum VkSamplerReductionModeEXT
{
	WeightedAverageExt = 0,
	MinExt = 1,
	MaxExt = 2,
}
public enum VkBlendOverlapEXT
{
	UncorrelatedExt = 0,
	DisjointExt = 1,
	ConjointExt = 2,
}
[Flags]
public enum VkPipelineCoverageToColorStateCreateFlagsNV
{
}
[Flags]
public enum VkPipelineCoverageModulationStateCreateFlagsNV
{
}
public enum VkCoverageModulationModeNV
{
	NoneNv = 0,
	RgbNv = 1,
	AlphaNv = 2,
	RgbaNv = 3,
}
public enum VkSamplerYcbcrModelConversionKHR
{
	RgbIdentityKhr = 0,
	YcbcrIdentityKhr = 1,
	Ycbcr709Khr = 2,
	Ycbcr601Khr = 3,
	Ycbcr2020Khr = 4,
}
public enum VkSamplerYcbcrRangeKHR
{
	ItuFullKhr = 0,
	ItuNarrowKhr = 1,
}
public enum VkChromaLocationKHR
{
	CositedEvenKhr = 0,
	MidpointKhr = 1,
}
[Flags]
public enum VkValidationCacheCreateFlagsEXT
{
}
public enum VkValidationCacheHeaderVersionEXT
{
	OneExt = 1,
}
public enum VkQueueGlobalPriorityEXT
{
	LowExt = 128,
	MediumExt = 256,
	HighExt = 512,
	RealtimeExt = 1024,
}
