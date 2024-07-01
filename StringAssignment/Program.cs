using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 string variables are declared
            string sentence1 = "This is how you concatenate strings together.";
            string sentence2 = "It is useful to know this.";
            string sentence3 = "Concatenating strings is important.";

            Console.WriteLine(sentence1 + " " + sentence2 + " " + sentence3); //This concatenates the three strings together and adds spaces
            Console.WriteLine(sentence3.ToUpper()); //ToUpper() capitalizes all the characters in the string.

            StringBuilder sbString = new StringBuilder(); //StringBuilder allows a string to be appeneded, or modified without creating new save locations in memory.
            sbString.Append("Four score and seven years ago,");
            sbString.Append(" our fathers brought forth on this continent");
            sbString.Append(" a new nation. Conceived in liberty and dedicated to the proposition");
            sbString.Append(" that all men are created equal.");
            sbString.Append("\netc. etc.");

            Console.WriteLine(sbString); //Prints the stringbuilder
            Console.ReadLine();

           

        }
    }
}
