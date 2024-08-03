using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMethod voidMethod = new voidMethod();

            //Calls the method in our voidMethod class
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            voidMethod.DivideByTwo(userInput);

            //Calls the overloaded method in the voidMethod class
            Console.WriteLine("Write a number with a decimal value (Optional)");
            double userInput2 = Double.Parse(Console.ReadLine());
            voidMethod.DivideByTwo(userInput2);

            //Uses an output parameter to pass in the first userInput and changes it to 1.
            StaticClass.OutMethod(out userInput);
            Console.WriteLine("Your first input has now been changed to a 1");
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
