using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q191_NumberOfOneBits
{
    public class Solution
    {
        public int HammingWeight(int n) 
        {
            var count = 0;

            while(n != 0)
            {
                n &= (n - 1);
                count++;
            }

            return count;
        }
    }
}
