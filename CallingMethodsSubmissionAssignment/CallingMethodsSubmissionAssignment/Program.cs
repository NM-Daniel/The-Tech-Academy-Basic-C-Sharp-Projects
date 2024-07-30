using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to see some math operations.");
            //a string input from the user is converted to an int
            int userInput = Convert.ToInt32(Console.ReadLine());

            //(an instance of Maths would have needed to have been created below - if the methods called were not static in Maths.cs)
            //Maths math = new Maths();

            //Three new variables are created. Each one calls a method found in class Maths
            int operation1 = Maths.Square(userInput); //(Would then be math.Square(userInput); - if methods were not static)
            int operation2 = Maths.Cube(userInput);
            int operation3 = Maths.AddFifty(userInput);

            //The results are displayed for the user
            Console.WriteLine(userInput + " squared is " + operation1);
            Console.WriteLine(userInput + " cubed is " + operation2);
            Console.WriteLine(userInput + " plus 50 is " + operation3);
            
            Console.ReadLine();
        }
    }
}
