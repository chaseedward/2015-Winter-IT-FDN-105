using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        public decimal Result = 0;
        
        public decimal Add(decimal num1, decimal num2)
        {
            Result = num1 + num2;
            return Result;   
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            Result = num1 - num2;
            return Result;   
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            Result = num1 * num2;
            return Result;   
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            Result = num1 / num2;
            return Result;  
        }
    }
}
