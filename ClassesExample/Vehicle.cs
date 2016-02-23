using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string model, string make, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string GetFullCarName()
        {
            return Make + " - " + Model;
        }
    }
}
