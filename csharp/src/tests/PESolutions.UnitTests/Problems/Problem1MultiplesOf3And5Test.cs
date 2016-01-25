using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem1MultiplesOf3And5Test
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem1MultiplesOf3And5 problem1MultiplesOf3And5 = new Problem1MultiplesOf3And5();
            Assert.AreEqual(23,problem1MultiplesOf3And5.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealSolution()
        {
            Problem1MultiplesOf3And5 problem1MultiplesOf3And5 = new Problem1MultiplesOf3And5();
            Assert.AreEqual(233168, problem1MultiplesOf3And5.Solution(1000));
        }

    }
}
