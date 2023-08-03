#include <vector>
#include <iostream>

using namespace std;

class Solution 
{
private:
    unsigned char b1_mask = 0b10000000;
    unsigned char b2_mask = 0b11100000;
    unsigned char b3_mask = 0b11110000;
    unsigned char b4_mask = 0b11111000;

private:
    bool checkFollowing(const vector<int> &data, int index) const
    {
        if(index < data.size())
        {
            unsigned char b = data[index];
            return (b & 0b11000000) == 0b10000000;
        }

        return false;
    }

public:
    bool validUtf8(const vector<int>& data) 
    {
        for(auto i = 0; i < data.size();)
        {
            unsigned char b = data[i];

            if((b & b1_mask) == 0)
            {
                i++;
            }
            else if((b & b2_mask) == 0b11000000)
            {
                if(!checkFollowing(data, i + 1)) return false;

                i += 2;
            }
            else if((b & b3_mask) == 0b11100000)
            {
                if(!checkFollowing(data, i + 1)) return false;
                if(!checkFollowing(data, i + 2)) return false;

                i += 3;
            }
            else if((b & b4_mask) == 0b11110000)
            {
                if(!checkFollowing(data, i + 1)) return false;
                if(!checkFollowing(data, i + 2)) return false;
                if(!checkFollowing(data, i + 3)) return false;

                i += 4;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
};

int main()
{
    Solution s;

    std::cout << s.validUtf8({197,130,1}) << "\n";
    std::cout << s.validUtf8({235,140,4}) << "\n";
}