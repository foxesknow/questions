#include <string>
#include <unordered_map>

using namespace std;

class Solution {
public:
    bool isIsomorphic(string s, string t) 
    {
        auto length = s.size();

        unordered_map<char, char> s_to_t;
        unordered_map<char, char> t_to_s;

        for(auto i = 0; i < length; i++)
        {
            auto s_c = s[i];
            auto t_c = t[i];

            if(s_to_t.count(s_c) && s_to_t[s_c] != t_c) return false;
            if(t_to_s.count(t_c) && t_to_s[t_c] != s_c) return false;
            
            s_to_t.insert({s_c, t_c});
            t_to_s.insert({t_c, s_c});
        }

        return true;
    }
};

int main()
{
    Solution s;

    auto test1 = s.isIsomorphic("egg", "add");
    auto test2 = s.isIsomorphic("egg", "adc");
    auto test3 = s.isIsomorphic("foo", "bar");
    auto test4 = s.isIsomorphic("paper", "title");
    auto test5 = s.isIsomorphic("badc", "baba");
}