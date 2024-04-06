#include <vector>

using namespace std;

class Solution 
{
public:
    vector<int> spiralOrder(vector<vector<int>>& matrix) 
    {
        vector<int> output;

        auto totalItems = matrix.size() * matrix[0].size();
        int colStop = matrix[0].size() - 1, rowStop = matrix.size() - 1;
        int colStart = 0, rowStart = 0;

        int row = 0, col = 0;
        int rowDirection = 0, colDirection = 1;

        for(auto i = 0; i < totalItems; i++)
        {
            output.push_back(matrix[row][col]);

            if(colDirection == 1 && col == colStop)
            {
                rowDirection = 1;
                colDirection = 0;
                rowStart++;
            }
            else if(colDirection == -1 && col == colStart)
            {
                rowDirection = -1;
                colDirection = 0;
                rowStop--;
            }
            else if(rowDirection == 1 && row == rowStop)
            {
                rowDirection = 0;
                colDirection = -1;
                colStop--;
            }
            else if(rowDirection == -1 && row == rowStart)
            {
                rowDirection = 0;
                colDirection = 1;
                colStart++;
            }

            row += rowDirection;
            col += colDirection;
        }

        return output;
    }
};

int main()
{
    Solution s;
    vector<vector<int>> matrix = {{1,2,3}, {4,5,6}, {7,8,9}};
    //vector<vector<int>> matrix = {{1,2,3,4}, {5,6,7,8}, {9,10,11,12}};
    auto result = s.spiralOrder(matrix);

    return 0;
}