using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.HR
{
    internal class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private string country;


        public Address(string street, string city, string zipCode, string country)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }

        public string Street
        {
            get { return street; }
            set
            {
                street = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            { city = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                zipCode = value;
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
    }
}
