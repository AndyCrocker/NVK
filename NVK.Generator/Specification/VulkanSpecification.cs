namespace NVK.Generator.Specification;

/// <summary>Represents the Vulkan specification.</summary>
internal class VulkanSpecification
{
    /*********
    ** Properties
    *********/
    /// <summary>The defines the specification.</summary>
    public List<string> Defines { get; }

    /// <summary>The constants in the specification.</summary>
    public List<ConstantInfo> Constants { get; }

    /// <summary>The enums in the specification.</summary>
    public List<EnumInfo> Enums { get; }

    /// <summary>The handles in the specification.</summary>
    public List<HandleInfo> Handles { get; }

    /// <summary>The structures in the specification.</summary>
    public List<StructureInfo> Structures { get; }

    /// <summary>The delegates in the specification.</summary>
    public List<DelegateInfo> Delegates { get; }

    /// <summary>The functions in the specification.</summary>
    public List<FunctionInfo> Functions { get; }

    /// <summary>The feature of the specification.</summary>
    public FeatureInfo Feature { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="registryUrl">The url of the registry XML.</param>
    public VulkanSpecification(string registryUrl)
    {
        var specificationDocument = XDocument.Load(registryUrl);

        var registryElement = specificationDocument.Element("registry")!;
        var typeElements = registryElement.Elements("types").Elements("type");
        var enumsElements = registryElement.Elements("enums");
        var commandElements = registryElement.Elements("commands").Elements("command");
        var extensionElements = registryElement.Element("extensions")!.Elements("extension");
        var featureElements = registryElement.Elements("feature");

        // defines aren't used in the C# generation, but are required as they are references in <feature> tags
        Defines = typeElements.WithAttribute("category", "define")
            .Select(defineElement => defineElement.Attribute("name")?.Value ?? defineElement.Element("name")!.Value).ToList();
        Defines.Add("vk_platform"); // vk_platform is actually an include, however, it's the only include that's references in <feature> tags so it'll just be hardcoded here for now

        Constants = enumsElements.WithAttribute("name", "API Constants").Elements("enum")
            .Select(constantElement => new ConstantInfo(constantElement)).ToList();

        // enums are declared and defined in different places, first parse the definitions then copy over all the declarations, taking into account duplicating definitions for aliased enums
        var enumDefinitions = enumsElements.WithoutAttribute("name", "API Constants")
            .Select(enumsElement => new EnumInfo(enumsElement)).ToList();
        Enums = typeElements.WithAttribute("category", "enum", "bitmask")
            .Select(enumElement => new EnumInfo(enumElement, enumDefinitions)).ToList();

        Handles = typeElements.WithAttribute("category", "handle")
            .Select(handleElement => new HandleInfo(handleElement)).ToList();

        Structures = typeElements.WithAttribute("category", "struct", "union")
            .Select(structureElement => new StructureInfo(structureElement)).ToList();

        Delegates = typeElements.WithAttribute("category", "funcpointer")
            .Select(delegateElement => new DelegateInfo(delegateElement)).ToList();

        var supportedPlatforms = new[] { "win32", "macos", "xlib", "xcb", "wayland", "android" };
        var allExtensions = extensionElements
            .Select(extensionElement => new ExtensionInfo(extensionElement, this));
        var supportedExtensions = allExtensions
            .Where(extensionInfo => extensionInfo.Supported != "disabled")
            .Where(extensionInfo => extensionInfo.Platform == null || supportedPlatforms.Contains(extensionInfo.Platform)).ToList();

        Functions = commandElements.Select(commandElement => new FunctionInfo(commandElement)).ToList();

        Feature = new FeatureInfo(featureElements, supportedExtensions, this);
    }
}
