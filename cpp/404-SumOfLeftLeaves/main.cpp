#include <utility>
#include <stack>

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
    int sumOfLeftLeaves(TreeNode* root) 
    {
        stack<pair<TreeNode*, TreeNode*>> nodes;
        if(root->left) nodes.push({root->left, root});
        if(root->right) nodes.push({root->right, root});

        auto sum = 0;

        while(!nodes.empty())
        {
            auto nodeAndParent = nodes.top();
            nodes.pop();

            auto node = nodeAndParent.first;
            auto parent = nodeAndParent.second;

            if(node->left == nullptr && node->right == nullptr && parent->left == node)
            {
                sum += node->val;
            }
            else
            {
                if(node->left) nodes.push({node->left, node});
                if(node->right) nodes.push({node->right, node});
            }
        }

        return sum;
    }
};

int main()
{
    auto root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

    Solution s;
    s.sumOfLeftLeaves(root);
}