using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Pet>
            {
                new Dog("Lassie", "Black", "Shetland Sheepdog", new DateTime(2010, 10, 10)),
                new Cat("Marko", "Grey", "Aegean", new DateTime(2013, 10, 13)),
                new Parrot("Mirko", "Green", "Green parakeet", new DateTime(2015, 11, 13)),
            };

            
            foreach (var pet in pets)
            {
                pet.makeNoise();
            }

            Console.ReadLine();
        }
    }
}
