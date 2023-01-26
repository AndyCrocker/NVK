// This file was generated, don't manually edit
namespace Vulkan_1_3;

public unsafe struct VkExtent2D
{
	public uint width;
	public uint height;
}
public unsafe struct VkExtent3D
{
	public uint width;
	public uint height;
	public uint depth;
}
public unsafe struct VkOffset2D
{
	public int x;
	public int y;
}
public unsafe struct VkOffset3D
{
	public int x;
	public int y;
	public int z;
}
public unsafe struct VkRect2D
{
	public VkOffset2D offset;
	public VkExtent2D extent;
}
public unsafe struct VkBaseInStructure
{
	public VkStructureType sType;
	public VkBaseInStructure* pNext;
}
public unsafe struct VkBaseOutStructure
{
	public VkStructureType sType;
	public VkBaseOutStructure* pNext;
}
public unsafe struct VkBufferMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkDispatchIndirectCommand
{
	public uint x;
	public uint y;
	public uint z;
}
public unsafe struct VkDrawIndexedIndirectCommand
{
	public uint indexCount;
	public uint instanceCount;
	public uint firstIndex;
	public int vertexOffset;
	public uint firstInstance;
}
public unsafe struct VkDrawIndirectCommand
{
	public uint vertexCount;
	public uint instanceCount;
	public uint firstVertex;
	public uint firstInstance;
}
public unsafe struct VkImageMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkImageSubresourceRange
{
	public VkImageAspectFlags aspectMask;
	public uint baseMipLevel;
	public uint levelCount;
	public uint baseArrayLayer;
	public uint layerCount;
}
public unsafe struct VkMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
}
public unsafe struct VkPipelineCacheHeaderVersionOne
{
	public uint headerSize;
	public VkPipelineCacheHeaderVersion headerVersion;
	public uint vendorID;
	public uint deviceID;
	public fixed byte pipelineCacheUUID[(int)VK.UuidSize];
}
public unsafe struct VkInstanceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkInstanceCreateFlags flags;
	public VkApplicationInfo* pApplicationInfo;
	public uint enabledLayerCount;
	public byte** ppEnabledLayerNames;
	public uint enabledExtensionCount;
	public byte** ppEnabledExtensionNames;
}
public unsafe struct VkApplicationInfo
{
	public VkStructureType sType;
	public void* pNext;
	public byte* pApplicationName;
	public uint applicationVersion;
	public byte* pEngineName;
	public uint engineVersion;
	public uint apiVersion;
}
public unsafe struct VkAllocationCallbacks
{
	public void* pUserData;
	public AllocationFunctionDelegate pfnAllocation;
	public ReallocationFunctionDelegate pfnReallocation;
	public FreeFunctionDelegate pfnFree;
	public InternalAllocationNotificationDelegate pfnInternalAllocation;
	public InternalFreeNotificationDelegate pfnInternalFree;
}
public unsafe struct VkPhysicalDeviceFeatures
{
	public VkBool32 robustBufferAccess;
	public VkBool32 fullDrawIndexUint32;
	public VkBool32 imageCubeArray;
	public VkBool32 independentBlend;
	public VkBool32 geometryShader;
	public VkBool32 tessellationShader;
	public VkBool32 sampleRateShading;
	public VkBool32 dualSrcBlend;
	public VkBool32 logicOp;
	public VkBool32 multiDrawIndirect;
	public VkBool32 drawIndirectFirstInstance;
	public VkBool32 depthClamp;
	public VkBool32 depthBiasClamp;
	public VkBool32 fillModeNonSolid;
	public VkBool32 depthBounds;
	public VkBool32 wideLines;
	public VkBool32 largePoints;
	public VkBool32 alphaToOne;
	public VkBool32 multiViewport;
	public VkBool32 samplerAnisotropy;
	public VkBool32 textureCompressionETC2;
	public VkBool32 textureCompressionASTC_LDR;
	public VkBool32 textureCompressionBC;
	public VkBool32 occlusionQueryPrecise;
	public VkBool32 pipelineStatisticsQuery;
	public VkBool32 vertexPipelineStoresAndAtomics;
	public VkBool32 fragmentStoresAndAtomics;
	public VkBool32 shaderTessellationAndGeometryPointSize;
	public VkBool32 shaderImageGatherExtended;
	public VkBool32 shaderStorageImageExtendedFormats;
	public VkBool32 shaderStorageImageMultisample;
	public VkBool32 shaderStorageImageReadWithoutFormat;
	public VkBool32 shaderStorageImageWriteWithoutFormat;
	public VkBool32 shaderUniformBufferArrayDynamicIndexing;
	public VkBool32 shaderSampledImageArrayDynamicIndexing;
	public VkBool32 shaderStorageBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageImageArrayDynamicIndexing;
	public VkBool32 shaderClipDistance;
	public VkBool32 shaderCullDistance;
	public VkBool32 shaderFloat64;
	public VkBool32 shaderInt64;
	public VkBool32 shaderInt16;
	public VkBool32 shaderResourceResidency;
	public VkBool32 shaderResourceMinLod;
	public VkBool32 sparseBinding;
	public VkBool32 sparseResidencyBuffer;
	public VkBool32 sparseResidencyImage2D;
	public VkBool32 sparseResidencyImage3D;
	public VkBool32 sparseResidency2Samples;
	public VkBool32 sparseResidency4Samples;
	public VkBool32 sparseResidency8Samples;
	public VkBool32 sparseResidency16Samples;
	public VkBool32 sparseResidencyAliased;
	public VkBool32 variableMultisampleRate;
	public VkBool32 inheritedQueries;
}
public unsafe struct VkFormatProperties
{
	public VkFormatFeatureFlags linearTilingFeatures;
	public VkFormatFeatureFlags optimalTilingFeatures;
	public VkFormatFeatureFlags bufferFeatures;
}
public unsafe struct VkImageFormatProperties
{
	public VkExtent3D maxExtent;
	public uint maxMipLevels;
	public uint maxArrayLayers;
	public VkSampleCountFlags sampleCounts;
	public VkDeviceSize maxResourceSize;
}
public unsafe struct VkPhysicalDeviceProperties
{
	public uint apiVersion;
	public uint driverVersion;
	public uint vendorID;
	public uint deviceID;
	public VkPhysicalDeviceType deviceType;
	public fixed byte deviceName[(int)VK.MaxPhysicalDeviceNameSize];
	public fixed byte pipelineCacheUUID[(int)VK.UuidSize];
	public VkPhysicalDeviceLimits limits;
	public VkPhysicalDeviceSparseProperties sparseProperties;
}
public unsafe struct VkPhysicalDeviceLimits
{
	public uint maxImageDimension1D;
	public uint maxImageDimension2D;
	public uint maxImageDimension3D;
	public uint maxImageDimensionCube;
	public uint maxImageArrayLayers;
	public uint maxTexelBufferElements;
	public uint maxUniformBufferRange;
	public uint maxStorageBufferRange;
	public uint maxPushConstantsSize;
	public uint maxMemoryAllocationCount;
	public uint maxSamplerAllocationCount;
	public VkDeviceSize bufferImageGranularity;
	public VkDeviceSize sparseAddressSpaceSize;
	public uint maxBoundDescriptorSets;
	public uint maxPerStageDescriptorSamplers;
	public uint maxPerStageDescriptorUniformBuffers;
	public uint maxPerStageDescriptorStorageBuffers;
	public uint maxPerStageDescriptorSampledImages;
	public uint maxPerStageDescriptorStorageImages;
	public uint maxPerStageDescriptorInputAttachments;
	public uint maxPerStageResources;
	public uint maxDescriptorSetSamplers;
	public uint maxDescriptorSetUniformBuffers;
	public uint maxDescriptorSetUniformBuffersDynamic;
	public uint maxDescriptorSetStorageBuffers;
	public uint maxDescriptorSetStorageBuffersDynamic;
	public uint maxDescriptorSetSampledImages;
	public uint maxDescriptorSetStorageImages;
	public uint maxDescriptorSetInputAttachments;
	public uint maxVertexInputAttributes;
	public uint maxVertexInputBindings;
	public uint maxVertexInputAttributeOffset;
	public uint maxVertexInputBindingStride;
	public uint maxVertexOutputComponents;
	public uint maxTessellationGenerationLevel;
	public uint maxTessellationPatchSize;
	public uint maxTessellationControlPerVertexInputComponents;
	public uint maxTessellationControlPerVertexOutputComponents;
	public uint maxTessellationControlPerPatchOutputComponents;
	public uint maxTessellationControlTotalOutputComponents;
	public uint maxTessellationEvaluationInputComponents;
	public uint maxTessellationEvaluationOutputComponents;
	public uint maxGeometryShaderInvocations;
	public uint maxGeometryInputComponents;
	public uint maxGeometryOutputComponents;
	public uint maxGeometryOutputVertices;
	public uint maxGeometryTotalOutputComponents;
	public uint maxFragmentInputComponents;
	public uint maxFragmentOutputAttachments;
	public uint maxFragmentDualSrcAttachments;
	public uint maxFragmentCombinedOutputResources;
	public uint maxComputeSharedMemorySize;
	public fixed uint maxComputeWorkGroupCount[3];
	public uint maxComputeWorkGroupInvocations;
	public fixed uint maxComputeWorkGroupSize[3];
	public uint subPixelPrecisionBits;
	public uint subTexelPrecisionBits;
	public uint mipmapPrecisionBits;
	public uint maxDrawIndexedIndexValue;
	public uint maxDrawIndirectCount;
	public float maxSamplerLodBias;
	public float maxSamplerAnisotropy;
	public uint maxViewports;
	public fixed uint maxViewportDimensions[2];
	public fixed float viewportBoundsRange[2];
	public uint viewportSubPixelBits;
	public nuint minMemoryMapAlignment;
	public VkDeviceSize minTexelBufferOffsetAlignment;
	public VkDeviceSize minUniformBufferOffsetAlignment;
	public VkDeviceSize minStorageBufferOffsetAlignment;
	public int minTexelOffset;
	public uint maxTexelOffset;
	public int minTexelGatherOffset;
	public uint maxTexelGatherOffset;
	public float minInterpolationOffset;
	public float maxInterpolationOffset;
	public uint subPixelInterpolationOffsetBits;
	public uint maxFramebufferWidth;
	public uint maxFramebufferHeight;
	public uint maxFramebufferLayers;
	public VkSampleCountFlags framebufferColorSampleCounts;
	public VkSampleCountFlags framebufferDepthSampleCounts;
	public VkSampleCountFlags framebufferStencilSampleCounts;
	public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
	public uint maxColorAttachments;
	public VkSampleCountFlags sampledImageColorSampleCounts;
	public VkSampleCountFlags sampledImageIntegerSampleCounts;
	public VkSampleCountFlags sampledImageDepthSampleCounts;
	public VkSampleCountFlags sampledImageStencilSampleCounts;
	public VkSampleCountFlags storageImageSampleCounts;
	public uint maxSampleMaskWords;
	public VkBool32 timestampComputeAndGraphics;
	public float timestampPeriod;
	public uint maxClipDistances;
	public uint maxCullDistances;
	public uint maxCombinedClipAndCullDistances;
	public uint discreteQueuePriorities;
	public fixed float pointSizeRange[2];
	public fixed float lineWidthRange[2];
	public float pointSizeGranularity;
	public float lineWidthGranularity;
	public VkBool32 strictLines;
	public VkBool32 standardSampleLocations;
	public VkDeviceSize optimalBufferCopyOffsetAlignment;
	public VkDeviceSize optimalBufferCopyRowPitchAlignment;
	public VkDeviceSize nonCoherentAtomSize;
}
public unsafe struct VkPhysicalDeviceSparseProperties
{
	public VkBool32 residencyStandard2DBlockShape;
	public VkBool32 residencyStandard2DMultisampleBlockShape;
	public VkBool32 residencyStandard3DBlockShape;
	public VkBool32 residencyAlignedMipSize;
	public VkBool32 residencyNonResidentStrict;
}
public unsafe struct VkQueueFamilyProperties
{
	public VkQueueFlags queueFlags;
	public uint queueCount;
	public uint timestampValidBits;
	public VkExtent3D minImageTransferGranularity;
}
public unsafe struct VkPhysicalDeviceMemoryProperties
{
	public uint memoryTypeCount;
	public VkMemoryType memoryTypes_0;
	public VkMemoryType memoryTypes_1;
	public VkMemoryType memoryTypes_2;
	public VkMemoryType memoryTypes_3;
	public VkMemoryType memoryTypes_4;
	public VkMemoryType memoryTypes_5;
	public VkMemoryType memoryTypes_6;
	public VkMemoryType memoryTypes_7;
	public VkMemoryType memoryTypes_8;
	public VkMemoryType memoryTypes_9;
	public VkMemoryType memoryTypes_10;
	public VkMemoryType memoryTypes_11;
	public VkMemoryType memoryTypes_12;
	public VkMemoryType memoryTypes_13;
	public VkMemoryType memoryTypes_14;
	public VkMemoryType memoryTypes_15;
	public VkMemoryType memoryTypes_16;
	public VkMemoryType memoryTypes_17;
	public VkMemoryType memoryTypes_18;
	public VkMemoryType memoryTypes_19;
	public VkMemoryType memoryTypes_20;
	public VkMemoryType memoryTypes_21;
	public VkMemoryType memoryTypes_22;
	public VkMemoryType memoryTypes_23;
	public VkMemoryType memoryTypes_24;
	public VkMemoryType memoryTypes_25;
	public VkMemoryType memoryTypes_26;
	public VkMemoryType memoryTypes_27;
	public VkMemoryType memoryTypes_28;
	public VkMemoryType memoryTypes_29;
	public VkMemoryType memoryTypes_30;
	public VkMemoryType memoryTypes_31;
	public uint memoryHeapCount;
	public VkMemoryHeap memoryHeaps_0;
	public VkMemoryHeap memoryHeaps_1;
	public VkMemoryHeap memoryHeaps_2;
	public VkMemoryHeap memoryHeaps_3;
	public VkMemoryHeap memoryHeaps_4;
	public VkMemoryHeap memoryHeaps_5;
	public VkMemoryHeap memoryHeaps_6;
	public VkMemoryHeap memoryHeaps_7;
	public VkMemoryHeap memoryHeaps_8;
	public VkMemoryHeap memoryHeaps_9;
	public VkMemoryHeap memoryHeaps_10;
	public VkMemoryHeap memoryHeaps_11;
	public VkMemoryHeap memoryHeaps_12;
	public VkMemoryHeap memoryHeaps_13;
	public VkMemoryHeap memoryHeaps_14;
	public VkMemoryHeap memoryHeaps_15;
}
public unsafe struct VkMemoryType
{
	public VkMemoryPropertyFlags propertyFlags;
	public uint heapIndex;
}
public unsafe struct VkMemoryHeap
{
	public VkDeviceSize size;
	public VkMemoryHeapFlags flags;
}
public unsafe struct VkDeviceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceCreateFlags flags;
	public uint queueCreateInfoCount;
	public VkDeviceQueueCreateInfo* pQueueCreateInfos;
	public uint enabledLayerCount;
	public byte** ppEnabledLayerNames;
	public uint enabledExtensionCount;
	public byte** ppEnabledExtensionNames;
	public VkPhysicalDeviceFeatures* pEnabledFeatures;
}
public unsafe struct VkDeviceQueueCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint queueFamilyIndex;
	public uint queueCount;
	public float* pQueuePriorities;
}
public unsafe struct VkExtensionProperties
{
	public fixed byte extensionName[(int)VK.MaxExtensionNameSize];
	public uint specVersion;
}
public unsafe struct VkLayerProperties
{
	public fixed byte layerName[(int)VK.MaxExtensionNameSize];
	public uint specVersion;
	public uint implementationVersion;
	public fixed byte description[(int)VK.MaxDescriptionSize];
}
public unsafe struct VkSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public VkPipelineStageFlags* pWaitDstStageMask;
	public uint commandBufferCount;
	public VkCommandBuffer* pCommandBuffers;
	public uint signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkMemoryAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint memoryTypeIndex;
}
public unsafe struct VkMappedMemoryRange
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkMemoryRequirements
{
	public VkDeviceSize size;
	public VkDeviceSize alignment;
	public uint memoryTypeBits;
}
public unsafe struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties formatProperties;
	public uint imageMipTailFirstLod;
	public VkDeviceSize imageMipTailSize;
	public VkDeviceSize imageMipTailOffset;
	public VkDeviceSize imageMipTailStride;
}
public unsafe struct VkSparseImageFormatProperties
{
	public VkImageAspectFlags aspectMask;
	public VkExtent3D imageGranularity;
	public VkSparseImageFormatFlags flags;
}
public unsafe struct VkBindSparseInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint bufferBindCount;
	public VkSparseBufferMemoryBindInfo* pBufferBinds;
	public uint imageOpaqueBindCount;
	public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
	public uint imageBindCount;
	public VkSparseImageMemoryBindInfo* pImageBinds;
	public uint signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer buffer;
	public uint bindCount;
	public VkSparseMemoryBind* pBinds;
}
public unsafe struct VkSparseMemoryBind
{
	public VkDeviceSize resourceOffset;
	public VkDeviceSize size;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkSparseMemoryBindFlags flags;
}
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
	public VkImage image;
	public uint bindCount;
	public VkSparseMemoryBind* pBinds;
}
public unsafe struct VkSparseImageMemoryBindInfo
{
	public VkImage image;
	public uint bindCount;
	public VkSparseImageMemoryBind* pBinds;
}
public unsafe struct VkSparseImageMemoryBind
{
	public VkImageSubresource subresource;
	public VkOffset3D offset;
	public VkExtent3D extent;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkSparseMemoryBindFlags flags;
}
public unsafe struct VkImageSubresource
{
	public VkImageAspectFlags aspectMask;
	public uint mipLevel;
	public uint arrayLayer;
}
public unsafe struct VkFenceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFenceCreateFlags flags;
}
public unsafe struct VkSemaphoreCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreCreateFlags flags;
}
public unsafe struct VkEventCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkEventCreateFlags flags;
}
public unsafe struct VkQueryPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolCreateFlags flags;
	public VkQueryType queryType;
	public uint queryCount;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}
