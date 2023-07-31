#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
public:
    vector<int> getRow(int rowIndex) 
    {
        vector<int> row(rowIndex + 1, 0);

        long value = 1;
        int line = rowIndex + 1;
        
        for(int i = 1; i <= rowIndex + 1; ++i)
        {
            row[i - 1] = value;
            value = (int)(value * (line - i) / i);
        }

        return row;
    }
};

int main()
{
    Solution s;
    auto result = s.getRow(3);
}