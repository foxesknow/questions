using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q11_ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height) 
        {
            var max = 0;

            var left = 0;
            var right = height.Length - 1;

            while(left < right)
            {
                var width = right - left;
                var peak = 0;

                if(height[left] > height[right])
                {
                    peak = height[right];
                    right--;
                }
                else
                {
                    peak = height[left];
                    left++;
                }

                var volumn = width * peak;
                max = Math.Max(max, volumn);
            }

            return max;
        }
    }
}
