using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad_homework
{
    class Address
    {
        private string city;
        private string streetName;
        private string streetNumber;

        public Address(string city, string streetName, string streetNumber)
        {
            City = city;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public string City { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }

        public string getFullAddress()
        {
            return StreetName + ", no." + StreetNumber + ", " + City;
        }

    }
}
