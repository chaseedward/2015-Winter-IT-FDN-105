﻿using System;
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
            var result = myMath.Multiply(16, 24);
            Assert.AreEqual(384, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            // When you divide 16/24 do you actually get .666666667?
            // Explain why this may not work.
            //
            // I changed the test parameter to round the number instead of the operation
            // because that allows the Divide method to be more faithful to actual
            // division.  But...it still does seem to get weird at the end of the
            // 6's when you don't do any rounding.  Probably a vagary of the float
            // variable...   -- Tristan
            //
            var result = myMath.Divide(16, 24);
            Assert.AreEqual(.667, Math.Round(result,3,MidpointRounding.AwayFromZero));
        }
    }
}
