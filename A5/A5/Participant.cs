using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Participant
    {
        #region FIELDS
        /* Fields */

        private string firstName;
        private string lastName;
        private Address address;

        #endregion

        #region CONSTRUCTORS
        /* Constructors */

        public Participant() : this("", "", new Address()) { }

        public Participant(Participant copyAnother) : this(copyAnother.FirstName, copyAnother.LastName, copyAnother.Address) { }

        public Participant(string fName, string lName, Address addrss)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.address = addrss;
        }

        #endregion

        #region PROPERTIES
        /* Properties */

        /// <summary>
        /// 
        /// </summary>
        public Address Address { get { return address; } set { address = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get { return firstName; } set { firstName = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string FullName => $"{LastName}, {FirstName}      ";

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get { return lastName; } set { lastName = value; } }

        #endregion

        #region METHODS
        /* Methods */
        public override string ToString() => FullName + address.ToString();

        public bool Validate() => firstName != null && lastName != null;

        #endregion
    }
}
