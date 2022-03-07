/* 
Prime factors are the combination of the smallest prime numbers
that, when multiplied together, will produce the original number.
Consider the following example:

Prime factors of 4 are: 2 x 2
Prime factors of 7 are: 7
Prime factors of 30 are: 5 x 3 x 2
Prime factors of 40 are: 5 x 2 x 2 x 2
Prime factor of 50 are: 5 x 5 x 2

Class library with a method named PrimeFactors that, when
passed an int variable as a parameter, returns a string showing its
prime factors.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Packt
{
    public class PrimeFactorsLib
    {
        public string PrimeFactors(int number)
        {
            int cacheNumber = number;
            if (number < 1)
            {
                return $"{number} has no prime factors";
            }
            var primes = new List<int>();
            for (int div = 2; 2 <= number; ++div)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;
                }
            }
            number = cacheNumber;
            if (primes.Count == 1)
            {
                return $"Prime factors of {number} are: {number}";
            }
            var sb = new StringBuilder($"Prime factors of {number} are: ");
            for (int index = 0; index < primes.Count - 1; ++index)
            {
                sb.Append($"{primes[index]} x ");
            }
            sb.Append(primes[primes.Count - 1].ToString());
            return sb.ToString();
        }
    }
}
