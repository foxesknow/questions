#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int pivotIndex(const vector<int>& nums) 
    {
        vector<int> leftToRight = nums;
        vector<int> rightToLeft = nums;

        for(auto it = leftToRight.begin() + 1; it != leftToRight.end(); ++it)
        {
            *it = *it + *(it - 1);
        }

        for(auto it = rightToLeft.rbegin() + 1; it != rightToLeft.rend(); ++it)
        {
            *it = *it + *(it - 1);
        }

        for(int i = 0; i < leftToRight.size(); ++i)
        {
            if(leftToRight[i] == rightToLeft[i]) return i;
        }

        return -1;
    }
};

int main()
{
    Solution s;
    std::cout << s.pivotIndex({1,7,3,6,5,6}) << "\n";
    std::cout << s.pivotIndex({2,1,-1}) << "\n";
    std::cout << s.pivotIndex({1,2,3}) << "\n";
}