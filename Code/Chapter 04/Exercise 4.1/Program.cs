using System;
using static System.Console;

namespace Exercise_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.) What does the C# keyword void mean?");
            Console.WriteLine("Denotes nothing, such as when it is the return type for a function, the function returns nothing");
            Console.WriteLine();
            Console.WriteLine("2.) What are some differences between imperative and functional programming styles?");
            Console.WriteLine("Imperative = code that specifies the steps that the computer must take to accomplish the goal.");
            Console.WriteLine("Functional = composing the problem as a set of functions to be executed");
            Console.WriteLine("3.) In Visual Studio Code, what is the difference between pressing:");
            Console.WriteLine("F5,");
            Console.WriteLine("Ctrl or Cmd + F5,");
            Console.WriteLine("Shift + F5");
            Console.WriteLine("Ctrl or Cmd + Shift + F5");
            Console.WriteLine("F5 = Run with debugging");
            Console.WriteLine("Shift + F5 = Stop debugging");
            Console.WriteLine("Ctrl or Cmd + Shift + F5 = Terminates the current debugging session, rebuilds if necessary, and then starts a new debugging session.");
            Console.WriteLine();
            Console.WriteLine("4.) Where does the Trace.WriteLine method write its output to?");
            Console.WriteLine("Debug console by default, but you can specify a file");
            Console.WriteLine();
            Console.WriteLine("5.) What are the five trace levels?");
            Console.WriteLine("Error, Info, Off, Verbose, Warning");
            Console.WriteLine();
        }
    }
}
