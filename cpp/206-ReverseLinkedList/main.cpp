struct ListNode 
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x, ListNode *next = nullptr) : val(x), next(next) {}
};

class Solution 
{
public:
    ListNode* reverseList(ListNode* head) 
    {
        ListNode *newHead = nullptr;

        while(head)
        {
            auto after = head->next;
            head->next = newHead;
            newHead = head;
            head = after;
        }

        return newHead;
    }
};

int main()
{
    Solution s;
    auto test1 = new ListNode(1, new ListNode(2, new ListNode(3)));
    s.reverseList(test1);
}