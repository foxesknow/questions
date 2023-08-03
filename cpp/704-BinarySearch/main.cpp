#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int search(const vector<int>& nums, int target) 
    {
        int left = 0;
        int right = nums.size() - 1;

        while(left <= right)
        {
            auto mid = (left + right) / 2;
            auto value = nums[mid];

            if(value == target) return mid;

            if(value < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;   
            }
        }

        return -1;
    }
};

int main()
{
    Solution s;
    std::cout << s.search({-1,0,3,5,9,12}, 9) << "\n";
    std::cout << s.search({-1,0,3,5,9,12}, 2) << "\n";
    std::cout << s.search({}, 2) << "\n";
    std::cout << s.search({2}, 2) << "\n";
}