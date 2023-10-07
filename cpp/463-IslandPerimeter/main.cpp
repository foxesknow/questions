#include <iostream>
#include <vector>

using namespace std;

class Solution {
private:
    int isWater(const vector<vector<int>> &grid, int row, int col) const
    {
        if(row < 0 || col < 0) return 1;
        if(col >= grid[0].size()) return 1;
        if(row >= grid.size()) return 1;

        return grid[row][col] == 0;
    }

public:
    int islandPerimeter(vector<vector<int>>& grid) 
    {
        int perimeter = 0;

        for(int row = 0; row < grid.size(); ++row)
        {
            const auto &r = grid[row];

            for(int col = 0; col < r.size(); ++col)
            {
                if(r[col] == 0) continue;

                perimeter += isWater(grid, row - 1, col);
                perimeter += isWater(grid, row + 1, col);
                perimeter += isWater(grid, row, col - 1);
                perimeter += isWater(grid, row, col + 1);
            }
        }

        return perimeter;
    }
};

void test1()
{
    vector<vector<int>> grid =
    {
        {0,1,0,0}, {1,1,1,0}, {0,1,0,0}, {1,1,0,0}
    };

    Solution s;
    cout << s.islandPerimeter(grid) << endl;
}

void test2()
{
    vector<vector<int>> grid =
    {
        {1}
    };

    Solution s;
    cout << s.islandPerimeter(grid) << endl;
}

void test3()
{
    vector<vector<int>> grid =
    {
        {1, 0}
    };

    Solution s;
    cout << s.islandPerimeter(grid) << endl;
}

int main()
{
    test1();
    test2();
    test3();

    return 0;
}