#include <iostream>

using namespace std;

class Solution 
{
public:
    bool isPalindrome(int x) 
    {
        if(x < 0) return false;

        auto original = x;
        uint64_t number = 0;

        while(x)
        {
            number *= 10;
            number += (x % 10);

            x /= 10;
        }

        return number == original;
    }
};

int main()
{
    Solution s;
    cout << s.isPalindrome(10) << endl;
    cout << s.isPalindrome(12321) << endl;

    return 0;
}