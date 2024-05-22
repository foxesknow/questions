using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q3105_LongestIncreasingOrDecreasing
{
    public class Solution
    {
        public int LongestMonotonicSubarray(int[] nums) 
        {
            var increasing = LongestIncreasingRun(nums);
            Array.Reverse(nums);
            var decreasing = LongestIncreasingRun(nums);

            return Math.Max(increasing, decreasing);
        }

        private int LongestIncreasingRun(int[] nums)
        {
            var longest = 1;

            var left = 0;

            for(var i = 1; i < nums.Length; i++)
            {
                if(nums[i] > nums[i - 1])
                {
                    longest = Math.Max(longest, i - left + 1);
                }
                else
                {
                    left = i;
                }
            }

            return longest;
        }
    }
}
