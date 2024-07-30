using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    //Class is made public so it can be used anywhere
    public class Maths
    {
        //the static modifier allows the Method(s) to be called in Program.cs without creating an object of the class Maths
        public static int Square (int num) //This method is called "Square" and it takes in an int called "num" and returns an int
        {
            return num * num;
        }
        public static int Cube (int num) //This method is called "Cube" and it takes in an int called "num" and returns an int
        {
            return num * num * num;
        }
        public static int AddFifty (int num) //This method is called "AddFifty" and it takes in an int called "num" and returns an int
        {
            return num + 50;
        }
    }
}
