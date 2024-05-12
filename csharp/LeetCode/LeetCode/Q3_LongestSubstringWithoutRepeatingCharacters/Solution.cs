using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q3_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s) 
        {
            if(s.Length == 0) return 0;

            Span<bool> seen = stackalloc bool[256];
            seen[s[0]] = true;

            var left = 0;
            var max = 1;

            for(var i = 1; i < s.Length; i++)
            {
                var c = s[i];
                if(!seen[c])
                {
                    seen[c] = true;
                    max = Math.Max(max, i - left + 1);
                    continue;
                }

                // We need need to move left to the first character after c from the left
                left++;
                while(s[left - 1] != c)
                {
                    seen[s[left - 1]] = false;
                    left++;
                }
            }

            return max;
        }
    }
}
