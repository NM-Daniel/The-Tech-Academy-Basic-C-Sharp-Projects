using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number and we'll multiply it by 50:");
            string userMult = Console.ReadLine();
            int mult = Convert.ToInt32(userMult);
            Console.WriteLine(mult * 50);

            Console.WriteLine("Please input number and we'll add 25:");
            string userAdd = Console.ReadLine();
            int add = Convert.ToInt32(userAdd);
            Console.WriteLine(add + 25);

            Console.WriteLine("Please input a number and we'll divide it by 12.5:");
            string userDiv = Console.ReadLine();
            int div = Convert.ToInt32(userDiv);
            Console.WriteLine(div / 12.5f);

            Console.WriteLine("Please input a number and we'll check if it's greater than 50");
            string userCheck = Console.ReadLine();
            int check = Convert.ToInt32(userCheck);
            Console.WriteLine(check > 50);

            Console.WriteLine("Please input a number and we will divide by 7 and give you the remainder:");
            string userMod = Console.ReadLine();
            int mod = Convert.ToInt32(userMod);
            Console.WriteLine(mod % 7);

            Console.WriteLine("End of Program. Please press enter.");
            Console.ReadLine();


        }
    }
}
