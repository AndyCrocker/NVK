using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NVK.Generator.Attributes;
using NVK.Generator.EqualityComparer;
using NVK.Generator.Extensions;
using NVK.Generator.Specification;

namespace NVK.Generator;

/// <summary>Handles generating C# code.</summary>
public static class CodeGenerator
{
    /*********
    ** Public Methods
    *********/
    /// <summary>Geenrates the C# files for a specification.</summary>
    /// <param name="specification">The specification to generate the code from.</param>
    public static void GenerateCode(VulkanSpecification specification)
    {
        var outputPath = "./Generated/";
        Directory.CreateDirectory(outputPath);

        GenerateVKFile(specification.Constants, specification.Commands, Path.Combine(outputPath, "VK.gen.cs"));
        GenerateEnumsFile(specification.Enums, Path.Combine(outputPath, "Enums.gen.cs"));
        GenerateDelegatesFile(specification.Delegates, Path.Combine(outputPath, "Delegates.gen.cs"));
        GenerateHandlesFile(specification.Handles, Path.Combine(outputPath, "Handles.gen.cs"));
        GenerateStructuresFile(specification.Structures, specification.Constants, Path.Combine(outputPath, "Structures.gen.cs"));
    }


    /*********
    ** Private Methods
    *********/
    /// <summary>Generates the C# file containing the Vulkan constants and commands.</summary>
    /// <param name="constantInfos">The constants to generate.</param>
    /// <param name="commandInfos">The commands to generate.</param>
    /// <param name="file">The VK file.</param>
    private static void GenerateVKFile(List<ConstantInfo> constantInfos, List<CommandInfo> commandInfos, string file)
    {
        using var streamWriter = File.CreateText(file);
        var csWriter = new CsWriter(streamWriter);

        csWriter.WriteHeader();
        csWriter.WriteLine();

        csWriter.WriteUsing("System");
        csWriter.WriteUsing("System.Runtime.InteropServices");
        csWriter.WriteLine();

        csWriter.WriteLine($"namespace Vulkan;");

        csWriter.WriteLine($"public static unsafe class VK");
        csWriter.WriteScope(() =>
        {
            // create constants
            foreach (var constantInfo in constantInfos)
                csWriter.WriteLine($"public const {constantInfo.DisplayType} {constantInfo.DisplayName} = {constantInfo.DisplayValue};");

            // create delegates
            foreach (var commandInfo in commandInfos.Where(command => command.Alias == null))
            {
                var overloads = Utilities.GenerateAllOverloads(commandInfo);
                for (int i = 0; i < overloads.Count; i++)
                {
                    var overload = overloads[i];
                    csWriter.WriteLine($"private delegate {overload.ReturnType} {overload.DelegateDisplayName}_{i}({string.Join(", ", overload.Parameters.Select(parameterInfo => parameterInfo.ToString()))});");
                }
            }

            // create fields
            csWriter.WriteLine("private static readonly OSVulkanLibraryBase VulkanLibrary;");
            foreach (var commandInfo in commandInfos.Where(command => command.Alias == null))
            {
                // field containing function pointer
                csWriter.WriteLine($"private static IntPtr {commandInfo.PointerDisplayName};");

                // fields for each overload delegate
                var overloads = Utilities.GenerateAllOverloads(commandInfo);
                for (int i = 0; i < overloads.Count; i++)
                    csWriter.WriteLine($"private static {commandInfo.DelegateDisplayName}_{i} {commandInfo.DisplayName}_{i};");
            }

            // create class initialiser to retrieve the function pointers
            csWriter.WriteLine("static VK()");
            csWriter.WriteScope(() =>
            {
                csWriter.WriteLine("VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();");
                csWriter.WriteLine("InitialiseRequiredMethods();");
            });

            // create methods
            var requiredMethods = new[] { "vkCreateInstance", "vkEnumerateInstanceExtensionProperties", "vkEnumerateInstanceLayerProperties", "vkGetInstanceProcAddr" };

            csWriter.WriteLine("private static void InitialiseRequiredMethods()");
            csWriter.WriteScope(() =>
            {
                foreach (var commandInfo in commandInfos.Where(commandInfo => requiredMethods.Contains(commandInfo.Name)))
                {
                    csWriter.WriteLine($"{commandInfo.PointerDisplayName} = VulkanLibrary.GetFunctionPointer(\"{commandInfo.Name}\");");
                    WriteDelegateOverloads(commandInfo);
                }
            });

            // create method that's called once a Vulkan instance has been created to link all the non required methods
            csWriter.WriteLine("public static void InitialiseInstanceMethods(VkInstance instance)");
            csWriter.WriteScope(() =>
            {
                foreach (var commandInfo in commandInfos.Where(commandInfo => !requiredMethods.Contains(commandInfo.Name)))
                {
                    if (commandInfo.Alias != null) // aliases don't have delegates
                        continue;

                    csWriter.WriteLine($"{commandInfo.PointerDisplayName} = GetInstancePrecedureAddress(instance, \"{commandInfo.Name}\");");
                    csWriter.WriteLine($"if ({commandInfo.PointerDisplayName} != IntPtr.Zero)");
                    csWriter.WriteScope(() => WriteDelegateOverloads(commandInfo));
                }
            });

            // main VK methods
            foreach (var commandInfo in commandInfos)
            {
                var overloads = Utilities.GenerateAllOverloads(commandInfo);
                for (int i = 0; i < overloads.Count; i++)
                {
                    var overload = overloads[i];
                    var parametersString = string.Join(", ", overload.Parameters.Select(parameterInfo => parameterInfo.ToString()));

                    // if the method is an alias, just call that instead of marshalling
                    if (overload.Alias != null)
                    {
                        var aliasedParameterNames = string.Join(", ", overload.Parameters.Select(parameterInfo => $"{parameterInfo.Modifier.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType}{parameterInfo.DisplayName}"));

                        var aliasedCommand = commandInfos.Single(cInfo => cInfo.Name == overload.Alias);
                        csWriter.WriteLine($"public static {aliasedCommand.ReturnType} {overload.DisplayName}({parametersString}) => {overload.AliasDisplayName}({aliasedParameterNames});");
                        continue;
                    }

                    // create method
                    var parameterNames = string.Join(", ", overload.Parameters.Select(parameterInfo => $"{parameterInfo.Modifier.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType}{parameterInfo.DisplayName}"));
                    csWriter.WriteLine($"public static {overload.ReturnType} {overload.DisplayName}({parametersString}) => {overload.DisplayName}_{i}({parameterNames});");
                }
            }


            // Writes the all the overloads for a command.
            void WriteDelegateOverloads(CommandInfo commandInfo)
            {
                var overloads = Utilities.GenerateAllOverloads(commandInfo);
                for (int i = 0; i < overloads.Count; i++)
                    csWriter.WriteLine($"{commandInfo.DisplayName}_{i} = Marshal.GetDelegateForFunctionPointer<{commandInfo.DelegateDisplayName}_{i}>({commandInfo.PointerDisplayName});");
            }
        });
    }

