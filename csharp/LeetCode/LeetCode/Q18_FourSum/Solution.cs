using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q18_FourSum
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target) 
        {
            Array.Sort(nums);

            var results = new List<IList<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(i != 0 && nums[i] == nums[i - 1]) continue;

                var currentValue = nums[i];
                var adjustedTarget = (long)target - currentValue;

                ThreeSum(nums, i + 1, nums.Length - 1, adjustedTarget, currentValue, results);
            }

            return results;
        }

        private void ThreeSum(int[] nums, int startIndex, int lastIndex, long target, int currentValue, IList<IList<int>> numbers) 
        {
            for(int i = startIndex; i <= lastIndex; i++)
            {
                long first = nums[i];

                // We can bail out early as everything else is positive which will never bring us back to the target
                if(target > 0 && first > target) break;

                // It's the same start number as last time, so don't bother again
                if(i > startIndex && first == nums[i - 1]) continue;
                
                var left = i + 1;
                var right = lastIndex;

                while(left < right)
                {
                    var second = nums[left];
                    var third = nums[right];

                    // We can bail out early as everything else is positive which will never bring us back to the target
                    if(target > 0 && first + second > target) break;

                    var sum = first + second + third;
                    if(sum == target)
                    {
                        numbers.Add(new int[]{currentValue, (int)first, second, third});
                        
                        // We need to move to the next numbers that are't the same as
                        // the ones we're currently looking at
                        while(left < right && second == nums[left])
                        {
                            left++;
                        }

                        while(right > left && third == nums[right])
                        {
                            right--;
                        }
                    }
                    else if(sum < target)
                    {
                        // If we're less than the target we need a bigger number
                        left++;
                    }
                    else
                    {
                        // If we're greater than were we need a smaller number
                        right--;
                    }
                }
            }
        }
    }
}
