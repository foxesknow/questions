using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q93_RestoreIPAddress
{
    public class Solution 
    {
        public IList<string> RestoreIpAddresses(string s) 
        {
            var numbers = s.AsSpan();
            Span<int> acc = stackalloc int[4];

            var results = new List<string>();
            Recurse(0, numbers, acc, results);

            return results;
        }

        private void Recurse(int level, ReadOnlySpan<char> numbers, Span<int> acc, List<string> results)
        {
            if(level == 4)
            {
                if(numbers.IsEmpty)
                {
                    var ipAddress = string.Join('.', acc.ToArray());
                    results.Add(ipAddress);
                }
                
                return;
            }

            if(numbers.IsEmpty) return;

            var integer = numbers[0] - '0';
            while(integer < 256)
            {
                acc[level] = integer;
                numbers = numbers[1..];
                
                Recurse(level + 1, numbers, acc, results);

                if(numbers.IsEmpty) break;
                
                // Zero is only allowed on its own, never as a prefix,
                // so we should stop after trying it
                if(integer == 0) break;

                integer = (integer * 10) + (numbers[0] - '0'); 
            }
        }
    }
}
