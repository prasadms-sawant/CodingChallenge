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
        public void ReverseStringTest(string input, string expectedOp)
        {
            string output = StringUtilities.Reverse(input);
            Assert.AreEqual(expectedOp, output);
        }
    }
}
