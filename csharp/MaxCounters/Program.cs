// https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/

var from = new Solution();
var a = from.solution(5, new[]{3,4,4,6,1,4,4});

Console.WriteLine("Hello, World!");

class Solution
{
    public int[] solution(int N, int[] A)
    {
        // The maximum value see in the sequence
        var max = 0;
        
        // The minimum value that all items must be
        var floor = 0;
        var counters = new int[N];

        for(int i = 0; i < A.Length; i++)
        {
            var command = A[i];

            if(command <= N)
            {
                var value = counters[command - 1];
                
                if(value < floor)
                {
                    // We need to bump the value up to the floor and then increase it
                    counters[command - 1] = 1 + floor;
                }
                else
                {
                    // We're already at the floor, so nice and easy
                    counters[command - 1] += 1;
                }

                // Update the ongoing maximum value
                max = Math.Max(max, counters[command - 1]);
            }
            else if(command == N + 1)
            {
                // We set the maximum value by just raising the floor
                floor = max;
            }
            
        }

        for(int i = 0; i < counters.Length; i++)
        {
            // Anything below the floor needs to be moved up to the floor
            if(counters[i] < floor)
            {
                counters[i] = floor;
            }
        }

        return counters;
    }
}
