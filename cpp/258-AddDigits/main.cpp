#include <iostream>

class Solution 
{
public:
    int addDigits(int num) 
    {
        while(num > 9)
        {
            auto sum = 0;
            while(num)
            {
                sum += num % 10;
                num /= 10;
            }

            num = sum;
        }

        return num;
    }
};

int main()
{
    Solution s;

    std::cout << s.addDigits(38) << "\n";
    std::cout << s.addDigits(0) << "\n";
}