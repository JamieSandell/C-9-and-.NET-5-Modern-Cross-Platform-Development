using System;
using static System.Console;

namespace Exercise_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What are the values of x and y after the following statements execute?");
            WriteLine();
            WriteLine("1.) x = 3;y = 2 + ++x;");
            WriteLine("x = 4, y = 6");
            WriteLine("");
            WriteLine("2.) x = 3 << 2;y = 10 >> 1, {3 << 2}, {10 >> 1}");
            WriteLine("x = 12, y = 5");
            WriteLine("");
            WriteLine("3.)x = 10 & 8; y = 10 | 7;");
            WriteLine("x = 8, y = 15");
        }
    }
}
