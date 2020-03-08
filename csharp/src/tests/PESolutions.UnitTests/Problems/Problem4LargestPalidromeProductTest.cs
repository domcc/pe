using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem4LargestPalindromeProductTest
    {
        [Test]
        public void Problem4LargestPalindromeProductTest1()
        {
            Problem4LargestPalindromeProduct problem = new Problem4LargestPalindromeProduct();
            var solution = problem.Solution(2);
            Assert.AreEqual(9009, solution.Item1);
            Assert.AreEqual(91, solution.Item2);
            Assert.AreEqual(99, solution.Item3);
        }
        
        [Test]
        public void Problem4LargestPalindromeProductTest2()
        {
            Problem4LargestPalindromeProduct problem = new Problem4LargestPalindromeProduct();
            var solution = problem.Solution(3);
            Assert.AreEqual(906609, solution.Item1);
            Assert.AreEqual(913, solution.Item2);
            Assert.AreEqual(993, solution.Item3);
        }
    }
}