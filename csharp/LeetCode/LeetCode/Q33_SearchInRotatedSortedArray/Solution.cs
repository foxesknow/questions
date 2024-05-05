using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q33_SearchInRotatedSortedArray
{
    public class Solution
    {
        public int Search(int[] nums, int target) 
        {
            var left = 0;
            var right = nums.Length - 1;

            while(left <= right)
            {
                var mid = (left + right) / 2;
                
                if(nums[mid] == target) return mid;

                if(nums[left] <= nums[mid])
                {
                    // The left is sorted
                    if(target >= nums[left] && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    // The right is sorted
                    if(target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
