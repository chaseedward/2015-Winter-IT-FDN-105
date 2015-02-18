//Eric Vernon

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath
    {
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;   
        }

        public static decimal Subtract(decimal num1, decimal num2)
        {
            //don't know why this needs to be static but Add doesn't
            return num1 - num2; 
        }

        public static decimal Multiply(decimal num1, decimal num2)
        {
            //don't know why this needs to be static but Add doesn't
            return num1 * num2;
        }

        public static decimal Divide(decimal num1, decimal num2)
        {
            //don't know why this needs to be static but Add doesn't
            return Decimal.Round(num1/num2, 3);
        }
    }
}
