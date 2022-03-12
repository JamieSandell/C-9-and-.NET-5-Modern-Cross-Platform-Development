using System;
using static System.Console;

namespace Exercise_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What is a delegate?");
            WriteLine("A delegate is like a function pointer in languages such as C that support it. It safely encapsulates a method, and has a built-in iterator");
            WriteLine();
            WriteLine("2.) What is an event?");
            WriteLine("A message sent by an object to signal the occurence of an action, e.g. OnMouseClick.");
            WriteLine();
            WriteLine("3.) How are a base class and a derived class related and how can the derived class access the base class?");
            WriteLine("A derived class inherits from a base class, and it has access to all the non-private members.");
            WriteLine();
            WriteLine("4.) What is the difference between the is and as operators?");
            WriteLine("The is operator checks to see if the object is of a type. The as operator attempts a safe conversion and returns null if it fails");
            WriteLine();
            WriteLine("5.) Which keyword is used to prevent a class from being derived from or a method from being further overridden?");
            WriteLine("Sealed.");
            WriteLine();
            WriteLine("6.) Which keyword is used to prevent a class from being instantiated with the new keyword?");
            WriteLine("Static.");
            WriteLine();
            WriteLine("7.) Which keyword is used to allow a member to be overridden?");
            WriteLine("Virtual.");
            WriteLine();
            WriteLine("8.) What's the difference between a destructor and a deconstruct method?");
            WriteLine("A destructor is called when an instance of an object is destroyed. A deconstruct method splits a variable value into parts and stores them in new variables.");;
            WriteLine();
            WriteLine("9.) What are the signatures of the constructors that all exceptions should have?");
            WriteLine("public CustomException() : base()");
            WriteLine("public CustomException(string message) : base(message)");
            WriteLine("public CustomException(string message, Exception innerException) : base(message, innerException)");
            WriteLine();
            WriteLine("10.) What is an extension method, and how do you write one?");
            WriteLine("They allow you to \"add\" to existing types without creating a new type, e.g. when a class is sealed.");
            WriteLine("Create a static class, add a static method that has a member variable of the type preceeded by the this keyword, e.g.");
            WriteLine("public static bool IsValidEmail(this string input)");
            WriteLine();
        }
    }
}
