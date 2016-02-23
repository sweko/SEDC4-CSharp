using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad_homework
{
    class Vehicle
    {
        private string name;
        private string manufacturer;
        private int year;
        private string color;

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

        public string getFullCarName()
        {
            return Manufacturer + " - " + Name;
        }

        public int getYear()
        {
            return Year;
        }

        public string getVehicleColor()
        {
            return Color;
        }
    }

}
