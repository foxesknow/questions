#include <string>
#include <iostream>

using namespace std;

class Solution 
{
public:
    bool rotateString(string s, string goal) 
    {
        if(s.size() == 0) return true;
        if(s.size() != goal.size()) return false;

        return (s + s).find(goal) != string::npos;
    }
};

int main()
{
    Solution s;
    std::cout << s.rotateString("abcde", "cdeab") << std::endl;
}