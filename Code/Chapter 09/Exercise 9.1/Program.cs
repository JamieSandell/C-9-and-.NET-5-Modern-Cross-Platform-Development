using System;
using static System.Console;

namespace Exercise_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What is the difference between using the File class and the FileInfo class?");
            WriteLine("File provides static methods for creation, copying, deletion, moving and opening of a single file and aids in the creation of FileStream objects");
            WriteLine("FileInfo provides the above, but instance methods and properties. It cannot be inherited.");
            WriteLine();
            WriteLine("2.) What is the difference between the ReadByte method and the Read method of a stream?");
            WriteLine("ReadByte returns -1 if at the end of the stream otherwise it returns the byte (cast to int32) read.)");
            WriteLine("Read takes in a buffer (to output to), and offset in the buffer to store the data from and the maximum number of bytes to read. Returns the total number of bytes read or 0 if eos reached.");
            WriteLine();
            WriteLine("3.) When would you use the StringReader, TextReader, and StreamReader classes?");
            WriteLine("StringReader when you want to read from a string.");
            WriteLine("TextReader reads characters from a text file.");
            WriteLine("StreamReader reads characters from a stream, such as a video stream, memory stream, etc.");
            WriteLine();
            WriteLine("4.) What does the DeflateStream type do?");
            WriteLine("Provides methods and properties for compressing and decompressing streams by using the Deflate algorithm.");
            WriteLine();
            WriteLine("5.) How many bytes per character does UTF-8 encoding use?");
            WriteLine("1 - 4 bytes per character.");
            WriteLine();
            WriteLine("6.) What is an object graph?");
            WriteLine("An object graph is a view of an object system at a particular point in time.");
            WriteLine();
            WriteLine("7.) What is the best serialization format to choose for minimizing space requirements?");
            WriteLine("System.Text.Json");
            WriteLine();
            WriteLine("8.) What is the best serialization format to choose for cross-platform compatiblity?");
            WriteLine("System.Text.JSON as it's a part of .NET Core 3.0, and is more performant as it uses UTF-8 as most network protocols, including HTTP use UTF-8. By default Json.Net uses UTF-16.");
            WriteLine();
            WriteLine("9.) Why is it bad to use a string like \\Code\\Chapter01 to represent a path and what should you do instead?");
            WriteLine("It isn't cross-platform, that would work in Windows, but in Linux it would be /Code/Chapter01.");
            WriteLine("Instead, you should (in this instance) var newFolder = Combine(GetFolderPath(SpecialFolder.Personal), \"Code\", \"Chapter01);");
            WriteLine();
            WriteLine("10.) Where can you find information about NuGet packages and their dependencies?");
            WriteLine("nuget.org");
        }
    }
}
