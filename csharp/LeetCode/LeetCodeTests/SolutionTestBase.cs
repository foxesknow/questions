using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace LeetCodeTests
{
    public abstract class SolutionTestBase
    {
        protected void EnsureListEquals(ListNode head, params int[] values)
        {
            foreach(var value in values)
            {
                Assert.That(head, Is.Not.Null);
                Assert.That(head.val, Is.EqualTo(value));

                head = head.next;
            }

            Assert.That(head, Is.Null);
        }
    }
}
