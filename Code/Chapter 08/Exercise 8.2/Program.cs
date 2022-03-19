/*
Create a console application that prompts the user to
enter a regular expression, and then prompts the user to enter some input
and compare the two for a match until the user presses Esc, as shown in the
following output:

The default regular expression checks for at least one digit.
Enter a regular expression (or press ENTER to use the 
default): ^[a-z]+$
Enter some input: apples
apples matches ^[a-z]+$? True
Press ESC to end or any key to try again.
Enter a regular expression (or press ENTER to use the
default): ^[a-z]+$
Enter some input: abc123xyz
abc123xyz matches ^[a-z]+$? False
Press ESC to end or any key to try again.
*/

using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Exercise_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("The default regular expression checks for at least one digit.");
            const string defaultRegularExpressionString = "^[a-z]+$";
            do
            {
                WriteLine("Enter a regular expression (or press ENTER to use the default): ^[a-z]+$");
                string input = ReadLine();
                Regex regex = new Regex(input);
            } while(ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
