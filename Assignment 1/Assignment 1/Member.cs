using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment
{
    class Member : iMember, IComparable<Member>
    {
        private string lastname;
        private string firstname;
        private string contactnumber;
        private string pin;
        public string FirstName { get { return firstname; } set => throw new NotImplementedException(); }
        public string LastName { get { return lastname; } set => throw new NotImplementedException(); }
        public string ContactNumber { get { return contactnumber; } set => throw new NotImplementedException(); }
        public string PIN { get { return pin; } set => throw new NotImplementedException(); }

        public string[] Tools => throw new NotImplementedException();

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.contactnumber = contactNumber;
            this.pin = pin;
        }

        public void addTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
