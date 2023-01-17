namespace NVK.Generator.Specification;

/// <summary>Represents the Vulkan specification.</summary>
internal class VulkanSpecification
{
    /*********
    ** Constants
    *********/
    /// <summary>The url of the registry to parse.</summary>
    private const string RegistryUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml";


    /*********
    ** Accessors
    *********/
    /// <summary>The type converter used in the specification.</summary>
    public TypeConverter TypeConverter { get; }

    /// <summary>The constants in the specification.</summary>
    public List<ConstantInfo> Constants { get; }

    /// <summary>The enums in the specification.</summary>
    public List<EnumInfo> Enums { get; }

    /// <summary>The commands in the specification.</summary>
    public List<CommandInfo> Commands { get; }

    /// <summary>The delegates in the specification.</summary>
    public List<DelegateInfo> Delegates { get; }

    /// <summary>The handles in the specification.</summary>
    public List<HandleInfo> Handles { get; }

    /// <summary>The structures in the specification.</summary>
    public List<StructureInfo> Structures { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="typeConverter">The type converter used in the specification.</param>
    /// <param name="constants">The constants in the specification.</param>
    /// <param name="enums">The enums in the specification.</param>
    /// <param name="commands">The commands in the specification.</param>
    /// <param name="delegates">The delegates in the specification.</param>
    /// <param name="handles">The handles in the specification.</param>
    /// <param name="structures">The structures in the specification.</param>
    private VulkanSpecification(TypeConverter typeConverter, List<ConstantInfo> constants, List<EnumInfo> enums, List<CommandInfo> commands, List<DelegateInfo> delegates, List<HandleInfo> handles, List<StructureInfo> structures)
    {
        TypeConverter = typeConverter;
        Constants = constants;
        Enums = enums;
        Commands = commands;
        Delegates = delegates;
        Handles = handles;
        Structures = structures;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    public static VulkanSpecification Generate()
    {
        var specificationDocument = XDocument.Load(RegistryUrl);
        var registry = specificationDocument.Element("registry");
        var types = registry!.Elements("types");

        // typedefs
        var typedefs = types.Elements("type")
            .Where(element => element.Value.StartsWith("typedef") && (element.HasAttributeWithValue("category", "bitmask") || element.HasAttributeWithValue("category", "basetype")))
            .Where(element => !element.Value.StartsWith("typedef struct")) // an annoying edge case that's so rare it's easier to just handle manually through the TypeConverter
            .Select(typedefElement => new TypedefInfo(typedefElement))
            .ToList();

        // enum aliases
        var enumAliases = types.Elements("type")
            .Where(element => element.Attribute("alias") != null && (element.HasAttributeWithValue("category", "enum") || element.HasAttributeWithValue("category", "bitmask")))
            .ToDictionary(element => element.Attribute("name")!.Value, element => element.Attribute("alias")!.Value);

        var typeConverter = new TypeConverter(typedefs, enumAliases);

        // extensions
        var supportedPlatforms = new[] { "win32", "macos", "xlib", "android" };
        var allExtensions = registry.Element("extensions")!.Elements("extension")
            .Select(extensionElement => new ExtensionInfo(extensionElement, typeConverter))
            .Where(extensionInfo => extensionInfo.Supported != "disabled")
            .ToList();
        var supportedExtensions = allExtensions
            .Where(extensionInfo => extensionInfo.Platform == null || supportedPlatforms.Contains(extensionInfo.Platform))
            .ToList();

        // constants
        var constants = registry.Elements("enums").Single(element => element.Attribute("name")!.Value == "API Constants").Elements("enum")
            .Select(constantElement => new ConstantInfo(constantElement))
            // ensure the constant isn't added by an unsupported extension
            .Where(constantInfo => !allExtensions.Any(extensionInfo => extensionInfo.Constants.Select(extensionConstantInfo => extensionConstantInfo.Name).Contains(constantInfo.Name))
                || supportedExtensions.Any(extensionInfo => extensionInfo.Constants.Select(extensionConstantInfo => extensionConstantInfo.Name).Contains(constantInfo.Name)))
            .ToList();

        // enums
        var enums = registry.Elements("enums").Where(element => element.Attribute("name")!.Value != "API Constants")
            .Select(enumsElement => new EnumInfo(enumsElement, typeConverter))
            // ensure the enum isn't added by an unsupported extension
            .Where(enumInfo => !allExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(enumInfo.Name) // ensure the enum isn't added by an unsupported extension
                || supportedExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(enumInfo.Name))
            .ToList();

        // methods
        var commands = registry.Element("commands")!.Elements("command")
            .Select(commandElement => new CommandInfo(commandElement, typeConverter))
            // ensure the function isn't added by an unsupported extension
            .Where(commandInfo => !allExtensions.SelectMany(extensionInfo => extensionInfo.CommandNames).Contains(commandInfo.Name)
                || supportedExtensions.SelectMany(extensionInfo => extensionInfo.CommandNames).Contains(commandInfo.Name))
            .ToList();
        foreach (var commandInfo in commands) // set the parameters of aliased commands, this is used for overload creation
            if (commandInfo.Alias != null)
                commandInfo.Parameters.AddRange(commands.Single(cInfo => cInfo.Name == commandInfo.Alias).Parameters);

        // delegates
        var delegates = types.Elements("type").Where(element => element.HasAttributeWithValue("category", "funcpointer"))
            .Select(delegateElement => new DelegateInfo(delegateElement, typeConverter))
            .ToList();

        // handles
        var handles = types.Elements("type").Where(element => element.HasAttributeWithValue("category", "handle"))
            .Select(handleElement => new HandleInfo(handleElement))
            // ensure the handle isn't added by an unsupported extension
            .Where(handleInfo => !allExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(handleInfo.Name)
                || supportedExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(handleInfo.Name))
            .ToList();

        // structures
        var structures = types.Elements("type").Where(element => element.HasAttributeWithValue("category", "struct") || element.HasAttributeWithValue("category", "union"))
            .Select(structureElement => new StructureInfo(structureElement, typeConverter))
            // ensure the structure isn't added by an unsupported extension
            .Where(structureInfo => !allExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(structureInfo.Name)
                || supportedExtensions.SelectMany(extensionInfo => extensionInfo.TypeNames).Contains(structureInfo.Name))
            .ToList();

        // add enums fields that are added in >1.0 Vulkan
        var featureElements = registry.Elements("feature").Where(featureElement => featureElement.Attribute("number")?.Value != "1.0"); // skip v1.0 as that doesn't add extensions
        foreach (var enumElement in featureElements.SelectMany(featureElement => featureElement.Elements("require")).SelectMany(requireElement => requireElement.Elements("enum")))
        {
            var extensionNumberString = enumElement.Attribute("extnumber")?.Value;
            int? extensionNumber = null;
            if (extensionNumberString != null)
                extensionNumber = int.Parse(extensionNumberString);

            // ensure enum element isn't a constant (these can be ignored as they're already defined, in the spec it's just mentioning what version they got added which we don't care about)
            if (enumElement.Attribute("extends") == null)
                continue;

            var coreEnumExtension = new ExtensionEnumFieldInfo(extensionNumber, enumElement, typeConverter);
            var enumBeingExtended = enums.Single(enumInfo => enumInfo.Name == coreEnumExtension.ExtendedType);
            enumBeingExtended.Values.Add(new EnumFieldInfo(enumBeingExtended.Name, coreEnumExtension.Name, coreEnumExtension.Value, coreEnumExtension.BitPosition, coreEnumExtension.Alias));
        }

        // fix extension constants, in some cases extension constants are defined in the main header constants (if multiple extensions add that constant), this means neither a value nor alias
        // is defined on the constant were the extension defines the constant, we'll just remove these constants from the extensions
        foreach (var extensionInfo in supportedExtensions)
            for (int i = 0; i < extensionInfo.Constants.Count; i++)
            {
                var constantInfo = extensionInfo.Constants[i];
                if (constantInfo.Alias == null && constantInfo.Value == null)
                {
                    var definedConstant = constants.Single(cInfo => cInfo.Name == constantInfo.Name);
                    definedConstant.Extensions.Add(extensionInfo.Name);
                    extensionInfo.Constants.RemoveAt(i--);
                }
            }

        // add everything added by extensions
        foreach (var extension in supportedExtensions)
        {
            // add constants and keep note that they were added by this extension (for documentation reasons)
            foreach (var constant in extension.Constants)
            {
                constant.Extensions.Add(extension.Name);
                constants.Add(constant);
            }

            // add enum fields and keep note that they were added by this extension (for documentation reasons)
            foreach (var enumValue in extension.EnumExtensions)
            {
                var enumBeingExtended = enums.Single(enumInfo => enumInfo.Name == enumValue.ExtendedType);
                enumBeingExtended.Values.Add(new EnumFieldInfo(enumBeingExtended.Name, enumValue.Name, enumValue.Value, enumValue.BitPosition, enumValue.Alias) { Extension = extension.Name });
            }

            // keep note of which handles, enums, and structures this extension added (for documentation reasons)
            foreach (var typeName in extension.TypeNames)
            {
                var handleInfo = handles.FirstOrDefault(handleInfo => handleInfo.Name == typeName);
                var enumInfo = enums.FirstOrDefault(enumInfo => enumInfo.Name == typeName);
                var structureInfo = structures.FirstOrDefault(structureInfo => structureInfo.Name == typeName);

                if (handleInfo != null)
                    handleInfo.Extension = extension.Name;
                else if (enumInfo != null)
                    enumInfo.Extension = extension.Name;
                else if (structureInfo != null)
                    structureInfo.Extension = extension.Name;
            }

            // keep note of which functions this extension added (for documentation reasons)
            foreach (var commandName in extension.CommandNames)
            {
                var command = commands.Single(commandInfo => commandInfo.Name == commandName);
                command.Extension = extension.Name;
            }
        }

        // remove edge case constants
        // some constants have aliases that get converted to the same name for the display name, which leads to two constants with
        // the same name being generated in VK.gen.cs
        for (int i = 0; i < constants.Count; i++)
        {
            var constant = constants[i];
            if (constant.Alias == null)
                continue;

            if (Utilities.PrettifyConsantName(constant.Name) == Utilities.PrettifyConsantName(constant.Alias))
                constants.RemoveAt(i--);
        }

        return new(typeConverter, constants, enums, commands, delegates, handles, structures);
    }
}
