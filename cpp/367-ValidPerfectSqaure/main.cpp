#include <iostream>

class Solution 
{
public:
    bool isPerfectSquare(int num) 
    {
        if(num == 0 || num == 1) return true;

        long lower = 0;
        long upper = num;
        long last = -1;

        while(true)
        {
            long mid = (lower + upper) / 2;

            long squared = mid * mid;
            if(squared == num) return true;
            if(last != -1 && last == mid) return false;

            if(squared > num)
            {
                upper = mid;
            }
            else
            {
                lower = mid;
            }

            last = mid;
        }
    }
};

int main()
{
    Solution s;
    std::cout << s.isPerfectSquare(16) << "\n";
    std::cout << s.isPerfectSquare(14) << "\n";
}