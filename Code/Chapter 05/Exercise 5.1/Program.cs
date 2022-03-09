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
            
        }
    }
}
