using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    //Made the class static. A static class does not need to be initialized in Program.cs
    static public class StaticClass
    {
        //A method with a output parameter
        public static void OutMethod (out int user1)
        {
            user1 = 1;
        }
    }
}
