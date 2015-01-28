using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_5x5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 6; i++)
            {
                for (var j = 1; j < 6; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.Write("\n");
            }
            var foo = Console.ReadLine();
        }
    }
}
