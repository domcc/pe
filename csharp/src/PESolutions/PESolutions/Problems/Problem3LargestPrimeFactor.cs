using System;

namespace PESolutions.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem3LargestPrimeFactor
    {
        public long Solution(long number)
        {
            long largestPrimeFactor = 1;
            for (long i = 1; i < number; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine(i);
                }

                long result = number / i;
                // If largest factor is greater than result then there cant be any left to check
                // because the largestPrimeFactory * i will be larger than number
                if (largestPrimeFactor > result) {
                    return largestPrimeFactor;
                }
                
                // Is the i a factor of number 
                if (number % i == 0)
                {
                    // Only check factors for prime candidates
                    if (IsPrime(i))
                    {
                        largestPrimeFactor = i;
                    }
                }
            }

            return largestPrimeFactor;
        }


        private bool IsPrime(long l)
        {
            for (long i = 2; i < l; i++)
            {
                if (l % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}