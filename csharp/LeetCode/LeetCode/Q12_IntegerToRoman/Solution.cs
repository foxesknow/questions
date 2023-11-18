using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q12_IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num) 
        {
            var roman = new StringBuilder(10);

            while(num >= 1000)
            {
                roman.Append('M');
                num -= 1000;
            }

            if(num >= 900)
            {
                roman.Append("CM");
                num -= 900;
            }

            if(num >= 500)
            {
                roman.Append('D');
                num -= 500;
            }

            if(num >= 400)
            {
                roman.Append("CD");
                num -= 400;
            }

            while(num >= 100)
            {
                roman.Append('C');
                num -= 100;
            }

            if(num >= 90)
            {
                roman.Append("XC");
                num -= 90;
            }

            while(num >= 50)
            {
                roman.Append('L');
                num -= 50;
            }

            if(num >= 40)
            {
                roman.Append("XL");
                num -= 40;
            }

            while(num >= 10)
            {
                roman.Append('X');
                num -= 10;
            }

            if(num >= 9)
            {
                roman.Append("IX");
                num  -= 9;
            }

            if(num >= 5)
            {
                roman.Append('V');
                num -= 5;
            }

            if(num >= 4)
            {
                roman.Append("IV");
                num -= 4;
            }

            for(var i = 0; i < num; i++)
            {
                roman.Append('I');
            }

            return roman.ToString();
        }
    }
}
