using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q409_LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s) 
        {
            Span<int> countMap = stackalloc int[52]; // 26 lower case and 26 upper case

            foreach(char c in s)
            {
                var index = (char.IsLower(c) ? c - 'a' : 26 + (c - 'A'));
                countMap[index]++;                
            }
            
            /*
             * Now that we've got our counts we just need to sum up all the evens.
             * For the odds we round down to the nearest even, except in one case
             * which will be the letter in the middle
             */

            bool foundOdd = false;
            var overallCount = 0;

            for(int i = 0; i < countMap.Length; i++)
            {
                var count = countMap[i];
                
                foundOdd |= (count & 1) == 1;
                overallCount += count & ~1;

            }

            return overallCount + (foundOdd ? 1 : 0);
        }
    }
}
