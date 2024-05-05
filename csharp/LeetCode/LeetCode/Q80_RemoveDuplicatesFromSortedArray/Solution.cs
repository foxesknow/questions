using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q80_RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums) 
        {
            var length = nums.Length;
            if(length <= 2) return length;

            var insertionPoint = 1;
            var current = nums[0];
            var currentCount = 1;
            var count = 1;

            for(var i = 1; i < length; i++)
            {
                if(nums[i] == current)
                {
                    if(currentCount == 1)
                    {
                        nums[insertionPoint] = nums[i];
                        insertionPoint++;
                        count++;
                    }

                    currentCount++;
                }
                else
                {
                    // It's a new number
                    nums[insertionPoint] = nums[i];
                    insertionPoint++;
                    currentCount = 1;
                    current = nums[i];
                    count++;
                }
            }

            return count;
        }
    }
}
