#include <bits/stdc++.h>

class Solution 
{
public:
    bool canWinNim(int n) 
    {
        return (n % 4) != 0;
    }
};

void example1()
{
    Solution s;
    std::cout << s.canWinNim(4) << std::endl;
}

void example2()
{
    Solution s;
    std::cout << s.canWinNim(1) << std::endl;
}

void example3()
{
    Solution s;
    std::cout << s.canWinNim(2) << std::endl;
}

int main()
{
    example1();
    example2();
    example3();
}