public unsafe struct VkBufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkDeviceSize size;
	public VkBufferUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public uint* pQueueFamilyIndices;
}
public unsafe struct VkBufferViewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferViewCreateFlags flags;
	public VkBuffer buffer;
	public VkFormat format;
	public VkDeviceSize offset;
	public VkDeviceSize range;
}
public unsafe struct VkImageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageType imageType;
	public VkFormat format;
	public VkExtent3D extent;
	public uint mipLevels;
	public uint arrayLayers;
	public VkSampleCountFlags samples;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public uint* pQueueFamilyIndices;
	public VkImageLayout initialLayout;
}
public unsafe struct VkSubresourceLayout
{
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkDeviceSize rowPitch;
	public VkDeviceSize arrayPitch;
	public VkDeviceSize depthPitch;
}
public unsafe struct VkImageViewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageViewCreateFlags flags;
	public VkImage image;
	public VkImageViewType viewType;
	public VkFormat format;
	public VkComponentMapping components;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkComponentMapping
{
	public VkComponentSwizzle r;
	public VkComponentSwizzle g;
	public VkComponentSwizzle b;
	public VkComponentSwizzle a;
}
public unsafe struct VkShaderModuleCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderModuleCreateFlags flags;
	public nuint codeSize;
	public uint* pCode;
}
public unsafe struct VkPipelineCacheCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCacheCreateFlags flags;
	public nuint initialDataSize;
	public void* pInitialData;
}
public unsafe struct VkGraphicsPipelineCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
	public VkPipelineTessellationStateCreateInfo* pTessellationState;
	public VkPipelineViewportStateCreateInfo* pViewportState;
	public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
	public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
	public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
	public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
	public VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkRenderPass renderPass;
	public uint subpass;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}
public unsafe struct VkPipelineShaderStageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineShaderStageCreateFlags flags;
	public VkShaderStageFlags stage;
	public VkShaderModule module;
	public byte* pName;
	public VkSpecializationInfo* pSpecializationInfo;
}
public unsafe struct VkSpecializationInfo
{
	public uint mapEntryCount;
	public VkSpecializationMapEntry* pMapEntries;
	public nuint dataSize;
	public void* pData;
}
public unsafe struct VkSpecializationMapEntry
{
	public uint constantID;
	public uint offset;
	public nuint size;
}
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineVertexInputStateCreateFlags flags;
	public uint vertexBindingDescriptionCount;
	public VkVertexInputBindingDescription* pVertexBindingDescriptions;
	public uint vertexAttributeDescriptionCount;
	public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
}
public unsafe struct VkVertexInputBindingDescription
{
	public uint binding;
	public uint stride;
	public VkVertexInputRate inputRate;
}
public unsafe struct VkVertexInputAttributeDescription
{
	public uint location;
	public uint binding;
	public VkFormat format;
	public uint offset;
}
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineInputAssemblyStateCreateFlags flags;
	public VkPrimitiveTopology topology;
	public VkBool32 primitiveRestartEnable;
}
public unsafe struct VkPipelineTessellationStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineTessellationStateCreateFlags flags;
	public uint patchControlPoints;
}
public unsafe struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineViewportStateCreateFlags flags;
	public uint viewportCount;
	public VkViewport* pViewports;
	public uint scissorCount;
	public VkRect2D* pScissors;
}
public unsafe struct VkViewport
{
	public float x;
	public float y;
	public float width;
	public float height;
	public float minDepth;
	public float maxDepth;
}
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationStateCreateFlags flags;
	public VkBool32 depthClampEnable;
	public VkBool32 rasterizerDiscardEnable;
	public VkPolygonMode polygonMode;
	public VkCullModeFlags cullMode;
	public VkFrontFace frontFace;
	public VkBool32 depthBiasEnable;
	public float depthBiasConstantFactor;
	public float depthBiasClamp;
	public float depthBiasSlopeFactor;
	public float lineWidth;
}
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineMultisampleStateCreateFlags flags;
	public VkSampleCountFlags rasterizationSamples;
	public VkBool32 sampleShadingEnable;
	public float minSampleShading;
	public uint* pSampleMask;
	public VkBool32 alphaToCoverageEnable;
	public VkBool32 alphaToOneEnable;
}
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDepthStencilStateCreateFlags flags;
	public VkBool32 depthTestEnable;
	public VkBool32 depthWriteEnable;
	public VkCompareOp depthCompareOp;
	public VkBool32 depthBoundsTestEnable;
	public VkBool32 stencilTestEnable;
	public VkStencilOpState front;
	public VkStencilOpState back;
	public float minDepthBounds;
	public float maxDepthBounds;
}
public unsafe struct VkStencilOpState
{
	public VkStencilOp failOp;
	public VkStencilOp passOp;
	public VkStencilOp depthFailOp;
	public VkCompareOp compareOp;
	public uint compareMask;
	public uint writeMask;
	public uint reference;
}
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineColorBlendStateCreateFlags flags;
	public VkBool32 logicOpEnable;
	public VkLogicOp logicOp;
	public uint attachmentCount;
	public VkPipelineColorBlendAttachmentState* pAttachments;
	public fixed float blendConstants[4];
}
public unsafe struct VkPipelineColorBlendAttachmentState
{
	public VkBool32 blendEnable;
	public VkBlendFactor srcColorBlendFactor;
	public VkBlendFactor dstColorBlendFactor;
	public VkBlendOp colorBlendOp;
	public VkBlendFactor srcAlphaBlendFactor;
	public VkBlendFactor dstAlphaBlendFactor;
	public VkBlendOp alphaBlendOp;
	public VkColorComponentFlags colorWriteMask;
}
public unsafe struct VkPipelineDynamicStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDynamicStateCreateFlags flags;
	public uint dynamicStateCount;
	public VkDynamicState* pDynamicStates;
}
public unsafe struct VkComputePipelineCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public VkPipelineShaderStageCreateInfo stage;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}
public unsafe struct VkPipelineLayoutCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineLayoutCreateFlags flags;
	public uint setLayoutCount;
	public VkDescriptorSetLayout* pSetLayouts;
	public uint pushConstantRangeCount;
	public VkPushConstantRange* pPushConstantRanges;
}
public unsafe struct VkPushConstantRange
{
	public VkShaderStageFlags stageFlags;
	public uint offset;
	public uint size;
}
public unsafe struct VkSamplerCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerCreateFlags flags;
	public VkFilter magFilter;
	public VkFilter minFilter;
	public VkSamplerMipmapMode mipmapMode;
	public VkSamplerAddressMode addressModeU;
	public VkSamplerAddressMode addressModeV;
	public VkSamplerAddressMode addressModeW;
	public float mipLodBias;
	public VkBool32 anisotropyEnable;
	public float maxAnisotropy;
	public VkBool32 compareEnable;
	public VkCompareOp compareOp;
	public float minLod;
	public float maxLod;
	public VkBorderColor borderColor;
	public VkBool32 unnormalizedCoordinates;
}
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSetLayoutCreateFlags flags;
	public uint bindingCount;
	public VkDescriptorSetLayoutBinding* pBindings;
}
public unsafe struct VkDescriptorSetLayoutBinding
{
	public uint binding;
	public VkDescriptorType descriptorType;
	public uint descriptorCount;
	public VkShaderStageFlags stageFlags;
	public VkSampler* pImmutableSamplers;
}
public unsafe struct VkDescriptorPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPoolCreateFlags flags;
	public uint maxSets;
	public uint poolSizeCount;
	public VkDescriptorPoolSize* pPoolSizes;
}
public unsafe struct VkDescriptorPoolSize
{
	public VkDescriptorType type;
	public uint descriptorCount;
}
public unsafe struct VkDescriptorSetAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPool descriptorPool;
	public uint descriptorSetCount;
	public VkDescriptorSetLayout* pSetLayouts;
}
public unsafe struct VkWriteDescriptorSet
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSet dstSet;
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public VkDescriptorImageInfo* pImageInfo;
	public VkDescriptorBufferInfo* pBufferInfo;
	public VkBufferView* pTexelBufferView;
}
public unsafe struct VkDescriptorImageInfo
{
	public VkSampler sampler;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}
public unsafe struct VkDescriptorBufferInfo
{
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize range;
}
public unsafe struct VkCopyDescriptorSet
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSet srcSet;
	public uint srcBinding;
	public uint srcArrayElement;
	public VkDescriptorSet dstSet;
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
}
public unsafe struct VkFramebufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFramebufferCreateFlags flags;
	public VkRenderPass renderPass;
	public uint attachmentCount;
	public VkImageView* pAttachments;
	public uint width;
	public uint height;
	public uint layers;
}
public unsafe struct VkRenderPassCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public VkAttachmentDescription* pAttachments;
	public uint subpassCount;
	public VkSubpassDescription* pSubpasses;
	public uint dependencyCount;
	public VkSubpassDependency* pDependencies;
}
public unsafe struct VkAttachmentDescription
{
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlags samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
public unsafe struct VkSubpassDescription
{
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint inputAttachmentCount;
	public VkAttachmentReference* pInputAttachments;
	public uint colorAttachmentCount;
	public VkAttachmentReference* pColorAttachments;
	public VkAttachmentReference* pResolveAttachments;
	public VkAttachmentReference* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public uint* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference
{
	public uint attachment;
	public VkImageLayout layout;
}
public unsafe struct VkSubpassDependency
{
	public uint srcSubpass;
	public uint dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
}
public unsafe struct VkCommandPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandPoolCreateFlags flags;
	public uint queueFamilyIndex;
}
public unsafe struct VkCommandBufferAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandPool commandPool;
	public VkCommandBufferLevel level;
	public uint commandBufferCount;
}
public unsafe struct VkCommandBufferBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBufferUsageFlags flags;
	public VkCommandBufferInheritanceInfo* pInheritanceInfo;
}
public unsafe struct VkCommandBufferInheritanceInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public uint subpass;
	public VkFramebuffer framebuffer;
	public VkBool32 occlusionQueryEnable;
	public VkQueryControlFlags queryFlags;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}
public unsafe struct VkBufferCopy
{
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
public unsafe struct VkImageCopy
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkImageSubresourceLayers
{
	public VkImageAspectFlags aspectMask;
	public uint mipLevel;
	public uint baseArrayLayer;
	public uint layerCount;
}
public unsafe struct VkImageBlit
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
public unsafe struct VkBufferImageCopy
{
	public VkDeviceSize bufferOffset;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
	[FieldOffset(0)]
	public fixed float float32[4];
	[FieldOffset(0)]
	public fixed int int32[4];
	[FieldOffset(0)]
	public fixed uint uint32[4];
}
public unsafe struct VkClearDepthStencilValue
{
	public float depth;
	public uint stencil;
}
public unsafe struct VkClearAttachment
{
	public VkImageAspectFlags aspectMask;
	public uint colorAttachment;
	public VkClearValue clearValue;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearValue
{
	[FieldOffset(0)]
	public VkClearColorValue color;
	[FieldOffset(0)]
	public VkClearDepthStencilValue depthStencil;
}
public unsafe struct VkClearRect
{
	public VkRect2D rect;
	public uint baseArrayLayer;
	public uint layerCount;
}
public unsafe struct VkImageResolve
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkRenderPassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public VkFramebuffer framebuffer;
	public VkRect2D renderArea;
	public uint clearValueCount;
	public VkClearValue* pClearValues;
}
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint subgroupSize;
	public VkShaderStageFlags supportedStages;
	public VkSubgroupFeatureFlags supportedOperations;
	public VkBool32 quadOperationsInAllStages;
}
public unsafe struct VkBindBufferMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkBindImageMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
}
public unsafe struct VkMemoryDedicatedRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}
public unsafe struct VkMemoryDedicatedAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkMemoryAllocateFlagsInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint deviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
	public uint deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreCount;
	public uint* pWaitSemaphoreDeviceIndices;
	public uint commandBufferCount;
	public uint* pCommandBufferDeviceMasks;
	public uint signalSemaphoreCount;
	public uint* pSignalSemaphoreDeviceIndices;
}
public unsafe struct VkDeviceGroupBindSparseInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint resourceDeviceIndex;
	public uint memoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
	public uint splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkPhysicalDeviceGroupProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice physicalDevices_0;
	public VkPhysicalDevice physicalDevices_1;
	public VkPhysicalDevice physicalDevices_2;
	public VkPhysicalDevice physicalDevices_3;
	public VkPhysicalDevice physicalDevices_4;
	public VkPhysicalDevice physicalDevices_5;
	public VkPhysicalDevice physicalDevices_6;
	public VkPhysicalDevice physicalDevices_7;
	public VkPhysicalDevice physicalDevices_8;
	public VkPhysicalDevice physicalDevices_9;
	public VkPhysicalDevice physicalDevices_10;
	public VkPhysicalDevice physicalDevices_11;
	public VkPhysicalDevice physicalDevices_12;
	public VkPhysicalDevice physicalDevices_13;
	public VkPhysicalDevice physicalDevices_14;
	public VkPhysicalDevice physicalDevices_15;
	public VkPhysicalDevice physicalDevices_16;
	public VkPhysicalDevice physicalDevices_17;
	public VkPhysicalDevice physicalDevices_18;
	public VkPhysicalDevice physicalDevices_19;
	public VkPhysicalDevice physicalDevices_20;
	public VkPhysicalDevice physicalDevices_21;
	public VkPhysicalDevice physicalDevices_22;
	public VkPhysicalDevice physicalDevices_23;
	public VkPhysicalDevice physicalDevices_24;
	public VkPhysicalDevice physicalDevices_25;
	public VkPhysicalDevice physicalDevices_26;
	public VkPhysicalDevice physicalDevices_27;
	public VkPhysicalDevice physicalDevices_28;
	public VkPhysicalDevice physicalDevices_29;
	public VkPhysicalDevice physicalDevices_30;
	public VkPhysicalDevice physicalDevices_31;
	public VkBool32 subsetAllocation;
}
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice* pPhysicalDevices;
}
public unsafe struct VkImageMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkMemoryRequirements2
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
}
public unsafe struct VkBufferMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkSparseImageMemoryRequirements2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}
public unsafe struct VkPhysicalDeviceFeatures2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceFeatures features;
}
public unsafe struct VkPhysicalDeviceProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceProperties properties;
}
public unsafe struct VkFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatProperties formatProperties;
}
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkImageCreateFlags flags;
}
public unsafe struct VkImageFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}
public unsafe struct VkQueueFamilyProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlags samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
public unsafe struct VkSparseImageFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageFormatProperties properties;
}
public unsafe struct VkPhysicalDevicePointClippingProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkPointClippingBehavior pointClippingBehavior;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
public unsafe struct VkInputAttachmentAspectReference
{
	public uint subpass;
	public uint inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkImageViewUsageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags usage;
}
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkTessellationDomainOrigin domainOrigin;
}
public unsafe struct VkRenderPassMultiviewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint subpassCount;
	public uint* pViewMasks;
	public uint dependencyCount;
	public int* pViewOffsets;
	public uint correlationMaskCount;
	public uint* pCorrelationMasks;
}
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxMultiviewViewCount;
	public uint maxMultiviewInstanceIndex;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkDeviceQueueInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint queueFamilyIndex;
	public uint queueIndex;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedMemory;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedNoFault;
}
public unsafe struct VkProtectedSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedSubmit;
}
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversion ycbcrModel;
	public VkSamplerYcbcrRange ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocation xChromaOffset;
	public VkChromaLocation yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}
public unsafe struct VkSamplerYcbcrConversionInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerYcbcrConversion conversion;
}
public unsafe struct VkBindImagePlaneMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlags planeAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlags planeAspect;
}
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerYcbcrConversion;
}
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint combinedImageSamplerDescriptorCount;
}
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint set;
}
public unsafe struct VkDescriptorUpdateTemplateEntry
{
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public nuint offset;
	public nuint stride;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlags handleType;
}
public unsafe struct VkExternalBufferProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
public unsafe struct VkExternalMemoryProperties
{
	public VkExternalMemoryFeatureFlags externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
}
public unsafe struct VkExternalImageFormatProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
public unsafe struct VkPhysicalDeviceIDProperties
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte deviceUUID[(int)VK.UuidSize];
	public fixed byte driverUUID[(int)VK.UuidSize];
	public fixed byte deviceLUID[(int)VK.LuidSize];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}
public unsafe struct VkExternalMemoryImageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkExternalMemoryBufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkExportMemoryAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleType;
}
public unsafe struct VkExternalFenceProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
	public VkExternalFenceFeatureFlags externalFenceFeatures;
}
public unsafe struct VkExportFenceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleTypes;
}
public unsafe struct VkExportSemaphoreCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleTypes;
}
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}
public unsafe struct VkExternalSemaphoreProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}
public unsafe struct VkDescriptorSetLayoutSupport
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supported;
}
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
[Obsolete("Use VkPhysicalDeviceShaderDrawParametersFeatures")]
public unsafe struct VkPhysicalDeviceShaderDrawParameterFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceVulkan11Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
	public VkBool32 protectedMemory;
	public VkBool32 samplerYcbcrConversion;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte deviceUUID[(int)VK.UuidSize];
	public fixed byte driverUUID[(int)VK.UuidSize];
	public fixed byte deviceLUID[(int)VK.LuidSize];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
	public uint subgroupSize;
	public VkShaderStageFlags subgroupSupportedStages;
	public VkSubgroupFeatureFlags subgroupSupportedOperations;
	public VkBool32 subgroupQuadOperationsInAllStages;
	public VkPointClippingBehavior pointClippingBehavior;
	public uint maxMultiviewViewCount;
	public uint maxMultiviewInstanceIndex;
	public VkBool32 protectedNoFault;
	public uint maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
