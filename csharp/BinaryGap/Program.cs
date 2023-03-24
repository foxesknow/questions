// Codility: https://app.codility.com/programmers/trainings/9/binary_gap/

var gap = new Solution();
Console.WriteLine(gap.solution(9));
Console.WriteLine(gap.solution(529));
Console.WriteLine(gap.solution(20));
Console.WriteLine(gap.solution(1041));
Console.WriteLine("Done");

/// <summary>
/// Find the longest binary gap (a run of zeros) between two 1s
/// 
/// For example 9 is 1001 and the longest gap is 2
///             20 is 10100 and the longest gap is 1
///             529 is 1000010001 and the longest gap is 5
/// </summary>
class Solution
{
    public int solution(int N)
    {
        var longest = 0;
        var counting = false;
        var currentRun = 0;

        while(N != 0)
        {
            var nextBit = N & 1;
            
            if(nextBit == 1)
            {
                counting = true;

                if(currentRun > longest)
                {
                    longest = currentRun;
                }

                currentRun = 0;
            }
            else
            {
                if(counting) currentRun++;
            }

            N >>= 1;
        }

        return longest;
    }
}


