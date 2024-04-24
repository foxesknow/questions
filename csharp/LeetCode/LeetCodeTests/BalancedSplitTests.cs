using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;

using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class BalancedSplitTests
    {
        [Test]
        public void Example1()
        {
            var s = new BalancedSplit();
            Assert.That(s.Exists(new[]{1,5,7,1}), Is.True);
        }

        [Test]
        public void Example2()
        {
            var s = new BalancedSplit();
            Assert.That(s.Exists(new[]{1,1,4,7,1}), Is.True);
        }

        [Test]
        public void Example3()
        {
            var s = new BalancedSplit();
            Assert.That(s.Exists(new[]{4,4,5,5}), Is.False);
        }

        [Test]
        public void Example4()
        {
            var s = new BalancedSplit();
            Assert.That(s.Exists(new[]{1,1,1,1,2,2,3,5}), Is.True);
        }
    }
}
