using System;
using static System.Console;

namespace Exercise_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What happens when you divide an int variable by 0?");
            WriteLine("You get an DivideByZero exception.");
            WriteLine();
            WriteLine("2.) What happens when you divide a double variable by 0?");
            WriteLine("double.PositiveInfinity");
            WriteLine();
            WriteLine("3.) What happens when you overflow an int variable, that is, set it to a value beyond its range?");
            WriteLine("It wraps around to it's lowest value");
            WriteLine();
            WriteLine("4.) What is the difference between x = y++ and x = ++y?");
            WriteLine("The first is postfix and will result in x being assigned the value that y has, and then y will be incremented.");
            WriteLine("The second is prefix, and will result in y being incremented and then the value of y ais ssigned to x.");
            WriteLine();
            WriteLine("5.) What is the difference between break, continue, and return when used inside a loop statement?");
            WriteLine("break will break out from the loop, continue will go to conditional/start of the loop and return will return from the function it in.");
            WriteLine();
            WriteLine("6.) What are the three parts of a for statement and which of them are required?");
            WriteLine("Initialiser (optional), condition (optional), and iterator (optional).");
            WriteLine();
            WriteLine("7.) What is the difference between the = and == operators?");
            WriteLine("= is assignment and == is comparison");
            WriteLine();
            WriteLine("8.) Does the following statement compile? for ( ; true; ) ;");
            WriteLine("Yes.");
            WriteLine();
            WriteLine("9.) What does the underscore _ represent in a switch expression?");
            WriteLine("Default case.");
            WriteLine();
            WriteLine("10.) What interface must an object implement to be enumerated over by using foreach statement?");
            WriteLine("IEnumerable.");
        }
    }
}
