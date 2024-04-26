using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q75_SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums) 
        {
            Span<int> counts = stackalloc int[3];

            foreach(var n in nums)
            {
                counts[n]++;
            }

            Array.Fill(nums, 0, 0, counts[0]);
            Array.Fill(nums, 1, counts[0], counts[1]);
            Array.Fill(nums, 2, counts[0] + counts[1], counts[2]);
        }
    }
}
