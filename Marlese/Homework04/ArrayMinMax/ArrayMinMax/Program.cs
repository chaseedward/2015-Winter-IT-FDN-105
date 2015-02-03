using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {5, -2, 100, 12, 4, -5};
            {
                Console.WriteLine("Min = " + numbers.Min());
                Console.WriteLine("Max = " + numbers.Max());
            }
        } 
             
    
    }
}

