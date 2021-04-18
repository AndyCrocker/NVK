using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NVK.Generator.Extensions
{
    /// <summary>Extension methods for the <see langword="string"/> class.</summary>
    public static class StringExtensions
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Splits a string on every uppercase character.</summary>
        /// <param name="value">The string to split.</param>
        /// <returns>An array whose elements contain the substrings from this instance that start with an uppercase.</returns>
        public static string[] SplitOnUpper(this string value) => Regex.Split(value, @"(?<!^)(?=[A-Z])"); // https://stackoverflow.com/a/4489031

        /// <summary>Converts the first character to lowercase.</summary>
        /// <param name="value">The string whose first character should be converted to lowercase.</param>
        /// <returns>A string with it's first character as lowercase.</returns>
        public static string FirstToLower(this string value)
        {
            if (value == "")
                return value;

            var charArray = value.ToCharArray();
            charArray[0] = char.ToLower(charArray[0]);
            return new string(charArray);
        }

        /// <summary>Converts the first character to uppercase.</summary>
        /// <param name="value">The string whose first character should be converted to uppercase.</param>
        /// <returns>A string with it's first character as uppercase.</returns>
        public static string FirstToUpper(this string value)
        {
            if (value == "")
                return value;

            var charArray = value.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        /// <summary>Resolves all abbreviations in a string.</summary>
        /// <param name="value">The string to resolve the abbreviations of.</param>
        /// <returns>A string without abbreviations.</returns>
        public static string ResolveAbbreviations(this string value)
        {
            var abbreviations = new List<(string Abbreviated, string Resolved)>
            {
                ("Src", "Source"),
                ("Dst", "Destination"),
                ("Cmd", "Command"),
                ("ProcAddr", "PrecedureAddress"),
                ("Fd", "FileDescriptor")
            };

            foreach (var abbreviation in abbreviations)
            {
                // completely ignoring case can't be done as it'll convert 'BlendState' to 'BlenDestinationate' among others
                value = value.Replace(abbreviation.Abbreviated, abbreviation.Resolved);
                value = value.Replace(abbreviation.Abbreviated.ToLower(), abbreviation.Resolved);
            }

            return value;
        }

        /// <summary>Ensures a string isn't a reserved C# word.</summary>
        /// <param name="value">The string to ensure isn't a reserved keyword.</param>
        /// <returns>A string that isn't a reserved keyword.</returns>
        public static string EnsureIsntReserved(this string value)
        {
            var reservedKeywords = new[] { "event", "object" }; // obviously not all the reserved keywords, but these are the only ones Vulkan uses
            if (reservedKeywords.Contains(value))
                value = $"@{value}";

            return value;
        }

        /// <summary>Removes any vendor tags from the end of a string.</summary>
        /// <param name="value">The string to remove vendor tags from the end of.</param>
        /// <returns>A string that doesn't have a vendor tag on the end.</returns>
        public static string RemoveSuffixesExtensionVendorTag(this string value)
        {
            // TODO: retrieve these automatically from the spec
            var vendorTags = new[] { "IMG", "AMD", "AMDX", "ARM", "FSL", "BRCM", "NXP", "NV", "NVX", "VIV", "VSI", "KDAB", "ANDROID", "CHROMIUM", "FUCHSIA", "GGP", "GOOGLE", "QCOM", "LUNARG", "SAMSUNG", "SEC", "TIZEN", "RENDERDOC", "NN", "MVK", "KHR", "KHX", "EXT", "MESA", "INTEL", "HUAWEI", "VALVE", "QNX" };

            foreach (var vendorTag in vendorTags)
                if (value.EndsWith(vendorTag))
                    return value.Substring(0, value.Length - vendorTag.Length);

            return value;
        }
    }
}
