using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Inheritance
{
    public abstract class Pet
    {
        public string Name { get; }

        public string Specie { get; }

        public DateTime DateOfBirth { get; }

        public TimeSpan Age {
            get {
                return DateTime.Now - DateOfBirth;
            }
        }

        public string Color { get; }

        public abstract void makeNoise();


        public Pet(string name, string specie, string color, DateTime dateOfBirth )
        {
            Name = name;
            Specie = specie;
            DateOfBirth = dateOfBirth;
            Color = color;
        }
    }
}
