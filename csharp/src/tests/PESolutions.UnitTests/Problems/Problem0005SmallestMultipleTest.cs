using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem0005SmallestMultipleTest
    {
        [Test]
        public void Problem5SmallestMultipleTest1()
        {
            Problem0005SmallestMultiple problem = new Problem0005SmallestMultiple();
            var solution = problem.Solution(1, 10);
            Assert.AreEqual(2520, solution);
        }
        
        [Test]
        public void Problem5SmallestMultipleTest2()
        {
            Problem0005SmallestMultiple problem = new Problem0005SmallestMultiple();
            var solution = problem.Solution(1, 20);
            Assert.AreEqual(232792560, solution);
        }
    }
}