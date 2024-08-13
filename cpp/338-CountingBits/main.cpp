#include <bits/stdc++.h>
#include "../LeetCode.h"

using namespace std;

class Solution 
{
public:
    vector<int> countBits(int n) 
    {
        vector<int> count(n + 1);
        count[0] = 0;

        /*
         * The number of bits in a number N is equal to the number 
         * in N/2 and then +1 if the current number is odd
         */
        for(auto i = 1; i <= n; i++)
        {
            auto halfCount = count[i / 2];
            auto totalCount = halfCount + (i & 1);
            count[i] = totalCount;
        }

        return count;
    }
};

void example1()
{
    Solution s;
    auto result = s.countBits(2);
    print(result);
}

void example2()
{
    Solution s;
    auto result = s.countBits(5);
    print(result);
}

int main()
{
    example1();
    example2();
}