#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

class KthLargest 
{
private:
    int m_K;
    vector<int> m_Stream;

public:
    KthLargest(int k, vector<int> nums) : m_K(k)
    {
        if(nums.size())
        {
            sort(nums.begin(), nums.end());

            if(m_K >= nums.size())
            {
                m_Stream.insert(m_Stream.begin(), nums.begin(), nums.end());
            }
            else
            {
                auto offset = nums.size() - k;
                m_Stream.insert(m_Stream.begin(), nums.begin() + offset, nums.end());
            }
        }
    }
    
    int add(int val) 
    {
        if(m_Stream.size() == m_K)
        {
            if(val <= m_Stream[0]) return m_Stream[0];
            if(val >= m_Stream[m_K - 1])
            {
                if(m_Stream.size() == m_K) m_Stream.erase(m_Stream.begin());
                m_Stream.push_back(val);
                return m_Stream[0];
            }
        }

        // It goes somewhere in the middle
        auto it = lower_bound(m_Stream.begin(), m_Stream.end(), val);
        m_Stream.insert(it, val);

        if(m_Stream.size() > m_K) m_Stream.erase(m_Stream.begin());

        return m_Stream[0];
    }
};

void test1()
{
    KthLargest s(3, vector<int>({4, 5, 8, 2}));
    std::cout << s.add(3) << "\n";
    std::cout << s.add(5) << "\n";
    std::cout << s.add(10) << "\n";
    std::cout << s.add(9) << "\n";
    std::cout << s.add(4) << "\n";
}

void test2()
{
    KthLargest s(1, vector<int>({}));
    std::cout << s.add(-3) << "\n";
    std::cout << s.add(-2) << "\n";
    std::cout << s.add(-4) << "\n";
    std::cout << s.add(0) << "\n";
    std::cout << s.add(4) << "\n";
}

void test3()
{
    KthLargest s(2, vector<int>({0}));
    std::cout << s.add(-1) << "\n";
    std::cout << s.add(1) << "\n";
    std::cout << s.add(-2) << "\n";
    std::cout << s.add(-4) << "\n";
    std::cout << s.add(3) << "\n";
}

int main()
{
    test3();
}