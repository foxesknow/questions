#include <vector>
#include <algorithm>

using namespace std;

class Solution 
{
public:
    vector<vector<int>> merge(vector<vector<int>> intervals) 
    {
        sort(intervals.begin(), intervals.end());  

        vector<vector<int>> results;
        results.push_back(intervals[0]);

        for(auto it = intervals.begin() + 1; it != intervals.end(); ++it)
        {
            auto &current = *it;
            auto &last = results[results.size() - 1];

            if(last[1] >= current[0])
            {
                last[1] = max(last[1], current[1]);
            }
            else
            {
                results.push_back(current);
            }
        }

        return results;
    }
};

int main()
{
    Solution s;
    auto test1 = s.merge({{1,3}, {2,6}, {8,10}, {15,18}});
    auto test2 = s.merge({{1,4}, {4,5}});
    auto test3 = s.merge({{1,4}, {2,3}});
    auto test4 = s.merge({{1,4}, {1,3}, {1, 1}});
}