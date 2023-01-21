namespace NVK.Generator.Specification;

/// <summary>Represents a parsed handle.</summary>
internal class HandleInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the handle.</summary>
    public string Name { get; }

    /// <summary>The name of the handle that this handle is an alias of.</summary>
    public string? Alias { get; }

    /// <summary>Whether the handle is a dispatchable object handle.</summary>
    public bool Dispatchable { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance</summary>
    /// <param name="element">The &lt;type&gt; element to parse the handle from.</param>
    public HandleInfo(XElement element)
    {
        // if the handle is an alias, the name is stored as an attribute instead of a child element
        Alias = element.Attribute("alias")?.Value;
        if (Alias != null)
        {
            Name = element.Attribute("name")!.Value;
            return;
        }

        Name = element.Element("name")!.Value;
        Dispatchable = element.Element("type")!.Value == "VK_DEFINE_HANDLE";
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Writes the handle to a C# writer.</summary>
    /// <param name="writer">The writer to write the handle to.</param>
    public void Write(CsWriter writer)
    {
        var handleType = Dispatchable ? "UIntPtr" : "ulong";
        var nullValue = Dispatchable ? "UIntPtr.Zero" : "0";

        if (Alias != null)
            writer.WriteLine($"[Obsolete(\"Use {Alias}\")]");

        writer.WriteLine($"public readonly struct {Name}");
        writer.WriteScope(() =>
        {
            writer.WriteLine($"public readonly {handleType} Handle;");

            writer.WriteLine($"public bool IsNull => Handle == {nullValue};");
            writer.WriteLine($"public static {Name} Null => new({nullValue});");

            writer.WriteLine($"public {Name}({handleType} handle)");
            writer.WriteScope(() =>
            {
                writer.WriteLine("Handle = handle;");
            });
            writer.WriteLine($"public override bool Equals(object obj) => obj is {Name} handle && this == handle;");
            writer.WriteLine($"public override int GetHashCode() => Handle.GetHashCode();");

            writer.WriteLine($"public static bool operator ==({Name} left, {Name} right) => left.Handle == right.Handle;");
            writer.WriteLine($"public static bool operator !=({Name} left, {Name} right) => left.Handle != right.Handle;");
            writer.WriteLine($"public static bool operator ==({Name} left, {handleType} right) => left.Handle == right;");
            writer.WriteLine($"public static bool operator !=({Name} left, {handleType} right) => left.Handle != right;");
            writer.WriteLine($"public static bool operator ==({handleType} left, {Name} right) => left == right.Handle;");
            writer.WriteLine($"public static bool operator !=({handleType} left, {Name} right) => left != right.Handle;");
        });
    }
}
