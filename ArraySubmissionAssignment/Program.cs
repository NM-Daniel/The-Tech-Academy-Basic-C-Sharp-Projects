using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a string array and an int array
            string[] stringArray = { "Hello, World", "Programming", "Coding", "C#", "Tech Academy" };
            int[] intArray = { 100, 1313, 7, 420, 9000 };

            Console.WriteLine("Please enter an index from 0-4 to see a string");
            int userInput = Convert.ToInt32(Console.ReadLine());
            

            //Uses an if else statement to test users input. If the users input is less than 0 or more than 4, a message will appear.
            //If the input is from 0-4, the element at the index is printed in double quotes
            if (userInput < 0 || userInput > 4)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
            Console.WriteLine("You chose " + userInput + ". Your string is " + "\"" + stringArray[userInput] + "\"");
            }


            Console.WriteLine("\nPlease enter an index from 0-4 again to see a number");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            //Uses an if else statement to test users input. If the users input is less than 0 or more than 4, a message will appear.
            //If the input is from 0-4, the element at the index is printed in double quotes
            if (userInput2 < 0 || userInput2 > 4)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine("You chose " + userInput2 + ". Your number is " + "\"" + intArray[userInput2] + "\"");
            }

            Console.WriteLine("\nEnter a number from 0-3 to reveal a color");
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            //Creates a list of colors
            List<string> stringList = new List<string>();
            stringList.Add("Yellow");
            stringList.Add("Red");
            stringList.Add("Green");
            stringList.Add("Blue");

            //Uses an if else statement to test users input. If the users input is less than 0 or more than 4, a message will appear.
            if (userInput3 >= 0 && userInput3 < stringList.Count)
            {
                Console.WriteLine("You chose " + userInput3 + ". Your color is " + stringList[userInput3] + ".");
            }
            else
            {
                Console.WriteLine("You selected " + userInput3 + ". That is not a valid index.");
            }

            Console.ReadLine();

        }
    }
}
