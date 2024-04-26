using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q71_SimplifyPath
{
    public class Solution
    {
        public string SimplifyPath(string path) 
        {
            var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(parts.Length);

            foreach(var part in parts)
            {
                if(part == ".")
                {
                    continue;
                }
                else if(part == "..")
                {
                    stack.TryPop(out var _);
                }
                else
                {
                    stack.Push(part);
                }
            }

            var normalizedPath = "/" + string.Join('/', stack.Reverse());
            return normalizedPath;
        }
    }
}
