// This file was generated, don't manually edit
namespace Vulkan_1_1;

public unsafe struct VkInstanceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkInstanceCreateFlags Flags;
	public VkApplicationInfo* ApplicationInfo;
	public uint EnabledLayerCount;
	public byte** EnabledLayerNames;
	public uint EnabledExtensionCount;
	public byte** EnabledExtensionNames;
}
public unsafe struct VkApplicationInfo
{
	public VkStructureType SType;
	public void* Next;
	public byte* ApplicationName;
	public uint ApplicationVersion;
	public byte* EngineName;
	public uint EngineVersion;
	public uint ApiVersion;
}
public unsafe struct VkAllocationCallbacks
{
	public void* UserData;
	public delegate*<void*, nuint, nuint, VkSystemAllocationScope, void*> Allocation;
	public delegate*<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> Reallocation;
	public delegate*<void*, void*, void> Free;
	public delegate*<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> InternalAllocation;
	public delegate*<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> InternalFree;
}
public unsafe struct VkPhysicalDeviceFeatures
{
	public VkBool32 RobustBufferAccess;
	public VkBool32 FullDrawIndexUint32;
	public VkBool32 ImageCubeArray;
	public VkBool32 IndependentBlend;
	public VkBool32 GeometryShader;
	public VkBool32 TessellationShader;
	public VkBool32 SampleRateShading;
	public VkBool32 DualSourceBlend;
	public VkBool32 LogicOp;
	public VkBool32 MultiDrawIndirect;
	public VkBool32 DrawIndirectFirstInstance;
	public VkBool32 DepthClamp;
	public VkBool32 DepthBiasClamp;
	public VkBool32 FillModeNonSolid;
	public VkBool32 DepthBounds;
	public VkBool32 WideLines;
	public VkBool32 LargePoints;
	public VkBool32 AlphaToOne;
	public VkBool32 MultiViewport;
	public VkBool32 SamplerAnisotropy;
	public VkBool32 TextureCompressionETC2;
	public VkBool32 TextureCompressionASTCLDR;
	public VkBool32 TextureCompressionBC;
	public VkBool32 OcclusionQueryPrecise;
	public VkBool32 PipelineStatisticsQuery;
	public VkBool32 VertexPipelineStoresAndAtomics;
	public VkBool32 FragmentStoresAndAtomics;
	public VkBool32 ShaderTessellationAndGeometryPointSize;
	public VkBool32 ShaderImageGatherExtended;
	public VkBool32 ShaderStorageImageExtendedFormats;
	public VkBool32 ShaderStorageImageMultisample;
	public VkBool32 ShaderStorageImageReadWithoutFormat;
	public VkBool32 ShaderStorageImageWriteWithoutFormat;
	public VkBool32 ShaderUniformBufferArrayDynamicIndexing;
	public VkBool32 ShaderSampledImageArrayDynamicIndexing;
	public VkBool32 ShaderStorageBufferArrayDynamicIndexing;
	public VkBool32 ShaderStorageImageArrayDynamicIndexing;
	public VkBool32 ShaderClipDistance;
	public VkBool32 ShaderCullDistance;
	public VkBool32 ShaderFloat64;
	public VkBool32 ShaderInt64;
	public VkBool32 ShaderInt16;
	public VkBool32 ShaderResourceResidency;
	public VkBool32 ShaderResourceMinLod;
	public VkBool32 SparseBinding;
	public VkBool32 SparseResidencyBuffer;
	public VkBool32 SparseResidencyImage2D;
	public VkBool32 SparseResidencyImage3D;
	public VkBool32 SparseResidency2Samples;
	public VkBool32 SparseResidency4Samples;
	public VkBool32 SparseResidency8Samples;
	public VkBool32 SparseResidency16Samples;
	public VkBool32 SparseResidencyAliased;
	public VkBool32 VariableMultisampleRate;
	public VkBool32 InheritedQueries;
}
public unsafe struct VkFormatProperties
{
	public VkFormatFeatureFlags LinearTilingFeatures;
	public VkFormatFeatureFlags OptimalTilingFeatures;
	public VkFormatFeatureFlags BufferFeatures;
}
public unsafe struct VkImageFormatProperties
{
	public VkExtent3D MaxExtent;
	public uint MaxMipLevels;
	public uint MaxArrayLayers;
	public VkSampleCountFlags SampleCounts;
	public VkDeviceSize MaxResourceSize;
}
public unsafe struct VkExtent3D
{
	public uint Width;
	public uint Height;
	public uint Depth;
}
public unsafe struct VkPhysicalDeviceProperties
{
	public uint ApiVersion;
	public uint DriverVersion;
	public uint VendorID;
	public uint DeviceID;
	public VkPhysicalDeviceType DeviceType;
	public fixed byte DeviceName[(int)VK.MaxPhysicalDeviceNameSize];
	public fixed byte PipelineCacheUUID[(int)VK.UuidSize];
	public VkPhysicalDeviceLimits Limits;
	public VkPhysicalDeviceSparseProperties SparseProperties;
}
public unsafe struct VkPhysicalDeviceLimits
{
	public uint MaxImageDimension1D;
	public uint MaxImageDimension2D;
	public uint MaxImageDimension3D;
	public uint MaxImageDimensionCube;
	public uint MaxImageArrayLayers;
	public uint MaxTexelBufferElements;
	public uint MaxUniformBufferRange;
	public uint MaxStorageBufferRange;
	public uint MaxPushConstantsSize;
	public uint MaxMemoryAllocationCount;
	public uint MaxSamplerAllocationCount;
	public VkDeviceSize BufferImageGranularity;
	public VkDeviceSize SparseAddressSpaceSize;
	public uint MaxBoundDescriptorSets;
	public uint MaxPerStageDescriptorSamplers;
	public uint MaxPerStageDescriptorUniformBuffers;
	public uint MaxPerStageDescriptorStorageBuffers;
	public uint MaxPerStageDescriptorSampledImages;
	public uint MaxPerStageDescriptorStorageImages;
	public uint MaxPerStageDescriptorInputAttachments;
	public uint MaxPerStageResources;
	public uint MaxDescriptorSetSamplers;
	public uint MaxDescriptorSetUniformBuffers;
	public uint MaxDescriptorSetUniformBuffersDynamic;
	public uint MaxDescriptorSetStorageBuffers;
	public uint MaxDescriptorSetStorageBuffersDynamic;
	public uint MaxDescriptorSetSampledImages;
	public uint MaxDescriptorSetStorageImages;
	public uint MaxDescriptorSetInputAttachments;
	public uint MaxVertexInputAttributes;
	public uint MaxVertexInputBindings;
	public uint MaxVertexInputAttributeOffset;
	public uint MaxVertexInputBindingStride;
	public uint MaxVertexOutputComponents;
	public uint MaxTessellationGenerationLevel;
	public uint MaxTessellationPatchSize;
	public uint MaxTessellationControlPerVertexInputComponents;
	public uint MaxTessellationControlPerVertexOutputComponents;
	public uint MaxTessellationControlPerPatchOutputComponents;
	public uint MaxTessellationControlTotalOutputComponents;
	public uint MaxTessellationEvaluationInputComponents;
	public uint MaxTessellationEvaluationOutputComponents;
	public uint MaxGeometryShaderInvocations;
	public uint MaxGeometryInputComponents;
	public uint MaxGeometryOutputComponents;
	public uint MaxGeometryOutputVertices;
	public uint MaxGeometryTotalOutputComponents;
	public uint MaxFragmentInputComponents;
	public uint MaxFragmentOutputAttachments;
	public uint MaxFragmentDualSourceAttachments;
	public uint MaxFragmentCombinedOutputResources;
	public uint MaxComputeSharedMemorySize;
	public fixed uint MaxComputeWorkGroupCount[3];
	public uint MaxComputeWorkGroupInvocations;
	public fixed uint MaxComputeWorkGroupSize[3];
	public uint SubPixelPrecisionBits;
	public uint SubTexelPrecisionBits;
	public uint MipmapPrecisionBits;
	public uint MaxDrawIndexedIndexValue;
	public uint MaxDrawIndirectCount;
	public float MaxSamplerLodBias;
	public float MaxSamplerAnisotropy;
	public uint MaxViewports;
	public fixed uint MaxViewportDimensions[2];
	public fixed float ViewportBoundsRange[2];
	public uint ViewportSubPixelBits;
	public nuint MinMemoryMapAlignment;
	public VkDeviceSize MinTexelBufferOffsetAlignment;
	public VkDeviceSize MinUniformBufferOffsetAlignment;
	public VkDeviceSize MinStorageBufferOffsetAlignment;
	public int MinTexelOffset;
	public uint MaxTexelOffset;
	public int MinTexelGatherOffset;
	public uint MaxTexelGatherOffset;
	public float MinInterpolationOffset;
	public float MaxInterpolationOffset;
	public uint SubPixelInterpolationOffsetBits;
	public uint MaxFramebufferWidth;
	public uint MaxFramebufferHeight;
	public uint MaxFramebufferLayers;
	public VkSampleCountFlags FramebufferColorSampleCounts;
	public VkSampleCountFlags FramebufferDepthSampleCounts;
	public VkSampleCountFlags FramebufferStencilSampleCounts;
	public VkSampleCountFlags FramebufferNoAttachmentsSampleCounts;
	public uint MaxColorAttachments;
	public VkSampleCountFlags SampledImageColorSampleCounts;
	public VkSampleCountFlags SampledImageIntegerSampleCounts;
	public VkSampleCountFlags SampledImageDepthSampleCounts;
	public VkSampleCountFlags SampledImageStencilSampleCounts;
	public VkSampleCountFlags StorageImageSampleCounts;
	public uint MaxSampleMaskWords;
	public VkBool32 TimestampComputeAndGraphics;
	public float TimestampPeriod;
	public uint MaxClipDistances;
	public uint MaxCullDistances;
	public uint MaxCombinedClipAndCullDistances;
	public uint DiscreteQueuePriorities;
	public fixed float PointSizeRange[2];
	public fixed float LineWidthRange[2];
	public float PointSizeGranularity;
	public float LineWidthGranularity;
	public VkBool32 StrictLines;
	public VkBool32 StandardSampleLocations;
	public VkDeviceSize OptimalBufferCopyOffsetAlignment;
	public VkDeviceSize OptimalBufferCopyRowPitchAlignment;
	public VkDeviceSize NonCoherentAtomSize;
}
public unsafe struct VkPhysicalDeviceSparseProperties
{
	public VkBool32 ResidencyStandard2DBlockShape;
	public VkBool32 ResidencyStandard2DMultisampleBlockShape;
	public VkBool32 ResidencyStandard3DBlockShape;
	public VkBool32 ResidencyAlignedMipSize;
	public VkBool32 ResidencyNonResidentStrict;
}
public unsafe struct VkQueueFamilyProperties
{
	public VkQueueFlags QueueFlags;
	public uint QueueCount;
	public uint TimestampValidBits;
	public VkExtent3D MinImageTransferGranularity;
}
public unsafe struct VkPhysicalDeviceMemoryProperties
{
	public uint MemoryTypeCount;
	public VkMemoryType MemoryTypes_0;
	public VkMemoryType MemoryTypes_1;
	public VkMemoryType MemoryTypes_2;
	public VkMemoryType MemoryTypes_3;
	public VkMemoryType MemoryTypes_4;
	public VkMemoryType MemoryTypes_5;
	public VkMemoryType MemoryTypes_6;
	public VkMemoryType MemoryTypes_7;
	public VkMemoryType MemoryTypes_8;
	public VkMemoryType MemoryTypes_9;
	public VkMemoryType MemoryTypes_10;
	public VkMemoryType MemoryTypes_11;
	public VkMemoryType MemoryTypes_12;
	public VkMemoryType MemoryTypes_13;
	public VkMemoryType MemoryTypes_14;
	public VkMemoryType MemoryTypes_15;
	public VkMemoryType MemoryTypes_16;
	public VkMemoryType MemoryTypes_17;
	public VkMemoryType MemoryTypes_18;
	public VkMemoryType MemoryTypes_19;
	public VkMemoryType MemoryTypes_20;
	public VkMemoryType MemoryTypes_21;
	public VkMemoryType MemoryTypes_22;
	public VkMemoryType MemoryTypes_23;
	public VkMemoryType MemoryTypes_24;
	public VkMemoryType MemoryTypes_25;
	public VkMemoryType MemoryTypes_26;
	public VkMemoryType MemoryTypes_27;
	public VkMemoryType MemoryTypes_28;
	public VkMemoryType MemoryTypes_29;
	public VkMemoryType MemoryTypes_30;
	public VkMemoryType MemoryTypes_31;
	public uint MemoryHeapCount;
	public VkMemoryHeap MemoryHeaps_0;
	public VkMemoryHeap MemoryHeaps_1;
	public VkMemoryHeap MemoryHeaps_2;
	public VkMemoryHeap MemoryHeaps_3;
	public VkMemoryHeap MemoryHeaps_4;
	public VkMemoryHeap MemoryHeaps_5;
	public VkMemoryHeap MemoryHeaps_6;
	public VkMemoryHeap MemoryHeaps_7;
	public VkMemoryHeap MemoryHeaps_8;
	public VkMemoryHeap MemoryHeaps_9;
	public VkMemoryHeap MemoryHeaps_10;
	public VkMemoryHeap MemoryHeaps_11;
	public VkMemoryHeap MemoryHeaps_12;
	public VkMemoryHeap MemoryHeaps_13;
	public VkMemoryHeap MemoryHeaps_14;
	public VkMemoryHeap MemoryHeaps_15;
}
public unsafe struct VkMemoryType
{
	public VkMemoryPropertyFlags PropertyFlags;
	public uint HeapIndex;
}
public unsafe struct VkMemoryHeap
{
	public VkDeviceSize Size;
	public VkMemoryHeapFlags Flags;
}
public unsafe struct VkDeviceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceCreateFlags Flags;
	public uint QueueCreateInfoCount;
	public VkDeviceQueueCreateInfo* QueueCreateInfos;
	public uint EnabledLayerCount;
	public byte** EnabledLayerNames;
	public uint EnabledExtensionCount;
	public byte** EnabledExtensionNames;
	public VkPhysicalDeviceFeatures* EnabledFeatures;
}
public unsafe struct VkDeviceQueueCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceQueueCreateFlags Flags;
	public uint QueueFamilyIndex;
	public uint QueueCount;
	public float* QueuePriorities;
}
public unsafe struct VkExtensionProperties
{
	public fixed byte ExtensionName[(int)VK.MaxExtensionNameSize];
	public uint SpecVersion;
}
public unsafe struct VkLayerProperties
{
	public fixed byte LayerName[(int)VK.MaxExtensionNameSize];
	public uint SpecVersion;
	public uint ImplementationVersion;
	public fixed byte Description[(int)VK.MaxDescriptionSize];
}
public unsafe struct VkSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreCount;
	public VkSemaphore* WaitSemaphores;
	public VkPipelineStageFlags* WaitDestinationStageMask;
	public uint CommandBufferCount;
	public VkCommandBuffer* CommandBuffers;
	public uint SignalSemaphoreCount;
	public VkSemaphore* SignalSemaphores;
}
public unsafe struct VkMemoryAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize AllocationSize;
	public uint MemoryTypeIndex;
}
public unsafe struct VkMappedMemoryRange
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
}
public unsafe struct VkMemoryRequirements
{
	public VkDeviceSize Size;
	public VkDeviceSize Alignment;
	public uint MemoryTypeBits;
}
public unsafe struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties FormatProperties;
	public uint ImageMipTailFirstLod;
	public VkDeviceSize ImageMipTailSize;
	public VkDeviceSize ImageMipTailOffset;
	public VkDeviceSize ImageMipTailStride;
}
public unsafe struct VkSparseImageFormatProperties
{
	public VkImageAspectFlags AspectMask;
	public VkExtent3D ImageGranularity;
	public VkSparseImageFormatFlags Flags;
}
public unsafe struct VkBindSparseInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreCount;
	public VkSemaphore* WaitSemaphores;
	public uint BufferBindCount;
	public VkSparseBufferMemoryBindInfo* BufferBinds;
	public uint ImageOpaqueBindCount;
	public VkSparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;
	public uint ImageBindCount;
	public VkSparseImageMemoryBindInfo* ImageBinds;
	public uint SignalSemaphoreCount;
	public VkSemaphore* SignalSemaphores;
}
public unsafe struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer Buffer;
	public uint BindCount;
	public VkSparseMemoryBind* Binds;
}
public unsafe struct VkSparseMemoryBind
{
	public VkDeviceSize ResourceOffset;
	public VkDeviceSize Size;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
	public VkSparseMemoryBindFlags Flags;
}
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
	public VkImage Image;
	public uint BindCount;
	public VkSparseMemoryBind* Binds;
}
public unsafe struct VkSparseImageMemoryBindInfo
{
	public VkImage Image;
	public uint BindCount;
	public VkSparseImageMemoryBind* Binds;
}
public unsafe struct VkSparseImageMemoryBind
{
	public VkImageSubresource Subresource;
	public VkOffset3D Offset;
	public VkExtent3D Extent;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
	public VkSparseMemoryBindFlags Flags;
}
public unsafe struct VkImageSubresource
{
	public VkImageAspectFlags AspectMask;
	public uint MipLevel;
	public uint ArrayLayer;
}
public unsafe struct VkOffset3D
{
	public int X;
	public int Y;
	public int Z;
}
public unsafe struct VkFenceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkFenceCreateFlags Flags;
}
public unsafe struct VkSemaphoreCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphoreCreateFlags Flags;
}
public unsafe struct VkEventCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkEventCreateFlags Flags;
}
public unsafe struct VkQueryPoolCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkQueryPoolCreateFlags Flags;
	public VkQueryType QueryType;
	public uint QueryCount;
	public VkQueryPipelineStatisticFlags PipelineStatistics;
}
public unsafe struct VkBufferCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferCreateFlags Flags;
	public VkDeviceSize Size;
	public VkBufferUsageFlags Usage;
	public VkSharingMode SharingMode;
	public uint QueueFamilyIndexCount;
	public uint* QueueFamilyIndices;
}
public unsafe struct VkBufferViewCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferViewCreateFlags Flags;
	public VkBuffer Buffer;
	public VkFormat Format;
	public VkDeviceSize Offset;
	public VkDeviceSize Range;
}
public unsafe struct VkImageCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageCreateFlags Flags;
	public VkImageType ImageType;
	public VkFormat Format;
	public VkExtent3D Extent;
	public uint MipLevels;
	public uint ArrayLayers;
	public VkSampleCountFlags Samples;
	public VkImageTiling Tiling;
	public VkImageUsageFlags Usage;
	public VkSharingMode SharingMode;
	public uint QueueFamilyIndexCount;
	public uint* QueueFamilyIndices;
	public VkImageLayout InitialLayout;
}
public unsafe struct VkSubresourceLayout
{
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
	public VkDeviceSize RowPitch;
	public VkDeviceSize ArrayPitch;
	public VkDeviceSize DepthPitch;
}
public unsafe struct VkImageViewCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageViewCreateFlags Flags;
	public VkImage Image;
	public VkImageViewType ViewType;
	public VkFormat Format;
	public VkComponentMapping Components;
	public VkImageSubresourceRange SubresourceRange;
}
public unsafe struct VkComponentMapping
{
	public VkComponentSwizzle R;
	public VkComponentSwizzle G;
	public VkComponentSwizzle B;
	public VkComponentSwizzle A;
}
public unsafe struct VkImageSubresourceRange
{
	public VkImageAspectFlags AspectMask;
	public uint BaseMipLevel;
	public uint LevelCount;
	public uint BaseArrayLayer;
	public uint LayerCount;
}
public unsafe struct VkShaderModuleCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderModuleCreateFlags Flags;
	public nuint CodeSize;
	public uint* Code;
}
public unsafe struct VkPipelineCacheCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCacheCreateFlags Flags;
	public nuint InitialDataSize;
	public void* InitialData;
}
public unsafe struct VkGraphicsPipelineCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreateFlags Flags;
	public uint StageCount;
	public VkPipelineShaderStageCreateInfo* Stages;
	public VkPipelineVertexInputStateCreateInfo* VertexInputState;
	public VkPipelineInputAssemblyStateCreateInfo* InputAssemblyState;
	public VkPipelineTessellationStateCreateInfo* TessellationState;
	public VkPipelineViewportStateCreateInfo* ViewportState;
	public VkPipelineRasterizationStateCreateInfo* RasterizationState;
	public VkPipelineMultisampleStateCreateInfo* MultisampleState;
	public VkPipelineDepthStencilStateCreateInfo* DepthStencilState;
	public VkPipelineColorBlendStateCreateInfo* ColorBlendState;
	public VkPipelineDynamicStateCreateInfo* DynamicState;
	public VkPipelineLayout Layout;
	public VkRenderPass RenderPass;
	public uint Subpass;
	public VkPipeline BasePipelineHandle;
	public int BasePipelineIndex;
}
public unsafe struct VkPipelineShaderStageCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineShaderStageCreateFlags Flags;
	public VkShaderStageFlags Stage;
	public VkShaderModule Module;
	public byte* Name;
	public VkSpecializationInfo* SpecializationInfo;
}
public unsafe struct VkSpecializationInfo
{
	public uint MapEntryCount;
	public VkSpecializationMapEntry* MapEntries;
	public nuint DataSize;
	public void* Data;
}
public unsafe struct VkSpecializationMapEntry
{
	public uint ConstantID;
	public uint Offset;
	public nuint Size;
}
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineVertexInputStateCreateFlags Flags;
	public uint VertexBindingDescriptionCount;
	public VkVertexInputBindingDescription* VertexBindingDescriptions;
	public uint VertexAttributeDescriptionCount;
	public VkVertexInputAttributeDescription* VertexAttributeDescriptions;
}
public unsafe struct VkVertexInputBindingDescription
{
	public uint Binding;
	public uint Stride;
	public VkVertexInputRate InputRate;
}
public unsafe struct VkVertexInputAttributeDescription
{
	public uint Location;
	public uint Binding;
	public VkFormat Format;
	public uint Offset;
}
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineInputAssemblyStateCreateFlags Flags;
	public VkPrimitiveTopology Topology;
	public VkBool32 PrimitiveRestartEnable;
}
public unsafe struct VkPipelineTessellationStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineTessellationStateCreateFlags Flags;
	public uint PatchControlPoints;
}
public unsafe struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineViewportStateCreateFlags Flags;
	public uint ViewportCount;
	public VkViewport* Viewports;
	public uint ScissorCount;
	public VkRect2D* Scissors;
}
public unsafe struct VkViewport
{
	public float X;
	public float Y;
	public float Width;
	public float Height;
	public float MinDepth;
	public float MaxDepth;
}
public unsafe struct VkRect2D
{
	public VkOffset2D Offset;
	public VkExtent2D Extent;
}
public unsafe struct VkOffset2D
{
	public int X;
	public int Y;
}
public unsafe struct VkExtent2D
{
	public uint Width;
	public uint Height;
}
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRasterizationStateCreateFlags Flags;
	public VkBool32 DepthClampEnable;
	public VkBool32 RasterizerDiscardEnable;
	public VkPolygonMode PolygonMode;
	public VkCullModeFlags CullMode;
	public VkFrontFace FrontFace;
	public VkBool32 DepthBiasEnable;
	public float DepthBiasConstantFactor;
	public float DepthBiasClamp;
	public float DepthBiasSlopeFactor;
	public float LineWidth;
}
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineMultisampleStateCreateFlags Flags;
	public VkSampleCountFlags RasterizationSamples;
	public VkBool32 SampleShadingEnable;
	public float MinSampleShading;
	public uint* SampleMask;
	public VkBool32 AlphaToCoverageEnable;
	public VkBool32 AlphaToOneEnable;
}
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineDepthStencilStateCreateFlags Flags;
	public VkBool32 DepthTestEnable;
	public VkBool32 DepthWriteEnable;
	public VkCompareOp DepthCompareOp;
	public VkBool32 DepthBoundsTestEnable;
	public VkBool32 StencilTestEnable;
	public VkStencilOpState Front;
	public VkStencilOpState Back;
	public float MinDepthBounds;
	public float MaxDepthBounds;
}
public unsafe struct VkStencilOpState
{
	public VkStencilOp FailOp;
	public VkStencilOp PassOp;
	public VkStencilOp DepthFailOp;
	public VkCompareOp CompareOp;
	public uint CompareMask;
	public uint WriteMask;
	public uint Reference;
}
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineColorBlendStateCreateFlags Flags;
	public VkBool32 LogicOpEnable;
	public VkLogicOp LogicOp;
	public uint AttachmentCount;
	public VkPipelineColorBlendAttachmentState* Attachments;
	public fixed float BlendConstants[4];
}
public unsafe struct VkPipelineColorBlendAttachmentState
{
	public VkBool32 BlendEnable;
	public VkBlendFactor SourceColorBlendFactor;
	public VkBlendFactor DestinationColorBlendFactor;
	public VkBlendOp ColorBlendOp;
	public VkBlendFactor SourceAlphaBlendFactor;
	public VkBlendFactor DestinationAlphaBlendFactor;
	public VkBlendOp AlphaBlendOp;
	public VkColorComponentFlags ColorWriteMask;
}
public unsafe struct VkPipelineDynamicStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineDynamicStateCreateFlags Flags;
	public uint DynamicStateCount;
	public VkDynamicState* DynamicStates;
}
public unsafe struct VkComputePipelineCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreateFlags Flags;
	public VkPipelineShaderStageCreateInfo Stage;
	public VkPipelineLayout Layout;
	public VkPipeline BasePipelineHandle;
	public int BasePipelineIndex;
}
public unsafe struct VkPipelineLayoutCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineLayoutCreateFlags Flags;
	public uint SetLayoutCount;
	public VkDescriptorSetLayout* SetLayouts;
	public uint PushConstantRangeCount;
	public VkPushConstantRange* PushConstantRanges;
}
public unsafe struct VkPushConstantRange
{
	public VkShaderStageFlags StageFlags;
	public uint Offset;
	public uint Size;
}
public unsafe struct VkSamplerCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerCreateFlags Flags;
	public VkFilter MagFilter;
	public VkFilter MinFilter;
	public VkSamplerMipmapMode MipmapMode;
	public VkSamplerAddressMode AddressModeU;
	public VkSamplerAddressMode AddressModeV;
	public VkSamplerAddressMode AddressModeW;
	public float MipLodBias;
	public VkBool32 AnisotropyEnable;
	public float MaxAnisotropy;
	public VkBool32 CompareEnable;
	public VkCompareOp CompareOp;
	public float MinLod;
	public float MaxLod;
	public VkBorderColor BorderColor;
	public VkBool32 UnnormalizedCoordinates;
}
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorSetLayoutCreateFlags Flags;
	public uint BindingCount;
	public VkDescriptorSetLayoutBinding* Bindings;
}
public unsafe struct VkDescriptorSetLayoutBinding
{
	public uint Binding;
	public VkDescriptorType DescriptorType;
	public uint DescriptorCount;
	public VkShaderStageFlags StageFlags;
	public VkSampler* ImmutableSamplers;
}
public unsafe struct VkDescriptorPoolCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorPoolCreateFlags Flags;
	public uint MaxSets;
	public uint PoolSizeCount;
	public VkDescriptorPoolSize* PoolSizes;
}
public unsafe struct VkDescriptorPoolSize
{
	public VkDescriptorType Type;
	public uint DescriptorCount;
}
public unsafe struct VkDescriptorSetAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorPool DescriptorPool;
	public uint DescriptorSetCount;
	public VkDescriptorSetLayout* SetLayouts;
}
public unsafe struct VkWriteDescriptorSet
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorSet DestinationSet;
	public uint DestinationBinding;
	public uint DestinationArrayElement;
	public uint DescriptorCount;
	public VkDescriptorType DescriptorType;
	public VkDescriptorImageInfo* ImageInfo;
	public VkDescriptorBufferInfo* BufferInfo;
	public VkBufferView* TexelBufferView;
}
public unsafe struct VkDescriptorImageInfo
{
	public VkSampler Sampler;
	public VkImageView ImageView;
	public VkImageLayout ImageLayout;
}
public unsafe struct VkDescriptorBufferInfo
{
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkDeviceSize Range;
}
public unsafe struct VkCopyDescriptorSet
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorSet SourceSet;
	public uint SourceBinding;
	public uint SourceArrayElement;
	public VkDescriptorSet DestinationSet;
	public uint DestinationBinding;
	public uint DestinationArrayElement;
	public uint DescriptorCount;
}
public unsafe struct VkFramebufferCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkFramebufferCreateFlags Flags;
	public VkRenderPass RenderPass;
	public uint AttachmentCount;
	public VkImageView* Attachments;
	public uint Width;
	public uint Height;
	public uint Layers;
}
public unsafe struct VkRenderPassCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPassCreateFlags Flags;
	public uint AttachmentCount;
	public VkAttachmentDescription* Attachments;
	public uint SubpassCount;
	public VkSubpassDescription* Subpasses;
	public uint DependencyCount;
	public VkSubpassDependency* Dependencies;
}
public unsafe struct VkAttachmentDescription
{
	public VkAttachmentDescriptionFlags Flags;
	public VkFormat Format;
	public VkSampleCountFlags Samples;
	public VkAttachmentLoadOp LoadOp;
	public VkAttachmentStoreOp StoreOp;
	public VkAttachmentLoadOp StencilLoadOp;
	public VkAttachmentStoreOp StencilStoreOp;
	public VkImageLayout InitialLayout;
	public VkImageLayout FinalLayout;
}
public unsafe struct VkSubpassDescription
{
	public VkSubpassDescriptionFlags Flags;
	public VkPipelineBindPoint PipelineBindPoint;
	public uint InputAttachmentCount;
	public VkAttachmentReference* InputAttachments;
	public uint ColorAttachmentCount;
	public VkAttachmentReference* ColorAttachments;
	public VkAttachmentReference* ResolveAttachments;
	public VkAttachmentReference* DepthStencilAttachment;
	public uint PreserveAttachmentCount;
	public uint* PreserveAttachments;
}
public unsafe struct VkAttachmentReference
{
	public uint Attachment;
	public VkImageLayout Layout;
}
public unsafe struct VkSubpassDependency
{
	public uint SourceSubpass;
	public uint DestinationSubpass;
	public VkPipelineStageFlags SourceStageMask;
	public VkPipelineStageFlags DestinationStageMask;
	public VkAccessFlags SourceAccessMask;
	public VkAccessFlags DestinationAccessMask;
	public VkDependencyFlags DependencyFlags;
}
public unsafe struct VkCommandPoolCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkCommandPoolCreateFlags Flags;
	public uint QueueFamilyIndex;
}
public unsafe struct VkCommandBufferAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkCommandPool CommandPool;
	public VkCommandBufferLevel Level;
	public uint CommandBufferCount;
}
public unsafe struct VkCommandBufferBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkCommandBufferUsageFlags Flags;
	public VkCommandBufferInheritanceInfo* InheritanceInfo;
}
public unsafe struct VkCommandBufferInheritanceInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPass RenderPass;
	public uint Subpass;
	public VkFramebuffer Framebuffer;
	public VkBool32 OcclusionQueryEnable;
	public VkQueryControlFlags QueryFlags;
	public VkQueryPipelineStatisticFlags PipelineStatistics;
}
public unsafe struct VkBufferCopy
{
	public VkDeviceSize SourceOffset;
	public VkDeviceSize DestinationOffset;
	public VkDeviceSize Size;
}
public unsafe struct VkImageCopy
{
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
}
public unsafe struct VkImageSubresourceLayers
{
	public VkImageAspectFlags AspectMask;
	public uint MipLevel;
	public uint BaseArrayLayer;
	public uint LayerCount;
}
public unsafe struct VkImageBlit
{
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffsets_0;
	public VkOffset3D SourceOffsets_1;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffsets_0;
	public VkOffset3D DestinationOffsets_1;
}
public unsafe struct VkBufferImageCopy
{
	public VkDeviceSize BufferOffset;
	public uint BufferRowLength;
	public uint BufferImageHeight;
	public VkImageSubresourceLayers ImageSubresource;
	public VkOffset3D ImageOffset;
	public VkExtent3D ImageExtent;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
	[FieldOffset(0)]
	public fixed float Float32[4];
	[FieldOffset(0)]
	public fixed int Int32[4];
	[FieldOffset(0)]
	public fixed uint Uint32[4];
}
public unsafe struct VkClearDepthStencilValue
{
	public float Depth;
	public uint Stencil;
}
public unsafe struct VkClearAttachment
{
	public VkImageAspectFlags AspectMask;
	public uint ColorAttachment;
	public VkClearValue ClearValue;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearValue
{
	[FieldOffset(0)]
	public VkClearColorValue Color;
	[FieldOffset(0)]
	public VkClearDepthStencilValue DepthStencil;
}
public unsafe struct VkClearRect
{
	public VkRect2D Rect;
	public uint BaseArrayLayer;
	public uint LayerCount;
}
public unsafe struct VkImageResolve
{
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
}
public unsafe struct VkMemoryBarrier
{
	public VkStructureType SType;
	public void* Next;
	public VkAccessFlags SourceAccessMask;
	public VkAccessFlags DestinationAccessMask;
}
public unsafe struct VkBufferMemoryBarrier
{
	public VkStructureType SType;
	public void* Next;
	public VkAccessFlags SourceAccessMask;
	public VkAccessFlags DestinationAccessMask;
	public uint SourceQueueFamilyIndex;
	public uint DestinationQueueFamilyIndex;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
}
public unsafe struct VkImageMemoryBarrier
{
	public VkStructureType SType;
	public void* Next;
	public VkAccessFlags SourceAccessMask;
	public VkAccessFlags DestinationAccessMask;
	public VkImageLayout OldLayout;
	public VkImageLayout NewLayout;
	public uint SourceQueueFamilyIndex;
	public uint DestinationQueueFamilyIndex;
	public VkImage Image;
	public VkImageSubresourceRange SubresourceRange;
}
public unsafe struct VkRenderPassBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPass RenderPass;
	public VkFramebuffer Framebuffer;
	public VkRect2D RenderArea;
	public uint ClearValueCount;
	public VkClearValue* ClearValues;
}
public unsafe struct VkDispatchIndirectCommand
{
	public uint X;
	public uint Y;
	public uint Z;
}
public unsafe struct VkDrawIndexedIndirectCommand
{
	public uint IndexCount;
	public uint InstanceCount;
	public uint FirstIndex;
	public int VertexOffset;
	public uint FirstInstance;
}
public unsafe struct VkDrawIndirectCommand
{
	public uint VertexCount;
	public uint InstanceCount;
	public uint FirstVertex;
	public uint FirstInstance;
}
public unsafe struct VkBaseOutStructure
{
	public VkStructureType SType;
	public VkBaseOutStructure* Next;
}
public unsafe struct VkBaseInStructure
{
	public VkStructureType SType;
	public VkBaseInStructure* Next;
}
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint SubgroupSize;
	public VkShaderStageFlags SupportedStages;
	public VkSubgroupFeatureFlags SupportedOperations;
	public VkBool32 QuadOperationsInAllStages;
}
public unsafe struct VkBindBufferMemoryInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
public unsafe struct VkBindImageMemoryInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 StorageBuffer16BitAccess;
	public VkBool32 UniformAndStorageBuffer16BitAccess;
	public VkBool32 StoragePushConstant16;
	public VkBool32 StorageInputOutput16;
}
public unsafe struct VkMemoryDedicatedRequirements
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrefersDedicatedAllocation;
	public VkBool32 RequiresDedicatedAllocation;
}
public unsafe struct VkMemoryDedicatedAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkBuffer Buffer;
}
public unsafe struct VkMemoryAllocateFlagsInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryAllocateFlags Flags;
	public uint DeviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
	public uint DeviceRenderAreaCount;
	public VkRect2D* DeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreCount;
	public uint* WaitSemaphoreDeviceIndices;
	public uint CommandBufferCount;
	public uint* CommandBufferDeviceMasks;
	public uint SignalSemaphoreCount;
	public uint* SignalSemaphoreDeviceIndices;
}
public unsafe struct VkDeviceGroupBindSparseInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint ResourceDeviceIndex;
	public uint MemoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
	public uint SplitInstanceBindRegionCount;
	public VkRect2D* SplitInstanceBindRegions;
}
public unsafe struct VkPhysicalDeviceGroupProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice PhysicalDevices_0;
	public VkPhysicalDevice PhysicalDevices_1;
	public VkPhysicalDevice PhysicalDevices_2;
	public VkPhysicalDevice PhysicalDevices_3;
	public VkPhysicalDevice PhysicalDevices_4;
	public VkPhysicalDevice PhysicalDevices_5;
	public VkPhysicalDevice PhysicalDevices_6;
	public VkPhysicalDevice PhysicalDevices_7;
	public VkPhysicalDevice PhysicalDevices_8;
	public VkPhysicalDevice PhysicalDevices_9;
	public VkPhysicalDevice PhysicalDevices_10;
	public VkPhysicalDevice PhysicalDevices_11;
	public VkPhysicalDevice PhysicalDevices_12;
	public VkPhysicalDevice PhysicalDevices_13;
	public VkPhysicalDevice PhysicalDevices_14;
	public VkPhysicalDevice PhysicalDevices_15;
	public VkPhysicalDevice PhysicalDevices_16;
	public VkPhysicalDevice PhysicalDevices_17;
	public VkPhysicalDevice PhysicalDevices_18;
	public VkPhysicalDevice PhysicalDevices_19;
	public VkPhysicalDevice PhysicalDevices_20;
	public VkPhysicalDevice PhysicalDevices_21;
	public VkPhysicalDevice PhysicalDevices_22;
	public VkPhysicalDevice PhysicalDevices_23;
	public VkPhysicalDevice PhysicalDevices_24;
	public VkPhysicalDevice PhysicalDevices_25;
	public VkPhysicalDevice PhysicalDevices_26;
	public VkPhysicalDevice PhysicalDevices_27;
	public VkPhysicalDevice PhysicalDevices_28;
	public VkPhysicalDevice PhysicalDevices_29;
	public VkPhysicalDevice PhysicalDevices_30;
	public VkPhysicalDevice PhysicalDevices_31;
	public VkBool32 SubsetAllocation;
}
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice* PhysicalDevices;
}
public unsafe struct VkImageMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
public unsafe struct VkMemoryRequirements2
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryRequirements MemoryRequirements;
}
public unsafe struct VkBufferMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
public unsafe struct VkSparseImageMemoryRequirements2
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageMemoryRequirements MemoryRequirements;
}
[Obsolete("Use VkMemoryRequirements2")]
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryRequirements MemoryRequirements;
}
public unsafe struct VkPhysicalDeviceFeatures2
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceFeatures Features;
}
public unsafe struct VkPhysicalDeviceProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceProperties Properties;
}
public unsafe struct VkFormatProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkFormatProperties FormatProperties;
}
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkImageType Type;
	public VkImageTiling Tiling;
	public VkImageUsageFlags Usage;
	public VkImageCreateFlags Flags;
}
public unsafe struct VkImageFormatProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkImageFormatProperties ImageFormatProperties;
}
public unsafe struct VkQueueFamilyProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueFamilyProperties QueueFamilyProperties;
}
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceMemoryProperties MemoryProperties;
}
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkImageType Type;
	public VkSampleCountFlags Samples;
	public VkImageUsageFlags Usage;
	public VkImageTiling Tiling;
}
public unsafe struct VkSparseImageFormatProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageFormatProperties Properties;
}
public unsafe struct VkPhysicalDevicePointClippingProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkPointClippingBehavior PointClippingBehavior;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint AspectReferenceCount;
	public VkInputAttachmentAspectReference* AspectReferences;
}
public unsafe struct VkInputAttachmentAspectReference
{
	public uint Subpass;
	public uint InputAttachmentIndex;
	public VkImageAspectFlags AspectMask;
}
public unsafe struct VkImageViewUsageCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags Usage;
}
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkTessellationDomainOrigin DomainOrigin;
}
public unsafe struct VkRenderPassMultiviewCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint SubpassCount;
	public uint* ViewMasks;
	public uint DependencyCount;
	public int* ViewOffsets;
	public uint CorrelationMaskCount;
	public uint* CorrelationMasks;
}
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Multiview;
	public VkBool32 MultiviewGeometryShader;
	public VkBool32 MultiviewTessellationShader;
}
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxMultiviewViewCount;
	public uint MaxMultiviewInstanceIndex;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
}
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
}
public unsafe struct VkDeviceQueueInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceQueueCreateFlags Flags;
	public uint QueueFamilyIndex;
	public uint QueueIndex;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProtectedMemory;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProtectedNoFault;
}
public unsafe struct VkProtectedSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProtectedSubmit;
}
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkSamplerYcbcrModelConversion YcbcrModel;
	public VkSamplerYcbcrRange YcbcrRange;
	public VkComponentMapping Components;
	public VkChromaLocation XChromaOffset;
	public VkChromaLocation YChromaOffset;
	public VkFilter ChromaFilter;
	public VkBool32 ForceExplicitReconstruction;
}
public unsafe struct VkSamplerYcbcrConversionInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerYcbcrConversion Conversion;
}
public unsafe struct VkBindImagePlaneMemoryInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SamplerYcbcrConversion;
}
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint CombinedImageSamplerDescriptorCount;
}
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorUpdateTemplateCreateFlags Flags;
	public uint DescriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType TemplateType;
	public VkDescriptorSetLayout DescriptorSetLayout;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipelineLayout PipelineLayout;
	public uint Set;
}
public unsafe struct VkDescriptorUpdateTemplateEntry
{
	public uint DestinationBinding;
	public uint DestinationArrayElement;
	public uint DescriptorCount;
	public VkDescriptorType DescriptorType;
	public nuint Offset;
	public nuint Stride;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferCreateFlags Flags;
	public VkBufferUsageFlags Usage;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkExternalBufferProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
public unsafe struct VkExternalMemoryProperties
{
	public VkExternalMemoryFeatureFlags ExternalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkExternalImageFormatProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
public unsafe struct VkPhysicalDeviceIDProperties
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	public fixed byte DriverUUID[(int)VK.UuidSize];
	public fixed byte DeviceLUID[(int)VK.LuidSize];
	public uint DeviceNodeMask;
	public VkBool32 DeviceLUIDValid;
}
public unsafe struct VkExternalMemoryImageCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
public unsafe struct VkExternalMemoryBufferCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
public unsafe struct VkExportMemoryAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags HandleType;
}
public unsafe struct VkExternalFenceProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags CompatibleHandleTypes;
	public VkExternalFenceFeatureFlags ExternalFenceFeatures;
}
public unsafe struct VkExportFenceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags HandleTypes;
}
public unsafe struct VkExportSemaphoreCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags HandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
public unsafe struct VkExternalSemaphoreProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
}
public unsafe struct VkDescriptorSetLayoutSupport
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Supported;
}
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPerSetDescriptors;
	public VkDeviceSize MaxMemoryAllocationSize;
}
[Obsolete("Use VkPhysicalDeviceShaderDrawParametersFeatures")]
public unsafe struct VkPhysicalDeviceShaderDrawParameterFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderDrawParameters;
}
public unsafe struct VkSurfaceCapabilitiesKHR
{
	public uint MinImageCount;
	public uint MaxImageCount;
	public VkExtent2D CurrentExtent;
	public VkExtent2D MinImageExtent;
	public VkExtent2D MaxImageExtent;
	public uint MaxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	public VkSurfaceTransformFlagsKHR CurrentTransform;
	public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;
	public VkImageUsageFlags SupportedUsageFlags;
}
public unsafe struct VkSurfaceFormatKHR
{
	public VkFormat Format;
	public VkColorSpaceKHR ColorSpace;
}
public unsafe struct VkSwapchainCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainCreateFlagsKHR Flags;
	public VkSurfaceKHR Surface;
	public uint MinImageCount;
	public VkFormat ImageFormat;
	public VkColorSpaceKHR ImageColorSpace;
	public VkExtent2D ImageExtent;
	public uint ImageArrayLayers;
	public VkImageUsageFlags ImageUsage;
	public VkSharingMode ImageSharingMode;
	public uint QueueFamilyIndexCount;
	public uint* QueueFamilyIndices;
	public VkSurfaceTransformFlagsKHR PreTransform;
	public VkCompositeAlphaFlagsKHR CompositeAlpha;
	public VkPresentModeKHR PresentMode;
	public VkBool32 Clipped;
	public VkSwapchainKHR OldSwapchain;
}
public unsafe struct VkPresentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreCount;
	public VkSemaphore* WaitSemaphores;
	public uint SwapchainCount;
	public VkSwapchainKHR* Swapchains;
	public uint* ImageIndices;
	public VkResult* Results;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed uint PresentMask[(int)VK.MaxDeviceGroupSize];
	public VkDeviceGroupPresentModeFlagsKHR Modes;
}
public unsafe struct VkAcquireNextImageInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
	public ulong Timeout;
	public VkSemaphore Semaphore;
	public VkFence Fence;
	public uint DeviceMask;
}
public unsafe struct VkImageSwapchainCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
}
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
	public uint ImageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public uint* DeviceMasks;
	public VkDeviceGroupPresentModeFlagsKHR Mode;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceGroupPresentModeFlagsKHR Modes;
}
public unsafe struct VkDisplayPropertiesKHR
{
	public VkDisplayKHR Display;
	public byte* DisplayName;
	public VkExtent2D PhysicalDimensions;
	public VkExtent2D PhysicalResolution;
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	public VkBool32 PlaneReorderPossible;
	public VkBool32 PersistentContent;
}
public unsafe struct VkDisplayPlanePropertiesKHR
{
	public VkDisplayKHR CurrentDisplay;
	public uint CurrentStackIndex;
}
public unsafe struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR DisplayMode;
	public VkDisplayModeParametersKHR Parameters;
}
public unsafe struct VkDisplayModeParametersKHR
{
	public VkExtent2D VisibleRegion;
	public uint RefreshRate;
}
public unsafe struct VkDisplayModeCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayModeCreateFlagsKHR Flags;
	public VkDisplayModeParametersKHR Parameters;
}
public unsafe struct VkDisplayPlaneCapabilitiesKHR
{
	public VkDisplayPlaneAlphaFlagsKHR SupportedAlpha;
	public VkOffset2D MinSourcePosition;
	public VkOffset2D MaxSourcePosition;
	public VkExtent2D MinSourceExtent;
	public VkExtent2D MaxSourceExtent;
	public VkOffset2D MinDestinationPosition;
	public VkOffset2D MaxDestinationPosition;
	public VkExtent2D MinDestinationExtent;
	public VkExtent2D MaxDestinationExtent;
}
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplaySurfaceCreateFlagsKHR Flags;
	public VkDisplayModeKHR DisplayMode;
	public uint PlaneIndex;
	public uint PlaneStackIndex;
	public VkSurfaceTransformFlagsKHR Transform;
	public float GlobalAlpha;
	public VkDisplayPlaneAlphaFlagsKHR AlphaMode;
	public VkExtent2D ImageExtent;
}
public unsafe struct VkDisplayPresentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkRect2D SourceRect;
	public VkRect2D DestinationRect;
	public VkBool32 Persistent;
}
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkXlibSurfaceCreateFlagsKHR Flags;
	public void* Dpy;
	public IntPtr Window;
}
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkXcbSurfaceCreateFlagsKHR Flags;
	public void* Connection;
	public IntPtr Window;
}
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkWaylandSurfaceCreateFlagsKHR Flags;
	public void* Display;
	public void* Surface;
}
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAndroidSurfaceCreateFlagsKHR Flags;
	public void* Window;
}
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkWin32SurfaceCreateFlagsKHR Flags;
	public IntPtr Hinstance;
	public IntPtr Hwnd;
}
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugReportFlagsEXT Flags;
	public delegate*<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void*, VkBool32> Callback;
	public void* UserData;
}
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkRasterizationOrderAMD RasterizationOrder;
}
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugReportObjectTypeEXT ObjectType;
	public ulong Object;
	public ulong TagName;
	public nuint TagSize;
	public void* Tag;
}
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugReportObjectTypeEXT ObjectType;
	public ulong Object;
	public byte* ObjectName;
}
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public byte* MarkerName;
	public fixed float Color[4];
}
public unsafe struct VkDedicatedAllocationImageCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkBuffer Buffer;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TransformFeedback;
	public VkBool32 GeometryStreams;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxTransformFeedbackStreams;
	public uint MaxTransformFeedbackBuffers;
	public VkDeviceSize MaxTransformFeedbackBufferSize;
	public uint MaxTransformFeedbackStreamDataSize;
	public uint MaxTransformFeedbackBufferDataSize;
	public uint MaxTransformFeedbackBufferDataStride;
	public VkBool32 TransformFeedbackQueries;
	public VkBool32 TransformFeedbackStreamsLinesTriangles;
	public VkBool32 TransformFeedbackRasterizationStreamSelect;
	public VkBool32 TransformFeedbackDraw;
}
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRasterizationStateStreamCreateFlagsEXT Flags;
	public uint RasterizationStream;
}
public unsafe struct VkImageViewHandleInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkImageView ImageView;
	public VkDescriptorType DescriptorType;
	public VkSampler Sampler;
}
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SupportsTextureGatherLODBiasAMD;
}
public unsafe struct VkShaderResourceUsageAMD
{
	public uint NumUsedVgprs;
	public uint NumUsedSgprs;
	public uint LdsSizePerLocalWorkGroup;
	public nuint LdsUsageSizeInBytes;
	public nuint ScratchMemUsageInBytes;
}
public unsafe struct VkShaderStatisticsInfoAMD
{
	public VkShaderStageFlags ShaderStageMask;
	public VkShaderResourceUsageAMD ResourceUsage;
	public uint NumPhysicalVgprs;
	public uint NumPhysicalSgprs;
	public uint NumAvailableVgprs;
	public uint NumAvailableSgprs;
	public fixed uint ComputeWorkGroupSize[3];
}
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 CornerSampledImage;
}
[Obsolete("Use VkRenderPassMultiviewCreateInfo")]
public unsafe struct VkRenderPassMultiviewCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SubpassCount;
	public uint* ViewMasks;
	public uint DependencyCount;
	public int* ViewOffsets;
	public uint CorrelationMaskCount;
	public uint* CorrelationMasks;
}
[Obsolete("Use VkPhysicalDeviceMultiviewFeatures")]
public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Multiview;
	public VkBool32 MultiviewGeometryShader;
	public VkBool32 MultiviewTessellationShader;
}
[Obsolete("Use VkPhysicalDeviceMultiviewProperties")]
public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxMultiviewViewCount;
	public uint MaxMultiviewInstanceIndex;
}
public unsafe struct VkExternalImageFormatPropertiesNV
{
	public VkImageFormatProperties ImageFormatProperties;
	public VkExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
}
public unsafe struct VkExternalMemoryImageCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
}
public unsafe struct VkExportMemoryAllocateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
}
public unsafe struct VkImportMemoryWin32HandleInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsNV HandleType;
	public IntPtr Handle;
}
public unsafe struct VkExportMemoryWin32HandleInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public SecurityAttributes* Attributes;
	public uint DwAccess;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint AcquireCount;
	public VkDeviceMemory* AcquireSyncs;
	public ulong* AcquireKeys;
	public uint* AcquireTimeoutMilliseconds;
	public uint ReleaseCount;
	public VkDeviceMemory* ReleaseSyncs;
	public ulong* ReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceFeatures2")]
