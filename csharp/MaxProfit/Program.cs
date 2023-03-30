// https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/

var maxProfit = new Solution();
var a = maxProfit.solution(new[]{23171, 21011, 21123, 21366, 21013, 21367});
var b = maxProfit.solution(new[]{99999, 23171, 21011, 21123, 21366, 21013, 21367});
var c = maxProfit.solution(new[]{1,2,3});
var d = maxProfit.solution(new[]{3,2,1});

 Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        if(A.Length == 0 || A.Length == 1) return 0;

        var min = A[0];
        var profit = 0;

        for(int i = 1; i < A.Length; i++)
        {
            if(A[i] < min)
            {
                min = A[i];
            }
            else if(A[i] > min)
            {
                profit = Math.Max(profit, A[i] - min);
            }
        }

        return profit;
    }
}
