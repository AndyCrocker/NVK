// This file was generated, don't manually edit
namespace Vulkan_1_1;

public unsafe struct VkInstanceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkInstanceCreateFlags flags;
	public VkApplicationInfo* pApplicationInfo;
	public uint32_t enabledLayerCount;
	public char** ppEnabledLayerNames;
	public uint32_t enabledExtensionCount;
	public char** ppEnabledExtensionNames;
}
public unsafe struct VkApplicationInfo
{
	public VkStructureType sType;
	public void* pNext;
	public char* pApplicationName;
	public uint32_t applicationVersion;
	public char* pEngineName;
	public uint32_t engineVersion;
	public uint32_t apiVersion;
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
	public uint32_t maxMipLevels;
	public uint32_t maxArrayLayers;
	public VkSampleCountFlags sampleCounts;
	public VkDeviceSize maxResourceSize;
}
public unsafe struct VkExtent3D
{
	public uint32_t width;
	public uint32_t height;
	public uint32_t depth;
}
public unsafe struct VkPhysicalDeviceProperties
{
	public uint32_t apiVersion;
	public uint32_t driverVersion;
	public uint32_t vendorID;
	public uint32_t deviceID;
	public VkPhysicalDeviceType deviceType;
	public fixed char deviceName[VK.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
	public uint8_t pipelineCacheUUID_0;
	public uint8_t pipelineCacheUUID_1;
	public uint8_t pipelineCacheUUID_2;
	public uint8_t pipelineCacheUUID_3;
	public uint8_t pipelineCacheUUID_4;
	public uint8_t pipelineCacheUUID_5;
	public uint8_t pipelineCacheUUID_6;
	public uint8_t pipelineCacheUUID_7;
	public uint8_t pipelineCacheUUID_8;
	public uint8_t pipelineCacheUUID_9;
	public uint8_t pipelineCacheUUID_10;
	public uint8_t pipelineCacheUUID_11;
	public uint8_t pipelineCacheUUID_12;
	public uint8_t pipelineCacheUUID_13;
	public uint8_t pipelineCacheUUID_14;
	public uint8_t pipelineCacheUUID_15;
	public VkPhysicalDeviceLimits limits;
	public VkPhysicalDeviceSparseProperties sparseProperties;
}
public unsafe struct VkPhysicalDeviceLimits
{
	public uint32_t maxImageDimension1D;
	public uint32_t maxImageDimension2D;
	public uint32_t maxImageDimension3D;
	public uint32_t maxImageDimensionCube;
	public uint32_t maxImageArrayLayers;
	public uint32_t maxTexelBufferElements;
	public uint32_t maxUniformBufferRange;
	public uint32_t maxStorageBufferRange;
	public uint32_t maxPushConstantsSize;
	public uint32_t maxMemoryAllocationCount;
	public uint32_t maxSamplerAllocationCount;
	public VkDeviceSize bufferImageGranularity;
	public VkDeviceSize sparseAddressSpaceSize;
	public uint32_t maxBoundDescriptorSets;
	public uint32_t maxPerStageDescriptorSamplers;
	public uint32_t maxPerStageDescriptorUniformBuffers;
	public uint32_t maxPerStageDescriptorStorageBuffers;
	public uint32_t maxPerStageDescriptorSampledImages;
	public uint32_t maxPerStageDescriptorStorageImages;
	public uint32_t maxPerStageDescriptorInputAttachments;
	public uint32_t maxPerStageResources;
	public uint32_t maxDescriptorSetSamplers;
	public uint32_t maxDescriptorSetUniformBuffers;
	public uint32_t maxDescriptorSetUniformBuffersDynamic;
	public uint32_t maxDescriptorSetStorageBuffers;
	public uint32_t maxDescriptorSetStorageBuffersDynamic;
	public uint32_t maxDescriptorSetSampledImages;
	public uint32_t maxDescriptorSetStorageImages;
	public uint32_t maxDescriptorSetInputAttachments;
	public uint32_t maxVertexInputAttributes;
	public uint32_t maxVertexInputBindings;
	public uint32_t maxVertexInputAttributeOffset;
	public uint32_t maxVertexInputBindingStride;
	public uint32_t maxVertexOutputComponents;
	public uint32_t maxTessellationGenerationLevel;
	public uint32_t maxTessellationPatchSize;
	public uint32_t maxTessellationControlPerVertexInputComponents;
	public uint32_t maxTessellationControlPerVertexOutputComponents;
	public uint32_t maxTessellationControlPerPatchOutputComponents;
	public uint32_t maxTessellationControlTotalOutputComponents;
	public uint32_t maxTessellationEvaluationInputComponents;
	public uint32_t maxTessellationEvaluationOutputComponents;
	public uint32_t maxGeometryShaderInvocations;
	public uint32_t maxGeometryInputComponents;
	public uint32_t maxGeometryOutputComponents;
	public uint32_t maxGeometryOutputVertices;
	public uint32_t maxGeometryTotalOutputComponents;
	public uint32_t maxFragmentInputComponents;
	public uint32_t maxFragmentOutputAttachments;
	public uint32_t maxFragmentDualSrcAttachments;
	public uint32_t maxFragmentCombinedOutputResources;
	public uint32_t maxComputeSharedMemorySize;
	public uint32_t maxComputeWorkGroupCount_0;
	public uint32_t maxComputeWorkGroupCount_1;
	public uint32_t maxComputeWorkGroupCount_2;
	public uint32_t maxComputeWorkGroupInvocations;
	public uint32_t maxComputeWorkGroupSize_0;
	public uint32_t maxComputeWorkGroupSize_1;
	public uint32_t maxComputeWorkGroupSize_2;
	public uint32_t subPixelPrecisionBits;
	public uint32_t subTexelPrecisionBits;
	public uint32_t mipmapPrecisionBits;
	public uint32_t maxDrawIndexedIndexValue;
	public uint32_t maxDrawIndirectCount;
	public float maxSamplerLodBias;
	public float maxSamplerAnisotropy;
	public uint32_t maxViewports;
	public uint32_t maxViewportDimensions_0;
	public uint32_t maxViewportDimensions_1;
	public fixed float viewportBoundsRange[];
	public uint32_t viewportSubPixelBits;
	public size_t minMemoryMapAlignment;
	public VkDeviceSize minTexelBufferOffsetAlignment;
	public VkDeviceSize minUniformBufferOffsetAlignment;
	public VkDeviceSize minStorageBufferOffsetAlignment;
	public int32_t minTexelOffset;
	public uint32_t maxTexelOffset;
	public int32_t minTexelGatherOffset;
	public uint32_t maxTexelGatherOffset;
	public float minInterpolationOffset;
	public float maxInterpolationOffset;
	public uint32_t subPixelInterpolationOffsetBits;
	public uint32_t maxFramebufferWidth;
	public uint32_t maxFramebufferHeight;
	public uint32_t maxFramebufferLayers;
	public VkSampleCountFlags framebufferColorSampleCounts;
	public VkSampleCountFlags framebufferDepthSampleCounts;
	public VkSampleCountFlags framebufferStencilSampleCounts;
	public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
	public uint32_t maxColorAttachments;
	public VkSampleCountFlags sampledImageColorSampleCounts;
	public VkSampleCountFlags sampledImageIntegerSampleCounts;
	public VkSampleCountFlags sampledImageDepthSampleCounts;
	public VkSampleCountFlags sampledImageStencilSampleCounts;
	public VkSampleCountFlags storageImageSampleCounts;
	public uint32_t maxSampleMaskWords;
	public VkBool32 timestampComputeAndGraphics;
	public float timestampPeriod;
	public uint32_t maxClipDistances;
	public uint32_t maxCullDistances;
	public uint32_t maxCombinedClipAndCullDistances;
	public uint32_t discreteQueuePriorities;
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
	public uint32_t queueCount;
	public uint32_t timestampValidBits;
	public VkExtent3D minImageTransferGranularity;
}
public unsafe struct VkPhysicalDeviceMemoryProperties
{
	public uint32_t memoryTypeCount;
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
	public uint32_t memoryHeapCount;
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
	public uint32_t heapIndex;
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
	public uint32_t queueCreateInfoCount;
	public VkDeviceQueueCreateInfo* pQueueCreateInfos;
	public uint32_t enabledLayerCount;
	public char** ppEnabledLayerNames;
	public uint32_t enabledExtensionCount;
	public char** ppEnabledExtensionNames;
	public VkPhysicalDeviceFeatures* pEnabledFeatures;
}
public unsafe struct VkDeviceQueueCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint32_t queueFamilyIndex;
	public uint32_t queueCount;
	public float* pQueuePriorities;
}
public unsafe struct VkExtensionProperties
{
	public fixed char extensionName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint32_t specVersion;
}
public unsafe struct VkLayerProperties
{
	public fixed char layerName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint32_t specVersion;
	public uint32_t implementationVersion;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
}
public unsafe struct VkSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public VkPipelineStageFlags* pWaitDstStageMask;
	public uint32_t commandBufferCount;
	public VkCommandBuffer* pCommandBuffers;
	public uint32_t signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkMemoryAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint32_t memoryTypeIndex;
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
	public uint32_t memoryTypeBits;
}
public unsafe struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties formatProperties;
	public uint32_t imageMipTailFirstLod;
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
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint32_t bufferBindCount;
	public VkSparseBufferMemoryBindInfo* pBufferBinds;
	public uint32_t imageOpaqueBindCount;
	public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
	public uint32_t imageBindCount;
	public VkSparseImageMemoryBindInfo* pImageBinds;
	public uint32_t signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer buffer;
	public uint32_t bindCount;
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
	public uint32_t bindCount;
	public VkSparseMemoryBind* pBinds;
}
public unsafe struct VkSparseImageMemoryBindInfo
{
	public VkImage image;
	public uint32_t bindCount;
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
	public uint32_t mipLevel;
	public uint32_t arrayLayer;
}
public unsafe struct VkOffset3D
{
	public int32_t x;
	public int32_t y;
	public int32_t z;
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
	public uint32_t queryCount;
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
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
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
	public uint32_t mipLevels;
	public uint32_t arrayLayers;
	public VkSampleCountFlagBits samples;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
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
	public uint32_t baseMipLevel;
	public uint32_t levelCount;
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
}
public unsafe struct VkShaderModuleCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderModuleCreateFlags flags;
	public size_t codeSize;
	public uint32_t* pCode;
}
public unsafe struct VkPipelineCacheCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCacheCreateFlags flags;
	public size_t initialDataSize;
	public void* pInitialData;
}
public unsafe struct VkGraphicsPipelineCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint32_t stageCount;
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
	public uint32_t subpass;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkPipelineShaderStageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineShaderStageCreateFlags flags;
	public VkShaderStageFlagBits stage;
	public VkShaderModule module;
	public char* pName;
	public VkSpecializationInfo* pSpecializationInfo;
}
public unsafe struct VkSpecializationInfo
{
	public uint32_t mapEntryCount;
	public VkSpecializationMapEntry* pMapEntries;
	public size_t dataSize;
	public void* pData;
}
public unsafe struct VkSpecializationMapEntry
{
	public uint32_t constantID;
	public uint32_t offset;
	public size_t size;
}
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineVertexInputStateCreateFlags flags;
	public uint32_t vertexBindingDescriptionCount;
	public VkVertexInputBindingDescription* pVertexBindingDescriptions;
	public uint32_t vertexAttributeDescriptionCount;
	public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
}
public unsafe struct VkVertexInputBindingDescription
{
	public uint32_t binding;
	public uint32_t stride;
	public VkVertexInputRate inputRate;
}
public unsafe struct VkVertexInputAttributeDescription
{
	public uint32_t location;
	public uint32_t binding;
	public VkFormat format;
	public uint32_t offset;
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
	public uint32_t patchControlPoints;
}
public unsafe struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineViewportStateCreateFlags flags;
	public uint32_t viewportCount;
	public VkViewport* pViewports;
	public uint32_t scissorCount;
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
	public int32_t x;
	public int32_t y;
}
public unsafe struct VkExtent2D
{
	public uint32_t width;
	public uint32_t height;
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
	public uint32_t compareMask;
	public uint32_t writeMask;
	public uint32_t reference;
}
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineColorBlendStateCreateFlags flags;
	public VkBool32 logicOpEnable;
	public VkLogicOp logicOp;
	public uint32_t attachmentCount;
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
	public uint32_t dynamicStateCount;
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
	public int32_t basePipelineIndex;
}
public unsafe struct VkPipelineLayoutCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineLayoutCreateFlags flags;
	public uint32_t setLayoutCount;
	public VkDescriptorSetLayout* pSetLayouts;
	public uint32_t pushConstantRangeCount;
	public VkPushConstantRange* pPushConstantRanges;
}
public unsafe struct VkPushConstantRange
{
	public VkShaderStageFlags stageFlags;
	public uint32_t offset;
	public uint32_t size;
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
	public uint32_t bindingCount;
	public VkDescriptorSetLayoutBinding* pBindings;
}
public unsafe struct VkDescriptorSetLayoutBinding
{
	public uint32_t binding;
	public VkDescriptorType descriptorType;
	public uint32_t descriptorCount;
	public VkShaderStageFlags stageFlags;
	public VkSampler* pImmutableSamplers;
}
public unsafe struct VkDescriptorPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPoolCreateFlags flags;
	public uint32_t maxSets;
	public uint32_t poolSizeCount;
	public VkDescriptorPoolSize* pPoolSizes;
}
public unsafe struct VkDescriptorPoolSize
{
	public VkDescriptorType type;
	public uint32_t descriptorCount;
}
public unsafe struct VkDescriptorSetAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPool descriptorPool;
	public uint32_t descriptorSetCount;
	public VkDescriptorSetLayout* pSetLayouts;
}
public unsafe struct VkWriteDescriptorSet
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSet dstSet;
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
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
	public uint32_t srcBinding;
	public uint32_t srcArrayElement;
	public VkDescriptorSet dstSet;
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
}
public unsafe struct VkFramebufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFramebufferCreateFlags flags;
	public VkRenderPass renderPass;
	public uint32_t attachmentCount;
	public VkImageView* pAttachments;
	public uint32_t width;
	public uint32_t height;
	public uint32_t layers;
}
public unsafe struct VkRenderPassCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint32_t attachmentCount;
	public VkAttachmentDescription* pAttachments;
	public uint32_t subpassCount;
	public VkSubpassDescription* pSubpasses;
	public uint32_t dependencyCount;
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
	public uint32_t inputAttachmentCount;
	public VkAttachmentReference* pInputAttachments;
	public uint32_t colorAttachmentCount;
	public VkAttachmentReference* pColorAttachments;
	public VkAttachmentReference* pResolveAttachments;
	public VkAttachmentReference* pDepthStencilAttachment;
	public uint32_t preserveAttachmentCount;
	public uint32_t* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference
{
	public uint32_t attachment;
	public VkImageLayout layout;
}
public unsafe struct VkSubpassDependency
{
	public uint32_t srcSubpass;
	public uint32_t dstSubpass;
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
	public uint32_t queueFamilyIndex;
}
public unsafe struct VkCommandBufferAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandPool commandPool;
	public VkCommandBufferLevel level;
	public uint32_t commandBufferCount;
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
	public uint32_t subpass;
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
	public uint32_t mipLevel;
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
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
	public uint32_t bufferRowLength;
	public uint32_t bufferImageHeight;
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
	public int32_t int32_0;
	public int32_t int32_1;
	public int32_t int32_2;
	public int32_t int32_3;
	[FieldOffset(0)]
	public uint32_t uint32_0;
	public uint32_t uint32_1;
	public uint32_t uint32_2;
	public uint32_t uint32_3;
}
public unsafe struct VkClearDepthStencilValue
{
	public float depth;
	public uint32_t stencil;
}
public unsafe struct VkClearAttachment
{
	public VkImageAspectFlags aspectMask;
	public uint32_t colorAttachment;
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
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
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
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
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
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
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
	public uint32_t clearValueCount;
	public VkClearValue* pClearValues;
}
public unsafe struct VkDispatchIndirectCommand
{
	public uint32_t x;
	public uint32_t y;
	public uint32_t z;
}
public unsafe struct VkDrawIndexedIndirectCommand
{
	public uint32_t indexCount;
	public uint32_t instanceCount;
	public uint32_t firstIndex;
	public int32_t vertexOffset;
	public uint32_t firstInstance;
}
public unsafe struct VkDrawIndirectCommand
{
	public uint32_t vertexCount;
	public uint32_t instanceCount;
	public uint32_t firstVertex;
	public uint32_t firstInstance;
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
	public uint32_t subgroupSize;
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
	public uint32_t deviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
	public uint32_t deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public uint32_t* pWaitSemaphoreDeviceIndices;
	public uint32_t commandBufferCount;
	public uint32_t* pCommandBufferDeviceMasks;
	public uint32_t signalSemaphoreCount;
	public uint32_t* pSignalSemaphoreDeviceIndices;
}
public unsafe struct VkDeviceGroupBindSparseInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t resourceDeviceIndex;
	public uint32_t memoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
	public uint32_t splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkPhysicalDeviceGroupProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t physicalDeviceCount;
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
	public uint32_t physicalDeviceCount;
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
	public VkSampleCountFlagBits samples;
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
	public uint32_t aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
