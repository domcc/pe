﻿namespace PESolutions.Problems
{
    /// <summary>
    /// Multiples of 3 and 5
    /// <remarks>If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </remarks>
    /// </summary>
    public class Problem0001MultiplesOf3And5
    {
        public int Solution(int number)
        {
            int result = 0;
            for (int i = 1; i < number; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    result += i;
                }
            }
            return result;


        }
    }
}
