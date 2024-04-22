using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q62_UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n) 
        {
            return Solve(0, 0, m, n, new());
        }

        private int Solve(int row, int column, int rows, int columns, Dictionary<(int Row, int Column), int> cache)
        {
            // We're off the edge of the grid
            if(row == rows || column == columns) return 0;

            // We're at the bottom right corner (bingo!)
            if(row == rows - 1 && column == columns - 1) return 1;

            if(cache.TryGetValue((row, column), out var previous))
            {
                return previous;
            }

            var thisCellSolution = Solve(row + 1, column, rows, columns, cache) +
                                   Solve(row, column + 1, rows, columns, cache);
            cache.Add((row, column), thisCellSolution);

            return thisCellSolution;
        }
    }
}
