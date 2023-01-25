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
	ErrorSurfaceLostKhr = -1000000000,
	ErrorNativeWindowInUseKhr = -1000000001,
	SuboptimalKhr = 1000001003,
	ErrorOutOfDateKhr = -1000001004,
	ErrorIncompatibleDisplayKhr = -1000003001,
	ErrorValidationFailedExt = -1000011001,
	ErrorInvalidShaderNv = -1000012000,
	ErrorImageUsageNotSupportedKhr = -1000023000,
	ErrorVideoPictureLayoutNotSupportedKhr = -1000023001,
	ErrorVideoProfileOperationNotSupportedKhr = -1000023002,
	ErrorVideoProfileFormatNotSupportedKhr = -1000023003,
	ErrorVideoProfileCodecNotSupportedKhr = -1000023004,
	ErrorVideoStdVersionNotSupportedKhr = -1000023005,
	[Obsolete("Use VkResult.ErrorOutOfPoolMemory")]
	ErrorOutOfPoolMemoryKhr = ErrorOutOfPoolMemory,
	[Obsolete("Use VkResult.ErrorInvalidExternalHandle")]
	ErrorInvalidExternalHandleKhr = ErrorInvalidExternalHandle,
	ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
	[Obsolete("Use VkResult.ErrorFragmentation")]
	ErrorFragmentationExt = ErrorFragmentation,
	[Obsolete("Use VkResult.ErrorNotPermittedKhr")]
	ErrorNotPermittedExt = ErrorNotPermittedKhr,
	ErrorNotPermittedKhr = -1000188001,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidDeviceAddressExt = ErrorInvalidOpaqueCaptureAddress,
	ErrorFullScreenExclusiveModeLostExt = -1000255000,
	[Obsolete("Use VkResult.ErrorInvalidOpaqueCaptureAddress")]
	ErrorInvalidOpaqueCaptureAddressKhr = ErrorInvalidOpaqueCaptureAddress,
	ThreadIdleKhr = 1000268000,
	ThreadDoneKhr = 1000268001,
	OperationDeferredKhr = 1000268002,
	OperationNotDeferredKhr = 1000268003,
	[Obsolete("Use VkResult.PipelineCompileRequired")]
	PipelineCompileRequiredExt = PipelineCompileRequired,
	[Obsolete("Use VkResult.PipelineCompileRequired")]
	ErrorPipelineCompileRequiredExt = PipelineCompileRequired,
	ErrorCompressionExhaustedExt = -1000338000,
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
	SamplerYcbcrConversionCreateInfo = 1000156000,
	SamplerYcbcrConversionInfo = 1000156001,
	BindImagePlaneMemoryInfo = 1000156002,
	ImagePlaneMemoryRequirementsInfo = 1000156003,
	PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
	SamplerYcbcrConversionImageFormatProperties = 1000156005,
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
	PhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,
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
	VideoProfileInfoKhr = 1000023000,
	VideoCapabilitiesKhr = 1000023001,
	VideoPictureResourceInfoKhr = 1000023002,
	VideoSessionMemoryRequirementsKhr = 1000023003,
	BindVideoSessionMemoryInfoKhr = 1000023004,
	VideoSessionCreateInfoKhr = 1000023005,
	VideoSessionParametersCreateInfoKhr = 1000023006,
	VideoSessionParametersUpdateInfoKhr = 1000023007,
	VideoBeginCodingInfoKhr = 1000023008,
	VideoEndCodingInfoKhr = 1000023009,
	VideoCodingControlInfoKhr = 1000023010,
	VideoReferenceSlotInfoKhr = 1000023011,
	QueueFamilyVideoPropertiesKhr = 1000023012,
	VideoProfileListInfoKhr = 1000023013,
	PhysicalDeviceVideoFormatInfoKhr = 1000023014,
	VideoFormatPropertiesKhr = 1000023015,
	QueueFamilyQueryResultStatusPropertiesKhr = 1000023016,
	VideoDecodeInfoKhr = 1000024000,
	VideoDecodeCapabilitiesKhr = 1000024001,
	VideoDecodeUsageInfoKhr = 1000024002,
	DedicatedAllocationImageCreateInfoNv = 1000026000,
	DedicatedAllocationBufferCreateInfoNv = 1000026001,
	DedicatedAllocationMemoryAllocateInfoNv = 1000026002,
	PhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
	PhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
	PipelineRasterizationStateStreamCreateInfoExt = 1000028002,
	CuModuleCreateInfoNvx = 1000029000,
	CuFunctionCreateInfoNvx = 1000029001,
	CuLaunchInfoNvx = 1000029002,
	ImageViewHandleInfoNvx = 1000030000,
	ImageViewAddressPropertiesNvx = 1000030001,
	VideoDecodeH264CapabilitiesKhr = 1000040000,
	VideoDecodeH264PictureInfoKhr = 1000040001,
	VideoDecodeH264ProfileInfoKhr = 1000040003,
	VideoDecodeH264SessionParametersCreateInfoKhr = 1000040004,
	VideoDecodeH264SessionParametersAddInfoKhr = 1000040005,
	VideoDecodeH264DpbSlotInfoKhr = 1000040006,
	TextureLodGatherFormatPropertiesAmd = 1000041000,
	[Obsolete("Use VkStructureType.RenderingInfo")]
	RenderingInfoKhr = RenderingInfo,
	[Obsolete("Use VkStructureType.RenderingAttachmentInfo")]
	RenderingAttachmentInfoKhr = RenderingAttachmentInfo,
	[Obsolete("Use VkStructureType.PipelineRenderingCreateInfo")]
	PipelineRenderingCreateInfoKhr = PipelineRenderingCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceDynamicRenderingFeatures")]
	PhysicalDeviceDynamicRenderingFeaturesKhr = PhysicalDeviceDynamicRenderingFeatures,
	[Obsolete("Use VkStructureType.CommandBufferInheritanceRenderingInfo")]
	CommandBufferInheritanceRenderingInfoKhr = CommandBufferInheritanceRenderingInfo,
	RenderingFragmentShadingRateAttachmentInfoKhr = 1000044006,
	RenderingFragmentDensityMapAttachmentInfoExt = 1000044007,
	AttachmentSampleCountInfoAmd = 1000044008,
	[Obsolete("Use VkStructureType.AttachmentSampleCountInfoAmd")]
	AttachmentSampleCountInfoNv = AttachmentSampleCountInfoAmd,
	MultiviewPerViewAttributesInfoNvx = 1000044009,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeatures")]
	PhysicalDeviceTextureCompressionAstcHdrFeaturesExt = PhysicalDeviceTextureCompressionAstcHdrFeatures,
	ImageViewAstcDecodeModeExt = 1000067000,
	PhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
	PipelineRobustnessCreateInfoExt = 1000068000,
	PhysicalDevicePipelineRobustnessFeaturesExt = 1000068001,
	PhysicalDevicePipelineRobustnessPropertiesExt = 1000068002,
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
	D3d12FenceSubmitInfoKhr = 1000078002,
	SemaphoreGetWin32HandleInfoKhr = 1000078003,
	ImportSemaphoreFileDescriptorInfoKhr = 1000079000,
	SemaphoreGetFileDescriptorInfoKhr = 1000079001,
	PhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
	CommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
	PhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
	ConditionalRenderingBeginInfoExt = 1000081002,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8Features")]
	PhysicalDeviceShaderFloat16Int8FeaturesKhr = PhysicalDeviceShaderFloat16Int8Features,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderFloat16Int8Features")]
	PhysicalDeviceFloat16Int8FeaturesKhr = PhysicalDeviceShaderFloat16Int8Features,
	[Obsolete("Use VkStructureType.PhysicalDevice16bitStorageFeatures")]
	PhysicalDevice16bitStorageFeaturesKhr = PhysicalDevice16bitStorageFeatures,
	PresentRegionsKhr = 1000084000,
	[Obsolete("Use VkStructureType.DescriptorUpdateTemplateCreateInfo")]
	DescriptorUpdateTemplateCreateInfoKhr = DescriptorUpdateTemplateCreateInfo,
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
	HdrMetadataExt = 1000105000,
	[Obsolete("Use VkStructureType.PhysicalDeviceImagelessFramebufferFeatures")]
	PhysicalDeviceImagelessFramebufferFeaturesKhr = PhysicalDeviceImagelessFramebufferFeatures,
	[Obsolete("Use VkStructureType.FramebufferAttachmentsCreateInfo")]
	FramebufferAttachmentsCreateInfoKhr = FramebufferAttachmentsCreateInfo,
	[Obsolete("Use VkStructureType.FramebufferAttachmentImageInfo")]
	FramebufferAttachmentImageInfoKhr = FramebufferAttachmentImageInfo,
	[Obsolete("Use VkStructureType.RenderPassAttachmentBeginInfo")]
	RenderPassAttachmentBeginInfoKhr = RenderPassAttachmentBeginInfo,
	[Obsolete("Use VkStructureType.AttachmentDescription2")]
	AttachmentDescription2Khr = AttachmentDescription2,
	[Obsolete("Use VkStructureType.AttachmentReference2")]
	AttachmentReference2Khr = AttachmentReference2,
	[Obsolete("Use VkStructureType.SubpassDescription2")]
	SubpassDescription2Khr = SubpassDescription2,
	[Obsolete("Use VkStructureType.SubpassDependency2")]
	SubpassDependency2Khr = SubpassDependency2,
	[Obsolete("Use VkStructureType.RenderPassCreateInfo2")]
	RenderPassCreateInfo2Khr = RenderPassCreateInfo2,
	[Obsolete("Use VkStructureType.SubpassBeginInfo")]
	SubpassBeginInfoKhr = SubpassBeginInfo,
	[Obsolete("Use VkStructureType.SubpassEndInfo")]
	SubpassEndInfoKhr = SubpassEndInfo,
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
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointersFeatures")]
	PhysicalDeviceVariablePointersFeaturesKhr = PhysicalDeviceVariablePointersFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceVariablePointersFeaturesKhr")]
	PhysicalDeviceVariablePointerFeaturesKhr = PhysicalDeviceVariablePointersFeaturesKhr,
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
	AndroidHardwareBufferFormatProperties2Android = 1000129006,
	[Obsolete("Use VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties")]
	PhysicalDeviceSamplerFilterMinmaxPropertiesExt = PhysicalDeviceSamplerFilterMinmaxProperties,
	[Obsolete("Use VkStructureType.SamplerReductionModeCreateInfo")]
	SamplerReductionModeCreateInfoExt = SamplerReductionModeCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceInlineUniformBlockFeatures")]
	PhysicalDeviceInlineUniformBlockFeaturesExt = PhysicalDeviceInlineUniformBlockFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceInlineUniformBlockProperties")]
	PhysicalDeviceInlineUniformBlockPropertiesExt = PhysicalDeviceInlineUniformBlockProperties,
	[Obsolete("Use VkStructureType.WriteDescriptorSetInlineUniformBlock")]
	WriteDescriptorSetInlineUniformBlockExt = WriteDescriptorSetInlineUniformBlock,
	[Obsolete("Use VkStructureType.DescriptorPoolInlineUniformBlockCreateInfo")]
	DescriptorPoolInlineUniformBlockCreateInfoExt = DescriptorPoolInlineUniformBlockCreateInfo,
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
	[Obsolete("Use VkStructureType.ImageFormatListCreateInfo")]
	ImageFormatListCreateInfoKhr = ImageFormatListCreateInfo,
	PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
	PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
	PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
	PipelineCoverageToColorStateCreateInfoNv = 1000149000,
	WriteDescriptorSetAccelerationStructureKhr = 1000150007,
	AccelerationStructureBuildGeometryInfoKhr = 1000150000,
	AccelerationStructureDeviceAddressInfoKhr = 1000150002,
	AccelerationStructureGeometryAabbsDataKhr = 1000150003,
	AccelerationStructureGeometryInstancesDataKhr = 1000150004,
	AccelerationStructureGeometryTrianglesDataKhr = 1000150005,
	AccelerationStructureGeometryKhr = 1000150006,
	AccelerationStructureVersionInfoKhr = 1000150009,
	CopyAccelerationStructureInfoKhr = 1000150010,
	CopyAccelerationStructureToMemoryInfoKhr = 1000150011,
	CopyMemoryToAccelerationStructureInfoKhr = 1000150012,
	PhysicalDeviceAccelerationStructureFeaturesKhr = 1000150013,
	PhysicalDeviceAccelerationStructurePropertiesKhr = 1000150014,
	AccelerationStructureCreateInfoKhr = 1000150017,
	AccelerationStructureBuildSizesInfoKhr = 1000150020,
	PhysicalDeviceRayTracingPipelineFeaturesKhr = 1000347000,
	PhysicalDeviceRayTracingPipelinePropertiesKhr = 1000347001,
	RayTracingPipelineCreateInfoKhr = 1000347015,
	RayTracingShaderGroupCreateInfoKhr = 1000347016,
	RayTracingPipelineInterfaceCreateInfoKhr = 1000347018,
	PhysicalDeviceRayQueryFeaturesKhr = 1000348013,
	PipelineCoverageModulationStateCreateInfoNv = 1000152000,
	PhysicalDeviceShaderSmBuiltinsFeaturesNv = 1000154000,
	PhysicalDeviceShaderSmBuiltinsPropertiesNv = 1000154001,
	[Obsolete("Use VkStructureType.SamplerYcbcrConversionCreateInfo")]
	SamplerYcbcrConversionCreateInfoKhr = SamplerYcbcrConversionCreateInfo,
	[Obsolete("Use VkStructureType.SamplerYcbcrConversionInfo")]
	SamplerYcbcrConversionInfoKhr = SamplerYcbcrConversionInfo,
	[Obsolete("Use VkStructureType.BindImagePlaneMemoryInfo")]
	BindImagePlaneMemoryInfoKhr = BindImagePlaneMemoryInfo,
	[Obsolete("Use VkStructureType.ImagePlaneMemoryRequirementsInfo")]
	ImagePlaneMemoryRequirementsInfoKhr = ImagePlaneMemoryRequirementsInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures")]
	PhysicalDeviceSamplerYcbcrConversionFeaturesKhr = PhysicalDeviceSamplerYcbcrConversionFeatures,
	[Obsolete("Use VkStructureType.SamplerYcbcrConversionImageFormatProperties")]
	SamplerYcbcrConversionImageFormatPropertiesKhr = SamplerYcbcrConversionImageFormatProperties,
	[Obsolete("Use VkStructureType.BindBufferMemoryInfo")]
	BindBufferMemoryInfoKhr = BindBufferMemoryInfo,
	[Obsolete("Use VkStructureType.BindImageMemoryInfo")]
	BindImageMemoryInfoKhr = BindImageMemoryInfo,
	DrmFormatModifierPropertiesListExt = 1000158000,
	PhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
	ImageDrmFormatModifierListCreateInfoExt = 1000158003,
	ImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
	ImageDrmFormatModifierPropertiesExt = 1000158005,
	DrmFormatModifierPropertiesList2Ext = 1000158006,
	ValidationCacheCreateInfoExt = 1000160000,
	ShaderModuleValidationCacheCreateInfoExt = 1000160001,
	[Obsolete("Use VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfo")]
	DescriptorSetLayoutBindingFlagsCreateInfoExt = DescriptorSetLayoutBindingFlagsCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceDescriptorIndexingFeatures")]
	PhysicalDeviceDescriptorIndexingFeaturesExt = PhysicalDeviceDescriptorIndexingFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceDescriptorIndexingProperties")]
	PhysicalDeviceDescriptorIndexingPropertiesExt = PhysicalDeviceDescriptorIndexingProperties,
	[Obsolete("Use VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo")]
	DescriptorSetVariableDescriptorCountAllocateInfoExt = DescriptorSetVariableDescriptorCountAllocateInfo,
	[Obsolete("Use VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport")]
	DescriptorSetVariableDescriptorCountLayoutSupportExt = DescriptorSetVariableDescriptorCountLayoutSupport,
	PipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
	PhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
	PhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
	PipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
	RayTracingPipelineCreateInfoNv = 1000165000,
	AccelerationStructureCreateInfoNv = 1000165001,
	GeometryNv = 1000165003,
	GeometryTrianglesNv = 1000165004,
	GeometryAabbNv = 1000165005,
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
	[Obsolete("Use VkStructureType.DeviceQueueGlobalPriorityCreateInfoKhr")]
	DeviceQueueGlobalPriorityCreateInfoExt = DeviceQueueGlobalPriorityCreateInfoKhr,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures")]
	PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = PhysicalDeviceShaderSubgroupExtendedTypesFeatures,
	[Obsolete("Use VkStructureType.PhysicalDevice8bitStorageFeatures")]
	PhysicalDevice8bitStorageFeaturesKhr = PhysicalDevice8bitStorageFeatures,
	ImportMemoryHostPointerInfoExt = 1000178000,
	MemoryHostPointerPropertiesExt = 1000178001,
	PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderAtomicInt64Features")]
	PhysicalDeviceShaderAtomicInt64FeaturesKhr = PhysicalDeviceShaderAtomicInt64Features,
	PhysicalDeviceShaderClockFeaturesKhr = 1000181000,
	PipelineCompilerControlCreateInfoAmd = 1000183000,
	CalibratedTimestampInfoExt = 1000184000,
	PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
	VideoDecodeH265CapabilitiesKhr = 1000187000,
	VideoDecodeH265SessionParametersCreateInfoKhr = 1000187001,
	VideoDecodeH265SessionParametersAddInfoKhr = 1000187002,
	VideoDecodeH265ProfileInfoKhr = 1000187003,
	VideoDecodeH265PictureInfoKhr = 1000187004,
	VideoDecodeH265DpbSlotInfoKhr = 1000187005,
	DeviceQueueGlobalPriorityCreateInfoKhr = 1000188000,
	PhysicalDeviceGlobalPriorityQueryFeaturesKhr = 1000188000,
	QueueFamilyGlobalPriorityPropertiesKhr = 1000188001,
	DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
	PhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
	PipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
	PhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
	[Obsolete("Use VkStructureType.PipelineCreationFeedbackCreateInfo")]
	PipelineCreationFeedbackCreateInfoExt = PipelineCreationFeedbackCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceDriverProperties")]
	PhysicalDeviceDriverPropertiesKhr = PhysicalDeviceDriverProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceFloatControlsProperties")]
	PhysicalDeviceFloatControlsPropertiesKhr = PhysicalDeviceFloatControlsProperties,
	[Obsolete("Use VkStructureType.PhysicalDeviceDepthStencilResolveProperties")]
	PhysicalDeviceDepthStencilResolvePropertiesKhr = PhysicalDeviceDepthStencilResolveProperties,
	[Obsolete("Use VkStructureType.SubpassDescriptionDepthStencilResolve")]
	SubpassDescriptionDepthStencilResolveKhr = SubpassDescriptionDepthStencilResolve,
	PhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
	PhysicalDeviceMeshShaderFeaturesNv = 1000202000,
	PhysicalDeviceMeshShaderPropertiesNv = 1000202001,
	[Obsolete("Use VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesKhr")]
	PhysicalDeviceFragmentShaderBarycentricFeaturesNv = PhysicalDeviceFragmentShaderBarycentricFeaturesKhr,
	PhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
	PipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
	PhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
	CheckpointDataNv = 1000206000,
	QueueFamilyCheckpointPropertiesNv = 1000206001,
	[Obsolete("Use VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures")]
	PhysicalDeviceTimelineSemaphoreFeaturesKhr = PhysicalDeviceTimelineSemaphoreFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceTimelineSemaphoreProperties")]
	PhysicalDeviceTimelineSemaphorePropertiesKhr = PhysicalDeviceTimelineSemaphoreProperties,
	[Obsolete("Use VkStructureType.SemaphoreTypeCreateInfo")]
	SemaphoreTypeCreateInfoKhr = SemaphoreTypeCreateInfo,
	[Obsolete("Use VkStructureType.TimelineSemaphoreSubmitInfo")]
	TimelineSemaphoreSubmitInfoKhr = TimelineSemaphoreSubmitInfo,
	[Obsolete("Use VkStructureType.SemaphoreWaitInfo")]
	SemaphoreWaitInfoKhr = SemaphoreWaitInfo,
	[Obsolete("Use VkStructureType.SemaphoreSignalInfo")]
	SemaphoreSignalInfoKhr = SemaphoreSignalInfo,
	PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
	QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
	[Obsolete("Use VkStructureType.QueryPoolPerformanceQueryCreateInfoIntel")]
	QueryPoolCreateInfoIntel = QueryPoolPerformanceQueryCreateInfoIntel,
	InitializePerformanceApiInfoIntel = 1000210001,
	PerformanceMarkerInfoIntel = 1000210002,
	PerformanceStreamMarkerInfoIntel = 1000210003,
	PerformanceOverrideInfoIntel = 1000210004,
	PerformanceConfigurationAcquireInfoIntel = 1000210005,
	[Obsolete("Use VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures")]
	PhysicalDeviceVulkanMemoryModelFeaturesKhr = PhysicalDeviceVulkanMemoryModelFeatures,
	PhysicalDevicePciBusInfoPropertiesExt = 1000212000,
	DisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
	SwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderTerminateInvocationFeatures")]
	PhysicalDeviceShaderTerminateInvocationFeaturesKhr = PhysicalDeviceShaderTerminateInvocationFeatures,
	PhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
	PhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
	RenderPassFragmentDensityMapCreateInfoExt = 1000218002,
	[Obsolete("Use VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures")]
	PhysicalDeviceScalarBlockLayoutFeaturesExt = PhysicalDeviceScalarBlockLayoutFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceSubgroupSizeControlProperties")]
	PhysicalDeviceSubgroupSizeControlPropertiesExt = PhysicalDeviceSubgroupSizeControlProperties,
	[Obsolete("Use VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfo")]
	PipelineShaderStageRequiredSubgroupSizeCreateInfoExt = PipelineShaderStageRequiredSubgroupSizeCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSubgroupSizeControlFeatures")]
	PhysicalDeviceSubgroupSizeControlFeaturesExt = PhysicalDeviceSubgroupSizeControlFeatures,
	FragmentShadingRateAttachmentInfoKhr = 1000226000,
	PipelineFragmentShadingRateStateCreateInfoKhr = 1000226001,
	PhysicalDeviceFragmentShadingRatePropertiesKhr = 1000226002,
	PhysicalDeviceFragmentShadingRateFeaturesKhr = 1000226003,
	PhysicalDeviceFragmentShadingRateKhr = 1000226004,
	PhysicalDeviceShaderCoreProperties2Amd = 1000227000,
	PhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
	PhysicalDeviceShaderImageAtomicInt64FeaturesExt = 1000234000,
	PhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
	PhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
	MemoryPriorityAllocateInfoExt = 1000238001,
	SurfaceProtectedCapabilitiesKhr = 1000239000,
	PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
	[Obsolete("Use VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures")]
	PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = PhysicalDeviceSeparateDepthStencilLayoutsFeatures,
	[Obsolete("Use VkStructureType.AttachmentReferenceStencilLayout")]
	AttachmentReferenceStencilLayoutKhr = AttachmentReferenceStencilLayout,
	[Obsolete("Use VkStructureType.AttachmentDescriptionStencilLayout")]
	AttachmentDescriptionStencilLayoutKhr = AttachmentDescriptionStencilLayout,
	PhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt")]
	PhysicalDeviceBufferAddressFeaturesExt = PhysicalDeviceBufferDeviceAddressFeaturesExt,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfo")]
	BufferDeviceAddressInfoExt = BufferDeviceAddressInfo,
	BufferDeviceAddressCreateInfoExt = 1000244002,
	[Obsolete("Use VkStructureType.PhysicalDeviceToolProperties")]
	PhysicalDeviceToolPropertiesExt = PhysicalDeviceToolProperties,
	[Obsolete("Use VkStructureType.ImageStencilUsageCreateInfo")]
	ImageStencilUsageCreateInfoExt = ImageStencilUsageCreateInfo,
	ValidationFeaturesExt = 1000247000,
	PhysicalDevicePresentWaitFeaturesKhr = 1000248000,
	PhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
	CooperativeMatrixPropertiesNv = 1000249001,
	PhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
	PhysicalDeviceCoverageReductionModeFeaturesNv = 1000250000,
	PipelineCoverageReductionStateCreateInfoNv = 1000250001,
	FramebufferMixedSamplesCombinationNv = 1000250002,
	PhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
	PhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
	[Obsolete("Use VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures")]
	PhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = PhysicalDeviceUniformBufferStandardLayoutFeatures,
	PhysicalDeviceProvokingVertexFeaturesExt = 1000254000,
	PipelineRasterizationProvokingVertexStateCreateInfoExt = 1000254001,
	PhysicalDeviceProvokingVertexPropertiesExt = 1000254002,
	SurfaceFullScreenExclusiveInfoExt = 1000255000,
	SurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
	SurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
	HeadlessSurfaceCreateInfoExt = 1000256000,
	[Obsolete("Use VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures")]
	PhysicalDeviceBufferDeviceAddressFeaturesKhr = PhysicalDeviceBufferDeviceAddressFeatures,
	[Obsolete("Use VkStructureType.BufferDeviceAddressInfo")]
	BufferDeviceAddressInfoKhr = BufferDeviceAddressInfo,
	[Obsolete("Use VkStructureType.BufferOpaqueCaptureAddressCreateInfo")]
	BufferOpaqueCaptureAddressCreateInfoKhr = BufferOpaqueCaptureAddressCreateInfo,
	[Obsolete("Use VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo")]
	MemoryOpaqueCaptureAddressAllocateInfoKhr = MemoryOpaqueCaptureAddressAllocateInfo,
	[Obsolete("Use VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo")]
	DeviceMemoryOpaqueCaptureAddressInfoKhr = DeviceMemoryOpaqueCaptureAddressInfo,
	PhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
	PipelineRasterizationLineStateCreateInfoExt = 1000259001,
	PhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
	PhysicalDeviceShaderAtomicFloatFeaturesExt = 1000260000,
	[Obsolete("Use VkStructureType.PhysicalDeviceHostQueryResetFeatures")]
	PhysicalDeviceHostQueryResetFeaturesExt = PhysicalDeviceHostQueryResetFeatures,
	PhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
	PhysicalDeviceExtendedDynamicStateFeaturesExt = 1000267000,
	PhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
	PipelineInfoKhr = 1000269001,
	PipelineExecutablePropertiesKhr = 1000269002,
	PipelineExecutableInfoKhr = 1000269003,
	PipelineExecutableStatisticKhr = 1000269004,
	PipelineExecutableInternalRepresentationKhr = 1000269005,
	PhysicalDeviceShaderAtomicFloat2FeaturesExt = 1000273000,
	SurfacePresentModeExt = 1000274000,
	SurfacePresentScalingCapabilitiesExt = 1000274001,
	SurfacePresentModeCompatibilityExt = 1000274002,
	PhysicalDeviceSwapchainMaintenance1FeaturesExt = 1000275000,
	SwapchainPresentFenceInfoExt = 1000275001,
	SwapchainPresentModesCreateInfoExt = 1000275002,
	SwapchainPresentModeInfoExt = 1000275003,
	SwapchainPresentScalingCreateInfoExt = 1000275004,
	ReleaseSwapchainImagesInfoExt = 1000275005,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeatures")]
	PhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = PhysicalDeviceShaderDemoteToHelperInvocationFeatures,
	PhysicalDeviceDeviceGeneratedCommandsPropertiesNv = 1000277000,
	GraphicsShaderGroupCreateInfoNv = 1000277001,
	GraphicsPipelineShaderGroupsCreateInfoNv = 1000277002,
	IndirectCommandsLayoutTokenNv = 1000277003,
	IndirectCommandsLayoutCreateInfoNv = 1000277004,
	GeneratedCommandsInfoNv = 1000277005,
	GeneratedCommandsMemoryRequirementsInfoNv = 1000277006,
	PhysicalDeviceDeviceGeneratedCommandsFeaturesNv = 1000277007,
	PhysicalDeviceInheritedViewportScissorFeaturesNv = 1000278000,
	CommandBufferInheritanceViewportScissorInfoNv = 1000278001,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderIntegerDotProductFeatures")]
	PhysicalDeviceShaderIntegerDotProductFeaturesKhr = PhysicalDeviceShaderIntegerDotProductFeatures,
	[Obsolete("Use VkStructureType.PhysicalDeviceShaderIntegerDotProductProperties")]
	PhysicalDeviceShaderIntegerDotProductPropertiesKhr = PhysicalDeviceShaderIntegerDotProductProperties,
	PhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
	[Obsolete("Use VkStructureType.PhysicalDeviceTexelBufferAlignmentProperties")]
	PhysicalDeviceTexelBufferAlignmentPropertiesExt = PhysicalDeviceTexelBufferAlignmentProperties,
	CommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
	RenderPassTransformBeginInfoQcom = 1000282001,
	PhysicalDeviceDeviceMemoryReportFeaturesExt = 1000284000,
	DeviceDeviceMemoryReportCreateInfoExt = 1000284001,
	DeviceMemoryReportCallbackDataExt = 1000284002,
	PhysicalDeviceRobustness2FeaturesExt = 1000286000,
	PhysicalDeviceRobustness2PropertiesExt = 1000286001,
	SamplerCustomBorderColorCreateInfoExt = 1000287000,
	PhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
	PhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
	PipelineLibraryCreateInfoKhr = 1000290000,
	PhysicalDevicePresentBarrierFeaturesNv = 1000292000,
	SurfaceCapabilitiesPresentBarrierNv = 1000292001,
	SwapchainPresentBarrierCreateInfoNv = 1000292002,
	PresentIdKhr = 1000294000,
	PhysicalDevicePresentIdFeaturesKhr = 1000294001,
	[Obsolete("Use VkStructureType.PhysicalDevicePrivateDataFeatures")]
	PhysicalDevicePrivateDataFeaturesExt = PhysicalDevicePrivateDataFeatures,
	[Obsolete("Use VkStructureType.DevicePrivateDataCreateInfo")]
	DevicePrivateDataCreateInfoExt = DevicePrivateDataCreateInfo,
	[Obsolete("Use VkStructureType.PrivateDataSlotCreateInfo")]
	PrivateDataSlotCreateInfoExt = PrivateDataSlotCreateInfo,
	[Obsolete("Use VkStructureType.PhysicalDevicePipelineCreationCacheControlFeatures")]
	PhysicalDevicePipelineCreationCacheControlFeaturesExt = PhysicalDevicePipelineCreationCacheControlFeatures,
	PhysicalDeviceDiagnosticsConfigFeaturesNv = 1000300000,
	DeviceDiagnosticsConfigCreateInfoNv = 1000300001,
	[Obsolete("Use VkStructureType.MemoryBarrier2")]
	MemoryBarrier2Khr = MemoryBarrier2,
	[Obsolete("Use VkStructureType.BufferMemoryBarrier2")]
	BufferMemoryBarrier2Khr = BufferMemoryBarrier2,
	[Obsolete("Use VkStructureType.ImageMemoryBarrier2")]
	ImageMemoryBarrier2Khr = ImageMemoryBarrier2,
	[Obsolete("Use VkStructureType.DependencyInfo")]
	DependencyInfoKhr = DependencyInfo,
	[Obsolete("Use VkStructureType.SubmitInfo2")]
	SubmitInfo2Khr = SubmitInfo2,
	[Obsolete("Use VkStructureType.SemaphoreSubmitInfo")]
	SemaphoreSubmitInfoKhr = SemaphoreSubmitInfo,
	[Obsolete("Use VkStructureType.CommandBufferSubmitInfo")]
	CommandBufferSubmitInfoKhr = CommandBufferSubmitInfo,
	[Obsolete("Use VkStructureType.PhysicalDeviceSynchronization2Features")]
	PhysicalDeviceSynchronization2FeaturesKhr = PhysicalDeviceSynchronization2Features,
	QueueFamilyCheckpointProperties2Nv = 1000314008,
	CheckpointData2Nv = 1000314009,
	PhysicalDeviceDescriptorBufferPropertiesExt = 1000316000,
	PhysicalDeviceDescriptorBufferDensityMapPropertiesExt = 1000316001,
	PhysicalDeviceDescriptorBufferFeaturesExt = 1000316002,
	DescriptorAddressInfoExt = 1000316003,
	DescriptorGetInfoExt = 1000316004,
	BufferCaptureDescriptorDataInfoExt = 1000316005,
	ImageCaptureDescriptorDataInfoExt = 1000316006,
	ImageViewCaptureDescriptorDataInfoExt = 1000316007,
	SamplerCaptureDescriptorDataInfoExt = 1000316008,
	OpaqueCaptureDescriptorDataCreateInfoExt = 1000316010,
	DescriptorBufferBindingInfoExt = 1000316011,
	DescriptorBufferBindingPushDescriptorBufferHandleExt = 1000316012,
	AccelerationStructureCaptureDescriptorDataInfoExt = 1000316009,
	PhysicalDeviceGraphicsPipelineLibraryFeaturesExt = 1000320000,
	PhysicalDeviceGraphicsPipelineLibraryPropertiesExt = 1000320001,
	GraphicsPipelineLibraryCreateInfoExt = 1000320002,
	PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd = 1000321000,
	PhysicalDeviceFragmentShaderBarycentricFeaturesKhr = 1000322000,
	PhysicalDeviceFragmentShaderBarycentricPropertiesKhr = 1000322000,
	PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = 1000323000,
	[Obsolete("Use VkStructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures")]
	PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr = PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,
	PhysicalDeviceFragmentShadingRateEnumsPropertiesNv = 1000326000,
	PhysicalDeviceFragmentShadingRateEnumsFeaturesNv = 1000326001,
	PipelineFragmentShadingRateEnumStateCreateInfoNv = 1000326002,
	AccelerationStructureGeometryMotionTrianglesDataNv = 1000327000,
	PhysicalDeviceRayTracingMotionBlurFeaturesNv = 1000327001,
	AccelerationStructureMotionInfoNv = 1000327002,
	PhysicalDeviceMeshShaderFeaturesExt = 1000328000,
	PhysicalDeviceMeshShaderPropertiesExt = 1000328001,
	PhysicalDeviceYcbcr2Plane444FormatsFeaturesExt = 1000330000,
	PhysicalDeviceFragmentDensityMap2FeaturesExt = 1000332000,
	PhysicalDeviceFragmentDensityMap2PropertiesExt = 1000332001,
	CopyCommandTransformInfoQcom = 1000333000,
	[Obsolete("Use VkStructureType.PhysicalDeviceImageRobustnessFeatures")]
	PhysicalDeviceImageRobustnessFeaturesExt = PhysicalDeviceImageRobustnessFeatures,
	PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = 1000336000,
	[Obsolete("Use VkStructureType.CopyBufferInfo2")]
	CopyBufferInfo2Khr = CopyBufferInfo2,
	[Obsolete("Use VkStructureType.CopyImageInfo2")]
	CopyImageInfo2Khr = CopyImageInfo2,
	[Obsolete("Use VkStructureType.CopyBufferToImageInfo2")]
	CopyBufferToImageInfo2Khr = CopyBufferToImageInfo2,
	[Obsolete("Use VkStructureType.CopyImageToBufferInfo2")]
	CopyImageToBufferInfo2Khr = CopyImageToBufferInfo2,
	[Obsolete("Use VkStructureType.BlitImageInfo2")]
	BlitImageInfo2Khr = BlitImageInfo2,
	[Obsolete("Use VkStructureType.ResolveImageInfo2")]
	ResolveImageInfo2Khr = ResolveImageInfo2,
	[Obsolete("Use VkStructureType.BufferCopy2")]
	BufferCopy2Khr = BufferCopy2,
	[Obsolete("Use VkStructureType.ImageCopy2")]
	ImageCopy2Khr = ImageCopy2,
	[Obsolete("Use VkStructureType.ImageBlit2")]
	ImageBlit2Khr = ImageBlit2,
	[Obsolete("Use VkStructureType.BufferImageCopy2")]
	BufferImageCopy2Khr = BufferImageCopy2,
	[Obsolete("Use VkStructureType.ImageResolve2")]
	ImageResolve2Khr = ImageResolve2,
	PhysicalDeviceImageCompressionControlFeaturesExt = 1000338000,
	ImageCompressionControlExt = 1000338001,
	SubresourceLayout2Ext = 1000338002,
	ImageSubresource2Ext = 1000338003,
	ImageCompressionPropertiesExt = 1000338004,
	PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt = 1000339000,
	PhysicalDevice4444FormatsFeaturesExt = 1000340000,
	PhysicalDeviceFaultFeaturesExt = 1000341000,
	DeviceFaultCountsExt = 1000341001,
	DeviceFaultInfoExt = 1000341002,
	[Obsolete("Use VkStructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt")]
	PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesArm = PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt,
	PhysicalDeviceRgba10x6FormatsFeaturesExt = 1000344000,
	[Obsolete("Use VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesExt")]
	PhysicalDeviceMutableDescriptorTypeFeaturesValve = PhysicalDeviceMutableDescriptorTypeFeaturesExt,
	[Obsolete("Use VkStructureType.MutableDescriptorTypeCreateInfoExt")]
	MutableDescriptorTypeCreateInfoValve = MutableDescriptorTypeCreateInfoExt,
	PhysicalDeviceVertexInputDynamicStateFeaturesExt = 1000352000,
	VertexInputBindingDescription2Ext = 1000352001,
	VertexInputAttributeDescription2Ext = 1000352002,
	PhysicalDeviceDrmPropertiesExt = 1000353000,
	PhysicalDeviceAddressBindingReportFeaturesExt = 1000354000,
	DeviceAddressBindingCallbackDataExt = 1000354001,
	PhysicalDeviceDepthClipControlFeaturesExt = 1000355000,
	PipelineViewportDepthClipControlCreateInfoExt = 1000355001,
	PhysicalDevicePrimitiveTopologyListRestartFeaturesExt = 1000356000,
	[Obsolete("Use VkStructureType.FormatProperties3")]
	FormatProperties3Khr = FormatProperties3,
	SubpassShadingPipelineCreateInfoHuawei = 1000369000,
	PhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,
	PhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,
	PhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,
	MemoryGetRemoteAddressInfoNv = 1000371000,
	PhysicalDeviceExternalMemoryRdmaFeaturesNv = 1000371001,
	PipelinePropertiesIdentifierExt = 1000372000,
	PhysicalDevicePipelinePropertiesFeaturesExt = 1000372001,
	[Obsolete("Use VkStructureType.PipelineInfoKhr")]
	PipelineInfoExt = PipelineInfoKhr,
	PhysicalDeviceMultisampledRenderToSingleSampledFeaturesExt = 1000376000,
	SubpassResolvePerformanceQueryExt = 1000376001,
	MultisampledRenderToSingleSampledInfoExt = 1000376002,
	PhysicalDeviceExtendedDynamicState2FeaturesExt = 1000377000,
	PhysicalDeviceColorWriteEnableFeaturesExt = 1000381000,
	PipelineColorWriteCreateInfoExt = 1000381001,
	PhysicalDevicePrimitivesGeneratedQueryFeaturesExt = 1000382000,
	PhysicalDeviceRayTracingMaintenance1FeaturesKhr = 1000386000,
	[Obsolete("Use VkStructureType.PhysicalDeviceGlobalPriorityQueryFeaturesKhr")]
	PhysicalDeviceGlobalPriorityQueryFeaturesExt = PhysicalDeviceGlobalPriorityQueryFeaturesKhr,
	[Obsolete("Use VkStructureType.QueueFamilyGlobalPriorityPropertiesKhr")]
	QueueFamilyGlobalPriorityPropertiesExt = QueueFamilyGlobalPriorityPropertiesKhr,
	PhysicalDeviceImageViewMinLodFeaturesExt = 1000391000,
	ImageViewMinLodCreateInfoExt = 1000391001,
	PhysicalDeviceMultiDrawFeaturesExt = 1000392000,
	PhysicalDeviceMultiDrawPropertiesExt = 1000392001,
	PhysicalDeviceImage2dViewOf3dFeaturesExt = 1000393000,
	MicromapBuildInfoExt = 1000396000,
	MicromapVersionInfoExt = 1000396001,
	CopyMicromapInfoExt = 1000396002,
	CopyMicromapToMemoryInfoExt = 1000396003,
	CopyMemoryToMicromapInfoExt = 1000396004,
	PhysicalDeviceOpacityMicromapFeaturesExt = 1000396005,
	PhysicalDeviceOpacityMicromapPropertiesExt = 1000396006,
	MicromapCreateInfoExt = 1000396007,
	MicromapBuildSizesInfoExt = 1000396008,
	AccelerationStructureTrianglesOpacityMicromapExt = 1000396009,
	PhysicalDeviceClusterCullingShaderFeaturesHuawei = 1000404000,
	PhysicalDeviceClusterCullingShaderPropertiesHuawei = 1000404001,
	PhysicalDeviceBorderColorSwizzleFeaturesExt = 1000411000,
	SamplerBorderColorComponentMappingCreateInfoExt = 1000411001,
	PhysicalDevicePageableDeviceLocalMemoryFeaturesExt = 1000412000,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance4Features")]
	PhysicalDeviceMaintenance4FeaturesKhr = PhysicalDeviceMaintenance4Features,
	[Obsolete("Use VkStructureType.PhysicalDeviceMaintenance4Properties")]
	PhysicalDeviceMaintenance4PropertiesKhr = PhysicalDeviceMaintenance4Properties,
	[Obsolete("Use VkStructureType.DeviceBufferMemoryRequirements")]
	DeviceBufferMemoryRequirementsKhr = DeviceBufferMemoryRequirements,
	[Obsolete("Use VkStructureType.DeviceImageMemoryRequirements")]
	DeviceImageMemoryRequirementsKhr = DeviceImageMemoryRequirements,
	PhysicalDeviceDescriptorSetHostMappingFeaturesValve = 1000420000,
	DescriptorSetBindingReferenceValve = 1000420001,
	DescriptorSetLayoutHostMappingInfoValve = 1000420002,
	PhysicalDeviceDepthClampZeroOneFeaturesExt = 1000421000,
	PhysicalDeviceNonSeamlessCubeMapFeaturesExt = 1000422000,
	PhysicalDeviceFragmentDensityMapOffsetFeaturesQcom = 1000425000,
	PhysicalDeviceFragmentDensityMapOffsetPropertiesQcom = 1000425001,
	SubpassFragmentDensityMapOffsetEndInfoQcom = 1000425002,
	PhysicalDeviceCopyMemoryIndirectFeaturesNv = 1000426000,
	PhysicalDeviceCopyMemoryIndirectPropertiesNv = 1000426001,
	PhysicalDeviceMemoryDecompressionFeaturesNv = 1000427000,
	PhysicalDeviceMemoryDecompressionPropertiesNv = 1000427001,
	PhysicalDeviceLinearColorAttachmentFeaturesNv = 1000430000,
	PhysicalDeviceImageCompressionControlSwapchainFeaturesExt = 1000437000,
	PhysicalDeviceImageProcessingFeaturesQcom = 1000440000,
	PhysicalDeviceImageProcessingPropertiesQcom = 1000440001,
	ImageViewSampleWeightCreateInfoQcom = 1000440002,
	PhysicalDeviceExtendedDynamicState3FeaturesExt = 1000455000,
	PhysicalDeviceExtendedDynamicState3PropertiesExt = 1000455001,
	PhysicalDeviceSubpassMergeFeedbackFeaturesExt = 1000458000,
	RenderPassCreationControlExt = 1000458001,
	RenderPassCreationFeedbackCreateInfoExt = 1000458002,
	RenderPassSubpassFeedbackCreateInfoExt = 1000458003,
	DirectDriverLoadingInfoLunarg = 1000459000,
	DirectDriverLoadingListLunarg = 1000459001,
	PhysicalDeviceShaderModuleIdentifierFeaturesExt = 1000462000,
	PhysicalDeviceShaderModuleIdentifierPropertiesExt = 1000462001,
	PipelineShaderStageModuleIdentifierCreateInfoExt = 1000462002,
	ShaderModuleIdentifierExt = 1000462003,
	PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt = 1000463000,
	PhysicalDeviceOpticalFlowFeaturesNv = 1000464000,
	PhysicalDeviceOpticalFlowPropertiesNv = 1000464001,
	OpticalFlowImageFormatInfoNv = 1000464002,
	OpticalFlowImageFormatPropertiesNv = 1000464003,
	OpticalFlowSessionCreateInfoNv = 1000464004,
	OpticalFlowExecuteInfoNv = 1000464005,
	OpticalFlowSessionCreatePrivateDataInfoNv = 1000464010,
	PhysicalDeviceLegacyDitheringFeaturesExt = 1000465000,
	PhysicalDevicePipelineProtectedAccessFeaturesExt = 1000466000,
	PhysicalDeviceTilePropertiesFeaturesQcom = 1000484000,
	TilePropertiesQcom = 1000484001,
	PhysicalDeviceAmigoProfilingFeaturesSec = 1000485000,
	AmigoProfilingSubmitInfoSec = 1000485001,
	PhysicalDeviceMultiviewPerViewViewportsFeaturesQcom = 1000488000,
	PhysicalDeviceRayTracingInvocationReorderFeaturesNv = 1000490000,
	PhysicalDeviceRayTracingInvocationReorderPropertiesNv = 1000490001,
	PhysicalDeviceMutableDescriptorTypeFeaturesExt = 1000494000,
	MutableDescriptorTypeCreateInfoExt = 1000494002,
	PhysicalDeviceShaderCoreBuiltinsFeaturesArm = 1000497000,
	PhysicalDeviceShaderCoreBuiltinsPropertiesArm = 1000497001,
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
	TransformFeedbackWriteExt = 1 << 25,
	TransformFeedbackCounterReadExt = 1 << 26,
	TransformFeedbackCounterWriteExt = 1 << 27,
	ConditionalRenderingReadExt = 1 << 20,
	ColorAttachmentReadNoncoherentExt = 1 << 19,
	AccelerationStructureReadKhr = 1 << 21,
	AccelerationStructureWriteKhr = 1 << 22,
	[Obsolete("Use VkAccessFlags.FragmentShadingRateAttachmentReadKhr")]
	ShadingRateImageReadNv = FragmentShadingRateAttachmentReadKhr,
	[Obsolete("Use VkAccessFlags.AccelerationStructureReadKhr")]
	AccelerationStructureReadNv = AccelerationStructureReadKhr,
	[Obsolete("Use VkAccessFlags.AccelerationStructureWriteKhr")]
	AccelerationStructureWriteNv = AccelerationStructureWriteKhr,
	FragmentDensityMapReadExt = 1 << 24,
	FragmentShadingRateAttachmentReadKhr = 1 << 23,
	CommandPreprocessReadNv = 1 << 17,
	CommandPreprocessWriteNv = 1 << 18,
	[Obsolete("Use VkAccessFlags.None")]
	NoneKhr = None,
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
	PresentSourceKhr = 1000001002,
	VideoDecodeDestinationKhr = 1000024000,
	VideoDecodeSourceKhr = 1000024001,
	VideoDecodeDpbKhr = 1000024002,
	SharedPresentKhr = 1000111000,
	[Obsolete("Use VkImageLayout.DepthReadOnlyStencilAttachmentOptimal")]
	DepthReadOnlyStencilAttachmentOptimalKhr = DepthReadOnlyStencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthAttachmentStencilReadOnlyOptimal")]
	DepthAttachmentStencilReadOnlyOptimalKhr = DepthAttachmentStencilReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.FragmentShadingRateAttachmentOptimalKhr")]
	ShadingRateOptimalNv = FragmentShadingRateAttachmentOptimalKhr,
	FragmentDensityMapOptimalExt = 1000218000,
	FragmentShadingRateAttachmentOptimalKhr = 1000226003,
	[Obsolete("Use VkImageLayout.DepthAttachmentOptimal")]
	DepthAttachmentOptimalKhr = DepthAttachmentOptimal,
	[Obsolete("Use VkImageLayout.DepthReadOnlyOptimal")]
	DepthReadOnlyOptimalKhr = DepthReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.StencilAttachmentOptimal")]
	StencilAttachmentOptimalKhr = StencilAttachmentOptimal,
	[Obsolete("Use VkImageLayout.StencilReadOnlyOptimal")]
	StencilReadOnlyOptimalKhr = StencilReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.ReadOnlyOptimal")]
	ReadOnlyOptimalKhr = ReadOnlyOptimal,
	[Obsolete("Use VkImageLayout.AttachmentOptimal")]
	AttachmentOptimalKhr = AttachmentOptimal,
	AttachmentFeedbackLoopOptimalExt = 1000339000,
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
	Plane0Khr = Plane0,
	[Obsolete("Use VkImageAspectFlags.Plane1")]
	Plane1Khr = Plane1,
	[Obsolete("Use VkImageAspectFlags.Plane2")]
	Plane2Khr = Plane2,
	MemoryPlane0Ext = 1 << 7,
	MemoryPlane1Ext = 1 << 8,
	MemoryPlane2Ext = 1 << 9,
	MemoryPlane3Ext = 1 << 10,
	[Obsolete("Use VkImageAspectFlags.None")]
	NoneKhr = None,
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
	SamplerYcbcrConversion = 1000156000,
	DescriptorUpdateTemplate = 1000085000,
	PrivateDataSlot = 1000295000,
	SurfaceKhr = 1000000000,
	SwapchainKhr = 1000001000,
	DisplayKhr = 1000002000,
	DisplayModeKhr = 1000002001,
	DebugReportCallbackExt = 1000011000,
	VideoSessionKhr = 1000023000,
	VideoSessionParametersKhr = 1000023001,
	CuModuleNvx = 1000029000,
	CuFunctionNvx = 1000029001,
	[Obsolete("Use VkObjectType.DescriptorUpdateTemplate")]
	DescriptorUpdateTemplateKhr = DescriptorUpdateTemplate,
	DebugUtilsMessengerExt = 1000128000,
	AccelerationStructureKhr = 1000150000,
	[Obsolete("Use VkObjectType.SamplerYcbcrConversion")]
	SamplerYcbcrConversionKhr = SamplerYcbcrConversion,
	ValidationCacheExt = 1000160000,
	AccelerationStructureNv = 1000165000,
	PerformanceConfigurationIntel = 1000210000,
	DeferredOperationKhr = 1000268000,
	IndirectCommandsLayoutNv = 1000277000,
	[Obsolete("Use VkObjectType.PrivateDataSlot")]
	PrivateDataSlotExt = PrivateDataSlot,
	MicromapExt = 1000396000,
	OpticalFlowSessionNv = 1000464000,
}
public enum VkVendorId
{
	Viv = 0x10001,
	Vsi = 0x10002,
	Kazan = 0x10003,
	Codeplay = 0x10004,
	Mesa = 0x10005,
	Pocl = 0x10006,
}
[Flags]
public enum VkInstanceCreateFlags
{
	EnumeratePortabilityKhr = 1 << 0,
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
	G8b8g8r8422Unorm = 1000156000,
	B8g8r8g8422Unorm = 1000156001,
	G8B8R83plane420Unorm = 1000156002,
	G8B8r82plane420Unorm = 1000156003,
	G8B8R83plane422Unorm = 1000156004,
	G8B8r82plane422Unorm = 1000156005,
	G8B8R83plane444Unorm = 1000156006,
	R10x6UnormPack16 = 1000156007,
	R10x6g10x6Unorm2pack16 = 1000156008,
	R10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
	G10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
	B10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
	G10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
	G10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
	G10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
	G10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
	G10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
	R12x4UnormPack16 = 1000156017,
	R12x4g12x4Unorm2pack16 = 1000156018,
	R12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
	G12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
	B12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
	G12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
	G12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
	G12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
	G12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
	G12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
	G16b16g16r16422Unorm = 1000156027,
	B16g16r16g16422Unorm = 1000156028,
	G16B16R163plane420Unorm = 1000156029,
	G16B16r162plane420Unorm = 1000156030,
	G16B16R163plane422Unorm = 1000156031,
	G16B16r162plane422Unorm = 1000156032,
	G16B16R163plane444Unorm = 1000156033,
	G8B8r82plane444Unorm = 1000330000,
	G10x6B10x6r10x62plane444Unorm3pack16 = 1000330001,
	G12x4B12x4r12x42plane444Unorm3pack16 = 1000330002,
	G16B16r162plane444Unorm = 1000330003,
	A4r4g4b4UnormPack16 = 1000340000,
	A4b4g4r4UnormPack16 = 1000340001,
	Astc4x4SfloatBlock = 1000066000,
	Astc5x4SfloatBlock = 1000066001,
	Astc5x5SfloatBlock = 1000066002,
	Astc6x5SfloatBlock = 1000066003,
	Astc6x6SfloatBlock = 1000066004,
	Astc8x5SfloatBlock = 1000066005,
	Astc8x6SfloatBlock = 1000066006,
	Astc8x8SfloatBlock = 1000066007,
	Astc10x5SfloatBlock = 1000066008,
	Astc10x6SfloatBlock = 1000066009,
	Astc10x8SfloatBlock = 1000066010,
	Astc10x10SfloatBlock = 1000066011,
	Astc12x10SfloatBlock = 1000066012,
	Astc12x12SfloatBlock = 1000066013,
	Pvrtc12bppUnormBlockImg = 1000054000,
	Pvrtc14bppUnormBlockImg = 1000054001,
	Pvrtc22bppUnormBlockImg = 1000054002,
	Pvrtc24bppUnormBlockImg = 1000054003,
	Pvrtc12bppSrgbBlockImg = 1000054004,
	Pvrtc14bppSrgbBlockImg = 1000054005,
	Pvrtc22bppSrgbBlockImg = 1000054006,
	Pvrtc24bppSrgbBlockImg = 1000054007,
	[Obsolete("Use VkFormat.Astc4x4SfloatBlock")]
	Astc4x4SfloatBlockExt = Astc4x4SfloatBlock,
	[Obsolete("Use VkFormat.Astc5x4SfloatBlock")]
	Astc5x4SfloatBlockExt = Astc5x4SfloatBlock,
	[Obsolete("Use VkFormat.Astc5x5SfloatBlock")]
	Astc5x5SfloatBlockExt = Astc5x5SfloatBlock,
	[Obsolete("Use VkFormat.Astc6x5SfloatBlock")]
	Astc6x5SfloatBlockExt = Astc6x5SfloatBlock,
	[Obsolete("Use VkFormat.Astc6x6SfloatBlock")]
	Astc6x6SfloatBlockExt = Astc6x6SfloatBlock,
	[Obsolete("Use VkFormat.Astc8x5SfloatBlock")]
	Astc8x5SfloatBlockExt = Astc8x5SfloatBlock,
	[Obsolete("Use VkFormat.Astc8x6SfloatBlock")]
	Astc8x6SfloatBlockExt = Astc8x6SfloatBlock,
	[Obsolete("Use VkFormat.Astc8x8SfloatBlock")]
	Astc8x8SfloatBlockExt = Astc8x8SfloatBlock,
	[Obsolete("Use VkFormat.Astc10x5SfloatBlock")]
	Astc10x5SfloatBlockExt = Astc10x5SfloatBlock,
	[Obsolete("Use VkFormat.Astc10x6SfloatBlock")]
	Astc10x6SfloatBlockExt = Astc10x6SfloatBlock,
	[Obsolete("Use VkFormat.Astc10x8SfloatBlock")]
	Astc10x8SfloatBlockExt = Astc10x8SfloatBlock,
	[Obsolete("Use VkFormat.Astc10x10SfloatBlock")]
	Astc10x10SfloatBlockExt = Astc10x10SfloatBlock,
	[Obsolete("Use VkFormat.Astc12x10SfloatBlock")]
	Astc12x10SfloatBlockExt = Astc12x10SfloatBlock,
	[Obsolete("Use VkFormat.Astc12x12SfloatBlock")]
	Astc12x12SfloatBlockExt = Astc12x12SfloatBlock,
	[Obsolete("Use VkFormat.G8b8g8r8422Unorm")]
	G8b8g8r8422UnormKhr = G8b8g8r8422Unorm,
	[Obsolete("Use VkFormat.B8g8r8g8422Unorm")]
	B8g8r8g8422UnormKhr = B8g8r8g8422Unorm,
	[Obsolete("Use VkFormat.G8B8R83plane420Unorm")]
	G8B8R83plane420UnormKhr = G8B8R83plane420Unorm,
	[Obsolete("Use VkFormat.G8B8r82plane420Unorm")]
	G8B8r82plane420UnormKhr = G8B8r82plane420Unorm,
	[Obsolete("Use VkFormat.G8B8R83plane422Unorm")]
	G8B8R83plane422UnormKhr = G8B8R83plane422Unorm,
	[Obsolete("Use VkFormat.G8B8r82plane422Unorm")]
	G8B8r82plane422UnormKhr = G8B8r82plane422Unorm,
	[Obsolete("Use VkFormat.G8B8R83plane444Unorm")]
	G8B8R83plane444UnormKhr = G8B8R83plane444Unorm,
	[Obsolete("Use VkFormat.R10x6UnormPack16")]
	R10x6UnormPack16Khr = R10x6UnormPack16,
	[Obsolete("Use VkFormat.R10x6g10x6Unorm2pack16")]
	R10x6g10x6Unorm2pack16Khr = R10x6g10x6Unorm2pack16,
	[Obsolete("Use VkFormat.R10x6g10x6b10x6a10x6Unorm4pack16")]
	R10x6g10x6b10x6a10x6Unorm4pack16Khr = R10x6g10x6b10x6a10x6Unorm4pack16,
	[Obsolete("Use VkFormat.G10x6b10x6g10x6r10x6422Unorm4pack16")]
	G10x6b10x6g10x6r10x6422Unorm4pack16Khr = G10x6b10x6g10x6r10x6422Unorm4pack16,
	[Obsolete("Use VkFormat.B10x6g10x6r10x6g10x6422Unorm4pack16")]
	B10x6g10x6r10x6g10x6422Unorm4pack16Khr = B10x6g10x6r10x6g10x6422Unorm4pack16,
	[Obsolete("Use VkFormat.G10x6B10x6R10x63plane420Unorm3pack16")]
	G10x6B10x6R10x63plane420Unorm3pack16Khr = G10x6B10x6R10x63plane420Unorm3pack16,
	[Obsolete("Use VkFormat.G10x6B10x6r10x62plane420Unorm3pack16")]
	G10x6B10x6r10x62plane420Unorm3pack16Khr = G10x6B10x6r10x62plane420Unorm3pack16,
	[Obsolete("Use VkFormat.G10x6B10x6R10x63plane422Unorm3pack16")]
	G10x6B10x6R10x63plane422Unorm3pack16Khr = G10x6B10x6R10x63plane422Unorm3pack16,
	[Obsolete("Use VkFormat.G10x6B10x6r10x62plane422Unorm3pack16")]
	G10x6B10x6r10x62plane422Unorm3pack16Khr = G10x6B10x6r10x62plane422Unorm3pack16,
	[Obsolete("Use VkFormat.G10x6B10x6R10x63plane444Unorm3pack16")]
	G10x6B10x6R10x63plane444Unorm3pack16Khr = G10x6B10x6R10x63plane444Unorm3pack16,
	[Obsolete("Use VkFormat.R12x4UnormPack16")]
	R12x4UnormPack16Khr = R12x4UnormPack16,
	[Obsolete("Use VkFormat.R12x4g12x4Unorm2pack16")]
	R12x4g12x4Unorm2pack16Khr = R12x4g12x4Unorm2pack16,
	[Obsolete("Use VkFormat.R12x4g12x4b12x4a12x4Unorm4pack16")]
	R12x4g12x4b12x4a12x4Unorm4pack16Khr = R12x4g12x4b12x4a12x4Unorm4pack16,
	[Obsolete("Use VkFormat.G12x4b12x4g12x4r12x4422Unorm4pack16")]
	G12x4b12x4g12x4r12x4422Unorm4pack16Khr = G12x4b12x4g12x4r12x4422Unorm4pack16,
	[Obsolete("Use VkFormat.B12x4g12x4r12x4g12x4422Unorm4pack16")]
	B12x4g12x4r12x4g12x4422Unorm4pack16Khr = B12x4g12x4r12x4g12x4422Unorm4pack16,
	[Obsolete("Use VkFormat.G12x4B12x4R12x43plane420Unorm3pack16")]
	G12x4B12x4R12x43plane420Unorm3pack16Khr = G12x4B12x4R12x43plane420Unorm3pack16,
	[Obsolete("Use VkFormat.G12x4B12x4r12x42plane420Unorm3pack16")]
	G12x4B12x4r12x42plane420Unorm3pack16Khr = G12x4B12x4r12x42plane420Unorm3pack16,
	[Obsolete("Use VkFormat.G12x4B12x4R12x43plane422Unorm3pack16")]
	G12x4B12x4R12x43plane422Unorm3pack16Khr = G12x4B12x4R12x43plane422Unorm3pack16,
	[Obsolete("Use VkFormat.G12x4B12x4r12x42plane422Unorm3pack16")]
	G12x4B12x4r12x42plane422Unorm3pack16Khr = G12x4B12x4r12x42plane422Unorm3pack16,
	[Obsolete("Use VkFormat.G12x4B12x4R12x43plane444Unorm3pack16")]
	G12x4B12x4R12x43plane444Unorm3pack16Khr = G12x4B12x4R12x43plane444Unorm3pack16,
	[Obsolete("Use VkFormat.G16b16g16r16422Unorm")]
	G16b16g16r16422UnormKhr = G16b16g16r16422Unorm,
	[Obsolete("Use VkFormat.B16g16r16g16422Unorm")]
	B16g16r16g16422UnormKhr = B16g16r16g16422Unorm,
	[Obsolete("Use VkFormat.G16B16R163plane420Unorm")]
	G16B16R163plane420UnormKhr = G16B16R163plane420Unorm,
	[Obsolete("Use VkFormat.G16B16r162plane420Unorm")]
	G16B16r162plane420UnormKhr = G16B16r162plane420Unorm,
	[Obsolete("Use VkFormat.G16B16R163plane422Unorm")]
	G16B16R163plane422UnormKhr = G16B16R163plane422Unorm,
	[Obsolete("Use VkFormat.G16B16r162plane422Unorm")]
	G16B16r162plane422UnormKhr = G16B16r162plane422Unorm,
	[Obsolete("Use VkFormat.G16B16R163plane444Unorm")]
	G16B16R163plane444UnormKhr = G16B16R163plane444Unorm,
	[Obsolete("Use VkFormat.G8B8r82plane444Unorm")]
	G8B8r82plane444UnormExt = G8B8r82plane444Unorm,
	[Obsolete("Use VkFormat.G10x6B10x6r10x62plane444Unorm3pack16")]
	G10x6B10x6r10x62plane444Unorm3pack16Ext = G10x6B10x6r10x62plane444Unorm3pack16,
	[Obsolete("Use VkFormat.G12x4B12x4r12x42plane444Unorm3pack16")]
	G12x4B12x4r12x42plane444Unorm3pack16Ext = G12x4B12x4r12x42plane444Unorm3pack16,
	[Obsolete("Use VkFormat.G16B16r162plane444Unorm")]
	G16B16r162plane444UnormExt = G16B16r162plane444Unorm,
	[Obsolete("Use VkFormat.A4r4g4b4UnormPack16")]
	A4r4g4b4UnormPack16Ext = A4r4g4b4UnormPack16,
	[Obsolete("Use VkFormat.A4b4g4r4UnormPack16")]
	A4b4g4r4UnormPack16Ext = A4b4g4r4UnormPack16,
	R16g16S105Nv = 1000464000,
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
	SampledImageYcbcrConversionLinearFilter = 1 << 18,
	SampledImageYcbcrConversionSeparateReconstructionFilter = 1 << 19,
	SampledImageYcbcrConversionChromaReconstructionExplicit = 1 << 20,
	SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 1 << 21,
	Disjoint = 1 << 22,
	CositedChromaSamples = 1 << 23,
	SampledImageFilterMinmax = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterCubicExt")]
	SampledImageFilterCubicImg = SampledImageFilterCubicExt,
	VideoDecodeOutputKhr = 1 << 25,
	VideoDecodeDpbKhr = 1 << 26,
	[Obsolete("Use VkFormatFeatureFlags.TransferSource")]
	TransferSourceKhr = TransferSource,
	[Obsolete("Use VkFormatFeatureFlags.TransferDestination")]
	TransferDestinationKhr = TransferDestination,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageFilterMinmax")]
	SampledImageFilterMinmaxExt = SampledImageFilterMinmax,
	AccelerationStructureVertexBufferKhr = 1 << 29,
	[Obsolete("Use VkFormatFeatureFlags.MidpointChromaSamples")]
	MidpointChromaSamplesKhr = MidpointChromaSamples,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYcbcrConversionLinearFilter")]
	SampledImageYcbcrConversionLinearFilterKhr = SampledImageYcbcrConversionLinearFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYcbcrConversionSeparateReconstructionFilter")]
	SampledImageYcbcrConversionSeparateReconstructionFilterKhr = SampledImageYcbcrConversionSeparateReconstructionFilter,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYcbcrConversionChromaReconstructionExplicit")]
	SampledImageYcbcrConversionChromaReconstructionExplicitKhr = SampledImageYcbcrConversionChromaReconstructionExplicit,
	[Obsolete("Use VkFormatFeatureFlags.SampledImageYcbcrConversionChromaReconstructionExplicitForceable")]
	SampledImageYcbcrConversionChromaReconstructionExplicitForceableKhr = SampledImageYcbcrConversionChromaReconstructionExplicitForceable,
	[Obsolete("Use VkFormatFeatureFlags.Disjoint")]
	DisjointKhr = Disjoint,
	[Obsolete("Use VkFormatFeatureFlags.CositedChromaSamples")]
	CositedChromaSamplesKhr = CositedChromaSamples,
	SampledImageFilterCubicExt = 1 << 13,
	FragmentDensityMapExt = 1 << 24,
	FragmentShadingRateAttachmentKhr = 1 << 30,
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
	DrmFormatModifierExt = 1000158000,
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
	VideoDecodeDestinationKhr = 1 << 10,
	VideoDecodeSourceKhr = 1 << 11,
	VideoDecodeDpbKhr = 1 << 12,
	[Obsolete("Use VkImageUsageFlags.FragmentShadingRateAttachmentKhr")]
	ShadingRateImageNv = FragmentShadingRateAttachmentKhr,
	FragmentDensityMapExt = 1 << 9,
	FragmentShadingRateAttachmentKhr = 1 << 8,
	AttachmentFeedbackLoopExt = 1 << 19,
	InvocationMaskHuawei = 1 << 18,
	SampleWeightQcom = 1 << 20,
	SampleBlockMatchQcom = 1 << 21,
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
	_2dArrayCompatible = 1 << 5,
	BlockTexelViewCompatible = 1 << 7,
	ExtendedUsage = 1 << 8,
	Protected = 1 << 11,
	Disjoint = 1 << 9,
	CornerSampledNv = 1 << 13,
	[Obsolete("Use VkImageCreateFlags.SplitInstanceBindRegions")]
	SplitInstanceBindRegionsKhr = SplitInstanceBindRegions,
	[Obsolete("Use VkImageCreateFlags._2dArrayCompatible")]
	_2dArrayCompatibleKhr = _2dArrayCompatible,
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
	DescriptorBufferCaptureReplayExt = 1 << 16,
	MultisampledRenderToSingleSampledExt = 1 << 18,
	_2dViewCompatibleExt = 1 << 17,
	FragmentDensityMapOffsetQcom = 1 << 15,
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
	Protected = 1 << 4,
	VideoDecodeKhr = 1 << 5,
	OpticalFlowNv = 1 << 8,
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
	RdmaCapableNv = 1 << 8,
}
[Flags]
public enum VkMemoryHeapFlags
{
	DeviceLocal = 1 << 0,
	MultiInstance = 1 << 1,
	[Obsolete("Use VkMemoryHeapFlags.MultiInstance")]
	MultiInstanceKhr = MultiInstance,
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
	TransformFeedbackExt = 1 << 24,
	ConditionalRenderingExt = 1 << 18,
	AccelerationStructureBuildKhr = 1 << 25,
	RayTracingShaderKhr = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags.FragmentShadingRateAttachmentKhr")]
	ShadingRateImageNv = FragmentShadingRateAttachmentKhr,
	[Obsolete("Use VkPipelineStageFlags.RayTracingShaderKhr")]
	RayTracingShaderNv = RayTracingShaderKhr,
	[Obsolete("Use VkPipelineStageFlags.AccelerationStructureBuildKhr")]
	AccelerationStructureBuildNv = AccelerationStructureBuildKhr,
	[Obsolete("Use VkPipelineStageFlags.TaskShaderExt")]
	TaskShaderNv = TaskShaderExt,
	[Obsolete("Use VkPipelineStageFlags.MeshShaderExt")]
	MeshShaderNv = MeshShaderExt,
	FragmentDensityProcessExt = 1 << 23,
	FragmentShadingRateAttachmentKhr = 1 << 22,
	CommandPreprocessNv = 1 << 17,
	[Obsolete("Use VkPipelineStageFlags.None")]
	NoneKhr = None,
	TaskShaderExt = 1 << 19,
	MeshShaderExt = 1 << 20,
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
	DeviceOnlyKhr = DeviceOnly,
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
	ResultStatusOnlyKhr = 1000023000,
	TransformFeedbackStreamExt = 1000028004,
	PerformanceQueryKhr = 1000116000,
	AccelerationStructureCompactedSizeKhr = 1000150000,
	AccelerationStructureSerializationSizeKhr = 1000150001,
	AccelerationStructureCompactedSizeNv = 1000165000,
	PerformanceQueryIntel = 1000210000,
	MeshPrimitivesGeneratedExt = 1000328000,
	PrimitivesGeneratedExt = 1000382000,
	AccelerationStructureSerializationBottomLevelPointersKhr = 1000386000,
	AccelerationStructureSizeKhr = 1000386001,
	MicromapSerializationSizeExt = 1000396000,
	MicromapCompactedSizeExt = 1000396001,
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
	TaskShaderInvocationsExt = 1 << 11,
	MeshShaderInvocationsExt = 1 << 12,
	ClusterCullingShaderInvocationsHuawei = 1 << 13,
}
[Flags]
public enum VkQueryResultFlags
{
	_64 = 1 << 0,
	Wait = 1 << 1,
	WithAvailability = 1 << 2,
	Partial = 1 << 3,
	WithStatusKhr = 1 << 4,
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
	DeviceAddressCaptureReplayExt = DeviceAddressCaptureReplay,
	[Obsolete("Use VkBufferCreateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKhr = DeviceAddressCaptureReplay,
	DescriptorBufferCaptureReplayExt = 1 << 5,
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
	VideoDecodeSourceKhr = 1 << 13,
	VideoDecodeDestinationKhr = 1 << 14,
	TransformFeedbackBufferExt = 1 << 11,
	TransformFeedbackCounterBufferExt = 1 << 12,
	ConditionalRenderingExt = 1 << 9,
	AccelerationStructureBuildInputReadOnlyKhr = 1 << 19,
	AccelerationStructureStorageKhr = 1 << 20,
	ShaderBindingTableKhr = 1 << 10,
	[Obsolete("Use VkBufferUsageFlags.ShaderBindingTableKhr")]
	RayTracingNv = ShaderBindingTableKhr,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddress")]
	ShaderDeviceAddressExt = ShaderDeviceAddress,
	[Obsolete("Use VkBufferUsageFlags.ShaderDeviceAddress")]
	ShaderDeviceAddressKhr = ShaderDeviceAddress,
	SamplerDescriptorBufferExt = 1 << 21,
	ResourceDescriptorBufferExt = 1 << 22,
	PushDescriptorsDescriptorBufferExt = 1 << 26,
	MicromapBuildInputReadOnlyExt = 1 << 23,
	MicromapStorageExt = 1 << 24,
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
	FragmentDensityMapDynamicExt = 1 << 0,
	DescriptorBufferCaptureReplayExt = 1 << 2,
	FragmentDensityMapDeferredExt = 1 << 1,
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
	ExternallySynchronized = 1 << 0,
	[Obsolete("Use VkPipelineCacheCreateFlags.ExternallySynchronized")]
	ExternallySynchronizedExt = ExternallySynchronized,
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
	RenderingFragmentShadingRateAttachmentKhr = 1 << 21,
	[Obsolete("Use VkPipelineCreateFlags.RenderingFragmentShadingRateAttachmentKhr")]
	RasterizationStateCreateFragmentShadingRateAttachmentKhr = RenderingFragmentShadingRateAttachmentKhr,
	RenderingFragmentDensityMapAttachmentExt = 1 << 22,
	[Obsolete("Use VkPipelineCreateFlags.RenderingFragmentDensityMapAttachmentExt")]
	RasterizationStateCreateFragmentDensityMapAttachmentExt = RenderingFragmentDensityMapAttachmentExt,
	[Obsolete("Use VkPipelineCreateFlags.ViewIndexFromDeviceIndex")]
	ViewIndexFromDeviceIndexKhr = ViewIndexFromDeviceIndex,
	[Obsolete("Use VkPipelineCreateFlags.DispatchBase")]
	DispatchBaseKhr = DispatchBase,
	RayTracingNoNullAnyHitShadersKhr = 1 << 14,
	RayTracingNoNullClosestHitShadersKhr = 1 << 15,
	RayTracingNoNullMissShadersKhr = 1 << 16,
	RayTracingNoNullIntersectionShadersKhr = 1 << 17,
	RayTracingSkipTrianglesKhr = 1 << 12,
	RayTracingSkipAabbsKhr = 1 << 13,
	RayTracingShaderGroupHandleCaptureReplayKhr = 1 << 19,
	DeferCompileNv = 1 << 5,
	CaptureStatisticsKhr = 1 << 6,
	CaptureInternalRepresentationsKhr = 1 << 7,
	IndirectBindableNv = 1 << 18,
	LibraryKhr = 1 << 11,
	[Obsolete("Use VkPipelineCreateFlags.FailOnPipelineCompileRequired")]
	FailOnPipelineCompileRequiredExt = FailOnPipelineCompileRequired,
	[Obsolete("Use VkPipelineCreateFlags.EarlyReturnOnFailure")]
	EarlyReturnOnFailureExt = EarlyReturnOnFailure,
	DescriptorBufferExt = 1 << 29,
	RetainLinkTimeOptimizationInfoExt = 1 << 23,
	LinkTimeOptimizationExt = 1 << 10,
	RayTracingAllowMotionNv = 1 << 20,
	ColorAttachmentFeedbackLoopExt = 1 << 25,
	DepthStencilAttachmentFeedbackLoopExt = 1 << 26,
	RayTracingOpacityMicromapExt = 1 << 24,
	NoProtectedAccessExt = 1 << 27,
	ProtectedAccessOnlyExt = 1 << 30,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags
{
	AllowVaryingSubgroupSize = 1 << 0,
	RequireFullSubgroups = 1 << 1,
	[Obsolete("Use VkPipelineShaderStageCreateFlags.AllowVaryingSubgroupSize")]
	AllowVaryingSubgroupSizeExt = AllowVaryingSubgroupSize,
	[Obsolete("Use VkPipelineShaderStageCreateFlags.RequireFullSubgroups")]
	RequireFullSubgroupsExt = RequireFullSubgroups,
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
	RaygenKhr = 1 << 8,
	AnyHitKhr = 1 << 9,
	ClosestHitKhr = 1 << 10,
	MissKhr = 1 << 11,
	IntersectionKhr = 1 << 12,
	CallableKhr = 1 << 13,
	[Obsolete("Use VkShaderStageFlags.RaygenKhr")]
	RaygenNv = RaygenKhr,
	[Obsolete("Use VkShaderStageFlags.AnyHitKhr")]
	AnyHitNv = AnyHitKhr,
	[Obsolete("Use VkShaderStageFlags.ClosestHitKhr")]
	ClosestHitNv = ClosestHitKhr,
	[Obsolete("Use VkShaderStageFlags.MissKhr")]
	MissNv = MissKhr,
	[Obsolete("Use VkShaderStageFlags.IntersectionKhr")]
	IntersectionNv = IntersectionKhr,
	[Obsolete("Use VkShaderStageFlags.CallableKhr")]
	CallableNv = CallableKhr,
	[Obsolete("Use VkShaderStageFlags.TaskExt")]
	TaskNv = TaskExt,
	[Obsolete("Use VkShaderStageFlags.MeshExt")]
	MeshNv = MeshExt,
	TaskExt = 1 << 6,
	MeshExt = 1 << 7,
	SubpassShadingHuawei = 1 << 14,
	ClusterCullingHuawei = 1 << 19,
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
	[Obsolete("Use VkPipelineDepthStencilStateCreateFlags.RasterizationOrderAttachmentDepthAccessExt")]
	RasterizationOrderAttachmentDepthAccessArm = RasterizationOrderAttachmentDepthAccessExt,
	[Obsolete("Use VkPipelineDepthStencilStateCreateFlags.RasterizationOrderAttachmentStencilAccessExt")]
	RasterizationOrderAttachmentStencilAccessArm = RasterizationOrderAttachmentStencilAccessExt,
	RasterizationOrderAttachmentDepthAccessExt = 1 << 0,
	RasterizationOrderAttachmentStencilAccessExt = 1 << 1,
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
	[Obsolete("Use VkPipelineColorBlendStateCreateFlags.RasterizationOrderAttachmentAccessExt")]
	RasterizationOrderAttachmentAccessArm = RasterizationOrderAttachmentAccessExt,
	RasterizationOrderAttachmentAccessExt = 1 << 0,
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
	ViewportWScalingNv = 1000087000,
	DiscardRectangleExt = 1000099000,
	SampleLocationsExt = 1000143000,
	RayTracingPipelineStackSizeKhr = 1000347000,
	ViewportShadingRatePaletteNv = 1000164004,
	ViewportCoarseSampleOrderNv = 1000164006,
	ExclusiveScissorNv = 1000205001,
	FragmentShadingRateKhr = 1000226000,
	LineStippleExt = 1000259000,
	[Obsolete("Use VkDynamicState.CullMode")]
	CullModeExt = CullMode,
	[Obsolete("Use VkDynamicState.FrontFace")]
	FrontFaceExt = FrontFace,
	[Obsolete("Use VkDynamicState.PrimitiveTopology")]
	PrimitiveTopologyExt = PrimitiveTopology,
	[Obsolete("Use VkDynamicState.ViewportWithCount")]
	ViewportWithCountExt = ViewportWithCount,
	[Obsolete("Use VkDynamicState.ScissorWithCount")]
	ScissorWithCountExt = ScissorWithCount,
	[Obsolete("Use VkDynamicState.VertexInputBindingStride")]
	VertexInputBindingStrideExt = VertexInputBindingStride,
	[Obsolete("Use VkDynamicState.DepthTestEnable")]
	DepthTestEnableExt = DepthTestEnable,
	[Obsolete("Use VkDynamicState.DepthWriteEnable")]
	DepthWriteEnableExt = DepthWriteEnable,
	[Obsolete("Use VkDynamicState.DepthCompareOp")]
	DepthCompareOpExt = DepthCompareOp,
	[Obsolete("Use VkDynamicState.DepthBoundsTestEnable")]
	DepthBoundsTestEnableExt = DepthBoundsTestEnable,
	[Obsolete("Use VkDynamicState.StencilTestEnable")]
	StencilTestEnableExt = StencilTestEnable,
	[Obsolete("Use VkDynamicState.StencilOp")]
	StencilOpExt = StencilOp,
	VertexInputExt = 1000352000,
	PatchControlPointsExt = 1000377000,
	[Obsolete("Use VkDynamicState.RasterizerDiscardEnable")]
	RasterizerDiscardEnableExt = RasterizerDiscardEnable,
	[Obsolete("Use VkDynamicState.DepthBiasEnable")]
	DepthBiasEnableExt = DepthBiasEnable,
	LogicOpExt = 1000377003,
	[Obsolete("Use VkDynamicState.PrimitiveRestartEnable")]
	PrimitiveRestartEnableExt = PrimitiveRestartEnable,
	ColorWriteEnableExt = 1000381000,
	TessellationDomainOriginExt = 1000455002,
	DepthClampEnableExt = 1000455003,
	PolygonModeExt = 1000455004,
	RasterizationSamplesExt = 1000455005,
	SampleMaskExt = 1000455006,
	AlphaToCoverageEnableExt = 1000455007,
	AlphaToOneEnableExt = 1000455008,
	LogicOpEnableExt = 1000455009,
	ColorBlendEnableExt = 1000455010,
	ColorBlendEquationExt = 1000455011,
	ColorWriteMaskExt = 1000455012,
	RasterizationStreamExt = 1000455013,
	ConservativeRasterizationModeExt = 1000455014,
	ExtraPrimitiveOverestimationSizeExt = 1000455015,
	DepthClipEnableExt = 1000455016,
	SampleLocationsEnableExt = 1000455017,
	ColorBlendAdvancedExt = 1000455018,
	ProvokingVertexModeExt = 1000455019,
	LineRasterizationModeExt = 1000455020,
	LineStippleEnableExt = 1000455021,
	DepthClipNegativeOneToOneExt = 1000455022,
	ViewportWScalingEnableNv = 1000455023,
	ViewportSwizzleNv = 1000455024,
	CoverageToColorEnableNv = 1000455025,
	CoverageToColorLocationNv = 1000455026,
	CoverageModulationModeNv = 1000455027,
	CoverageModulationTableEnableNv = 1000455028,
	CoverageModulationTableNv = 1000455029,
	ShadingRateImageEnableNv = 1000455030,
	RepresentativeFragmentTestEnableNv = 1000455031,
	CoverageReductionModeNv = 1000455032,
}
[Flags]
public enum VkPipelineLayoutCreateFlags
{
	IndependentSetsExt = 1 << 1,
}
[Flags]
public enum VkSamplerCreateFlags
{
	SubsampledExt = 1 << 0,
	SubsampledCoarseReconstructionExt = 1 << 1,
	DescriptorBufferCaptureReplayExt = 1 << 3,
	NonSeamlessCubeMapExt = 1 << 2,
	ImageProcessingQcom = 1 << 4,
}
public enum VkFilter
{
	Nearest = 0,
	Linear = 1,
	[Obsolete("Use VkFilter.CubicExt")]
	CubicImg = CubicExt,
	CubicExt = 1000170000,
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
	FloatCustomExt = 1000287003,
	IntCustomExt = 1000287004,
}
[Flags]
public enum VkDescriptorSetLayoutCreateFlags
{
	UpdateAfterBindPool = 1 << 1,
	PushDescriptorKhr = 1 << 0,
	[Obsolete("Use VkDescriptorSetLayoutCreateFlags.UpdateAfterBindPool")]
	UpdateAfterBindPoolExt = UpdateAfterBindPool,
	DescriptorBufferExt = 1 << 4,
	EmbeddedImmutableSamplersExt = 1 << 5,
	[Obsolete("Use VkDescriptorSetLayoutCreateFlags.HostOnlyPoolExt")]
	HostOnlyPoolValve = HostOnlyPoolExt,
	HostOnlyPoolExt = 1 << 2,
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
	InlineUniformBlockExt = InlineUniformBlock,
	AccelerationStructureKhr = 1000150000,
	AccelerationStructureNv = 1000165000,
	[Obsolete("Use VkDescriptorType.MutableExt")]
	MutableValve = MutableExt,
	SampleWeightImageQcom = 1000440000,
	BlockMatchImageQcom = 1000440001,
	MutableExt = 1000494000,
}
[Flags]
public enum VkDescriptorPoolCreateFlags
{
	FreeDescriptorSet = 1 << 0,
	UpdateAfterBind = 1 << 1,
	[Obsolete("Use VkDescriptorPoolCreateFlags.UpdateAfterBind")]
	UpdateAfterBindExt = UpdateAfterBind,
	[Obsolete("Use VkDescriptorPoolCreateFlags.HostOnlyExt")]
	HostOnlyValve = HostOnlyExt,
	HostOnlyExt = 1 << 2,
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
	ImagelessKhr = Imageless,
}
[Flags]
public enum VkRenderPassCreateFlags
{
	TransformQcom = 1 << 1,
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
	NoneExt = 1000400000,
}
public enum VkAttachmentStoreOp
{
	Store = 0,
	DontCare = 1,
	None = 1000301000,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneKhr = None,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneQcom = None,
	[Obsolete("Use VkAttachmentStoreOp.None")]
	NoneExt = None,
}
[Flags]
public enum VkSubpassDescriptionFlags
{
	PerViewAttributesNvx = 1 << 0,
	PerViewPositionXOnlyNvx = 1 << 1,
	FragmentRegionQcom = 1 << 2,
	ShaderResolveQcom = 1 << 3,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentColorAccessExt")]
	RasterizationOrderAttachmentColorAccessArm = RasterizationOrderAttachmentColorAccessExt,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentDepthAccessExt")]
	RasterizationOrderAttachmentDepthAccessArm = RasterizationOrderAttachmentDepthAccessExt,
	[Obsolete("Use VkSubpassDescriptionFlags.RasterizationOrderAttachmentStencilAccessExt")]
	RasterizationOrderAttachmentStencilAccessArm = RasterizationOrderAttachmentStencilAccessExt,
	RasterizationOrderAttachmentColorAccessExt = 1 << 4,
	RasterizationOrderAttachmentDepthAccessExt = 1 << 5,
	RasterizationOrderAttachmentStencilAccessExt = 1 << 6,
	EnableLegacyDitheringExt = 1 << 7,
}
public enum VkPipelineBindPoint
{
	Graphics = 0,
	Compute = 1,
	RayTracingKhr = 1000347000,
	[Obsolete("Use VkPipelineBindPoint.RayTracingKhr")]
	RayTracingNv = RayTracingKhr,
	SubpassShadingHuawei = 1000369003,
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
	FeedbackLoopExt = 1 << 3,
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
	Uint16 = 0,
	Uint32 = 1,
	NoneKhr = 1000150000,
	[Obsolete("Use VkIndexType.NoneKhr")]
	NoneNv = NoneKhr,
	Uint8Ext = 1000265000,
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
	DeviceAddress = 1 << 1,
	DeviceAddressCaptureReplay = 1 << 2,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKhr = DeviceMask,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddress")]
	DeviceAddressKhr = DeviceAddress,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKhr = DeviceAddressCaptureReplay,
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
	RgbIdentity = 0,
	YcbcrIdentity = 1,
	Ycbcr709 = 2,
	Ycbcr601 = 3,
	Ycbcr2020 = 4,
	[Obsolete("Use VkSamplerYcbcrModelConversion.RgbIdentity")]
	RgbIdentityKhr = RgbIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YcbcrIdentity")]
	YcbcrIdentityKhr = YcbcrIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr709")]
	Ycbcr709Khr = Ycbcr709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr601")]
	Ycbcr601Khr = Ycbcr601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr2020")]
	Ycbcr2020Khr = Ycbcr2020,
}
public enum VkSamplerYcbcrRange
{
	ItuFull = 0,
	ItuNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ItuFull")]
	ItuFullKhr = ItuFull,
	[Obsolete("Use VkSamplerYcbcrRange.ItuNarrow")]
	ItuNarrowKhr = ItuNarrow,
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
	D3d11Texture = 1 << 3,
	D3d11TextureKmt = 1 << 4,
	D3d12Heap = 1 << 5,
	D3d12Resource = 1 << 6,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d11Texture")]
	D3d11TextureKhr = D3d11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d11TextureKmt")]
	D3d11TextureKmtKhr = D3d11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d12Heap")]
	D3d12HeapKhr = D3d12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d12Resource")]
	D3d12ResourceKhr = D3d12Resource,
	DmaBufExt = 1 << 9,
	AndroidHardwareBufferAndroid = 1 << 10,
	HostAllocationExt = 1 << 7,
	HostMappedForeignMemoryExt = 1 << 8,
	RdmaAddressNv = 1 << 12,
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
	D3d12Fence = 1 << 3,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3d12Fence")]
	D3d11Fence = D3d12Fence,
	SyncFileDescriptor = 1 << 4,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3d12Fence")]
	D3d12FenceKhr = D3d12Fence,
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
public enum VkDriverId
{
	AmdProprietary = 1,
	AmdOpenSource = 2,
	MesaRadv = 3,
	NvidiaProprietary = 4,
	IntelProprietaryWindows = 5,
	IntelOpenSourceMesa = 6,
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
	ImaginationOpenSourceMesa = 25,
	[Obsolete("Use VkDriverId.AmdProprietary")]
	AmdProprietaryKhr = AmdProprietary,
	[Obsolete("Use VkDriverId.AmdOpenSource")]
	AmdOpenSourceKhr = AmdOpenSource,
	[Obsolete("Use VkDriverId.MesaRadv")]
	MesaRadvKhr = MesaRadv,
	[Obsolete("Use VkDriverId.NvidiaProprietary")]
	NvidiaProprietaryKhr = NvidiaProprietary,
	[Obsolete("Use VkDriverId.IntelProprietaryWindows")]
	IntelProprietaryWindowsKhr = IntelProprietaryWindows,
	[Obsolete("Use VkDriverId.IntelOpenSourceMesa")]
	IntelOpenSourceMesaKhr = IntelOpenSourceMesa,
	[Obsolete("Use VkDriverId.ImaginationProprietary")]
	ImaginationProprietaryKhr = ImaginationProprietary,
	[Obsolete("Use VkDriverId.QualcommProprietary")]
	QualcommProprietaryKhr = QualcommProprietary,
	[Obsolete("Use VkDriverId.ArmProprietary")]
	ArmProprietaryKhr = ArmProprietary,
	[Obsolete("Use VkDriverId.GoogleSwiftshader")]
	GoogleSwiftshaderKhr = GoogleSwiftshader,
	[Obsolete("Use VkDriverId.GgpProprietary")]
	GgpProprietaryKhr = GgpProprietary,
	[Obsolete("Use VkDriverId.BroadcomProprietary")]
	BroadcomProprietaryKhr = BroadcomProprietary,
}
public enum VkShaderFloatControlsIndependence
{
	_32Only = 0,
	All = 1,
	None = 2,
	[Obsolete("Use VkShaderFloatControlsIndependence._32Only")]
	_32OnlyKhr = _32Only,
	[Obsolete("Use VkShaderFloatControlsIndependence.All")]
	AllKhr = All,
	[Obsolete("Use VkShaderFloatControlsIndependence.None")]
	NoneKhr = None,
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
	NoneKhr = None,
	[Obsolete("Use VkResolveModeFlags.SampleZero")]
	SampleZeroKhr = SampleZero,
	[Obsolete("Use VkResolveModeFlags.Average")]
	AverageKhr = Average,
	[Obsolete("Use VkResolveModeFlags.Min")]
	MinKhr = Min,
	[Obsolete("Use VkResolveModeFlags.Max")]
	MaxKhr = Max,
}
[Flags]
public enum VkDescriptorBindingFlags
{
	UpdateAfterBind = 1 << 0,
	UpdateUnusedWhilePending = 1 << 1,
	PartiallyBound = 1 << 2,
	VariableDescriptorCount = 1 << 3,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateAfterBind")]
	UpdateAfterBindExt = UpdateAfterBind,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateUnusedWhilePending")]
	UpdateUnusedWhilePendingExt = UpdateUnusedWhilePending,
	[Obsolete("Use VkDescriptorBindingFlags.PartiallyBound")]
	PartiallyBoundExt = PartiallyBound,
	[Obsolete("Use VkDescriptorBindingFlags.VariableDescriptorCount")]
	VariableDescriptorCountExt = VariableDescriptorCount,
}
public enum VkSamplerReductionMode
{
	WeightedAverage = 0,
	Min = 1,
	Max = 2,
	[Obsolete("Use VkSamplerReductionMode.WeightedAverage")]
	WeightedAverageExt = WeightedAverage,
	[Obsolete("Use VkSamplerReductionMode.Min")]
	MinExt = Min,
	[Obsolete("Use VkSamplerReductionMode.Max")]
	MaxExt = Max,
}
[Flags]
public enum VkSemaphoreWaitFlags
{
	Any = 1 << 0,
	[Obsolete("Use VkSemaphoreWaitFlags.Any")]
	AnyKhr = Any,
}
public enum VkSemaphoreType
{
	Binary = 0,
	Timeline = 1,
	[Obsolete("Use VkSemaphoreType.Binary")]
	BinaryKhr = Binary,
	[Obsolete("Use VkSemaphoreType.Timeline")]
	TimelineKhr = Timeline,
}
[Flags]
public enum VkPipelineCreationFeedbackFlags
{
	Valid = 1 << 0,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.Valid")]
	ValidExt = Valid,
	ApplicationPipelineCacheHit = 1 << 1,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.ApplicationPipelineCacheHit")]
	ApplicationPipelineCacheHitExt = ApplicationPipelineCacheHit,
	BasePipelineAcceleration = 1 << 2,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.BasePipelineAcceleration")]
	BasePipelineAccelerationExt = BasePipelineAcceleration,
}
[Flags]
public enum VkToolPurposeFlags
{
	Validation = 1 << 0,
	[Obsolete("Use VkToolPurposeFlags.Validation")]
	ValidationExt = Validation,
	Profiling = 1 << 1,
	[Obsolete("Use VkToolPurposeFlags.Profiling")]
	ProfilingExt = Profiling,
	Tracing = 1 << 2,
	[Obsolete("Use VkToolPurposeFlags.Tracing")]
	TracingExt = Tracing,
	AdditionalFeatures = 1 << 3,
	[Obsolete("Use VkToolPurposeFlags.AdditionalFeatures")]
	AdditionalFeaturesExt = AdditionalFeatures,
	ModifyingFeatures = 1 << 4,
	[Obsolete("Use VkToolPurposeFlags.ModifyingFeatures")]
	ModifyingFeaturesExt = ModifyingFeatures,
	DebugReportingExt = 1 << 5,
	DebugMarkersExt = 1 << 6,
}
[Flags]
public enum VkPrivateDataSlotCreateFlags
{
}
[Flags]
public enum VkPipelineStageFlags2 : long
{
	_2None = 0,
	[Obsolete("Use VkPipelineStageFlags2._2None")]
	_2NoneKhr = _2None,
	_2TopOfPipe = 1 << 0,
	[Obsolete("Use VkPipelineStageFlags2._2TopOfPipe")]
	_2TopOfPipeKhr = _2TopOfPipe,
	_2DrawIndirect = 1 << 1,
	[Obsolete("Use VkPipelineStageFlags2._2DrawIndirect")]
	_2DrawIndirectKhr = _2DrawIndirect,
	_2VertexInput = 1 << 2,
	[Obsolete("Use VkPipelineStageFlags2._2VertexInput")]
	_2VertexInputKhr = _2VertexInput,
	_2VertexShader = 1 << 3,
	[Obsolete("Use VkPipelineStageFlags2._2VertexShader")]
	_2VertexShaderKhr = _2VertexShader,
	_2TessellationControlShader = 1 << 4,
	[Obsolete("Use VkPipelineStageFlags2._2TessellationControlShader")]
	_2TessellationControlShaderKhr = _2TessellationControlShader,
	_2TessellationEvaluationShader = 1 << 5,
	[Obsolete("Use VkPipelineStageFlags2._2TessellationEvaluationShader")]
	_2TessellationEvaluationShaderKhr = _2TessellationEvaluationShader,
	_2GeometryShader = 1 << 6,
	[Obsolete("Use VkPipelineStageFlags2._2GeometryShader")]
	_2GeometryShaderKhr = _2GeometryShader,
	_2FragmentShader = 1 << 7,
	[Obsolete("Use VkPipelineStageFlags2._2FragmentShader")]
	_2FragmentShaderKhr = _2FragmentShader,
	_2EarlyFragmentTests = 1 << 8,
	[Obsolete("Use VkPipelineStageFlags2._2EarlyFragmentTests")]
	_2EarlyFragmentTestsKhr = _2EarlyFragmentTests,
	_2LateFragmentTests = 1 << 9,
	[Obsolete("Use VkPipelineStageFlags2._2LateFragmentTests")]
	_2LateFragmentTestsKhr = _2LateFragmentTests,
	_2ColorAttachmentOutput = 1 << 10,
	[Obsolete("Use VkPipelineStageFlags2._2ColorAttachmentOutput")]
	_2ColorAttachmentOutputKhr = _2ColorAttachmentOutput,
	_2ComputeShader = 1 << 11,
	[Obsolete("Use VkPipelineStageFlags2._2ComputeShader")]
	_2ComputeShaderKhr = _2ComputeShader,
	_2AllTransfer = 1 << 12,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransfer")]
	_2AllTransferKhr = _2AllTransfer,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransferKhr")]
	_2Transfer = _2AllTransferKhr,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransfer")]
	_2TransferKhr = _2AllTransfer,
	_2BottomOfPipe = 1 << 13,
	[Obsolete("Use VkPipelineStageFlags2._2BottomOfPipe")]
	_2BottomOfPipeKhr = _2BottomOfPipe,
	_2Host = 1 << 14,
	[Obsolete("Use VkPipelineStageFlags2._2Host")]
	_2HostKhr = _2Host,
	_2AllGraphics = 1 << 15,
	[Obsolete("Use VkPipelineStageFlags2._2AllGraphics")]
	_2AllGraphicsKhr = _2AllGraphics,
	_2AllCommands = 1 << 16,
	[Obsolete("Use VkPipelineStageFlags2._2AllCommands")]
	_2AllCommandsKhr = _2AllCommands,
	_2Copy = 1 << 32,
	[Obsolete("Use VkPipelineStageFlags2._2Copy")]
	_2CopyKhr = _2Copy,
	_2Resolve = 1 << 33,
	[Obsolete("Use VkPipelineStageFlags2._2Resolve")]
	_2ResolveKhr = _2Resolve,
	_2Blit = 1 << 34,
	[Obsolete("Use VkPipelineStageFlags2._2Blit")]
	_2BlitKhr = _2Blit,
	_2Clear = 1 << 35,
	[Obsolete("Use VkPipelineStageFlags2._2Clear")]
	_2ClearKhr = _2Clear,
	_2IndexInput = 1 << 36,
	[Obsolete("Use VkPipelineStageFlags2._2IndexInput")]
	_2IndexInputKhr = _2IndexInput,
	_2VertexAttributeInput = 1 << 37,
	[Obsolete("Use VkPipelineStageFlags2._2VertexAttributeInput")]
	_2VertexAttributeInputKhr = _2VertexAttributeInput,
	_2PreRasterizationShaders = 1 << 38,
	[Obsolete("Use VkPipelineStageFlags2._2PreRasterizationShaders")]
	_2PreRasterizationShadersKhr = _2PreRasterizationShaders,
	_2VideoDecodeKhr = 1 << 26,
	_2TransformFeedbackExt = 1 << 24,
	_2ConditionalRenderingExt = 1 << 18,
	_2CommandPreprocessNv = 1 << 17,
	_2FragmentShadingRateAttachmentKhr = 1 << 22,
	[Obsolete("Use VkPipelineStageFlags2._2FragmentShadingRateAttachmentKhr")]
	_2ShadingRateImageNv = _2FragmentShadingRateAttachmentKhr,
	_2AccelerationStructureBuildKhr = 1 << 25,
	_2RayTracingShaderKhr = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags2._2RayTracingShaderKhr")]
	_2RayTracingShaderNv = _2RayTracingShaderKhr,
	[Obsolete("Use VkPipelineStageFlags2._2AccelerationStructureBuildKhr")]
	_2AccelerationStructureBuildNv = _2AccelerationStructureBuildKhr,
	_2FragmentDensityProcessExt = 1 << 23,
	[Obsolete("Use VkPipelineStageFlags2._2TaskShaderExt")]
	_2TaskShaderNv = _2TaskShaderExt,
	[Obsolete("Use VkPipelineStageFlags2._2MeshShaderExt")]
	_2MeshShaderNv = _2MeshShaderExt,
	_2TaskShaderExt = 1 << 19,
	_2MeshShaderExt = 1 << 20,
	_2SubpassShadingHuawei = 1 << 39,
	_2InvocationMaskHuawei = 1 << 40,
	_2AccelerationStructureCopyKhr = 1 << 28,
	_2MicromapBuildExt = 1 << 30,
	_2ClusterCullingShaderHuawei = 1 << 41,
	_2OpticalFlowNv = 1 << 29,
}
[Flags]
public enum VkAccessFlags2 : long
{
	_2None = 0,
	[Obsolete("Use VkAccessFlags2._2None")]
	_2NoneKhr = _2None,
	_2IndirectCommandRead = 1 << 0,
	[Obsolete("Use VkAccessFlags2._2IndirectCommandRead")]
	_2IndirectCommandReadKhr = _2IndirectCommandRead,
	_2IndexRead = 1 << 1,
	[Obsolete("Use VkAccessFlags2._2IndexRead")]
	_2IndexReadKhr = _2IndexRead,
	_2VertexAttributeRead = 1 << 2,
	[Obsolete("Use VkAccessFlags2._2VertexAttributeRead")]
	_2VertexAttributeReadKhr = _2VertexAttributeRead,
	_2UniformRead = 1 << 3,
	[Obsolete("Use VkAccessFlags2._2UniformRead")]
	_2UniformReadKhr = _2UniformRead,
	_2InputAttachmentRead = 1 << 4,
	[Obsolete("Use VkAccessFlags2._2InputAttachmentRead")]
	_2InputAttachmentReadKhr = _2InputAttachmentRead,
	_2ShaderRead = 1 << 5,
	[Obsolete("Use VkAccessFlags2._2ShaderRead")]
	_2ShaderReadKhr = _2ShaderRead,
	_2ShaderWrite = 1 << 6,
	[Obsolete("Use VkAccessFlags2._2ShaderWrite")]
	_2ShaderWriteKhr = _2ShaderWrite,
	_2ColorAttachmentRead = 1 << 7,
	[Obsolete("Use VkAccessFlags2._2ColorAttachmentRead")]
	_2ColorAttachmentReadKhr = _2ColorAttachmentRead,
	_2ColorAttachmentWrite = 1 << 8,
	[Obsolete("Use VkAccessFlags2._2ColorAttachmentWrite")]
	_2ColorAttachmentWriteKhr = _2ColorAttachmentWrite,
	_2DepthStencilAttachmentRead = 1 << 9,
	[Obsolete("Use VkAccessFlags2._2DepthStencilAttachmentRead")]
	_2DepthStencilAttachmentReadKhr = _2DepthStencilAttachmentRead,
	_2DepthStencilAttachmentWrite = 1 << 10,
	[Obsolete("Use VkAccessFlags2._2DepthStencilAttachmentWrite")]
	_2DepthStencilAttachmentWriteKhr = _2DepthStencilAttachmentWrite,
	_2TransferRead = 1 << 11,
	[Obsolete("Use VkAccessFlags2._2TransferRead")]
	_2TransferReadKhr = _2TransferRead,
	_2TransferWrite = 1 << 12,
	[Obsolete("Use VkAccessFlags2._2TransferWrite")]
	_2TransferWriteKhr = _2TransferWrite,
	_2HostRead = 1 << 13,
	[Obsolete("Use VkAccessFlags2._2HostRead")]
	_2HostReadKhr = _2HostRead,
	_2HostWrite = 1 << 14,
	[Obsolete("Use VkAccessFlags2._2HostWrite")]
	_2HostWriteKhr = _2HostWrite,
	_2MemoryRead = 1 << 15,
	[Obsolete("Use VkAccessFlags2._2MemoryRead")]
	_2MemoryReadKhr = _2MemoryRead,
	_2MemoryWrite = 1 << 16,
	[Obsolete("Use VkAccessFlags2._2MemoryWrite")]
	_2MemoryWriteKhr = _2MemoryWrite,
	_2ShaderSampledRead = 1 << 32,
	[Obsolete("Use VkAccessFlags2._2ShaderSampledRead")]
	_2ShaderSampledReadKhr = _2ShaderSampledRead,
	_2ShaderStorageRead = 1 << 33,
	[Obsolete("Use VkAccessFlags2._2ShaderStorageRead")]
	_2ShaderStorageReadKhr = _2ShaderStorageRead,
	_2ShaderStorageWrite = 1 << 34,
	[Obsolete("Use VkAccessFlags2._2ShaderStorageWrite")]
	_2ShaderStorageWriteKhr = _2ShaderStorageWrite,
	_2VideoDecodeReadKhr = 1 << 35,
	_2VideoDecodeWriteKhr = 1 << 36,
	_2TransformFeedbackWriteExt = 1 << 25,
	_2TransformFeedbackCounterReadExt = 1 << 26,
	_2TransformFeedbackCounterWriteExt = 1 << 27,
	_2ConditionalRenderingReadExt = 1 << 20,
	_2CommandPreprocessReadNv = 1 << 17,
	_2CommandPreprocessWriteNv = 1 << 18,
	_2FragmentShadingRateAttachmentReadKhr = 1 << 23,
	[Obsolete("Use VkAccessFlags2._2FragmentShadingRateAttachmentReadKhr")]
	_2ShadingRateImageReadNv = _2FragmentShadingRateAttachmentReadKhr,
	_2AccelerationStructureReadKhr = 1 << 21,
	_2AccelerationStructureWriteKhr = 1 << 22,
	[Obsolete("Use VkAccessFlags2._2AccelerationStructureReadKhr")]
	_2AccelerationStructureReadNv = _2AccelerationStructureReadKhr,
	[Obsolete("Use VkAccessFlags2._2AccelerationStructureWriteKhr")]
	_2AccelerationStructureWriteNv = _2AccelerationStructureWriteKhr,
	_2FragmentDensityMapReadExt = 1 << 24,
	_2ColorAttachmentReadNoncoherentExt = 1 << 19,
	_2DescriptorBufferReadExt = 1 << 41,
	_2InvocationMaskReadHuawei = 1 << 39,
	_2ShaderBindingTableReadKhr = 1 << 40,
	_2MicromapReadExt = 1 << 44,
	_2MicromapWriteExt = 1 << 45,
	_2OpticalFlowReadNv = 1 << 42,
	_2OpticalFlowWriteNv = 1 << 43,
}
[Flags]
public enum VkSubmitFlags
{
	Protected = 1 << 0,
	[Obsolete("Use VkSubmitFlags.Protected")]
	ProtectedKhr = Protected,
}
[Flags]
public enum VkRenderingFlags
{
	ContentsSecondaryCommandBuffers = 1 << 0,
	[Obsolete("Use VkRenderingFlags.ContentsSecondaryCommandBuffers")]
	ContentsSecondaryCommandBuffersKhr = ContentsSecondaryCommandBuffers,
	Suspending = 1 << 1,
	[Obsolete("Use VkRenderingFlags.Suspending")]
	SuspendingKhr = Suspending,
	Resuming = 1 << 2,
	[Obsolete("Use VkRenderingFlags.Resuming")]
	ResumingKhr = Resuming,
	EnableLegacyDitheringExt = 1 << 3,
}
[Flags]
public enum VkFormatFeatureFlags2 : long
{
	_2SampledImage = 1 << 0,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImage")]
	_2SampledImageKhr = _2SampledImage,
	_2StorageImage = 1 << 1,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageImage")]
	_2StorageImageKhr = _2StorageImage,
	_2StorageImageAtomic = 1 << 2,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageImageAtomic")]
	_2StorageImageAtomicKhr = _2StorageImageAtomic,
	_2UniformTexelBuffer = 1 << 3,
	[Obsolete("Use VkFormatFeatureFlags2._2UniformTexelBuffer")]
	_2UniformTexelBufferKhr = _2UniformTexelBuffer,
	_2StorageTexelBuffer = 1 << 4,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageTexelBuffer")]
	_2StorageTexelBufferKhr = _2StorageTexelBuffer,
	_2StorageTexelBufferAtomic = 1 << 5,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageTexelBufferAtomic")]
	_2StorageTexelBufferAtomicKhr = _2StorageTexelBufferAtomic,
	_2VertexBuffer = 1 << 6,
	[Obsolete("Use VkFormatFeatureFlags2._2VertexBuffer")]
	_2VertexBufferKhr = _2VertexBuffer,
	_2ColorAttachment = 1 << 7,
	[Obsolete("Use VkFormatFeatureFlags2._2ColorAttachment")]
	_2ColorAttachmentKhr = _2ColorAttachment,
	_2ColorAttachmentBlend = 1 << 8,
	[Obsolete("Use VkFormatFeatureFlags2._2ColorAttachmentBlend")]
	_2ColorAttachmentBlendKhr = _2ColorAttachmentBlend,
	_2DepthStencilAttachment = 1 << 9,
	[Obsolete("Use VkFormatFeatureFlags2._2DepthStencilAttachment")]
	_2DepthStencilAttachmentKhr = _2DepthStencilAttachment,
	_2BlitSource = 1 << 10,
	[Obsolete("Use VkFormatFeatureFlags2._2BlitSource")]
	_2BlitSourceKhr = _2BlitSource,
	_2BlitDestination = 1 << 11,
	[Obsolete("Use VkFormatFeatureFlags2._2BlitDestination")]
	_2BlitDestinationKhr = _2BlitDestination,
	_2SampledImageFilterLinear = 1 << 12,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterLinear")]
	_2SampledImageFilterLinearKhr = _2SampledImageFilterLinear,
	_2SampledImageFilterCubic = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterCubic")]
	_2SampledImageFilterCubicExt = _2SampledImageFilterCubic,
	_2TransferSource = 1 << 14,
	[Obsolete("Use VkFormatFeatureFlags2._2TransferSource")]
	_2TransferSourceKhr = _2TransferSource,
	_2TransferDestination = 1 << 15,
	[Obsolete("Use VkFormatFeatureFlags2._2TransferDestination")]
	_2TransferDestinationKhr = _2TransferDestination,
	_2SampledImageFilterMinmax = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterMinmax")]
	_2SampledImageFilterMinmaxKhr = _2SampledImageFilterMinmax,
	_2MidpointChromaSamples = 1 << 17,
	[Obsolete("Use VkFormatFeatureFlags2._2MidpointChromaSamples")]
	_2MidpointChromaSamplesKhr = _2MidpointChromaSamples,
	_2SampledImageYcbcrConversionLinearFilter = 1 << 18,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionLinearFilter")]
	_2SampledImageYcbcrConversionLinearFilterKhr = _2SampledImageYcbcrConversionLinearFilter,
	_2SampledImageYcbcrConversionSeparateReconstructionFilter = 1 << 19,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionSeparateReconstructionFilter")]
	_2SampledImageYcbcrConversionSeparateReconstructionFilterKhr = _2SampledImageYcbcrConversionSeparateReconstructionFilter,
	_2SampledImageYcbcrConversionChromaReconstructionExplicit = 1 << 20,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionChromaReconstructionExplicit")]
	_2SampledImageYcbcrConversionChromaReconstructionExplicitKhr = _2SampledImageYcbcrConversionChromaReconstructionExplicit,
	_2SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 1 << 21,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionChromaReconstructionExplicitForceable")]
	_2SampledImageYcbcrConversionChromaReconstructionExplicitForceableKhr = _2SampledImageYcbcrConversionChromaReconstructionExplicitForceable,
	_2Disjoint = 1 << 22,
	[Obsolete("Use VkFormatFeatureFlags2._2Disjoint")]
	_2DisjointKhr = _2Disjoint,
	_2CositedChromaSamples = 1 << 23,
	[Obsolete("Use VkFormatFeatureFlags2._2CositedChromaSamples")]
	_2CositedChromaSamplesKhr = _2CositedChromaSamples,
	_2StorageReadWithoutFormat = 1 << 31,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageReadWithoutFormat")]
	_2StorageReadWithoutFormatKhr = _2StorageReadWithoutFormat,
	_2StorageWriteWithoutFormat = 1 << 32,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageWriteWithoutFormat")]
	_2StorageWriteWithoutFormatKhr = _2StorageWriteWithoutFormat,
	_2SampledImageDepthComparison = 1 << 33,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageDepthComparison")]
	_2SampledImageDepthComparisonKhr = _2SampledImageDepthComparison,
	_2VideoDecodeOutputKhr = 1 << 25,
	_2VideoDecodeDpbKhr = 1 << 26,
	_2AccelerationStructureVertexBufferKhr = 1 << 29,
	_2FragmentDensityMapExt = 1 << 24,
	_2FragmentShadingRateAttachmentKhr = 1 << 30,
	_2LinearColorAttachmentNv = 1 << 38,
	_2WeightImageQcom = 1 << 34,
	_2WeightSampledImageQcom = 1 << 35,
	_2BlockMatchingQcom = 1 << 36,
	_2BoxFilterSampledQcom = 1 << 37,
	_2OpticalFlowImageNv = 1 << 40,
	_2OpticalFlowVectorNv = 1 << 41,
	_2OpticalFlowCostNv = 1 << 42,
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
	DisplayP3LinearExt = 1000104003,
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
	[Obsolete("Use VkColorSpaceKHR.DisplayP3LinearExt")]
	DciP3LinearExt = DisplayP3LinearExt,
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
	DeferredMemoryAllocationExt = 1 << 3,
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
	ValidationCacheExtExt = 33,
	[Obsolete("Use VkDebugReportObjectTypeEXT.ValidationCacheExtExt")]
	ValidationCacheExt = ValidationCacheExtExt,
	SamplerYcbcrConversionExt = 1000011000,
	DescriptorUpdateTemplateExt = 1000011000,
	CuModuleNvxExt = 1000029000,
	CuFunctionNvxExt = 1000029001,
	[Obsolete("Use VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateExt")]
	DescriptorUpdateTemplateKhrExt = DescriptorUpdateTemplateExt,
	AccelerationStructureKhrExt = 1000150000,
	[Obsolete("Use VkDebugReportObjectTypeEXT.SamplerYcbcrConversionExt")]
	SamplerYcbcrConversionKhrExt = SamplerYcbcrConversionExt,
	AccelerationStructureNvExt = 1000165000,
}
public enum VkRasterizationOrderAMD
{
	StrictAmd = 0,
	RelaxedAmd = 1,
}
[Flags]
public enum VkVideoCodecOperationFlagsKHR
{
	NoneKhr = 0,
	DecodeH264Khr = 1 << 0,
	DecodeH265Khr = 1 << 1,
}
[Flags]
public enum VkVideoChromaSubsamplingFlagsKHR
{
	InvalidKhr = 0,
	MonochromeKhr = 1 << 0,
	_420Khr = 1 << 1,
	_422Khr = 1 << 2,
	_444Khr = 1 << 3,
}
[Flags]
public enum VkVideoComponentBitDepthFlagsKHR
{
	InvalidKhr = 0,
	_8Khr = 1 << 0,
	_10Khr = 1 << 2,
	_12Khr = 1 << 4,
}
[Flags]
public enum VkVideoCapabilityFlagsKHR
{
	ProtectedContentKhr = 1 << 0,
	SeparateReferenceImagesKhr = 1 << 1,
}
[Flags]
public enum VkVideoSessionCreateFlagsKHR
{
	ProtectedContentKhr = 1 << 0,
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
	ResetKhr = 1 << 0,
}
public enum VkQueryResultStatusKHR
{
	ErrorKhr = -1,
	NotReadyKhr = 0,
	CompleteKhr = 1,
}
[Flags]
public enum VkVideoDecodeFlagsKHR
{
}
[Flags]
public enum VkVideoDecodeCapabilityFlagsKHR
{
	DpbAndOutputCoincideKhr = 1 << 0,
	DpbAndOutputDistinctKhr = 1 << 1,
}
[Flags]
public enum VkVideoDecodeUsageFlagsKHR
{
	DefaultKhr = 0,
	TranscodingKhr = 1 << 0,
	OfflineKhr = 1 << 1,
	StreamingKhr = 1 << 2,
}
[Flags]
public enum VkPipelineRasterizationStateStreamCreateFlagsEXT
{
}
[Flags]
public enum VkVideoDecodeH264PictureLayoutFlagsKHR
{
	ProgressiveKhr = 0,
	InterlacedInterleavedLinesKhr = 1 << 0,
	InterlacedSeparatePlanesKhr = 1 << 1,
}
public enum VkShaderInfoTypeAMD
{
	StatisticsAmd = 0,
	BinaryAmd = 1,
	DisassemblyAmd = 2,
}
[Obsolete("Use VkRenderingFlags")]
[Flags]
public enum VkRenderingFlagsKHR
{
	ContentsSecondaryCommandBuffers = 1 << 0,
	[Obsolete("Use VkRenderingFlags.ContentsSecondaryCommandBuffers")]
	ContentsSecondaryCommandBuffersKhr = ContentsSecondaryCommandBuffers,
	Suspending = 1 << 1,
	[Obsolete("Use VkRenderingFlags.Suspending")]
	SuspendingKhr = Suspending,
	Resuming = 1 << 2,
	[Obsolete("Use VkRenderingFlags.Resuming")]
	ResumingKhr = Resuming,
	EnableLegacyDitheringExt = 1 << 3,
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
	DeviceAddress = 1 << 1,
	DeviceAddressCaptureReplay = 1 << 2,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceMask")]
	DeviceMaskKhr = DeviceMask,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddress")]
	DeviceAddressKhr = DeviceAddress,
	[Obsolete("Use VkMemoryAllocateFlags.DeviceAddressCaptureReplay")]
	DeviceAddressCaptureReplayKhr = DeviceAddressCaptureReplay,
}
public enum VkValidationCheckEXT
{
	AllExt = 0,
	ShadersExt = 1,
}
public enum VkPipelineRobustnessBufferBehaviorEXT
{
	DeviceDefaultExt = 0,
	DisabledExt = 1,
	RobustBufferAccessExt = 2,
	RobustBufferAccess2Ext = 3,
}
public enum VkPipelineRobustnessImageBehaviorEXT
{
	DeviceDefaultExt = 0,
	DisabledExt = 1,
	RobustImageAccessExt = 2,
	RobustImageAccess2Ext = 3,
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
	D3d11Texture = 1 << 3,
	D3d11TextureKmt = 1 << 4,
	D3d12Heap = 1 << 5,
	D3d12Resource = 1 << 6,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d11Texture")]
	D3d11TextureKhr = D3d11Texture,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d11TextureKmt")]
	D3d11TextureKmtKhr = D3d11TextureKmt,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d12Heap")]
	D3d12HeapKhr = D3d12Heap,
	[Obsolete("Use VkExternalMemoryHandleTypeFlags.D3d12Resource")]
	D3d12ResourceKhr = D3d12Resource,
	DmaBufExt = 1 << 9,
	AndroidHardwareBufferAndroid = 1 << 10,
	HostAllocationExt = 1 << 7,
	HostMappedForeignMemoryExt = 1 << 8,
	RdmaAddressNv = 1 << 12,
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
	D3d12Fence = 1 << 3,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3d12Fence")]
	D3d11Fence = D3d12Fence,
	SyncFileDescriptor = 1 << 4,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueFileDescriptor")]
	OpaqueFileDescriptorKhr = OpaqueFileDescriptor,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32")]
	OpaqueWin32Khr = OpaqueWin32,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt")]
	OpaqueWin32KmtKhr = OpaqueWin32Kmt,
	[Obsolete("Use VkExternalSemaphoreHandleTypeFlags.D3d12Fence")]
	D3d12FenceKhr = D3d12Fence,
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
	CommandBufferKhr = 0,
	RenderPassKhr = 1,
	CommandKhr = 2,
	[Obsolete("Use VkPerformanceCounterScopeKHR.CommandBufferKhr")]
	QueryScopeCommandBufferKhr = CommandBufferKhr,
	[Obsolete("Use VkPerformanceCounterScopeKHR.RenderPassKhr")]
	QueryScopeRenderPassKhr = RenderPassKhr,
	[Obsolete("Use VkPerformanceCounterScopeKHR.CommandKhr")]
	QueryScopeCommandKhr = CommandKhr,
}
public enum VkPerformanceCounterStorageKHR
{
	Int32Khr = 0,
	Int64Khr = 1,
	Uint32Khr = 2,
	Uint64Khr = 3,
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
	DeviceAddressBindingExt = 1 << 3,
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
	WeightedAverageExt = WeightedAverage,
	[Obsolete("Use VkSamplerReductionMode.Min")]
	MinExt = Min,
	[Obsolete("Use VkSamplerReductionMode.Max")]
	MaxExt = Max,
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
public enum VkAccelerationStructureCreateFlagsKHR
{
	DeviceAddressCaptureReplayKhr = 1 << 0,
	DescriptorBufferCaptureReplayExt = 1 << 3,
	MotionNv = 1 << 2,
}
public enum VkAccelerationStructureTypeKHR
{
	TopLevelKhr = 0,
	BottomLevelKhr = 1,
	GenericKhr = 2,
	[Obsolete("Use VkAccelerationStructureTypeKHR.TopLevelKhr")]
	TopLevelNv = TopLevelKhr,
	[Obsolete("Use VkAccelerationStructureTypeKHR.BottomLevelKhr")]
	BottomLevelNv = BottomLevelKhr,
}
[Flags]
public enum VkBuildAccelerationStructureFlagsKHR
{
	AllowUpdateKhr = 1 << 0,
	AllowCompactionKhr = 1 << 1,
	PreferFastTraceKhr = 1 << 2,
	PreferFastBuildKhr = 1 << 3,
	LowMemoryKhr = 1 << 4,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowUpdateKhr")]
	AllowUpdateNv = AllowUpdateKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowCompactionKhr")]
	AllowCompactionNv = AllowCompactionKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKhr")]
	PreferFastTraceNv = PreferFastTraceKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKhr")]
	PreferFastBuildNv = PreferFastBuildKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.LowMemoryKhr")]
	LowMemoryNv = LowMemoryKhr,
	MotionNv = 1 << 5,
	AllowOpacityMicromapUpdateExt = 1 << 6,
	AllowDisableOpacityMicromapsExt = 1 << 7,
	AllowOpacityMicromapDataUpdateExt = 1 << 8,
}
public enum VkBuildAccelerationStructureModeKHR
{
	BuildKhr = 0,
	UpdateKhr = 1,
}
public enum VkGeometryTypeKHR
{
	TrianglesKhr = 0,
	AabbsKhr = 1,
	InstancesKhr = 2,
	[Obsolete("Use VkGeometryTypeKHR.TrianglesKhr")]
	TrianglesNv = TrianglesKhr,
	[Obsolete("Use VkGeometryTypeKHR.AabbsKhr")]
	AabbsNv = AabbsKhr,
}
[Flags]
public enum VkGeometryFlagsKHR
{
	OpaqueKhr = 1 << 0,
	NoDuplicateAnyHitInvocationKhr = 1 << 1,
	[Obsolete("Use VkGeometryFlagsKHR.OpaqueKhr")]
	OpaqueNv = OpaqueKhr,
	[Obsolete("Use VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKhr")]
	NoDuplicateAnyHitInvocationNv = NoDuplicateAnyHitInvocationKhr,
}
public enum VkCopyAccelerationStructureModeKHR
{
	CloneKhr = 0,
	CompactKhr = 1,
	SerializeKhr = 2,
	DeserializeKhr = 3,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CloneKhr")]
	CloneNv = CloneKhr,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CompactKhr")]
	CompactNv = CompactKhr,
}
public enum VkAccelerationStructureCompatibilityKHR
{
	CompatibleKhr = 0,
	IncompatibleKhr = 1,
}
public enum VkAccelerationStructureBuildTypeKHR
{
	HostKhr = 0,
	DeviceKhr = 1,
	HostOrDeviceKhr = 2,
}
[Flags]
public enum VkGeometryInstanceFlagsKHR
{
	TriangleFacingCullDisableKhr = 1 << 0,
	TriangleFlipFacingKhr = 1 << 1,
	ForceOpaqueKhr = 1 << 2,
	ForceNoOpaqueKhr = 1 << 3,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFlipFacingKhr")]
	TriangleFrontCounterclockwiseKhr = TriangleFlipFacingKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKhr")]
	TriangleCullDisableNv = TriangleFacingCullDisableKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFrontCounterclockwiseKhr")]
	TriangleFrontCounterclockwiseNv = TriangleFrontCounterclockwiseKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceOpaqueKhr")]
	ForceOpaqueNv = ForceOpaqueKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceNoOpaqueKhr")]
	ForceNoOpaqueNv = ForceNoOpaqueKhr,
	ForceOpacityMicromap2StateExt = 1 << 4,
	DisableOpacityMicromapsExt = 1 << 5,
}
public enum VkRayTracingShaderGroupTypeKHR
{
	GeneralKhr = 0,
	TrianglesHitGroupKhr = 1,
	ProceduralHitGroupKhr = 2,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.GeneralKhr")]
	GeneralNv = GeneralKhr,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKhr")]
	TrianglesHitGroupNv = TrianglesHitGroupKhr,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKhr")]
	ProceduralHitGroupNv = ProceduralHitGroupKhr,
}
public enum VkShaderGroupShaderKHR
{
	GeneralKhr = 0,
	ClosestHitKhr = 1,
	AnyHitKhr = 2,
	IntersectionKhr = 3,
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
[Obsolete("Use VkSamplerYcbcrModelConversion")]
public enum VkSamplerYcbcrModelConversionKHR
{
	RgbIdentity = 0,
	YcbcrIdentity = 1,
	Ycbcr709 = 2,
	Ycbcr601 = 3,
	Ycbcr2020 = 4,
	[Obsolete("Use VkSamplerYcbcrModelConversion.RgbIdentity")]
	RgbIdentityKhr = RgbIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.YcbcrIdentity")]
	YcbcrIdentityKhr = YcbcrIdentity,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr709")]
	Ycbcr709Khr = Ycbcr709,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr601")]
	Ycbcr601Khr = Ycbcr601,
	[Obsolete("Use VkSamplerYcbcrModelConversion.Ycbcr2020")]
	Ycbcr2020Khr = Ycbcr2020,
}
[Obsolete("Use VkSamplerYcbcrRange")]
public enum VkSamplerYcbcrRangeKHR
{
	ItuFull = 0,
	ItuNarrow = 1,
	[Obsolete("Use VkSamplerYcbcrRange.ItuFull")]
	ItuFullKhr = ItuFull,
	[Obsolete("Use VkSamplerYcbcrRange.ItuNarrow")]
	ItuNarrowKhr = ItuNarrow,
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
[Obsolete("Use VkDescriptorBindingFlags")]
[Flags]
public enum VkDescriptorBindingFlagsEXT
{
	UpdateAfterBind = 1 << 0,
	UpdateUnusedWhilePending = 1 << 1,
	PartiallyBound = 1 << 2,
	VariableDescriptorCount = 1 << 3,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateAfterBind")]
	UpdateAfterBindExt = UpdateAfterBind,
	[Obsolete("Use VkDescriptorBindingFlags.UpdateUnusedWhilePending")]
	UpdateUnusedWhilePendingExt = UpdateUnusedWhilePending,
	[Obsolete("Use VkDescriptorBindingFlags.PartiallyBound")]
	PartiallyBoundExt = PartiallyBound,
	[Obsolete("Use VkDescriptorBindingFlags.VariableDescriptorCount")]
	VariableDescriptorCountExt = VariableDescriptorCount,
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
[Obsolete("Use VkAccelerationStructureTypeKHR")]
public enum VkAccelerationStructureTypeNV
{
	TopLevelKhr = 0,
	BottomLevelKhr = 1,
	GenericKhr = 2,
	[Obsolete("Use VkAccelerationStructureTypeKHR.TopLevelKhr")]
	TopLevelNv = TopLevelKhr,
	[Obsolete("Use VkAccelerationStructureTypeKHR.BottomLevelKhr")]
	BottomLevelNv = BottomLevelKhr,
}
[Obsolete("Use VkBuildAccelerationStructureFlagsKHR")]
[Flags]
public enum VkBuildAccelerationStructureFlagsNV
{
	AllowUpdateKhr = 1 << 0,
	AllowCompactionKhr = 1 << 1,
	PreferFastTraceKhr = 1 << 2,
	PreferFastBuildKhr = 1 << 3,
	LowMemoryKhr = 1 << 4,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowUpdateKhr")]
	AllowUpdateNv = AllowUpdateKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.AllowCompactionKhr")]
	AllowCompactionNv = AllowCompactionKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKhr")]
	PreferFastTraceNv = PreferFastTraceKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKhr")]
	PreferFastBuildNv = PreferFastBuildKhr,
	[Obsolete("Use VkBuildAccelerationStructureFlagsKHR.LowMemoryKhr")]
	LowMemoryNv = LowMemoryKhr,
	MotionNv = 1 << 5,
	AllowOpacityMicromapUpdateExt = 1 << 6,
	AllowDisableOpacityMicromapsExt = 1 << 7,
	AllowOpacityMicromapDataUpdateExt = 1 << 8,
}
public enum VkAccelerationStructureMemoryRequirementsTypeNV
{
	ObjectNv = 0,
	BuildScratchNv = 1,
	UpdateScratchNv = 2,
}
[Obsolete("Use VkRayTracingShaderGroupTypeKHR")]
public enum VkRayTracingShaderGroupTypeNV
{
	GeneralKhr = 0,
	TrianglesHitGroupKhr = 1,
	ProceduralHitGroupKhr = 2,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.GeneralKhr")]
	GeneralNv = GeneralKhr,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKhr")]
	TrianglesHitGroupNv = TrianglesHitGroupKhr,
	[Obsolete("Use VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKhr")]
	ProceduralHitGroupNv = ProceduralHitGroupKhr,
}
[Obsolete("Use VkGeometryTypeKHR")]
public enum VkGeometryTypeNV
{
	TrianglesKhr = 0,
	AabbsKhr = 1,
	InstancesKhr = 2,
	[Obsolete("Use VkGeometryTypeKHR.TrianglesKhr")]
	TrianglesNv = TrianglesKhr,
	[Obsolete("Use VkGeometryTypeKHR.AabbsKhr")]
	AabbsNv = AabbsKhr,
}
[Obsolete("Use VkGeometryFlagsKHR")]
[Flags]
public enum VkGeometryFlagsNV
{
	OpaqueKhr = 1 << 0,
	NoDuplicateAnyHitInvocationKhr = 1 << 1,
	[Obsolete("Use VkGeometryFlagsKHR.OpaqueKhr")]
	OpaqueNv = OpaqueKhr,
	[Obsolete("Use VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKhr")]
	NoDuplicateAnyHitInvocationNv = NoDuplicateAnyHitInvocationKhr,
}
[Obsolete("Use VkGeometryInstanceFlagsKHR")]
[Flags]
public enum VkGeometryInstanceFlagsNV
{
	TriangleFacingCullDisableKhr = 1 << 0,
	TriangleFlipFacingKhr = 1 << 1,
	ForceOpaqueKhr = 1 << 2,
	ForceNoOpaqueKhr = 1 << 3,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFlipFacingKhr")]
	TriangleFrontCounterclockwiseKhr = TriangleFlipFacingKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKhr")]
	TriangleCullDisableNv = TriangleFacingCullDisableKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.TriangleFrontCounterclockwiseKhr")]
	TriangleFrontCounterclockwiseNv = TriangleFrontCounterclockwiseKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceOpaqueKhr")]
	ForceOpaqueNv = ForceOpaqueKhr,
	[Obsolete("Use VkGeometryInstanceFlagsKHR.ForceNoOpaqueKhr")]
	ForceNoOpaqueNv = ForceNoOpaqueKhr,
	ForceOpacityMicromap2StateExt = 1 << 4,
	DisableOpacityMicromapsExt = 1 << 5,
}
[Obsolete("Use VkCopyAccelerationStructureModeKHR")]
public enum VkCopyAccelerationStructureModeNV
{
	CloneKhr = 0,
	CompactKhr = 1,
	SerializeKhr = 2,
	DeserializeKhr = 3,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CloneKhr")]
	CloneNv = CloneKhr,
	[Obsolete("Use VkCopyAccelerationStructureModeKHR.CompactKhr")]
	CompactNv = CompactKhr,
}
[Obsolete("Use VkQueueGlobalPriorityKHR")]
public enum VkQueueGlobalPriorityEXT
{
	LowKhr = 128,
	MediumKhr = 256,
	HighKhr = 512,
	RealtimeKhr = 1024,
	[Obsolete("Use VkQueueGlobalPriorityKHR.LowKhr")]
	LowExt = LowKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.MediumKhr")]
	MediumExt = MediumKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.HighKhr")]
	HighExt = HighKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.RealtimeKhr")]
	RealtimeExt = RealtimeKhr,
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
public enum VkQueueGlobalPriorityKHR
{
	LowKhr = 128,
	MediumKhr = 256,
	HighKhr = 512,
	RealtimeKhr = 1024,
	[Obsolete("Use VkQueueGlobalPriorityKHR.LowKhr")]
	LowExt = LowKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.MediumKhr")]
	MediumExt = MediumKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.HighKhr")]
	HighExt = HighKhr,
	[Obsolete("Use VkQueueGlobalPriorityKHR.RealtimeKhr")]
	RealtimeExt = RealtimeKhr,
}
public enum VkMemoryOverallocationBehaviorAMD
{
	DefaultAmd = 0,
	AllowedAmd = 1,
	DisallowedAmd = 2,
}
[Obsolete("Use VkPipelineCreationFeedbackFlags")]
[Flags]
public enum VkPipelineCreationFeedbackFlagsEXT
{
	Valid = 1 << 0,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.Valid")]
	ValidExt = Valid,
	ApplicationPipelineCacheHit = 1 << 1,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.ApplicationPipelineCacheHit")]
	ApplicationPipelineCacheHitExt = ApplicationPipelineCacheHit,
	BasePipelineAcceleration = 1 << 2,
	[Obsolete("Use VkPipelineCreationFeedbackFlags.BasePipelineAcceleration")]
	BasePipelineAccelerationExt = BasePipelineAcceleration,
}
[Obsolete("Use VkDriverId")]
public enum VkDriverIdKHR
{
	AmdProprietary = 1,
	AmdOpenSource = 2,
	MesaRadv = 3,
	NvidiaProprietary = 4,
	IntelProprietaryWindows = 5,
	IntelOpenSourceMesa = 6,
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
	ImaginationOpenSourceMesa = 25,
	[Obsolete("Use VkDriverId.AmdProprietary")]
	AmdProprietaryKhr = AmdProprietary,
	[Obsolete("Use VkDriverId.AmdOpenSource")]
	AmdOpenSourceKhr = AmdOpenSource,
	[Obsolete("Use VkDriverId.MesaRadv")]
	MesaRadvKhr = MesaRadv,
	[Obsolete("Use VkDriverId.NvidiaProprietary")]
	NvidiaProprietaryKhr = NvidiaProprietary,
	[Obsolete("Use VkDriverId.IntelProprietaryWindows")]
	IntelProprietaryWindowsKhr = IntelProprietaryWindows,
	[Obsolete("Use VkDriverId.IntelOpenSourceMesa")]
	IntelOpenSourceMesaKhr = IntelOpenSourceMesa,
	[Obsolete("Use VkDriverId.ImaginationProprietary")]
	ImaginationProprietaryKhr = ImaginationProprietary,
	[Obsolete("Use VkDriverId.QualcommProprietary")]
	QualcommProprietaryKhr = QualcommProprietary,
	[Obsolete("Use VkDriverId.ArmProprietary")]
	ArmProprietaryKhr = ArmProprietary,
	[Obsolete("Use VkDriverId.GoogleSwiftshader")]
	GoogleSwiftshaderKhr = GoogleSwiftshader,
	[Obsolete("Use VkDriverId.GgpProprietary")]
	GgpProprietaryKhr = GgpProprietary,
	[Obsolete("Use VkDriverId.BroadcomProprietary")]
	BroadcomProprietaryKhr = BroadcomProprietary,
}
[Obsolete("Use VkShaderFloatControlsIndependence")]
public enum VkShaderFloatControlsIndependenceKHR
{
	_32Only = 0,
	All = 1,
	None = 2,
	[Obsolete("Use VkShaderFloatControlsIndependence._32Only")]
	_32OnlyKhr = _32Only,
	[Obsolete("Use VkShaderFloatControlsIndependence.All")]
	AllKhr = All,
	[Obsolete("Use VkShaderFloatControlsIndependence.None")]
	NoneKhr = None,
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
	NoneKhr = None,
	[Obsolete("Use VkResolveModeFlags.SampleZero")]
	SampleZeroKhr = SampleZero,
	[Obsolete("Use VkResolveModeFlags.Average")]
	AverageKhr = Average,
	[Obsolete("Use VkResolveModeFlags.Min")]
	MinKhr = Min,
	[Obsolete("Use VkResolveModeFlags.Max")]
	MaxKhr = Max,
}
[Obsolete("Use VkSemaphoreType")]
public enum VkSemaphoreTypeKHR
{
	Binary = 0,
	Timeline = 1,
	[Obsolete("Use VkSemaphoreType.Binary")]
	BinaryKhr = Binary,
	[Obsolete("Use VkSemaphoreType.Timeline")]
	TimelineKhr = Timeline,
}
[Obsolete("Use VkSemaphoreWaitFlags")]
[Flags]
public enum VkSemaphoreWaitFlagsKHR
{
	Any = 1 << 0,
	[Obsolete("Use VkSemaphoreWaitFlags.Any")]
	AnyKhr = Any,
}
public enum VkPerformanceOverrideTypeINTEL
{
	NullHardwareIntel = 0,
	FlushGpuCachesIntel = 1,
}
public enum VkPerformanceConfigurationTypeINTEL
{
	CommandQueueMetricsDiscoveryActivatedIntel = 0,
}
public enum VkPerformanceParameterTypeINTEL
{
	HwCountersSupportedIntel = 0,
	StreamMarkerValidBitsIntel = 1,
}
public enum VkPerformanceValueTypeINTEL
{
	Uint32Intel = 0,
	Uint64Intel = 1,
	FloatIntel = 2,
	BoolIntel = 3,
	StringIntel = 4,
}
public enum VkQueryPoolSamplingModeINTEL
{
	ManualIntel = 0,
}
public enum VkFragmentShadingRateCombinerOpKHR
{
	KeepKhr = 0,
	ReplaceKhr = 1,
	MinKhr = 2,
	MaxKhr = 3,
	MulKhr = 4,
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
	ValidationExt = Validation,
	Profiling = 1 << 1,
	[Obsolete("Use VkToolPurposeFlags.Profiling")]
	ProfilingExt = Profiling,
	Tracing = 1 << 2,
	[Obsolete("Use VkToolPurposeFlags.Tracing")]
	TracingExt = Tracing,
	AdditionalFeatures = 1 << 3,
	[Obsolete("Use VkToolPurposeFlags.AdditionalFeatures")]
	AdditionalFeaturesExt = AdditionalFeatures,
	ModifyingFeatures = 1 << 4,
	[Obsolete("Use VkToolPurposeFlags.ModifyingFeatures")]
	ModifyingFeaturesExt = ModifyingFeatures,
	DebugReportingExt = 1 << 5,
	DebugMarkersExt = 1 << 6,
}
public enum VkValidationFeatureEnableEXT
{
	GpuAssistedExt = 0,
	GpuAssistedReserveBindingSlotExt = 1,
	BestPracticesExt = 2,
	DebugPrintfExt = 3,
	SynchronizationValidationExt = 4,
}
public enum VkValidationFeatureDisableEXT
{
	AllExt = 0,
	ShadersExt = 1,
	ThreadSafetyExt = 2,
	ApiParametersExt = 3,
	ObjectLifetimesExt = 4,
	CoreChecksExt = 5,
	UniqueHandlesExt = 6,
	ShaderValidationCacheExt = 7,
}
public enum VkComponentTypeNV
{
	Float16Nv = 0,
	Float32Nv = 1,
	Float64Nv = 2,
	Sint8Nv = 3,
	Sint16Nv = 4,
	Sint32Nv = 5,
	Sint64Nv = 6,
	Uint8Nv = 7,
	Uint16Nv = 8,
	Uint32Nv = 9,
	Uint64Nv = 10,
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
public enum VkProvokingVertexModeEXT
{
	FirstVertexExt = 0,
	LastVertexExt = 1,
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
	Uint64Khr = 2,
	Float64Khr = 3,
}
[Flags]
public enum VkPresentScalingFlagsEXT
{
	OneToOneExt = 1 << 0,
	AspectRatioStretchExt = 1 << 1,
	StretchExt = 1 << 2,
}
[Flags]
public enum VkPresentGravityFlagsEXT
{
	MinExt = 1 << 0,
	MaxExt = 1 << 1,
	CenteredExt = 1 << 2,
}
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagsNV
{
	ExplicitPreprocessNv = 1 << 0,
	IndexedSequencesNv = 1 << 1,
	UnorderedSequencesNv = 1 << 2,
}
public enum VkIndirectCommandsTokenTypeNV
{
	ShaderGroupNv = 0,
	StateFlagsNv = 1,
	IndexBufferNv = 2,
	VertexBufferNv = 3,
	PushConstantNv = 4,
	DrawIndexedNv = 5,
	DrawNv = 6,
	DrawTasksNv = 7,
	DrawMeshTasksNv = 1000328000,
}
[Flags]
public enum VkIndirectStateFlagsNV
{
	FrontfaceNv = 1 << 0,
}
[Flags]
public enum VkDeviceMemoryReportFlagsEXT
{
}
public enum VkDeviceMemoryReportEventTypeEXT
{
	AllocateExt = 0,
	FreeExt = 1,
	ImportExt = 2,
	UnimportExt = 3,
	AllocationFailedExt = 4,
}
[Obsolete("Use VkPrivateDataSlotCreateFlags")]
[Flags]
public enum VkPrivateDataSlotCreateFlagsEXT
{
}
[Flags]
public enum VkDeviceDiagnosticsConfigFlagsNV
{
	EnableShaderDebugInfoNv = 1 << 0,
	EnableResourceTrackingNv = 1 << 1,
	EnableAutomaticCheckpointsNv = 1 << 2,
	EnableShaderErrorReportingNv = 1 << 3,
}
[Obsolete("Use VkPipelineStageFlags2")]
[Flags]
public enum VkPipelineStageFlags2KHR : long
{
	_2None = 0,
	[Obsolete("Use VkPipelineStageFlags2._2None")]
	_2NoneKhr = _2None,
	_2TopOfPipe = 1 << 0,
	[Obsolete("Use VkPipelineStageFlags2._2TopOfPipe")]
	_2TopOfPipeKhr = _2TopOfPipe,
	_2DrawIndirect = 1 << 1,
	[Obsolete("Use VkPipelineStageFlags2._2DrawIndirect")]
	_2DrawIndirectKhr = _2DrawIndirect,
	_2VertexInput = 1 << 2,
	[Obsolete("Use VkPipelineStageFlags2._2VertexInput")]
	_2VertexInputKhr = _2VertexInput,
	_2VertexShader = 1 << 3,
	[Obsolete("Use VkPipelineStageFlags2._2VertexShader")]
	_2VertexShaderKhr = _2VertexShader,
	_2TessellationControlShader = 1 << 4,
	[Obsolete("Use VkPipelineStageFlags2._2TessellationControlShader")]
	_2TessellationControlShaderKhr = _2TessellationControlShader,
	_2TessellationEvaluationShader = 1 << 5,
	[Obsolete("Use VkPipelineStageFlags2._2TessellationEvaluationShader")]
	_2TessellationEvaluationShaderKhr = _2TessellationEvaluationShader,
	_2GeometryShader = 1 << 6,
	[Obsolete("Use VkPipelineStageFlags2._2GeometryShader")]
	_2GeometryShaderKhr = _2GeometryShader,
	_2FragmentShader = 1 << 7,
	[Obsolete("Use VkPipelineStageFlags2._2FragmentShader")]
	_2FragmentShaderKhr = _2FragmentShader,
	_2EarlyFragmentTests = 1 << 8,
	[Obsolete("Use VkPipelineStageFlags2._2EarlyFragmentTests")]
	_2EarlyFragmentTestsKhr = _2EarlyFragmentTests,
	_2LateFragmentTests = 1 << 9,
	[Obsolete("Use VkPipelineStageFlags2._2LateFragmentTests")]
	_2LateFragmentTestsKhr = _2LateFragmentTests,
	_2ColorAttachmentOutput = 1 << 10,
	[Obsolete("Use VkPipelineStageFlags2._2ColorAttachmentOutput")]
	_2ColorAttachmentOutputKhr = _2ColorAttachmentOutput,
	_2ComputeShader = 1 << 11,
	[Obsolete("Use VkPipelineStageFlags2._2ComputeShader")]
	_2ComputeShaderKhr = _2ComputeShader,
	_2AllTransfer = 1 << 12,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransfer")]
	_2AllTransferKhr = _2AllTransfer,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransferKhr")]
	_2Transfer = _2AllTransferKhr,
	[Obsolete("Use VkPipelineStageFlags2._2AllTransfer")]
	_2TransferKhr = _2AllTransfer,
	_2BottomOfPipe = 1 << 13,
	[Obsolete("Use VkPipelineStageFlags2._2BottomOfPipe")]
	_2BottomOfPipeKhr = _2BottomOfPipe,
	_2Host = 1 << 14,
	[Obsolete("Use VkPipelineStageFlags2._2Host")]
	_2HostKhr = _2Host,
	_2AllGraphics = 1 << 15,
	[Obsolete("Use VkPipelineStageFlags2._2AllGraphics")]
	_2AllGraphicsKhr = _2AllGraphics,
	_2AllCommands = 1 << 16,
	[Obsolete("Use VkPipelineStageFlags2._2AllCommands")]
	_2AllCommandsKhr = _2AllCommands,
	_2Copy = 1 << 32,
	[Obsolete("Use VkPipelineStageFlags2._2Copy")]
	_2CopyKhr = _2Copy,
	_2Resolve = 1 << 33,
	[Obsolete("Use VkPipelineStageFlags2._2Resolve")]
	_2ResolveKhr = _2Resolve,
	_2Blit = 1 << 34,
	[Obsolete("Use VkPipelineStageFlags2._2Blit")]
	_2BlitKhr = _2Blit,
	_2Clear = 1 << 35,
	[Obsolete("Use VkPipelineStageFlags2._2Clear")]
	_2ClearKhr = _2Clear,
	_2IndexInput = 1 << 36,
	[Obsolete("Use VkPipelineStageFlags2._2IndexInput")]
	_2IndexInputKhr = _2IndexInput,
	_2VertexAttributeInput = 1 << 37,
	[Obsolete("Use VkPipelineStageFlags2._2VertexAttributeInput")]
	_2VertexAttributeInputKhr = _2VertexAttributeInput,
	_2PreRasterizationShaders = 1 << 38,
	[Obsolete("Use VkPipelineStageFlags2._2PreRasterizationShaders")]
	_2PreRasterizationShadersKhr = _2PreRasterizationShaders,
	_2VideoDecodeKhr = 1 << 26,
	_2TransformFeedbackExt = 1 << 24,
	_2ConditionalRenderingExt = 1 << 18,
	_2CommandPreprocessNv = 1 << 17,
	_2FragmentShadingRateAttachmentKhr = 1 << 22,
	[Obsolete("Use VkPipelineStageFlags2._2FragmentShadingRateAttachmentKhr")]
	_2ShadingRateImageNv = _2FragmentShadingRateAttachmentKhr,
	_2AccelerationStructureBuildKhr = 1 << 25,
	_2RayTracingShaderKhr = 1 << 21,
	[Obsolete("Use VkPipelineStageFlags2._2RayTracingShaderKhr")]
	_2RayTracingShaderNv = _2RayTracingShaderKhr,
	[Obsolete("Use VkPipelineStageFlags2._2AccelerationStructureBuildKhr")]
	_2AccelerationStructureBuildNv = _2AccelerationStructureBuildKhr,
	_2FragmentDensityProcessExt = 1 << 23,
	[Obsolete("Use VkPipelineStageFlags2._2TaskShaderExt")]
	_2TaskShaderNv = _2TaskShaderExt,
	[Obsolete("Use VkPipelineStageFlags2._2MeshShaderExt")]
	_2MeshShaderNv = _2MeshShaderExt,
	_2TaskShaderExt = 1 << 19,
	_2MeshShaderExt = 1 << 20,
	_2SubpassShadingHuawei = 1 << 39,
	_2InvocationMaskHuawei = 1 << 40,
	_2AccelerationStructureCopyKhr = 1 << 28,
	_2MicromapBuildExt = 1 << 30,
	_2ClusterCullingShaderHuawei = 1 << 41,
	_2OpticalFlowNv = 1 << 29,
}
[Obsolete("Use VkAccessFlags2")]
[Flags]
public enum VkAccessFlags2KHR : long
{
	_2None = 0,
	[Obsolete("Use VkAccessFlags2._2None")]
	_2NoneKhr = _2None,
	_2IndirectCommandRead = 1 << 0,
	[Obsolete("Use VkAccessFlags2._2IndirectCommandRead")]
	_2IndirectCommandReadKhr = _2IndirectCommandRead,
	_2IndexRead = 1 << 1,
	[Obsolete("Use VkAccessFlags2._2IndexRead")]
	_2IndexReadKhr = _2IndexRead,
	_2VertexAttributeRead = 1 << 2,
	[Obsolete("Use VkAccessFlags2._2VertexAttributeRead")]
	_2VertexAttributeReadKhr = _2VertexAttributeRead,
	_2UniformRead = 1 << 3,
	[Obsolete("Use VkAccessFlags2._2UniformRead")]
	_2UniformReadKhr = _2UniformRead,
	_2InputAttachmentRead = 1 << 4,
	[Obsolete("Use VkAccessFlags2._2InputAttachmentRead")]
	_2InputAttachmentReadKhr = _2InputAttachmentRead,
	_2ShaderRead = 1 << 5,
	[Obsolete("Use VkAccessFlags2._2ShaderRead")]
	_2ShaderReadKhr = _2ShaderRead,
	_2ShaderWrite = 1 << 6,
	[Obsolete("Use VkAccessFlags2._2ShaderWrite")]
	_2ShaderWriteKhr = _2ShaderWrite,
	_2ColorAttachmentRead = 1 << 7,
	[Obsolete("Use VkAccessFlags2._2ColorAttachmentRead")]
	_2ColorAttachmentReadKhr = _2ColorAttachmentRead,
	_2ColorAttachmentWrite = 1 << 8,
	[Obsolete("Use VkAccessFlags2._2ColorAttachmentWrite")]
	_2ColorAttachmentWriteKhr = _2ColorAttachmentWrite,
	_2DepthStencilAttachmentRead = 1 << 9,
	[Obsolete("Use VkAccessFlags2._2DepthStencilAttachmentRead")]
	_2DepthStencilAttachmentReadKhr = _2DepthStencilAttachmentRead,
	_2DepthStencilAttachmentWrite = 1 << 10,
	[Obsolete("Use VkAccessFlags2._2DepthStencilAttachmentWrite")]
	_2DepthStencilAttachmentWriteKhr = _2DepthStencilAttachmentWrite,
	_2TransferRead = 1 << 11,
	[Obsolete("Use VkAccessFlags2._2TransferRead")]
	_2TransferReadKhr = _2TransferRead,
	_2TransferWrite = 1 << 12,
	[Obsolete("Use VkAccessFlags2._2TransferWrite")]
	_2TransferWriteKhr = _2TransferWrite,
	_2HostRead = 1 << 13,
	[Obsolete("Use VkAccessFlags2._2HostRead")]
	_2HostReadKhr = _2HostRead,
	_2HostWrite = 1 << 14,
	[Obsolete("Use VkAccessFlags2._2HostWrite")]
	_2HostWriteKhr = _2HostWrite,
	_2MemoryRead = 1 << 15,
	[Obsolete("Use VkAccessFlags2._2MemoryRead")]
	_2MemoryReadKhr = _2MemoryRead,
	_2MemoryWrite = 1 << 16,
	[Obsolete("Use VkAccessFlags2._2MemoryWrite")]
	_2MemoryWriteKhr = _2MemoryWrite,
	_2ShaderSampledRead = 1 << 32,
	[Obsolete("Use VkAccessFlags2._2ShaderSampledRead")]
	_2ShaderSampledReadKhr = _2ShaderSampledRead,
	_2ShaderStorageRead = 1 << 33,
	[Obsolete("Use VkAccessFlags2._2ShaderStorageRead")]
	_2ShaderStorageReadKhr = _2ShaderStorageRead,
	_2ShaderStorageWrite = 1 << 34,
	[Obsolete("Use VkAccessFlags2._2ShaderStorageWrite")]
	_2ShaderStorageWriteKhr = _2ShaderStorageWrite,
	_2VideoDecodeReadKhr = 1 << 35,
	_2VideoDecodeWriteKhr = 1 << 36,
	_2TransformFeedbackWriteExt = 1 << 25,
	_2TransformFeedbackCounterReadExt = 1 << 26,
	_2TransformFeedbackCounterWriteExt = 1 << 27,
	_2ConditionalRenderingReadExt = 1 << 20,
	_2CommandPreprocessReadNv = 1 << 17,
	_2CommandPreprocessWriteNv = 1 << 18,
	_2FragmentShadingRateAttachmentReadKhr = 1 << 23,
	[Obsolete("Use VkAccessFlags2._2FragmentShadingRateAttachmentReadKhr")]
	_2ShadingRateImageReadNv = _2FragmentShadingRateAttachmentReadKhr,
	_2AccelerationStructureReadKhr = 1 << 21,
	_2AccelerationStructureWriteKhr = 1 << 22,
	[Obsolete("Use VkAccessFlags2._2AccelerationStructureReadKhr")]
	_2AccelerationStructureReadNv = _2AccelerationStructureReadKhr,
	[Obsolete("Use VkAccessFlags2._2AccelerationStructureWriteKhr")]
	_2AccelerationStructureWriteNv = _2AccelerationStructureWriteKhr,
	_2FragmentDensityMapReadExt = 1 << 24,
	_2ColorAttachmentReadNoncoherentExt = 1 << 19,
	_2DescriptorBufferReadExt = 1 << 41,
	_2InvocationMaskReadHuawei = 1 << 39,
	_2ShaderBindingTableReadKhr = 1 << 40,
	_2MicromapReadExt = 1 << 44,
	_2MicromapWriteExt = 1 << 45,
	_2OpticalFlowReadNv = 1 << 42,
	_2OpticalFlowWriteNv = 1 << 43,
}
[Obsolete("Use VkSubmitFlags")]
[Flags]
public enum VkSubmitFlagsKHR
{
	Protected = 1 << 0,
	[Obsolete("Use VkSubmitFlags.Protected")]
	ProtectedKhr = Protected,
}
[Flags]
public enum VkGraphicsPipelineLibraryFlagsEXT
{
	VertexInputInterfaceExt = 1 << 0,
	PreRasterizationShadersExt = 1 << 1,
	FragmentShaderExt = 1 << 2,
	FragmentOutputInterfaceExt = 1 << 3,
}
public enum VkFragmentShadingRateNV
{
	_1InvocationPerPixelNv = 0,
	_1InvocationPer1x2PixelsNv = 1,
	_1InvocationPer2x1PixelsNv = 4,
	_1InvocationPer2x2PixelsNv = 5,
	_1InvocationPer2x4PixelsNv = 6,
	_1InvocationPer4x2PixelsNv = 9,
	_1InvocationPer4x4PixelsNv = 10,
	_2InvocationsPerPixelNv = 11,
	_4InvocationsPerPixelNv = 12,
	_8InvocationsPerPixelNv = 13,
	_16InvocationsPerPixelNv = 14,
	NoInvocationsNv = 15,
}
public enum VkFragmentShadingRateTypeNV
{
	FragmentSizeNv = 0,
	EnumsNv = 1,
}
[Flags]
public enum VkAccelerationStructureMotionInfoFlagsNV
{
}
public enum VkAccelerationStructureMotionInstanceTypeNV
{
	StaticNv = 0,
	MatrixMotionNv = 1,
	SrtMotionNv = 2,
}
[Flags]
public enum VkAccelerationStructureMotionInstanceFlagsNV
{
}
[Flags]
public enum VkImageCompressionFlagsEXT
{
	DefaultExt = 0,
	FixedRateDefaultExt = 1 << 0,
	FixedRateExplicitExt = 1 << 1,
	DisabledExt = 1 << 2,
}
[Flags]
public enum VkImageCompressionFixedRateFlagsEXT
{
	NoneExt = 0,
	_1bpcExt = 1 << 0,
	_2bpcExt = 1 << 1,
	_3bpcExt = 1 << 2,
	_4bpcExt = 1 << 3,
	_5bpcExt = 1 << 4,
	_6bpcExt = 1 << 5,
	_7bpcExt = 1 << 6,
	_8bpcExt = 1 << 7,
	_9bpcExt = 1 << 8,
	_10bpcExt = 1 << 9,
	_11bpcExt = 1 << 10,
	_12bpcExt = 1 << 11,
	_13bpcExt = 1 << 12,
	_14bpcExt = 1 << 13,
	_15bpcExt = 1 << 14,
	_16bpcExt = 1 << 15,
	_17bpcExt = 1 << 16,
	_18bpcExt = 1 << 17,
	_19bpcExt = 1 << 18,
	_20bpcExt = 1 << 19,
	_21bpcExt = 1 << 20,
	_22bpcExt = 1 << 21,
	_23bpcExt = 1 << 22,
	_24bpcExt = 1 << 23,
}
public enum VkDeviceFaultAddressTypeEXT
{
	NoneExt = 0,
	ReadInvalidExt = 1,
	WriteInvalidExt = 2,
	ExecuteInvalidExt = 3,
	InstructionPointerUnknownExt = 4,
	InstructionPointerInvalidExt = 5,
	InstructionPointerFaultExt = 6,
}
public enum VkDeviceFaultVendorBinaryHeaderVersionEXT
{
	OneExt = 1,
}
[Flags]
public enum VkDeviceAddressBindingFlagsEXT
{
	InternalObjectExt = 1 << 0,
}
public enum VkDeviceAddressBindingTypeEXT
{
	BindExt = 0,
	UnbindExt = 1,
}
[Obsolete("Use VkFormatFeatureFlags2")]
[Flags]
public enum VkFormatFeatureFlags2KHR : long
{
	_2SampledImage = 1 << 0,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImage")]
	_2SampledImageKhr = _2SampledImage,
	_2StorageImage = 1 << 1,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageImage")]
	_2StorageImageKhr = _2StorageImage,
	_2StorageImageAtomic = 1 << 2,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageImageAtomic")]
	_2StorageImageAtomicKhr = _2StorageImageAtomic,
	_2UniformTexelBuffer = 1 << 3,
	[Obsolete("Use VkFormatFeatureFlags2._2UniformTexelBuffer")]
	_2UniformTexelBufferKhr = _2UniformTexelBuffer,
	_2StorageTexelBuffer = 1 << 4,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageTexelBuffer")]
	_2StorageTexelBufferKhr = _2StorageTexelBuffer,
	_2StorageTexelBufferAtomic = 1 << 5,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageTexelBufferAtomic")]
	_2StorageTexelBufferAtomicKhr = _2StorageTexelBufferAtomic,
	_2VertexBuffer = 1 << 6,
	[Obsolete("Use VkFormatFeatureFlags2._2VertexBuffer")]
	_2VertexBufferKhr = _2VertexBuffer,
	_2ColorAttachment = 1 << 7,
	[Obsolete("Use VkFormatFeatureFlags2._2ColorAttachment")]
	_2ColorAttachmentKhr = _2ColorAttachment,
	_2ColorAttachmentBlend = 1 << 8,
	[Obsolete("Use VkFormatFeatureFlags2._2ColorAttachmentBlend")]
	_2ColorAttachmentBlendKhr = _2ColorAttachmentBlend,
	_2DepthStencilAttachment = 1 << 9,
	[Obsolete("Use VkFormatFeatureFlags2._2DepthStencilAttachment")]
	_2DepthStencilAttachmentKhr = _2DepthStencilAttachment,
	_2BlitSource = 1 << 10,
	[Obsolete("Use VkFormatFeatureFlags2._2BlitSource")]
	_2BlitSourceKhr = _2BlitSource,
	_2BlitDestination = 1 << 11,
	[Obsolete("Use VkFormatFeatureFlags2._2BlitDestination")]
	_2BlitDestinationKhr = _2BlitDestination,
	_2SampledImageFilterLinear = 1 << 12,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterLinear")]
	_2SampledImageFilterLinearKhr = _2SampledImageFilterLinear,
	_2SampledImageFilterCubic = 1 << 13,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterCubic")]
	_2SampledImageFilterCubicExt = _2SampledImageFilterCubic,
	_2TransferSource = 1 << 14,
	[Obsolete("Use VkFormatFeatureFlags2._2TransferSource")]
	_2TransferSourceKhr = _2TransferSource,
	_2TransferDestination = 1 << 15,
	[Obsolete("Use VkFormatFeatureFlags2._2TransferDestination")]
	_2TransferDestinationKhr = _2TransferDestination,
	_2SampledImageFilterMinmax = 1 << 16,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageFilterMinmax")]
	_2SampledImageFilterMinmaxKhr = _2SampledImageFilterMinmax,
	_2MidpointChromaSamples = 1 << 17,
	[Obsolete("Use VkFormatFeatureFlags2._2MidpointChromaSamples")]
	_2MidpointChromaSamplesKhr = _2MidpointChromaSamples,
	_2SampledImageYcbcrConversionLinearFilter = 1 << 18,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionLinearFilter")]
	_2SampledImageYcbcrConversionLinearFilterKhr = _2SampledImageYcbcrConversionLinearFilter,
	_2SampledImageYcbcrConversionSeparateReconstructionFilter = 1 << 19,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionSeparateReconstructionFilter")]
	_2SampledImageYcbcrConversionSeparateReconstructionFilterKhr = _2SampledImageYcbcrConversionSeparateReconstructionFilter,
	_2SampledImageYcbcrConversionChromaReconstructionExplicit = 1 << 20,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionChromaReconstructionExplicit")]
	_2SampledImageYcbcrConversionChromaReconstructionExplicitKhr = _2SampledImageYcbcrConversionChromaReconstructionExplicit,
	_2SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 1 << 21,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageYcbcrConversionChromaReconstructionExplicitForceable")]
	_2SampledImageYcbcrConversionChromaReconstructionExplicitForceableKhr = _2SampledImageYcbcrConversionChromaReconstructionExplicitForceable,
	_2Disjoint = 1 << 22,
	[Obsolete("Use VkFormatFeatureFlags2._2Disjoint")]
	_2DisjointKhr = _2Disjoint,
	_2CositedChromaSamples = 1 << 23,
	[Obsolete("Use VkFormatFeatureFlags2._2CositedChromaSamples")]
	_2CositedChromaSamplesKhr = _2CositedChromaSamples,
	_2StorageReadWithoutFormat = 1 << 31,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageReadWithoutFormat")]
	_2StorageReadWithoutFormatKhr = _2StorageReadWithoutFormat,
	_2StorageWriteWithoutFormat = 1 << 32,
	[Obsolete("Use VkFormatFeatureFlags2._2StorageWriteWithoutFormat")]
	_2StorageWriteWithoutFormatKhr = _2StorageWriteWithoutFormat,
	_2SampledImageDepthComparison = 1 << 33,
	[Obsolete("Use VkFormatFeatureFlags2._2SampledImageDepthComparison")]
	_2SampledImageDepthComparisonKhr = _2SampledImageDepthComparison,
	_2VideoDecodeOutputKhr = 1 << 25,
	_2VideoDecodeDpbKhr = 1 << 26,
	_2AccelerationStructureVertexBufferKhr = 1 << 29,
	_2FragmentDensityMapExt = 1 << 24,
	_2FragmentShadingRateAttachmentKhr = 1 << 30,
	_2LinearColorAttachmentNv = 1 << 38,
	_2WeightImageQcom = 1 << 34,
	_2WeightSampledImageQcom = 1 << 35,
	_2BlockMatchingQcom = 1 << 36,
	_2BoxFilterSampledQcom = 1 << 37,
	_2OpticalFlowImageNv = 1 << 40,
	_2OpticalFlowVectorNv = 1 << 41,
	_2OpticalFlowCostNv = 1 << 42,
}
[Flags]
public enum VkMicromapCreateFlagsEXT
{
	DeviceAddressCaptureReplayExt = 1 << 0,
}
public enum VkMicromapTypeEXT
{
	OpacityMicromapExt = 0,
}
[Flags]
public enum VkBuildMicromapFlagsEXT
{
	PreferFastTraceExt = 1 << 0,
	PreferFastBuildExt = 1 << 1,
	AllowCompactionExt = 1 << 2,
}
public enum VkBuildMicromapModeEXT
{
	BuildExt = 0,
}
public enum VkCopyMicromapModeEXT
{
	CloneExt = 0,
	SerializeExt = 1,
	DeserializeExt = 2,
	CompactExt = 3,
}
public enum VkOpacityMicromapFormatEXT
{
	_2StateExt = 1,
	_4StateExt = 2,
}
public enum VkOpacityMicromapSpecialIndexEXT
{
	FullyTransparentExt = -1,
	FullyOpaqueExt = -2,
	FullyUnknownTransparentExt = -3,
	FullyUnknownOpaqueExt = -4,
}
[Flags]
public enum VkMemoryDecompressionMethodFlagsNV : long
{
	Gdeflate10Nv = 1 << 0,
}
public enum VkSubpassMergeStatusEXT
{
	MergedExt = 0,
	DisallowedExt = 1,
	NotMergedSideEffectsExt = 2,
	NotMergedSamplesMismatchExt = 3,
	NotMergedViewsMismatchExt = 4,
	NotMergedAliasingExt = 5,
	NotMergedDependenciesExt = 6,
	NotMergedIncompatibleInputAttachmentExt = 7,
	NotMergedTooManyAttachmentsExt = 8,
	NotMergedInsufficientStorageExt = 9,
	NotMergedDepthStencilCountExt = 10,
	NotMergedResolveAttachmentReuseExt = 11,
	NotMergedSingleSubpassExt = 12,
	NotMergedUnspecifiedExt = 13,
}
[Flags]
public enum VkDirectDriverLoadingFlagsLUNARG
{
}
public enum VkDirectDriverLoadingModeLUNARG
{
	ExclusiveLunarg = 0,
	InclusiveLunarg = 1,
}
[Flags]
public enum VkOpticalFlowUsageFlagsNV
{
	UnknownNv = 0,
	InputNv = 1 << 0,
	OutputNv = 1 << 1,
	HintNv = 1 << 2,
	CostNv = 1 << 3,
	GlobalFlowNv = 1 << 4,
}
[Flags]
public enum VkOpticalFlowGridSizeFlagsNV
{
	UnknownNv = 0,
	_1x1Nv = 1 << 0,
	_2x2Nv = 1 << 1,
	_4x4Nv = 1 << 2,
	_8x8Nv = 1 << 3,
}
public enum VkOpticalFlowPerformanceLevelNV
{
	UnknownNv = 0,
	SlowNv = 1,
	MediumNv = 2,
	FastNv = 3,
}
[Flags]
public enum VkOpticalFlowSessionCreateFlagsNV
{
	EnableHintNv = 1 << 0,
	EnableCostNv = 1 << 1,
	EnableGlobalFlowNv = 1 << 2,
	AllowRegionsNv = 1 << 3,
	BothDirectionsNv = 1 << 4,
}
public enum VkOpticalFlowSessionBindingPointNV
{
	UnknownNv = 0,
	InputNv = 1,
	ReferenceNv = 2,
	HintNv = 3,
	FlowVectorNv = 4,
	BackwardFlowVectorNv = 5,
	CostNv = 6,
	BackwardCostNv = 7,
	GlobalFlowNv = 8,
}
[Flags]
public enum VkOpticalFlowExecuteFlagsNV
{
	DisableTemporalHintsNv = 1 << 0,
}
public enum VkRayTracingInvocationReorderModeNV
{
	NoneNv = 0,
	ReorderNv = 1,
}