public unsafe struct VkPhysicalDeviceVulkan12Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerMirrorClampToEdge;
	public VkBool32 drawIndirectCount;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
	public VkBool32 descriptorIndexing;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
	public VkBool32 samplerFilterMinmax;
	public VkBool32 scalarBlockLayout;
	public VkBool32 imagelessFramebuffer;
	public VkBool32 uniformBufferStandardLayout;
	public VkBool32 shaderSubgroupExtendedTypes;
	public VkBool32 separateDepthStencilLayouts;
	public VkBool32 hostQueryReset;
	public VkBool32 timelineSemaphore;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
	public VkBool32 shaderOutputViewportIndex;
	public VkBool32 shaderOutputLayer;
	public VkBool32 subgroupBroadcastDynamicId;
}
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed byte driverName[(int)VK.MaxDriverNameSize];
	public fixed byte driverInfo[(int)VK.MaxDriverInfoSize];
	public VkConformanceVersion conformanceVersion;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
	public uint maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint maxPerStageUpdateAfterBindResources;
	public uint maxDescriptorSetUpdateAfterBindSamplers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindSampledImages;
	public uint maxDescriptorSetUpdateAfterBindStorageImages;
	public uint maxDescriptorSetUpdateAfterBindInputAttachments;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
	public ulong maxTimelineSemaphoreValueDifference;
	public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}
public unsafe struct VkConformanceVersion
{
	public byte major;
	public byte minor;
	public byte subminor;
	public byte patch;
}
public unsafe struct VkImageFormatListCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkRenderPassCreateInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public VkAttachmentDescription2* pAttachments;
	public uint subpassCount;
	public VkSubpassDescription2* pSubpasses;
	public uint dependencyCount;
	public VkSubpassDependency2* pDependencies;
	public uint correlatedViewMaskCount;
	public uint* pCorrelatedViewMasks;
}
public unsafe struct VkAttachmentDescription2
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlags samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
public unsafe struct VkSubpassDescription2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint viewMask;
	public uint inputAttachmentCount;
	public VkAttachmentReference2* pInputAttachments;
	public uint colorAttachmentCount;
	public VkAttachmentReference2* pColorAttachments;
	public VkAttachmentReference2* pResolveAttachments;
	public VkAttachmentReference2* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public uint* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference2
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkSubpassDependency2
{
	public VkStructureType sType;
	public void* pNext;
	public uint srcSubpass;
	public uint dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int viewOffset;
}
public unsafe struct VkSubpassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassContents contents;
}
public unsafe struct VkSubpassEndInfo
{
	public VkStructureType sType;
	public void* pNext;
}
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
}
public unsafe struct VkPhysicalDeviceDriverProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed byte driverName[(int)VK.MaxDriverNameSize];
	public fixed byte driverInfo[(int)VK.MaxDriverInfoSize];
	public VkConformanceVersion conformanceVersion;
}
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
}
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint bindingCount;
	public VkDescriptorBindingFlags* pBindingFlags;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint maxPerStageUpdateAfterBindResources;
	public uint maxDescriptorSetUpdateAfterBindSamplers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindSampledImages;
	public uint maxDescriptorSetUpdateAfterBindStorageImages;
	public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint descriptorSetCount;
	public uint* pDescriptorCounts;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxVariableDescriptorCount;
}
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags depthResolveMode;
	public VkResolveModeFlags stencilResolveMode;
	public VkAttachmentReference2* pDepthStencilResolveAttachment;
}
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
}
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 scalarBlockLayout;
}
public unsafe struct VkImageStencilUsageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags stencilUsage;
}
public unsafe struct VkSamplerReductionModeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerReductionMode reductionMode;
}
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imagelessFramebuffer;
}
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}
public unsafe struct VkFramebufferAttachmentImageInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint width;
	public uint height;
	public uint layerCount;
	public uint viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkRenderPassAttachmentBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentCount;
	public VkImageView* pAttachments;
}
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 uniformBufferStandardLayout;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}
public unsafe struct VkAttachmentReferenceStencilLayout
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilLayout;
}
public unsafe struct VkAttachmentDescriptionStencilLayout
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilInitialLayout;
	public VkImageLayout stencilFinalLayout;
}
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hostQueryReset;
}
public unsafe struct VkSemaphoreWaitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreWaitFlags flags;
	public uint semaphoreCount;
	public VkSemaphore* pSemaphores;
	public ulong* pValues;
}
public unsafe struct VkSemaphoreSignalInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 timelineSemaphore;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
{
	public VkStructureType sType;
	public void* pNext;
	public ulong maxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreType semaphoreType;
	public ulong initialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreValueCount;
	public ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValueCount;
	public ulong* pSignalSemaphoreValues;
}
public unsafe struct VkBufferDeviceAddressInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
}
public unsafe struct VkPhysicalDeviceVulkan13Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	public VkBool32 pipelineCreationCacheControl;
	public VkBool32 privateData;
	public VkBool32 shaderDemoteToHelperInvocation;
	public VkBool32 shaderTerminateInvocation;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
	public VkBool32 synchronization2;
	public VkBool32 textureCompressionASTC_HDR;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
	public VkBool32 dynamicRendering;
	public VkBool32 shaderIntegerDotProduct;
	public VkBool32 maintenance4;
}
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
	public VkStructureType sType;
	public void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
	public uint maxInlineUniformBlockSize;
	public uint maxPerStageDescriptorInlineUniformBlocks;
	public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint maxDescriptorSetInlineUniformBlocks;
	public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	public uint maxInlineUniformTotalSize;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize maxBufferSize;
}
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreationFeedback* pPipelineCreationFeedback;
	public uint pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedback** pPipelineStageCreationFeedbacks;
}
public unsafe struct VkPipelineCreationFeedback
{
	public VkPipelineCreationFeedbackFlags flags;
	public ulong duration;
}
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderTerminateInvocation;
}
public unsafe struct VkPhysicalDeviceToolProperties
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte name[(int)VK.MaxExtensionNameSize];
	public fixed byte version[(int)VK.MaxExtensionNameSize];
	public VkToolPurposeFlags purposes;
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public fixed byte layer[(int)VK.MaxExtensionNameSize];
}
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}
public unsafe struct VkPrivateDataSlotCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPrivateDataSlotCreateFlags flags;
}
public unsafe struct VkPhysicalDevicePrivateDataFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 privateData;
}
public unsafe struct VkDevicePrivateDataCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint privateDataSlotRequestCount;
}
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineCreationCacheControl;
}
public unsafe struct VkDependencyInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDependencyFlags dependencyFlags;
	public uint memoryBarrierCount;
	public VkMemoryBarrier2* pMemoryBarriers;
	public uint bufferMemoryBarrierCount;
	public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
	public uint imageMemoryBarrierCount;
	public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
public unsafe struct VkMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
}
public unsafe struct VkBufferMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkImageMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkSubmitInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubmitFlags flags;
	public uint waitSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
	public uint commandBufferInfoCount;
	public VkCommandBufferSubmitInfo* pCommandBufferInfos;
	public uint signalSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}
public unsafe struct VkSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
	public VkPipelineStageFlags2 stageMask;
	public uint deviceIndex;
}
public unsafe struct VkCommandBufferSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBuffer commandBuffer;
	public uint deviceMask;
}
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 synchronization2;
}
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
}
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
}
public unsafe struct VkCopyBufferInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public VkBufferCopy2* pRegions;
}
public unsafe struct VkBufferCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
public unsafe struct VkCopyImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageCopy2* pRegions;
}
public unsafe struct VkImageCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkCopyBufferToImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkBufferImageCopy2* pRegions;
}
public unsafe struct VkBufferImageCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize bufferOffset;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
public unsafe struct VkCopyImageToBufferInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public VkBufferImageCopy2* pRegions;
}
public unsafe struct VkBlitImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageBlit2* pRegions;
	public VkFilter filter;
}
public unsafe struct VkImageBlit2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
public unsafe struct VkResolveImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageResolve2* pRegions;
}
public unsafe struct VkImageResolve2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint requiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxInlineUniformBlockSize;
	public uint maxPerStageDescriptorInlineUniformBlocks;
	public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint maxDescriptorSetInlineUniformBlocks;
	public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
	public VkStructureType sType;
	public void* pNext;
	public uint dataSize;
	public void* pData;
}
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxInlineUniformBlockBindings;
}
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureCompressionASTC_HDR;
}
public unsafe struct VkRenderingInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public VkRect2D renderArea;
	public uint layerCount;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkRenderingAttachmentInfo* pColorAttachments;
	public VkRenderingAttachmentInfo* pDepthAttachment;
	public VkRenderingAttachmentInfo* pStencilAttachment;
}
public unsafe struct VkRenderingAttachmentInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkResolveModeFlags resolveMode;
	public VkImageView resolveImageView;
	public VkImageLayout resolveImageLayout;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkClearValue clearValue;
}
public unsafe struct VkPipelineRenderingCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
}
public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicRendering;
}
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
	public VkSampleCountFlags rasterizationSamples;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerDotProduct;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}
public unsafe struct VkFormatProperties3
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatFeatureFlags2 linearTilingFeatures;
	public VkFormatFeatureFlags2 optimalTilingFeatures;
	public VkFormatFeatureFlags2 bufferFeatures;
}
public unsafe struct VkDeviceBufferMemoryRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateInfo* pCreateInfo;
}
public unsafe struct VkDeviceImageMemoryRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateInfo* pCreateInfo;
	public VkImageAspectFlags planeAspect;
}
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 maintenance4;
}
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize maxBufferSize;
}
public unsafe struct VkSurfaceCapabilitiesKHR
{
	public uint minImageCount;
	public uint maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
}
public unsafe struct VkSurfaceFormatKHR
{
	public VkFormat format;
	public VkColorSpaceKHR colorSpace;
}
public unsafe struct VkSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainCreateFlagsKHR flags;
	public VkSurfaceKHR surface;
	public uint minImageCount;
	public VkFormat imageFormat;
	public VkColorSpaceKHR imageColorSpace;
	public VkExtent2D imageExtent;
	public uint imageArrayLayers;
	public VkImageUsageFlags imageUsage;
	public VkSharingMode imageSharingMode;
	public uint queueFamilyIndexCount;
	public uint* pQueueFamilyIndices;
	public VkSurfaceTransformFlagsKHR preTransform;
	public VkCompositeAlphaFlagsKHR compositeAlpha;
	public VkPresentModeKHR presentMode;
	public VkBool32 clipped;
	public VkSwapchainKHR oldSwapchain;
}
public unsafe struct VkPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint swapchainCount;
	public VkSwapchainKHR* pSwapchains;
	public uint* pImageIndices;
	public VkResult* pResults;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed uint presentMask[(int)VK.MaxDeviceGroupSize];
	public VkDeviceGroupPresentModeFlagsKHR modes;
}
public unsafe struct VkAcquireNextImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public ulong timeout;
	public VkSemaphore semaphore;
	public VkFence fence;
	public uint deviceMask;
}
public unsafe struct VkImageSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
}
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint imageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public uint* pDeviceMasks;
	public VkDeviceGroupPresentModeFlagsKHR mode;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceGroupPresentModeFlagsKHR modes;
}
public unsafe struct VkDisplayPropertiesKHR
{
	public VkDisplayKHR display;
	public byte* displayName;
	public VkExtent2D physicalDimensions;
	public VkExtent2D physicalResolution;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkBool32 planeReorderPossible;
	public VkBool32 persistentContent;
}
public unsafe struct VkDisplayPlanePropertiesKHR
{
	public VkDisplayKHR currentDisplay;
	public uint currentStackIndex;
}
public unsafe struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR displayMode;
	public VkDisplayModeParametersKHR parameters;
}
public unsafe struct VkDisplayModeParametersKHR
{
	public VkExtent2D visibleRegion;
	public uint refreshRate;
}
public unsafe struct VkDisplayModeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModeCreateFlagsKHR flags;
	public VkDisplayModeParametersKHR parameters;
}
public unsafe struct VkDisplayPlaneCapabilitiesKHR
{
	public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
	public VkOffset2D minSrcPosition;
	public VkOffset2D maxSrcPosition;
	public VkExtent2D minSrcExtent;
	public VkExtent2D maxSrcExtent;
	public VkOffset2D minDstPosition;
	public VkOffset2D maxDstPosition;
	public VkExtent2D minDstExtent;
	public VkExtent2D maxDstExtent;
}
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplaySurfaceCreateFlagsKHR flags;
	public VkDisplayModeKHR displayMode;
	public uint planeIndex;
	public uint planeStackIndex;
	public VkSurfaceTransformFlagsKHR transform;
	public float globalAlpha;
	public VkDisplayPlaneAlphaFlagsKHR alphaMode;
	public VkExtent2D imageExtent;
}
public unsafe struct VkDisplayPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRect2D srcRect;
	public VkRect2D dstRect;
	public VkBool32 persistent;
}
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkXlibSurfaceCreateFlagsKHR flags;
	public void* dpy;
	public IntPtr window;
}
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkXcbSurfaceCreateFlagsKHR flags;
	public void* connection;
	public IntPtr window;
}
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWaylandSurfaceCreateFlagsKHR flags;
	public void* display;
	public void* surface;
}
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAndroidSurfaceCreateFlagsKHR flags;
	public void* window;
}
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWin32SurfaceCreateFlagsKHR flags;
	public IntPtr hinstance;
	public IntPtr hwnd;
}
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportFlagsEXT flags;
	public DebugReportCallbackEXTDelegate pfnCallback;
	public void* pUserData;
}
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkRasterizationOrderAMD rasterizationOrder;
}
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public ulong object;
	public ulong tagName;
	public nuint tagSize;
	public void* pTag;
}
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public ulong object;
	public byte* pObjectName;
}
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public byte* pMarkerName;
	public fixed float color[4];
}
public unsafe struct VkVideoProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodecOperationFlagsKHR videoCodecOperation;
	public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
	public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
	public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
}
public unsafe struct VkVideoCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCapabilityFlagsKHR flags;
	public VkDeviceSize minBitstreamBufferOffsetAlignment;
	public VkDeviceSize minBitstreamBufferSizeAlignment;
	public VkExtent2D pictureAccessGranularity;
	public VkExtent2D minCodedExtent;
	public VkExtent2D maxCodedExtent;
	public uint maxDpbSlots;
	public uint maxActiveReferencePictures;
	public VkExtensionProperties stdHeaderVersion;
}
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags imageUsage;
}
public unsafe struct VkVideoFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkComponentMapping componentMapping;
	public VkImageCreateFlags imageCreateFlags;
	public VkImageType imageType;
	public VkImageTiling imageTiling;
	public VkImageUsageFlags imageUsageFlags;
}
public unsafe struct VkVideoSessionCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint queueFamilyIndex;
	public VkVideoSessionCreateFlagsKHR flags;
	public VkVideoProfileInfoKHR* pVideoProfile;
	public VkFormat pictureFormat;
	public VkExtent2D maxCodedExtent;
	public VkFormat referencePictureFormat;
	public uint maxDpbSlots;
	public uint maxActiveReferencePictures;
	public VkExtensionProperties* pStdHeaderVersion;
}
public unsafe struct VkVideoSessionMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint memoryBindIndex;
	public VkMemoryRequirements memoryRequirements;
}
public unsafe struct VkBindVideoSessionMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint memoryBindIndex;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkDeviceSize memorySize;
}
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoSessionParametersCreateFlagsKHR flags;
	public VkVideoSessionParametersKHR videoSessionParametersTemplate;
	public VkVideoSessionKHR videoSession;
}
public unsafe struct VkVideoSessionParametersUpdateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint updateSequenceCount;
}
public unsafe struct VkVideoBeginCodingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoBeginCodingFlagsKHR flags;
	public VkVideoSessionKHR videoSession;
	public VkVideoSessionParametersKHR videoSessionParameters;
	public uint referenceSlotCount;
	public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}
public unsafe struct VkVideoReferenceSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public int slotIndex;
	public VkVideoPictureResourceInfoKHR* pPictureResource;
}
public unsafe struct VkVideoPictureResourceInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkOffset2D codedOffset;
	public VkExtent2D codedExtent;
	public uint baseArrayLayer;
	public VkImageView imageViewBinding;
}
public unsafe struct VkVideoEndCodingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoEndCodingFlagsKHR flags;
}
public unsafe struct VkVideoCodingControlInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodingControlFlagsKHR flags;
}
public unsafe struct VkQueueFamilyQueryResultStatusPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 queryResultStatusSupport;
}
public unsafe struct VkQueueFamilyVideoPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodecOperationFlagsKHR videoCodecOperations;
}
public unsafe struct VkVideoProfileListInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint profileCount;
	public VkVideoProfileInfoKHR* pProfiles;
}
public unsafe struct VkVideoDecodeInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeFlagsKHR flags;
	public VkBuffer srcBuffer;
	public VkDeviceSize srcBufferOffset;
	public VkDeviceSize srcBufferRange;
	public VkVideoPictureResourceInfoKHR dstPictureResource;
	public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
	public uint referenceSlotCount;
	public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}
