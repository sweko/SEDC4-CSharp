using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamo
{
    public static class DynCreator
    {
        static private Random r = new Random();

        public static dynamic GetSomeObject()
        {
            return GetSomeObject(r.NextDouble());
        }

        public static dynamic GetSomeObject(double value)
        {
            if (value > 0.5)
                return new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };
            else if (value > 0.2)
                return new Vehicle { Make = "Toyota", Model = "Corolla", Year = 2005 };
            else
                return new List<int> { 2, 4, 6, 8, 10 };
        }
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} from {Year}";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
