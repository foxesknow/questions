#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

class Solution {
public:
    string licenseKeyFormatting(string s, int k) 
    {
        string result;

        int charactersAdded = 0;

        for(auto it = s.rbegin(); it != s.rend(); ++it)
        {
            auto c = *it;
            if(c == '-') continue;

            if(charactersAdded && (charactersAdded % k) == 0)
            {
                result.push_back('-');
            }

            if(c >= 'a' && c <='z')
            {
                // A hack-tastic way to convert from lower case to upper case!
                c &= ~32;
            }

            result.push_back(c);
            ++charactersAdded;
        }

        reverse(result.begin(), result.end());

        return result;
    }
};

int main()
{
    Solution s;
    cout << s.licenseKeyFormatting("5F3Z-2e-9-w", 4) << endl;
    cout << s.licenseKeyFormatting("2-5g-3-J", 2) << endl;
    cout << s.licenseKeyFormatting("2-5g-3-J", 1) << endl;

    return 0;
}