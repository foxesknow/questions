#include <string>
#include <vector>
#include <algorithm>
#include <unordered_map>


using namespace std;

class Solution 
{
public:
    vector<vector<string>> groupAnagrams(const vector<string>& strs) 
    {
        unordered_map<string, vector<string>> mappings;

        for(auto key : strs)
        {
            auto original = key;
            sort(key.begin(), key.end());

            mappings[key].push_back(original);
        }

        vector<vector<string>> groups;

        for(auto &pair : mappings)
        {
            groups.push_back(pair.second);
        }

        return groups;
    }
};

int main()
{
    Solution s;
    auto test1 = s.groupAnagrams({"eat","tea","tan","ate","nat","bat"});
}