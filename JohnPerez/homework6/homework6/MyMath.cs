using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyMath //create class for unit test class to reference to
    {
        public decimal Add(int x, int y)
        {
            return x + y;
        }

        public decimal Subtract(int x, int y)
        {
            return x - y;
        }

        public decimal Multiply(int x, int y)
        {
            return x * y;
        }

        public decimal Divide(int x, int y)  
        {
           decimal result = x / y;
           result = decimal.Round(result, 3); //trying to round to the nearest thousandth for unit test to pass
           return result;
        }

    }
}
