#include <iostream>
#include <unordered_map>

using namespace std;

class Solution 
{
public:
    int fib(int n) 
    {
        auto first = 0, second = 1;

        while(n--)
        {
            auto next = first + second;
            first = second;
            second = next;
        }

        return first;    
    }

    int fib_cache(int n)
    {
        unordered_map<int, int> cache;
        return fib_cache(cache, n);
    }

private:
    int fib_cache(unordered_map<int, int> &cache, int n) 
    {
        if(n < 2) return n;

        if(const auto item = cache.find(n); item != cache.end())
        {
            return item->second;
        }

        auto value = fib_cache(cache, n - 1) + fib_cache(cache, n - 2);
        cache.insert({n, value});

        return value;
    }
};

int main()
{
    Solution solution;
    std::cout << solution.fib(2) << "\n";
    std::cout << solution.fib(3) << "\n";
    std::cout << solution.fib(4) << "\n";
    std::cout << solution.fib(10) << "\n";
    std::cout << solution.fib(20) << "\n";

    std::cout << "Memoize\n";
    std::cout << solution.fib_cache(2) << "\n";
    std::cout << solution.fib_cache(3) << "\n";
    std::cout << solution.fib_cache(4) << "\n";
    std::cout << solution.fib_cache(10) << "\n";
    std::cout << solution.fib_cache(20) << "\n";
}