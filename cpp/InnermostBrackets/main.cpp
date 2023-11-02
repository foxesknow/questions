#include <iostream>
#include <utility>
#include <string>
#include <vector>
#include <algorithm>

/*

Innermost brackets

Given a string that may contain brackets, and no unbalanced brackets, find the substring(s) within the most deeply nested balanced bracket(s).
The following sets of characters should be considered as open/close brackets respectively: ( ), [ ], { }
If there are multiple sets of brackets with the same highest depth, your function should return all substrings. If there are no brackets in the string, then your function should return the entire input string.

"ab(c(d)e)"      ->  "d"
"[a{{b}c}d(e)]"  ->  "b"
"((a)b(cd)ef)"    ->  "a", "cd"
"(ab[]c){d{e}}"  ->  "", "e"
"Hello, World!"  ->  "Hello, World!"

*/

using namespace std;

using Details = pair<string, int>;

bool isOpen(char c)
{
    return c == '(' || c == '[' || c == '{';
}

bool isClose(char c)
{
    return c == ')' || c == ']' || c == '}';
}

int process(vector<Details> &details, string::const_iterator &it, string::const_iterator end, int count)
{
    int maxDepth = count;

    string current;

    while(it != end)
    {
        auto c = *it;

        if(isOpen(c))
        {
            details.emplace_back(current, count);
            ++it;
            current.clear();

            auto subDepth = process(details, it, end, count + 1);
            maxDepth = max(maxDepth, subDepth);
        }
        else if(isClose(c))
        {
            details.emplace_back(current, count);
            ++it;
            break;
        }
        else
        {
            current += c;
            ++it;
        }
    }

    return maxDepth;
}

vector<string> getMostDeeply(string expression)
{
    vector<Details> details;
    auto it = cbegin(expression);
    auto maxDepth = process(details, it, cend(expression), 0);

    vector<string> results;

    if(details.size() == 0)
    {
        results.push_back(expression);
        return results;
    }
    
    for(const auto &item : details)
    {
        if(item.second == maxDepth)
        {
            results.push_back(item.first);
        }
    }

    return results;
}

void print(const vector<string> &results)
{
    for(const auto &item : results)
    {
        cout << '\"' << item << '\"' << " ";
    }

    cout << endl;
}

void test1()
{
    auto mostDeeply = getMostDeeply("ab(c(d)e)");
    print(mostDeeply);
}

void test2()
{
    auto mostDeeply = getMostDeeply("[a{{b}c}d(e)]");
    print(mostDeeply);
}

void test3()
{
    auto mostDeeply = getMostDeeply("((a)b(cd)ef)");
    print(mostDeeply);
}

void test4()
{
    auto mostDeeply = getMostDeeply("(ab[]c){d{e}}");
    print(mostDeeply);
}

void test5()
{
    auto mostDeeply = getMostDeeply("Hello, World!");
    print(mostDeeply);
}

int main()
{
    test1();
    test2();
    test3();
    test4();
    test5();

    return 0;
}