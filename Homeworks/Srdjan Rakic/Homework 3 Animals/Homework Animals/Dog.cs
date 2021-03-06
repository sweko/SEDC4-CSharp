﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string specie, string color, string breed, string age)
        {
            Name = name;
            Specie = specie;
            Color = color;
            Breed = breed;
            Age = age;
        }

        public override string MakeSound()
        {
            return "Dog says: Woof!";
        }
    }
}
