using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    class Fox : Animal
    {
        
        public Fox(string name, string specie, string color, string age)
        {
            Name = name;
            Specie = specie;
            Color = color;
            Age = age;
        }

        public override string MakeSound()
        {
           return "Fox says : Ring - ding - ding - ding - dingering!";
        }

    }
}
