// https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/

var factors = new Solution();
var a = factors.solution(1);
var b = factors.solution(2);
var c = factors.solution(6);
var d = factors.solution(12);
var e = factors.solution(3);
var f = factors.solution(7);
var g = factors.solution(120);
var h = factors.solution(16);

Console.WriteLine("done");

class Solution
{
    public int solution(int N)
    {
        if(N == 1) return 1;

        var count = 0;

        var root = (int)Math.Sqrt(N);
        for(int i = 1; i <= root; i++)
        {
            if((N % i) == 0) 
            {
                // Most factors are X * Y, giving us 2 factors each pass.
                // However, if the original number is a square then it'll be X * X, giving us just the one factor
                if(i * i == N)
                {
                    count += 1;
                }
                else
                {
                    count += 2;
                }
            }
        }

        return count;
    }
}
