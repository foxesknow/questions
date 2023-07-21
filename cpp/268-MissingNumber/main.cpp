#include <cstdint>
#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int missingNumber(const vector<int>& nums) 
    {
        // We can work out the expected sum of the numbers
        // by doing some triangle maths
        int64_t sum = (nums.size() * (nums.size() + 1)) / 2;
        for(const auto i : nums)
        {
            sum -= i;
        }

        return sum;
    }
};

int main()
{
    Solution solution;
    std::cout << solution.missingNumber({3,0,1}) << std::endl;
    std::cout << solution.missingNumber({0,1}) << std::endl;
    std::cout << solution.missingNumber({9,6,4,2,3,5,7,0,1}) << std::endl;
}