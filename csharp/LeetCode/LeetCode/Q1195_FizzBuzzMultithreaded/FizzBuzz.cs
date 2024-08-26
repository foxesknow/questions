using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q1195_FizzBuzzMultithreaded
{
    internal class FizzBuzz
    {
        private int n;

        private readonly object m_SyncRoot = new();
        private int m_NextNumber = 1;
        private State m_State = State.Number;
        private bool m_KeepRunning = true;

        public FizzBuzz(int n)
        {
            this.n = n;
        }

        // printFizz() outputs "fizz".
        public void Fizz(Action printFizz)
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while(m_State != State.Fizz && m_KeepRunning)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(!m_KeepRunning) break;
                    printFizz();
                    NextState();
                }
            }
        }

        // printBuzzz() outputs "buzz".
        public void Buzz(Action printBuzz)
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while(m_State != State.Buzz && m_KeepRunning)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(!m_KeepRunning) break;
                    printBuzz();
                    NextState();
                }
            }
        }

        // printFizzBuzz() outputs "fizzbuzz".
        public void Fizzbuzz(Action printFizzBuzz)
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while(m_State != State.FizzBuzz && m_KeepRunning)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(!m_KeepRunning) break;
                    printFizzBuzz();
                    NextState();
                }
            }
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Number(Action<int> printNumber)
        {
            while(true)
            {
                lock(m_SyncRoot)
                {
                    while(m_State != State.Number && m_KeepRunning)
                    {
                        System.Threading.Monitor.Wait(m_SyncRoot);
                    }

                    if(!m_KeepRunning) break;
                    printNumber(m_NextNumber);
                    NextState();
                }
            }
        }

        private void NextState()
        {
            m_NextNumber++;

            if(m_NextNumber > n)
            {
                m_KeepRunning = false;
            }

            if((m_NextNumber % 15) == 0)
            {
                m_State = State.FizzBuzz;
            }
            else if((m_NextNumber % 5) == 0)
            {
                m_State = State.Buzz;
            }
            else if((m_NextNumber % 3) == 0)
            {
                m_State = State.Fizz;
            }
            else
            {
                m_State = State.Number;
            }

            System.Threading.Monitor.PulseAll(m_SyncRoot);
        }

        enum State
        {
            Number,
            Fizz,
            Buzz,
            FizzBuzz
        }
    }
}
