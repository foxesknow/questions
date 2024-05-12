using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q4_MedianOfTwoSortedArrays;
using NUnit.Framework;

namespace LeetCodeTests.Q4_MedianOfTwoSortedArrays
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums1 = new int[]{1, 3};
            var nums2 = new int[]{2};
            Assert.That(s.FindMedianSortedArrays(nums1, nums2), Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var nums1 = new int[]{1, 2};
            var nums2 = new int[]{3,4};
            Assert.That(s.FindMedianSortedArrays(nums1, nums2), Is.EqualTo(2.5));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var nums1 = new int[]{};
            var nums2 = new int[]{3,4};
            Assert.That(s.FindMedianSortedArrays(nums1, nums2), Is.EqualTo(3.5));
        }
    }
}
