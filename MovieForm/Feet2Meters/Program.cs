using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feet2Meters
{
    class Program
    {
        static void Main(string[] args)
        {
            //vnesi vo feet
            Console.Write("Enter value in feet: ");
            string input = Console.ReadLine();
            double feet = double.Parse(input);
            //presmetaj vo metri
            double conversionFactor = 0.3048;
            double meters = feet * conversionFactor;
            //ispecati metri
            Console.WriteLine("Converted " + feet.ToString("0.##") + " feet to " + meters.ToString("0.##") + " meters");
            Console.WriteLine("Converted {0:0.##} feet to {1:0.##} meters", feet, meters);
            Console.WriteLine($"Converted {feet:0.##} feet to {meters:0.##} meters");
        }
    }
}
