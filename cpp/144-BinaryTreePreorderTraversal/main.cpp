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
public:
    void walk(const TreeNode *root, vector<int> &traversal) const
    {
        if(root == nullptr) return;

        traversal.push_back(root->val);
        walk(root->left, traversal);
        walk(root->right, traversal);
    }

    vector<int> preorderTraversal(TreeNode* root) 
    {
        vector<int> traversal;
        walk(root, traversal);

        return traversal;
    }
};