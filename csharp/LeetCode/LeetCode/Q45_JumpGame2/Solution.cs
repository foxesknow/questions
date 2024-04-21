using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q45_JumpGame2
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            if(nums.Length == 1) return 0;

            // The largest value in nums is 1000, so use anything bigger to indicate "no value"
            const int NoValue = 9999;
            var cache = new int[nums.Length];

            var lastIndex = nums.Length - 1;

            // Work backwards through the array finding the shortest distance from an
            // index to the last index
            for(int index = lastIndex - 1; index >= 0; index--)
            {
                var jumps = nums[index];
                
                if(jumps == 0)
                {
                    // We can't go anywhere from here
                    cache[index] = NoValue;
                    continue;
                }

                if(index + jumps >= lastIndex)
                {
                    // Easy, it's one jump to the end
                    cache[index] = 1;
                    continue;
                }

                // Find the smallest number of steps within our jump range
                var thisMin = NoValue;
                for(int i = 1; i <= jumps; i++)
                {
                    var landOnIndex = index + i;
                    thisMin = Math.Min(thisMin, cache[landOnIndex]);
                }

                // Update our cache for the next iteration.
                // It's +1 to incluse where we are now
                cache[index] = thisMin + 1;
            }

            return cache[0];
        }
    }
}
