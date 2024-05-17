using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q50_Pow
{
    public class Solution
    {
        public double MyPow(double x, int n) 
        {
            if(x == 1 || n == 0) return 1;
            if(n == 1) return x;
            if(n == -1) return 1 / x;
            if(x == 0) return 0;

            var half = MyPow(x, n / 2);
            var value = half * half;

            if((n & 1) == 1)
            {
                // We've got an odd power, so we need to scale the number up one more.
                // Also, because the power is odd sign of the power is relevant
                var sign = (n >= 0 ? 1 : -1);
                return value * MyPow(x, sign);
            }
            else
            {
                return value;
            }
        }
    }
}
