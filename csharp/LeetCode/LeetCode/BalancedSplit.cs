using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BalancedSplit
    {
        public bool Exists(int[] numbers)
        {
            if(numbers.Length == 0) return false;
            
            var sum = numbers.Aggregate(0L, (acc, value) => acc + value);
            if(sum % 2 == 1) return false;

            Array.Sort(numbers);

            var index = 0;
            var currentSum = sum;
            var half = sum / 2;

            while(currentSum > half)
            {
                currentSum -= numbers[index];
                index++;
            }

            if(currentSum == half && numbers[index] != numbers[index - 1])
            {
                return true;
            }

            return false;
        }
    }
}