public unsafe struct VkPhysicalDeviceFeatures2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceFeatures Features;
}
[Obsolete("Use VkPhysicalDeviceProperties2")]
public unsafe struct VkPhysicalDeviceProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceProperties Properties;
}
[Obsolete("Use VkFormatProperties2")]
public unsafe struct VkFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormatProperties FormatProperties;
}
[Obsolete("Use VkImageFormatProperties2")]
public unsafe struct VkImageFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageFormatProperties ImageFormatProperties;
}
[Obsolete("Use VkPhysicalDeviceImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceImageFormatInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkImageType Type;
	public VkImageTiling Tiling;
	public VkImageUsageFlags Usage;
	public VkImageCreateFlags Flags;
}
[Obsolete("Use VkQueueFamilyProperties2")]
public unsafe struct VkQueueFamilyProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueFamilyProperties QueueFamilyProperties;
}
[Obsolete("Use VkPhysicalDeviceMemoryProperties2")]
public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceMemoryProperties MemoryProperties;
}
[Obsolete("Use VkSparseImageFormatProperties2")]
public unsafe struct VkSparseImageFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageFormatProperties Properties;
}
[Obsolete("Use VkPhysicalDeviceSparseImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkImageType Type;
	public VkSampleCountFlags Samples;
	public VkImageUsageFlags Usage;
	public VkImageTiling Tiling;
}
[Obsolete("Use VkMemoryAllocateFlagsInfo")]
public unsafe struct VkMemoryAllocateFlagsInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryAllocateFlags Flags;
	public uint DeviceMask;
}
[Obsolete("Use VkDeviceGroupRenderPassBeginInfo")]
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
	public uint DeviceRenderAreaCount;
	public VkRect2D* DeviceRenderAreas;
}
[Obsolete("Use VkDeviceGroupCommandBufferBeginInfo")]
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
}
[Obsolete("Use VkDeviceGroupSubmitInfo")]
public unsafe struct VkDeviceGroupSubmitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreCount;
	public uint* WaitSemaphoreDeviceIndices;
	public uint CommandBufferCount;
	public uint* CommandBufferDeviceMasks;
	public uint SignalSemaphoreCount;
	public uint* SignalSemaphoreDeviceIndices;
}
[Obsolete("Use VkDeviceGroupBindSparseInfo")]
public unsafe struct VkDeviceGroupBindSparseInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint ResourceDeviceIndex;
	public uint MemoryDeviceIndex;
}
[Obsolete("Use VkBindBufferMemoryDeviceGroupInfo")]
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
}
[Obsolete("Use VkBindImageMemoryDeviceGroupInfo")]
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
	public uint SplitInstanceBindRegionCount;
	public VkRect2D* SplitInstanceBindRegions;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DisabledValidationCheckCount;
	public VkValidationCheckEXT* DisabledValidationChecks;
}
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TextureCompressionASTCHDR;
}
public unsafe struct VkImageViewASTCDecodeModeEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat DecodeMode;
}
public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DecodeModeSharedExponent;
}
[Obsolete("Use VkPhysicalDeviceGroupProperties")]
public unsafe struct VkPhysicalDeviceGroupPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice PhysicalDevices_0;
	public VkPhysicalDevice PhysicalDevices_1;
	public VkPhysicalDevice PhysicalDevices_2;
	public VkPhysicalDevice PhysicalDevices_3;
	public VkPhysicalDevice PhysicalDevices_4;
	public VkPhysicalDevice PhysicalDevices_5;
	public VkPhysicalDevice PhysicalDevices_6;
	public VkPhysicalDevice PhysicalDevices_7;
	public VkPhysicalDevice PhysicalDevices_8;
	public VkPhysicalDevice PhysicalDevices_9;
	public VkPhysicalDevice PhysicalDevices_10;
	public VkPhysicalDevice PhysicalDevices_11;
	public VkPhysicalDevice PhysicalDevices_12;
	public VkPhysicalDevice PhysicalDevices_13;
	public VkPhysicalDevice PhysicalDevices_14;
	public VkPhysicalDevice PhysicalDevices_15;
	public VkPhysicalDevice PhysicalDevices_16;
	public VkPhysicalDevice PhysicalDevices_17;
	public VkPhysicalDevice PhysicalDevices_18;
	public VkPhysicalDevice PhysicalDevices_19;
	public VkPhysicalDevice PhysicalDevices_20;
	public VkPhysicalDevice PhysicalDevices_21;
	public VkPhysicalDevice PhysicalDevices_22;
	public VkPhysicalDevice PhysicalDevices_23;
	public VkPhysicalDevice PhysicalDevices_24;
	public VkPhysicalDevice PhysicalDevices_25;
	public VkPhysicalDevice PhysicalDevices_26;
	public VkPhysicalDevice PhysicalDevices_27;
	public VkPhysicalDevice PhysicalDevices_28;
	public VkPhysicalDevice PhysicalDevices_29;
	public VkPhysicalDevice PhysicalDevices_30;
	public VkPhysicalDevice PhysicalDevices_31;
	public VkBool32 SubsetAllocation;
}
[Obsolete("Use VkDeviceGroupDeviceCreateInfo")]
public unsafe struct VkDeviceGroupDeviceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice* PhysicalDevices;
}
[Obsolete("Use VkExternalMemoryProperties")]
public unsafe struct VkExternalMemoryPropertiesKHR
{
	public VkExternalMemoryFeatureFlags ExternalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes;
}
[Obsolete("Use VkPhysicalDeviceExternalImageFormatInfo")]
public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
[Obsolete("Use VkExternalImageFormatProperties")]
public unsafe struct VkExternalImageFormatPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceExternalBufferInfo")]
public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferCreateFlags Flags;
	public VkBufferUsageFlags Usage;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
