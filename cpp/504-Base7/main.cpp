#include <string>
#include <cmath>

using namespace std;

class Solution 
{
public:
    string convertToBase7(int num) 
    {
        auto negative = num < 0;
        auto value = abs(num);
        auto multiplier = 1;
        auto base7 = 0;

        while(value)
        {
            auto digit = value % 7;
            value /= 7;

            base7 += (digit * multiplier);
            multiplier *= 10;
        }

        if(negative) base7 *= -1;

        return to_string(base7);
    }
};

int main()
{
    Solution s;
    auto test1 = s.convertToBase7(100);
    auto test2 = s.convertToBase7(-7);
}