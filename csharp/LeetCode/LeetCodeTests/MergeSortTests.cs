using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        [TestCase(new int[]{1})]
        [TestCase(new int[]{1, 2})]
        [TestCase(new int[]{2, 1})]
        [TestCase(new int[]{2, 1,3 })]
        [TestCase(new int[]{5, 4, 3, 2, 1})]
        [TestCase(new int[]{12, 11, 13, 5, 6, 7})]
        public void Sort(int[] numbers)
        {
            var expected = new int[numbers.Length];
            Array.Copy(numbers, expected, numbers.Length);
            Array.Sort(expected);
            
            var mergeSort = new MergeSort();
            mergeSort.Sort(numbers);

            Assert.That(numbers, Is.EqualTo(expected));

        }
    }
}
