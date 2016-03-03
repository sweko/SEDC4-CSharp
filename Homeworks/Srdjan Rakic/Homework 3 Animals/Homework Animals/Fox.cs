using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    class Fox : Animal
    {
        public override string Name { get; set; }
        public override string Specie { get; set; }
        public override string Color { get; set; }
        public override string Age { get; set; }

        public Fox(string name, string specie, string color, string age)
        {
            Name = name;
            Specie = specie;
            Color = color;
            Age = age;
        }


        public override string makeSound()
        {
            return ("Ring-ding-ding-ding-dingering");
        }

    }
}
