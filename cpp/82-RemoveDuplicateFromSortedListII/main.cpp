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
    ListNode* deleteDuplicates(ListNode* head) 
    {
        if(head == nullptr) return head;

        ListNode newHead;
        ListNode *next = &newHead;

        while(head)
        {
            if(head->next == nullptr)
            {
                next->next = head;
                head = nullptr;
                continue;
            }

            if(head->val != head->next->val)
            {
                next->next = head;
                head = head->next;
                next = next->next;
                next->next = nullptr;
            }
            else
            {
                const auto value = head->val;
                while(head && head->val == value)
                {
                    head = head->next;
                }
            }
        }

        return newHead.next;
    }
};

int main()
{
    Solution s;

    auto test1 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3)))));
    s.deleteDuplicates(test1);

    auto test2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));
    s.deleteDuplicates(test2);
}