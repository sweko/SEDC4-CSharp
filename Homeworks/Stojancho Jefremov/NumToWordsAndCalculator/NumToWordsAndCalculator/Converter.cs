using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordsAndCalculator
{
    public static class Converter
    {
        public static string ToWords(ulong number)
        {
            #region SpecialCases
            if (number > 999999999999)
            {
                throw new Exception($"The {number} is out of range (greater than 999999999999)!");
            }
            if (number == 0)
            {
                return "Zero";
            }
            #endregion


            //TODO implementation...
            var result = Chunk(number)
                .Select(ToEnglish)
                .Select(AppendScale)
                .Where(IsNotZero)
                .Reverse();
            return string.Join(" ", result)
                .CapitalizeFirstChar()
                .Trim();
        }

        private static string CapitalizeFirstChar(this string input)
        {
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        private static IEnumerable<ushort> Chunk(ulong number)
        {
            var thousands = new List<ushort>();
            while (number > 0)
            {
                thousands.Add((ushort)(number % 1000));
                number = number / 1000;
            }
            return thousands;
        }

        private static string ToEnglish(ushort number)
        {
            
            ushort hundreds;
            ushort tens;
            ushort ones;
            var words = new List<string>();

            var ONE_TO_NINETEEN = new ReadOnlyCollection<string> 
            (
                new List<string>
                {
                    "one", "two", "three", "four", "five",
                    "six", "seven", "eight", "nine", "ten",
                    "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                    "sixteen", "seventeen", "eighteen", "nineteen"
                }
            );
            var TENS = new ReadOnlyCollection<string>
            (
                new List<string>
                {
                    "ten", "twenty", "thirty", "forty", "fifty",
                    "sixty", "seventy", "eighty", "ninety"
                }
            );

            if (number == 0)
            {
                return "zero";
            }

            if (number < 20)
            {
                return ONE_TO_NINETEEN[number - 1];
            }

            

            if (number < 100)
            {
                ones = (ushort)(number % 10);
                tens = (ushort)(number / 10);
                words.Add(TENS[tens - 1]);
                words.Add(ONE_TO_NINETEEN[ones - 1]);
                return string.Join(" ", words.Where(IsNotZero));
            }
            
            hundreds = (ushort)(number / 100);
            words.Add(ToEnglish(hundreds));
            words.Add("hundred");
            words.Add(ToEnglish((ushort)(number % 100)));
            return string.Join(" ", words.Where(IsNotZero));


        }

        private static bool IsNotZero(string word) => !word.Equals("zero");

        private static string AppendScale(string chunk, int index)
        {
            
            if (string.IsNullOrEmpty(chunk) || !IsNotZero(chunk))
            {
                return "zero";
            }

            if (index == 0)
            {
                return chunk;
            }
           
            var SCALES = new ReadOnlyCollection<string>
                (
                    new List<string>
                    { "thousand", "million", "billion" }
                );
            var scale = SCALES[index - 1];
            return string.Join(" ", chunk, scale);
            
            
        }
    }
}
