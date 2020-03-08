using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem0001MultiplesOf3And5Test
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem0001MultiplesOf3And5 problem0001MultiplesOf3And5 = new Problem0001MultiplesOf3And5();
            Assert.AreEqual(23,problem0001MultiplesOf3And5.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealSolution()
        {
            Problem0001MultiplesOf3And5 problem0001MultiplesOf3And5 = new Problem0001MultiplesOf3And5();
            Assert.AreEqual(233168, problem0001MultiplesOf3And5.Solution(1000));
        }

    }
}
