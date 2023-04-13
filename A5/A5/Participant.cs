using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Participant
    {
        private string firstName;
        private string lastName;
        private Address address;

        public Participant(string fName, string lName, Address addrss)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.address = addrss;
        }

        public string FirstName { get { return firstName;} set { firstName = value; } } 

        public string LastName { get { return lastName;} set { lastName = value; } }

    }
}
