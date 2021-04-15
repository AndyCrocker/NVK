namespace NVK.Generator.Specification
{
    /// <summary>Represents a type.</summary>
    public class TypeInfo
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the type.</summary>
        public string Name { get; }

        /// <summary>The pointer indirection of the type.</summary>
        public int PointerIndirection { get; }

        /// <summary>The number of array dimensions of the type.</summary>
        public int ArrayDimensions { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the type.</param>
        /// <param name="pointerIndirection">The pointer indirection of the type.</param>
        /// <param name="arrayDimensions">The number of array dimensions of the type.</param>
        public TypeInfo(string name, int pointerIndirection = 0, int arrayDimensions = 0)
        {
            Name = name;
            PointerIndirection = pointerIndirection;
            ArrayDimensions = arrayDimensions;
        }

        /// <inheritdoc/>
        public override string ToString() => Name + new string('*', PointerIndirection) + GetArraySuffix();


        /*********
        ** Private Methods
        *********/
        /// <summary>Gets the array suffix for the type.</summary>
        /// <returns>The array suffix for the type.</returns>
        private string GetArraySuffix()
        {
            if (ArrayDimensions == 0)
                return "";
            else
                return $"[{new string(',', ArrayDimensions - 1)}]";
        }
    }
}
