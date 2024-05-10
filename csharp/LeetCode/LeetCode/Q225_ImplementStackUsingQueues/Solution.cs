using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q225_ImplementStackUsingQueues
{
    public class MyStack
    {
        private readonly Queue<int> m_Queue = new();

        public MyStack()
        {

        }

        public void Push(int x)
        {
            var shuffleCount = m_Queue.Count;
            m_Queue.Enqueue(x);

            for(var i = 0; i < shuffleCount; i++)
            {
                var item = m_Queue.Dequeue();
                m_Queue.Enqueue(item);
            }
        }

        public int Pop()
        {
            return m_Queue.Dequeue();
        }

        public int Top()
        {
            return m_Queue.Peek();
        }

        public bool Empty()
        {
            return m_Queue.Count == 0;
        }
    }
}
