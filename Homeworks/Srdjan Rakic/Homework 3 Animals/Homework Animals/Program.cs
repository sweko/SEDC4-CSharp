using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat garfield = new Cat("Garfield", "feline", "gray", "Exotic Shorthair", "6");
            Dog baron = new Dog("Baron", "canine", "black", "Husky", "8");
            Fox foxy = new Fox("Foxy", "canine", "red", "4");

            //Console.WriteLine($"{garfield.Name} is an {garfield.Breed} cat and is {garfield.Age} years old. Cat says {garfield.makeSound()}");
            //Console.WriteLine($"{baron.Name} is a {baron.Breed} and is {baron.Age} years old. Dog says {baron.makeSound()}");
            //Console.WriteLine($"{foxy.Name} is a {foxy.Color} fox and is {foxy.Age} years old. What does the fox say ?\n\n{foxy.makeSound()}");

            List<Animal> animals = new List<Animal>();
            animals.Add(garfield);
            animals.Add(baron);
            animals.Add(foxy);

            foreach(Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name} says {animal.makeSound()}");
            }

            Console.ReadKey();

        }

    }

}

