#include <unordered_set>

using namespace std;

struct ListNode 
{
    int val;
    ListNode *next;
    ListNode(int x) : val(x), next(nullptr) {}
};

class Solution 
{
public:
    ListNode *detectCycle(ListNode *head) 
    {
        if(head == nullptr) return head;

        unordered_set<ListNode*> visited;

        while(head)
        {
            if(head->next == nullptr) break;

            auto it = visited.find(head->next);
            if(it != visited.end()) return head->next;

            visited.insert(head);
            head = head->next;
        }

        return nullptr;
    }
};

int main()
{
    auto node1 = new ListNode(3);
    auto node2 = new ListNode(2);
    auto node3 = new ListNode(0);
    auto node4 = new ListNode(-4);

    node1->next = node2;
    node2->next = node3;
    node3->next = node4;
    node4->next = node2;

    Solution s;
    auto node = s.detectCycle(node1);
}