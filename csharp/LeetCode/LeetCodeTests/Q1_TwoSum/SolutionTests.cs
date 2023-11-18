using LeetCode.Q1_TwoSum;

using NUnit.Framework;


namespace LeetCodeTests.Q1_TwoSum
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var solution = new Solution();
            var result = solution.TwoSum([2, 7, 11, 15], 9);
            
            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result, Contains.Item(0));
            Assert.That(result, Contains.Item(1));
        }

        [Test]
        public void Example2()
        {
            var solution = new Solution();
            var result = solution.TwoSum([3, 2, 4], 6);
            
            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result, Contains.Item(1));
            Assert.That(result, Contains.Item(2));
        }

        [Test]
        public void Example3()
        {
            var solution = new Solution();
            var result = solution.TwoSum([3, 3], 6);
            
            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result, Contains.Item(0));
            Assert.That(result, Contains.Item(1));
        }

        [Test]
        public void Example4()
        {
            var solution = new Solution();
            var result = solution.TwoSum([3, 4], 8);
            
            Assert.That(result.Length, Is.EqualTo(0));
        }

        [Test]
        public void Example5()
        {
            var solution = new Solution();
            var result = solution.TwoSum([1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1], 11);
            
            Assert.That(result.Length, Is.EqualTo(2));
        }
    }
}
