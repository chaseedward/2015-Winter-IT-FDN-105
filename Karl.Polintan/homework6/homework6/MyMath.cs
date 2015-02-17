using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        //start at 0
        public static decimal Result = 0;

        //Add
        public decimal Add(decimal x, decimal y)
        {
            Result = x + y;
            return Result;
        }

        //Subtract
        public decimal Subtract(decimal x, decimal y)
        {
            Result = x - y;
            return Result;
        }

        //Multiply
        public static decimal Multiply(decimal x, decimal y)
        {
            Result = x * y;
            return Result;
        }

        //Divide
        public static decimal Divide(decimal x, decimal y)
        {
            Result = x / y;
            return Math.Round(Result, 3);
        }
    }
}