using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework6_fibonacci
{
    public class Fibonacci
    {
        // 0 1 1 2 3 5 8 13 21 ...
        public int Calc(int len)
        {
            var value = 0;
            var a = 0;
            var b = 1;

            // Where do these WriteLines show up?
            Console.WriteLine(0);
            if (len == 0 || len == 1)
            {
                return 0;
            }

            Console.WriteLine(1);
            if (len == 2)
            {
                return 1;
            }

            len -= 2;

            for (var count = 0; count < len; count++)
            {
                value = a + b;
                Console.WriteLine(value);
                a = b;
                b = value;
            }

            return value;
        }
    }
}
