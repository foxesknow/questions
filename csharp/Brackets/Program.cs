// https://app.codility.com/programmers/lessons/7-stacks_and_queues/brackets/


var brackets = new Solution();
var a = brackets.solution("{[()()]}");
var b = brackets.solution("([)()]");

Console.WriteLine("done");

class Solution
{
    public int solution(string S)
    {
        if(S.Length == 0) return 1;

        var stack = new System.Collections.Generic.Stack<char>();

        foreach(var c in S)
        {
            if(c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0)
                {
                    // Oops!
                    return 0;
                }

                var top = stack.Pop();
                if(top == '{' && c != '}') return 0;
                if(top == '[' && c != ']') return 0;
                if(top == '(' && c != ')') return 0;
            }
        }

        return stack.Count == 0 ? 1 : 0;
    }
}