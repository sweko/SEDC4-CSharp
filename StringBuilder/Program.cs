using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Person
    {
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = InitNames();
            Console.WriteLine(result.Count());

            Stopwatch s = Stopwatch.StartNew();
            string json = JsonConvert.SerializeObject(result);
            s.Stop();
            Console.WriteLine(json.Length);
            Console.WriteLine(s.ElapsedMilliseconds);

            s = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.Append(item.One + item.Two + item.Three + item.Four + item.Five);
            }
            string allNames = sb.ToString();
            s.Stop();
            Console.WriteLine(allNames.Length);
            Console.WriteLine(s.ElapsedMilliseconds);
        }

        private static IEnumerable<Person> InitNames()
        {
            var names = new List<string>
            {
                "Aleksandar", "Blagoja","Vladimir", "Goran", "Dejan", "Efrem",
                "Gjoko", "Stefan", "Petar", "Risto", "Blazo",
            };

            return
                from n1 in names
                from n2 in names
                from n3 in names
                from n4 in names
                from n5 in names
                select new Person
                {
                    One = n1,
                    Two = n2,
                    Three = n3,
                    Four = n4,
                    Five = n5
                };
        }
    }
}
