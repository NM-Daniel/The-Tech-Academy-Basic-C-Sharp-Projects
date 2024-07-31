using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOps operation = new mathOps(); //Instantiating the class mathOps as a variable called operation
            
            int inputOne = 2;
            Console.WriteLine(operation.NumAlt(inputOne)); //Calls the first NumAlt Method
            Console.ReadLine();

            decimal inputTwo = 15.234m;
            Console.WriteLine(operation.NumAlt(inputTwo)); //Calls the decimal NumAlt Method
            Console.ReadLine();

            string inputThree = "10";
            Console.WriteLine(operation.NumAlt(inputThree)); //Calls the string NumAlt Method
            Console.ReadLine();


        }
    }
}
