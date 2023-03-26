// https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/

var ofThree = new Solution();
var a = ofThree.solution(new[]{-3,1,2,-2,5,6});
var b = ofThree.solution(new[]{-4,5,-5,-5});

Console.WriteLine("Done");

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        
        var length = A.Length;
        
        // It's either the top 3 that are the bigest...
        var threeBigest = A[length - 1] * A[length - 2] * A[length - 3];
        
        // Or the first 2 and the bigest. We look at the first 2 as 2 negatives
        // multiplied together make a positive
        var twoSmallestAndBigest = A[0] * A[1] * A[length-1];

        return Math.Max(threeBigest, twoSmallestAndBigest);
    }
}