    /// <summary>Generates the C# file containing the Vulkan enums.</summary>
    /// <param name="enumInfos">The enums to generate.</param>
    /// <param name="file">The enums file.</param>
    private static void GenerateEnumsFile(List<EnumInfo> enumInfos, string file)
    {
        using var streamWriter = File.CreateText(file);
        var csWriter = new CsWriter(streamWriter);

        csWriter.WriteHeader();
        csWriter.WriteLine();

        csWriter.WriteUsing("System");
        csWriter.WriteLine();

        csWriter.WriteLine($"namespace Vulkan;");

        foreach (var enumInfo in enumInfos)
        {
            if (enumInfo.Type == EnumType.Bitmask)
                csWriter.WriteLine($"[Flags]");

            csWriter.WriteLine($"public enum {enumInfo.Name}{((enumInfo.BitWidth == 64) ? " : long" : "")}");
            csWriter.WriteScope(() =>
            {
                foreach (var enumValue in enumInfo.Values.Distinct(new EnumFieldInfoDisplayNameEqualityComparer()))
                    csWriter.WriteLine(enumValue.ToString());
            });
        }
    }

    /// <summary>Generates the C# file containing the Vulkan function pointers.</summary>
    /// <param name="delegateInfos">The delegates to generate.</param>
    /// <param name="file">The delegates file.</param>
    /// <remarks>Note: this doesn't contain the delegates used for interop, those are stored in <c>VK.gen.cs</c> generated by <see cref="GenerateVKFile(List{ConstantInfo}, List{CommandInfo}, string)"/>.</remarks>
    private static void GenerateDelegatesFile(List<DelegateInfo> delegateInfos, string file)
    {
        using var streamWriter = File.CreateText(file);
        var csWriter = new CsWriter(streamWriter);

        csWriter.WriteHeader();
        csWriter.WriteLine();

        csWriter.WriteUsing("System");
        csWriter.WriteLine();

        csWriter.WriteLine($"namespace Vulkan;");

        foreach (var delegateInfo in delegateInfos)
        {
            var parameters = string.Join(", ", delegateInfo.Parameters.Select(parameterInfo => parameterInfo.ToString()));
            csWriter.WriteLine($"public unsafe delegate {delegateInfo.ReturnType} {delegateInfo.DisplayName}({parameters});");
        }
    }

