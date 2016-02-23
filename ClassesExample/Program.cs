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

            characters.Add(new Person("Walter", "White", 52, new Address("Albuquerque", "Negra Arroyo Lane", "308"), new Vehicle("Aztec", "Pontiac", 2004)));
            characters.Add(new Person("Skyler", "White", 47, new Address("Albuquerque", "Negra Arroyo Lane", "308"), new Vehicle("Grand Wagoneer", "Jeep", 1991)));
            characters.Add(new Person("Jesse", "Pinkman", 36, new Address("Albuquerque", "Margo St.", "9809"), new Vehicle("Tercel", "Toyota", 1986)));
            characters.Add(new Person("Hank", "Schrader", 52, new Address("Albuquerque", "Cumbre del Sur Court", "4901"), new Vehicle("Commander", "Jeep", 2006)));
            characters.Add(new Person("Saul", "Goodman", 52, new Address("Albuquerque", "Montgomery Blvd", "9800"), new Vehicle("de Ville", "Cadillac", 1997)));

            Console.WriteLine("Breaking Bad characters: \n");

            foreach (Person character in characters)
            {
                Console.WriteLine($"Full Name: {character.FullName}\nAge: {character.Age}\nAddress: {character.Address.GetFullAddress()}\nVehicle: {character.Car.GetFullCarName()}\nYear: {character.Car.Year}\n");
            }

            Console.ReadLine();


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

