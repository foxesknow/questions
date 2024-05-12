using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q20_ValidParenthesis
{
    public class Solution
    {
        public bool IsValid(string s) 
        {
            var stack = new Stack<char>();

            foreach(var c in s)
            {
                if(c is ('(' or '{' or '['))
                {
                    stack.Push(c);
                    continue;
                }

                // It's a close token
                if(stack.Count == 0) return false;

                var isValid = stack.Pop() switch
                {
                    '(' when c == ')' => true,
                    '{' when c == '}' => true,
                    '[' when c == ']' => true,
                    _ => false
                };

                if(!isValid) return false;
            }

            return stack.Count == 0;
        }
    }
}
