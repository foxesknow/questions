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

        public int FibCache(int n) 
        {
            Span<int> cache = stackalloc int[50];

            return Fib(cache, n);

            static int Fib(Span<int> cache, int n)
            {
                if(n==0) return 0;
                if(n==1) return 1;

                if(cache[n] != 0) return cache[n];

                var value = Fib(cache, n - 1) + Fib(cache, n - 2);
                cache[n] = value;

                return value;
            }
        }
    }
}
