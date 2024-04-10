using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q17_3SumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target) 
        {
            int? closestDiff = null;
            int closest = 0;

            // Sort the numbers so it's easier to find the matches
            Array.Sort(nums);

            int lastIndex = nums.Length - 1;

            for(int i = 0; i < nums.Length; i++)
            {
                var first = nums[i];

                // It's the same start number as last time, so don't bother again
                if(i > 0 && first == nums[i - 1]) continue;

                var left = i + 1;
                var right = lastIndex;

                while(left < right)
                {
                    var second = nums[left];
                    var third = nums[right];

                    // If the first 2 are bigger than zero then we can stop checking
                    var sum = first + second + third;                    
                    if(sum == target) return sum;

                    var diff = Math.Abs(sum - target);

                    if(closestDiff == null)
                    {
                        closestDiff = diff;
                        closest = sum;
                    }
                    else
                    {
                        if(closestDiff.Value > diff)
                        {
                            closestDiff = diff;
                            closest = sum;
                        }
                    }

                    if(sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return closest;
        }
    }
}
