using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                FileStream fs = null;
                try
                {
                    fs = File.Open("somefile.txt", FileMode.OpenOrCreate);
                    int x = int.Parse(input);
                    Console.WriteLine($"1000 divided by {x} is {1000 / x}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{input} is not a valid number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected exception occured: {ex.Message}");
                    throw;
                }
                finally
                {
                    Console.WriteLine("Closing file");
                    if (fs != null)
                        fs.Close();
                }

            }

        }
    }
}
