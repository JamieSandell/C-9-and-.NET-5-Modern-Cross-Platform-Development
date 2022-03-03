using System;
using static System.Console;

namespace Exercise_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What would happen if this code executes?");
            WriteLine("int max = 500;");
            WriteLine("for (byte i = 0; i < max; i++)");
            WriteLine("{");
            WriteLine("\tWriteLine(i);");
            WriteLine("}");
            WriteLine("You will end up in an infinite loop as the range for byte is 0 - 255, so it will overflow and wrap around to 0.");
            WriteLine("WriteLine");
            WriteLine("You could wrap it in a checked statement and have a try catch within that for the OverflowException");
        }
    }
}
