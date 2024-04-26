using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q55_JumpGame
{
    public class Solution
    {
        public bool CanJump(int[] nums) 
        {
            var energy = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] > energy)
                {
                    energy = nums[i];
                }

                energy--;

                if(energy < 0) return false;
            }

            return true;
        }
    }
}
