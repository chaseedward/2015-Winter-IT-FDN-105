using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        public static decimal result;

        public decimal Add(decimal i, decimal i1)
        {
            result = i + i1;
            return result;
        }

        public decimal Subtract(decimal i, decimal i1)
        {
            result = i - i1;
            return result;
        }

        public static decimal Multiply(decimal i, decimal i1)
        {
            result = i * i1;
            return result;
        }

        public static decimal Divide(decimal i, decimal i1)
        {
            result = Math.Round(i/i1, 3);
            return result;
            //This test fails because the true value is not .667. Although, I'm somewhat
            //confused as to why round function doesn't fix it. Does Round() not actually remove 
            // the extra decimal places??
        }
    }
}
