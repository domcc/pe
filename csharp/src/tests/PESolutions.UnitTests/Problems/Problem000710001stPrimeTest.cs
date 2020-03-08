using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem000710001stPrimeTest
    {
        [Test]
        public void Problem710001stPrimeTest1()
        {
            Problem000710001stPrime problem = new Problem000710001stPrime();
            var solution = problem.Solution(6);
            Assert.AreEqual(13, solution);
        }
        
        [Test]
        public void Problem710001stPrimeTest2()
        {
            Problem000710001stPrime problem = new Problem000710001stPrime();
            var solution = problem.Solution(10001);
            Assert.AreEqual(104743, solution);
        }
    }
}