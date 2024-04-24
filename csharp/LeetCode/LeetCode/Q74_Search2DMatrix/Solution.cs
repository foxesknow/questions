using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q74_Search2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target) 
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;

            var left = 0;
            var right = (rows * columns) - 1;

            while(left <= right)
            {
                var mid = (left + right) / 2;
                
                var value = GetValue(matrix, columns, mid);
                if(value == target) return true;

                if(value < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }

        private int GetValue(int[][] matrix, int numberOfColumns, int index)
        {
            var row = index / numberOfColumns;
            var col = index % numberOfColumns;
            var value = matrix[row][col];
            
            return value;
        }
    }
}