public unsafe struct VkVideoDecodeCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeCapabilityFlagsKHR flags;
}
public unsafe struct VkVideoDecodeUsageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeUsageFlagsKHR videoUsageHints;
}
public unsafe struct VkDedicatedAllocationImageCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 transformFeedback;
	public VkBool32 geometryStreams;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxTransformFeedbackStreams;
	public uint maxTransformFeedbackBuffers;
	public VkDeviceSize maxTransformFeedbackBufferSize;
	public uint maxTransformFeedbackStreamDataSize;
	public uint maxTransformFeedbackBufferDataSize;
	public uint maxTransformFeedbackBufferDataStride;
	public VkBool32 transformFeedbackQueries;
	public VkBool32 transformFeedbackStreamsLinesTriangles;
	public VkBool32 transformFeedbackRasterizationStreamSelect;
	public VkBool32 transformFeedbackDraw;
}
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
	public uint rasterizationStream;
}
public unsafe struct VkCuModuleCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public nuint dataSize;
	public void* pData;
}
public unsafe struct VkCuFunctionCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkCuModuleNVX module;
	public byte* pName;
}
public unsafe struct VkCuLaunchInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkCuFunctionNVX function;
	public uint gridDimX;
	public uint gridDimY;
	public uint gridDimZ;
	public uint blockDimX;
	public uint blockDimY;
	public uint blockDimZ;
	public uint sharedMemBytes;
	public nuint paramCount;
	public void** pParams;
	public nuint extraCount;
	public void** pExtras;
}
public unsafe struct VkImageViewHandleInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkDescriptorType descriptorType;
	public VkSampler sampler;
}
public unsafe struct VkImageViewAddressPropertiesNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress deviceAddress;
	public VkDeviceSize size;
}
public unsafe struct VkVideoDecodeH264ProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH264ProfileIdc stdProfileIdc;
	public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;
}
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH264LevelIdc maxLevelIdc;
	public VkOffset2D fieldOffsetGranularity;
}
public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxStdSPSCount;
	public uint maxStdPPSCount;
	public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
}
public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint stdSPSCount;
	public StdVideoH264SequenceParameterSet* pStdSPSs;
	public uint stdPPSCount;
	public StdVideoH264PictureParameterSet* pStdPPSs;
}
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
	public uint sliceCount;
	public uint* pSliceOffsets;
}
public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
}
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supportsTextureGatherLODBiasAMD;
}
public unsafe struct VkShaderResourceUsageAMD
{
	public uint numUsedVgprs;
	public uint numUsedSgprs;
	public uint ldsSizePerLocalWorkGroup;
	public nuint ldsUsageSizeInBytes;
	public nuint scratchMemUsageInBytes;
}
public unsafe struct VkShaderStatisticsInfoAMD
{
	public VkShaderStageFlags shaderStageMask;
	public VkShaderResourceUsageAMD resourceUsage;
	public uint numPhysicalVgprs;
	public uint numPhysicalSgprs;
	public uint numAvailableVgprs;
	public uint numAvailableSgprs;
	public fixed uint computeWorkGroupSize[3];
}
[Obsolete("Use VkRenderingInfo")]
public unsafe struct VkRenderingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public VkRect2D renderArea;
	public uint layerCount;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkRenderingAttachmentInfo* pColorAttachments;
	public VkRenderingAttachmentInfo* pDepthAttachment;
	public VkRenderingAttachmentInfo* pStencilAttachment;
}
[Obsolete("Use VkRenderingAttachmentInfo")]
public unsafe struct VkRenderingAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkResolveModeFlags resolveMode;
	public VkImageView resolveImageView;
	public VkImageLayout resolveImageLayout;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkClearValue clearValue;
}
[Obsolete("Use VkPipelineRenderingCreateInfo")]
public unsafe struct VkPipelineRenderingCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
}
[Obsolete("Use VkPhysicalDeviceDynamicRenderingFeatures")]
public unsafe struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicRendering;
}
[Obsolete("Use VkCommandBufferInheritanceRenderingInfo")]
public unsafe struct VkCommandBufferInheritanceRenderingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public uint viewMask;
	public uint colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
	public VkSampleCountFlags rasterizationSamples;
}
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkExtent2D shadingRateAttachmentTexelSize;
}
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}
public unsafe struct VkAttachmentSampleCountInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public uint colorAttachmentCount;
	public VkSampleCountFlags* pColorAttachmentSamples;
	public VkSampleCountFlags depthStencilAttachmentSamples;
}
[Obsolete("Use VkAttachmentSampleCountInfoAMD")]
public unsafe struct VkAttachmentSampleCountInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint colorAttachmentCount;
	public VkSampleCountFlags* pColorAttachmentSamples;
	public VkSampleCountFlags depthStencilAttachmentSamples;
}
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 perViewAttributes;
	public VkBool32 perViewAttributesPositionXOnly;
}
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 cornerSampledImage;
}
[Obsolete("Use VkRenderPassMultiviewCreateInfo")]
public unsafe struct VkRenderPassMultiviewCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint subpassCount;
	public uint* pViewMasks;
	public uint dependencyCount;
	public int* pViewOffsets;
	public uint correlationMaskCount;
	public uint* pCorrelationMasks;
}
[Obsolete("Use VkPhysicalDeviceMultiviewFeatures")]
public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}
[Obsolete("Use VkPhysicalDeviceMultiviewProperties")]
public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxMultiviewViewCount;
	public uint maxMultiviewInstanceIndex;
}
public unsafe struct VkExternalImageFormatPropertiesNV
{
	public VkImageFormatProperties imageFormatProperties;
	public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
}
public unsafe struct VkExternalMemoryImageCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}
public unsafe struct VkExportMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}
public unsafe struct VkImportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleType;
	public IntPtr handle;
}
public unsafe struct VkExportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public SecurityAttributes* pAttributes;
	public uint dwAccess;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public ulong* pAcquireKeys;
	public uint* pAcquireTimeoutMilliseconds;
	public uint releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public ulong* pReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceFeatures2")]
public unsafe struct VkPhysicalDeviceFeatures2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceFeatures features;
}
[Obsolete("Use VkPhysicalDeviceProperties2")]
public unsafe struct VkPhysicalDeviceProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceProperties properties;
}
[Obsolete("Use VkFormatProperties2")]
public unsafe struct VkFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatProperties formatProperties;
}
[Obsolete("Use VkImageFormatProperties2")]
public unsafe struct VkImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}
[Obsolete("Use VkPhysicalDeviceImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceImageFormatInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkImageCreateFlags flags;
}
[Obsolete("Use VkQueueFamilyProperties2")]
public unsafe struct VkQueueFamilyProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}
[Obsolete("Use VkPhysicalDeviceMemoryProperties2")]
public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}
[Obsolete("Use VkSparseImageFormatProperties2")]
public unsafe struct VkSparseImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageFormatProperties properties;
}
[Obsolete("Use VkPhysicalDeviceSparseImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlags samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
[Obsolete("Use VkMemoryAllocateFlagsInfo")]
public unsafe struct VkMemoryAllocateFlagsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint deviceMask;
}
[Obsolete("Use VkDeviceGroupRenderPassBeginInfo")]
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
	public uint deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
[Obsolete("Use VkDeviceGroupCommandBufferBeginInfo")]
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
}
[Obsolete("Use VkDeviceGroupSubmitInfo")]
public unsafe struct VkDeviceGroupSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreCount;
	public uint* pWaitSemaphoreDeviceIndices;
	public uint commandBufferCount;
	public uint* pCommandBufferDeviceMasks;
	public uint signalSemaphoreCount;
	public uint* pSignalSemaphoreDeviceIndices;
}
[Obsolete("Use VkDeviceGroupBindSparseInfo")]
public unsafe struct VkDeviceGroupBindSparseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint resourceDeviceIndex;
	public uint memoryDeviceIndex;
}
[Obsolete("Use VkBindBufferMemoryDeviceGroupInfo")]
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
}
[Obsolete("Use VkBindImageMemoryDeviceGroupInfo")]
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
	public uint splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint disabledValidationCheckCount;
	public VkValidationCheckEXT* pDisabledValidationChecks;
}
[Obsolete("Use VkPhysicalDeviceTextureCompressionASTCHDRFeatures")]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureCompressionASTC_HDR;
}
public unsafe struct VkImageViewASTCDecodeModeEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat decodeMode;
}
public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 decodeModeSharedExponent;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineRobustness;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
}
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT images;
}
[Obsolete("Use VkPhysicalDeviceGroupProperties")]
public unsafe struct VkPhysicalDeviceGroupPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice physicalDevices_0;
	public VkPhysicalDevice physicalDevices_1;
	public VkPhysicalDevice physicalDevices_2;
	public VkPhysicalDevice physicalDevices_3;
	public VkPhysicalDevice physicalDevices_4;
	public VkPhysicalDevice physicalDevices_5;
	public VkPhysicalDevice physicalDevices_6;
	public VkPhysicalDevice physicalDevices_7;
	public VkPhysicalDevice physicalDevices_8;
	public VkPhysicalDevice physicalDevices_9;
	public VkPhysicalDevice physicalDevices_10;
	public VkPhysicalDevice physicalDevices_11;
	public VkPhysicalDevice physicalDevices_12;
	public VkPhysicalDevice physicalDevices_13;
	public VkPhysicalDevice physicalDevices_14;
	public VkPhysicalDevice physicalDevices_15;
	public VkPhysicalDevice physicalDevices_16;
	public VkPhysicalDevice physicalDevices_17;
	public VkPhysicalDevice physicalDevices_18;
	public VkPhysicalDevice physicalDevices_19;
	public VkPhysicalDevice physicalDevices_20;
	public VkPhysicalDevice physicalDevices_21;
	public VkPhysicalDevice physicalDevices_22;
	public VkPhysicalDevice physicalDevices_23;
	public VkPhysicalDevice physicalDevices_24;
	public VkPhysicalDevice physicalDevices_25;
	public VkPhysicalDevice physicalDevices_26;
	public VkPhysicalDevice physicalDevices_27;
	public VkPhysicalDevice physicalDevices_28;
	public VkPhysicalDevice physicalDevices_29;
	public VkPhysicalDevice physicalDevices_30;
	public VkPhysicalDevice physicalDevices_31;
	public VkBool32 subsetAllocation;
}
[Obsolete("Use VkDeviceGroupDeviceCreateInfo")]
public unsafe struct VkDeviceGroupDeviceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice* pPhysicalDevices;
}
[Obsolete("Use VkExternalMemoryProperties")]
public unsafe struct VkExternalMemoryPropertiesKHR
{
	public VkExternalMemoryFeatureFlags externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}
[Obsolete("Use VkPhysicalDeviceExternalImageFormatInfo")]
public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
}
[Obsolete("Use VkExternalImageFormatProperties")]
public unsafe struct VkExternalImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceExternalBufferInfo")]
public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlags handleType;
}
[Obsolete("Use VkExternalBufferProperties")]
public unsafe struct VkExternalBufferPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceIDProperties")]
public unsafe struct VkPhysicalDeviceIDPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte deviceUUID[(int)VK.UuidSize];
	public fixed byte driverUUID[(int)VK.UuidSize];
	public fixed byte deviceLUID[(int)VK.LuidSize];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}
[Obsolete("Use VkExternalMemoryImageCreateInfo")]
public unsafe struct VkExternalMemoryImageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
[Obsolete("Use VkExternalMemoryBufferCreateInfo")]
public unsafe struct VkExternalMemoryBufferCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
[Obsolete("Use VkExportMemoryAllocateInfo")]
public unsafe struct VkExportMemoryAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint memoryTypeBits;
}
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SecurityAttributes* pAttributes;
	public uint dwAccess;
	public IntPtr name;
}
public unsafe struct VkMemoryGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}
public unsafe struct VkMemoryFdPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint memoryTypeBits;
}
public unsafe struct VkImportMemoryFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public int fd;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public ulong* pAcquireKeys;
	public uint* pAcquireTimeouts;
	public uint releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public ulong* pReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceExternalSemaphoreInfo")]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}
[Obsolete("Use VkExternalSemaphoreProperties")]
public unsafe struct VkExternalSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}
[Obsolete("Use VkExportSemaphoreCreateInfo")]
public unsafe struct VkExportSemaphoreCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleTypes;
}
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SecurityAttributes* pAttributes;
	public uint dwAccess;
	public IntPtr name;
}
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreValuesCount;
	public ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValuesCount;
	public ulong* pSignalSemaphoreValues;
}
public unsafe struct VkImportSemaphoreFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlags handleType;
	public int fd;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxPushDescriptors;
}
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkConditionalRenderingFlagsEXT flags;
}
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 conditionalRendering;
	public VkBool32 inheritedConditionalRendering;
}
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 conditionalRenderingEnable;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8Features")]
public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8Features")]
public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
[Obsolete("Use VkPhysicalDevice16BitStorageFeatures")]
public unsafe struct VkPhysicalDevice16BitStorageFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
}
public unsafe struct VkPresentRegionsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public VkPresentRegionKHR* pRegions;
}
public unsafe struct VkPresentRegionKHR
{
	public uint rectangleCount;
	public VkRectLayerKHR* pRectangles;
}
public unsafe struct VkRectLayerKHR
{
	public VkOffset2D offset;
	public VkExtent2D extent;
	public uint layer;
}
[Obsolete("Use VkDescriptorUpdateTemplateEntry")]
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public nuint offset;
	public nuint stride;
}
[Obsolete("Use VkDescriptorUpdateTemplateCreateInfo")]
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint set;
}
public unsafe struct VkViewportWScalingNV
{
	public float xcoeff;
	public float ycoeff;
}
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 viewportWScalingEnable;
	public uint viewportCount;
	public VkViewportWScalingNV* pViewportWScalings;
}
public unsafe struct VkSurfaceCapabilities2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint minImageCount;
	public uint maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
	public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
}
public unsafe struct VkDisplayPowerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPowerStateEXT powerState;
}
public unsafe struct VkDeviceEventInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceEventTypeEXT deviceEvent;
}
public unsafe struct VkDisplayEventInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayEventTypeEXT displayEvent;
}
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceCounterFlagsEXT surfaceCounters;
}
public unsafe struct VkRefreshCycleDurationGOOGLE
{
	public ulong refreshDuration;
}
public unsafe struct VkPastPresentationTimingGOOGLE
{
	public uint presentID;
	public ulong desiredPresentTime;
	public ulong actualPresentTime;
	public ulong earliestPresentTime;
	public ulong presentMargin;
}
public unsafe struct VkPresentTimesInfoGOOGLE
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public VkPresentTimeGOOGLE* pTimes;
}
public unsafe struct VkPresentTimeGOOGLE
{
	public uint presentID;
	public ulong desiredPresentTime;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 perViewPositionAllComponents;
}
public unsafe struct VkViewportSwizzleNV
{
	public VkViewportCoordinateSwizzleNV x;
	public VkViewportCoordinateSwizzleNV y;
	public VkViewportCoordinateSwizzleNV z;
	public VkViewportCoordinateSwizzleNV w;
}
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
	public uint viewportCount;
	public VkViewportSwizzleNV* pViewportSwizzles;
}
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxDiscardRectangles;
}
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
	public VkDiscardRectangleModeEXT discardRectangleMode;
	public uint discardRectangleCount;
	public VkRect2D* pDiscardRectangles;
}
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float primitiveOverestimationSize;
	public float maxExtraPrimitiveOverestimationSize;
	public float extraPrimitiveOverestimationSizeGranularity;
	public VkBool32 primitiveUnderestimation;
	public VkBool32 conservativePointAndLineRasterization;
	public VkBool32 degenerateTrianglesRasterized;
	public VkBool32 degenerateLinesRasterized;
	public VkBool32 fullyCoveredFragmentShaderInputVariable;
	public VkBool32 conservativeRasterizationPostDepthCoverage;
}
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
	public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
	public float extraPrimitiveOverestimationSize;
}
public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClipEnable;
}
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
	public VkBool32 depthClipEnable;
}
public unsafe struct VkHdrMetadataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkXYColorEXT displayPrimaryRed;
	public VkXYColorEXT displayPrimaryGreen;
	public VkXYColorEXT displayPrimaryBlue;
	public VkXYColorEXT whitePoint;
	public float maxLuminance;
	public float minLuminance;
	public float maxContentLightLevel;
	public float maxFrameAverageLightLevel;
}
public unsafe struct VkXYColorEXT
{
	public float x;
	public float y;
}
[Obsolete("Use VkPhysicalDeviceImagelessFramebufferFeatures")]
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imagelessFramebuffer;
}
[Obsolete("Use VkFramebufferAttachmentsCreateInfo")]
public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}
[Obsolete("Use VkFramebufferAttachmentImageInfo")]
public unsafe struct VkFramebufferAttachmentImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint width;
	public uint height;
	public uint layerCount;
	public uint viewFormatCount;
	public VkFormat* pViewFormats;
}
[Obsolete("Use VkRenderPassAttachmentBeginInfo")]
public unsafe struct VkRenderPassAttachmentBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentCount;
	public VkImageView* pAttachments;
}
[Obsolete("Use VkRenderPassCreateInfo2")]
public unsafe struct VkRenderPassCreateInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public VkAttachmentDescription2* pAttachments;
	public uint subpassCount;
	public VkSubpassDescription2* pSubpasses;
	public uint dependencyCount;
	public VkSubpassDependency2* pDependencies;
	public uint correlatedViewMaskCount;
	public uint* pCorrelatedViewMasks;
}
[Obsolete("Use VkAttachmentDescription2")]
public unsafe struct VkAttachmentDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlags samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
[Obsolete("Use VkAttachmentReference2")]
public unsafe struct VkAttachmentReference2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
[Obsolete("Use VkSubpassDescription2")]
public unsafe struct VkSubpassDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint viewMask;
	public uint inputAttachmentCount;
	public VkAttachmentReference2* pInputAttachments;
	public uint colorAttachmentCount;
	public VkAttachmentReference2* pColorAttachments;
	public VkAttachmentReference2* pResolveAttachments;
	public VkAttachmentReference2* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public uint* pPreserveAttachments;
}
[Obsolete("Use VkSubpassDependency2")]
public unsafe struct VkSubpassDependency2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint srcSubpass;
	public uint dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int viewOffset;
}
[Obsolete("Use VkSubpassBeginInfo")]
public unsafe struct VkSubpassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassContents contents;
}
[Obsolete("Use VkSubpassEndInfo")]
public unsafe struct VkSubpassEndInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
}
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags sharedPresentSupportedUsageFlags;
}
[Obsolete("Use VkPhysicalDeviceExternalFenceInfo")]
public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleType;
}
[Obsolete("Use VkExternalFenceProperties")]
public unsafe struct VkExternalFencePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
	public VkExternalFenceFeatureFlags externalFenceFeatures;
}
[Obsolete("Use VkExportFenceCreateInfo")]
public unsafe struct VkExportFenceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleTypes;
}
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlags handleType;
}
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SecurityAttributes* pAttributes;
	public uint dwAccess;
	public IntPtr name;
}
public unsafe struct VkImportFenceFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlags handleType;
	public int fd;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlags handleType;
}
public unsafe struct VkPerformanceCounterKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterUnitKHR unit;
	public VkPerformanceCounterScopeKHR scope;
	public VkPerformanceCounterStorageKHR storage;
	public fixed byte uuid[(int)VK.UuidSize];
}
public unsafe struct VkPerformanceCounterDescriptionKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterDescriptionFlagsKHR flags;
	public fixed byte name[(int)VK.MaxDescriptionSize];
	public fixed byte category[(int)VK.MaxDescriptionSize];
	public fixed byte description[(int)VK.MaxDescriptionSize];
}
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint queueFamilyIndex;
	public uint counterIndexCount;
	public uint* pCounterIndices;
}
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAcquireProfilingLockFlagsKHR flags;
	public ulong timeout;
}
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 performanceCounterQueryPools;
	public VkBool32 performanceCounterMultipleQueryPools;
}
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 allowCommandBufferQueryCopies;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceCounterResultKHR
{
	[FieldOffset(0)]
	public int int32;
	[FieldOffset(0)]
	public long int64;
	[FieldOffset(0)]
	public uint uint32;
	[FieldOffset(0)]
	public ulong uint64;
	[FieldOffset(0)]
	public float float32;
	[FieldOffset(0)]
	public double float64;
}
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint counterPassIndex;
}
[Obsolete("Use VkPhysicalDevicePointClippingProperties")]
public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPointClippingBehavior pointClippingBehavior;
}
[Obsolete("Use VkRenderPassInputAttachmentAspectCreateInfo")]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
[Obsolete("Use VkInputAttachmentAspectReference")]
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint subpass;
	public uint inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}
