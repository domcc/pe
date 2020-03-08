using System;
using System.Collections.Generic;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Problem0010SummationOfPrimes
    {
        public long Solution1(int primesBelow)
        {
            long sum = 2;
            List<int> numbers = new List<int>(primesBelow + 1);
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            for (int i = 3; i <= primesBelow; i ++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add(-1);
                }
                else
                {
                    numbers.Add(i);
                }
            }

            int index = 3;
            int value = numbers[index];
            List<long> primes = new List<long>();
            while (index <= primesBelow)
            {
                value = numbers[index];
                if (value != -1)
                {
                    primes.Add(value);
                    for (long j = (long) Math.Pow(value, 2); j < numbers.Count; j = j + value)
                    {
                        if (j > 1999_999)
                        {
                            Console.WriteLine("");
                        }
                        numbers[(int)j] = -1;
                    }
                }

                index++;

            }

            foreach (int prime in primes)
            {
                sum += prime;
            }
            return sum;
        }
        
        private bool IsPrime(long l)
        {
            for (long i = 2; i < l; i++)
            {
                if( l % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}