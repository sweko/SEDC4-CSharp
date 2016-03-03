using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsDemo
{
    public static class LinqDemo
    {
        public static List<Person> persons = new List<Person>
        {
            new Person { Name = "Pero", Age =25, IsMale = true},
            new Person { Name = "Martin", Age =64, IsMale = true},
            new Person {Name = "Persa", Age = 73, IsMale = false },
            new Person {Name = "Martina", Age = 18, IsMale = false }
        };


        public static int GetMaleAge()
        {
            //return Enumerable.Sum(Enumerable.Where(persons, p => p.IsMale), p => p.Age);
            return persons.Where(p => p.IsMale).Sum(p => p.Age);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
    }

}
