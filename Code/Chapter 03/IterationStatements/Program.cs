using System;
using static System.Console;
using System.IO;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;
            int attempt = 0;
            int maxAttempt = 10;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempt++;
                if (attempt >= maxAttempt)
                {
                    Write("Locked out, too many attempts!");
                    return;
                }
            }
            while (password != "Pa$$w0rd");
            WriteLine("Correct!");

            for (int y = 1; y <= 10; ++y)
            {
                WriteLine(y);
            }

            string[] names = {"Adam", "Barry", "Larry"};
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}