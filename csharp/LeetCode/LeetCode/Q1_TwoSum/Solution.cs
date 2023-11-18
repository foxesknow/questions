namespace LeetCode.Q1_TwoSum
{
    public class Solution 
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            var indexes = new Dictionary<int, int>();

            for(var i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                if(indexes.TryGetValue(target - value, out var existing))
                {
                    return new int[]{existing, i};
                }
                else
                {
                    indexes[value] = i;
                }
            }

            return Array.Empty<int>();
        }
    }
}
