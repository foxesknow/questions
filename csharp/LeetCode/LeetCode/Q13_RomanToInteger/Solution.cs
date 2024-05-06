using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q13_RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s) 
        {
            var value = 0;
            char previous = '\0';

            foreach(var c in s)
            {
                var adjustment = (previous, c) switch
                {
                    ('C', 'M') => 800,
                    ('C', 'D') => 300,
                    ('X', 'L') => 30,
                    ('X', 'C') => 80,
                    ('I', 'X') => 8,
                    ('I', 'V') => 3,
                    (_, 'M') => 1000,
                    (_, 'D') => 500,
                    (_, 'C') => 100,
                    (_, 'L') => 50,
                    (_, 'X') => 10,
                    (_, 'V') => 5,
                    (_, 'I') => 1,
                    _ => throw new Exception()
                };

                value += adjustment;
                previous = c;
            }

            return value;
        }
    }
}
