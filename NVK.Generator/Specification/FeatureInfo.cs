namespace NVK.Generator.Specification;

/// <summary>Represents a parsed feature.</summary>
internal class FeatureInfo
{
    /*********
    ** Fields
    *********/
    /// <summary>The specification to use when creating the feature.</summary>
    private VulkanSpecification Specification;


    /*********
    ** Properties
    *********/
    /// <summary>The constants in the feature.</summary>
    public List<ConstantInfo> Constants { get; } = new();

    /// <summary>The enums in the feature.</summary>
    public List<EnumInfo> Enums { get; } = new();

    /// <summary>The handles in the feature.</summary>
    public List<HandleInfo> Handles { get; } = new();

    /// <summary>The structures in the feature.</summary>
    public List<StructureInfo> Structures { get; } = new();

    /// <summary>The delegate in the feature.</summary>
    public List<DelegateInfo> Delegates { get; } = new();

    /// <summary>The functions in the feature.</summary>
    public List<FunctionInfo> Functions { get; } = new();


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="featureElements">The &lt;feature&gt; elements to parse the feature from.</param>
    /// <param name="supportedExtensions">The extensions that should be added to the feature.</param>
    /// <param name="specification">The specification to use when creating the feature.</param>
    public FeatureInfo(IEnumerable<XElement> featureElements, List<ExtensionInfo> supportedExtensions, VulkanSpecification specification)
    {
        Specification = specification;

        var requireInfos = featureElements.Elements("require")
            .Select(requireElement => new RequireInfo(requireElement));

        foreach (var requireInfo in requireInfos)
            AddRequire(requireInfo);

        foreach (var extension in supportedExtensions)
            foreach (var requireInfo in extension.RequireInfos)
                AddRequire(requireInfo);
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Adds the members of a &lt;require&gt; tag to the feature.</summary>
    /// <param name="requireInfo">The &lt;require&gt; tag to add to the feature.</param>
    private void AddRequire(RequireInfo requireInfo)
    {
        foreach (var constantName in requireInfo.ConstantNames)
            AddConstantByName(constantName);
        foreach (var constant in requireInfo.Constants)
            AddConstant(constant);

        foreach (var functionName in requireInfo.FunctionNames)
            AddFunctionByName(functionName);

        foreach (var typeName in requireInfo.TypeNames)
            AddTypeByName(typeName);

        foreach (var enumField in requireInfo.EnumFields)
        {
            var enumInfo = Specification.Enums.Single(enumInfo => enumInfo.Name == enumField.EnumName);
            var enumFieldInfo = new EnumFieldInfo(enumInfo, enumField.EnumFieldElement, enumField.ExtensionNumber);

            // enum fields can be added multiple times if they are specified in different extensions, so just make sure to only add it once
            if (enumInfo.Fields.Any(fieldInfo => fieldInfo.Name == enumFieldInfo.Name))
                continue;

            enumInfo.Fields.Add(enumFieldInfo);
        }
    }

    /// <summary>Adds a constant from the specification to the feature with a specified name.</summary>
    /// <param name="name">The name of the constant to add to the feature from the specification.</param>
    private void AddConstantByName(string name)
    {
        var constantInfo = Specification.Constants.Single(enumInfo => enumInfo.Name == name);
        AddConstant(constantInfo);
    }

    /// <summary>Adds a constant to the feature.</summary>
    /// <param name="constantInfo">The constant to add to the feature.</param>
    private void AddConstant(ConstantInfo constantInfo)
    {
        if (Constants.Any(cInfo => cInfo.Name == constantInfo.Name))
            return;

        // some constants are aliased to fix incorrect formatting of underscores, these result in identical display names so we'll just ignore these constants
        if (constantInfo.Alias != null)
            if (ConstantInfo.CalculateDisplayName(constantInfo.Name) == ConstantInfo.CalculateDisplayName(constantInfo.Alias))
                return;

        Constants.Add(constantInfo);
    }

    /// <summary>Adds a type from the specification to the feature with a specified name.</summary>
    /// <param name="name">The name of the type to add to the feature from the specification.</param>
    /// <exception cref="ArgumentException">Thrown if no type named <paramref name="name"/> could be found in the specification.</exception>
    private void AddTypeByName(string name)
    {
        var enumInfo = Specification.Enums.SingleOrDefault(enumInfo => enumInfo.Name == name);
        if (enumInfo != null)
        {
            if (!Enums.Any(enumInfo => enumInfo.Name == name)) // types may potentially get duplicated as some specs list required types explicitly while others don't
                Enums.Add(enumInfo);
            return;
        }

        var handleInfo = Specification.Handles.SingleOrDefault(handleInfo => handleInfo.Name == name);
        if (handleInfo != null)
        {
            if (!Handles.Any(handleInfo => handleInfo.Name == name)) // types may potentially get duplicated as some specs list required types explicitly while others don't
                Handles.Add(handleInfo);
            return;
        }

        var structureInfo = Specification.Structures.SingleOrDefault(structureInfo => structureInfo.Name == name);
        if (structureInfo != null)
        {
            if (!Structures.Any(structureInfo => structureInfo.Name == name)) // types may potentially get duplicated as some specs list required types explicitly while others don't
                Structures.Add(structureInfo);

            foreach (var fieldInfo in structureInfo.Fields)
            {
                if (fieldInfo.Type.Name != name) // some structs, notable VkBaseInStructure & VkBaseOutStructure have fields with their own type
                    AddTypeByName(fieldInfo.Type.Name);

                // if the field is an array whose length is determined by a constant, that constant may not be added to the feature explicitly
                var constantInfo = Specification.Constants.SingleOrDefault(constantInfo => constantInfo.Name == fieldInfo.ArrayLength);
                if (constantInfo != null)
                    AddConstantByName(constantInfo.Name);
            }

            return;
        }

        var delegateInfo = Specification.Delegates.SingleOrDefault(delegateInfo => delegateInfo.Name == name);
        if (delegateInfo != null)
        {
            if (!Delegates.Any(delegateInfo => delegateInfo.Name == name)) // types may potentially get duplicated as some specs list required types explicitly while others don't
                Delegates.Add(delegateInfo);
            return;
        }

        // defines are also references in <feature> tags, we don't need them so they're ignored
        if (Specification.Defines.Contains(name))
            return;

        // TODO: unhardcode
        if (new[] { "VkBool32", "VkDeviceAddress", "VkDeviceSize", "VkFlags", "VkFlags64", "VkSampleMask", "void", "int32_t", "int64_t", "uint8_t", "uint32_t",
            "uint64_t", "char", "size_t", "float", "Display", "Window", "VisualID", "xcb_connection_t", "xcb_window_t", "xcb_visualid_t", "wl_display", "wl_surface",
            "MirConnection", "MirSurface", "ANativeWindow", "HINSTANCE", "HWND", "HANDLE", "DWORD", "LPCWSTR", "SECURITY_ATTRIBUTES", "int", "RROutput", "double",
            "HMONITOR", "uint16_t", "AHardwareBuffer", "VkRemoteAddressNV",

            "StdVideoH264ProfileIdc", "StdVideoH264LevelIdc", "StdVideoH264SequenceParameterSet",
            "StdVideoH264PictureParameterSet", "StdVideoH264PictureParameterSet", "StdVideoDecodeH264PictureInfo",
            "StdVideoDecodeH264ReferenceInfo", "StdVideoH265ProfileIdc", "StdVideoH265LevelIdc",
            "StdVideoH265VideoParameterSet", "StdVideoH265SequenceParameterSet", "StdVideoH265PictureParameterSet",
            "StdVideoH265VideoParameterSet", "StdVideoH265SequenceParameterSet", "StdVideoH265PictureParameterSet",
            "StdVideoDecodeH265PictureInfo", "StdVideoDecodeH265ReferenceInfo" }.Contains(name))
            return;

        throw new ArgumentException($"Could find type with name '{name}'");
    }

    /// <summary>Adds a function from the specification to the feature with a specified name.</summary>
    /// <param name="name">The name of the function to add to the feature from the specification.</param>
    private void AddFunctionByName(string name)
    {
        // most types (especially in V1.0) expect generators to implicitly load types that are used in a function return or parameters instead of the registry explicitly listing them
        var functionInfo = Specification.Functions.Single(functionInfo => functionInfo.Name == name);

        AddTypeByName(functionInfo.ReturnType.Name);
        foreach (var parameterInfo in functionInfo.Parameters)
            AddTypeByName(parameterInfo.Type.Name);

        Functions.Add(functionInfo);
    }
}
