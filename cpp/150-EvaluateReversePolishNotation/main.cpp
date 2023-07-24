#include <vector>
#include <string>
#include <stack>
#include <cstdlib>
#include <iostream>

using namespace std;

class Solution 
{
    int pop(stack<int> &evaluationStack) const
    {
        const auto value = evaluationStack.top();
        evaluationStack.pop();

        return value;
    }

public:
    int evalRPN(const vector<string>& tokens) 
    {
        stack<int> evaluationStack;

        for(const auto token : tokens)
        {
            if(token == "+")
            {
                const auto rhs = pop(evaluationStack);
                const auto lhs = pop(evaluationStack);
                evaluationStack.push(lhs + rhs);
            }
            else if(token == "-")
            {
                const auto rhs = pop(evaluationStack);
                const auto lhs = pop(evaluationStack);
                evaluationStack.push(lhs - rhs);
            }
            else if(token == "*")
            {
                const auto rhs = pop(evaluationStack);
                const auto lhs = pop(evaluationStack);
                evaluationStack.push(lhs * rhs);
            }
            else if(token == "/")
            {
                const auto rhs = pop(evaluationStack);
                const auto lhs = pop(evaluationStack);
                evaluationStack.push(lhs / rhs);
            }
            else
            {
                const auto value = atoi(token.c_str());
                evaluationStack.push(value);
            }
        }

        return evaluationStack.top();
    }
};

int main()
{
    Solution s;
    std::cout << s.evalRPN({"2", "1", "+", "3", "*"}) << "\n";
    std::cout << s.evalRPN({"4", "13", "5", "/", "+"}) << "\n";
}