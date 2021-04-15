using System;

namespace NVK.Generator.Attributes
{
    /// <summary>An attribute used to specify the underlying type to an enum value.</summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class UnderlyingTypeAttribute : Attribute
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The underlying type that the enum value represents.</summary>
        public string UnderlyingType { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="underlyingType">The underlying type that the enum value represents.</param>
        public UnderlyingTypeAttribute(string underlyingType)
        {
            UnderlyingType = underlyingType;
        }
    }
}
