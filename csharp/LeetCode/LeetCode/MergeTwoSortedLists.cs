using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        public IReadOnlyList<int> Merge(IReadOnlyList<int> left, IReadOnlyList<int> right)
        {
            var destination = new int[left.Count + right.Count];

            var leftOffset = 0;
            var rightOffset = 0;
            var destinationOffset = 0;

            while(leftOffset < left.Count && rightOffset < right.Count)
            {
                if(left[leftOffset] <= right[rightOffset])
                {
                    destination[destinationOffset++] = left[leftOffset++];
                }
                else
                {
                    destination[destinationOffset++] = right[rightOffset++];
                }
            }

            while(leftOffset < left.Count)
            {
                destination[destinationOffset++] = left[leftOffset++];
            }

            while(rightOffset < right.Count)
            {
                destination[destinationOffset++] = right[rightOffset++];
            }

            return destination;
        }
    }
}
