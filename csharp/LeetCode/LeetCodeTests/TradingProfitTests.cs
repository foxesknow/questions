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
    public class TradingProfitTests
    {
        [Test]
        public void Case0()
        {
            List<string> records = new()
            {
                "MAVEN OFFER 10 25",
                "MAVEN BUY 10 20",
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(0));
            Assert.That(l, Is.EqualTo(200));
            Assert.That(s, Is.EqualTo(0));
        }

        [Test]
        public void Case1()
        {
            List<string> records = new()
            {
                "MAVEN SELL 10 25 BID 10 20"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(0));
            Assert.That(l, Is.EqualTo(0));
            Assert.That(s, Is.EqualTo(250));
        }

        [Test]
        public void Case2()
        {
            List<string> records = new()
            {
                "MAVEN BUY 10 20 SELL 5 25 OFFER 10 18 BID 5 28"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(35));
            Assert.That(l, Is.EqualTo(0));
            Assert.That(s, Is.EqualTo(0));
        }

        [Test]
        public void Case3()
        {
            List<string> records = new()
            {
                "MAVEN BUY 12 20 SELL 6 25 OFFER 10 18 BID 5 28"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(35));
            Assert.That(l, Is.EqualTo(40));
            Assert.That(s, Is.EqualTo(25));
        }

        [Test]
        public void Case4()
        {
            List<string> records = new()
            {
                "MAVEN BUY 12 20 SELL 6 25 SELL 10 18 BUY 5 28"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(0));
            Assert.That(l, Is.EqualTo(40));
            Assert.That(s, Is.EqualTo(25));
        }

        [Test]
        public void Case5()
        {
            List<string> records = new()
            {
                "MAVEN BUY 3 20 BID 5 20 BUY 2 20",
                "MAVEN SELL 9 18"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(10));
            Assert.That(l, Is.EqualTo(20));
            Assert.That(s, Is.EqualTo(0));
        }

        [Test]
        public void Case6()
        {
            List<string> records = new()
            {
                "TINYCORP SELL 27 1",
                "MAVEN BID 5 20 OFFER 5 25",
                "MEDPHARMA BID 3 120 OFFER 7 150",
                "NEWFIRM BID 10 140 BID 7 150 OFFER 14 180",
                "TINYCORP BID 25 3 OFFER 25 6",
                "FASTAIR BID 21 65 OFFER 35 85",
                "FLYCARS BID 50 80 OFFER 100 90",
                "BIGBANK BID 200 13 OFFER 100 19",
                "REDCHIP BID 55 25 OFFER 80 30",
                "FASTAIR BUY 50 100",
                "CHEMCO SELL 100 67",
                "MAVEN BUY 5 30",
                "REDCHIP SELL 5 30",
                "NEWFIRM BUY 2 200",
                "MEDPHARMA BUY 2 150",
                "BIGBANK SELL 50 11",
                "FLYCARS BUY 200 100",
                "CHEMCO BID 1000 77 OFFER 500 88",
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(2740));
            Assert.That(l, Is.EqualTo(11500));
            Assert.That(s, Is.EqualTo(152));
        }

        [Test]
        public void Case8()
        {
            List<string> records = new()
            {
                "A OFFER 1 20",
                "A BID 1 30"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(0));
            Assert.That(l, Is.EqualTo(0));
            Assert.That(s, Is.EqualTo(0));
        }

        [Test]
        public void Case17()
        {
            List<string> records = new()
            {
                "B BID 1 23 BUY 1 19",
                "B OFFER 1 16"
            };

            var (profit, l, s) = TradingProfit.Trade(records);
            Assert.That(profit, Is.EqualTo(0));
            Assert.That(l, Is.EqualTo(19));
            Assert.That(s, Is.EqualTo(0));
        }
    }
}
