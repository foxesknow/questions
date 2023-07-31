#include <iostream>

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
    bool isSymmetric(TreeNode *left, TreeNode *right) const
    {
        if(left == nullptr && right == nullptr) return true;
        if(left == nullptr || right == nullptr) return false;

        if(left->val != right->val) return false;

        return isSymmetric(left->left, right->right) && isSymmetric(left->right, right->left);
    }

public:
    bool isSymmetric(TreeNode* root) 
    {
        return isSymmetric(root->left, root->right);
    }
};

void test1()
{
    auto left = new TreeNode(2, new TreeNode(3), new TreeNode(4));
    auto right = new TreeNode(2, new TreeNode(4), new TreeNode(3));
    auto root = new TreeNode(1, left, right);

    Solution s;
    std::cout << s.isSymmetric(root) << "\n";
}

void test2()
{
    auto left = new TreeNode(2, nullptr, new TreeNode(3));
    auto right = new TreeNode(2, nullptr, new TreeNode(3));
    auto root = new TreeNode(1, left, right);

    Solution s;
    std::cout << s.isSymmetric(root) << "\n";
}

void test3()
{
    auto root = new TreeNode(10);
    
    Solution s;
    std::cout << s.isSymmetric(root) << "\n";
}

int main()
{
    test1();
    test2();
    test3();
}