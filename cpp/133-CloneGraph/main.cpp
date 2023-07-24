#include <vector>
#include <unordered_map>
#include <unordered_set>
#include <deque>

using namespace std;

class Node {
public:
    int val;
    vector<Node*> neighbors;
    Node() {
        val = 0;
        neighbors = vector<Node*>();
    }
    Node(int _val) {
        val = _val;
        neighbors = vector<Node*>();
    }
    Node(int _val, vector<Node*> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
};

class Solution 
{
private:
     Node *getOrCreate(const Node *node, unordered_map<int, Node*> &cache) const
    {
        auto it = cache.find(node->val);
        if(it != cache.end())
        {
            return it->second;
        }

        auto newNode = new Node(node->val);
        cache.insert({newNode->val, newNode});

        for(const auto linkedNode : node->neighbors)
        {
            auto neighbor = getOrCreate(linkedNode, cache);
            newNode->neighbors.push_back(neighbor);
        }

        return newNode;
    }

public:
    Node* cloneGraph(Node* node) 
    {
        if(node == nullptr) return node;

        unordered_map<int, Node*> nodeCache;
        
        deque<Node*> work;
        work.push_back(node);

        auto new_start = getOrCreate(node, nodeCache);

        while(!work.empty())
        {
            const auto nextNode = work.front();
            work.pop_front();

            // If we've already processed it then store
            if(nodeCache.find(nextNode->val) != nodeCache.end()) continue;

            getOrCreate(nextNode, nodeCache);
            work.insert(work.begin(), nextNode->neighbors.begin(), nextNode->neighbors.end());
        }

        return new_start;
    }
};

void test1()
{
    Solution s;

    auto node1 = new Node(1);
    auto node2 = new Node(2);
    auto node3 = new Node(3);
    auto node4 = new Node(4);

    node1->neighbors.push_back(node2);
    node1->neighbors.push_back(node3);

    node2->neighbors.push_back(node1);
    node2->neighbors.push_back(node3);

    node3->neighbors.push_back(node2);
    node3->neighbors.push_back(node4);
    
    node4->neighbors.push_back(node1);
    node4->neighbors.push_back(node3);

    s.cloneGraph(node1);
}

void test2()
{
    Solution s;
    auto node = new Node(1);
    s.cloneGraph(node);
}

int main()
{
    test1();
    test2();
}