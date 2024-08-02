using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class voidMethod
    {
        //Creating a void method that takes in two integers, called num1 and num2
        public void MyMethod (int num1, int num2)
        {
            //A mathematical operation is run on num1
            int altered = num1 / 100;
            //num2 will be the integer that is actually displayed to the screen
            Console.WriteLine(num2);
            
        }
    }
}
