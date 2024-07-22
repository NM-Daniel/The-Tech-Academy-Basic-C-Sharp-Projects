using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 100, 84, 98, 6, 8 }; //A list is initialized
            Console.WriteLine("Please enter a number to divide by.");
            int userInput; //The userInput variable is declared but not assigned a value yet.
            bool success = false; //We will use this bool variable for our while loop
            
            while (!success) { //This loop will keep running until the user enters in a valid input
                
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine()); //the user assigns a value to the variable userInput
                    for (int i = 0; i < intList.Count; i++) //For loop to run through our list
                    {
                        Console.WriteLine(intList[i] / userInput);
                        success = true; //lets the program know the loop ran successfully to exit the while loop
                    }
                }
                catch (FormatException ex) //If the user enters a string data type
                {
                    Console.WriteLine("Please enter a whole number.");
                    
                }
                catch (DivideByZeroException ex) //If the user enters a 0
                {
                    Console.WriteLine("You cannot divide by zero.");
                }
                catch (Exception ex) //Any other exception message will print.
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine("Operation successful. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
