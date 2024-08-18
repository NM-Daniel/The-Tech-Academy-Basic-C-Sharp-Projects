using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            bool succesfulInput = false;
            //Creates a while loop to attempt to get a positive int answer from the user.
            while (!succesfulInput)
            {
                try
                {
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    //Creates a DateTime variable that is the current DateTime plus the negative value the user inputted.
                    DateTime minusAge = DateTime.Now.AddYears(-userAge);
                    //If the user enters a value 0 or below a custom exception is thrown
                    if (userAge <= 0) throw new ZeroNegativeException();
                    Console.WriteLine("You were born in (roughly) " + minusAge.Year);
                    //If the user enters a number > 0 the loop will end
                    if (userAge > 0) succesfulInput = true;
                }
                catch (ZeroNegativeException)
                {
                    Console.WriteLine("That cannot be your age. Enter a number above zero.");
                }
                //Any other exception to the program will display this message and end the loop with return;
                catch (Exception)
                {
                    Console.WriteLine("You done broke it now, bud");
                    Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();

        }
    }
}
