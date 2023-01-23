namespace NVK.Generator.Specification;

/// <summary>Represents a parsed function.</summary>
internal class FunctionInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the function.</summary>
    public string Name { get; }

    /// <summary>The name of the function that this function is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>The command queues the function can be placed on.</summary>
    public string[] Queues { get; } = Array.Empty<string>();

    /// <summary>The possible successful return codes from the function.</summary>
    public string[] SuccessCodes { get; } = Array.Empty<string>();

    /// <summary>The possible error return codes from the function.</summary>
    public string[] ErrorCodes { get; } = Array.Empty<string>();

    /// <summary>The return type of the function.</summary>
    public TypeInfo ReturnType { get; }

    /// <summary>The parameters of the function.</summary>
    public List<FunctionParameterInfo> Parameters { get; } = new();

    /// <summary>The display string for <see cref="Name"/>.</summary>
    private string DisplayName => CalculateDisplayName(Name)!;

    /// <summary>The display string for <see cref="Alias"/>.</summary>
    private string? AliasDisplayName => CalculateDisplayName(Alias);

    /// <summary>The display name of each delegate for the function.</summary>
    /// <remarks>Delegate in this case refers to the internal delegate for P/Invoke, not Vulkan delegates.</remarks>
    private string DelegateDisplayName => $"{DisplayName}Delegate";

    /// <summary>The display name of the function pointer for the function.</summary>
    /// <remarks>Function pointer in this case refers to the internal function pointer for P/Invoke, not Vulkan delegates.</remarks>
    private string PointerDisplayName => $"{DisplayName}Pointer";


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;command&gt; element to parse the function from.</param>
    public FunctionInfo(XElement element)
    {
        // if the function is an alias, the name is stored as an attribute instead of a child element
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
        {
            Name = element.Attribute("name")!.Value;
            ReturnType = new("void");
            return;
        }

        Queues = element.Attribute("queues")?.Value.Split(',') ?? Array.Empty<string>();
        SuccessCodes = element.Attribute("successcodes")?.Value.Split(',') ?? Array.Empty<string>();
        ErrorCodes = element.Attribute("errorcodes")?.Value.Split(',') ?? Array.Empty<string>();

        // an example layout of a function is:
        // `<proto><type>[returnTypeName]</type> <name>[name]</name></proto>
        // <param>const <type>[parameterTypeName]</type>* <name>[parameterName]</name></param>
        // [..]`
        var protoElement = element.Element("proto")!;

        Name = protoElement.Element("name")!.Value;
        ReturnType = new(protoElement.Element("type")!.Value);
        Parameters = element.Elements("param")
            .Select(parameterElement => new FunctionParameterInfo(parameterElement)).ToList();
    }

    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the function.</param>
    /// <param name="returnType">The return type of the function.</param>
    /// <param name="parameters">The parameters of the function.</param>
    /// <param name="alias">The name of the function that this function is an alias of.</param>
    public FunctionInfo(string name, TypeInfo returnType, List<FunctionParameterInfo> parameters, string? alias)
    {
        Name = name;
        ReturnType = returnType;
        Parameters = parameters;
        Alias = alias;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the function to a C# writer.</summary>
    /// <param name="writer">The writer to write the function to.</param>
    public void Write(CsWriter writer)
    {
        var overloads = GenerateAllOverloads();
        for (int i = 0; i < overloads.Count; i++)
        {
            var overload = overloads[i];

            var parametersString = string.Join(", ", overload.Parameters.Select(parameterInfo => $"{parameterInfo.Modifier.GetAttribute<ParameterModifierAttribute>()?.Value}{parameterInfo.Type} {parameterInfo.Name}"));
            var calledParametersString = string.Join(", ", overload.Parameters.Select(parameterInfo =>
                {
                    var modifierAttribute = parameterInfo.Modifier.GetAttribute<ParameterModifierAttribute>();
                    return $"{(modifierAttribute?.IsRequiredForCalling ?? false ? modifierAttribute.Value : "")}{parameterInfo.Name}";
                }));

            if (Alias != null)
                writer.WriteLine($"[Obsolete(\"Use {AliasDisplayName}\")]");

            writer.WriteLine($"public static {ReturnType} {DisplayName}({parametersString}) => {DisplayName}_{i}({calledParametersString});");
            writer.WriteLine($"private delegate {ReturnType} {DelegateDisplayName}_{i}({parametersString});");
            writer.WriteLine($"private static {DelegateDisplayName}_{i} {DisplayName}_{i};");
        }

        writer.WriteLine($"private static IntPtr {PointerDisplayName};");
    }

    /// <summary>Writes the function pointer and delegates being assigned as a required function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteRequiredFunction(CsWriter writer)
    {
        writer.WriteLine($"{PointerDisplayName} = VulkanLibrary.GetFunctionPointer(\"{DisplayName}\");");

        var overloads = GenerateAllOverloads();
        for (int i = 0; i < overloads.Count; i++)
            writer.WriteLine($"{DisplayName}_{i} = Marshal.GetDelegateForFunctionPointer<{DelegateDisplayName}_{i}>({PointerDisplayName});");
    }

    /// <summary>Writes the function pointer and delegates being assigned as an instance function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteInstanceFunction(CsWriter writer)
    {
        writer.WriteLine($"{PointerDisplayName} = GetInstanceProcedureAddress(instance, \"{AliasDisplayName ?? DisplayName}\");");
        writer.WriteLine($"if ({PointerDisplayName} != IntPtr.Zero)");
        writer.WriteScope(() =>
        {
            var overloads = GenerateAllOverloads();
            for (int i = 0; i < overloads.Count; i++)
                writer.WriteLine($"{DisplayName}_{i} = Marshal.GetDelegateForFunctionPointer<{DelegateDisplayName}_{i}>({PointerDisplayName});");
        });
    }

    /// <summary>Calculates the display name of a function name.</summary>
    /// <param name="name">The name to calculate the display name of.</param>
    /// <returns>The display name for a function called <paramref name="name"/>.</returns>
    public static string? CalculateDisplayName(string? name)
    {
        if (name == null)
            return null;

        if (name.StartsWith("vk"))
            name = name[2..];

        return name.ResolveAbbreviations();
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Generates all overloads for the function.</summary>
    /// <returns>All the overloads that the function can have.</returns>
    private List<FunctionInfo> GenerateAllOverloads()
    {
        // TODO: TEMP
        if (Parameters.Count == 0)
            return new() { this };

        // get all the version each parameter can be
        var parameterVariations = new List<List<FunctionParameterInfo>>();
        for (int i = 0; i < Parameters.Count; i++)
            parameterVariations.Add(GetParameterVariations(Parameters[i]));

        // get all parameter variations
        var parameterCombinations = GetParameterCombinations(parameterVariations);
        return parameterCombinations.Select(parameterCombination => new FunctionInfo(Name, ReturnType, parameterCombination, Alias)).ToList();
    }

    /// <summary>Generates all varieties of a parameter.</summary>
    /// <param name="parameterInfo">The parameter to generate the variations of.</param>
    /// <returns>The variations that <paramref name="parameterInfo"/> can have, including <paramref name="parameterInfo"/> itself.</returns>
    private List<FunctionParameterInfo> GetParameterVariations(FunctionParameterInfo parameterInfo)
    {
        // ensure parameter can have multiple variations
        if (parameterInfo.Type.PointerIndirection == 0 || parameterInfo.Type.Name == "void")
            return new() { parameterInfo };

        // check if the parameter should have a single variant with an array
        if (parameterInfo.Name.EndsWith("Infos"))
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, isArray: true), ParameterModifier.None) };

        var parameterIndex = Parameters.IndexOf(parameterInfo);
        var previousParameter = parameterIndex >= 1 ? Parameters[parameterIndex - 1] : null;
        if ((DisplayName.StartsWith("Enumerate")                                                            // enumerate methods
                || (DisplayName.StartsWith("Allocate") && DisplayName.EndsWith("s"))                        // certain allocate methods
                || (DisplayName.StartsWith("Get") && (previousParameter?.Name.EndsWith("Count") ?? false))) // and certain get methods should all have a marshalled array
            && Parameters.Last() == parameterInfo)                                                          // on the last parameter
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, isArray: true), ParameterModifier.InOut) };

        // check if parameter is a byte pointer (meaning it's actually a string)
        if (parameterInfo.Type.Name == "byte")
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo("string", isArray: parameterInfo.Type.PointerIndirection == 2), ParameterModifier.None) };

        // check if parameter should have a single 'out' version
        if ((DisplayName.StartsWith("Allocate")                // allocate methods
                || DisplayName.StartsWith("Create")            // create methods
                || DisplayName.StartsWith("Get")               // get methods
                || DisplayName.StartsWith("AcquireNextImage")) // and 'AcquireNextImage(2)KHR' should all have outs
            && Parameters.Last() == parameterInfo)             // on the last parameter
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Out) };

        // check parameter pairs for converting pointers to arrays, an example of a pair we are are looking for is: 'uint submitCount, VkSubmitInfo* submits', in this case 'submits' should be an array
        if (parameterInfo.Name.EndsWith("s") && previousParameter != null)
        {
            var fixedParameterName = parameterInfo.Name.Replace("Copies", "Copys"); // correct plural name differences to work with the check
            var previousParameterName = previousParameter.Name;
            if (previousParameterName == fixedParameterName[..^1] + "Count")
                return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, isArray: true), ParameterModifier.None) };
        }

        // pointer + ref version
        return new() { parameterInfo, new(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Ref) };
    }

    /// <summary>Generates all combinations of parameter variations.</summary>
    /// <param name="parameterVariations">The variations of each paramter of a command.</param>
    /// <returns>The combinations of parameter variations.</returns>
    private static List<List<FunctionParameterInfo>> GetParameterCombinations(List<List<FunctionParameterInfo>> parameterVariations)
    {
        var parameterCombinations = new List<List<FunctionParameterInfo>>();
        var firstParameter = parameterVariations.First();
        var otherParameters = parameterVariations.Skip(1).ToList();

        // loop through each variations and recursively prepend that to the each combination of the other parameters
        foreach (var variation in firstParameter)
            if (otherParameters.Count == 0) // we're at the end of the parameter list, just add the variation
                parameterCombinations.Add(new() { variation });
            else // recursively get the combination of other parameters
            {
                var otherParameterVariations = GetParameterCombinations(otherParameters);
                foreach (var otherParameterVariation in otherParameterVariations)
                {
                    var combination = new List<FunctionParameterInfo>() { variation };
                    combination.AddRange(otherParameterVariation);
                    parameterCombinations.Add(combination);
                }
            }

        return parameterCombinations;
    }
}
