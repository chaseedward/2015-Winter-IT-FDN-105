using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var r = 1; r <= 5; r++) //row creation
            {
                if (r == 1){
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                    
                else if (r == 2){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                   
                else if (r == 3){
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                    
                else if (r == 4){
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                    
                else if (r == 5){
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                    

                for (var c = 1; c <= 5; c++) //column creation
                {
                    Console.Write("{0,-10}", (r * c)); //output formatting
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
