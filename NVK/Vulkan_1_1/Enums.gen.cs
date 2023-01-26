// This file was generated, don't manually edit
namespace Vulkan_1_1;

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
	ErrorOutOfPoolMemory = -1000069000,
	ErrorInvalidExternalHandle = -1000072003,
	ErrorSurfaceLostKHR = -1000000000,
	ErrorNativeWindowInUseKHR = -1000000001,
	SuboptimalKHR = 1000001003,
	ErrorOutOfDateKHR = -1000001004,
	ErrorIncompatibleDisplayKHR = -1000003001,
	ErrorValidationFailedEXT = -1000011001,
	ErrorInvalidShaderNV = -1000012000,
	[Obsolete("Use VkResult.ErrorOutOfPoolMemory")]
	ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,
	[Obsolete("Use VkResult.ErrorInvalidExternalHandle")]
	ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,
	ErrorInvalidDRMFormatModifierPlaneLayoutEXT = -1000158000,
	ErrorFragmentationEXT = -1000161000,
	ErrorNotPermittedEXT = -1000174001,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddressKHR")]
	ErrorInvalidDeviceAddressEXT = ErrorInvalidOpaqueCaptureAddressKHR,
	ErrorFullScreenExclusiveModeLostEXT = -1000255000,
	ErrorInvalidOpaqueCaptureAddressKHR = -1000257000,
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
	PhysicalDeviceSubgroupProperties = 1000094000,
	BindBufferMemoryInfo = 1000157000,
	BindImageMemoryInfo = 1000157001,
	PhysicalDevice16bitStorageFeatures = 1000083000,
	MemoryDedicatedRequirements = 1000127000,
	MemoryDedicatedAllocateInfo = 1000127001,
	MemoryAllocateFlagsInfo = 1000060000,
	DeviceGroupRenderPassBeginInfo = 1000060003,
	DeviceGroupCommandBufferBeginInfo = 1000060004,
	DeviceGroupSubmitInfo = 1000060005,
	DeviceGroupBindSparseInfo = 1000060006,
	BindBufferMemoryDeviceGroupInfo = 1000060013,
	BindImageMemoryDeviceGroupInfo = 1000060014,
	PhysicalDeviceGroupProperties = 1000070000,
	DeviceGroupDeviceCreateInfo = 1000070001,
	BufferMemoryRequirementsInfo2 = 1000146000,
	ImageMemoryRequirementsInfo2 = 1000146001,
	ImageSparseMemoryRequirementsInfo2 = 1000146002,
	MemoryRequirements2 = 1000146003,
	SparseImageMemoryRequirements2 = 1000146004,
	PhysicalDeviceFeatures2 = 1000059000,
	PhysicalDeviceProperties2 = 1000059001,
	FormatProperties2 = 1000059002,
	ImageFormatProperties2 = 1000059003,
	PhysicalDeviceImageFormatInfo2 = 1000059004,
	QueueFamilyProperties2 = 1000059005,
	PhysicalDeviceMemoryProperties2 = 1000059006,
	SparseImageFormatProperties2 = 1000059007,
	PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
	PhysicalDevicePointClippingProperties = 1000117000,
	RenderPassInputAttachmentAspectCreateInfo = 1000117001,
	ImageViewUsageCreateInfo = 1000117002,
	PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
	RenderPassMultiviewCreateInfo = 1000053000,
	PhysicalDeviceMultiviewFeatures = 1000053001,
	PhysicalDeviceMultiviewProperties = 1000053002,
	PhysicalDeviceVariablePointersFeatures = 1000120000,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointersFeatures")]
	PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,
	ProtectedSubmitInfo = 1000145000,
	PhysicalDeviceProtectedMemoryFeatures = 1000145001,
	PhysicalDeviceProtectedMemoryProperties = 1000145002,
	DeviceQueueInfo2 = 1000145003,
	SamplerYCBCRConversionCreateInfo = 1000156000,
	SamplerYCBCRConversionInfo = 1000156001,
	BindImagePlaneMemoryInfo = 1000156002,
	ImagePlaneMemoryRequirementsInfo = 1000156003,
	PhysicalDeviceSamplerYCBCRConversionFeatures = 1000156004,
	SamplerYCBCRConversionImageFormatProperties = 1000156005,
	DescriptorUpdateTemplateCreateInfo = 1000085000,
	PhysicalDeviceExternalImageFormatInfo = 1000071000,
	ExternalImageFormatProperties = 1000071001,
	PhysicalDeviceExternalBufferInfo = 1000071002,
	ExternalBufferProperties = 1000071003,
	PhysicalDeviceIdProperties = 1000071004,
	ExternalMemoryBufferCreateInfo = 1000072000,
	ExternalMemoryImageCreateInfo = 1000072001,
	ExportMemoryAllocateInfo = 1000072002,
	PhysicalDeviceExternalFenceInfo = 1000112000,
	ExternalFenceProperties = 1000112001,
	ExportFenceCreateInfo = 1000113000,
	ExportSemaphoreCreateInfo = 1000077000,
	PhysicalDeviceExternalSemaphoreInfo = 1000076000,
	ExternalSemaphoreProperties = 1000076001,
	PhysicalDeviceMaintenance3Properties = 1000168000,
	DescriptorSetLayoutSupport = 1000168001,
	PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderDrawParametersFeatures")]
	PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,
	SwapchainCreateInfoKHR = 1000001000,
	PresentInfoKHR = 1000001001,
	DeviceGroupPresentCapabilitiesKHR = 1000001007,
	ImageSwapchainCreateInfoKHR = 1000001008,
	BindImageMemorySwapchainInfoKHR = 1000001009,
	AcquireNextImageInfoKHR = 1000001010,
	DeviceGroupPresentInfoKHR = 1000001011,
	DeviceGroupSwapchainCreateInfoKHR = 1000001012,
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
	PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,
	PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,
	PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,
	ImageViewHandleInfoNVX = 1000030000,
	TextureLodGatherFormatPropertiesAMD = 1000041000,
	PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
	[Obsolete("Use VkStructureType.RenderPassMultiviewCreateInfo")]
	RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceMultiviewFeatures")]
	PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceMultiviewProperties")]
	PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,
	ExternalMemoryImageCreateInfoNV = 1000056000,
	ExportMemoryAllocateInfoNV = 1000056001,
	ImportMemoryWin32HandleInfoNV = 1000057000,
	ExportMemoryWin32HandleInfoNV = 1000057001,
	Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
	[Obsolete("Use VkStructureType.PhysicalDeviceFeatures2")]
	PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,
	[Obsolete("Use VkStructureType.PhysicalDeviceProperties2")]
	PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,
	[Obsolete("Use VkStructureType.FormatProperties2")]
	FormatProperties2KHR = FormatProperties2,
	[Obsolete("Use VkStructureType.ImageFormatProperties2")]
	ImageFormatProperties2KHR = ImageFormatProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceImageFormatInfo2")]
	PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,
	[Obsolete("Use VkStructureType.QueueFamilyProperties2")]
	QueueFamilyProperties2KHR = QueueFamilyProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceMemoryProperties2")]
	PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,
	[Obsolete("Use VkStructureType.SparseImageFormatProperties2")]
	SparseImageFormatProperties2KHR = SparseImageFormatProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceSparseImageFormatInfo2")]
	PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,
	[Obsolete("Use VkStructureType.MemoryAllocateFlagsInfo")]
	MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,
	[Obsolete("Use VkStructureType.DeviceGroupRenderPassBeginInfo")]
	DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,
	[Obsolete("Use VkStructureType.DeviceGroupCommandBufferBeginInfo")]
	DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,
	[Obsolete("Use VkStructureType.DeviceGroupSubmitInfo")]
	DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,
	[Obsolete("Use VkStructureType.DeviceGroupBindSparseInfo")]
	DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,
	[Obsolete("Use VkStructureType.BindBufferMemoryDeviceGroupInfo")]
	BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,
	[Obsolete("Use VkStructureType.BindImageMemoryDeviceGroupInfo")]
	BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,
	ValidationFlagsEXT = 1000061000,
	PhysicalDeviceTextureCompressionASTCHDRFeaturesEXT = 1000066000,
	ImageViewASTCDecodeModeEXT = 1000067000,
	PhysicalDeviceASTCDecodeFeaturesEXT = 1000067001,
	[Obsolete("Use VkStructureType.PhysicalDeviceGroupProperties")]
	PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,
	[Obsolete("Use VkStructureType.DeviceGroupDeviceCreateInfo")]
	DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalImageFormatInfo")]
	PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,
	[Obsolete("Use VkStructureType.ExternalImageFormatProperties")]
	ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalBufferInfo")]
	PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,
	[Obsolete("Use VkStructureType.ExternalBufferProperties")]
	ExternalBufferPropertiesKHR = ExternalBufferProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceIdProperties")]
	PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,
	[Obsolete("Use VkStructureType.ExternalMemoryBufferCreateInfo")]
	ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,
	[Obsolete("Use VkStructureType.ExternalMemoryImageCreateInfo")]
	ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,
	[Obsolete("Use VkStructureType.ExportMemoryAllocateInfo")]
	ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,
	ImportMemoryWin32HandleInfoKHR = 1000073000,
	ExportMemoryWin32HandleInfoKHR = 1000073001,
	MemoryWin32HandlePropertiesKHR = 1000073002,
	MemoryGetWin32HandleInfoKHR = 1000073003,
	ImportMemoryFileDescriptorInfoKHR = 1000074000,
	MemoryFileDescriptorPropertiesKHR = 1000074001,
	MemoryGetFileDescriptorInfoKHR = 1000074002,
	Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalSemaphoreInfo")]
	PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,
	[Obsolete("Use VkStructureType.ExternalSemaphoreProperties")]
	ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,
	[Obsolete("Use VkStructureType.ExportSemaphoreCreateInfo")]
	ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,
	ImportSemaphoreWin32HandleInfoKHR = 1000078000,
	ExportSemaphoreWin32HandleInfoKHR = 1000078001,
	D3D12FenceSubmitInfoKHR = 1000078002,
	SemaphoreGetWin32HandleInfoKHR = 1000078003,
	ImportSemaphoreFileDescriptorInfoKHR = 1000079000,
	SemaphoreGetFileDescriptorInfoKHR = 1000079001,
	PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
	CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,
	PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,
	ConditionalRenderingBeginInfoEXT = 1000081002,
	PhysicalDeviceShaderFloat16Int8FeaturesKHR = 1000082000,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8FeaturesKHR")]
	PhysicalDeviceFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8FeaturesKHR,
	[Obsolete("Use VkStructureType.PhysicalDevice16bitStorageFeatures")]
	PhysicalDevice16bitStorageFeaturesKHR = PhysicalDevice16bitStorageFeatures,
	PresentRegionsKHR = 1000084000,
	[Obsolete("Use VkStructureType.DescriptorUpdateTemplateCreateInfo")]
	DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,
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
	PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,
	PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,
	HDRMetadataEXT = 1000105000,
	PhysicalDeviceImagelessFramebufferFeaturesKHR = 1000108000,
	FramebufferAttachmentsCreateInfoKHR = 1000108001,
	FramebufferAttachmentImageInfoKHR = 1000108002,
	RenderPassAttachmentBeginInfoKHR = 1000108003,
	AttachmentDescription2KHR = 1000109000,
	AttachmentReference2KHR = 1000109001,
	SubpassDescription2KHR = 1000109002,
	SubpassDependency2KHR = 1000109003,
	RenderPassCreateInfo2KHR = 1000109004,
	SubpassBeginInfoKHR = 1000109005,
	SubpassEndInfoKHR = 1000109006,
	SharedPresentSurfaceCapabilitiesKHR = 1000111000,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalFenceInfo")]
	PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,
	[Obsolete("Use VkStructureType.ExternalFenceProperties")]
	ExternalFencePropertiesKHR = ExternalFenceProperties,
	[Obsolete("Use VkStructureType.ExportFenceCreateInfo")]
	ExportFenceCreateInfoKHR = ExportFenceCreateInfo,
	ImportFenceWin32HandleInfoKHR = 1000114000,
	ExportFenceWin32HandleInfoKHR = 1000114001,
	FenceGetWin32HandleInfoKHR = 1000114002,
	ImportFenceFileDescriptorInfoKHR = 1000115000,
	FenceGetFileDescriptorInfoKHR = 1000115001,
	PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,
	PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,
	QueryPoolPerformanceCreateInfoKHR = 1000116002,
	PerformanceQuerySubmitInfoKHR = 1000116003,
	AcquireProfilingLockInfoKHR = 1000116004,
	PerformanceCounterKHR = 1000116005,
	PerformanceCounterDescriptionKHR = 1000116006,
	[Obsolete("Use VkStructureType.PhysicalDevicePointClippingProperties")]
	PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,
	[Obsolete("Use VkStructureType.RenderPassInputAttachmentAspectCreateInfo")]
	RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,
	[Obsolete("Use VkStructureType.ImageViewUsageCreateInfo")]
	ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,
	[Obsolete("Use VkStructureType.PipelineTessellationDomainOriginStateCreateInfo")]
	PipelineTessellationDomainOriginStateCreateInfoKHR = PipelineTessellationDomainOriginStateCreateInfo,
	PhysicalDeviceSurfaceInfo2KHR = 1000119000,
	SurfaceCapabilities2KHR = 1000119001,
	SurfaceFormat2KHR = 1000119002,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointerFeatures")]
	PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointerFeatures")]
	PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
	DisplayProperties2KHR = 1000121000,
	DisplayPlaneProperties2KHR = 1000121001,
	DisplayModeProperties2KHR = 1000121002,
	DisplayPlaneInfo2KHR = 1000121003,
	DisplayPlaneCapabilities2KHR = 1000121004,
	MacosSurfaceCreateInfoMVK = 1000123000,
	[Obsolete("Use VkStructureType.MemoryDedicatedRequirements")]
	MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,
	[Obsolete("Use VkStructureType.MemoryDedicatedAllocateInfo")]
	MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,
	DebugUtilsObjectNameInfoEXT = 1000128000,
	DebugUtilsObjectTagInfoEXT = 1000128001,
	DebugUtilsLabelEXT = 1000128002,
	DebugUtilsMessengerCallbackDataEXT = 1000128003,
	DebugUtilsMessengerCreateInfoEXT = 1000128004,
	AndroidHardwareBufferUsageANDROID = 1000129000,
	AndroidHardwareBufferPropertiesANDROID = 1000129001,
	AndroidHardwareBufferFormatPropertiesANDROID = 1000129002,
	ImportAndroidHardwareBufferInfoANDROID = 1000129003,
	MemoryGetAndroidHardwareBufferInfoANDROID = 1000129004,
	ExternalFormatANDROID = 1000129005,
	PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = 1000130000,
	SamplerReductionModeCreateInfoEXT = 1000130001,
	PhysicalDeviceInlineUniformBlockFeaturesEXT = 1000138000,
	PhysicalDeviceInlineUniformBlockPropertiesEXT = 1000138001,
	WriteDescriptorSetInlineUniformBlockEXT = 1000138002,
	DescriptorPoolInlineUniformBlockCreateInfoEXT = 1000138003,
	SampleLocationsInfoEXT = 1000143000,
	RenderPassSampleLocationsBeginInfoEXT = 1000143001,
	PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
	PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
	MultisamplePropertiesEXT = 1000143004,
	[Obsolete("Use VkStructureType.BufferMemoryRequirementsInfo2")]
	BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.ImageMemoryRequirementsInfo2")]
	ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.ImageSparseMemoryRequirementsInfo2")]
	ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.MemoryRequirements2")]
	MemoryRequirements2KHR = MemoryRequirements2,
	[Obsolete("Use VkStructureType.SparseImageMemoryRequirements2")]
	SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,
	ImageFormatListCreateInfoKHR = 1000147000,
	PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
	PipelineCoverageToColorStateCreateInfoNV = 1000149000,
	PipelineCoverageModulationStateCreateInfoNV = 1000152000,
	PhysicalDeviceShaderSMBuiltinsFeaturesNV = 1000154000,
	PhysicalDeviceShaderSMBuiltinsPropertiesNV = 1000154001,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionCreateInfo")]
	SamplerYCBCRConversionCreateInfoKHR = SamplerYCBCRConversionCreateInfo,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionInfo")]
	SamplerYCBCRConversionInfoKHR = SamplerYCBCRConversionInfo,
	[Obsolete("Use VkStructureType.BindImagePlaneMemoryInfo")]
	BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,
	[Obsolete("Use VkStructureType.ImagePlaneMemoryRequirementsInfo")]
	ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSamplerYCBCRConversionFeatures")]
	PhysicalDeviceSamplerYCBCRConversionFeaturesKHR = PhysicalDeviceSamplerYCBCRConversionFeatures,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionImageFormatProperties")]
	SamplerYCBCRConversionImageFormatPropertiesKHR = SamplerYCBCRConversionImageFormatProperties,
	[Obsolete("Use VkStructureType.BindBufferMemoryInfo")]
	BindBufferMemoryInfoKHR = BindBufferMemoryInfo,
	[Obsolete("Use VkStructureType.BindImageMemoryInfo")]
	BindImageMemoryInfoKHR = BindImageMemoryInfo,
	DRMFormatModifierPropertiesListEXT = 1000158000,
	DRMFormatModifierPropertiesEXT = 1000158001,
	PhysicalDeviceImageDRMFormatModifierInfoEXT = 1000158002,
	ImageDRMFormatModifierListCreateInfoEXT = 1000158003,
	ImageDRMFormatModifierExplicitCreateInfoEXT = 1000158004,
	ImageDRMFormatModifierPropertiesEXT = 1000158005,
	ValidationCacheCreateInfoEXT = 1000160000,
	ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
	DescriptorSetLayoutBindingFlagsCreateInfoEXT = 1000161000,
	PhysicalDeviceDescriptorIndexingFeaturesEXT = 1000161001,
	PhysicalDeviceDescriptorIndexingPropertiesEXT = 1000161002,
	DescriptorSetVariableDescriptorCountAllocateInfoEXT = 1000161003,
	DescriptorSetVariableDescriptorCountLayoutSupportEXT = 1000161004,
	PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
	PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
	PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
	PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
	RayTracingPipelineCreateInfoNV = 1000165000,
	AccelerationStructureCreateInfoNV = 1000165001,
	GeometryNV = 1000165003,
	GeometryTrianglesNV = 1000165004,
	GeometryAABBNV = 1000165005,
	BindAccelerationStructureMemoryInfoNV = 1000165006,
	WriteDescriptorSetAccelerationStructureNV = 1000165007,
	AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
	PhysicalDeviceRayTracingPropertiesNV = 1000165009,
	RayTracingShaderGroupCreateInfoNV = 1000165011,
	AccelerationStructureInfoNV = 1000165012,
	PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
	PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance3Properties")]
	PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,
	[Obsolete("Use VkStructureType.DescriptorSetLayoutSupport")]
	DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,
	PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,
	FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,
	DeviceQueueGlobalPriorityCreateInfoEXT = 1000174000,
	PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR = 1000175000,
	PhysicalDevice8bitStorageFeaturesKHR = 1000177000,
	ImportMemoryHostPointerInfoEXT = 1000178000,
	MemoryHostPointerPropertiesEXT = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
	PhysicalDeviceShaderAtomicInt64FeaturesKHR = 1000180000,
	PhysicalDeviceShaderClockFeaturesKHR = 1000181000,
	PipelineCompilerControlCreateInfoAMD = 1000183000,
	CalibratedTimestampInfoEXT = 1000184000,
	PhysicalDeviceShaderCorePropertiesAMD = 1000185000,
	DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
	PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
	PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
	PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
	PipelineCreationFeedbackCreateInfoEXT = 1000192000,
	PhysicalDeviceDriverPropertiesKHR = 1000196000,
	PhysicalDeviceFloatControlsPropertiesKHR = 1000197000,
	PhysicalDeviceDepthStencilResolvePropertiesKHR = 1000199000,
	SubpassDescriptionDepthStencilResolveKHR = 1000199001,
	PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
	PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
	PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
	PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
	PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
	PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
	PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
	CheckpointDataNV = 1000206000,
	QueueFamilyCheckpointPropertiesNV = 1000206001,
	PhysicalDeviceTimelineSemaphoreFeaturesKHR = 1000207000,
	PhysicalDeviceTimelineSemaphorePropertiesKHR = 1000207001,
	SemaphoreTypeCreateInfoKHR = 1000207002,
	TimelineSemaphoreSubmitInfoKHR = 1000207003,
	SemaphoreWaitInfoKHR = 1000207004,
	SemaphoreSignalInfoKHR = 1000207005,
	PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,
	QueryPoolCreateInfoINTEL = 1000210000,
	InitializePerformanceAPIInfoINTEL = 1000210001,
	PerformanceMarkerInfoINTEL = 1000210002,
	PerformanceStreamMarkerInfoINTEL = 1000210003,
	PerformanceOverrideInfoINTEL = 1000210004,
	PerformanceConfigurationAcquireInfoINTEL = 1000210005,
	PhysicalDeviceVulkanMemoryModelFeaturesKHR = 1000211000,
	PhysicalDevicePCIBusInfoPropertiesEXT = 1000212000,
	DisplayNativeHDRSurfaceCapabilitiesAMD = 1000213000,
	SwapchainDisplayNativeHDRCreateInfoAMD = 1000213001,
	PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
	PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
	RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
	PhysicalDeviceScalarBlockLayoutFeaturesEXT = 1000221000,
	PhysicalDeviceSubgroupSizeControlPropertiesEXT = 1000225000,
	PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = 1000225001,
	PhysicalDeviceSubgroupSizeControlFeaturesEXT = 1000225002,
	PhysicalDeviceShaderCoreProperties2AMD = 1000227000,
	PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,
	PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
	PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
	MemoryPriorityAllocateInfoEXT = 1000238001,
	SurfaceProtectedCapabilitiesKHR = 1000239000,
	PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
	PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR = 1000241000,
	AttachmentReferenceStencilLayoutKHR = 1000241001,
	AttachmentDescriptionStencilLayoutKHR = 1000241002,
	PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT")]
	PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfoKHR")]
	BufferDeviceAddressInfoEXT = BufferDeviceAddressInfoKHR,
	BufferDeviceAddressCreateInfoEXT = 1000244002,
	PhysicalDeviceToolPropertiesEXT = 1000245000,
	ImageStencilUsageCreateInfoEXT = 1000246000,
	ValidationFeaturesEXT = 1000247000,
	PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
	CooperativeMatrixPropertiesNV = 1000249001,
	PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
	PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
	PipelineCoverageReductionStateCreateInfoNV = 1000250001,
	FramebufferMixedSamplesCombinationNV = 1000250002,
	PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,
	PhysicalDeviceYCBCRImageArraysFeaturesEXT = 1000252000,
	PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR = 1000253000,
	SurfaceFullScreenExclusiveInfoEXT = 1000255000,
	SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
	SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
	HeadlessSurfaceCreateInfoEXT = 1000256000,
	PhysicalDeviceBufferDeviceAddressFeaturesKHR = 1000257000,
	BufferDeviceAddressInfoKHR = 1000257001,
	BufferOpaqueCaptureAddressCreateInfoKHR = 1000257002,
	MemoryOpaqueCaptureAddressAllocateInfoKHR = 1000257003,
	DeviceMemoryOpaqueCaptureAddressInfoKHR = 1000257004,
	PhysicalDeviceLineRasterizationFeaturesEXT = 1000259000,
	PipelineRasterizationLineStateCreateInfoEXT = 1000259001,
	PhysicalDeviceLineRasterizationPropertiesEXT = 1000259002,
	PhysicalDeviceHostQueryResetFeaturesEXT = 1000261000,
	PhysicalDeviceIndexTypeUInt8FeaturesEXT = 1000265000,
	PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,
	PipelineInfoKHR = 1000269001,
	PipelineExecutablePropertiesKHR = 1000269002,
	PipelineExecutableInfoKHR = 1000269003,
	PipelineExecutableStatisticKHR = 1000269004,
	PipelineExecutableInternalRepresentationKHR = 1000269005,
	PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = 1000276000,
	PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
	PhysicalDeviceTexelBufferAlignmentPropertiesEXT = 1000281001,
}
[Flags]
public enum VkInstanceCreateFlags
{
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
	G8B8G8R8422UNorm = 1000156000,
	B8G8R8G8422UNorm = 1000156001,
	G8B8R83Plane420UNorm = 1000156002,
	G8B8R82Plane420UNorm = 1000156003,
	G8B8R83Plane422UNorm = 1000156004,
	G8B8R82Plane422UNorm = 1000156005,
	G8B8R83Plane444UNorm = 1000156006,
	R10X6UNormPack16 = 1000156007,
	R10X6G10X6UNorm2Pack16 = 1000156008,
	R10X6G10X6B10X6A10X6UNorm4Pack16 = 1000156009,
	G10X6B10X6G10X6R10X6422UNorm4Pack16 = 1000156010,
	B10X6G10X6R10X6G10X6422UNorm4Pack16 = 1000156011,
	G10X6B10X6R10X63Plane420UNorm3Pack16 = 1000156012,
	G10X6B10X6R10X62Plane420UNorm3Pack16 = 1000156013,
	G10X6B10X6R10X63Plane422UNorm3Pack16 = 1000156014,
	G10X6B10X6R10X62Plane422UNorm3Pack16 = 1000156015,
	G10X6B10X6R10X63Plane444UNorm3Pack16 = 1000156016,
	R12X4UNormPack16 = 1000156017,
	R12X4G12X4UNorm2Pack16 = 1000156018,
	R12X4G12X4B12X4A12X4UNorm4Pack16 = 1000156019,
	G12X4B12X4G12X4R12X4422UNorm4Pack16 = 1000156020,
	B12X4G12X4R12X4G12X4422UNorm4Pack16 = 1000156021,
	G12X4B12X4R12X43Plane420UNorm3Pack16 = 1000156022,
	G12X4B12X4R12X42Plane420UNorm3Pack16 = 1000156023,
	G12X4B12X4R12X43Plane422UNorm3Pack16 = 1000156024,
	G12X4B12X4R12X42Plane422UNorm3Pack16 = 1000156025,
	G12X4B12X4R12X43Plane444UNorm3Pack16 = 1000156026,
	G16B16G16R16422UNorm = 1000156027,
	B16G16R16G16422UNorm = 1000156028,
	G16B16R163Plane420UNorm = 1000156029,
	G16B16R162Plane420UNorm = 1000156030,
	G16B16R163Plane422UNorm = 1000156031,
	G16B16R162Plane422UNorm = 1000156032,
	G16B16R163Plane444UNorm = 1000156033,
	PVRTC12BPPUNormBlockIMG = 1000054000,
	PVRTC14BPPUNormBlockIMG = 1000054001,
	PVRTC22BPPUNormBlockIMG = 1000054002,
	PVRTC24BPPUNormBlockIMG = 1000054003,
	PVRTC12BPPSRGBBlockIMG = 1000054004,
	PVRTC14BPPSRGBBlockIMG = 1000054005,
	PVRTC22BPPSRGBBlockIMG = 1000054006,
	PVRTC24BPPSRGBBlockIMG = 1000054007,
	ASTC4x4SFloatBlockEXT = 1000066000,
	ASTC5x4SFloatBlockEXT = 1000066001,
	ASTC5x5SFloatBlockEXT = 1000066002,
	ASTC6x5SFloatBlockEXT = 1000066003,
	ASTC6x6SFloatBlockEXT = 1000066004,
	ASTC8x5SFloatBlockEXT = 1000066005,
	ASTC8x6SFloatBlockEXT = 1000066006,
	ASTC8x8SFloatBlockEXT = 1000066007,
	ASTC10x5SFloatBlockEXT = 1000066008,
	ASTC10x6SFloatBlockEXT = 1000066009,
	ASTC10x8SFloatBlockEXT = 1000066010,
	ASTC10x10SFloatBlockEXT = 1000066011,
	ASTC12x10SFloatBlockEXT = 1000066012,
	ASTC12x12SFloatBlockEXT = 1000066013,
	[Obsolete("Use VkFormat.G8B8G8R8422UNorm")]
	G8B8G8R8422UNormKHR = G8B8G8R8422UNorm,
	[Obsolete("Use VkFormat.B8G8R8G8422UNorm")]
	B8G8R8G8422UNormKHR = B8G8R8G8422UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane420UNorm")]
	G8B8R83Plane420UNormKHR = G8B8R83Plane420UNorm,
	[Obsolete("Use VkFormat.G8B8R82Plane420UNorm")]
	G8B8R82Plane420UNormKHR = G8B8R82Plane420UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane422UNorm")]
	G8B8R83Plane422UNormKHR = G8B8R83Plane422UNorm,
	[Obsolete("Use VkFormat.G8B8R82Plane422UNorm")]
	G8B8R82Plane422UNormKHR = G8B8R82Plane422UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane444UNorm")]
	G8B8R83Plane444UNormKHR = G8B8R83Plane444UNorm,
	[Obsolete("Use VkFormat.R10X6UNormPack16")]
	R10X6UNormPack16KHR = R10X6UNormPack16,
	[Obsolete("Use VkFormat.R10X6G10X6UNorm2Pack16")]
	R10X6G10X6UNorm2Pack16KHR = R10X6G10X6UNorm2Pack16,
	[Obsolete("Use VkFormat.R10X6G10X6B10X6A10X6UNorm4Pack16")]
	R10X6G10X6B10X6A10X6UNorm4Pack16KHR = R10X6G10X6B10X6A10X6UNorm4Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6G10X6R10X6422UNorm4Pack16")]
	G10X6B10X6G10X6R10X6422UNorm4Pack16KHR = G10X6B10X6G10X6R10X6422UNorm4Pack16,
	[Obsolete("Use VkFormat.B10X6G10X6R10X6G10X6422UNorm4Pack16")]
	B10X6G10X6R10X6G10X6422UNorm4Pack16KHR = B10X6G10X6R10X6G10X6422UNorm4Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane420UNorm3Pack16")]
	G10X6B10X6R10X63Plane420UNorm3Pack16KHR = G10X6B10X6R10X63Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X62Plane420UNorm3Pack16")]
	G10X6B10X6R10X62Plane420UNorm3Pack16KHR = G10X6B10X6R10X62Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane422UNorm3Pack16")]
	G10X6B10X6R10X63Plane422UNorm3Pack16KHR = G10X6B10X6R10X63Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X62Plane422UNorm3Pack16")]
	G10X6B10X6R10X62Plane422UNorm3Pack16KHR = G10X6B10X6R10X62Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane444UNorm3Pack16")]
	G10X6B10X6R10X63Plane444UNorm3Pack16KHR = G10X6B10X6R10X63Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.R12X4UNormPack16")]
	R12X4UNormPack16KHR = R12X4UNormPack16,
	[Obsolete("Use VkFormat.R12X4G12X4UNorm2Pack16")]
	R12X4G12X4UNorm2Pack16KHR = R12X4G12X4UNorm2Pack16,
	[Obsolete("Use VkFormat.R12X4G12X4B12X4A12X4UNorm4Pack16")]
	R12X4G12X4B12X4A12X4UNorm4Pack16KHR = R12X4G12X4B12X4A12X4UNorm4Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4G12X4R12X4422UNorm4Pack16")]
	G12X4B12X4G12X4R12X4422UNorm4Pack16KHR = G12X4B12X4G12X4R12X4422UNorm4Pack16,
	[Obsolete("Use VkFormat.B12X4G12X4R12X4G12X4422UNorm4Pack16")]
	B12X4G12X4R12X4G12X4422UNorm4Pack16KHR = B12X4G12X4R12X4G12X4422UNorm4Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane420UNorm3Pack16")]
	G12X4B12X4R12X43Plane420UNorm3Pack16KHR = G12X4B12X4R12X43Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X42Plane420UNorm3Pack16")]
	G12X4B12X4R12X42Plane420UNorm3Pack16KHR = G12X4B12X4R12X42Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane422UNorm3Pack16")]
	G12X4B12X4R12X43Plane422UNorm3Pack16KHR = G12X4B12X4R12X43Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X42Plane422UNorm3Pack16")]
	G12X4B12X4R12X42Plane422UNorm3Pack16KHR = G12X4B12X4R12X42Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane444UNorm3Pack16")]
	G12X4B12X4R12X43Plane444UNorm3Pack16KHR = G12X4B12X4R12X43Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.G16B16G16R16422UNorm")]
	G16B16G16R16422UNormKHR = G16B16G16R16422UNorm,
	[Obsolete("Use VkFormat.B16G16R16G16422UNorm")]
	B16G16R16G16422UNormKHR = B16G16R16G16422UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane420UNorm")]
	G16B16R163Plane420UNormKHR = G16B16R163Plane420UNorm,
	[Obsolete("Use VkFormat.G16B16R162Plane420UNorm")]
	G16B16R162Plane420UNormKHR = G16B16R162Plane420UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane422UNorm")]
	G16B16R163Plane422UNormKHR = G16B16R163Plane422UNorm,
	[Obsolete("Use VkFormat.G16B16R162Plane422UNorm")]
	G16B16R162Plane422UNormKHR = G16B16R162Plane422UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane444UNorm")]
	G16B16R163Plane444UNormKHR = G16B16R163Plane444UNorm,
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
	TransferSource = 1 << 14,
	TransferDestination = 1 << 15,
	MidpointChromaSamples = 1 << 17,
	SampledImageYCBCRConversionLinearFilter = 1 << 18,
	SampledImageYCBCRConversionSeparateReconstructionFilter = 1 << 19,
	SampledImageYCBCRConversionChromaReconstructionExplicit = 1 << 20,
	SampledImageYCBCRConversionChromaReconstructionExplicitForceable = 1 << 21,
	Disjoint = 1 << 22,
	CositedChromaSamples = 1 << 23,
	SampledImageFilterCubicIMG = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags.TransferSource")]
	TransferSourceKHR = TransferSource,
	[Obsolete("Use VkFormatFeatureFlags.TransferDestination")]
	TransferDestinationKHR = TransferDestination,
	SampledImageFilterMinmaxEXT = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags.MidpointChromaSamples")]
	MidpointChromaSamplesKHR = MidpointChromaSamples,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionLinearFilter")]
	SampledImageYCBCRConversionLinearFilterKHR = SampledImageYCBCRConversionLinearFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionSeparateReconstructionFilter")]
	SampledImageYCBCRConversionSeparateReconstructionFilterKHR = SampledImageYCBCRConversionSeparateReconstructionFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionChromaReconstructionExplicit")]
	SampledImageYCBCRConversionChromaReconstructionExplicitKHR = SampledImageYCBCRConversionChromaReconstructionExplicit,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionChromaReconstructionExplicitForceable")]
	SampledImageYCBCRConversionChromaReconstructionExplicitForceableKHR = SampledImageYCBCRConversionChromaReconstructionExplicitForceable,
	[Obsolete("Use VkFormatFeatureFlags.Disjoint")]
	DisjointKHR = Disjoint,
	[Obsolete("Use VkFormatFeatureFlags.CositedChromaSamples")]
	CositedChromaSamplesKHR = CositedChromaSamples,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterCubicIMG")]
	SampledImageFilterCubicEXT = SampledImageFilterCubicIMG,
	FragmentDensityMapEXT = 1 << 24,
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
	DRMFormatModifierEXT = 1000158000,
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
	ShadingRateImageNV = 1 << 8,
	FragmentDensityMapEXT = 1 << 9,
}
[Flags]
public enum VkImageCreateFlags
{
	SparseBinding = 1 << 0,
	SparseResidency = 1 << 1,
	SparseAliased = 1 << 2,
	MutableFormat = 1 << 3,
	CubeCompatible = 1 << 4,
	Alias = 1 << 10,
	SplitInstanceBindRegions = 1 << 6,
	_2DArrayCompatible = 1 << 5,
	BlockTexelViewCompatible = 1 << 7,
	ExtendedUsage = 1 << 8,
	Protected = 1 << 11,
	Disjoint = 1 << 9,
	CornerSampledNV = 1 << 13,
	[Obsolete("Use VkImageCreateFlags.SplitInstanceBindRegions")]
	SplitInstanceBindRegionsKHR = SplitInstanceBindRegions,
	[Obsolete("Use VkImageCreateFlags._2DArrayCompatible")]
	_2DArrayCompatibleKHR = _2DArrayCompatible,
	[Obsolete("Use VkImageCreateFlags.BlockTexelViewCompatible")]
	BlockTexelViewCompatibleKHR = BlockTexelViewCompatible,
	[Obsolete("Use VkImageCreateFlags.ExtendedUsage")]
	ExtendedUsageKHR = ExtendedUsage,
	SampleLocationsCompatibleDepthEXT = 1 << 12,
	[Obsolete("Use VkImageCreateFlags.Disjoint")]
	DisjointKHR = Disjoint,
	[Obsolete("Use VkImageCreateFlags.Alias")]
	AliasKHR = Alias,
	SubsampledEXT = 1 << 14,
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
	Protected = 1 << 4,
}
[Flags]
public enum VkMemoryPropertyFlags
{
	DeviceLocal = 1 << 0,
	HostVisible = 1 << 1,
	HostCoherent = 1 << 2,
	HostCached = 1 << 3,
	LazilyAllocated = 1 << 4,
	Protected = 1 << 5,
	DeviceCoherentAMD = 1 << 6,
	DeviceUncachedAMD = 1 << 7,
}
[Flags]
public enum VkMemoryHeapFlags
{
	DeviceLocal = 1 << 0,
	MultiInstance = 1 << 1,
	[Obsolete("Use VkMemoryHeapFlags.MultiInstance")]
	MultiInstanceKHR = MultiInstance,
}
[Flags]
public enum VkDeviceCreateFlags
{
}
[Flags]
public enum VkDeviceQueueCreateFlags
{
	Protected = 1 << 0,
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
	TransformFeedbackEXT = 1 << 24,
	ConditionalRenderingEXT = 1 << 18,
	CommandProcessNVX = 1 << 17,
	ShadingRateImageNV = 1 << 22,
	RayTracingShaderNV = 1 << 21,
	AccelerationStructureBuildNV = 1 << 25,
	TaskShaderNV = 1 << 19,
	MeshShaderNV = 1 << 20,
	FragmentDensityProcessEXT = 1 << 23,
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
	Plane0 = 1 << 4,
	Plane1 = 1 << 5,
	Plane2 = 1 << 6,
	[Obsolete("Use VkImageAspectFlags.Plane0")]
	Plane0KHR = Plane0,
	[Obsolete("Use VkImageAspectFlags.Plane1")]
	Plane1KHR = Plane1,
	[Obsolete("Use VkImageAspectFlags.Plane2")]
	Plane2KHR = Plane2,
	MemoryPlane0EXT = 1 << 7,
	MemoryPlane1EXT = 1 << 8,
	MemoryPlane2EXT = 1 << 9,
	MemoryPlane3EXT = 1 << 10,
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
	TransformFeedbackStreamEXT = 1000028004,
	PerformanceQueryKHR = 1000116000,
	AccelerationStructureCompactedSizeNV = 1000165000,
	PerformanceQueryINTEL = 1000210000,
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
	Protected = 1 << 3,
	[Obsolete("Use VkBufferCreateFlags.DeviceAddressCaptureReplayKHR")]
	DeviceAddressCaptureReplayEXT = DeviceAddressCaptureReplayKHR,
	DeviceAddressCaptureReplayKHR = 1 << 4,
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
	TransformFeedbackBufferEXT = 1 << 11,
	TransformFeedbackCounterBufferEXT = 1 << 12,
	ConditionalRenderingEXT = 1 << 9,
	RayTracingNV = 1 << 10,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddressKHR")]
	ShaderDeviceAddressEXT = ShaderDeviceAddressKHR,
	ShaderDeviceAddressKHR = 1 << 17,
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
	DepthReadOnlyStencilAttachmentOptimal = 1000117000,
	DepthAttachmentStencilReadOnlyOptimal = 1000117001,
	PresentSourceKHR = 1000001002,
	SharedPresentKHR = 1000111000,
	[Obsolete("Use VkImageLayout.DepthReadOnlyStencilAttachmentOptimal")]
	DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthAttachmentStencilReadOnlyOptimal")]
	DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,
	ShadingRateOptimalNV = 1000164003,
	FragmentDensityMapOptimalEXT = 1000218000,
	DepthAttachmentOptimalKHR = 1000241000,
	DepthReadOnlyOptimalKHR = 1000241001,
	StencilAttachmentOptimalKHR = 1000241002,
	StencilReadOnlyOptimalKHR = 1000241003,
}
[Flags]
public enum VkImageViewCreateFlags
{
	FragmentDensityMapDynamicEXT = 1 << 0,
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
	ViewIndexFromDeviceIndex = 1 << 3,
	DispatchBase = 1 << 4,
	[Obsolete("Use VkPipelineCreateFlags.ViewIndexFromDeviceIndex")]
	ViewIndexFromDeviceIndexKHR = ViewIndexFromDeviceIndex,
	[Obsolete("Use VkPipelineCreateFlags.DispatchBase")]
	DispatchBaseKHR = DispatchBase,
	DeferCompileNV = 1 << 5,
	CaptureStatisticsKHR = 1 << 6,
	CaptureInternalRepresentationsKHR = 1 << 7,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags
{
	AllowVaryingSubgroupSizeEXT = 1 << 0,
	RequireFullSubgroupsEXT = 1 << 1,
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
	RaygenNV = 1 << 8,
	AnyHitNV = 1 << 9,
	ClosestHitNV = 1 << 10,
	MissNV = 1 << 11,
	IntersectionNV = 1 << 12,
	CallableNV = 1 << 13,
	TaskNV = 1 << 6,
	MeshNV = 1 << 7,
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
	ViewportShadingRatePaletteNV = 1000164004,
	ViewportCoarseSampleOrderNV = 1000164006,
	ExclusiveScissorNV = 1000205001,
	LineStippleEXT = 1000259000,
}
[Flags]
public enum VkPipelineLayoutCreateFlags
{
}
[Flags]
public enum VkSamplerCreateFlags
{
	SubsampledEXT = 1 << 0,
	SubsampledCoarseReconstructionEXT = 1 << 1,
}
public enum VkFilter
{
	Nearest = 0,
	Linear = 1,
	CubicIMG = 1000015000,
	[Obsolete("Use VkFilter.CubicIMG")]
	CubicEXT = CubicIMG,
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
	[Obsolete("Use VkSamplerAddressMode.MirrorClampToEdge")]
	MirrorClampToEdgeKHR = MirrorClampToEdge,
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
	UpdateAfterBindPoolEXT = 1 << 1,
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
	InlineUniformBlockEXT = 1000138000,
	AccelerationStructureNV = 1000165000,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
	UpdateAfterBindEXT = 1 << 1,
}
[Flags]
public enum VkDescriptorPoolResetFlags
{
}
[Flags]
public enum VkFramebufferCreateFlags
{
	ImagelessKHR = 1 << 0,
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
	RayTracingNV = 1000165000,
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
	TransformFeedbackWriteEXT = 1 << 25,
	TransformFeedbackCounterReadEXT = 1 << 26,
	TransformFeedbackCounterWriteEXT = 1 << 27,
	ConditionalRenderingReadEXT = 1 << 20,
	CommandProcessReadNVX = 1 << 17,
	CommandProcessWriteNVX = 1 << 18,
	ColorAttachmentReadNoncoherentEXT = 1 << 19,
	ShadingRateImageReadNV = 1 << 23,
	AccelerationStructureReadNV = 1 << 21,
	AccelerationStructureWriteNV = 1 << 22,
	FragmentDensityMapReadEXT = 1 << 24,
}
[Flags]
public enum VkDependencyFlags
{
	ByRegion = 1 << 0,
	DeviceGroup = 1 << 2,
	ViewLocal = 1 << 1,
	[Obsolete("Use VkDependencyFlags.ViewLocal")]
	ViewLocalKHR = ViewLocal,
	[Obsolete("Use VkDependencyFlags.DeviceGroup")]
	DeviceGroupKHR = DeviceGroup,
}
[Flags]
public enum VkCommandPoolCreateFlags
{
	Transient = 1 << 0,
	ResetCommandBuffer = 1 << 1,
	Protected = 1 << 2,
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
	NoneNV = 1000165000,
	UInt8EXT = 1000265000,
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
	SamplerYCBCRConversion = 1000156000,
	DescriptorUpdateTemplate = 1000085000,
	SurfaceKHR = 1000000000,
	SwapchainKHR = 1000001000,
	DisplayKHR = 1000002000,
	DisplayModeKHR = 1000002001,
	DebugReportCallbackEXT = 1000011000,
	[Obsolete("Use VkObjectType.DescriptorUpdateTemplate")]
	DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,
	ObjectTableNVX = 1000086000,
	IndirectCommandsLayoutNVX = 1000086001,
	DebugUtilsMessengerEXT = 1000128000,
	[Obsolete("Use VkObjectType.SamplerYCBCRConversion")]
	SamplerYCBCRConversionKHR = SamplerYCBCRConversion,
	ValidationCacheEXT = 1000160000,
	AccelerationStructureNV = 1000165000,
	PerformanceConfigurationINTEL = 1000210000,
}
public enum VkVendorId
{
	VIV = 0x10001,
	VSI = 0x10002,
	Kazan = 0x10003,
}
[Flags]
public enum VkSubgroupFeatureFlags
{
	Basic = 1 << 0,
	Vote = 1 << 1,
	Arithmetic = 1 << 2,
	Ballot = 1 << 3,
	Shuffle = 1 << 4,
	ShuffleRelative = 1 << 5,
	Clustered = 1 << 6,
	Quad = 1 << 7,
	PartitionedNV = 1 << 8,
}
[Flags]
public enum VkPeerMemoryFeatureFlags
{
	CopySource = 1 << 0,
	CopyDestination = 1 << 1,
	GenericSource = 1 << 2,
	GenericDestination = 1 << 3,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopySource")]
	CopySourceKHR = CopySource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopyDestination")]
	CopyDestinationKHR = CopyDestination,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericSource")]
	GenericSourceKHR = GenericSource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericDestination")]
	GenericDestinationKHR = GenericDestination,
}
[Flags]
public enum VkMemoryAllocateFlags
{
	DeviceMask = 1 << 0,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKHR = DeviceMask,
	DeviceAddressKHR = 1 << 1,
	DeviceAddressCaptureReplayKHR = 1 << 2,
}
[Flags]
public enum VkCommandPoolTrimFlags
{
}
public enum VkPointClippingBehavior
{
	AllClipPlanes = 0,
	UserClipPlanesOnly = 1,
	[Obsolete("Use VkPointClippingBehavior.AllClipPlanes")]
	AllClipPlanesKHR = AllClipPlanes,
	[Obsolete("Use VkPointClippingBehavior.UserClipPlanesOnly")]
	UserClipPlanesOnlyKHR = UserClipPlanesOnly,
}
public enum VkTessellationDomainOrigin
{
	UpperLeft = 0,
	LowerLeft = 1,
	[Obsolete("Use VkTessellationDomainOrigin.UpperLeft")]
	UpperLeftKHR = UpperLeft,
	[Obsolete("Use VkTessellationDomainOrigin.LowerLeft")]
	LowerLeftKHR = LowerLeft,
}
public enum VkSamplerYcbcrModelConversion
{
	RGBIdentity = 0,
	YCBCRIdentity = 1,
	YCBCR709 = 2,
	YCBCR601 = 3,
	YCBCR2020 = 4,
	[Obsolete("Use VkSamplerYcbcrModelConversion.RGBIdentity")]
	RGBIdentityKHR = RGBIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCRIdentity")]
	YCBCRIdentityKHR = YCBCRIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR709")]
	YCBCR709KHR = YCBCR709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR601")]
	YCBCR601KHR = YCBCR601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR2020")]
	YCBCR2020KHR = YCBCR2020,
}
public enum VkSamplerYcbcrRange
{
	ITUFull = 0,
	ITUNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ITUFull")]
	ITUFullKHR = ITUFull,
	[Obsolete("Use VkSamplerYcbcrRange.ITUNarrow")]
	ITUNarrowKHR = ITUNarrow,
}
public enum VkChromaLocation
{
	CositedEven = 0,
	Midpoint = 1,
	[Obsolete("Use VkChromaLocation.CositedEven")]
	CositedEvenKHR = CositedEven,
	[Obsolete("Use VkChromaLocation.Midpoint")]
	MidpointKHR = Midpoint,
}
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlags
{
}
public enum VkDescriptorUpdateTemplateType
{
	DescriptorSet = 0,
	PushDescriptorsKHR = 1,
	[Obsolete("Use VkDescriptorUpdateTemplateType.DescriptorSet")]
	DescriptorSetKHR = DescriptorSet,
}
[Flags]
public enum VkExternalMemoryHandleTypeFlags
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	D3D11Texture = 1 << 3,
	D3D11TextureKmt = 1 << 4,
	D3D12Heap = 1 << 5,
	D3D12Resource = 1 << 6,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11Texture")]
	D3D11TextureKHR = D3D11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11TextureKmt")]
	D3D11TextureKmtKHR = D3D11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Heap")]
	D3D12HeapKHR = D3D12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Resource")]
	D3D12ResourceKHR = D3D12Resource,
	DmaBufEXT = 1 << 9,
	AndroidHardwareBufferANDROID = 1 << 10,
	HostAllocationEXT = 1 << 7,
	HostMappedForeignMemoryEXT = 1 << 8,
}
[Flags]
public enum VkExternalMemoryFeatureFlags
{
	DedicatedOnly = 1 << 0,
	Exportable = 1 << 1,
	Importable = 1 << 2,
	[Obsolete("Use VkExternalMemoryFeatureFlags.DedicatedOnly")]
	DedicatedOnlyKHR = DedicatedOnly,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Importable")]
	ImportableKHR = Importable,
}
[Flags]
public enum VkExternalFenceHandleTypeFlags
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	SyncFileDescriptor = 1 << 3,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKHR = SyncFileDescriptor,
}
[Flags]
public enum VkExternalFenceFeatureFlags
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalFenceFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalFenceFeatureFlags.Importable")]
	ImportableKHR = Importable,
}
[Flags]
public enum VkFenceImportFlags
{
	Temporary = 1 << 0,
	[Obsolete("Use VkFenceImportFlags.Temporary")]
	TemporaryKHR = Temporary,
}
[Flags]
public enum VkSemaphoreImportFlags
{
	Temporary = 1 << 0,
	[Obsolete("Use VkSemaphoreImportFlags.Temporary")]
	TemporaryKHR = Temporary,
}
[Flags]
public enum VkExternalSemaphoreHandleTypeFlags
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	D3D12Fence = 1 << 3,
	SyncFileDescriptor = 1 << 4,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D12FenceKHR = D3D12Fence,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKHR = SyncFileDescriptor,
}
[Flags]
public enum VkExternalSemaphoreFeatureFlags
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Importable")]
	ImportableKHR = Importable,
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
	DisplayP3LinearEXT = 1000104003,
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
	[Obsolete("Use VkColorSpaceKHR.DisplayP3LinearEXT")]
	DCIP3LinearEXT = DisplayP3LinearEXT,
	DisplayNativeAMD = 1000213000,
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
	SplitInstanceBindRegionsKHR = 1 << 0,
	ProtectedKHR = 1 << 1,
	MutableFormatKHR = 1 << 2,
}
[Flags]
public enum VkDeviceGroupPresentModeFlagsKHR
{
	LocalKHR = 1 << 0,
	RemoteKHR = 1 << 1,
	SumKHR = 1 << 2,
	LocalMultiDeviceKHR = 1 << 3,
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
	[Obsolete("Use VkDebugReportObjectTypeEXT.DebugReportCallbackEXTEXT")]
	DebugReportEXT = DebugReportCallbackEXTEXT,
	DisplayKHREXT = 29,
	DisplayModeKHREXT = 30,
	ObjectTableNVXEXT = 31,
	IndirectCommandsLayoutNVXEXT = 32,
	ValidationCacheEXTEXT = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheEXTEXT")]
	ValidationCacheEXT = ValidationCacheEXTEXT,
	SamplerYCBCRConversionEXT = 1000011000,
	DescriptorUpdateTemplateEXT = 1000011000,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateEXT")]
	DescriptorUpdateTemplateKHREXT = DescriptorUpdateTemplateEXT,
	[Obsolete("Use VkDebugReportObjectTypeEXT.SamplerYCBCRConversionEXT")]
	SamplerYCBCRConversionKHREXT = SamplerYCBCRConversionEXT,
	AccelerationStructureNVEXT = 1000165000,
}
public enum VkRasterizationOrderAMD
{
	StrictAMD = 0,
	RelaxedAMD = 1,
}
[Flags]
public enum VkPipelineRasterizationStateStreamCreateFlagsEXT
{
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
[Obsolete("Use VkPeerMemoryFeatureFlags")]
[Flags]
public enum VkPeerMemoryFeatureFlagsKHR
{
	CopySource = 1 << 0,
	CopyDestination = 1 << 1,
	GenericSource = 1 << 2,
	GenericDestination = 1 << 3,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopySource")]
	CopySourceKHR = CopySource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopyDestination")]
	CopyDestinationKHR = CopyDestination,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericSource")]
	GenericSourceKHR = GenericSource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericDestination")]
	GenericDestinationKHR = GenericDestination,
}
[Obsolete("Use VkMemoryAllocateFlags")]
[Flags]
public enum VkMemoryAllocateFlagsKHR
{
	DeviceMask = 1 << 0,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKHR = DeviceMask,
	DeviceAddressKHR = 1 << 1,
	DeviceAddressCaptureReplayKHR = 1 << 2,
}
public enum VkValidationCheckEXT
{
	AllEXT = 0,
	ShadersEXT = 1,
}
[Obsolete("Use VkCommandPoolTrimFlags")]
[Flags]
public enum VkCommandPoolTrimFlagsKHR
{
}
[Obsolete("Use VkExternalMemoryHandleTypeFlags")]
[Flags]
public enum VkExternalMemoryHandleTypeFlagsKHR
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	D3D11Texture = 1 << 3,
	D3D11TextureKmt = 1 << 4,
	D3D12Heap = 1 << 5,
	D3D12Resource = 1 << 6,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11Texture")]
	D3D11TextureKHR = D3D11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11TextureKmt")]
	D3D11TextureKmtKHR = D3D11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Heap")]
	D3D12HeapKHR = D3D12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Resource")]
	D3D12ResourceKHR = D3D12Resource,
	DmaBufEXT = 1 << 9,
	AndroidHardwareBufferANDROID = 1 << 10,
	HostAllocationEXT = 1 << 7,
	HostMappedForeignMemoryEXT = 1 << 8,
}
[Obsolete("Use VkExternalMemoryFeatureFlags")]
[Flags]
public enum VkExternalMemoryFeatureFlagsKHR
{
	DedicatedOnly = 1 << 0,
	Exportable = 1 << 1,
	Importable = 1 << 2,
	[Obsolete("Use VkExternalMemoryFeatureFlags.DedicatedOnly")]
	DedicatedOnlyKHR = DedicatedOnly,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Importable")]
	ImportableKHR = Importable,
}
[Obsolete("Use VkExternalSemaphoreHandleTypeFlags")]
[Flags]
public enum VkExternalSemaphoreHandleTypeFlagsKHR
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	D3D12Fence = 1 << 3,
	SyncFileDescriptor = 1 << 4,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D12FenceKHR = D3D12Fence,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKHR = SyncFileDescriptor,
}
[Obsolete("Use VkExternalSemaphoreFeatureFlags")]
[Flags]
public enum VkExternalSemaphoreFeatureFlagsKHR
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Importable")]
	ImportableKHR = Importable,
}
[Obsolete("Use VkSemaphoreImportFlags")]
[Flags]
public enum VkSemaphoreImportFlagsKHR
{
	Temporary = 1 << 0,
	[Obsolete("Use VkSemaphoreImportFlags.Temporary")]
	TemporaryKHR = Temporary,
}
[Flags]
public enum VkConditionalRenderingFlagsEXT
{
	InvertedEXT = 1 << 0,
}
[Obsolete("Use VkDescriptorUpdateTemplateCreateFlags")]
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlagsKHR
{
}
[Obsolete("Use VkDescriptorUpdateTemplateType")]
public enum VkDescriptorUpdateTemplateTypeKHR
{
	DescriptorSet = 0,
	PushDescriptorsKHR = 1,
	[Obsolete("Use VkDescriptorUpdateTemplateType.DescriptorSet")]
	DescriptorSetKHR = DescriptorSet,
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
public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT
{
}
[Obsolete("Use VkExternalFenceHandleTypeFlags")]
[Flags]
public enum VkExternalFenceHandleTypeFlagsKHR
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	SyncFileDescriptor = 1 << 3,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKHR = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32KHR = OpaqueWin32,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKHR = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKHR = SyncFileDescriptor,
}
[Obsolete("Use VkExternalFenceFeatureFlags")]
[Flags]
public enum VkExternalFenceFeatureFlagsKHR
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalFenceFeatureFlags.Exportable")]
	ExportableKHR = Exportable,
	[Obsolete("Use VkExternalFenceFeatureFlags.Importable")]
	ImportableKHR = Importable,
}
[Obsolete("Use VkFenceImportFlags")]
[Flags]
public enum VkFenceImportFlagsKHR
{
	Temporary = 1 << 0,
	[Obsolete("Use VkFenceImportFlags.Temporary")]
	TemporaryKHR = Temporary,
}
public enum VkPerformanceCounterUnitKHR
{
	GenericKHR = 0,
	PercentageKHR = 1,
	NanosecondsKHR = 2,
	BytesKHR = 3,
	BytesPerSecondKHR = 4,
	KelvinKHR = 5,
	WattsKHR = 6,
	VoltsKHR = 7,
	AmpsKHR = 8,
	HertzKHR = 9,
	CyclesKHR = 10,
}
public enum VkPerformanceCounterScopeKHR
{
	QueryScopeCommandBufferKHR = 0,
	QueryScopeRenderPassKHR = 1,
	QueryScopeCommandKHR = 2,
}
public enum VkPerformanceCounterStorageKHR
{
	Int32KHR = 0,
	Int64KHR = 1,
	UInt32KHR = 2,
	UInt64KHR = 3,
	Float32KHR = 4,
	Float64KHR = 5,
}
[Flags]
public enum VkPerformanceCounterDescriptionFlagsKHR
{
	PerformanceImpactingKHR = 1 << 0,
	ConcurrentlyImpactedKHR = 1 << 1,
}
[Flags]
public enum VkAcquireProfilingLockFlagsKHR
{
}
[Obsolete("Use VkPointClippingBehavior")]
public enum VkPointClippingBehaviorKHR
{
	AllClipPlanes = 0,
	UserClipPlanesOnly = 1,
	[Obsolete("Use VkPointClippingBehavior.AllClipPlanes")]
	AllClipPlanesKHR = AllClipPlanes,
	[Obsolete("Use VkPointClippingBehavior.UserClipPlanesOnly")]
	UserClipPlanesOnlyKHR = UserClipPlanesOnly,
}
[Obsolete("Use VkTessellationDomainOrigin")]
public enum VkTessellationDomainOriginKHR
{
	UpperLeft = 0,
	LowerLeft = 1,
	[Obsolete("Use VkTessellationDomainOrigin.UpperLeft")]
	UpperLeftKHR = UpperLeft,
	[Obsolete("Use VkTessellationDomainOrigin.LowerLeft")]
	LowerLeftKHR = LowerLeft,
}
[Flags]
public enum VkMacOSSurfaceCreateFlagsMVK
{
}
[Flags]
public enum VkDebugUtilsMessengerCreateFlagsEXT
{
}
[Flags]
public enum VkDebugUtilsMessageSeverityFlagsEXT
{
	VerboseEXT = 1 << 0,
	InfoEXT = 1 << 4,
	WarningEXT = 1 << 8,
	ErrorEXT = 1 << 12,
}
[Flags]
public enum VkDebugUtilsMessageTypeFlagsEXT
{
	GeneralEXT = 1 << 0,
	ValidationEXT = 1 << 1,
	PerformanceEXT = 1 << 2,
}
[Flags]
public enum VkDebugUtilsMessengerCallbackDataFlagsEXT
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
[Obsolete("Use VkSamplerYcbcrModelConversion")]
public enum VkSamplerYcbcrModelConversionKHR
{
	RGBIdentity = 0,
	YCBCRIdentity = 1,
	YCBCR709 = 2,
	YCBCR601 = 3,
	YCBCR2020 = 4,
	[Obsolete("Use VkSamplerYcbcrModelConversion.RGBIdentity")]
	RGBIdentityKHR = RGBIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCRIdentity")]
	YCBCRIdentityKHR = YCBCRIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR709")]
	YCBCR709KHR = YCBCR709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR601")]
	YCBCR601KHR = YCBCR601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR2020")]
	YCBCR2020KHR = YCBCR2020,
}
[Obsolete("Use VkSamplerYcbcrRange")]
public enum VkSamplerYcbcrRangeKHR
{
	ITUFull = 0,
	ITUNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ITUFull")]
	ITUFullKHR = ITUFull,
	[Obsolete("Use VkSamplerYcbcrRange.ITUNarrow")]
	ITUNarrowKHR = ITUNarrow,
}
[Obsolete("Use VkChromaLocation")]
public enum VkChromaLocationKHR
{
	CositedEven = 0,
	Midpoint = 1,
	[Obsolete("Use VkChromaLocation.CositedEven")]
	CositedEvenKHR = CositedEven,
	[Obsolete("Use VkChromaLocation.Midpoint")]
	MidpointKHR = Midpoint,
}
[Flags]
public enum VkValidationCacheCreateFlagsEXT
{
}
public enum VkValidationCacheHeaderVersionEXT
{
	OneEXT = 1,
}
[Flags]
public enum VkDescriptorBindingFlagsEXT
{
	UpdateAfterBindEXT = 1 << 0,
	UpdateUnusedWhilePendingEXT = 1 << 1,
	PartiallyBoundEXT = 1 << 2,
	VariableDescriptorCountEXT = 1 << 3,
}
public enum VkShadingRatePaletteEntryNV
{
	NoInvocationsNV = 0,
	_16InvocationsPerPixelNV = 1,
	_8InvocationsPerPixelNV = 2,
	_4InvocationsPerPixelNV = 3,
	_2InvocationsPerPixelNV = 4,
	_1InvocationPerPixelNV = 5,
	_1InvocationPer2x1PixelsNV = 6,
	_1InvocationPer1x2PixelsNV = 7,
	_1InvocationPer2x2PixelsNV = 8,
	_1InvocationPer4x2PixelsNV = 9,
	_1InvocationPer2x4PixelsNV = 10,
	_1InvocationPer4x4PixelsNV = 11,
}
public enum VkCoarseSampleOrderTypeNV
{
	DefaultNV = 0,
	CustomNV = 1,
	PixelMajorNV = 2,
	SampleMajorNV = 3,
}
public enum VkAccelerationStructureTypeNV
{
	TopLevelNV = 0,
	BottomLevelNV = 1,
}
[Flags]
public enum VkBuildAccelerationStructureFlagsNV
{
	AllowUpdateNV = 1 << 0,
	AllowCompactionNV = 1 << 1,
	PreferFastTraceNV = 1 << 2,
	PreferFastBuildNV = 1 << 3,
	LowMemoryNV = 1 << 4,
}
public enum VkGeometryTypeNV
{
	TrianglesNV = 0,
	AABBsNV = 1,
}
[Flags]
public enum VkGeometryFlagsNV
{
	OpaqueNV = 1 << 0,
	NoDuplicateAnyHitInvocationNV = 1 << 1,
}
public enum VkAccelerationStructureMemoryRequirementsTypeNV
{
	ObjectNV = 0,
	BuildScratchNV = 1,
	UpdateScratchNV = 2,
}
public enum VkCopyAccelerationStructureModeNV
{
	CloneNV = 0,
	CompactNV = 1,
}
public enum VkRayTracingShaderGroupTypeNV
{
	GeneralNV = 0,
	TrianglesHitGroupNV = 1,
	ProceduralHitGroupNV = 2,
}
[Flags]
public enum VkGeometryInstanceFlagsNV
{
	TriangleCullDisableNV = 1 << 0,
	TriangleFrontCounterclockwiseNV = 1 << 1,
	ForceOpaqueNV = 1 << 2,
	ForceNoOpaqueNV = 1 << 3,
}
public enum VkQueueGlobalPriorityEXT
{
	LowEXT = 128,
	MediumEXT = 256,
	HighEXT = 512,
	RealtimeEXT = 1024,
}
[Flags]
public enum VkPipelineCompilerControlFlagsAMD
{
}
public enum VkTimeDomainEXT
{
	DeviceEXT = 0,
	ClockMonotonicEXT = 1,
	ClockMonotonicRawEXT = 2,
	QueryPerformanceCounterEXT = 3,
}
public enum VkMemoryOverallocationBehaviorAMD
{
	DefaultAMD = 0,
	AllowedAMD = 1,
	DisallowedAMD = 2,
}
[Flags]
public enum VkPipelineCreationFeedbackFlagsEXT
{
	ValidEXT = 1 << 0,
	ApplicationPipelineCacheHitEXT = 1 << 1,
	BasePipelineAccelerationEXT = 1 << 2,
}
public enum VkDriverIdKHR
{
	AmdProprietaryKHR = 1,
	AmdOpenSourceKHR = 2,
	MesaRadvKHR = 3,
	NvidiaProprietaryKHR = 4,
	IntelProprietaryWindowsKHR = 5,
	IntelOpenSourceMESAKHR = 6,
	ImaginationProprietaryKHR = 7,
	QualcommProprietaryKHR = 8,
	ArmProprietaryKHR = 9,
	GoogleSwiftshaderKHR = 10,
	GgpProprietaryKHR = 11,
	BroadcomProprietaryKHR = 12,
}
public enum VkShaderFloatControlsIndependenceKHR
{
	_32OnlyKHR = 0,
	AllKHR = 1,
	NoneKHR = 2,
}
[Flags]
public enum VkResolveModeFlagsKHR
{
	NoneKHR = 0,
	SampleZeroKHR = 1 << 0,
	AverageKHR = 1 << 1,
	MinKHR = 1 << 2,
	MaxKHR = 1 << 3,
}
[Flags]
public enum VkSemaphoreWaitFlagsKHR
{
	AnyKHR = 1 << 0,
}
public enum VkSemaphoreTypeKHR
{
	BinaryKHR = 0,
	TimelineKHR = 1,
}
public enum VkPerformanceOverrideTypeINTEL
{
	NullHardwareINTEL = 0,
	FlushGPUCachesINTEL = 1,
}
public enum VkPerformanceConfigurationTypeINTEL
{
	CommandQueueMetricsDiscoveryActivatedINTEL = 0,
}
public enum VkPerformanceParameterTypeINTEL
{
	HWCountersSupportedINTEL = 0,
	StreamMarkerValidBitsINTEL = 1,
}
public enum VkPerformanceValueTypeINTEL
{
	UInt32INTEL = 0,
	UInt64INTEL = 1,
	FloatINTEL = 2,
	BoolINTEL = 3,
	StringINTEL = 4,
}
public enum VkQueryPoolSamplingModeINTEL
{
	ManualINTEL = 0,
}
[Flags]
public enum VkShaderCorePropertiesFlagsAMD
{
}
[Flags]
public enum VkToolPurposeFlagsEXT
{
	ValidationEXT = 1 << 0,
	ProfilingEXT = 1 << 1,
	TracingEXT = 1 << 2,
	AdditionalFeaturesEXT = 1 << 3,
	ModifyingFeaturesEXT = 1 << 4,
	DebugReportingEXT = 1 << 5,
	DebugMarkersEXT = 1 << 6,
}
public enum VkValidationFeatureEnableEXT
{
	GPUAssistedEXT = 0,
	GPUAssistedReserveBindingSlotEXT = 1,
	BestPracticesEXT = 2,
}
public enum VkValidationFeatureDisableEXT
{
	AllEXT = 0,
	ShadersEXT = 1,
	ThreadSafetyEXT = 2,
	APIParametersEXT = 3,
	ObjectLifetimesEXT = 4,
	CoreChecksEXT = 5,
	UniqueHandlesEXT = 6,
}
public enum VkComponentTypeNV
{
	Float16NV = 0,
	Float32NV = 1,
	Float64NV = 2,
	SInt8NV = 3,
	SInt16NV = 4,
	SInt32NV = 5,
	SInt64NV = 6,
	UInt8NV = 7,
	UInt16NV = 8,
	UInt32NV = 9,
	UInt64NV = 10,
}
public enum VkScopeNV
{
	DeviceNV = 1,
	WorkgroupNV = 2,
	SubgroupNV = 3,
	QueueFamilyNV = 5,
}
public enum VkCoverageReductionModeNV
{
	MergeNV = 0,
	TruncateNV = 1,
}
[Flags]
public enum VkPipelineCoverageReductionStateCreateFlagsNV
{
}
public enum VkFullScreenExclusiveEXT
{
	DefaultEXT = 0,
	AllowedEXT = 1,
	DisallowedEXT = 2,
	ApplicationControlledEXT = 3,
}
[Flags]
public enum VkHeadlessSurfaceCreateFlagsEXT
{
}
public enum VkLineRasterizationModeEXT
{
	DefaultEXT = 0,
	RectangularEXT = 1,
	BresenhamEXT = 2,
	RectangularSmoothEXT = 3,
}
public enum VkPipelineExecutableStatisticFormatKHR
{
	Bool32KHR = 0,
	Int64KHR = 1,
	UInt64KHR = 2,
	Float64KHR = 3,
}
