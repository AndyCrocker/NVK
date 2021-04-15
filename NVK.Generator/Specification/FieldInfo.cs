using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace NVK.Generator.Specification
{
    /// <summary>Represents a structure field.</summary>
    public class FieldInfo
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the field.</summary>
        public string Name { get; }

        /// <summary>The type of the field.</summary>
        public TypeInfo Type { get; }

        /// <summary>The number of elements in the field (if the type is an array).</summary>
        /// <remarks>This is a <see langword="string"/> to allow setting the element count to a constant.</remarks>
        public string? ElementCount { get; }

        /// <summary>The name of the field ready for displaying.</summary>
        public string DisplayName => Utilities.PrettifyFieldName(Name, Type.PointerIndirection);


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="element">The field element.</param>
        /// <param name="typeConverter">The type converter to use when creating the instance.</param>
        public FieldInfo(XElement element, TypeConverter typeConverter)
        {
            Name = element.Element("name")?.Value ?? throw new ArgumentException("Doesn't contain a 'name' element.", nameof(element));

            var pointerIndirection = element.Value.Count(character => character == '*');
            Type = new TypeInfo(typeConverter.GetConvertedType(element.Element("type")?.Value ?? throw new ArgumentException("Doesn't contain a 'type' element.", nameof(element))), pointerIndirection);

            // remove the comment element as it can sometimes contains "[]" which falsely implies an array
            element.Element("comment")?.Remove();

            var match = Regex.Match(element.Value, "\\[(.*)\\]");
            if (match.Captures.Count > 0)
                ElementCount = match.Groups[1].Value;
        }
    }
}
