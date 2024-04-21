using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q11_ContainerWithMostWater;

using NUnit.Framework;

namespace LeetCodeTests.Q11_ContainerWithMostWater
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var most = s.MaxArea(new[]{1,8,6,2,5,4,8,3,7});
            Assert.That(most, Is.EqualTo(49));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var most = s.MaxArea(new[]{1,1});
            Assert.That(most, Is.EqualTo(1));
        }
    }
}
