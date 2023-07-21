#include <iostream>

class Solution 
{
public:
    int fib(int n) 
    {
        auto first = 0, second = 1;

        while(n--)
        {
            auto next = first + second;
            first = second;
            second = next;
        }

        return first;    
    }
};

int main()
{
    Solution solution;
    std::cout << solution.fib(2) << "\n";
    std::cout << solution.fib(3) << "\n";
    std::cout << solution.fib(4) << "\n";
    std::cout << solution.fib(10) << "\n";
}