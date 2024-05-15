using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q34_FindFirstAndLast
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var index1 = LowerBound(nums, target);

            if(index1 == -1) return new int[]{-1, -1};

            var index2 = UpperBound(nums, target);

            return new[]{index1, index2};
        }

        private int LowerBound(int[] nums, int target)
        {
            return BoundedSearch(nums, target, SearchType.Lower);
        }

        private int UpperBound(int[] nums, int target)
        {
            return BoundedSearch(nums, target, SearchType.Upper);
        }

        private int BoundedSearch(int[] nums, int target, SearchType searchType)
        {
            var index = -1;
            int left = 0, right = nums.Length - 1;

            while(left <= right)
            {
                var mid = (left + right) / 2;
                var value = nums[mid];

                if(value == target)
                {
                    index = mid;

                    if(searchType == SearchType.Lower)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if(value < target)
                {
                    left = mid + 1;                    
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }

        enum SearchType
        {
            Upper,
            Lower
        }
    }
}
