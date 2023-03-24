using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddNumber
{
    internal class Xor
    {
        public static bool Find(int[] numbers, out int result)
        {
            var latch = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                latch ^= numbers[i];
            }

            result = latch;
            return latch != 0;
        }
    }
}
