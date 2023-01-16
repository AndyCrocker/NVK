namespace NVK.Generator;

/// <summary>Contains useful helper methods.</summary>
public static class Utilities
{
    /*********
    ** Fields
    *********/
    // TODO: ideally this will be determined automatically
    /// <summary>The Vulkan methods that start with "Get" whose last paramater should be an array.</summary>
    private static readonly string[] GetMethodsRequiringArray = new[] { "GetQueueCheckpointDataNV", "GetQueueCheckpointData2NV", "GetPhysicalDeviceSparseImageFormatProperties2KHR", "GetPhysicalDeviceSparseImageFormatProperties2", "GetPhysicalDeviceSparseImageFormatProperties", "GetPhysicalDeviceQueueFamilyProperties2KHR", "GetPhysicalDeviceQueueFamilyProperties2", "GetPhysicalDeviceQueueFamilyProperties", "GetImageSparseMemoryRequirements2KHR", "GetImageSparseMemoryRequirements2", "GetImageSparseMemoryRequirements", "GetAccelerationStructureBuildSizesKHR", "GetSwapchainImagesKHR", "GetPipelineExecutablePropertiesKHR", "GetPipelineExecutableStatisticsKHR", "GetPipelineExecutableInternalRepresentationsKHR", "GetPhysicalDeviceToolProperties", "GetPhysicalDeviceToolPropertiesEXT", "GetPhysicalDeviceSurfacePresentModesKHR", "GetPhysicalDeviceSurfacePresentModes2EXT", "GetPhysicalDeviceSurfaceFormatsKHR", "GetPhysicalDeviceSurfaceFormats2KHR", "GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", "GetPhysicalDevicePresentRectanglesKHR", "GetPhysicalDeviceFragmentShadingRatesKHR", "GetPhysicalDeviceDisplayPropertiesKHR", "GetPhysicalDeviceDisplayProperties2KHR", "GetPhysicalDeviceDisplayPlanePropertiesKHR", "GetPhysicalDeviceDisplayPlaneProperties2KHR", "GetPhysicalDeviceCooperativeMatrixPropertiesNV", "GetPhysicalDeviceCalibrateableTimeDomainsEXT", "GetPastPresentationTimingGOOGLE", "GetDisplayPlaneSupportedDisplaysKHR", "GetDisplayModePropertiesKHR", "GetDisplayModeProperties2KHR" };


    /*********
    ** Public Methods
    *********/
    /// <summary>Prettifies a constant name.</summary>
    /// <param name="constantName">The constant name to prettify.</param>
    /// <returns>A pretty version of <paramref name="constantName"/>.</returns>
    public static string PrettifyConsantName(string constantName)
    {
        var splitConstantName = constantName.Substring(3).Split('_'); // remove "VK_" prefix
        return string.Concat(splitConstantName.Select(splitName => splitName.ToLower().FirstToUpper()));
    }

    /// <summary>Prettifies a constant value.</summary>
    /// <param name="constantValue">The constant value to prettify.</param>
    /// <returns>A pretty version of <paramref name="constantValue"/>.</returns>
    public static string PrettifyConsantValue(string constantValue) => constantValue.Trim('(', ')').Replace("LL", "L").Replace(".0f", "f").Replace(".0F", "f");

    /// <summary>Prettifies a delegate name.</summary>
    /// <param name="delegateName">The delegate name to prettify.</param>
    /// <returns>A pretty version of <paramref name="delegateName"/>.</returns>
    public static string PrettifyDelegateName(string delegateName)
    {
        if (delegateName.StartsWith("PFN_vk")) // remove "PFN_vk" prefix
            delegateName = delegateName.Substring(6);
        else if (delegateName.StartsWith("vk")) // remove "vk" prefix
            delegateName = delegateName.Substring(2);

        return delegateName.ResolveAbbreviations() + "Delegate";
    }

