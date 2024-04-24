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
    public class RevenueMilestonesTests
    {
        [Test]
        public void Example1()
        {
            var s = new RevenueMilestones();
            var revenues = new[]{10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            var milestones = new[]{100, 200, 500};
            var days = s.GetMilestoneDays(revenues, milestones);
            Assert.That(days[0], Is.EqualTo(4));
            Assert.That(days[1], Is.EqualTo(6));
            Assert.That(days[2], Is.EqualTo(10));
        }

        [Test]
        public void Example2()
        {
            var s = new RevenueMilestones();
            var revenues = new[]{10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            var milestones = new[]{100, 200, 500};
            var days = s.GetMilestoneDays2(revenues, milestones);
            Assert.That(days[0], Is.EqualTo(4));
            Assert.That(days[1], Is.EqualTo(6));
            Assert.That(days[2], Is.EqualTo(10));
        }
    }
}
