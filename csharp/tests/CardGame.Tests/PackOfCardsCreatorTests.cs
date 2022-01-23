using NUnit.Framework;
namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class PackOfCardsCreatorTests
    {
        private IPackOfCardsCreator _packCreator;
        [SetUp]
        public void InitializeCreator() {
            _packCreator = new PackOfCardsCreator();
        }

        [Test]
        public void CreateTest() {
            var output = _packCreator.Create();
            Assert.IsInstanceOf(typeof(IPackOfCards), output);
        }
    }
}
