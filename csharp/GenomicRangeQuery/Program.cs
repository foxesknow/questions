// https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/

var query = new Solution();
var a = query.solution("CAGCCTA", new[]{2,5,0}, new[]{4,5,6});
var b = query.solution("AC", new[]{0,0,1}, new[]{0,1,1});
Console.WriteLine("Done");


class Solution
{
    public int[] solution(string S, int[] P, int[] Q)
    {      
        /*
         * We buildup an ongoing cost of the string as a prefix count.
         * Using CAGCCTA as our input string:
         *    0 1 2 3 4 5 6 7
         *    ---------------
         *      C A G C C T A
         * A: 0 0 1 1 1 1 1 2
         * C: 0 1 1 2 3 3 3 3
         * G: 0 0 0 1 1 1 1 1
         * T: 0 0 0 0 0 0 1 1
         * 
         * We add in a column of zeros at the start to make the calculation easier.
         * This way every additional column reflects what changed compared to the last.
         * For example in column #2 we have (1, 1, 0, 0) and in column #1 we have (0, 1, 0, 0)
         * so we can see that the first value changed and therefore an A was present
         * 
         * The start index now refers to the previous character, which is fine as it tells us what
         * changed to make that column. However, the end is out by 1 so we'll need to increase it.
         * For for (2, 2) which refers to the G character we look at the difference between column 2 and 3.
         * The 3 is the G and the 2 is the previous values.
         * 
         * We always need to start from a column 1 less than the start index to see what caused the change.
         * The extra column at the front means we don't require any code to do this, but it means we need 
         * to +1 the end
         */

        int[] prefixOfAs = new int[S.Length + 1];
        int[] prefixOfCs = new int[S.Length + 1];
        int[] prefixOfGs = new int[S.Length + 1];
        int[] prefixOfTs = new int[S.Length + 1];

        int sumOfA = 0;
        int sumOfC = 0;
        int sumOfG = 0;
        int sumOfT = 0;

        for(int i = 0; i < S.Length; i++)
        {
            char c = S[i];

            if(c == 'A') sumOfA++;
            else if(c == 'C') sumOfC++;
            else if(c == 'G') sumOfG++;
            else if(c == 'T') sumOfT++;

            prefixOfAs[i + 1] = sumOfA;
            prefixOfCs[i + 1] = sumOfC;
            prefixOfGs[i + 1] = sumOfG;
            prefixOfTs[i + 1] = sumOfT;
        }

        var result = new int[P.Length];

        for(int i = 0; i < P.Length; i++)
        {
            var start = P[i];

            // +1 as we inserted a column at the front
            var end = Q[i] + 1; 

            /*
             * We can work out the impact by comparing the difference between the start and end
             * values in our prefix arrays. If the end is greater than the start then it means
             * something change within that range
             */
            int impact = 0;
            if(prefixOfAs[end] > prefixOfAs[start]) impact = 1;
            else if(prefixOfCs[end] > prefixOfCs[start]) impact = 2;
            else if(prefixOfGs[end] > prefixOfGs[start]) impact = 3;
            else if(prefixOfTs[end] > prefixOfTs[start]) impact = 4;

            result[i] = impact;
        }

        return result;
    }
}