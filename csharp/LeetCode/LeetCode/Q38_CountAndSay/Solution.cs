using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q38_CountAndSay
{
    public class Solution
    {
        public string CountAndSay(int n) 
        {
            var value = "1";

            for(int i = 2; i <= n; i++)
            {
                value = Expand(value);
            }

            return value;
        }

        private string Expand(string input)
        {
            var b = new StringBuilder();

            var count = 1;
            var current = input[0];

            for(int i = 1; i < input.Length; i++)
            {
                var c = input[i];

                if(c != current)
                {
                    b.Append(count);
                    b.Append(current);
                    current = c;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            b.Append(count);
            b.Append(current);

            return b.ToString();
        }
    }
}
