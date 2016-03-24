using LotrEntities.Warriors;
using LotrEntities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class WarriorFactory
    {
        public IEnumerable<IWarrior> GetBadGuys(int count)
        {
            var saruman = new SlaverMaia
            {
                Name = "Saruman",
                Color = "White",
                Master = new Vala
                {
                    Name = "Morgoth"
                }
            };

            var result = new List<UrukHai>();
            for (int i = 0; i < count; i++)
            {
                result.Add(new UrukHai
                {
                    Weapon = new Sword(200),
                    HealthPoints = 3000,
                    Name = $"Urukhai #{i + 1}",
                    Master = saruman
                });
            }
            return result;
        }

        private List<Func<int, IWarrior>> generators;

        public WarriorFactory()
        {
            generators = new List<Func<int, IWarrior>>{
                i => GetElfWarrior($"Elf {i + 1}"),
                i => GetHobbitWarrior($"Hobbit {i + 1}"),
                i => GetHumanWarrior($"Human {i + 1}"),
                i => GetDwarfWarrior($"Dwarf {i + 1}")
            };
        }

        public IEnumerable<IWarrior> GetGoodGuys(int count)
        {
            Random r = new Random();
            List<IWarrior> result = new List<IWarrior>();
            for (int i = 0; i < count; i++)
            {
                var type = r.Next(4);
                var generator = generators[type];
                result.Add(generator(i));
            }
            return result;
        }

        public IWarrior GetElfWarrior(string name)
        {
            return new ElfArcher
            {
                Name = name,
                HealthPoints = 1500,
                Weapon = new Bow(200, 100)
            };
        }

        public IWarrior GetHobbitWarrior(string name)
        {
            return new HobbitWarrior
            {
                Name = name,
                HealthPoints = 1500,
                Weapon = new Sword(200)
            };
        }

        public IWarrior GetHumanWarrior(string name)
        {
            return new HumanWarrior
            {
                Name = name,
                HealthPoints = 1500,
                Weapon = new Staff(200, 100)
            };
        }

        public IWarrior GetDwarfWarrior(string name)
        {
            return new DwarfWarrior
            {
                Name = name,
                HealthPoints = 3500,
                Weapon = new Sword(300)
            };
        }

    }
}
