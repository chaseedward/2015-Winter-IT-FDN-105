using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class FibonacciTest
    {
        private fibonacci fibonacci;

        [TestInitialize]
        public void Setup()
        {
            fibonacci = new fibonacci();
        }

        [TestMethod]
        public void TestCalc()
        {
            var value = fibonacci.Calc(9);
            Assert.AreEqual(21, value);
        }
    }
}
