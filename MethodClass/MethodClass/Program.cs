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

            //The parameters are passed in out of order but specified by their name
            voidMethod.MyMethod(num2: 450, num1: 300);
            Console.ReadLine();

        }
    }
}
