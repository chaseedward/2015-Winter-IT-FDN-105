using System;
using homework6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class MyMathTests
    {
        private MyMath myMath;
        private fibonacci myFibonacci;

        [TestInitialize]
        public void Setup()
        {
            myMath = new MyMath();
            myFibonacci = new fibonacci();
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
            var result = myMath.Multiply(16, 24);
            Assert.AreEqual(384, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            // When you divide 16/24 do you actually get .666666667?
            // Explain why this may not work.
            // my function casts the division quotient to decimal to get decimal numbers
            // my function rounds decimal to 3 places to get .667
            var result = myMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            // Fibonacci number of 9 = 21
            // Fibonacci number of 8 = 13
            var result8 = fibonacci.Calc(8);
            var result9 = fibonacci.Calc(9);
            Assert.AreEqual(13, result8);
            Assert.AreEqual(21, result9);
        }
    }
}
