using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q1114_PrintInOrder
{
    internal class Foo
    {
        private readonly object m_SyncRoot = new();
        private int m_NextState = 1;

        public Foo() 
        {
        
        }

        public void First(Action printFirst) 
        {
            lock(m_SyncRoot)
            {
                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();

                m_NextState = 2;
                System.Threading.Monitor.PulseAll(m_SyncRoot);
            }
        }

        public void Second(Action printSecond) 
        {
            lock(m_SyncRoot)
            {
                while(m_NextState != 2)
                {
                    System.Threading.Monitor.Wait(m_SyncRoot);
                }

                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                m_NextState = 3;

                System.Threading.Monitor.PulseAll(m_SyncRoot);
            }
        }

        public void Third(Action printThird) 
        {
            lock(m_SyncRoot)
            {
                while(m_NextState != 3)
                {
                    System.Threading.Monitor.Wait(m_SyncRoot);
                }

                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }
    }
}
