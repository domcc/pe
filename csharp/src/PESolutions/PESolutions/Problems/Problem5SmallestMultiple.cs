using System;
using System.Linq;

namespace PESolutions.Problems
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem5SmallestMultiple
    {
        public long Solution(int start, int end)
        {
            long i = 1;
            while (true)
            {
                bool found = true;
                for (int j = start; j <= end; j++)
                {
                    if (i % j != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return i;
                }

                i++;
            }
        }
    }
}