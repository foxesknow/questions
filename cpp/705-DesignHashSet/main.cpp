#include <vector>
#include <algorithm>

using namespace std;

class MyHashSet 
{
private:
    static const int Buckets = 64;
    vector<int> m_Buckets[Buckets];

    vector<int> &getBucket(int key)
    {
        const auto index = (key ^ 0x01000193) % Buckets;
        return m_Buckets[index];
    }

public:
    MyHashSet() 
    {
    }
    
    void add(int key) 
    {
        auto &bucket = getBucket(key);
        auto location = lower_bound(bucket.begin(), bucket.end(), key);

        if(location != bucket.end() && *location == key)
        {
            return;
        }

        bucket.insert(location, key);
    }
    
    void remove(int key) 
    {
        auto &bucket = getBucket(key);
        auto location = lower_bound(bucket.begin(), bucket.end(), key);

        if(location != bucket.end() && *location == key)
        {
            bucket.erase(location);
        }
    }
    
    bool contains(int key) 
    {
        auto &bucket = getBucket(key);
        return binary_search(bucket.begin(), bucket.end(), key);
    }
};

int main()
{
    MyHashSet s;
    s.add(1);
    s.add(3);
    s.add(2);
    s.add(3);
    s.add(0);
    s.remove(7);
}