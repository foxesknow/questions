using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q4_MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            var totalLength = nums1.Length + nums2.Length;
            var medianPosition = totalLength / 2;
            bool isEven = (totalLength % 2) == 0;

            if(isEven)
            {
                medianPosition--;
            }

            Span<int> s1 = nums1;
            Span<int> s2 = nums2;

            double median = 0;

            for(var i = 0; i <= medianPosition; i++)
            {
                median = Advance(ref s1, ref s2);
            }

            if(isEven)
            {
                var next = Advance(ref s1, ref s2);
                median = (median + next) / 2;
            }

            return median;
        }

        private int Advance(ref Span<int> nums1, ref Span<int> nums2)
        {
            if(nums1.Length == 0)
            {
                var value = nums2[0];
                nums2 = nums2[1..];

                return value;
            }

            if(nums2.Length == 0)
            {
                var value = nums1[0];
                nums1 = nums1[1..];

                return value;
            }

            if(nums1[0] <= nums2[0])
            {
                var value = nums1[0];
                nums1 = nums1[1..];

                return value;
            }
            else
            {
                var value = nums2[0];
                nums2 = nums2[1..];

                return value;
            }
        }
    }
}
