// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var rotation = new Solution();
var a = rotation.solution(new[]{3, 8, 9, 7, 6}, 3);
var b = rotation.solution(new[]{0, 0, 0}, 1);
var c = rotation.solution(new[]{1, 2, 3, 4}, 4);
var d = rotation.solution(new[]{1, 2, 3, 4}, 5);
var e = rotation.solution(new[]{-4}, 0);
Console.WriteLine("done");

class Solution
{
    public int[] solution(int[] A, int K)
    {
        if(K == 0) return A;
        if(A.Length <= 1) return A;
        if(A.Length == K) return A;

        // Handle the number of rotations being more than the length of the list
        K = K % A.Length;

        var result = new int[A.Length];
        var nextIndex  = A.Length - K;

        for(int i = 0; i< A.Length; i++)
        {
            result[i] = A[nextIndex];
            nextIndex = (nextIndex + 1) % A.Length;
        }            

        return result;
    }
}