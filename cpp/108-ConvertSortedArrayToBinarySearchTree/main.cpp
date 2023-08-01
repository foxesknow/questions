#include <vector>

using namespace std;

struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode() : val(0), left(nullptr), right(nullptr) {}
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 };

class Solution 
{
    TreeNode *make(const vector<int>& nums, size_t begin, size_t end) const
    {
        auto length = end - begin;
        
        if(length == 0) return nullptr;
        if(length == 1) return new TreeNode(nums[begin]);
        if(length == 2) return new TreeNode(nums[begin], nullptr, new TreeNode(nums[begin + 1]));
        if(length == 3) return new TreeNode(nums[begin + 1], new TreeNode(nums[begin]), new TreeNode(nums[begin + 2]));

        auto pivot = length / 2;
        auto left = make(nums, begin, begin + pivot);
        auto right = make(nums, begin + pivot + 1, end);
        auto root = new TreeNode(nums[begin + pivot], left, right);
        return root;
    }

public:
    TreeNode* sortedArrayToBST(const vector<int>& nums) 
    {
        auto root = make(nums, 0, nums.size());
        return root;
    }
};

int main()
{
    Solution s;
    auto test1 = s.sortedArrayToBST({-10,-3,0,5,9});
    auto test2 = s.sortedArrayToBST({1,3});
    auto test3 = s.sortedArrayToBST({0,1,2,3,4,5,6,7,8});
}