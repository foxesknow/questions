https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/

var from = new Solution();
var a = from.solution(5, new[]{1,3,1,4,2,3,5,4});

Console.WriteLine("Hello, World!");

class Solution
{
    public int solution(int X, int[] A)
    {
        var seen = new System.Collections.Generic.HashSet<int>();
        
        for(int i = 0; i < A.Length ; i++)
        {
            if(seen.Add(A[i]) && seen.Count == X)
            {
                return i;
            }
        }

        return -1;
    }
}
