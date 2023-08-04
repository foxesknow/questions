#include <stack>

using namespace std;

class MyQueue 
{
private:
    stack<int> m_Active;
    stack<int> m_Passive;

    void merge()
    {
        if(m_Active.empty())
        {
            while(!m_Passive.empty())
            {
                auto value = m_Passive.top();
                m_Passive.pop();

                m_Active.push(value);
            }
        }
    }

public:
    MyQueue() 
    {
        
    }
    
    void push(int x) 
    {
        m_Passive.push(x);
    }
    
    int pop() 
    {
        merge();
        auto front = m_Active.top();
        m_Active.pop();

        return front;
    }
    
    int peek() 
    {
        merge();
        return m_Active.top();
    }
    
    bool empty() 
    {
        return m_Active.empty() && m_Passive.empty();
    }
};

int main()
{
    MyQueue s;
    s.push(1);
    s.push(2);
    s.peek();
    s.pop();
}