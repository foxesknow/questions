// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
Console.WriteLine("Hello, World!");

/*
 * A non-empty array consists on N integers.
 * It contains an odd number of items
 * Each item in the array can be paired with another of the same value, except the odd one out.
 * Find the odd one out
 */
class Solution {
    public int solution(int[] A) 
    {
        int oddOneOut = 0;

        for(int i = 0; i < A.Length; i++)
        {
            // XOR the first time will set the bits
            // XOR the second time will reset the bits
            // However, for the odd-one-out the bits will remain!
            // This works no matter the order of numbers in A
            oddOneOut ^= A[i];
        }

        return oddOneOut;
    }
}