    /// <summary>Prettifies a field name.</summary>
    /// <param name="fieldName">The field name to prettify.</param>
    /// <param name="pointerIndirection">The pointer indirection of the field.</param>
    /// <returns>A pretty version of <paramref name="fieldName"/>.</returns>
    public static string PrettifyFieldName(string fieldName, int pointerIndirection)
    {
        if (fieldName == "sType")
            return "SType";

        for (int i = 0; i < pointerIndirection; i++) // remove pointer prefix
            if (fieldName.StartsWith('p'))
                fieldName = fieldName.Substring(1);

        fieldName = fieldName.Replace("pfn", ""); // remove function pointer prefix

        // a single awkward case where two fields are only differentiated by the level of pointer indirection (and therefore the prefixed "p"'s that we've just removed), just suffix the second one with a '2'
        if (fieldName == "Geometries" && pointerIndirection == 2)
            fieldName += "2";

        return fieldName.ResolveAbbreviations().FirstToUpper();
    }

    /// <summary>Prettifies a command name.</summary>
    /// <param name="commandName">The command name to prettify.</param>
    /// <returns>A pretty version of <paramref name="commandName"/>.</returns>
    public static string PrettifyCommandName(string commandName)
    {
        if (commandName.StartsWith("vk")) // remove "vk" prefix
            commandName = commandName.Substring(2);

        return commandName.ResolveAbbreviations();
    }

    /// <summary>Prettifies a parameter name.</summary>
    /// <param name="parameterName">The parameter name to prettify.</param>
    /// <param name="pointerIndirection">The pointer indirection of the parameter.</param>
    /// <returns>A pretty version of <paramref name="parameterName"/>.</returns>
    public static string PrettifyParameterName(string parameterName, int pointerIndirection)
    {
        for (int i = 0; i < pointerIndirection; i++) // remove pointer prefix
            if (parameterName.StartsWith('p'))
                parameterName = parameterName.Substring(1);

        return parameterName.ResolveAbbreviations().FirstToLower().EnsureIsntReserved();
    }

    /// <summary>Prettifies a structure name.</summary>
    /// <param name="structureName">The structure name to prettify.</param>
    /// <returns>A pretty version of <paramref name="structureName"/>.</returns>
    public static string PrettifyStructureName(string structureName)
    {
        return structureName;
    }

    /// <summary>Prettifies an enum name.</summary>
    /// <param name="enumName">The enum name to prettify.</param>
    /// <returns>A pretty version of <paramref name="enumName"/>.</returns>
    public static string PrettifyEnumName(string enumName)
    {
        return enumName;
    }

    /// <summary>Prettifies a enum field name.</summary>
    /// <param name="enumName">The name of the enum that adds the field.</param>
    /// <param name="enumFieldName">The enum field name to prettify.</param>
    /// <returns>A pretty version of <paramref name="enumFieldName"/>.</returns>
    public static string PrettifyEnumFieldName(string enumName, string enumFieldName)
    {
        enumName = enumName.Replace("FlagBits", "").RemoveSuffixesExtensionVendorTag();

        // remove the enum name from the field name
        var splitEnumName = enumName.SplitOnUpper().ToList();
        var splitEnumFieldName = enumFieldName.Split('_').ToList();

        for (int i = 0; i < splitEnumName.Count; i++)
            if (splitEnumName[i].ToLower() == splitEnumFieldName[i].ToLower())
            {
                splitEnumName.RemoveAt(i);
                splitEnumFieldName.RemoveAt(i--);
            }

        // bitfield enums have an unwanted 'Bit' in their field names
        splitEnumFieldName.Remove("BIT");

        // handle special enum cases
        if (enumName == "VkSampleCountFlags")
            splitEnumFieldName.Insert(0, "Count");

        // reconstruct the name and ensure it doesn't start with a digit (as that's not a valid C# identifier)
        var newEnumFieldName = string.Join("", splitEnumFieldName.Select(splitName => CapitaliseEnumFieldNameSection(enumName, splitName)));
        if (char.IsDigit(newEnumFieldName[0]))
            newEnumFieldName = $"_{newEnumFieldName}";

        return newEnumFieldName.ResolveAbbreviations();
    }

