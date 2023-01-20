namespace NVK.Generator.Specification;

/// <summary>Represents a parsed delegate parameter.</summary>
internal class DelegateParameterInfo
{
    /*********
    ** Properties
    *********/
    /// <summary>The name of the parameter.</summary>
    public string Name { get; }

    /// <summary>The type of the parameter.</summary>
    public TypeInfo Type { get; }


    /*********
    ** Constructors
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="name">The name of the parameter.</param>
    /// <param name="type">The type of the parameter.</param>
    public DelegateParameterInfo(string name, TypeInfo type)
    {
        Name = name;
        Type = type;
    }
}
