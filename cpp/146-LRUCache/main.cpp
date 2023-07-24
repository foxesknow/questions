#include <map>
#include <unordered_map>
#include <iostream>

using namespace std;

class LRUCache 
{
private:
    struct KeyData
    {
        int age;
        int value;
    };

    int m_Age;
    int m_Capacity;

    // Maps an age to a key
    map<int, int> m_Ages;

    // The actual data
    unordered_map<int, KeyData> m_KeyValueMap;

    int makeAge()
    {
        return m_Age++;
    }

    int get(int key, int value) 
    {
        const auto it = m_KeyValueMap.find(key);
        if(it != m_KeyValueMap.end()) 
        {
            // We need to update the age on this item
            const auto keyData = it->second;
            m_Ages.erase(keyData.age);

            // Add the new age...
            const auto newAge = makeAge();
            m_Ages.insert({newAge, key});

            // ...and update the age of the key/value item
            it->second.age = newAge;
            if(value != -1) it->second.value = value;

            return keyData.value;
        }

        return -1;
    }

public:
    LRUCache(int capacity) : m_Age(0), m_Capacity(capacity)
    {
    }
    
    int get(int key) 
    {
        return get(key, -1);
    }
    
    void put(int key, int value) 
    {
        const auto existing = get(key, value);
        if(existing != -1) return;

        // The value isn't there
        const int age = makeAge();
        m_Ages.insert({age, key});
        auto pair = m_KeyValueMap.insert({key, {age, value}});
        
        // If the key is already there then update the age
        if(pair.second == false)
        {
            auto it = pair.first;
            it->second.age = age;
        }

        if(m_Ages.size() > m_Capacity)
        {
            // We need to remove one.
            // As we're using a map the youngest age is at the beginning
            auto youngest = m_Ages.begin();
            m_KeyValueMap.erase(youngest->second);
            m_Ages.erase(youngest);
        }
    }
};

int main()
{
    LRUCache cache(2);
    cache.put(1, 1);
    cache.put(2, 2);
    std::cout << cache.get(1) << "\n";

    cache.put(3, 3);
    std::cout << cache.get(2) << "\n";

    cache.put(4, 4);
    std::cout << cache.get(1) << "\n";
    std::cout << cache.get(3) << "\n";
    std::cout << cache.get(4) << "\n";
}