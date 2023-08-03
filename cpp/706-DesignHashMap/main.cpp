#include <vector>
#include <algorithm>

using namespace std;

class MyHashMap 
{
private:
    struct Data
    {
        int Key;
        int Value;
    };

    static const int Buckets = 64;
    vector<Data> m_Buckets[Buckets];

    vector<Data> &getBucket(int key)
    {
        const auto index = (key ^ 0x01000193) % Buckets;
        return m_Buckets[index];
    }

public:
    MyHashMap() 
    {
    }
    
    void put(int key, int value) 
    {
        auto &bucket = getBucket(key);
        auto location = lower_bound(bucket.begin(), bucket.end(), key, [](auto it, auto b){return it.Key < b;});

        if(location != bucket.end() && location->Key == key)
        {
            location->Value = value;
            return;
        }

        bucket.insert(location, {key, value});        
    }
    
    int get(int key) 
    {
        auto &bucket = getBucket(key);
        auto location = lower_bound(bucket.begin(), bucket.end(), key, [](auto it, auto b){return it.Key < b;});

        if(location != bucket.end() && location->Key == key)
        {
            return location->Value;
        }

        return -1;
    }
    
    void remove(int key) 
    {
        auto &bucket = getBucket(key);
        auto location = lower_bound(bucket.begin(), bucket.end(), key, [](auto it, auto b){return it.Key < b;});

        if(location != bucket.end() && location->Key == key)
        {
            bucket.erase(location);
        }
    }
};

int main()
{
    MyHashMap s;
    s.put(1, 20);
    s.put(1, 30);
    s.get(1);
}