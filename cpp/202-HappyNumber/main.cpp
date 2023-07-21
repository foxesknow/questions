#include <iostream>
#include <unordered_set>

using namespace std;

class Solution 
{
private:
    int sumOfSquaredDigits(int n) const
    {
        int sum = 0;

        while(n)
        {
            auto digit = n % 10;
            sum += (digit * digit);

            n /= 10;
        }

        return sum;
    }

public:
    bool isHappy(int n) 
    {
        unordered_set<int> seen;

        while(n != 1)
        {
            auto insert_info = seen.insert(n);
            if(insert_info.second == false)
            {
                break;
            }

            n = sumOfSquaredDigits(n);
        }

        return n == 1;
    }
};

int main()
{
    Solution solution;
    std::cout << solution.isHappy(19) << "\n";
    std::cout << solution.isHappy(2) << "\n";
}