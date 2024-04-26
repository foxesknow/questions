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
                var n = nums[i];
                if(n != 0)
                {
                    (nums[insertionPoint], nums[i]) = (nums[i], nums[insertionPoint]);
                    insertionPoint++;
                }
            }
        }
    }
}
