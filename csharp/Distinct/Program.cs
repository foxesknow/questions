// https://app.codility.com/programmers/lessons/6-sorting/distinct/

var distinct = new Solution();
var a = distinct.solution(new[]{1,1,1,2,3,1});
Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        if(A.Length == 0) return 0;
        if(A.Length == 1) return 1;

        Array.Sort(A);

        var distinctCount = 1;
        var lastNumber = A[0];

        for(int i = 1; i < A.Length; i++)
        {
            if(lastNumber != A[i])
            {
                lastNumber = A[i];
                distinctCount++;
            }
        }

        return distinctCount;
    }
}