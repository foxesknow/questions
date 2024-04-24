using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContigiousArrays
    {
        public int[] Count(int[]  values)
        {
            var answer = new int[values.Length];
            var stack = new Stack<int>();

            for(var i = 0; i < values.Length; i++)
            {
                while(stack.Count != 0 && values[stack.Peek()] < values[i])
                {
                    var index = stack.Pop();
                    var value = answer[index];
                    answer[i] += value;
                }

                stack.Push(i);
                answer[i]++;
            }

            return answer;
        }
    }
}
