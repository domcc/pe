using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem0008LargestProductInASeriesTest
    {
        [Test]
        public void Problem8LargestProductInASeriesTest1()
        {
            Problem0008LargestProductInASeries problem = new Problem0008LargestProductInASeries();
            var solution = problem.Solution(4);
            Assert.AreEqual(5832, solution);
        }
        
        [Test]
        public void Problem8LargestProductInASeriesTest2()
        {
            Problem0008LargestProductInASeries problem = new Problem0008LargestProductInASeries();
            var solution = problem.Solution(13);
            Assert.AreEqual(23514624000, solution);
        }
    }
}