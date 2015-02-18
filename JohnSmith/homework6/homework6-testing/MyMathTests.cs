using System;
using homework6_fibonacci;
using homework6_myMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class MyMathTests
    {
        private MyMath _myMath;

        [TestInitialize]
        public void Setup()
        {
            _myMath = new MyMath();
        }

        [TestMethod]
        public void TestAdd()
        {
            var result = _myMath.Add(16, 24);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var result = _myMath.Subtract(16, 24);
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var result = _myMath.Multiply(16, 24);
            Assert.AreEqual(384, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            // When you divide 16/24 do you actually get .666666667?
            // Explain why this may not work.
            var result = _myMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }
    }

    public class MyFibonacciTests
    {
        private Fibonacci _myFibonacci;

        [TestInitialize]
        public void Setup()
        {
            _myFibonacci = new Fibonacci();
        }

        [TestMethod]
        public void TestAdd()
        {
            var result = _myFibonacci.Calc(9);
            Assert.AreEqual(21, result);
        }
    }
}
