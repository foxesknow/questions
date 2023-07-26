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
    ListNode* reverseBetween(ListNode* head, int left, int right) 
    {
        if(left == right) return head;

        ListNode newHead(-1, head);
        auto next = &newHead;

        for(int i = 1; i < left; i++)
        {
            next = next->next;
        }
        
        auto endOfLeft = next;

        ListNode *subsequenceFront = nullptr;
        ListNode *subsequenceTail = nullptr;
        next = next->next;

        // Reverse the sub sequence
        for(int i = left; i <= right; i++)
        {
            auto after = next->next;
            next->next = subsequenceFront;
            subsequenceFront = next;
            next = after;

            if(subsequenceTail == nullptr) subsequenceTail = subsequenceFront;
        }

        endOfLeft->next = subsequenceFront;
        subsequenceTail->next = next;

        return newHead.next;
    }
};

int main()
{
    Solution s;
    
    auto test1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    s.reverseBetween(test1, 1, 5);
}