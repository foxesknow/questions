#include <iostream>
#include <cstdint>
#include <cstdlib>

using namespace std;

class Solution 
{
    const int MaxInt = 2147483647;
    const int MinInt = -2147483648;

private:
    int sign(int number) const
    {
        return number < 0 ? -1 : 1;
    }

public:
    int divide(int dividend, int divisor) 
    {
        if(dividend == MinInt && divisor == -1) return MaxInt;
        if(dividend == MinInt && divisor == 1) return MinInt;

        auto resultSign = sign(dividend) * sign(divisor);

        long dd = abs((long)dividend);
        long dv = abs((long)divisor);

        long result = 0;

        while(dv <= dd)
        {
            long scale = 1;
            long multiplier = dv;
            
            while(multiplier <= dd - multiplier)
            {
                multiplier += multiplier; // i.e multiplier * 2
                scale += scale;
            }
            
            result += scale;
            dd -= multiplier;
        }

        result *= resultSign;

        return (int)result;
    }
};

int main()
{
    Solution s;
    std::cout << s.divide(10, 4) << "\n";
    std::cout << s.divide(10, 3) << "\n";
    std::cout << s.divide(7, -3) << "\n";
    std::cout << s.divide(2147483647, 2) << "\n";
    std::cout << s.divide(-2147483648, 2) << "\n";
}