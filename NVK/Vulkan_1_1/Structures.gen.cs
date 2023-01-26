// This file was generated, don't manually edit
namespace Vulkan_1_1;

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
	public delegate*<void*, nuint, nuint, VkSystemAllocationScope, void*> pfnAllocation;
	public delegate*<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> pfnReallocation;
	public delegate*<void*, void*, void> pfnFree;
	public delegate*<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation;
	public delegate*<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree;
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
public unsafe struct VkExtent3D
{
	public uint width;
	public uint height;
	public uint depth;
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
public unsafe struct VkOffset3D
{
	public int x;
	public int y;
	public int z;
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
public unsafe struct VkImageSubresourceRange
{
	public VkImageAspectFlags aspectMask;
	public uint baseMipLevel;
	public uint levelCount;
	public uint baseArrayLayer;
	public uint layerCount;
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
public unsafe struct VkRect2D
{
	public VkOffset2D offset;
	public VkExtent2D extent;
}
public unsafe struct VkOffset2D
{
	public int x;
	public int y;
}
public unsafe struct VkExtent2D
{
	public uint width;
	public uint height;
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
public unsafe struct VkMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
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
public unsafe struct VkBaseOutStructure
{
	public VkStructureType sType;
	public VkBaseOutStructure* pNext;
}
public unsafe struct VkBaseInStructure
{
	public VkStructureType sType;
	public VkBaseInStructure* pNext;
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
[Obsolete("Use VkMemoryRequirements2")]
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
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
	public delegate*<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void*, VkBool32> pfnCallback;
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
public unsafe struct VkImageViewHandleInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkDescriptorType descriptorType;
	public VkSampler sampler;
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
public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8FeaturesKHR")]
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
public unsafe struct VkCmdProcessCommandsInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectTableNVX objectTable;
	public VkIndirectCommandsLayoutNVX indirectCommandsLayout;
	public uint indirectCommandsTokenCount;
	public VkIndirectCommandsTokenNVX* pIndirectCommandsTokens;
	public uint maxSequencesCount;
	public VkCommandBuffer targetCommandBuffer;
	public VkBuffer sequencesCountBuffer;
	public VkDeviceSize sequencesCountOffset;
	public VkBuffer sequencesIndexBuffer;
	public VkDeviceSize sequencesIndexOffset;
}
public unsafe struct VkIndirectCommandsTokenNVX
{
	public VkIndirectCommandsTokenTypeNVX tokenType;
	public VkBuffer buffer;
	public VkDeviceSize offset;
}
public unsafe struct VkCmdReserveSpaceForCommandsInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectTableNVX objectTable;
	public VkIndirectCommandsLayoutNVX indirectCommandsLayout;
	public uint maxSequencesCount;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkIndirectCommandsLayoutUsageFlagsNVX flags;
	public uint tokenCount;
	public VkIndirectCommandsLayoutTokenNVX* pTokens;
}
public unsafe struct VkIndirectCommandsLayoutTokenNVX
{
	public VkIndirectCommandsTokenTypeNVX tokenType;
	public uint bindingUnit;
	public uint dynamicCount;
	public uint divisor;
}
public unsafe struct VkObjectTableCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public uint objectCount;
	public VkObjectEntryTypeNVX* pObjectEntryTypes;
	public uint* pObjectEntryCounts;
	public VkObjectEntryUsageFlagsNVX* pObjectEntryUsageFlags;
	public uint maxUniformBuffersPerDescriptor;
	public uint maxStorageBuffersPerDescriptor;
	public uint maxStorageImagesPerDescriptor;
	public uint maxSampledImagesPerDescriptor;
	public uint maxPipelineLayouts;
}
public unsafe struct VkObjectTableEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
}
public unsafe struct VkDeviceGeneratedCommandsFeaturesNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 computeBindingPointSupport;
}
public unsafe struct VkDeviceGeneratedCommandsLimitsNVX
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxIndirectCommandsLayoutTokenCount;
	public uint maxObjectEntryCounts;
	public uint minSequenceCountBufferOffsetAlignment;
	public uint minSequenceIndexBufferOffsetAlignment;
	public uint minCommandsTokenBufferOffsetAlignment;
}
public unsafe struct VkObjectTablePipelineEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
	public VkPipeline pipeline;
}
public unsafe struct VkObjectTableDescriptorSetEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
	public VkPipelineLayout pipelineLayout;
	public VkDescriptorSet descriptorSet;
}
public unsafe struct VkObjectTableVertexBufferEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
	public VkBuffer buffer;
}
public unsafe struct VkObjectTableIndexBufferEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
	public VkBuffer buffer;
	public VkIndexType indexType;
}
public unsafe struct VkObjectTablePushConstantEntryNVX
{
	public VkObjectEntryTypeNVX type;
	public VkObjectEntryUsageFlagsNVX flags;
	public VkPipelineLayout pipelineLayout;
	public VkShaderStageFlags stageFlags;
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
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imagelessFramebuffer;
}
public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfoKHR* pAttachmentImageInfos;
}
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
public unsafe struct VkRenderPassAttachmentBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachmentCount;
	public VkImageView* pAttachments;
}
public unsafe struct VkRenderPassCreateInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public VkAttachmentDescription2KHR* pAttachments;
	public uint subpassCount;
	public VkSubpassDescription2KHR* pSubpasses;
	public uint dependencyCount;
	public VkSubpassDependency2KHR* pDependencies;
	public uint correlatedViewMaskCount;
	public uint* pCorrelatedViewMasks;
}
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
public unsafe struct VkSubpassDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint viewMask;
	public uint inputAttachmentCount;
	public VkAttachmentReference2KHR* pInputAttachments;
	public uint colorAttachmentCount;
	public VkAttachmentReference2KHR* pColorAttachments;
	public VkAttachmentReference2KHR* pResolveAttachments;
	public VkAttachmentReference2KHR* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public uint* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
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
public unsafe struct VkSubpassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassContents contents;
}
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
	public delegate*<VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, VkBool32> pfnUserCallback;
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
public unsafe struct VkSamplerReductionModeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerReductionModeEXT reductionMode;
}
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}
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
public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint dataSize;
	public void* pData;
}
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
[Obsolete("Use VkSparseImageMemoryRequirements2")]
public unsafe struct VkSparseImageMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}
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
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint bindingCount;
	public VkDescriptorBindingFlagsEXT* pBindingFlags;
}
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
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint descriptorSetCount;
	public uint* pDescriptorCounts;
}
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
	public VkGeometryTypeNV geometryType;
	public VkGeometryDataNV geometry;
	public VkGeometryFlagsNV flags;
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
	public VkRayTracingShaderGroupTypeNV type;
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
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityEXT globalPriority;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}
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
public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
	public uint pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedbackEXT** pPipelineStageCreationFeedbacks;
}
public unsafe struct VkPipelineCreationFeedbackEXT
{
	public VkPipelineCreationFeedbackFlagsEXT flags;
	public ulong duration;
}
public unsafe struct VkConformanceVersionKHR
{
	public byte major;
	public byte minor;
	public byte subminor;
	public byte patch;
}
public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverIdKHR driverID;
	public fixed byte driverName[(int)VK.MaxDriverNameSizeKhr];
	public fixed byte driverInfo[(int)VK.MaxDriverInfoSizeKhr];
	public VkConformanceVersionKHR conformanceVersion;
}
public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderFloatControlsIndependenceKHR denormBehaviorIndependence;
	public VkShaderFloatControlsIndependenceKHR roundingModeIndependence;
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
public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlagsKHR depthResolveMode;
	public VkResolveModeFlagsKHR stencilResolveMode;
	public VkAttachmentReference2KHR* pDepthStencilResolveAttachment;
}
public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlagsKHR supportedDepthResolveModes;
	public VkResolveModeFlagsKHR supportedStencilResolveModes;
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
public unsafe struct VkSemaphoreWaitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreWaitFlagsKHR flags;
	public uint semaphoreCount;
	public VkSemaphore* pSemaphores;
	public ulong* pValues;
}
public unsafe struct VkSemaphoreSignalInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 timelineSemaphore;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong maxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreTypeKHR semaphoreType;
	public ulong initialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint waitSemaphoreValueCount;
	public ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValueCount;
	public ulong* pSignalSemaphoreValues;
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
public unsafe struct VkQueryPoolCreateInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}
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
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 scalarBlockLayout;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint requiredSubgroupSize;
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
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}
public unsafe struct VkAttachmentReferenceStencilLayoutKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilLayout;
}
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
[Obsolete("Use VkBufferDeviceAddressInfoKHR")]
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
public unsafe struct VkPhysicalDeviceToolPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte name[(int)VK.MaxExtensionNameSize];
	public fixed byte version[(int)VK.MaxExtensionNameSize];
	public VkToolPurposeFlagsEXT purposes;
	public fixed byte description[(int)VK.MaxDescriptionSize];
	public fixed byte layer[(int)VK.MaxExtensionNameSize];
}
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
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 uniformBufferStandardLayout;
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
public unsafe struct VkBufferDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public ulong opaqueCaptureAddress;
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
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 texelBufferAlignment;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}
