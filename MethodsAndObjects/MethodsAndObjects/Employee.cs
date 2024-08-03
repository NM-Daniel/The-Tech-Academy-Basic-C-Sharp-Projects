using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //Employee class inherits the properties and methods from the Person class
    public class Employee : Person
    {
        //An additional property is given to objects in the Employee class
        public int Id { get; set; }

    }
}
