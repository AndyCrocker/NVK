namespace NVK.Generator.Specification;

/// <summary>Represents a parsed function.</summary>
internal class FunctionInfo
{
    /*********
    ** Fields
    *********/
    /// <summary>The specification the function was parsed from.</summary>
    private VulkanSpecification Specification { get; }


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


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;command&gt; element to parse the function from.</param>
    /// <param name="specification">The specification to use when parsing the function.</param>
    public FunctionInfo(XElement element, VulkanSpecification specification)
    {
        Specification = specification;

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
    /// <param name="specification">The specification the function was parsed from.</param>
    /// <param name="name">The name of the function.</param>
    /// <param name="returnType">The return type of the function.</param>
    /// <param name="parameters">The parameters of the function.</param>
    /// <param name="alias">The name of the function that this function is an alias of.</param>
    private FunctionInfo(VulkanSpecification specification, string name, TypeInfo returnType, List<FunctionParameterInfo> parameters, string? alias)
    {
        Specification = specification;
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

            var parametersString = CalculateParameterString(overload, true, true, true, true, false);
            var calledParametersString = CalculateParameterString(overload, false, true, false, true, false);

            if (Alias != null)
                writer.WriteLine($"[Obsolete(\"Use {AliasDisplayName}\")]");

            writer.WriteLine($"public static {ReturnType} {DisplayName}({parametersString}) => {DisplayName}_{i}({calledParametersString});");
            writer.WriteLine($"private static {CalculateDelegateSignature(overload)} {DisplayName}_{i};");
        }
    }

    /// <summary>Writes the function pointer and delegates being assigned as a required function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteRequiredFunction(CsWriter writer)
    {
        var functionPointerName = DisplayName.FirstToLower();
        writer.WriteLine($"var {functionPointerName} = VulkanLibrary.GetFunctionPointer(\"{DisplayName}\");");

        var overloads = GenerateAllOverloads();
        for (int i = 0; i < overloads.Count; i++)
            writer.WriteLine($"{DisplayName}_{i} = ({CalculateDelegateSignature(overloads[i])}){functionPointerName};");
    }

