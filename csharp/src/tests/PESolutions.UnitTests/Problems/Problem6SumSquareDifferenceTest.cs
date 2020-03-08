using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem6SumSquareDifferenceTest
    {
        [Test]
        public void Problem6SumSquareDifferenceTest1()
        {
            Problem6SumSquareDifference problem = new Problem6SumSquareDifference();
            var solution = problem.Solution(10);
            Assert.AreEqual(2640, solution);
        }
        
        [Test]
        public void Problem6SumSquareDifferenceTest2()
        {
            Problem6SumSquareDifference problem = new Problem6SumSquareDifference();
            var solution = problem.Solution(100);
            Assert.AreEqual(25164150, solution);
        }
    }
}