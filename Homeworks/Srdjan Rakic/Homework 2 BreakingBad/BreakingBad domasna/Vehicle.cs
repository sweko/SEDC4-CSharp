using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(string name, string manufacturer, int year, string color)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
            Color = color;
        }

        public string GetFullCarName()
        {
            return Manufacturer + " - " + Name;
        }

    }

}
