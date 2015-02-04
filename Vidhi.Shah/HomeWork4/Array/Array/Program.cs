using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int i;
            int max = 0, min = 0;

            int lengthofarray = numbers.Length;

          

            for (i = 0; i < lengthofarray; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("Maximum number in the array is {0}", max);
            Console.WriteLine("Minimum number in the array is {0}", min);

            Console.ReadLine();
        }
    }
}
