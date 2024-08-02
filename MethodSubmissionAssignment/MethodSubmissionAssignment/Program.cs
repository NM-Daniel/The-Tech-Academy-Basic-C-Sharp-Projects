using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number (Required):");
            double inputOne = Double.Parse(Console.ReadLine()); //The user input is casted to a double data typed and assigned to a variable called inputOne

            Operation Op = new Operation(); //An instance of the Operation class is created.

            Console.WriteLine("Please enter a second number to perform an operation (Optional. Press enter to skip):");

            //A try block is used first used to work with two user inputs
            try
            {
                double inputTwo = Double.Parse(Console.ReadLine());
                Console.WriteLine(inputOne + "^" + inputTwo + " is " + Op.Power(inputOne, inputTwo));
            }
            //If no input is entered the Format exception error will be handled and we will call the Method without the second input
            catch (FormatException ex)
            {
                Console.WriteLine(inputOne + " squared is " + Op.Power(inputOne));
            }
            Console.ReadLine();
        }
    }
}
