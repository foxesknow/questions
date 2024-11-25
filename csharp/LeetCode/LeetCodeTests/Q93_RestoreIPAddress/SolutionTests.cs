using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;
using LeetCode.Q93_RestoreIPAddress;

using NUnit.Framework;

namespace LeetCodeTests.Q93_RestoreIPAddress
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var results = s.RestoreIpAddresses("25525511135");
            Assert.That(results, Has.Count.EqualTo(2));
            Assert.That(results, Contains.Item("255.255.11.135"));
            Assert.That(results, Contains.Item("255.255.111.35"));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var results = s.RestoreIpAddresses("0000");
            Assert.That(results, Has.Count.EqualTo(1));
            Assert.That(results, Contains.Item("0.0.0.0"));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var results = s.RestoreIpAddresses("101023");
            Assert.That(results, Has.Count.EqualTo(5));
            Assert.That(results, Contains.Item("1.0.10.23"));
            Assert.That(results, Contains.Item("1.0.102.3"));
            Assert.That(results, Contains.Item("10.1.0.23"));
            Assert.That(results, Contains.Item("10.10.2.3"));
            Assert.That(results, Contains.Item("101.0.2.3"));
        }
    }
}
