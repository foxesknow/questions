﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q59_SpiralMatrix2
{
    public class Solution
    {
        public int[][] GenerateMatrix(int n) 
        {
            var matrix = new int[n][];
            for(var i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            var totalItems = n * n;
            int col = 0, colStart = 0, colStop = n - 1, colDirection = 1;
            int row = 0, rowStart = 0, rowStop = n - 1, rowDirection = 0;

            for(int i = 0; i < totalItems; i++)
            {
                matrix[row][col] = i + 1;

                if(colDirection == 1 && col == colStop)
                {
                    // We're going left to right and have reached the end
                    rowDirection = 1;
                    colDirection = 0;
                    rowStart++;
                }
                else if(colDirection == -1 && col == colStart)
                {
                    // We're going right to left and have reached the beginning
                    rowDirection = -1;
                    colDirection = 0;
                    rowStop--;
                }
                else if(rowDirection == 1 && row == rowStop)
                {
                    // We're going top to bottom and have reached the bottom
                    rowDirection = 0;
                    colDirection = -1;
                    colStop--;
                }
                else if(rowDirection == -1 && row == rowStart)
                {
                    // We're going bottom to top and have reached the top
                    rowDirection = 0;
                    colDirection = 1;
                    colStart++;
                }

                row += rowDirection;
                col += colDirection;
            }

            return matrix;            
        }
    }
}
