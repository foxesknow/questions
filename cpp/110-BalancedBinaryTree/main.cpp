#include <cstdlib>
#include <algorithm>
#include <iostream>

using namespace std;

struct TreeNode 
{
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode() : val(0), left(nullptr), right(nullptr) {}
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
};

class Solution 
{
private:
    int depth(TreeNode *node, int acc, bool &isBalanced) const
    {
        if(node == nullptr || !isBalanced) return acc;

        auto leftDepth = depth(node->left, acc + 1, isBalanced);
        auto rightDepth = depth(node->right, acc + 1, isBalanced);

        if(abs(leftDepth - rightDepth) > 1) isBalanced = false;

        return max(leftDepth, rightDepth);
    }

public:
    bool isBalanced(TreeNode* root) 
    {
        auto isBalanced = true;
        depth(root, 0, isBalanced);
        return isBalanced;
    }
};

void test1()
{
    auto _20 = new TreeNode(20, new TreeNode(15), new TreeNode(7));
    auto _9 = new TreeNode(9);
    auto root = new TreeNode(3, _9, _20);

    Solution s;
    std::cout << s.isBalanced(root) << "\n";
}

void test2()
{
    auto _3 = new TreeNode(3, new TreeNode(4), new TreeNode(4));
    auto _2 = new TreeNode(2, _3, new TreeNode(3));
    auto root = new TreeNode(1, _2, new TreeNode(2));

    Solution s;
    std::cout << s.isBalanced(root) << "\n";
}

int main()
{
    test1();
    test2();
}