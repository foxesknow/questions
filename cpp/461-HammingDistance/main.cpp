#include <iostream>

class Solution {
public:
    int hammingDistance(int x, int y) 
    {
        int count = 0;

        while(x || y)
        {
            count += (x & 1) ^ (y & 1);
            x >>= 1;
            y >>= 1;
        }

        return count;   
    }
};

int main()
{
    Solution s;
    std::cout << s.hammingDistance(1, 3) << std::endl;
    std::cout << s.hammingDistance(1, 4) << std::endl;

    return 0;    
}