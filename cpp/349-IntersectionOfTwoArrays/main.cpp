#include <vector>
#include <algorithm>
#include <unordered_set>
#include <iterator>

using namespace std;

class Solution 
{
public:
    vector<int> intersection(vector<int>& nums1, vector<int>& nums2) 
    {
        sort(nums1.begin(), nums1.end());
        sort(nums2.begin(), nums2.end());

        unordered_set<int> intersection;
        auto insert = inserter(intersection, intersection.begin());
        set_intersection(nums1.begin(), nums1.end(), nums2.begin(), nums2.end(), insert);

        return vector<int>(intersection.begin(), intersection.end());
    }
};

int main()
{
    vector<int> nums1 = {1,2,2,1};
    vector<int> nums2 = {2,2};

    Solution s;
    s.intersection(nums1, nums2);
}