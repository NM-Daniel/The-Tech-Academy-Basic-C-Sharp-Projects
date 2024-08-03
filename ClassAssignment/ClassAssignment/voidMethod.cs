using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class voidMethod
    {
        //Creates a simple Method
        public void DivideByTwo (int num1)
        {
            int result = num1 / 2;
            Console.WriteLine($"{num1} divided by 2 equals {result}");
        }

        //Overloaded DivideByTwo by changing the parameter type
        public void DivideByTwo (double num1)
        {
            double result = num1 / 2;
            Console.WriteLine($"{num1} divided by 2 equals {result}");
        }

    }
}
