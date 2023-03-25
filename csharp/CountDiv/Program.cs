// https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/

var countDiv = new Solution();

Console.WriteLine(countDiv.solution(6, 11, 2));
Console.WriteLine(countDiv.solution(6, 7, 2));
Console.WriteLine(countDiv.solution(6, 8, 2));
Console.WriteLine(countDiv.solution(6, 6, 2));
Console.WriteLine(countDiv.solution(7, 7, 2));
Console.WriteLine(countDiv.solution(7, 8, 2));
Console.WriteLine("Done");

class Solution
{
    public int solution(int A, int B, int K)
    {
        // Round up A to the nearest multiple of K, if it's not already a multiple
        A = roundUp(A, K);
        
        // Round down B to the nearest multiple of K, if it's not already a multiple
        B = roundDown(B, K);

        if(A <= B)
        {
            // +1 as the range is inclusive
            return 1 + ((B - A) / K);
        }

        return 0;
    }

    int roundUp(int A, int K)
    {
        var remainder = A % K;
        if(remainder != 0)
        {
            A += (K - remainder);
        }

        return A;
    }

    int roundDown(int B, int K)
    {
        return B - (B % K);
    }
}