namespace NVK.Generator.Specification
{
    /// <summary>Represents a <see cref="DelegateInfo"/> parameter.</summary>
    public class DelegateParameterInfo
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the parameter.</summary>
        public string Name { get; }

        /// <summary>The type of the parameter.</summary>
        public TypeInfo Type { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        public DelegateParameterInfo(string name, TypeInfo type)
        {
            Name = name;
            Type = type;
        }

        /// <inheritdoc/>
        public override string ToString() => $"{Type} {Utilities.PrettifyParameterName(Name, Type.PointerIndirection)}";
    }
}
