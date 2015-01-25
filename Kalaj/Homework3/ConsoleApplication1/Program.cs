using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class TestWhile
{
    static void Main()
    {
        int x;
        int y = 0;

        x = 1;
        while (x < 1000)
        {
            y = y + x;

            if (y > 20)
            {
                // exits the loop
                break;
            }

            if (y == 10)
            {
                // skips remainder of loop body
                continue;
            }

            Console.WriteLine("{0} {1}", x, y);

            x++;
        }
        
        Console.ReadLine();
    }
}
