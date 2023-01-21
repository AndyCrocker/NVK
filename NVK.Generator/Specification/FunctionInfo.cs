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

    /// <summary>The base name of each delegate for the function.</summary>
    /// <remarks>Delegate in this case refers to the internal delegate for P/Invoke, not Vulkan delegates.</remarks>
    private string DelegateName => $"{Name}Delegate";

    /// <summary>The name of the function pointer for the function.</summary>
    /// <remarks>Function pointer in this case refers to the internal function pointer for P/Invoke, not Vulkan delegates.</remarks>
    private string PointerName => $"{Name}Pointer";


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


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the function to a C# writer.</summary>
    /// <param name="writer">The writer to write the function to.</param>
    /// <param name="specification">The specification to use when writing the function.</param>
    public void Write(CsWriter writer, FeatureInfo specification)
    {
        var parameters = Parameters;
        if (Alias != null)
        {
            writer.WriteLine($"[Obsolete(\"Use {Alias}\")]");
            parameters = specification.Functions.Single(functionInfo => functionInfo.Name == Alias).Parameters;
        }

        var parametersString = string.Join(", ", parameters.Select(parameterInfo => $"{parameterInfo.Type} {parameterInfo.Name}"));
        var calledParametersString = string.Join(", ", parameters.Select(parameterInfo => parameterInfo.Name));
        writer.WriteLine($"public static {ReturnType} {Name}({parametersString}) => {Name}_0({calledParametersString});");

        writer.WriteLine($"private delegate {ReturnType} {DelegateName}_0({parametersString});");
        writer.WriteLine($"private static IntPtr {PointerName};");
        writer.WriteLine($"private static {DelegateName}_0 {Name}_0;");
    }

    /// <summary>Writes the function pointer and delegates being assigned as a required function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteRequiredFunction(CsWriter writer)
    {
        writer.WriteLine($"{PointerName} = VulkanLibrary.GetFunctionPointer(\"{Name}\");");
        writer.WriteLine($"{Name}_0 = Marshal.GetDelegateForFunctionPointer<{DelegateName}_0>({PointerName});");
    }

    /// <summary>Writes the function pointer and delegates being assigned as an instance function to a C# writer.</summary>
    /// <param name="writer">The writer to write the assignment to.</param>
    public void WriteInstanceFunction(CsWriter writer)
    {
        writer.WriteLine($"{PointerName} = vkGetInstanceProcAddr(instance, \"{Alias ?? Name}\");");
        writer.WriteLine($"if ({PointerName} != IntPtr.Zero)");
        writer.WriteScope(() =>
        {
            writer.WriteLine($"{Name}_0 = Marshal.GetDelegateForFunctionPointer<{DelegateName}_0>({PointerName});");
        });
    }
}
