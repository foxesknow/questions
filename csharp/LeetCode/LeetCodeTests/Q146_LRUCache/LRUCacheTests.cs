using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q146_LRUCache;
using NUnit.Framework;

namespace LeetCodeTests.Q146_LRUCache
{
    [TestFixture]
    public class LRUCacheTests
    {
        [Test]
        public void Example1()
        {
            var lru = new LRUCache(2);
            lru.Put(1, 1);
            lru.Put(2, 2);
            Assert.That(lru.Get(1), Is.EqualTo(1));

            lru.Put(3, 3);
            Assert.That(lru.Get(2), Is.EqualTo(-1));

            lru.Put(4, 4);
            Assert.That(lru.Get(1), Is.EqualTo(-1));
            Assert.That(lru.Get(3), Is.EqualTo(3));
            Assert.That(lru.Get(4), Is.EqualTo(4));
        }

        [Test]
        public void Example2()
        {
            var lru = new LRUCache(1);
            lru.Put(2, 1);
            Assert.That(lru.Get(2), Is.EqualTo(1));
        }
    }
}
