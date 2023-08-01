class Solution 
{
public:
    int findComplement(int num) 
    {
        int complement = 0;
        int setter = 1;

        while(num)
        {
            if((num & 1) == 0)
            {
                complement |= setter;
            }

            num >>= 1;
            setter <<= 1;
        }

        return complement;
    }
};

int main()
{
    Solution s;

    auto test1 = s.findComplement(5);
    auto test2 = s.findComplement(1);
}