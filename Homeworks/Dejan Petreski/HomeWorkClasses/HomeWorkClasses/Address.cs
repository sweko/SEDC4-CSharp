using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Address
    {
        public Address(string streetName, string streetNumber)
        {
            this.StreetName = streetName;
            this.StreetNumber = streetNumber;
        }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }

        public string FullAddress
        {
            get
            {
                return StreetName + " " + StreetNumber;
            }
            set
            {

            }
        }
    }
}
