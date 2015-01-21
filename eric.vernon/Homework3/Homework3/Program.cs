using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 6; i++)
            {
                //create 5 rows of entries              
                for(int j = 1; j < 6; j++)
                {
                    Console.Write("{0,5}", j * i);
                    //print row with 5 spaces in between entries
                    //each entry equals j * i
                }
                
                Console.WriteLine();   
            }
            
            Console.ReadKey();
        }
    }
}
