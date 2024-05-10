using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q234_PalindromeLinkedList;
using NUnit.Framework;

namespace LeetCodeTests.Q234_PalindromeLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 2, 1);
            Assert.That(s.IsPalindrome(list), Is.True);
        }


        [Test]
        public void Example2()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2);
            Assert.That(s.IsPalindrome(list), Is.False);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 4, 2, 1);
            Assert.That(s.IsPalindrome(list), Is.True);
        }
    }
}
