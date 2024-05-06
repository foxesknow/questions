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

            var (length, referenceString) = strs.Min(s => (s.Length, s));
            var builder = new StringBuilder(length);

            for(var i = 0; i < length; i++)
            {
                var c = referenceString[i];
                
                var allSame = strs.All(s => s[i] == c);
                if(allSame)
                {
                    builder.Append(c);
                }
                else
                {
                    break;
                }
            }


            return builder.ToString();
        }
    }
}
