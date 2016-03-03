    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Pet>
            {
                new Dog("Asha", 4),
                new Cat("Tina", 3),
                new Lion("King", 8),
                new Fox("Fox", 5)
            };

            
            foreach (var pet in pets)
            {
                Console.WriteLine(pet.MakeNoise().ToString());
            }
        }
    }
}
