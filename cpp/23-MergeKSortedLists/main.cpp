#include <vector>
#include "../LeetCode.h"

using namespace std;

class Solution {
private:
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
public:
    ListNode* mergeKLists(vector<ListNode*>& lists) 
    {
        if(lists.empty()) return nullptr;    

        auto next = lists.begin();
        ListNode *merged = *next++;

        for(; next != lists.end(); ++next)
        {
            merged = mergeTwoLists(merged, *next);
        }

        return merged;
    }
};

void test1()
{
    auto l1 = makeList({1, 4, 5});
    auto l2 = makeList({1, 3, 4});
    auto l3 = makeList({2, 6});

    Solution s;
    vector<ListNode*> lists = {l1, l2, l3};
    auto merged = s.mergeKLists(lists);
    print(merged);
}

void test2()
{
    Solution s;
    vector<ListNode*> lists;
    auto merged = s.mergeKLists(lists);
    print(merged);
}

int main()
{
    test1();
    test2();
    return 0;
}