[Obsolete("Use VkExternalBufferProperties")]
public unsafe struct VkExternalBufferPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryProperties ExternalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceIDProperties")]
public unsafe struct VkPhysicalDeviceIDPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	public fixed byte DriverUUID[(int)VK.UuidSize];
	public fixed byte DeviceLUID[(int)VK.LuidSize];
	public uint DeviceNodeMask;
	public VkBool32 DeviceLUIDValid;
}
[Obsolete("Use VkExternalMemoryImageCreateInfo")]
public unsafe struct VkExternalMemoryImageCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
[Obsolete("Use VkExternalMemoryBufferCreateInfo")]
public unsafe struct VkExternalMemoryBufferCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
[Obsolete("Use VkExportMemoryAllocateInfo")]
public unsafe struct VkExportMemoryAllocateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleTypes;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
	public IntPtr Handle;
	public IntPtr Name;
}
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public SecurityAttributes* Attributes;
	public uint DwAccess;
	public IntPtr Name;
}
public unsafe struct VkMemoryGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkMemoryFdPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkImportMemoryFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
	public int FileDescriptor;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AcquireCount;
	public VkDeviceMemory* AcquireSyncs;
	public ulong* AcquireKeys;
	public uint* AcquireTimeouts;
	public uint ReleaseCount;
	public VkDeviceMemory* ReleaseSyncs;
	public ulong* ReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceExternalSemaphoreInfo")]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
