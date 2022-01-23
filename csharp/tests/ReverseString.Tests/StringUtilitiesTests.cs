using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class StringUtilitiesTests
    {
        [Test]
        [TestCase("hello","olleh")]
        [TestCase("","")]
        [TestCase(null,"")]
        [TestCase("#sdfsdd","ddsfds#")]
        public void ReverseStringTest(string input, string expectedOp)
        {
            string output = StringUtilities.Reverse(input);
            Assert.AreEqual(expectedOp, output);
        }

        [Test]
        [TestCase("hello", "olleh")]
        [TestCase("", "")]
        [TestCase(null, "")]
        [TestCase("#sdfsdd", "ddsfds#")]
        [TestCase("abcdef","fedcba")]
        public void OptimizedReverseStringTest(string input, string expectedOp) {
            string output = StringUtilities.OptimizedReverse(input);
            Assert.AreEqual(expectedOp, output);
        }
    }
}
