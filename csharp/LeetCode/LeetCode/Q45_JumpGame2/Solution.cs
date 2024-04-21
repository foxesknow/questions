using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q45_JumpGame2
{
    public class Solution
    {
        public int Jump(int[] nums) 
        {
            return Recurse(nums, 0, int.MaxValue, 0, nums.Length - 1, new());
        }

        public int Recurse(int[] nums, int acc, int minJump, int index, int lastIndex, Dictionary<int, int> cache)
        {
            if(index == lastIndex)
            {
                return Math.Min(acc, minJump);
            }

            if(index > lastIndex)
            {
                return minJump;
            }

            if(cache.TryGetValue(index, out var thisMin))
            {
                return thisMin;
            }

            var jumps = nums[index];

            thisMin = int.MaxValue;
            for(var i = 1; i <= jumps; i++)
            {
                var recurseMin = Recurse(nums, acc + 1, minJump, index + i, lastIndex, cache);
                thisMin = Math.Min(thisMin, recurseMin);                
            }

            minJump = Math.Min(minJump, thisMin);
            cache.Add(index, thisMin);

            return minJump;
        }
    }
}
