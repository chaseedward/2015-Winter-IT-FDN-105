using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass0120
{
    class Program
    {
        static void Main()
        {
            int myInt = 20;

            // 1. (boxing)
            // myObj now contains the integer
            // value of 20.
            object myObj = myInt;

            Console.WriteLine("(0)", );

            // 2. myObj now contains 2001
            myObj = 2001;

            // 3. (unboxing)
            // myOtherInt contains the value
            // contained in myObj.
            int myOtherInt = (int)myObj;

            // 4. (unboxing)
            // if you wanted to unbox myObj
            // into a double you FIRST need
            // to unbox it as an int and then
            // convert it to a double.
            double dbl = (double)(int)myObj;
        }
        
    }
}
