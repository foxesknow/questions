#include <bits/stdc++.h>

using namespace std;

class NumArray 
{
private:
    vector<int> m_Data;

public:
    NumArray(vector<int>& nums) : m_Data(std::move(nums))
    {
        
    }
    
    int sumRange(int left, int right) 
    {
        auto sum = 0;

        for(auto i = left; i <= right; i++)
        {
            sum += m_Data[i];
        }

        return sum;    
    }
};

void example1()
{
    vector<int> nums = {-2, 0, 3, -5, 2, -1};
    NumArray s(nums);
    
    std::cout << s.sumRange(0, 2) << std::endl;
    std::cout << s.sumRange(2, 5) << std::endl;
    std::cout << s.sumRange(0, 5) << std::endl;
}

int main()
{
    example1();
}