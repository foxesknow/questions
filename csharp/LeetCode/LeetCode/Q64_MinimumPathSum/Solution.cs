using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q64_MinimumPathSum
{
    public class Solution
    {
        public int MinPathSum(int[][] grid) 
        {
            return Solve(0, 0, grid.Length, grid[0].Length, new(), grid).Value;
        }

        private int? Solve(int row, int column, int rows, int columns, Dictionary<(int Row, int Column), int> cache, int[][] grid)
        {
            // We're off the edge of the grid
            if(row == rows || column == columns) return null;

            // We're at the bottom right corner (bingo!)
            if(row == rows - 1 && column == columns - 1) 
            {
                return grid[row][column];
            }

            if(cache.TryGetValue((row, column), out var previous))
            {
                return previous;
            }

            var goingDown = Solve(row + 1, column, rows, columns, cache, grid);
            var goingRight = Solve(row, column + 1, rows, columns, cache, grid);
            var thisCell = grid[row][column];

            var thisCellSolution = (goingDown, goingRight) switch
            {
                (null, null)  => thisCell,
                (null, int y) => thisCell + y,
                (int x, null) => thisCell + x,
                (int x, int y) => Math.Min(x, y) + thisCell
            };
            
            cache.Add((row, column), thisCellSolution);

            return thisCellSolution;
        }
    }
}
