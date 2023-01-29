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
	ErrorSurfaceLostKHR = -1000000000,
	ErrorNativeWindowInUseKHR = -1000000001,
	SuboptimalKHR = 1000001003,
	ErrorOutOfDateKHR = -1000001004,
	ErrorIncompatibleDisplayKHR = -1000003001,
	ErrorValidationFailedEXT = -1000011001,
	ErrorInvalidShaderNV = -1000012000,
	ErrorOutOfPoolMemoryKHR = -1000069000,
	ErrorInvalidExternalHandleKHR = -1000072003,
	ErrorNotPermittedEXT = -1000174001,
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
	SwapchainCreateInfoKHR = 1000001000,
	PresentInfoKHR = 1000001001,
	DisplayModeCreateInfoKHR = 1000002000,
	DisplaySurfaceCreateInfoKHR = 1000002001,
	DisplayPresentInfoKHR = 1000003000,
	XlibSurfaceCreateInfoKHR = 1000004000,
	XcbSurfaceCreateInfoKHR = 1000005000,
	WaylandSurfaceCreateInfoKHR = 1000006000,
	AndroidSurfaceCreateInfoKHR = 1000008000,
	Win32SurfaceCreateInfoKHR = 1000009000,
	DebugReportCallbackCreateInfoEXT = 1000011000,
	[Obsolete("Use VkStructureType.DebugReportCallbackCreateInfoEXT")]
	DebugReportCreateInfoEXT = DebugReportCallbackCreateInfoEXT,
	PipelineRasterizationStateRasterizationOrderAMD = 1000018000,
	DebugMarkerObjectNameInfoEXT = 1000022000,
	DebugMarkerObjectTagInfoEXT = 1000022001,
	DebugMarkerMarkerInfoEXT = 1000022002,
	DedicatedAllocationImageCreateInfoNV = 1000026000,
	DedicatedAllocationBufferCreateInfoNV = 1000026001,
	DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
	TextureLodGatherFormatPropertiesAMD = 1000041000,
	RenderPassMultiviewCreateInfoKHX = 1000053000,
	PhysicalDeviceMultiviewFeaturesKHX = 1000053001,
	PhysicalDeviceMultiviewPropertiesKHX = 1000053002,
	ExternalMemoryImageCreateInfoNV = 1000056000,
	ExportMemoryAllocateInfoNV = 1000056001,
	ImportMemoryWin32HandleInfoNV = 1000057000,
	ExportMemoryWin32HandleInfoNV = 1000057001,
	Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
	PhysicalDeviceFeatures2KHR = 1000059000,
	PhysicalDeviceProperties2KHR = 1000059001,
	FormatProperties2KHR = 1000059002,
	ImageFormatProperties2KHR = 1000059003,
	PhysicalDeviceImageFormatInfo2KHR = 1000059004,
	QueueFamilyProperties2KHR = 1000059005,
	PhysicalDeviceMemoryProperties2KHR = 1000059006,
	SparseImageFormatProperties2KHR = 1000059007,
	PhysicalDeviceSparseImageFormatInfo2KHR = 1000059008,
	MemoryAllocateFlagsInfoKHX = 1000060000,
	DeviceGroupRenderPassBeginInfoKHX = 1000060003,
	DeviceGroupCommandBufferBeginInfoKHX = 1000060004,
	DeviceGroupSubmitInfoKHX = 1000060005,
	DeviceGroupBindSparseInfoKHX = 1000060006,
	AcquireNextImageInfoKHX = 1000060010,
	BindBufferMemoryDeviceGroupInfoKHX = 1000060013,
	BindImageMemoryDeviceGroupInfoKHX = 1000060014,
	DeviceGroupPresentCapabilitiesKHX = 1000060007,
	ImageSwapchainCreateInfoKHX = 1000060008,
	BindImageMemorySwapchainInfoKHX = 1000060009,
	DeviceGroupPresentInfoKHX = 1000060011,
	DeviceGroupSwapchainCreateInfoKHX = 1000060012,
	ValidationFlagsEXT = 1000061000,
	ViSurfaceCreateInfoNN = 1000062000,
	PhysicalDeviceGroupPropertiesKHX = 1000070000,
	DeviceGroupDeviceCreateInfoKHX = 1000070001,
	PhysicalDeviceExternalImageFormatInfoKHR = 1000071000,
	ExternalImageFormatPropertiesKHR = 1000071001,
	PhysicalDeviceExternalBufferInfoKHR = 1000071002,
	ExternalBufferPropertiesKHR = 1000071003,
	PhysicalDeviceIdPropertiesKHR = 1000071004,
	ExternalMemoryBufferCreateInfoKHR = 1000072000,
	ExternalMemoryImageCreateInfoKHR = 1000072001,
	ExportMemoryAllocateInfoKHR = 1000072002,
	ImportMemoryWin32HandleInfoKHR = 1000073000,
	ExportMemoryWin32HandleInfoKHR = 1000073001,
	MemoryWin32HandlePropertiesKHR = 1000073002,
	MemoryGetWin32HandleInfoKHR = 1000073003,
	ImportMemoryFileDescriptorInfoKHR = 1000074000,
	MemoryFileDescriptorPropertiesKHR = 1000074001,
	MemoryGetFileDescriptorInfoKHR = 1000074002,
	Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
	PhysicalDeviceExternalSemaphoreInfoKHR = 1000076000,
	ExternalSemaphorePropertiesKHR = 1000076001,
	ExportSemaphoreCreateInfoKHR = 1000077000,
	ImportSemaphoreWin32HandleInfoKHR = 1000078000,
	ExportSemaphoreWin32HandleInfoKHR = 1000078001,
	D3D12FenceSubmitInfoKHR = 1000078002,
	SemaphoreGetWin32HandleInfoKHR = 1000078003,
	ImportSemaphoreFileDescriptorInfoKHR = 1000079000,
	SemaphoreGetFileDescriptorInfoKHR = 1000079001,
	PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
	PhysicalDevice16bitStorageFeaturesKHR = 1000083000,
	PresentRegionsKHR = 1000084000,
	DescriptorUpdateTemplateCreateInfoKHR = 1000085000,
	ObjectTableCreateInfoNVX = 1000086000,
	IndirectCommandsLayoutCreateInfoNVX = 1000086001,
	CommandProcessCommandsInfoNVX = 1000086002,
	CommandReserveSpaceForCommandsInfoNVX = 1000086003,
	DeviceGeneratedCommandsLimitsNVX = 1000086004,
	DeviceGeneratedCommandsFeaturesNVX = 1000086005,
	PipelineViewportWScalingStateCreateInfoNV = 1000087000,
	SurfaceCapabilities2EXT = 1000090000,
	DisplayPowerInfoEXT = 1000091000,
	DeviceEventInfoEXT = 1000091001,
	DisplayEventInfoEXT = 1000091002,
	SwapchainCounterCreateInfoEXT = 1000091003,
	PresentTimesInfoGOOGLE = 1000092000,
	PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,
	PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
	PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,
	PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,
	PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,
	PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,
	HDRMetadataEXT = 1000105000,
	SharedPresentSurfaceCapabilitiesKHR = 1000111000,
	PhysicalDeviceExternalFenceInfoKHR = 1000112000,
	ExternalFencePropertiesKHR = 1000112001,
	ExportFenceCreateInfoKHR = 1000113000,
	ImportFenceWin32HandleInfoKHR = 1000114000,
	ExportFenceWin32HandleInfoKHR = 1000114001,
	FenceGetWin32HandleInfoKHR = 1000114002,
	ImportFenceFileDescriptorInfoKHR = 1000115000,
	FenceGetFileDescriptorInfoKHR = 1000115001,
	PhysicalDevicePointClippingPropertiesKHR = 1000117000,
	RenderPassInputAttachmentAspectCreateInfoKHR = 1000117001,
	ImageViewUsageCreateInfoKHR = 1000117002,
	PipelineTessellationDomainOriginStateCreateInfoKHR = 1000117003,
	PhysicalDeviceSurfaceInfo2KHR = 1000119000,
	SurfaceCapabilities2KHR = 1000119001,
	SurfaceFormat2KHR = 1000119002,
	PhysicalDeviceVariablePointerFeaturesKHR = 1000120000,
	IosSurfaceCreateInfoMVK = 1000122000,
	MacosSurfaceCreateInfoMVK = 1000123000,
	MemoryDedicatedRequirementsKHR = 1000127000,
	MemoryDedicatedAllocateInfoKHR = 1000127001,
	PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = 1000130000,
	SamplerReductionModeCreateInfoEXT = 1000130001,
	SampleLocationsInfoEXT = 1000143000,
	RenderPassSampleLocationsBeginInfoEXT = 1000143001,
	PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
	PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
	MultisamplePropertiesEXT = 1000143004,
	BufferMemoryRequirementsInfo2KHR = 1000146000,
	ImageMemoryRequirementsInfo2KHR = 1000146001,
	ImageSparseMemoryRequirementsInfo2KHR = 1000146002,
	MemoryRequirements2KHR = 1000146003,
	SparseImageMemoryRequirements2KHR = 1000146004,
	ImageFormatListCreateInfoKHR = 1000147000,
	PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
	PipelineCoverageToColorStateCreateInfoNV = 1000149000,
	PipelineCoverageModulationStateCreateInfoNV = 1000152000,
	SamplerYCBCRConversionCreateInfoKHR = 1000156000,
	SamplerYCBCRConversionInfoKHR = 1000156001,
	BindImagePlaneMemoryInfoKHR = 1000156002,
	ImagePlaneMemoryRequirementsInfoKHR = 1000156003,
	PhysicalDeviceSamplerYCBCRConversionFeaturesKHR = 1000156004,
	SamplerYCBCRConversionImageFormatPropertiesKHR = 1000156005,
	BindBufferMemoryInfoKHR = 1000157000,
	BindImageMemoryInfoKHR = 1000157001,
	ValidationCacheCreateInfoEXT = 1000160000,
	ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
	DeviceQueueGlobalPriorityCreateInfoEXT = 1000174000,
	ImportMemoryHostPointerInfoEXT = 1000178000,
	MemoryHostPointerPropertiesEXT = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
}
[Flags]
public enum VkInstanceCreateFlags
{
}
public enum VkSystemAllocationScope
{
	Command = 0,
	Object = 1,
	Cache = 2,
	Device = 3,
	Instance = 4,
}
public enum VkInternalAllocationType
{
	Executable = 0,
}
public enum VkFormat
{
	Undefined = 0,
	R4G4UNormPack8 = 1,
	R4G4B4A4UNormPack16 = 2,
	B4G4R4A4UNormPack16 = 3,
	R5G6B5UNormPack16 = 4,
	B5G6R5UNormPack16 = 5,
	R5G5B5A1UNormPack16 = 6,
	B5G5R5A1UNormPack16 = 7,
	A1R5G5B5UNormPack16 = 8,
	R8UNorm = 9,
	R8SNorm = 10,
	R8UScaled = 11,
	R8SScaled = 12,
	R8UInt = 13,
	R8SInt = 14,
	R8SRGB = 15,
	R8G8UNorm = 16,
	R8G8SNorm = 17,
	R8G8UScaled = 18,
	R8G8SScaled = 19,
	R8G8UInt = 20,
	R8G8SInt = 21,
	R8G8SRGB = 22,
	R8G8B8UNorm = 23,
	R8G8B8SNorm = 24,
	R8G8B8UScaled = 25,
	R8G8B8SScaled = 26,
	R8G8B8UInt = 27,
	R8G8B8SInt = 28,
	R8G8B8SRGB = 29,
	B8G8R8UNorm = 30,
	B8G8R8SNorm = 31,
	B8G8R8UScaled = 32,
	B8G8R8SScaled = 33,
	B8G8R8UInt = 34,
	B8G8R8SInt = 35,
	B8G8R8SRGB = 36,
	R8G8B8A8UNorm = 37,
	R8G8B8A8SNorm = 38,
	R8G8B8A8UScaled = 39,
	R8G8B8A8SScaled = 40,
	R8G8B8A8UInt = 41,
	R8G8B8A8SInt = 42,
	R8G8B8A8SRGB = 43,
	B8G8R8A8UNorm = 44,
	B8G8R8A8SNorm = 45,
	B8G8R8A8UScaled = 46,
	B8G8R8A8SScaled = 47,
	B8G8R8A8UInt = 48,
	B8G8R8A8SInt = 49,
	B8G8R8A8SRGB = 50,
	A8B8G8R8UNormPack32 = 51,
	A8B8G8R8SNormPack32 = 52,
	A8B8G8R8UScaledPack32 = 53,
	A8B8G8R8SScaledPack32 = 54,
	A8B8G8R8UIntPack32 = 55,
	A8B8G8R8SIntPack32 = 56,
	A8B8G8R8SRGBPack32 = 57,
	A2R10G10B10UNormPack32 = 58,
	A2R10G10B10SNormPack32 = 59,
	A2R10G10B10UScaledPack32 = 60,
	A2R10G10B10SScaledPack32 = 61,
	A2R10G10B10UIntPack32 = 62,
	A2R10G10B10SIntPack32 = 63,
	A2B10G10R10UNormPack32 = 64,
	A2B10G10R10SNormPack32 = 65,
	A2B10G10R10UScaledPack32 = 66,
	A2B10G10R10SScaledPack32 = 67,
	A2B10G10R10UIntPack32 = 68,
	A2B10G10R10SIntPack32 = 69,
	R16UNorm = 70,
	R16SNorm = 71,
	R16UScaled = 72,
	R16SScaled = 73,
	R16UInt = 74,
	R16SInt = 75,
	R16SFloat = 76,
	R16G16UNorm = 77,
	R16G16SNorm = 78,
	R16G16UScaled = 79,
	R16G16SScaled = 80,
	R16G16UInt = 81,
	R16G16SInt = 82,
	R16G16SFloat = 83,
	R16G16B16UNorm = 84,
	R16G16B16SNorm = 85,
	R16G16B16UScaled = 86,
	R16G16B16SScaled = 87,
	R16G16B16UInt = 88,
	R16G16B16SInt = 89,
	R16G16B16SFloat = 90,
	R16G16B16A16UNorm = 91,
	R16G16B16A16SNorm = 92,
	R16G16B16A16UScaled = 93,
	R16G16B16A16SScaled = 94,
	R16G16B16A16UInt = 95,
	R16G16B16A16SInt = 96,
	R16G16B16A16SFloat = 97,
	R32UInt = 98,
	R32SInt = 99,
	R32SFloat = 100,
	R32G32UInt = 101,
	R32G32SInt = 102,
	R32G32SFloat = 103,
	R32G32B32UInt = 104,
	R32G32B32SInt = 105,
	R32G32B32SFloat = 106,
	R32G32B32A32UInt = 107,
	R32G32B32A32SInt = 108,
	R32G32B32A32SFloat = 109,
	R64UInt = 110,
	R64SInt = 111,
	R64SFloat = 112,
	R64G64UInt = 113,
	R64G64SInt = 114,
	R64G64SFloat = 115,
	R64G64B64UInt = 116,
	R64G64B64SInt = 117,
	R64G64B64SFloat = 118,
	R64G64B64A64UInt = 119,
	R64G64B64A64SInt = 120,
	R64G64B64A64SFloat = 121,
	B10G11R11UFloatPack32 = 122,
	E5B9G9R9UFloatPack32 = 123,
	D16UNorm = 124,
	X8D24UNormPack32 = 125,
	D32SFloat = 126,
	S8UInt = 127,
	D16UNormS8UInt = 128,
	D24UNormS8UInt = 129,
	D32SFloatS8UInt = 130,
	BC1RGBUNormBlock = 131,
	BC1RGBSRGBBlock = 132,
	BC1RGBAUNormBlock = 133,
	BC1RGBASRGBBlock = 134,
	BC2UNormBlock = 135,
	BC2SRGBBlock = 136,
	BC3UNormBlock = 137,
	BC3SRGBBlock = 138,
	BC4UNormBlock = 139,
	BC4SNormBlock = 140,
	BC5UNormBlock = 141,
	BC5SNormBlock = 142,
	BC6HUFloatBlock = 143,
	BC6HSFloatBlock = 144,
	BC7UNormBlock = 145,
	BC7SRGBBlock = 146,
	ETC2R8G8B8UNormBlock = 147,
	ETC2R8G8B8SRGBBlock = 148,
	ETC2R8G8B8A1UNormBlock = 149,
	ETC2R8G8B8A1SRGBBlock = 150,
	ETC2R8G8B8A8UNormBlock = 151,
	ETC2R8G8B8A8SRGBBlock = 152,
	EACR11UNormBlock = 153,
	EACR11SNormBlock = 154,
	EACR11G11UNormBlock = 155,
	EACR11G11SNormBlock = 156,
	ASTC4x4UNormBlock = 157,
	ASTC4x4SRGBBlock = 158,
	ASTC5x4UNormBlock = 159,
	ASTC5x4SRGBBlock = 160,
	ASTC5x5UNormBlock = 161,
	ASTC5x5SRGBBlock = 162,
	ASTC6x5UNormBlock = 163,
	ASTC6x5SRGBBlock = 164,
	ASTC6x6UNormBlock = 165,
	ASTC6x6SRGBBlock = 166,
	ASTC8x5UNormBlock = 167,
	ASTC8x5SRGBBlock = 168,
	ASTC8x6UNormBlock = 169,
	ASTC8x6SRGBBlock = 170,
	ASTC8x8UNormBlock = 171,
	ASTC8x8SRGBBlock = 172,
	ASTC10x5UNormBlock = 173,
	ASTC10x5SRGBBlock = 174,
	ASTC10x6UNormBlock = 175,
	ASTC10x6SRGBBlock = 176,
	ASTC10x8UNormBlock = 177,
	ASTC10x8SRGBBlock = 178,
	ASTC10x10UNormBlock = 179,
	ASTC10x10SRGBBlock = 180,
	ASTC12x10UNormBlock = 181,
	ASTC12x10SRGBBlock = 182,
	ASTC12x12UNormBlock = 183,
	ASTC12x12SRGBBlock = 184,
	PVRTC12BPPUNormBlockIMG = 1000054000,
	PVRTC14BPPUNormBlockIMG = 1000054001,
	PVRTC22BPPUNormBlockIMG = 1000054002,
	PVRTC24BPPUNormBlockIMG = 1000054003,
	PVRTC12BPPSRGBBlockIMG = 1000054004,
	PVRTC14BPPSRGBBlockIMG = 1000054005,
	PVRTC22BPPSRGBBlockIMG = 1000054006,
	PVRTC24BPPSRGBBlockIMG = 1000054007,
	G8B8G8R8422UNormKHR = 1000156000,
	B8G8R8G8422UNormKHR = 1000156001,
	G8B8R83Plane420UNormKHR = 1000156002,
	G8B8R82Plane420UNormKHR = 1000156003,
	G8B8R83Plane422UNormKHR = 1000156004,
	G8B8R82Plane422UNormKHR = 1000156005,
	G8B8R83Plane444UNormKHR = 1000156006,
	R10X6UNormPack16KHR = 1000156007,
	R10X6G10X6UNorm2Pack16KHR = 1000156008,
	R10X6G10X6B10X6A10X6UNorm4Pack16KHR = 1000156009,
	G10X6B10X6G10X6R10X6422UNorm4Pack16KHR = 1000156010,
	B10X6G10X6R10X6G10X6422UNorm4Pack16KHR = 1000156011,
	G10X6B10X6R10X63Plane420UNorm3Pack16KHR = 1000156012,
	G10X6B10X6R10X62Plane420UNorm3Pack16KHR = 1000156013,
	G10X6B10X6R10X63Plane422UNorm3Pack16KHR = 1000156014,
	G10X6B10X6R10X62Plane422UNorm3Pack16KHR = 1000156015,
	G10X6B10X6R10X63Plane444UNorm3Pack16KHR = 1000156016,
	R12X4UNormPack16KHR = 1000156017,
	R12X4G12X4UNorm2Pack16KHR = 1000156018,
	R12X4G12X4B12X4A12X4UNorm4Pack16KHR = 1000156019,
	G12X4B12X4G12X4R12X4422UNorm4Pack16KHR = 1000156020,
	B12X4G12X4R12X4G12X4422UNorm4Pack16KHR = 1000156021,
	G12X4B12X4R12X43Plane420UNorm3Pack16KHR = 1000156022,
	G12X4B12X4R12X42Plane420UNorm3Pack16KHR = 1000156023,
	G12X4B12X4R12X43Plane422UNorm3Pack16KHR = 1000156024,
	G12X4B12X4R12X42Plane422UNorm3Pack16KHR = 1000156025,
	G12X4B12X4R12X43Plane444UNorm3Pack16KHR = 1000156026,
	G16B16G16R16422UNormKHR = 1000156027,
	B16G16R16G16422UNormKHR = 1000156028,
	G16B16R163Plane420UNormKHR = 1000156029,
	G16B16R162Plane420UNormKHR = 1000156030,
	G16B16R163Plane422UNormKHR = 1000156031,
	G16B16R162Plane422UNormKHR = 1000156032,
	G16B16R163Plane444UNormKHR = 1000156033,
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
	SampledImageFilterCubicIMG = 1 << 13,
	TransferSourceKHR = 1 << 14,
	TransferDestinationKHR = 1 << 15,
	SampledImageFilterMinmaxEXT = 1 << 16,
	MidpointChromaSamplesKHR = 1 << 17,
	SampledImageYCBCRConversionLinearFilterKHR = 1 << 18,
	SampledImageYCBCRConversionSeparateReconstructionFilterKHR = 1 << 19,
	SampledImageYCBCRConversionChromaReconstructionExplicitKHR = 1 << 20,
	SampledImageYCBCRConversionChromaReconstructionExplicitForceableKHR = 1 << 21,
	DisjointKHR = 1 << 22,
	CositedChromaSamplesKHR = 1 << 23,
}
public enum VkImageType
{
	_1D = 0,
	_2D = 1,
	_3D = 2,
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
	BindSfrKHX = 1 << 6,
	_2DArrayCompatibleKHR = 1 << 5,
	BlockTexelViewCompatibleKHR = 1 << 7,
	ExtendedUsageKHR = 1 << 8,
	SampleLocationsCompatibleDepthEXT = 1 << 12,
	DisjointKHR = 1 << 9,
	AliasKHR = 1 << 10,
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
	IntegratedGPU = 1,
	DiscreteGPU = 2,
	VirtualGPU = 3,
	CPU = 4,
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
	MultiInstanceKHX = 1 << 1,
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
	CommandProcessNVX = 1 << 17,
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
	Plane0KHR = 1 << 4,
	Plane1KHR = 1 << 5,
	Plane2KHR = 1 << 6,
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
	PresentSourceKHR = 1000001002,
	SharedPresentKHR = 1000111000,
	DepthReadOnlyStencilAttachmentOptimalKHR = 1000117000,
	DepthAttachmentStencilReadOnlyOptimalKHR = 1000117001,
}
[Flags]
public enum VkImageViewCreateFlags
{
}
public enum VkImageViewType
{
	_1D = 0,
	_2D = 1,
	_3D = 2,
	Cube = 3,
	_1DArray = 4,
	_2DArray = 5,
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
	ViewIndexFromDeviceIndexKHX = 1 << 3,
	DispatchBaseKHX = 1 << 4,
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
	FillRectangleNV = 1000153000,
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
	ZeroEXT = 1000148000,
	SourceEXT = 1000148001,
	DestinationEXT = 1000148002,
	SourceOverEXT = 1000148003,
	DestinationOverEXT = 1000148004,
	SourceInEXT = 1000148005,
	DestinationInEXT = 1000148006,
	SourceOutEXT = 1000148007,
	DestinationOutEXT = 1000148008,
	SourceAtopEXT = 1000148009,
	DestinationAtopEXT = 1000148010,
	XorEXT = 1000148011,
	MultiplyEXT = 1000148012,
	ScreenEXT = 1000148013,
	OverlayEXT = 1000148014,
	DarkenEXT = 1000148015,
	LightenEXT = 1000148016,
	ColordodgeEXT = 1000148017,
	ColorburnEXT = 1000148018,
	HardlightEXT = 1000148019,
	SoftlightEXT = 1000148020,
	DifferenceEXT = 1000148021,
	ExclusionEXT = 1000148022,
	InvertEXT = 1000148023,
	InvertRGBEXT = 1000148024,
	LineardodgeEXT = 1000148025,
	LinearburnEXT = 1000148026,
	VividlightEXT = 1000148027,
	LinearlightEXT = 1000148028,
	PinlightEXT = 1000148029,
	HardmixEXT = 1000148030,
	HSLHueEXT = 1000148031,
	HSLSaturationEXT = 1000148032,
	HSLColorEXT = 1000148033,
	HSLLuminosityEXT = 1000148034,
	PlusEXT = 1000148035,
	PlusClampedEXT = 1000148036,
	PlusClampedAlphaEXT = 1000148037,
	PlusDarkerEXT = 1000148038,
	MinusEXT = 1000148039,
	MinusClampedEXT = 1000148040,
	ContrastEXT = 1000148041,
	InvertOvgEXT = 1000148042,
	RedEXT = 1000148043,
	GreenEXT = 1000148044,
	BlueEXT = 1000148045,
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
	ViewportWScalingNV = 1000087000,
	DiscardRectangleEXT = 1000099000,
	SampleLocationsEXT = 1000143000,
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
	CubicIMG = 1000015000,
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
	PushDescriptorKHR = 1 << 0,
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
	PerViewAttributesNVX = 1 << 0,
	PerViewPositionXOnlyNVX = 1 << 1,
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
	CommandProcessReadNVX = 1 << 17,
	CommandProcessWriteNVX = 1 << 18,
	ColorAttachmentReadNoncoherentEXT = 1 << 19,
}
[Flags]
public enum VkDependencyFlags
{
	ByRegion = 1 << 0,
	ViewLocalKHX = 1 << 1,
	DeviceGroupKHX = 1 << 2,
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
	UInt16 = 0,
	UInt32 = 1,
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
	SurfaceKHR = 1000000000,
	SwapchainKHR = 1000001000,
	DisplayKHR = 1000002000,
	DisplayModeKHR = 1000002001,
	DebugReportCallbackEXT = 1000011000,
	DescriptorUpdateTemplateKHR = 1000085000,
	ObjectTableNVX = 1000086000,
	IndirectCommandsLayoutNVX = 1000086001,
	SamplerYCBCRConversionKHR = 1000156000,
	ValidationCacheEXT = 1000160000,
}
[Flags]
public enum VkSurfaceTransformFlagsKHR
{
	IdentityKHR = 1 << 0,
	Rotate90KHR = 1 << 1,
	Rotate180KHR = 1 << 2,
	Rotate270KHR = 1 << 3,
	HorizontalMirrorKHR = 1 << 4,
	HorizontalMirrorRotate90KHR = 1 << 5,
	HorizontalMirrorRotate180KHR = 1 << 6,
	HorizontalMirrorRotate270KHR = 1 << 7,
	InheritKHR = 1 << 8,
}
[Flags]
public enum VkCompositeAlphaFlagsKHR
{
	OpaqueKHR = 1 << 0,
	PreMultipliedKHR = 1 << 1,
	PostMultipliedKHR = 1 << 2,
	InheritKHR = 1 << 3,
}
public enum VkColorSpaceKHR
{
	SRGBNonlinearKHR = 0,
	[Obsolete("Use VkColorSpaceKHR.SRGBNonlinearKHR")]
	ColorspaceSRGBNonlinearKHR = SRGBNonlinearKHR,
	DisplayP3NonlinearEXT = 1000104001,
	ExtendedSRGBLinearEXT = 1000104002,
	DCIP3LinearEXT = 1000104003,
	DCIP3NonlinearEXT = 1000104004,
	BT709LinearEXT = 1000104005,
	BT709NonlinearEXT = 1000104006,
	BT2020LinearEXT = 1000104007,
	HDR10ST2084EXT = 1000104008,
	DolbyVisionEXT = 1000104009,
	HDR10HLGEXT = 1000104010,
	AdobeRGBLinearEXT = 1000104011,
	AdobeRGBNonlinearEXT = 1000104012,
	PassThroughEXT = 1000104013,
	ExtendedSRGBNonlinearEXT = 1000104014,
}
public enum VkPresentModeKHR
{
	ImmediateKHR = 0,
	MailboxKHR = 1,
	FifoKHR = 2,
	FifoRelaxedKHR = 3,
	SharedDemandRefreshKHR = 1000111000,
	SharedContinuousRefreshKHR = 1000111001,
}
[Flags]
public enum VkSwapchainCreateFlagsKHR
{
	BindSfrKHX = 1 << 0,
}
[Flags]
public enum VkDisplayModeCreateFlagsKHR
{
}
[Flags]
public enum VkDisplayPlaneAlphaFlagsKHR
{
	OpaqueKHR = 1 << 0,
	GlobalKHR = 1 << 1,
	PerPixelKHR = 1 << 2,
	PerPixelPremultipliedKHR = 1 << 3,
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
	InformationEXT = 1 << 0,
	WarningEXT = 1 << 1,
	PerformanceWarningEXT = 1 << 2,
	ErrorEXT = 1 << 3,
	DebugEXT = 1 << 4,
}
public enum VkDebugReportObjectTypeEXT
{
	UnknownEXT = 0,
	InstanceEXT = 1,
	PhysicalDeviceEXT = 2,
	DeviceEXT = 3,
	QueueEXT = 4,
	SemaphoreEXT = 5,
	CommandBufferEXT = 6,
	FenceEXT = 7,
	DeviceMemoryEXT = 8,
	BufferEXT = 9,
	ImageEXT = 10,
	EventEXT = 11,
	QueryPoolEXT = 12,
	BufferViewEXT = 13,
	ImageViewEXT = 14,
	ShaderModuleEXT = 15,
	PipelineCacheEXT = 16,
	PipelineLayoutEXT = 17,
	RenderPassEXT = 18,
	PipelineEXT = 19,
	DescriptorSetLayoutEXT = 20,
	SamplerEXT = 21,
	DescriptorPoolEXT = 22,
	DescriptorSetEXT = 23,
	FramebufferEXT = 24,
	CommandPoolEXT = 25,
	SurfaceKHREXT = 26,
	SwapchainKHREXT = 27,
	DebugReportCallbackEXTEXT = 28,
	DisplayKHREXT = 29,
	DisplayModeKHREXT = 30,
	ObjectTableNVXEXT = 31,
	IndirectCommandsLayoutNVXEXT = 32,
	ValidationCacheEXTEXT = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DebugReportCallbackEXTEXT")]
	DebugReportEXT = DebugReportCallbackEXTEXT,
	DescriptorUpdateTemplateKHREXT = 1000085000,
	SamplerYCBCRConversionKHREXT = 1000156000,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheEXTEXT")]
	ValidationCacheEXT = ValidationCacheEXTEXT,
}
public enum VkRasterizationOrderAMD
{
	StrictAMD = 0,
	RelaxedAMD = 1,
}
public enum VkShaderInfoTypeAMD
{
	StatisticsAMD = 0,
	BinaryAMD = 1,
	DisassemblyAMD = 2,
}
[Flags]
public enum VkExternalMemoryHandleTypeFlagsNV
{
	OpaqueWin32NV = 1 << 0,
	OpaqueWin32KmtNV = 1 << 1,
	D3D11ImageNV = 1 << 2,
	D3D11ImageKmtNV = 1 << 3,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsNV
{
	DedicatedOnlyNV = 1 << 0,
	ExportableNV = 1 << 1,
	ImportableNV = 1 << 2,
}
[Flags]
public enum VkPeerMemoryFeatureFlagsKHX
{
	CopySourceKHX = 1 << 0,
	CopyDestinationKHX = 1 << 1,
	GenericSourceKHX = 1 << 2,
	GenericDestinationKHX = 1 << 3,
}
[Flags]
public enum VkMemoryAllocateFlagsKHX
{
	DeviceMaskKHX = 1 << 0,
}
[Flags]
public enum VkDeviceGroupPresentModeFlagsKHX
{
	LocalKHX = 1 << 0,
	RemoteKHX = 1 << 1,
	SumKHX = 1 << 2,
	LocalMultiDeviceKHX = 1 << 3,
}
public enum VkValidationCheckEXT
{
	AllEXT = 0,
	ShadersEXT = 1,
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
	OpaqueFileDescriptorKHR = 1 << 0,
	OpaqueWin32KHR = 1 << 1,
	OpaqueWin32KmtKHR = 1 << 2,
	D3D11TextureKHR = 1 << 3,
	D3D11TextureKmtKHR = 1 << 4,
	D3D12HeapKHR = 1 << 5,
	D3D12ResourceKHR = 1 << 6,
	DmaBufEXT = 1 << 9,
	HostAllocationEXT = 1 << 7,
	HostMappedForeignMemoryEXT = 1 << 8,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsKHR
{
	DedicatedOnlyKHR = 1 << 0,
	ExportableKHR = 1 << 1,
	ImportableKHR = 1 << 2,
}
[Flags]
public enum VkExternalSemaphoreHandleTypeFlagsKHR
{
	OpaqueFileDescriptorKHR = 1 << 0,
	OpaqueWin32KHR = 1 << 1,
	OpaqueWin32KmtKHR = 1 << 2,
	D3D12FenceKHR = 1 << 3,
	SyncFileDescriptorKHR = 1 << 4,
}
[Flags]
public enum VkExternalSemaphoreFeatureFlagsKHR
{
	ExportableKHR = 1 << 0,
	ImportableKHR = 1 << 1,
}
[Flags]
public enum VkSemaphoreImportFlagsKHR
{
	TemporaryKHR = 1 << 0,
}
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlagsKHR
{
}
public enum VkDescriptorUpdateTemplateTypeKHR
{
	DescriptorSetKHR = 0,
	PushDescriptorsKHR = 1,
}
public enum VkIndirectCommandsTokenTypeNVX
{
	PipelineNVX = 0,
	DescriptorSetNVX = 1,
	IndexBufferNVX = 2,
	VertexBufferNVX = 3,
	PushConstantNVX = 4,
	DrawIndexedNVX = 5,
	DrawNVX = 6,
	DispatchNVX = 7,
}
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagsNVX
{
	UnorderedSequencesNVX = 1 << 0,
	SparseSequencesNVX = 1 << 1,
	EmptyExecutionsNVX = 1 << 2,
	IndexedSequencesNVX = 1 << 3,
}
public enum VkObjectEntryTypeNVX
{
	DescriptorSetNVX = 0,
	PipelineNVX = 1,
	IndexBufferNVX = 2,
	VertexBufferNVX = 3,
	PushConstantNVX = 4,
}
[Flags]
public enum VkObjectEntryUsageFlagsNVX
{
	GraphicsNVX = 1 << 0,
	ComputeNVX = 1 << 1,
}
[Flags]
public enum VkSurfaceCounterFlagsEXT
{
	VBlankEXT = 1 << 0,
}
public enum VkDisplayPowerStateEXT
{
	OffEXT = 0,
	SuspendEXT = 1,
	OnEXT = 2,
}
public enum VkDeviceEventTypeEXT
{
	DisplayHotplugEXT = 0,
}
public enum VkDisplayEventTypeEXT
{
	FirstPixelOutEXT = 0,
}
public enum VkViewportCoordinateSwizzleNV
{
	PositiveXNV = 0,
	NegativeXNV = 1,
	PositiveYNV = 2,
	NegativeYNV = 3,
	PositiveZNV = 4,
	NegativeZNV = 5,
	PositiveWNV = 6,
	NegativeWNV = 7,
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
	InclusiveEXT = 0,
	ExclusiveEXT = 1,
}
[Flags]
public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT
{
}
public enum VkConservativeRasterizationModeEXT
{
	DisabledEXT = 0,
	OverestimateEXT = 1,
	UnderestimateEXT = 2,
}
[Flags]
public enum VkExternalFenceHandleTypeFlagsKHR
{
	OpaqueFileDescriptorKHR = 1 << 0,
	OpaqueWin32KHR = 1 << 1,
	OpaqueWin32KmtKHR = 1 << 2,
	SyncFileDescriptorKHR = 1 << 3,
}
[Flags]
public enum VkExternalFenceFeatureFlagsKHR
{
	ExportableKHR = 1 << 0,
	ImportableKHR = 1 << 1,
}
[Flags]
public enum VkFenceImportFlagsKHR
{
	TemporaryKHR = 1 << 0,
}
public enum VkPointClippingBehaviorKHR
{
	AllClipPlanesKHR = 0,
	UserClipPlanesOnlyKHR = 1,
}
public enum VkTessellationDomainOriginKHR
{
	UpperLeftKHR = 0,
	LowerLeftKHR = 1,
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
	WeightedAverageEXT = 0,
	MinEXT = 1,
	MaxEXT = 2,
}
public enum VkBlendOverlapEXT
{
	UncorrelatedEXT = 0,
	DisjointEXT = 1,
	ConjointEXT = 2,
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
	NoneNV = 0,
	RGBNV = 1,
	AlphaNV = 2,
	RGBANV = 3,
}
public enum VkSamplerYcbcrModelConversionKHR
{
	RGBIdentityKHR = 0,
	YCBCRIdentityKHR = 1,
	YCBCR709KHR = 2,
	YCBCR601KHR = 3,
	YCBCR2020KHR = 4,
}
public enum VkSamplerYcbcrRangeKHR
{
	ITUFullKHR = 0,
	ITUNarrowKHR = 1,
}
public enum VkChromaLocationKHR
{
	CositedEvenKHR = 0,
	MidpointKHR = 1,
}
[Flags]
public enum VkValidationCacheCreateFlagsEXT
{
}
public enum VkValidationCacheHeaderVersionEXT
{
	OneEXT = 1,
}
public enum VkQueueGlobalPriorityEXT
{
	LowEXT = 128,
	MediumEXT = 256,
	HighEXT = 512,
	RealtimeEXT = 1024,
}