public unsafe struct VkInputAttachmentAspectReference
{
	public uint32_t subpass;
	public uint32_t inputAttachmentIndex;
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
	public uint32_t subpassCount;
	public uint32_t* pViewMasks;
	public uint32_t dependencyCount;
	public int32_t* pViewOffsets;
	public uint32_t correlationMaskCount;
	public uint32_t* pCorrelationMasks;
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
	public uint32_t maxMultiviewViewCount;
	public uint32_t maxMultiviewInstanceIndex;
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
	public uint32_t queueFamilyIndex;
	public uint32_t queueIndex;
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
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
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
	public uint32_t combinedImageSamplerDescriptorCount;
}
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint32_t descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint32_t set;
}
public unsafe struct VkDescriptorUpdateTemplateEntry
{
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
	public VkDescriptorType descriptorType;
	public size_t offset;
	public size_t stride;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlagBits handleType;
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
	public VkExternalMemoryHandleTypeFlagBits handleType;
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
	public uint8_t deviceUUID_0;
	public uint8_t deviceUUID_1;
	public uint8_t deviceUUID_2;
	public uint8_t deviceUUID_3;
	public uint8_t deviceUUID_4;
	public uint8_t deviceUUID_5;
	public uint8_t deviceUUID_6;
	public uint8_t deviceUUID_7;
	public uint8_t deviceUUID_8;
	public uint8_t deviceUUID_9;
	public uint8_t deviceUUID_10;
	public uint8_t deviceUUID_11;
	public uint8_t deviceUUID_12;
	public uint8_t deviceUUID_13;
	public uint8_t deviceUUID_14;
	public uint8_t deviceUUID_15;
	public uint8_t driverUUID_0;
	public uint8_t driverUUID_1;
	public uint8_t driverUUID_2;
	public uint8_t driverUUID_3;
	public uint8_t driverUUID_4;
	public uint8_t driverUUID_5;
	public uint8_t driverUUID_6;
	public uint8_t driverUUID_7;
	public uint8_t driverUUID_8;
	public uint8_t driverUUID_9;
	public uint8_t driverUUID_10;
	public uint8_t driverUUID_11;
	public uint8_t driverUUID_12;
	public uint8_t driverUUID_13;
	public uint8_t driverUUID_14;
	public uint8_t driverUUID_15;
	public uint8_t deviceLUID_0;
	public uint8_t deviceLUID_1;
	public uint8_t deviceLUID_2;
	public uint8_t deviceLUID_3;
	public uint8_t deviceLUID_4;
	public uint8_t deviceLUID_5;
	public uint8_t deviceLUID_6;
	public uint8_t deviceLUID_7;
	public uint32_t deviceNodeMask;
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
	public VkExternalFenceHandleTypeFlagBits handleType;
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
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
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
	public uint32_t maxPerSetDescriptors;
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
	public uint32_t minImageCount;
	public uint32_t maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint32_t maxImageArrayLayers;
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
	public uint32_t minImageCount;
	public VkFormat imageFormat;
	public VkColorSpaceKHR imageColorSpace;
	public VkExtent2D imageExtent;
	public uint32_t imageArrayLayers;
	public VkImageUsageFlags imageUsage;
	public VkSharingMode imageSharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
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
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint32_t swapchainCount;
	public VkSwapchainKHR* pSwapchains;
	public uint32_t* pImageIndices;
	public VkResult* pResults;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t presentMask_0;
	public uint32_t presentMask_1;
	public uint32_t presentMask_2;
	public uint32_t presentMask_3;
	public uint32_t presentMask_4;
	public uint32_t presentMask_5;
	public uint32_t presentMask_6;
	public uint32_t presentMask_7;
	public uint32_t presentMask_8;
	public uint32_t presentMask_9;
	public uint32_t presentMask_10;
	public uint32_t presentMask_11;
	public uint32_t presentMask_12;
	public uint32_t presentMask_13;
	public uint32_t presentMask_14;
	public uint32_t presentMask_15;
	public uint32_t presentMask_16;
	public uint32_t presentMask_17;
	public uint32_t presentMask_18;
	public uint32_t presentMask_19;
	public uint32_t presentMask_20;
	public uint32_t presentMask_21;
	public uint32_t presentMask_22;
	public uint32_t presentMask_23;
	public uint32_t presentMask_24;
	public uint32_t presentMask_25;
	public uint32_t presentMask_26;
	public uint32_t presentMask_27;
	public uint32_t presentMask_28;
	public uint32_t presentMask_29;
	public uint32_t presentMask_30;
	public uint32_t presentMask_31;
	public VkDeviceGroupPresentModeFlagsKHR modes;
}
public unsafe struct VkAcquireNextImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint64_t timeout;
	public VkSemaphore semaphore;
	public VkFence fence;
	public uint32_t deviceMask;
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
	public uint32_t imageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public uint32_t* pDeviceMasks;
	public VkDeviceGroupPresentModeFlagBitsKHR mode;
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
	public char* displayName;
	public VkExtent2D physicalDimensions;
	public VkExtent2D physicalResolution;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkBool32 planeReorderPossible;
	public VkBool32 persistentContent;
}
public unsafe struct VkDisplayPlanePropertiesKHR
{
	public VkDisplayKHR currentDisplay;
	public uint32_t currentStackIndex;
}
public unsafe struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR displayMode;
	public VkDisplayModeParametersKHR parameters;
}
public unsafe struct VkDisplayModeParametersKHR
{
	public VkExtent2D visibleRegion;
	public uint32_t refreshRate;
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
	public uint32_t planeIndex;
	public uint32_t planeStackIndex;
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
	public Display* dpy;
	public Window window;
}
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkXcbSurfaceCreateFlagsKHR flags;
	public xcb_connection_t* connection;
	public xcb_window_t window;
}
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWaylandSurfaceCreateFlagsKHR flags;
	public wl_display* display;
	public wl_surface* surface;
}
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAndroidSurfaceCreateFlagsKHR flags;
	public ANativeWindow* window;
}
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWin32SurfaceCreateFlagsKHR flags;
	public HINSTANCE hinstance;
	public HWND hwnd;
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
	public uint64_t object;
	public uint64_t tagName;
	public size_t tagSize;
	public void* pTag;
}
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public uint64_t object;
	public char* pObjectName;
}
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public char* pMarkerName;
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
	public uint32_t maxTransformFeedbackStreams;
	public uint32_t maxTransformFeedbackBuffers;
	public VkDeviceSize maxTransformFeedbackBufferSize;
	public uint32_t maxTransformFeedbackStreamDataSize;
	public uint32_t maxTransformFeedbackBufferDataSize;
	public uint32_t maxTransformFeedbackBufferDataStride;
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
	public uint32_t rasterizationStream;
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
	public uint32_t numUsedVgprs;
	public uint32_t numUsedSgprs;
	public uint32_t ldsSizePerLocalWorkGroup;
	public size_t ldsUsageSizeInBytes;
	public size_t scratchMemUsageInBytes;
}
public unsafe struct VkShaderStatisticsInfoAMD
{
	public VkShaderStageFlags shaderStageMask;
	public VkShaderResourceUsageAMD resourceUsage;
	public uint32_t numPhysicalVgprs;
	public uint32_t numPhysicalSgprs;
	public uint32_t numAvailableVgprs;
	public uint32_t numAvailableSgprs;
	public uint32_t computeWorkGroupSize_0;
	public uint32_t computeWorkGroupSize_1;
	public uint32_t computeWorkGroupSize_2;
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
	public uint32_t subpassCount;
	public uint32_t* pViewMasks;
	public uint32_t dependencyCount;
	public int32_t* pViewOffsets;
	public uint32_t correlationMaskCount;
	public uint32_t* pCorrelationMasks;
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
	public uint32_t maxMultiviewViewCount;
	public uint32_t maxMultiviewInstanceIndex;
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
	public HANDLE handle;
}
public unsafe struct VkExportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public uint64_t* pAcquireKeys;
	public uint32_t* pAcquireTimeoutMilliseconds;
	public uint32_t releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public uint64_t* pReleaseKeys;
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
	public VkSampleCountFlagBits samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
