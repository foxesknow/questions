#include <string>
#include <iostream>

using namespace std;

class Solution 
{
    bool isInterleave(const string &s1, int s1Offset, const string &s2, int s2Offset, const string &s3, int s3Offset) const
    {
        if(s3Offset == s3.size())
        {
            if(s1.size() && s1Offset == 0) return false;
            if(s2.size() && s2Offset == 0) return false;

            //if(abs(s1Offset - s2Offset) > 1) return false;

            return true;
        }

        if(s1[s1Offset] == s3[s3Offset])
        {
            if(isInterleave(s1, s1Offset + 1, s2, s2Offset, s3, s3Offset + 1))
            {
                return true;
            }
        }

        if(s2[s2Offset] == s3[s3Offset])
        {
            if(isInterleave(s1, s1Offset, s2, s2Offset + 1, s3, s3Offset + 1))
            {
                return true;
            }
        }

        return false;
    }

public:
    bool isInterleave(string s1, string s2, string s3) 
    {
        return isInterleave(s1, 0, s2, 0, s3, 0);
    }
};

void test1()
{
    Solution s;
    auto match = s.isInterleave("aabcc", "dbbca", "aadbbcbcac");
    std::cout << match << "\n";
}

void test2()
{
    Solution s;
    auto match = s.isInterleave("aabcc", "dbbca", "aadbbbaccc");
    std::cout << match << "\n";
}

void test3()
{
    Solution s;
    auto match = s.isInterleave("aaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    std::cout << match << "\n";
}

void test4()
{
    Solution s;
    auto match = s.isInterleave("a", "b", "a");
    std::cout << match << "\n";
}

void test5()
{
    Solution s;
    auto match = s.isInterleave("", "", "");
    std::cout << match << "\n";
}

void test6()
{
    Solution s;
    auto match = s.isInterleave("", "abc", "abc");
    std::cout << match << "\n";
}

int main()
{
    test1();
    test2();
    test3();
    test4();
    test5();
    test6();
}