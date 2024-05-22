using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q3151_SpecialArray1
{
    public class Solution
    {
        public bool IsArraySpecial(int[] nums) 
        {
            if(nums.Length == 1) return true;

            for(var i = 1; i < nums.Length; i++)
            {
                var rhs = Parity(nums[i]);
                var lhs = Parity(nums[i - 1]);

                if(lhs == rhs) return false;
            }

            return true;
        }

        private bool Parity(int number)
        {
            return (number & 1) == 1;
        }
    }
}