    /// <summary>Writes the function pointer and delegates being assigned as an instance function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteInstanceFunction(CsWriter writer)
    {
        var functionPointerName = DisplayName.FirstToLower();
        writer.WriteLine($"var {functionPointerName} = GetInstanceProcedureAddress(instance, \"{AliasDisplayName ?? DisplayName}\");");

        var overloads = GenerateAllOverloads();
        for (int i = 0; i < overloads.Count; i++)
            writer.WriteLine($"{DisplayName}_{i} = ({CalculateDelegateSignature(overloads[i])}){functionPointerName};");
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
    /// <summary>Calculates a comma separated parameter list.</summary>
    /// <param name="functionInfo">The function to use for calculating the parameter list.</param>
    /// <param name="includeNonCalledModifiers">Whether modifier values should be included when <see cref="ParameterModifierAttribute.IsRequiredForCalling"/> is <see langword="false"/>.</param>
    /// <param name="includeCalledModifiers">Whether modifier values should be included when <see cref="ParameterModifierAttribute.IsRequiredForCalling"/> is <see langword="true"/>.</param>
    /// <param name="includeType">Whether the parameter types should be included in the parameter list.</param>
    /// <param name="includeNames">Whether the parameter names should be included in the parameter list.</param>
    /// <param name="includeReturnType">Whether the return type should be included on the end of the parameter list.</param>
    /// <returns>The calculated comma separated parameter list.</returns>
    private static string CalculateParameterString(FunctionInfo functionInfo, bool includeNonCalledModifiers, bool includeCalledModifiers, bool includeType, bool includeNames, bool includeReturnType)
    {
        var parameterStrings = functionInfo.Parameters.Select(parameterInfo =>
        {
            var parameter = "";

            var modifier = parameterInfo.Modifier.GetAttribute<ParameterModifierAttribute>();
            if (modifier != null)
                if ((includeNonCalledModifiers && !modifier.IsRequiredForCalling) ||
                    (includeCalledModifiers && modifier.IsRequiredForCalling))
                    parameter = modifier.Value;

            if (includeType)
                parameter += $" {parameterInfo.Type}";

            if (includeNames)
                parameter += $" {parameterInfo.Name}";

            return parameter.Trim();
        }).ToList();

        if (includeReturnType)
            parameterStrings.Add(functionInfo.ReturnType.ToString()!);

        return string.Join(", ", parameterStrings);
    }

    /// <summary>Calculates the delegate signature.</summary>
    /// <param name="functionInfo">The function to create the signature of.</param>
    /// <returns>The delegate signature of the function.</returns>
    private static string CalculateDelegateSignature(FunctionInfo functionInfo) =>
        $"delegate* unmanaged[Cdecl]<{CalculateParameterString(functionInfo, false, true, true, false, true)}>";

    /// <summary>Generates all overloads for the function.</summary>
    /// <returns>All the overloads that the function can have.</returns>
    private List<FunctionInfo> GenerateAllOverloads()
    {
        var parameters = Parameters;
        if (Alias != null)
            parameters = Specification.Functions.Single(functionInfo => functionInfo.Name == Alias).Parameters;

        // get all the version each parameter can be
        var parameterVariations = new List<List<FunctionParameterInfo>>();
        for (int i = 0; i < parameters.Count; i++)
            parameterVariations.Add(GetParameterVariations(parameters[i], parameters));

        // get all parameter variations
        var parameterCombinations = GetParameterCombinations(parameterVariations);
        return parameterCombinations.Select(parameterCombination => new FunctionInfo(Specification, Name, ReturnType, parameterCombination, Alias)).ToList();
    }

    /// <summary>Generates all varieties of a parameter.</summary>
    /// <param name="parameterInfo">The parameter to generate the variations of.</param>
    /// <returns>The variations that <paramref name="parameterInfo"/> can have, including <paramref name="parameterInfo"/> itself.</returns>
    private List<FunctionParameterInfo> GetParameterVariations(FunctionParameterInfo parameterInfo, List<FunctionParameterInfo> parameterInfos)
    {
        // ensure parameter can have multiple variations
        if (parameterInfo.Type.PointerIndirection == 0 || parameterInfo.Type.Name == "void")
            return new() { parameterInfo };

        // check if the parameter should have a single variant with an array
        if (parameterInfo.Name.EndsWith("Infos"))
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, isArray: true), ParameterModifier.None) };

        var parameterIndex = parameterInfos.IndexOf(parameterInfo);
        var previousParameter = parameterIndex >= 1 ? parameterInfos[parameterIndex - 1] : null;
        if ((DisplayName.StartsWith("Enumerate")                                                            // enumerate methods
                || (DisplayName.StartsWith("Allocate") && DisplayName.EndsWith("s"))                        // certain allocate methods
                || (DisplayName.StartsWith("Get") && (previousParameter?.Name.EndsWith("Count") ?? false))) // and certain get methods should all have a marshalled array
            && parameterInfos.Last() == parameterInfo)                                                          // on the last parameter
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, isArray: true), ParameterModifier.InOut) };

        // check if parameter is a byte pointer (meaning it's actually a string)
        if (parameterInfo.Type.Name == "byte")
            return new() { new FunctionParameterInfo(parameterInfo.Name, new TypeInfo("string", isArray: parameterInfo.Type.PointerIndirection == 2), ParameterModifier.None) };

        // check if parameter should have a single 'out' version
        if ((DisplayName.StartsWith("Allocate")                // allocate methods
                || DisplayName.StartsWith("Create")            // create methods
                || DisplayName.StartsWith("Get")               // get methods
                || DisplayName.StartsWith("AcquireNextImage")) // and 'AcquireNextImage(2)KHR' should all have outs
            && parameterInfos.Last() == parameterInfo)             // on the last parameter
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
