#include <string>
#include <iostream>

using namespace std;

class Solution 
{
public:
    int firstUniqChar(string s) 
    {
        int frequencies[26] = {0};

        // Go through the string, counting the occurances of each character
        for(auto c : s)
        {
            const int index = c -'a';
            frequencies[index]++;
        }

        // Now go through it again, stopping when he get a frequency of 1
        for(int i = 0; i < s.size(); ++i)
        {
            const int index = s[i] - 'a';
            if(frequencies[index] == 1) return i;
        }

        return -1;
    }
};

int main()
{
    Solution s;

    std::cout << s.firstUniqChar("leetcode") << std::endl;
    std::cout << s.firstUniqChar("loveleetcode") << std::endl;
    std::cout << s.firstUniqChar("aabb") << std::endl;
}