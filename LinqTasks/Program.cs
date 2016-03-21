﻿using LinqClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumAge = InitPersons()
                .Where(p => p.Gender == Gender.Female)
                .Sum(p => p.Age);

            Console.WriteLine($"Sum of ages of all female characters is {sumAge}");

            var age = 6;
            var young = InitPersons()
                .FirstOrDefault(p => p.Age < age);

            if (young != null)
                Console.WriteLine($"First person under {age} is {young.Age} old");
            else
                Console.WriteLine($"No one is under {age} years old");

            var oldestLastName = 
                InitPersons()
                .OrderByDescending(p => p.Age)
                .First().LastName;

            var oldestLastNameLinq =
                (from p in InitPersons()
                 orderby p.Age descending
                 select p).First().LastName;

            Console.WriteLine($"oldest is >>{oldestLastName}<<");
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

            persons.Add(new Person
            {
                FirstName = "Madonna",
                LastName = "Chicone",
                Age = 500,
                Gender = Gender.Female
            });

            return persons;
        }
    }
}
