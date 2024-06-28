using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is the package weight?"); //Greeting message
            int packageWeight = Convert.ToInt32(Console.ReadLine()); //Takes user input, converts the string to an Int, and assigns the value to packageWeight

            if (packageWeight > 50) //Conditional statement that executes if the packageWeight variable is greather than 50
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0); //Way to end program found on stack overflow
            }

            Console.WriteLine("What is the package width?"); 
            int packageWidth = Convert.ToInt32(Console.ReadLine()); //Takes user input, converts the string to an Int, and assigns the value to packageWidth
            Console.WriteLine("What is the height of the package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine()); //Takes user input, converts the string to an Int, and assigns the value to packageHeight
            Console.WriteLine("What is the length of the package?");
            int packageLength = Convert.ToInt32(Console.ReadLine()); //Takes user input, converts the string to an Int, and assigns the value to packageLength

            int packageDimensions = packageWidth + packageHeight + packageLength; //Creates a variable that is equal to the sum of the package dimensions

            if (packageDimensions > 50) //Conditional statement that executes if the variable packageDimensions is greater than 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            decimal quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100m; //A decimal data type is chosen for working with currency.

            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C") + "\nThank You!"); //The quote is displayed as a currency string.

            Console.ReadLine();


        }
    }
}
