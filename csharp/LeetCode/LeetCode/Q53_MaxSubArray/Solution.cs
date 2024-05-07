using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q53_MaxSubArray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var sum = nums[0];

            for(var i = 1; i < nums.Length; i++)
            {
                var current = nums[i];
                sum = Math.Max(current, sum + current);
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
