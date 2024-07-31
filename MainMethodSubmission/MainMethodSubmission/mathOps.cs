using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class mathOps
    {
        public int NumAlt (int num)
        {
            return num + 2;
        }
           
        public int NumAlt (decimal num) //Method takes in a decimal data type
        {
            decimal answer = num / 3m; //Creates a decimal variable and operates on the num input
            return Convert.ToInt32(answer); //Converts the answer to an int and returns it

        }

        public int NumAlt (string phrase) //Method takes in a string
        {
            int intPhrase = Convert.ToInt32(phrase); //Converts the string to an int named intPhrase
            return intPhrase - 1; //subtracts 1 from the int and returns it
        }
    }
}
