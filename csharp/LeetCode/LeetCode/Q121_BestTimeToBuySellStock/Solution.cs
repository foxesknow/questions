using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q121_BestTimeToBuySellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices) 
        {
            var profit = 0;
            var minPrice = prices[0];

            for(var i = 1; i < prices.Length; i++)
            {
                var thisProfit = prices[i] - minPrice;
                profit = Math.Max(profit, thisProfit);
                minPrice = Math.Min(minPrice, prices[i]);
            }

            return profit;
        }
    }
}
