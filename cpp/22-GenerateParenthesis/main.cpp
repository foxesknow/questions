#include <vector>
#include <string>
#include <iostream>

using namespace std;

class Solution {
public:
    vector<string> generateParenthesis(int n) 
    {
        vector<string> store;
        recurse("", store, 0, 0, n);
        
        return store;
    }

    void recurse(string current, vector<string> &store, int open, int close, int n) const
    {
        if(open == n && close == n)
        {
            store.push_back(current);
            return;
        }

        if(open < n)
        {
            recurse(current + '(', store, open + 1, close, n);
        }

        if(close < open)
        {
            recurse(current + ')', store, open, close + 1, n);
        }
    }
};

template<typename T>
void print(const std::vector<T> &items)
{
    for(const auto &item : items)
    {
        std::cout << item << ' ';
    }

    std::cout << '\n';
}

int main()
{
    Solution solution;
    print(solution.generateParenthesis(3));
    print(solution.generateParenthesis(1));
}