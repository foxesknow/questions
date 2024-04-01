#include <vector>
#include <iostream>

using namespace std;

class Iterator 
{
    struct Data;
    Data* data;
public:
    Iterator(const vector<int>& nums);
    Iterator(const Iterator& iter);
 
    // Returns the next element in the iteration.
    int next();

    // Returns true if the iteration has more elements.
    bool hasNext() const;
};

class PeekingIterator //: public Iterator 
{
    vector<int>::const_iterator m_Next;
    vector<int>::const_iterator m_End;
public:
	PeekingIterator(const vector<int>& nums) //: Iterator(nums) 
    {
	    m_Next = nums.cbegin();
        m_End = nums.cend();
	}
	
    // Returns the next element in the iteration without advancing the iterator.
	int peek() 
    {
        return *m_Next;
	}
	
	// hasNext() and next() should behave the same as in the Iterator interface.
	// Override them if needed.
	int next() 
    {
	    return *m_Next++;
	}
	
	bool hasNext() const 
    {
	    return m_Next != m_End;
	}
};

int main()
{
    vector<int> data = {1, 2, 3};
    
    PeekingIterator it(data);
    cout << it.next() << endl;
    cout << it.peek() << endl;
    cout << it.next() << endl;
    cout << it.next() << endl;
    cout << it.hasNext() << endl;


    return 0;
}