using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsDemo
{
    class StringUtil
    {
        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
