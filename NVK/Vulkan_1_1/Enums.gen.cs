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
	ErrorSurfaceLostKhr = -1000000000,
	ErrorNativeWindowInUseKhr = -1000000001,
	SuboptimalKhr = 1000001003,
	ErrorOutOfDateKhr = -1000001004,
	ErrorIncompatibleDisplayKhr = -1000003001,
	ErrorValidationFailedExt = -1000011001,
	ErrorInvalidShaderNv = -1000012000,
	[Obsolete("Use VkResult.ErrorOutOfPoolMemory")]
	ErrorOutOfPoolMemoryKhr = ErrorOutOfPoolMemory,
	[Obsolete("Use VkResult.ErrorInvalidExternalHandle")]
	ErrorInvalidExternalHandleKhr = ErrorInvalidExternalHandle,
	ErrorInvalidDRMFormatModifierPlaneLayoutExt = -1000158000,
	ErrorFragmentationExt = -1000161000,
	ErrorNotPermittedExt = -1000174001,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddressKhr")]
	ErrorInvalidDeviceAddressExt = ErrorInvalidOpaqueCaptureAddressKhr,
	ErrorFullScreenExclusiveModeLostExt = -1000255000,
	ErrorInvalidOpaqueCaptureAddressKhr = -1000257000,
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
	SwapchainCreateInfoKhr = 1000001000,
	PresentInfoKhr = 1000001001,
	DeviceGroupPresentCapabilitiesKhr = 1000001007,
	ImageSwapchainCreateInfoKhr = 1000001008,
	BindImageMemorySwapchainInfoKhr = 1000001009,
	AcquireNextImageInfoKhr = 1000001010,
	DeviceGroupPresentInfoKhr = 1000001011,
	DeviceGroupSwapchainCreateInfoKhr = 1000001012,
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
	PhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
	PhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
	PipelineRasterizationStateStreamCreateInfoExt = 1000028002,
	ImageViewHandleInfoNvx = 1000030000,
	TextureLodGatherFormatPropertiesAmd = 1000041000,
	PhysicalDeviceCornerSampledImageFeaturesNv = 1000050000,
	[Obsolete("Use VkStructureType.RenderPassMultiviewCreateInfo")]
	RenderPassMultiviewCreateInfoKhr = RenderPassMultiviewCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceMultiviewFeatures")]
	PhysicalDeviceMultiviewFeaturesKhr = PhysicalDeviceMultiviewFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceMultiviewProperties")]
	PhysicalDeviceMultiviewPropertiesKhr = PhysicalDeviceMultiviewProperties,
	ExternalMemoryImageCreateInfoNv = 1000056000,
	ExportMemoryAllocateInfoNv = 1000056001,
	ImportMemoryWin32HandleInfoNv = 1000057000,
	ExportMemoryWin32HandleInfoNv = 1000057001,
	Win32KeyedMutexAcquireReleaseInfoNv = 1000058000,
	[Obsolete("Use VkStructureType.PhysicalDeviceFeatures2")]
	PhysicalDeviceFeatures2Khr = PhysicalDeviceFeatures2,
	[Obsolete("Use VkStructureType.PhysicalDeviceProperties2")]
	PhysicalDeviceProperties2Khr = PhysicalDeviceProperties2,
	[Obsolete("Use VkStructureType.FormatProperties2")]
	FormatProperties2Khr = FormatProperties2,
	[Obsolete("Use VkStructureType.ImageFormatProperties2")]
	ImageFormatProperties2Khr = ImageFormatProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceImageFormatInfo2")]
	PhysicalDeviceImageFormatInfo2Khr = PhysicalDeviceImageFormatInfo2,
	[Obsolete("Use VkStructureType.QueueFamilyProperties2")]
	QueueFamilyProperties2Khr = QueueFamilyProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceMemoryProperties2")]
	PhysicalDeviceMemoryProperties2Khr = PhysicalDeviceMemoryProperties2,
	[Obsolete("Use VkStructureType.SparseImageFormatProperties2")]
	SparseImageFormatProperties2Khr = SparseImageFormatProperties2,
	[Obsolete("Use VkStructureType.PhysicalDeviceSparseImageFormatInfo2")]
	PhysicalDeviceSparseImageFormatInfo2Khr = PhysicalDeviceSparseImageFormatInfo2,
	[Obsolete("Use VkStructureType.MemoryAllocateFlagsInfo")]
	MemoryAllocateFlagsInfoKhr = MemoryAllocateFlagsInfo,
	[Obsolete("Use VkStructureType.DeviceGroupRenderPassBeginInfo")]
	DeviceGroupRenderPassBeginInfoKhr = DeviceGroupRenderPassBeginInfo,
	[Obsolete("Use VkStructureType.DeviceGroupCommandBufferBeginInfo")]
	DeviceGroupCommandBufferBeginInfoKhr = DeviceGroupCommandBufferBeginInfo,
	[Obsolete("Use VkStructureType.DeviceGroupSubmitInfo")]
	DeviceGroupSubmitInfoKhr = DeviceGroupSubmitInfo,
	[Obsolete("Use VkStructureType.DeviceGroupBindSparseInfo")]
	DeviceGroupBindSparseInfoKhr = DeviceGroupBindSparseInfo,
	[Obsolete("Use VkStructureType.BindBufferMemoryDeviceGroupInfo")]
	BindBufferMemoryDeviceGroupInfoKhr = BindBufferMemoryDeviceGroupInfo,
	[Obsolete("Use VkStructureType.BindImageMemoryDeviceGroupInfo")]
	BindImageMemoryDeviceGroupInfoKhr = BindImageMemoryDeviceGroupInfo,
	ValidationFlagsExt = 1000061000,
	PhysicalDeviceTextureCompressionASTCHDRFeaturesExt = 1000066000,
	ImageViewASTCDecodeModeExt = 1000067000,
	PhysicalDeviceASTCDecodeFeaturesExt = 1000067001,
	[Obsolete("Use VkStructureType.PhysicalDeviceGroupProperties")]
	PhysicalDeviceGroupPropertiesKhr = PhysicalDeviceGroupProperties,
	[Obsolete("Use VkStructureType.DeviceGroupDeviceCreateInfo")]
	DeviceGroupDeviceCreateInfoKhr = DeviceGroupDeviceCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalImageFormatInfo")]
	PhysicalDeviceExternalImageFormatInfoKhr = PhysicalDeviceExternalImageFormatInfo,
	[Obsolete("Use VkStructureType.ExternalImageFormatProperties")]
	ExternalImageFormatPropertiesKhr = ExternalImageFormatProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalBufferInfo")]
	PhysicalDeviceExternalBufferInfoKhr = PhysicalDeviceExternalBufferInfo,
	[Obsolete("Use VkStructureType.ExternalBufferProperties")]
	ExternalBufferPropertiesKhr = ExternalBufferProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceIdProperties")]
	PhysicalDeviceIdPropertiesKhr = PhysicalDeviceIdProperties,
	[Obsolete("Use VkStructureType.ExternalMemoryBufferCreateInfo")]
	ExternalMemoryBufferCreateInfoKhr = ExternalMemoryBufferCreateInfo,
	[Obsolete("Use VkStructureType.ExternalMemoryImageCreateInfo")]
	ExternalMemoryImageCreateInfoKhr = ExternalMemoryImageCreateInfo,
	[Obsolete("Use VkStructureType.ExportMemoryAllocateInfo")]
	ExportMemoryAllocateInfoKhr = ExportMemoryAllocateInfo,
	ImportMemoryWin32HandleInfoKhr = 1000073000,
	ExportMemoryWin32HandleInfoKhr = 1000073001,
	MemoryWin32HandlePropertiesKhr = 1000073002,
	MemoryGetWin32HandleInfoKhr = 1000073003,
	ImportMemoryFileDescriptorInfoKhr = 1000074000,
	MemoryFileDescriptorPropertiesKhr = 1000074001,
	MemoryGetFileDescriptorInfoKhr = 1000074002,
	Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalSemaphoreInfo")]
	PhysicalDeviceExternalSemaphoreInfoKhr = PhysicalDeviceExternalSemaphoreInfo,
	[Obsolete("Use VkStructureType.ExternalSemaphoreProperties")]
	ExternalSemaphorePropertiesKhr = ExternalSemaphoreProperties,
	[Obsolete("Use VkStructureType.ExportSemaphoreCreateInfo")]
	ExportSemaphoreCreateInfoKhr = ExportSemaphoreCreateInfo,
	ImportSemaphoreWin32HandleInfoKhr = 1000078000,
	ExportSemaphoreWin32HandleInfoKhr = 1000078001,
	D3D12FenceSubmitInfoKhr = 1000078002,
	SemaphoreGetWin32HandleInfoKhr = 1000078003,
	ImportSemaphoreFileDescriptorInfoKhr = 1000079000,
	SemaphoreGetFileDescriptorInfoKhr = 1000079001,
	PhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
	CommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
	PhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
	ConditionalRenderingBeginInfoExt = 1000081002,
	PhysicalDeviceShaderFloat16Int8FeaturesKhr = 1000082000,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8FeaturesKhr")]
	PhysicalDeviceFloat16Int8FeaturesKhr = PhysicalDeviceShaderFloat16Int8FeaturesKhr,
	[Obsolete("Use VkStructureType.PhysicalDevice16bitStorageFeatures")]
	PhysicalDevice16bitStorageFeaturesKhr = PhysicalDevice16bitStorageFeatures,
	PresentRegionsKhr = 1000084000,
	[Obsolete("Use VkStructureType.DescriptorUpdateTemplateCreateInfo")]
	DescriptorUpdateTemplateCreateInfoKhr = DescriptorUpdateTemplateCreateInfo,
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
	PhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
	PipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
	HDRMetadataExt = 1000105000,
	PhysicalDeviceImagelessFramebufferFeaturesKhr = 1000108000,
	FramebufferAttachmentsCreateInfoKhr = 1000108001,
	FramebufferAttachmentImageInfoKhr = 1000108002,
	RenderPassAttachmentBeginInfoKhr = 1000108003,
	AttachmentDescription2Khr = 1000109000,
	AttachmentReference2Khr = 1000109001,
	SubpassDescription2Khr = 1000109002,
	SubpassDependency2Khr = 1000109003,
	RenderPassCreateInfo2Khr = 1000109004,
	SubpassBeginInfoKhr = 1000109005,
	SubpassEndInfoKhr = 1000109006,
	SharedPresentSurfaceCapabilitiesKhr = 1000111000,
	[Obsolete("Use VkStructureType.PhysicalDeviceExternalFenceInfo")]
	PhysicalDeviceExternalFenceInfoKhr = PhysicalDeviceExternalFenceInfo,
	[Obsolete("Use VkStructureType.ExternalFenceProperties")]
	ExternalFencePropertiesKhr = ExternalFenceProperties,
	[Obsolete("Use VkStructureType.ExportFenceCreateInfo")]
	ExportFenceCreateInfoKhr = ExportFenceCreateInfo,
	ImportFenceWin32HandleInfoKhr = 1000114000,
	ExportFenceWin32HandleInfoKhr = 1000114001,
	FenceGetWin32HandleInfoKhr = 1000114002,
	ImportFenceFileDescriptorInfoKhr = 1000115000,
	FenceGetFileDescriptorInfoKhr = 1000115001,
	PhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
	PhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
	QueryPoolPerformanceCreateInfoKhr = 1000116002,
	PerformanceQuerySubmitInfoKhr = 1000116003,
	AcquireProfilingLockInfoKhr = 1000116004,
	PerformanceCounterKhr = 1000116005,
	PerformanceCounterDescriptionKhr = 1000116006,
	[Obsolete("Use VkStructureType.PhysicalDevicePointClippingProperties")]
	PhysicalDevicePointClippingPropertiesKhr = PhysicalDevicePointClippingProperties,
	[Obsolete("Use VkStructureType.RenderPassInputAttachmentAspectCreateInfo")]
	RenderPassInputAttachmentAspectCreateInfoKhr = RenderPassInputAttachmentAspectCreateInfo,
	[Obsolete("Use VkStructureType.ImageViewUsageCreateInfo")]
	ImageViewUsageCreateInfoKhr = ImageViewUsageCreateInfo,
	[Obsolete("Use VkStructureType.PipelineTessellationDomainOriginStateCreateInfo")]
	PipelineTessellationDomainOriginStateCreateInfoKhr = PipelineTessellationDomainOriginStateCreateInfo,
	PhysicalDeviceSurfaceInfo2Khr = 1000119000,
	SurfaceCapabilities2Khr = 1000119001,
	SurfaceFormat2Khr = 1000119002,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointerFeatures")]
	PhysicalDeviceVariablePointerFeaturesKhr = PhysicalDeviceVariablePointerFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointerFeatures")]
	PhysicalDeviceVariablePointersFeaturesKhr = PhysicalDeviceVariablePointerFeatures,
	DisplayProperties2Khr = 1000121000,
	DisplayPlaneProperties2Khr = 1000121001,
	DisplayModeProperties2Khr = 1000121002,
	DisplayPlaneInfo2Khr = 1000121003,
	DisplayPlaneCapabilities2Khr = 1000121004,
	MacosSurfaceCreateInfoMvk = 1000123000,
	[Obsolete("Use VkStructureType.MemoryDedicatedRequirements")]
	MemoryDedicatedRequirementsKhr = MemoryDedicatedRequirements,
	[Obsolete("Use VkStructureType.MemoryDedicatedAllocateInfo")]
	MemoryDedicatedAllocateInfoKhr = MemoryDedicatedAllocateInfo,
	DebugUtilsObjectNameInfoExt = 1000128000,
	DebugUtilsObjectTagInfoExt = 1000128001,
	DebugUtilsLabelExt = 1000128002,
	DebugUtilsMessengerCallbackDataExt = 1000128003,
	DebugUtilsMessengerCreateInfoExt = 1000128004,
	AndroidHardwareBufferUsageAndroid = 1000129000,
	AndroidHardwareBufferPropertiesAndroid = 1000129001,
	AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
	ImportAndroidHardwareBufferInfoAndroid = 1000129003,
	MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
	ExternalFormatAndroid = 1000129005,
	PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
	SamplerReductionModeCreateInfoExt = 1000130001,
	PhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
	PhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
	WriteDescriptorSetInlineUniformBlockExt = 1000138002,
	DescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
	SampleLocationsInfoExt = 1000143000,
	RenderPassSampleLocationsBeginInfoExt = 1000143001,
	PipelineSampleLocationsStateCreateInfoExt = 1000143002,
	PhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
	MultisamplePropertiesExt = 1000143004,
	[Obsolete("Use VkStructureType.BufferMemoryRequirementsInfo2")]
	BufferMemoryRequirementsInfo2Khr = BufferMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.ImageMemoryRequirementsInfo2")]
	ImageMemoryRequirementsInfo2Khr = ImageMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.ImageSparseMemoryRequirementsInfo2")]
	ImageSparseMemoryRequirementsInfo2Khr = ImageSparseMemoryRequirementsInfo2,
	[Obsolete("Use VkStructureType.MemoryRequirements2")]
	MemoryRequirements2Khr = MemoryRequirements2,
	[Obsolete("Use VkStructureType.SparseImageMemoryRequirements2")]
	SparseImageMemoryRequirements2Khr = SparseImageMemoryRequirements2,
	ImageFormatListCreateInfoKhr = 1000147000,
	PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
	PipelineCoverageToColorStateCreateInfoNv = 1000149000,
	PipelineCoverageModulationStateCreateInfoNv = 1000152000,
	PhysicalDeviceShaderSMBuiltinsFeaturesNv = 1000154000,
	PhysicalDeviceShaderSMBuiltinsPropertiesNv = 1000154001,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionCreateInfo")]
	SamplerYCBCRConversionCreateInfoKhr = SamplerYCBCRConversionCreateInfo,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionInfo")]
	SamplerYCBCRConversionInfoKhr = SamplerYCBCRConversionInfo,
	[Obsolete("Use VkStructureType.BindImagePlaneMemoryInfo")]
	BindImagePlaneMemoryInfoKhr = BindImagePlaneMemoryInfo,
	[Obsolete("Use VkStructureType.ImagePlaneMemoryRequirementsInfo")]
	ImagePlaneMemoryRequirementsInfoKhr = ImagePlaneMemoryRequirementsInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSamplerYCBCRConversionFeatures")]
	PhysicalDeviceSamplerYCBCRConversionFeaturesKhr = PhysicalDeviceSamplerYCBCRConversionFeatures,
	[Obsolete("Use VkStructureType.SamplerYCBCRConversionImageFormatProperties")]
	SamplerYCBCRConversionImageFormatPropertiesKhr = SamplerYCBCRConversionImageFormatProperties,
	[Obsolete("Use VkStructureType.BindBufferMemoryInfo")]
	BindBufferMemoryInfoKhr = BindBufferMemoryInfo,
	[Obsolete("Use VkStructureType.BindImageMemoryInfo")]
	BindImageMemoryInfoKhr = BindImageMemoryInfo,
	DRMFormatModifierPropertiesListExt = 1000158000,
	DRMFormatModifierPropertiesExt = 1000158001,
	PhysicalDeviceImageDRMFormatModifierInfoExt = 1000158002,
	ImageDRMFormatModifierListCreateInfoExt = 1000158003,
	ImageDRMFormatModifierExplicitCreateInfoExt = 1000158004,
	ImageDRMFormatModifierPropertiesExt = 1000158005,
	ValidationCacheCreateInfoExt = 1000160000,
	ShaderModuleValidationCacheCreateInfoExt = 1000160001,
	DescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
	PhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
	PhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
	DescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
	DescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
	PipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
	PhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
	PhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
	PipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
	RayTracingPipelineCreateInfoNv = 1000165000,
	AccelerationStructureCreateInfoNv = 1000165001,
	GeometryNv = 1000165003,
	GeometryTrianglesNv = 1000165004,
	GeometryAABBNv = 1000165005,
	BindAccelerationStructureMemoryInfoNv = 1000165006,
	WriteDescriptorSetAccelerationStructureNv = 1000165007,
	AccelerationStructureMemoryRequirementsInfoNv = 1000165008,
	PhysicalDeviceRayTracingPropertiesNv = 1000165009,
	RayTracingShaderGroupCreateInfoNv = 1000165011,
	AccelerationStructureInfoNv = 1000165012,
	PhysicalDeviceRepresentativeFragmentTestFeaturesNv = 1000166000,
	PipelineRepresentativeFragmentTestStateCreateInfoNv = 1000166001,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance3Properties")]
	PhysicalDeviceMaintenance3PropertiesKhr = PhysicalDeviceMaintenance3Properties,
	[Obsolete("Use VkStructureType.DescriptorSetLayoutSupport")]
	DescriptorSetLayoutSupportKhr = DescriptorSetLayoutSupport,
	PhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
	FilterCubicImageViewImageFormatPropertiesExt = 1000170001,
	DeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
	PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = 1000175000,
	PhysicalDevice8bitStorageFeaturesKhr = 1000177000,
	ImportMemoryHostPointerInfoExt = 1000178000,
	MemoryHostPointerPropertiesExt = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
	PhysicalDeviceShaderAtomicInt64FeaturesKhr = 1000180000,
	PhysicalDeviceShaderClockFeaturesKhr = 1000181000,
	PipelineCompilerControlCreateInfoAmd = 1000183000,
	CalibratedTimestampInfoExt = 1000184000,
	PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
	DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
	PhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
	PipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
	PhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
	PipelineCreationFeedbackCreateInfoExt = 1000192000,
	PhysicalDeviceDriverPropertiesKhr = 1000196000,
	PhysicalDeviceFloatControlsPropertiesKhr = 1000197000,
	PhysicalDeviceDepthStencilResolvePropertiesKhr = 1000199000,
	SubpassDescriptionDepthStencilResolveKhr = 1000199001,
	PhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
	PhysicalDeviceMeshShaderFeaturesNv = 1000202000,
	PhysicalDeviceMeshShaderPropertiesNv = 1000202001,
	PhysicalDeviceFragmentShaderBarycentricFeaturesNv = 1000203000,
	PhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
	PipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
	PhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
	CheckpointDataNv = 1000206000,
	QueueFamilyCheckpointPropertiesNv = 1000206001,
	PhysicalDeviceTimelineSemaphoreFeaturesKhr = 1000207000,
	PhysicalDeviceTimelineSemaphorePropertiesKhr = 1000207001,
	SemaphoreTypeCreateInfoKhr = 1000207002,
	TimelineSemaphoreSubmitInfoKhr = 1000207003,
	SemaphoreWaitInfoKhr = 1000207004,
	SemaphoreSignalInfoKhr = 1000207005,
	PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
	QueryPoolCreateInfoIntel = 1000210000,
	InitializePerformanceAPIInfoIntel = 1000210001,
	PerformanceMarkerInfoIntel = 1000210002,
	PerformanceStreamMarkerInfoIntel = 1000210003,
	PerformanceOverrideInfoIntel = 1000210004,
	PerformanceConfigurationAcquireInfoIntel = 1000210005,
	PhysicalDeviceVulkanMemoryModelFeaturesKhr = 1000211000,
	PhysicalDevicePCIBusInfoPropertiesExt = 1000212000,
	DisplayNativeHDRSurfaceCapabilitiesAmd = 1000213000,
	SwapchainDisplayNativeHDRCreateInfoAmd = 1000213001,
	PhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
	PhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
	RenderPassFragmentDensityMapCreateInfoExt = 1000218002,
	PhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
	PhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
	PipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
	PhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
	PhysicalDeviceShaderCoreProperties2Amd = 1000227000,
	PhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
	PhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
	PhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
	MemoryPriorityAllocateInfoExt = 1000238001,
	SurfaceProtectedCapabilitiesKhr = 1000239000,
	PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
	PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = 1000241000,
	AttachmentReferenceStencilLayoutKhr = 1000241001,
	AttachmentDescriptionStencilLayoutKhr = 1000241002,
	PhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt")]
	PhysicalDeviceBufferAddressFeaturesExt = PhysicalDeviceBufferDeviceAddressFeaturesExt,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfoKhr")]
	BufferDeviceAddressInfoExt = BufferDeviceAddressInfoKhr,
	BufferDeviceAddressCreateInfoExt = 1000244002,
	PhysicalDeviceToolPropertiesExt = 1000245000,
	ImageStencilUsageCreateInfoExt = 1000246000,
	ValidationFeaturesExt = 1000247000,
	PhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
	CooperativeMatrixPropertiesNv = 1000249001,
	PhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
	PhysicalDeviceCoverageReductionModeFeaturesNv = 1000250000,
	PipelineCoverageReductionStateCreateInfoNv = 1000250001,
	FramebufferMixedSamplesCombinationNv = 1000250002,
	PhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
	PhysicalDeviceYCBCRImageArraysFeaturesExt = 1000252000,
	PhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = 1000253000,
	SurfaceFullScreenExclusiveInfoExt = 1000255000,
	SurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
	SurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
	HeadlessSurfaceCreateInfoExt = 1000256000,
	PhysicalDeviceBufferDeviceAddressFeaturesKhr = 1000257000,
	BufferDeviceAddressInfoKhr = 1000257001,
	BufferOpaqueCaptureAddressCreateInfoKhr = 1000257002,
	MemoryOpaqueCaptureAddressAllocateInfoKhr = 1000257003,
	DeviceMemoryOpaqueCaptureAddressInfoKhr = 1000257004,
	PhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
	PipelineRasterizationLineStateCreateInfoExt = 1000259001,
	PhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
	PhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
	PhysicalDeviceIndexTypeUInt8FeaturesExt = 1000265000,
	PhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
	PipelineInfoKhr = 1000269001,
	PipelineExecutablePropertiesKhr = 1000269002,
	PipelineExecutableInfoKhr = 1000269003,
	PipelineExecutableStatisticKhr = 1000269004,
	PipelineExecutableInternalRepresentationKhr = 1000269005,
	PhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
	PhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
	PhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
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
	PVRTC12BPPUNormBlockImg = 1000054000,
	PVRTC14BPPUNormBlockImg = 1000054001,
	PVRTC22BPPUNormBlockImg = 1000054002,
	PVRTC24BPPUNormBlockImg = 1000054003,
	PVRTC12BPPSRGBBlockImg = 1000054004,
	PVRTC14BPPSRGBBlockImg = 1000054005,
	PVRTC22BPPSRGBBlockImg = 1000054006,
	PVRTC24BPPSRGBBlockImg = 1000054007,
	ASTC4x4SFloatBlockExt = 1000066000,
	ASTC5x4SFloatBlockExt = 1000066001,
	ASTC5x5SFloatBlockExt = 1000066002,
	ASTC6x5SFloatBlockExt = 1000066003,
	ASTC6x6SFloatBlockExt = 1000066004,
	ASTC8x5SFloatBlockExt = 1000066005,
	ASTC8x6SFloatBlockExt = 1000066006,
	ASTC8x8SFloatBlockExt = 1000066007,
	ASTC10x5SFloatBlockExt = 1000066008,
	ASTC10x6SFloatBlockExt = 1000066009,
	ASTC10x8SFloatBlockExt = 1000066010,
	ASTC10x10SFloatBlockExt = 1000066011,
	ASTC12x10SFloatBlockExt = 1000066012,
	ASTC12x12SFloatBlockExt = 1000066013,
	[Obsolete("Use VkFormat.G8B8G8R8422UNorm")]
	G8B8G8R8422UNormKhr = G8B8G8R8422UNorm,
	[Obsolete("Use VkFormat.B8G8R8G8422UNorm")]
	B8G8R8G8422UNormKhr = B8G8R8G8422UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane420UNorm")]
	G8B8R83Plane420UNormKhr = G8B8R83Plane420UNorm,
	[Obsolete("Use VkFormat.G8B8R82Plane420UNorm")]
	G8B8R82Plane420UNormKhr = G8B8R82Plane420UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane422UNorm")]
	G8B8R83Plane422UNormKhr = G8B8R83Plane422UNorm,
	[Obsolete("Use VkFormat.G8B8R82Plane422UNorm")]
	G8B8R82Plane422UNormKhr = G8B8R82Plane422UNorm,
	[Obsolete("Use VkFormat.G8B8R83Plane444UNorm")]
	G8B8R83Plane444UNormKhr = G8B8R83Plane444UNorm,
	[Obsolete("Use VkFormat.R10X6UNormPack16")]
	R10X6UNormPack16Khr = R10X6UNormPack16,
	[Obsolete("Use VkFormat.R10X6G10X6UNorm2Pack16")]
	R10X6G10X6UNorm2Pack16Khr = R10X6G10X6UNorm2Pack16,
	[Obsolete("Use VkFormat.R10X6G10X6B10X6A10X6UNorm4Pack16")]
	R10X6G10X6B10X6A10X6UNorm4Pack16Khr = R10X6G10X6B10X6A10X6UNorm4Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6G10X6R10X6422UNorm4Pack16")]
	G10X6B10X6G10X6R10X6422UNorm4Pack16Khr = G10X6B10X6G10X6R10X6422UNorm4Pack16,
	[Obsolete("Use VkFormat.B10X6G10X6R10X6G10X6422UNorm4Pack16")]
	B10X6G10X6R10X6G10X6422UNorm4Pack16Khr = B10X6G10X6R10X6G10X6422UNorm4Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane420UNorm3Pack16")]
	G10X6B10X6R10X63Plane420UNorm3Pack16Khr = G10X6B10X6R10X63Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X62Plane420UNorm3Pack16")]
	G10X6B10X6R10X62Plane420UNorm3Pack16Khr = G10X6B10X6R10X62Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane422UNorm3Pack16")]
	G10X6B10X6R10X63Plane422UNorm3Pack16Khr = G10X6B10X6R10X63Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X62Plane422UNorm3Pack16")]
	G10X6B10X6R10X62Plane422UNorm3Pack16Khr = G10X6B10X6R10X62Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G10X6B10X6R10X63Plane444UNorm3Pack16")]
	G10X6B10X6R10X63Plane444UNorm3Pack16Khr = G10X6B10X6R10X63Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.R12X4UNormPack16")]
	R12X4UNormPack16Khr = R12X4UNormPack16,
	[Obsolete("Use VkFormat.R12X4G12X4UNorm2Pack16")]
	R12X4G12X4UNorm2Pack16Khr = R12X4G12X4UNorm2Pack16,
	[Obsolete("Use VkFormat.R12X4G12X4B12X4A12X4UNorm4Pack16")]
	R12X4G12X4B12X4A12X4UNorm4Pack16Khr = R12X4G12X4B12X4A12X4UNorm4Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4G12X4R12X4422UNorm4Pack16")]
	G12X4B12X4G12X4R12X4422UNorm4Pack16Khr = G12X4B12X4G12X4R12X4422UNorm4Pack16,
	[Obsolete("Use VkFormat.B12X4G12X4R12X4G12X4422UNorm4Pack16")]
	B12X4G12X4R12X4G12X4422UNorm4Pack16Khr = B12X4G12X4R12X4G12X4422UNorm4Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane420UNorm3Pack16")]
	G12X4B12X4R12X43Plane420UNorm3Pack16Khr = G12X4B12X4R12X43Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X42Plane420UNorm3Pack16")]
	G12X4B12X4R12X42Plane420UNorm3Pack16Khr = G12X4B12X4R12X42Plane420UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane422UNorm3Pack16")]
	G12X4B12X4R12X43Plane422UNorm3Pack16Khr = G12X4B12X4R12X43Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X42Plane422UNorm3Pack16")]
	G12X4B12X4R12X42Plane422UNorm3Pack16Khr = G12X4B12X4R12X42Plane422UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X43Plane444UNorm3Pack16")]
	G12X4B12X4R12X43Plane444UNorm3Pack16Khr = G12X4B12X4R12X43Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.G16B16G16R16422UNorm")]
	G16B16G16R16422UNormKhr = G16B16G16R16422UNorm,
	[Obsolete("Use VkFormat.B16G16R16G16422UNorm")]
	B16G16R16G16422UNormKhr = B16G16R16G16422UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane420UNorm")]
	G16B16R163Plane420UNormKhr = G16B16R163Plane420UNorm,
	[Obsolete("Use VkFormat.G16B16R162Plane420UNorm")]
	G16B16R162Plane420UNormKhr = G16B16R162Plane420UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane422UNorm")]
	G16B16R163Plane422UNormKhr = G16B16R163Plane422UNorm,
	[Obsolete("Use VkFormat.G16B16R162Plane422UNorm")]
	G16B16R162Plane422UNormKhr = G16B16R162Plane422UNorm,
	[Obsolete("Use VkFormat.G16B16R163Plane444UNorm")]
	G16B16R163Plane444UNormKhr = G16B16R163Plane444UNorm,
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
	SampledImageFilterCubicImg = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags.TransferSource")]
	TransferSourceKhr = TransferSource,
	[Obsolete("Use VkFormatFeatureFlags.TransferDestination")]
	TransferDestinationKhr = TransferDestination,
	SampledImageFilterMinmaxExt = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags.MidpointChromaSamples")]
	MidpointChromaSamplesKhr = MidpointChromaSamples,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionLinearFilter")]
	SampledImageYCBCRConversionLinearFilterKhr = SampledImageYCBCRConversionLinearFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionSeparateReconstructionFilter")]
	SampledImageYCBCRConversionSeparateReconstructionFilterKhr = SampledImageYCBCRConversionSeparateReconstructionFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionChromaReconstructionExplicit")]
	SampledImageYCBCRConversionChromaReconstructionExplicitKhr = SampledImageYCBCRConversionChromaReconstructionExplicit,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYCBCRConversionChromaReconstructionExplicitForceable")]
	SampledImageYCBCRConversionChromaReconstructionExplicitForceableKhr = SampledImageYCBCRConversionChromaReconstructionExplicitForceable,
	[Obsolete("Use VkFormatFeatureFlags.Disjoint")]
	DisjointKhr = Disjoint,
	[Obsolete("Use VkFormatFeatureFlags.CositedChromaSamples")]
	CositedChromaSamplesKhr = CositedChromaSamples,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterCubicImg")]
	SampledImageFilterCubicExt = SampledImageFilterCubicImg,
	FragmentDensityMapExt = 1 << 24,
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
	DRMFormatModifierExt = 1000158000,
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
	ShadingRateImageNv = 1 << 8,
	FragmentDensityMapExt = 1 << 9,
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
	CornerSampledNv = 1 << 13,
	[Obsolete("Use VkImageCreateFlags.SplitInstanceBindRegions")]
	SplitInstanceBindRegionsKhr = SplitInstanceBindRegions,
	[Obsolete("Use VkImageCreateFlags._2DArrayCompatible")]
	_2DArrayCompatibleKhr = _2DArrayCompatible,
	[Obsolete("Use VkImageCreateFlags.BlockTexelViewCompatible")]
	BlockTexelViewCompatibleKhr = BlockTexelViewCompatible,
	[Obsolete("Use VkImageCreateFlags.ExtendedUsage")]
	ExtendedUsageKhr = ExtendedUsage,
	SampleLocationsCompatibleDepthExt = 1 << 12,
	[Obsolete("Use VkImageCreateFlags.Disjoint")]
	DisjointKhr = Disjoint,
	[Obsolete("Use VkImageCreateFlags.Alias")]
	AliasKhr = Alias,
	SubsampledExt = 1 << 14,
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
	DeviceCoherentAmd = 1 << 6,
	DeviceUncachedAmd = 1 << 7,
}
[Flags]
public enum VkMemoryHeapFlags
{
	DeviceLocal = 1 << 0,
	MultiInstance = 1 << 1,
	[Obsolete("Use VkMemoryHeapFlags.MultiInstance")]
	MultiInstanceKhr = MultiInstance,
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
	TransformFeedbackExt = 1 << 24,
	ConditionalRenderingExt = 1 << 18,
	CommandProcessNvx = 1 << 17,
	ShadingRateImageNv = 1 << 22,
	RayTracingShaderNv = 1 << 21,
	AccelerationStructureBuildNv = 1 << 25,
	TaskShaderNv = 1 << 19,
	MeshShaderNv = 1 << 20,
	FragmentDensityProcessExt = 1 << 23,
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
	Plane0Khr = Plane0,
	[Obsolete("Use VkImageAspectFlags.Plane1")]
	Plane1Khr = Plane1,
	[Obsolete("Use VkImageAspectFlags.Plane2")]
	Plane2Khr = Plane2,
	MemoryPlane0Ext = 1 << 7,
	MemoryPlane1Ext = 1 << 8,
	MemoryPlane2Ext = 1 << 9,
	MemoryPlane3Ext = 1 << 10,
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
	TransformFeedbackStreamExt = 1000028004,
	PerformanceQueryKhr = 1000116000,
	AccelerationStructureCompactedSizeNv = 1000165000,
	PerformanceQueryIntel = 1000210000,
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
	[Obsolete("Use VkBufferCreateFlags.DeviceAddressCaptureReplayKhr")]
	DeviceAddressCaptureReplayExt = DeviceAddressCaptureReplayKhr,
	DeviceAddressCaptureReplayKhr = 1 << 4,
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
	TransformFeedbackBufferExt = 1 << 11,
	TransformFeedbackCounterBufferExt = 1 << 12,
	ConditionalRenderingExt = 1 << 9,
	RayTracingNv = 1 << 10,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddressKhr")]
	ShaderDeviceAddressExt = ShaderDeviceAddressKhr,
	ShaderDeviceAddressKhr = 1 << 17,
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
	PresentSourceKhr = 1000001002,
	SharedPresentKhr = 1000111000,
	[Obsolete("Use VkImageLayout.DepthReadOnlyStencilAttachmentOptimal")]
	DepthReadOnlyStencilAttachmentOptimalKhr = DepthReadOnlyStencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthAttachmentStencilReadOnlyOptimal")]
	DepthAttachmentStencilReadOnlyOptimalKhr = DepthAttachmentStencilReadOnlyOptimal,
	ShadingRateOptimalNv = 1000164003,
	FragmentDensityMapOptimalExt = 1000218000,
	DepthAttachmentOptimalKhr = 1000241000,
	DepthReadOnlyOptimalKhr = 1000241001,
	StencilAttachmentOptimalKhr = 1000241002,
	StencilReadOnlyOptimalKhr = 1000241003,
}
[Flags]
public enum VkImageViewCreateFlags
{
	FragmentDensityMapDynamicExt = 1 << 0,
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
	ViewIndexFromDeviceIndexKhr = ViewIndexFromDeviceIndex,
	[Obsolete("Use VkPipelineCreateFlags.DispatchBase")]
	DispatchBaseKhr = DispatchBase,
	DeferCompileNv = 1 << 5,
	CaptureStatisticsKhr = 1 << 6,
	CaptureInternalRepresentationsKhr = 1 << 7,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags
{
	AllowVaryingSubgroupSizeExt = 1 << 0,
	RequireFullSubgroupsExt = 1 << 1,
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
	RaygenNv = 1 << 8,
	AnyHitNv = 1 << 9,
	ClosestHitNv = 1 << 10,
	MissNv = 1 << 11,
	IntersectionNv = 1 << 12,
	CallableNv = 1 << 13,
	TaskNv = 1 << 6,
	MeshNv = 1 << 7,
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
	InvertRGBExt = 1000148024,
	LineardodgeExt = 1000148025,
	LinearburnExt = 1000148026,
	VividlightExt = 1000148027,
	LinearlightExt = 1000148028,
	PinlightExt = 1000148029,
	HardmixExt = 1000148030,
	HSLHueExt = 1000148031,
	HSLSaturationExt = 1000148032,
	HSLColorExt = 1000148033,
	HSLLuminosityExt = 1000148034,
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
	ViewportShadingRatePaletteNv = 1000164004,
	ViewportCoarseSampleOrderNv = 1000164006,
	ExclusiveScissorNv = 1000205001,
	LineStippleExt = 1000259000,
}
[Flags]
public enum VkPipelineLayoutCreateFlags
{
}
[Flags]
public enum VkSamplerCreateFlags
{
	SubsampledExt = 1 << 0,
	SubsampledCoarseReconstructionExt = 1 << 1,
}
public enum VkFilter
{
	Nearest = 0,
	Linear = 1,
	CubicImg = 1000015000,
	[Obsolete("Use VkFilter.CubicImg")]
	CubicExt = CubicImg,
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
	MirrorClampToEdgeKhr = MirrorClampToEdge,
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
	UpdateAfterBindPoolExt = 1 << 1,
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
	InlineUniformBlockExt = 1000138000,
	AccelerationStructureNv = 1000165000,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
	UpdateAfterBindExt = 1 << 1,
}
[Flags]
public enum VkDescriptorPoolResetFlags
{
}
[Flags]
public enum VkFramebufferCreateFlags
{
	ImagelessKhr = 1 << 0,
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
	RayTracingNv = 1000165000,
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
	TransformFeedbackWriteExt = 1 << 25,
	TransformFeedbackCounterReadExt = 1 << 26,
	TransformFeedbackCounterWriteExt = 1 << 27,
	ConditionalRenderingReadExt = 1 << 20,
	CommandProcessReadNvx = 1 << 17,
	CommandProcessWriteNvx = 1 << 18,
	ColorAttachmentReadNoncoherentExt = 1 << 19,
	ShadingRateImageReadNv = 1 << 23,
	AccelerationStructureReadNv = 1 << 21,
	AccelerationStructureWriteNv = 1 << 22,
	FragmentDensityMapReadExt = 1 << 24,
}
[Flags]
public enum VkDependencyFlags
{
	ByRegion = 1 << 0,
	DeviceGroup = 1 << 2,
	ViewLocal = 1 << 1,
	[Obsolete("Use VkDependencyFlags.ViewLocal")]
	ViewLocalKhr = ViewLocal,
	[Obsolete("Use VkDependencyFlags.DeviceGroup")]
	DeviceGroupKhr = DeviceGroup,
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
	NoneNv = 1000165000,
	UInt8Ext = 1000265000,
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
	SurfaceKhr = 1000000000,
	SwapchainKhr = 1000001000,
	DisplayKhr = 1000002000,
	DisplayModeKhr = 1000002001,
	DebugReportCallbackExt = 1000011000,
	[Obsolete("Use VkObjectType.DescriptorUpdateTemplate")]
	DescriptorUpdateTemplateKhr = DescriptorUpdateTemplate,
	ObjectTableNvx = 1000086000,
	IndirectCommandsLayoutNvx = 1000086001,
	DebugUtilsMessengerExt = 1000128000,
	[Obsolete("Use VkObjectType.SamplerYCBCRConversion")]
	SamplerYCBCRConversionKhr = SamplerYCBCRConversion,
	ValidationCacheExt = 1000160000,
	AccelerationStructureNv = 1000165000,
	PerformanceConfigurationIntel = 1000210000,
}
public enum VkVendorId
{
	Viv = 0x10001,
	Vsi = 0x10002,
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
	PartitionedNv = 1 << 8,
}
[Flags]
public enum VkPeerMemoryFeatureFlags
{
	CopySource = 1 << 0,
	CopyDestination = 1 << 1,
	GenericSource = 1 << 2,
	GenericDestination = 1 << 3,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopySource")]
	CopySourceKhr = CopySource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopyDestination")]
	CopyDestinationKhr = CopyDestination,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericSource")]
	GenericSourceKhr = GenericSource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericDestination")]
	GenericDestinationKhr = GenericDestination,
}
[Flags]
public enum VkMemoryAllocateFlags
{
	DeviceMask = 1 << 0,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKhr = DeviceMask,
	DeviceAddressKhr = 1 << 1,
	DeviceAddressCaptureReplayKhr = 1 << 2,
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
	AllClipPlanesKhr = AllClipPlanes,
	[Obsolete("Use VkPointClippingBehavior.UserClipPlanesOnly")]
	UserClipPlanesOnlyKhr = UserClipPlanesOnly,
}
public enum VkTessellationDomainOrigin
{
	UpperLeft = 0,
	LowerLeft = 1,
	[Obsolete("Use VkTessellationDomainOrigin.UpperLeft")]
	UpperLeftKhr = UpperLeft,
	[Obsolete("Use VkTessellationDomainOrigin.LowerLeft")]
	LowerLeftKhr = LowerLeft,
}
public enum VkSamplerYcbcrModelConversion
{
	RGBIdentity = 0,
	YCBCRIdentity = 1,
	YCBCR709 = 2,
	YCBCR601 = 3,
	YCBCR2020 = 4,
	[Obsolete("Use VkSamplerYcbcrModelConversion.RGBIdentity")]
	RGBIdentityKhr = RGBIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCRIdentity")]
	YCBCRIdentityKhr = YCBCRIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR709")]
	YCBCR709Khr = YCBCR709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR601")]
	YCBCR601Khr = YCBCR601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR2020")]
	YCBCR2020Khr = YCBCR2020,
}
public enum VkSamplerYcbcrRange
{
	ITUFull = 0,
	ITUNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ITUFull")]
	ITUFullKhr = ITUFull,
	[Obsolete("Use VkSamplerYcbcrRange.ITUNarrow")]
	ITUNarrowKhr = ITUNarrow,
}
public enum VkChromaLocation
{
	CositedEven = 0,
	Midpoint = 1,
	[Obsolete("Use VkChromaLocation.CositedEven")]
	CositedEvenKhr = CositedEven,
	[Obsolete("Use VkChromaLocation.Midpoint")]
	MidpointKhr = Midpoint,
}
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlags
{
}
public enum VkDescriptorUpdateTemplateType
{
	DescriptorSet = 0,
	PushDescriptorsKhr = 1,
	[Obsolete("Use VkDescriptorUpdateTemplateType.DescriptorSet")]
	DescriptorSetKhr = DescriptorSet,
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
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11Texture")]
	D3D11TextureKhr = D3D11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11TextureKmt")]
	D3D11TextureKmtKhr = D3D11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Heap")]
	D3D12HeapKhr = D3D12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Resource")]
	D3D12ResourceKhr = D3D12Resource,
	DmaBufExt = 1 << 9,
	AndroidHardwareBufferAndroid = 1 << 10,
	HostAllocationExt = 1 << 7,
	HostMappedForeignMemoryExt = 1 << 8,
}
[Flags]
public enum VkExternalMemoryFeatureFlags
{
	DedicatedOnly = 1 << 0,
	Exportable = 1 << 1,
	Importable = 1 << 2,
	[Obsolete("Use VkExternalMemoryFeatureFlags.DedicatedOnly")]
	DedicatedOnlyKhr = DedicatedOnly,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Importable")]
	ImportableKhr = Importable,
}
[Flags]
public enum VkExternalFenceHandleTypeFlags
{
	OpaqueFileDescriptor = 1 << 0,
	OpaqueWin32 = 1 << 1,
	OpaqueWin32Kmt = 1 << 2,
	SyncFileDescriptor = 1 << 3,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKhr = SyncFileDescriptor,
}
[Flags]
public enum VkExternalFenceFeatureFlags
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalFenceFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalFenceFeatureFlags.Importable")]
	ImportableKhr = Importable,
}
[Flags]
public enum VkFenceImportFlags
{
	Temporary = 1 << 0,
	[Obsolete("Use VkFenceImportFlags.Temporary")]
	TemporaryKhr = Temporary,
}
[Flags]
public enum VkSemaphoreImportFlags
{
	Temporary = 1 << 0,
	[Obsolete("Use VkSemaphoreImportFlags.Temporary")]
	TemporaryKhr = Temporary,
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
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D12FenceKhr = D3D12Fence,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKhr = SyncFileDescriptor,
}
[Flags]
public enum VkExternalSemaphoreFeatureFlags
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Importable")]
	ImportableKhr = Importable,
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
	SRGBNonlinearKhr = 0,
	[Obsolete("Use VkColorSpaceKHR.SRGBNonlinearKhr")]
	ColorspaceSRGBNonlinearKhr = SRGBNonlinearKhr,
	DisplayP3NonlinearExt = 1000104001,
	ExtendedSRGBLinearExt = 1000104002,
	DisplayP3LinearExt = 1000104003,
	DCIP3NonlinearExt = 1000104004,
	BT709LinearExt = 1000104005,
	BT709NonlinearExt = 1000104006,
	BT2020LinearExt = 1000104007,
	HDR10ST2084Ext = 1000104008,
	DolbyVisionExt = 1000104009,
	HDR10HLGExt = 1000104010,
	AdobeRGBLinearExt = 1000104011,
	AdobeRGBNonlinearExt = 1000104012,
	PassThroughExt = 1000104013,
	ExtendedSRGBNonlinearExt = 1000104014,
	[Obsolete("Use VkColorSpaceKHR.DisplayP3LinearExt")]
	DCIP3LinearExt = DisplayP3LinearExt,
	DisplayNativeAmd = 1000213000,
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
	SplitInstanceBindRegionsKhr = 1 << 0,
	ProtectedKhr = 1 << 1,
	MutableFormatKhr = 1 << 2,
}
[Flags]
public enum VkDeviceGroupPresentModeFlagsKHR
{
	LocalKhr = 1 << 0,
	RemoteKhr = 1 << 1,
	SumKhr = 1 << 2,
	LocalMultiDeviceKhr = 1 << 3,
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
	[Obsolete("Use VkDebugReportObjectTypeEXT.DebugReportCallbackExtExt")]
	DebugReportExt = DebugReportCallbackExtExt,
	DisplayKhrExt = 29,
	DisplayModeKhrExt = 30,
	ObjectTableNvxExt = 31,
	IndirectCommandsLayoutNvxExt = 32,
	ValidationCacheExtExt = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheExtExt")]
	ValidationCacheExt = ValidationCacheExtExt,
	SamplerYCBCRConversionExt = 1000011000,
	DescriptorUpdateTemplateExt = 1000011000,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateExt")]
	DescriptorUpdateTemplateKhrExt = DescriptorUpdateTemplateExt,
	[Obsolete("Use VkDebugReportObjectTypeEXT.SamplerYCBCRConversionExt")]
	SamplerYCBCRConversionKhrExt = SamplerYCBCRConversionExt,
	AccelerationStructureNvExt = 1000165000,
}
public enum VkRasterizationOrderAMD
{
	StrictAmd = 0,
	RelaxedAmd = 1,
}
[Flags]
public enum VkPipelineRasterizationStateStreamCreateFlagsEXT
{
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
	D3D11ImageNv = 1 << 2,
	D3D11ImageKmtNv = 1 << 3,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsNV
{
	DedicatedOnlyNv = 1 << 0,
	ExportableNv = 1 << 1,
	ImportableNv = 1 << 2,
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
	CopySourceKhr = CopySource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.CopyDestination")]
	CopyDestinationKhr = CopyDestination,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericSource")]
	GenericSourceKhr = GenericSource,
	[Obsolete("Use VkPeerMemoryFeatureFlags.GenericDestination")]
	GenericDestinationKhr = GenericDestination,
}
[Obsolete("Use VkMemoryAllocateFlags")]
[Flags]
public enum VkMemoryAllocateFlagsKHR
{
	DeviceMask = 1 << 0,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKhr = DeviceMask,
	DeviceAddressKhr = 1 << 1,
	DeviceAddressCaptureReplayKhr = 1 << 2,
}
public enum VkValidationCheckEXT
{
	AllExt = 0,
	ShadersExt = 1,
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
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11Texture")]
	D3D11TextureKhr = D3D11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D11TextureKmt")]
	D3D11TextureKmtKhr = D3D11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Heap")]
	D3D12HeapKhr = D3D12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3D12Resource")]
	D3D12ResourceKhr = D3D12Resource,
	DmaBufExt = 1 << 9,
	AndroidHardwareBufferAndroid = 1 << 10,
	HostAllocationExt = 1 << 7,
	HostMappedForeignMemoryExt = 1 << 8,
}
[Obsolete("Use VkExternalMemoryFeatureFlags")]
[Flags]
public enum VkExternalMemoryFeatureFlagsKHR
{
	DedicatedOnly = 1 << 0,
	Exportable = 1 << 1,
	Importable = 1 << 2,
	[Obsolete("Use VkExternalMemoryFeatureFlags.DedicatedOnly")]
	DedicatedOnlyKhr = DedicatedOnly,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalMemoryFeatureFlags.Importable")]
	ImportableKhr = Importable,
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
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D12FenceKhr = D3D12Fence,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKhr = SyncFileDescriptor,
}
[Obsolete("Use VkExternalSemaphoreFeatureFlags")]
[Flags]
public enum VkExternalSemaphoreFeatureFlagsKHR
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalSemaphoreFeatureFlags.Importable")]
	ImportableKhr = Importable,
}
[Obsolete("Use VkSemaphoreImportFlags")]
[Flags]
public enum VkSemaphoreImportFlagsKHR
{
	Temporary = 1 << 0,
	[Obsolete("Use VkSemaphoreImportFlags.Temporary")]
	TemporaryKhr = Temporary,
}
[Flags]
public enum VkConditionalRenderingFlagsEXT
{
	InvertedExt = 1 << 0,
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
	PushDescriptorsKhr = 1,
	[Obsolete("Use VkDescriptorUpdateTemplateType.DescriptorSet")]
	DescriptorSetKhr = DescriptorSet,
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
	VBlankExt = 1 << 0,
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
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalFenceHandleTypeFlags.SyncFileDescriptor")]
	SyncFileDescriptorKhr = SyncFileDescriptor,
}
[Obsolete("Use VkExternalFenceFeatureFlags")]
[Flags]
public enum VkExternalFenceFeatureFlagsKHR
{
	Exportable = 1 << 0,
	Importable = 1 << 1,
	[Obsolete("Use VkExternalFenceFeatureFlags.Exportable")]
	ExportableKhr = Exportable,
	[Obsolete("Use VkExternalFenceFeatureFlags.Importable")]
	ImportableKhr = Importable,
}
[Obsolete("Use VkFenceImportFlags")]
[Flags]
public enum VkFenceImportFlagsKHR
{
	Temporary = 1 << 0,
	[Obsolete("Use VkFenceImportFlags.Temporary")]
	TemporaryKhr = Temporary,
}
public enum VkPerformanceCounterUnitKHR
{
	GenericKhr = 0,
	PercentageKhr = 1,
	NanosecondsKhr = 2,
	BytesKhr = 3,
	BytesPerSecondKhr = 4,
	KelvinKhr = 5,
	WattsKhr = 6,
	VoltsKhr = 7,
	AmpsKhr = 8,
	HertzKhr = 9,
	CyclesKhr = 10,
}
public enum VkPerformanceCounterScopeKHR
{
	QueryScopeCommandBufferKhr = 0,
	QueryScopeRenderPassKhr = 1,
	QueryScopeCommandKhr = 2,
}
public enum VkPerformanceCounterStorageKHR
{
	Int32Khr = 0,
	Int64Khr = 1,
	UInt32Khr = 2,
	UInt64Khr = 3,
	Float32Khr = 4,
	Float64Khr = 5,
}
[Flags]
public enum VkPerformanceCounterDescriptionFlagsKHR
{
	PerformanceImpactingKhr = 1 << 0,
	ConcurrentlyImpactedKhr = 1 << 1,
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
	AllClipPlanesKhr = AllClipPlanes,
	[Obsolete("Use VkPointClippingBehavior.UserClipPlanesOnly")]
	UserClipPlanesOnlyKhr = UserClipPlanesOnly,
}
[Obsolete("Use VkTessellationDomainOrigin")]
public enum VkTessellationDomainOriginKHR
{
	UpperLeft = 0,
	LowerLeft = 1,
	[Obsolete("Use VkTessellationDomainOrigin.UpperLeft")]
	UpperLeftKhr = UpperLeft,
	[Obsolete("Use VkTessellationDomainOrigin.LowerLeft")]
	LowerLeftKhr = LowerLeft,
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
	VerboseExt = 1 << 0,
	InfoExt = 1 << 4,
	WarningExt = 1 << 8,
	ErrorExt = 1 << 12,
}
[Flags]
public enum VkDebugUtilsMessageTypeFlagsEXT
{
	GeneralExt = 1 << 0,
	ValidationExt = 1 << 1,
	PerformanceExt = 1 << 2,
}
[Flags]
public enum VkDebugUtilsMessengerCallbackDataFlagsEXT
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
	RGBNv = 1,
	AlphaNv = 2,
	RGBANv = 3,
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
	RGBIdentityKhr = RGBIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCRIdentity")]
	YCBCRIdentityKhr = YCBCRIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR709")]
	YCBCR709Khr = YCBCR709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR601")]
	YCBCR601Khr = YCBCR601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YCBCR2020")]
	YCBCR2020Khr = YCBCR2020,
}
[Obsolete("Use VkSamplerYcbcrRange")]
public enum VkSamplerYcbcrRangeKHR
{
	ITUFull = 0,
	ITUNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ITUFull")]
	ITUFullKhr = ITUFull,
	[Obsolete("Use VkSamplerYcbcrRange.ITUNarrow")]
	ITUNarrowKhr = ITUNarrow,
}
[Obsolete("Use VkChromaLocation")]
public enum VkChromaLocationKHR
{
	CositedEven = 0,
	Midpoint = 1,
	[Obsolete("Use VkChromaLocation.CositedEven")]
	CositedEvenKhr = CositedEven,
	[Obsolete("Use VkChromaLocation.Midpoint")]
	MidpointKhr = Midpoint,
}
[Flags]
public enum VkValidationCacheCreateFlagsEXT
{
}
public enum VkValidationCacheHeaderVersionEXT
{
	OneExt = 1,
}
[Flags]
public enum VkDescriptorBindingFlagsEXT
{
	UpdateAfterBindExt = 1 << 0,
	UpdateUnusedWhilePendingExt = 1 << 1,
	PartiallyBoundExt = 1 << 2,
	VariableDescriptorCountExt = 1 << 3,
}
public enum VkShadingRatePaletteEntryNV
{
	NoInvocationsNv = 0,
	_16InvocationsPerPixelNv = 1,
	_8InvocationsPerPixelNv = 2,
	_4InvocationsPerPixelNv = 3,
	_2InvocationsPerPixelNv = 4,
	_1InvocationPerPixelNv = 5,
	_1InvocationPer2x1PixelsNv = 6,
	_1InvocationPer1x2PixelsNv = 7,
	_1InvocationPer2x2PixelsNv = 8,
	_1InvocationPer4x2PixelsNv = 9,
	_1InvocationPer2x4PixelsNv = 10,
	_1InvocationPer4x4PixelsNv = 11,
}
public enum VkCoarseSampleOrderTypeNV
{
	DefaultNv = 0,
	CustomNv = 1,
	PixelMajorNv = 2,
	SampleMajorNv = 3,
}
public enum VkAccelerationStructureTypeNV
{
	TopLevelNv = 0,
	BottomLevelNv = 1,
}
[Flags]
public enum VkBuildAccelerationStructureFlagsNV
{
	AllowUpdateNv = 1 << 0,
	AllowCompactionNv = 1 << 1,
	PreferFastTraceNv = 1 << 2,
	PreferFastBuildNv = 1 << 3,
	LowMemoryNv = 1 << 4,
}
public enum VkGeometryTypeNV
{
	TrianglesNv = 0,
	AABBsNv = 1,
}
[Flags]
public enum VkGeometryFlagsNV
{
	OpaqueNv = 1 << 0,
	NoDuplicateAnyHitInvocationNv = 1 << 1,
}
public enum VkAccelerationStructureMemoryRequirementsTypeNV
{
	ObjectNv = 0,
	BuildScratchNv = 1,
	UpdateScratchNv = 2,
}
public enum VkCopyAccelerationStructureModeNV
{
	CloneNv = 0,
	CompactNv = 1,
}
public enum VkRayTracingShaderGroupTypeNV
{
	GeneralNv = 0,
	TrianglesHitGroupNv = 1,
	ProceduralHitGroupNv = 2,
}
[Flags]
public enum VkGeometryInstanceFlagsNV
{
	TriangleCullDisableNv = 1 << 0,
	TriangleFrontCounterclockwiseNv = 1 << 1,
	ForceOpaqueNv = 1 << 2,
	ForceNoOpaqueNv = 1 << 3,
}
public enum VkQueueGlobalPriorityEXT
{
	LowExt = 128,
	MediumExt = 256,
	HighExt = 512,
	RealtimeExt = 1024,
}
[Flags]
public enum VkPipelineCompilerControlFlagsAMD
{
}
public enum VkTimeDomainEXT
{
	DeviceExt = 0,
	ClockMonotonicExt = 1,
	ClockMonotonicRawExt = 2,
	QueryPerformanceCounterExt = 3,
}
public enum VkMemoryOverallocationBehaviorAMD
{
	DefaultAmd = 0,
	AllowedAmd = 1,
	DisallowedAmd = 2,
}
[Flags]
public enum VkPipelineCreationFeedbackFlagsEXT
{
	ValidExt = 1 << 0,
	ApplicationPipelineCacheHitExt = 1 << 1,
	BasePipelineAccelerationExt = 1 << 2,
}
public enum VkDriverIdKHR
{
	AmdProprietaryKhr = 1,
	AmdOpenSourceKhr = 2,
	MesaRadvKhr = 3,
	NvidiaProprietaryKhr = 4,
	IntelProprietaryWindowsKhr = 5,
	IntelOpenSourceMesaKhr = 6,
	ImaginationProprietaryKhr = 7,
	QualcommProprietaryKhr = 8,
	ArmProprietaryKhr = 9,
	GoogleSwiftshaderKhr = 10,
	GgpProprietaryKhr = 11,
	BroadcomProprietaryKhr = 12,
}
public enum VkShaderFloatControlsIndependenceKHR
{
	_32OnlyKhr = 0,
	AllKhr = 1,
	NoneKhr = 2,
}
[Flags]
public enum VkResolveModeFlagsKHR
{
	NoneKhr = 0,
	SampleZeroKhr = 1 << 0,
	AverageKhr = 1 << 1,
	MinKhr = 1 << 2,
	MaxKhr = 1 << 3,
}
[Flags]
public enum VkSemaphoreWaitFlagsKHR
{
	AnyKhr = 1 << 0,
}
public enum VkSemaphoreTypeKHR
{
	BinaryKhr = 0,
	TimelineKhr = 1,
}
public enum VkPerformanceOverrideTypeINTEL
{
	NullHardwareIntel = 0,
	FlushGPUCachesIntel = 1,
}
public enum VkPerformanceConfigurationTypeINTEL
{
	CommandQueueMetricsDiscoveryActivatedIntel = 0,
}
public enum VkPerformanceParameterTypeINTEL
{
	HWCountersSupportedIntel = 0,
	StreamMarkerValidBitsIntel = 1,
}
public enum VkPerformanceValueTypeINTEL
{
	UInt32Intel = 0,
	UInt64Intel = 1,
	FloatIntel = 2,
	BoolIntel = 3,
	StringIntel = 4,
}
public enum VkQueryPoolSamplingModeINTEL
{
	ManualIntel = 0,
}
[Flags]
public enum VkShaderCorePropertiesFlagsAMD
{
}
[Flags]
public enum VkToolPurposeFlagsEXT
{
	ValidationExt = 1 << 0,
	ProfilingExt = 1 << 1,
	TracingExt = 1 << 2,
	AdditionalFeaturesExt = 1 << 3,
	ModifyingFeaturesExt = 1 << 4,
	DebugReportingExt = 1 << 5,
	DebugMarkersExt = 1 << 6,
}
public enum VkValidationFeatureEnableEXT
{
	GPUAssistedExt = 0,
	GPUAssistedReserveBindingSlotExt = 1,
	BestPracticesExt = 2,
}
public enum VkValidationFeatureDisableEXT
{
	AllExt = 0,
	ShadersExt = 1,
	ThreadSafetyExt = 2,
	APIParametersExt = 3,
	ObjectLifetimesExt = 4,
	CoreChecksExt = 5,
	UniqueHandlesExt = 6,
}
public enum VkComponentTypeNV
{
	Float16Nv = 0,
	Float32Nv = 1,
	Float64Nv = 2,
	SInt8Nv = 3,
	SInt16Nv = 4,
	SInt32Nv = 5,
	SInt64Nv = 6,
	UInt8Nv = 7,
	UInt16Nv = 8,
	UInt32Nv = 9,
	UInt64Nv = 10,
}
public enum VkScopeNV
{
	DeviceNv = 1,
	WorkgroupNv = 2,
	SubgroupNv = 3,
	QueueFamilyNv = 5,
}
public enum VkCoverageReductionModeNV
{
	MergeNv = 0,
	TruncateNv = 1,
}
[Flags]
public enum VkPipelineCoverageReductionStateCreateFlagsNV
{
}
public enum VkFullScreenExclusiveEXT
{
	DefaultExt = 0,
	AllowedExt = 1,
	DisallowedExt = 2,
	ApplicationControlledExt = 3,
}
[Flags]
public enum VkHeadlessSurfaceCreateFlagsEXT
{
}
public enum VkLineRasterizationModeEXT
{
	DefaultExt = 0,
	RectangularExt = 1,
	BresenhamExt = 2,
	RectangularSmoothExt = 3,
}
public enum VkPipelineExecutableStatisticFormatKHR
{
	Bool32Khr = 0,
	Int64Khr = 1,
	UInt64Khr = 2,
	Float64Khr = 3,
}
