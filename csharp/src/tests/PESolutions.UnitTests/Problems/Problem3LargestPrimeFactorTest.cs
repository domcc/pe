using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem3LargestPrimeFactorTest
    {
        [Test]
        public void LargestPrimeFactorTest1()
        {
            Problem3LargestPrimeFactor problem = new Problem3LargestPrimeFactor();
            Assert.AreEqual(29, problem.Solution(13195));
        }
        
        [Test]
        public void LargestPrimeFactorTest2()
        {
            Problem3LargestPrimeFactor problem = new Problem3LargestPrimeFactor();
            Assert.AreEqual(6857, problem.Solution(600851475143 ));
        }
    }
}