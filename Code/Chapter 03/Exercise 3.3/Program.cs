// Write a simulated FizzBuzz game that goes up to 100.

using System;
using static System.Console;

namespace Exercise_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int fizz = 3;
            int buzz = 5;

            for (int number = start; number <= end; ++number)
            {
                if (number % fizz == 0 && number % buzz == 0)
                {
                    Write("FizzBuzz ");
                }
                else if (number % fizz == 0)
                {
                    Write("Fizz ");
                }
                else if (number % buzz == 0)
                {
                    Write("Buzz ");
                }
                else
                {
                    Write($"{number} ");
                }
            }
        }
    }
}
