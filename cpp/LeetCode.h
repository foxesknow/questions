/*
 * Common LeetCode types and supporting functions
 */
#pragma once

#include <iostream>
#include <vector>

struct ListNode 
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

inline void print(ListNode *node)
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

template<typename T>
inline void print(const std::vector<T> &data)
{
    for(const auto &i : data)
    {
        std::cout << i << " ";
    }

    std::cout << std::endl;
}

inline ListNode *makeList(std::initializer_list<int> values)
{
    ListNode head;
    ListNode *tail = &head;

    for(auto value : values)
    {
        auto node = new ListNode(value);
        tail->next = node;
        tail = node;
    }

    return head.next;
}

 struct TreeNode 
 {
     int val;
     TreeNode *left;
     TreeNode *right;
     TreeNode() : val(0), left(nullptr), right(nullptr) {}
     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 };