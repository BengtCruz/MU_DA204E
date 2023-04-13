using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        public Address(string street, string city, string zipCode, Countries country)
        {
           this.street = street;
           this.city = city;   
           this.zipCode = zipCode;
           this.country = country;
        }

        public Address(string street, string city, string zip) : this(street, city, zip, Countries.Sweden) { }

        public Address() : this("","","") { }

        public Address(Address copyAnother)
        {
            this.street = copyAnother.street;
            this.city = copyAnother.city;
            this.zipCode = copyAnother.zipCode;
            this.country = copyAnother.country;
        }

        public string Street { get { return street; } set { street = value; } }

        public string City { get { return city; } set { city = value; } }   

        public string ZipCode { get { return zipCode; } set { zipCode = value; } }

        public Countries Countries { get { return country; } set { country = value;} }
    }
}
