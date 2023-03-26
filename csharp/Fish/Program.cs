// https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/

var fish = new Solution();
int a = fish.solution(new[]{4,3,2,1,5}, new[]{0,1,0,0,0});
Console.WriteLine("done");

class Solution
{
    public int solution(int[] A, int[]B)
    {
        int alive = 0;
        var downstreamFishSize = new System.Collections.Generic.Stack<int>();

        for(int i = 0; i < A.Length; i++)
        {
            var size = A[i];
            if(B[i] == 1)
            {
                // A fish going upstream.
                downstreamFishSize.Push(size);
            }
            else
            {
                // It's fish going upstream
                while(downstreamFishSize.Count != 0)
                {
                    var downstreamSize = downstreamFishSize.Peek();
                    if(downstreamSize > size)
                    {
                        // We ate the fish!
                        break;
                    }
                    else
                    {
                        // The fish ate us
                        downstreamFishSize.Pop();
                    }
                }

                // If there's nothing left in the stack then the
                // upstream fish made it!
                if(downstreamFishSize.Count == 0)
                {
                    alive++;
                }
            }

        }

        return alive + downstreamFishSize.Count;
    }
}