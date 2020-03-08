using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem0006SumSquareDifferenceTest
    {
        [Test]
        public void Problem6SumSquareDifferenceTest1()
        {
            Problem0006SumSquareDifference problem = new Problem0006SumSquareDifference();
            var solution = problem.Solution(10);
            Assert.AreEqual(2640, solution);
        }
        
        [Test]
        public void Problem6SumSquareDifferenceTest2()
        {
            Problem0006SumSquareDifference problem = new Problem0006SumSquareDifference();
            var solution = problem.Solution(100);
            Assert.AreEqual(25164150, solution);
        }
    }
}