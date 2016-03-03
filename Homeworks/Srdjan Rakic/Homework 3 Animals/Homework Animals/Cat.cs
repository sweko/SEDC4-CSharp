using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    class Cat : Animal
    {
        public override string Name { get; set; }
        public override string Specie { get; set; }
        public override string Color { get; set; }
        public string Breed { get; set; }
        public override string Age { get; set; }

        public Cat(string name, string specie, string color, string breed ,string age)
        {
            Name = name;
            Specie = specie;
            Color = color;
            Breed = breed;
            Age = age;
        }

        public override string makeSound()
        {
            return ("Meow!");
        }

    }
}
