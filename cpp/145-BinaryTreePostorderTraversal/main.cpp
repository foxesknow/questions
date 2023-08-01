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
        
        walk(root->left, traversal);
        walk(root->right, traversal);
        traversal.push_back(root->val);
    }

    vector<int> postorderTraversal(TreeNode* root) 
    {
        vector<int> traversal;
        walk(root, traversal);

        return traversal;
    }
};