[Obsolete("Use VkExternalSemaphoreProperties")]
public unsafe struct VkExternalSemaphorePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
}
[Obsolete("Use VkExportSemaphoreCreateInfo")]
public unsafe struct VkExportSemaphoreCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlags HandleTypes;
}
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkSemaphoreImportFlags Flags;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
	public IntPtr Handle;
	public IntPtr Name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public SecurityAttributes* Attributes;
	public uint DwAccess;
	public IntPtr Name;
}
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreValuesCount;
	public ulong* WaitSemaphoreValues;
	public uint SignalSemaphoreValuesCount;
	public ulong* SignalSemaphoreValues;
}
public unsafe struct VkImportSemaphoreFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkSemaphoreImportFlags Flags;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
	public int FileDescriptor;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPushDescriptors;
}
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkConditionalRenderingFlagsEXT Flags;
}
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ConditionalRendering;
	public VkBool32 InheritedConditionalRendering;
}
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ConditionalRenderingEnable;
}
public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderFloat16;
	public VkBool32 ShaderInt8;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8FeaturesKHR")]
public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderFloat16;
	public VkBool32 ShaderInt8;
}
[Obsolete("Use VkPhysicalDevice16BitStorageFeatures")]
public unsafe struct VkPhysicalDevice16BitStorageFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 StorageBuffer16BitAccess;
	public VkBool32 UniformAndStorageBuffer16BitAccess;
	public VkBool32 StoragePushConstant16;
	public VkBool32 StorageInputOutput16;
}
public unsafe struct VkPresentRegionsKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public VkPresentRegionKHR* Regions;
}
public unsafe struct VkPresentRegionKHR
{
	public uint RectangleCount;
	public VkRectLayerKHR* Rectangles;
}
public unsafe struct VkRectLayerKHR
{
	public VkOffset2D Offset;
	public VkExtent2D Extent;
	public uint Layer;
}
[Obsolete("Use VkDescriptorUpdateTemplateEntry")]
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint DestinationBinding;
	public uint DestinationArrayElement;
	public uint DescriptorCount;
	public VkDescriptorType DescriptorType;
	public nuint Offset;
	public nuint Stride;
}
[Obsolete("Use VkDescriptorUpdateTemplateCreateInfo")]
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorUpdateTemplateCreateFlags Flags;
	public uint DescriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType TemplateType;
	public VkDescriptorSetLayout DescriptorSetLayout;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipelineLayout PipelineLayout;
	public uint Set;
}
public unsafe struct VkCmdProcessCommandsInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkObjectTableNVX ObjectTable;
	public VkIndirectCommandsLayoutNVX IndirectCommandsLayout;
	public uint IndirectCommandsTokenCount;
	public VkIndirectCommandsTokenNVX* IndirectCommandsTokens;
	public uint MaxSequencesCount;
	public VkCommandBuffer TargetCommandBuffer;
	public VkBuffer SequencesCountBuffer;
	public VkDeviceSize SequencesCountOffset;
	public VkBuffer SequencesIndexBuffer;
	public VkDeviceSize SequencesIndexOffset;
}
public unsafe struct VkIndirectCommandsTokenNVX
{
	public VkIndirectCommandsTokenTypeNVX TokenType;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
}
public unsafe struct VkCmdReserveSpaceForCommandsInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkObjectTableNVX ObjectTable;
	public VkIndirectCommandsLayoutNVX IndirectCommandsLayout;
	public uint MaxSequencesCount;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkIndirectCommandsLayoutUsageFlagsNVX Flags;
	public uint TokenCount;
	public VkIndirectCommandsLayoutTokenNVX* Tokens;
}
public unsafe struct VkIndirectCommandsLayoutTokenNVX
{
	public VkIndirectCommandsTokenTypeNVX TokenType;
	public uint BindingUnit;
	public uint DynamicCount;
	public uint Divisor;
}
public unsafe struct VkObjectTableCreateInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public uint ObjectCount;
	public VkObjectEntryTypeNVX* ObjectEntryTypes;
	public uint* ObjectEntryCounts;
	public VkObjectEntryUsageFlagsNVX* ObjectEntryUsageFlags;
	public uint MaxUniformBuffersPerDescriptor;
	public uint MaxStorageBuffersPerDescriptor;
	public uint MaxStorageImagesPerDescriptor;
	public uint MaxSampledImagesPerDescriptor;
	public uint MaxPipelineLayouts;
}
public unsafe struct VkObjectTableEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
}
public unsafe struct VkDeviceGeneratedCommandsFeaturesNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ComputeBindingPointSupport;
}
public unsafe struct VkDeviceGeneratedCommandsLimitsNVX
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxIndirectCommandsLayoutTokenCount;
	public uint MaxObjectEntryCounts;
	public uint MinSequenceCountBufferOffsetAlignment;
	public uint MinSequenceIndexBufferOffsetAlignment;
	public uint MinCommandsTokenBufferOffsetAlignment;
}
public unsafe struct VkObjectTablePipelineEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
	public VkPipeline Pipeline;
}
public unsafe struct VkObjectTableDescriptorSetEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
	public VkPipelineLayout PipelineLayout;
	public VkDescriptorSet DescriptorSet;
}
public unsafe struct VkObjectTableVertexBufferEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
	public VkBuffer Buffer;
}
public unsafe struct VkObjectTableIndexBufferEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
	public VkBuffer Buffer;
	public VkIndexType IndexType;
}
public unsafe struct VkObjectTablePushConstantEntryNVX
{
	public VkObjectEntryTypeNVX Type;
	public VkObjectEntryUsageFlagsNVX Flags;
	public VkPipelineLayout PipelineLayout;
	public VkShaderStageFlags StageFlags;
}
public unsafe struct VkViewportWScalingNV
{
	public float Xcoeff;
	public float Ycoeff;
}
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ViewportWScalingEnable;
	public uint ViewportCount;
	public VkViewportWScalingNV* ViewportWScalings;
}
public unsafe struct VkSurfaceCapabilities2EXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MinImageCount;
	public uint MaxImageCount;
	public VkExtent2D CurrentExtent;
	public VkExtent2D MinImageExtent;
	public VkExtent2D MaxImageExtent;
	public uint MaxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR SupportedTransforms;
	public VkSurfaceTransformFlagsKHR CurrentTransform;
	public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;
	public VkImageUsageFlags SupportedUsageFlags;
	public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters;
}
public unsafe struct VkDisplayPowerInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayPowerStateEXT PowerState;
}
public unsafe struct VkDeviceEventInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceEventTypeEXT DeviceEvent;
}
public unsafe struct VkDisplayEventInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayEventTypeEXT DisplayEvent;
}
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceCounterFlagsEXT SurfaceCounters;
}
public unsafe struct VkRefreshCycleDurationGOOGLE
{
	public ulong RefreshDuration;
}
public unsafe struct VkPastPresentationTimingGOOGLE
{
	public uint PresentID;
	public ulong DesiredPresentTime;
	public ulong ActualPresentTime;
	public ulong EarliestPresentTime;
	public ulong PresentMargin;
}
public unsafe struct VkPresentTimesInfoGOOGLE
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public VkPresentTimeGOOGLE* Times;
}
public unsafe struct VkPresentTimeGOOGLE
{
	public uint PresentID;
	public ulong DesiredPresentTime;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PerViewPositionAllComponents;
}
public unsafe struct VkViewportSwizzleNV
{
	public VkViewportCoordinateSwizzleNV X;
	public VkViewportCoordinateSwizzleNV Y;
	public VkViewportCoordinateSwizzleNV Z;
	public VkViewportCoordinateSwizzleNV W;
}
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineViewportSwizzleStateCreateFlagsNV Flags;
	public uint ViewportCount;
	public VkViewportSwizzleNV* ViewportSwizzles;
}
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxDiscardRectangles;
}
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineDiscardRectangleStateCreateFlagsEXT Flags;
	public VkDiscardRectangleModeEXT DiscardRectangleMode;
	public uint DiscardRectangleCount;
	public VkRect2D* DiscardRectangles;
}
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public float PrimitiveOverestimationSize;
	public float MaxExtraPrimitiveOverestimationSize;
	public float ExtraPrimitiveOverestimationSizeGranularity;
	public VkBool32 PrimitiveUnderestimation;
	public VkBool32 ConservativePointAndLineRasterization;
	public VkBool32 DegenerateTrianglesRasterized;
	public VkBool32 DegenerateLinesRasterized;
	public VkBool32 FullyCoveredFragmentShaderInputVariable;
	public VkBool32 ConservativeRasterizationPostDepthCoverage;
}
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRasterizationConservativeStateCreateFlagsEXT Flags;
	public VkConservativeRasterizationModeEXT ConservativeRasterizationMode;
	public float ExtraPrimitiveOverestimationSize;
}
public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DepthClipEnable;
}
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRasterizationDepthClipStateCreateFlagsEXT Flags;
	public VkBool32 DepthClipEnable;
}
public unsafe struct VkHdrMetadataEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkXYColorEXT DisplayPrimaryRed;
	public VkXYColorEXT DisplayPrimaryGreen;
	public VkXYColorEXT DisplayPrimaryBlue;
	public VkXYColorEXT WhitePoint;
	public float MaxLuminance;
	public float MinLuminance;
	public float MaxContentLightLevel;
	public float MaxFrameAverageLightLevel;
}
public unsafe struct VkXYColorEXT
{
	public float X;
	public float Y;
}
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImagelessFramebuffer;
}
public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfoKHR* AttachmentImageInfos;
}
public unsafe struct VkFramebufferAttachmentImageInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageCreateFlags Flags;
	public VkImageUsageFlags Usage;
	public uint Width;
	public uint Height;
	public uint LayerCount;
	public uint ViewFormatCount;
	public VkFormat* ViewFormats;
}
public unsafe struct VkRenderPassAttachmentBeginInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentCount;
	public VkImageView* Attachments;
}
public unsafe struct VkRenderPassCreateInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPassCreateFlags Flags;
	public uint AttachmentCount;
	public VkAttachmentDescription2KHR* Attachments;
	public uint SubpassCount;
	public VkSubpassDescription2KHR* Subpasses;
	public uint DependencyCount;
	public VkSubpassDependency2KHR* Dependencies;
	public uint CorrelatedViewMaskCount;
	public uint* CorrelatedViewMasks;
}
public unsafe struct VkAttachmentDescription2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAttachmentDescriptionFlags Flags;
	public VkFormat Format;
	public VkSampleCountFlags Samples;
	public VkAttachmentLoadOp LoadOp;
	public VkAttachmentStoreOp StoreOp;
	public VkAttachmentLoadOp StencilLoadOp;
	public VkAttachmentStoreOp StencilStoreOp;
	public VkImageLayout InitialLayout;
	public VkImageLayout FinalLayout;
}
public unsafe struct VkSubpassDescription2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSubpassDescriptionFlags Flags;
	public VkPipelineBindPoint PipelineBindPoint;
	public uint ViewMask;
	public uint InputAttachmentCount;
	public VkAttachmentReference2KHR* InputAttachments;
	public uint ColorAttachmentCount;
	public VkAttachmentReference2KHR* ColorAttachments;
	public VkAttachmentReference2KHR* ResolveAttachments;
	public VkAttachmentReference2KHR* DepthStencilAttachment;
	public uint PreserveAttachmentCount;
	public uint* PreserveAttachments;
}
public unsafe struct VkAttachmentReference2KHR
{
	public VkStructureType SType;
	public void* Next;
	public uint Attachment;
	public VkImageLayout Layout;
	public VkImageAspectFlags AspectMask;
}
public unsafe struct VkSubpassDependency2KHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SourceSubpass;
	public uint DestinationSubpass;
	public VkPipelineStageFlags SourceStageMask;
	public VkPipelineStageFlags DestinationStageMask;
	public VkAccessFlags SourceAccessMask;
	public VkAccessFlags DestinationAccessMask;
	public VkDependencyFlags DependencyFlags;
	public int ViewOffset;
}
public unsafe struct VkSubpassBeginInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSubpassContents Contents;
}
public unsafe struct VkSubpassEndInfoKHR
{
	public VkStructureType SType;
	public void* Next;
}
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags SharedPresentSupportedUsageFlags;
}
[Obsolete("Use VkPhysicalDeviceExternalFenceInfo")]
public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags HandleType;
}
[Obsolete("Use VkExternalFenceProperties")]
public unsafe struct VkExternalFencePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags CompatibleHandleTypes;
	public VkExternalFenceFeatureFlags ExternalFenceFeatures;
}
[Obsolete("Use VkExportFenceCreateInfo")]
public unsafe struct VkExportFenceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlags HandleTypes;
}
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkFenceImportFlags Flags;
	public VkExternalFenceHandleTypeFlags HandleType;
	public IntPtr Handle;
	public IntPtr Name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkExternalFenceHandleTypeFlags HandleType;
}
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public SecurityAttributes* Attributes;
	public uint DwAccess;
	public IntPtr Name;
}
public unsafe struct VkImportFenceFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkFenceImportFlags Flags;
	public VkExternalFenceHandleTypeFlags HandleType;
	public int FileDescriptor;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkExternalFenceHandleTypeFlags HandleType;
}
public unsafe struct VkPerformanceCounterKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPerformanceCounterUnitKHR Unit;
	public VkPerformanceCounterScopeKHR Scope;
	public VkPerformanceCounterStorageKHR Storage;
	public fixed byte Uuid[(int)VK.UuidSize];
}
public unsafe struct VkPerformanceCounterDescriptionKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPerformanceCounterDescriptionFlagsKHR Flags;
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	public fixed byte Category[(int)VK.MaxDescriptionSize];
	public fixed byte Description[(int)VK.MaxDescriptionSize];
}
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint QueueFamilyIndex;
	public uint CounterIndexCount;
	public uint* CounterIndices;
}
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAcquireProfilingLockFlagsKHR Flags;
	public ulong Timeout;
}
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PerformanceCounterQueryPools;
	public VkBool32 PerformanceCounterMultipleQueryPools;
}
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AllowCommandBufferQueryCopies;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceCounterResultKHR
{
	[FieldOffset(0)]
	public int Int32;
	[FieldOffset(0)]
	public long Int64;
	[FieldOffset(0)]
	public uint Uint32;
	[FieldOffset(0)]
	public ulong Uint64;
	[FieldOffset(0)]
	public float Float32;
	[FieldOffset(0)]
	public double Float64;
}
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint CounterPassIndex;
}
[Obsolete("Use VkPhysicalDevicePointClippingProperties")]
public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPointClippingBehavior PointClippingBehavior;
}
[Obsolete("Use VkRenderPassInputAttachmentAspectCreateInfo")]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AspectReferenceCount;
	public VkInputAttachmentAspectReference* AspectReferences;
}
[Obsolete("Use VkInputAttachmentAspectReference")]
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint Subpass;
	public uint InputAttachmentIndex;
	public VkImageAspectFlags AspectMask;
}
[Obsolete("Use VkImageViewUsageCreateInfo")]
public unsafe struct VkImageViewUsageCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags Usage;
}
[Obsolete("Use VkPipelineTessellationDomainOriginStateCreateInfo")]
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkTessellationDomainOrigin DomainOrigin;
}
public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceKHR Surface;
}
public unsafe struct VkSurfaceCapabilities2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceCapabilitiesKHR SurfaceCapabilities;
}
public unsafe struct VkSurfaceFormat2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceFormatKHR SurfaceFormat;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointersFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
}
public unsafe struct VkDisplayProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayPropertiesKHR DisplayProperties;
}
public unsafe struct VkDisplayPlaneProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayPlanePropertiesKHR DisplayPlaneProperties;
}
public unsafe struct VkDisplayModeProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayModePropertiesKHR DisplayModeProperties;
}
public unsafe struct VkDisplayPlaneInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayModeKHR Mode;
	public uint PlaneIndex;
}
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDisplayPlaneCapabilitiesKHR Capabilities;
}
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType SType;
	public void* Next;
	public VkMacOSSurfaceCreateFlagsMVK Flags;
	public void* View;
}
[Obsolete("Use VkMemoryDedicatedRequirements")]
public unsafe struct VkMemoryDedicatedRequirementsKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrefersDedicatedAllocation;
	public VkBool32 RequiresDedicatedAllocation;
}
[Obsolete("Use VkMemoryDedicatedAllocateInfo")]
public unsafe struct VkMemoryDedicatedAllocateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkBuffer Buffer;
}
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkObjectType ObjectType;
	public ulong ObjectHandle;
	public byte* ObjectName;
}
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkObjectType ObjectType;
	public ulong ObjectHandle;
	public ulong TagName;
	public nuint TagSize;
	public void* Tag;
}
public unsafe struct VkDebugUtilsLabelEXT
{
	public VkStructureType SType;
	public void* Next;
	public byte* LabelName;
	public fixed float Color[4];
}
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugUtilsMessengerCreateFlagsEXT Flags;
	public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;
	public VkDebugUtilsMessageTypeFlagsEXT MessageType;
	public delegate*<VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, VkBool32> UserCallback;
	public void* UserData;
}
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugUtilsMessengerCallbackDataFlagsEXT Flags;
	public byte* MessageIdName;
	public int MessageIdNumber;
	public byte* Message;
	public uint QueueLabelCount;
	public VkDebugUtilsLabelEXT* QueueLabels;
	public uint CommandBufLabelCount;
	public VkDebugUtilsLabelEXT* CommandBufLabels;
	public uint ObjectCount;
	public VkDebugUtilsObjectNameInfoEXT* Objects;
}
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize AllocationSize;
	public uint MemoryTypeBits;
}
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
}
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
	public VkStructureType SType;
	public void* Next;
	public ulong AndroidHardwareBufferUsage;
}
public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public ulong ExternalFormat;
	public VkFormatFeatureFlags FormatFeatures;
	public VkComponentMapping SamplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
	public VkSamplerYcbcrRange SuggestedYcbcrRange;
	public VkChromaLocation SuggestedXChromaOffset;
	public VkChromaLocation SuggestedYChromaOffset;
}
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
	public VkStructureType SType;
	public void* Next;
	public void* Buffer;
}
public unsafe struct VkExternalFormatANDROID
{
	public VkStructureType SType;
	public void* Next;
	public ulong ExternalFormat;
}
public unsafe struct VkSamplerReductionModeCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerReductionModeEXT ReductionMode;
}
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FilterMinmaxSingleComponentFormats;
	public VkBool32 FilterMinmaxImageComponentMapping;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 InlineUniformBlock;
	public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxInlineUniformBlockSize;
	public uint MaxPerStageDescriptorInlineUniformBlocks;
	public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint MaxDescriptorSetInlineUniformBlocks;
	public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DataSize;
	public void* Data;
}
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxInlineUniformBlockBindings;
}
public unsafe struct VkSampleLocationsInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkSampleCountFlags SampleLocationsPerPixel;
	public VkExtent2D SampleLocationGridSize;
	public uint SampleLocationsCount;
	public VkSampleLocationEXT* SampleLocations;
}
public unsafe struct VkSampleLocationEXT
{
	public float X;
	public float Y;
}
public unsafe struct VkMultisamplePropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D MaxSampleLocationGridSize;
}
public unsafe struct VkAttachmentSampleLocationsEXT
{
	public uint AttachmentIndex;
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
public unsafe struct VkSubpassSampleLocationsEXT
{
	public uint SubpassIndex;
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentInitialSampleLocationsCount;
	public VkAttachmentSampleLocationsEXT* AttachmentInitialSampleLocations;
	public uint PostSubpassSampleLocationsCount;
	public VkSubpassSampleLocationsEXT* PostSubpassSampleLocations;
}
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SampleLocationsEnable;
	public VkSampleLocationsInfoEXT SampleLocationsInfo;
}
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkSampleCountFlags SampleLocationSampleCounts;
	public VkExtent2D MaxSampleLocationGridSize;
	public fixed float SampleLocationCoordinateRange[2];
	public uint SampleLocationSubPixelBits;
	public VkBool32 VariableSampleLocations;
}
[Obsolete("Use VkBufferMemoryRequirementsInfo2")]
public unsafe struct VkBufferMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
[Obsolete("Use VkImageMemoryRequirementsInfo2")]
public unsafe struct VkImageMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
[Obsolete("Use VkImageSparseMemoryRequirementsInfo2")]
public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
[Obsolete("Use VkSparseImageMemoryRequirements2")]
public unsafe struct VkSparseImageMemoryRequirements2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageMemoryRequirements MemoryRequirements;
}
public unsafe struct VkImageFormatListCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint ViewFormatCount;
	public VkFormat* ViewFormats;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AdvancedBlendCoherentOperations;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint AdvancedBlendMaxColorAttachments;
	public VkBool32 AdvancedBlendIndependentBlend;
	public VkBool32 AdvancedBlendNonPremultipliedSourceColor;
	public VkBool32 AdvancedBlendNonPremultipliedDestinationColor;
	public VkBool32 AdvancedBlendCorrelatedOverlap;
	public VkBool32 AdvancedBlendAllOperations;
}
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SourcePremultiplied;
	public VkBool32 DestinationPremultiplied;
	public VkBlendOverlapEXT BlendOverlap;
}
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCoverageToColorStateCreateFlagsNV Flags;
	public VkBool32 CoverageToColorEnable;
	public uint CoverageToColorLocation;
}
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCoverageModulationStateCreateFlagsNV Flags;
	public VkCoverageModulationModeNV CoverageModulationMode;
	public VkBool32 CoverageModulationTableEnable;
	public uint CoverageModulationTableCount;
	public float* CoverageModulationTable;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public uint ShaderSMCount;
	public uint ShaderWarpsPerSM;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSMBuiltins;
}
[Obsolete("Use VkSamplerYcbcrConversionCreateInfo")]
public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkSamplerYcbcrModelConversion YcbcrModel;
	public VkSamplerYcbcrRange YcbcrRange;
	public VkComponentMapping Components;
	public VkChromaLocation XChromaOffset;
	public VkChromaLocation YChromaOffset;
	public VkFilter ChromaFilter;
	public VkBool32 ForceExplicitReconstruction;
}
[Obsolete("Use VkSamplerYcbcrConversionInfo")]
public unsafe struct VkSamplerYcbcrConversionInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerYcbcrConversion Conversion;
}
[Obsolete("Use VkBindImagePlaneMemoryInfo")]
public unsafe struct VkBindImagePlaneMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
[Obsolete("Use VkImagePlaneMemoryRequirementsInfo")]
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
[Obsolete("Use VkPhysicalDeviceSamplerYcbcrConversionFeatures")]
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SamplerYcbcrConversion;
}
[Obsolete("Use VkSamplerYcbcrConversionImageFormatProperties")]
public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint CombinedImageSamplerDescriptorCount;
}
[Obsolete("Use VkBindBufferMemoryInfo")]
public unsafe struct VkBindBufferMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
[Obsolete("Use VkBindImageMemoryInfo")]
public unsafe struct VkBindImageMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public ulong DrmFormatModifier;
}
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DrmFormatModifierCount;
	public VkDrmFormatModifierPropertiesEXT* DrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
	public ulong DrmFormatModifier;
	public uint DrmFormatModifierPlaneCount;
	public VkFormatFeatureFlags DrmFormatModifierTilingFeatures;
}
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public ulong DrmFormatModifier;
	public VkSharingMode SharingMode;
	public uint QueueFamilyIndexCount;
	public uint* QueueFamilyIndices;
}
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DrmFormatModifierCount;
	public ulong* DrmFormatModifiers;
}
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public ulong DrmFormatModifier;
	public uint DrmFormatModifierPlaneCount;
	public VkSubresourceLayout* PlaneLayouts;
}
public unsafe struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkValidationCacheCreateFlagsEXT Flags;
	public nuint InitialDataSize;
	public void* InitialData;
}
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkValidationCacheEXT ValidationCache;
}
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint BindingCount;
	public VkDescriptorBindingFlagsEXT* BindingFlags;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 ShaderSampledImageArrayNonUniformIndexing;
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 ShaderStorageImageArrayNonUniformIndexing;
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 DescriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 DescriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 DescriptorBindingUpdateUnusedWhilePending;
	public VkBool32 DescriptorBindingPartiallyBound;
	public VkBool32 DescriptorBindingVariableDescriptorCount;
	public VkBool32 RuntimeDescriptorArray;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 RobustBufferAccessUpdateAfterBind;
	public VkBool32 QuadDivergentImplicitLod;
	public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
	public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint MaxPerStageUpdateAfterBindResources;
	public uint MaxDescriptorSetUpdateAfterBindSamplers;
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint MaxDescriptorSetUpdateAfterBindSampledImages;
	public uint MaxDescriptorSetUpdateAfterBindStorageImages;
	public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DescriptorSetCount;
	public uint* DescriptorCounts;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxVariableDescriptorCount;
}
public unsafe struct VkShadingRatePaletteNV
{
	public uint ShadingRatePaletteEntryCount;
	public VkShadingRatePaletteEntryNV* ShadingRatePaletteEntries;
}
public unsafe struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV ShadingRate;
	public uint SampleCount;
	public uint SampleLocationCount;
	public VkCoarseSampleLocationNV* SampleLocations;
}
public unsafe struct VkCoarseSampleLocationNV
{
	public uint PixelX;
	public uint PixelY;
	public uint Sample;
}
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShadingRateImageEnable;
	public uint ViewportCount;
	public VkShadingRatePaletteNV* ShadingRatePalettes;
}
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShadingRateImage;
	public VkBool32 ShadingRateCoarseSampleOrder;
}
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D ShadingRateTexelSize;
	public uint ShadingRatePaletteSize;
	public uint ShadingRateMaxCoarseSamples;
}
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkCoarseSampleOrderTypeNV SampleOrderType;
	public uint CustomSampleOrderCount;
	public VkCoarseSampleOrderCustomNV* CustomSampleOrders;
}
public unsafe struct VkAccelerationStructureCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize CompactedSize;
	public VkAccelerationStructureInfoNV Info;
}
public unsafe struct VkAccelerationStructureInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureTypeNV Type;
	public VkBuildAccelerationStructureFlagsNV Flags;
	public uint InstanceCount;
	public uint GeometryCount;
	public VkGeometryNV* Geometries;
}
public unsafe struct VkGeometryNV
{
	public VkStructureType SType;
	public void* Next;
	public VkGeometryTypeNV GeometryType;
	public VkGeometryDataNV Geometry;
	public VkGeometryFlagsNV Flags;
}
public unsafe struct VkGeometryDataNV
{
	public VkGeometryTrianglesNV Triangles;
	public VkGeometryAABBNV Aabbs;
}
public unsafe struct VkGeometryTrianglesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer VertexData;
	public VkDeviceSize VertexOffset;
	public uint VertexCount;
	public VkDeviceSize VertexStride;
	public VkFormat VertexFormat;
	public VkBuffer IndexData;
	public VkDeviceSize IndexOffset;
	public uint IndexCount;
	public VkIndexType IndexType;
	public VkBuffer TransformData;
	public VkDeviceSize TransformOffset;
}
public unsafe struct VkGeometryAABBNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer AabbData;
	public uint NumAABBs;
	public uint Stride;
	public VkDeviceSize Offset;
}
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureMemoryRequirementsTypeNV Type;
	public VkAccelerationStructureNV AccelerationStructure;
}
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureNV AccelerationStructure;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
}
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreateFlags Flags;
	public uint StageCount;
	public VkPipelineShaderStageCreateInfo* Stages;
	public uint GroupCount;
	public VkRayTracingShaderGroupCreateInfoNV* Groups;
	public uint MaxRecursionDepth;
	public VkPipelineLayout Layout;
	public VkPipeline BasePipelineHandle;
	public int BasePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkRayTracingShaderGroupTypeNV Type;
	public uint GeneralShader;
	public uint ClosestHitShader;
	public uint AnyHitShader;
	public uint IntersectionShader;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType SType;
	public void* Next;
	public uint AccelerationStructureCount;
	public VkAccelerationStructureNV* AccelerationStructures;
}
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public uint ShaderGroupHandleSize;
	public uint MaxRecursionDepth;
	public uint MaxShaderGroupStride;
	public uint ShaderGroupBaseAlignment;
	public ulong MaxGeometryCount;
	public ulong MaxInstanceCount;
	public ulong MaxTriangleCount;
	public uint MaxDescriptorSetAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RepresentativeFragmentTest;
}
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RepresentativeFragmentTestEnable;
}
[Obsolete("Use VkPhysicalDeviceMaintenance3Properties")]
public unsafe struct VkPhysicalDeviceMaintenance3PropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPerSetDescriptors;
	public VkDeviceSize MaxMemoryAllocationSize;
}
[Obsolete("Use VkDescriptorSetLayoutSupport")]
public unsafe struct VkDescriptorSetLayoutSupportKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Supported;
}
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageViewType ImageViewType;
}
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FilterCubic;
	public VkBool32 FilterCubicMinmax;
}
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueGlobalPriorityEXT GlobalPriority;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSubgroupExtendedTypes;
}
public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 StorageBuffer8BitAccess;
	public VkBool32 UniformAndStorageBuffer8BitAccess;
	public VkBool32 StoragePushConstant8;
}
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
	public void* HostPointer;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize MinImportedHostPointerAlignment;
}
public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderBufferInt64Atomics;
	public VkBool32 ShaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSubgroupClock;
	public VkBool32 ShaderDeviceClock;
}
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCompilerControlFlagsAMD CompilerControlFlags;
}
public unsafe struct VkCalibratedTimestampInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkTimeDomainEXT TimeDomain;
}
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
	public VkStructureType SType;
	public void* Next;
	public uint ShaderEngineCount;
	public uint ShaderArraysPerEngineCount;
	public uint ComputeUnitsPerShaderArray;
	public uint SimdPerComputeUnit;
	public uint WavefrontsPerSimd;
	public uint WavefrontSize;
	public uint SgprsPerSimd;
	public uint MinSgprAllocation;
	public uint MaxSgprAllocation;
	public uint SgprAllocationGranularity;
	public uint VgprsPerSimd;
	public uint MinVgprAllocation;
	public uint MaxVgprAllocation;
	public uint VgprAllocationGranularity;
}
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryOverallocationBehaviorAMD OverallocationBehavior;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxVertexAttribDivisor;
}
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
	public uint Binding;
	public uint Divisor;
}
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint VertexBindingDivisorCount;
	public VkVertexInputBindingDivisorDescriptionEXT* VertexBindingDivisors;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VertexAttributeInstanceRateDivisor;
	public VkBool32 VertexAttributeInstanceRateZeroDivisor;
}
public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreationFeedbackEXT* PipelineCreationFeedback;
	public uint PipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedbackEXT** PipelineStageCreationFeedbacks;
}
public unsafe struct VkPipelineCreationFeedbackEXT
{
	public VkPipelineCreationFeedbackFlagsEXT Flags;
	public ulong Duration;
}
public unsafe struct VkConformanceVersionKHR
{
	public byte Major;
	public byte Minor;
	public byte Subminor;
	public byte Patch;
}
public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDriverIdKHR DriverID;
	public fixed byte DriverName[(int)VK.MaxDriverNameSizeKhr];
	public fixed byte DriverInfo[(int)VK.MaxDriverInfoSizeKhr];
	public VkConformanceVersionKHR ConformanceVersion;
}
public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderFloatControlsIndependenceKHR DenormBehaviorIndependence;
	public VkShaderFloatControlsIndependenceKHR RoundingModeIndependence;
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 ShaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 ShaderDenormPreserveFloat16;
	public VkBool32 ShaderDenormPreserveFloat32;
	public VkBool32 ShaderDenormPreserveFloat64;
	public VkBool32 ShaderDenormFlushToZeroFloat16;
	public VkBool32 ShaderDenormFlushToZeroFloat32;
	public VkBool32 ShaderDenormFlushToZeroFloat64;
	public VkBool32 ShaderRoundingModeRTEFloat16;
	public VkBool32 ShaderRoundingModeRTEFloat32;
	public VkBool32 ShaderRoundingModeRTEFloat64;
	public VkBool32 ShaderRoundingModeRTZFloat16;
	public VkBool32 ShaderRoundingModeRTZFloat32;
	public VkBool32 ShaderRoundingModeRTZFloat64;
}
public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkResolveModeFlagsKHR DepthResolveMode;
	public VkResolveModeFlagsKHR StencilResolveMode;
	public VkAttachmentReference2KHR* DepthStencilResolveAttachment;
}
public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkResolveModeFlagsKHR SupportedDepthResolveModes;
	public VkResolveModeFlagsKHR SupportedStencilResolveModes;
	public VkBool32 IndependentResolveNone;
	public VkBool32 IndependentResolve;
}
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ComputeDerivativeGroupQuads;
	public VkBool32 ComputeDerivativeGroupLinear;
}
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TaskShader;
	public VkBool32 MeshShader;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxDrawMeshTasksCount;
	public uint MaxTaskWorkGroupInvocations;
	public fixed uint MaxTaskWorkGroupSize[3];
	public uint MaxTaskTotalMemorySize;
	public uint MaxTaskOutputCount;
	public uint MaxMeshWorkGroupInvocations;
	public fixed uint MaxMeshWorkGroupSize[3];
	public uint MaxMeshTotalMemorySize;
	public uint MaxMeshOutputVertices;
	public uint MaxMeshOutputPrimitives;
	public uint MaxMeshMultiviewViewCount;
	public uint MeshOutputPerVertexGranularity;
	public uint MeshOutputPerPrimitiveGranularity;
}
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
	public uint TaskCount;
	public uint FirstTask;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImageFootprint;
}
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint ExclusiveScissorCount;
	public VkRect2D* ExclusiveScissors;
}
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ExclusiveScissor;
}
public unsafe struct VkCheckpointDataNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags Stage;
	public void* CheckpointMarker;
}
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags CheckpointExecutionStageMask;
}
public unsafe struct VkSemaphoreWaitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphoreWaitFlagsKHR Flags;
	public uint SemaphoreCount;
	public VkSemaphore* Semaphores;
	public ulong* Values;
}
public unsafe struct VkSemaphoreSignalInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public ulong Value;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TimelineSemaphore;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public ulong MaxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphoreTypeKHR SemaphoreType;
	public ulong InitialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreValueCount;
	public ulong* WaitSemaphoreValues;
	public uint SignalSemaphoreValueCount;
	public ulong* SignalSemaphoreValues;
}
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderIntegerFunctions2;
}
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public void* UserData;
}
public unsafe struct VkPerformanceMarkerInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public ulong Marker;
}
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public uint Marker;
}
public unsafe struct VkPerformanceOverrideInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkPerformanceOverrideTypeINTEL Type;
	public VkBool32 Enable;
	public ulong Parameter;
}
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkPerformanceConfigurationTypeINTEL Type;
}
public unsafe struct VkPerformanceValueINTEL
{
	public VkPerformanceValueTypeINTEL Type;
	public VkPerformanceValueDataINTEL Data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
	[FieldOffset(0)]
	public uint Value32;
	[FieldOffset(0)]
	public ulong Value64;
	[FieldOffset(0)]
	public float ValueFloat;
	[FieldOffset(0)]
	public VkBool32 ValueBool;
	[FieldOffset(0)]
	public byte* ValueString;
}
public unsafe struct VkQueryPoolCreateInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
}
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VulkanMemoryModel;
	public VkBool32 VulkanMemoryModelDeviceScope;
	public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint PciDomain;
	public uint PciBus;
	public uint PciDevice;
	public uint PciFunction;
}
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 LocalDimmingSupport;
}
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 LocalDimmingEnable;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentDensityMap;
	public VkBool32 FragmentDensityMapDynamic;
	public VkBool32 FragmentDensityMapNonSubsampledImages;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D MinFragmentDensityTexelSize;
	public VkExtent2D MaxFragmentDensityTexelSize;
	public VkBool32 FragmentDensityInvocations;
}
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkAttachmentReference FragmentDensityMapAttachment;
}
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ScalarBlockLayout;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SubgroupSizeControl;
	public VkBool32 ComputeFullSubgroups;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MinSubgroupSize;
	public uint MaxSubgroupSize;
	public uint MaxComputeWorkgroupSubgroups;
	public VkShaderStageFlags RequiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint RequiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
	public uint ActiveComputeUnitCount;
}
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DeviceCoherentMemory;
}
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize HeapBudget_0;
	public VkDeviceSize HeapBudget_1;
	public VkDeviceSize HeapBudget_2;
	public VkDeviceSize HeapBudget_3;
	public VkDeviceSize HeapBudget_4;
	public VkDeviceSize HeapBudget_5;
	public VkDeviceSize HeapBudget_6;
	public VkDeviceSize HeapBudget_7;
	public VkDeviceSize HeapBudget_8;
	public VkDeviceSize HeapBudget_9;
	public VkDeviceSize HeapBudget_10;
	public VkDeviceSize HeapBudget_11;
	public VkDeviceSize HeapBudget_12;
	public VkDeviceSize HeapBudget_13;
	public VkDeviceSize HeapBudget_14;
	public VkDeviceSize HeapBudget_15;
	public VkDeviceSize HeapUsage_0;
	public VkDeviceSize HeapUsage_1;
	public VkDeviceSize HeapUsage_2;
	public VkDeviceSize HeapUsage_3;
	public VkDeviceSize HeapUsage_4;
	public VkDeviceSize HeapUsage_5;
	public VkDeviceSize HeapUsage_6;
	public VkDeviceSize HeapUsage_7;
	public VkDeviceSize HeapUsage_8;
	public VkDeviceSize HeapUsage_9;
	public VkDeviceSize HeapUsage_10;
	public VkDeviceSize HeapUsage_11;
	public VkDeviceSize HeapUsage_12;
	public VkDeviceSize HeapUsage_13;
	public VkDeviceSize HeapUsage_14;
	public VkDeviceSize HeapUsage_15;
}
public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MemoryPriority;
}
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public float Priority;
}
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SupportsProtected;
}
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DedicatedAllocationImageAliasing;
}
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SeparateDepthStencilLayouts;
}
public unsafe struct VkAttachmentReferenceStencilLayoutKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageLayout StencilLayout;
}
public unsafe struct VkAttachmentDescriptionStencilLayoutKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageLayout StencilInitialLayout;
	public VkImageLayout StencilFinalLayout;
}
[Obsolete("Use VkPhysicalDeviceBufferDeviceAddressFeaturesEXT")]
public unsafe struct VkPhysicalDeviceBufferAddressFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 BufferDeviceAddress;
	public VkBool32 BufferDeviceAddressCaptureReplay;
	public VkBool32 BufferDeviceAddressMultiDevice;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 BufferDeviceAddress;
	public VkBool32 BufferDeviceAddressCaptureReplay;
	public VkBool32 BufferDeviceAddressMultiDevice;
}
[Obsolete("Use VkBufferDeviceAddressInfoKHR")]
public unsafe struct VkBufferDeviceAddressInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkBufferDeviceAddressCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceAddress DeviceAddress;
}
public unsafe struct VkPhysicalDeviceToolPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte Name[(int)VK.MaxExtensionNameSize];
	public fixed byte Version[(int)VK.MaxExtensionNameSize];
	public VkToolPurposeFlagsEXT Purposes;
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public fixed byte Layer[(int)VK.MaxExtensionNameSize];
}
public unsafe struct VkImageStencilUsageCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags StencilUsage;
}
public unsafe struct VkValidationFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint EnabledValidationFeatureCount;
	public VkValidationFeatureEnableEXT* EnabledValidationFeatures;
	public uint DisabledValidationFeatureCount;
	public VkValidationFeatureDisableEXT* DisabledValidationFeatures;
}
public unsafe struct VkCooperativeMatrixPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public uint MSize;
	public uint NSize;
	public uint KSize;
	public VkComponentTypeNV AType;
	public VkComponentTypeNV BType;
	public VkComponentTypeNV CType;
	public VkComponentTypeNV DType;
	public VkScopeNV Scope;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 CooperativeMatrix;
	public VkBool32 CooperativeMatrixRobustBufferAccess;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderStageFlags CooperativeMatrixSupportedStages;
}
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
	public VkStructureType SType;
	public void* Next;
	public VkCoverageReductionModeNV CoverageReductionMode;
	public VkSampleCountFlags RasterizationSamples;
	public VkSampleCountFlags DepthStencilSamples;
	public VkSampleCountFlags ColorSamples;
}
public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 CoverageReductionMode;
}
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCoverageReductionStateCreateFlagsNV Flags;
	public VkCoverageReductionModeNV CoverageReductionMode;
}
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentShaderSampleInterlock;
	public VkBool32 FragmentShaderPixelInterlock;
	public VkBool32 FragmentShaderShadingRateInterlock;
}
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 YcbcrImageArrays;
}
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 UniformBufferStandardLayout;
}
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkFullScreenExclusiveEXT FullScreenExclusive;
}
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FullScreenExclusiveSupported;
}
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public IntPtr Hmonitor;
}
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkHeadlessSurfaceCreateFlagsEXT Flags;
}
public unsafe struct VkBufferDeviceAddressInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 BufferDeviceAddress;
	public VkBool32 BufferDeviceAddressCaptureReplay;
	public VkBool32 BufferDeviceAddressMultiDevice;
}
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public ulong OpaqueCaptureAddress;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public ulong OpaqueCaptureAddress;
}
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RectangularLines;
	public VkBool32 BresenhamLines;
	public VkBool32 SmoothLines;
	public VkBool32 StippledRectangularLines;
	public VkBool32 StippledBresenhamLines;
	public VkBool32 StippledSmoothLines;
}
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint LineSubPixelPrecisionBits;
}
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkLineRasterizationModeEXT LineRasterizationMode;
	public VkBool32 StippledLineEnable;
	public uint LineStippleFactor;
	public ushort LineStipplePattern;
}
public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 HostQueryReset;
}
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 IndexTypeUint8;
}
public unsafe struct VkPipelineInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPipeline Pipeline;
}
public unsafe struct VkPipelineExecutablePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderStageFlags Stages;
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public uint SubgroupSize;
}
public unsafe struct VkPipelineExecutableInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPipeline Pipeline;
	public uint ExecutableIndex;
}
public unsafe struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public VkPipelineExecutableStatisticFormatKHR Format;
	public VkPipelineExecutableStatisticValueKHR Value;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
	[FieldOffset(0)]
	public VkBool32 B32;
	[FieldOffset(0)]
	public long I64;
	[FieldOffset(0)]
	public ulong U64;
	[FieldOffset(0)]
	public double F64;
}
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public VkBool32 IsText;
	public nuint DataSize;
	public void* Data;
}
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelineExecutableInfo;
}
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderDemoteToHelperInvocation;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TexelBufferAlignment;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
	public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
}
