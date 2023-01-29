// This file was generated, don't manually edit
namespace Vulkan_1_2;

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
	ErrorUnknown = -13,
	ErrorOutOfPoolMemory = -1000069000,
	ErrorInvalidExternalHandle = -1000072003,
	ErrorFragmentation = -1000161000,
	ErrorInvalidOpaqueCaptureAddress = -1000257000,
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
	[Obsolete("Use VkResult.ErrorFragmentation")]
	ErrorFragmentationEXT = ErrorFragmentation,
	ErrorNotPermittedEXT = -1000174001,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidDeviceAddressEXT = ErrorInvalidOpaqueCaptureAddress,
	ErrorFullScreenExclusiveModeLostEXT = -1000255000,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidOpaqueCaptureAddressKHR = ErrorInvalidOpaqueCaptureAddress,
	ThreadIdleKHR = 1000268000,
	ThreadDoneKHR = 1000268001,
	OperationDeferredKHR = 1000268002,
	OperationNotDeferredKHR = 1000268003,
	PipelineCompileRequiredEXT = 1000297000,
	[Obsolete("Use VkResult.PipelineCompileRequiredEXT")]
	ErrorPipelineCompileRequiredEXT = PipelineCompileRequiredEXT,
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
	PhysicalDeviceVulkan11Features = 49,
	PhysicalDeviceVulkan11Properties = 50,
	PhysicalDeviceVulkan12Features = 51,
	PhysicalDeviceVulkan12Properties = 52,
	ImageFormatListCreateInfo = 1000147000,
	AttachmentDescription2 = 1000109000,
	AttachmentReference2 = 1000109001,
	SubpassDescription2 = 1000109002,
	SubpassDependency2 = 1000109003,
	RenderPassCreateInfo2 = 1000109004,
	SubpassBeginInfo = 1000109005,
	SubpassEndInfo = 1000109006,
	PhysicalDevice8bitStorageFeatures = 1000177000,
	PhysicalDeviceDriverProperties = 1000196000,
	PhysicalDeviceShaderAtomicInt64Features = 1000180000,
	PhysicalDeviceShaderFloat16Int8Features = 1000082000,
	PhysicalDeviceFloatControlsProperties = 1000197000,
	DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
	PhysicalDeviceDescriptorIndexingFeatures = 1000161001,
	PhysicalDeviceDescriptorIndexingProperties = 1000161002,
	DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
	DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
	PhysicalDeviceDepthStencilResolveProperties = 1000199000,
	SubpassDescriptionDepthStencilResolve = 1000199001,
	PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
	ImageStencilUsageCreateInfo = 1000246000,
	PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
	SamplerReductionModeCreateInfo = 1000130001,
	PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
	PhysicalDeviceImagelessFramebufferFeatures = 1000108000,
	FramebufferAttachmentsCreateInfo = 1000108001,
	FramebufferAttachmentImageInfo = 1000108002,
	RenderPassAttachmentBeginInfo = 1000108003,
	PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
	PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
	PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
	AttachmentReferenceStencilLayout = 1000241001,
	AttachmentDescriptionStencilLayout = 1000241002,
	PhysicalDeviceHostQueryResetFeatures = 1000261000,
	PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
	PhysicalDeviceTimelineSemaphoreProperties = 1000207001,
	SemaphoreTypeCreateInfo = 1000207002,
	TimelineSemaphoreSubmitInfo = 1000207003,
	SemaphoreWaitInfo = 1000207004,
	SemaphoreSignalInfo = 1000207005,
	PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
	BufferDeviceAddressInfo = 1000244001,
	BufferOpaqueCaptureAddressCreateInfo = 1000257002,
	MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
	DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
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
	CuModuleCreateInfoNVX = 1000029000,
	CuFunctionCreateInfoNVX = 1000029001,
	CuLaunchInfoNVX = 1000029002,
	ImageViewHandleInfoNVX = 1000030000,
	ImageViewAddressPropertiesNVX = 1000030001,
	TextureLodGatherFormatPropertiesAMD = 1000041000,
	RenderingInfoKHR = 1000044000,
	RenderingAttachmentInfoKHR = 1000044001,
	PipelineRenderingCreateInfoKHR = 1000044002,
	PhysicalDeviceDynamicRenderingFeaturesKHR = 1000044003,
	CommandBufferInheritanceRenderingInfoKHR = 1000044004,
	RenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,
	RenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,
	AttachmentSampleCountInfoAMD = 1000044008,
	[Obsolete("Use VkStructureType.AttachmentSampleCountInfoAMD")]
	AttachmentSampleCountInfoNV = AttachmentSampleCountInfoAMD,
	MultiviewPerViewAttributesInfoNVX = 1000044009,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8Features")]
	PhysicalDeviceShaderFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8Features")]
	PhysicalDeviceFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,
	[Obsolete("Use VkStructureType.PhysicalDevice16bitStorageFeatures")]
	PhysicalDevice16bitStorageFeaturesKHR = PhysicalDevice16bitStorageFeatures,
	PresentRegionsKHR = 1000084000,
	[Obsolete("Use VkStructureType.DescriptorUpdateTemplateCreateInfo")]
	DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceImagelessFramebufferFeatures")]
	PhysicalDeviceImagelessFramebufferFeaturesKHR = PhysicalDeviceImagelessFramebufferFeatures,
	[Obsolete("Use VkStructureType.FramebufferAttachmentsCreateInfo")]
	FramebufferAttachmentsCreateInfoKHR = FramebufferAttachmentsCreateInfo,
	[Obsolete("Use VkStructureType.FramebufferAttachmentImageInfo")]
	FramebufferAttachmentImageInfoKHR = FramebufferAttachmentImageInfo,
	[Obsolete("Use VkStructureType.RenderPassAttachmentBeginInfo")]
	RenderPassAttachmentBeginInfoKHR = RenderPassAttachmentBeginInfo,
	[Obsolete("Use VkStructureType.AttachmentDescription2")]
	AttachmentDescription2KHR = AttachmentDescription2,
	[Obsolete("Use VkStructureType.AttachmentReference2")]
	AttachmentReference2KHR = AttachmentReference2,
	[Obsolete("Use VkStructureType.SubpassDescription2")]
	SubpassDescription2KHR = SubpassDescription2,
	[Obsolete("Use VkStructureType.SubpassDependency2")]
	SubpassDependency2KHR = SubpassDependency2,
	[Obsolete("Use VkStructureType.RenderPassCreateInfo2")]
	RenderPassCreateInfo2KHR = RenderPassCreateInfo2,
	[Obsolete("Use VkStructureType.SubpassBeginInfo")]
	SubpassBeginInfoKHR = SubpassBeginInfo,
	[Obsolete("Use VkStructureType.SubpassEndInfo")]
	SubpassEndInfoKHR = SubpassEndInfo,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointersFeatures")]
	PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointersFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointersFeaturesKHR")]
	PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointersFeaturesKHR,
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
	AndroidHardwareBufferFormatProperties2ANDROID = 1000129006,
	[Obsolete("Use VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties")]
	PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = PhysicalDeviceSamplerFilterMinmaxProperties,
	[Obsolete("Use VkStructureType.SamplerReductionModeCreateInfo")]
	SamplerReductionModeCreateInfoEXT = SamplerReductionModeCreateInfo,
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
	[Obsolete("Use VkStructureType.ImageFormatListCreateInfo")]
	ImageFormatListCreateInfoKHR = ImageFormatListCreateInfo,
	PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
	PipelineCoverageToColorStateCreateInfoNV = 1000149000,
	WriteDescriptorSetAccelerationStructureKHR = 1000150007,
	AccelerationStructureBuildGeometryInfoKHR = 1000150000,
	AccelerationStructureDeviceAddressInfoKHR = 1000150002,
	AccelerationStructureGeometryAABBsDataKHR = 1000150003,
	AccelerationStructureGeometryInstancesDataKHR = 1000150004,
	AccelerationStructureGeometryTrianglesDataKHR = 1000150005,
	AccelerationStructureGeometryKHR = 1000150006,
	AccelerationStructureVersionInfoKHR = 1000150009,
	CopyAccelerationStructureInfoKHR = 1000150010,
	CopyAccelerationStructureToMemoryInfoKHR = 1000150011,
	CopyMemoryToAccelerationStructureInfoKHR = 1000150012,
	PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,
	PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,
	AccelerationStructureCreateInfoKHR = 1000150017,
	AccelerationStructureBuildSizesInfoKHR = 1000150020,
	PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,
	PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,
	RayTracingPipelineCreateInfoKHR = 1000347015,
	RayTracingShaderGroupCreateInfoKHR = 1000347016,
	RayTracingPipelineInterfaceCreateInfoKHR = 1000347018,
	PhysicalDeviceRayQueryFeaturesKHR = 1000348013,
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
	PhysicalDeviceImageDRMFormatModifierInfoEXT = 1000158002,
	ImageDRMFormatModifierListCreateInfoEXT = 1000158003,
	ImageDRMFormatModifierExplicitCreateInfoEXT = 1000158004,
	ImageDRMFormatModifierPropertiesEXT = 1000158005,
	DRMFormatModifierPropertiesList2EXT = 1000158006,
	ValidationCacheCreateInfoEXT = 1000160000,
	ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
	[Obsolete("Use VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfo")]
	DescriptorSetLayoutBindingFlagsCreateInfoEXT = DescriptorSetLayoutBindingFlagsCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceDescriptorIndexingFeatures")]
	PhysicalDeviceDescriptorIndexingFeaturesEXT = PhysicalDeviceDescriptorIndexingFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceDescriptorIndexingProperties")]
	PhysicalDeviceDescriptorIndexingPropertiesEXT = PhysicalDeviceDescriptorIndexingProperties,
	[Obsolete("Use VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo")]
	DescriptorSetVariableDescriptorCountAllocateInfoEXT = DescriptorSetVariableDescriptorCountAllocateInfo,
	[Obsolete("Use VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport")]
	DescriptorSetVariableDescriptorCountLayoutSupportEXT = DescriptorSetVariableDescriptorCountLayoutSupport,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures")]
	PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR = PhysicalDeviceShaderSubgroupExtendedTypesFeatures,
	[Obsolete("Use VkStructureType.PhysicalDevice8bitStorageFeatures")]
	PhysicalDevice8bitStorageFeaturesKHR = PhysicalDevice8bitStorageFeatures,
	ImportMemoryHostPointerInfoEXT = 1000178000,
	MemoryHostPointerPropertiesEXT = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderAtomicInt64Features")]
	PhysicalDeviceShaderAtomicInt64FeaturesKHR = PhysicalDeviceShaderAtomicInt64Features,
	PhysicalDeviceShaderClockFeaturesKHR = 1000181000,
	PipelineCompilerControlCreateInfoAMD = 1000183000,
	CalibratedTimestampInfoEXT = 1000184000,
	PhysicalDeviceShaderCorePropertiesAMD = 1000185000,
	DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
	PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
	PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
	PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
	PipelineCreationFeedbackCreateInfoEXT = 1000192000,
	[Obsolete("Use VkStructureType.PhysicalDeviceDriverProperties")]
	PhysicalDeviceDriverPropertiesKHR = PhysicalDeviceDriverProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceFloatControlsProperties")]
	PhysicalDeviceFloatControlsPropertiesKHR = PhysicalDeviceFloatControlsProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceDepthStencilResolveProperties")]
	PhysicalDeviceDepthStencilResolvePropertiesKHR = PhysicalDeviceDepthStencilResolveProperties,
	[Obsolete("Use VkStructureType.SubpassDescriptionDepthStencilResolve")]
	SubpassDescriptionDepthStencilResolveKHR = SubpassDescriptionDepthStencilResolve,
	PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
	PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
	PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
	PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
	PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
	PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
	PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
	CheckpointDataNV = 1000206000,
	QueueFamilyCheckpointPropertiesNV = 1000206001,
	[Obsolete("Use VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures")]
	PhysicalDeviceTimelineSemaphoreFeaturesKHR = PhysicalDeviceTimelineSemaphoreFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceTimelineSemaphoreProperties")]
	PhysicalDeviceTimelineSemaphorePropertiesKHR = PhysicalDeviceTimelineSemaphoreProperties,
	[Obsolete("Use VkStructureType.SemaphoreTypeCreateInfo")]
	SemaphoreTypeCreateInfoKHR = SemaphoreTypeCreateInfo,
	[Obsolete("Use VkStructureType.TimelineSemaphoreSubmitInfo")]
	TimelineSemaphoreSubmitInfoKHR = TimelineSemaphoreSubmitInfo,
	[Obsolete("Use VkStructureType.SemaphoreWaitInfo")]
	SemaphoreWaitInfoKHR = SemaphoreWaitInfo,
	[Obsolete("Use VkStructureType.SemaphoreSignalInfo")]
	SemaphoreSignalInfoKHR = SemaphoreSignalInfo,
	PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,
	QueryPoolPerformanceQueryCreateInfoINTEL = 1000210000,
	[Obsolete("Use VkStructureType.QueryPoolPerformanceQueryCreateInfoINTEL")]
	QueryPoolCreateInfoINTEL = QueryPoolPerformanceQueryCreateInfoINTEL,
	InitializePerformanceAPIInfoINTEL = 1000210001,
	PerformanceMarkerInfoINTEL = 1000210002,
	PerformanceStreamMarkerInfoINTEL = 1000210003,
	PerformanceOverrideInfoINTEL = 1000210004,
	PerformanceConfigurationAcquireInfoINTEL = 1000210005,
	[Obsolete("Use VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures")]
	PhysicalDeviceVulkanMemoryModelFeaturesKHR = PhysicalDeviceVulkanMemoryModelFeatures,
	PhysicalDevicePCIBusInfoPropertiesEXT = 1000212000,
	DisplayNativeHDRSurfaceCapabilitiesAMD = 1000213000,
	SwapchainDisplayNativeHDRCreateInfoAMD = 1000213001,
	PhysicalDeviceShaderTerminateInvocationFeaturesKHR = 1000215000,
	PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
	PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
	RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
	[Obsolete("Use VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures")]
	PhysicalDeviceScalarBlockLayoutFeaturesEXT = PhysicalDeviceScalarBlockLayoutFeatures,
	PhysicalDeviceSubgroupSizeControlPropertiesEXT = 1000225000,
	PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = 1000225001,
	PhysicalDeviceSubgroupSizeControlFeaturesEXT = 1000225002,
	FragmentShadingRateAttachmentInfoKHR = 1000226000,
	PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,
	PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,
	PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,
	PhysicalDeviceFragmentShadingRateKHR = 1000226004,
	PhysicalDeviceShaderCoreProperties2AMD = 1000227000,
	PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,
	PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,
	PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
	PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
	MemoryPriorityAllocateInfoEXT = 1000238001,
	SurfaceProtectedCapabilitiesKHR = 1000239000,
	PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
	[Obsolete("Use VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures")]
	PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR = PhysicalDeviceSeparateDepthStencilLayoutsFeatures,
	[Obsolete("Use VkStructureType.AttachmentReferenceStencilLayout")]
	AttachmentReferenceStencilLayoutKHR = AttachmentReferenceStencilLayout,
	[Obsolete("Use VkStructureType.AttachmentDescriptionStencilLayout")]
	AttachmentDescriptionStencilLayoutKHR = AttachmentDescriptionStencilLayout,
	PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT")]
	PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfo")]
	BufferDeviceAddressInfoEXT = BufferDeviceAddressInfo,
	BufferDeviceAddressCreateInfoEXT = 1000244002,
	PhysicalDeviceToolPropertiesEXT = 1000245000,
	[Obsolete("Use VkStructureType.ImageStencilUsageCreateInfo")]
	ImageStencilUsageCreateInfoEXT = ImageStencilUsageCreateInfo,
	ValidationFeaturesEXT = 1000247000,
	PhysicalDevicePresentWaitFeaturesKHR = 1000248000,
	PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
	CooperativeMatrixPropertiesNV = 1000249001,
	PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
	PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
	PipelineCoverageReductionStateCreateInfoNV = 1000250001,
	FramebufferMixedSamplesCombinationNV = 1000250002,
	PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,
	PhysicalDeviceYCBCRImageArraysFeaturesEXT = 1000252000,
	[Obsolete("Use VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures")]
	PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR = PhysicalDeviceUniformBufferStandardLayoutFeatures,
	PhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,
	PipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,
	PhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,
	SurfaceFullScreenExclusiveInfoEXT = 1000255000,
	SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
	SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
	HeadlessSurfaceCreateInfoEXT = 1000256000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures")]
	PhysicalDeviceBufferDeviceAddressFeaturesKHR = PhysicalDeviceBufferDeviceAddressFeatures,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfo")]
	BufferDeviceAddressInfoKHR = BufferDeviceAddressInfo,
	[Obsolete("Use VkStructureType.BufferOpaqueCaptureAddressCreateInfo")]
	BufferOpaqueCaptureAddressCreateInfoKHR = BufferOpaqueCaptureAddressCreateInfo,
	[Obsolete("Use VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo")]
	MemoryOpaqueCaptureAddressAllocateInfoKHR = MemoryOpaqueCaptureAddressAllocateInfo,
	[Obsolete("Use VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo")]
	DeviceMemoryOpaqueCaptureAddressInfoKHR = DeviceMemoryOpaqueCaptureAddressInfo,
	PhysicalDeviceLineRasterizationFeaturesEXT = 1000259000,
	PipelineRasterizationLineStateCreateInfoEXT = 1000259001,
	PhysicalDeviceLineRasterizationPropertiesEXT = 1000259002,
	PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,
	[Obsolete("Use VkStructureType.PhysicalDeviceHostQueryResetFeatures")]
	PhysicalDeviceHostQueryResetFeaturesEXT = PhysicalDeviceHostQueryResetFeatures,
	PhysicalDeviceIndexTypeUInt8FeaturesEXT = 1000265000,
	PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,
	PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,
	PipelineInfoKHR = 1000269001,
	PipelineExecutablePropertiesKHR = 1000269002,
	PipelineExecutableInfoKHR = 1000269003,
	PipelineExecutableStatisticKHR = 1000269004,
	PipelineExecutableInternalRepresentationKHR = 1000269005,
	PhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,
	PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = 1000276000,
	PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
	GraphicsShaderGroupCreateInfoNV = 1000277001,
	GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
	IndirectCommandsLayoutTokenNV = 1000277003,
	IndirectCommandsLayoutCreateInfoNV = 1000277004,
	GeneratedCommandsInfoNV = 1000277005,
	GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
	PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
	PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,
	CommandBufferInheritanceViewportScissorInfoNV = 1000278001,
	PhysicalDeviceShaderIntegerDotProductFeaturesKHR = 1000280000,
	PhysicalDeviceShaderIntegerDotProductPropertiesKHR = 1000280001,
	PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
	PhysicalDeviceTexelBufferAlignmentPropertiesEXT = 1000281001,
	CommandBufferInheritanceRenderPassTransformInfoQCOM = 1000282000,
	RenderPassTransformBeginInfoQCOM = 1000282001,
	PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,
	DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,
	DeviceMemoryReportCallbackDataEXT = 1000284002,
	PhysicalDeviceRobustness2FeaturesEXT = 1000286000,
	PhysicalDeviceRobustness2PropertiesEXT = 1000286001,
	SamplerCustomBorderColorCreateInfoEXT = 1000287000,
	PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,
	PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,
	PipelineLibraryCreateInfoKHR = 1000290000,
	PresentIdKHR = 1000294000,
	PhysicalDevicePresentIdFeaturesKHR = 1000294001,
	PhysicalDevicePrivateDataFeaturesEXT = 1000295000,
	DevicePrivateDataCreateInfoEXT = 1000295001,
	PrivateDataSlotCreateInfoEXT = 1000295002,
	PhysicalDevicePipelineCreationCacheControlFeaturesEXT = 1000297000,
	PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
	DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
	MemoryBarrier2KHR = 1000314000,
	BufferMemoryBarrier2KHR = 1000314001,
	ImageMemoryBarrier2KHR = 1000314002,
	DependencyInfoKHR = 1000314003,
	SubmitInfo2KHR = 1000314004,
	SemaphoreSubmitInfoKHR = 1000314005,
	CommandBufferSubmitInfoKHR = 1000314006,
	PhysicalDeviceSynchronization2FeaturesKHR = 1000314007,
	QueueFamilyCheckpointProperties2NV = 1000314008,
	CheckpointData2NV = 1000314009,
	PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,
	PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR = 1000325000,
	PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
	PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
	PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
	AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,
	PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,
	AccelerationStructureMotionInfoNV = 1000327002,
	PhysicalDeviceYCBCR2Plane444FormatsFeaturesEXT = 1000330000,
	PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,
	PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,
	CopyCommandTransformInfoQCOM = 1000333000,
	PhysicalDeviceImageRobustnessFeaturesEXT = 1000335000,
	PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,
	CopyBufferInfo2KHR = 1000337000,
	CopyImageInfo2KHR = 1000337001,
	CopyBufferToImageInfo2KHR = 1000337002,
	CopyImageToBufferInfo2KHR = 1000337003,
	BlitImageInfo2KHR = 1000337004,
	ResolveImageInfo2KHR = 1000337005,
	BufferCopy2KHR = 1000337006,
	ImageCopy2KHR = 1000337007,
	ImageBlit2KHR = 1000337008,
	BufferImageCopy2KHR = 1000337009,
	ImageResolve2KHR = 1000337010,
	PhysicalDevice4444FormatsFeaturesEXT = 1000340000,
	PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM = 1000342000,
	PhysicalDeviceRgba10x6FormatsFeaturesEXT = 1000344000,
	PhysicalDeviceMutableDescriptorTypeFeaturesVALVE = 1000351000,
	MutableDescriptorTypeCreateInfoVALVE = 1000351002,
	PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,
	VertexInputBindingDescription2EXT = 1000352001,
	VertexInputAttributeDescription2EXT = 1000352002,
	PhysicalDeviceDRMPropertiesEXT = 1000353000,
	PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,
	PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,
	PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,
	FormatProperties3KHR = 1000360000,
	SubpassShadingPipelineCreateInfoHUAWEI = 1000369000,
	PhysicalDeviceSubpassShadingFeaturesHUAWEI = 1000369001,
	PhysicalDeviceSubpassShadingPropertiesHUAWEI = 1000369002,
	PhysicalDeviceInvocationMaskFeaturesHUAWEI = 1000370000,
	MemoryGetRemoteAddressInfoNV = 1000371000,
	PhysicalDeviceExternalMemoryRDMAFeaturesNV = 1000371001,
	PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,
	PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,
	PipelineColorWriteCreateInfoEXT = 1000381001,
	PhysicalDeviceGlobalPriorityQueryFeaturesEXT = 1000388000,
	QueueFamilyGlobalPriorityPropertiesEXT = 1000388001,
	PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,
	ImageViewMinLodCreateInfoEXT = 1000391001,
	PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,
	PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,
	PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,
	SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,
	PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,
	PhysicalDeviceMaintenance4FeaturesKHR = 1000413000,
	PhysicalDeviceMaintenance4PropertiesKHR = 1000413001,
	DeviceBufferMemoryRequirementsKHR = 1000413002,
	DeviceImageMemoryRequirementsKHR = 1000413003,
	PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM = 1000425000,
	PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM = 1000425001,
	SubpassFragmentDensityMapOffsetEndInfoQCOM = 1000425002,
	PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,
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
	ColorAttachmentReadNoncoherentEXT = 1 << 19,
	AccelerationStructureReadKHR = 1 << 21,
	AccelerationStructureWriteKHR = 1 << 22,
	[Obsolete("Use VkAccessFlags.FragmentShadingRateAttachmentReadKHR")]
	ShadingRateImageReadNV = FragmentShadingRateAttachmentReadKHR,
	[Obsolete("Use VkAccessFlags.AccelerationStructureReadKHR")]
	AccelerationStructureReadNV = AccelerationStructureReadKHR,
	[Obsolete("Use VkAccessFlags.AccelerationStructureWriteKHR")]
	AccelerationStructureWriteNV = AccelerationStructureWriteKHR,
	FragmentDensityMapReadEXT = 1 << 24,
	FragmentShadingRateAttachmentReadKHR = 1 << 23,
	CommandPreprocessReadNV = 1 << 17,
	CommandPreprocessWriteNV = 1 << 18,
	NoneKHR = 0,
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
	DepthAttachmentOptimal = 1000241000,
	DepthReadOnlyOptimal = 1000241001,
	StencilAttachmentOptimal = 1000241002,
	StencilReadOnlyOptimal = 1000241003,
	PresentSourceKHR = 1000001002,
	SharedPresentKHR = 1000111000,
	[Obsolete("Use VkImageLayout.DepthReadOnlyStencilAttachmentOptimal")]
	DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthAttachmentStencilReadOnlyOptimal")]
	DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.FragmentShadingRateAttachmentOptimalKHR")]
	ShadingRateOptimalNV = FragmentShadingRateAttachmentOptimalKHR,
	FragmentDensityMapOptimalEXT = 1000218000,
	FragmentShadingRateAttachmentOptimalKHR = 1000226003,
	[Obsolete("Use VkImageLayout.DepthAttachmentOptimal")]
	DepthAttachmentOptimalKHR = DepthAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthReadOnlyOptimal")]
	DepthReadOnlyOptimalKHR = DepthReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.StencilAttachmentOptimal")]
	StencilAttachmentOptimalKHR = StencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.StencilReadOnlyOptimal")]
	StencilReadOnlyOptimalKHR = StencilReadOnlyOptimal,
	ReadOnlyOptimalKHR = 1000314000,
	AttachmentOptimalKHR = 1000314001,
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
	NoneKHR = 0,
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
	CuModuleNVX = 1000029000,
	CuFunctionNVX = 1000029001,
	[Obsolete("Use VkObjectType.DescriptorUpdateTemplate")]
	DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,
	DebugUtilsMessengerEXT = 1000128000,
	AccelerationStructureKHR = 1000150000,
	[Obsolete("Use VkObjectType.SamplerYCBCRConversion")]
	SamplerYCBCRConversionKHR = SamplerYCBCRConversion,
	ValidationCacheEXT = 1000160000,
	AccelerationStructureNV = 1000165000,
	PerformanceConfigurationINTEL = 1000210000,
	DeferredOperationKHR = 1000268000,
	IndirectCommandsLayoutNV = 1000277000,
	PrivateDataSlotEXT = 1000295000,
}
public enum VkPipelineCacheHeaderVersion
{
	One = 1,
}
public enum VkVendorId
{
	VIV = 0x10001,
	VSI = 0x10002,
	Kazan = 0x10003,
	Codeplay = 0x10004,
	MESA = 0x10005,
	Pocl = 0x10006,
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
	G8B8R82Plane444UNormEXT = 1000330000,
	G10X6B10X6R10X62Plane444UNorm3Pack16EXT = 1000330001,
	G12X4B12X4R12X42Plane444UNorm3Pack16EXT = 1000330002,
	G16B16R162Plane444UNormEXT = 1000330003,
	A4R4G4B4UNormPack16EXT = 1000340000,
	A4B4G4R4UNormPack16EXT = 1000340001,
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
	SampledImageFilterMinmax = 1 << 16,
	SampledImageFilterCubicIMG = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags.TransferSource")]
	TransferSourceKHR = TransferSource,
	[Obsolete("Use VkFormatFeatureFlags.TransferDestination")]
	TransferDestinationKHR = TransferDestination,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterMinmax")]
	SampledImageFilterMinmaxEXT = SampledImageFilterMinmax,
	AccelerationStructureVertexBufferKHR = 1 << 29,
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
	FragmentShadingRateAttachmentKHR = 1 << 30,
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
	[Obsolete("Use VkImageUsageFlags.FragmentShadingRateAttachmentKHR")]
	ShadingRateImageNV = FragmentShadingRateAttachmentKHR,
	FragmentDensityMapEXT = 1 << 9,
	FragmentShadingRateAttachmentKHR = 1 << 8,
	InvocationMaskHUAWEI = 1 << 18,
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
	FragmentDensityMapOffsetQCOM = 1 << 15,
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
	RDMACapableNV = 1 << 8,
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
	AccelerationStructureBuildKHR = 1 << 25,
	RayTracingShaderKHR = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags.FragmentShadingRateAttachmentKHR")]
	ShadingRateImageNV = FragmentShadingRateAttachmentKHR,
	[Obsolete("Use VkPipelineStageFlags.RayTracingShaderKHR")]
	RayTracingShaderNV = RayTracingShaderKHR,
	[Obsolete("Use VkPipelineStageFlags.AccelerationStructureBuildKHR")]
	AccelerationStructureBuildNV = AccelerationStructureBuildKHR,
	TaskShaderNV = 1 << 19,
	MeshShaderNV = 1 << 20,
	FragmentDensityProcessEXT = 1 << 23,
	FragmentShadingRateAttachmentKHR = 1 << 22,
	CommandPreprocessNV = 1 << 17,
	NoneKHR = 0,
}
[Flags]
public enum VkMemoryMapFlags
{
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
	DeviceOnlyKHR = 1 << 0,
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
	AccelerationStructureCompactedSizeKHR = 1000150000,
	AccelerationStructureSerializationSizeKHR = 1000150001,
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
	DeviceAddressCaptureReplay = 1 << 4,
	[Obsolete("Use VkBufferCreateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayEXT = DeviceAddressCaptureReplay,
	[Obsolete("Use VkBufferCreateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKHR = DeviceAddressCaptureReplay,
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
	ShaderDeviceAddress = 1 << 17,
	TransformFeedbackBufferEXT = 1 << 11,
	TransformFeedbackCounterBufferEXT = 1 << 12,
	ConditionalRenderingEXT = 1 << 9,
	AccelerationStructureBuildInputReadOnlyKHR = 1 << 19,
	AccelerationStructureStorageKHR = 1 << 20,
	ShaderBindingTableKHR = 1 << 10,
	[Obsolete("Use VkBufferUsageFlags.ShaderBindingTableKHR")]
	RayTracingNV = ShaderBindingTableKHR,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddress")]
	ShaderDeviceAddressEXT = ShaderDeviceAddress,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddress")]
	ShaderDeviceAddressKHR = ShaderDeviceAddress,
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
[Flags]
public enum VkImageViewCreateFlags
{
	FragmentDensityMapDynamicEXT = 1 << 0,
	FragmentDensityMapDeferredEXT = 1 << 1,
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
	ExternallySynchronizedEXT = 1 << 0,
}
[Flags]
public enum VkPipelineCreateFlags
{
	DisableOptimization = 1 << 0,
	AllowDerivatives = 1 << 1,
	Derivative = 1 << 2,
	ViewIndexFromDeviceIndex = 1 << 3,
	DispatchBase = 1 << 4,
	RenderingFragmentShadingRateAttachmentKHR = 1 << 21,
	[Obsolete("Use VkPipelineCreateFlags.RenderingFragmentShadingRateAttachmentKHR")]
	RasterizationStateCreateFragmentShadingRateAttachmentKHR = RenderingFragmentShadingRateAttachmentKHR,
	RenderingFragmentDensityMapAttachmentEXT = 1 << 22,
	[Obsolete("Use VkPipelineCreateFlags.RenderingFragmentDensityMapAttachmentEXT")]
	RasterizationStateCreateFragmentDensityMapAttachmentEXT = RenderingFragmentDensityMapAttachmentEXT,
	[Obsolete("Use VkPipelineCreateFlags.ViewIndexFromDeviceIndex")]
	ViewIndexFromDeviceIndexKHR = ViewIndexFromDeviceIndex,
	[Obsolete("Use VkPipelineCreateFlags.DispatchBase")]
	DispatchBaseKHR = DispatchBase,
	RayTracingNoNullAnyHitShadersKHR = 1 << 14,
	RayTracingNoNullClosestHitShadersKHR = 1 << 15,
	RayTracingNoNullMissShadersKHR = 1 << 16,
	RayTracingNoNullIntersectionShadersKHR = 1 << 17,
	RayTracingSkipTrianglesKHR = 1 << 12,
	RayTracingSkipAABBsKHR = 1 << 13,
	RayTracingShaderGroupHandleCaptureReplayKHR = 1 << 19,
	DeferCompileNV = 1 << 5,
	CaptureStatisticsKHR = 1 << 6,
	CaptureInternalRepresentationsKHR = 1 << 7,
	IndirectBindableNV = 1 << 18,
	LibraryKHR = 1 << 11,
	FailOnPipelineCompileRequiredEXT = 1 << 8,
	EarlyReturnOnFailureEXT = 1 << 9,
	RayTracingAllowMotionNV = 1 << 20,
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
	RaygenKHR = 1 << 8,
	AnyHitKHR = 1 << 9,
	ClosestHitKHR = 1 << 10,
	MissKHR = 1 << 11,
	IntersectionKHR = 1 << 12,
	CallableKHR = 1 << 13,
	[Obsolete("Use VkShaderStageFlags.RaygenKHR")]
	RaygenNV = RaygenKHR,
	[Obsolete("Use VkShaderStageFlags.AnyHitKHR")]
	AnyHitNV = AnyHitKHR,
	[Obsolete("Use VkShaderStageFlags.ClosestHitKHR")]
	ClosestHitNV = ClosestHitKHR,
	[Obsolete("Use VkShaderStageFlags.MissKHR")]
	MissNV = MissKHR,
	[Obsolete("Use VkShaderStageFlags.IntersectionKHR")]
	IntersectionNV = IntersectionKHR,
	[Obsolete("Use VkShaderStageFlags.CallableKHR")]
	CallableNV = CallableKHR,
	TaskNV = 1 << 6,
	MeshNV = 1 << 7,
	SubpassShadingHUAWEI = 1 << 14,
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
	RasterizationOrderAttachmentDepthAccessARM = 1 << 0,
	RasterizationOrderAttachmentStencilAccessARM = 1 << 1,
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
	RasterizationOrderAttachmentAccessARM = 1 << 0,
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
	RayTracingPipelineStackSizeKHR = 1000347000,
	ViewportShadingRatePaletteNV = 1000164004,
	ViewportCoarseSampleOrderNV = 1000164006,
	ExclusiveScissorNV = 1000205001,
	FragmentShadingRateKHR = 1000226000,
	LineStippleEXT = 1000259000,
	CullModeEXT = 1000267000,
	FrontFaceEXT = 1000267001,
	PrimitiveTopologyEXT = 1000267002,
	ViewportWithCountEXT = 1000267003,
	ScissorWithCountEXT = 1000267004,
	VertexInputBindingStrideEXT = 1000267005,
	DepthTestEnableEXT = 1000267006,
	DepthWriteEnableEXT = 1000267007,
	DepthCompareOpEXT = 1000267008,
	DepthBoundsTestEnableEXT = 1000267009,
	StencilTestEnableEXT = 1000267010,
	StencilOpEXT = 1000267011,
	VertexInputEXT = 1000352000,
	PatchControlPointsEXT = 1000377000,
	RasterizerDiscardEnableEXT = 1000377001,
	DepthBiasEnableEXT = 1000377002,
	LogicOpEXT = 1000377003,
	PrimitiveRestartEnableEXT = 1000377004,
	ColorWriteEnableEXT = 1000381000,
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
	FloatCustomEXT = 1000287003,
	IntCustomEXT = 1000287004,
}
[Flags]
public enum VkDescriptorSetLayoutCreateFlags
{
	UpdateAfterBindPool = 1 << 1,
	PushDescriptorKHR = 1 << 0,
	[Obsolete("Use VkDescriptorSetLayoutCreateFlags.UpdateAfterBindPool")]
	UpdateAfterBindPoolEXT = UpdateAfterBindPool,
	HostOnlyPoolVALVE = 1 << 2,
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
	AccelerationStructureKHR = 1000150000,
	AccelerationStructureNV = 1000165000,
	MutableVALVE = 1000351000,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
	UpdateAfterBind = 1 << 1,
	[Obsolete("Use VkDescriptorPoolCreateFlags.UpdateAfterBind")]
	UpdateAfterBindEXT = UpdateAfterBind,
	HostOnlyVALVE = 1 << 2,
}
[Flags]
public enum VkDescriptorPoolResetFlags
{
}
[Flags]
public enum VkFramebufferCreateFlags
{
	Imageless = 1 << 0,
	[Obsolete("Use VkFramebufferCreateFlags.Imageless")]
	ImagelessKHR = Imageless,
}
[Flags]
public enum VkRenderPassCreateFlags
{
	TransformQCOM = 1 << 1,
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
	NoneEXT = 1000400000,
}
public enum VkAttachmentStoreOp
{
	Store = 0,
	DontCare = 1,
	NoneKHR = 1000044000,
	[Obsolete("Use VkAttachmentStoreOp.NoneKHR")]
	NoneQCOM = NoneKHR,
	[Obsolete("Use VkAttachmentStoreOp.NoneKHR")]
	NoneEXT = NoneKHR,
}
[Flags]
public enum VkSubpassDescriptionFlags
{
	PerViewAttributesNVX = 1 << 0,
	PerViewPositionXOnlyNVX = 1 << 1,
	FragmentRegionQCOM = 1 << 2,
	ShaderResolveQCOM = 1 << 3,
	RasterizationOrderAttachmentColorAccessARM = 1 << 4,
	RasterizationOrderAttachmentDepthAccessARM = 1 << 5,
	RasterizationOrderAttachmentStencilAccessARM = 1 << 6,
}
public enum VkPipelineBindPoint
{
	Graphics = 0,
	Compute = 1,
	RayTracingKHR = 1000347000,
	[Obsolete("Use VkPipelineBindPoint.RayTracingKHR")]
	RayTracingNV = RayTracingKHR,
	SubpassShadingHUAWEI = 1000369003,
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
	NoneKHR = 1000150000,
	[Obsolete("Use VkIndexType.NoneKHR")]
	NoneNV = NoneKHR,
	UInt8EXT = 1000265000,
}
public enum VkSubpassContents
{
	Inline = 0,
	SecondaryCommandBuffers = 1,
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
	DeviceAddress = 1 << 1,
	DeviceAddressCaptureReplay = 1 << 2,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKHR = DeviceMask,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddress")]
	DeviceAddressKHR = DeviceAddress,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKHR = DeviceAddressCaptureReplay,
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
	RDMAAddressNV = 1 << 12,
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
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D11Fence = D3D12Fence,
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
public enum VkDriverId
{
	AmdProprietary = 1,
	AmdOpenSource = 2,
	MesaRadv = 3,
	NvidiaProprietary = 4,
	IntelProprietaryWindows = 5,
	IntelOpenSourceMESA = 6,
	ImaginationProprietary = 7,
	QualcommProprietary = 8,
	ArmProprietary = 9,
	GoogleSwiftshader = 10,
	GgpProprietary = 11,
	BroadcomProprietary = 12,
	MesaLlvmpipe = 13,
	Moltenvk = 14,
	CoreaviProprietary = 15,
	JuiceProprietary = 16,
	VerisiliconProprietary = 17,
	MesaTurnip = 18,
	MesaV3dv = 19,
	MesaPanvk = 20,
	SamsungProprietary = 21,
	[Obsolete("Use VkDriverId.AmdProprietary")]
	AmdProprietaryKHR = AmdProprietary,
	[Obsolete("Use VkDriverId.AmdOpenSource")]
	AmdOpenSourceKHR = AmdOpenSource,
	[Obsolete("Use VkDriverId.MesaRadv")]
	MesaRadvKHR = MesaRadv,
	[Obsolete("Use VkDriverId.NvidiaProprietary")]
	NvidiaProprietaryKHR = NvidiaProprietary,
	[Obsolete("Use VkDriverId.IntelProprietaryWindows")]
	IntelProprietaryWindowsKHR = IntelProprietaryWindows,
	[Obsolete("Use VkDriverId.IntelOpenSourceMESA")]
	IntelOpenSourceMESAKHR = IntelOpenSourceMESA,
	[Obsolete("Use VkDriverId.ImaginationProprietary")]
	ImaginationProprietaryKHR = ImaginationProprietary,
	[Obsolete("Use VkDriverId.QualcommProprietary")]
	QualcommProprietaryKHR = QualcommProprietary,
	[Obsolete("Use VkDriverId.ArmProprietary")]
	ArmProprietaryKHR = ArmProprietary,
	[Obsolete("Use VkDriverId.GoogleSwiftshader")]
	GoogleSwiftshaderKHR = GoogleSwiftshader,
	[Obsolete("Use VkDriverId.GgpProprietary")]
	GgpProprietaryKHR = GgpProprietary,
	[Obsolete("Use VkDriverId.BroadcomProprietary")]
	BroadcomProprietaryKHR = BroadcomProprietary,
}
public enum VkShaderFloatControlsIndependence
{
	_32Only = 0,
	All = 1,
	None = 2,
	[Obsolete("Use VkShaderFloatControlsIndependence._32Only")]
	_32OnlyKHR = _32Only,
	[Obsolete("Use VkShaderFloatControlsIndependence.All")]
	AllKHR = All,
	[Obsolete("Use VkShaderFloatControlsIndependence.None")]
	NoneKHR = None,
}
[Flags]
public enum VkResolveModeFlags
{
	None = 0,
	SampleZero = 1 << 0,
	Average = 1 << 1,
	Min = 1 << 2,
	Max = 1 << 3,
	[Obsolete("Use VkResolveModeFlags.None")]
	NoneKHR = None,
	[Obsolete("Use VkResolveModeFlags.SampleZero")]
	SampleZeroKHR = SampleZero,
	[Obsolete("Use VkResolveModeFlags.Average")]
	AverageKHR = Average,
	[Obsolete("Use VkResolveModeFlags.Min")]
	MinKHR = Min,
	[Obsolete("Use VkResolveModeFlags.Max")]
	MaxKHR = Max,
}
[Flags]
public enum VkDescriptorBindingFlags
{
	UpdateAfterBind = 1 << 0,
	UpdateUnusedWhilePending = 1 << 1,
	PartiallyBound = 1 << 2,
	VariableDescriptorCount = 1 << 3,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateAfterBind")]
	UpdateAfterBindEXT = UpdateAfterBind,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateUnusedWhilePending")]
	UpdateUnusedWhilePendingEXT = UpdateUnusedWhilePending,
	[Obsolete("Use VkDescriptorBindingFlags.PartiallyBound")]
	PartiallyBoundEXT = PartiallyBound,
	[Obsolete("Use VkDescriptorBindingFlags.VariableDescriptorCount")]
	VariableDescriptorCountEXT = VariableDescriptorCount,
}
public enum VkSamplerReductionMode
{
	WeightedAverage = 0,
	Min = 1,
	Max = 2,
	[Obsolete("Use VkSamplerReductionMode.WeightedAverage")]
	WeightedAverageEXT = WeightedAverage,
	[Obsolete("Use VkSamplerReductionMode.Min")]
	MinEXT = Min,
	[Obsolete("Use VkSamplerReductionMode.Max")]
	MaxEXT = Max,
}
[Flags]
public enum VkSemaphoreWaitFlags
{
	Any = 1 << 0,
	[Obsolete("Use VkSemaphoreWaitFlags.Any")]
	AnyKHR = Any,
}
public enum VkSemaphoreType
{
	Binary = 0,
	Timeline = 1,
	[Obsolete("Use VkSemaphoreType.Binary")]
	BinaryKHR = Binary,
	[Obsolete("Use VkSemaphoreType.Timeline")]
	TimelineKHR = Timeline,
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
	ValidationCacheEXTEXT = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheEXTEXT")]
	ValidationCacheEXT = ValidationCacheEXTEXT,
	SamplerYCBCRConversionEXT = 1000011000,
	DescriptorUpdateTemplateEXT = 1000011000,
	CuModuleNVXEXT = 1000029000,
	CuFunctionNVXEXT = 1000029001,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateEXT")]
	DescriptorUpdateTemplateKHREXT = DescriptorUpdateTemplateEXT,
	AccelerationStructureKHREXT = 1000150000,
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
public enum VkRenderingFlagsKHR
{
	ContentsSecondaryCommandBuffersKHR = 1 << 0,
	SuspendingKHR = 1 << 1,
	ResumingKHR = 1 << 2,
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
	DeviceAddress = 1 << 1,
	DeviceAddressCaptureReplay = 1 << 2,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKHR = DeviceMask,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddress")]
	DeviceAddressKHR = DeviceAddress,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKHR = DeviceAddressCaptureReplay,
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
	RDMAAddressNV = 1 << 12,
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
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3D12Fence")]
	D3D11Fence = D3D12Fence,
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
	CommandBufferKHR = 0,
	RenderPassKHR = 1,
	CommandKHR = 2,
	[Obsolete("Use VkPerformanceCounterScopeKHR.CommandBufferKHR")]
	QueryScopeCommandBufferKHR = CommandBufferKHR,
	[Obsolete("Use VkPerformanceCounterScopeKHR.RenderPassKHR")]
	QueryScopeRenderPassKHR = RenderPassKHR,
	[Obsolete("Use VkPerformanceCounterScopeKHR.CommandKHR")]
	QueryScopeCommandKHR = CommandKHR,
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
[Flags]
public enum VkFormatFeatureFlags2KHR : long
{
	_2SampledImageKHR = 1 << 0,
	_2StorageImageKHR = 1 << 1,
	_2StorageImageAtomicKHR = 1 << 2,
	_2UniformTexelBufferKHR = 1 << 3,
	_2StorageTexelBufferKHR = 1 << 4,
	_2StorageTexelBufferAtomicKHR = 1 << 5,
	_2VertexBufferKHR = 1 << 6,
	_2ColorAttachmentKHR = 1 << 7,
	_2ColorAttachmentBlendKHR = 1 << 8,
	_2DepthStencilAttachmentKHR = 1 << 9,
	_2BlitSourceKHR = 1 << 10,
	_2BlitDestinationKHR = 1 << 11,
	_2SampledImageFilterLinearKHR = 1 << 12,
	_2SampledImageFilterCubicEXT = 1 << 13,
	_2TransferSourceKHR = 1 << 14,
	_2TransferDestinationKHR = 1 << 15,
	_2SampledImageFilterMinmaxKHR = 1 << 16,
	_2MidpointChromaSamplesKHR = 1 << 17,
	_2SampledImageYCBCRConversionLinearFilterKHR = 1 << 18,
	_2SampledImageYCBCRConversionSeparateReconstructionFilterKHR = 1 << 19,
	_2SampledImageYCBCRConversionChromaReconstructionExplicitKHR = 1 << 20,
	_2SampledImageYCBCRConversionChromaReconstructionExplicitForceableKHR = 1 << 21,
	_2DisjointKHR = 1 << 22,
	_2CositedChromaSamplesKHR = 1 << 23,
	_2StorageReadWithoutFormatKHR = 1 << 31,
	_2StorageWriteWithoutFormatKHR = 1 << 32,
	_2SampledImageDepthComparisonKHR = 1 << 33,
	_2AccelerationStructureVertexBufferKHR = 1 << 29,
	_2FragmentDensityMapEXT = 1 << 24,
	_2FragmentShadingRateAttachmentKHR = 1 << 30,
	_2LinearColorAttachmentNV = 1 << 38,
}
[Obsolete("Use VkSamplerReductionMode")]
public enum VkSamplerReductionModeEXT
{
	WeightedAverage = 0,
	Min = 1,
	Max = 2,
	[Obsolete("Use VkSamplerReductionMode.WeightedAverage")]
	WeightedAverageEXT = WeightedAverage,
	[Obsolete("Use VkSamplerReductionMode.Min")]
	MinEXT = Min,
	[Obsolete("Use VkSamplerReductionMode.Max")]
	MaxEXT = Max,
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
public enum VkAccelerationStructureCreateFlagsKHR
{
	DeviceAddressCaptureReplayKHR = 1 << 0,
	MotionNV = 1 << 2,
}
public enum VkAccelerationStructureTypeKHR
{
	TopLevelKHR = 0,
	BottomLevelKHR = 1,
	GenericKHR = 2,
	[Obsolete("Use VkAccelerationStructureTypeKHR.TopLevelKHR")]
	TopLevelNV = TopLevelKHR,
	[Obsolete("Use VkAccelerationStructureTypeKHR.BottomLevelKHR")]
	BottomLevelNV = BottomLevelKHR,
}
[Flags]
public enum VkBuildAccelerationStructureFlagsKHR
{
	AllowUpdateKHR = 1 << 0,
	AllowCompactionKHR = 1 << 1,
	PreferFastTraceKHR = 1 << 2,
	PreferFastBuildKHR = 1 << 3,
	LowMemoryKHR = 1 << 4,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowUpdateKHR")]
	AllowUpdateNV = AllowUpdateKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowCompactionKHR")]
	AllowCompactionNV = AllowCompactionKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKHR")]
	PreferFastTraceNV = PreferFastTraceKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKHR")]
	PreferFastBuildNV = PreferFastBuildKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.LowMemoryKHR")]
	LowMemoryNV = LowMemoryKHR,
	MotionNV = 1 << 5,
}
public enum VkBuildAccelerationStructureModeKHR
{
	BuildKHR = 0,
	UpdateKHR = 1,
}
public enum VkGeometryTypeKHR
{
	TrianglesKHR = 0,
	AABBsKHR = 1,
	InstancesKHR = 2,
	[Obsolete("Use VkGeometryTypeKHR.TrianglesKHR")]
	TrianglesNV = TrianglesKHR,
	[Obsolete("Use VkGeometryTypeKHR.AABBsKHR")]
	AABBsNV = AABBsKHR,
}
[Flags]
public enum VkGeometryFlagsKHR
{
	OpaqueKHR = 1 << 0,
	NoDuplicateAnyHitInvocationKHR = 1 << 1,
	[Obsolete("Use VkGeometryFlagsKHR.OpaqueKHR")]
	OpaqueNV = OpaqueKHR,
	[Obsolete("Use VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKHR")]
	NoDuplicateAnyHitInvocationNV = NoDuplicateAnyHitInvocationKHR,
}
public enum VkCopyAccelerationStructureModeKHR
{
	CloneKHR = 0,
	CompactKHR = 1,
	SerializeKHR = 2,
	DeserializeKHR = 3,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CloneKHR")]
	CloneNV = CloneKHR,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CompactKHR")]
	CompactNV = CompactKHR,
}
public enum VkAccelerationStructureCompatibilityKHR
{
	CompatibleKHR = 0,
	IncompatibleKHR = 1,
}
public enum VkAccelerationStructureBuildTypeKHR
{
	HostKHR = 0,
	DeviceKHR = 1,
	HostOrDeviceKHR = 2,
}
[Flags]
public enum VkGeometryInstanceFlagsKHR
{
	TriangleFacingCullDisableKHR = 1 << 0,
	TriangleFlipFacingKHR = 1 << 1,
	ForceOpaqueKHR = 1 << 2,
	ForceNoOpaqueKHR = 1 << 3,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFlipFacingKHR")]
	TriangleFrontCounterclockwiseKHR = TriangleFlipFacingKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKHR")]
	TriangleCullDisableNV = TriangleFacingCullDisableKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFrontCounterclockwiseKHR")]
	TriangleFrontCounterclockwiseNV = TriangleFrontCounterclockwiseKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceOpaqueKHR")]
	ForceOpaqueNV = ForceOpaqueKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceNoOpaqueKHR")]
	ForceNoOpaqueNV = ForceNoOpaqueKHR,
}
public enum VkRayTracingShaderGroupTypeKHR
{
	GeneralKHR = 0,
	TrianglesHitGroupKHR = 1,
	ProceduralHitGroupKHR = 2,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.GeneralKHR")]
	GeneralNV = GeneralKHR,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKHR")]
	TrianglesHitGroupNV = TrianglesHitGroupKHR,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKHR")]
	ProceduralHitGroupNV = ProceduralHitGroupKHR,
}
public enum VkShaderGroupShaderKHR
{
	GeneralKHR = 0,
	ClosestHitKHR = 1,
	AnyHitKHR = 2,
	IntersectionKHR = 3,
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
[Obsolete("Use VkDescriptorBindingFlags")]
[Flags]
public enum VkDescriptorBindingFlagsEXT
{
	UpdateAfterBind = 1 << 0,
	UpdateUnusedWhilePending = 1 << 1,
	PartiallyBound = 1 << 2,
	VariableDescriptorCount = 1 << 3,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateAfterBind")]
	UpdateAfterBindEXT = UpdateAfterBind,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateUnusedWhilePending")]
	UpdateUnusedWhilePendingEXT = UpdateUnusedWhilePending,
	[Obsolete("Use VkDescriptorBindingFlags.PartiallyBound")]
	PartiallyBoundEXT = PartiallyBound,
	[Obsolete("Use VkDescriptorBindingFlags.VariableDescriptorCount")]
	VariableDescriptorCountEXT = VariableDescriptorCount,
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
[Obsolete("Use VkAccelerationStructureTypeKHR")]
public enum VkAccelerationStructureTypeNV
{
	TopLevelKHR = 0,
	BottomLevelKHR = 1,
	GenericKHR = 2,
	[Obsolete("Use VkAccelerationStructureTypeKHR.TopLevelKHR")]
	TopLevelNV = TopLevelKHR,
	[Obsolete("Use VkAccelerationStructureTypeKHR.BottomLevelKHR")]
	BottomLevelNV = BottomLevelKHR,
}
[Obsolete("Use VkBuildAccelerationStructureFlagsKHR")]
[Flags]
public enum VkBuildAccelerationStructureFlagsNV
{
	AllowUpdateKHR = 1 << 0,
	AllowCompactionKHR = 1 << 1,
	PreferFastTraceKHR = 1 << 2,
	PreferFastBuildKHR = 1 << 3,
	LowMemoryKHR = 1 << 4,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowUpdateKHR")]
	AllowUpdateNV = AllowUpdateKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowCompactionKHR")]
	AllowCompactionNV = AllowCompactionKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKHR")]
	PreferFastTraceNV = PreferFastTraceKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKHR")]
	PreferFastBuildNV = PreferFastBuildKHR,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.LowMemoryKHR")]
	LowMemoryNV = LowMemoryKHR,
	MotionNV = 1 << 5,
}
public enum VkAccelerationStructureMemoryRequirementsTypeNV
{
	ObjectNV = 0,
	BuildScratchNV = 1,
	UpdateScratchNV = 2,
}
[Obsolete("Use VkRayTracingShaderGroupTypeKHR")]
public enum VkRayTracingShaderGroupTypeNV
{
	GeneralKHR = 0,
	TrianglesHitGroupKHR = 1,
	ProceduralHitGroupKHR = 2,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.GeneralKHR")]
	GeneralNV = GeneralKHR,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKHR")]
	TrianglesHitGroupNV = TrianglesHitGroupKHR,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKHR")]
	ProceduralHitGroupNV = ProceduralHitGroupKHR,
}
[Obsolete("Use VkGeometryTypeKHR")]
public enum VkGeometryTypeNV
{
	TrianglesKHR = 0,
	AABBsKHR = 1,
	InstancesKHR = 2,
	[Obsolete("Use VkGeometryTypeKHR.TrianglesKHR")]
	TrianglesNV = TrianglesKHR,
	[Obsolete("Use VkGeometryTypeKHR.AABBsKHR")]
	AABBsNV = AABBsKHR,
}
[Obsolete("Use VkGeometryFlagsKHR")]
[Flags]
public enum VkGeometryFlagsNV
{
	OpaqueKHR = 1 << 0,
	NoDuplicateAnyHitInvocationKHR = 1 << 1,
	[Obsolete("Use VkGeometryFlagsKHR.OpaqueKHR")]
	OpaqueNV = OpaqueKHR,
	[Obsolete("Use VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKHR")]
	NoDuplicateAnyHitInvocationNV = NoDuplicateAnyHitInvocationKHR,
}
[Obsolete("Use VkGeometryInstanceFlagsKHR")]
[Flags]
public enum VkGeometryInstanceFlagsNV
{
	TriangleFacingCullDisableKHR = 1 << 0,
	TriangleFlipFacingKHR = 1 << 1,
	ForceOpaqueKHR = 1 << 2,
	ForceNoOpaqueKHR = 1 << 3,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFlipFacingKHR")]
	TriangleFrontCounterclockwiseKHR = TriangleFlipFacingKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKHR")]
	TriangleCullDisableNV = TriangleFacingCullDisableKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFrontCounterclockwiseKHR")]
	TriangleFrontCounterclockwiseNV = TriangleFrontCounterclockwiseKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceOpaqueKHR")]
	ForceOpaqueNV = ForceOpaqueKHR,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceNoOpaqueKHR")]
	ForceNoOpaqueNV = ForceNoOpaqueKHR,
}
[Obsolete("Use VkCopyAccelerationStructureModeKHR")]
public enum VkCopyAccelerationStructureModeNV
{
	CloneKHR = 0,
	CompactKHR = 1,
	SerializeKHR = 2,
	DeserializeKHR = 3,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CloneKHR")]
	CloneNV = CloneKHR,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CompactKHR")]
	CompactNV = CompactKHR,
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
[Obsolete("Use VkDriverId")]
public enum VkDriverIdKHR
{
	AmdProprietary = 1,
	AmdOpenSource = 2,
	MesaRadv = 3,
	NvidiaProprietary = 4,
	IntelProprietaryWindows = 5,
	IntelOpenSourceMESA = 6,
	ImaginationProprietary = 7,
	QualcommProprietary = 8,
	ArmProprietary = 9,
	GoogleSwiftshader = 10,
	GgpProprietary = 11,
	BroadcomProprietary = 12,
	MesaLlvmpipe = 13,
	Moltenvk = 14,
	CoreaviProprietary = 15,
	JuiceProprietary = 16,
	VerisiliconProprietary = 17,
	MesaTurnip = 18,
	MesaV3dv = 19,
	MesaPanvk = 20,
	SamsungProprietary = 21,
	[Obsolete("Use VkDriverId.AmdProprietary")]
	AmdProprietaryKHR = AmdProprietary,
	[Obsolete("Use VkDriverId.AmdOpenSource")]
	AmdOpenSourceKHR = AmdOpenSource,
	[Obsolete("Use VkDriverId.MesaRadv")]
	MesaRadvKHR = MesaRadv,
	[Obsolete("Use VkDriverId.NvidiaProprietary")]
	NvidiaProprietaryKHR = NvidiaProprietary,
	[Obsolete("Use VkDriverId.IntelProprietaryWindows")]
	IntelProprietaryWindowsKHR = IntelProprietaryWindows,
	[Obsolete("Use VkDriverId.IntelOpenSourceMESA")]
	IntelOpenSourceMESAKHR = IntelOpenSourceMESA,
	[Obsolete("Use VkDriverId.ImaginationProprietary")]
	ImaginationProprietaryKHR = ImaginationProprietary,
	[Obsolete("Use VkDriverId.QualcommProprietary")]
	QualcommProprietaryKHR = QualcommProprietary,
	[Obsolete("Use VkDriverId.ArmProprietary")]
	ArmProprietaryKHR = ArmProprietary,
	[Obsolete("Use VkDriverId.GoogleSwiftshader")]
	GoogleSwiftshaderKHR = GoogleSwiftshader,
	[Obsolete("Use VkDriverId.GgpProprietary")]
	GgpProprietaryKHR = GgpProprietary,
	[Obsolete("Use VkDriverId.BroadcomProprietary")]
	BroadcomProprietaryKHR = BroadcomProprietary,
}
[Obsolete("Use VkShaderFloatControlsIndependence")]
public enum VkShaderFloatControlsIndependenceKHR
{
	_32Only = 0,
	All = 1,
	None = 2,
	[Obsolete("Use VkShaderFloatControlsIndependence._32Only")]
	_32OnlyKHR = _32Only,
	[Obsolete("Use VkShaderFloatControlsIndependence.All")]
	AllKHR = All,
	[Obsolete("Use VkShaderFloatControlsIndependence.None")]
	NoneKHR = None,
}
[Obsolete("Use VkResolveModeFlags")]
[Flags]
public enum VkResolveModeFlagsKHR
{
	None = 0,
	SampleZero = 1 << 0,
	Average = 1 << 1,
	Min = 1 << 2,
	Max = 1 << 3,
	[Obsolete("Use VkResolveModeFlags.None")]
	NoneKHR = None,
	[Obsolete("Use VkResolveModeFlags.SampleZero")]
	SampleZeroKHR = SampleZero,
	[Obsolete("Use VkResolveModeFlags.Average")]
	AverageKHR = Average,
	[Obsolete("Use VkResolveModeFlags.Min")]
	MinKHR = Min,
	[Obsolete("Use VkResolveModeFlags.Max")]
	MaxKHR = Max,
}
[Obsolete("Use VkSemaphoreType")]
public enum VkSemaphoreTypeKHR
{
	Binary = 0,
	Timeline = 1,
	[Obsolete("Use VkSemaphoreType.Binary")]
	BinaryKHR = Binary,
	[Obsolete("Use VkSemaphoreType.Timeline")]
	TimelineKHR = Timeline,
}
[Obsolete("Use VkSemaphoreWaitFlags")]
[Flags]
public enum VkSemaphoreWaitFlagsKHR
{
	Any = 1 << 0,
	[Obsolete("Use VkSemaphoreWaitFlags.Any")]
	AnyKHR = Any,
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
public enum VkFragmentShadingRateCombinerOpKHR
{
	KeepKHR = 0,
	ReplaceKHR = 1,
	MinKHR = 2,
	MaxKHR = 3,
	MulKHR = 4,
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
	DebugPrintfEXT = 3,
	SynchronizationValidationEXT = 4,
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
	ShaderValidationCacheEXT = 7,
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
public enum VkProvokingVertexModeEXT
{
	FirstVertexEXT = 0,
	LastVertexEXT = 1,
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
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagsNV
{
	ExplicitPreprocessNV = 1 << 0,
	IndexedSequencesNV = 1 << 1,
	UnorderedSequencesNV = 1 << 2,
}
public enum VkIndirectCommandsTokenTypeNV
{
	ShaderGroupNV = 0,
	StateFlagsNV = 1,
	IndexBufferNV = 2,
	VertexBufferNV = 3,
	PushConstantNV = 4,
	DrawIndexedNV = 5,
	DrawNV = 6,
	DrawTasksNV = 7,
}
[Flags]
public enum VkIndirectStateFlagsNV
{
	FrontfaceNV = 1 << 0,
}
[Flags]
public enum VkDeviceMemoryReportFlagsEXT
{
}
public enum VkDeviceMemoryReportEventTypeEXT
{
	AllocateEXT = 0,
	FreeEXT = 1,
	ImportEXT = 2,
	UnimportEXT = 3,
	AllocationFailedEXT = 4,
}
[Flags]
public enum VkPrivateDataSlotCreateFlagsEXT
{
}
[Flags]
public enum VkDeviceDiagnosticsConfigFlagsNV
{
	EnableShaderDebugInfoNV = 1 << 0,
	EnableResourceTrackingNV = 1 << 1,
	EnableAutomaticCheckpointsNV = 1 << 2,
}
[Flags]
public enum VkPipelineStageFlags2KHR : long
{
	_2NoneKHR = 0,
	_2TopOfPipeKHR = 1 << 0,
	_2DrawIndirectKHR = 1 << 1,
	_2VertexInputKHR = 1 << 2,
	_2VertexShaderKHR = 1 << 3,
	_2TessellationControlShaderKHR = 1 << 4,
	_2TessellationEvaluationShaderKHR = 1 << 5,
	_2GeometryShaderKHR = 1 << 6,
	_2FragmentShaderKHR = 1 << 7,
	_2EarlyFragmentTestsKHR = 1 << 8,
	_2LateFragmentTestsKHR = 1 << 9,
	_2ColorAttachmentOutputKHR = 1 << 10,
	_2ComputeShaderKHR = 1 << 11,
	_2AllTransferKHR = 1 << 12,
	[Obsolete("Use VkPipelineStageFlags2KHR._2AllTransferKHR")]
	_2TransferKHR = _2AllTransferKHR,
	_2BottomOfPipeKHR = 1 << 13,
	_2HostKHR = 1 << 14,
	_2AllGraphicsKHR = 1 << 15,
	_2AllCommandsKHR = 1 << 16,
	_2CopyKHR = 1 << 32,
	_2ResolveKHR = 1 << 33,
	_2BlitKHR = 1 << 34,
	_2ClearKHR = 1 << 35,
	_2IndexInputKHR = 1 << 36,
	_2VertexAttributeInputKHR = 1 << 37,
	_2PreRasterizationShadersKHR = 1 << 38,
	_2TransformFeedbackEXT = 1 << 24,
	_2ConditionalRenderingEXT = 1 << 18,
	_2CommandPreprocessNV = 1 << 17,
	_2FragmentShadingRateAttachmentKHR = 1 << 22,
	[Obsolete("Use VkPipelineStageFlags2KHR._2FragmentShadingRateAttachmentKHR")]
	_2ShadingRateImageNV = _2FragmentShadingRateAttachmentKHR,
	_2AccelerationStructureBuildKHR = 1 << 25,
	_2RayTracingShaderKHR = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags2KHR._2RayTracingShaderKHR")]
	_2RayTracingShaderNV = _2RayTracingShaderKHR,
	[Obsolete("Use VkPipelineStageFlags2KHR._2AccelerationStructureBuildKHR")]
	_2AccelerationStructureBuildNV = _2AccelerationStructureBuildKHR,
	_2FragmentDensityProcessEXT = 1 << 23,
	_2TaskShaderNV = 1 << 19,
	_2MeshShaderNV = 1 << 20,
	_2SubpassShadingHUAWEI = 1 << 39,
	_2InvocationMaskHUAWEI = 1 << 40,
}
[Flags]
public enum VkAccessFlags2KHR : long
{
	_2NoneKHR = 0,
	_2IndirectCommandReadKHR = 1 << 0,
	_2IndexReadKHR = 1 << 1,
	_2VertexAttributeReadKHR = 1 << 2,
	_2UniformReadKHR = 1 << 3,
	_2InputAttachmentReadKHR = 1 << 4,
	_2ShaderReadKHR = 1 << 5,
	_2ShaderWriteKHR = 1 << 6,
	_2ColorAttachmentReadKHR = 1 << 7,
	_2ColorAttachmentWriteKHR = 1 << 8,
	_2DepthStencilAttachmentReadKHR = 1 << 9,
	_2DepthStencilAttachmentWriteKHR = 1 << 10,
	_2TransferReadKHR = 1 << 11,
	_2TransferWriteKHR = 1 << 12,
	_2HostReadKHR = 1 << 13,
	_2HostWriteKHR = 1 << 14,
	_2MemoryReadKHR = 1 << 15,
	_2MemoryWriteKHR = 1 << 16,
	_2ShaderSampledReadKHR = 1 << 32,
	_2ShaderStorageReadKHR = 1 << 33,
	_2ShaderStorageWriteKHR = 1 << 34,
	_2TransformFeedbackWriteEXT = 1 << 25,
	_2TransformFeedbackCounterReadEXT = 1 << 26,
	_2TransformFeedbackCounterWriteEXT = 1 << 27,
	_2ConditionalRenderingReadEXT = 1 << 20,
	_2CommandPreprocessReadNV = 1 << 17,
	_2CommandPreprocessWriteNV = 1 << 18,
	_2FragmentShadingRateAttachmentReadKHR = 1 << 23,
	[Obsolete("Use VkAccessFlags2KHR._2FragmentShadingRateAttachmentReadKHR")]
	_2ShadingRateImageReadNV = _2FragmentShadingRateAttachmentReadKHR,
	_2AccelerationStructureReadKHR = 1 << 21,
	_2AccelerationStructureWriteKHR = 1 << 22,
	[Obsolete("Use VkAccessFlags2KHR._2AccelerationStructureReadKHR")]
	_2AccelerationStructureReadNV = _2AccelerationStructureReadKHR,
	[Obsolete("Use VkAccessFlags2KHR._2AccelerationStructureWriteKHR")]
	_2AccelerationStructureWriteNV = _2AccelerationStructureWriteKHR,
	_2FragmentDensityMapReadEXT = 1 << 24,
	_2ColorAttachmentReadNoncoherentEXT = 1 << 19,
	_2InvocationMaskReadHUAWEI = 1 << 39,
}
[Flags]
public enum VkSubmitFlagsKHR
{
	ProtectedKHR = 1 << 0,
}
public enum VkFragmentShadingRateNV
{
	_1InvocationPerPixelNV = 0,
	_1InvocationPer1x2PixelsNV = 1,
	_1InvocationPer2x1PixelsNV = 4,
	_1InvocationPer2x2PixelsNV = 5,
	_1InvocationPer2x4PixelsNV = 6,
	_1InvocationPer4x2PixelsNV = 9,
	_1InvocationPer4x4PixelsNV = 10,
	_2InvocationsPerPixelNV = 11,
	_4InvocationsPerPixelNV = 12,
	_8InvocationsPerPixelNV = 13,
	_16InvocationsPerPixelNV = 14,
	NoInvocationsNV = 15,
}
public enum VkFragmentShadingRateTypeNV
{
	FragmentSizeNV = 0,
	EnumsNV = 1,
}
[Flags]
public enum VkAccelerationStructureMotionInfoFlagsNV
{
}
public enum VkAccelerationStructureMotionInstanceTypeNV
{
	StaticNV = 0,
	MatrixMotionNV = 1,
	SrtMotionNV = 2,
}
[Flags]
public enum VkAccelerationStructureMotionInstanceFlagsNV
{
}
