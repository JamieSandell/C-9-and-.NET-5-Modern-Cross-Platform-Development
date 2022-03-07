using Packt;
using System;
using static System.Console;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeFactorsLib = new PrimeFactorsLib();
            int start = 2;
            int end = 1000;
            for (int number = start; number <= end; ++number)
            {
                WriteLine(primeFactorsLib.PrimeFactors(number));
            }
        }
    }
}
