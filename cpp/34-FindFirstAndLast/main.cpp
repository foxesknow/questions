#include <vector>
#include <algorithm>>

using namespace std;

class Solution 
{
public:
    vector<int> searchRange(const vector<int>& nums, int target) 
    {
        auto lower = lower_bound(nums.begin(), nums.end(), target);
        if(lower == nums.end() || *lower != target)
        {
            return {-1, -1};
        }

        auto upper = upper_bound(lower, nums.end(), target);

        auto first = (int)distance(nums.begin(), lower);
        auto last = (int)distance(nums.begin(), upper);

        return {first, last - 1};
    }
};

int main()
{
    Solution s;

    auto test1 = s.searchRange({5,7,7,8,8,10}, 8);
    auto test2 = s.searchRange({5,7,7,8,8,10}, 6);
    auto test3 = s.searchRange({}, 0);
}