using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    public abstract class Animal
    {
        public int id;
        static int sID = 0;

        public abstract string Name { get; set; }
        public abstract string Specie { get; set; }
        public abstract string Color { get; set; }
        public abstract string Age { get; set; }

        public abstract string makeSound();

        public Animal()
        {
            id = ++sID;
        }

    }
}
