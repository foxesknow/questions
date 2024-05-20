using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AnagramChecker
    {
        /// <summary>
        /// Checks is word2 is an anagram of word1
        /// NOTE: Ignore the casing of letters, and each letter is in the range A-Z, a-z
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool IsAnagram(string word1, string word2)
        {
            if(word1 is null || word2 is null) throw new ArgumentNullException();

            if(word1.Length != word2.Length) return false;
            Span<int> frequences = stackalloc int[26];

            foreach(var c in word1)
            {
                var index = GetIndex(c);
                frequences[index]++;
            }

            foreach(var c in word2)
            {
                var index = GetIndex(c);
                frequences[index]--;

                if(frequences[index] < 0) return false;
            }

            foreach(var frequency in frequences)
            {
                if(frequency != 0) return false;
            }

            return true;
        }

        private int GetIndex(char c)
        {
            if(char.IsUpper(c)) return c - 'A';

            return c - 'a';
        }
    }
}
