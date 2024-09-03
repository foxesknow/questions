using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortSpan
    {
        private void Combine(Span<int> destination, Span<int> left, Span<int> right)
        {
            Span<int> buffer = new int[left.Length + right.Length];
            var offset = 0;

            while(!left.IsEmpty && !right.IsEmpty)
            {
                if(left[0] <= right[0])
                {
                    buffer[offset++] = left[0];
                    left = left.Slice(1);
                }
                else
                {
                    buffer[offset++] = right[0];
                    right = right.Slice(1);
                }
            }

            if(left.Length != 0)
            {
                left.CopyTo(buffer.Slice(offset));
            }
            else
            {
                right.CopyTo(buffer.Slice(offset));
            }

            buffer.CopyTo(destination);
        }

        public void Sort(Span<int> numbers)
        {
            if(numbers.Length > 1)
            {
                var mid = numbers.Length / 2;
                
                var left = numbers[0..mid];
                var right = numbers.Slice(mid);

                Sort(left);
                Sort(right);

                Combine(numbers, left, right);
            }
        }
    }
}
