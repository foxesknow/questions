#include <vector>
#include <string>
using namespace std;

class Solution 
{
private:
    string makeString(int start, int stop) const
    {
        if(stop == start)
        {
            return to_string(start);
        }
        else
        {
            return to_string(start) + "->" + to_string(stop);
        }
    }

public:
    vector<string> summaryRanges(const vector<int>& nums) 
    {
        vector<string> result;

        if(nums.size() == 0) return result;

        if(nums.size() == 1)
        {
            result.push_back(makeString(nums[0], nums[0]));
            return result;
        }

        int start = nums[0];
        int stop = start;

        for(auto i = 1 ; i < nums.size(); ++i)
        {
            auto num = nums[i];

            if(num == stop + 1)
            {
                stop = num;
                continue;
            }

            // We're at the end of a range
            result.push_back(makeString(start, stop));
            
            start = stop = num;
        }

        result.push_back(makeString(start, stop));

        return result;
    }
};

int main()
{
    Solution s;
    auto test1 = s.summaryRanges({0,1,2,4,5,7});
    auto test2 = s.summaryRanges({0,2,4,6});
    auto test3 = s.summaryRanges({0,1,2,3,4});
}