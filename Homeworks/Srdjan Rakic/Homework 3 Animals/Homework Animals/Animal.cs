using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animals
{
    public class Animal
    {
        public int id;
        static int sID = 0;

        public string Name { get; set; }
        public string Specie { get; set; }
        public string Color { get; set; }
        public string Age { get; set; }

  
        public Animal()
        {
            id = ++sID;
        }

        public virtual string MakeSound()
        {
             return null;
        }
    }
}
