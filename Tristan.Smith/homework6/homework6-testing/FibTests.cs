using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibTest()
        {
            var result = homework6.fibonacci.Calc(9);

            // This test does not work because the 9th fibonacci number is actually
            // 21, not 13 (using 0 as the first number).  However, this is the test that you
            // asked for...

            Assert.AreEqual(13, result);
        }
        [TestMethod]
        public void RealFibTest()
        {
            var result = homework6.fibonacci.Calc(9);
            Assert.AreEqual(21, result);
        }
    }
}
