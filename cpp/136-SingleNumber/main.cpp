#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int singleNumber(const vector<int>& nums) 
    {
        int missing = 0;

        for(const auto number : nums)
        {
            missing ^= number;
        }

        return missing;
    }
};

int main()
{
    Solution solution;

    std::cout << solution.singleNumber({2,2,1}) << "\n";
    std::cout << solution.singleNumber({4,1,2,1,2}) << "\n";
    std::cout << solution.singleNumber({1}) << "\n";
}