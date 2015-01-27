using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print program instructions to console 
            Console.WriteLine("Enter a positive integer, n, to see it displayed n!");

            var userPrompt = "y";  //Var to hold user input to "Keep going? (Y or N):" question, initialized to "y" to start main program while loop

            //While loop to grab user input. While user wants to keep entering values, just keep going.
            while (userPrompt.Equals("y") || userPrompt.Equals("Y"))
            {
                var consoleInput = "";          //Read string from console
                var userInt = 0;                //Variable to hold int parsed from console input string
                long accumulator = 1;           //Long variable to hold factorial product
                var promptModeExit = false;     //Flag to exit prompt mode. Stay in prompt mode while false
                
                Console.Write("\nn:"); //User input prompt
                
                consoleInput = Console.ReadLine(); //Grab user input
                
                if (int.TryParse(consoleInput, out userInt)) // Try to parse user input string as an integer
                {
                    if (userInt < 0) //User entered a negative integer, which is not allowed. Print an educational message and move down to user prompt mode
                    {
                        Console.WriteLine("\n\tHmmm. You've entered a negative integer.\n");
                        Console.WriteLine("\t0! = 1\n");
                        Console.WriteLine("\tIf we try to extend this to -1, we find that (-1)! = 1/0 \n\twhich means that (-1!) is undefined. Extending further to \n\t(-2)! etc. is thus impossible as well.");
                        Console.WriteLine("\n\tPlease enter positive integers only!");
                    }
                    else if (userInt == 0) //Print 0 factorial to console and move down to user prompt mode
                    {
                        Console.WriteLine("\n\t0!    =    1\n");
                    }
                    
                    else //User input validated to be a postive integer. Print n! to console
                    {
                        Console.WriteLine(); //append a newline to the console output for nicer formatting
                        
                        //Calculate the factorial
                        for (var i = 1; i <= userInt; i++)
                        {
                            accumulator = accumulator * i;

                            //Write the nth factorial to the console
                            Console.WriteLine("\t{0}!\t=\t{1}", i, accumulator);
                        }

                        Console.WriteLine(); //append a newline to the console output for nicer formatting
                    }
                }
                else //Console input can't be parsed as an integer. Remind them what to do and move down to user pormpt mode 
                {
                    Console.WriteLine("\n\tPlease enter positive integers only.");
                }

                //USER PROMPT MODE - ask user if they want to keep interacting with the program 
                //and validate their answer is only upper or lower case Y or N.
                do
                {
                    //Prompt the user and grab their answer
                    Console.Write("\nKeep going? (Y or N):");
                    userPrompt = Console.ReadLine();

                    //Test that userPrompt string is not NULL or empty and that it only contains upper or lowercase y or n. 
                    //If false, prompt user to again enter a y or n
                    //If true, set promptModeExit flag to true and exit user prompt mode
                    if ( !string.IsNullOrEmpty(userPrompt) && (userPrompt.Equals("y") || userPrompt.Equals("Y") || userPrompt.Equals("n") || userPrompt.Equals("N")) )
                    {
                        promptModeExit = true;
                    }

                } while (!promptModeExit);
            }
        }
    }
}
