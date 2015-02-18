using homework6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        /* test that fibonacci.Calc(9) is 13
         * Result: fibonacci.cal(9) is 21. Not 13. 
         Would have to change to fibonacci.Calc(8) */

        [TestMethod]

        public void TestFibo()
        {
            var result = fibonacci.Calc(9);
            Assert.AreEqual(13, result);
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
            // Likely because of a type mismatch? Also despite rounding the test still fails, depends on the type of number.
            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }
    }
}