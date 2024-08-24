using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class OneBillionUsers
    {
        public int GetBillionUsersDay(float[] growthRates) 
        {
            /*
             * (https://leetcode.com/discuss/interview-question/746520/facebook-recruiting-portal-1-billion-users)
             * We need to find the optimal power for all growth rates such that
             * their sum comes to 1bn. Each growth rate relates to the rate of 
             * growth for a different application within the business
             * 
             * We can do this linearly, by just raising each to the power N until
             * the sum of the rates >= 1bn
             * 
             * Or we can divide and conquer to find the optimal power value.
             * This is similar to a binary search
             * 
             */
            var target = 1_000_000_000;
            
            var start = 1;
            var stop = 2000;
            
            while(start <= stop)
            {
                var mid = start + (stop - start) / 2;
                var total = growthRates.Aggregate(0d, (acc, rate) => acc + Math.Pow(rate, mid));

                if(total == target) return mid;

                if(total > target)
                {
                    stop = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

                Console.WriteLine($"{start} - {stop}");
            }
            
            return start;
        }
    }
}
