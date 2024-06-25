using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat is your name?"); //Initial greeting
        string studentName = Console.ReadLine(); //User types in name

        Console.WriteLine("What course are you on?"); //Course question
        string courseName = Console.ReadLine(); //User types namem of course

        Console.WriteLine("What page number?"); 
        string pageNo = Console.ReadLine(); //User types in their page number
        short pageNumber = Convert.ToInt16(pageNo); //Casts the string to a short

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); 
        string helpAnswer = Console.ReadLine(); //Takes the users answer
        bool needHelp = bool.Parse(helpAnswer); //Converts users answer to a boolean

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedBack = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursAnswer = Console.ReadLine(); //User inputs the hours worked. Decimal points will be accepted.
        float hoursStudied = float.Parse(hoursAnswer); //Casts string input to a float in case they worked partial hours.

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!\nPress enter to exit");
        Console.ReadLine(); //Ends the program with 'Enter'
    }
}

