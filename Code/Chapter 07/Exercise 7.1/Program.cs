using System;
using static System.Console;

namespace Exercise_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What is the difference between a namespace and an assembly?");
            WriteLine("Namespace is a collection of names that are unique, and form a logical boundary for a group of classes.");
            WriteLine("An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality.");
            WriteLine();
            WriteLine("2.) How do you reference another project in a .csproj file?");
            WriteLine("<ProjectReference Include=\"pathToCSProj.csproj\"");
            WriteLine();
            WriteLine("3.) What is the benefit of a tool like ILSpy?");
            WriteLine("Used to decompile .NET to IL code.");
            WriteLine();
            WriteLine("4.) Which .NET type does the C# float alias represent?");
            WriteLine("System.Single");
            WriteLine();
            WriteLine("5.) What tool should you use before porting an application from .NET Framework to .NET 5?");
            WriteLine(".Net Portability Analyzer.");
            WriteLine();
            WriteLine("6.) What is the difference between framework-depedent and self-contained deployments of .NET applications?");
            WriteLine("Framework-depedent require that the framework be present on the machine it is running on, whereas self-contained have everything it needs to run.");
            WriteLine();
            WriteLine("7.) What is a RID?");
            WriteLine("Runtime identifier. Used by .NET packages to represent platform-specific assets in NuGet packages.");
            WriteLine();
            WriteLine("8.) What is the difference between the dotnet pack and dotnet publish commands?");
            WriteLine("dotnet pack builds the project and creates NuGet packages.");
            WriteLine("dotnet publish compiles the application, reads through its dependencies specified in the project file, and publishes the resulting set of files.");
            WriteLine();
            WriteLine("9.) What types of applications written for .NET framework can be ported to .NET 5?");
            WriteLine("ASP.NET Core MVC, ASP.NET Core Web API, Console applications, Windows Forms applications, WPF applications.");
            WriteLine();
            WriteLine("10.) Can you use packages written for .NET Framework with .NET 5?");
            WriteLine("Yes, as long as an assembly package only uses APIs available in .NET Standard, it can be used in a .NET 5 project.");
            WriteLine();
        }
    }
}