    /// <summary>Generates all overloads for a command.</summary>
    /// <param name="commandInfo">The command to generate the overloads of.</param>
    /// <returns>All the overloads that <paramref name="commandInfo"/> can have, including <paramref name="commandInfo"/> itself.</returns>
    /// <remarks>This only creates overloads with adjusted parameter modifiers, not any convenience overloads such as not needing to specify array lengths.<br/>Note: <paramref name="commandInfo"/> will be included in the returned list.</remarks>
    public static List<CommandInfo> GenerateAllOverloads(CommandInfo commandInfo)
    {
        var overloads = new List<CommandInfo> { commandInfo };

        // get all the version each parameter can be
        List<List<CommandParameterInfo>> parameterVariations = new();
        for (int i = 0; i < commandInfo.Parameters.Count; i++)
            parameterVariations.Add(GetParameterVariations(commandInfo, commandInfo.Parameters[i]));

        // get all parameter variations
        var parameterCombinations = GetParameterCombinations(parameterVariations);
        var temp = parameterCombinations.Select(parameterCombination => new CommandInfo(commandInfo.Name, commandInfo.ReturnType!, parameterCombination, commandInfo.Alias) { Extension = commandInfo.Extension }).ToList();
        return temp;
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Capitalises a section of an enum field name.</summary>
    /// <param name="enumName">The name of the enum that enum field belongs to.</param>
    /// <param name="enumFieldNameSection">The enum field name section to capitalise.</param>
    /// <returns>The correctly capitalised <paramref name="enumFieldNameSection"/>.</returns>
    private static string CapitaliseEnumFieldNameSection(string enumName, string enumFieldNameSection)
    {
        enumFieldNameSection = enumFieldNameSection.ToLower();

        // only the VkFormat enum fields have special capitalisation rules, unless it's the 'undefined' field
        if (enumName != "VkFormat" || enumFieldNameSection == "undefined")
            return enumFieldNameSection.FirstToUpper();

        // check if section is a compression format
        var compressionFormats = new[] { "bc", "etc", "eac", "astc", "pvrtc" };
        if (compressionFormats.Any(compressionFormat => enumFieldNameSection.StartsWith(compressionFormat)))
            return enumFieldNameSection.ToUpper();

        // check if section is specifying bits per pixel
        if (enumFieldNameSection.EndsWith("bpp"))
            return enumFieldNameSection.ToUpper();

        // check if the section is the format channel definitions (such as R8G8B8A8)
        var channelCharacters = new[] { 'r', 'g', 'b', 'a', 'e' };
        if (channelCharacters.Contains(enumFieldNameSection[0]) && char.IsDigit(enumFieldNameSection[1]))
            return enumFieldNameSection.ToUpper();

        // check if the section is a numbered pack section (such as 4PACK16)
        if (char.IsDigit(enumFieldNameSection[0]) && enumFieldNameSection[1] == 'p')
        {
            // capitalise the 'p', not the number
            var charArray = enumFieldNameSection.ToCharArray();
            charArray[1] = char.ToUpper(charArray[1]);
            return new string(charArray);
        }

        // check if the section has a special static capitalisation
        var specialCapitalisationCases = new Dictionary<string, string>()
        {
            { "srgb", "SRGB" },
            { "uint", "UInt" },
            { "sint", "SInt" },
            { "unorm", "UNorm" },
            { "snorm", "SNorm" },
            { "ufloat", "UFloat" },
            { "sfloat", "SFloat" },
            { "uscaled", "UScaled" },
            { "sscaled", "SScaled" },
            { "rgb", "RGB" },
            { "rgba", "RGBA" }
        };
        if (specialCapitalisationCases.ContainsKey(enumFieldNameSection))
            return specialCapitalisationCases[enumFieldNameSection];

        // just capatialise it normally
        return enumFieldNameSection.FirstToUpper();
    }

    /// <summary>Generates all variaties of a parameter.</summary>
    /// <param name="commandInfo">The command the parameter belongs to</param>
    /// <param name="parameterInfo">The parameter to generate the variations of.</param>
    /// <returns>The variations that <paramref name="parameterInfo"/> can have, including <paramref name="parameterInfo"/> itself.</returns>
    private static List<CommandParameterInfo> GetParameterVariations(CommandInfo commandInfo, CommandParameterInfo parameterInfo)
    {
        var parameterVariations = new List<CommandParameterInfo>() { parameterInfo };

        // ensure parameter can have multiple variations
        if (parameterInfo.Type.PointerIndirection == 0 || parameterInfo.Type.Name == "void")
            return parameterVariations;

        // check if parameter is a byte pointer (meaning it's actually a string)
        if (parameterInfo.Type.Name == "byte")
        {
            if (parameterInfo.Type.PointerIndirection == 1) // convert byte* to string
                parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo("string"), ParameterModifier.None));
            else if (parameterInfo.Type.PointerIndirection == 2) // convert byte** to string[]
                parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo("string", arrayDimensions: 1), ParameterModifier.None));
        }

        // check if parameter should be an 'out' version
        else if (
            (commandInfo.DisplayName.StartsWith("Allocate")                                                                     // allocate methods
                || commandInfo.DisplayName.StartsWith("Create")                                                                 // create methods
                || (commandInfo.DisplayName.StartsWith("Get") && !GetMethodsRequiringArray.Contains(commandInfo.DisplayName))   // certain get methods
                || commandInfo.DisplayName.StartsWith("AcquireNextImage"))                                                      // and 'AcquireNextImage(2)KHR' should all have outs
            && commandInfo.Parameters.Last() == parameterInfo)                                                                  // on the last parameter
            parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Out) };

        // otherwise create a 'ref' version
        else
            parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Ref));

        // check if the parameter should be an array
        if (parameterInfo.Name.EndsWith("Infos"))
            parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, arrayDimensions: 1), ParameterModifier.None) };
        else if (
            (commandInfo.DisplayName.StartsWith("Enumerate")                                                                    // enumerate methods
                || (commandInfo.DisplayName.StartsWith("Get") && GetMethodsRequiringArray.Contains(commandInfo.DisplayName))    // certain get methods
                || (commandInfo.DisplayName.StartsWith("Allocate") && (commandInfo.DisplayName.EndsWith("s"))))                 // and certain allocate methods should all have a marshalled array
            && commandInfo.Parameters.Last() == parameterInfo)                                                                  // on the last parameter
            parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, arrayDimensions: 1), ParameterModifier.InOut) };
        else if (parameterInfo.Name.EndsWith("s"))
        {
            // this will check parameter pairs for converting pointers to arrays, an example of a pair we are are looking for is: 'uint submitCount, VkSubmitInfo* submits', in this case 'submits' should be an array
            var parameterIndex = commandInfo.Parameters.IndexOf(parameterInfo);
            if (parameterIndex >= 1)
            {
                // correct plural name differences to work with the check
                var fixedParameterName = parameterInfo.DisplayName.Replace("Copies", "Copys");
                var previousParameterName = commandInfo.Parameters[parameterIndex - 1].DisplayName;
                if (previousParameterName == fixedParameterName[..^1] + "Count")
                    parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, arrayDimensions: 1), ParameterModifier.None) };
            }
        }

        return parameterVariations;
    }

    /// <summary>Generates all combinations of parameter variations.</summary>
    /// <param name="parameterVariations">The variations of each paramter of a command.</param>
    /// <returns>The combinations of parameter variations.</returns>
    private static List<List<CommandParameterInfo>> GetParameterCombinations(List<List<CommandParameterInfo>> parameterVariations)
    {
        var parameterCombinations = new List<List<CommandParameterInfo>>();
        var firstParameter = parameterVariations.First();
        var otherParameters = parameterVariations.Skip(1).ToList();

        // loop through each variations and recursively prepend that to the each combination of the other parameters
        foreach (var variation in firstParameter)
            if (otherParameters.Count == 0) // we're at the end of the paramter list, just add the variation
                parameterCombinations.Add(new() { variation });
            else // recursively get the combination of other parameters
            {
                var otherParameterVariations = GetParameterCombinations(otherParameters);
                foreach (var otherParameterVariation in otherParameterVariations)
                {
                    var combination = new List<CommandParameterInfo>() { variation };
                    combination.AddRange(otherParameterVariation);
                    parameterCombinations.Add(combination);
                }
            }

        return parameterCombinations;
    }
}
