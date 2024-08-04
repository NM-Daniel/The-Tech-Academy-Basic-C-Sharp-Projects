using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        //SayName method is overriden so we can use it in this class
        public override void SayName()
        {
            Console.WriteLine("Full name: " + firstName + " " + lastName);

        }

        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit");
        }
    }
}
