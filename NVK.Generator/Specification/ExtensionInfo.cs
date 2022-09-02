using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace NVK.Generator.Specification;

/// <summary>Represents a Vulkan extension.</summary>
public class ExtensionInfo
{
    /*********
    ** Accessors
    *********/
    /// <summary>The name of the extension.</summary>
    public string Name { get; }

    /// <summary>The platform the extension is for.</summary>
    public string? Platform { get; }

    /// <summary>The api name this extension is for, if the extension should be ignored this will be "disabled".</summary>
    public string Supported { get; }

    /// <summary>The constants the extension adds.</summary>
    public List<ConstantInfo> Constants { get; } = new();

    /// <summary>The enum values the extension adds.</summary>
    public List<ExtensionEnumFieldInfo> EnumExtensions { get; } = new();

    /// <summary>The names of the types the extensions adds.</summary>
    public List<string> TypeNames { get; } = new();

    /// <summary>The names of the commands the extensions adds.</summary>
    public List<string> CommandNames { get; } = new();


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="element">The extension element.</param>
    /// <param name="typeConverter">The type converter to use when creating the instance.</param>
    public ExtensionInfo(XElement element, TypeConverter typeConverter)
    {
        Name = element.Attribute("name")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'name' attribute.", nameof(element));
        Platform = element.Attribute("platform")?.Value;
        Supported = element.Attribute("supported")?.Value ?? throw new ArgumentException($"Element: {element} doesn't contain a 'supported' attribute.", nameof(element));
        
        foreach (var requireElement in element.Elements("require"))
        {
            // add types
            foreach (var typeElement in requireElement.Elements("type"))
                TypeNames.Add(typeConverter.GetConvertedType(typeElement.Attribute("name")?.Value ?? throw new ArgumentException($"Child type element: {requireElement} doesn't contain a 'name' attribute.")));

            // add commands
            foreach (var commandElement in requireElement.Elements("command"))
                CommandNames.Add(commandElement.Attribute("name")?.Value ?? throw new ArgumentException($"Child command element: {requireElement} doesn't contain a 'name' attribute."));

            // add constants and enum extensions
            foreach (var enumElement in requireElement.Elements("enum"))
            {
                // if the enum doesn't extend anything, it's a regular constant
                if (enumElement.Attribute("extends") == null)
                    Constants.Add(new ConstantInfo(enumElement));

                // otherwise, it's an enum extension
                else
                {
                    var number = int.Parse(element.Attribute("number")?.Value ?? throw new ArgumentException($"Child enum element: {enumElement} doesn't contain a 'number' attribute.", nameof(element)));
                    EnumExtensions.Add(new ExtensionEnumFieldInfo(number, enumElement, typeConverter));
                }
            }
        }
    }
}
