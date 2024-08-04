using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        //Comparison operators are overloaded so they compare employee objects based on their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        //Must overloaded the pair
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

    }
}
