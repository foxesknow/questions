using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using LeetCode.Q1116_PrintZeroEvenOdd;

using NUnit.Framework;

namespace LeetCodeTests.Q1116_PrintZeroEvenOdd
{
    [TestFixture]
    public class ZeroEvenOddTests
    {
        [Test]
        public void Execute()
        {
            var s = new ZeroEvenOdd(2);

            var b = new StringBuilder();
            Action<int> printNumber = n =>
            {
                lock(b)
                {
                    b.Append(n);
                }
            };

            var oddThread = new Thread(() => s.Odd(printNumber));
            oddThread.Start();

            var evenThread = new Thread(() => s.Even(printNumber));
            evenThread.Start();

            var zeroThread = new Thread(() => s.Zero(printNumber));
            zeroThread.Start();

            oddThread.Join();
            evenThread.Join();
            zeroThread.Join();

            Assert.That(b.ToString(), Is.EqualTo("0102"));
        }
    }
}
