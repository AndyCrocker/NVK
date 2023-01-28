// This file was generated, don't manually edit
namespace Vulkan_1_3;

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
	PipelineCompileRequired = 1000297000,
	ErrorSurfaceLostKHR = -1000000000,
	ErrorNativeWindowInUseKHR = -1000000001,
	SuboptimalKHR = 1000001003,
	ErrorOutOfDateKHR = -1000001004,
	ErrorIncompatibleDisplayKHR = -1000003001,
	ErrorValidationFailedEXT = -1000011001,
	ErrorInvalidShaderNV = -1000012000,
	ErrorImageUsageNotSupportedKHR = -1000023000,
	ErrorVideoPictureLayoutNotSupportedKHR = -1000023001,
	ErrorVideoProfileOperationNotSupportedKHR = -1000023002,
	ErrorVideoProfileFormatNotSupportedKHR = -1000023003,
	ErrorVideoProfileCodecNotSupportedKHR = -1000023004,
	ErrorVideoStdVersionNotSupportedKHR = -1000023005,
	[Obsolete("Use VkResult.ErrorOutOfPoolMemory")]
	ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,
	[Obsolete("Use VkResult.ErrorInvalidExternalHandle")]
	ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,
	ErrorInvalidDRMFormatModifierPlaneLayoutEXT = -1000158000,
	[Obsolete("Use VkResult.ErrorFragmentation")]
	ErrorFragmentationEXT = ErrorFragmentation,
	[Obsolete("Use VkResult.ErrorNotPermittedKHR")]
	ErrorNotPermittedEXT = ErrorNotPermittedKHR,
	ErrorNotPermittedKHR = -1000188001,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidDeviceAddressEXT = ErrorInvalidOpaqueCaptureAddress,
	ErrorFullScreenExclusiveModeLostEXT = -1000255000,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidOpaqueCaptureAddressKHR = ErrorInvalidOpaqueCaptureAddress,
	ThreadIdleKHR = 1000268000,
	ThreadDoneKHR = 1000268001,
	OperationDeferredKHR = 1000268002,
	OperationNotDeferredKHR = 1000268003,
	[Obsolete("Use VkResult.PipelineCompileRequired")]
	PipelineCompileRequiredEXT = PipelineCompileRequired,
	[Obsolete("Use VkResult.PipelineCompileRequired")]
	ErrorPipelineCompileRequiredEXT = PipelineCompileRequired,
	ErrorCompressionExhaustedEXT = -1000338000,
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
	PhysicalDeviceVulkan13Features = 53,
	PhysicalDeviceVulkan13Properties = 54,
	PipelineCreationFeedbackCreateInfo = 1000192000,
	PhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,
	PhysicalDeviceToolProperties = 1000245000,
	PhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,
	PhysicalDevicePrivateDataFeatures = 1000295000,
	DevicePrivateDataCreateInfo = 1000295001,
	PrivateDataSlotCreateInfo = 1000295002,
	PhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,
	MemoryBarrier2 = 1000314000,
	BufferMemoryBarrier2 = 1000314001,
	ImageMemoryBarrier2 = 1000314002,
	DependencyInfo = 1000314003,
	SubmitInfo2 = 1000314004,
	SemaphoreSubmitInfo = 1000314005,
	CommandBufferSubmitInfo = 1000314006,
	PhysicalDeviceSynchronization2Features = 1000314007,
	PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,
	PhysicalDeviceImageRobustnessFeatures = 1000335000,
	CopyBufferInfo2 = 1000337000,
	CopyImageInfo2 = 1000337001,
	CopyBufferToImageInfo2 = 1000337002,
	CopyImageToBufferInfo2 = 1000337003,
	BlitImageInfo2 = 1000337004,
	ResolveImageInfo2 = 1000337005,
	BufferCopy2 = 1000337006,
	ImageCopy2 = 1000337007,
	ImageBlit2 = 1000337008,
	BufferImageCopy2 = 1000337009,
	ImageResolve2 = 1000337010,
	PhysicalDeviceSubgroupSizeControlProperties = 1000225000,
	PipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,
	PhysicalDeviceSubgroupSizeControlFeatures = 1000225002,
	PhysicalDeviceInlineUniformBlockFeatures = 1000138000,
	PhysicalDeviceInlineUniformBlockProperties = 1000138001,
	WriteDescriptorSetInlineUniformBlock = 1000138002,
	DescriptorPoolInlineUniformBlockCreateInfo = 1000138003,
	PhysicalDeviceTextureCompressionASTCHDRFeatures = 1000066000,
	RenderingInfo = 1000044000,
	RenderingAttachmentInfo = 1000044001,
	PipelineRenderingCreateInfo = 1000044002,
	PhysicalDeviceDynamicRenderingFeatures = 1000044003,
	CommandBufferInheritanceRenderingInfo = 1000044004,
	PhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,
	PhysicalDeviceShaderIntegerDotProductProperties = 1000280001,
	PhysicalDeviceTexelBufferAlignmentProperties = 1000281001,
	FormatProperties3 = 1000360000,
	PhysicalDeviceMaintenance4Features = 1000413000,
	PhysicalDeviceMaintenance4Properties = 1000413001,
	DeviceBufferMemoryRequirements = 1000413002,
	DeviceImageMemoryRequirements = 1000413003,
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
	VideoProfileInfoKHR = 1000023000,
	VideoCapabilitiesKHR = 1000023001,
	VideoPictureResourceInfoKHR = 1000023002,
	VideoSessionMemoryRequirementsKHR = 1000023003,
	BindVideoSessionMemoryInfoKHR = 1000023004,
	VideoSessionCreateInfoKHR = 1000023005,
	VideoSessionParametersCreateInfoKHR = 1000023006,
	VideoSessionParametersUpdateInfoKHR = 1000023007,
	VideoBeginCodingInfoKHR = 1000023008,
	VideoEndCodingInfoKHR = 1000023009,
	VideoCodingControlInfoKHR = 1000023010,
	VideoReferenceSlotInfoKHR = 1000023011,
	QueueFamilyVideoPropertiesKHR = 1000023012,
	VideoProfileListInfoKHR = 1000023013,
	PhysicalDeviceVideoFormatInfoKHR = 1000023014,
	VideoFormatPropertiesKHR = 1000023015,
	QueueFamilyQueryResultStatusPropertiesKHR = 1000023016,
	VideoDecodeInfoKHR = 1000024000,
	VideoDecodeCapabilitiesKHR = 1000024001,
	VideoDecodeUsageInfoKHR = 1000024002,
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
	VideoDecodeH264CapabilitiesKHR = 1000040000,
	VideoDecodeH264PictureInfoKHR = 1000040001,
	VideoDecodeH264ProfileInfoKHR = 1000040003,
	VideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,
	VideoDecodeH264SessionParametersAddInfoKHR = 1000040005,
	VideoDecodeH264DPBSlotInfoKHR = 1000040006,
	TextureLodGatherFormatPropertiesAMD = 1000041000,
	[Obsolete("Use VkStructureType.RenderingInfo")]
	RenderingInfoKHR = RenderingInfo,
	[Obsolete("Use VkStructureType.RenderingAttachmentInfo")]
	RenderingAttachmentInfoKHR = RenderingAttachmentInfo,
	[Obsolete("Use VkStructureType.PipelineRenderingCreateInfo")]
	PipelineRenderingCreateInfoKHR = PipelineRenderingCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceDynamicRenderingFeatures")]
	PhysicalDeviceDynamicRenderingFeaturesKHR = PhysicalDeviceDynamicRenderingFeatures,
	[Obsolete("Use VkStructureType.CommandBufferInheritanceRenderingInfo")]
	CommandBufferInheritanceRenderingInfoKHR = CommandBufferInheritanceRenderingInfo,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceTextureCompressionASTCHDRFeatures")]
	PhysicalDeviceTextureCompressionASTCHDRFeaturesEXT = PhysicalDeviceTextureCompressionASTCHDRFeatures,
	ImageViewASTCDecodeModeEXT = 1000067000,
	PhysicalDeviceASTCDecodeFeaturesEXT = 1000067001,
	PipelineRobustnessCreateInfoEXT = 1000068000,
	PhysicalDevicePipelineRobustnessFeaturesEXT = 1000068001,
	PhysicalDevicePipelineRobustnessPropertiesEXT = 1000068002,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceInlineUniformBlockFeatures")]
	PhysicalDeviceInlineUniformBlockFeaturesEXT = PhysicalDeviceInlineUniformBlockFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceInlineUniformBlockProperties")]
	PhysicalDeviceInlineUniformBlockPropertiesEXT = PhysicalDeviceInlineUniformBlockProperties,
	[Obsolete("Use VkStructureType.WriteDescriptorSetInlineUniformBlock")]
	WriteDescriptorSetInlineUniformBlockEXT = WriteDescriptorSetInlineUniformBlock,
	[Obsolete("Use VkStructureType.DescriptorPoolInlineUniformBlockCreateInfo")]
	DescriptorPoolInlineUniformBlockCreateInfoEXT = DescriptorPoolInlineUniformBlockCreateInfo,
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
	[Obsolete("Use VkStructureType.DeviceQueueGlobalPriorityCreateInfoKHR")]
	DeviceQueueGlobalPriorityCreateInfoEXT = DeviceQueueGlobalPriorityCreateInfoKHR,
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
	VideoDecodeH265CapabilitiesKHR = 1000187000,
	VideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,
	VideoDecodeH265SessionParametersAddInfoKHR = 1000187002,
	VideoDecodeH265ProfileInfoKHR = 1000187003,
	VideoDecodeH265PictureInfoKHR = 1000187004,
	VideoDecodeH265DPBSlotInfoKHR = 1000187005,
	DeviceQueueGlobalPriorityCreateInfoKHR = 1000188000,
	PhysicalDeviceGlobalPriorityQueryFeaturesKHR = 1000188000,
	QueueFamilyGlobalPriorityPropertiesKHR = 1000188001,
	DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
	PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
	PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
	PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
	[Obsolete("Use VkStructureType.PipelineCreationFeedbackCreateInfo")]
	PipelineCreationFeedbackCreateInfoEXT = PipelineCreationFeedbackCreateInfo,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesKHR")]
	PhysicalDeviceFragmentShaderBarycentricFeaturesNV = PhysicalDeviceFragmentShaderBarycentricFeaturesKHR,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderTerminateInvocationFeatures")]
	PhysicalDeviceShaderTerminateInvocationFeaturesKHR = PhysicalDeviceShaderTerminateInvocationFeatures,
	PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
	PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
	RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
	[Obsolete("Use VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures")]
	PhysicalDeviceScalarBlockLayoutFeaturesEXT = PhysicalDeviceScalarBlockLayoutFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceSubgroupSizeControlProperties")]
	PhysicalDeviceSubgroupSizeControlPropertiesEXT = PhysicalDeviceSubgroupSizeControlProperties,
	[Obsolete("Use VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfo")]
	PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = PipelineShaderStageRequiredSubgroupSizeCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSubgroupSizeControlFeatures")]
	PhysicalDeviceSubgroupSizeControlFeaturesEXT = PhysicalDeviceSubgroupSizeControlFeatures,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceToolProperties")]
	PhysicalDeviceToolPropertiesEXT = PhysicalDeviceToolProperties,
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
	SurfacePresentModeEXT = 1000274000,
	SurfacePresentScalingCapabilitiesEXT = 1000274001,
	SurfacePresentModeCompatibilityEXT = 1000274002,
	PhysicalDeviceSwapchainMaintenance1FeaturesEXT = 1000275000,
	SwapchainPresentFenceInfoEXT = 1000275001,
	SwapchainPresentModesCreateInfoEXT = 1000275002,
	SwapchainPresentModeInfoEXT = 1000275003,
	SwapchainPresentScalingCreateInfoEXT = 1000275004,
	ReleaseSwapchainImagesInfoEXT = 1000275005,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeatures")]
	PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = PhysicalDeviceShaderDemoteToHelperInvocationFeatures,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderIntegerDotProductFeatures")]
	PhysicalDeviceShaderIntegerDotProductFeaturesKHR = PhysicalDeviceShaderIntegerDotProductFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderIntegerDotProductProperties")]
	PhysicalDeviceShaderIntegerDotProductPropertiesKHR = PhysicalDeviceShaderIntegerDotProductProperties,
	PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
	[Obsolete("Use VkStructureType.PhysicalDeviceTexelBufferAlignmentProperties")]
	PhysicalDeviceTexelBufferAlignmentPropertiesEXT = PhysicalDeviceTexelBufferAlignmentProperties,
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
	PhysicalDevicePresentBarrierFeaturesNV = 1000292000,
	SurfaceCapabilitiesPresentBarrierNV = 1000292001,
	SwapchainPresentBarrierCreateInfoNV = 1000292002,
	PresentIdKHR = 1000294000,
	PhysicalDevicePresentIdFeaturesKHR = 1000294001,
	[Obsolete("Use VkStructureType.PhysicalDevicePrivateDataFeatures")]
	PhysicalDevicePrivateDataFeaturesEXT = PhysicalDevicePrivateDataFeatures,
	[Obsolete("Use VkStructureType.DevicePrivateDataCreateInfo")]
	DevicePrivateDataCreateInfoEXT = DevicePrivateDataCreateInfo,
	[Obsolete("Use VkStructureType.PrivateDataSlotCreateInfo")]
	PrivateDataSlotCreateInfoEXT = PrivateDataSlotCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDevicePipelineCreationCacheControlFeatures")]
	PhysicalDevicePipelineCreationCacheControlFeaturesEXT = PhysicalDevicePipelineCreationCacheControlFeatures,
	PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
	DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
	[Obsolete("Use VkStructureType.MemoryBarrier2")]
	MemoryBarrier2KHR = MemoryBarrier2,
	[Obsolete("Use VkStructureType.BufferMemoryBarrier2")]
	BufferMemoryBarrier2KHR = BufferMemoryBarrier2,
	[Obsolete("Use VkStructureType.ImageMemoryBarrier2")]
	ImageMemoryBarrier2KHR = ImageMemoryBarrier2,
	[Obsolete("Use VkStructureType.DependencyInfo")]
	DependencyInfoKHR = DependencyInfo,
	[Obsolete("Use VkStructureType.SubmitInfo2")]
	SubmitInfo2KHR = SubmitInfo2,
	[Obsolete("Use VkStructureType.SemaphoreSubmitInfo")]
	SemaphoreSubmitInfoKHR = SemaphoreSubmitInfo,
	[Obsolete("Use VkStructureType.CommandBufferSubmitInfo")]
	CommandBufferSubmitInfoKHR = CommandBufferSubmitInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSynchronization2Features")]
	PhysicalDeviceSynchronization2FeaturesKHR = PhysicalDeviceSynchronization2Features,
	QueueFamilyCheckpointProperties2NV = 1000314008,
	CheckpointData2NV = 1000314009,
	PhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,
	PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,
	PhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,
	DescriptorAddressInfoEXT = 1000316003,
	DescriptorGetInfoEXT = 1000316004,
	BufferCaptureDescriptorDataInfoEXT = 1000316005,
	ImageCaptureDescriptorDataInfoEXT = 1000316006,
	ImageViewCaptureDescriptorDataInfoEXT = 1000316007,
	SamplerCaptureDescriptorDataInfoEXT = 1000316008,
	OpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,
	DescriptorBufferBindingInfoEXT = 1000316011,
	DescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,
	AccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,
	PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,
	PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,
	GraphicsPipelineLibraryCreateInfoEXT = 1000320002,
	PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,
	PhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000322000,
	PhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,
	PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,
	[Obsolete("Use VkStructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures")]
	PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR = PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,
	PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
	PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
	PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
	AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,
	PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,
	AccelerationStructureMotionInfoNV = 1000327002,
	PhysicalDeviceMeshShaderFeaturesEXT = 1000328000,
	PhysicalDeviceMeshShaderPropertiesEXT = 1000328001,
	PhysicalDeviceYCBCR2Plane444FormatsFeaturesEXT = 1000330000,
	PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,
	PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,
	CopyCommandTransformInfoQCOM = 1000333000,
	[Obsolete("Use VkStructureType.PhysicalDeviceImageRobustnessFeatures")]
	PhysicalDeviceImageRobustnessFeaturesEXT = PhysicalDeviceImageRobustnessFeatures,
	PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,
	[Obsolete("Use VkStructureType.CopyBufferInfo2")]
	CopyBufferInfo2KHR = CopyBufferInfo2,
	[Obsolete("Use VkStructureType.CopyImageInfo2")]
	CopyImageInfo2KHR = CopyImageInfo2,
	[Obsolete("Use VkStructureType.CopyBufferToImageInfo2")]
	CopyBufferToImageInfo2KHR = CopyBufferToImageInfo2,
	[Obsolete("Use VkStructureType.CopyImageToBufferInfo2")]
	CopyImageToBufferInfo2KHR = CopyImageToBufferInfo2,
	[Obsolete("Use VkStructureType.BlitImageInfo2")]
	BlitImageInfo2KHR = BlitImageInfo2,
	[Obsolete("Use VkStructureType.ResolveImageInfo2")]
	ResolveImageInfo2KHR = ResolveImageInfo2,
	[Obsolete("Use VkStructureType.BufferCopy2")]
	BufferCopy2KHR = BufferCopy2,
	[Obsolete("Use VkStructureType.ImageCopy2")]
	ImageCopy2KHR = ImageCopy2,
	[Obsolete("Use VkStructureType.ImageBlit2")]
	ImageBlit2KHR = ImageBlit2,
	[Obsolete("Use VkStructureType.BufferImageCopy2")]
	BufferImageCopy2KHR = BufferImageCopy2,
	[Obsolete("Use VkStructureType.ImageResolve2")]
	ImageResolve2KHR = ImageResolve2,
	PhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,
	ImageCompressionControlEXT = 1000338001,
	SubresourceLayout2EXT = 1000338002,
	ImageSubresource2EXT = 1000338003,
	ImageCompressionPropertiesEXT = 1000338004,
	PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,
	PhysicalDevice4444FormatsFeaturesEXT = 1000340000,
	PhysicalDeviceFaultFeaturesEXT = 1000341000,
	DeviceFaultCountsEXT = 1000341001,
	DeviceFaultInfoEXT = 1000341002,
	[Obsolete("Use VkStructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT")]
	PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM = PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT,
	PhysicalDeviceRgba10x6FormatsFeaturesEXT = 1000344000,
	[Obsolete("Use VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesEXT")]
	PhysicalDeviceMutableDescriptorTypeFeaturesVALVE = PhysicalDeviceMutableDescriptorTypeFeaturesEXT,
	[Obsolete("Use VkStructureType.MutableDescriptorTypeCreateInfoEXT")]
	MutableDescriptorTypeCreateInfoVALVE = MutableDescriptorTypeCreateInfoEXT,
	PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,
	VertexInputBindingDescription2EXT = 1000352001,
	VertexInputAttributeDescription2EXT = 1000352002,
	PhysicalDeviceDRMPropertiesEXT = 1000353000,
	PhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,
	DeviceAddressBindingCallbackDataEXT = 1000354001,
	PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,
	PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,
	PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,
	[Obsolete("Use VkStructureType.FormatProperties3")]
	FormatProperties3KHR = FormatProperties3,
	SubpassShadingPipelineCreateInfoHUAWEI = 1000369000,
	PhysicalDeviceSubpassShadingFeaturesHUAWEI = 1000369001,
	PhysicalDeviceSubpassShadingPropertiesHUAWEI = 1000369002,
	PhysicalDeviceInvocationMaskFeaturesHUAWEI = 1000370000,
	MemoryGetRemoteAddressInfoNV = 1000371000,
	PhysicalDeviceExternalMemoryRDMAFeaturesNV = 1000371001,
	PipelinePropertiesIdentifierEXT = 1000372000,
	PhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,
	[Obsolete("Use VkStructureType.PipelineInfoKHR")]
	PipelineInfoEXT = PipelineInfoKHR,
	PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,
	SubpassResolvePerformanceQueryEXT = 1000376001,
	MultisampledRenderToSingleSampledInfoEXT = 1000376002,
	PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,
	PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,
	PipelineColorWriteCreateInfoEXT = 1000381001,
	PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,
	PhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,
	[Obsolete("Use VkStructureType.PhysicalDeviceGlobalPriorityQueryFeaturesKHR")]
	PhysicalDeviceGlobalPriorityQueryFeaturesEXT = PhysicalDeviceGlobalPriorityQueryFeaturesKHR,
	[Obsolete("Use VkStructureType.QueueFamilyGlobalPriorityPropertiesKHR")]
	QueueFamilyGlobalPriorityPropertiesEXT = QueueFamilyGlobalPriorityPropertiesKHR,
	PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,
	ImageViewMinLodCreateInfoEXT = 1000391001,
	PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,
	PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,
	PhysicalDeviceImage2DViewOf3DFeaturesEXT = 1000393000,
	MicromapBuildInfoEXT = 1000396000,
	MicromapVersionInfoEXT = 1000396001,
	CopyMicromapInfoEXT = 1000396002,
	CopyMicromapToMemoryInfoEXT = 1000396003,
	CopyMemoryToMicromapInfoEXT = 1000396004,
	PhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,
	PhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,
	MicromapCreateInfoEXT = 1000396007,
	MicromapBuildSizesInfoEXT = 1000396008,
	AccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,
	PhysicalDeviceClusterCullingShaderFeaturesHUAWEI = 1000404000,
	PhysicalDeviceClusterCullingShaderPropertiesHUAWEI = 1000404001,
	PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,
	SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,
	PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance4Features")]
	PhysicalDeviceMaintenance4FeaturesKHR = PhysicalDeviceMaintenance4Features,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance4Properties")]
	PhysicalDeviceMaintenance4PropertiesKHR = PhysicalDeviceMaintenance4Properties,
	[Obsolete("Use VkStructureType.DeviceBufferMemoryRequirements")]
	DeviceBufferMemoryRequirementsKHR = DeviceBufferMemoryRequirements,
	[Obsolete("Use VkStructureType.DeviceImageMemoryRequirements")]
	DeviceImageMemoryRequirementsKHR = DeviceImageMemoryRequirements,
	PhysicalDeviceDescriptorSetHostMappingFeaturesVALVE = 1000420000,
	DescriptorSetBindingReferenceVALVE = 1000420001,
	DescriptorSetLayoutHostMappingInfoVALVE = 1000420002,
	PhysicalDeviceDepthClampZeroOneFeaturesEXT = 1000421000,
	PhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,
	PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM = 1000425000,
	PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM = 1000425001,
	SubpassFragmentDensityMapOffsetEndInfoQCOM = 1000425002,
	PhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,
	PhysicalDeviceCopyMemoryIndirectPropertiesNV = 1000426001,
	PhysicalDeviceMemoryDecompressionFeaturesNV = 1000427000,
	PhysicalDeviceMemoryDecompressionPropertiesNV = 1000427001,
	PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,
	PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,
	PhysicalDeviceImageProcessingFeaturesQCOM = 1000440000,
	PhysicalDeviceImageProcessingPropertiesQCOM = 1000440001,
	ImageViewSampleWeightCreateInfoQCOM = 1000440002,
	PhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,
	PhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,
	PhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,
	RenderPassCreationControlEXT = 1000458001,
	RenderPassCreationFeedbackCreateInfoEXT = 1000458002,
	RenderPassSubpassFeedbackCreateInfoEXT = 1000458003,
	DirectDriverLoadingInfoLUNARG = 1000459000,
	DirectDriverLoadingListLUNARG = 1000459001,
	PhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,
	PhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,
	PipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,
	ShaderModuleIdentifierEXT = 1000462003,
	PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000463000,
	PhysicalDeviceOpticalFlowFeaturesNV = 1000464000,
	PhysicalDeviceOpticalFlowPropertiesNV = 1000464001,
	OpticalFlowImageFormatInfoNV = 1000464002,
	OpticalFlowImageFormatPropertiesNV = 1000464003,
	OpticalFlowSessionCreateInfoNV = 1000464004,
	OpticalFlowExecuteInfoNV = 1000464005,
	OpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,
	PhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,
	PhysicalDevicePipelineProtectedAccessFeaturesEXT = 1000466000,
	PhysicalDeviceTilePropertiesFeaturesQCOM = 1000484000,
	TilePropertiesQCOM = 1000484001,
	PhysicalDeviceAmigoProfilingFeaturesSEC = 1000485000,
	AmigoProfilingSubmitInfoSEC = 1000485001,
	PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM = 1000488000,
	PhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,
	PhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,
	PhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000494000,
	MutableDescriptorTypeCreateInfoEXT = 1000494002,
	PhysicalDeviceShaderCoreBuiltinsFeaturesARM = 1000497000,
	PhysicalDeviceShaderCoreBuiltinsPropertiesARM = 1000497001,
	PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,
}
public enum VkPipelineCacheHeaderVersion
{
	One = 1,
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
	None = 0,
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
	[Obsolete("Use VkAccessFlags.None")]
	NoneKHR = None,
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
	ReadOnlyOptimal = 1000314000,
	AttachmentOptimal = 1000314001,
	PresentSourceKHR = 1000001002,
	VideoDecodeDestinationKHR = 1000024000,
	VideoDecodeSourceKHR = 1000024001,
	VideoDecodeDPBKHR = 1000024002,
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
	[Obsolete("Use VkImageLayout.ReadOnlyOptimal")]
	ReadOnlyOptimalKHR = ReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.AttachmentOptimal")]
	AttachmentOptimalKHR = AttachmentOptimal,
	AttachmentFeedbackLoopOptimalEXT = 1000339000,
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
	None = 0,
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
	[Obsolete("Use VkImageAspectFlags.None")]
	NoneKHR = None,
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
	PrivateDataSlot = 1000295000,
	SurfaceKHR = 1000000000,
	SwapchainKHR = 1000001000,
	DisplayKHR = 1000002000,
	DisplayModeKHR = 1000002001,
	DebugReportCallbackEXT = 1000011000,
	VideoSessionKHR = 1000023000,
	VideoSessionParametersKHR = 1000023001,
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
	[Obsolete("Use VkObjectType.PrivateDataSlot")]
	PrivateDataSlotEXT = PrivateDataSlot,
	MicromapEXT = 1000396000,
	OpticalFlowSessionNV = 1000464000,
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
	EnumeratePortabilityKHR = 1 << 0,
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
	G8B8R82Plane444UNorm = 1000330000,
	G10X6B10X6R10X62Plane444UNorm3Pack16 = 1000330001,
	G12X4B12X4R12X42Plane444UNorm3Pack16 = 1000330002,
	G16B16R162Plane444UNorm = 1000330003,
	A4R4G4B4UNormPack16 = 1000340000,
	A4B4G4R4UNormPack16 = 1000340001,
	ASTC4x4SFloatBlock = 1000066000,
	ASTC5x4SFloatBlock = 1000066001,
	ASTC5x5SFloatBlock = 1000066002,
	ASTC6x5SFloatBlock = 1000066003,
	ASTC6x6SFloatBlock = 1000066004,
	ASTC8x5SFloatBlock = 1000066005,
	ASTC8x6SFloatBlock = 1000066006,
	ASTC8x8SFloatBlock = 1000066007,
	ASTC10x5SFloatBlock = 1000066008,
	ASTC10x6SFloatBlock = 1000066009,
	ASTC10x8SFloatBlock = 1000066010,
	ASTC10x10SFloatBlock = 1000066011,
	ASTC12x10SFloatBlock = 1000066012,
	ASTC12x12SFloatBlock = 1000066013,
	PVRTC12BPPUNormBlockIMG = 1000054000,
	PVRTC14BPPUNormBlockIMG = 1000054001,
	PVRTC22BPPUNormBlockIMG = 1000054002,
	PVRTC24BPPUNormBlockIMG = 1000054003,
	PVRTC12BPPSRGBBlockIMG = 1000054004,
	PVRTC14BPPSRGBBlockIMG = 1000054005,
	PVRTC22BPPSRGBBlockIMG = 1000054006,
	PVRTC24BPPSRGBBlockIMG = 1000054007,
	[Obsolete("Use VkFormat.ASTC4x4SFloatBlock")]
	ASTC4x4SFloatBlockEXT = ASTC4x4SFloatBlock,
	[Obsolete("Use VkFormat.ASTC5x4SFloatBlock")]
	ASTC5x4SFloatBlockEXT = ASTC5x4SFloatBlock,
	[Obsolete("Use VkFormat.ASTC5x5SFloatBlock")]
	ASTC5x5SFloatBlockEXT = ASTC5x5SFloatBlock,
	[Obsolete("Use VkFormat.ASTC6x5SFloatBlock")]
	ASTC6x5SFloatBlockEXT = ASTC6x5SFloatBlock,
	[Obsolete("Use VkFormat.ASTC6x6SFloatBlock")]
	ASTC6x6SFloatBlockEXT = ASTC6x6SFloatBlock,
	[Obsolete("Use VkFormat.ASTC8x5SFloatBlock")]
	ASTC8x5SFloatBlockEXT = ASTC8x5SFloatBlock,
	[Obsolete("Use VkFormat.ASTC8x6SFloatBlock")]
	ASTC8x6SFloatBlockEXT = ASTC8x6SFloatBlock,
	[Obsolete("Use VkFormat.ASTC8x8SFloatBlock")]
	ASTC8x8SFloatBlockEXT = ASTC8x8SFloatBlock,
	[Obsolete("Use VkFormat.ASTC10x5SFloatBlock")]
	ASTC10x5SFloatBlockEXT = ASTC10x5SFloatBlock,
	[Obsolete("Use VkFormat.ASTC10x6SFloatBlock")]
	ASTC10x6SFloatBlockEXT = ASTC10x6SFloatBlock,
	[Obsolete("Use VkFormat.ASTC10x8SFloatBlock")]
	ASTC10x8SFloatBlockEXT = ASTC10x8SFloatBlock,
	[Obsolete("Use VkFormat.ASTC10x10SFloatBlock")]
	ASTC10x10SFloatBlockEXT = ASTC10x10SFloatBlock,
	[Obsolete("Use VkFormat.ASTC12x10SFloatBlock")]
	ASTC12x10SFloatBlockEXT = ASTC12x10SFloatBlock,
	[Obsolete("Use VkFormat.ASTC12x12SFloatBlock")]
	ASTC12x12SFloatBlockEXT = ASTC12x12SFloatBlock,
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
	[Obsolete("Use VkFormat.G8B8R82Plane444UNorm")]
	G8B8R82Plane444UNormEXT = G8B8R82Plane444UNorm,
	[Obsolete("Use VkFormat.G10X6B10X6R10X62Plane444UNorm3Pack16")]
	G10X6B10X6R10X62Plane444UNorm3Pack16EXT = G10X6B10X6R10X62Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.G12X4B12X4R12X42Plane444UNorm3Pack16")]
	G12X4B12X4R12X42Plane444UNorm3Pack16EXT = G12X4B12X4R12X42Plane444UNorm3Pack16,
	[Obsolete("Use VkFormat.G16B16R162Plane444UNorm")]
	G16B16R162Plane444UNormEXT = G16B16R162Plane444UNorm,
	[Obsolete("Use VkFormat.A4R4G4B4UNormPack16")]
	A4R4G4B4UNormPack16EXT = A4R4G4B4UNormPack16,
	[Obsolete("Use VkFormat.A4B4G4R4UNormPack16")]
	A4B4G4R4UNormPack16EXT = A4B4G4R4UNormPack16,
	R16G16S105NV = 1000464000,
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
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterCubicEXT")]
	SampledImageFilterCubicIMG = SampledImageFilterCubicEXT,
	VideoDecodeOutputKHR = 1 << 25,
	VideoDecodeDPBKHR = 1 << 26,
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
	SampledImageFilterCubicEXT = 1 << 13,
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
	VideoDecodeDestinationKHR = 1 << 10,
	VideoDecodeSourceKHR = 1 << 11,
	VideoDecodeDPBKHR = 1 << 12,
	[Obsolete("Use VkImageUsageFlags.FragmentShadingRateAttachmentKHR")]
	ShadingRateImageNV = FragmentShadingRateAttachmentKHR,
	FragmentDensityMapEXT = 1 << 9,
	FragmentShadingRateAttachmentKHR = 1 << 8,
	AttachmentFeedbackLoopEXT = 1 << 19,
	InvocationMaskHUAWEI = 1 << 18,
	SampleWeightQCOM = 1 << 20,
	SampleBlockMatchQCOM = 1 << 21,
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
	DescriptorBufferCaptureReplayEXT = 1 << 16,
	MultisampledRenderToSingleSampledEXT = 1 << 18,
	_2DViewCompatibleEXT = 1 << 17,
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
	VideoDecodeKHR = 1 << 5,
	OpticalFlowNV = 1 << 8,
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
public enum VkInternalAllocationType
{
	Executable = 0,
}
public enum VkSystemAllocationScope
{
	Command = 0,
	Object = 1,
	Cache = 2,
	Device = 3,
	Instance = 4,
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
	None = 0,
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
	[Obsolete("Use VkPipelineStageFlags.TaskShaderEXT")]
	TaskShaderNV = TaskShaderEXT,
	[Obsolete("Use VkPipelineStageFlags.MeshShaderEXT")]
	MeshShaderNV = MeshShaderEXT,
	FragmentDensityProcessEXT = 1 << 23,
	FragmentShadingRateAttachmentKHR = 1 << 22,
	CommandPreprocessNV = 1 << 17,
	[Obsolete("Use VkPipelineStageFlags.None")]
	NoneKHR = None,
	TaskShaderEXT = 1 << 19,
	MeshShaderEXT = 1 << 20,
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
	DeviceOnly = 1 << 0,
	[Obsolete("Use VkEventCreateFlags.DeviceOnly")]
	DeviceOnlyKHR = DeviceOnly,
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
	ResultStatusOnlyKHR = 1000023000,
	TransformFeedbackStreamEXT = 1000028004,
	PerformanceQueryKHR = 1000116000,
	AccelerationStructureCompactedSizeKHR = 1000150000,
	AccelerationStructureSerializationSizeKHR = 1000150001,
	AccelerationStructureCompactedSizeNV = 1000165000,
	PerformanceQueryINTEL = 1000210000,
	MeshPrimitivesGeneratedEXT = 1000328000,
	PrimitivesGeneratedEXT = 1000382000,
	AccelerationStructureSerializationBottomLevelPointersKHR = 1000386000,
	AccelerationStructureSizeKHR = 1000386001,
	MicromapSerializationSizeEXT = 1000396000,
	MicromapCompactedSizeEXT = 1000396001,
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
	TaskShaderInvocationsEXT = 1 << 11,
	MeshShaderInvocationsEXT = 1 << 12,
	ClusterCullingShaderInvocationsHUAWEI = 1 << 13,
}
[Flags]
public enum VkQueryResultFlags
{
	_64 = 1 << 0,
	Wait = 1 << 1,
	WithAvailability = 1 << 2,
	Partial = 1 << 3,
	WithStatusKHR = 1 << 4,
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
	DescriptorBufferCaptureReplayEXT = 1 << 5,
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
	VideoDecodeSourceKHR = 1 << 13,
	VideoDecodeDestinationKHR = 1 << 14,
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
	SamplerDescriptorBufferEXT = 1 << 21,
	ResourceDescriptorBufferEXT = 1 << 22,
	PushDescriptorsDescriptorBufferEXT = 1 << 26,
	MicromapBuildInputReadOnlyEXT = 1 << 23,
	MicromapStorageEXT = 1 << 24,
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
	DescriptorBufferCaptureReplayEXT = 1 << 2,
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
	ExternallySynchronized = 1 << 0,
	[Obsolete("Use VkPipelineCacheCreateFlags.ExternallySynchronized")]
	ExternallySynchronizedEXT = ExternallySynchronized,
}
[Flags]
public enum VkPipelineCreateFlags
{
	DisableOptimization = 1 << 0,
	AllowDerivatives = 1 << 1,
	Derivative = 1 << 2,
	ViewIndexFromDeviceIndex = 1 << 3,
	DispatchBase = 1 << 4,
	FailOnPipelineCompileRequired = 1 << 8,
	EarlyReturnOnFailure = 1 << 9,
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
	[Obsolete("Use VkPipelineCreateFlags.FailOnPipelineCompileRequired")]
	FailOnPipelineCompileRequiredEXT = FailOnPipelineCompileRequired,
	[Obsolete("Use VkPipelineCreateFlags.EarlyReturnOnFailure")]
	EarlyReturnOnFailureEXT = EarlyReturnOnFailure,
	DescriptorBufferEXT = 1 << 29,
	RetainLinkTimeOptimizationInfoEXT = 1 << 23,
	LinkTimeOptimizationEXT = 1 << 10,
	RayTracingAllowMotionNV = 1 << 20,
	ColorAttachmentFeedbackLoopEXT = 1 << 25,
	DepthStencilAttachmentFeedbackLoopEXT = 1 << 26,
	RayTracingOpacityMicromapEXT = 1 << 24,
	NoProtectedAccessEXT = 1 << 27,
	ProtectedAccessOnlyEXT = 1 << 30,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags
{
	AllowVaryingSubgroupSize = 1 << 0,
	RequireFullSubgroups = 1 << 1,
	[Obsolete("Use VkPipelineShaderStageCreateFlags.AllowVaryingSubgroupSize")]
	AllowVaryingSubgroupSizeEXT = AllowVaryingSubgroupSize,
	[Obsolete("Use VkPipelineShaderStageCreateFlags.RequireFullSubgroups")]
	RequireFullSubgroupsEXT = RequireFullSubgroups,
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
	[Obsolete("Use VkShaderStageFlags.TaskEXT")]
	TaskNV = TaskEXT,
	[Obsolete("Use VkShaderStageFlags.MeshEXT")]
	MeshNV = MeshEXT,
	TaskEXT = 1 << 6,
	MeshEXT = 1 << 7,
	SubpassShadingHUAWEI = 1 << 14,
	ClusterCullingHUAWEI = 1 << 19,
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
	[Obsolete("Use VkPipelineDepthStencilStateCreateFlags.RasterizationOrderAttachmentDepthAccessEXT")]
	RasterizationOrderAttachmentDepthAccessARM = RasterizationOrderAttachmentDepthAccessEXT,
	[Obsolete("Use VkPipelineDepthStencilStateCreateFlags.RasterizationOrderAttachmentStencilAccessEXT")]
	RasterizationOrderAttachmentStencilAccessARM = RasterizationOrderAttachmentStencilAccessEXT,
	RasterizationOrderAttachmentDepthAccessEXT = 1 << 0,
	RasterizationOrderAttachmentStencilAccessEXT = 1 << 1,
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
	[Obsolete("Use VkPipelineColorBlendStateCreateFlags.RasterizationOrderAttachmentAccessEXT")]
	RasterizationOrderAttachmentAccessARM = RasterizationOrderAttachmentAccessEXT,
	RasterizationOrderAttachmentAccessEXT = 1 << 0,
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
	CullMode = 1000267000,
	FrontFace = 1000267001,
	PrimitiveTopology = 1000267002,
	ViewportWithCount = 1000267003,
	ScissorWithCount = 1000267004,
	VertexInputBindingStride = 1000267005,
	DepthTestEnable = 1000267006,
	DepthWriteEnable = 1000267007,
	DepthCompareOp = 1000267008,
	DepthBoundsTestEnable = 1000267009,
	StencilTestEnable = 1000267010,
	StencilOp = 1000267011,
	RasterizerDiscardEnable = 1000377001,
	DepthBiasEnable = 1000377002,
	PrimitiveRestartEnable = 1000377004,
	ViewportWScalingNV = 1000087000,
	DiscardRectangleEXT = 1000099000,
	SampleLocationsEXT = 1000143000,
	RayTracingPipelineStackSizeKHR = 1000347000,
	ViewportShadingRatePaletteNV = 1000164004,
	ViewportCoarseSampleOrderNV = 1000164006,
	ExclusiveScissorNV = 1000205001,
	FragmentShadingRateKHR = 1000226000,
	LineStippleEXT = 1000259000,
	[Obsolete("Use VkDynamicState.CullMode")]
	CullModeEXT = CullMode,
	[Obsolete("Use VkDynamicState.FrontFace")]
	FrontFaceEXT = FrontFace,
	[Obsolete("Use VkDynamicState.PrimitiveTopology")]
	PrimitiveTopologyEXT = PrimitiveTopology,
	[Obsolete("Use VkDynamicState.ViewportWithCount")]
	ViewportWithCountEXT = ViewportWithCount,
	[Obsolete("Use VkDynamicState.ScissorWithCount")]
	ScissorWithCountEXT = ScissorWithCount,
	[Obsolete("Use VkDynamicState.VertexInputBindingStride")]
	VertexInputBindingStrideEXT = VertexInputBindingStride,
	[Obsolete("Use VkDynamicState.DepthTestEnable")]
	DepthTestEnableEXT = DepthTestEnable,
	[Obsolete("Use VkDynamicState.DepthWriteEnable")]
	DepthWriteEnableEXT = DepthWriteEnable,
	[Obsolete("Use VkDynamicState.DepthCompareOp")]
	DepthCompareOpEXT = DepthCompareOp,
	[Obsolete("Use VkDynamicState.DepthBoundsTestEnable")]
	DepthBoundsTestEnableEXT = DepthBoundsTestEnable,
	[Obsolete("Use VkDynamicState.StencilTestEnable")]
	StencilTestEnableEXT = StencilTestEnable,
	[Obsolete("Use VkDynamicState.StencilOp")]
	StencilOpEXT = StencilOp,
	VertexInputEXT = 1000352000,
	PatchControlPointsEXT = 1000377000,
	[Obsolete("Use VkDynamicState.RasterizerDiscardEnable")]
	RasterizerDiscardEnableEXT = RasterizerDiscardEnable,
	[Obsolete("Use VkDynamicState.DepthBiasEnable")]
	DepthBiasEnableEXT = DepthBiasEnable,
	LogicOpEXT = 1000377003,
	[Obsolete("Use VkDynamicState.PrimitiveRestartEnable")]
	PrimitiveRestartEnableEXT = PrimitiveRestartEnable,
	ColorWriteEnableEXT = 1000381000,
	TessellationDomainOriginEXT = 1000455002,
	DepthClampEnableEXT = 1000455003,
	PolygonModeEXT = 1000455004,
	RasterizationSamplesEXT = 1000455005,
	SampleMaskEXT = 1000455006,
	AlphaToCoverageEnableEXT = 1000455007,
	AlphaToOneEnableEXT = 1000455008,
	LogicOpEnableEXT = 1000455009,
	ColorBlendEnableEXT = 1000455010,
	ColorBlendEquationEXT = 1000455011,
	ColorWriteMaskEXT = 1000455012,
	RasterizationStreamEXT = 1000455013,
	ConservativeRasterizationModeEXT = 1000455014,
	ExtraPrimitiveOverestimationSizeEXT = 1000455015,
	DepthClipEnableEXT = 1000455016,
	SampleLocationsEnableEXT = 1000455017,
	ColorBlendAdvancedEXT = 1000455018,
	ProvokingVertexModeEXT = 1000455019,
	LineRasterizationModeEXT = 1000455020,
	LineStippleEnableEXT = 1000455021,
	DepthClipNegativeOneToOneEXT = 1000455022,
	ViewportWScalingEnableNV = 1000455023,
	ViewportSwizzleNV = 1000455024,
	CoverageToColorEnableNV = 1000455025,
	CoverageToColorLocationNV = 1000455026,
	CoverageModulationModeNV = 1000455027,
	CoverageModulationTableEnableNV = 1000455028,
	CoverageModulationTableNV = 1000455029,
	ShadingRateImageEnableNV = 1000455030,
	RepresentativeFragmentTestEnableNV = 1000455031,
	CoverageReductionModeNV = 1000455032,
}
[Flags]
public enum VkPipelineLayoutCreateFlags
{
	IndependentSetsEXT = 1 << 1,
}
[Flags]
public enum VkSamplerCreateFlags
{
	SubsampledEXT = 1 << 0,
	SubsampledCoarseReconstructionEXT = 1 << 1,
	DescriptorBufferCaptureReplayEXT = 1 << 3,
	NonSeamlessCubeMapEXT = 1 << 2,
	ImageProcessingQCOM = 1 << 4,
}
public enum VkFilter
{
	Nearest = 0,
	Linear = 1,
	[Obsolete("Use VkFilter.CubicEXT")]
	CubicIMG = CubicEXT,
	CubicEXT = 1000170000,
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
	DescriptorBufferEXT = 1 << 4,
	EmbeddedImmutableSamplersEXT = 1 << 5,
	[Obsolete("Use VkDescriptorSetLayoutCreateFlags.HostOnlyPoolEXT")]
	HostOnlyPoolVALVE = HostOnlyPoolEXT,
	HostOnlyPoolEXT = 1 << 2,
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
	InlineUniformBlock = 1000138000,
	[Obsolete("Use VkDescriptorType.InlineUniformBlock")]
	InlineUniformBlockEXT = InlineUniformBlock,
	AccelerationStructureKHR = 1000150000,
	AccelerationStructureNV = 1000165000,
	[Obsolete("Use VkDescriptorType.MutableEXT")]
	MutableVALVE = MutableEXT,
	SampleWeightImageQCOM = 1000440000,
	BlockMatchImageQCOM = 1000440001,
	MutableEXT = 1000494000,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
	UpdateAfterBind = 1 << 1,
	[Obsolete("Use VkDescriptorPoolCreateFlags.UpdateAfterBind")]
	UpdateAfterBindEXT = UpdateAfterBind,
	[Obsolete("Use VkDescriptorPoolCreateFlags.HostOnlyEXT")]
	HostOnlyVALVE = HostOnlyEXT,
	HostOnlyEXT = 1 << 2,
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
	None = 1000301000,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneKHR = None,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneQCOM = None,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneEXT = None,
}
[Flags]
public enum VkSubpassDescriptionFlags
{
	PerViewAttributesNVX = 1 << 0,
	PerViewPositionXOnlyNVX = 1 << 1,
	FragmentRegionQCOM = 1 << 2,
	ShaderResolveQCOM = 1 << 3,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentColorAccessEXT")]
	RasterizationOrderAttachmentColorAccessARM = RasterizationOrderAttachmentColorAccessEXT,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentDepthAccessEXT")]
	RasterizationOrderAttachmentDepthAccessARM = RasterizationOrderAttachmentDepthAccessEXT,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentStencilAccessEXT")]
	RasterizationOrderAttachmentStencilAccessARM = RasterizationOrderAttachmentStencilAccessEXT,
	RasterizationOrderAttachmentColorAccessEXT = 1 << 4,
	RasterizationOrderAttachmentDepthAccessEXT = 1 << 5,
	RasterizationOrderAttachmentStencilAccessEXT = 1 << 6,
	EnableLegacyDitheringEXT = 1 << 7,
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
	FeedbackLoopEXT = 1 << 3,
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
	MesaVenus = 22,
	MesaDozen = 23,
	MesaNvk = 24,
	ImaginationOpenSourceMESA = 25,
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
public enum VkPipelineCreationFeedbackFlags
{
	Valid = 1 << 0,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.Valid")]
	ValidEXT = Valid,
	ApplicationPipelineCacheHit = 1 << 1,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.ApplicationPipelineCacheHit")]
	ApplicationPipelineCacheHitEXT = ApplicationPipelineCacheHit,
	BasePipelineAcceleration = 1 << 2,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.BasePipelineAcceleration")]
	BasePipelineAccelerationEXT = BasePipelineAcceleration,
}
[Flags]
public enum VkToolPurposeFlags
{
	Validation = 1 << 0,
	[Obsolete("Use VkToolPurposeFlags.Validation")]
	ValidationEXT = Validation,
	Profiling = 1 << 1,
	[Obsolete("Use VkToolPurposeFlags.Profiling")]
	ProfilingEXT = Profiling,
	Tracing = 1 << 2,
	[Obsolete("Use VkToolPurposeFlags.Tracing")]
	TracingEXT = Tracing,
	AdditionalFeatures = 1 << 3,
	[Obsolete("Use VkToolPurposeFlags.AdditionalFeatures")]
	AdditionalFeaturesEXT = AdditionalFeatures,
	ModifyingFeatures = 1 << 4,
	[Obsolete("Use VkToolPurposeFlags.ModifyingFeatures")]
	ModifyingFeaturesEXT = ModifyingFeatures,
	DebugReportingEXT = 1 << 5,
	DebugMarkersEXT = 1 << 6,
}
[Flags]
public enum VkPrivateDataSlotCreateFlags
{
}
[Flags]
public enum VkPipelineStageFlags2 : long
{
	None = 0,
	[Obsolete("Use VkPipelineStageFlags2.None")]
	NoneKHR = None,
	TopOfPipe = 1 << 0,
	[Obsolete("Use VkPipelineStageFlags2.TopOfPipe")]
	TopOfPipeKHR = TopOfPipe,
	DrawIndirect = 1 << 1,
	[Obsolete("Use VkPipelineStageFlags2.DrawIndirect")]
	DrawIndirectKHR = DrawIndirect,
	VertexInput = 1 << 2,
	[Obsolete("Use VkPipelineStageFlags2.VertexInput")]
	VertexInputKHR = VertexInput,
	VertexShader = 1 << 3,
	[Obsolete("Use VkPipelineStageFlags2.VertexShader")]
	VertexShaderKHR = VertexShader,
	TessellationControlShader = 1 << 4,
	[Obsolete("Use VkPipelineStageFlags2.TessellationControlShader")]
	TessellationControlShaderKHR = TessellationControlShader,
	TessellationEvaluationShader = 1 << 5,
	[Obsolete("Use VkPipelineStageFlags2.TessellationEvaluationShader")]
	TessellationEvaluationShaderKHR = TessellationEvaluationShader,
	GeometryShader = 1 << 6,
	[Obsolete("Use VkPipelineStageFlags2.GeometryShader")]
	GeometryShaderKHR = GeometryShader,
	FragmentShader = 1 << 7,
	[Obsolete("Use VkPipelineStageFlags2.FragmentShader")]
	FragmentShaderKHR = FragmentShader,
	EarlyFragmentTests = 1 << 8,
	[Obsolete("Use VkPipelineStageFlags2.EarlyFragmentTests")]
	EarlyFragmentTestsKHR = EarlyFragmentTests,
	LateFragmentTests = 1 << 9,
	[Obsolete("Use VkPipelineStageFlags2.LateFragmentTests")]
	LateFragmentTestsKHR = LateFragmentTests,
	ColorAttachmentOutput = 1 << 10,
	[Obsolete("Use VkPipelineStageFlags2.ColorAttachmentOutput")]
	ColorAttachmentOutputKHR = ColorAttachmentOutput,
	ComputeShader = 1 << 11,
	[Obsolete("Use VkPipelineStageFlags2.ComputeShader")]
	ComputeShaderKHR = ComputeShader,
	AllTransfer = 1 << 12,
	[Obsolete("Use VkPipelineStageFlags2.AllTransfer")]
	AllTransferKHR = AllTransfer,
	[Obsolete("Use VkPipelineStageFlags2.AllTransferKHR")]
	Transfer = AllTransferKHR,
	[Obsolete("Use VkPipelineStageFlags2.AllTransfer")]
	TransferKHR = AllTransfer,
	BottomOfPipe = 1 << 13,
	[Obsolete("Use VkPipelineStageFlags2.BottomOfPipe")]
	BottomOfPipeKHR = BottomOfPipe,
	Host = 1 << 14,
	[Obsolete("Use VkPipelineStageFlags2.Host")]
	HostKHR = Host,
	AllGraphics = 1 << 15,
	[Obsolete("Use VkPipelineStageFlags2.AllGraphics")]
	AllGraphicsKHR = AllGraphics,
	AllCommands = 1 << 16,
	[Obsolete("Use VkPipelineStageFlags2.AllCommands")]
	AllCommandsKHR = AllCommands,
	Copy = 1 << 32,
	[Obsolete("Use VkPipelineStageFlags2.Copy")]
	CopyKHR = Copy,
	Resolve = 1 << 33,
	[Obsolete("Use VkPipelineStageFlags2.Resolve")]
	ResolveKHR = Resolve,
	Blit = 1 << 34,
	[Obsolete("Use VkPipelineStageFlags2.Blit")]
	BlitKHR = Blit,
	Clear = 1 << 35,
	[Obsolete("Use VkPipelineStageFlags2.Clear")]
	ClearKHR = Clear,
	IndexInput = 1 << 36,
	[Obsolete("Use VkPipelineStageFlags2.IndexInput")]
	IndexInputKHR = IndexInput,
	VertexAttributeInput = 1 << 37,
	[Obsolete("Use VkPipelineStageFlags2.VertexAttributeInput")]
	VertexAttributeInputKHR = VertexAttributeInput,
	PreRasterizationShaders = 1 << 38,
	[Obsolete("Use VkPipelineStageFlags2.PreRasterizationShaders")]
	PreRasterizationShadersKHR = PreRasterizationShaders,
	VideoDecodeKHR = 1 << 26,
	TransformFeedbackEXT = 1 << 24,
	ConditionalRenderingEXT = 1 << 18,
	CommandPreprocessNV = 1 << 17,
	FragmentShadingRateAttachmentKHR = 1 << 22,
	[Obsolete("Use VkPipelineStageFlags2.FragmentShadingRateAttachmentKHR")]
	ShadingRateImageNV = FragmentShadingRateAttachmentKHR,
	AccelerationStructureBuildKHR = 1 << 25,
	RayTracingShaderKHR = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags2.RayTracingShaderKHR")]
	RayTracingShaderNV = RayTracingShaderKHR,
	[Obsolete("Use VkPipelineStageFlags2.AccelerationStructureBuildKHR")]
	AccelerationStructureBuildNV = AccelerationStructureBuildKHR,
	FragmentDensityProcessEXT = 1 << 23,
	[Obsolete("Use VkPipelineStageFlags2.TaskShaderEXT")]
	TaskShaderNV = TaskShaderEXT,
	[Obsolete("Use VkPipelineStageFlags2.MeshShaderEXT")]
	MeshShaderNV = MeshShaderEXT,
	TaskShaderEXT = 1 << 19,
	MeshShaderEXT = 1 << 20,
	SubpassShadingHUAWEI = 1 << 39,
	InvocationMaskHUAWEI = 1 << 40,
	AccelerationStructureCopyKHR = 1 << 28,
	MicromapBuildEXT = 1 << 30,
	ClusterCullingShaderHUAWEI = 1 << 41,
	OpticalFlowNV = 1 << 29,
}
[Flags]
public enum VkAccessFlags2 : long
{
	None = 0,
	[Obsolete("Use VkAccessFlags2.None")]
	NoneKHR = None,
	IndirectCommandRead = 1 << 0,
	[Obsolete("Use VkAccessFlags2.IndirectCommandRead")]
	IndirectCommandReadKHR = IndirectCommandRead,
	IndexRead = 1 << 1,
	[Obsolete("Use VkAccessFlags2.IndexRead")]
	IndexReadKHR = IndexRead,
	VertexAttributeRead = 1 << 2,
	[Obsolete("Use VkAccessFlags2.VertexAttributeRead")]
	VertexAttributeReadKHR = VertexAttributeRead,
	UniformRead = 1 << 3,
	[Obsolete("Use VkAccessFlags2.UniformRead")]
	UniformReadKHR = UniformRead,
	InputAttachmentRead = 1 << 4,
	[Obsolete("Use VkAccessFlags2.InputAttachmentRead")]
	InputAttachmentReadKHR = InputAttachmentRead,
	ShaderRead = 1 << 5,
	[Obsolete("Use VkAccessFlags2.ShaderRead")]
	ShaderReadKHR = ShaderRead,
	ShaderWrite = 1 << 6,
	[Obsolete("Use VkAccessFlags2.ShaderWrite")]
	ShaderWriteKHR = ShaderWrite,
	ColorAttachmentRead = 1 << 7,
	[Obsolete("Use VkAccessFlags2.ColorAttachmentRead")]
	ColorAttachmentReadKHR = ColorAttachmentRead,
	ColorAttachmentWrite = 1 << 8,
	[Obsolete("Use VkAccessFlags2.ColorAttachmentWrite")]
	ColorAttachmentWriteKHR = ColorAttachmentWrite,
	DepthStencilAttachmentRead = 1 << 9,
	[Obsolete("Use VkAccessFlags2.DepthStencilAttachmentRead")]
	DepthStencilAttachmentReadKHR = DepthStencilAttachmentRead,
	DepthStencilAttachmentWrite = 1 << 10,
	[Obsolete("Use VkAccessFlags2.DepthStencilAttachmentWrite")]
	DepthStencilAttachmentWriteKHR = DepthStencilAttachmentWrite,
	TransferRead = 1 << 11,
	[Obsolete("Use VkAccessFlags2.TransferRead")]
	TransferReadKHR = TransferRead,
	TransferWrite = 1 << 12,
	[Obsolete("Use VkAccessFlags2.TransferWrite")]
	TransferWriteKHR = TransferWrite,
	HostRead = 1 << 13,
	[Obsolete("Use VkAccessFlags2.HostRead")]
	HostReadKHR = HostRead,
	HostWrite = 1 << 14,
	[Obsolete("Use VkAccessFlags2.HostWrite")]
	HostWriteKHR = HostWrite,
	MemoryRead = 1 << 15,
	[Obsolete("Use VkAccessFlags2.MemoryRead")]
	MemoryReadKHR = MemoryRead,
	MemoryWrite = 1 << 16,
	[Obsolete("Use VkAccessFlags2.MemoryWrite")]
	MemoryWriteKHR = MemoryWrite,
	ShaderSampledRead = 1 << 32,
	[Obsolete("Use VkAccessFlags2.ShaderSampledRead")]
	ShaderSampledReadKHR = ShaderSampledRead,
	ShaderStorageRead = 1 << 33,
	[Obsolete("Use VkAccessFlags2.ShaderStorageRead")]
	ShaderStorageReadKHR = ShaderStorageRead,
	ShaderStorageWrite = 1 << 34,
	[Obsolete("Use VkAccessFlags2.ShaderStorageWrite")]
	ShaderStorageWriteKHR = ShaderStorageWrite,
	VideoDecodeReadKHR = 1 << 35,
	VideoDecodeWriteKHR = 1 << 36,
	TransformFeedbackWriteEXT = 1 << 25,
	TransformFeedbackCounterReadEXT = 1 << 26,
	TransformFeedbackCounterWriteEXT = 1 << 27,
	ConditionalRenderingReadEXT = 1 << 20,
	CommandPreprocessReadNV = 1 << 17,
	CommandPreprocessWriteNV = 1 << 18,
	FragmentShadingRateAttachmentReadKHR = 1 << 23,
	[Obsolete("Use VkAccessFlags2.FragmentShadingRateAttachmentReadKHR")]
	ShadingRateImageReadNV = FragmentShadingRateAttachmentReadKHR,
	AccelerationStructureReadKHR = 1 << 21,
	AccelerationStructureWriteKHR = 1 << 22,
	[Obsolete("Use VkAccessFlags2.AccelerationStructureReadKHR")]
	AccelerationStructureReadNV = AccelerationStructureReadKHR,
	[Obsolete("Use VkAccessFlags2.AccelerationStructureWriteKHR")]
	AccelerationStructureWriteNV = AccelerationStructureWriteKHR,
	FragmentDensityMapReadEXT = 1 << 24,
	ColorAttachmentReadNoncoherentEXT = 1 << 19,
	DescriptorBufferReadEXT = 1 << 41,
	InvocationMaskReadHUAWEI = 1 << 39,
	ShaderBindingTableReadKHR = 1 << 40,
	MicromapReadEXT = 1 << 44,
	MicromapWriteEXT = 1 << 45,
	OpticalFlowReadNV = 1 << 42,
	OpticalFlowWriteNV = 1 << 43,
}
[Flags]
public enum VkSubmitFlags
{
	Protected = 1 << 0,
	[Obsolete("Use VkSubmitFlags.Protected")]
	ProtectedKHR = Protected,
}
[Flags]
public enum VkRenderingFlags
{
	ContentsSecondaryCommandBuffers = 1 << 0,
	[Obsolete("Use VkRenderingFlags.ContentsSecondaryCommandBuffers")]
	ContentsSecondaryCommandBuffersKHR = ContentsSecondaryCommandBuffers,
	Suspending = 1 << 1,
	[Obsolete("Use VkRenderingFlags.Suspending")]
	SuspendingKHR = Suspending,
	Resuming = 1 << 2,
	[Obsolete("Use VkRenderingFlags.Resuming")]
	ResumingKHR = Resuming,
	EnableLegacyDitheringEXT = 1 << 3,
}
[Flags]
public enum VkFormatFeatureFlags2 : long
{
	SampledImage = 1 << 0,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImage")]
	SampledImageKHR = SampledImage,
	StorageImage = 1 << 1,
	[Obsolete("Use VkFormatFeatureFlags2.StorageImage")]
	StorageImageKHR = StorageImage,
	StorageImageAtomic = 1 << 2,
	[Obsolete("Use VkFormatFeatureFlags2.StorageImageAtomic")]
	StorageImageAtomicKHR = StorageImageAtomic,
	UniformTexelBuffer = 1 << 3,
	[Obsolete("Use VkFormatFeatureFlags2.UniformTexelBuffer")]
	UniformTexelBufferKHR = UniformTexelBuffer,
	StorageTexelBuffer = 1 << 4,
	[Obsolete("Use VkFormatFeatureFlags2.StorageTexelBuffer")]
	StorageTexelBufferKHR = StorageTexelBuffer,
	StorageTexelBufferAtomic = 1 << 5,
	[Obsolete("Use VkFormatFeatureFlags2.StorageTexelBufferAtomic")]
	StorageTexelBufferAtomicKHR = StorageTexelBufferAtomic,
	VertexBuffer = 1 << 6,
	[Obsolete("Use VkFormatFeatureFlags2.VertexBuffer")]
	VertexBufferKHR = VertexBuffer,
	ColorAttachment = 1 << 7,
	[Obsolete("Use VkFormatFeatureFlags2.ColorAttachment")]
	ColorAttachmentKHR = ColorAttachment,
	ColorAttachmentBlend = 1 << 8,
	[Obsolete("Use VkFormatFeatureFlags2.ColorAttachmentBlend")]
	ColorAttachmentBlendKHR = ColorAttachmentBlend,
	DepthStencilAttachment = 1 << 9,
	[Obsolete("Use VkFormatFeatureFlags2.DepthStencilAttachment")]
	DepthStencilAttachmentKHR = DepthStencilAttachment,
	BlitSource = 1 << 10,
	[Obsolete("Use VkFormatFeatureFlags2.BlitSource")]
	BlitSourceKHR = BlitSource,
	BlitDestination = 1 << 11,
	[Obsolete("Use VkFormatFeatureFlags2.BlitDestination")]
	BlitDestinationKHR = BlitDestination,
	SampledImageFilterLinear = 1 << 12,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterLinear")]
	SampledImageFilterLinearKHR = SampledImageFilterLinear,
	SampledImageFilterCubic = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterCubic")]
	SampledImageFilterCubicEXT = SampledImageFilterCubic,
	TransferSource = 1 << 14,
	[Obsolete("Use VkFormatFeatureFlags2.TransferSource")]
	TransferSourceKHR = TransferSource,
	TransferDestination = 1 << 15,
	[Obsolete("Use VkFormatFeatureFlags2.TransferDestination")]
	TransferDestinationKHR = TransferDestination,
	SampledImageFilterMinmax = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterMinmax")]
	SampledImageFilterMinmaxKHR = SampledImageFilterMinmax,
	MidpointChromaSamples = 1 << 17,
	[Obsolete("Use VkFormatFeatureFlags2.MidpointChromaSamples")]
	MidpointChromaSamplesKHR = MidpointChromaSamples,
	SampledImageYCBCRConversionLinearFilter = 1 << 18,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionLinearFilter")]
	SampledImageYCBCRConversionLinearFilterKHR = SampledImageYCBCRConversionLinearFilter,
	SampledImageYCBCRConversionSeparateReconstructionFilter = 1 << 19,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionSeparateReconstructionFilter")]
	SampledImageYCBCRConversionSeparateReconstructionFilterKHR = SampledImageYCBCRConversionSeparateReconstructionFilter,
	SampledImageYCBCRConversionChromaReconstructionExplicit = 1 << 20,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionChromaReconstructionExplicit")]
	SampledImageYCBCRConversionChromaReconstructionExplicitKHR = SampledImageYCBCRConversionChromaReconstructionExplicit,
	SampledImageYCBCRConversionChromaReconstructionExplicitForceable = 1 << 21,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionChromaReconstructionExplicitForceable")]
	SampledImageYCBCRConversionChromaReconstructionExplicitForceableKHR = SampledImageYCBCRConversionChromaReconstructionExplicitForceable,
	Disjoint = 1 << 22,
	[Obsolete("Use VkFormatFeatureFlags2.Disjoint")]
	DisjointKHR = Disjoint,
	CositedChromaSamples = 1 << 23,
	[Obsolete("Use VkFormatFeatureFlags2.CositedChromaSamples")]
	CositedChromaSamplesKHR = CositedChromaSamples,
	StorageReadWithoutFormat = 1 << 31,
	[Obsolete("Use VkFormatFeatureFlags2.StorageReadWithoutFormat")]
	StorageReadWithoutFormatKHR = StorageReadWithoutFormat,
	StorageWriteWithoutFormat = 1 << 32,
	[Obsolete("Use VkFormatFeatureFlags2.StorageWriteWithoutFormat")]
	StorageWriteWithoutFormatKHR = StorageWriteWithoutFormat,
	SampledImageDepthComparison = 1 << 33,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageDepthComparison")]
	SampledImageDepthComparisonKHR = SampledImageDepthComparison,
	VideoDecodeOutputKHR = 1 << 25,
	VideoDecodeDPBKHR = 1 << 26,
	AccelerationStructureVertexBufferKHR = 1 << 29,
	FragmentDensityMapEXT = 1 << 24,
	FragmentShadingRateAttachmentKHR = 1 << 30,
	LinearColorAttachmentNV = 1 << 38,
	WeightImageQCOM = 1 << 34,
	WeightSampledImageQCOM = 1 << 35,
	BlockMatchingQCOM = 1 << 36,
	BoxFilterSampledQCOM = 1 << 37,
	OpticalFlowImageNV = 1 << 40,
	OpticalFlowVectorNV = 1 << 41,
	OpticalFlowCostNV = 1 << 42,
}
public enum StdVideoH264ChromaFormatIdc
{
	Monochrome = 0,
	_420 = 1,
	_422 = 2,
	_444 = 3,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264ProfileIdc
{
	Baseline = 66,
	Main = 77,
	High = 100,
	High444Predictive = 244,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264LevelIdc
{
	_10 = 0,
	_11 = 1,
	_12 = 2,
	_13 = 3,
	_20 = 4,
	_21 = 5,
	_22 = 6,
	_30 = 7,
	_31 = 8,
	_32 = 9,
	_40 = 10,
	_41 = 11,
	_42 = 12,
	_50 = 13,
	_51 = 14,
	_52 = 15,
	_60 = 16,
	_61 = 17,
	_62 = 18,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264PocType
{
	_0 = 0,
	_1 = 1,
	_2 = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264AspectRatioIdc
{
	Unspecified = 0,
	Square = 1,
	_1211 = 2,
	_1011 = 3,
	_1611 = 4,
	_4033 = 5,
	_2411 = 6,
	_2011 = 7,
	_3211 = 8,
	_8033 = 9,
	_1811 = 10,
	_1511 = 11,
	_6433 = 12,
	_16099 = 13,
	_43 = 14,
	_32 = 15,
	_21 = 16,
	ExtendedSar = 255,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264WeightedBipredIdc
{
	Default = 0,
	Explicit = 1,
	Implicit = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264ModificationOfPicNumsIdc
{
	ShortTermSubtract = 0,
	ShortTermAdd = 1,
	LongTerm = 2,
	End = 3,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264MemMgmtControlOp
{
	End = 0,
	UnmarkShortTerm = 1,
	UnmarkLongTerm = 2,
	MarkLongTerm = 3,
	SetMaxLongTermIndex = 4,
	UnmarkAll = 5,
	MarkCurrentAsLongTerm = 6,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264CabacInitIdc
{
	_0 = 0,
	_1 = 1,
	_2 = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264DisableDeblockingFilterIdc
{
	Disabled = 0,
	Enabled = 1,
	Partial = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264SliceType
{
	P = 0,
	B = 1,
	I = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264PictureType
{
	P = 0,
	B = 1,
	I = 2,
	Idr = 5,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH264NonVclNaluType
{
	Sps = 0,
	Pps = 1,
	Aud = 2,
	Prefix = 3,
	EndOfSequence = 4,
	EndOfStream = 5,
	Precoded = 6,
	Invalid = 0x7FFFFFFF,
}
[Flags]
public enum StdVideoH264SpsVuiFlags
{
	AspectRatioInfoPresentFlag = 1 << 0,
	OverscanInfoPresentFlag = 1 << 1,
	OverscanAppropriateFlag = 1 << 2,
	VideoSignalTypePresentFlag = 1 << 3,
	VideoFullRangeFlag = 1 << 4,
	ColorDescriptionPresentFlag = 1 << 5,
	ChromaLocInfoPresentFlag = 1 << 6,
	TimingInfoPresentFlag = 1 << 7,
	FixedFrameRateFlag = 1 << 8,
	BitstreamRestrictionFlag = 1 << 9,
	NalHrdParametersPresentFlag = 1 << 10,
	VclHrdParametersPresentFlag = 1 << 11,
}
[Flags]
public enum StdVideoH264SpsFlags
{
	ConstraintSet0Flag = 1 << 0,
	ConstraintSet1Flag = 1 << 1,
	ConstraintSet2Flag = 1 << 2,
	ConstraintSet3Flag = 1 << 3,
	ConstraintSet4Flag = 1 << 4,
	ConstraintSet5Flag = 1 << 5,
	Direct8x8InferenceFlag = 1 << 6,
	MbAdaptiveFrameFieldFlag = 1 << 7,
	FrameMbsOnlyFlag = 1 << 8,
	DeltaPicOrderAlwaysZeroFlag = 1 << 9,
	SeparateColourPlaneFlag = 1 << 10,
	GapsInFrameNumValueAllowedFlag = 1 << 11,
	QpprimeYZeroTransformBypassFlag = 1 << 12,
	FrameCroppingFlag = 1 << 13,
	SeqScalingMatrixPresentFlag = 1 << 14,
	VuiParametersPresentFlag = 1 << 15,
}
[Flags]
public enum StdVideoH264PpsFlags
{
	Transform8x8ModeFlag = 1 << 0,
	RedundantPicCntPresentFlag = 1 << 1,
	ConstrainedIntraPredFlag = 1 << 2,
	DeblockingFilterControlPresentFlag = 1 << 3,
	WeightedPredFlag = 1 << 4,
	BottomFieldPicOrderInFramePresentFlag = 1 << 5,
	EntropyCodingModeFlag = 1 << 6,
	PicScalingMatrixPresentFlag = 1 << 7,
}
public enum StdVideoDecodeH264FieldOrderCount
{
	Top = 0,
	Bottom = 1,
	Invalid = 0x7FFFFFFF,
}
[Flags]
public enum StdVideoDecodeH264PictureInfoFlags
{
	FieldPicFlag = 1 << 0,
	IsIntra = 1 << 1,
	Idrpicflag = 1 << 2,
	BottomFieldFlag = 1 << 3,
	IsReference = 1 << 4,
	ComplementaryFieldPair = 1 << 5,
}
[Flags]
public enum StdVideoDecodeH264ReferenceInfoFlags
{
	TopFieldFlag = 1 << 0,
	BottomFieldFlag = 1 << 1,
	UsedForLongTerm = 1 << 2,
	IsNonExisting = 1 << 3,
}
[Flags]
public enum StdVideoEncodeH264SliceHeaderFlags
{
	DirectSpatialMvPredFlag = 1 << 0,
	NumRefIdxActiveOverrideFlag = 1 << 1,
	NoOutputOfPriorPicsFlag = 1 << 2,
	AdaptiveRefPicMarkingModeFlag = 1 << 3,
	NoPriorReferencesAvailableFlag = 1 << 4,
}
[Flags]
public enum StdVideoEncodeH264PictureInfoFlags
{
	IdrFlag = 1 << 0,
	IsReferenceFlag = 1 << 1,
	UsedForLongTermReference = 1 << 2,
}
[Flags]
public enum StdVideoEncodeH264ReferenceInfoFlags
{
	UsedForLongTerm = 1 << 0,
}
[Flags]
public enum StdVideoEncodeH264RefMgmtFlags
{
	RefPicListModificationL0Flag = 1 << 0,
	RefPicListModificationL1Flag = 1 << 1,
}
public enum StdVideoH265ChromaFormatIdc
{
	Monochrome = 0,
	_420 = 1,
	_422 = 2,
	_444 = 3,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH265ProfileIdc
{
	Main = 1,
	Main10 = 2,
	MainStillPicture = 3,
	FormatRangeExtensions = 4,
	SccExtensions = 9,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH265LevelIdc
{
	_10 = 0,
	_20 = 1,
	_21 = 2,
	_30 = 3,
	_31 = 4,
	_40 = 5,
	_41 = 6,
	_50 = 7,
	_51 = 8,
	_52 = 9,
	_60 = 10,
	_61 = 11,
	_62 = 12,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH265SliceType
{
	B = 0,
	P = 1,
	I = 2,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH265PictureType
{
	P = 0,
	B = 1,
	I = 2,
	Idr = 3,
	Invalid = 0x7FFFFFFF,
}
public enum StdVideoH265AspectRatioIdc
{
	Unspecified = 0,
	Square = 1,
	_1211 = 2,
	_1011 = 3,
	_1611 = 4,
	_4033 = 5,
	_2411 = 6,
	_2011 = 7,
	_3211 = 8,
	_8033 = 9,
	_1811 = 10,
	_1511 = 11,
	_6433 = 12,
	_16099 = 13,
	_43 = 14,
	_32 = 15,
	_21 = 16,
	ExtendedSar = 255,
	Invalid = 0x7FFFFFFF,
}
[Flags]
public enum StdVideoH265HrdFlags
{
	NalHrdParametersPresentFlag = 1 << 0,
	VclHrdParametersPresentFlag = 1 << 1,
	SubPicHrdParamsPresentFlag = 1 << 2,
	SubPicCpbParamsInPicTimingSeiFlag = 1 << 3,
	FixedPicRateGeneralFlag0 = 1 << 4,
	FixedPicRateGeneralFlag1 = 1 << 5,
	FixedPicRateGeneralFlag2 = 1 << 6,
	FixedPicRateGeneralFlag3 = 1 << 7,
	FixedPicRateGeneralFlag4 = 1 << 8,
	FixedPicRateGeneralFlag5 = 1 << 9,
	FixedPicRateGeneralFlag6 = 1 << 10,
	FixedPicRateGeneralFlag7 = 1 << 11,
	FixedPicRateWithinCvsFlag0 = 1 << 12,
	FixedPicRateWithinCvsFlag1 = 1 << 13,
	FixedPicRateWithinCvsFlag2 = 1 << 14,
	FixedPicRateWithinCvsFlag3 = 1 << 15,
	FixedPicRateWithinCvsFlag4 = 1 << 16,
	FixedPicRateWithinCvsFlag5 = 1 << 17,
	FixedPicRateWithinCvsFlag6 = 1 << 18,
	FixedPicRateWithinCvsFlag7 = 1 << 19,
	LowDelayHrdFlag0 = 1 << 20,
	LowDelayHrdFlag1 = 1 << 21,
	LowDelayHrdFlag2 = 1 << 22,
	LowDelayHrdFlag3 = 1 << 23,
	LowDelayHrdFlag4 = 1 << 24,
	LowDelayHrdFlag5 = 1 << 25,
	LowDelayHrdFlag6 = 1 << 26,
	LowDelayHrdFlag7 = 1 << 27,
}
[Flags]
public enum StdVideoH265VpsFlags
{
	VpsTemporalIdNestingFlag = 1 << 0,
	VpsSubLayerOrderingInfoPresentFlag = 1 << 1,
	VpsTimingInfoPresentFlag = 1 << 2,
	VpsPocProportionalToTimingFlag = 1 << 3,
}
[Flags]
public enum StdVideoH265ProfileTierLevelFlags
{
	GeneralTierFlag = 1 << 0,
	GeneralProgressiveSourceFlag = 1 << 1,
	GeneralInterlacedSourceFlag = 1 << 2,
	GeneralNonPackedConstraintFlag = 1 << 3,
	GeneralFrameOnlyConstraintFlag = 1 << 4,
}
[Flags]
public enum StdVideoH265SpsVuiFlags
{
	AspectRatioInfoPresentFlag = 1 << 0,
	OverscanInfoPresentFlag = 1 << 1,
	OverscanAppropriateFlag = 1 << 2,
	VideoSignalTypePresentFlag = 1 << 3,
	VideoFullRangeFlag = 1 << 4,
	ColourDescriptionPresentFlag = 1 << 5,
	ChromaLocInfoPresentFlag = 1 << 6,
	NeutralChromaIndicationFlag = 1 << 7,
	FieldSeqFlag = 1 << 8,
	FrameFieldInfoPresentFlag = 1 << 9,
	DefaultDisplayWindowFlag = 1 << 10,
	VuiTimingInfoPresentFlag = 1 << 11,
	VuiPocProportionalToTimingFlag = 1 << 12,
	VuiHrdParametersPresentFlag = 1 << 13,
	BitstreamRestrictionFlag = 1 << 14,
	TilesFixedStructureFlag = 1 << 15,
	MotionVectorsOverPicBoundariesFlag = 1 << 16,
	RestrictedRefPicListsFlag = 1 << 17,
}
[Flags]
public enum StdVideoH265SpsFlags
{
	SpsTemporalIdNestingFlag = 1 << 0,
	SeparateColourPlaneFlag = 1 << 1,
	ConformanceWindowFlag = 1 << 2,
	SpsSubLayerOrderingInfoPresentFlag = 1 << 3,
	ScalingListEnabledFlag = 1 << 4,
	SpsScalingListDataPresentFlag = 1 << 5,
	AmpEnabledFlag = 1 << 6,
	SampleAdaptiveOffsetEnabledFlag = 1 << 7,
	PcmEnabledFlag = 1 << 8,
	PcmLoopFilterDisabledFlag = 1 << 9,
	LongTermRefPicsPresentFlag = 1 << 10,
	SpsTemporalMvpEnabledFlag = 1 << 11,
	StrongIntraSmoothingEnabledFlag = 1 << 12,
	VuiParametersPresentFlag = 1 << 13,
	SpsExtensionPresentFlag = 1 << 14,
	SpsRangeExtensionFlag = 1 << 15,
	TransformSkipRotationEnabledFlag = 1 << 16,
	TransformSkipContextEnabledFlag = 1 << 17,
	ImplicitRdpcmEnabledFlag = 1 << 18,
	ExplicitRdpcmEnabledFlag = 1 << 19,
	ExtendedPrecisionProcessingFlag = 1 << 20,
	IntraSmoothingDisabledFlag = 1 << 21,
	HighPrecisionOffsetsEnabledFlag = 1 << 22,
	PersistentRiceAdaptationEnabledFlag = 1 << 23,
	CabacBypassAlignmentEnabledFlag = 1 << 24,
	SpsSccExtensionFlag = 1 << 25,
	SpsCurrPicRefEnabledFlag = 1 << 26,
	PaletteModeEnabledFlag = 1 << 27,
	SpsPalettePredictorInitializersPresentFlag = 1 << 28,
	IntraBoundaryFilteringDisabledFlag = 1 << 29,
}
[Flags]
public enum StdVideoH265ShortTermRefPicSetFlags
{
	InterRefPicSetPredictionFlag = 1 << 0,
	DeltaRpsSign = 1 << 1,
}
[Flags]
public enum StdVideoH265PpsFlags
{
	DependentSliceSegmentsEnabledFlag = 1 << 0,
	OutputFlagPresentFlag = 1 << 1,
	SignDataHidingEnabledFlag = 1 << 2,
	CabacInitPresentFlag = 1 << 3,
	ConstrainedIntraPredFlag = 1 << 4,
	TransformSkipEnabledFlag = 1 << 5,
	CuQpDeltaEnabledFlag = 1 << 6,
	PpsSliceChromaQpOffsetsPresentFlag = 1 << 7,
	WeightedPredFlag = 1 << 8,
	WeightedBipredFlag = 1 << 9,
	TransquantBypassEnabledFlag = 1 << 10,
	TilesEnabledFlag = 1 << 11,
	EntropyCodingSyncEnabledFlag = 1 << 12,
	UniformSpacingFlag = 1 << 13,
	LoopFilterAcrossTilesEnabledFlag = 1 << 14,
	PpsLoopFilterAcrossSlicesEnabledFlag = 1 << 15,
	DeblockingFilterControlPresentFlag = 1 << 16,
	DeblockingFilterOverrideEnabledFlag = 1 << 17,
	PpsDeblockingFilterDisabledFlag = 1 << 18,
	PpsScalingListDataPresentFlag = 1 << 19,
	ListsModificationPresentFlag = 1 << 20,
	SliceSegmentHeaderExtensionPresentFlag = 1 << 21,
	PpsExtensionPresentFlag = 1 << 22,
	CrossComponentPredictionEnabledFlag = 1 << 23,
	ChromaQpOffsetListEnabledFlag = 1 << 24,
	PpsCurrPicRefEnabledFlag = 1 << 25,
	ResidualAdaptiveColourTransformEnabledFlag = 1 << 26,
	PpsSliceActQpOffsetsPresentFlag = 1 << 27,
	PpsPalettePredictorInitializersPresentFlag = 1 << 28,
	MonochromePaletteFlag = 1 << 29,
	PpsRangeExtensionFlag = 1 << 30,
}
[Flags]
public enum StdVideoDecodeH265PictureInfoFlags
{
	Irappicflag = 1 << 0,
	Idrpicflag = 1 << 1,
	Isreference = 1 << 2,
	ShortTermRefPicSetSpsFlag = 1 << 3,
}
[Flags]
public enum StdVideoDecodeH265ReferenceInfoFlags
{
	UsedForLongTerm = 1 << 0,
	UnusedForReference = 1 << 1,
}
[Flags]
public enum StdVideoEncodeH265SliceSegmentHeaderFlags
{
	FirstSliceSegmentInPicFlag = 1 << 0,
	NoOutputOfPriorPicsFlag = 1 << 1,
	DependentSliceSegmentFlag = 1 << 2,
	PicOutputFlag = 1 << 3,
	ShortTermRefPicSetSpsFlag = 1 << 4,
	SliceTemporalMvpEnableFlag = 1 << 5,
	SliceSaoLumaFlag = 1 << 6,
	SliceSaoChromaFlag = 1 << 7,
	NumRefIdxActiveOverrideFlag = 1 << 8,
	MvdL1ZeroFlag = 1 << 9,
	CabacInitFlag = 1 << 10,
	CuChromaQpOffsetEnabledFlag = 1 << 11,
	DeblockingFilterOverrideFlag = 1 << 12,
	SliceDeblockingFilterDisabledFlag = 1 << 13,
	CollocatedFromL0Flag = 1 << 14,
	SliceLoopFilterAcrossSlicesEnabledFlag = 1 << 15,
}
[Flags]
public enum StdVideoEncodeH265ReferenceModificationFlags
{
	RefPicListModificationFlagL0 = 1 << 0,
	RefPicListModificationFlagL1 = 1 << 1,
}
[Flags]
public enum StdVideoEncodeH265PictureInfoFlags
{
	IsReferenceFlag = 1 << 0,
	Irappicflag = 1 << 1,
	LongTermFlag = 1 << 2,
	DiscardableFlag = 1 << 3,
	CrossLayerBlaFlag = 1 << 4,
}
[Flags]
public enum StdVideoEncodeH265ReferenceInfoFlags
{
	UsedForLongTerm = 1 << 0,
	UnusedForReference = 1 << 1,
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
	DeferredMemoryAllocationEXT = 1 << 3,
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
public enum VkVideoCodecOperationFlagsKHR
{
	NoneKHR = 0,
	DecodeH264KHR = 1 << 0,
	DecodeH265KHR = 1 << 1,
}
[Flags]
public enum VkVideoChromaSubsamplingFlagsKHR
{
	InvalidKHR = 0,
	MonochromeKHR = 1 << 0,
	_420KHR = 1 << 1,
	_422KHR = 1 << 2,
	_444KHR = 1 << 3,
}
[Flags]
public enum VkVideoComponentBitDepthFlagsKHR
{
	InvalidKHR = 0,
	_8KHR = 1 << 0,
	_10KHR = 1 << 2,
	_12KHR = 1 << 4,
}
[Flags]
public enum VkVideoCapabilityFlagsKHR
{
	ProtectedContentKHR = 1 << 0,
	SeparateReferenceImagesKHR = 1 << 1,
}
[Flags]
public enum VkVideoSessionCreateFlagsKHR
{
	ProtectedContentKHR = 1 << 0,
}
[Flags]
public enum VkVideoSessionParametersCreateFlagsKHR
{
}
[Flags]
public enum VkVideoBeginCodingFlagsKHR
{
}
[Flags]
public enum VkVideoEndCodingFlagsKHR
{
}
[Flags]
public enum VkVideoCodingControlFlagsKHR
{
	ResetKHR = 1 << 0,
}
public enum VkQueryResultStatusKHR
{
	ErrorKHR = -1,
	NotReadyKHR = 0,
	CompleteKHR = 1,
}
[Flags]
public enum VkVideoDecodeFlagsKHR
{
}
[Flags]
public enum VkVideoDecodeCapabilityFlagsKHR
{
	DPBAndOutputCoincideKHR = 1 << 0,
	DPBAndOutputDistinctKHR = 1 << 1,
}
[Flags]
public enum VkVideoDecodeUsageFlagsKHR
{
	DefaultKHR = 0,
	TranscodingKHR = 1 << 0,
	OfflineKHR = 1 << 1,
	StreamingKHR = 1 << 2,
}
[Flags]
public enum VkPipelineRasterizationStateStreamCreateFlagsEXT
{
}
[Flags]
public enum VkVideoDecodeH264PictureLayoutFlagsKHR
{
	ProgressiveKHR = 0,
	InterlacedInterleavedLinesKHR = 1 << 0,
	InterlacedSeparatePlanesKHR = 1 << 1,
}
public enum VkShaderInfoTypeAMD
{
	StatisticsAMD = 0,
	BinaryAMD = 1,
	DisassemblyAMD = 2,
}
[Obsolete("Use VkRenderingFlags")]
[Flags]
public enum VkRenderingFlagsKHR
{
	ContentsSecondaryCommandBuffers = 1 << 0,
	[Obsolete("Use VkRenderingFlags.ContentsSecondaryCommandBuffers")]
	ContentsSecondaryCommandBuffersKHR = ContentsSecondaryCommandBuffers,
	Suspending = 1 << 1,
	[Obsolete("Use VkRenderingFlags.Suspending")]
	SuspendingKHR = Suspending,
	Resuming = 1 << 2,
	[Obsolete("Use VkRenderingFlags.Resuming")]
	ResumingKHR = Resuming,
	EnableLegacyDitheringEXT = 1 << 3,
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
public enum VkPipelineRobustnessBufferBehaviorEXT
{
	DeviceDefaultEXT = 0,
	DisabledEXT = 1,
	RobustBufferAccessEXT = 2,
	RobustBufferAccess2EXT = 3,
}
public enum VkPipelineRobustnessImageBehaviorEXT
{
	DeviceDefaultEXT = 0,
	DisabledEXT = 1,
	RobustImageAccessEXT = 2,
	RobustImageAccess2EXT = 3,
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
	DeviceAddressBindingEXT = 1 << 3,
}
[Flags]
public enum VkDebugUtilsMessengerCallbackDataFlagsEXT
{
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
	DescriptorBufferCaptureReplayEXT = 1 << 3,
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
	AllowOpacityMicromapUpdateEXT = 1 << 6,
	AllowDisableOpacityMicromapsEXT = 1 << 7,
	AllowOpacityMicromapDataUpdateEXT = 1 << 8,
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
	ForceOpacityMicromap2StateEXT = 1 << 4,
	DisableOpacityMicromapsEXT = 1 << 5,
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
	AllowOpacityMicromapUpdateEXT = 1 << 6,
	AllowDisableOpacityMicromapsEXT = 1 << 7,
	AllowOpacityMicromapDataUpdateEXT = 1 << 8,
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
	ForceOpacityMicromap2StateEXT = 1 << 4,
	DisableOpacityMicromapsEXT = 1 << 5,
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
[Obsolete("Use VkQueueGlobalPriorityKHR")]
public enum VkQueueGlobalPriorityEXT
{
	LowKHR = 128,
	MediumKHR = 256,
	HighKHR = 512,
	RealtimeKHR = 1024,
	[Obsolete("Use VkQueueGlobalPriorityKHR.LowKHR")]
	LowEXT = LowKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.MediumKHR")]
	MediumEXT = MediumKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.HighKHR")]
	HighEXT = HighKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.RealtimeKHR")]
	RealtimeEXT = RealtimeKHR,
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
public enum VkQueueGlobalPriorityKHR
{
	LowKHR = 128,
	MediumKHR = 256,
	HighKHR = 512,
	RealtimeKHR = 1024,
	[Obsolete("Use VkQueueGlobalPriorityKHR.LowKHR")]
	LowEXT = LowKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.MediumKHR")]
	MediumEXT = MediumKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.HighKHR")]
	HighEXT = HighKHR,
	[Obsolete("Use VkQueueGlobalPriorityKHR.RealtimeKHR")]
	RealtimeEXT = RealtimeKHR,
}
public enum VkMemoryOverallocationBehaviorAMD
{
	DefaultAMD = 0,
	AllowedAMD = 1,
	DisallowedAMD = 2,
}
[Obsolete("Use VkPipelineCreationFeedbackFlags")]
[Flags]
public enum VkPipelineCreationFeedbackFlagsEXT
{
	Valid = 1 << 0,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.Valid")]
	ValidEXT = Valid,
	ApplicationPipelineCacheHit = 1 << 1,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.ApplicationPipelineCacheHit")]
	ApplicationPipelineCacheHitEXT = ApplicationPipelineCacheHit,
	BasePipelineAcceleration = 1 << 2,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.BasePipelineAcceleration")]
	BasePipelineAccelerationEXT = BasePipelineAcceleration,
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
	MesaVenus = 22,
	MesaDozen = 23,
	MesaNvk = 24,
	ImaginationOpenSourceMESA = 25,
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
[Obsolete("Use VkToolPurposeFlags")]
[Flags]
public enum VkToolPurposeFlagsEXT
{
	Validation = 1 << 0,
	[Obsolete("Use VkToolPurposeFlags.Validation")]
	ValidationEXT = Validation,
	Profiling = 1 << 1,
	[Obsolete("Use VkToolPurposeFlags.Profiling")]
	ProfilingEXT = Profiling,
	Tracing = 1 << 2,
	[Obsolete("Use VkToolPurposeFlags.Tracing")]
	TracingEXT = Tracing,
	AdditionalFeatures = 1 << 3,
	[Obsolete("Use VkToolPurposeFlags.AdditionalFeatures")]
	AdditionalFeaturesEXT = AdditionalFeatures,
	ModifyingFeatures = 1 << 4,
	[Obsolete("Use VkToolPurposeFlags.ModifyingFeatures")]
	ModifyingFeaturesEXT = ModifyingFeatures,
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
public enum VkPresentScalingFlagsEXT
{
	OneToOneEXT = 1 << 0,
	AspectRatioStretchEXT = 1 << 1,
	StretchEXT = 1 << 2,
}
[Flags]
public enum VkPresentGravityFlagsEXT
{
	MinEXT = 1 << 0,
	MaxEXT = 1 << 1,
	CenteredEXT = 1 << 2,
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
	DrawMeshTasksNV = 1000328000,
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
[Obsolete("Use VkPrivateDataSlotCreateFlags")]
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
	EnableShaderErrorReportingNV = 1 << 3,
}
[Obsolete("Use VkPipelineStageFlags2")]
[Flags]
public enum VkPipelineStageFlags2KHR : long
{
	None = 0,
	[Obsolete("Use VkPipelineStageFlags2.None")]
	NoneKHR = None,
	TopOfPipe = 1 << 0,
	[Obsolete("Use VkPipelineStageFlags2.TopOfPipe")]
	TopOfPipeKHR = TopOfPipe,
	DrawIndirect = 1 << 1,
	[Obsolete("Use VkPipelineStageFlags2.DrawIndirect")]
	DrawIndirectKHR = DrawIndirect,
	VertexInput = 1 << 2,
	[Obsolete("Use VkPipelineStageFlags2.VertexInput")]
	VertexInputKHR = VertexInput,
	VertexShader = 1 << 3,
	[Obsolete("Use VkPipelineStageFlags2.VertexShader")]
	VertexShaderKHR = VertexShader,
	TessellationControlShader = 1 << 4,
	[Obsolete("Use VkPipelineStageFlags2.TessellationControlShader")]
	TessellationControlShaderKHR = TessellationControlShader,
	TessellationEvaluationShader = 1 << 5,
	[Obsolete("Use VkPipelineStageFlags2.TessellationEvaluationShader")]
	TessellationEvaluationShaderKHR = TessellationEvaluationShader,
	GeometryShader = 1 << 6,
	[Obsolete("Use VkPipelineStageFlags2.GeometryShader")]
	GeometryShaderKHR = GeometryShader,
	FragmentShader = 1 << 7,
	[Obsolete("Use VkPipelineStageFlags2.FragmentShader")]
	FragmentShaderKHR = FragmentShader,
	EarlyFragmentTests = 1 << 8,
	[Obsolete("Use VkPipelineStageFlags2.EarlyFragmentTests")]
	EarlyFragmentTestsKHR = EarlyFragmentTests,
	LateFragmentTests = 1 << 9,
	[Obsolete("Use VkPipelineStageFlags2.LateFragmentTests")]
	LateFragmentTestsKHR = LateFragmentTests,
	ColorAttachmentOutput = 1 << 10,
	[Obsolete("Use VkPipelineStageFlags2.ColorAttachmentOutput")]
	ColorAttachmentOutputKHR = ColorAttachmentOutput,
	ComputeShader = 1 << 11,
	[Obsolete("Use VkPipelineStageFlags2.ComputeShader")]
	ComputeShaderKHR = ComputeShader,
	AllTransfer = 1 << 12,
	[Obsolete("Use VkPipelineStageFlags2.AllTransfer")]
	AllTransferKHR = AllTransfer,
	[Obsolete("Use VkPipelineStageFlags2.AllTransferKHR")]
	Transfer = AllTransferKHR,
	[Obsolete("Use VkPipelineStageFlags2.AllTransfer")]
	TransferKHR = AllTransfer,
	BottomOfPipe = 1 << 13,
	[Obsolete("Use VkPipelineStageFlags2.BottomOfPipe")]
	BottomOfPipeKHR = BottomOfPipe,
	Host = 1 << 14,
	[Obsolete("Use VkPipelineStageFlags2.Host")]
	HostKHR = Host,
	AllGraphics = 1 << 15,
	[Obsolete("Use VkPipelineStageFlags2.AllGraphics")]
	AllGraphicsKHR = AllGraphics,
	AllCommands = 1 << 16,
	[Obsolete("Use VkPipelineStageFlags2.AllCommands")]
	AllCommandsKHR = AllCommands,
	Copy = 1 << 32,
	[Obsolete("Use VkPipelineStageFlags2.Copy")]
	CopyKHR = Copy,
	Resolve = 1 << 33,
	[Obsolete("Use VkPipelineStageFlags2.Resolve")]
	ResolveKHR = Resolve,
	Blit = 1 << 34,
	[Obsolete("Use VkPipelineStageFlags2.Blit")]
	BlitKHR = Blit,
	Clear = 1 << 35,
	[Obsolete("Use VkPipelineStageFlags2.Clear")]
	ClearKHR = Clear,
	IndexInput = 1 << 36,
	[Obsolete("Use VkPipelineStageFlags2.IndexInput")]
	IndexInputKHR = IndexInput,
	VertexAttributeInput = 1 << 37,
	[Obsolete("Use VkPipelineStageFlags2.VertexAttributeInput")]
	VertexAttributeInputKHR = VertexAttributeInput,
	PreRasterizationShaders = 1 << 38,
	[Obsolete("Use VkPipelineStageFlags2.PreRasterizationShaders")]
	PreRasterizationShadersKHR = PreRasterizationShaders,
	VideoDecodeKHR = 1 << 26,
	TransformFeedbackEXT = 1 << 24,
	ConditionalRenderingEXT = 1 << 18,
	CommandPreprocessNV = 1 << 17,
	FragmentShadingRateAttachmentKHR = 1 << 22,
	[Obsolete("Use VkPipelineStageFlags2.FragmentShadingRateAttachmentKHR")]
	ShadingRateImageNV = FragmentShadingRateAttachmentKHR,
	AccelerationStructureBuildKHR = 1 << 25,
	RayTracingShaderKHR = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags2.RayTracingShaderKHR")]
	RayTracingShaderNV = RayTracingShaderKHR,
	[Obsolete("Use VkPipelineStageFlags2.AccelerationStructureBuildKHR")]
	AccelerationStructureBuildNV = AccelerationStructureBuildKHR,
	FragmentDensityProcessEXT = 1 << 23,
	[Obsolete("Use VkPipelineStageFlags2.TaskShaderEXT")]
	TaskShaderNV = TaskShaderEXT,
	[Obsolete("Use VkPipelineStageFlags2.MeshShaderEXT")]
	MeshShaderNV = MeshShaderEXT,
	TaskShaderEXT = 1 << 19,
	MeshShaderEXT = 1 << 20,
	SubpassShadingHUAWEI = 1 << 39,
	InvocationMaskHUAWEI = 1 << 40,
	AccelerationStructureCopyKHR = 1 << 28,
	MicromapBuildEXT = 1 << 30,
	ClusterCullingShaderHUAWEI = 1 << 41,
	OpticalFlowNV = 1 << 29,
}
[Obsolete("Use VkAccessFlags2")]
[Flags]
public enum VkAccessFlags2KHR : long
{
	None = 0,
	[Obsolete("Use VkAccessFlags2.None")]
	NoneKHR = None,
	IndirectCommandRead = 1 << 0,
	[Obsolete("Use VkAccessFlags2.IndirectCommandRead")]
	IndirectCommandReadKHR = IndirectCommandRead,
	IndexRead = 1 << 1,
	[Obsolete("Use VkAccessFlags2.IndexRead")]
	IndexReadKHR = IndexRead,
	VertexAttributeRead = 1 << 2,
	[Obsolete("Use VkAccessFlags2.VertexAttributeRead")]
	VertexAttributeReadKHR = VertexAttributeRead,
	UniformRead = 1 << 3,
	[Obsolete("Use VkAccessFlags2.UniformRead")]
	UniformReadKHR = UniformRead,
	InputAttachmentRead = 1 << 4,
	[Obsolete("Use VkAccessFlags2.InputAttachmentRead")]
	InputAttachmentReadKHR = InputAttachmentRead,
	ShaderRead = 1 << 5,
	[Obsolete("Use VkAccessFlags2.ShaderRead")]
	ShaderReadKHR = ShaderRead,
	ShaderWrite = 1 << 6,
	[Obsolete("Use VkAccessFlags2.ShaderWrite")]
	ShaderWriteKHR = ShaderWrite,
	ColorAttachmentRead = 1 << 7,
	[Obsolete("Use VkAccessFlags2.ColorAttachmentRead")]
	ColorAttachmentReadKHR = ColorAttachmentRead,
	ColorAttachmentWrite = 1 << 8,
	[Obsolete("Use VkAccessFlags2.ColorAttachmentWrite")]
	ColorAttachmentWriteKHR = ColorAttachmentWrite,
	DepthStencilAttachmentRead = 1 << 9,
	[Obsolete("Use VkAccessFlags2.DepthStencilAttachmentRead")]
	DepthStencilAttachmentReadKHR = DepthStencilAttachmentRead,
	DepthStencilAttachmentWrite = 1 << 10,
	[Obsolete("Use VkAccessFlags2.DepthStencilAttachmentWrite")]
	DepthStencilAttachmentWriteKHR = DepthStencilAttachmentWrite,
	TransferRead = 1 << 11,
	[Obsolete("Use VkAccessFlags2.TransferRead")]
	TransferReadKHR = TransferRead,
	TransferWrite = 1 << 12,
	[Obsolete("Use VkAccessFlags2.TransferWrite")]
	TransferWriteKHR = TransferWrite,
	HostRead = 1 << 13,
	[Obsolete("Use VkAccessFlags2.HostRead")]
	HostReadKHR = HostRead,
	HostWrite = 1 << 14,
	[Obsolete("Use VkAccessFlags2.HostWrite")]
	HostWriteKHR = HostWrite,
	MemoryRead = 1 << 15,
	[Obsolete("Use VkAccessFlags2.MemoryRead")]
	MemoryReadKHR = MemoryRead,
	MemoryWrite = 1 << 16,
	[Obsolete("Use VkAccessFlags2.MemoryWrite")]
	MemoryWriteKHR = MemoryWrite,
	ShaderSampledRead = 1 << 32,
	[Obsolete("Use VkAccessFlags2.ShaderSampledRead")]
	ShaderSampledReadKHR = ShaderSampledRead,
	ShaderStorageRead = 1 << 33,
	[Obsolete("Use VkAccessFlags2.ShaderStorageRead")]
	ShaderStorageReadKHR = ShaderStorageRead,
	ShaderStorageWrite = 1 << 34,
	[Obsolete("Use VkAccessFlags2.ShaderStorageWrite")]
	ShaderStorageWriteKHR = ShaderStorageWrite,
	VideoDecodeReadKHR = 1 << 35,
	VideoDecodeWriteKHR = 1 << 36,
	TransformFeedbackWriteEXT = 1 << 25,
	TransformFeedbackCounterReadEXT = 1 << 26,
	TransformFeedbackCounterWriteEXT = 1 << 27,
	ConditionalRenderingReadEXT = 1 << 20,
	CommandPreprocessReadNV = 1 << 17,
	CommandPreprocessWriteNV = 1 << 18,
	FragmentShadingRateAttachmentReadKHR = 1 << 23,
	[Obsolete("Use VkAccessFlags2.FragmentShadingRateAttachmentReadKHR")]
	ShadingRateImageReadNV = FragmentShadingRateAttachmentReadKHR,
	AccelerationStructureReadKHR = 1 << 21,
	AccelerationStructureWriteKHR = 1 << 22,
	[Obsolete("Use VkAccessFlags2.AccelerationStructureReadKHR")]
	AccelerationStructureReadNV = AccelerationStructureReadKHR,
	[Obsolete("Use VkAccessFlags2.AccelerationStructureWriteKHR")]
	AccelerationStructureWriteNV = AccelerationStructureWriteKHR,
	FragmentDensityMapReadEXT = 1 << 24,
	ColorAttachmentReadNoncoherentEXT = 1 << 19,
	DescriptorBufferReadEXT = 1 << 41,
	InvocationMaskReadHUAWEI = 1 << 39,
	ShaderBindingTableReadKHR = 1 << 40,
	MicromapReadEXT = 1 << 44,
	MicromapWriteEXT = 1 << 45,
	OpticalFlowReadNV = 1 << 42,
	OpticalFlowWriteNV = 1 << 43,
}
[Obsolete("Use VkSubmitFlags")]
[Flags]
public enum VkSubmitFlagsKHR
{
	Protected = 1 << 0,
	[Obsolete("Use VkSubmitFlags.Protected")]
	ProtectedKHR = Protected,
}
[Flags]
public enum VkGraphicsPipelineLibraryFlagsEXT
{
	VertexInputInterfaceEXT = 1 << 0,
	PreRasterizationShadersEXT = 1 << 1,
	FragmentShaderEXT = 1 << 2,
	FragmentOutputInterfaceEXT = 1 << 3,
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
[Flags]
public enum VkImageCompressionFlagsEXT
{
	DefaultEXT = 0,
	FixedRateDefaultEXT = 1 << 0,
	FixedRateExplicitEXT = 1 << 1,
	DisabledEXT = 1 << 2,
}
[Flags]
public enum VkImageCompressionFixedRateFlagsEXT
{
	NoneEXT = 0,
	_1BPCEXT = 1 << 0,
	_2BPCEXT = 1 << 1,
	_3BPCEXT = 1 << 2,
	_4BPCEXT = 1 << 3,
	_5BPCEXT = 1 << 4,
	_6BPCEXT = 1 << 5,
	_7BPCEXT = 1 << 6,
	_8BPCEXT = 1 << 7,
	_9BPCEXT = 1 << 8,
	_10BPCEXT = 1 << 9,
	_11BPCEXT = 1 << 10,
	_12BPCEXT = 1 << 11,
	_13BPCEXT = 1 << 12,
	_14BPCEXT = 1 << 13,
	_15BPCEXT = 1 << 14,
	_16BPCEXT = 1 << 15,
	_17BPCEXT = 1 << 16,
	_18BPCEXT = 1 << 17,
	_19BPCEXT = 1 << 18,
	_20BPCEXT = 1 << 19,
	_21BPCEXT = 1 << 20,
	_22BPCEXT = 1 << 21,
	_23BPCEXT = 1 << 22,
	_24BPCEXT = 1 << 23,
}
public enum VkDeviceFaultAddressTypeEXT
{
	NoneEXT = 0,
	ReadInvalidEXT = 1,
	WriteInvalidEXT = 2,
	ExecuteInvalidEXT = 3,
	InstructionPointerUnknownEXT = 4,
	InstructionPointerInvalidEXT = 5,
	InstructionPointerFaultEXT = 6,
}
public enum VkDeviceFaultVendorBinaryHeaderVersionEXT
{
	OneEXT = 1,
}
[Flags]
public enum VkDeviceAddressBindingFlagsEXT
{
	InternalObjectEXT = 1 << 0,
}
public enum VkDeviceAddressBindingTypeEXT
{
	BindEXT = 0,
	UnbindEXT = 1,
}
[Obsolete("Use VkFormatFeatureFlags2")]
[Flags]
public enum VkFormatFeatureFlags2KHR : long
{
	SampledImage = 1 << 0,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImage")]
	SampledImageKHR = SampledImage,
	StorageImage = 1 << 1,
	[Obsolete("Use VkFormatFeatureFlags2.StorageImage")]
	StorageImageKHR = StorageImage,
	StorageImageAtomic = 1 << 2,
	[Obsolete("Use VkFormatFeatureFlags2.StorageImageAtomic")]
	StorageImageAtomicKHR = StorageImageAtomic,
	UniformTexelBuffer = 1 << 3,
	[Obsolete("Use VkFormatFeatureFlags2.UniformTexelBuffer")]
	UniformTexelBufferKHR = UniformTexelBuffer,
	StorageTexelBuffer = 1 << 4,
	[Obsolete("Use VkFormatFeatureFlags2.StorageTexelBuffer")]
	StorageTexelBufferKHR = StorageTexelBuffer,
	StorageTexelBufferAtomic = 1 << 5,
	[Obsolete("Use VkFormatFeatureFlags2.StorageTexelBufferAtomic")]
	StorageTexelBufferAtomicKHR = StorageTexelBufferAtomic,
	VertexBuffer = 1 << 6,
	[Obsolete("Use VkFormatFeatureFlags2.VertexBuffer")]
	VertexBufferKHR = VertexBuffer,
	ColorAttachment = 1 << 7,
	[Obsolete("Use VkFormatFeatureFlags2.ColorAttachment")]
	ColorAttachmentKHR = ColorAttachment,
	ColorAttachmentBlend = 1 << 8,
	[Obsolete("Use VkFormatFeatureFlags2.ColorAttachmentBlend")]
	ColorAttachmentBlendKHR = ColorAttachmentBlend,
	DepthStencilAttachment = 1 << 9,
	[Obsolete("Use VkFormatFeatureFlags2.DepthStencilAttachment")]
	DepthStencilAttachmentKHR = DepthStencilAttachment,
	BlitSource = 1 << 10,
	[Obsolete("Use VkFormatFeatureFlags2.BlitSource")]
	BlitSourceKHR = BlitSource,
	BlitDestination = 1 << 11,
	[Obsolete("Use VkFormatFeatureFlags2.BlitDestination")]
	BlitDestinationKHR = BlitDestination,
	SampledImageFilterLinear = 1 << 12,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterLinear")]
	SampledImageFilterLinearKHR = SampledImageFilterLinear,
	SampledImageFilterCubic = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterCubic")]
	SampledImageFilterCubicEXT = SampledImageFilterCubic,
	TransferSource = 1 << 14,
	[Obsolete("Use VkFormatFeatureFlags2.TransferSource")]
	TransferSourceKHR = TransferSource,
	TransferDestination = 1 << 15,
	[Obsolete("Use VkFormatFeatureFlags2.TransferDestination")]
	TransferDestinationKHR = TransferDestination,
	SampledImageFilterMinmax = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageFilterMinmax")]
	SampledImageFilterMinmaxKHR = SampledImageFilterMinmax,
	MidpointChromaSamples = 1 << 17,
	[Obsolete("Use VkFormatFeatureFlags2.MidpointChromaSamples")]
	MidpointChromaSamplesKHR = MidpointChromaSamples,
	SampledImageYCBCRConversionLinearFilter = 1 << 18,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionLinearFilter")]
	SampledImageYCBCRConversionLinearFilterKHR = SampledImageYCBCRConversionLinearFilter,
	SampledImageYCBCRConversionSeparateReconstructionFilter = 1 << 19,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionSeparateReconstructionFilter")]
	SampledImageYCBCRConversionSeparateReconstructionFilterKHR = SampledImageYCBCRConversionSeparateReconstructionFilter,
	SampledImageYCBCRConversionChromaReconstructionExplicit = 1 << 20,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionChromaReconstructionExplicit")]
	SampledImageYCBCRConversionChromaReconstructionExplicitKHR = SampledImageYCBCRConversionChromaReconstructionExplicit,
	SampledImageYCBCRConversionChromaReconstructionExplicitForceable = 1 << 21,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageYCBCRConversionChromaReconstructionExplicitForceable")]
	SampledImageYCBCRConversionChromaReconstructionExplicitForceableKHR = SampledImageYCBCRConversionChromaReconstructionExplicitForceable,
	Disjoint = 1 << 22,
	[Obsolete("Use VkFormatFeatureFlags2.Disjoint")]
	DisjointKHR = Disjoint,
	CositedChromaSamples = 1 << 23,
	[Obsolete("Use VkFormatFeatureFlags2.CositedChromaSamples")]
	CositedChromaSamplesKHR = CositedChromaSamples,
	StorageReadWithoutFormat = 1 << 31,
	[Obsolete("Use VkFormatFeatureFlags2.StorageReadWithoutFormat")]
	StorageReadWithoutFormatKHR = StorageReadWithoutFormat,
	StorageWriteWithoutFormat = 1 << 32,
	[Obsolete("Use VkFormatFeatureFlags2.StorageWriteWithoutFormat")]
	StorageWriteWithoutFormatKHR = StorageWriteWithoutFormat,
	SampledImageDepthComparison = 1 << 33,
	[Obsolete("Use VkFormatFeatureFlags2.SampledImageDepthComparison")]
	SampledImageDepthComparisonKHR = SampledImageDepthComparison,
	VideoDecodeOutputKHR = 1 << 25,
	VideoDecodeDPBKHR = 1 << 26,
	AccelerationStructureVertexBufferKHR = 1 << 29,
	FragmentDensityMapEXT = 1 << 24,
	FragmentShadingRateAttachmentKHR = 1 << 30,
	LinearColorAttachmentNV = 1 << 38,
	WeightImageQCOM = 1 << 34,
	WeightSampledImageQCOM = 1 << 35,
	BlockMatchingQCOM = 1 << 36,
	BoxFilterSampledQCOM = 1 << 37,
	OpticalFlowImageNV = 1 << 40,
	OpticalFlowVectorNV = 1 << 41,
	OpticalFlowCostNV = 1 << 42,
}
[Flags]
public enum VkMicromapCreateFlagsEXT
{
	DeviceAddressCaptureReplayEXT = 1 << 0,
}
public enum VkMicromapTypeEXT
{
	OpacityMicromapEXT = 0,
}
[Flags]
public enum VkBuildMicromapFlagsEXT
{
	PreferFastTraceEXT = 1 << 0,
	PreferFastBuildEXT = 1 << 1,
	AllowCompactionEXT = 1 << 2,
}
public enum VkBuildMicromapModeEXT
{
	BuildEXT = 0,
}
public enum VkCopyMicromapModeEXT
{
	CloneEXT = 0,
	SerializeEXT = 1,
	DeserializeEXT = 2,
	CompactEXT = 3,
}
public enum VkOpacityMicromapFormatEXT
{
	_2StateEXT = 1,
	_4StateEXT = 2,
}
public enum VkOpacityMicromapSpecialIndexEXT
{
	FullyTransparentEXT = -1,
	FullyOpaqueEXT = -2,
	FullyUnknownTransparentEXT = -3,
	FullyUnknownOpaqueEXT = -4,
}
[Flags]
public enum VkMemoryDecompressionMethodFlagsNV : long
{
	GDeflate10NV = 1 << 0,
}
public enum VkSubpassMergeStatusEXT
{
	MergedEXT = 0,
	DisallowedEXT = 1,
	NotMergedSideEffectsEXT = 2,
	NotMergedSamplesMismatchEXT = 3,
	NotMergedViewsMismatchEXT = 4,
	NotMergedAliasingEXT = 5,
	NotMergedDependenciesEXT = 6,
	NotMergedIncompatibleInputAttachmentEXT = 7,
	NotMergedTooManyAttachmentsEXT = 8,
	NotMergedInsufficientStorageEXT = 9,
	NotMergedDepthStencilCountEXT = 10,
	NotMergedResolveAttachmentReuseEXT = 11,
	NotMergedSingleSubpassEXT = 12,
	NotMergedUnspecifiedEXT = 13,
}
[Flags]
public enum VkDirectDriverLoadingFlagsLUNARG
{
}
public enum VkDirectDriverLoadingModeLUNARG
{
	ExclusiveLUNARG = 0,
	InclusiveLUNARG = 1,
}
[Flags]
public enum VkOpticalFlowUsageFlagsNV
{
	UnknownNV = 0,
	InputNV = 1 << 0,
	OutputNV = 1 << 1,
	HintNV = 1 << 2,
	CostNV = 1 << 3,
	GlobalFlowNV = 1 << 4,
}
[Flags]
public enum VkOpticalFlowGridSizeFlagsNV
{
	UnknownNV = 0,
	_1x1NV = 1 << 0,
	_2x2NV = 1 << 1,
	_4x4NV = 1 << 2,
	_8x8NV = 1 << 3,
}
public enum VkOpticalFlowPerformanceLevelNV
{
	UnknownNV = 0,
	SlowNV = 1,
	MediumNV = 2,
	FastNV = 3,
}
[Flags]
public enum VkOpticalFlowSessionCreateFlagsNV
{
	EnableHintNV = 1 << 0,
	EnableCostNV = 1 << 1,
	EnableGlobalFlowNV = 1 << 2,
	AllowRegionsNV = 1 << 3,
	BothDirectionsNV = 1 << 4,
}
public enum VkOpticalFlowSessionBindingPointNV
{
	UnknownNV = 0,
	InputNV = 1,
	ReferenceNV = 2,
	HintNV = 3,
	FlowVectorNV = 4,
	BackwardFlowVectorNV = 5,
	CostNV = 6,
	BackwardCostNV = 7,
	GlobalFlowNV = 8,
}
[Flags]
public enum VkOpticalFlowExecuteFlagsNV
{
	DisableTemporalHintsNV = 1 << 0,
}
public enum VkRayTracingInvocationReorderModeNV
{
	NoneNV = 0,
	ReorderNV = 1,
}