[Obsolete("Use VkImageViewUsageCreateInfo")]
public unsafe struct VkImageViewUsageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags usage;
}
[Obsolete("Use VkPipelineTessellationDomainOriginStateCreateInfo")]
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkTessellationDomainOrigin domainOrigin;
}
public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceKHR surface;
}
public unsafe struct VkSurfaceCapabilities2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceCapabilitiesKHR surfaceCapabilities;
}
public unsafe struct VkSurfaceFormat2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceFormatKHR surfaceFormat;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointersFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkDisplayProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPropertiesKHR displayProperties;
}
public unsafe struct VkDisplayPlaneProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPlanePropertiesKHR displayPlaneProperties;
}
public unsafe struct VkDisplayModeProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModePropertiesKHR displayModeProperties;
}
public unsafe struct VkDisplayPlaneInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModeKHR mode;
	public uint planeIndex;
}
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPlaneCapabilitiesKHR capabilities;
}
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public void* pNext;
	public VkMacOSSurfaceCreateFlagsMVK flags;
	public void* pView;
}
[Obsolete("Use VkMemoryDedicatedRequirements")]
public unsafe struct VkMemoryDedicatedRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}
[Obsolete("Use VkMemoryDedicatedAllocateInfo")]
public unsafe struct VkMemoryDedicatedAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectType objectType;
	public ulong objectHandle;
	public byte* pObjectName;
}
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectType objectType;
	public ulong objectHandle;
	public ulong tagName;
	public nuint tagSize;
	public void* pTag;
}
public unsafe struct VkDebugUtilsLabelEXT
{
	public VkStructureType sType;
	public void* pNext;
	public byte* pLabelName;
	public fixed float color[4];
}
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCreateFlagsEXT flags;
	public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
	public VkDebugUtilsMessageTypeFlagsEXT messageType;
	public DebugUtilsMessengerCallbackEXTDelegate pfnUserCallback;
	public void* pUserData;
}
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
	public byte* pMessageIdName;
	public int messageIdNumber;
	public byte* pMessage;
	public uint queueLabelCount;
	public VkDebugUtilsLabelEXT* pQueueLabels;
	public uint cmdBufLabelCount;
	public VkDebugUtilsLabelEXT* pCmdBufLabels;
	public uint objectCount;
	public VkDebugUtilsObjectNameInfoEXT* pObjects;
}
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint memoryTypeBits;
}
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public ulong androidHardwareBufferUsage;
}
public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public ulong externalFormat;
	public VkFormatFeatureFlags formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public void* buffer;
}
public unsafe struct VkExternalFormatANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public ulong externalFormat;
}
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public ulong externalFormat;
	public VkFormatFeatureFlags2 formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}
[Obsolete("Use VkSamplerReductionModeCreateInfo")]
public unsafe struct VkSamplerReductionModeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerReductionMode reductionMode;
}
[Obsolete("Use VkPhysicalDeviceSamplerFilterMinmaxProperties")]
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}
[Obsolete("Use VkPhysicalDeviceInlineUniformBlockFeatures")]
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}
[Obsolete("Use VkPhysicalDeviceInlineUniformBlockProperties")]
public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxInlineUniformBlockSize;
	public uint maxPerStageDescriptorInlineUniformBlocks;
	public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint maxDescriptorSetInlineUniformBlocks;
	public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
[Obsolete("Use VkWriteDescriptorSetInlineUniformBlock")]
public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint dataSize;
	public void* pData;
}
[Obsolete("Use VkDescriptorPoolInlineUniformBlockCreateInfo")]
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxInlineUniformBlockBindings;
}
public unsafe struct VkSampleLocationsInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags sampleLocationsPerPixel;
	public VkExtent2D sampleLocationGridSize;
	public uint sampleLocationsCount;
	public VkSampleLocationEXT* pSampleLocations;
}
public unsafe struct VkSampleLocationEXT
{
	public float x;
	public float y;
}
public unsafe struct VkMultisamplePropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D maxSampleLocationGridSize;
}
public unsafe struct VkAttachmentSampleLocationsEXT
{
	public uint attachmentIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkSubpassSampleLocationsEXT
{
	public uint subpassIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentInitialSampleLocationsCount;
	public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
	public uint postSubpassSampleLocationsCount;
	public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
}
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 sampleLocationsEnable;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags sampleLocationSampleCounts;
	public VkExtent2D maxSampleLocationGridSize;
	public fixed float sampleLocationCoordinateRange[2];
	public uint sampleLocationSubPixelBits;
	public VkBool32 variableSampleLocations;
}
[Obsolete("Use VkBufferMemoryRequirementsInfo2")]
public unsafe struct VkBufferMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
[Obsolete("Use VkImageMemoryRequirementsInfo2")]
public unsafe struct VkImageMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
[Obsolete("Use VkImageSparseMemoryRequirementsInfo2")]
public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
[Obsolete("Use VkMemoryRequirements2")]
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
}
[Obsolete("Use VkSparseImageMemoryRequirements2")]
public unsafe struct VkSparseImageMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}
[Obsolete("Use VkImageFormatListCreateInfo")]
public unsafe struct VkImageFormatListCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 advancedBlendCoherentOperations;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint advancedBlendMaxColorAttachments;
	public VkBool32 advancedBlendIndependentBlend;
	public VkBool32 advancedBlendNonPremultipliedSrcColor;
	public VkBool32 advancedBlendNonPremultipliedDstColor;
	public VkBool32 advancedBlendCorrelatedOverlap;
	public VkBool32 advancedBlendAllOperations;
}
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 srcPremultiplied;
	public VkBool32 dstPremultiplied;
	public VkBlendOverlapEXT blendOverlap;
}
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageToColorStateCreateFlagsNV flags;
	public VkBool32 coverageToColorEnable;
	public uint coverageToColorLocation;
}
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureCreateFlagsKHR createFlags;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkAccelerationStructureTypeKHR type;
	public VkDeviceAddress deviceAddress;
}
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureTypeKHR type;
	public VkBuildAccelerationStructureFlagsKHR flags;
	public VkBuildAccelerationStructureModeKHR mode;
	public VkAccelerationStructureKHR srcAccelerationStructure;
	public VkAccelerationStructureKHR dstAccelerationStructure;
	public uint geometryCount;
	public VkAccelerationStructureGeometryKHR* pGeometries;
	public VkAccelerationStructureGeometryKHR** ppGeometries;
	public VkDeviceOrHostAddressKHR scratchData;
}
public unsafe struct VkAccelerationStructureGeometryKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkAccelerationStructureGeometryDataKHR geometry;
	public VkGeometryFlagsKHR flags;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryInstancesDataKHR instances;
}
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat vertexFormat;
	public VkDeviceOrHostAddressConstKHR vertexData;
	public VkDeviceSize vertexStride;
	public uint maxVertex;
	public VkIndexType indexType;
	public VkDeviceOrHostAddressConstKHR indexData;
	public VkDeviceOrHostAddressConstKHR transformData;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressConstKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress deviceAddress;
	[FieldOffset(0)]
	public void* hostAddress;
}
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR data;
	public VkDeviceSize stride;
}
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 arrayOfPointers;
	public VkDeviceOrHostAddressConstKHR data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress deviceAddress;
	[FieldOffset(0)]
	public void* hostAddress;
}
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
	public uint primitiveCount;
	public uint primitiveOffset;
	public uint firstVertex;
	public uint transformOffset;
}
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR src;
	public VkDeviceOrHostAddressKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR accelerationStructure;
}
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public byte* pVersionData;
}
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize accelerationStructureSize;
	public VkDeviceSize updateScratchSize;
	public VkDeviceSize buildScratchSize;
}
public unsafe struct VkAabbPositionsKHR
{
	public float minX;
	public float minY;
	public float minZ;
	public float maxX;
	public float maxY;
	public float maxZ;
}
public unsafe struct VkTransformMatrixKHR
{
	public fixed float matrix[12];
}
public unsafe struct VkAccelerationStructureInstanceKHR
{
	public VkTransformMatrixKHR transform;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint accelerationStructureCount;
	public VkAccelerationStructureKHR* pAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 accelerationStructure;
	public VkBool32 accelerationStructureCaptureReplay;
	public VkBool32 accelerationStructureIndirectBuild;
	public VkBool32 accelerationStructureHostCommands;
	public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong maxGeometryCount;
	public ulong maxInstanceCount;
	public ulong maxPrimitiveCount;
	public uint maxPerStageDescriptorAccelerationStructures;
	public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
	public uint maxDescriptorSetAccelerationStructures;
	public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
	public uint minAccelerationStructureScratchOffsetAlignment;
}
public unsafe struct VkStridedDeviceAddressRegionKHR
{
	public VkDeviceAddress deviceAddress;
	public VkDeviceSize stride;
	public VkDeviceSize size;
}
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public uint groupCount;
	public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
	public uint maxPipelineRayRecursionDepth;
	public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
	public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
	public VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint generalShader;
	public uint closestHitShader;
	public uint anyHitShader;
	public uint intersectionShader;
	public void* pShaderGroupCaptureReplayHandle;
}
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint libraryCount;
	public VkPipeline* pLibraries;
}
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxPipelineRayPayloadSize;
	public uint maxPipelineRayHitAttributeSize;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingPipeline;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
	public VkBool32 rayTracingPipelineTraceRaysIndirect;
	public VkBool32 rayTraversalPrimitiveCulling;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint shaderGroupHandleSize;
	public uint maxRayRecursionDepth;
	public uint maxShaderGroupStride;
	public uint shaderGroupBaseAlignment;
	public uint shaderGroupHandleCaptureReplaySize;
	public uint maxRayDispatchInvocationCount;
	public uint shaderGroupHandleAlignment;
	public uint maxRayHitAttributeSize;
}
public unsafe struct VkTraceRaysIndirectCommandKHR
{
	public uint width;
	public uint height;
	public uint depth;
}
public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayQuery;
}
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageModulationStateCreateFlagsNV flags;
	public VkCoverageModulationModeNV coverageModulationMode;
	public VkBool32 coverageModulationTableEnable;
	public uint coverageModulationTableCount;
	public float* pCoverageModulationTable;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint shaderSMCount;
	public uint shaderWarpsPerSM;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSMBuiltins;
}
[Obsolete("Use VkSamplerYcbcrConversionCreateInfo")]
public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversion ycbcrModel;
	public VkSamplerYcbcrRange ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocation xChromaOffset;
	public VkChromaLocation yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}
[Obsolete("Use VkSamplerYcbcrConversionInfo")]
public unsafe struct VkSamplerYcbcrConversionInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerYcbcrConversion conversion;
}
[Obsolete("Use VkBindImagePlaneMemoryInfo")]
public unsafe struct VkBindImagePlaneMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlags planeAspect;
}
[Obsolete("Use VkImagePlaneMemoryRequirementsInfo")]
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlags planeAspect;
}
[Obsolete("Use VkPhysicalDeviceSamplerYcbcrConversionFeatures")]
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerYcbcrConversion;
}
[Obsolete("Use VkSamplerYcbcrConversionImageFormatProperties")]
public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint combinedImageSamplerDescriptorCount;
}
[Obsolete("Use VkBindBufferMemoryInfo")]
public unsafe struct VkBindBufferMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
[Obsolete("Use VkBindImageMemoryInfo")]
public unsafe struct VkBindImageMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public ulong drmFormatModifier;
}
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint drmFormatModifierCount;
	public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
}
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public ulong drmFormatModifier;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public uint* pQueueFamilyIndices;
}
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint drmFormatModifierCount;
	public ulong* pDrmFormatModifiers;
}
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public VkSubresourceLayout* pPlaneLayouts;
}
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint drmFormatModifierCount;
	public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierProperties2EXT
{
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
}
public unsafe struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkValidationCacheCreateFlagsEXT flags;
	public nuint initialDataSize;
	public void* pInitialData;
}
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkValidationCacheEXT validationCache;
}
[Obsolete("Use VkDescriptorSetLayoutBindingFlagsCreateInfo")]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint bindingCount;
	public VkDescriptorBindingFlags* pBindingFlags;
}
[Obsolete("Use VkPhysicalDeviceDescriptorIndexingFeatures")]
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
}
[Obsolete("Use VkPhysicalDeviceDescriptorIndexingProperties")]
public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint maxPerStageUpdateAfterBindResources;
	public uint maxDescriptorSetUpdateAfterBindSamplers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindSampledImages;
	public uint maxDescriptorSetUpdateAfterBindStorageImages;
	public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}
[Obsolete("Use VkDescriptorSetVariableDescriptorCountAllocateInfo")]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint descriptorSetCount;
	public uint* pDescriptorCounts;
}
[Obsolete("Use VkDescriptorSetVariableDescriptorCountLayoutSupport")]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxVariableDescriptorCount;
}
public unsafe struct VkShadingRatePaletteNV
{
	public uint shadingRatePaletteEntryCount;
	public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
}
public unsafe struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV shadingRate;
	public uint sampleCount;
	public uint sampleLocationCount;
	public VkCoarseSampleLocationNV* pSampleLocations;
}
public unsafe struct VkCoarseSampleLocationNV
{
	public uint pixelX;
	public uint pixelY;
	public uint sample;
}
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shadingRateImageEnable;
	public uint viewportCount;
	public VkShadingRatePaletteNV* pShadingRatePalettes;
}
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shadingRateImage;
	public VkBool32 shadingRateCoarseSampleOrder;
}
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D shadingRateTexelSize;
	public uint shadingRatePaletteSize;
	public uint shadingRateMaxCoarseSamples;
}
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkCoarseSampleOrderTypeNV sampleOrderType;
	public uint customSampleOrderCount;
	public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
}
public unsafe struct VkAccelerationStructureCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize compactedSize;
	public VkAccelerationStructureInfoNV info;
}
public unsafe struct VkAccelerationStructureInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureTypeNV type;
	public VkBuildAccelerationStructureFlagsNV flags;
	public uint instanceCount;
	public uint geometryCount;
	public VkGeometryNV* pGeometries;
}
public unsafe struct VkGeometryNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkGeometryDataNV geometry;
	public VkGeometryFlagsKHR flags;
}
public unsafe struct VkGeometryDataNV
{
	public VkGeometryTrianglesNV triangles;
	public VkGeometryAABBNV aabbs;
}
public unsafe struct VkGeometryTrianglesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer vertexData;
	public VkDeviceSize vertexOffset;
	public uint vertexCount;
	public VkDeviceSize vertexStride;
	public VkFormat vertexFormat;
	public VkBuffer indexData;
	public VkDeviceSize indexOffset;
	public uint indexCount;
	public VkIndexType indexType;
	public VkBuffer transformData;
	public VkDeviceSize transformOffset;
}
public unsafe struct VkGeometryAABBNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer aabbData;
	public uint numAABBs;
	public uint stride;
	public VkDeviceSize offset;
}
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureMemoryRequirementsTypeNV type;
	public VkAccelerationStructureNV accelerationStructure;
}
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureNV accelerationStructure;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
}
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public uint groupCount;
	public VkRayTracingShaderGroupCreateInfoNV* pGroups;
	public uint maxRecursionDepth;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint generalShader;
	public uint closestHitShader;
	public uint anyHitShader;
	public uint intersectionShader;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint accelerationStructureCount;
	public VkAccelerationStructureNV* pAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint shaderGroupHandleSize;
	public uint maxRecursionDepth;
	public uint maxShaderGroupStride;
	public uint shaderGroupBaseAlignment;
	public ulong maxGeometryCount;
	public ulong maxInstanceCount;
	public ulong maxTriangleCount;
	public uint maxDescriptorSetAccelerationStructures;
}
[Obsolete("Use VkTransformMatrixKHR")]
public unsafe struct VkTransformMatrixNV
{
	public fixed float matrix[12];
}
[Obsolete("Use VkAabbPositionsKHR")]
public unsafe struct VkAabbPositionsNV
{
	public float minX;
	public float minY;
	public float minZ;
	public float maxX;
	public float maxY;
	public float maxZ;
}
[Obsolete("Use VkAccelerationStructureInstanceKHR")]
public unsafe struct VkAccelerationStructureInstanceNV
{
	public VkTransformMatrixKHR transform;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}
