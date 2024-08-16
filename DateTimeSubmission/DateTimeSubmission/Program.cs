using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the exact date and time it is currently
            Console.WriteLine("It is currently:" + DateTime.Now);
            Console.WriteLine("Enter a number");

            //Takes an input from the user
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Creates a new DateTime variable that takes the time now and uses the AddHours() Method to add the users input to the hours
            DateTime futureTime = DateTime.Now.AddHours(userNum);
            //Prints the futureTime
            Console.WriteLine("In {0} hours it will be: {1}", userNum, futureTime);
            
            Console.ReadLine();
        }
    }
}
