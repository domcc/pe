using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    [TestFixture]
    public class Problem2Test
    {
        [Test]
        public void TestSolution1WithSampleData()
        {
            Problem2 problem1 = new Problem2();
            Assert.AreEqual(10, problem1.Solution(10));
        }

        [Test]
        public void TestSolution1WithRealData()
        {
            Problem2 problem1 = new Problem2();
            Assert.AreEqual(4613732, problem1.Solution(4000000));
        }
    }
}
