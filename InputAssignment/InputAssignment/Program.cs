using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            //Creates a string variable for the user to assign a number to
            string userNumber = Console.ReadLine();

            //Creates an instance of StreamWriter called log which is used to save the user's input to a text file. False used to not append the file and update it each
            //time the program is run
            using (StreamWriter log = new StreamWriter(@"C:\Users\natha\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\InputAssignment\InputAssignment\logs.txt", false))
            {
                log.WriteLine(userNumber);
            }

            //Another way of logging without creating variable or using StreamWriter
            //File.WriteAllText(@"C:\Users\natha\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\InputAssignment\InputAssignment\logs.txt", Console.ReadLine());

            Console.WriteLine("\nThe number you logged is:");
            //File.ReadAllText() reads the content of the txt file.
            Console.WriteLine(File.ReadAllText(@"C:\Users\natha\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\InputAssignment\InputAssignment\logs.txt"));
            Console.ReadLine();

        }
    }
}
