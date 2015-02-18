using System;
using homework6_fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing_fibonacci
{
    [TestClass]
    public class MyFibonacciTests
    {
        private Fibonacci _myFibonacci;

        [TestInitialize]
        public void Setup()
        {
            _myFibonacci = new Fibonacci();
        }

        [TestMethod]
        public void TestCalc()
        {
            var result = _myFibonacci.Calc(9);
            Assert.AreEqual(21, result);
        }
    }
}