#include <vector>
#include <algorithm>

using namespace std;

class Solution 
{
public:
    int findMaxConsecutiveOnes(const vector<int>& nums) 
    {
        int overallMax = 0;
        int currentMax = 0;

        for(auto i : nums)
        {
            if(i == 1)
            {
                currentMax++;
            }
            else
            {
                overallMax = max(overallMax, currentMax);
                currentMax = 0;
            }
        }

        return max(overallMax, currentMax);
    }
};

int main()
{
    Solution s;
    auto test1 = s.findMaxConsecutiveOnes({1,1,0,1,1,1});
    auto test2 = s.findMaxConsecutiveOnes({1,0,1,1,0,1});
}