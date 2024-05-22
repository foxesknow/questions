using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q3136_ValidWord
{
    public class Solution
    {
        public bool IsValid(string word) 
        {
            if(word.Length < 3) return false;

            var vowelCount = 0;
            var consonantCount = 0;
            
            foreach(var c in word)
            {
                if(char.IsDigit(c)) continue;

                if(char.IsLetter(c) == false) return false;

                if(IsVowel(c))
                {
                    vowelCount++;
                }
                else if(IsConsonant(c))
                {
                    consonantCount++;
                }
                else
                {
                    return false;
                }
            }

            return vowelCount > 0 && consonantCount > 0;
        }

        private bool IsVowel(char c)
        {
            return char.ToLower(c) is ('a' or 'e' or 'i' or 'o' or 'u'); 
        }

        private bool IsConsonant(char c)
        {
            return !IsVowel(c);
        }
    }
}
