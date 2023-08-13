#include <string>
#include <iostream>
#include <algorithm>

using namespace std;

class Solution 
{
private:
    int nextDigit(const string &s, int index) const
    {
        if(index >= 0) return s[index] - '0';

        return 0;
    }

public:
    string addBinary(string a, string b) 
    {
        string result = "";
        
        int offsetA = a.size();
        --offsetA;

        int offsetB = b.size();
        --offsetB;
        
        int carry = 0;

        while(offsetA >= 0 || offsetB >= 0 || carry == 1)
        {
            const auto bitA = nextDigit(a, offsetA);
            const auto bitB = nextDigit(b, offsetB);
            
            const auto sum = bitA + bitB + carry;
            result.push_back('0' + (sum % 2));            
            carry = sum / 2;

            offsetA--;
            offsetB--;
        }

        reverse(result.begin(), result.end());
        return result;
    }
};

int main()
{
    Solution s;
    std::cout << s.addBinary("11", "1") << "\n";
    std::cout << s.addBinary("1010", "1011") << "\n";
}