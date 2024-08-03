using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //An object of the Employee class is instantiated and initialized with FirstName and LastName property values
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //employee object inherited the SayName Method from the Person class.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
