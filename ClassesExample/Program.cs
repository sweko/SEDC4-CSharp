using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person("Wekoslav","Stefanovski", 0x26);

            var jasmina= new Person("Jasmina", "Kostova");
            jasmina.Age = 3;

            Console.WriteLine($"Person is {weko.FullName} and is {weko.Age} years old");
            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            jasmina.Age += 1;

            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            var breakingBadActors = new List<Person>() {
                                new Person("Walter", "White", 50),
                                new Person("Walter Jr", "White", 17),
                                new Person("Skyler", "White", 45),
                                new Person("Jesse", "Pinkman", 27),
                                new Person("Gustavo", "Fring", 50)
            };
            breakingBadActors[0].Vehicle = new Vehicle("Pontiac", "Aztek", 2004, "Fern Green");
            breakingBadActors[1].Vehicle = new Vehicle("Dodge", "Challenger SE Rallye", 2009, "Red");
            breakingBadActors[2].Vehicle = new Vehicle("Jeep", "Grand Wagoneer", 1991, "Red");
            breakingBadActors[3].Vehicle = new Vehicle("Toyota", "Tercel Wagon 4WD", 1986, "Red");
            breakingBadActors[4].Vehicle = new Vehicle("Volvo", "V70 (Gen. 1)", 1998, "Blue");

            Console.WriteLine("Breaking Bad actors:");
            Console.WriteLine("-------------------------------------");
            foreach (var actor in breakingBadActors)
            {
                Console.WriteLine(actor);
            }
            Console.WriteLine("-------------------------------------");

            //weko.FullName = "Stavre Jovevski";

            //jasmina.Age = -19;



        }
    }
}

