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
    void walk(TreeNode *node, int total, int &accumulator) const
    {
        total = (total * 10) + node->val;

        if(node->left == nullptr && node->right == nullptr)
        {
            accumulator += total;
            return;
        }

        if(node->left) walk(node->left, total, accumulator);
        if(node->right) walk(node->right, total, accumulator);
    }

public:
    int sumNumbers(TreeNode* root) 
    {
        int accumulator = 0;
        walk(root, 0, accumulator);

        return accumulator;
    }
};

int main()
{
    Solution s;
    
    auto test1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    auto test1Sum = s.sumNumbers(test1);

    auto test2 = new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0));
    auto test2Sum = s.sumNumbers(test2);
}