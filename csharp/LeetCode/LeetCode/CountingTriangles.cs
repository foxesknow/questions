using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountingTriangles
    {
        public int CountDistinct(IList<int[]> arr)
        {
            var unique = new HashSet<(int, int, int)>();

            foreach(var triangle in arr)
            {
                // Sort it;
                var (a, b, c) = (triangle[0], triangle[1], triangle[2]);
                SwapIfGreater(ref a, ref b);
                SwapIfGreater(ref b, ref c);
                SwapIfGreater(ref a, ref b);

                unique.Add((a, b, c));
            }

            return unique.Count;;
        }

        private void SwapIfGreater(ref int a, ref int b)
        {
            if(a > b)
            {
                var temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
