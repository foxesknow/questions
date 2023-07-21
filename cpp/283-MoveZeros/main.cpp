#include <vector>

using namespace std;

class Solution {
public:
    void moveZeroes(vector<int>& nums) 
    {
        size_t next = 0;

        // First, move all non-zero numbers down
        for(const auto num : nums)
        {
            if(num != 0)
            {
                nums[next] = num;
                next++;
            }
        }   

        // And then fill what's left with zeros
        for(size_t i = next; i != nums.size(); ++i)
        {
            nums[i] = 0;
        }
    }
};