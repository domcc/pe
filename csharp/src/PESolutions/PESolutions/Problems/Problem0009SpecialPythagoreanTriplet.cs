using System;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which
    ///
    /// a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    ///
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Problem0009SpecialPythagoreanTriplet
    {
        public (int a, int b, int c, int product) Solution1(int sum)
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c,2) && a + b + c == sum)
                        {
                            return (a, b, c, a * b * c);
                        }
                    }
                }
            }

            return (-1, -1, -1, -1);
        }
        public long Solution2()
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return -1;
        }
    }
}