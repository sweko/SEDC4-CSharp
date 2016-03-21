using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Vehicle
    {
        public Vehicle(string manufacturer, string model, ushort year, string color)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Color = color;
        }

        private string Manufacturer { get; set; }

        private string Model { get; set; }

        private ushort Year { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var result = "";
            result += "Manufacturer: " + Manufacturer;
            result += " Model: " + Model;
            result += " Year: " + Year;
            result += " Color: " + Color;
            return result;
        }

    }
}
