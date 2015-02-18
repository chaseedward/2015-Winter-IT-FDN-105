using System;

namespace homework6
{
    public class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public double Divide(int a, int b)
        {
            decimal quotient = ((decimal) a / b);
            quotient = decimal.Round(quotient, 3);
            return (double) quotient;
        }
    }
}