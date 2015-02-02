using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// got stuck and couldn't figure it out. Orginally started as 5 variables and
// 5 for loops. 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 5; j++)
                {
                    if (i > 0) Console.Write(i * j + "\t");
                    else Console.Write(j + "\t");
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
