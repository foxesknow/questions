using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q227_BasicCalculator2
{
    public class Solution
    {
        public int Calculate(string s) 
        {
            var numbers = new Stack<int>();
            var operators = new Stack<char>();

            foreach(var token in Tokenize(s))
            {
                if(token is int i)
                {
                    numbers.Push(i);
                }
                else
                {
                    char op = (char)token;

                    if(operators.Count == 0)
                    {
                        operators.Push(op);
                    }
                    else
                    {
                        if(Precedence(op) > Precedence(operators.Peek()))
                        {
                            operators.Push(op);
                        }
                        else
                        {
                            while(operators.Count > 0 && Precedence(op) <= Precedence(operators.Peek()))
                            {
                                Evaluate(operators.Pop(), numbers);
                            }

                            operators.Push(op);
                        }
                    }
                }
            }

            while(operators.TryPop(out var op))
            {
                Evaluate(op, numbers);
            }

            return numbers.Peek();
        }



        private void Evaluate(char op, Stack<int> numbers)
        {
            var rhs = numbers.Pop();
            var lhs = numbers.Pop();

            var result = op switch
            {
                '+' => lhs + rhs,
                '-' => lhs - rhs,
                '*' => lhs * rhs,
                '/' => lhs / rhs,
                _   => throw new Exception("unsupported operator")
            };

            numbers.Push(result);
        }

        private int Precedence(char c)
        {
            if(c == '*' || c == '/') return 2;
            return 1;
        }

        private IEnumerable<object> Tokenize(string s)
        {
            string current = "";

            foreach(var c in s)
            {
                if(char.IsWhiteSpace(c)) continue;

                if(char.IsDigit(c))
                {
                    current += c;
                }
                else
                {
                    // It's an operator
                    if(current.Length != 0) yield return int.Parse(current);
                    yield return c;

                    current = "";
                }
            }

            if(current.Length != 0) yield return int.Parse(current);
        }
    }
}
