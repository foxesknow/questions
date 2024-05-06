using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q14_LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs) 
        {
            if(strs.Length == 1) return strs[0];

            Array.Sort(strs);
            var first = strs[0];
            var last = strs[strs.Length - 1];
            var range = Math.Min(first.Length, last.Length);

            for(var i = 0; i < range; i++)
            {
                if(first[i] == last[i]) continue;

                return first.Substring(0, i);
            }

            return first;
        }
    }
}
