using System;

namespace NVK.Generator.Attributes
{
    /// <summary>An attribute used to specify the underlying attribute to an enum value.</summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class UnderlyingAttributeAttribute : Attribute
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The underlying attribute that the enum value represents.</summary>
        public string UnderlyingAttribute { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="underlyingAttribute">The underlying attribute that the enum value represents.</param>
        public UnderlyingAttributeAttribute(string underlyingAttribute)
        {
            UnderlyingAttribute = underlyingAttribute;
        }
    }
}
