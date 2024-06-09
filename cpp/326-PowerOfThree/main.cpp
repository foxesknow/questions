#include <bits/stdc++.h>
#include <math.h>
#include <iostream>

class Solution 
{
public:
    bool isPowerOfThree(int n) 
    {
        if(n <= 0) return false; 

        long long upper = pow(3, 20);
        return (upper % n) == 0;
    }
};

void example1()
{
    Solution s;
    std::cout << s.isPowerOfThree(27) << std::endl;
}

void example2()
{
    Solution s;
    std::cout << s.isPowerOfThree(0) << std::endl;
}

void example3()
{
    Solution s;
    std::cout << s.isPowerOfThree(-1) << std::endl;
}

void example4()
{
    Solution s;
    std::cout << s.isPowerOfThree(10) << std::endl;
}

void example5()
{
    Solution s;
    std::cout << s.isPowerOfThree(9) << std::endl;
}

void example6()
{
    Solution s;
    std::cout << s.isPowerOfThree(243) << std::endl;
}

int main()
{
    example1();
    example2();
    example3();
    example4();
    example5();
    example6();
}