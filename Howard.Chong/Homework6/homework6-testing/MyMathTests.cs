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
            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);

            //I got 0.6666666a lot of 6 7 as the answer
            //This may not work because the Assert is set to equal .667 as the set number
            //But it doesn't account for rounding a repeating number up to .667
        }


        //Write a test to verifiy that fibonacci.Calc(9) is 13.
        [TestMethod]
        public void TestFibonacciCalc()
        {
            var result = fibonacci.Calc(9);
            Assert.AreEqual(13, result);
        }
        //Test results are negative.
    }
}
