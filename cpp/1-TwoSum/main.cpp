#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        auto indexes = unordered_map<int, int>();

        for(int i = 0; i < nums.size(); i++)
        {
            const auto value = nums[i];
            const auto existing = indexes.find(target - value);
            
            if(existing == end(indexes))
            {
                indexes.insert({value, i});
            }
            else
            {
                return {existing->second, i};
            }
        }

        return vector<int>();
    }
};

template<typename T>
void print(const std::vector<T> &items)
{
    for(const auto &item : items)
    {
        std::cout << item << ' ';
    }

    std::cout << '\n';
}

int main()
{
    Solution solution;

    {
        auto nums = vector<int>{2,7,11,15};
        print(solution.twoSum(nums, 9));
    }

    return 0;
}