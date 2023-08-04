#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
private:
    bool isValid(int number) const
    {
        auto current = number;
        while(current)
        {
            auto digit = current % 10;
            if(digit == 0) return false;

            if(number % digit != 0) return false;

            current /= 10;
        }

        return true;
    }

public:
    vector<int> selfDividingNumbers(int left, int right) 
    {
        vector<int> numbers;

        for(int i = left; i <= right; ++i)
        {
            if(isValid(i)) numbers.push_back(i);
        }

        return numbers;
    }
};

template<typename T>
void print(const T &container)
{
    for(auto it = begin(container); it != end(container); ++it)
    {
        std::cout << *it << " ";
    }

    std::cout << std::endl;
}

int main()
{
    Solution s;
    print(s.selfDividingNumbers(1, 22));
    print(s.selfDividingNumbers(47, 85));
}