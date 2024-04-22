using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q56_MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals) 
        {
            Array.Sort(intervals, (lhs, rhs) => lhs[0].CompareTo(rhs[0]));

            var merged = new List<int[]>();

            merged.Add(intervals[0]);

            for(var i = 1; i < intervals.Length; i++)
            {
                var pair = intervals[i];
                var back = merged[merged.Count - 1];
                
                if(pair[0] <= back[1])
                {
                    back[1] = Math.Max(back[1], pair[1]);
                }
                else
                {
                    merged.Add(pair);
                }
            }

            return merged.ToArray();
        }
    }
}