public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 representativeFragmentTest;
}
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 representativeFragmentTestEnable;
}
[Obsolete("Use VkPhysicalDeviceMaintenance3Properties")]
public unsafe struct VkPhysicalDeviceMaintenance3PropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
[Obsolete("Use VkDescriptorSetLayoutSupport")]
public unsafe struct VkDescriptorSetLayoutSupportKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supported;
}
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageViewType imageViewType;
}
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterCubic;
	public VkBool32 filterCubicMinmax;
}
[Obsolete("Use VkDeviceQueueGlobalPriorityCreateInfoKHR")]
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityKHR globalPriority;
}
[Obsolete("Use VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures")]
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}
[Obsolete("Use VkPhysicalDevice8BitStorageFeatures")]
public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
}
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint memoryTypeBits;
}
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public void* pHostPointer;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize minImportedHostPointerAlignment;
}
[Obsolete("Use VkPhysicalDeviceShaderAtomicInt64Features")]
public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupClock;
	public VkBool32 shaderDeviceClock;
}
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
}
public unsafe struct VkCalibratedTimestampInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkTimeDomainEXT timeDomain;
}
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public uint shaderEngineCount;
	public uint shaderArraysPerEngineCount;
	public uint computeUnitsPerShaderArray;
	public uint simdPerComputeUnit;
	public uint wavefrontsPerSimd;
	public uint wavefrontSize;
	public uint sgprsPerSimd;
	public uint minSgprAllocation;
	public uint maxSgprAllocation;
	public uint sgprAllocationGranularity;
	public uint vgprsPerSimd;
	public uint minVgprAllocation;
	public uint maxVgprAllocation;
	public uint vgprAllocationGranularity;
}
public unsafe struct VkVideoDecodeH265ProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH265ProfileIdc stdProfileIdc;
}
public unsafe struct VkVideoDecodeH265CapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH265LevelIdc maxLevelIdc;
}
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxStdVPSCount;
	public uint maxStdSPSCount;
	public uint maxStdPPSCount;
	public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
}
public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint stdVPSCount;
	public StdVideoH265VideoParameterSet* pStdVPSs;
	public uint stdSPSCount;
	public StdVideoH265SequenceParameterSet* pStdSPSs;
	public uint stdPPSCount;
	public StdVideoH265PictureParameterSet* pStdPPSs;
}
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH265PictureInfo* pStdPictureInfo;
	public uint sliceSegmentCount;
	public uint* pSliceSegmentOffsets;
}
public unsafe struct VkVideoDecodeH265DpbSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
}
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityKHR globalPriority;
}
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 globalPriorityQuery;
}
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint priorityCount;
	public VkQueueGlobalPriorityKHR priorities_0;
	public VkQueueGlobalPriorityKHR priorities_1;
	public VkQueueGlobalPriorityKHR priorities_2;
	public VkQueueGlobalPriorityKHR priorities_3;
	public VkQueueGlobalPriorityKHR priorities_4;
	public VkQueueGlobalPriorityKHR priorities_5;
	public VkQueueGlobalPriorityKHR priorities_6;
	public VkQueueGlobalPriorityKHR priorities_7;
	public VkQueueGlobalPriorityKHR priorities_8;
	public VkQueueGlobalPriorityKHR priorities_9;
	public VkQueueGlobalPriorityKHR priorities_10;
	public VkQueueGlobalPriorityKHR priorities_11;
	public VkQueueGlobalPriorityKHR priorities_12;
	public VkQueueGlobalPriorityKHR priorities_13;
	public VkQueueGlobalPriorityKHR priorities_14;
	public VkQueueGlobalPriorityKHR priorities_15;
}
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxVertexAttribDivisor;
}
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
	public uint binding;
	public uint divisor;
}
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint vertexBindingDivisorCount;
	public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vertexAttributeInstanceRateDivisor;
	public VkBool32 vertexAttributeInstanceRateZeroDivisor;
}
[Obsolete("Use VkPipelineCreationFeedbackCreateInfo")]
public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreationFeedback* pPipelineCreationFeedback;
	public uint pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedback** pPipelineStageCreationFeedbacks;
}
[Obsolete("Use VkPipelineCreationFeedback")]
public unsafe struct VkPipelineCreationFeedbackEXT
{
	public VkPipelineCreationFeedbackFlags flags;
	public ulong duration;
}
[Obsolete("Use VkConformanceVersion")]
public unsafe struct VkConformanceVersionKHR
{
	public byte major;
	public byte minor;
	public byte subminor;
	public byte patch;
}
[Obsolete("Use VkPhysicalDeviceDriverProperties")]
public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed byte driverName[(int)VK.MaxDriverNameSize];
	public fixed byte driverInfo[(int)VK.MaxDriverInfoSize];
	public VkConformanceVersion conformanceVersion;
}
[Obsolete("Use VkPhysicalDeviceFloatControlsProperties")]
public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
}
[Obsolete("Use VkSubpassDescriptionDepthStencilResolve")]
public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags depthResolveMode;
	public VkResolveModeFlags stencilResolveMode;
	public VkAttachmentReference2* pDepthStencilResolveAttachment;
}
[Obsolete("Use VkPhysicalDeviceDepthStencilResolveProperties")]
public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
}
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 computeDerivativeGroupQuads;
	public VkBool32 computeDerivativeGroupLinear;
}
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 taskShader;
	public VkBool32 meshShader;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxDrawMeshTasksCount;
	public uint maxTaskWorkGroupInvocations;
	public fixed uint maxTaskWorkGroupSize[3];
	public uint maxTaskTotalMemorySize;
	public uint maxTaskOutputCount;
	public uint maxMeshWorkGroupInvocations;
	public fixed uint maxMeshWorkGroupSize[3];
	public uint maxMeshTotalMemorySize;
	public uint maxMeshOutputVertices;
	public uint maxMeshOutputPrimitives;
	public uint maxMeshMultiviewViewCount;
	public uint meshOutputPerVertexGranularity;
	public uint meshOutputPerPrimitiveGranularity;
}
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
	public uint taskCount;
	public uint firstTask;
}
[Obsolete("Use VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR")]
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageFootprint;
}
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint exclusiveScissorCount;
	public VkRect2D* pExclusiveScissors;
}
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 exclusiveScissor;
}
public unsafe struct VkCheckpointDataNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags stage;
	public void* pCheckpointMarker;
}
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags checkpointExecutionStageMask;
}
[Obsolete("Use VkPhysicalDeviceTimelineSemaphoreFeatures")]
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 timelineSemaphore;
}
[Obsolete("Use VkPhysicalDeviceTimelineSemaphoreProperties")]
public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong maxTimelineSemaphoreValueDifference;
}
[Obsolete("Use VkSemaphoreTypeCreateInfo")]
public unsafe struct VkSemaphoreTypeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreType semaphoreType;
	public ulong initialValue;
}
[Obsolete("Use VkTimelineSemaphoreSubmitInfo")]
public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreValueCount;
	public ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValueCount;
	public ulong* pSignalSemaphoreValues;
}
[Obsolete("Use VkSemaphoreWaitInfo")]
public unsafe struct VkSemaphoreWaitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreWaitFlags flags;
	public uint semaphoreCount;
	public VkSemaphore* pSemaphores;
	public ulong* pValues;
}
[Obsolete("Use VkSemaphoreSignalInfo")]
public unsafe struct VkSemaphoreSignalInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
}
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerFunctions2;
}
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public void* pUserData;
}
public unsafe struct VkPerformanceMarkerInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public ulong marker;
}
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public uint marker;
}
public unsafe struct VkPerformanceOverrideInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceOverrideTypeINTEL type;
	public VkBool32 enable;
	public ulong parameter;
}
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceConfigurationTypeINTEL type;
}
public unsafe struct VkPerformanceValueINTEL
{
	public VkPerformanceValueTypeINTEL type;
	public VkPerformanceValueDataINTEL data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
	[FieldOffset(0)]
	public uint value32;
	[FieldOffset(0)]
	public ulong value64;
	[FieldOffset(0)]
	public float valueFloat;
	[FieldOffset(0)]
	public VkBool32 valueBool;
	[FieldOffset(0)]
	public byte* valueString;
}
[Obsolete("Use VkQueryPoolPerformanceQueryCreateInfoINTEL")]
public unsafe struct VkQueryPoolCreateInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}
[Obsolete("Use VkPhysicalDeviceVulkanMemoryModelFeatures")]
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint pciDomain;
	public uint pciBus;
	public uint pciDevice;
	public uint pciFunction;
}
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 localDimmingSupport;
}
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 localDimmingEnable;
}
[Obsolete("Use VkPhysicalDeviceShaderTerminateInvocationFeatures")]
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderTerminateInvocation;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMap;
	public VkBool32 fragmentDensityMapDynamic;
	public VkBool32 fragmentDensityMapNonSubsampledImages;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D minFragmentDensityTexelSize;
	public VkExtent2D maxFragmentDensityTexelSize;
	public VkBool32 fragmentDensityInvocations;
}
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentReference fragmentDensityMapAttachment;
}
[Obsolete("Use VkPhysicalDeviceScalarBlockLayoutFeatures")]
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 scalarBlockLayout;
}
[Obsolete("Use VkPhysicalDeviceSubgroupSizeControlFeatures")]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}
[Obsolete("Use VkPhysicalDeviceSubgroupSizeControlProperties")]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
[Obsolete("Use VkPipelineShaderStageRequiredSubgroupSizeCreateInfo")]
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint requiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags sampleCounts;
	public VkExtent2D fragmentSize;
}
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentReference2* pFragmentShadingRateAttachment;
	public VkExtent2D shadingRateAttachmentTexelSize;
}
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D fragmentSize;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineFragmentShadingRate;
	public VkBool32 primitiveFragmentShadingRate;
	public VkBool32 attachmentFragmentShadingRate;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
	public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
	public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
	public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
	public VkBool32 layeredShadingRateAttachments;
	public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
	public VkExtent2D maxFragmentSize;
	public uint maxFragmentSizeAspectRatio;
	public uint maxFragmentShadingRateCoverageSamples;
	public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
	public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
	public VkBool32 fragmentShadingRateWithSampleMask;
	public VkBool32 fragmentShadingRateWithShaderSampleMask;
	public VkBool32 fragmentShadingRateWithConservativeRasterization;
	public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
	public VkBool32 fragmentShadingRateWithCustomSampleLocations;
	public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
}
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
	public uint activeComputeUnitCount;
}
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceCoherentMemory;
}
public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderImageInt64Atomics;
	public VkBool32 sparseImageInt64Atomics;
}
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize heapBudget_0;
	public VkDeviceSize heapBudget_1;
	public VkDeviceSize heapBudget_2;
	public VkDeviceSize heapBudget_3;
	public VkDeviceSize heapBudget_4;
	public VkDeviceSize heapBudget_5;
	public VkDeviceSize heapBudget_6;
	public VkDeviceSize heapBudget_7;
	public VkDeviceSize heapBudget_8;
	public VkDeviceSize heapBudget_9;
	public VkDeviceSize heapBudget_10;
	public VkDeviceSize heapBudget_11;
	public VkDeviceSize heapBudget_12;
	public VkDeviceSize heapBudget_13;
	public VkDeviceSize heapBudget_14;
	public VkDeviceSize heapBudget_15;
	public VkDeviceSize heapUsage_0;
	public VkDeviceSize heapUsage_1;
	public VkDeviceSize heapUsage_2;
	public VkDeviceSize heapUsage_3;
	public VkDeviceSize heapUsage_4;
	public VkDeviceSize heapUsage_5;
	public VkDeviceSize heapUsage_6;
	public VkDeviceSize heapUsage_7;
	public VkDeviceSize heapUsage_8;
	public VkDeviceSize heapUsage_9;
	public VkDeviceSize heapUsage_10;
	public VkDeviceSize heapUsage_11;
	public VkDeviceSize heapUsage_12;
	public VkDeviceSize heapUsage_13;
	public VkDeviceSize heapUsage_14;
	public VkDeviceSize heapUsage_15;
}
public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 memoryPriority;
}
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float priority;
}
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supportsProtected;
}
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocationImageAliasing;
}
[Obsolete("Use VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures")]
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}
[Obsolete("Use VkAttachmentReferenceStencilLayout")]
public unsafe struct VkAttachmentReferenceStencilLayoutKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilLayout;
}
[Obsolete("Use VkAttachmentDescriptionStencilLayout")]
public unsafe struct VkAttachmentDescriptionStencilLayoutKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilInitialLayout;
	public VkImageLayout stencilFinalLayout;
}
[Obsolete("Use VkPhysicalDeviceBufferDeviceAddressFeaturesEXT")]
public unsafe struct VkPhysicalDeviceBufferAddressFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
[Obsolete("Use VkBufferDeviceAddressInfo")]
public unsafe struct VkBufferDeviceAddressInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkBufferDeviceAddressCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress deviceAddress;
}
[Obsolete("Use VkPhysicalDeviceToolProperties")]
public unsafe struct VkPhysicalDeviceToolPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte name[(int)VK.MaxExtensionNameSize];
	public fixed byte version[(int)VK.MaxExtensionNameSize];
	public VkToolPurposeFlags purposes;
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public fixed byte layer[(int)VK.MaxExtensionNameSize];
}
[Obsolete("Use VkImageStencilUsageCreateInfo")]
public unsafe struct VkImageStencilUsageCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags stencilUsage;
}
public unsafe struct VkValidationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint enabledValidationFeatureCount;
	public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
	public uint disabledValidationFeatureCount;
	public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentWait;
}
public unsafe struct VkCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint MSize;
	public uint NSize;
	public uint KSize;
	public VkComponentTypeNV AType;
	public VkComponentTypeNV BType;
	public VkComponentTypeNV CType;
	public VkComponentTypeNV DType;
	public VkScopeNV scope;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 cooperativeMatrix;
	public VkBool32 cooperativeMatrixRobustBufferAccess;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderStageFlags cooperativeMatrixSupportedStages;
}
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkCoverageReductionModeNV coverageReductionMode;
	public VkSampleCountFlags rasterizationSamples;
	public VkSampleCountFlags depthStencilSamples;
	public VkSampleCountFlags colorSamples;
}
public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 coverageReductionMode;
}
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageReductionStateCreateFlagsNV flags;
	public VkCoverageReductionModeNV coverageReductionMode;
}
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderSampleInterlock;
	public VkBool32 fragmentShaderPixelInterlock;
	public VkBool32 fragmentShaderShadingRateInterlock;
}
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 ycbcrImageArrays;
}
[Obsolete("Use VkPhysicalDeviceUniformBufferStandardLayoutFeatures")]
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 uniformBufferStandardLayout;
}
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 provokingVertexLast;
	public VkBool32 transformFeedbackPreservesProvokingVertex;
}
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 provokingVertexModePerPipeline;
	public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
}
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkProvokingVertexModeEXT provokingVertexMode;
}
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkFullScreenExclusiveEXT fullScreenExclusive;
}
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fullScreenExclusiveSupported;
}
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public IntPtr hmonitor;
}
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkHeadlessSurfaceCreateFlagsEXT flags;
}
[Obsolete("Use VkPhysicalDeviceBufferDeviceAddressFeatures")]
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
[Obsolete("Use VkBufferDeviceAddressInfo")]
public unsafe struct VkBufferDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
[Obsolete("Use VkBufferOpaqueCaptureAddressCreateInfo")]
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
}
[Obsolete("Use VkMemoryOpaqueCaptureAddressAllocateInfo")]
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
}
[Obsolete("Use VkDeviceMemoryOpaqueCaptureAddressInfo")]
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rectangularLines;
	public VkBool32 bresenhamLines;
	public VkBool32 smoothLines;
	public VkBool32 stippledRectangularLines;
	public VkBool32 stippledBresenhamLines;
	public VkBool32 stippledSmoothLines;
}
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint lineSubPixelPrecisionBits;
}
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkLineRasterizationModeEXT lineRasterizationMode;
	public VkBool32 stippledLineEnable;
	public uint lineStippleFactor;
	public ushort lineStipplePattern;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferFloat32Atomics;
	public VkBool32 shaderBufferFloat32AtomicAdd;
	public VkBool32 shaderBufferFloat64Atomics;
	public VkBool32 shaderBufferFloat64AtomicAdd;
	public VkBool32 shaderSharedFloat32Atomics;
	public VkBool32 shaderSharedFloat32AtomicAdd;
	public VkBool32 shaderSharedFloat64Atomics;
	public VkBool32 shaderSharedFloat64AtomicAdd;
	public VkBool32 shaderImageFloat32Atomics;
	public VkBool32 shaderImageFloat32AtomicAdd;
	public VkBool32 sparseImageFloat32Atomics;
	public VkBool32 sparseImageFloat32AtomicAdd;
}
[Obsolete("Use VkPhysicalDeviceHostQueryResetFeatures")]
public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hostQueryReset;
}
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 indexTypeUint8;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState;
}
public unsafe struct VkPipelineInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
}
public unsafe struct VkPipelineExecutablePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderStageFlags stages;
	public fixed byte name[(int)VK.MaxDescriptionSize];
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public uint subgroupSize;
}
public unsafe struct VkPipelineExecutableInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
	public uint executableIndex;
}
public unsafe struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte name[(int)VK.MaxDescriptionSize];
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public VkPipelineExecutableStatisticFormatKHR format;
	public VkPipelineExecutableStatisticValueKHR value;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
	[FieldOffset(0)]
	public VkBool32 b32;
	[FieldOffset(0)]
	public long i64;
	[FieldOffset(0)]
	public ulong u64;
	[FieldOffset(0)]
	public double f64;
}
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte name[(int)VK.MaxDescriptionSize];
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public VkBool32 isText;
	public nuint dataSize;
	public void* pData;
}
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineExecutableInfo;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferFloat16Atomics;
	public VkBool32 shaderBufferFloat16AtomicAdd;
	public VkBool32 shaderBufferFloat16AtomicMinMax;
	public VkBool32 shaderBufferFloat32AtomicMinMax;
	public VkBool32 shaderBufferFloat64AtomicMinMax;
	public VkBool32 shaderSharedFloat16Atomics;
	public VkBool32 shaderSharedFloat16AtomicAdd;
	public VkBool32 shaderSharedFloat16AtomicMinMax;
	public VkBool32 shaderSharedFloat32AtomicMinMax;
	public VkBool32 shaderSharedFloat64AtomicMinMax;
	public VkBool32 shaderImageFloat32AtomicMinMax;
	public VkBool32 sparseImageFloat32AtomicMinMax;
}
public unsafe struct VkSurfacePresentModeEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentModeKHR presentMode;
}
public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentScalingFlagsEXT supportedPresentScaling;
	public VkPresentGravityFlagsEXT supportedPresentGravityX;
	public VkPresentGravityFlagsEXT supportedPresentGravityY;
	public VkExtent2D minScaledImageExtent;
	public VkExtent2D maxScaledImageExtent;
}
public unsafe struct VkSurfacePresentModeCompatibilityEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint presentModeCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkReleaseSwapchainImagesInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint imageIndexCount;
	public uint* pImageIndices;
}
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 swapchainMaintenance1;
}
public unsafe struct VkSwapchainPresentFenceInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public VkFence* pFences;
}
public unsafe struct VkSwapchainPresentModesCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint presentModeCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkSwapchainPresentModeInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentScalingFlagsEXT scalingBehavior;
	public VkPresentGravityFlagsEXT presentGravityX;
	public VkPresentGravityFlagsEXT presentGravityY;
}
[Obsolete("Use VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures")]
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint maxSequencesCount;
}
public unsafe struct VkGeneratedCommandsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint streamCount;
	public VkIndirectCommandsStreamNV* pStreams;
	public uint sequencesCount;
	public VkBuffer preprocessBuffer;
	public VkDeviceSize preprocessOffset;
	public VkDeviceSize preprocessSize;
	public VkBuffer sequencesCountBuffer;
	public VkDeviceSize sequencesCountOffset;
	public VkBuffer sequencesIndexBuffer;
	public VkDeviceSize sequencesIndexOffset;
}
public unsafe struct VkIndirectCommandsStreamNV
{
	public VkBuffer buffer;
	public VkDeviceSize offset;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndirectCommandsLayoutUsageFlagsNV flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint tokenCount;
	public VkIndirectCommandsLayoutTokenNV* pTokens;
	public uint streamCount;
	public uint* pStreamStrides;
}
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndirectCommandsTokenTypeNV tokenType;
	public uint stream;
	public uint offset;
	public uint vertexBindingUnit;
	public VkBool32 vertexDynamicStride;
	public VkPipelineLayout pushconstantPipelineLayout;
	public VkShaderStageFlags pushconstantShaderStageFlags;
	public uint pushconstantOffset;
	public uint pushconstantSize;
	public VkIndirectStateFlagsNV indirectStateFlags;
	public uint indexTypeCount;
	public VkIndexType* pIndexTypes;
	public uint* pIndexTypeValues;
}
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxGraphicsShaderGroupCount;
	public uint maxIndirectSequenceCount;
	public uint maxIndirectCommandsTokenCount;
	public uint maxIndirectCommandsStreamCount;
	public uint maxIndirectCommandsTokenOffset;
	public uint maxIndirectCommandsStreamStride;
	public uint minSequencesCountBufferOffsetAlignment;
	public uint minSequencesIndexBufferOffsetAlignment;
	public uint minIndirectCommandsBufferOffsetAlignment;
}
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceGeneratedCommands;
}
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public VkPipelineTessellationStateCreateInfo* pTessellationState;
}
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint groupCount;
	public VkGraphicsShaderGroupCreateInfoNV* pGroups;
	public uint pipelineCount;
	public VkPipeline* pPipelines;
}
public unsafe struct VkBindShaderGroupIndirectCommandNV
{
	public uint groupIndex;
}
public unsafe struct VkBindIndexBufferIndirectCommandNV
{
	public VkDeviceAddress bufferAddress;
	public uint size;
	public VkIndexType indexType;
}
public unsafe struct VkBindVertexBufferIndirectCommandNV
{
	public VkDeviceAddress bufferAddress;
	public uint size;
	public uint stride;
}
public unsafe struct VkSetStateFlagsIndirectCommandNV
{
	public uint data;
}
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inheritedViewportScissor2D;
}
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 viewportScissor2D;
	public uint viewportDepthCount;
	public VkViewport* pViewportDepths;
}
[Obsolete("Use VkPhysicalDeviceShaderIntegerDotProductFeatures")]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerDotProduct;
}
[Obsolete("Use VkPhysicalDeviceShaderIntegerDotProductProperties")]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 texelBufferAlignment;
}
[Obsolete("Use VkPhysicalDeviceTexelBufferAlignmentProperties")]
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
}
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
	public VkRect2D renderArea;
}
public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceMemoryReport;
}
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemoryReportFlagsEXT flags;
	public DeviceMemoryReportCallbackEXTDelegate pfnUserCallback;
	public void* pUserData;
}
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemoryReportFlagsEXT flags;
	public VkDeviceMemoryReportEventTypeEXT type;
	public ulong memoryObjectId;
	public VkDeviceSize size;
	public VkObjectType objectType;
	public ulong objectHandle;
	public uint heapIndex;
}
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustBufferAccess2;
	public VkBool32 robustImageAccess2;
	public VkBool32 nullDescriptor;
}
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize robustStorageBufferAccessSizeAlignment;
	public VkDeviceSize robustUniformBufferAccessSizeAlignment;
}
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkClearColorValue customBorderColor;
	public VkFormat format;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxCustomBorderColorSamplers;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 customBorderColors;
	public VkBool32 customBorderColorWithoutFormat;
}
public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrier;
}
public unsafe struct VkSurfaceCapabilitiesPresentBarrierNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrierSupported;
}
public unsafe struct VkSwapchainPresentBarrierCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrierEnable;
}
public unsafe struct VkPresentIdKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public ulong* pPresentIds;
}
public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentId;
}
[Obsolete("Use VkPhysicalDevicePrivateDataFeatures")]
public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 privateData;
}
[Obsolete("Use VkDevicePrivateDataCreateInfo")]
public unsafe struct VkDevicePrivateDataCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint privateDataSlotRequestCount;
}
[Obsolete("Use VkPrivateDataSlotCreateInfo")]
public unsafe struct VkPrivateDataSlotCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPrivateDataSlotCreateFlags flags;
}
[Obsolete("Use VkPhysicalDevicePipelineCreationCacheControlFeatures")]
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineCreationCacheControl;
}
public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 diagnosticsConfig;
}
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceDiagnosticsConfigFlagsNV flags;
}
[Obsolete("Use VkMemoryBarrier2")]
public unsafe struct VkMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
}
[Obsolete("Use VkBufferMemoryBarrier2")]
public unsafe struct VkBufferMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
[Obsolete("Use VkImageMemoryBarrier2")]
public unsafe struct VkImageMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
[Obsolete("Use VkDependencyInfo")]
public unsafe struct VkDependencyInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDependencyFlags dependencyFlags;
	public uint memoryBarrierCount;
	public VkMemoryBarrier2* pMemoryBarriers;
	public uint bufferMemoryBarrierCount;
	public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
	public uint imageMemoryBarrierCount;
	public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
