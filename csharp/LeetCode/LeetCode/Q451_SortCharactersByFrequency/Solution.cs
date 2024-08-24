using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q451_SortCharactersByFrequency
{
    public class Solution
    {
        public string FrequencySort(string s) 
        {
            var frequencies = new Dictionary<char, int>();

            foreach(var c in s)
            {
                if(frequencies.TryGetValue(c, out var count))
                {
                    frequencies[c] = count + 1;
                }
                else
                {
                    frequencies.Add(c, 1);
                }
            }

            var counts = frequencies.ToList();
            counts.Sort((left, right) => right.Value.CompareTo(left.Value));

            var sum = counts.Sum(pair => pair.Value);
            var characters = new char[sum];
            var index = 0;

            foreach(var pair in counts)
            {
                char c = pair.Key;

                for(int i = 0; i < pair.Value; i++)
                {
                    characters[index++] = c;
                }
            }
            
            return new string(characters);
        }
    }
}
