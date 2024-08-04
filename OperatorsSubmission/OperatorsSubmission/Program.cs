using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two instances of Employee objects have been created and assigned values for their properties.
            Employee employee1 = new Employee() { Id = 0, firstName = "Bob", lastName = "Vance" };
            Employee employee2 = new Employee() { Id = 1, firstName = "Michael", lastName = "Scott" };

            Console.WriteLine("Are Bob and Michael's Id numbers the same?");

            //Using the overloaded comparison operators to compare employee1.Id with employee2.Id
            bool same = employee1 == employee2;
            Console.WriteLine(same);

            Console.ReadLine();

        }
    }
}
