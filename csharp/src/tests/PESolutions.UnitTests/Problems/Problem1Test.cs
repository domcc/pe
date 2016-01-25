using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem1Test
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem1 problem1 = new Problem1();
            Assert.AreEqual(23,problem1.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealSolution()
        {
            Problem1 problem1 = new Problem1();
            Assert.AreEqual(233168, problem1.Solution(1000));
        }

    }
}
