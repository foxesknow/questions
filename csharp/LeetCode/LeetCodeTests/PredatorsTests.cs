using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class PredatorsTests
    {
        [Test]
        public void Test1()
        {
            List<int> predators = new(){-1, 8, 6, 0, 7, 3, 8, 9, -1, 6};
            var count = Predators.minimumGroups(predators);
            Assert.That(count, Is.EqualTo(5));
        }
    }
}
