using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q69_Sqrt
{
    public class Solution
    {
        public int MySqrt(int x) 
        {
            if(x == 0 || x == 1) return x;

            long? last = null;
            long lower = 1, upper = x;

            while(true)
            {
                long mid = (lower + upper) / 2;
                if(last is not null && last == mid) return (int)mid;

                var sqr = mid * mid;
                if(sqr == x)
                {
                    return (int)mid;
                }
                else if(sqr > x)
                {
                    upper = mid;
                }
                else
                {
                    lower = mid;
                }

                last = mid;
            }
        }
    }
}
