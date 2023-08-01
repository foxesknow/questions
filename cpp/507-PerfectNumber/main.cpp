#include <cmath>

using namespace std;

class Solution 
{
public:
    bool checkPerfectNumber(int num) 
    {
        if(num < 2) return false;

        auto upper = static_cast<int>(sqrt(num));
        auto sum = 1;

        for(auto i = 2; i <= upper; ++i)
        {
            if(num % i == 0)
            {
                sum += i;
                sum += num / i;
            }
        }

        return num == sum;
    }
};

int main()
{
    Solution s;
    auto test1 = s.checkPerfectNumber(28);
    auto test2 = s.checkPerfectNumber(6);
}