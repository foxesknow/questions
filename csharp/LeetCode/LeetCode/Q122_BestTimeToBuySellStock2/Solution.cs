using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q122_BestTimeToBuySellStock2
{
    public class Solution
    {
        public int MaxProfit(int[] prices) 
        {
            var profit = 0;

            for(int i = 1; i < prices.Length; i++)
            {
                // See if we'd have made a profit buying yesterday and selling today
                var thisProfit = prices[i] - prices[i - 1];
                if(thisProfit > 0) profit += thisProfit;
            }

            return profit;
        }
    }
}
