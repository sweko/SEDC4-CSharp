using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToMacedonian
{
    class Program
    {
        static void Main(string[] args)
        {
            var trData = File.ReadAllText(@"data.json");
            var translations = JsonConvert.DeserializeObject<Dictionary<string, string>>(trData);

            while (true)
            {
                Console.Write("Enter word (in english): ");
                var word = Console.ReadLine();

                if (translations.ContainsKey(word))
                {
                    Console.WriteLine($"{word} translates to {translations[word]}");
                }
                else
                {
                    Console.WriteLine($"{word} not found in dictionary");
                }
            }
        }
    }
}
