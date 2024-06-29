using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            
            //A simple while loop
            int j = 10; //j acts as our counter
            while (j > -1) //Will run the loop as long as our counter is greater than -1
            {
                Console.WriteLine(j);
                j--; //decrements j by one
            }
            Console.WriteLine("\nPress Enter");
            Console.ReadLine();


            //Do While loop
            Console.WriteLine("Guess my name:");
            string name = "Nathan"; //This will be the name the user is trying to guess
            string guess = ""; //guess variable is declared.

            int i = 0; //This will be our counter
            do //runs the code through once
            {
                guess = Console.ReadLine(); //Takes input from the user
                i++; //The counter in incremented by one

                if (guess == name) //If the user guesses the correct name they are informed they won
                {
                    Console.WriteLine("You win!");
                    break; //breaks out of the loop
                }
                else if (guess != name) 
                {
                    Console.WriteLine("You have " + (3 - i) + " guesses remaining."); //This line tells the user how many guesses they have left
                }
            }
            while (i < 3); //repeats the block of code above as long as the counter is less than 3
            
            if (guess != name) //If the user did not guess the name in time an additional message is displayed
            {
                Console.WriteLine("Out of Guesses");
            }
            
            Console.ReadLine();

        }
    }
}
