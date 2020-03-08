using NUnit.Framework;
using PESolutions.Problems;

namespace PESolutions.UnitTests.Problems
{
    public class Problem9SpecialPythagoreanTripletTest
    {
        [Test]
        public void Problem9SpecialPythagoreanTripletTest1()
        {
            Problem9SpecialPythagoreanTriplet problem = new Problem9SpecialPythagoreanTriplet();
            var solution = problem.Solution1(12);
            Assert.AreEqual(3, solution.a);
            Assert.AreEqual(4, solution.b);
            Assert.AreEqual(5, solution.c);
            Assert.AreEqual(60, solution.product);
        }
        
        [Test]
        public void Problem9SpecialPythagoreanTripletTest2()
        {
            Problem9SpecialPythagoreanTriplet problem = new Problem9SpecialPythagoreanTriplet();
            var solution = problem.Solution1(1000);
            Assert.AreEqual(200, solution.a);
            Assert.AreEqual(375, solution.b);
            Assert.AreEqual(425, solution.c);
            Assert.AreEqual(31875000, solution.product);
        }
    }
}