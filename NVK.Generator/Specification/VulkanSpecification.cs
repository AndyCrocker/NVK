namespace NVK.Generator.Specification;

/// <summary>Represents the Vulkan specification.</summary>
internal class VulkanSpecification
{
    /*********
    ** Fields
    *********/
    /// <summary>The extensions in the specification.</summary>
    private readonly List<ExtensionInfo> Extensions = new();


    /*********
    ** Properties
    *********/
    /// <summary>The constants in the specification.</summary>
    public List<ConstantInfo> Constants { get; } = new();

    /// <summary>The enums in the specification.</summary>
    public List<EnumInfo> Enums { get; } = new();

    /// <summary>The handles in the specification.</summary>
    public List<HandleInfo> Handles { get; } = new();

    /// <summary>The structures in the specification.</summary>
    public List<StructureInfo> Structures { get; } = new();

    /// <summary>The functions in the specification.</summary>
    public List<FunctionInfo> Functions { get; } = new();

    /// <summary>The feature of the specification.</summary>
    public FeatureInfo Feature { get; private set; }

    /// <summary>The vendor tags of the specification.</summary>
    public static List<string> VendorTags { get; private set; } = new();

    /// <summary>The function pointers in the specification.</summary>
    public static List<FunctionPointerInfo> FunctionPointers { get; private set; } = new();


    /*********
    ** Constructors
    *********/
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    /// <summary>Constructs an instance.</summary>
    /// <param name="vkUrl">The url of the vk.xml file.</param>
    /// <param name="videoUrl">The url of the video.xml file.</param>
    public VulkanSpecification(string vkUrl, string? videoUrl)
    {
        VendorTags = new();
        FunctionPointers = new();

        if (videoUrl != null)
            ParseVideoXML(XDocument.Load(videoUrl));

        ParseVkXML(XDocument.Load(vkUrl));
    }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


    /*********
    ** Private Methods
    *********/
    /// <summary>Parses the video.xml file.</summary>
    /// <param name="videoDocument">The parsed video.xml file.</param>
    private void ParseVideoXML(XDocument videoDocument)
    {
        var registryElement = videoDocument.Element("registry")!;

        var typeElements = registryElement.Elements("types").Elements("type");
        var enumsElements = registryElement.Elements("enums");
        var extensionElements = registryElement.Element("extensions")!.Elements("extension");

        ParseEnums(typeElements.WithAttribute("category", "enum"), enumsElements);
        ParseStructures(typeElements.WithAttribute("category", "struct"));
        ParseExtensions(extensionElements);
    }

    /// <summary>Parses the vk.xml file.</summary>
    /// <param name="vkDocument">The parsed vk.xml file.</param>
    private void ParseVkXML(XDocument vkDocument)
    {
        var registryElement = vkDocument.Element("registry")!;

        var tagElements = registryElement.Elements("tags").Elements("tag");
        var typeElements = registryElement.Elements("types").Elements("type");
        var enumsElements = registryElement.Elements("enums");
        var commandElements = registryElement.Elements("commands").Elements("command");
        var extensionElements = registryElement.Element("extensions")!.Elements("extension");
        var featureElements = registryElement.Elements("feature");

        VendorTags = tagElements
            .Select(tagElement => tagElement.Attribute("name")!.Value).ToList();

        // can't use linq here as some function pointers use earlier defined ones so they need to be available in FunctionPointers
        foreach (var functionPointerElement in typeElements.WithAttribute("category", "funcpointer"))
            FunctionPointers.Add(new(functionPointerElement));

        ParseEnums(typeElements.WithAttribute("category", "enum", "bitmask"), enumsElements.WithoutAttribute("name", "API Constants"));
        ParseStructures(typeElements.WithAttribute("category", "struct", "union"));

        Constants.AddRange(enumsElements.WithAttribute("name", "API Constants").Elements("enum")
            .Select(constantElement => new ConstantInfo(constantElement)));

        Handles.AddRange(typeElements.WithAttribute("category", "handle")
            .Select(handleElement => new HandleInfo(handleElement)));

        Functions.AddRange(commandElements.Select(commandElement => new FunctionInfo(commandElement, this)));

        ParseExtensions(extensionElements);

        Feature = new FeatureInfo(featureElements, Extensions, this);
    }

