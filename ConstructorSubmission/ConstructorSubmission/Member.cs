using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Member
    {
        public string name { get; set; }
        public int MemberNumber { get; set; }

        //chaining constructors together to accept 1, 2, or no parameters
        public Member() : this ("Guest")
        {
        }
        public Member(string name) : this (name, 0)
        {
        }
        public Member(string name, int memberNumber)
        {
            this.name = name;
            this.MemberNumber = memberNumber;
        }
    }
}
