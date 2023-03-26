// https://app.codility.com/programmers/lessons/6-sorting/triangle/

var triangle = new Solution();
var a = triangle.solution(new[]{10,2,5,1,8,20});

Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);

        /*
         * Given that P < Q < R we know:
         *          That A[Q] + A[R] > A[P] 
         *          That A[P] + A[R] > A[Q]
         *  
         *  This is a symptom of the data being sorted.
         *  
         *  So all we need to do is check that A[P] + A[Q] > A[R]
         */

        for(int i = 0; i < A.Length - 2; i++)
        {
            long p = A[i];
            long q = A[i + 1];
            long r = A[i + 2];
            if(p + q > r) return 1;
        }

        return 0;
    }
}