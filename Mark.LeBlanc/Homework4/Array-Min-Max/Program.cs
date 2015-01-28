using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {5, -2, 100, 12, 4, -5};
            //var array = new int[] { -32, 88, 909, 5, -2, 562, 79, -777, 321, 200, 100, 12, 1100, 333, 4, -5 };

            int max, min; //Min, max value variables

            min = max = array[0]; //Inititalize to first value in array

            //Iterate over array and do comparisons
            foreach (int x in array)
            {
                if (x > max)
                {
                    max = x;
                }

                if (x < min)
                {
                    min = x;
                }
            }

            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);

            Console.ReadLine();
        }
    }
}
