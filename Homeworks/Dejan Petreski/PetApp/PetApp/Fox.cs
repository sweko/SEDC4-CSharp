using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Fox : Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Fox(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string MakeNoise()
        {
            throw new Exception("What does the fox say?");
        }
    }
}
