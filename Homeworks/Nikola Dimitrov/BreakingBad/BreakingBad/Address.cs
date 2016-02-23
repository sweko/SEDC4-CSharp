using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    public class Address
    {
        public Address (string streetName, string streetNumber, string city, string country)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.city = city;
            this.country = country;

        }

        public Address()
        {
        }

        private string streetName;
        private string streetNumber;
        private string city;
        private string country;

        public string FullAddress
        {
            get
            {
                return $"{streetName} {streetNumber}, {city}, {country}";
            }         
        }


    }

   
   
}
