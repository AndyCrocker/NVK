namespace NVK.Generator.Specification;

/// <summary>Represents a parsed type.</summary>
internal class TypeInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the type.</summary>
    public string Name { get; }

    /// <summary>The pointer indirection of the type.</summary>
    public int PointerIndirection { get; }

    
    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the type.</param>
    /// <param name="pointerIndirection">The pointer indirection of the type.</param>
    public TypeInfo(string name, int pointerIndirection = 0)
    {
        Name = name;
        PointerIndirection = pointerIndirection;
    }


    /*********
    ** Public Methods
    *********/
    /// <summary>Gets a string that represents the type.</summary>
    /// <returns>A string that represents the type.</returns>
    public override string? ToString() => $"{Name}{new('*', PointerIndirection)}";
}
