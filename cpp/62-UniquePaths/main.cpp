#include <iostream>
#include <unordered_map>

using namespace std;


class Solution 
{
private:
    // Generates a cell ordinal
    int getCell(int row, int column, int width) const
    {
        return (row * width) + column;
    }

    int solve(int row, int column, int rows, int columns, unordered_map<int, int> &cache) const
    {
        // We're off the edge, so bail out
        if(row == rows || column == columns) return 0;
        
        // We're at the bottom right cell, so bingo!
        if(row == rows - 1 && column == columns - 1) return 1;

        // See if we've been to this cell before
        const auto cell = getCell(row, column, columns);
        const auto lookup = cache.find(cell);
        if(lookup != cache.end()) return lookup->second;

        // Work out the solutions from here and save the result
        // as it's possible to end up back at the same cell backtracking
        int cellSolutions = solve(row + 1, column, rows, columns, cache) + solve(row, column + 1, rows, columns, cache);
        cache.insert({cell, cellSolutions});

        return cellSolutions;
    }

public:
    int uniquePaths(int m, int n) 
    {
        unordered_map<int, int> cache;
        return solve(0, 0, m, n, cache);
    }
};

int main()
{
    Solution s;

    std::cout << s.uniquePaths(3, 2) << "\n";
    std::cout << s.uniquePaths(3, 7) << "\n";
    std::cout << s.uniquePaths(23, 12) << "\n";
}