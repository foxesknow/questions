#include <vector>
#include <cstdint>

using namespace std;

class Solution 
{
private:
    void set(size_t index, uint64_t *array) const
    {
        const auto i = index / 64;
        const auto offset = index % 64;

        array[i] |= (1L << offset);
    }

    bool isSet(size_t index, uint64_t *array) const
    {
        const auto i = index / 64;
        const auto offset = index % 64;

        return (array[i] & (1L << offset)) != 0;
    }

public:
    void setZeroes(vector<vector<int>>& matrix) 
    {
        // The maximum size of a the grid is 200 is either direction.
        // 4 uint64_t gives us 256 flags, which is plenty
        uint64_t rowsToZero[4] = {0};  
        uint64_t columnsToZero[4] = {0};  

        const auto rowCount = matrix.size();
        const auto columnCount = matrix[0].size();

        for(size_t rowIndex = 0; rowIndex < rowCount; ++rowIndex)
        {
            const auto &thisRow = matrix[rowIndex];

            for(size_t colIndex = 0; colIndex < columnCount; ++colIndex)
            {
                if(thisRow[colIndex] == 0)
                {
                    set(rowIndex, rowsToZero);
                    set(colIndex, columnsToZero);
                }
            }
        }

        for(size_t rowIndex = 0; rowIndex < rowCount; ++rowIndex)
        {
            auto &thisRow = matrix[rowIndex];

            for(size_t colIndex = 0; colIndex < columnCount; ++colIndex)
            {
                if(isSet(rowIndex, rowsToZero) || isSet(colIndex, columnsToZero))
                {
                    thisRow[colIndex] = 0;
                }
            }                
        }
    }
};

void test1()
{
    vector<vector<int>> matrix =
    {
        {1,1,1},
        {1,0,1},
        {1,1,1},
    };

    Solution s;
    s.setZeroes(matrix);
}

void test2()
{
    vector<vector<int>> matrix =
    {
        {0,1,2,0},
        {3,4,5,2},
        {1,3,1,5},
    };

    Solution s;
    s.setZeroes(matrix);
}

int main()
{
    test1();
    test2();
}