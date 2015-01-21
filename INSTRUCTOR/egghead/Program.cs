using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace egghead
{
    class Program
    {
        static void Main()
        {
            // Write a program that takes seconds 
            //   and converts it into days, hours, minutes, and seconds.
            //  (Hint: Have a variable that has the number seconds per day,
            //              the number seconds per hour,
            //              and the number seconds per minute.) 
            var valueInSeconds = 89000;

            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            Console.WriteLine("Days=" + days);
            Console.WriteLine("Hours=" + hours);
            Console.WriteLine("Minutes=" + minutes);
            Console.WriteLine("Seconds=" + seconds);
            Console.ReadLine();
        }
    }
}
