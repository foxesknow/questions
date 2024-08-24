using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q451_SortCharactersByFrequency;

using NUnit.Framework;

namespace LeetCodeTests.Q451_SortCharactersByFrequency
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        [TestCase("tree", "eert")]
        public void FrequencySort(string value, string expected)
        {
            var s = new Solution();
            Assert.That(s.FrequencySort(value), Is.EqualTo(expected));
        }
    }
}
