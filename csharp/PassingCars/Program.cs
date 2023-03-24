// https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
Console.WriteLine("Hello, World!");

var missing = new Solution();
var a = missing.solution(new[]{0,1,0,1,1});
var b = missing.solution(new[]{0,0});
var c = missing.solution(new[]{1,0});
Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        var count = 0;
        var adjustment = 0;

        foreach(var car in A)
        {
            if(car == 0)
            {
                // Something going east
                adjustment++;
            }
            else if(car == 1)
            {
                // Something going west
                count += adjustment;
            }

            if(count > 1_000_000_000) return -1;
        }

        return count;
    }
}
