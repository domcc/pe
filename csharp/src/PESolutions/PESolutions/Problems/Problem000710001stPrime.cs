using System;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    ///
    /// What is the 10 001st prime number?
    /// </summary>
    public class Problem000710001stPrime
    {
        public long Solution(int nthPrime)
        {
            int primeCount = 0;
            int i = 2;
            int lastPrime = 0;
            while (primeCount != nthPrime)
            {
                if (IsPrime(i))
                {
                    primeCount++;
                    lastPrime = i;
                }

                i++;
            }

            return lastPrime;
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