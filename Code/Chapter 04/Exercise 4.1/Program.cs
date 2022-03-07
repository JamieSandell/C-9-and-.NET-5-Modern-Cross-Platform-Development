using System;
using static System.Console;

namespace Exercise_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What does the C# keyword void mean?");
            WriteLine("Denotes nothing, such as when it is the return type for a function, the function returns nothing");
            WriteLine();
            WriteLine("2.) What are some differences between imperative and functional programming styles?");
            WriteLine("Imperative = code that specifies the steps that the computer must take to accomplish the goal.");
            WriteLine("Functional = composing the problem as a set of functions to be executed");
            WriteLine("3.) In Visual Studio Code, what is the difference between pressing:");
            WriteLine("F5,");
            WriteLine("Ctrl or Cmd + F5,");
            WriteLine("Shift + F5");
            WriteLine("Ctrl or Cmd + Shift + F5");
            WriteLine("F5 = Run with debugging");
            WriteLine("Shift + F5 = Stop debugging");
            WriteLine("Ctrl or Cmd + Shift + F5 = Terminates the current debugging session, rebuilds if necessary, and then starts a new debugging session.");
            WriteLine();
            WriteLine("4.) Where does the Trace.WriteLine method write its output to?");
            WriteLine("Debug console by default, but you can specify a file");
            WriteLine();
            WriteLine("5.) What are the five trace levels?");
            WriteLine("Error, Info, Off, Verbose, Warning");
            WriteLine();
            WriteLine("6.) What is the difference between Debug and Trace?");
            WriteLine("Debug will only output statements in the debug build, trace output statemenets will output in debug and release builds.");
            WriteLine("");
            WriteLine("7.) When writing a unit test, what are the three As?");
            WriteLine("Arrange, act, and assert");
            WriteLine("");
            WriteLine("8.) When writing a unit test using xUnit, what attribute must you decorate the test methods with?");
            WriteLine("[Fact]");
            WriteLine();
            WriteLine("9.) What dotnet command executes xUnit tests?");
            WriteLine("dotnet test");
            WriteLine();
            WriteLine("10.) What is TDD?");
            WriteLine("Test driven development.");
        }
    }
}
