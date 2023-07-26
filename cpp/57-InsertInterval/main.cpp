#include <vector>

using namespace std;

class Solution 
{
private:
    vector<int> *pick(vector<vector<int>> &intervals, size_t &index, vector<int> *&newInterval) const
    {
        if(index == intervals.size())
        {
            auto temp = newInterval;
            newInterval = nullptr;
            return temp;
        }

        if(newInterval == nullptr) 
        {
            return index < intervals.size() ? &intervals[index++] : nullptr;
        }

        if(intervals[index] < *newInterval)
        {
            return &intervals[index++];
        }
        else
        {
            auto temp = newInterval;
            newInterval = nullptr;
            return temp;
        }
    }
public:
    vector<vector<int>> insert(vector<vector<int>> intervals, vector<int> newInterval) 
    {
        vector<vector<int>> results;

        vector<int> *interval = &newInterval;
        size_t index = 0;
        results.push_back(*pick(intervals, index, interval));
        
        while(auto current = pick(intervals, index, interval))
        {
            auto &last = results[results.size() - 1];

            if(last[1] >= (*current)[0])
            {
                last[1] = max(last[1], (*current)[1]);
            }
            else
            {
                results.push_back(*current);
            }
        }

        return results;
    }
};

int main()
{
    Solution s;
    auto test1 = s.insert({{1,3}, {6,9}}, {2, 5});    
    auto test2 = s.insert({{1,2}, {3,5}, {6,7}, {8,10}, {12,16}}, {4, 8});
    auto test3 = s.insert({{4,5}, {6,9}}, {2, 3});
}