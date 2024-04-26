using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q283_MoveZeros
{
    public class Solution
    {
        public void MoveZeroes(int[] nums) 
        {
            var insertionPoint = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[insertionPoint] = nums[i];
                    insertionPoint++;
                }
            }

            Array.Fill(nums, 0, insertionPoint, nums.Length - insertionPoint);
        }
    }
}
