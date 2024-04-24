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
    public class OneBillionUsersTests
    {
        [Test]
        public void Example1()
        {
            var s = new OneBillionUsers();
            var days = s.GetBillionUsersDay(new float[]{1.5f});
            Assert.That(days, Is.EqualTo(52));
        }

        [Test]
        public void Example2()
        {
            var s = new OneBillionUsers();
            var days = s.GetBillionUsersDay(new float[]{1.1f, 1.2f, 1.3f});
            Assert.That(days, Is.EqualTo(79));
        }

        [Test]
        public void Example3()
        {
            var s = new OneBillionUsers();
            var days = s.GetBillionUsersDay(new float[]{1.01f, 1.02f});
            Assert.That(days, Is.EqualTo(1047));
        }
    }
}
