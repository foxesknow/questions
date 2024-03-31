#include <iostream>
#include <stack>


using namespace std;

class Solution 
{
public:
    bool isValid(string s) 
    {
        stack<char> tokens;

        for(char c : s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                tokens.push(c);
            }
            else
            {
                // It's a close token
                if(tokens.size() == 0) return false;

                auto top = tokens.top();
                tokens.pop();

                if(top == '(' && c != ')') return false;
                if(top == '{' && c != '}') return false;
                if(top == '[' && c != ']') return false;
            }
        }

        return tokens.size() == 0;
    }
};

int main()
{
    Solution solution;

    cout << solution.isValid("()") << endl;
    cout << solution.isValid("()[]{}") << endl;
    cout << solution.isValid("(]") << endl;

    return 0;
}