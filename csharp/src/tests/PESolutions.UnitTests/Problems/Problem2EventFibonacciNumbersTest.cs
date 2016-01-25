using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem2EventFibonacciNumbersTest
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem2EvenFibonacciNumbers problem1 = new Problem2EvenFibonacciNumbers();
            Assert.AreEqual(10, problem1.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealData()
        {
            Problem2EvenFibonacciNumbers problem1 = new Problem2EvenFibonacciNumbers();
            Assert.AreEqual(4613732, problem1.Solution(4000000));
        }
    }
}
