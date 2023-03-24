#include <iostream>
#include <vector>

using namespace std;

int solution(vector<int> &A)
{
    int oddOneOut = 0;

    for(auto number : A)
    {
        oddOneOut ^= number;
    }

    return oddOneOut;
}

int main()
{
    std::cout << "hello" << std::endl;
    return 0;
}