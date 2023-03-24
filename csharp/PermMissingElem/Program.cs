https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/

var finder = new Solution();
var answer = finder.solution(new[]{2,3,1,5});
Console.WriteLine("Done");

class Solution
{
    public int solution(int[] A)
    {
        long accumulator = ((A.LongLength + 1) * (A.LongLength + 2)) / 2;

        for(int i = 0; i < A.Length; i++)
        {
            accumulator -= A[i];
        }

        return (int)accumulator;
    }
}