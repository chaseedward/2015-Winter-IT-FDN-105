using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{5, -2, 100, 12, 4, -5};
            int min = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                min = Math.Min(numbers[i], min);
                max = Math.Max(numbers[i], max);
            }
            Console.WriteLine("min:" + min);
            Console.WriteLine("max:" + max);
            Console.ReadLine();
        }
    }
}
