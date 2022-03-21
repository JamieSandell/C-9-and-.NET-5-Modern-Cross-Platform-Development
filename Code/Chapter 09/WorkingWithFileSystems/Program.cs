using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.Path;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void OutputFileSystemInfo()
        {
            WriteLine("{0, -33} {1}", "Path.PathSeparator", PathSeparator);
            WriteLine("{0, -33} {1}", "Path.DirectorySeparatorChar", DirectorySeparatorChar);
            WriteLine("{0, -33} {1}", "Directory.GetCurrentDirectory()", GetCurrentDirectory());
            WriteLine("{0, -33} {1}", "Environment.CurrentDirectory()", CurrentDirectory);
            WriteLine("{0, -33} {1}", "Environment.SystemDirectory()", SystemDirectory);
            WriteLine("{0, -33} {1}");
        }
    }
}
