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

            //This does not work because when the Test runs, it Expects .667 and not .66666667.
            //May be we can tell the Test that the result will be .667. 

            // return (double) Math.Round(ValReturn, 3); 
            // the above line rounds the Decimals to 3 places giving you .667
            // This time the Test passes becauses it expects only 3 decimal places, I think???

            var result = MyMath.Divide(16, 24);
            Assert.AreEqual(.667, result);
        }

        [TestMethod]
        public void MyFibonacci()
        {
            var result = Fibonacci.Calc(9); // This retuns 21, 
            Assert.AreEqual(13, result);    //but if I changed the Cal(9) to Cal(8), then it retuns 13.
        } 
    }
}
