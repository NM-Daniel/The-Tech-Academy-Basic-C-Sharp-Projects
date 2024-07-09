using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsChallengeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            //Creating an array of strings
            string[] stringArray = { "January ", "February ", "March ", "April ", "May ", "June ", "July " };
            Console.WriteLine("Please enter the current year:");
            //Takes input from the user and assigns it to a string variable called userInput
            string userInput = Console.ReadLine();

            //For loop to append the userInput to each item in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }
            //A foreach loop that prints off the the appended string in the array
            foreach (string month in stringArray)
            {
                Console.WriteLine(month);
            }
            Console.ReadLine();
            //End of Part 1

            //Part 2
            string infinite = "Never";
            ////infinite loop. Infinite will never equal "Never ending" with this code
            //while (infinite != "Never ending")
            //{
            //    Console.WriteLine(infinite);
            //}

            //Fixes the infinite loop by appending a string so that infinite will equal "Never ending"
            while (infinite != "Never ending")
            {
                Console.WriteLine(infinite);
                infinite += " ending";
                Console.WriteLine(infinite);
            }
            Console.ReadLine();
            //End of Part 2

            //Part 3
            //A loop that uses < as the comparison operator
            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine("We've seen " + stringArray[j]);
            }
            //A loop that uses <= as the comparison operator
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
            //End of Part 3

            //Part 4
            //Creates a list of strings
            List<string> stringList = new List<string>();
            stringList.Add("dog");
            stringList.Add("cat");
            stringList.Add("fish");
            stringList.Add("hamster");
            stringList.Add("rabbit");

            Console.WriteLine("Enter a common household pet:");
            //Assigns the user input to a variable called userPet. Makes the user's input not case sensitive
            string userPet = Console.ReadLine().ToLower();
            //creates a bool called petFound to control our loop
            bool petFound = false;

            //While petFound is false execute this loop
            while (!petFound)
            {
                //K will keep track of how many times we execute the for loop
                int k = 0;
                //For loop that will iterate through the list to see if the userPet matches an item in the list
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (userPet == stringList[i])
                    {
                        Console.WriteLine("The index of the pet you entered is " + i); //Tells the user the index of the pet they entered if it is in the list
                        petFound = true; //Makes petFound true which will end the while loop
                        break; //breaks out of this for loop back to the while loop
                    }
                    else if (userPet != stringList[i])
                    {
                        k++; //add to our k counter
                    }

                }
                //if the for loop above executed through the whole list and did not find a match. This if statement will execute.
                if (k == stringList.Count)
                {
                    Console.WriteLine("That pet is not on the list.");
                    break; //This break will exit the while loop
                }
            }
            Console.ReadLine();
            //End of Part 4

            //Part 5
            //Created a list of strings and called it stringList2
            List<string> stringList2 = new List<string>() { "Charlie", "Nathan", "Ronald", "McClane", "Nathan", "Wendy" };
            Console.WriteLine("Please enter a name:");
            string userName = Console.ReadLine(); //Assigns the user's input to a string variable called userName

            bool nameFound = false; //This bool will determine if the message that the userName is not found in the list is displayed

            //For loop to run through the list and look for a match
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].Contains(userName))
                {
                    Console.WriteLine("The index/indices of that name are: " + i);
                    nameFound = true; //nameFound will be reassigned to true
                }
            }

            if (!nameFound) //This if statement only executes if nameFound is still false
            {
                Console.WriteLine("That name is not in the list.");
            }
            Console.ReadLine();
            //End of Part 5

            ////Part 6
            //Create a list of strings
            List<string> states = new List<string>() { "Oregon", "Idaho", "Washington", "Oregon", "Nebraska", "Nebraska" };
            //Create a list where states we have already seen will go to.
            List<string> duplicateStates = new List<string>();

            //Foreach loop that will go through every item in our states list
            foreach (string state in states)
            {
                //if statement will check if we have seen the state before. If we have it will execute the code in the brackets
                if (duplicateStates.Contains(state))
                {
                    Console.WriteLine(state + " is a duplicate state.");
                }
                //If we have not see the state before the message will be displayed in the console and then the state will be added to our duplicateStates list.
                else
                {
                    Console.WriteLine(state + " is a new state.");
                    duplicateStates.Add(state);
                }
            }
            Console.ReadLine();
            //End of Part 6

        }
    }
}
