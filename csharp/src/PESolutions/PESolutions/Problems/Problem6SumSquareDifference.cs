using System;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2+2^2+...+10^2=385
    ///
    /// The square of the sum of the first ten natural numbers is,
    /// (1+2+...+10)^2=552=3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025−385=2640.
    ///
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Problem6SumSquareDifference
    {
        public long Solution(int nNumbers)
        {
            int number1 = 0;
            int number2 = 0;
            for (int i = 1; i <= nNumbers; i++)
            {
                number1 = number1 + (int)Math.Pow(i, 2);
                number2 = number2 + i;
            }

            number2 = (int)Math.Pow(number2, 2);
            return number2 - number1;
        }
    }
}