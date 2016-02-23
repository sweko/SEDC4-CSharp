using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    public class Vehicle
    {
        public Vehicle(string vehicleType, string brand, string model, int modelYear, string color)
        {
            this.vehicleType = vehicleType;
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.color = color;
        }

        private string vehicleType;
        private string brand;
        private string model;
        private int modelYear;
        private string color;

        public Vehicle()
        {
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }

        public string Car
        {
            get
            {
                return brand + " " + model;
            }
        }

        public int ModelYear
        {
            get
            {
                return modelYear;
            }
            set
            {
                modelYear = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
    }
}
