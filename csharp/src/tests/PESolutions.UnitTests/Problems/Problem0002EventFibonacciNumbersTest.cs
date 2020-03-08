using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem0002EventFibonacciNumbersTest
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem0002EvenFibonacciNumbers problem1 = new Problem0002EvenFibonacciNumbers();
            Assert.AreEqual(10, problem1.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealData()
        {
            Problem0002EvenFibonacciNumbers problem1 = new Problem0002EvenFibonacciNumbers();
            Assert.AreEqual(4613732, problem1.Solution(4000000));
        }
    }
}
