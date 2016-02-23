using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            var walter = new Person("Walter", "White", new Address("Piermont Dr", "3828"), new Vehicle("Pontiac", "Aztek 2004", 170));

            var jesse = new Person("Jesse", "Pinkman", new Address("Margo St.", "9809"), new Vehicle("Toyota", "Tercel 1986", 130));

            Console.WriteLine($"{walter.FullName}, {walter.Address.FullAddress}, {walter.Vehicle.CarDetails}");
            Console.WriteLine($"{jesse.FullName}, {jesse.Address.FullAddress}, {jesse.Vehicle.CarDetails}");

        }
    }
}
