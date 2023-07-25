#include <iostream>

struct ListNode 
{
    int val;
    ListNode *next;
    ListNode(int x, ListNode *n = nullptr) : val(x), next(n) {}
};

class Solution 
{
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) 
    {
        auto carry = 0;

        ListNode *head = nullptr;
        ListNode *next = nullptr;

        while(l1 || l2 || carry)
        {
            auto sum = carry;
            if(l1) 
            {
                sum += l1->val;
                l1 = l1->next;
            }

            if(l2) 
            {
                sum += l2->val;
                l2 = l2->next;
            }

            auto node = new ListNode(sum % 10);
            carry = sum / 10;

            if(next)
            {
                next->next = node;
                next = node;
            }
            else
            {
                head = next = node;
            }
        }   

        return head;
    }
};

void test1()
{
    Solution s;
    auto l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    auto l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
    auto sum = s.addTwoNumbers(l1, l2);
}

int main()
{
    test1();
}