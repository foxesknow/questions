using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q41_FirstMissingPositive
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums) 
        {
            var n = nums.Length;

            for(var i = 0; i < n; i++)
            {
                if(nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = n + 1;
                }
            }

            // Now mark all the array items that are reachable
            // We'll negate the value in the array item to indicate we've reached it
            for(int i = 0; i < n; i++)
            {
                // If the index is beyond the array then don't bother
                if(Math.Abs(nums[i]) > n) continue;

                // Only mark the index if we've not already seen it
                var index = Math.Abs(nums[i]) - 1; // -1 as array is 0 based
                if(nums[index] > 0)
                {
                    nums[index] *= -1;
                }
            }

            // Now just walk the array until we get to the first
            // item that we never reached
            for(int i = 0; i < n; i++)
            {
                if(nums[i] > 0) return i + 1;
            }

            return n + 1;
        }
    }
}
