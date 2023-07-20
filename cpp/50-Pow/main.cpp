#include <iostream>

class Solution {
public:
    double myPow(double x, int n) 
    {
        if(x == 1 || n == 0) return 1;
        if(n == 1) return x;
        if(n == -1) return 1 / x;
        if(x == 0) return 0;

        const auto half = myPow(x, n / 2);
        const auto result = half * half;

        if(n & 1 == 1)
        {
            const auto sign = (n >= 0 ? 1 : -1);
            return result * myPow(x, sign);
        }
        else
        {
            return result;
        }
    }
};

int main()
{
    Solution solution;
    std::cout << solution.myPow(2.0, 10) << std::endl;
    std::cout << solution.myPow(2.1, 3) << std::endl;
    std::cout << solution.myPow(2.0, -2) << std::endl;
    std::cout << solution.myPow(2.0, 10) << std::endl;
}