[Obsolete("Use VkMemoryAllocateFlagsInfo")]
public unsafe struct VkMemoryAllocateFlagsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint32_t deviceMask;
}
[Obsolete("Use VkDeviceGroupRenderPassBeginInfo")]
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
	public uint32_t deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
[Obsolete("Use VkDeviceGroupCommandBufferBeginInfo")]
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
}
[Obsolete("Use VkDeviceGroupSubmitInfo")]
public unsafe struct VkDeviceGroupSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public uint32_t* pWaitSemaphoreDeviceIndices;
	public uint32_t commandBufferCount;
	public uint32_t* pCommandBufferDeviceMasks;
	public uint32_t signalSemaphoreCount;
	public uint32_t* pSignalSemaphoreDeviceIndices;
}
[Obsolete("Use VkDeviceGroupBindSparseInfo")]
public unsafe struct VkDeviceGroupBindSparseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t resourceDeviceIndex;
	public uint32_t memoryDeviceIndex;
}
[Obsolete("Use VkBindBufferMemoryDeviceGroupInfo")]
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
[Obsolete("Use VkBindImageMemoryDeviceGroupInfo")]
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
	public uint32_t splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t disabledValidationCheckCount;
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
	public uint32_t physicalDeviceCount;
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
	public uint32_t physicalDeviceCount;
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
	public VkExternalMemoryHandleTypeFlagBits handleType;
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
	public VkExternalMemoryHandleTypeFlagBits handleType;
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
	public uint8_t deviceUUID_0;
	public uint8_t deviceUUID_1;
	public uint8_t deviceUUID_2;
	public uint8_t deviceUUID_3;
	public uint8_t deviceUUID_4;
	public uint8_t deviceUUID_5;
	public uint8_t deviceUUID_6;
	public uint8_t deviceUUID_7;
	public uint8_t deviceUUID_8;
	public uint8_t deviceUUID_9;
	public uint8_t deviceUUID_10;
	public uint8_t deviceUUID_11;
	public uint8_t deviceUUID_12;
	public uint8_t deviceUUID_13;
	public uint8_t deviceUUID_14;
	public uint8_t deviceUUID_15;
	public uint8_t driverUUID_0;
	public uint8_t driverUUID_1;
	public uint8_t driverUUID_2;
	public uint8_t driverUUID_3;
	public uint8_t driverUUID_4;
	public uint8_t driverUUID_5;
	public uint8_t driverUUID_6;
	public uint8_t driverUUID_7;
	public uint8_t driverUUID_8;
	public uint8_t driverUUID_9;
	public uint8_t driverUUID_10;
	public uint8_t driverUUID_11;
	public uint8_t driverUUID_12;
	public uint8_t driverUUID_13;
	public uint8_t driverUUID_14;
	public uint8_t driverUUID_15;
	public uint8_t deviceLUID_0;
	public uint8_t deviceLUID_1;
	public uint8_t deviceLUID_2;
	public uint8_t deviceLUID_3;
	public uint8_t deviceLUID_4;
	public uint8_t deviceLUID_5;
	public uint8_t deviceLUID_6;
	public uint8_t deviceLUID_7;
	public uint32_t deviceNodeMask;
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
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkMemoryGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkMemoryFdPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public uint64_t* pAcquireKeys;
	public uint32_t* pAcquireTimeouts;
	public uint32_t releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public uint64_t* pReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceExternalSemaphoreInfo")]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
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
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreValuesCount;
	public uint64_t* pWaitSemaphoreValues;
	public uint32_t signalSemaphoreValuesCount;
	public uint64_t* pSignalSemaphoreValues;
}
public unsafe struct VkImportSemaphoreFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxPushDescriptors;
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
	public uint32_t swapchainCount;
	public VkPresentRegionKHR* pRegions;
}
public unsafe struct VkPresentRegionKHR
{
	public uint32_t rectangleCount;
	public VkRectLayerKHR* pRectangles;
}
public unsafe struct VkRectLayerKHR
{
	public VkOffset2D offset;
	public VkExtent2D extent;
	public uint32_t layer;
}
[Obsolete("Use VkDescriptorUpdateTemplateEntry")]
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
	public VkDescriptorType descriptorType;
	public size_t offset;
	public size_t stride;
}
[Obsolete("Use VkDescriptorUpdateTemplateCreateInfo")]
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint32_t descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint32_t set;
}
public unsafe struct VkCmdProcessCommandsInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectTableNVX objectTable;
	public VkIndirectCommandsLayoutNVX indirectCommandsLayout;
	public uint32_t indirectCommandsTokenCount;
	public VkIndirectCommandsTokenNVX* pIndirectCommandsTokens;
	public uint32_t maxSequencesCount;
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
	public uint32_t maxSequencesCount;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkIndirectCommandsLayoutUsageFlagsNVX flags;
	public uint32_t tokenCount;
	public VkIndirectCommandsLayoutTokenNVX* pTokens;
}
public unsafe struct VkIndirectCommandsLayoutTokenNVX
{
	public VkIndirectCommandsTokenTypeNVX tokenType;
	public uint32_t bindingUnit;
	public uint32_t dynamicCount;
	public uint32_t divisor;
}
public unsafe struct VkObjectTableCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t objectCount;
	public VkObjectEntryTypeNVX* pObjectEntryTypes;
	public uint32_t* pObjectEntryCounts;
	public VkObjectEntryUsageFlagsNVX* pObjectEntryUsageFlags;
	public uint32_t maxUniformBuffersPerDescriptor;
	public uint32_t maxStorageBuffersPerDescriptor;
	public uint32_t maxStorageImagesPerDescriptor;
	public uint32_t maxSampledImagesPerDescriptor;
	public uint32_t maxPipelineLayouts;
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
	public uint32_t maxIndirectCommandsLayoutTokenCount;
	public uint32_t maxObjectEntryCounts;
	public uint32_t minSequenceCountBufferOffsetAlignment;
	public uint32_t minSequenceIndexBufferOffsetAlignment;
	public uint32_t minCommandsTokenBufferOffsetAlignment;
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
	public uint32_t viewportCount;
	public VkViewportWScalingNV* pViewportWScalings;
}
public unsafe struct VkSurfaceCapabilities2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t minImageCount;
	public uint32_t maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint32_t maxImageArrayLayers;
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
	public uint64_t refreshDuration;
}
public unsafe struct VkPastPresentationTimingGOOGLE
{
	public uint32_t presentID;
	public uint64_t desiredPresentTime;
	public uint64_t actualPresentTime;
	public uint64_t earliestPresentTime;
	public uint64_t presentMargin;
}
public unsafe struct VkPresentTimesInfoGOOGLE
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public VkPresentTimeGOOGLE* pTimes;
}
public unsafe struct VkPresentTimeGOOGLE
{
	public uint32_t presentID;
	public uint64_t desiredPresentTime;
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
	public uint32_t viewportCount;
	public VkViewportSwizzleNV* pViewportSwizzles;
}
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxDiscardRectangles;
}
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
	public VkDiscardRectangleModeEXT discardRectangleMode;
	public uint32_t discardRectangleCount;
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
	public uint32_t attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfoKHR* pAttachmentImageInfos;
}
public unsafe struct VkFramebufferAttachmentImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint32_t width;
	public uint32_t height;
	public uint32_t layerCount;
	public uint32_t viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkRenderPassAttachmentBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentCount;
	public VkImageView* pAttachments;
}
public unsafe struct VkRenderPassCreateInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint32_t attachmentCount;
	public VkAttachmentDescription2KHR* pAttachments;
	public uint32_t subpassCount;
	public VkSubpassDescription2KHR* pSubpasses;
	public uint32_t dependencyCount;
	public VkSubpassDependency2KHR* pDependencies;
	public uint32_t correlatedViewMaskCount;
	public uint32_t* pCorrelatedViewMasks;
}
public unsafe struct VkAttachmentDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
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
public unsafe struct VkSubpassDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint32_t viewMask;
	public uint32_t inputAttachmentCount;
	public VkAttachmentReference2KHR* pInputAttachments;
	public uint32_t colorAttachmentCount;
	public VkAttachmentReference2KHR* pColorAttachments;
	public VkAttachmentReference2KHR* pResolveAttachments;
	public VkAttachmentReference2KHR* pDepthStencilAttachment;
	public uint32_t preserveAttachmentCount;
	public uint32_t* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkSubpassDependency2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t srcSubpass;
	public uint32_t dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int32_t viewOffset;
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
	public VkExternalFenceHandleTypeFlagBits handleType;
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
	public VkExternalFenceHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkImportFenceFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
