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

            List<Animal> animals = new List<Animal>();
            animals.Add(garfield);
            animals.Add(baron);
            animals.Add(foxy);

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound().ToString());
            }

            Console.ReadKey();

        }

    }

}

