// https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/

var from = new Solution();
var a = from.solution(new[]{4,1,3,2});
var b = from.solution(new[]{4,1,3});
var c = from.solution(new[]{1,1});

Console.WriteLine("Hello, World!");

class Solution
{
    public int solution(int[] A)
    {
        var max = 0;
        var seen = new System.Collections.Generic.HashSet<int>();
        
        for(int i = 0; i < A.Length; i++)
        {
            var value = A[i];
            if(seen.Add(value))
            {
                max = Math.Max(max, value);
            }
            else
            {
                // The number has already been seen
                return 0;
            }
        }

        return seen.Count == max ? 1 : 0;
    }
}
