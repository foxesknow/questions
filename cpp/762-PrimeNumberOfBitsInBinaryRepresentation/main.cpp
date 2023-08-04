#include <iostream>

class Solution 
{
private:
    int countBits(int number) const
    {
        auto count = 0;

        while(number)
        {
            number &= (number - 1);
            count++;
        }

        return count;
    }

    bool isPrime(int number) const
    {
        switch(number)
        {
            case 2:
            case 3:
            case 5:
            case 7:
            case 11:
            case 13:
            case 17:
            case 19:
            case 23:
            case 29:
            case 31:    return true;
            default:    return false;
        }
    }

public:
    int countPrimeSetBits(int left, int right) 
    {
        int count = 0;

        for(int i = left; i <= right; ++i)
        {
            auto bitCount = countBits(i);
            if(isPrime(bitCount))
            {
                ++count;
            }
        }

        return count;
    }
};

int main()
{
    Solution s;
    std::cout << s.countPrimeSetBits(6, 10) << "\n";
    std::cout << s.countPrimeSetBits(10, 15) << "\n";
}