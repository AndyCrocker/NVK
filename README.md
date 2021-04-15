**NVK** is a low-level .NET5 [Vulkan](https://www.khronos.org/vulkan/) binding.

## Generating Bindings
To generate the bindings, you'll need the [.NET5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0).

Compile and run the `NVK.Generator` project, this will ouput all auto-generated source files into the `Generated` directory of the output directory as well as copying over the `ToCopy` folder contents to the `NVK` project. Copy over those auto-generated files to the `NVK` project and compile the project.

## Credits
NVK's generator was based on [vk](https://github.com/mellinoe/vk)'s.