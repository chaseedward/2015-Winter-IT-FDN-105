using System;

namespace homework6
{
    public class MyMath
    {
        public static decimal ValReturn;
        public double Add(decimal a, decimal b)
        {
            ValReturn = a + b;
            return (double) ValReturn;
        }

        public double Subtract(decimal a, decimal b)
        {
            ValReturn = a - b;
            return (double) ValReturn;
        }

        public static double Multiply( decimal a, decimal b)
        {
            ValReturn = a * b;
            return (double)ValReturn;  
        }

        public static double Divide(double a, double b)
        {
            ValReturn = (decimal) (a/b);
            return (double) Math.Round(ValReturn, 3);
        }
    }
}
