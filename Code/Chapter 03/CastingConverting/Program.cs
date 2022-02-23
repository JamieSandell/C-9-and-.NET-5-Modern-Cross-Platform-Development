using System;
using static System.Console;
using static System.Convert;
using System.IO;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // Implicit cast, int can safely be cast to a double.
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // Explicit cast, could (and in this instance will) lose information.
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g); // Converting will round up here to 10 (if g is 9.8), whereas casting will output 9.
            WriteLine($"g is {g} and h is {h}");

            double[] doubles = new[] {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};
            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}"); // Banker's Rounding
            }

            foreach(double n in doubles)
            {
                WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                            arg0: n,
                            arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
            }

            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            byte[] binaryObject = new byte[128]; // allocate array of 128 bytes
            (new Random()).NextBytes(binaryObject); // populate array with random bytes
            WriteLine("Binary Object as bytes:");
            for (int index = 0; index <binaryObject.Length; ++index)
            {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();
            string encoded = Convert.ToBase64String(binaryObject); // convert to Base64 string and output as text
            WriteLine($"Binary Object as Base64: {encoded}");
        }
    }
}