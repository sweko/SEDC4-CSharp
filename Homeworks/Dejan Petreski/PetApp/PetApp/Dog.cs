using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Dog : Pet
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string MakeNoise()
        {
            return "Dog says: Woof, Woof!";
        }
    }
}
