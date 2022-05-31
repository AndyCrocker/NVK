// this file was generated, don't edit manually

using System;

namespace Vulkan
{
	public struct VkInstance
	{
		public readonly UIntPtr Handle;
		public bool IsNull => Handle == UIntPtr.Zero;
		public static VkInstance Null => new(UIntPtr.Zero);
		public VkInstance(UIntPtr handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkInstance handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkInstance left, VkInstance right) => left.Handle == right.Handle;
		public static bool operator !=(VkInstance left, VkInstance right) => left.Handle != right.Handle;
		public static bool operator ==(VkInstance left, UIntPtr right) => left.Handle == right;
		public static bool operator !=(VkInstance left, UIntPtr right) => left.Handle != right;
		public static bool operator ==(UIntPtr left, VkInstance right) => left == right.Handle;
		public static bool operator !=(UIntPtr left, VkInstance right) => left != right.Handle;
	}
	public struct VkPhysicalDevice
	{
		public readonly UIntPtr Handle;
		public bool IsNull => Handle == UIntPtr.Zero;
		public static VkPhysicalDevice Null => new(UIntPtr.Zero);
		public VkPhysicalDevice(UIntPtr handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPhysicalDevice handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle == right.Handle;
		public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle != right.Handle;
		public static bool operator ==(VkPhysicalDevice left, UIntPtr right) => left.Handle == right;
		public static bool operator !=(VkPhysicalDevice left, UIntPtr right) => left.Handle != right;
		public static bool operator ==(UIntPtr left, VkPhysicalDevice right) => left == right.Handle;
		public static bool operator !=(UIntPtr left, VkPhysicalDevice right) => left != right.Handle;
	}
	public struct VkDevice
	{
		public readonly UIntPtr Handle;
		public bool IsNull => Handle == UIntPtr.Zero;
		public static VkDevice Null => new(UIntPtr.Zero);
		public VkDevice(UIntPtr handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDevice handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDevice left, VkDevice right) => left.Handle == right.Handle;
		public static bool operator !=(VkDevice left, VkDevice right) => left.Handle != right.Handle;
		public static bool operator ==(VkDevice left, UIntPtr right) => left.Handle == right;
		public static bool operator !=(VkDevice left, UIntPtr right) => left.Handle != right;
		public static bool operator ==(UIntPtr left, VkDevice right) => left == right.Handle;
		public static bool operator !=(UIntPtr left, VkDevice right) => left != right.Handle;
	}
	public struct VkQueue
	{
		public readonly UIntPtr Handle;
		public bool IsNull => Handle == UIntPtr.Zero;
		public static VkQueue Null => new(UIntPtr.Zero);
		public VkQueue(UIntPtr handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkQueue handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkQueue left, VkQueue right) => left.Handle == right.Handle;
		public static bool operator !=(VkQueue left, VkQueue right) => left.Handle != right.Handle;
		public static bool operator ==(VkQueue left, UIntPtr right) => left.Handle == right;
		public static bool operator !=(VkQueue left, UIntPtr right) => left.Handle != right;
		public static bool operator ==(UIntPtr left, VkQueue right) => left == right.Handle;
		public static bool operator !=(UIntPtr left, VkQueue right) => left != right.Handle;
	}
	public struct VkCommandBuffer
	{
		public readonly UIntPtr Handle;
		public bool IsNull => Handle == UIntPtr.Zero;
		public static VkCommandBuffer Null => new(UIntPtr.Zero);
		public VkCommandBuffer(UIntPtr handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkCommandBuffer handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) => left.Handle == right.Handle;
		public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) => left.Handle != right.Handle;
		public static bool operator ==(VkCommandBuffer left, UIntPtr right) => left.Handle == right;
		public static bool operator !=(VkCommandBuffer left, UIntPtr right) => left.Handle != right;
		public static bool operator ==(UIntPtr left, VkCommandBuffer right) => left == right.Handle;
		public static bool operator !=(UIntPtr left, VkCommandBuffer right) => left != right.Handle;
	}
	public struct VkDeviceMemory
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDeviceMemory Null => new(0);
		public VkDeviceMemory(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDeviceMemory handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) => left.Handle == right.Handle;
		public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) => left.Handle != right.Handle;
		public static bool operator ==(VkDeviceMemory left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDeviceMemory left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDeviceMemory right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDeviceMemory right) => left != right.Handle;
	}
	public struct VkCommandPool
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkCommandPool Null => new(0);
		public VkCommandPool(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkCommandPool handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkCommandPool left, VkCommandPool right) => left.Handle == right.Handle;
		public static bool operator !=(VkCommandPool left, VkCommandPool right) => left.Handle != right.Handle;
		public static bool operator ==(VkCommandPool left, ulong right) => left.Handle == right;
		public static bool operator !=(VkCommandPool left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkCommandPool right) => left == right.Handle;
		public static bool operator !=(ulong left, VkCommandPool right) => left != right.Handle;
	}
	public struct VkBuffer
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkBuffer Null => new(0);
		public VkBuffer(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkBuffer handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkBuffer left, VkBuffer right) => left.Handle == right.Handle;
		public static bool operator !=(VkBuffer left, VkBuffer right) => left.Handle != right.Handle;
		public static bool operator ==(VkBuffer left, ulong right) => left.Handle == right;
		public static bool operator !=(VkBuffer left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkBuffer right) => left == right.Handle;
		public static bool operator !=(ulong left, VkBuffer right) => left != right.Handle;
	}
	public struct VkBufferView
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkBufferView Null => new(0);
		public VkBufferView(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkBufferView handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkBufferView left, VkBufferView right) => left.Handle == right.Handle;
		public static bool operator !=(VkBufferView left, VkBufferView right) => left.Handle != right.Handle;
		public static bool operator ==(VkBufferView left, ulong right) => left.Handle == right;
		public static bool operator !=(VkBufferView left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkBufferView right) => left == right.Handle;
		public static bool operator !=(ulong left, VkBufferView right) => left != right.Handle;
	}
	public struct VkImage
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkImage Null => new(0);
		public VkImage(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkImage handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkImage left, VkImage right) => left.Handle == right.Handle;
		public static bool operator !=(VkImage left, VkImage right) => left.Handle != right.Handle;
		public static bool operator ==(VkImage left, ulong right) => left.Handle == right;
		public static bool operator !=(VkImage left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkImage right) => left == right.Handle;
		public static bool operator !=(ulong left, VkImage right) => left != right.Handle;
	}
	public struct VkImageView
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkImageView Null => new(0);
		public VkImageView(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkImageView handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkImageView left, VkImageView right) => left.Handle == right.Handle;
		public static bool operator !=(VkImageView left, VkImageView right) => left.Handle != right.Handle;
		public static bool operator ==(VkImageView left, ulong right) => left.Handle == right;
		public static bool operator !=(VkImageView left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkImageView right) => left == right.Handle;
		public static bool operator !=(ulong left, VkImageView right) => left != right.Handle;
	}
	public struct VkShaderModule
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkShaderModule Null => new(0);
		public VkShaderModule(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkShaderModule handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkShaderModule left, VkShaderModule right) => left.Handle == right.Handle;
		public static bool operator !=(VkShaderModule left, VkShaderModule right) => left.Handle != right.Handle;
		public static bool operator ==(VkShaderModule left, ulong right) => left.Handle == right;
		public static bool operator !=(VkShaderModule left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkShaderModule right) => left == right.Handle;
		public static bool operator !=(ulong left, VkShaderModule right) => left != right.Handle;
	}
	public struct VkPipeline
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPipeline Null => new(0);
		public VkPipeline(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPipeline handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPipeline left, VkPipeline right) => left.Handle == right.Handle;
		public static bool operator !=(VkPipeline left, VkPipeline right) => left.Handle != right.Handle;
		public static bool operator ==(VkPipeline left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPipeline left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPipeline right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPipeline right) => left != right.Handle;
	}
	public struct VkPipelineLayout
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPipelineLayout Null => new(0);
		public VkPipelineLayout(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPipelineLayout handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) => left.Handle == right.Handle;
		public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) => left.Handle != right.Handle;
		public static bool operator ==(VkPipelineLayout left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPipelineLayout left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPipelineLayout right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPipelineLayout right) => left != right.Handle;
	}
	public struct VkSampler
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSampler Null => new(0);
		public VkSampler(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSampler handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSampler left, VkSampler right) => left.Handle == right.Handle;
		public static bool operator !=(VkSampler left, VkSampler right) => left.Handle != right.Handle;
		public static bool operator ==(VkSampler left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSampler left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSampler right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSampler right) => left != right.Handle;
	}
	public struct VkDescriptorSet
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDescriptorSet Null => new(0);
		public VkDescriptorSet(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDescriptorSet handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) => left.Handle == right.Handle;
		public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) => left.Handle != right.Handle;
		public static bool operator ==(VkDescriptorSet left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDescriptorSet left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDescriptorSet right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDescriptorSet right) => left != right.Handle;
	}
	public struct VkDescriptorSetLayout
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDescriptorSetLayout Null => new(0);
		public VkDescriptorSetLayout(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDescriptorSetLayout handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle == right.Handle;
		public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle != right.Handle;
		public static bool operator ==(VkDescriptorSetLayout left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDescriptorSetLayout left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDescriptorSetLayout right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDescriptorSetLayout right) => left != right.Handle;
	}
	public struct VkDescriptorPool
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDescriptorPool Null => new(0);
		public VkDescriptorPool(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDescriptorPool handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) => left.Handle == right.Handle;
		public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) => left.Handle != right.Handle;
		public static bool operator ==(VkDescriptorPool left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDescriptorPool left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDescriptorPool right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDescriptorPool right) => left != right.Handle;
	}
	public struct VkFence
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkFence Null => new(0);
		public VkFence(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkFence handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkFence left, VkFence right) => left.Handle == right.Handle;
		public static bool operator !=(VkFence left, VkFence right) => left.Handle != right.Handle;
		public static bool operator ==(VkFence left, ulong right) => left.Handle == right;
		public static bool operator !=(VkFence left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkFence right) => left == right.Handle;
		public static bool operator !=(ulong left, VkFence right) => left != right.Handle;
	}
	public struct VkSemaphore
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSemaphore Null => new(0);
		public VkSemaphore(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSemaphore handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSemaphore left, VkSemaphore right) => left.Handle == right.Handle;
		public static bool operator !=(VkSemaphore left, VkSemaphore right) => left.Handle != right.Handle;
		public static bool operator ==(VkSemaphore left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSemaphore left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSemaphore right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSemaphore right) => left != right.Handle;
	}
	public struct VkEvent
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkEvent Null => new(0);
		public VkEvent(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkEvent handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkEvent left, VkEvent right) => left.Handle == right.Handle;
		public static bool operator !=(VkEvent left, VkEvent right) => left.Handle != right.Handle;
		public static bool operator ==(VkEvent left, ulong right) => left.Handle == right;
		public static bool operator !=(VkEvent left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkEvent right) => left == right.Handle;
		public static bool operator !=(ulong left, VkEvent right) => left != right.Handle;
	}
	public struct VkQueryPool
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkQueryPool Null => new(0);
		public VkQueryPool(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkQueryPool handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkQueryPool left, VkQueryPool right) => left.Handle == right.Handle;
		public static bool operator !=(VkQueryPool left, VkQueryPool right) => left.Handle != right.Handle;
		public static bool operator ==(VkQueryPool left, ulong right) => left.Handle == right;
		public static bool operator !=(VkQueryPool left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkQueryPool right) => left == right.Handle;
		public static bool operator !=(ulong left, VkQueryPool right) => left != right.Handle;
	}
	public struct VkFramebuffer
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkFramebuffer Null => new(0);
		public VkFramebuffer(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkFramebuffer handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkFramebuffer left, VkFramebuffer right) => left.Handle == right.Handle;
		public static bool operator !=(VkFramebuffer left, VkFramebuffer right) => left.Handle != right.Handle;
		public static bool operator ==(VkFramebuffer left, ulong right) => left.Handle == right;
		public static bool operator !=(VkFramebuffer left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkFramebuffer right) => left == right.Handle;
		public static bool operator !=(ulong left, VkFramebuffer right) => left != right.Handle;
	}
	public struct VkRenderPass
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkRenderPass Null => new(0);
		public VkRenderPass(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkRenderPass handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkRenderPass left, VkRenderPass right) => left.Handle == right.Handle;
		public static bool operator !=(VkRenderPass left, VkRenderPass right) => left.Handle != right.Handle;
		public static bool operator ==(VkRenderPass left, ulong right) => left.Handle == right;
		public static bool operator !=(VkRenderPass left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkRenderPass right) => left == right.Handle;
		public static bool operator !=(ulong left, VkRenderPass right) => left != right.Handle;
	}
	public struct VkPipelineCache
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPipelineCache Null => new(0);
		public VkPipelineCache(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPipelineCache handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPipelineCache left, VkPipelineCache right) => left.Handle == right.Handle;
		public static bool operator !=(VkPipelineCache left, VkPipelineCache right) => left.Handle != right.Handle;
		public static bool operator ==(VkPipelineCache left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPipelineCache left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPipelineCache right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPipelineCache right) => left != right.Handle;
	}
	public struct VkIndirectCommandsLayoutNV
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkIndirectCommandsLayoutNV Null => new(0);
		public VkIndirectCommandsLayoutNV(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkIndirectCommandsLayoutNV handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle == right.Handle;
		public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle != right.Handle;
		public static bool operator ==(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle == right;
		public static bool operator !=(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkIndirectCommandsLayoutNV right) => left == right.Handle;
		public static bool operator !=(ulong left, VkIndirectCommandsLayoutNV right) => left != right.Handle;
	}
	public struct VkDescriptorUpdateTemplate
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDescriptorUpdateTemplate Null => new(0);
		public VkDescriptorUpdateTemplate(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDescriptorUpdateTemplate handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle == right.Handle;
		public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle != right.Handle;
		public static bool operator ==(VkDescriptorUpdateTemplate left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDescriptorUpdateTemplate left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDescriptorUpdateTemplate right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDescriptorUpdateTemplate right) => left != right.Handle;
	}
	public struct VkDescriptorUpdateTemplateKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDescriptorUpdateTemplateKHR Null => new(0);
		public VkDescriptorUpdateTemplateKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDescriptorUpdateTemplateKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDescriptorUpdateTemplateKHR left, VkDescriptorUpdateTemplateKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkDescriptorUpdateTemplateKHR left, VkDescriptorUpdateTemplateKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkDescriptorUpdateTemplateKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDescriptorUpdateTemplateKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDescriptorUpdateTemplateKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDescriptorUpdateTemplateKHR right) => left != right.Handle;
	}
	public struct VkSamplerYcbcrConversion
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSamplerYcbcrConversion Null => new(0);
		public VkSamplerYcbcrConversion(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSamplerYcbcrConversion handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle == right.Handle;
		public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle != right.Handle;
		public static bool operator ==(VkSamplerYcbcrConversion left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSamplerYcbcrConversion left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSamplerYcbcrConversion right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSamplerYcbcrConversion right) => left != right.Handle;
	}
	public struct VkSamplerYcbcrConversionKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSamplerYcbcrConversionKHR Null => new(0);
		public VkSamplerYcbcrConversionKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSamplerYcbcrConversionKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSamplerYcbcrConversionKHR left, VkSamplerYcbcrConversionKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkSamplerYcbcrConversionKHR left, VkSamplerYcbcrConversionKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkSamplerYcbcrConversionKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSamplerYcbcrConversionKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSamplerYcbcrConversionKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSamplerYcbcrConversionKHR right) => left != right.Handle;
	}
	public struct VkValidationCacheEXT
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkValidationCacheEXT Null => new(0);
		public VkValidationCacheEXT(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkValidationCacheEXT handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle == right.Handle;
		public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle != right.Handle;
		public static bool operator ==(VkValidationCacheEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(VkValidationCacheEXT left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkValidationCacheEXT right) => left == right.Handle;
		public static bool operator !=(ulong left, VkValidationCacheEXT right) => left != right.Handle;
	}
	public struct VkAccelerationStructureKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkAccelerationStructureKHR Null => new(0);
		public VkAccelerationStructureKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkAccelerationStructureKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkAccelerationStructureKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkAccelerationStructureKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkAccelerationStructureKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkAccelerationStructureKHR right) => left != right.Handle;
	}
	public struct VkAccelerationStructureNV
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkAccelerationStructureNV Null => new(0);
		public VkAccelerationStructureNV(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkAccelerationStructureNV handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle == right.Handle;
		public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle != right.Handle;
		public static bool operator ==(VkAccelerationStructureNV left, ulong right) => left.Handle == right;
		public static bool operator !=(VkAccelerationStructureNV left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkAccelerationStructureNV right) => left == right.Handle;
		public static bool operator !=(ulong left, VkAccelerationStructureNV right) => left != right.Handle;
	}
	public struct VkPerformanceConfigurationINTEL
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPerformanceConfigurationINTEL Null => new(0);
		public VkPerformanceConfigurationINTEL(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPerformanceConfigurationINTEL handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle == right.Handle;
		public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle != right.Handle;
		public static bool operator ==(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPerformanceConfigurationINTEL right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPerformanceConfigurationINTEL right) => left != right.Handle;
	}
	public struct VkDeferredOperationKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDeferredOperationKHR Null => new(0);
		public VkDeferredOperationKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDeferredOperationKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkDeferredOperationKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDeferredOperationKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDeferredOperationKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDeferredOperationKHR right) => left != right.Handle;
	}
	public struct VkPrivateDataSlot
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPrivateDataSlot Null => new(0);
		public VkPrivateDataSlot(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPrivateDataSlot handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Handle == right.Handle;
		public static bool operator !=(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Handle != right.Handle;
		public static bool operator ==(VkPrivateDataSlot left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPrivateDataSlot left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPrivateDataSlot right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPrivateDataSlot right) => left != right.Handle;
	}
	public struct VkPrivateDataSlotEXT
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkPrivateDataSlotEXT Null => new(0);
		public VkPrivateDataSlotEXT(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkPrivateDataSlotEXT handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Handle == right.Handle;
		public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Handle != right.Handle;
		public static bool operator ==(VkPrivateDataSlotEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(VkPrivateDataSlotEXT left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkPrivateDataSlotEXT right) => left == right.Handle;
		public static bool operator !=(ulong left, VkPrivateDataSlotEXT right) => left != right.Handle;
	}
	public struct VkCuModuleNVX
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkCuModuleNVX Null => new(0);
		public VkCuModuleNVX(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkCuModuleNVX handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right) => left.Handle == right.Handle;
		public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right) => left.Handle != right.Handle;
		public static bool operator ==(VkCuModuleNVX left, ulong right) => left.Handle == right;
		public static bool operator !=(VkCuModuleNVX left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkCuModuleNVX right) => left == right.Handle;
		public static bool operator !=(ulong left, VkCuModuleNVX right) => left != right.Handle;
	}
	public struct VkCuFunctionNVX
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkCuFunctionNVX Null => new(0);
		public VkCuFunctionNVX(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkCuFunctionNVX handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Handle == right.Handle;
		public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Handle != right.Handle;
		public static bool operator ==(VkCuFunctionNVX left, ulong right) => left.Handle == right;
		public static bool operator !=(VkCuFunctionNVX left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkCuFunctionNVX right) => left == right.Handle;
		public static bool operator !=(ulong left, VkCuFunctionNVX right) => left != right.Handle;
	}
	public struct VkDisplayKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDisplayKHR Null => new(0);
		public VkDisplayKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDisplayKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkDisplayKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDisplayKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDisplayKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDisplayKHR right) => left != right.Handle;
	}
	public struct VkDisplayModeKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDisplayModeKHR Null => new(0);
		public VkDisplayModeKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDisplayModeKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkDisplayModeKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDisplayModeKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDisplayModeKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDisplayModeKHR right) => left != right.Handle;
	}
	public struct VkSurfaceKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSurfaceKHR Null => new(0);
		public VkSurfaceKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSurfaceKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkSurfaceKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSurfaceKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSurfaceKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSurfaceKHR right) => left != right.Handle;
	}
	public struct VkSwapchainKHR
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkSwapchainKHR Null => new(0);
		public VkSwapchainKHR(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkSwapchainKHR handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle == right.Handle;
		public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle != right.Handle;
		public static bool operator ==(VkSwapchainKHR left, ulong right) => left.Handle == right;
		public static bool operator !=(VkSwapchainKHR left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkSwapchainKHR right) => left == right.Handle;
		public static bool operator !=(ulong left, VkSwapchainKHR right) => left != right.Handle;
	}
	public struct VkDebugReportCallbackEXT
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDebugReportCallbackEXT Null => new(0);
		public VkDebugReportCallbackEXT(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDebugReportCallbackEXT handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle == right.Handle;
		public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle != right.Handle;
		public static bool operator ==(VkDebugReportCallbackEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDebugReportCallbackEXT left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDebugReportCallbackEXT right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDebugReportCallbackEXT right) => left != right.Handle;
	}
	public struct VkDebugUtilsMessengerEXT
	{
		public readonly ulong Handle;
		public bool IsNull => Handle == 0;
		public static VkDebugUtilsMessengerEXT Null => new(0);
		public VkDebugUtilsMessengerEXT(ulong handle)
		{
			Handle = handle;
		}
		public override bool Equals(object obj) => obj is VkDebugUtilsMessengerEXT handle && this == handle;
		public override int GetHashCode() => Handle.GetHashCode();
		public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
		public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
		public static bool operator ==(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle != right;
		public static bool operator ==(ulong left, VkDebugUtilsMessengerEXT right) => left == right.Handle;
		public static bool operator !=(ulong left, VkDebugUtilsMessengerEXT right) => left != right.Handle;
	}
}
