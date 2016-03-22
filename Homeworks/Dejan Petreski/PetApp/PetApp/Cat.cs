using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Cat : Pet
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string MakeNoise()
        {
            return "Cat says: Meow!";
        }
    }
}
