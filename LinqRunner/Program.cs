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

            var persons = InitPersons();
            PrintItems(persons);
            /*
            var malePersons = GetItemFilter(persons, p => p.Gender == Gender.Male);
            PrintItems(malePersons);

            Console.Write("Enter cutoff age: ");
            int cutoff = int.Parse(Console.ReadLine());

            var youngPersons = GetItemFilter(persons, p => p.Age < cutoff);
            PrintItems(youngPersons);

            var firstNameLonger = GetItemFilter(persons, p => p.FirstName.Length > p.LastName.Length);
            PrintItems(firstNameLonger);
            */
            /*
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
            /*
            var fields = InitFields();
            PrintItems(fields);

            var over100 = GetItemFilter(fields, f => f.Area > 100);
            PrintItems(over100);


            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintItems(GetItemFilter(numbers, n => n % 2 == 0));
            */
            //males under 40

            var mu40 = persons
                .Filter(p => p.Gender == Gender.Male)
                .Where(p => p.Age < 40)
                .Where(p => p.FirstName.Length > p.LastName.Length);

            PrintItems(mu40);
        }

        private static IEnumerable<RectangleField> InitFields()
        {
            var fields = new List<RectangleField>
            {
                new RectangleField { Height = 10, Width = 10 },
                new RectangleField { Height = 7, Width = 12 },
                new RectangleField { Height = 9, Width = 15 },
                new RectangleField { Height = 12, Width = 4 },
                new RectangleField { Height = 6, Width = 2 },
                new RectangleField { Height = 14, Width = 20 },
                new RectangleField { Height = 7, Width = 9 },
            };
            return fields;
        }

        //private static void PrintPerson(Person person)
        //{
        //    Console.WriteLine(person);
        //}

        //private static string GetFullName(Person person)
        //{
        //    return person.FirstName + " " + person.LastName;
        //}

        //private static void PrintPersons(IEnumerable<Person> persons)
        //{
        //    foreach (var person in persons)
        //    {
        //        Console.WriteLine(person);
        //    }
        //    Console.WriteLine("---------------------------");
        //}

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

        //private static IEnumerable<Person> GetPersonsFilter(IEnumerable<Person> persons, Func<Person, bool> filter)
        //{
        //    var result = new Stack<Person>();
        //    foreach (var person in persons)
        //    {
        //        if (filter(person))
        //        {
        //            result.Push(person);
        //        }
        //    }
        //    return result;
        //}

        //private static IEnumerable<RectangleField> GetFieldFilter(IEnumerable<RectangleField> fields, Func<RectangleField, bool> filter)
        //{
        //    var result = new Stack<RectangleField>();
        //    foreach (var field in fields)
        //    {
        //        if (filter(field))
        //        {
        //            result.Push(field);
        //        }
        //    }
        //    return result;
        //}

        //private static IEnumerable<T> GetItemFilter<T>(IEnumerable<T> items, Func<T, bool> filter)
        //{
        //    var result = new Queue<T>();
        //    foreach (var item in items)
        //    {
        //        if (filter(item))
        //        {
        //            result.Enqueue(item);
        //        }
        //    }
        //    return result;
        //}

        private static void PrintItems<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
        }

    }
}

