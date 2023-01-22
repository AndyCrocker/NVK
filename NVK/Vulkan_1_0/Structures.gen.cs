// This file was generated, don't manually edit
namespace Vulkan_1_0;

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
	public PFN_vkAllocationFunction pfnAllocation;
	public PFN_vkReallocationFunction pfnReallocation;
	public PFN_vkFreeFunction pfnFree;
	public PFN_vkInternalAllocationNotification pfnInternalAllocation;
	public PFN_vkInternalFreeNotification pfnInternalFree;
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
	public fixed byte deviceName[VK.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
	public fixed byte pipelineCacheUUID[VK.VK_UUID_SIZE];
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
	public fixed uint maxComputeWorkGroupCount[];
	public uint maxComputeWorkGroupInvocations;
	public fixed uint maxComputeWorkGroupSize[];
	public uint subPixelPrecisionBits;
	public uint subTexelPrecisionBits;
	public uint mipmapPrecisionBits;
	public uint maxDrawIndexedIndexValue;
	public uint maxDrawIndirectCount;
	public float maxSamplerLodBias;
	public float maxSamplerAnisotropy;
	public uint maxViewports;
	public fixed uint maxViewportDimensions[];
	public fixed float viewportBoundsRange[];
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
	public fixed float pointSizeRange[];
	public fixed float lineWidthRange[];
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
	public fixed byte extensionName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint specVersion;
}
public unsafe struct VkLayerProperties
{
	public fixed byte layerName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint specVersion;
	public uint implementationVersion;
	public fixed byte description[VK.VK_MAX_DESCRIPTION_SIZE];
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
	public VkSampleCountFlagBits samples;
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
	public VkShaderStageFlagBits stage;
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
	public VkSampleCountFlagBits rasterizationSamples;
	public VkBool32 sampleShadingEnable;
	public float minSampleShading;
	public VkSampleMask* pSampleMask;
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
	public fixed float blendConstants[];
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
	public VkSampleCountFlagBits samples;
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
	public fixed float float32[];
	[FieldOffset(0)]
	public fixed int int32[];
	[FieldOffset(0)]
	public fixed uint uint32[];
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
public unsafe struct VkSurfaceCapabilitiesKHR
{
	public uint minImageCount;
	public uint maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagBitsKHR currentTransform;
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
	public VkSurfaceTransformFlagBitsKHR preTransform;
	public VkCompositeAlphaFlagBitsKHR compositeAlpha;
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
	public VkSurfaceTransformFlagBitsKHR transform;
	public float globalAlpha;
	public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
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
	public PFN_vkDebugReportCallbackEXT pfnCallback;
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
	public fixed float color[];
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
	public fixed uint computeWorkGroupSize[];
}
public unsafe struct VkRenderPassMultiviewCreateInfoKHX
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
public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}
public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHX
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
public unsafe struct VkPhysicalDeviceFeatures2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceFeatures features;
}
public unsafe struct VkPhysicalDeviceProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceProperties properties;
}
public unsafe struct VkFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatProperties formatProperties;
}
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
public unsafe struct VkImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}
public unsafe struct VkQueueFamilyProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}
public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlagBits samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
public unsafe struct VkSparseImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageFormatProperties properties;
}
public unsafe struct VkMemoryAllocateFlagsInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlagsKHX flags;
	public uint deviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
	public uint deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfoKHX
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
public unsafe struct VkDeviceGroupBindSparseInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint resourceDeviceIndex;
	public uint memoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint deviceIndexCount;
	public uint* pDeviceIndices;
	public uint SFRRectCount;
	public VkRect2D* pSFRRects;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHX
{
	public VkStructureType sType;
	public void* pNext;
	public fixed uint presentMask[VK.VK_MAX_DEVICE_GROUP_SIZE_KHX];
	public VkDeviceGroupPresentModeFlagsKHX modes;
}
public unsafe struct VkAcquireNextImageInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public ulong timeout;
	public VkSemaphore semaphore;
	public VkFence fence;
	public uint deviceMask;
}
public unsafe struct VkImageSwapchainCreateInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
}
public unsafe struct VkBindImageMemorySwapchainInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint imageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint swapchainCount;
	public uint* pDeviceMasks;
	public VkDeviceGroupPresentModeFlagBitsKHX mode;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceGroupPresentModeFlagsKHX modes;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint disabledValidationCheckCount;
	public VkValidationCheckEXT* pDisabledValidationChecks;
}
public unsafe struct VkViSurfaceCreateInfoNN
{
	public VkStructureType sType;
	public void* pNext;
	public VkViSurfaceCreateFlagsNN flags;
	public void* window;
}
public unsafe struct VkPhysicalDeviceGroupPropertiesKHX
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
public unsafe struct VkDeviceGroupDeviceCreateInfoKHX
{
	public VkStructureType sType;
	public void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice* pPhysicalDevices;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkExternalBufferPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryPropertiesKHR externalMemoryProperties;
}
public unsafe struct VkExternalMemoryPropertiesKHR
{
	public VkExternalMemoryFeatureFlagsKHR externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsKHR exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsKHR compatibleHandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkExternalImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryPropertiesKHR externalMemoryProperties;
}
public unsafe struct VkPhysicalDeviceIDPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed byte deviceUUID[VK.VK_UUID_SIZE];
	public fixed byte driverUUID[VK.VK_UUID_SIZE];
	public fixed byte deviceLUID[VK.VK_LUID_SIZE_KHR];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}
