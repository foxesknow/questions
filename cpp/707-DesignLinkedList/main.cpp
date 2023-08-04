class MyLinkedList 
{
private:
    struct Node
    {
        int val;
        Node *next;
    };

    int m_Count;
    Node *m_Head;

public:
    MyLinkedList() : m_Count(0), m_Head(nullptr)
    {
        
    }
    
    int get(int index) 
    {
        if(index >= m_Count) return -1;

        auto node = m_Head;
        while(node && index--)
        {
            node = node->next;
        }

        return node == nullptr ? -1 : node->val;
    }
    
    void addAtHead(int val) 
    {
        auto node = new Node{val, m_Head};
        m_Head = node;
        m_Count++;
    }
    
    void addAtTail(int val) 
    {
        if(m_Head == nullptr)
        {
            addAtHead(val);
            return;
        }

        auto node = m_Head;
        while(node->next != nullptr)
        {
            node = node->next;
        }

        node->next = new Node{val, nullptr};
        m_Count++;
    }
    
    void addAtIndex(int index, int val) 
    {
        if(index == 0)
        {
            addAtHead(val);
            return;
        }

        if(index == m_Count)
        {
            addAtTail(val);
            return;
        }

        if(index > m_Count) return;

        auto node = m_Head;
        while(node && --index)
        {
            node = node->next;
        }

        if(node)
        {
            auto newNode = new Node{val, node->next};
            node->next = newNode;
            m_Count++;
        }
    }
    
    void deleteAtIndex(int index) 
    {
        if(index >= m_Count) return;

        if(index == 0)
        {
            if(m_Head)
            {
                auto newHead = m_Head->next;
                delete m_Head;
                m_Head = newHead;
                m_Count--;
            }

            return;
        }

        auto node = m_Head;
        while(node && --index)
        {
            node = node->next;
        }

        if(node && node->next)
        {
            auto toDelete = node->next;
            node->next = node->next->next;
            delete toDelete;
            m_Count--;
        }
    }
};

int main()
{
    MyLinkedList s;
    s.addAtHead(10);
    s.addAtHead(20);
    s.addAtHead(30);
    s.addAtHead(40);
    s.addAtIndex(4, 99);
    s.deleteAtIndex(4);
}