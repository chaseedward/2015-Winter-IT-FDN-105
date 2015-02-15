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

        //test that fibonacci.Calc(9) is 13
        //TODO: Figure out why it's 21 instead of 13
        [TestMethod]
        public void TestFibonacci()
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
           //Answer: Would need to round output to 3 decimals.
           //Issue: I'm able to get .667, but it's a decimal instead of the "expected double"
            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }

    }
}
