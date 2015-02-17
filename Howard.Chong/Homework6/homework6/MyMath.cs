using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        // Result set to 0
        public static decimal Result = 0;

        public decimal Add(decimal I, decimal J)
        {
            Result = I + J;
            return Result;
        }

        public decimal Subtract(decimal I, decimal J)
        {
            Result = I - J;
            return Result;
        }

        public static decimal Multiply(decimal I, decimal J)
        {
            Result = I*J;
            return Result;
        }

        public static decimal Divide(decimal I, decimal J)
        {
            Result = I/J;
            return Result;
        }
    }
}