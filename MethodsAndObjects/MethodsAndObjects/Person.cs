using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //Properties are set for the class Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //A method is created called SayName that will print their full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
