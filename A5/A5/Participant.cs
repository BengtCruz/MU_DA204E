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

        /// <summary>
        /// Initialize an object of type Participant with the specified values
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="addrss"></param>
        public Participant(string fName, string lName, Address addrss)
        {
            this.firstName = fName;
            this.lastName = lName;

            if(addrss != null) 
                address = addrss;
            else
                address = new Address();
        }

        /// <summary>
        /// Initialize an object of type Participant with default values
        /// </summary>
        public Participant() : this("", "", new Address()) { }

        /// <summary>
        /// Initialize an object of type Participant with the specified values
        /// </summary>
        /// <param name="copyAnother"></param>
        public Participant(Participant copyAnother) : this(copyAnother.FirstName, copyAnother.SecondName, new Address(copyAnother.Address)) { }


        #endregion

        #region PROPERTIES
        /* Properties */

        /// <summary>
        /// Property that gets and sets the address of the participant
        /// </summary>
        public Address Address { get { return address; } set { address = value; } }

        /// <summary>
        /// Property that gets and sets the first name of the participant
        /// </summary>
        public string FirstName { get { return firstName; } set { firstName = value; } }

        /// <summary>
        /// Property that gets full name of the participant
        /// </summary>
        public string FullName => $"{SecondName}, {FirstName}";

        /// <summary>
        /// Property that gets and sets the last name of the participant
        /// </summary>
        public string SecondName { get { return lastName; } set { lastName = value; } }

        #endregion

        #region METHODS
        /* Methods */

        /// <summary>
        /// String value of the participant
        /// </summary>
        /// <returns> A string with formatted string values describing the guest </returns>
        public override string ToString() => string.Format("{0,-20} {1}", FullName, address.ToString());

        /// <summary>
        /// Validate the participant information
        /// </summary>
        /// <returns> Return false if address or names are empty or null </returns>
        public bool Validate() => !(!address.Validate() || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(SecondName));

        #endregion
    }
}
