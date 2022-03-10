using System;
using static System.Console;

namespace Exercise_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What are the six combinations of access modifier keywords and what do they do?");
            WriteLine("Private - only accessible within the class or structure.");
            WriteLine("Public - no access restricitons.");
            WriteLine("Protected - accessible from within the class and any derived classes.");
            WriteLine("Internal - (default) accessible from within its own assembly.");
            WriteLine("Protected internal - same as internal plus any derived classes within the assembly.");
            WriteLine("Private protected - Same as private, but only from within the same assembly");
            WriteLine();
            WriteLine("2.) What is the difference between static, const, and readonly keywords when applied to a type member?");
            WriteLine("Static - Becomes a fixed, shared, part of the class, e.g. static int numberOfUsers = 1;");
            WriteLine("Const - a non-changing part of the class, e.g. static float PI = 3.14f;");
            WriteLine("Readonly - immutable, but can be set at initialisation.");
            WriteLine();
            WriteLine("3.) What does a constructor do?");
            WriteLine("It is called when a new instance of an object is created.");
            WriteLine("4.) Why should you apply the [Flags] attribute to an enum type when you want to store combined values?");
            WriteLine("It allows you to treat the enum as a bit field, e.g. Enum Colours favouriteColours = Colours.Red | Colours.Blue;");
            WriteLine();
            WriteLine("5.) Why is the partial keyword useful?");
            WriteLine("For big classes / shared projects, where it's useful to split a class over multiple files.");
            WriteLine();
            WriteLine("6.) What is a tuple?");
            WriteLine("Used to store multiple items in a single variable.");
            WriteLine();
            WriteLine("7.) - What does the C# record keyword do?");
            WriteLine("Creates an immutable type that provide non-destructive mutation.");
            WriteLine();
            WriteLine("8.) What does Overloading mean?");
            WriteLine("Having the same function name with different signatures.");
            WriteLine();
            WriteLine("9.) What is the difference between a field and a property?");
            WriteLine("A private field would require public getters and setters, where as an auto-property does not, although they're created behind the scenes along with a pirvate backed field for you.");
            WriteLine();
            WriteLine("10.) How do you make a method parameter optional?");
            WriteLine("void UpdateInfo(string name, int age = 21); age is the optional parameter");
            WriteLine();
        }
    }
}
