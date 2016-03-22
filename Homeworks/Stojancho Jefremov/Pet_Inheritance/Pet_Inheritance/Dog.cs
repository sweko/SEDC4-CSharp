using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Inheritance
{
    public class Dog : Pet
    {

        public Dog(string name, string color, string specie, DateTime dateOfBirth) 
            : base(name, specie, color, dateOfBirth)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
