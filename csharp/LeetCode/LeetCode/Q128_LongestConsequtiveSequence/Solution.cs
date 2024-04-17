using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q128_LongestConsequtiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums) 
        {
            if(nums.Length == 0) return 0;

            Array.Sort(nums);
            var longest = 0;

            int left = AdvanceLeft(0, nums);
            int right = left;
            int adjustment = 0;
            
            while(right + 1 < nums.Length)
            {
                if(nums[right] == nums[right + 1])
                {
                    // If adjacent items are the same then we ignore them.
                    // This means we'll have to adjust the max by the number of items we skip
                    adjustment++;
                    right++;
                }
                else if(nums[right] + 1 == nums[right + 1])
                {
                    right++;
                }
                else
                {
                    longest = Math.Max(longest, (right - left) + 1 - adjustment);
                    left = AdvanceLeft(right + 1, nums);
                    right = left;
                    adjustment = 0;
                }
            }

            return Math.Max(longest, (right - left) + 1 - adjustment);
        }

        private int AdvanceLeft(int left, int[] nums)
        {
            while(left + 1 < nums.Length && nums[left] == nums[left + 1])
            {
                left++;
            }

            return left;
        }
    }
}
