#include <string>
#include <iostream>

using namespace std;

class Solution 
{
public:
    string toLowerCase(string s) 
    {
        for(auto &c : s)
        {
            if(c >= 'A' && c <= 'Z')
            {
                c = 'a' + (c - 'A');
            }
        }        

        return s;
    }
};

int main()
{
    Solution s;
    std::cout << s.toLowerCase("Hello") << "\n";
    std::cout << s.toLowerCase("goodbye") << "\n";
    std::cout << s.toLowerCase("JACK") << "\n";
}