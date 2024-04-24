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
    public class ContigiousArraysTests
    {
        [Test]
        public void Example1()
        {
            var s = new ContigiousArrays();
            var answer = s.Count(new[]{3,4,1,6,2});
        }
    }
}
