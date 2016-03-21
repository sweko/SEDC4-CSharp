using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            const string file = @"data.json";

            //1. Read Data
            //1.a. Does previous data exist?
            var dictionary = new Dictionary<string, string>();

            if (File.Exists(file))
            //1.a.1 Prev data exist => Load Data
            {
                //1.a.1.a Read text from file
                var source = File.ReadAllText(file);
                //1.a.1.b deserialize to dictionary
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(source);
            }
            //1.a.2 Prev data does not exist => empty data


            //2. Add new data
            //2.a. Input new word
            Console.Write("Enter english word:");
            var english = Console.ReadLine();
            //2.b. Input new translation
            Console.Write("Enter macedonian word:");
            var macedonian = Console.ReadLine();
            //2.c. Add to existing data
            dictionary.Add(english, macedonian);

            //3. Write Data
            //3.a Write to file
            //3.a.1 Serialize to text
            var output = JsonConvert.SerializeObject(dictionary);
            //3.a.2 write text to file
            File.WriteAllText(file, output);
        }
    }
}
