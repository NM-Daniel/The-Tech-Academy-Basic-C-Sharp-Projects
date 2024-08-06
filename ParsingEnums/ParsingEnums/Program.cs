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

            //try/catch block to convert the string input to enum type, if it does not match an enumeral the ArgumentException is handled.
            try
            {
                Enum.Parse(typeof(daysOfWeek), userInput);
                Console.WriteLine("It is " + userInput);
            }
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
