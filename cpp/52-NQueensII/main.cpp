#include <cstdlib>
#include <vector>
#include <iostream>

using namespace std;

class Solution {
private:
    const int Empty = -1;

    bool doesIntersect(int q1_row, int q1_col, int q2_row, int q2_col) const
    {
        // Two points intersect if the gradient between them is 1
        if(q1_col == q2_col) return true;

        const auto row_abs = std::abs(q1_row - q2_row);
        const auto col_abs = std::abs(q1_col - q2_col);

        return row_abs == col_abs;
    }

    bool isSafe(vector<int> &board, int row, int column) const
    {
        for(size_t board_row = 0; board_row < board.size(); ++board_row)
        {
            if(board[board_row] == Empty) 
            {
                return true;
            }

            if(doesIntersect(row, column, board_row, board[board_row]))
            {
                return false;
            }
        }

        return true;
    }

    int solve(vector<int> &board, int row) const
    {
        if(board.size() == row) return 1;

        int solutions = 0;

        for(int column = 0; column < board.size(); ++column)
        {
            if(isSafe(board, row, column))
            {
                board[row] = column;
                solutions += solve(board, row + 1);
                board[row] = Empty;
            }
        }

        return solutions;
    }

public:
    int totalNQueens(int n) 
    {
        vector<int> board(n, Empty);
        
        return solve(board, 0);
    }
};


int main()
{
    Solution solution;
    std::cout << solution.totalNQueens(4) << "\n";
    std::cout << solution.totalNQueens(1) << "\n";
    std::cout << solution.totalNQueens(8) << "\n";

}