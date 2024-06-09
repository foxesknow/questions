#include <bits/stdc++.h>
#include "../LeetCode.h"

using namespace std;

class Solution 
{
    void recurse(TreeNode *node, stringstream &acc) const
    {
        if(node == nullptr) return;

        acc << node->val;

        if(node->left == nullptr && node->right == nullptr) return;

        if(node->left == nullptr && node->right != nullptr)
        {
            acc << "()";
            acc << '(';
            recurse(node->right, acc);
            acc << ')';
        }
        else
        {
            acc << '(';
            recurse(node->left, acc);
            acc << ')';
            
            if(node->right)
            {
                acc << '(';
                recurse(node->right, acc);
                acc << ')';
            }
        }
    }

public:
    string tree2str(TreeNode* root) 
    {
        stringstream acc;
        recurse(root, acc);

        return acc.str();
    }
};

void example1()
{
    Solution s;
    auto root = new TreeNode
                (
                    1, 
                    new TreeNode
                    (
                        2, 
                        new TreeNode(4), 
                        nullptr
                    ), 
                    new TreeNode(3)
                );

    cout << s.tree2str(root) << endl;
}

void example2()
{
    Solution s;
    auto root = new TreeNode
                (
                    1, 
                    new TreeNode
                    (
                        2, 
                        nullptr,
                        new TreeNode(4)
                    ), 
                    new TreeNode(3)
                );

    cout << s.tree2str(root) << endl;
}

int main()
{
    example1();
    example2();
}