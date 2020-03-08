using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem8LargestProductInASeriesTest
    {
        [Test]
        public void Problem8LargestProductInASeriesTest1()
        {
            Problem8LargestProductInASeries problem = new Problem8LargestProductInASeries();
            var solution = problem.Solution(4);
            Assert.AreEqual(5832, solution);
        }
        
        [Test]
        public void Problem8LargestProductInASeriesTest2()
        {
            Problem8LargestProductInASeries problem = new Problem8LargestProductInASeries();
            var solution = problem.Solution(13);
            Assert.AreEqual(23514624000, solution);
        }
    }
}