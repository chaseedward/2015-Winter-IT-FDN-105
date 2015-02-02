using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

internal class Multiply
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++) //will start as 1 * all interations of j below, then 2 * iterations of j below, etc. until 5 is reached.
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i * j + "\t"); // "\t" is a tab to align the columns
            }
            Console.Write("\n"); // "\n" is a carriage return to make the loop continue on a different line
        }

        Console.ReadLine();
    }
}
