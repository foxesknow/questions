using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q509_Fibonacci
{
    public class Solution
    {
        public int Fib(int n) 
        {
            return Fib(0, 1, n);

            static int Fib(int first, int second, int n)
            {
                if(n==0) return first;
                if(n==1) return second;

                return Fib(second, first + second, n - 1);
            }
        }
    }
}
