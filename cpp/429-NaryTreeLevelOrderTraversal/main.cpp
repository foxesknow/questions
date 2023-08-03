#include <vector>
#include <deque>

using namespace std;

class Node 
{
public:
    int val;
    vector<Node*> children;

    Node() {}

    Node(int _val) {
        val = _val;
    }

    Node(int _val, vector<Node*> _children) 
    {
        val = _val;
        children = _children;
    }
};

class Solution 
{
public:
    vector<vector<int>> levelOrder(Node* root) 
    {
        vector<vector<int>> results;
        if(root == nullptr) return results;

        deque<Node*> nodes;
        nodes.push_back(root);

        while(!nodes.empty())
        {
            vector<int> level;

            size_t nodesCount = nodes.size();
            for(size_t i = 0; i < nodesCount; ++ i)
            {
                auto node = nodes.front();
                nodes.pop_front();

                level.push_back(node->val);
                for(auto child : node->children)
                {
                    nodes.push_back(child);
                }
            }

            results.push_back(move(level));
        }

        return results;
    }
};

int main()
{
}