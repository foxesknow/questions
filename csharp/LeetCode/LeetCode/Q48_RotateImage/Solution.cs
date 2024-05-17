using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q48_RotateImage
{
    public class Solution
    {
        public void Rotate(int[][] matrix) 
        {
            var n = matrix[0].Length;
            
            // First, flip it across the diagonal
            for(var row = 0; row < n; row++)
            {
                for(var col = 0; col < row; col++)
                {
                    (matrix[row][col], matrix[col][row]) = (matrix[col][row], matrix[row][col]);
                }
            }

            // Now reverse each row
            foreach(var row in matrix)
            {
                Array.Reverse(row);
            }
        }
    }
}
