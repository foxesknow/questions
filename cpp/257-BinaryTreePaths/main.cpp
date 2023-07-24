#include <string>
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
private:
    void walk(TreeNode* root, vector<string> &result, string acc) const
    {
        if(root->left == nullptr && root->right == nullptr)
        {
            result.push_back(acc);
            return;
        }
        if(root->left) walk(root->left, result, acc + "->" + to_string(root->left->val));
        if(root->right) walk(root->right, result, acc + "->" + to_string(root->right->val));
    }

public:
    vector<string> binaryTreePaths(TreeNode* root) 
    {
        vector<string> result;
        auto acc = to_string(root->val);

        walk(root, result, acc);
        return result;
    }
};

int main()
{
    auto tree = new TreeNode(1, new TreeNode(2), new TreeNode(3));

    Solution s;
    s.binaryTreePaths(tree);
}