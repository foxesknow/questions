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
private:
    bool areIdentical(const TreeNode *node1, const TreeNode *node2) const
    {
        if(node1 == nullptr && node2 == nullptr) return true;
        if(node1 == nullptr || node2 == nullptr) return false;
        if(node1->val != node2->val) return false;

        return areIdentical(node1->left, node2->left) && areIdentical(node1->right, node2->right);
    }

public:
    bool isSubtree(TreeNode* root, TreeNode* subRoot) 
    {
        stack<TreeNode*> nodes;
        nodes.push(root);

        while(!nodes.empty())
        {
            auto next = nodes.top();
            nodes.pop();

            if(next->val == subRoot->val && areIdentical(next, subRoot))
            {
                return true;
            }

            if(next->left) nodes.push(next->left);
            if(next->right) nodes.push(next->right);
        }

        return false;
    }
};

int main()
{
}