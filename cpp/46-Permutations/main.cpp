#include <vector>
#include <algorithm>

using namespace std;

class Solution 
{
public:
    vector<vector<int>> permute(vector<int>& nums) 
    {
        vector<vector<int>> result;
        sort(nums.begin(), nums.end());

        do
        {
            result.push_back(nums);
        }while(next_permutation(nums.begin(), nums.end()));

        return result;
    }
};

int main()
{
    Solution s;
    vector<int> v = {1,1,1};
    auto result = s.permute(v);
}