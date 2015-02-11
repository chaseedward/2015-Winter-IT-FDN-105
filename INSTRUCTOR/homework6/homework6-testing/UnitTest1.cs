using System;
using homework6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class UnitTest1
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
            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }
    }
}