public unsafe struct VkExternalMemoryImageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsKHR handleTypes;
}
public unsafe struct VkExternalMemoryBufferCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsKHR handleTypes;
}
public unsafe struct VkExportMemoryAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsKHR handleTypes;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
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
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
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
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
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
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
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
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkExternalSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagsKHR exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlagsKHR compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlagsKHR externalSemaphoreFeatures;
}
public unsafe struct VkExportSemaphoreCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagsKHR handleTypes;
}
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlagsKHR flags;
	public VkExternalSemaphoreHandleTypeFlagBitsKHR handleType;
	public IntPtr handle;
	public IntPtr name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBitsKHR handleType;
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
	public VkSemaphoreImportFlagsKHR flags;
	public VkExternalSemaphoreHandleTypeFlagBitsKHR handleType;
	public int fd;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint maxPushDescriptors;
}
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
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlagsKHR flags;
	public uint descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntryKHR* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateTypeKHR templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint set;
}
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public nuint offset;
	public nuint stride;
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
	public VkSurfaceTransformFlagBitsKHR currentTransform;
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
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags sharedPresentSupportedUsageFlags;
}
public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkExternalFencePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlagsKHR exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlagsKHR compatibleHandleTypes;
	public VkExternalFenceFeatureFlagsKHR externalFenceFeatures;
}
public unsafe struct VkExportFenceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlagsKHR handleTypes;
}
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlagsKHR flags;
	public VkExternalFenceHandleTypeFlagBitsKHR handleType;
	public IntPtr handle;
	public IntPtr name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBitsKHR handleType;
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
	public VkFenceImportFlagsKHR flags;
	public VkExternalFenceHandleTypeFlagBitsKHR handleType;
	public int fd;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBitsKHR handleType;
}
public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPointClippingBehaviorKHR pointClippingBehavior;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint aspectReferenceCount;
	public VkInputAttachmentAspectReferenceKHR* pAspectReferences;
}
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint subpass;
	public uint inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkImageViewUsageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags usage;
}
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkTessellationDomainOriginKHR domainOrigin;
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
public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkIOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public void* pNext;
	public VkIOSSurfaceCreateFlagsMVK flags;
	public void* pView;
}
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public void* pNext;
	public VkMacOSSurfaceCreateFlagsMVK flags;
	public void* pView;
}
public unsafe struct VkMemoryDedicatedRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}
public unsafe struct VkMemoryDedicatedAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
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
public unsafe struct VkSampleLocationsInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlagBits sampleLocationsPerPixel;
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
	public fixed float sampleLocationCoordinateRange[];
	public uint sampleLocationSubPixelBits;
	public VkBool32 variableSampleLocations;
}
public unsafe struct VkImageMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
}
public unsafe struct VkBufferMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
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
public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversionKHR ycbcrModel;
	public VkSamplerYcbcrRangeKHR ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocationKHR xChromaOffset;
	public VkChromaLocationKHR yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}
public unsafe struct VkSamplerYcbcrConversionInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerYcbcrConversionKHR conversion;
}
public unsafe struct VkBindImagePlaneMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerYcbcrConversion;
}
public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint combinedImageSamplerDescriptorCount;
}
public unsafe struct VkBindBufferMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkBindImageMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
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
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityEXT globalPriority;
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
	public VkExternalMemoryHandleTypeFlagBitsKHR handleType;
	public void* pHostPointer;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize minImportedHostPointerAlignment;
}