[Obsolete("Use VkSubmitInfo2")]
public unsafe struct VkSubmitInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubmitFlags flags;
	public uint waitSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
	public uint commandBufferInfoCount;
	public VkCommandBufferSubmitInfo* pCommandBufferInfos;
	public uint signalSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}
[Obsolete("Use VkSemaphoreSubmitInfo")]
public unsafe struct VkSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
	public VkPipelineStageFlags2 stageMask;
	public uint deviceIndex;
}
[Obsolete("Use VkCommandBufferSubmitInfo")]
public unsafe struct VkCommandBufferSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBuffer commandBuffer;
	public uint deviceMask;
}
[Obsolete("Use VkPhysicalDeviceSynchronization2Features")]
public unsafe struct VkPhysicalDeviceSynchronization2FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 synchronization2;
}
public unsafe struct VkCheckpointData2NV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 stage;
	public void* pCheckpointMarker;
}
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 checkpointExecutionStageMask;
}
public unsafe struct VkDescriptorGetInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorType type;
	public VkDescriptorDataEXT data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDescriptorDataEXT
{
	[FieldOffset(0)]
	public VkSampler* pSampler;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pCombinedImageSampler;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pInputAttachmentImage;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pSampledImage;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pStorageImage;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pUniformBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pStorageBuffer;
	[FieldOffset(0)]
	public VkDeviceAddress accelerationStructure;
}
public unsafe struct VkDescriptorAddressInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress address;
	public VkDeviceSize range;
	public VkFormat format;
}
public unsafe struct VkDescriptorBufferBindingInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress address;
	public VkBufferUsageFlags usage;
}
public unsafe struct VkBufferCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkImageCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
}
public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampler sampler;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 combinedImageSamplerDescriptorSingleArray;
	public VkBool32 bufferlessPushDescriptors;
	public VkBool32 allowSamplerImageViewPostSubmitCreation;
	public VkDeviceSize descriptorBufferOffsetAlignment;
	public uint maxDescriptorBufferBindings;
	public uint maxResourceDescriptorBufferBindings;
	public uint maxSamplerDescriptorBufferBindings;
	public uint maxEmbeddedImmutableSamplerBindings;
	public uint maxEmbeddedImmutableSamplers;
	public nuint bufferCaptureReplayDescriptorDataSize;
	public nuint imageCaptureReplayDescriptorDataSize;
	public nuint imageViewCaptureReplayDescriptorDataSize;
	public nuint samplerCaptureReplayDescriptorDataSize;
	public nuint accelerationStructureCaptureReplayDescriptorDataSize;
	public nuint samplerDescriptorSize;
	public nuint combinedImageSamplerDescriptorSize;
	public nuint sampledImageDescriptorSize;
	public nuint storageImageDescriptorSize;
	public nuint uniformTexelBufferDescriptorSize;
	public nuint robustUniformTexelBufferDescriptorSize;
	public nuint storageTexelBufferDescriptorSize;
	public nuint robustStorageTexelBufferDescriptorSize;
	public nuint uniformBufferDescriptorSize;
	public nuint robustUniformBufferDescriptorSize;
	public nuint storageBufferDescriptorSize;
	public nuint robustStorageBufferDescriptorSize;
	public nuint inputAttachmentDescriptorSize;
	public nuint accelerationStructureDescriptorSize;
	public VkDeviceSize maxSamplerDescriptorBufferRange;
	public VkDeviceSize maxResourceDescriptorBufferRange;
	public VkDeviceSize samplerDescriptorBufferAddressSpaceSize;
	public VkDeviceSize resourceDescriptorBufferAddressSpaceSize;
	public VkDeviceSize descriptorBufferAddressSpaceSize;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public nuint combinedImageSamplerDensityMapDescriptorSize;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 descriptorBuffer;
	public VkBool32 descriptorBufferCaptureReplay;
	public VkBool32 descriptorBufferImageLayoutIgnored;
	public VkBool32 descriptorBufferPushDescriptors;
}
public unsafe struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public void* opaqueCaptureDescriptorData;
}
public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR accelerationStructure;
	public VkAccelerationStructureNV accelerationStructureNV;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 graphicsPipelineLibrary;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 graphicsPipelineLibraryFastLinking;
	public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
}
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkGraphicsPipelineLibraryFlagsEXT flags;
}
public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderEarlyAndLateFragmentTests;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 triStripVertexOrderIndependentOfProvokingVertex;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupUniformControlFlow;
}
[Obsolete("Use VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures")]
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShadingRateEnums;
	public VkBool32 supersampleFragmentShadingRates;
	public VkBool32 noInvocationFragmentShadingRates;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
}
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkFragmentShadingRateTypeNV shadingRateType;
	public VkFragmentShadingRateNV shadingRate;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR vertexData;
}
public unsafe struct VkAccelerationStructureMotionInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxInstances;
	public VkAccelerationStructureMotionInfoFlagsNV flags;
}
public unsafe struct VkAccelerationStructureMotionInstanceNV
{
	public VkAccelerationStructureMotionInstanceTypeNV type;
	public VkAccelerationStructureMotionInstanceFlagsNV flags;
	public VkAccelerationStructureMotionInstanceDataNV data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
	[FieldOffset(0)]
	public VkAccelerationStructureInstanceKHR staticInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
}
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
	public VkTransformMatrixKHR transformT0;
	public VkTransformMatrixKHR transformT1;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
	public VkSRTDataNV transformT0;
	public VkSRTDataNV transformT1;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}
public unsafe struct VkSRTDataNV
{
	public float sx;
	public float a;
	public float b;
	public float pvx;
	public float sy;
	public float c;
	public float pvy;
	public float sz;
	public float pvz;
	public float qx;
	public float qy;
	public float qz;
	public float qw;
	public float tx;
	public float ty;
	public float tz;
}
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingMotionBlur;
	public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
}
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 taskShader;
	public VkBool32 meshShader;
	public VkBool32 multiviewMeshShader;
	public VkBool32 primitiveFragmentShadingRateMeshShader;
	public VkBool32 meshShaderQueries;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxTaskWorkGroupTotalCount;
	public fixed uint maxTaskWorkGroupCount[3];
	public uint maxTaskWorkGroupInvocations;
	public fixed uint maxTaskWorkGroupSize[3];
	public uint maxTaskPayloadSize;
	public uint maxTaskSharedMemorySize;
	public uint maxTaskPayloadAndSharedMemorySize;
	public uint maxMeshWorkGroupTotalCount;
	public fixed uint maxMeshWorkGroupCount[3];
	public uint maxMeshWorkGroupInvocations;
	public fixed uint maxMeshWorkGroupSize[3];
	public uint maxMeshSharedMemorySize;
	public uint maxMeshPayloadAndSharedMemorySize;
	public uint maxMeshOutputMemorySize;
	public uint maxMeshPayloadAndOutputMemorySize;
	public uint maxMeshOutputComponents;
	public uint maxMeshOutputVertices;
	public uint maxMeshOutputPrimitives;
	public uint maxMeshOutputLayers;
	public uint maxMeshMultiviewViewCount;
	public uint meshOutputPerVertexGranularity;
	public uint meshOutputPerPrimitiveGranularity;
	public uint maxPreferredTaskWorkGroupInvocations;
	public uint maxPreferredMeshWorkGroupInvocations;
	public VkBool32 prefersLocalInvocationVertexOutput;
	public VkBool32 prefersLocalInvocationPrimitiveOutput;
	public VkBool32 prefersCompactVertexOutput;
	public VkBool32 prefersCompactPrimitiveOutput;
}
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
	public uint groupCountX;
	public uint groupCountY;
	public uint groupCountZ;
}
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 ycbcr2plane444Formats;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMapDeferred;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subsampledLoads;
	public VkBool32 subsampledCoarseReconstructionEarlyAccess;
	public uint maxSubsampledArrayLayers;
	public uint maxDescriptorSetSubsampledSamplers;
}
public unsafe struct VkCopyCommandTransformInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
}
[Obsolete("Use VkPhysicalDeviceImageRobustnessFeatures")]
public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
}
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 workgroupMemoryExplicitLayout;
	public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
	public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
	public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
}
[Obsolete("Use VkCopyBufferInfo2")]
public unsafe struct VkCopyBufferInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public VkBufferCopy2* pRegions;
}
[Obsolete("Use VkCopyImageInfo2")]
public unsafe struct VkCopyImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageCopy2* pRegions;
}
[Obsolete("Use VkCopyBufferToImageInfo2")]
public unsafe struct VkCopyBufferToImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkBufferImageCopy2* pRegions;
}
[Obsolete("Use VkCopyImageToBufferInfo2")]
public unsafe struct VkCopyImageToBufferInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public VkBufferImageCopy2* pRegions;
}
[Obsolete("Use VkBlitImageInfo2")]
public unsafe struct VkBlitImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageBlit2* pRegions;
	public VkFilter filter;
}
[Obsolete("Use VkResolveImageInfo2")]
public unsafe struct VkResolveImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public VkImageResolve2* pRegions;
}
[Obsolete("Use VkBufferCopy2")]
public unsafe struct VkBufferCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
[Obsolete("Use VkImageCopy2")]
public unsafe struct VkImageCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
[Obsolete("Use VkImageBlit2")]
public unsafe struct VkImageBlit2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
[Obsolete("Use VkBufferImageCopy2")]
public unsafe struct VkBufferImageCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize bufferOffset;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
[Obsolete("Use VkImageResolve2")]
public unsafe struct VkImageResolve2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkImageSubresource2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresource imageSubresource;
}
public unsafe struct VkSubresourceLayout2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubresourceLayout subresourceLayout;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageCompressionControl;
}
public unsafe struct VkImageCompressionControlEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCompressionFlagsEXT flags;
	public uint compressionControlPlaneCount;
	public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
}
public unsafe struct VkImageCompressionPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCompressionFlagsEXT imageCompressionFlags;
	public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
}
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 attachmentFeedbackLoopLayout;
}
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 formatA4R4G4B4;
	public VkBool32 formatA4B4G4R4;
}
public unsafe struct VkDeviceFaultCountsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint addressInfoCount;
	public uint vendorInfoCount;
	public VkDeviceSize vendorBinarySize;
}
public unsafe struct VkDeviceFaultInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public VkDeviceFaultAddressInfoEXT* pAddressInfos;
	public VkDeviceFaultVendorInfoEXT* pVendorInfos;
	public void* pVendorBinaryData;
}
public unsafe struct VkDeviceFaultAddressInfoEXT
{
	public VkDeviceFaultAddressTypeEXT addressType;
	public VkDeviceAddress reportedAddress;
	public VkDeviceSize addressPrecision;
}
public unsafe struct VkDeviceFaultVendorInfoEXT
{
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public ulong vendorFaultCode;
	public ulong vendorFaultData;
}
public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceFault;
	public VkBool32 deviceFaultVendorBinary;
}
public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
	public uint headerSize;
	public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
	public uint vendorID;
	public uint deviceID;
	public uint driverVersion;
	public fixed byte pipelineCacheUUID[(int)VK.UuidSize];
	public uint applicationNameOffset;
	public uint applicationVersion;
	public uint engineNameOffset;
}
[Obsolete("Use VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT")]
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rasterizationOrderColorAttachmentAccess;
	public VkBool32 rasterizationOrderDepthAttachmentAccess;
	public VkBool32 rasterizationOrderStencilAttachmentAccess;
}
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 formatRgba10x6WithoutYCbCrSampler;
}
[Obsolete("Use VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT")]
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 mutableDescriptorType;
}
[Obsolete("Use VkMutableDescriptorTypeListEXT")]
public unsafe struct VkMutableDescriptorTypeListVALVE
{
	public uint descriptorTypeCount;
	public VkDescriptorType* pDescriptorTypes;
}
[Obsolete("Use VkMutableDescriptorTypeCreateInfoEXT")]
public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public uint mutableDescriptorTypeListCount;
	public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}
