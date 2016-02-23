using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Choose character (Walter, Jesse, Hank, Skyler, Saul) from TV show Breaking Bad.");
            Console.Write("Enter the first name of character you choose: ");
            string characterName = Console.ReadLine();
            var movieCharacter = new Person(characterName);
            var characterAddress = new Address();
            var characterVehicle = new Vehicle();
            
                      

            if (characterName == "Walter")
            {
                characterAddress = new Address("Negra Arroyo Lane", "308", "Albuquerque", "New Mexico");
                characterVehicle = new Vehicle("SUV", "Pontiac", "Aztek", 2004, "green");
            }
            else if (characterName == "Jesse")
            {
                characterAddress = new Address("Margo Street", "9809", "Albuquerque", "New Mexico");
                characterVehicle = new Vehicle("compact wagon", "Toyota", "Tercel", 1986, "red");
            }
            else if (characterName == "Skyler")
            {
                characterAddress = new Address("Negra Arroyo Lane", "308", "Albuquerque", "New Mexico");
                characterVehicle = new Vehicle("wagon", "Jeep", "Grand Wagoner", 1991, "red");
            }
            else if (characterName == "Hank")
            {
                characterAddress = new Address("Cumbre del Sur Ct.", "4901", "Albuquerque", "New Mexico");
                characterVehicle = new Vehicle("SUV", "Jeep", "Comander", 2006, "dark gray");
            }
            else if (characterName == "Saul")
            {
                characterAddress = new Address("Montgomery Blvd NE 87111", "9800", "Albuquerque", "New Mexico");
                characterVehicle = new Vehicle("sedan", "Cadillac", "DeVile", 1997, "white");
            }
            else
            {
                throw new Exception("Invalid character name. You must to choose from Walter, Jesse, Hank, Skyler or Saul");
            }
            

            Console.WriteLine($"My name is {movieCharacter.FullName} and I am {movieCharacter.Age} years old.");
            Console.WriteLine($"My address is {characterAddress.FullAddress}.");
            Console.WriteLine($"I am driving {characterVehicle.VehicleType}. My car is {characterVehicle.Car} produced in {characterVehicle.ModelYear} and the color is {characterVehicle.Color}.");

            Console.ReadLine();
        }
    }
}
