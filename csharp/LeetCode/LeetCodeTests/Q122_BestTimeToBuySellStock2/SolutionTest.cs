using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q122_BestTimeToBuySellStock2;
using NUnit.Framework;

namespace LeetCodeTests.Q122_BestTimeToBuySellStock2
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            Assert.That(s.MaxProfit(new int[]{7,1,5,3,6,4}), Is.EqualTo(7));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            Assert.That(s.MaxProfit(new int[]{7,6,4,3,1}), Is.EqualTo(0));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            Assert.That(s.MaxProfit(new int[]{1,2,3,4,5,6}), Is.EqualTo(5));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            Assert.That(s.MaxProfit(new int[]{7}), Is.EqualTo(0));
        }
    }
}
