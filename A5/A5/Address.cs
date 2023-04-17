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
        /// 
        /// </summary>
        public Address() : this("","","") { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="copyAnother"></param>
        public Address(Address copyAnother) : this(copyAnother.street, copyAnother.city, copyAnother.zipCode, copyAnother.country) { }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zip"></param>
        public Address(string street, string city, string zip) : this(street, city, zip, Countries.Sweden) { }
        #endregion

        #region PROPERTIES
        /* Properties */

        /// <summary>
        /// 
        /// </summary>
        public string Street { get { return street; } set { street = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string City { get { return city; } set { if (!string.IsNullOrEmpty(value)) city = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string ZipCode { get { return zipCode; } set { zipCode = value; } }

        /// <summary>
        /// 
        /// </summary>
        public Countries Countries { get { return country; } set { country = value;} }
        #endregion

        #region METHODS
        /* Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetAddressLabel() => $"{Street}           {ZipCode}  {City},{GetCountryString()}";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCountryString() => country.ToString().Replace("_"," ");

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => GetAddressLabel();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate() => !string.IsNullOrEmpty(Street)
            || !string.IsNullOrEmpty(City)
            || !string.IsNullOrEmpty(ZipCode)
            || !string.IsNullOrEmpty(ToString());
        #endregion

    }
}