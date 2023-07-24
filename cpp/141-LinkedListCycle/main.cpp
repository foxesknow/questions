struct ListNode {
    int val;
    ListNode *next;
    ListNode(int x) : val(x), next(nullptr) {}
};

class Solution 
{
public:
    bool hasCycle(ListNode *head) 
    {
        if(head == nullptr) return false;
        if(head->next == nullptr) return false;

        auto slow = head;
        auto fast = head->next;

        while(true)
        {
            if(slow == nullptr || fast == nullptr) return false;
            if(slow == fast) break;            

            slow = slow->next;

            fast = fast->next;
            if(fast) fast = fast->next;
        }

        return true;
    }
};