using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q6_ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows) 
        {
            if(numRows == 1) return s;

            var sequence = Zigzag(s, numRows).OrderBy(x => x.Row).ThenBy(x => x.Col);
            return new string(sequence.Select(x => x.C).ToArray());
        }

        private IEnumerable<(int Row, int Col, char C)> Zigzag(string s, int numRows)
        {
            var row = 0;
            var rowAdjust = 1;
            var col = 0;
            var colAdjust = 0;

            foreach(char c in s)
            {
                yield return (row, col, c);
                
                row += rowAdjust;
                col += colAdjust;

                if(row == numRows)
                {
                    row -= 2;
                    rowAdjust = -1;

                    col++;
                    colAdjust = 1;
                }
                else if(row == -1)
                {
                    row = 1;
                    rowAdjust = 1;

                    col--;
                    colAdjust = 0;
                }
            }
        }
    }
}
