using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Address
    {
        private string streetName;
        public string StreetName {
            get { return streetName; }
            set { streetName = value; }
        }

        public string StreetNumber { get; set; }
        public string City { get; set; }

        public Address(string city, string street, string number)
        {
            streetName = street;
            StreetNumber = number;
            City = city;
        }

        public string GetFullAddress()
        {
            return StreetName + ", no." + StreetNumber + ", " + City;
        }
    }
}
