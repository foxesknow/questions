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
    public class AccountsMergeTests
    {
        [Test]
        public void Example1()
        {
            Dictionary<string, List<string>> contacts = new()
            {
                {"C1", new(){"bob@yahoo.com", "bob@gmail.com"}},
                {"C2", new(){"mary@facebook.com"}},
                {"C3", new(){"bob@gmail.com", "bob_1@hotmail.com"}},
                {"C4", new(){"bob_1@hotmail.com"}},
                {"C5", new(){"mary@facebook.com"}},
                {"C6", new(){"mark@gmail.com"}},
            };

            var merge = new AccountsMerge();
            var groups = merge.Merge(contacts);
            Assert.That(groups, Has.Count.EqualTo(3));

            Assert.That(groups[0], Contains.Item("C1") & Contains.Item("C3") & Contains.Item("C4"));
            Assert.That(groups[1], Contains.Item("C2") & Contains.Item("C5"));
            Assert.That(groups[2], Contains.Item("C6"));
        }
    }
}
