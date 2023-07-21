#include <cstdint>
#include <iostream>

using namespace std;

class Solution 
{
    int bitsPerNibble(int value) const
    {
        switch(value)
        {
            case 0:     return 0;
            case 1:     return 1;
            case 2:     return 1;
            case 3:     return 2;
            case 4:     return 1;
            case 5:     return 2;
            case 6:     return 2;
            case 7:     return 3;
            case 8:     return 1;
            case 9:     return 2;
            case 10:    return 2;
            case 11:    return 3;
            case 12:    return 2;
            case 13:    return 3;
            case 14:    return 3;
            case 15:    return 4;
        }

        return 0;
    }

public:
    int hammingWeight(uint32_t n) 
    {
        // http://graphics.stanford.edu/~seander/bithacks.html#CountBitsSetNaive
        
        int count = 0;

        while(n)
        {
            // Clear the lowest bit set...
            n &= (n - 1);
            count++;
        }

        return count;
    }

    int hammingWeight2(uint32_t n) 
    {
        int total = bitsPerNibble(n & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);
        total += bitsPerNibble((n >> 4) & 15);

        return total;
    }
};

int main()
{
    Solution solution;
    std::cout << solution.hammingWeight(11) << "\n";
    std::cout << solution.hammingWeight(4294967293) << "\n";
}