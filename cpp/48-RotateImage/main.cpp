#include <vector>
#include <algorithm>

using namespace std;

class Solution 
{
public:
    void rotate(vector<vector<int>>& matrix) 
    {
        auto size = matrix.size();

        // Walk the triangle from top left to bottom right, transposing one triangle with another
        // We do this because we're doing an in-place transpose, and if we were to explicitly
        // transpose each cell we'd end up with the matrix we started with!
        for(size_t r = 0; r < size; ++r)
        {
            for(size_t c = 0; c < r; ++c)
            {
                swap(matrix[r][c], matrix[c][r]);
            }
        }

        for(auto &row : matrix)
        {
            reverse(row.begin(), row.end());
        }
    }
};

int main()
{
    Solution s;

    vector<vector<int>> matrix = {{1,2,3}, {4,5,6}, {7,8,9}};
    s.rotate(matrix);

    return 0;
}