using LotrEntities;
using LotrEntities.Armors;
using LotrEntities.Warriors;
using LotrEntities.Weapons;
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
            };

            var saruman = new SlaverMaia
            {
                Name = "Saruman",
                Color = "White",
                Master = morgoth,
            };

            var sauron = new SlaverMaia
            {
                Name = "Sauron",
                Color = "Black",
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
            Console.WriteLine("---------------------------");

            var elf = new ElfArcher
            {
                Name = "Legolas",
                Weapon = new Bow(150, 60),
                HealthPoints = 2500,
                Height = 185,
                MainArmor = new ElvenArmor { Defense = 120},
                SideArmor = new Shield { Defense = 30 },
            };

            var bburukhai = new UrukHai
            {
                Name = "Big Bad Urukhai",
                Weapon = new Sword(200),
                HealthPoints = 3000,
                Height = 225,
                Master  = saruman,
                MainArmor = new Shield{ Defense = 50},
            };

            int turn = 0;
            while (elf.IsAlive && bburukhai.IsAlive)
            {
                if (turn % 2 == 0)
                {
                    elf.Attack(bburukhai);
                }
                else
                {
                    bburukhai.Attack(elf);
                }
                turn += 1;
                Console.WriteLine($"Turn #{turn}");
                Console.WriteLine(elf);
                Console.WriteLine(bburukhai);
                Console.WriteLine("---------------------------");
            }

            if (elf.IsAlive)
            {
                Console.WriteLine($"{elf.Name} wins, {bburukhai.Name} is dead");
            }
            else
            {
                Console.WriteLine($"{bburukhai.Name} wins, {elf.Name} is dead");
            }
            

        }
    }
}
