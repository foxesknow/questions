using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class EncryptedWords
    {
        public string Encrypt(string value)
        {
            var buffer = new StringBuilder(value.Length);
            Encrypt(value, 0, value.Length - 1, buffer);

            return buffer.ToString();
        }

        private void Encrypt(string value, int left, int right, StringBuilder acc)
        {            
            var distance = right - left;

            if(distance == 0)
            {
                acc.Append(value[left]);
                return;
            }

            if(distance == 1)
            {
                acc.Append(value[left]);
                acc.Append(value[left + 1]);
                return;
            }

            var mid = (left + right) / 2;
            acc.Append(value[mid]);
            Encrypt(value, left, mid - 1, acc);
            Encrypt(value, mid + 1, right, acc);
        }
    }
}
