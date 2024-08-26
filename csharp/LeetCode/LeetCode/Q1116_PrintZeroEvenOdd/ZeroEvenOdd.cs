using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q1116_PrintZeroEvenOdd
{
    public class ZeroEvenOdd
    {
        private int n;

        private readonly object m_SyncRoot = new();
        private bool m_DoZero = true;
        private int m_Next = 1;
    
        public ZeroEvenOdd(int n) 
        {
            this.n = n;
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber) 
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while(!m_DoZero && m_Next <= n)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(m_Next > n) return;

                    printNumber(0);
                    m_DoZero = false;

                    System.Threading.Monitor.PulseAll(m_SyncRoot);
                }
            }
        }

        public void Even(Action<int> printNumber) 
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while((m_DoZero || (m_Next & 1) != 0) && m_Next <= n)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(m_Next > n) return;

                    printNumber(m_Next);
                    m_Next++;

                    m_DoZero = true;

                    System.Threading.Monitor.PulseAll(m_SyncRoot);
                }
            }
        }

        public void Odd(Action<int> printNumber) 
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while((m_DoZero || (m_Next & 1) != 1) && m_Next <= n)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(m_Next > n) return;

                    printNumber(m_Next);
                    m_Next++;

                    m_DoZero = true;

                    System.Threading.Monitor.PulseAll(m_SyncRoot);
                }
            }
        }
    }
}
