using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] numbersset = new int[] {5, -2, 100, 12, 4, -5};
            Console.WriteLine("The Min Value is {0} and Max Value is {1}", numbersset.Min(), numbersset.Max());
            Console.ReadLine();



        }
    }
}
