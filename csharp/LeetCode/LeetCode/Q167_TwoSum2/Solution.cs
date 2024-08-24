using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q167_TwoSum2
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target) 
        {
            var left = 0;
            var right = numbers.Length - 1;

            while(left < right)
            {
                var sum = numbers[left] + numbers[right];
                if(sum == target)
                {
                    // +1 as they want the indexes to be 1 bases for some reason!
                    return new[]{left + 1, right + 1};
                }

                if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            throw new Exception("we shouldn't get here!");
        }
    }
}
