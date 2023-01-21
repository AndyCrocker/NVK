namespace NVK.Generator;

// <summary>Handles generating C# code.</summary>
internal static class CodeGenerator
{
    /*********
    ** Constants
    *********/
    /// <summary>The C# code that is present at the top of the file mentioning the file is generated and shouldn't be edited directly.</summary>
    private const string GeneratedWarningCode = "// This file was generated, don't manually edit";

    /// <summary>The path to the root of the NVK project.</summary>
    private const string NVKPath = "../../../../NVK/";

    /// <summary>The path to the ToCopy files containing files that should be copied to the NVK project.</summary>
    private const string ToCopyPath = "../../../ToCopy/";


    /*********
    ** Fields
    *********/
    /// <summary>The name of the namespace for the current specification version being written.</summary>
    private static string NamespaceName = "";

    /// <summary>The path to the output of the current specification version.</summary>
    private static string OutputPath = "";

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    
    /// <summary>The specification that is currently being written.</summary>
    private static FeatureInfo Specification;

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


    /*********
    ** Properties
    *********/
    /// <summary>The the C# namespace code.</summary>
    private static string NamespaceCode => $"namespace {NamespaceName};";


    /*********
    ** Public Methods
    *********/
    /// <summary>Generates the C# files for a specification.</summary>
    /// <param name="version">The version of the specification.</param>
    /// <param name="specification">The specification to generates files for.</param>
    public static void Generate(string version, FeatureInfo specification)
    {
        Specification = specification;

        NamespaceName = $"Vulkan_{version.Replace(".", "_")}";
        OutputPath = $"{NVKPath}/{NamespaceName}";
        Directory.CreateDirectory(OutputPath);

        GeneratedToCopyFiles();
        GenerateStructuresFile();
        GenerateHandlesFile();
        GenerateDelegatesFile();
        GenerateEnumsFile();
        GenerateVkFile();
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Copies all the files located in <see cref="ToCopyPath"/> to <see cref="OutputPath"/>.</summary>
    private static void GeneratedToCopyFiles()
    {
        foreach (var toCopyFile in new DirectoryInfo(ToCopyPath).EnumerateFiles())
        {
            var toCopyFileLines = File.ReadAllLines(toCopyFile.FullName);

            var prefixLines = new[] { GeneratedWarningCode, NamespaceCode, "" };
            var toCopyFileName =  Path.ChangeExtension(toCopyFile.Name, ".gen.cs");

            File.WriteAllLines($"{OutputPath}/{toCopyFileName}", prefixLines.Concat(toCopyFileLines));
        }
    }

    /// <summary>Generates the file containing the structures to <see cref="OutputPath"/>.</summary>
    private static void GenerateStructuresFile()
    {
        using var writer = CreateFileWriter("Structures.gen.cs");

        foreach (var structureInfo in Specification.Structures)
            structureInfo.Write(writer, Specification);
    }

    /// <summary>Generates the file containing the handles to <see cref="OutputPath"/>.</summary>
    private static void GenerateHandlesFile()
    {
        using var writer = CreateFileWriter("Handles.gen.cs");

        foreach (var handleInfo in Specification.Handles)
            handleInfo.Write(writer);
    }

    /// <summary>Generates the file containing the delegates to <see cref="OutputPath"/>.</summary>
    private static void GenerateDelegatesFile()
    {
        using var writer = CreateFileWriter("Delegates.gen.cs");

        foreach (var delegateInfo in Specification.Delegates)
            delegateInfo.Write(writer);
    }

    /// <summary>Generates the file containing the enums to <see cref="OutputPath"/>.</summary>
    private static void GenerateEnumsFile()
    {
        using var writer = CreateFileWriter("Enums.gen.cs");

        foreach (var enumInfo in Specification.Enums)
            enumInfo.Write(writer);
    }

    /// <summary>Generates the file containing the constants and functions to <see cref="OutputPath"/>.</summary>
    private static void GenerateVkFile()
    {
        using var writer = CreateFileWriter("VK.gen.cs");

        writer.WriteLine("public static unsafe class VK");
        writer.WriteScope(() =>
        {
            foreach (var constantInfo in Specification.Constants)
                constantInfo.Write(writer);

            foreach (var functionInfo in Specification.Functions)
                functionInfo.Write(writer, Specification);

            writer.WriteLine("private static readonly OSVulkanLibraryBase VulkanLibrary;");
            writer.WriteLine("static VK()");
            writer.WriteScope(() =>
            {
                writer.WriteLine("VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();");
                writer.WriteLine("InitialiseRequiredMethods();");
            });

            var requiredMethods = new[] { "vkCreateInstance", "vkEnumerateInstanceExtensionProperties", "vkEnumerateInstanceLayerProperties", "vkGetInstanceProcAddr" };

            // required methods (methods that have pointers set before an instance is created)
            writer.WriteLine("private static void InitialiseRequiredMethods()");
            writer.WriteScope(() =>
            {
                foreach (var functionInfo in Specification.Functions.Where(functionInfo => requiredMethods.Contains(functionInfo.Name)))
                    functionInfo.WriteRequiredFunction(writer);
            });

            // instance methods (methods that have pointers set after an instance is created)
            writer.WriteLine("public static void InitialiseInstanceMethods(VkInstance instance)");
            writer.WriteScope(() =>
            {
                foreach (var functionInfo in Specification.Functions.Where(commandInfo => !requiredMethods.Contains(commandInfo.Name)))
                    functionInfo.WriteInstanceFunction(writer);
            });
        });
    }

    /// <summary>Creates a C# writer and writes the header to it.</summary>
    /// <param name="fileName">The name of the file to create the writer for.</param>
    /// <returns>The created C# writer.</returns>
    private static CsWriter CreateFileWriter(string fileName)
    {
        var streamWriter = File.CreateText($"{OutputPath}/{fileName}");
        var writer = new CsWriter(streamWriter);

        writer.WriteLine(GeneratedWarningCode);
        writer.WriteLine(NamespaceCode);
        writer.WriteLine();

        return writer;
    }
}
