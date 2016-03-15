using LinqClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var persons = InitPersons();
            PrintPersons(persons);

            var malePersons = GetPersonsFilter(persons, p => p.Gender == Gender.Male);
            PrintPersons(malePersons);

            Console.Write("Enter cutoff age: ");
            int cutoff = int.Parse(Console.ReadLine());

            var youngPersons = GetPersonsFilter(persons, p => p.Age < cutoff);
            PrintPersons(youngPersons);

            var firstNameLonger = GetPersonsFilter(persons, p => p.FirstName.Length > p.LastName.Length);
            PrintPersons(firstNameLonger);


            var weko = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Age = 0x26,
                Gender = Gender.Male
            };

            Action<Person> personPrinter = p => Console.WriteLine(p);
            personPrinter(weko);

            Func<Person, string> fullNameGetter = p => p.FirstName + " " + p.LastName;
            var wekoFullName = fullNameGetter(weko);
            Console.WriteLine(wekoFullName);
            */
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine(person);
        }

        private static string GetFullName(Person person)
        {
            return person.FirstName + " " + person.LastName;
        }


        private static IEnumerable<Person> GetPersonsFilter(IEnumerable<Person> persons, Func<Person, bool> filter)
        {
            var result = new Stack<Person>();
            foreach (var person in persons)
            {
                if (filter(person))
                {
                    result.Push(person);
                }
            }
            return result;
        }

        private static void PrintPersons(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("---------------------------");
        }

        private static IEnumerable<Person> InitPersons()
        {
            var persons = new List<Person>();
            persons.Add(new Person
            {
                FirstName = "Walter",
                LastName = "White",
                Age = 52,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Jesse",
                LastName = "Pinkman",
                Age = 31,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Skyler",
                LastName = "White",
                Age = 41,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Walter Jr",
                LastName = "White",
                Age = 18,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Hank",
                LastName = "Schrader",
                Age = 48,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Marie",
                LastName = "Schrader",
                Age = 38,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Gustavo",
                LastName = "Fring",
                Age = 49,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Lydia",
                LastName = "Rodarte-Quayle",
                Age = 33,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Saul",
                LastName = "Goodman",
                Age = 54,
                Gender = Gender.Male
            });

            return persons;
        }



    }
}
