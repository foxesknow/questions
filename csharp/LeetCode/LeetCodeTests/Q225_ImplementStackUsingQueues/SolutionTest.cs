using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q225_ImplementStackUsingQueues;
using NUnit.Framework;

namespace LeetCodeTests.Q225_ImplementStackUsingQueues
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            Assert.That(stack.Top(), Is.EqualTo(2));
            Assert.That(stack.Pop(), Is.EqualTo(2));
            Assert.That(stack.Empty(), Is.False);
        }
    }
}
