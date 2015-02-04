using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Session4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myarray = new[] { 5, -2, 100, 12, 4, -5 };
            var max = myarray[0];
            var min = myarray[0];

            foreach (var x in myarray)
            {
                if (x >= max)
                {
                    max = x;
                }
                if (x <= min)
                {
                    min = x;
                }
            }
            string str = Convert.ToString(myarray);
            Console.WriteLine("The values in the array are: "+ String.Join(", ", myarray));
            Console.WriteLine("The Max Number is " + max);
            Console.WriteLine("The Min Number is " + min);
            Console.ReadLine();
        }
    }
}
