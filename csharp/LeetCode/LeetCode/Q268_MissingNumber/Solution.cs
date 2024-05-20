using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q268_MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums) 
        {
            // As we expect the numbers 1..nums.Length we can 
            // work out the expected sum of items in the array

            var expectedSum = ((long)nums.Length * (nums.Length + 1)) / 2;

            foreach(var num in nums)
            {
                expectedSum -= num;
            }

            return (int)expectedSum;
        }
    }
}
