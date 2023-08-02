struct ListNode 
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution 
{
private:
    ListNode *findRightSide(ListNode *node) const
    {
        auto mid = node;

        while(node->next && node->next->next)
        {
            mid = mid->next;
            node = node->next->next;
        }

        if(node->next) mid = mid->next;

        return mid;
    }

    ListNode *reverse(ListNode *node) const 
    {
        ListNode *head = nullptr;

        while(node)
        {
            auto next = node->next;
            node->next = head;
            head = node;
            node = next;
        }

        return head;
    }

    void merge(ListNode *head, ListNode *reversed) const
    {
        while(head && reversed)
        {
            auto nextHead = head->next;
            auto nextReversed = reversed->next;

            head->next = reversed;
            reversed->next = nextHead;

            head = nextHead;
            reversed = nextReversed;
        }

        if(head) head->next = nullptr;
    }

public:
    void reorderList(ListNode* head) 
    {
        if(head == nullptr) return;
        if(head->next == nullptr) return;
        if(head->next->next == nullptr) return;

        auto rightSide = findRightSide(head);
        auto reversed = reverse(rightSide);
        merge(head, reversed);
    }
};

void test1()
{
    auto list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
    Solution s;
    s.reorderList(list);
}

void test2()
{
    auto list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    Solution s;
    s.reorderList(list);
}

int main()
{
    test1();
    test2();
}