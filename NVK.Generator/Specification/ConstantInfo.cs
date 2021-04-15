using System;
using System.Collections.Generic;
using System.Xml.Linq;
using NVK.Generator.Attributes;
using NVK.Generator.Extensions;

namespace NVK.Generator.Specification
{
    /// <summary>Represents a Vulkan constant.</summary>
    public class ConstantInfo
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the constant.</summary>
        public string Name { get; }

        /// <summary>The type of the constant.</summary>
        public ConstantType Type { get; }

        /// <summary>The value of the constant.</summary>
        public string? Value { get; }

        /// <summary>The name of the constant that this constant is an alias of.</summary>
        public string? Alias { get; set; }

        /// <summary>The extensions that add this constant.</summary>
        public List<string> Extensions { get; } = new();

        /// <summary>The name of the constant ready for displaying.</summary>
        public string DisplayName => Utilities.PrettifyConsantName(Name);

        /// <summary>The type of the constant ready for displaying.</summary>
        public string DisplayType => Type.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType ?? throw new InvalidOperationException($"Type has a value of {(int)Type} which doesn't have a specified underlying type.");

        /// <summary>The value of the constant ready for displaying.</summary>
        public string DisplayValue
        { 
            get
            {
                string value;
                if (Alias != null)
                    value = Utilities.PrettifyConsantName(Alias);
                else
                {
                    if (Value == null)
                        throw new InvalidOperationException("Constant doesn't contain a valid or alias.");

                    if (Type != ConstantType.String)
                        value = Value.Replace("\"", "");
                    else
                        value = Value;
                }

                return Utilities.PrettifyConsantValue(value);
            }
        }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="element">The constant element.</param>
        public ConstantInfo(XElement element)
        {
            Name = element.Attribute("name")?.Value ?? throw new ArgumentException("Doesn't contain a 'name' attribute.", nameof(element));
            Value = element.Attribute("value")?.Value;
            Alias = element.Attribute("alias")?.Value;

            // determine the type from the value
            if (Alias == null && Value != null)
                Type = DetermineType(Value);
        }


        /*********
        ** Private Methods
        *********/
        /// <summary>Determine the type of a constant value.</summary>
        /// <param name="value">The value to determine the type of.</param>
        /// <returns>The type of the value.</returns>
        private ConstantType DetermineType(string value)
        {
            if (value.EndsWith("f"))
                return ConstantType.Single;
            else if (value.EndsWith("ULL)"))
                return ConstantType.ULong;
            else if (value.Contains('"'))
                return ConstantType.String;
            else
                return ConstantType.UInt;
        }
    }
}
