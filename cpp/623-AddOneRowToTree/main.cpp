#include <bits/stdc++.h>
#include "../LeetCode.h"

class Solution 
{
    TreeNode *recurse(TreeNode *root, int val, int depth) const
    {
        if(root == nullptr) return nullptr;

        if(depth == 1)
        {
            return new TreeNode
            (
                root->val,
                new TreeNode(val, root->left, nullptr),
                new TreeNode(val, nullptr, root->right)
            );
        }

        auto newLeft = recurse(root->left, val, depth - 1);
        auto newRight = recurse(root->right, val, depth - 1);

        root->left = newLeft;
        root->right = newRight;

        return root;
    }

public:
    TreeNode* addOneRow(TreeNode* root, int val, int depth) 
    {
        if(depth == 1) return new TreeNode(val, root, nullptr);

        return recurse(root, val, depth - 1);
    }
};

void example1()
{
    Solution s;

    auto root = new TreeNode
                (
                    4,
                    new TreeNode
                    (
                        2,
                        new TreeNode(3),
                        new TreeNode(1)
                    ),
                    new TreeNode
                    (
                        6,
                        new TreeNode(5),
                        nullptr
                    )
                );

    auto newRoot = s.addOneRow(root, 1, 2);
}

void example2()
{
    Solution s;

    auto root = new TreeNode
                (
                    4,
                    new TreeNode
                    (
                        2,
                        new TreeNode(3),
                        new TreeNode(1)
                    ),
                    nullptr
                );

    auto newRoot = s.addOneRow(root, 1, 3);
}

int main()
{
    example1();
    example2();
}