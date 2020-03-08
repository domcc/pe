using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem5SmallestMultipleTest
    {
        [Test]
        public void Problem5SmallestMultipleTest1()
        {
            Problem5SmallestMultiple problem = new Problem5SmallestMultiple();
            var solution = problem.Solution(1, 10);
            Assert.AreEqual(2520, solution);
        }
        
        [Test]
        public void Problem5SmallestMultipleTest2()
        {
            Problem5SmallestMultiple problem = new Problem5SmallestMultiple();
            var solution = problem.Solution(1, 20);
            Assert.AreEqual(232792560, solution);
        }
    }
}