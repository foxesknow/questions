using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q412_FizzBuzz
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n) 
        {
            var results = new string[n];

            for(int i = 1; i <= n; i++)
            {
                var s = i switch
                {
                    var x when x % 15 == 0  => "FizzBuzz",
                    var x when x % 5 == 0   => "Buzz",
                    var x when x % 3 == 0   => "Fizz",
                    var x                   => x.ToString()
                };

                results[i - 1] = s;
            }

            return results;
        }
    }
}
