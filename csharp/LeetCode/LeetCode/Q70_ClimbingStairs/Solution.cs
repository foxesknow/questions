using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q70_ClimbingStairs;

public class Solution
{
    public int ClimbStairs(int n) 
    {
        Span<int> cache = stackalloc int[n + 1];

        return Run(cache, n);

        static int Run(Span<int> cache, int n)
        {
            if(n < 0) return 0;
            if(n <= 2) return n;

            if(cache[n] is int previous && previous != 0)
            {
                return previous;
            }

            var result = Run(cache, n - 1) + Run(cache, n - 2);
            cache[n] = result;

            return result;
        }
    }
}
