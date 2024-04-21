using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q39_CombinationSum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target) 
        {
            Array.Sort(candidates);
            List<IList<int>> results = new();
            Recurse(candidates, target, results, new List<int>(), 0);

            return results;
        }

        private void Recurse(int[] candidates, int target, IList<IList<int>> results, List<int> acc, int index)
        {
            if(target == 0)
            {
                results.Add(acc.ToArray());
                return;
            }

            for(; index < candidates.Length; index++)
            {
                var next = candidates[index];
                
                if(next > target)
                {
                    // We're done
                    return;
                }

                acc.Add(next);
                Recurse(candidates, target - next, results, acc, index);
                acc.RemoveAt(acc.Count - 1);
            }
        }
    }
}
