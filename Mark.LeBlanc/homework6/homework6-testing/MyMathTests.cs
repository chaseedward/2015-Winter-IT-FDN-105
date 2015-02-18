using System;
using homework6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class MyMathTests
    {
        private MyMath myMath;

        [TestInitialize]
        public void Setup()
        {
            myMath = new MyMath();
        }

        // Fibonacci test 
        [TestMethod]
        public void TestFibonacci()
        {
            var result = fibonacci.Calc(9);
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void TestAdd()
        {
            var result = myMath.Add(16, 24);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var result = myMath.Subtract(16, 24);
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var result = MyMath.Multiply(16, 24);
            Assert.AreEqual(384, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            // When you divide 16/24 do you actually get .666666667?
            // Explain why this may not work.
            //
            // Once you do the cast to double on the integer division, the decimal
            // precision of the result is much longer than 3 decimal places. Unless You 
            // specifically apply rounding to 3 decimal places, the Assert will fail in this case.
            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }
    }
}
