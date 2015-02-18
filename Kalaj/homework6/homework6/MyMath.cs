using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        //start result variable at 0
        public static decimal Result = 0;

        //create add function to support MyMathTests
        public decimal Add(decimal x, decimal y)
        {
            Result = x+y;
            return Result;
        }

        //create subtract function to support MyMathTest
        public decimal Subtract(decimal x, decimal y)
        {
            Result = x-y;
            return Result;
        }

        //create multiply function to support MyMathTest
        public static decimal Multiply(decimal x, decimal y)
        {
            Result = x*y;
            return Result;
        }

        //create divide function to support MyMathTest
        public static decimal Divide(decimal x, decimal y)
        {
            Result = x/y;
            //give an output rounded to three decimal places
            return Math.Round(Result, 3);
        }
    }
}
