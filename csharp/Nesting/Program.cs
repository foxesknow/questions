// https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/

var nesting = new Solution();
var a = nesting.solution("(()(())())");
var b = nesting.solution("())");
var c = nesting.solution("()()()");

Console.WriteLine("done");

class Solution
{
    public int solution(string S)
    {
        if(S.Length == 0) return 1;

        var openCount = 0;

        foreach(var c in S)
        {
            if(c == '(')
            {
                openCount++;
            }
            else
            {
                if(openCount == 0)
                {
                    return 0;
                }

                openCount--;
            }
        }

        return openCount == 0 ? 1 : 0;
    }
}