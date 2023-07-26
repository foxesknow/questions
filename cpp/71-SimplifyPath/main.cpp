#include <string>
#include <iostream>
#include <deque>

using namespace std;

class Solution 
{
    deque<string> splitPath(const string &path) const
    {
        deque<string> parts;

        size_t start = 1;

        auto keepProcessing = true;
        while(keepProcessing)
        {
            string part;
            auto index = path.find('/', start);

            if(index == string::npos)
            {
                if(start < path.size())
                {
                    part = path.substr(start, path.size() - start);
                }

                keepProcessing = false;
            }
            else
            {
                part = path.substr(start, index - start);
            }

            start = index + 1;

            if(part.size() == 0 || part == ".") continue;
            
            if(part == "..") 
            {
                if(parts.size()) parts.pop_back();
            }
            else
            {
                parts.push_back(part);
            }
        }

        return parts;
    }

public:
    string simplifyPath(string path) 
    {
        auto parts = splitPath(path);
        if(parts.size() == 0) return "/";

        string normalizedPath;

        for(const auto &part : parts)
        {
            normalizedPath += '/';
            normalizedPath += part;
        }

        return normalizedPath;
    }
};

int main()
{
    Solution s;
    std::cout << s.simplifyPath("/home/") << "\n";
    std::cout << s.simplifyPath("/../") << "\n";
    std::cout << s.simplifyPath("/home//foo/") << "\n";
}