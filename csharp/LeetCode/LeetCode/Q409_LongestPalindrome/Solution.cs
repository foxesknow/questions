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

            var largestOddCount = 0;
            int largestOddCharacterIndex = -1;

            for(int i = 0; i < countMap.Length; i++)
            {
                var count = countMap[i];
                if((count & 1) == 1 && count > largestOddCount)
                {
                    largestOddCount = count;
                    largestOddCharacterIndex = i;
                }
            }

            /*
	         * Now we've got our stats the rule is that all even count characters
	         * can go in as they evenly divide either side of the center.
	         * For any remaining odd characters that aren't the largest one found above
	         * we round down to the nearest even count and use that
	         */

            var sumOfEvens = 0;
            var sumOfRoundedDownOdds = 0;

            for(int i = 0; i < countMap.Length; i++)
            {
                var count = countMap[i];
                if(count == 0 || i == largestOddCharacterIndex) continue;

                if((count & 1) == 0)
                {
                    sumOfEvens += count;
                }
                else
                {
                    sumOfRoundedDownOdds += (count - 1);
                }
            }

            return sumOfEvens + sumOfRoundedDownOdds + largestOddCount;
        }
    }
}