    /// <summary>Generates the C# file containing the Vulkan enums.</summary>
    /// <param name="handleInfos">The handles to generate.</param>
    /// <param name="file">The handles file.</param>
    private static void GenerateHandlesFile(List<HandleInfo> handleInfos, string file)
    {
        using var streamWriter = File.CreateText(file);
        var csWriter = new CsWriter(streamWriter);

        csWriter.WriteHeader();
        csWriter.WriteLine();

        csWriter.WriteUsing("System");
        csWriter.WriteLine();

        csWriter.WriteLine($"namespace Vulkan;");

        foreach (var handleInfo in handleInfos)
        {
            var handleType = handleInfo.Dispatchable ? "UIntPtr" : "ulong";
            var nullValue = handleInfo.Dispatchable ? "UIntPtr.Zero" : "0";

            csWriter.WriteLine($"public struct {handleInfo.Name}");
            csWriter.WriteScope(() =>
            {
                // fields
                csWriter.WriteLine($"public readonly {handleType} Handle;");

                // accessors
                csWriter.WriteLine($"public bool IsNull => Handle == {nullValue};");
                csWriter.WriteLine($"public static {handleInfo.Name} Null => new({nullValue});");

                // public methods
                csWriter.WriteLine($"public {handleInfo.Name}({handleType} handle)");
                csWriter.WriteScope(() =>
                {
                    csWriter.WriteLine("Handle = handle;");
                });
                csWriter.WriteLine($"public override bool Equals(object obj) => obj is {handleInfo.Name} handle && this == handle;");
                csWriter.WriteLine($"public override int GetHashCode() => Handle.GetHashCode();");

                // operators
                csWriter.WriteLine($"public static bool operator ==({handleInfo.Name} left, {handleInfo.Name} right) => left.Handle == right.Handle;");
                csWriter.WriteLine($"public static bool operator !=({handleInfo.Name} left, {handleInfo.Name} right) => left.Handle != right.Handle;");
                csWriter.WriteLine($"public static bool operator ==({handleInfo.Name} left, {handleType} right) => left.Handle == right;");
                csWriter.WriteLine($"public static bool operator !=({handleInfo.Name} left, {handleType} right) => left.Handle != right;");
                csWriter.WriteLine($"public static bool operator ==({handleType} left, {handleInfo.Name} right) => left == right.Handle;");
                csWriter.WriteLine($"public static bool operator !=({handleType} left, {handleInfo.Name} right) => left != right.Handle;");
            });
        }
    }

