#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

class Solution 
{
private:

    bool isAlphaNumberic(char c) const
    {
        return (c >= 'a' && c <='z') || (c >= 'A' && c <='Z') || (c >= '0' && c <='9');
    }

    char to_lower(char c) const
    {
        if(c >= 'A' && c <='Z')
        {
            auto offset = c - 'A';
            return 'a' + offset;
        }

        return c;
    }

public:
    bool isPalindrome(string s) 
    {
        auto first_remove = remove_if(s.begin(), s.end(), [this](char c){return !isAlphaNumberic(c);});

        long left = 0;
        long right = distance(s.begin(), first_remove) - 1;

        while(left < right)
        {
            if(to_lower(s[left]) != to_lower(s[right])) return false;

            left++;
            right--;
        }

        return true;
    }
};

int main()
{
    Solution s;
    cout << s.isPalindrome("A man, a plan, a canal: Panama") << "\n";
    cout << s.isPalindrome("race a car") << "\n";
    cout << s.isPalindrome(" ") << "\n";
}