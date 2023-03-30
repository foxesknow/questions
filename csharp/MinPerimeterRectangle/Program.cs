// https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/min_perimeter_rectangle/

var perimeter = new Solution();
var a = perimeter.solution(30);
var b = perimeter.solution(36);
var c = perimeter.solution(1);

Console.WriteLine("done");

class Solution
{
    public int solution(int N)
    {
        var root = (int)Math.Sqrt(N);

        for(int length = root; length > 0; length--)
        {
            var remainder = N % length;
            if(remainder != 0) continue;

            var height = N / length;

            return (height * 2) + (length * 2);
        }

        return 0;
    }
}