    /// <summary>Generates the C# file containing the Vulkan structures.</summary>
    /// <param name="structureInfos">The structures to generate.</param>
    /// <param name="constantInfos">The constants to use when resolving array lengths for fields.</param>
    /// <param name="file">The structures file.</param>
    private static void GenerateStructuresFile(List<StructureInfo> structureInfos, List<ConstantInfo> constantInfos, string file)
    {
        using var streamWriter = File.CreateText(file);
        var csWriter = new CsWriter(streamWriter);

        csWriter.WriteHeader();
        csWriter.WriteLine();

        csWriter.WriteUsing("System");
        csWriter.WriteUsing("System.Runtime.InteropServices");
        csWriter.WriteLine();

        csWriter.WriteLine($"namespace Vulkan;");

        foreach (var structureInfo in structureInfos.Where(structureInfo => structureInfo.Fields.Count > 0))
        {
            if (structureInfo.IsUnion)
                csWriter.WriteLine("[StructLayout(LayoutKind.Explicit)]");

            csWriter.WriteLine($"public unsafe struct {structureInfo.DisplayName}");
            csWriter.WriteScope(() =>
            {
                // fields
                foreach (var fieldInfo in structureInfo.Fields)
                {
                    if (structureInfo.IsUnion)
                        csWriter.WriteLine("[FieldOffset(0)]");

                    if (fieldInfo.ElementCount == null)
                        csWriter.WriteLine($"public {fieldInfo.Type} {fieldInfo.DisplayName};");
                    else
                    {
                        int.TryParse(fieldInfo.ElementCount, out var numericArrayLength);
                        if (fieldInfo.ElementCount.Contains("][")) // check if the field is an array of arrays, if so then set the array length to be that of a single dimensional one
                            numericArrayLength = fieldInfo.ElementCount.Split("][").Select(arrayDimension => int.Parse(arrayDimension)).Aggregate(1, (x, y) => x * y);

                        // check if the type is allowed in a fixed array
                        var fixedArrayTypes = new[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "bool", "char", "float", "double" };
                        if (fixedArrayTypes.Contains(fieldInfo.Type.Name))
                        {
                            var arrayLength = numericArrayLength.ToString();
                            if (numericArrayLength == 0) // if it's a constant (instead of a number), prefix it as such
                                arrayLength = $"(int)VK.{Utilities.PrettifyConsantName(fieldInfo.ElementCount)}";

                            csWriter.WriteLine($"public fixed {fieldInfo.Type} {fieldInfo.DisplayName}[{arrayLength}];");
                        }

                        // if it isn't, then create a separate field for each element
                        else
                        {
                            // if the array length is a Vulkan constant, resolve it to a numeric value
                            if (numericArrayLength == 0)
                                numericArrayLength = int.Parse(constantInfos.Single(constantInfo => constantInfo.Name == fieldInfo.ElementCount).DisplayValue);

                            for (int i = 0; i < numericArrayLength; i++)
                                csWriter.WriteLine($"public {fieldInfo.Type} {fieldInfo.DisplayName}_{i};");
                        }
                    }
                }

                var structuresWithConstructors = new[] { "VkOffset2D", "VkOffset3D", "VkExtent2D", "VkExtent3D", "VkRect2D", "VkComponentMapping", "VkImageSubresource", "VkImageSubresourceLayers", "VkImageSubresourceRange", "VkClearDepthStencilValue", "VkClearColorValue" };

                // properties
                if (structureInfo.DisplayName.StartsWith("VkOffset") || structureInfo.DisplayName.StartsWith("VkExtent"))
                    csWriter.WriteLine($"public static {structureInfo.DisplayName} Zero => new();");
                else if (structureInfo.DisplayName == "VkComponentMapping")
                    csWriter.WriteLine("public static VkComponentMapping Identity => new(VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity);");

                // constructors
                if (structuresWithConstructors.Contains(structureInfo.DisplayName))
                {
                    // special constructors
                    if (structureInfo.DisplayName == "VkClearColorValue")
                    {
                        var parameterTypes = new[] { "float", "int", "uint" };
                        foreach (var parameterType in parameterTypes)
                        {
                            csWriter.WriteLine($"public VkClearColorValue({parameterType} r, {parameterType} g, {parameterType} b, {parameterType} a)");
                            csWriter.WriteScope(() =>
                            {
                                var fieldName = parameterType.FirstToUpper() + "32";
                                csWriter.WriteLine($"{fieldName}[0] = r;");
                                csWriter.WriteLine($"{fieldName}[1] = g;");
                                csWriter.WriteLine($"{fieldName}[2] = b;");
                                csWriter.WriteLine($"{fieldName}[3] = a;");
                            });
                        }
                    }

                    // auto generated constructor
                    else
                    {
                        var parametersString = string.Join(", ", structureInfo.Fields.Select(fieldInfo => $"{fieldInfo.Type} {fieldInfo.DisplayName.FirstToLower()}"));
                        csWriter.WriteLine($"public {structureInfo.DisplayName}({parametersString})");
                        csWriter.WriteScope(() =>
                        {
                            foreach (var fieldInfo in structureInfo.Fields)
                                csWriter.WriteLine($"{fieldInfo.DisplayName} = {fieldInfo.DisplayName.FirstToLower()};");
                        });
                    }
                }

                // operators
                if (structureInfo.DisplayName == "VkClearValue")
                {
                    csWriter.WriteLine("public static implicit operator VkClearValue(VkClearColorValue colour) => new() { Color = colour };");
                    csWriter.WriteLine("public static implicit operator VkClearValue(VkClearDepthStencilValue depthStencil) => new() { DepthStencil = depthStencil };");
                }
            });
        }
    }
}
