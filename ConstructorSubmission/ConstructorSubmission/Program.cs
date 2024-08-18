using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a const greeting that will not change.
            const string greeting = "Welcome. Please Enter your name";
            Console.WriteLine(greeting);

            string userName = Console.ReadLine();

            //If the user does not enter a name a Member object will be created with no parameters.
            if (userName == "")
            {
                var member = new Member();
                Console.WriteLine("Welcome {0}. Your member number is {1}.", member.name, member.MemberNumber);
            }
            //If the user enters their name they will be given the choice to enter an int that will be used as the sencond parameter.
            else
            {
                Console.WriteLine("Do you know your member number? y or n");
                string answer = Console.ReadLine().ToLower();
                int userMemNum;
                if (answer == "y")
                {
                    Console.WriteLine("Please enter your member number");
                    userMemNum = Convert.ToInt32(Console.ReadLine());
                    //Member() is given the user's two answers as parameters.
                    var member = new Member(userName, userMemNum);
                    Console.WriteLine("Welcome {0}. Your member number is {1}.", member.name, member.MemberNumber);
                }
                else
                {
                    //Only the userName is give to the Member() constructor
                    var member = new Member(userName);
                    Console.WriteLine("Welcome {0}. You have been given a member number of {1}.", member.name, member.MemberNumber);
                }
            }

            Console.ReadLine();

            

        }
    }
}
