using MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement
{
    public class PersonManager
    {
        private List<Person> persons = new List<Person>();

        public void Reset()
        {
            persons = GetDefaultPersons();
        }

        private List<Person> GetDefaultPersons()
        {
            return new List<Person>
            {
                new Person {ID = 1, FirstName = "Francis", LastName = "Ford Coppola" },
                new Person {ID = 2, FirstName = "Martin", LastName = "Sheen" },
                new Person {ID = 3, FirstName = "Robert", LastName = "Duval"},
                new Person {ID = 4, FirstName = "Dennis", LastName = "Hopper"},
                new Person {ID = 5, FirstName = "Marlon", LastName = "Brando"},
                new Person {ID = 6, FirstName = "John", LastName = "Travolta" },
                new Person {ID = 7, FirstName = "Samuel", LastName = "Jackson" },
                new Person {ID = 8, FirstName = "Bruce", LastName = "Willis" },
                new Person {ID = 9, FirstName = "Quentin", LastName="Tarantino"},
                new Person {ID = 10, FirstName = "Brad", LastName = "Pitt" },
                new Person {ID = 11, FirstName = "Edward", LastName = "Norton" },
                new Person {ID = 12, FirstName = "Helena", LastName = "Bonham Carter" },
                new Person {ID = 13,  FirstName = "David", LastName = "Fincher" }
            };
        }

        internal Person GetPersonById(int id)
        {
            foreach (var person in persons)
            {
                if (person.ID == id)
                    return person;
            }
            return null;
        }

        internal Person GetPerson(string firstName, string lastName)
        {
            foreach (var person in persons)
            {
                if ((person.FirstName == firstName) && (person.LastName == lastName))
                    return person;
            }
            return null;
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public List<Person> GetAllPersons()
        {
            return persons;
        }

        public List<Person> GetAllMales()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllFemales()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllLiving()
        {
            throw new NotImplementedException();
        }

    }
}
