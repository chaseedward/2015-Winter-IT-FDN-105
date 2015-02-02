using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3mult
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 1; x <= 5; x++)
            //for (var x = 5; x >= 1; x--) using this code would start with 25 down
            {
                for (var z = 1; z <= 5; z++)
                //for (var z = 5; z >= 1; z--) the inverse
                {
                    Console.Write("{0, 5}", (x*z)); //numbers arranged on a table on the right 5 by 5
                   // Console.Write("{0,-5}", (x*z)); numbers arranged on a table on the left  5 by 5
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