public unsafe struct VkVertexInputBindingDescription2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint binding;
	public uint stride;
	public VkVertexInputRate inputRate;
	public uint divisor;
}
public unsafe struct VkVertexInputAttributeDescription2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint location;
	public uint binding;
	public VkFormat format;
	public uint offset;
}
public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vertexInputDynamicState;
}
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hasPrimary;
	public VkBool32 hasRender;
	public long primaryMajor;
	public long primaryMinor;
	public long renderMajor;
	public long renderMinor;
}
public unsafe struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 reportAddressBinding;
}
public unsafe struct VkDeviceAddressBindingCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddressBindingFlagsEXT flags;
	public VkDeviceAddress baseAddress;
	public VkDeviceSize size;
	public VkDeviceAddressBindingTypeEXT bindingType;
}
public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClipControl;
}
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 negativeOneToOne;
}
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 primitiveTopologyListRestart;
	public VkBool32 primitiveTopologyPatchListRestart;
}
[Obsolete("Use VkFormatProperties3")]
public unsafe struct VkFormatProperties3KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatFeatureFlags2 linearTilingFeatures;
	public VkFormatFeatureFlags2 optimalTilingFeatures;
	public VkFormatFeatureFlags2 bufferFeatures;
}
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public uint subpass;
}
public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subpassShading;
}
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxSubpassShadingWorkgroupSizeAspectRatio;
}
public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 invocationMask;
}
public unsafe struct VkMemoryGetRemoteAddressInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}
public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 externalMemoryRDMA;
}
[Obsolete("Use VkPipelineInfoKHR")]
public unsafe struct VkPipelineInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
}
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte pipelineIdentifier[(int)VK.UuidSize];
}
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelinePropertiesIdentifier;
}
public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multisampledRenderToSingleSampled;
}
public unsafe struct VkSubpassResolvePerformanceQueryEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 optimal;
}
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multisampledRenderToSingleSampledEnable;
	public VkSampleCountFlags rasterizationSamples;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState2;
	public VkBool32 extendedDynamicState2LogicOp;
	public VkBool32 extendedDynamicState2PatchControlPoints;
}
public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 colorWriteEnable;
}
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentCount;
	public VkBool32* pColorWriteEnables;
}
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 primitivesGeneratedQuery;
	public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
	public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
}
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingMaintenance1;
	public VkBool32 rayTracingPipelineTraceRaysIndirect2;
}
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
	public VkDeviceAddress raygenShaderRecordAddress;
	public VkDeviceSize raygenShaderRecordSize;
	public VkDeviceAddress missShaderBindingTableAddress;
	public VkDeviceSize missShaderBindingTableSize;
	public VkDeviceSize missShaderBindingTableStride;
	public VkDeviceAddress hitShaderBindingTableAddress;
	public VkDeviceSize hitShaderBindingTableSize;
	public VkDeviceSize hitShaderBindingTableStride;
	public VkDeviceAddress callableShaderBindingTableAddress;
	public VkDeviceSize callableShaderBindingTableSize;
	public VkDeviceSize callableShaderBindingTableStride;
	public uint width;
	public uint height;
	public uint depth;
}
[Obsolete("Use VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR")]
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 globalPriorityQuery;
}
[Obsolete("Use VkQueueFamilyGlobalPriorityPropertiesKHR")]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint priorityCount;
	public VkQueueGlobalPriorityKHR priorities_0;
	public VkQueueGlobalPriorityKHR priorities_1;
	public VkQueueGlobalPriorityKHR priorities_2;
	public VkQueueGlobalPriorityKHR priorities_3;
	public VkQueueGlobalPriorityKHR priorities_4;
	public VkQueueGlobalPriorityKHR priorities_5;
	public VkQueueGlobalPriorityKHR priorities_6;
	public VkQueueGlobalPriorityKHR priorities_7;
	public VkQueueGlobalPriorityKHR priorities_8;
	public VkQueueGlobalPriorityKHR priorities_9;
	public VkQueueGlobalPriorityKHR priorities_10;
	public VkQueueGlobalPriorityKHR priorities_11;
	public VkQueueGlobalPriorityKHR priorities_12;
	public VkQueueGlobalPriorityKHR priorities_13;
	public VkQueueGlobalPriorityKHR priorities_14;
	public VkQueueGlobalPriorityKHR priorities_15;
}
public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 minLod;
}
public unsafe struct VkImageViewMinLodCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float minLod;
}
public unsafe struct VkMultiDrawInfoEXT
{
	public uint firstVertex;
	public uint vertexCount;
}
public unsafe struct VkMultiDrawIndexedInfoEXT
{
	public uint firstIndex;
	public uint indexCount;
	public int vertexOffset;
}
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiDraw;
}
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxMultiDrawCount;
}
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 image2DViewOf3D;
	public VkBool32 sampler2DViewOf3D;
}
public unsafe struct VkMicromapCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapCreateFlagsEXT createFlags;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkMicromapTypeEXT type;
	public VkDeviceAddress deviceAddress;
}
public unsafe struct VkMicromapBuildInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapTypeEXT type;
	public VkBuildMicromapFlagsEXT flags;
	public VkBuildMicromapModeEXT mode;
	public VkMicromapEXT dstMicromap;
	public uint usageCountsCount;
	public VkMicromapUsageEXT* pUsageCounts;
	public VkMicromapUsageEXT** ppUsageCounts;
	public VkDeviceOrHostAddressConstKHR data;
	public VkDeviceOrHostAddressKHR scratchData;
	public VkDeviceOrHostAddressConstKHR triangleArray;
	public VkDeviceSize triangleArrayStride;
}
public unsafe struct VkMicromapUsageEXT
{
	public uint count;
	public uint subdivisionLevel;
	public uint format;
}
public unsafe struct VkCopyMicromapInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapEXT src;
	public VkMicromapEXT dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkCopyMicromapToMemoryInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapEXT src;
	public VkDeviceOrHostAddressKHR dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkCopyMemoryToMicromapInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR src;
	public VkMicromapEXT dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkMicromapVersionInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public byte* pVersionData;
}
public unsafe struct VkMicromapBuildSizesInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize micromapSize;
	public VkDeviceSize buildScratchSize;
	public VkBool32 discardable;
}
public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 micromap;
	public VkBool32 micromapCaptureReplay;
	public VkBool32 micromapHostCommands;
}
public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxOpacity2StateSubdivisionLevel;
	public uint maxOpacity4StateSubdivisionLevel;
}
public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndexType indexType;
	public VkDeviceOrHostAddressConstKHR indexBuffer;
	public VkDeviceSize indexStride;
	public uint baseTriangle;
	public uint usageCountsCount;
	public VkMicromapUsageEXT* pUsageCounts;
	public VkMicromapUsageEXT** ppUsageCounts;
	public VkMicromapEXT micromap;
}
public unsafe struct VkMicromapTriangleEXT
{
	public uint dataOffset;
	public ushort subdivisionLevel;
	public ushort format;
}
public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 clustercullingShader;
	public VkBool32 multiviewClusterCullingShader;
}
public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public fixed uint maxWorkGroupCount[3];
	public fixed uint maxWorkGroupSize[3];
	public uint maxOutputClusterCount;
}
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 borderColorSwizzle;
	public VkBool32 borderColorSwizzleFromImage;
}
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkComponentMapping components;
	public VkBool32 srgb;
}
public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pageableDeviceLocalMemory;
}
[Obsolete("Use VkPhysicalDeviceMaintenance4Features")]
public unsafe struct VkPhysicalDeviceMaintenance4FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 maintenance4;
}
[Obsolete("Use VkPhysicalDeviceMaintenance4Properties")]
public unsafe struct VkPhysicalDeviceMaintenance4PropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize maxBufferSize;
}
[Obsolete("Use VkDeviceBufferMemoryRequirements")]
public unsafe struct VkDeviceBufferMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateInfo* pCreateInfo;
}
[Obsolete("Use VkDeviceImageMemoryRequirements")]
public unsafe struct VkDeviceImageMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateInfo* pCreateInfo;
	public VkImageAspectFlags planeAspect;
}
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSetLayout descriptorSetLayout;
	public uint binding;
}
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public nuint descriptorOffset;
	public uint descriptorSize;
}
public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 descriptorSetHostMapping;
}
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClampZeroOne;
}
public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 nonSeamlessCubeMap;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMapOffset;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D fragmentDensityOffsetGranularity;
}
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public uint fragmentDensityOffsetCount;
	public VkOffset2D* pFragmentDensityOffsets;
}
public unsafe struct VkCopyMemoryIndirectCommandNV
{
	public VkDeviceAddress srcAddress;
	public VkDeviceAddress dstAddress;
	public VkDeviceSize size;
}
public unsafe struct VkCopyMemoryToImageIndirectCommandNV
{
	public VkDeviceAddress srcAddress;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 indirectCopy;
}
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFlags supportedQueues;
}
public unsafe struct VkDecompressMemoryRegionNV
{
	public VkDeviceAddress srcAddress;
	public VkDeviceAddress dstAddress;
	public VkDeviceSize compressedSize;
	public VkDeviceSize decompressedSize;
	public VkMemoryDecompressionMethodFlagsNV decompressionMethod;
}
public unsafe struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 memoryDecompression;
}
public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
	public ulong maxDecompressionIndirectCount;
}
public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 linearColorAttachment;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageCompressionControlSwapchain;
}
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkOffset2D filterCenter;
	public VkExtent2D filterSize;
	public uint numPhases;
}
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureSampleWeighted;
	public VkBool32 textureBoxFilter;
	public VkBool32 textureBlockMatch;
}
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxWeightFilterPhases;
	public VkExtent2D maxWeightFilterDimension;
	public VkExtent2D maxBlockMatchRegion;
	public VkExtent2D maxBoxFilterBlockSize;
}
public unsafe struct VkColorBlendEquationEXT
{
	public VkBlendFactor srcColorBlendFactor;
	public VkBlendFactor dstColorBlendFactor;
	public VkBlendOp colorBlendOp;
	public VkBlendFactor srcAlphaBlendFactor;
	public VkBlendFactor dstAlphaBlendFactor;
	public VkBlendOp alphaBlendOp;
}
public unsafe struct VkColorBlendAdvancedEXT
{
	public VkBlendOp advancedBlendOp;
	public VkBool32 srcPremultiplied;
	public VkBool32 dstPremultiplied;
	public VkBlendOverlapEXT blendOverlap;
	public VkBool32 clampResults;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState3TessellationDomainOrigin;
	public VkBool32 extendedDynamicState3DepthClampEnable;
	public VkBool32 extendedDynamicState3PolygonMode;
	public VkBool32 extendedDynamicState3RasterizationSamples;
	public VkBool32 extendedDynamicState3SampleMask;
	public VkBool32 extendedDynamicState3AlphaToCoverageEnable;
	public VkBool32 extendedDynamicState3AlphaToOneEnable;
	public VkBool32 extendedDynamicState3LogicOpEnable;
	public VkBool32 extendedDynamicState3ColorBlendEnable;
	public VkBool32 extendedDynamicState3ColorBlendEquation;
	public VkBool32 extendedDynamicState3ColorWriteMask;
	public VkBool32 extendedDynamicState3RasterizationStream;
	public VkBool32 extendedDynamicState3ConservativeRasterizationMode;
	public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;
	public VkBool32 extendedDynamicState3DepthClipEnable;
	public VkBool32 extendedDynamicState3SampleLocationsEnable;
	public VkBool32 extendedDynamicState3ColorBlendAdvanced;
	public VkBool32 extendedDynamicState3ProvokingVertexMode;
	public VkBool32 extendedDynamicState3LineRasterizationMode;
	public VkBool32 extendedDynamicState3LineStippleEnable;
	public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;
	public VkBool32 extendedDynamicState3ViewportWScalingEnable;
	public VkBool32 extendedDynamicState3ViewportSwizzle;
	public VkBool32 extendedDynamicState3CoverageToColorEnable;
	public VkBool32 extendedDynamicState3CoverageToColorLocation;
	public VkBool32 extendedDynamicState3CoverageModulationMode;
	public VkBool32 extendedDynamicState3CoverageModulationTableEnable;
	public VkBool32 extendedDynamicState3CoverageModulationTable;
	public VkBool32 extendedDynamicState3CoverageReductionMode;
	public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;
	public VkBool32 extendedDynamicState3ShadingRateImageEnable;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicPrimitiveTopologyUnrestricted;
}
public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subpassMergeFeedback;
}
public unsafe struct VkRenderPassCreationControlEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 disallowMerging;
}
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
	public uint postMergeSubpassCount;
}
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
}
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
	public VkSubpassMergeStatusEXT subpassMergeStatus;
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public uint postMergeIndex;
}
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
}
public unsafe struct VkDirectDriverLoadingInfoLUNARG
{
	public VkStructureType sType;
	public void* pNext;
	public VkDirectDriverLoadingFlagsLUNARG flags;
	public GetInstanceProcedureAddressLUNARGDelegate pfnGetInstanceProcAddr;
}
public unsafe struct VkDirectDriverLoadingListLUNARG
{
	public VkStructureType sType;
	public void* pNext;
	public VkDirectDriverLoadingModeLUNARG mode;
	public uint driverCount;
	public VkDirectDriverLoadingInfoLUNARG* pDrivers;
}
public unsafe struct VkShaderModuleIdentifierEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint identifierSize;
	public fixed byte identifier[(int)VK.MaxShaderModuleIdentifierSizeExt];
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderModuleIdentifier;
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte shaderModuleIdentifierAlgorithmUUID[(int)VK.UuidSize];
}
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint identifierSize;
	public byte* pIdentifier;
}
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rasterizationOrderColorAttachmentAccess;
	public VkBool32 rasterizationOrderDepthAttachmentAccess;
	public VkBool32 rasterizationOrderStencilAttachmentAccess;
}
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowUsageFlagsNV usage;
}
public unsafe struct VkOpticalFlowImageFormatPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
}
public unsafe struct VkOpticalFlowSessionCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint width;
	public uint height;
	public VkFormat imageFormat;
	public VkFormat flowVectorFormat;
	public VkFormat costFormat;
	public VkOpticalFlowGridSizeFlagsNV outputGridSize;
	public VkOpticalFlowGridSizeFlagsNV hintGridSize;
	public VkOpticalFlowPerformanceLevelNV performanceLevel;
	public VkOpticalFlowSessionCreateFlagsNV flags;
}
public unsafe struct VkOpticalFlowExecuteInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowExecuteFlagsNV flags;
	public uint regionCount;
	public VkRect2D* pRegions;
}
public unsafe struct VkPhysicalDeviceOpticalFlowFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 opticalFlow;
}
public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
	public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
	public VkBool32 hintSupported;
	public VkBool32 costSupported;
	public VkBool32 bidirectionalFlowSupported;
	public VkBool32 globalFlowSupported;
	public uint minWidth;
	public uint minHeight;
	public uint maxWidth;
	public uint maxHeight;
	public uint maxNumRegionsOfInterest;
}
public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint id;
	public uint size;
	public void* pPrivateData;
}
public unsafe struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 legacyDithering;
}
public unsafe struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineProtectedAccess;
}
public unsafe struct VkTilePropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent3D tileSize;
	public VkExtent2D apronSize;
	public VkOffset2D origin;
}
public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 tileProperties;
}
public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 amigoProfiling;
}
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
	public VkStructureType sType;
	public void* pNext;
	public ulong firstDrawTimestamp;
	public ulong swapBufferTimestamp;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiviewPerViewViewports;
}
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
}
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingInvocationReorder;
}
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 mutableDescriptorType;
}
public unsafe struct VkMutableDescriptorTypeListEXT
{
	public uint descriptorTypeCount;
	public VkDescriptorType* pDescriptorTypes;
}
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint mutableDescriptorTypeListCount;
	public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderCoreBuiltins;
}
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
	public VkStructureType sType;
	public void* pNext;
	public ulong shaderCoreMask;
	public uint shaderCoreCount;
	public uint shaderWarpsPerCore;
}
public unsafe struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineLibraryGroupHandles;
}
