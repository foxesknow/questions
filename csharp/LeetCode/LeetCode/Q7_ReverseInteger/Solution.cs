using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q7_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x) 
        {
            var isNegative = (x < 0);
            var value = 0;

            while(x != 0)
            {
                var nextDigit = Math.Abs(x % 10);

                // Check for overflow
                if(value != 0 && ((int.MaxValue - nextDigit) / value) < 10) return 0;

                value = (value * 10) + nextDigit;
                x /= 10;
            }

            // A positive number always has a negative equivilant
            if(isNegative) value *= -1;

            return value;
        }
    }
}
