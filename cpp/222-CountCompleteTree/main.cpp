#include "../LeetCode.h"
#include <stack>

using namespace std;

class Solution 
{
public:
    int countNodes(TreeNode* root) 
    {
        if(root == nullptr) return 0;

        int count = 0;

        stack<TreeNode*> nodes;
        nodes.push(root);

        while(nodes.size() != 0)
        {
            count++;

            auto top = nodes.top();
            nodes.pop();

            if(top->left) nodes.push(top->left);
            if(top->right) nodes.push(top->right);
        }

        return count;
    }
};