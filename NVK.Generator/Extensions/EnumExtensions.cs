using System;
using System.Linq;
using System.Reflection;

namespace NVK.Generator.Extensions
{
    /// <summary>Extension methods for the <see cref="Enum"/> class.</summary>
    public static class EnumExtensions
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Gets a specified attribute that an enum has.</summary>
        /// <typeparam name="T">The type of attribute to get.</typeparam>
        /// <param name="enum">The enum to get the attribute of.</param>
        /// <returns>The first attribute that has a type of <typeparamref name="T"/> on <paramref name="enum"/>, if one exists; otherwise, <see langword="null"/>.</returns>
        public static T? GetAttribute<T>(this Enum @enum)
            where T : Attribute
        {
            var fieldInfo = @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault();
            if (fieldInfo == null)
                return null;

            return (T?)fieldInfo.GetCustomAttributes(typeof(T)).FirstOrDefault();
        }
    }
}
