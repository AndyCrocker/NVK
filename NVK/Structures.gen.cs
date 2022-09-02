// this file was generated, don't edit manually

using System;
using System.Runtime.InteropServices;

namespace Vulkan;
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
public unsafe struct VkClearRect
{
	public VkRect2D Rect;
	public uint BaseArrayLayer;
	public uint LayerCount;
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
	public IntPtr Allocation;
	public IntPtr Reallocation;
	public IntPtr Free;
	public IntPtr InternalAllocation;
	public IntPtr InternalFree;
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
public unsafe struct VkDeviceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint QueueCreateInfoCount;
	public VkDeviceQueueCreateInfo* QueueCreateInfos;
	public uint EnabledLayerCount;
	public byte** EnabledLayerNames;
	public uint EnabledExtensionCount;
	public byte** EnabledExtensionNames;
	public VkPhysicalDeviceFeatures* EnabledFeatures;
}
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
public unsafe struct VkMemoryAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize AllocationSize;
	public uint MemoryTypeIndex;
}
public unsafe struct VkMemoryRequirements
{
	public VkDeviceSize Size;
	public VkDeviceSize Alignment;
	public uint MemoryTypeBits;
}
public unsafe struct VkSparseImageFormatProperties
{
	public VkImageAspectFlags AspectMask;
	public VkExtent3D ImageGranularity;
	public VkSparseImageFormatFlags Flags;
}
public unsafe struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties FormatProperties;
	public uint ImageMipTailFirstLod;
	public VkDeviceSize ImageMipTailSize;
	public VkDeviceSize ImageMipTailOffset;
	public VkDeviceSize ImageMipTailStride;
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
public unsafe struct VkMappedMemoryRange
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
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
public unsafe struct VkDescriptorBufferInfo
{
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkDeviceSize Range;
}
public unsafe struct VkDescriptorImageInfo
{
	public VkSampler Sampler;
	public VkImageView ImageView;
	public VkImageLayout ImageLayout;
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
	public uint Flags;
	public VkBuffer Buffer;
	public VkFormat Format;
	public VkDeviceSize Offset;
	public VkDeviceSize Range;
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
public unsafe struct VkBufferCopy
{
	public VkDeviceSize SourceOffset;
	public VkDeviceSize DestinationOffset;
	public VkDeviceSize Size;
}
public unsafe struct VkSparseMemoryBind
{
	public VkDeviceSize ResourceOffset;
	public VkDeviceSize Size;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
	public VkSparseMemoryBindFlags Flags;
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
public unsafe struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer Buffer;
	public uint BindCount;
	public VkSparseMemoryBind* Binds;
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
public unsafe struct VkImageCopy
{
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
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
public unsafe struct VkImageResolve
{
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
}
public unsafe struct VkShaderModuleCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public nuint CodeSize;
	public uint* Code;
}
public unsafe struct VkDescriptorSetLayoutBinding
{
	public uint Binding;
	public VkDescriptorType DescriptorType;
	public uint DescriptorCount;
	public VkShaderStageFlags StageFlags;
	public VkSampler* ImmutableSamplers;
}
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorSetLayoutCreateFlags Flags;
	public uint BindingCount;
	public VkDescriptorSetLayoutBinding* Bindings;
}
public unsafe struct VkDescriptorPoolSize
{
	public VkDescriptorType Type;
	public uint DescriptorCount;
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
public unsafe struct VkDescriptorSetAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorPool DescriptorPool;
	public uint DescriptorSetCount;
	public VkDescriptorSetLayout* SetLayouts;
}
public unsafe struct VkSpecializationMapEntry
{
	public uint ConstantID;
	public uint Offset;
	public nuint Size;
}
public unsafe struct VkSpecializationInfo
{
	public uint MapEntryCount;
	public VkSpecializationMapEntry* MapEntries;
	public nuint DataSize;
	public void* Data;
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
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint VertexBindingDescriptionCount;
	public VkVertexInputBindingDescription* VertexBindingDescriptions;
	public uint VertexAttributeDescriptionCount;
	public VkVertexInputAttributeDescription* VertexAttributeDescriptions;
}
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkPrimitiveTopology Topology;
	public VkBool32 PrimitiveRestartEnable;
}
public unsafe struct VkPipelineTessellationStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint PatchControlPoints;
}
public unsafe struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint ViewportCount;
	public VkViewport* Viewports;
	public uint ScissorCount;
	public VkRect2D* Scissors;
}
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
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
	public uint Flags;
	public VkSampleCountFlags RasterizationSamples;
	public VkBool32 SampleShadingEnable;
	public float MinSampleShading;
	public uint* SampleMask;
	public VkBool32 AlphaToCoverageEnable;
	public VkBool32 AlphaToOneEnable;
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
public unsafe struct VkPipelineDynamicStateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint DynamicStateCount;
	public VkDynamicState* DynamicStates;
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
public unsafe struct VkPipelineCacheCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCacheCreateFlags Flags;
	public nuint InitialDataSize;
	public void* InitialData;
}
public unsafe struct VkPipelineCacheHeaderVersionOne
{
	public uint HeaderSize;
	public VkPipelineCacheHeaderVersion HeaderVersion;
	public uint VendorID;
	public uint DeviceID;
	public fixed byte PipelineCacheUUID[(int)VK.UuidSize];
}
public unsafe struct VkPushConstantRange
{
	public VkShaderStageFlags StageFlags;
	public uint Offset;
	public uint Size;
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
public unsafe struct VkCommandBufferBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkCommandBufferUsageFlags Flags;
	public VkCommandBufferInheritanceInfo* InheritanceInfo;
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
public unsafe struct VkClearAttachment
{
	public VkImageAspectFlags AspectMask;
	public uint ColorAttachment;
	public VkClearValue ClearValue;
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
public unsafe struct VkAttachmentReference
{
	public uint Attachment;
	public VkImageLayout Layout;
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
public unsafe struct VkEventCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkEventCreateFlags Flags;
}
public unsafe struct VkFenceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkFenceCreateFlags Flags;
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
	public VkBool32 TextureCompressionASTC_LDR;
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
public unsafe struct VkPhysicalDeviceSparseProperties
{
	public VkBool32 ResidencyStandard2DBlockShape;
	public VkBool32 ResidencyStandard2DMultisampleBlockShape;
	public VkBool32 ResidencyStandard3DBlockShape;
	public VkBool32 ResidencyAlignedMipSize;
	public VkBool32 ResidencyNonResidentStrict;
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
public unsafe struct VkSemaphoreCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
}
public unsafe struct VkQueryPoolCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkQueryType QueryType;
	public uint QueryCount;
	public VkQueryPipelineStatisticFlags PipelineStatistics;
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
public unsafe struct VkDrawIndirectCommand
{
	public uint VertexCount;
	public uint InstanceCount;
	public uint FirstVertex;
	public uint FirstInstance;
}
public unsafe struct VkDrawIndexedIndirectCommand
{
	public uint IndexCount;
	public uint InstanceCount;
	public uint FirstIndex;
	public int VertexOffset;
	public uint FirstInstance;
}
public unsafe struct VkDispatchIndirectCommand
{
	public uint X;
	public uint Y;
	public uint Z;
}
public unsafe struct VkMultiDrawInfoEXT
{
	public uint FirstVertex;
	public uint VertexCount;
}
public unsafe struct VkMultiDrawIndexedInfoEXT
{
	public uint FirstIndex;
	public uint IndexCount;
	public int VertexOffset;
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
public unsafe struct VkDisplayModeParametersKHR
{
	public VkExtent2D VisibleRegion;
	public uint RefreshRate;
}
public unsafe struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR DisplayMode;
	public VkDisplayModeParametersKHR Parameters;
}
public unsafe struct VkDisplayModeCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
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
	public uint Flags;
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
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public IntPtr* Window;
}
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public IntPtr Hinstance;
	public IntPtr Hwnd;
}
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public IntPtr* Dpy;
	public IntPtr Window;
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
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugReportFlagsEXT Flags;
	public IntPtr Callback;
	public void* UserData;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DisabledValidationCheckCount;
	public VkValidationCheckEXT* DisabledValidationChecks;
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
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkRasterizationOrderAMD RasterizationOrder;
}
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDebugReportObjectTypeEXT ObjectType;
	public ulong Object;
	public byte* ObjectName;
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
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DeviceGeneratedCommands;
}
public unsafe struct VkDevicePrivateDataCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint PrivateDataSlotRequestCount;
}
public unsafe struct VkPrivateDataSlotCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
}
public unsafe struct VkPhysicalDevicePrivateDataFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrivateData;
}
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxGraphicsShaderGroupCount;
	public uint MaxIndirectSequenceCount;
	public uint MaxIndirectCommandsTokenCount;
	public uint MaxIndirectCommandsStreamCount;
	public uint MaxIndirectCommandsTokenOffset;
	public uint MaxIndirectCommandsStreamStride;
	public uint MinSequencesCountBufferOffsetAlignment;
	public uint MinSequencesIndexBufferOffsetAlignment;
	public uint MinIndirectCommandsBufferOffsetAlignment;
}
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxMultiDrawCount;
}
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint StageCount;
	public VkPipelineShaderStageCreateInfo* Stages;
	public VkPipelineVertexInputStateCreateInfo* VertexInputState;
	public VkPipelineTessellationStateCreateInfo* TessellationState;
}
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint GroupCount;
	public VkGraphicsShaderGroupCreateInfoNV* Groups;
	public uint PipelineCount;
	public VkPipeline* Pipelines;
}
public unsafe struct VkBindShaderGroupIndirectCommandNV
{
	public uint GroupIndex;
}
public unsafe struct VkBindIndexBufferIndirectCommandNV
{
	public VkDeviceAddress BufferAddress;
	public uint Size;
	public VkIndexType IndexType;
}
public unsafe struct VkBindVertexBufferIndirectCommandNV
{
	public VkDeviceAddress BufferAddress;
	public uint Size;
	public uint Stride;
}
public unsafe struct VkSetStateFlagsIndirectCommandNV
{
	public uint Data;
}
public unsafe struct VkIndirectCommandsStreamNV
{
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
}
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
	public VkStructureType SType;
	public void* Next;
	public VkIndirectCommandsTokenTypeNV TokenType;
	public uint Stream;
	public uint Offset;
	public uint VertexBindingUnit;
	public VkBool32 VertexDynamicStride;
	public VkPipelineLayout PushconstantPipelineLayout;
	public VkShaderStageFlags PushconstantShaderStageFlags;
	public uint PushconstantOffset;
	public uint PushconstantSize;
	public VkIndirectStateFlagsNV IndirectStateFlags;
	public uint IndexTypeCount;
	public VkIndexType* IndexTypes;
	public uint* IndexTypeValues;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkIndirectCommandsLayoutUsageFlagsNV Flags;
	public VkPipelineBindPoint PipelineBindPoint;
	public uint TokenCount;
	public VkIndirectCommandsLayoutTokenNV* Tokens;
	public uint StreamCount;
	public uint* StreamStrides;
}
public unsafe struct VkGeneratedCommandsInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipeline Pipeline;
	public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
	public uint StreamCount;
	public VkIndirectCommandsStreamNV* Streams;
	public uint SequencesCount;
	public VkBuffer PreprocessBuffer;
	public VkDeviceSize PreprocessOffset;
	public VkDeviceSize PreprocessSize;
	public VkBuffer SequencesCountBuffer;
	public VkDeviceSize SequencesCountOffset;
	public VkBuffer SequencesIndexBuffer;
	public VkDeviceSize SequencesIndexOffset;
}
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipeline Pipeline;
	public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
	public uint MaxSequencesCount;
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
public unsafe struct VkImageFormatProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkImageFormatProperties ImageFormatProperties;
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
public unsafe struct VkSparseImageFormatProperties2
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageFormatProperties Properties;
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
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPushDescriptors;
}
public unsafe struct VkConformanceVersion
{
	public byte Major;
	public byte Minor;
	public byte Subminor;
	public byte Patch;
}
public unsafe struct VkPhysicalDeviceDriverProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkDriverId DriverID;
	public fixed byte DriverName[(int)VK.MaxDriverNameSize];
	public fixed byte DriverInfo[(int)VK.MaxDriverInfoSize];
	public VkConformanceVersion ConformanceVersion;
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
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
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
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkImportMemoryFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
	public int FileDescriptor;
}
public unsafe struct VkMemoryFdPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkMemoryGetFdInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlags HandleType;
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
public unsafe struct VkExportSemaphoreCreateInfo
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
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public VkExternalSemaphoreHandleTypeFlags HandleType;
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
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public SecurityAttributes* Attributes;
	public uint DwAccess;
	public IntPtr Name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFence Fence;
	public VkExternalFenceHandleTypeFlags HandleType;
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
public unsafe struct VkMemoryAllocateFlagsInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryAllocateFlags Flags;
	public uint DeviceMask;
}
public unsafe struct VkBindBufferMemoryInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DeviceIndexCount;
	public uint* DeviceIndices;
}
public unsafe struct VkBindImageMemoryInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
	public VkDeviceMemory Memory;
	public VkDeviceSize MemoryOffset;
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
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed uint PresentMask[(int)VK.MaxDeviceGroupSize];
	public VkDeviceGroupPresentModeFlagsKHR Modes;
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
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public uint* DeviceMasks;
	public VkDeviceGroupPresentModeFlagsKHR Mode;
}
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint PhysicalDeviceCount;
	public VkPhysicalDevice* PhysicalDevices;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceGroupPresentModeFlagsKHR Modes;
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
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public uint DescriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType TemplateType;
	public VkDescriptorSetLayout DescriptorSetLayout;
	public VkPipelineBindPoint PipelineBindPoint;
	public VkPipelineLayout PipelineLayout;
	public uint Set;
}
public unsafe struct VkXYColorEXT
{
	public float X;
	public float Y;
}
public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PresentId;
}
public unsafe struct VkPresentIdKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint SwapchainCount;
	public ulong* PresentIds;
}
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PresentWait;
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
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public void* View;
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
	public uint Flags;
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
	public uint Flags;
	public VkDiscardRectangleModeEXT DiscardRectangleMode;
	public uint DiscardRectangleCount;
	public VkRect2D* DiscardRectangles;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PerViewPositionAllComponents;
}
public unsafe struct VkInputAttachmentAspectReference
{
	public uint Subpass;
	public uint InputAttachmentIndex;
	public VkImageAspectFlags AspectMask;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint AspectReferenceCount;
	public VkInputAttachmentAspectReference* AspectReferences;
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
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags SharedPresentSupportedUsageFlags;
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
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint SubgroupSize;
	public VkShaderStageFlags SupportedStages;
	public VkSubgroupFeatureFlags SupportedOperations;
	public VkBool32 QuadOperationsInAllStages;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSubgroupExtendedTypes;
}
public unsafe struct VkBufferMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkDeviceBufferMemoryRequirements
{
	public VkStructureType SType;
	public void* Next;
	public VkBufferCreateInfo* CreateInfo;
}
public unsafe struct VkImageMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage Image;
}
public unsafe struct VkDeviceImageMemoryRequirements
{
	public VkStructureType SType;
	public void* Next;
	public VkImageCreateInfo* CreateInfo;
	public VkImageAspectFlags PlaneAspect;
}
public unsafe struct VkMemoryRequirements2
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryRequirements MemoryRequirements;
}
public unsafe struct VkSparseImageMemoryRequirements2
{
	public VkStructureType SType;
	public void* Next;
	public VkSparseImageMemoryRequirements MemoryRequirements;
}
public unsafe struct VkPhysicalDevicePointClippingProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkPointClippingBehavior PointClippingBehavior;
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
public unsafe struct VkSamplerYcbcrConversionInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerYcbcrConversion Conversion;
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
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SupportsTextureGatherLODBiasAMD;
}
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkConditionalRenderingFlagsEXT Flags;
}
public unsafe struct VkProtectedSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProtectedSubmit;
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
public unsafe struct VkDeviceQueueInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceQueueCreateFlags Flags;
	public uint QueueFamilyIndex;
	public uint QueueIndex;
}
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkBool32 CoverageToColorEnable;
	public uint CoverageToColorLocation;
}
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FilterMinmaxSingleComponentFormats;
	public VkBool32 FilterMinmaxImageComponentMapping;
}
public unsafe struct VkSampleLocationEXT
{
	public float X;
	public float Y;
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
public unsafe struct VkMultisamplePropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D MaxSampleLocationGridSize;
}
public unsafe struct VkSamplerReductionModeCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSamplerReductionMode ReductionMode;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AdvancedBlendCoherentOperations;
}
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MultiDraw;
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
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 InlineUniformBlock;
	public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxInlineUniformBlockSize;
	public uint MaxPerStageDescriptorInlineUniformBlocks;
	public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint MaxDescriptorSetInlineUniformBlocks;
	public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
	public VkStructureType SType;
	public void* Next;
	public uint DataSize;
	public void* Data;
}
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxInlineUniformBlockBindings;
}
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkCoverageModulationModeNV CoverageModulationMode;
	public VkBool32 CoverageModulationTableEnable;
	public uint CoverageModulationTableCount;
	public float* CoverageModulationTable;
}
public unsafe struct VkImageFormatListCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint ViewFormatCount;
	public VkFormat* ViewFormats;
}
public unsafe struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public nuint InitialDataSize;
	public void* InitialData;
}
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkValidationCacheEXT ValidationCache;
}
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPerSetDescriptors;
	public VkDeviceSize MaxMemoryAllocationSize;
}
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Maintenance4;
}
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize MaxBufferSize;
}
public unsafe struct VkDescriptorSetLayoutSupport
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Supported;
}
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderFloat16;
	public VkBool32 ShaderInt8;
}
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderFloatControlsIndependence DenormBehaviorIndependence;
	public VkShaderFloatControlsIndependence RoundingModeIndependence;
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
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 HostQueryReset;
}
public unsafe struct VkNativeBufferUsage2ANDROID
{
	public ulong Consumer;
	public ulong Producer;
}
public unsafe struct VkNativeBufferANDROID
{
	public VkStructureType SType;
	public void* Next;
	public void* Handle;
	public int Stride;
	public int Format;
	public int Usage;
	public VkNativeBufferUsage2ANDROID Usage2;
}
public unsafe struct VkSwapchainImageCreateInfoANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkSwapchainImageUsageFlagsANDROID Usage;
}
public unsafe struct VkPhysicalDevicePresentationPropertiesANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SharedImage;
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
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkQueueGlobalPriorityKHR GlobalPriority;
}
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 GlobalPriorityQuery;
}
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint PriorityCount;
	public VkQueueGlobalPriorityKHR Priorities_0;
	public VkQueueGlobalPriorityKHR Priorities_1;
	public VkQueueGlobalPriorityKHR Priorities_2;
	public VkQueueGlobalPriorityKHR Priorities_3;
	public VkQueueGlobalPriorityKHR Priorities_4;
	public VkQueueGlobalPriorityKHR Priorities_5;
	public VkQueueGlobalPriorityKHR Priorities_6;
	public VkQueueGlobalPriorityKHR Priorities_7;
	public VkQueueGlobalPriorityKHR Priorities_8;
	public VkQueueGlobalPriorityKHR Priorities_9;
	public VkQueueGlobalPriorityKHR Priorities_10;
	public VkQueueGlobalPriorityKHR Priorities_11;
	public VkQueueGlobalPriorityKHR Priorities_12;
	public VkQueueGlobalPriorityKHR Priorities_13;
	public VkQueueGlobalPriorityKHR Priorities_14;
	public VkQueueGlobalPriorityKHR Priorities_15;
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
	public uint Flags;
	public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;
	public VkDebugUtilsMessageTypeFlagsEXT MessageType;
	public IntPtr UserCallback;
	public void* UserData;
}
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
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
public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DeviceMemoryReport;
}
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public IntPtr UserCallback;
	public void* UserData;
}
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkDeviceMemoryReportEventTypeEXT Type;
	public ulong MemoryObjectId;
	public VkDeviceSize Size;
	public VkObjectType ObjectType;
	public ulong ObjectHandle;
	public uint HeapIndex;
}
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExternalMemoryHandleTypeFlags HandleType;
	public void* HostPointer;
}
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MemoryTypeBits;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize MinImportedHostPointerAlignment;
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
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType SType;
	public void* Next;
	public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
	public uint ActiveComputeUnitCount;
}
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
	public VkConservativeRasterizationModeEXT ConservativeRasterizationMode;
	public float ExtraPrimitiveOverestimationSize;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
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
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
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
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint BindingCount;
	public VkDescriptorBindingFlags* BindingFlags;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint DescriptorSetCount;
	public uint* DescriptorCounts;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxVariableDescriptorCount;
}
public unsafe struct VkAttachmentDescription2
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
public unsafe struct VkAttachmentReference2
{
	public VkStructureType SType;
	public void* Next;
	public uint Attachment;
	public VkImageLayout Layout;
	public VkImageAspectFlags AspectMask;
}
public unsafe struct VkSubpassDescription2
{
	public VkStructureType SType;
	public void* Next;
	public VkSubpassDescriptionFlags Flags;
	public VkPipelineBindPoint PipelineBindPoint;
	public uint ViewMask;
	public uint InputAttachmentCount;
	public VkAttachmentReference2* InputAttachments;
	public uint ColorAttachmentCount;
	public VkAttachmentReference2* ColorAttachments;
	public VkAttachmentReference2* ResolveAttachments;
	public VkAttachmentReference2* DepthStencilAttachment;
	public uint PreserveAttachmentCount;
	public uint* PreserveAttachments;
}
public unsafe struct VkSubpassDependency2
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
public unsafe struct VkRenderPassCreateInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPassCreateFlags Flags;
	public uint AttachmentCount;
	public VkAttachmentDescription2* Attachments;
	public uint SubpassCount;
	public VkSubpassDescription2* Subpasses;
	public uint DependencyCount;
	public VkSubpassDependency2* Dependencies;
	public uint CorrelatedViewMaskCount;
	public uint* CorrelatedViewMasks;
}
public unsafe struct VkSubpassBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSubpassContents Contents;
}
public unsafe struct VkSubpassEndInfo
{
	public VkStructureType SType;
	public void* Next;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TimelineSemaphore;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
{
	public VkStructureType SType;
	public void* Next;
	public ulong MaxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphoreType SemaphoreType;
	public ulong InitialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint WaitSemaphoreValueCount;
	public ulong* WaitSemaphoreValues;
	public uint SignalSemaphoreValueCount;
	public ulong* SignalSemaphoreValues;
}
public unsafe struct VkSemaphoreWaitInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphoreWaitFlags Flags;
	public uint SemaphoreCount;
	public VkSemaphore* Semaphores;
	public ulong* Values;
}
public unsafe struct VkSemaphoreSignalInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public ulong Value;
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
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxVertexAttribDivisor;
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
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
	public VkStructureType SType;
	public void* Next;
	public IntPtr* Buffer;
}
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
	public VkStructureType SType;
	public void* Next;
	public ulong AndroidHardwareBufferUsage;
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
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ConditionalRenderingEnable;
}
public unsafe struct VkExternalFormatANDROID
{
	public VkStructureType SType;
	public void* Next;
	public ulong ExternalFormat;
}
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 StorageBuffer8BitAccess;
	public VkBool32 UniformAndStorageBuffer8BitAccess;
	public VkBool32 StoragePushConstant8;
}
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ConditionalRendering;
	public VkBool32 InheritedConditionalRendering;
}
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VulkanMemoryModel;
	public VkBool32 VulkanMemoryModelDeviceScope;
	public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderBufferInt64Atomics;
	public VkBool32 ShaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderBufferFloat32Atomics;
	public VkBool32 ShaderBufferFloat32AtomicAdd;
	public VkBool32 ShaderBufferFloat64Atomics;
	public VkBool32 ShaderBufferFloat64AtomicAdd;
	public VkBool32 ShaderSharedFloat32Atomics;
	public VkBool32 ShaderSharedFloat32AtomicAdd;
	public VkBool32 ShaderSharedFloat64Atomics;
	public VkBool32 ShaderSharedFloat64AtomicAdd;
	public VkBool32 ShaderImageFloat32Atomics;
	public VkBool32 ShaderImageFloat32AtomicAdd;
	public VkBool32 SparseImageFloat32Atomics;
	public VkBool32 SparseImageFloat32AtomicAdd;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderBufferFloat16Atomics;
	public VkBool32 ShaderBufferFloat16AtomicAdd;
	public VkBool32 ShaderBufferFloat16AtomicMinMax;
	public VkBool32 ShaderBufferFloat32AtomicMinMax;
	public VkBool32 ShaderBufferFloat64AtomicMinMax;
	public VkBool32 ShaderSharedFloat16Atomics;
	public VkBool32 ShaderSharedFloat16AtomicAdd;
	public VkBool32 ShaderSharedFloat16AtomicMinMax;
	public VkBool32 ShaderSharedFloat32AtomicMinMax;
	public VkBool32 ShaderSharedFloat64AtomicMinMax;
	public VkBool32 ShaderImageFloat32AtomicMinMax;
	public VkBool32 SparseImageFloat32AtomicMinMax;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VertexAttributeInstanceRateDivisor;
	public VkBool32 VertexAttributeInstanceRateZeroDivisor;
}
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags CheckpointExecutionStageMask;
}
public unsafe struct VkCheckpointDataNV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags Stage;
	public void* CheckpointMarker;
}
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkResolveModeFlags SupportedDepthResolveModes;
	public VkResolveModeFlags SupportedStencilResolveModes;
	public VkBool32 IndependentResolveNone;
	public VkBool32 IndependentResolve;
}
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
	public VkStructureType SType;
	public void* Next;
	public VkResolveModeFlags DepthResolveMode;
	public VkResolveModeFlags StencilResolveMode;
	public VkAttachmentReference2* DepthStencilResolveAttachment;
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
	public uint Flags;
	public uint RasterizationStream;
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
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ExclusiveScissor;
}
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint ExclusiveScissorCount;
	public VkRect2D* ExclusiveScissors;
}
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 CornerSampledImage;
}
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ComputeDerivativeGroupQuads;
	public VkBool32 ComputeDerivativeGroupLinear;
}
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImageFootprint;
}
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DedicatedAllocationImageAliasing;
}
public unsafe struct VkShadingRatePaletteNV
{
	public uint ShadingRatePaletteEntryCount;
	public VkShadingRatePaletteEntryNV* ShadingRatePaletteEntries;
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
public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 InvocationMask;
}
public unsafe struct VkCoarseSampleLocationNV
{
	public uint PixelX;
	public uint PixelY;
	public uint Sample;
}
public unsafe struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV ShadingRate;
	public uint SampleCount;
	public uint SampleLocationCount;
	public VkCoarseSampleLocationNV* SampleLocations;
}
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkCoarseSampleOrderTypeNV SampleOrderType;
	public uint CustomSampleOrderCount;
	public VkCoarseSampleOrderCustomNV* CustomSampleOrders;
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
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TaskShader;
	public VkBool32 MeshShader;
	public VkBool32 MultiviewMeshShader;
	public VkBool32 PrimitiveFragmentShadingRateMeshShader;
	public VkBool32 MeshShaderQueries;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxTaskWorkGroupTotalCount;
	public fixed uint MaxTaskWorkGroupCount[3];
	public uint MaxTaskWorkGroupInvocations;
	public fixed uint MaxTaskWorkGroupSize[3];
	public uint MaxTaskPayloadSize;
	public uint MaxTaskSharedMemorySize;
	public uint MaxTaskPayloadAndSharedMemorySize;
	public uint MaxMeshWorkGroupTotalCount;
	public fixed uint MaxMeshWorkGroupCount[3];
	public uint MaxMeshWorkGroupInvocations;
	public fixed uint MaxMeshWorkGroupSize[3];
	public uint MaxMeshSharedMemorySize;
	public uint MaxMeshPayloadAndSharedMemorySize;
	public uint MaxMeshOutputMemorySize;
	public uint MaxMeshPayloadAndOutputMemorySize;
	public uint MaxMeshOutputComponents;
	public uint MaxMeshOutputVertices;
	public uint MaxMeshOutputPrimitives;
	public uint MaxMeshOutputLayers;
	public uint MaxMeshMultiviewViewCount;
	public uint MeshOutputPerVertexGranularity;
	public uint MeshOutputPerPrimitiveGranularity;
	public uint MaxPreferredTaskWorkGroupInvocations;
	public uint MaxPreferredMeshWorkGroupInvocations;
	public VkBool32 PrefersLocalInvocationVertexOutput;
	public VkBool32 PrefersLocalInvocationPrimitiveOutput;
	public VkBool32 PrefersCompactVertexOutput;
	public VkBool32 PrefersCompactPrimitiveOutput;
}
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
	public uint GroupCountX;
	public uint GroupCountY;
	public uint GroupCountZ;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkRayTracingShaderGroupTypeKHR Type;
	public uint GeneralShader;
	public uint ClosestHitShader;
	public uint AnyHitShader;
	public uint IntersectionShader;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkRayTracingShaderGroupTypeKHR Type;
	public uint GeneralShader;
	public uint ClosestHitShader;
	public uint AnyHitShader;
	public uint IntersectionShader;
	public void* ShaderGroupCaptureReplayHandle;
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
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreateFlags Flags;
	public uint StageCount;
	public VkPipelineShaderStageCreateInfo* Stages;
	public uint GroupCount;
	public VkRayTracingShaderGroupCreateInfoKHR* Groups;
	public uint MaxPipelineRayRecursionDepth;
	public VkPipelineLibraryCreateInfoKHR* LibraryInfo;
	public VkRayTracingPipelineInterfaceCreateInfoKHR* LibraryInterface;
	public VkPipelineDynamicStateCreateInfo* DynamicState;
	public VkPipelineLayout Layout;
	public VkPipeline BasePipelineHandle;
	public int BasePipelineIndex;
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
public unsafe struct VkGeometryDataNV
{
	public VkGeometryTrianglesNV Triangles;
	public VkGeometryAABBNV Aabbs;
}
public unsafe struct VkGeometryNV
{
	public VkStructureType SType;
	public void* Next;
	public VkGeometryTypeKHR GeometryType;
	public VkGeometryDataNV Geometry;
	public VkGeometryFlagsKHR Flags;
}
public unsafe struct VkAccelerationStructureInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureTypeKHR Type;
	public VkBuildAccelerationStructureFlagsKHR Flags;
	public uint InstanceCount;
	public uint GeometryCount;
	public VkGeometryNV* Geometries;
}
public unsafe struct VkAccelerationStructureCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize CompactedSize;
	public VkAccelerationStructureInfoNV Info;
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
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint AccelerationStructureCount;
	public VkAccelerationStructureKHR* AccelerationStructures;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType SType;
	public void* Next;
	public uint AccelerationStructureCount;
	public VkAccelerationStructureNV* AccelerationStructures;
}
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureMemoryRequirementsTypeNV Type;
	public VkAccelerationStructureNV AccelerationStructure;
}
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AccelerationStructure;
	public VkBool32 AccelerationStructureCaptureReplay;
	public VkBool32 AccelerationStructureIndirectBuild;
	public VkBool32 AccelerationStructureHostCommands;
	public VkBool32 DescriptorBindingAccelerationStructureUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RayTracingPipeline;
	public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplay;
	public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplayMixed;
	public VkBool32 RayTracingPipelineTraceRaysIndirect;
	public VkBool32 RayTraversalPrimitiveCulling;
}
public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RayQuery;
}
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public ulong MaxGeometryCount;
	public ulong MaxInstanceCount;
	public ulong MaxPrimitiveCount;
	public uint MaxPerStageDescriptorAccelerationStructures;
	public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
	public uint MaxDescriptorSetAccelerationStructures;
	public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;
	public uint MinAccelerationStructureScratchOffsetAlignment;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint ShaderGroupHandleSize;
	public uint MaxRayRecursionDepth;
	public uint MaxShaderGroupStride;
	public uint ShaderGroupBaseAlignment;
	public uint ShaderGroupHandleCaptureReplaySize;
	public uint MaxRayDispatchInvocationCount;
	public uint ShaderGroupHandleAlignment;
	public uint MaxRayHitAttributeSize;
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
public unsafe struct VkStridedDeviceAddressRegionKHR
{
	public VkDeviceAddress DeviceAddress;
	public VkDeviceSize Stride;
	public VkDeviceSize Size;
}
public unsafe struct VkTraceRaysIndirectCommandKHR
{
	public uint Width;
	public uint Height;
	public uint Depth;
}
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
	public VkDeviceAddress RaygenShaderRecordAddress;
	public VkDeviceSize RaygenShaderRecordSize;
	public VkDeviceAddress MissShaderBindingTableAddress;
	public VkDeviceSize MissShaderBindingTableSize;
	public VkDeviceSize MissShaderBindingTableStride;
	public VkDeviceAddress HitShaderBindingTableAddress;
	public VkDeviceSize HitShaderBindingTableSize;
	public VkDeviceSize HitShaderBindingTableStride;
	public VkDeviceAddress CallableShaderBindingTableAddress;
	public VkDeviceSize CallableShaderBindingTableSize;
	public VkDeviceSize CallableShaderBindingTableStride;
	public uint Width;
	public uint Height;
	public uint Depth;
}
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RayTracingMaintenance1;
	public VkBool32 RayTracingPipelineTraceRaysIndirect2;
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
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public ulong DrmFormatModifier;
}
public unsafe struct VkImageStencilUsageCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageUsageFlags StencilUsage;
}
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkMemoryOverallocationBehaviorAMD OverallocationBehavior;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentDensityMap;
	public VkBool32 FragmentDensityMapDynamic;
	public VkBool32 FragmentDensityMapNonSubsampledImages;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentDensityMapDeferred;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentDensityMapOffset;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D MinFragmentDensityTexelSize;
	public VkExtent2D MaxFragmentDensityTexelSize;
	public VkBool32 FragmentDensityInvocations;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SubsampledLoads;
	public VkBool32 SubsampledCoarseReconstructionEarlyAccess;
	public uint MaxSubsampledArrayLayers;
	public uint MaxDescriptorSetSubsampledSamplers;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D FragmentDensityOffsetGranularity;
}
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkAttachmentReference FragmentDensityMapAttachment;
}
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
	public VkStructureType SType;
	public void* Next;
	public uint FragmentDensityOffsetCount;
	public VkOffset2D* FragmentDensityOffsets;
}
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ScalarBlockLayout;
}
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SupportsProtected;
}
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 UniformBufferStandardLayout;
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
	public uint Flags;
	public VkBool32 DepthClipEnable;
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
public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PageableDeviceLocalMemory;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
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
public unsafe struct VkBufferDeviceAddressInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer Buffer;
}
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public ulong OpaqueCaptureAddress;
}
public unsafe struct VkBufferDeviceAddressCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceAddress DeviceAddress;
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
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImagelessFramebuffer;
}
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfo* AttachmentImageInfos;
}
public unsafe struct VkFramebufferAttachmentImageInfo
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
public unsafe struct VkRenderPassAttachmentBeginInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentCount;
	public VkImageView* Attachments;
}
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TextureCompressionASTC_HDR;
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
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 YcbcrImageArrays;
}
public unsafe struct VkImageViewHandleInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkImageView ImageView;
	public VkDescriptorType DescriptorType;
	public VkSampler Sampler;
}
public unsafe struct VkImageViewAddressPropertiesNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceAddress DeviceAddress;
	public VkDeviceSize Size;
}
public unsafe struct VkPipelineCreationFeedback
{
	public VkPipelineCreationFeedbackFlags Flags;
	public ulong Duration;
}
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCreationFeedback* PipelineCreationFeedback;
	public uint PipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedback** PipelineStageCreationFeedbacks;
}
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkFullScreenExclusiveEXT FullScreenExclusive;
}
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public IntPtr Hmonitor;
}
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FullScreenExclusiveSupported;
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
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAcquireProfilingLockFlagsKHR Flags;
	public ulong Timeout;
}
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint CounterPassIndex;
}
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Flags;
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
	public uint Flags;
	public VkCoverageReductionModeNV CoverageReductionMode;
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
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderIntegerFunctions2;
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
public unsafe struct VkPerformanceValueINTEL
{
	public VkPerformanceValueTypeINTEL Type;
	public VkPerformanceValueDataINTEL Data;
}
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public void* UserData;
}
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
	public VkStructureType SType;
	public void* Next;
	public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
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
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSubgroupClock;
	public VkBool32 ShaderDeviceClock;
}
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 IndexTypeUint8;
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
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentShaderSampleInterlock;
	public VkBool32 FragmentShaderPixelInterlock;
	public VkBool32 FragmentShaderShadingRateInterlock;
}
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SeparateDepthStencilLayouts;
}
public unsafe struct VkAttachmentReferenceStencilLayout
{
	public VkStructureType SType;
	public void* Next;
	public VkImageLayout StencilLayout;
}
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrimitiveTopologyListRestart;
	public VkBool32 PrimitiveTopologyPatchListRestart;
}
public unsafe struct VkAttachmentDescriptionStencilLayout
{
	public VkStructureType SType;
	public void* Next;
	public VkImageLayout StencilInitialLayout;
	public VkImageLayout StencilFinalLayout;
}
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelineExecutableInfo;
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
public unsafe struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte Name[(int)VK.MaxDescriptionSize];
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public VkPipelineExecutableStatisticFormatKHR Format;
	public VkPipelineExecutableStatisticValueKHR Value;
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
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
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
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
	public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SubgroupSizeControl;
	public VkBool32 ComputeFullSubgroups;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
	public VkStructureType SType;
	public void* Next;
	public uint MinSubgroupSize;
	public uint MaxSubgroupSize;
	public uint MaxComputeWorkgroupSubgroups;
	public VkShaderStageFlags RequiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint RequiredSubgroupSize;
}
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPass RenderPass;
	public uint Subpass;
}
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxSubpassShadingWorkgroupSizeAspectRatio;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
	public VkStructureType SType;
	public void* Next;
	public ulong OpaqueCaptureAddress;
}
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
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
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelineCreationCacheControl;
}
public unsafe struct VkPhysicalDeviceVulkan11Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 StorageBuffer16BitAccess;
	public VkBool32 UniformAndStorageBuffer16BitAccess;
	public VkBool32 StoragePushConstant16;
	public VkBool32 StorageInputOutput16;
	public VkBool32 Multiview;
	public VkBool32 MultiviewGeometryShader;
	public VkBool32 MultiviewTessellationShader;
	public VkBool32 VariablePointersStorageBuffer;
	public VkBool32 VariablePointers;
	public VkBool32 ProtectedMemory;
	public VkBool32 SamplerYcbcrConversion;
	public VkBool32 ShaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte DeviceUUID[(int)VK.UuidSize];
	public fixed byte DriverUUID[(int)VK.UuidSize];
	public fixed byte DeviceLUID[(int)VK.LuidSize];
	public uint DeviceNodeMask;
	public VkBool32 DeviceLUIDValid;
	public uint SubgroupSize;
	public VkShaderStageFlags SubgroupSupportedStages;
	public VkSubgroupFeatureFlags SubgroupSupportedOperations;
	public VkBool32 SubgroupQuadOperationsInAllStages;
	public VkPointClippingBehavior PointClippingBehavior;
	public uint MaxMultiviewViewCount;
	public uint MaxMultiviewInstanceIndex;
	public VkBool32 ProtectedNoFault;
	public uint MaxPerSetDescriptors;
	public VkDeviceSize MaxMemoryAllocationSize;
}
public unsafe struct VkPhysicalDeviceVulkan12Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SamplerMirrorClampToEdge;
	public VkBool32 DrawIndirectCount;
	public VkBool32 StorageBuffer8BitAccess;
	public VkBool32 UniformAndStorageBuffer8BitAccess;
	public VkBool32 StoragePushConstant8;
	public VkBool32 ShaderBufferInt64Atomics;
	public VkBool32 ShaderSharedInt64Atomics;
	public VkBool32 ShaderFloat16;
	public VkBool32 ShaderInt8;
	public VkBool32 DescriptorIndexing;
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
	public VkBool32 SamplerFilterMinmax;
	public VkBool32 ScalarBlockLayout;
	public VkBool32 ImagelessFramebuffer;
	public VkBool32 UniformBufferStandardLayout;
	public VkBool32 ShaderSubgroupExtendedTypes;
	public VkBool32 SeparateDepthStencilLayouts;
	public VkBool32 HostQueryReset;
	public VkBool32 TimelineSemaphore;
	public VkBool32 BufferDeviceAddress;
	public VkBool32 BufferDeviceAddressCaptureReplay;
	public VkBool32 BufferDeviceAddressMultiDevice;
	public VkBool32 VulkanMemoryModel;
	public VkBool32 VulkanMemoryModelDeviceScope;
	public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
	public VkBool32 ShaderOutputViewportIndex;
	public VkBool32 ShaderOutputLayer;
	public VkBool32 SubgroupBroadcastDynamicId;
}
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
	public VkStructureType SType;
	public void* Next;
	public VkDriverId DriverID;
	public fixed byte DriverName[(int)VK.MaxDriverNameSize];
	public fixed byte DriverInfo[(int)VK.MaxDriverInfoSize];
	public VkConformanceVersion ConformanceVersion;
	public VkShaderFloatControlsIndependence DenormBehaviorIndependence;
	public VkShaderFloatControlsIndependence RoundingModeIndependence;
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
	public VkResolveModeFlags SupportedDepthResolveModes;
	public VkResolveModeFlags SupportedStencilResolveModes;
	public VkBool32 IndependentResolveNone;
	public VkBool32 IndependentResolve;
	public VkBool32 FilterMinmaxSingleComponentFormats;
	public VkBool32 FilterMinmaxImageComponentMapping;
	public ulong MaxTimelineSemaphoreValueDifference;
	public VkSampleCountFlags FramebufferIntegerColorSampleCounts;
}
public unsafe struct VkPhysicalDeviceVulkan13Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RobustImageAccess;
	public VkBool32 InlineUniformBlock;
	public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
	public VkBool32 PipelineCreationCacheControl;
	public VkBool32 PrivateData;
	public VkBool32 ShaderDemoteToHelperInvocation;
	public VkBool32 ShaderTerminateInvocation;
	public VkBool32 SubgroupSizeControl;
	public VkBool32 ComputeFullSubgroups;
	public VkBool32 Synchronization2;
	public VkBool32 TextureCompressionASTC_HDR;
	public VkBool32 ShaderZeroInitializeWorkgroupMemory;
	public VkBool32 DynamicRendering;
	public VkBool32 ShaderIntegerDotProduct;
	public VkBool32 Maintenance4;
}
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
	public VkStructureType SType;
	public void* Next;
	public uint MinSubgroupSize;
	public uint MaxSubgroupSize;
	public uint MaxComputeWorkgroupSubgroups;
	public VkShaderStageFlags RequiredSubgroupSizeStages;
	public uint MaxInlineUniformBlockSize;
	public uint MaxPerStageDescriptorInlineUniformBlocks;
	public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint MaxDescriptorSetInlineUniformBlocks;
	public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	public uint MaxInlineUniformTotalSize;
	public VkBool32 IntegerDotProduct8BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct8BitSignedAccelerated;
	public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct16BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct16BitSignedAccelerated;
	public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct32BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct32BitSignedAccelerated;
	public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct64BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct64BitSignedAccelerated;
	public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
	public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize MaxBufferSize;
}
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineCompilerControlFlagsAMD CompilerControlFlags;
}
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DeviceCoherentMemory;
}
public unsafe struct VkPhysicalDeviceToolProperties
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte Name[(int)VK.MaxExtensionNameSize];
	public fixed byte Version[(int)VK.MaxExtensionNameSize];
	public VkToolPurposeFlags Purposes;
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public fixed byte Layer[(int)VK.MaxExtensionNameSize];
}
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkClearColorValue CustomBorderColor;
	public VkFormat Format;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxCustomBorderColorSamplers;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 CustomBorderColors;
	public VkBool32 CustomBorderColorWithoutFormat;
}
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkComponentMapping Components;
	public VkBool32 Srgb;
}
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 BorderColorSwizzle;
	public VkBool32 BorderColorSwizzleFromImage;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress DeviceAddress;
	[FieldOffset(0)]
	public void* HostAddress;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressConstKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress DeviceAddress;
	[FieldOffset(0)]
	public void* HostAddress;
}
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat VertexFormat;
	public VkDeviceOrHostAddressConstKHR VertexData;
	public VkDeviceSize VertexStride;
	public uint MaxVertex;
	public VkIndexType IndexType;
	public VkDeviceOrHostAddressConstKHR IndexData;
	public VkDeviceOrHostAddressConstKHR TransformData;
}
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceOrHostAddressConstKHR Data;
	public VkDeviceSize Stride;
}
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ArrayOfPointers;
	public VkDeviceOrHostAddressConstKHR Data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryTrianglesDataKHR Triangles;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryAabbsDataKHR Aabbs;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryInstancesDataKHR Instances;
}
public unsafe struct VkAccelerationStructureGeometryKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkGeometryTypeKHR GeometryType;
	public VkAccelerationStructureGeometryDataKHR Geometry;
	public VkGeometryFlagsKHR Flags;
}
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureTypeKHR Type;
	public VkBuildAccelerationStructureFlagsKHR Flags;
	public VkBuildAccelerationStructureModeKHR Mode;
	public VkAccelerationStructureKHR SourceAccelerationStructure;
	public VkAccelerationStructureKHR DestinationAccelerationStructure;
	public uint GeometryCount;
	public VkAccelerationStructureGeometryKHR* Geometries;
	public VkAccelerationStructureGeometryKHR** Geometries2;
	public VkDeviceOrHostAddressKHR ScratchData;
}
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
	public uint PrimitiveCount;
	public uint PrimitiveOffset;
	public uint FirstVertex;
	public uint TransformOffset;
}
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureCreateFlagsKHR CreateFlags;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
	public VkAccelerationStructureTypeKHR Type;
	public VkDeviceAddress DeviceAddress;
}
public unsafe struct VkAabbPositionsKHR
{
	public float MinX;
	public float MinY;
	public float MinZ;
	public float MaxX;
	public float MaxY;
	public float MaxZ;
}
public unsafe struct VkTransformMatrixKHR
{
	public fixed float Matrix[12];
}
public unsafe struct VkAccelerationStructureInstanceKHR
{
	public VkTransformMatrixKHR Transform;
	public uint InstanceCustomIndex;
	public uint Mask;
	public uint InstanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR Flags;
	public ulong AccelerationStructureReference;
}
public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureKHR AccelerationStructure;
}
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public byte* VersionData;
}
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureKHR Source;
	public VkAccelerationStructureKHR Destination;
	public VkCopyAccelerationStructureModeKHR Mode;
}
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAccelerationStructureKHR Source;
	public VkDeviceOrHostAddressKHR Destination;
	public VkCopyAccelerationStructureModeKHR Mode;
}
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceOrHostAddressConstKHR Source;
	public VkAccelerationStructureKHR Destination;
	public VkCopyAccelerationStructureModeKHR Mode;
}
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxPipelineRayPayloadSize;
	public uint MaxPipelineRayHitAttributeSize;
}
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public uint LibraryCount;
	public VkPipeline* Libraries;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ExtendedDynamicState;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ExtendedDynamicState2;
	public VkBool32 ExtendedDynamicState2LogicOp;
	public VkBool32 ExtendedDynamicState2PatchControlPoints;
}
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceTransformFlagsKHR Transform;
}
public unsafe struct VkCopyCommandTransformInfoQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceTransformFlagsKHR Transform;
}
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkSurfaceTransformFlagsKHR Transform;
	public VkRect2D RenderArea;
}
public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DiagnosticsConfig;
}
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceDiagnosticsConfigFlagsNV Flags;
}
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderZeroInitializeWorkgroupMemory;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderSubgroupUniformControlFlow;
}
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RobustBufferAccess2;
	public VkBool32 RobustImageAccess2;
	public VkBool32 NullDescriptor;
}
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize RobustStorageBufferAccessSizeAlignment;
	public VkDeviceSize RobustUniformBufferAccessSizeAlignment;
}
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RobustImageAccess;
}
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 WorkgroupMemoryExplicitLayout;
	public VkBool32 WorkgroupMemoryExplicitLayoutScalarBlockLayout;
	public VkBool32 WorkgroupMemoryExplicitLayout8BitAccess;
	public VkBool32 WorkgroupMemoryExplicitLayout16BitAccess;
}
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FormatA4R4G4B4;
	public VkBool32 FormatA4B4G4R4;
}
public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SubpassShading;
}
public unsafe struct VkBufferCopy2
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize SourceOffset;
	public VkDeviceSize DestinationOffset;
	public VkDeviceSize Size;
}
public unsafe struct VkImageCopy2
{
	public VkStructureType SType;
	public void* Next;
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
}
public unsafe struct VkImageBlit2
{
	public VkStructureType SType;
	public void* Next;
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffsets_0;
	public VkOffset3D SourceOffsets_1;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffsets_0;
	public VkOffset3D DestinationOffsets_1;
}
public unsafe struct VkBufferImageCopy2
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize BufferOffset;
	public uint BufferRowLength;
	public uint BufferImageHeight;
	public VkImageSubresourceLayers ImageSubresource;
	public VkOffset3D ImageOffset;
	public VkExtent3D ImageExtent;
}
public unsafe struct VkImageResolve2
{
	public VkStructureType SType;
	public void* Next;
	public VkImageSubresourceLayers SourceSubresource;
	public VkOffset3D SourceOffset;
	public VkImageSubresourceLayers DestinationSubresource;
	public VkOffset3D DestinationOffset;
	public VkExtent3D Extent;
}
public unsafe struct VkCopyBufferInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer SourceBuffer;
	public VkBuffer DestinationBuffer;
	public uint RegionCount;
	public VkBufferCopy2* Regions;
}
public unsafe struct VkCopyImageInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage SourceImage;
	public VkImageLayout SourceImageLayout;
	public VkImage DestinationImage;
	public VkImageLayout DestinationImageLayout;
	public uint RegionCount;
	public VkImageCopy2* Regions;
}
public unsafe struct VkBlitImageInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage SourceImage;
	public VkImageLayout SourceImageLayout;
	public VkImage DestinationImage;
	public VkImageLayout DestinationImageLayout;
	public uint RegionCount;
	public VkImageBlit2* Regions;
	public VkFilter Filter;
}
public unsafe struct VkCopyBufferToImageInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkBuffer SourceBuffer;
	public VkImage DestinationImage;
	public VkImageLayout DestinationImageLayout;
	public uint RegionCount;
	public VkBufferImageCopy2* Regions;
}
public unsafe struct VkCopyImageToBufferInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage SourceImage;
	public VkImageLayout SourceImageLayout;
	public VkBuffer DestinationBuffer;
	public uint RegionCount;
	public VkBufferImageCopy2* Regions;
}
public unsafe struct VkResolveImageInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkImage SourceImage;
	public VkImageLayout SourceImageLayout;
	public VkImage DestinationImage;
	public VkImageLayout DestinationImageLayout;
	public uint RegionCount;
	public VkImageResolve2* Regions;
}
public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderImageInt64Atomics;
	public VkBool32 SparseImageInt64Atomics;
}
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkAttachmentReference2* FragmentShadingRateAttachment;
	public VkExtent2D ShadingRateAttachmentTexelSize;
}
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D FragmentSize;
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_1;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelineFragmentShadingRate;
	public VkBool32 PrimitiveFragmentShadingRate;
	public VkBool32 AttachmentFragmentShadingRate;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent2D MinFragmentShadingRateAttachmentTexelSize;
	public VkExtent2D MaxFragmentShadingRateAttachmentTexelSize;
	public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;
	public VkBool32 PrimitiveFragmentShadingRateWithMultipleViewports;
	public VkBool32 LayeredShadingRateAttachments;
	public VkBool32 FragmentShadingRateNonTrivialCombinerOps;
	public VkExtent2D MaxFragmentSize;
	public uint MaxFragmentSizeAspectRatio;
	public uint MaxFragmentShadingRateCoverageSamples;
	public VkSampleCountFlags MaxFragmentShadingRateRasterizationSamples;
	public VkBool32 FragmentShadingRateWithShaderDepthStencilWrites;
	public VkBool32 FragmentShadingRateWithSampleMask;
	public VkBool32 FragmentShadingRateWithShaderSampleMask;
	public VkBool32 FragmentShadingRateWithConservativeRasterization;
	public VkBool32 FragmentShadingRateWithFragmentShaderInterlock;
	public VkBool32 FragmentShadingRateWithCustomSampleLocations;
	public VkBool32 FragmentShadingRateStrictMultiplyCombiner;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkSampleCountFlags SampleCounts;
	public VkExtent2D FragmentSize;
}
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderTerminateInvocation;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentShadingRateEnums;
	public VkBool32 SupersampleFragmentShadingRates;
	public VkBool32 NoInvocationFragmentShadingRates;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkSampleCountFlags MaxFragmentShadingRateInvocationCount;
}
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkFragmentShadingRateTypeNV ShadingRateType;
	public VkFragmentShadingRateNV ShadingRate;
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR CombinerOps_1;
}
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceSize AccelerationStructureSize;
	public VkDeviceSize UpdateScratchSize;
	public VkDeviceSize BuildScratchSize;
}
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Image2DViewOf3D;
	public VkBool32 Sampler2DViewOf3D;
}
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MutableDescriptorType;
}
public unsafe struct VkMutableDescriptorTypeListVALVE
{
	public uint DescriptorTypeCount;
	public VkDescriptorType* DescriptorTypes;
}
public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
{
	public VkStructureType SType;
	public void* Next;
	public uint MutableDescriptorTypeListCount;
	public VkMutableDescriptorTypeListVALVE* MutableDescriptorTypeLists;
}
public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DepthClipControl;
}
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 NegativeOneToOne;
}
public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 VertexInputDynamicState;
}
public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ExternalMemoryRDMA;
}
public unsafe struct VkVertexInputBindingDescription2EXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Binding;
	public uint Stride;
	public VkVertexInputRate InputRate;
	public uint Divisor;
}
public unsafe struct VkVertexInputAttributeDescription2EXT
{
	public VkStructureType SType;
	public void* Next;
	public uint Location;
	public uint Binding;
	public VkFormat Format;
	public uint Offset;
}
public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ColorWriteEnable;
}
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint AttachmentCount;
	public VkBool32* ColorWriteEnables;
}
public unsafe struct VkMemoryBarrier2
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags2 SourceStageMask;
	public VkAccessFlags2 SourceAccessMask;
	public VkPipelineStageFlags2 DestinationStageMask;
	public VkAccessFlags2 DestinationAccessMask;
}
public unsafe struct VkImageMemoryBarrier2
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags2 SourceStageMask;
	public VkAccessFlags2 SourceAccessMask;
	public VkPipelineStageFlags2 DestinationStageMask;
	public VkAccessFlags2 DestinationAccessMask;
	public VkImageLayout OldLayout;
	public VkImageLayout NewLayout;
	public uint SourceQueueFamilyIndex;
	public uint DestinationQueueFamilyIndex;
	public VkImage Image;
	public VkImageSubresourceRange SubresourceRange;
}
public unsafe struct VkBufferMemoryBarrier2
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags2 SourceStageMask;
	public VkAccessFlags2 SourceAccessMask;
	public VkPipelineStageFlags2 DestinationStageMask;
	public VkAccessFlags2 DestinationAccessMask;
	public uint SourceQueueFamilyIndex;
	public uint DestinationQueueFamilyIndex;
	public VkBuffer Buffer;
	public VkDeviceSize Offset;
	public VkDeviceSize Size;
}
public unsafe struct VkDependencyInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkDependencyFlags DependencyFlags;
	public uint MemoryBarrierCount;
	public VkMemoryBarrier2* MemoryBarriers;
	public uint BufferMemoryBarrierCount;
	public VkBufferMemoryBarrier2* BufferMemoryBarriers;
	public uint ImageMemoryBarrierCount;
	public VkImageMemoryBarrier2* ImageMemoryBarriers;
}
public unsafe struct VkSemaphoreSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkSemaphore Semaphore;
	public ulong Value;
	public VkPipelineStageFlags2 StageMask;
	public uint DeviceIndex;
}
public unsafe struct VkCommandBufferSubmitInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkCommandBuffer CommandBuffer;
	public uint DeviceMask;
}
public unsafe struct VkSubmitInfo2
{
	public VkStructureType SType;
	public void* Next;
	public VkSubmitFlags Flags;
	public uint WaitSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* WaitSemaphoreInfos;
	public uint CommandBufferInfoCount;
	public VkCommandBufferSubmitInfo* CommandBufferInfos;
	public uint SignalSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* SignalSemaphoreInfos;
}
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags2 CheckpointExecutionStageMask;
}
public unsafe struct VkCheckpointData2NV
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineStageFlags2 Stage;
	public void* CheckpointMarker;
}
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Synchronization2;
}
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PrimitivesGeneratedQuery;
	public VkBool32 PrimitivesGeneratedQueryWithRasterizerDiscard;
	public VkBool32 PrimitivesGeneratedQueryWithNonZeroStreams;
}
public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MultisampledRenderToSingleSampled;
}
public unsafe struct VkSubpassResolvePerformanceQueryEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Optimal;
}
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MultisampledRenderToSingleSampledEnable;
	public VkSampleCountFlags RasterizationSamples;
}
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 InheritedViewportScissor2D;
}
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ViewportScissor2D;
	public uint ViewportDepthCount;
	public VkViewport* ViewportDepths;
}
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 Ycbcr2plane444Formats;
}
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProvokingVertexLast;
	public VkBool32 TransformFeedbackPreservesProvokingVertex;
}
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ProvokingVertexModePerPipeline;
	public VkBool32 TransformFeedbackPreservesTriangleFanProvokingVertex;
}
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkProvokingVertexModeEXT ProvokingVertexMode;
}
public unsafe struct VkCuModuleCreateInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public nuint DataSize;
	public void* Data;
}
public unsafe struct VkCuFunctionCreateInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkCuModuleNVX Module;
	public byte* Name;
}
public unsafe struct VkCuLaunchInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkCuFunctionNVX Function;
	public uint GridDimX;
	public uint GridDimY;
	public uint GridDimZ;
	public uint BlockDimX;
	public uint BlockDimY;
	public uint BlockDimZ;
	public uint SharedMemBytes;
	public nuint ParamCount;
	public void** Params;
	public nuint ExtraCount;
	public void** Extras;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderIntegerDotProduct;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 IntegerDotProduct8BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct8BitSignedAccelerated;
	public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct16BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct16BitSignedAccelerated;
	public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct32BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct32BitSignedAccelerated;
	public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProduct64BitUnsignedAccelerated;
	public VkBool32 IntegerDotProduct64BitSignedAccelerated;
	public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 HasPrimary;
	public VkBool32 HasRender;
	public long PrimaryMajor;
	public long PrimaryMinor;
	public long RenderMajor;
	public long RenderMinor;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TriStripVertexOrderIndependentOfProvokingVertex;
}
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RayTracingMotionBlur;
	public VkBool32 RayTracingMotionBlurPipelineTraceRaysIndirect;
}
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceOrHostAddressConstKHR VertexData;
}
public unsafe struct VkAccelerationStructureMotionInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxInstances;
	public uint Flags;
}
public unsafe struct VkSRTDataNV
{
	public float Sx;
	public float A;
	public float B;
	public float Pvx;
	public float Sy;
	public float C;
	public float Pvy;
	public float Sz;
	public float Pvz;
	public float Qx;
	public float Qy;
	public float Qz;
	public float Qw;
	public float Tx;
	public float Ty;
	public float Tz;
}
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
	public VkSRTDataNV TransformT0;
	public VkSRTDataNV TransformT1;
	public uint InstanceCustomIndex;
	public uint Mask;
	public uint InstanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR Flags;
	public ulong AccelerationStructureReference;
}
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
	public VkTransformMatrixKHR TransformT0;
	public VkTransformMatrixKHR TransformT1;
	public uint InstanceCustomIndex;
	public uint Mask;
	public uint InstanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR Flags;
	public ulong AccelerationStructureReference;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
	[FieldOffset(0)]
	public VkAccelerationStructureInstanceKHR StaticInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
}
public unsafe struct VkAccelerationStructureMotionInstanceNV
{
	public VkAccelerationStructureMotionInstanceTypeNV Type;
	public uint Flags;
	public VkAccelerationStructureMotionInstanceDataNV Data;
}
public unsafe struct VkMemoryGetRemoteAddressInfoNV
{
	public VkStructureType SType;
	public void* Next;
	public VkDeviceMemory Memory;
	public VkExternalMemoryHandleTypeFlags HandleType;
}
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 FormatRgba10x6WithoutYCbCrSampler;
}
public unsafe struct VkFormatProperties3
{
	public VkStructureType SType;
	public void* Next;
	public VkFormatFeatureFlags2 LinearTilingFeatures;
	public VkFormatFeatureFlags2 OptimalTilingFeatures;
	public VkFormatFeatureFlags2 BufferFeatures;
}
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
	public VkStructureType SType;
	public void* Next;
	public uint DrmFormatModifierCount;
	public VkDrmFormatModifierProperties2EXT* DrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierProperties2EXT
{
	public ulong DrmFormatModifier;
	public uint DrmFormatModifierPlaneCount;
	public VkFormatFeatureFlags2 DrmFormatModifierTilingFeatures;
}
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
	public VkStructureType SType;
	public void* Next;
	public VkFormat Format;
	public ulong ExternalFormat;
	public VkFormatFeatureFlags2 FormatFeatures;
	public VkComponentMapping SamplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
	public VkSamplerYcbcrRange SuggestedYcbcrRange;
	public VkChromaLocation SuggestedXChromaOffset;
	public VkChromaLocation SuggestedYChromaOffset;
}
public unsafe struct VkPipelineRenderingCreateInfo
{
	public VkStructureType SType;
	public void* Next;
	public uint ViewMask;
	public uint ColorAttachmentCount;
	public VkFormat* ColorAttachmentFormats;
	public VkFormat DepthAttachmentFormat;
	public VkFormat StencilAttachmentFormat;
}
public unsafe struct VkRenderingInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderingFlags Flags;
	public VkRect2D RenderArea;
	public uint LayerCount;
	public uint ViewMask;
	public uint ColorAttachmentCount;
	public VkRenderingAttachmentInfo* ColorAttachments;
	public VkRenderingAttachmentInfo* DepthAttachment;
	public VkRenderingAttachmentInfo* StencilAttachment;
}
public unsafe struct VkRenderingAttachmentInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkImageView ImageView;
	public VkImageLayout ImageLayout;
	public VkResolveModeFlags ResolveMode;
	public VkImageView ResolveImageView;
	public VkImageLayout ResolveImageLayout;
	public VkAttachmentLoadOp LoadOp;
	public VkAttachmentStoreOp StoreOp;
	public VkClearValue ClearValue;
}
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType SType;
	public void* Next;
	public VkImageView ImageView;
	public VkImageLayout ImageLayout;
	public VkExtent2D ShadingRateAttachmentTexelSize;
}
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageView ImageView;
	public VkImageLayout ImageLayout;
}
public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DynamicRendering;
}
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderingFlags Flags;
	public uint ViewMask;
	public uint ColorAttachmentCount;
	public VkFormat* ColorAttachmentFormats;
	public VkFormat DepthAttachmentFormat;
	public VkFormat StencilAttachmentFormat;
	public VkSampleCountFlags RasterizationSamples;
}
public unsafe struct VkAttachmentSampleCountInfoAMD
{
	public VkStructureType SType;
	public void* Next;
	public uint ColorAttachmentCount;
	public VkSampleCountFlags* ColorAttachmentSamples;
	public VkSampleCountFlags DepthStencilAttachmentSamples;
}
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PerViewAttributes;
	public VkBool32 PerViewAttributesPositionXOnly;
}
public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 MinLod;
}
public unsafe struct VkImageViewMinLodCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public float MinLod;
}
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 RasterizationOrderColorAttachmentAccess;
	public VkBool32 RasterizationOrderDepthAttachmentAccess;
	public VkBool32 RasterizationOrderStencilAttachmentAccess;
}
public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 LinearColorAttachment;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 GraphicsPipelineLibrary;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 GraphicsPipelineLibraryFastLinking;
	public VkBool32 GraphicsPipelineLibraryIndependentInterpolationDecoration;
}
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkGraphicsPipelineLibraryFlagsEXT Flags;
}
public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DescriptorSetHostMapping;
}
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
	public VkStructureType SType;
	public void* Next;
	public VkDescriptorSetLayout DescriptorSetLayout;
	public uint Binding;
}
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
	public VkStructureType SType;
	public void* Next;
	public nuint DescriptorOffset;
	public uint DescriptorSize;
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderModuleIdentifier;
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte ShaderModuleIdentifierAlgorithmUUID[(int)VK.UuidSize];
}
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint IdentifierSize;
	public byte* Identifier;
}
public unsafe struct VkShaderModuleIdentifierEXT
{
	public VkStructureType SType;
	public void* Next;
	public uint IdentifierSize;
	public fixed byte Identifier[(int)VK.MaxShaderModuleIdentifierSizeExt];
}
public unsafe struct VkImageCompressionControlEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageCompressionFlagsEXT Flags;
	public uint CompressionControlPlaneCount;
	public VkImageCompressionFixedRateFlagsEXT* FixedRateFlags;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImageCompressionControl;
}
public unsafe struct VkImageCompressionPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageCompressionFlagsEXT ImageCompressionFlags;
	public VkImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ImageCompressionControlSwapchain;
}
public unsafe struct VkImageSubresource2EXT
{
	public VkStructureType SType;
	public void* Next;
	public VkImageSubresource ImageSubresource;
}
public unsafe struct VkSubresourceLayout2EXT
{
	public VkStructureType SType;
	public void* Next;
	public VkSubresourceLayout SubresourceLayout;
}
public unsafe struct VkRenderPassCreationControlEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DisallowMerging;
}
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
	public uint PostMergeSubpassCount;
}
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPassCreationFeedbackInfoEXT* RenderPassFeedback;
}
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
	public VkSubpassMergeStatusEXT SubpassMergeStatus;
	public fixed byte Description[(int)VK.MaxDescriptionSize];
	public uint PostMergeIndex;
}
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkRenderPassSubpassFeedbackInfoEXT* SubpassFeedback;
}
public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 SubpassMergeFeedback;
}
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
	public VkStructureType SType;
	public void* Next;
	public fixed byte PipelineIdentifier[(int)VK.UuidSize];
}
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelinePropertiesIdentifier;
}
public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 ShaderEarlyAndLateFragmentTests;
}
public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 NonSeamlessCubeMap;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 PipelineRobustness;
}
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRobustnessBufferBehaviorEXT StorageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT UniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT VertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT Images;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessStorageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessUniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessVertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT DefaultRobustnessImages;
}
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkOffset2D FilterCenter;
	public VkExtent2D FilterSize;
	public uint NumPhases;
}
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TextureSampleWeighted;
	public VkBool32 TextureBoxFilter;
	public VkBool32 TextureBlockMatch;
}
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public uint MaxWeightFilterPhases;
	public VkExtent2D MaxWeightFilterDimension;
	public VkExtent2D MaxBlockMatchRegion;
	public VkExtent2D MaxBoxFilterBlockSize;
}
public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 TileProperties;
}
public unsafe struct VkTilePropertiesQCOM
{
	public VkStructureType SType;
	public void* Next;
	public VkExtent3D TileSize;
	public VkExtent2D ApronSize;
	public VkOffset2D Origin;
}
public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AmigoProfiling;
}
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
	public VkStructureType SType;
	public void* Next;
	public ulong FirstDrawTimestamp;
	public ulong SwapBufferTimestamp;
}
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 AttachmentFeedbackLoopLayout;
}
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
	public VkStructureType SType;
	public void* Next;
	public VkBool32 DepthClampZeroOne;
}
