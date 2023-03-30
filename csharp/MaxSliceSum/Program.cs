// https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
// See also: https://algodaily.com/lessons/kadanes-algorithm-explained

var maxSlice = new Solution();
var a = maxSlice.solution(new[]{3,2,-6,4,0});
var b = maxSlice.solution(new[]{1, -2, 5, -3, 4, -1, 6});

Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        if(A.Length == 1) return A[0];

        var localSum = A[0];
        var globallSum = A[0];

        for(int i = 1; i < A.Length; i++)
        {
            localSum = Math.Max(A[i], localSum + A[i]);
            if(localSum > globallSum)
            {
                globallSum = localSum;
            }
        }

        return globallSum;
    }
}
