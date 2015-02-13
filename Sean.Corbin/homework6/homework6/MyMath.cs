//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        public decimal Result=0;
        public decimal Add(decimal n1, decimal n2)
        {
            Result=n1+n2;
            return Result;
        }
        public decimal Subtract(decimal n1, decimal n2)
        {
            Result=n1-n2;
            return Result;
        }
        public decimal Multiply(decimal n1, decimal n2)
        {
            Result=n1*n2;
            return Result;
        }
        public decimal Divide(decimal n1, decimal n2)
        {
            Result=n1 / n2;
            return Result;
        }
    }
}