public unsafe struct VkPerformanceCounterKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterUnitKHR unit;
	public VkPerformanceCounterScopeKHR scope;
	public VkPerformanceCounterStorageKHR storage;
	public uint8_t uuid_0;
	public uint8_t uuid_1;
	public uint8_t uuid_2;
	public uint8_t uuid_3;
	public uint8_t uuid_4;
	public uint8_t uuid_5;
	public uint8_t uuid_6;
	public uint8_t uuid_7;
	public uint8_t uuid_8;
	public uint8_t uuid_9;
	public uint8_t uuid_10;
	public uint8_t uuid_11;
	public uint8_t uuid_12;
	public uint8_t uuid_13;
	public uint8_t uuid_14;
	public uint8_t uuid_15;
}
public unsafe struct VkPerformanceCounterDescriptionKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterDescriptionFlagsKHR flags;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char category[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
}
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t queueFamilyIndex;
	public uint32_t counterIndexCount;
	public uint32_t* pCounterIndices;
}
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAcquireProfilingLockFlagsKHR flags;
	public uint64_t timeout;
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
	public int32_t int32;
	[FieldOffset(0)]
	public int64_t int64;
	[FieldOffset(0)]
	public uint32_t uint32;
	[FieldOffset(0)]
	public uint64_t uint64;
	[FieldOffset(0)]
	public float float32;
	[FieldOffset(0)]
	public double float64;
}
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t counterPassIndex;
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
	public uint32_t aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