    /// <summary>Parses the enums of a document.</summary>
    /// <param name="enumTypeElements">The &lt;type&gt; elements of the enums to parse.</param>
    /// <param name="enumsElements">The &lt;enums&gt; elements of the enums to parse.</param>
    private void ParseEnums(IEnumerable<XElement> enumTypeElements, IEnumerable<XElement> enumsElements)
    {
        // enums are declared and defined in different places, first parse the definitions then copy over all the declarations, taking into account duplicating definitions for aliased enums
        var enumDefinitions = enumsElements
            .Select(enumsElement => new EnumInfo(enumsElement, true)).ToList();
        Enums.AddRange(enumTypeElements
            .Select(enumElement => new EnumInfo(enumElement, false)));

        foreach (var enumInfo in Enums) // Fields couldn't be populated at parsing time as they reference other declarations which may not have been parsed yet
            enumInfo.PopulateFields(Enums, enumDefinitions);
        
        // remove all "_FlagBits" enums, all relevant data was moved over from them to the "_Flags" enums and type conversion has already been set up
        Enums.RemoveAll(enumInfo => Enums.Any(ei => (enumInfo.Alias ?? enumInfo.Name) == ei.Requires));
    }

    /// <summary>Parses the structures of a document.</summary>
    /// <param name="structureTypeElements">The &lt;type&gt; elements of the structures to parse.</param>
    private void ParseStructures(IEnumerable<XElement> structureTypeElements)
    {
        var structureInfos = structureTypeElements
            .Select(structureElement => new StructureInfo(structureElement)).ToList();

        // some structures (in video.xml) are actually bitmasks, they use the `: [bitWidth]` C syntax on struct fields to use them as bitmasks
        // C# doesn't have an alternative to this as FieldOffset works with bytes, not bits.

        // there are some cases where we can't convert these to bitmasks as they're too big, or would be too inconvenient to use as some have all there fields
        // as wider than one bit, so if the structure has at least some fields that are one bit wide, we'll just convert it to a bitmask; otherwise, leave it
        // as a structure
        var bitfieldEnums = new List<EnumInfo>();
        for (int i = 0; i < structureInfos.Count; i++)
        {
            var structureInfo = structureInfos[i];
            var structureElement = structureTypeElements.ElementAt(i);

            var firstFieldElement = structureElement.Element("member");
            if (firstFieldElement != null && firstFieldElement.ToString().Contains(" : "))
                bitfieldEnums.Add(new(structureElement));
        }

        Structures.AddRange(structureInfos.Where(structureInfo => !bitfieldEnums.Any(enumInfo => enumInfo.Name == structureInfo.Name)));
        Enums.AddRange(bitfieldEnums);
    }

    /// <summary>Parses the extensions of a document.</summary>
    /// <param name="extensionElements">The &lt;extension&gt; elements of the extensions to parse.</param>
    private void ParseExtensions(IEnumerable<XElement> extensionElements)
    {
        var supportedPlatforms = new[] { "win32", "macos", "xlib", "xcb", "wayland", "android" };
        var disallowedExtensions = new[] { "VK_KHR_mir_surface" }; // https://github.com/KhronosGroup/Vulkan-Docs/issues/814

        var allExtensions = extensionElements
            .Select(extensionElement => new ExtensionInfo(extensionElement, this));
        Extensions.AddRange(allExtensions
            .Where(extensionInfo => extensionInfo.Supported != "disabled" && !disallowedExtensions.Contains(extensionInfo.Name))
            .Where(extensionInfo => extensionInfo.Platform == null || supportedPlatforms.Contains(extensionInfo.Platform)));
    }
}
