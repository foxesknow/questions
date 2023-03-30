using System.Linq;

// https://app.codility.com/programmers/lessons/8-leader/dominator/

var leader = new Solution();
var a = leader.solution(new[]{3,2,3,4,3,3,3,-1});
var b = leader.solution(new[]{1,2,3});
var c = leader.solution(new[]{1,2,3,4,1});

Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        if(A.Length == 0) return -1;

        /*
         * Work through the items to work out which number might be the denominator.
         * As any potential denominator occurs over half the time then for any pair
         * we encounter where the numbers are different we can discard them.
         * If they're the same then it's a potential match. We'll keep count of the potential matches.
         */
        var virtualStackSize = 0;
        var topOfStack = 0;

        foreach(var value in A)
        {
            if(virtualStackSize == 0)
            {
                // It's either the first time, or we've discarded all pairs
                topOfStack = value;
                virtualStackSize = 1;
            }
            else
            {
                // We've got a pair (value, topOfStack)
                if(value == topOfStack)
                {
                    // As the value is the same as the top of stack it could be the denominator...
                    virtualStackSize++;
                }
                else
                {
                    // The pair is different, so ignore both
                    virtualStackSize--;
                }
            }
        }

        if(virtualStackSize == 0) return -1;

        /*
         * topOfStack is now our candidate, so check to be sure
         */
        var midpoint = A.Length / 2;
        var numberOfOccurances = 0;

        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == topOfStack)
            {
                numberOfOccurances++;
                if(numberOfOccurances > midpoint) return i;
            }
        }

        return -1;
    }
}