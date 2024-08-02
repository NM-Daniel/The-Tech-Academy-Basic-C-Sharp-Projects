using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //the class voidMethod is instantiated.
            voidMethod voidMethod = new voidMethod();

            //MyMethod, created in voidMethod class, is passed two int's
            voidMethod.MyMethod(1000, 500);
            Console.ReadLine();

            //Different int's are created and assigned to variables
            int num1 = 300;
            int num2 = 450;

            //MyMethod is given two int's but it is passed in as a variable name.
            voidMethod.MyMethod(num1, num2);
            Console.ReadLine();

        }
    }
}
