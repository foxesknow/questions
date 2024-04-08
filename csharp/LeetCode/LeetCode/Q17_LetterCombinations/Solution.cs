using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q17_LetterCombinations
{
    public class Solution
    {
        private static readonly IReadOnlyDictionary<char, string> buttons = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };

        public IList<string> LetterCombinations(string digits) 
        {
            var acc = new List<string>();
            Recurse(digits, acc, "");

            return acc;
        }

        private void Recurse(ReadOnlySpan<char> digits, List<string> acc, string current)
        {
            if(digits.Length == 0)
            {
                if(current.Length != 0) acc.Add(current);
                return;
            }

            var digit = digits[0];
            var letters = buttons[digit];

            foreach(var c in letters)
            {
                Recurse(digits[1..], acc, current + c);
            }
        }
    }
}
