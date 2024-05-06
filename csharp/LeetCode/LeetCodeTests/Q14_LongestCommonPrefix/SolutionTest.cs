using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q14_LongestCommonPrefix;
using NUnit.Framework;

namespace LeetCodeTests.Q14_LongestCommonPrefix
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var strs = new string[]{"flower","flow","flight"};
            Assert.That(s.LongestCommonPrefix(strs), Is.EqualTo("fl"));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var strs = new string[]{"dog","racecar","car"};
            Assert.That(s.LongestCommonPrefix(strs), Is.EqualTo(""));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var strs = new string[]{"dog","dog","dog"};
            Assert.That(s.LongestCommonPrefix(strs), Is.EqualTo("dog"));
        }
    }
}
