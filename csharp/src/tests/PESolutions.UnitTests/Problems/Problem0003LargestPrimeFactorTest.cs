using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem0003LargestPrimeFactorTest
    {
        [Test]
        public void LargestPrimeFactorTest1()
        {
            Problem0003LargestPrimeFactor problem = new Problem0003LargestPrimeFactor();
            Assert.AreEqual(29, problem.Solution(13195));
        }
        
        [Test]
        public void LargestPrimeFactorTest2()
        {
            Problem0003LargestPrimeFactor problem = new Problem0003LargestPrimeFactor();
            Assert.AreEqual(6857, problem.Solution(600851475143 ));
        }
    }
}