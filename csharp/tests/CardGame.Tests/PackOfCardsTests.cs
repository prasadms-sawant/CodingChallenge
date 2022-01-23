using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class PackOfCardsTests
    {
        private PackOfCards _pack;

        [SetUp]
        public void InitializePackOfCards() {
            _pack = new PackOfCards();
        }

        [Test]
        [TestCase(51)]
        public void TakeCardFromTopOfPackTest(int expectedCardsCount) {
            _pack.TakeCardFromTopOfPack();
            int output = _pack.Count;
            Assert.AreEqual(expectedCardsCount, output);
        }

        [Test]
        [TestCase(52)]
        public void ShuffleTest(int expectedCardsCount)
        {
            _pack.Shuffle();
            int output = _pack.Count;
            Assert.AreEqual(expectedCardsCount, output);
        }
    }
}
