// This file was generated, don't manually edit
namespace Vulkan_1_0;

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
	public static VkExtent3D Zero => new();
	public VkExtent3D(uint width, uint height, uint depth)
	{
		Width = width;
		Height = height;
		Depth = depth;
	}
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
	public VkImageSubresource(VkImageAspectFlags aspectMask, uint mipLevel, uint arrayLayer)
	{
		AspectMask = aspectMask;
		MipLevel = mipLevel;
		ArrayLayer = arrayLayer;
	}
}
public unsafe struct VkOffset3D
{
	public int X;
	public int Y;
	public int Z;
	public static VkOffset3D Zero => new();
	public VkOffset3D(int x, int y, int z)
	{
		X = x;
		Y = y;
		Z = z;
	}
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
	public static VkComponentMapping Identity => new(VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity);
	public VkComponentMapping(VkComponentSwizzle r, VkComponentSwizzle g, VkComponentSwizzle b, VkComponentSwizzle a)
	{
		R = r;
		G = g;
		B = b;
		A = a;
	}
}
public unsafe struct VkImageSubresourceRange
{
	public VkImageAspectFlags AspectMask;
	public uint BaseMipLevel;
	public uint LevelCount;
	public uint BaseArrayLayer;
	public uint LayerCount;
	public VkImageSubresourceRange(VkImageAspectFlags aspectMask, uint baseMipLevel, uint levelCount, uint baseArrayLayer, uint layerCount)
	{
		AspectMask = aspectMask;
		BaseMipLevel = baseMipLevel;
		LevelCount = levelCount;
		BaseArrayLayer = baseArrayLayer;
		LayerCount = layerCount;
	}
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
	public VkRect2D(VkOffset2D offset, VkExtent2D extent)
	{
		Offset = offset;
		Extent = extent;
	}
}
public unsafe struct VkOffset2D
{
	public int X;
	public int Y;
	public static VkOffset2D Zero => new();
	public VkOffset2D(int x, int y)
	{
		X = x;
		Y = y;
	}
}
public unsafe struct VkExtent2D
{
	public uint Width;
	public uint Height;
	public static VkExtent2D Zero => new();
	public VkExtent2D(uint width, uint height)
	{
		Width = width;
		Height = height;
	}
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
	public VkImageSubresourceLayers(VkImageAspectFlags aspectMask, uint mipLevel, uint baseArrayLayer, uint layerCount)
	{
		AspectMask = aspectMask;
		MipLevel = mipLevel;
		BaseArrayLayer = baseArrayLayer;
		LayerCount = layerCount;
	}
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
	public VkClearColorValue(float r, float g, float b, float a)
	{
		Float32[0] = r;
		Float32[1] = g;
		Float32[2] = b;
		Float32[3] = a;
	}
	public VkClearColorValue(int r, int g, int b, int a)
	{
		Int32[0] = r;
		Int32[1] = g;
		Int32[2] = b;
		Int32[3] = a;
	}
	public VkClearColorValue(uint r, uint g, uint b, uint a)
	{
		Uint32[0] = r;
		Uint32[1] = g;
		Uint32[2] = b;
		Uint32[3] = a;
	}
}
public unsafe struct VkClearDepthStencilValue
{
	public float Depth;
	public uint Stencil;
	public VkClearDepthStencilValue(float depth, uint stencil)
	{
		Depth = depth;
		Stencil = stencil;
	}
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
	public static implicit operator VkClearValue(VkClearColorValue colour) => new() { Color = colour };
	public static implicit operator VkClearValue(VkClearDepthStencilValue depthStencil) => new() { DepthStencil = depthStencil };
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
public unsafe struct VkRenderPassMultiviewCreateInfoKHX
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
public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Multiview;
	public VkBool32 MultiviewGeometryShader;
	public VkBool32 MultiviewTessellationShader;
}
public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHX
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
public unsafe struct VkPhysicalDeviceFeatures2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceFeatures Features;
}
public unsafe struct VkPhysicalDeviceProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceProperties Properties;
}
public unsafe struct VkFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormatProperties FormatProperties;
}
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
public unsafe struct VkImageFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageFormatProperties ImageFormatProperties;
}
public unsafe struct VkQueueFamilyProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueFamilyProperties QueueFamilyProperties;
}
public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPhysicalDeviceMemoryProperties MemoryProperties;
}
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
public unsafe struct VkSparseImageFormatProperties2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageFormatProperties Properties;
}
public unsafe struct VkMemoryAllocateFlagsInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryAllocateFlagsKHX Flags;
	public uint DeviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
	public uint DeviceRenderAreaCount;
	public VkRect2D* DeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfoKHX
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
public unsafe struct VkDeviceGroupBindSparseInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint ResourceDeviceIndex;
	public uint MemoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
	public uint SFRRectCount;
	public VkRect2D* SFRRects;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHX
{
	public VkStructureType SType;
	public void* Next;
	public fixed uint PresentMask[(int)VK.MaxDeviceGroupSizeKhx];
	public VkDeviceGroupPresentModeFlagsKHX Modes;
}
public unsafe struct VkAcquireNextImageInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
	public ulong Timeout;
	public VkSemaphore Semaphore;
	public VkFence Fence;
	public uint DeviceMask;
}
public unsafe struct VkImageSwapchainCreateInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
}
public unsafe struct VkBindImageMemorySwapchainInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainKHR Swapchain;
	public uint ImageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public uint* DeviceMasks;
	public VkDeviceGroupPresentModeFlagsKHX Mode;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceGroupPresentModeFlagsKHX Modes;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DisabledValidationCheckCount;
	public VkValidationCheckEXT* DisabledValidationChecks;
}
public unsafe struct VkViSurfaceCreateInfoNN
{
	public VkStructureType SType;
	public void* Next;
	public VkViSurfaceCreateFlagsNN Flags;
	public void* Window;
}
public unsafe struct VkPhysicalDeviceGroupPropertiesKHX
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
public unsafe struct VkDeviceGroupDeviceCreateInfoKHX
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice* PhysicalDevices;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferCreateFlags Flags;
	public VkBufferUsageFlags Usage;
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkExternalBufferPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryPropertiesKHR ExternalMemoryProperties;
}
public unsafe struct VkExternalMemoryPropertiesKHR
{
	public VkExternalMemoryFeatureFlagsKHR ExternalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsKHR ExportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsKHR CompatibleHandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkExternalImageFormatPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryPropertiesKHR ExternalMemoryProperties;
}
public unsafe struct VkPhysicalDeviceIDPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	public fixed byte DriverUUID[(int)VK.UuidSize];
	public fixed byte DeviceLUID[(int)VK.LuidSizeKhr];
	public uint DeviceNodeMask;
	public VkBool32 DeviceLUIDValid;
}
public unsafe struct VkExternalMemoryImageCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsKHR HandleTypes;
}
public unsafe struct VkExternalMemoryBufferCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsKHR HandleTypes;
}
public unsafe struct VkExportMemoryAllocateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlagsKHR HandleTypes;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
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
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
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
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
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
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
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
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkExternalSemaphorePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlagsKHR ExportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlagsKHR CompatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlagsKHR ExternalSemaphoreFeatures;
}
public unsafe struct VkExportSemaphoreCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleTypes;
}
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkSemaphoreImportFlagsKHR Flags;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleType;
	public IntPtr Handle;
	public IntPtr Name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleType;
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
	public VkSemaphoreImportFlagsKHR Flags;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleType;
	public int FileDescriptor;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkExternalSemaphoreHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPushDescriptors;
}
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
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorUpdateTemplateCreateFlagsKHR Flags;
	public uint DescriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntryKHR* DescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateTypeKHR TemplateType;
	public VkDescriptorSetLayout DescriptorSetLayout;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipelineLayout PipelineLayout;
	public uint Set;
}
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint DestinationBinding;
	public uint DestinationArrayElement;
	public uint DescriptorCount;
	public VkDescriptorType DescriptorType;
	public nuint Offset;
	public nuint Stride;
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
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags SharedPresentSupportedUsageFlags;
}
public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkExternalFencePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlagsKHR ExportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlagsKHR CompatibleHandleTypes;
	public VkExternalFenceFeatureFlagsKHR ExternalFenceFeatures;
}
public unsafe struct VkExportFenceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalFenceHandleTypeFlagsKHR HandleTypes;
}
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkFenceImportFlagsKHR Flags;
	public VkExternalFenceHandleTypeFlagsKHR HandleType;
	public IntPtr Handle;
	public IntPtr Name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkExternalFenceHandleTypeFlagsKHR HandleType;
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
	public VkFenceImportFlagsKHR Flags;
	public VkExternalFenceHandleTypeFlagsKHR HandleType;
	public int FileDescriptor;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkExternalFenceHandleTypeFlagsKHR HandleType;
}
public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPointClippingBehaviorKHR PointClippingBehavior;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AspectReferenceCount;
	public VkInputAttachmentAspectReferenceKHR* AspectReferences;
}
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint Subpass;
	public uint InputAttachmentIndex;
	public VkImageAspectFlags AspectMask;
}
public unsafe struct VkImageViewUsageCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags Usage;
}
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkTessellationDomainOriginKHR DomainOrigin;
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
public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
}
public unsafe struct VkIOSSurfaceCreateInfoMVK
{
	public VkStructureType SType;
	public void* Next;
	public VkIOSSurfaceCreateFlagsMVK Flags;
	public void* View;
}
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType SType;
	public void* Next;
	public VkMacOSSurfaceCreateFlagsMVK Flags;
	public void* View;
}
public unsafe struct VkMemoryDedicatedRequirementsKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrefersDedicatedAllocation;
	public VkBool32 RequiresDedicatedAllocation;
}
public unsafe struct VkMemoryDedicatedAllocateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkBuffer Buffer;
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
public unsafe struct VkImageMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryRequirements MemoryRequirements;
}
public unsafe struct VkBufferMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
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
public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public VkSamplerYcbcrModelConversionKHR YcbcrModel;
	public VkSamplerYcbcrRangeKHR YcbcrRange;
	public VkComponentMapping Components;
	public VkChromaLocationKHR XChromaOffset;
	public VkChromaLocationKHR YChromaOffset;
	public VkFilter ChromaFilter;
	public VkBool32 ForceExplicitReconstruction;
}
public unsafe struct VkSamplerYcbcrConversionInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerYcbcrConversionKHR Conversion;
}
public unsafe struct VkBindImagePlaneMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageAspectFlags PlaneAspect;
}
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SamplerYcbcrConversion;
}
public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint CombinedImageSamplerDescriptorCount;
}
public unsafe struct VkBindBufferMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
public unsafe struct VkBindImageMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
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
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueGlobalPriorityEXT GlobalPriority;
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
	public VkExternalMemoryHandleTypeFlagsKHR HandleType;
	public void* HostPointer;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize MinImportedHostPointerAlignment;
}
