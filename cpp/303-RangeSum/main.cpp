#include <bits/stdc++.h>

using namespace std;

class NumArray 
{
private:
    vector<int> m_Data;

public:
    NumArray(vector<int>& nums) : m_Data(std::move(nums))
    {
        // Build a prefix sum
        for(auto it = m_Data.begin() + 1; it != m_Data.end(); ++it)
        {
            *it += *(it - 1);
        }
    }
    
    int sumRange(int left, int right) 
    {
        if(left == 0) return m_Data[right];

        auto sum = m_Data[right] - m_Data[left - 1];
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