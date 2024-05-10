using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q242_ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t) 
        {
            if(s.Length != t.Length) return false;

            Span<int> cache = stackalloc int[26];

            var length = s.Length;
            for(var i = 0; i < s.Length; i++)
            {
                cache[s[i] - 'a']++;
                cache[t[i] - 'a']--;
            }

            for(var i = 0; i < cache.Length; i++)
            {
                if(cache[i] < 0) return false;
            }

            return true;
        }
    }
}
