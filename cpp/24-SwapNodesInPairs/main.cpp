#include "../LeetCode.h"

class Solution 
{
public:
    ListNode* swapPairs(ListNode* head) 
    {
        if(head == nullptr || head->next == nullptr) return head;

        ListNode *swapHead = nullptr;
        ListNode *tail = nullptr;

        while(head)
        {
            if(head->next == nullptr)
            {
                if(swapHead == nullptr)
                {
                    swapHead = head;
                }
                else
                {
                    tail->next = head;
                }

                head = head -> next;

            }
            else
            {
                // We've got at least 2 items
                auto newHead = head->next->next;

                auto swap = head->next;
                swap->next = head;
                swap->next->next = nullptr;

                if(swapHead == nullptr)
                {
                    swapHead = swap;
                }
                else
                {
                    tail->next = swap;
                }

                tail = swap->next;
                head = newHead;
            }
        }

        return swapHead;
    }
};

void example1()
{
    Solution s;

    auto head = makeList({1, 2, 3, 4});
    auto swap = s.swapPairs(head);
    print(swap);
}

void example2()
{
    Solution s;

    auto head = makeList({});
    auto swap = s.swapPairs(head);
    print(swap);
}

void example3()
{
    Solution s;

    auto head = makeList({1});
    auto swap = s.swapPairs(head);
    print(swap);
}

void example4()
{
    Solution s;

    auto head = makeList({1, 2, 3, 4, 5, 6, 7});
    auto swap = s.swapPairs(head);
    print(swap);
}

int main()
{
    example1();
    example2();
    example3();
    example4();
}