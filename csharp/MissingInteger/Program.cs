// https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
Console.WriteLine("Hello, World!");

var missing = new Solution();
var a = missing.solution(new[]{1,3,6,4,1,2});
var b = missing.solution(new[]{-1,-3});
Console.WriteLine("done");

class Solution
{
    public int solution(int[] A)
    {
        var min = 0;
        var max = 0;

        var data = new System.Collections.Generic.HashSet<int>();

        foreach(var value in A)
        {
            if(value < 1) continue;

            if(data.Add(value))
            {
                if(min == 0 || value < min) min = value;
                max = Math.Max(max, value);
            }
        }

        // If we've not found any positive numbers, or we don't have a 1 then it's easy
        if(data.Count == 0) return 1;
        if(min > 1) return 1;

        // If we've got a all the numbers then we need 1 more than the max
        var range = max - min;
        if(data.Count == range + 1) return max + 1;

        // There's something missing between the min and max
        for(var i = min + 1; i < max; i++)
        {
            if(data.Contains(i) == false) return i;
        }

        // Wont' get here
        return 0;
    }
}
