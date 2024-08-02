using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    public class Operation
    {
        public double Power(double num1, double num2 = 2) //a Method called Power that takes in one or two doubles and returns a double after an operation
        {
            double result = Math.Pow(num1, num2); //num1 is given the power of num2
            return result;
        }

    }
}
