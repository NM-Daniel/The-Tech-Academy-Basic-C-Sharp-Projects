using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string userInput = Console.ReadLine();

            //try/catch block that creates a new variable called theDay of daysOfWeek type and attempts to give it the value entered from the user.
            //adding true ignores the users casing
            try
            {
                daysOfWeek theDay = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), userInput, true);
                Console.WriteLine("It is " + theDay);
            }
            //If the user enteres sometimes that is not an enum value this catches the exception
            catch (ArgumentException)
            {
                Console.WriteLine("Please Enter an actual day of the week.");
            }
            Console.ReadLine();

        }
        //Creates daysOfWeek enum
        public enum daysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturdary
        }
    }
}
