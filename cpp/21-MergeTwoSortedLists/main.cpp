#include <iostream>

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution 
{
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) 
    {
        if(!list1) return list2;
        if(!list2) return list1;

        auto head = grab(list1, list2);
        auto next = head;

        while(list1 && list2)
        {
            next->next = grab(list1, list2);
            next = next->next;
        }

        next->next = (list1 ? list1 : list2);

        return head;
    }

    ListNode *grab(ListNode *&list1, ListNode *&list2)
    {
        ListNode *next = nullptr;
        if(list1->val < list2->val)
        {
            next = list1;
            list1 = list1->next;
        }
        else
        {
            next = list2;
            list2 = list2->next;
        }

        return next;
    }
};

void print(ListNode *node)
{
    if(node == nullptr)
    {
        std::cout << "null";
    }
    else
    {
        while(node)
        {
            std::cout << node->val << ' ';
            node = node->next;
        }
    }

    std::cout << "\n";
}

void test1()
{
    auto list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
    auto list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

    Solution solution;
    print(solution.mergeTwoLists(list1, list2));
}

void test2()
{
    ListNode *list1 = nullptr;
    ListNode *list2 = nullptr;

    Solution solution;
    print(solution.mergeTwoLists(list1, list2));
}

void test3()
{
    ListNode *list1 = nullptr;
    auto list2 = new ListNode(0);

    Solution solution;
    print(solution.mergeTwoLists(list1, list2));
}

int main()
{
    test1();
    test2();
    test3();
}