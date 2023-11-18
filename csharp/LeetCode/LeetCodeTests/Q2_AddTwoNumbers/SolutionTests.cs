using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;
using LeetCode.Q2_AddTwoNumbers;

using NUnit.Framework;


namespace LeetCodeTests.Q2_AddTwoNumbers
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var l1 = ListNode.Make(2, 4, 3);
            var l2 = ListNode.Make(5, 6, 4);

            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);

            Assert.That(result.Skip(0).val, Is.EqualTo(7));
            Assert.That(result.Skip(1).val, Is.EqualTo(0));
            Assert.That(result.Skip(2).val, Is.EqualTo(8));
            Assert.That(result.Skip(2).next, Is.Null);
        }

        [Test]
        public void Example2()
        {
            var l1 = ListNode.Make(0);
            var l2 = ListNode.Make(0);

            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);

            Assert.That(result.Skip(0).val, Is.EqualTo(0));
            Assert.That(result.Skip(0).next, Is.Null);
        }

        [Test]
        public void Example3()
        {
            var l1 = ListNode.Make(9,9,9,9,9,9,9);
            var l2 = ListNode.Make(9,9,9,9);

            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);

            Assert.That(result.Skip(0).val, Is.EqualTo(8));
            Assert.That(result.Skip(1).val, Is.EqualTo(9));
            Assert.That(result.Skip(2).val, Is.EqualTo(9));
            Assert.That(result.Skip(3).val, Is.EqualTo(9));
            Assert.That(result.Skip(4).val, Is.EqualTo(0));
            Assert.That(result.Skip(5).val, Is.EqualTo(0));
            Assert.That(result.Skip(6).val, Is.EqualTo(0));
            Assert.That(result.Skip(7).val, Is.EqualTo(1));
            Assert.That(result.Skip(7).next, Is.Null);
        }
    }
}
