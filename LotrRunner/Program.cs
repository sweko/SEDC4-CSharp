using LotrEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();

            humans.Add(new Human
            {
                Name = "Aragorn",
                HealthPoints = 2000,
                Height = 195
            });

            humans.Add(new Hobbit
            {
                Name = "Bilbo Baggins",
                HealthPoints = 500,
                Height = 100,
                Clan = HobbitClan.Bagginses
            });

            humans.PrintItems();

            var morgoth = new Vala
            {
                Name = "Morgoth",
                Slaves = new List<UrukHai>()
            };

            var saruman = new SlaverMaia
            {
                Name = "Saruman",
                Color = "White",
                Slaves = new List<UrukHai>(),
                Master = morgoth,
            };

            var sauron = new SlaverMaia
            {
                Name = "Sauron",
                Color = "Black",
                Slaves = new List<UrukHai>(),
                Master = morgoth,
            };

            List<UrukHai> urukhai = new List<UrukHai>
            {
                new UrukHai
                {
                    Name = "Urukhai 1",
                    Height = 240,
                    HealthPoints = 5000,
                    Master = saruman
                },
                new UrukHai
                {
                    Name = "Urukhai 2",
                    Height = 240,
                    HealthPoints = 5000,
                    Master = saruman
                },
                new UrukHai
                {
                    Name = "Urukhai 3",
                    Height = 240,
                    HealthPoints = 5000,
                    Master = sauron
                },
                new UrukHai
                {
                    Name = "Urukhai 3",
                    Height = 240,
                    HealthPoints = 5000,
                    Master = morgoth
                },
            };

            var gandalf = new Maia
            {
                Name = "Gandalf",
                Color = "Gray",
                Master = new Vala
                {
                    Name = "Aule"
                }
            };

            urukhai.PrintItems();

            Console.WriteLine(gandalf);
            Console.WriteLine(saruman);
            Console.WriteLine(sauron);

        }
    }
}
