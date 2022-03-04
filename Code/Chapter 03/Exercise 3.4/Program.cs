/* Ask the user for two numbers in the range 0-255 and then divides the first number by the second.
    Write exception handlers to catch any thrown errors, as showing in the following output:
    
    Enter a number between 0 and 255: apples
    Enter another number between 0 and 255: bananas
    FormatException: Input string was not in the correct format. */

using System;
using static System.Console;

namespace Exercise_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 255;
            Write($"Enter a number between {min} and {max}: ");
            string input1 = ReadLine();
            Write($"Enter another number between {min} and {max}: ");
            string input2 = ReadLine();
            checked
            {                
                try
                {
                    int number1 = int.Parse(input1);
                    int number2 = int.Parse(input2);
                    if (number1 < min || number1 > max || number2 < min || number2 > max)
                    {
                        WriteLine($"The input {number1} and {number2} is outside of {min}-{max}");
                        return;
                    }
                    WriteLine($"{number1} / {number2} = {number1 / number2}");
                }
                catch(FormatException)
                {
                    WriteLine("FormatException: Input string was not in the correct format.");
                }
                catch(OverflowException)
                {
                    WriteLine($"The input {input1} or {input2} was out of bounds of {int.MinValue}-{int.MaxValue}");
                }
                catch(DivideByZeroException)
                {
                    WriteLine($"Divide by zero exception caught.");
                }
            }
        }
    }
}
