using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _460_LFUCache
{
public class LFUCache
{
    private readonly int m_Capacity;

    private long m_LastUsed;

    private readonly Dictionary<int, KeyValueData> m_DataByKey = new();
    private readonly SortedSet<FrequencyData> m_FrequencyData = new();

    public LFUCache(int capacity) 
    {
        m_Capacity = capacity;
    }
    
    public int Get(int key) 
    {
        if(m_DataByKey.TryGetValue(key, out var data))
        {
            Touch(key, ref data);
            return data.Value;
        }
            
        return -1;
    }
    
    public void Put(int key, int value) 
    {
        MakeSpaceFor(key);

        if(m_DataByKey.TryGetValue(key, out var data))
        {
            Touch(key, ref data, value);
            return;
        }

        // It's a new value
        var lastUsed = MakeLastUsed();
        m_DataByKey.Add(key, new(value, lastUsed, 1));
        m_FrequencyData.Add(new(1, lastUsed, key));
    }

    private void Touch(int key, ref KeyValueData data, int newValue = -1)
    {
        m_FrequencyData.Remove(new(data.Frequency, data.LastUsed, key));

        var value = (newValue == -1 ? data.Value : newValue);

        var newData = new KeyValueData(value, MakeLastUsed(), data.Frequency + 1);
        m_DataByKey[key] = newData;
        m_FrequencyData.Add(new(data.Frequency + 1, newData.LastUsed, key));
    }

    private void MakeSpaceFor(int key)
    {
        if(m_DataByKey.Count < m_Capacity)
        {
            return;
        }

        if(m_DataByKey.ContainsKey(key))
        {
            return;
        }

        // So it's a new key and we don't have room
        FrequencyData toRemove = m_FrequencyData.First();
        m_DataByKey.Remove(toRemove.Key);
        m_FrequencyData.Remove(toRemove);
    }

    private long MakeLastUsed()
    {
        return m_LastUsed++;
    }

    readonly struct KeyValueData
    {
        public KeyValueData(int value, long lastUsed, int frequency)
        {
            this.Value = value;
            this.LastUsed = lastUsed;
            this.Frequency = frequency;
        }

        public int Value{get;}
        public long LastUsed{get;}
        public int Frequency{get;}
    }

    readonly struct FrequencyData : IComparable<FrequencyData>
    {
        public FrequencyData(int frequency, long lastUsed, int key)
        {
            this.Frequency = frequency;
            this.LastUsed = lastUsed;
            this.Key = key;
        }

        public int Frequency{get;}
        public long LastUsed{get;}
        public int Key{get;}

        public int CompareTo(FrequencyData other)
        {
            return (this.Frequency, this.LastUsed).CompareTo((other.Frequency, other.LastUsed));
        }
    }
}
}
