using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordsAndCalculator
{
    public static class Converter
    {
        public static string ToWords(ulong number, Language language)
        {
            #region SpecialCases
            if (number > 999999999999)
            {
                switch (language)
                {
                    case Language.English:
                        throw new Exception($"The {number} is out of range (greater than 999999999999)!");
                    case Language.Macedonian:
                        throw new Exception($"Бројот {number} е надвор од опсег (поголем од 999999999999)!");
                    default:
                        throw new Exception($"The language {language} is not recognized!");
                }
            }
            if (number == 0)
            {
                switch (language)
                {
                    case Language.English:
                        return "Zero";
                    case Language.Macedonian:
                        return "Нула";
                    default:
                        throw new Exception($"The language {language} is not recognized!");
                }
            }
            #endregion

            IEnumerable<string> result;
            CultureInfo culture;
            switch (language)
            {
                case Language.English:
                    culture = new CultureInfo("en");
                    result = Chunk(number)
                                .Select(ToEnglish)
                                .Select(AppendEnglishScale)
                                .Where(IsNotZero)
                                .Reverse();
                    break;
                case Language.Macedonian:
                    culture = new CultureInfo("mk-MK");
                    result = Chunk(number)
                                .Select(ToMacedonian)
                                .Select(AppendMacedonianScale)
                                .Where(IsNotZero)
                                .Reverse();
                    break;
                default:
                    throw new Exception($"The language {language} is not recognized!");
            }
            

            return string.Join(" ", result)
                .CapitalizeFirstChar(culture)
                .Trim();
        }

        private static string CapitalizeFirstChar(this string input, CultureInfo culture)
        {
            input = input.Trim();
            return input.First().ToString().ToUpper(culture) + input.Substring(1);
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

        private static string AppendEnglishScale(string chunk, int index)
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

        private static string ToMacedonian(ushort number)
        {

            ushort hundreds;
            ushort tens;
            ushort ones;
            var words = new List<string>();

            var ONE_TO_NINETEEN = new ReadOnlyCollection<string>
            (
                new List<string>
                {
                    "еден", "два", "три", "четири", "пет",
                    "шест", "седум", "осум", "девет", "десет",
                    "единаесет", "дванаесет", "тринаесет", "четиринаесет", "петнаесет",
                    "шеснаесет", "седумнаесет", "осумнаесет", "деветнаесет"
                }
            );
            var TENS = new ReadOnlyCollection<string>
            (
                new List<string>
                {
                    "десет", "дваесет", "триесет", "четириесет", "педесет",
                    "шеесет", "седумдесет", "осумдесет", "деведесет"
                }
            );
            var HUNDREDS = new ReadOnlyCollection<string>
            (
                new List<string>
                {
                    "сто", "двесте", "триста", "четиристотини", "петстотини",
                    "шестотини", "седумстотини", "осумстотини", "деветстотини"
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
                return string.Join(" и ", words.Where(IsNotZero));
            }

            hundreds = (ushort)(number / 100);
            words.Add(HUNDREDS[hundreds - 1]);
            var tensDigit = (number % 100) / 10;
            if (tensDigit == 0)
            {
                words.Add("и");
            }
            words.Add(ToMacedonian((ushort)(number % 100)));
            return string.Join(" ", words.Where(IsNotZero));


        }

        private static string AppendMacedonianScale(string chunk, int index)
        {
            if (string.IsNullOrEmpty(chunk) || !IsNotZero(chunk))
            {
                return "zero";
            }

            if (index == 0)
            {
                return chunk;
            }
            
            var chunkScaleObject = ProcessMacedonianChunks(chunk, index);

            return string.Join(" ", chunkScaleObject.Chunk, chunkScaleObject.Scale);

            
        }

        private static dynamic ProcessMacedonianChunks(string chunk, int index)
        {
            
            var SCALES = new ReadOnlyCollection<string>
                (
                    new List<string>
                    { "илјада", "милион", "милијарда" }
                );

                
            var scale = SCALES[index - 1];
            
            if (chunk.Equals("еден"))
            {
                //TODO This empty string should be filtered!
                chunk = string.Empty;
            }
            else if (index == 1 || index == 3)
            {
                if ((chunk.IndexOf("еден") > -1))
                {
                    chunk = chunk.Replace("еден", "една");
                }
                else
                {
                    if (chunk.Length == 3)
                    {
                        chunk = chunk.Replace("два", "две");
                    }
                    scale = scale.Substring(0, scale.Length - 1) + 'и';
                }
            }
            else if (chunk.IndexOf("еден") == -1)
            {
                scale += 'и';
            }
            
            return new { Chunk = chunk, Scale = scale };
        }
    }
}
