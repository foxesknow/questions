using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q63_UniquePaths2
{
    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid) 
        {
            return Solve(0, 0, obstacleGrid.Length, obstacleGrid[0].Length, new(), obstacleGrid);
        }

        private int Solve(int row, int column, int rows, int columns, Dictionary<(int Row, int Column), int> cache, int[][] obstacleGrid)
        {
            // We're off the edge of the grid
            if(row == rows || column == columns) return 0;

            // We're at the bottom right corner (bingo!)
            if(row == rows - 1 && column == columns - 1) 
            {
                return obstacleGrid[row][column] == 1 ? 0 : 1;
            }

            if(obstacleGrid[row][column] == 1) return 0;

            if(cache.TryGetValue((row, column), out var previous))
            {
                return previous;
            }

            var thisCellSolution = Solve(row + 1, column, rows, columns, cache, obstacleGrid) +
                                   Solve(row, column + 1, rows, columns, cache, obstacleGrid);
            cache.Add((row, column), thisCellSolution);

            return thisCellSolution;
        }
    }
}
