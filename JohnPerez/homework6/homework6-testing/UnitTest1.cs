using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework6_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = homework6.fibonacci.Calc(9);
            Assert.AreEqual(21, result); //9th fibonacci is 21.
        }
    }
}
