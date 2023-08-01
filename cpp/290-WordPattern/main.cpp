#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

class Solution 
{
private:
    vector<string> extractWords(string s) const
    {
        vector<string> words;

        size_t start = 0;

        auto keepProcessing = true;
        while(keepProcessing)
        {
            string part;
            auto index = s.find(' ', start);

            if(index == string::npos)
            {
                if(start < s.size())
                {
                    part = s.substr(start, s.size() - start);
                }

                keepProcessing = false;
            }
            else
            {
                part = s.substr(start, index - start);
            }

            start = index + 1;

            if(part.size() == 0) continue;
            words.push_back(part);
        }

        return words;
    }

public:
    bool wordPattern(string pattern, string s) 
    {
        auto words = extractWords(s);
        if(words.size() != pattern.size()) return false;

        unordered_map<char, string> charToWord;
        unordered_map<string, char> wordToChar;

        int wordIndex = 0;
        for(auto c : pattern)
        {
            if(charToWord.count(c) && charToWord[c] != words[wordIndex]) return false;
            if(wordToChar.count(words[wordIndex]) && wordToChar[words[wordIndex]] != c) return false;

            charToWord.insert({c, words[wordIndex]});
            wordToChar.insert({words[wordIndex], c});
            wordIndex++;
        }

        return true;
    }
};

int main()
{
    Solution s;
    auto test1 = s.wordPattern("abba", "dog cat cat dog");
    auto test2 = s.wordPattern("abba", "dog cat cat fish");
    auto test3 = s.wordPattern("aaaa", "dog cat cat dog");
    auto test4 = s.wordPattern("abba", "dog dog dog dog");
}