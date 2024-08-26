using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q1115_PrintFooBarAlternately
{
    internal class FooBar
    {
        private int n;

        private bool m_DoFoo = true;
        private bool m_DoBar = true;
        private readonly object m_SyncRoot = new();

        public FooBar(int n) 
        {
            this.n = n;
        }

        public void Foo(Action printFoo) 
        {        
            for (int i = 0; i < n; i++) 
            {
                lock(m_SyncRoot)
                {
                    while(!m_DoFoo)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }
            
        	        // printFoo() outputs "foo". Do not change or remove this line.
        	        printFoo();
                    
                    m_DoFoo = false;
                    m_DoBar = true;
                    System.Threading.Monitor.Pulse(m_SyncRoot);
                }
            }
        }

        public void Bar(Action printBar) {
        
            for (int i = 0; i < n; i++) 
            {            
                lock(m_SyncRoot)
                {
                    while(!m_DoBar)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    // printBar() outputs "bar". Do not change or remove this line.
        	        printBar();

                    m_DoFoo = true;
                    m_DoBar = false;
                    System.Threading.Monitor.Pulse(m_SyncRoot);
                }
            }
        }
    }
}
