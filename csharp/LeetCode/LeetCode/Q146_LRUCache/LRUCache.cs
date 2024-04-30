using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q146_LRUCache
{
    public class LRUCache
    {
        private readonly LinkedList<(int Key, int Value)> m_Lru = new();
        private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> m_Cache= new();
        private readonly int m_Capacity;

        public LRUCache(int capacity) 
        {
            m_Capacity = capacity;
        }
    
        public int Get(int key) 
        {
            if(m_Cache.TryGetValue(key, out var node))
            {
                // It's now our most recently used item!
                if(node != m_Lru.First)
                {
                    m_Lru.Remove(node);
                    m_Lru.AddFirst(node);
                }

                return node.Value.Value;
            }
            
            return -1;
        }
    
        public void Put(int key, int value) 
        {
            if(m_Cache.TryGetValue(key, out var node))
            {
                // It's now our most recently used item!
                if(node != m_Lru.First)
                {
                    m_Lru.Remove(node);
                    m_Lru.AddFirst(node);
                }  
                
                node.Value = (key, value);
            }
            else
            {
                node = m_Lru.AddFirst((key, value));
                m_Cache.Add(key, node);

                if(m_Cache.Count > m_Capacity)
                {
                    var last = m_Lru.Last;
                    m_Lru.RemoveLast();
                    m_Cache.Remove(last.Value.Key);
                }
            }
        }
    }
}
