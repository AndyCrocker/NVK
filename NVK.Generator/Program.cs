using System;
using System.IO;
using System.Xml.Linq;
using NVK.Generator.Specification;

namespace NVK.Generator;

/// <summary>The application entry point.</summary>
public class Program
{
    /*********
    ** Public Methods
    *********/
    /// <summary>The application entry point.</summary>
    public static void Main()
    {
        // ensure vk.xml exists
        var vkXmlPath = Path.Combine(Environment.CurrentDirectory, "vk.xml");
        if (!File.Exists(vkXmlPath))
            throw new FileNotFoundException($"{vkXmlPath} doesn't exist");

        // parse xml file to specification object 
        VulkanSpecification specification;
        using (var fileStream = File.OpenRead(vkXmlPath))
        {
            try
            {
                specification = new VulkanSpecification(XDocument.Load(fileStream));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to parse XML file to VulkanSpecification {ex}");
                return;
            }
        }

        // generate code
        CodeGenerator.GenerateCode(specification);
    }
}
