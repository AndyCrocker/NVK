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
        Console.WriteLine("Parsing XML registry...");
        var specification = VulkanSpecification.Generate();
        Console.WriteLine("Parsed XML registry");

        Console.WriteLine("Parsing HTML documentation...");
        DocumentationGenerator.Generate(specification);
        Console.WriteLine("Parsed HTML documentation");

        Console.WriteLine("Generating C#...");
        CodeGenerator.GenerateCode(specification);
        Console.WriteLine("Generated C#");
    }
}
