#include <cstdlib>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int reverse(int x) 
    {
        const int maxInt = 2147483647;

        const auto isNegative = x < 0;
        int value = 0;

        while(x)
        {
            const auto nextDigit = abs(x % 10);

            // Check for overflow
            if(value && ((maxInt - nextDigit) / value) < 10) return 0;
            value = (value * 10) + nextDigit;

            x /= 10;
        }

        // A positive integer always has a negative equivilant
        if(isNegative) value *= -1;

        return value;
    }
};

int main()
{
    Solution solution;
    std::cout << solution.reverse(123) << "\n";
    std::cout << solution.reverse(-123) << "\n";
    std::cout << solution.reverse(120) << "\n";
    std::cout << solution.reverse(0) << "\n";
}