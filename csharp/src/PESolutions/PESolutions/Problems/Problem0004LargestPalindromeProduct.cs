using System;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Problem0004LargestPalindromeProduct
    {
        public (int, int, int) Solution(int numberOfDigits)
        {
            long largestPrimeFactor = 1;
            byte [] digits = new byte[6];
            int largest = 0;
            int number1 = 0, number2 = 0;
            int start = (int) Math.Pow(10, numberOfDigits - 1);
            int end = (int) Math.Pow(10, numberOfDigits);
            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    int value = i * j;
                    int count = 0;
                    int value2 = value;
                    while (value2 > 0)
                    {
                        byte digit = (byte)(value2 % 10);
                        value2 = value2 / 10;
                        digits[count] = digit;
                        count++;
                    }

                    int reverse = 0;
                    for(int x = 0; x < count; x++)
                    {
                        reverse = digits[x] + (reverse * 10);
                    }

                    if (reverse == value && value > largest)
                    {
                        largest = value;
                        number1 = i;
                        number2 = j;
                    }
                }
            }

            return (largest, number1, number2);
        }
    }
}