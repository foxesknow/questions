// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/

var tape = new Solution();
var a = tape.solution(new[]{3, 1, 2, 4, 3});
var b = tape.solution(new[]{1, 2, 3, 4, 2});

Console.WriteLine("Hello, World!");

class Solution
{
    public int solution(int[] A)
    {
        long sum = 0;

        // Work out the sum of the values.
        // We'll use this to work out the partition sizes later
        for(int i = 0; i < A.Length; i++)
        {
            sum += A[i];
        }

        long left = 0;
        long? minimal = null;

        for(int i = 1; i < A.Length ; i++)
        {
            left += A[i - 1];
            var right = sum - left;
            var diff = Math.Abs(left - right);

            if(minimal == null || diff < minimal) minimal = diff;
        }

        return (int)minimal.GetValueOrDefault();
    }
}
