using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Programn\nPerson 1 hourly rate:");
            string personOneHourlyRate = Console.ReadLine(); //Gathers input for person 1's hoursly rate
            Console.WriteLine("Hours worked per week:");
            string personOneHoursWorked = Console.ReadLine(); //Gathers input for person 1's hours worked

            Console.WriteLine("\nPerson 2 hourly rate:");
            string personTwoHourlyRate = Console.ReadLine(); //Gathers input for person 2's hoursly rate
            Console.WriteLine("Hours worked per week:");
            string personTwoHoursWorked = Console.ReadLine(); //Gathers input for person 1's hours worked 

            Console.WriteLine("\nAnnual salary of Person 1:");
            decimal pOneHourly = Convert.ToDecimal(personOneHourlyRate); //Converts the string input from the user to a decimal we can do math operations on
            decimal pOneHoursWorked = Convert.ToDecimal(personOneHoursWorked); 
            decimal pOneSalary = pOneHourly * pOneHoursWorked * 52; //Multiplies Person 1's hourly rate by the weekly hours by 52 weeks per year
            Console.WriteLine(pOneSalary); //Prints their salary on the screen

            Console.WriteLine("\nAnnual salary of Person 2:");
            decimal pTwoHourly = Convert.ToDecimal(personTwoHourlyRate); //Converts the string input from the user to a decimal we can do math operations on
            decimal pTwoHoursWorked = Convert.ToDecimal(personTwoHoursWorked);
            decimal pTwoSalary = pTwoHourly * pTwoHoursWorked * 52; //Multiplies Person 2's hourly rate by the weekly hours by 52 weeks per year
            Console.WriteLine(pTwoSalary); //Prints their salary on the screen

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(pOneSalary > pTwoSalary); //Checks if it's true that pOneSalary is greater than pTwoSalary. Displays answer

            Console.WriteLine("\nEnd of program. Press Enter to exit.");
            Console.ReadLine(); //Keeps the program from closing until enter is pressed


        }
    }
}
