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
        public void TakeCardFromTopOfPackTest() {
            for (int i = _pack.Count; i > 0; i--)
            {
                ICard card = _pack.TakeCardFromTopOfPack();
                Assert.AreEqual(i - 1, _pack.Count);
            }
            Assert.AreEqual(0, _pack.Count);
        }

        [Test]
        [TestCase(52)]
        public void ShuffleTest(int expectedCardsCount){
            _pack.Shuffle();
            int output = _pack.Count;
            Assert.AreEqual(expectedCardsCount, output);
        }
    }
}
