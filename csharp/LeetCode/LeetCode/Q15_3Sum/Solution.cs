using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q15_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums) 
        {
            // Sort the numbers so it's easier to find the matches
            Array.Sort(nums);

            int lastIndex = nums.Length - 1;
            var numbers = new List<IList<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                var first = nums[i];
                if(first > 0) break;

                // It's the same start number as last time, so don't bother again
                if(i > 0 && first == nums[i - 1]) continue;
                
                // If the first 2 numbers take as over 0 then we're done
                if(i != lastIndex && first + nums[i + 1] > 0) break;

                var left = i + 1;
                var right = lastIndex;

                while(left < right)
                {
                    var second = nums[left];
                    var third = nums[right];

                    // If the first 2 are bigger than zero then we can stop checking
                    if(first + second > 0) break;

                    var sum = first + second + third;
                    if(sum == 0)
                    {
                        numbers.Add(new List<int>(3){first, second, third});
                        
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
                    else if(sum < 0)
                    {
                        // If we're less than zero we need a bigger number
                        left++;
                    }
                    else
                    {
                        // If we're greater than were we need a smaller number
                        right--;
                    }
                }
            }

            return numbers;
        }
    }
}

