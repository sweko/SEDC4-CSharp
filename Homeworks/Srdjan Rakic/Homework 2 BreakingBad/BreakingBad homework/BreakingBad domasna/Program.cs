using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> characters = new List<Person>();

            characters.Add(new Person("Walter", "White", 59, new Address("Albuquerque", "Negra Arroyo Lane", "308"), new Vehicle("Aztec", "Pontiac", 2004, "Fern Green")));
            characters.Add(new Person("Skyler", "White", 47, new Address("Albuquerque", "Negra Arroyo Lane", "308"), new Vehicle("Grand Wagoneer", "Jeep", 1991, "Red")));
            characters.Add(new Person("Jesse", "Pinkman", 36, new Address("Albuquerque", "Margo St.", "9809"), new Vehicle("Tercel", "Toyota", 1986, "Red")));
            characters.Add(new Person("Hank", "Schrader", 52, new Address("Albuquerque", "Cumbre del Sur Court", "4901"), new Vehicle("Commander", "Jeep", 2006, "Black")));
            characters.Add(new Person("Saul", "Goodman", 52, new Address("Albuquerque", "Montgomery Blvd", "9800"), new Vehicle("de Ville", "Cadillac", 1997, "White")));

            Console.WriteLine("Breaking Bad characters: \n");

            foreach (Person character in characters)
            {
                Console.WriteLine($"Full Name: {character.FullName}\nAge: {character.Age}\nAddress: {character.Address.getFullAddress()}\nVehicle: {character.Vehicle.getFullCarName()}\nYear: {character.Vehicle.getYear()}\nColor: {character.Vehicle.getVehicleColor()}\n");
            }

            Console.ReadLine();
        }
    }
}

