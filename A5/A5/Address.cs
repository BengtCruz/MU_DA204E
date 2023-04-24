using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Address
    {
        #region FIELDS
        /* Fields */

        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        #endregion

        #region CONSTRUCTORS
        /* Constructors */

        /// <summary>
        /// Initialize an object of type Address with default values
        /// </summary>
        public Address() : this("","","") { }

        /// <summary>
        /// Initialize an object of type Address with values from another object of type Address
        /// </summary>
        /// <param name="copyAnother"></param>
        public Address(Address copyAnother) : this(copyAnother.street, copyAnother.city, copyAnother.zipCode, copyAnother.country) { }

        /// <summary>
        /// Initialize an object of type Address with values from parameters
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        /// <summary>
        /// Initialize an object of type Address with values from parameters
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zip"></param>
        public Address(string street, string city, string zip) : this(street, city, zip, Countries.Sweden) { }
        #endregion

        #region PROPERTIES
        /* Properties */

        /// <summary>
        /// Property will set or get the street for the guest in list.
        /// </summary>
        public string Street { get { return street; } set { if(!string.IsNullOrEmpty(value)) street = value; } }

        /// <summary>
        /// Property will set or get the city for the guest in list.
        /// </summary>
        public string City { get { return city; } set { if (!string.IsNullOrEmpty(value)) city = value; } }

        /// <summary>
        /// Property will set or get the zip code for the guest in list.
        /// </summary>
        public string ZipCode { get { return zipCode; } set { if (!string.IsNullOrEmpty(value)) zipCode = value; } }

        /// <summary>
        /// Property will set or get the country for the guest in list.
        /// </summary>
        public Countries Country { get { return country; } set { country = value;} }
        #endregion

        #region METHODS
        /* Methods */

        /// <summary>
        /// Get the address label
        /// </summary>
        /// <returns> A string in the form of a label with address information </returns>
        public string GetAddressLabel() => $"{Street}\n{ZipCode}  {City}";

        /// <summary>
        /// Get the country as a string
        /// </summary>
        /// <returns> Return the value of country as a string, and not as an enum. </returns>
        public string GetCountryString() => country.ToString().Replace("_"," ");

        /// <summary>
        /// Get the full address as a string
        /// </summary>
        /// <returns> A string with formatted string values and aligned in the left. </returns>
        public override string ToString() => string.Format("{0,-25} {1,-10} {2,-10} {3}", street, zipCode, city, GetCountryString());

        /// <summary>
        /// Validate whether the address is valid or not
        /// </summary>
        /// <returns> Will return false if street, city or zipcode are missing. </returns>
        public bool Validate() => !(string.IsNullOrEmpty(Street)
            || string.IsNullOrEmpty(City)
            || string.IsNullOrEmpty(ZipCode));

        #endregion
        
    }
}