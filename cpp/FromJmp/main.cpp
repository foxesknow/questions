#include <iostream>
#include <vector>

using namespace std;

int solution(int X, int Y, int D)
{
    auto distanceToTravel = Y - X;

    auto steps = distanceToTravel / D;
    if((distanceToTravel % D) != 0)
    {
        steps++;
    }

    return steps;
}

int main()
{
    std::cout << solution(10, 85, 30) << std::endl;
    return 0;
}