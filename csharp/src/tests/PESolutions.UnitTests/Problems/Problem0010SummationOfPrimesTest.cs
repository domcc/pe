using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem0010SummationOfPrimesTest
    {
        [Test]
        public void Problem10SummationOfPrimesTest1()
        {
            Problem0010SummationOfPrimes problem = new Problem0010SummationOfPrimes();
            var solution = problem.Solution1(10);
            Assert.AreEqual(17, solution);
        }
        
        [Test]
        public void Problem10SummationOfPrimesTest2()
        {
            Problem0010SummationOfPrimes problem = new Problem0010SummationOfPrimes();
            var solution = problem.Solution1(2_000_000);
            Assert.AreEqual(142913828922, solution);
        }
    }
}