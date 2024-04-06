#include <string>
#include <limits>
#include <iostream>

using namespace std;

class Solution 
{
private:
    string::iterator skipWhitespace(string::iterator it, string::iterator end) const
    {
        while(it != end && *it == ' ')
        {
            ++it;
        }

        return it;
    }

    bool isDigit(char c) const
    {
        return c >= '0' && c <= '9';
    }

    int toNumber(char c) const
    {
        return c - '0';
    }

public:
    int myAtoi(string s) 
    {
        auto end = s.end();
        auto it = skipWhitespace(s.begin(), end);

        if(it == end) return 0;

        bool isNegative = false;
        if(*it == '-' || *it == '+')
        {
            isNegative = (*it == '-');
            ++it;
        }

        uint64_t number = 0;
        uint64_t largestAbs = ((uint64_t)numeric_limits<int>::max()) + (isNegative ? 1 : 0);

        for(; it != end && isDigit(*it); ++it)
        {
            number = (number * 10) + toNumber(*it);

            if(number >= largestAbs) break;
        }

        if(isNegative && number >= largestAbs) return numeric_limits<int>::min();
        if(!isNegative && number >= largestAbs) return numeric_limits<int>::max();

        if(isNegative) number *= -1;

        return static_cast<int>(number);
    }
};

int main()
{
    Solution s;

    cout << s.myAtoi("1") << endl;
    cout << s.myAtoi("42") << endl;
    cout << s.myAtoi("   -42") << endl;
    cout << s.myAtoi("4193 with words") << endl;

    cout << s.myAtoi("2147483647") << endl;
    cout << s.myAtoi("2147483648") << endl;
    
    cout << s.myAtoi("-2147483648") << endl;

    return 0;
}