using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    //A custom Exception is made that inherits from class Exception
    public class ZeroNegativeException : Exception
    {
        public ZeroNegativeException()
            : base() { }
        public ZeroNegativeException(string message)
            : base(message) { }
    }
}
