using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? Please use numbers");
            string userAge = Console.ReadLine(); //User inputs their age as a string

            Console.WriteLine("Have you ever had a DUI? Please respond with true or false");
            string userDUI = Console.ReadLine(); //User inputs if they've had a dui as a true or false string

            Console.WriteLine("How many speeding tickets do you have? Please use numbers");
            string userTickets = Console.ReadLine(); //User inputs the number of tickets they have as a string

            //User data is converted to Int and Boolean data types
            int age = Convert.ToInt32(userAge);
            int tickets = Convert.ToInt32(userTickets);
            bool dui = Convert.ToBoolean(userDUI);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age >= 15 && dui == false && tickets <= 3); //User must be 15 or older AND not had any DUI's AND had no more than 3 tickets
            Console.ReadLine();





        }
    }
}
