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
            List<Person> characters = new List<Person>();

            var waltsHouse = new Address("Albuquerque", "Negra Arroyo Lane", "308");
            var walt = new Person("Walter", "White", 52, waltsHouse, new Vehicle("Aztec", "Pontiac", 2004));
            characters.Add(walt);

            var skyler = new Person("Skyler", "White", 47, waltsHouse, new Vehicle("Grand Wagoneer", "Jeep", 1991));
            characters.Add(skyler);

            var jesse = new Person("Jesse", "Pinkman", 36, new Address("Albuquerque", "Margo St.", "9809"), new Vehicle("Tercel", "Toyota", 1986));
            characters.Add(jesse);

            var hank = new Person("Hank", "Schrader", 52, new Address("Albuquerque", "Cumbre del Sur Court", "4901"), new Vehicle("Commander", "Jeep", 2006));
            characters.Add(hank);

            var saul = new Person("Saul", "Goodman", 52, new Address("Albuquerque", "Montgomery Blvd", "9800"), new Vehicle("de Ville", "Cadillac", 1997));
            characters.Add(saul);

            var areAgesEqual = hank.Age == saul.Age;
            Console.WriteLine("areAgesEqual "+areAgesEqual);

            var areAddressesEqual = walt.Address == skyler.Address;
            Console.WriteLine("areAddressesEqual " + areAddressesEqual);

            Console.WriteLine(walt.Address.StreetName == skyler.Address.StreetName);
            Console.WriteLine(walt.Address.StreetNumber == skyler.Address.StreetNumber);
            Console.WriteLine(walt.Address.City == skyler.Address.City);

            var fiesta1 = new Vehicle("Fiesta", "Ford", 2001);
            var fiesta2 = new Vehicle("Fiesta", "Ford", 2001);

            Console.WriteLine(fiesta1.Year == fiesta2.Year);


            //Console.WriteLine("Breaking Bad characters: \n");

            //foreach (Person character in characters)
            //{
            //    Console.WriteLine($"Full Name: {character.FullName}\nAge: {character.Age}\nAddress: {character.Address.GetFullAddress()}\nVehicle: {character.Car.GetFullCarName()}\nYear: {character.Car.Year}\n");
            //}

            //Console.WriteLine("--------------");
            //var weko = new Person(
            //    "Wekoslav", 
            //    "Stefanovski",
            //    new Address("Skopje", "Infinity Drive", "1"),
            //    null
            //);

            //Console.WriteLine(weko.FullName);

            /*
            var weko = new Person("Wekoslav","Stefanovski", 0x26);

            var jasmina= new Person("Jasmina", "Kostova");
            jasmina.Age = 3;

            Console.WriteLine($"Person is {weko.FullName} and is {weko.Age} years old");
            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            jasmina.Age += 1;

            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            //weko.FullName = "Stavre Jovevski";

            //jasmina.Age = -19;
            */


        }
    }
}

