#include <bits/stdc++.h>
#include <iostream>

#include "../LeetCode.h"

using namespace std;

class Solution 
{
private:
    set<char> m_Top;
    set<char> m_Middle;
    set<char> m_Bottom;

    static set<char> toSet(const string &s)
    {
        set<char> set;

        for(auto c : s)
        {
            if(c >= 'A' && c <= 'Z') c += 32;

            set.insert(c);
        }

        return set;
    }

    static bool isSubset(set<char> keyboardLine, set<char> word)
    {
        return includes(keyboardLine.begin(), keyboardLine.end(), word.begin(), word.end());
    }

public:
    Solution()
     : m_Top({'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'}),
       m_Middle({'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'}),
       m_Bottom({'z', 'x', 'c', 'v', 'b', 'n', 'm'})
    {
    }

    vector<string> findWords(vector<string>& words) 
    {
        vector<string> results;

        for(const auto &s : words)
        {
            auto asSet = toSet(s);
            if(isSubset(m_Top, asSet) || isSubset(m_Middle, asSet) || isSubset(m_Bottom, asSet))
            {
                results.push_back(s);
            }
        }

        return results;
    }
};

void example1()
{
    Solution s;
    vector<string> words = {"Hello","Alaska","Dad","Peace"};
    print(s.findWords(words));
}

void example2()
{
    Solution s;
    vector<string> words = {"omk"};
    print(s.findWords(words));
}

void example3()
{
    Solution s;
    vector<string> words = {"adsdf","sfd"};
    print(s.findWords(words));
}

int main()
{
    example1();
    example2();
    example3();
}
