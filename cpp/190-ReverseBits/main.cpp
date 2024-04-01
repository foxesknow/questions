#include <iostream>

class Solution {
public:
    uint32_t reverseBits(uint32_t n) 
    {
        uint32_t result = 0;

        for(int i = 31; i >= 0 && n; i--)
        {
            result |= ((n & 1) << i);
            n >>= 1;
        }

        return result;    
    }
};

int main()
{
    Solution s;
    std::cout << s.reverseBits(0b00000010100101000001111010011100) << std::endl;
    std::cout << s.reverseBits(0b11111111111111111111111111111101) << std::endl;

    return 0;
}