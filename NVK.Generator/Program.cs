namespace NVK.Generator;

/// <summary>The application entry point.</summary>
public class Program
{
    /*********
    ** Fields
    *********/
    /// <summary>The urls of the registries to parse.</summary>
    /// <remarks>Each major version of the registry needs to be parsed from a seperate version of the registry as extensions don't have enough data to determine how they were altered between versions.</remarks>
    private static List<(string Version, string URL)> RegistryUrls = new() {
        ("1.0", "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/v1.0.69-core/src/spec/vk.xml"),
        ("1.1", "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/v1.1.130/xml/vk.xml"),
        ("1.2", "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/v1.2.203/xml/vk.xml"),
        ("1.3", "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml")
    };


    /*********
    ** Public Methods
    *********/
    /// <summary>The application entry point.</summary>
    public static void Main()
    {
        var specifications = new List<(string Version, VulkanSpecification Specification)>();

        foreach (var registryUrl in RegistryUrls)
        {
            Console.WriteLine($"Parsing V{registryUrl.Version} XML registry...");
            specifications.Add((registryUrl.Version, new VulkanSpecification(registryUrl.URL)));
        }
    }
}
