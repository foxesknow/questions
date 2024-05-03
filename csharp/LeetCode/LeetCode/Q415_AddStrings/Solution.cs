using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q415_AddStrings
{
    public class Solution
    {
        public string AddStrings(string num1, string num2) 
        {
            var reverseSum = ReverseSum(num1, num2);
            return new string(reverseSum.Reverse().ToArray());

        }

        private IEnumerable<char> ReverseSum(string num1, string num2) 
        {
            var maxLength = Math.Max(num1.Length, num2.Length);
            var builder = new StringBuilder(maxLength + 1);

            int carry = 0;
            var zip = Enumerable.Zip(ReverseScan(num1, maxLength), ReverseScan(num2, maxLength));
            
            foreach(var (lhs, rhs) in zip)
            {
                var sum = lhs + rhs + carry;
                carry = sum / 10;
                char digit = (char)('0' + (sum % 10));
                yield return digit;
            }

            if(carry != 0) yield return '1';
        }

        public IEnumerable<int> ReverseScan(string num, int count)
        {
            for(var i = num.Length - 1; i >= 0; i--)
            {
                yield return num[i] - '0';
                count--;
            }

            while(count-- > 0)
            {
                yield return 0;
            }
        }
    }
}
