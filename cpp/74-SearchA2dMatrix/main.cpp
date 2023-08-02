#include <vector>

using namespace std;

class Solution 
{
private:
    int getValue(vector<vector<int>>& matrix, int absoluteIndex, int numberOfcolumns) const
    {
        const auto row = absoluteIndex / numberOfcolumns;
        const auto col = absoluteIndex % numberOfcolumns;

        return matrix[row][col];
    }

public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) 
    {
        const int numberOfRows = matrix.size();
        const int numberOfColumns = matrix[0].size();

        int left = 0;
        int right = (numberOfRows * numberOfColumns) - 1;

        while(left <= right)
        {
            auto mid = (left + right) / 2;
            
            const auto value = getValue(matrix, mid, numberOfColumns);
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
};

void test1()
{
    vector<vector<int>> matrix =
    {
        {1,3,5,7},
        {10,11,16,20},
        {23,30,34,60}
    };

    Solution s;
    auto found = s.searchMatrix(matrix, 13);
}

void test2()
{
    vector<vector<int>> matrix =
    {
        {1},
    };

    Solution s;
    auto found = s.searchMatrix(matrix, 0);
}

int main()
{
    test1();
    test2();
}