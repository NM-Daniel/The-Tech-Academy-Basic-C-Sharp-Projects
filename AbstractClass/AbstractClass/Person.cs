using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
   public abstract class Person //A person object will not be instantiated because the class is abstract
    {
        //Properties for the abstract class Person
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Classes that inherit the Person class must have this SayName Method
        public abstract void SayName();
    }
}
