// https://app.codility.com/programmers/lessons/8-leader/equi_leader/

var equiLeader = new Solution();
var a = equiLeader.solution(new[]{4,3,4,4,4,2});

Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        if(FindDenominator(A, out var denominator, out var frequency) == false) return 0;

        var leftCount = 0;
        var rightCount = frequency;
        var count = 0;

        for(int pivot = 0; pivot < A.Length; pivot++)
        {
            if(A[pivot] == denominator)
            {
                leftCount++;
                rightCount--;
            }

            var leftSize = pivot + 1;
            var rightSize = A.Length - leftSize;

            if(leftCount > leftSize / 2 && rightCount > rightSize / 2)
            {
                count++;
            }
        }

        return count;
    }

    private bool FindDenominator(int[] A, out int denominator, out int frequency)
    {
        frequency = 0;
        denominator = 0;

        if(A.Length == 0) return false;

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

        if(virtualStackSize == 0) return false;

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
            }
        }

        if(numberOfOccurances > midpoint)
        {
            frequency = numberOfOccurances;
            denominator = topOfStack;

            return true;
        }

        return false;
    }
}