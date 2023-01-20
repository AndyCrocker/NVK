namespace NVK.Generator.Specification;

/// <summary>Represents a parsed structure.</summary>
internal class StructureInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the structure.</summary>
    public string Name { get; }

    /// <summary>The name of the structure that this structure is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>Whether the structure is a union.</summary>
    public bool IsUnion { get; }

    /// <summary>Notes that the structure is going to be filled in by the API rather than an application filling it out and passing it to the API.</summary>
    public bool ReturnedOnly { get; }

    /// <summary>A list of structures whose <c>pNext</c> can include this type.</summary>
    public string[] StructExtends { get; }

    /// <summary>Specifies if structures whose <c>pNext</c> chain include this structure may incllude more than one instance of it.</summary>
    public bool AllowDuplicate { get; }

    /// <summary>The fields of the structure.</summary>
    public List<StructureFieldInfo> Fields { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The &lt;type&gt; element to parse the structure from.</param>
    public StructureInfo(XElement element)
    {
        Name = element.Attribute("name")!.Value;
        Alias = element.Attribute("alias")?.Value;
        IsUnion = element.HasAttribute("category", "union");
        ReturnedOnly = element.HasAttribute("returnedonly", "true");
        StructExtends = element.Attribute("structextends")?.Value.Split(',') ?? Array.Empty<string>();
        AllowDuplicate = element.HasAttribute("allowduplicate", "true");
        Fields = element.Elements("member")
            .Select(structFieldElement => new StructureFieldInfo(this, structFieldElement)).ToList();
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the structure to a C# writer.</summary>
    /// <param name="writer">The writer to write the structure to.</param>
    /// <param name="specification">The specification to use when writing the structure.</param>
    public void Write(CsWriter writer, FeatureInfo specification)
    {
        var fieldInfos = Fields;
        if (Alias != null)
        {
            writer.WriteLine($"[Obsolete(\"Use {Alias}\")]");
            fieldInfos = specification.Structures.Single(structureInfo => structureInfo.Name == Alias).Fields;
        }

        if (IsUnion)
            writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");

        writer.WriteLine($"public unsafe struct {Name}");
        writer.WriteScope(() =>
        {
            foreach (var fieldInfo in fieldInfos)
                fieldInfo.Write(writer, specification);
        });
    }
}
