#include <iostream>

class Solution 
{
public:
    bool isPowerOfFour(int n) 
    {
        if(n <= 0) return false;

        // Powers of 4 only have one bit set
        if((n & (n - 1)) != 0) return false;

        auto mask = 0b01010101010101010101010101010101;
        return (n & mask) == n;
    }
};

int main()
{
    Solution s;

    std::cout << s.isPowerOfFour(4) << "\n";
    std::cout << s.isPowerOfFour(20) << "\n";
    std::cout << s.isPowerOfFour(64) << "\n";
}