using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Davey
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int max = numbers.Max();
            int min = numbers.Min();
            Console.WriteLine("Max= {0}, Min= {1}", max, min);
        }
    }
}
