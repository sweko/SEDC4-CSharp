using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Vehicle
    {
        public Vehicle(string manufacturer, string brand, int topSpeed)
        {
            this.Manufacturer = manufacturer;
            this.Brand = brand;
            this.TopSpeed = topSpeed;
        }
        public string Manufacturer { get; set; }
        public string Brand { get; set; }
        public int TopSpeed { get; set; }

        public string CarDetails
        {
            get
            {
                return Manufacturer + " " + Brand + ", " + TopSpeed;
            }
            set
            {

            }
        }
    }
}