[Obsolete("Use VkInputAttachmentAspectReference")]
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint32_t subpass;
	public uint32_t inputAttachmentIndex;
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
	public uint32_t planeIndex;
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
	public uint64_t objectHandle;
	public char* pObjectName;
}
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectType objectType;
	public uint64_t objectHandle;
	public uint64_t tagName;
	public size_t tagSize;
	public void* pTag;
}
public unsafe struct VkDebugUtilsLabelEXT
{
	public VkStructureType sType;
	public void* pNext;
	public char* pLabelName;
	public fixed float color[];
}
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCreateFlagsEXT flags;
	public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
	public VkDebugUtilsMessageTypeFlagsEXT messageType;
	public PFN_vkDebugUtilsMessengerCallbackEXT pfnUserCallback;
	public void* pUserData;
}
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
	public char* pMessageIdName;
	public int32_t messageIdNumber;
	public char* pMessage;
	public uint32_t queueLabelCount;
	public VkDebugUtilsLabelEXT* pQueueLabels;
	public uint32_t cmdBufLabelCount;
	public VkDebugUtilsLabelEXT* pCmdBufLabels;
	public uint32_t objectCount;
	public VkDebugUtilsObjectNameInfoEXT* pObjects;
}
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint32_t memoryTypeBits;
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
	public uint64_t androidHardwareBufferUsage;
}
public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public uint64_t externalFormat;
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
	public AHardwareBuffer* buffer;
}
public unsafe struct VkExternalFormatANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t externalFormat;
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
	public uint32_t maxInlineUniformBlockSize;
	public uint32_t maxPerStageDescriptorInlineUniformBlocks;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint32_t maxDescriptorSetInlineUniformBlocks;
	public uint32_t maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t dataSize;
	public void* pData;
}
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInlineUniformBlockBindings;
}
public unsafe struct VkSampleLocationsInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlagBits sampleLocationsPerPixel;
	public VkExtent2D sampleLocationGridSize;
	public uint32_t sampleLocationsCount;
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
	public uint32_t attachmentIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkSubpassSampleLocationsEXT
{
	public uint32_t subpassIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentInitialSampleLocationsCount;
	public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
	public uint32_t postSubpassSampleLocationsCount;
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
	public uint32_t sampleLocationSubPixelBits;
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
	public uint32_t viewFormatCount;
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
	public uint32_t advancedBlendMaxColorAttachments;
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
	public uint32_t coverageToColorLocation;
}
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageModulationStateCreateFlagsNV flags;
	public VkCoverageModulationModeNV coverageModulationMode;
	public VkBool32 coverageModulationTableEnable;
	public uint32_t coverageModulationTableCount;
	public float* pCoverageModulationTable;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderSMCount;
	public uint32_t shaderWarpsPerSM;
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
	public VkImageAspectFlagBits planeAspect;
}
[Obsolete("Use VkImagePlaneMemoryRequirementsInfo")]
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
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
	public uint32_t combinedImageSamplerDescriptorCount;
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
	public uint64_t drmFormatModifier;
}
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t drmFormatModifierCount;
	public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
	public uint64_t drmFormatModifier;
	public uint32_t drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
}
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t drmFormatModifier;
	public VkSharingMode sharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
}
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t drmFormatModifierCount;
	public uint64_t* pDrmFormatModifiers;
}
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t drmFormatModifier;
	public uint32_t drmFormatModifierPlaneCount;
	public VkSubresourceLayout* pPlaneLayouts;
}
public unsafe struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkValidationCacheCreateFlagsEXT flags;
	public size_t initialDataSize;
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
	public uint32_t bindingCount;
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
	public uint32_t maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint32_t maxPerStageUpdateAfterBindResources;
	public uint32_t maxDescriptorSetUpdateAfterBindSamplers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindSampledImages;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageImages;
	public uint32_t maxDescriptorSetUpdateAfterBindInputAttachments;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t descriptorSetCount;
	public uint32_t* pDescriptorCounts;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxVariableDescriptorCount;
}
public unsafe struct VkShadingRatePaletteNV
{
	public uint32_t shadingRatePaletteEntryCount;
	public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
}
public unsafe struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV shadingRate;
	public uint32_t sampleCount;
	public uint32_t sampleLocationCount;
	public VkCoarseSampleLocationNV* pSampleLocations;
}
public unsafe struct VkCoarseSampleLocationNV
{
	public uint32_t pixelX;
	public uint32_t pixelY;
	public uint32_t sample;
}
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shadingRateImageEnable;
	public uint32_t viewportCount;
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
	public uint32_t shadingRatePaletteSize;
	public uint32_t shadingRateMaxCoarseSamples;
}
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkCoarseSampleOrderTypeNV sampleOrderType;
	public uint32_t customSampleOrderCount;
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
	public uint32_t instanceCount;
	public uint32_t geometryCount;
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
	public uint32_t vertexCount;
	public VkDeviceSize vertexStride;
	public VkFormat vertexFormat;
	public VkBuffer indexData;
	public VkDeviceSize indexOffset;
	public uint32_t indexCount;
	public VkIndexType indexType;
	public VkBuffer transformData;
	public VkDeviceSize transformOffset;
}
public unsafe struct VkGeometryAABBNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer aabbData;
	public uint32_t numAABBs;
	public uint32_t stride;
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
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint32_t stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public uint32_t groupCount;
	public VkRayTracingShaderGroupCreateInfoNV* pGroups;
	public uint32_t maxRecursionDepth;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingShaderGroupTypeNV type;
	public uint32_t generalShader;
	public uint32_t closestHitShader;
	public uint32_t anyHitShader;
	public uint32_t intersectionShader;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t accelerationStructureCount;
	public VkAccelerationStructureNV* pAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderGroupHandleSize;
	public uint32_t maxRecursionDepth;
	public uint32_t maxShaderGroupStride;
	public uint32_t shaderGroupBaseAlignment;
	public uint64_t maxGeometryCount;
	public uint64_t maxInstanceCount;
	public uint64_t maxTriangleCount;
	public uint32_t maxDescriptorSetAccelerationStructures;
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
	public uint32_t maxPerSetDescriptors;
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
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
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
	public uint32_t shaderEngineCount;
	public uint32_t shaderArraysPerEngineCount;
	public uint32_t computeUnitsPerShaderArray;
	public uint32_t simdPerComputeUnit;
	public uint32_t wavefrontsPerSimd;
	public uint32_t wavefrontSize;
	public uint32_t sgprsPerSimd;
	public uint32_t minSgprAllocation;
	public uint32_t maxSgprAllocation;
	public uint32_t sgprAllocationGranularity;
	public uint32_t vgprsPerSimd;
	public uint32_t minVgprAllocation;
	public uint32_t maxVgprAllocation;
	public uint32_t vgprAllocationGranularity;
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
	public uint32_t maxVertexAttribDivisor;
}
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
	public uint32_t binding;
	public uint32_t divisor;
}
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t vertexBindingDivisorCount;
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
	public uint32_t pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedbackEXT** pPipelineStageCreationFeedbacks;
}
public unsafe struct VkPipelineCreationFeedbackEXT
{
	public VkPipelineCreationFeedbackFlagsEXT flags;
	public uint64_t duration;
}
public unsafe struct VkConformanceVersionKHR
{
	public uint8_t major;
	public uint8_t minor;
	public uint8_t subminor;
	public uint8_t patch;
}
public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverIdKHR driverID;
	public fixed char driverName[VK.VK_MAX_DRIVER_NAME_SIZE_KHR];
	public fixed char driverInfo[VK.VK_MAX_DRIVER_INFO_SIZE_KHR];
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
	public VkResolveModeFlagBitsKHR depthResolveMode;
	public VkResolveModeFlagBitsKHR stencilResolveMode;
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
	public uint32_t maxDrawMeshTasksCount;
	public uint32_t maxTaskWorkGroupInvocations;
	public uint32_t maxTaskWorkGroupSize_0;
	public uint32_t maxTaskWorkGroupSize_1;
	public uint32_t maxTaskWorkGroupSize_2;
	public uint32_t maxTaskTotalMemorySize;
	public uint32_t maxTaskOutputCount;
	public uint32_t maxMeshWorkGroupInvocations;
	public uint32_t maxMeshWorkGroupSize_0;
	public uint32_t maxMeshWorkGroupSize_1;
	public uint32_t maxMeshWorkGroupSize_2;
	public uint32_t maxMeshTotalMemorySize;
	public uint32_t maxMeshOutputVertices;
	public uint32_t maxMeshOutputPrimitives;
	public uint32_t maxMeshMultiviewViewCount;
	public uint32_t meshOutputPerVertexGranularity;
	public uint32_t meshOutputPerPrimitiveGranularity;
}
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
	public uint32_t taskCount;
	public uint32_t firstTask;
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
	public uint32_t exclusiveScissorCount;
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
	public VkPipelineStageFlagBits stage;
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
	public uint32_t semaphoreCount;
	public VkSemaphore* pSemaphores;
	public uint64_t* pValues;
}
public unsafe struct VkSemaphoreSignalInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public uint64_t value;
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
	public uint64_t maxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreTypeKHR semaphoreType;
	public uint64_t initialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreValueCount;
	public uint64_t* pWaitSemaphoreValues;
	public uint32_t signalSemaphoreValueCount;
	public uint64_t* pSignalSemaphoreValues;
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
	public uint64_t marker;
}
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t marker;
}
public unsafe struct VkPerformanceOverrideInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceOverrideTypeINTEL type;
	public VkBool32 enable;
	public uint64_t parameter;
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
	public uint32_t value32;
	[FieldOffset(0)]
	public uint64_t value64;
	[FieldOffset(0)]
	public float valueFloat;
	[FieldOffset(0)]
	public VkBool32 valueBool;
	[FieldOffset(0)]
	public char* valueString;
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
	public uint32_t pciDomain;
	public uint32_t pciBus;
	public uint32_t pciDevice;
	public uint32_t pciFunction;
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
	public uint32_t minSubgroupSize;
	public uint32_t maxSubgroupSize;
	public uint32_t maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t requiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
	public uint32_t activeComputeUnitCount;
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
	public fixed char name[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public fixed char version[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public VkToolPurposeFlagsEXT purposes;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char layer[VK.VK_MAX_EXTENSION_NAME_SIZE];
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
	public uint32_t enabledValidationFeatureCount;
	public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
	public uint32_t disabledValidationFeatureCount;
	public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}
public unsafe struct VkCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t MSize;
	public uint32_t NSize;
	public uint32_t KSize;
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
	public VkSampleCountFlagBits rasterizationSamples;
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
	public HMONITOR hmonitor;
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
	public uint64_t opaqueCaptureAddress;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t opaqueCaptureAddress;
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
	public uint32_t lineSubPixelPrecisionBits;
}
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkLineRasterizationModeEXT lineRasterizationMode;
	public VkBool32 stippledLineEnable;
	public uint32_t lineStippleFactor;
	public uint16_t lineStipplePattern;
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
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public uint32_t subgroupSize;
}
public unsafe struct VkPipelineExecutableInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
	public uint32_t executableIndex;
}
public unsafe struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public VkPipelineExecutableStatisticFormatKHR format;
	public VkPipelineExecutableStatisticValueKHR value;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
	[FieldOffset(0)]
	public VkBool32 b32;
	[FieldOffset(0)]
	public int64_t i64;
	[FieldOffset(0)]
	public uint64_t u64;
	[FieldOffset(0)]
	public double f64;
}
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public VkBool32 isText;
	public size_t dataSize;
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
