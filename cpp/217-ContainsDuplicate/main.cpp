#include <bits/stdc++.h>

using namespace std;

class Solution 
{
public:
    bool containsDuplicate(vector<int>& nums) 
    {
        sort(nums.begin(), nums.end());

        auto length = nums.size();
        for(auto i = 1; i < length; i++)
        {
            if(nums[i] == nums[i - 1]) return true;
        }

        return false;
    }
};

void example1()
{
    Solution s;

    vector<int> nums = {1, 2, 3, 1};
    std::cout << s.containsDuplicate(nums) << std::endl;
}

void example2()
{
    Solution s;

    vector<int> nums = {1, 2, 3, 4};
    std::cout << s.containsDuplicate(nums) << std::endl;
}

void example3()
{
    Solution s;

    vector<int> nums = {1,1,1,3,3,4,3,2,4,2};
    std::cout << s.containsDuplicate(nums) << std::endl;
}

int main()
{
    example1();
    example2();
    example3();
}