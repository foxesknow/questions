using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSort
    {
        /// <summary>
        /// Combines a left and right block that are adjacent to each other in memory.
        /// The result will be a run of sorted numbers running from left to the end of
        /// the block that is (leftLength + rightLength) long.
        /// </summary>
        /// <param name="numbers">The array we're sorting</param>
        /// <param name="left">The start of the left block to combine</param>
        /// <param name="leftLength">The length of the left block</param>
        /// <param name="right">The start of the right block</param>
        /// <param name="rightLength">The length of the right block</param>
        private void Combine(int[] numbers, int left, int leftLength, int right, int rightLength)
        {
            // We need to create local copies of the data as we're going to 
            // be overwriting the incoming array
            var leftScratch = new int[leftLength];
            Array.Copy(numbers, left, leftScratch, 0, leftScratch.Length);

            var rightScratch = new int[rightLength];
            Array.Copy(numbers, right, rightScratch, 0, rightScratch.Length);

            var offset = left;
            var l = 0;
            var r = 0;

            // Combine the 2 lists until we reach the end of one or both
            while(l < leftLength && r < rightLength)
            {
                // The <= makes this stable
                if(leftScratch[l] <= rightScratch[r])
                {
                    numbers[offset++] = leftScratch[l++];
                }
                else
                {
                    numbers[offset++] = rightScratch[r++];
                }
            }

            if(l < leftLength)
            {
                var itemsToCopy = leftLength - l;
                Array.Copy(leftScratch, l, numbers, offset, itemsToCopy);
                offset += itemsToCopy;
            }

            if(r < rightLength)
            {
                var itemsToCopy = rightLength - r;
                Array.Copy(rightScratch, r, numbers, offset, itemsToCopy);
            }
        }

        private void Sort(int[] numbers, int left, int right)
        {
            if(left < right)
            {
                var mid = left + (right - left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, mid + 1, right);

                var leftLength = mid - left + 1;
                var rightLength = right - mid;

                Combine(numbers, left, leftLength, mid + 1, rightLength);
            }
        }

        public void Sort(int[] numbers)
        {
            Sort(numbers, 0, numbers.Length - 1);
            //mergeSort(numbers, 0, numbers.Length - 1);
        }
    }
}

