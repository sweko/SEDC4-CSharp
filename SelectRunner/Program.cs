using LinqClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 2, 3, 5, 7, 8, 11, 13, 16 };

            //   3     5      7    11    13
            // {1.73, 2.23, 2.64, 3.31, 3.60}

            //var result = GetMappedItems(numbers.Filter(n => n % 2 == 1), n => Math.Sqrt(n));

            var result = numbers
                .Where(n => n % 2 == 1)
                .Select(n => Math.Sqrt(n));
            result.PrintItems();


            var otherResults = 
                from n in numbers
                where n % 2 == 1
                select Math.Sqrt(n);

            otherResults.PrintItems();

            var cubes = numbers
                .Filter(n => n % 2 == 0)
                .Map(n=> n*n*n)
                .Map(n => Math.Sqrt(n));

            cubes.PrintItems();

            var names = InitPersons()
                .Map(p => $"{p.LastName}, {p.FirstName}");
            names.PrintItems();

            IEnumerable<int> ages = InitPersons().Select(p => p.Age).ToList();
            Console.WriteLine(ages.GetType().Name);
            ages.PrintItems();

            var groups = InitPersons()
                .GroupBy(p => p.LastName)
                .Where(group => group.Count() > 1)
                .ToDictionary(g=> g.Key, g => g.ToList());

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                group.Value.PrintItems();
            }

            var sumAge = InitPersons().Sum(p => p.Age);

            var aggAge = InitPersons().Aggregate(0, (a, p) => a + p.Age);

            Console.WriteLine(sumAge);
            Console.WriteLine(aggAge);

            var sum = string.Empty;
            foreach (var item in InitPersons())
            {
                sum = sum + " " + item.LastName;
            }

            var aggLastName = InitPersons().Aggregate(string.Empty, (a, p) => a + " " + p.LastName);
            Console.WriteLine(aggLastName);

            var persons = groups.SelectMany(g => g.Value).ToList();
            persons.PrintItems();

        }

        //private static IEnumerable<int> GetAges(IEnumerable<Person> persons)
        //{
        //    var ages = new List<int>();
        //    foreach (var person in persons)
        //    {
        //        ages.Add(person.Age);
        //    }
        //    return ages;
        //}

        //private static IEnumerable<string> GetLastNameFirstName(IEnumerable<Person> persons)
        //{
        //    var names = new List<string>();
        //    foreach (var person in persons)
        //    {
        //        names.Add($"{person.LastName}, {person.FirstName}");
        //    }
        //    return names;
        //}

        //private static IEnumerable<int> GetCubes(IEnumerable<int> numbers)
        //{
        //    var cubes = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        cubes.Add(number * number * number);
        //    }
        //    return cubes;
        //}

        //private static IEnumerable<double> GetSquareRoots(IEnumerable<int> numbers)
        //{
        //    var result = new List<double>();
        //    foreach (var number in numbers)
        //    {
        //        result.Add(Math.Sqrt(number));
        //    }
        //    return result;
        //}

        //private static IEnumerable<TOut> GetMappedItems<TIn, TOut>(IEnumerable<TIn> source, Func<TIn, TOut> mapper) {
        //    var result = new List<TOut>();
        //    foreach (var item in source)
        //    {
        //        result.Add(mapper(item));
        //    }
        //    return result;
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
    }
}
